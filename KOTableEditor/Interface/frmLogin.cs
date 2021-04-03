/**
 * ______________________________________________________
 * This file is part of ko-table-editor project.
 * 
 * @author       Mustafa Kemal Gılor <mustafagilor@gmail.com> (2017)
 * .
 * SPDX-License-Identifier:	MIT
 * ______________________________________________________
 */

using System;
using KOTableEditor.Auxillary;
using System.Security.Cryptography;
using System.Text;

namespace KOTableEditor.Interface
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            try
            {
                teUsername.Text = StaticReference.Decrypt(RegistrySettings.Username, RegistrySettings._key, RegistrySettings._keySize);
                tePassword.Text = StaticReference.Decrypt(RegistrySettings.Password, RegistrySettings._key, RegistrySettings._keySize);
            } catch {/* ignored */}
            ceKeepLoggedIn.Checked = RegistrySettings.KeepLoggedIn;
            ceRememberMe.Checked = RegistrySettings.RememberMe;
            // linkNewMember.url
        }

        private void linkNewMember_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            linkNewMember.LinkVisited = true;
            System.Diagnostics.Process.Start(e.Link);
        }

        private void linkForgottenPass_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            linkForgottenPass.LinkVisited = true;
            System.Diagnostics.Process.Start(e.Link);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginResult = KODevLoginManager.Login(teUsername.Text,tePassword.Text);

            switch (loginResult.Result.Substring(0, 29))
            {

                //LOGINSTATUS_KEY_3 (TOKEN METHODU İÇİN)  Token mevcut, fakat süresi dolmuş. Yeniden ID şifre ile token almak gerekli.
                case "LS003F5esRwzAPt33psnJdEt7eJkT":
                //LOGINSTATUS_KEY_4 (TOKEN METHODU İÇİN) Token mevcut, geçerli fakat kullanıcının gönderdiği değer yanlış!
                case "LS004GUcuNEM67D2P5PbUXqTLPHTt":
                //LOGINSTATUS_KEY_5 (PAROLA METHODU İÇİN) Hesap şuan kullanımda (token başkasında.)
                case "LS004rPrCHnnYLHUREjrh2fUggjQJ":
                //LOGINSTATUS_KEY_1 (PAROLA METHODU İÇİN) ID veya Parola yanlış.
                case "LS001Gs84DmanHUWmrWwLgDKysrFk":
                    StaticReference.ShowError(this, loginResult.Message);
                    break;
                //LOGINSTATUS_KEY_2 (TOKEN METHODU İÇİN)  Token mevcut, geçerli ve doğru. 
                case "LS002RvkzvsDWeLdGDGCKHDKx8SuP":
                //LOGINSTATUS_KEY_T (PAROLA METHODU İÇİN) ID ve Parola doğru, token değeri JSON içerisinde token kısmına eklenir.
                case "LS00TF5esRwzAPt33psnJdEt7eJkT":
                    {
                        RegistrySettings.LoggedIn = true;
                        RegistrySettings.KeepLoggedIn = ceKeepLoggedIn.Checked;
                        RegistrySettings.RememberMe = ceRememberMe.Checked;

                        RegistrySettings.Username = StaticReference.Encrypt(teUsername.Text, RegistrySettings._key, RegistrySettings._keySize);
                        if (RegistrySettings.RememberMe)
                            RegistrySettings.Password = StaticReference.Encrypt(tePassword.Text, RegistrySettings._key, RegistrySettings._keySize);
                        else
                            RegistrySettings.Password = "_empty";
                    
                        RegistrySettings.Save();
                        Close();
                    }
                    break;
                //LOGINSTATUS_KEY_E
                case "LS00Ef9TV4vPbmGh9tytn7HdTMZp2":
                    StaticReference.ShowError(this, loginResult.Message);
                    break;
            }
           
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            SHA256 mySHA256 = SHA256Managed.Create();
            var key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes("Q3QgesV4wMug5ZtS7DenWAw3"));
            StaticReference.ShowWarning(this, BitConverter.ToString(key));
            var iv = new byte[16] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
            var result = KODevLoginManager.EncryptString("wowowowowharam", key, iv);
            StaticReference.ShowError(this, result);
            //RegistrySettings.Load();
           // RegistrySettings.Save();
        }
    }
}