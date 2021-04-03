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
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using KOTableEditor.Interface;
using Microsoft.VisualBasic.ApplicationServices;
using DevExpress.XtraEditors;

namespace KOTableEditor.Auxillary
{

    class SingleInstanceApp : WindowsFormsApplicationBase
    {
        public SingleInstanceApp()
        {
            IsSingleInstance = true;
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs e)
        {
            base.OnStartupNextInstance(e);

            // Handle command line arguments of second instance
            if (MainForm == null)
            {
                return;
            }else
            {
                if (e.BringToForeground)
                {
                    ((mainFrm)MainForm).ProcessCommandlineArguments(e.CommandLine.ToArray());
                    MainForm.BringToFront();
                }
                else
                {
                    ((mainFrm)MainForm).ProcessCommandlineArguments(e.CommandLine.ToArray());
                }
            }
        }

        protected override void OnCreateMainForm()
        {
            base.OnCreateMainForm();
            RegistrySettings.Load();
            UserLookAndFeel.Default.SkinName = RegistrySettings.SkinName;
            SupportedLanguage current = SupportedLanguage.Türkçe; // default
            if (Enum.TryParse(RegistrySettings.Language, out current))
            {

            }
            LanguageManager.ChangeLanguage(current, null);
          /*  MainForm = new mainFrm();
            return;*/
            if (RegistrySettings.KeepLoggedIn)
            {
                var loginResult = KODevLoginManager.Login(StaticReference.Decrypt(RegistrySettings.Username, RegistrySettings._key, RegistrySettings._keySize), StaticReference.Decrypt(RegistrySettings.Password, RegistrySettings._key, RegistrySettings._keySize));

                switch (loginResult.Result.Substring(0,29))
                {
                   
                    //LOGINSTATUS_KEY_3 (TOKEN METHODU İÇİN)  Token mevcut, fakat süresi dolmuş. Yeniden ID şifre ile token almak gerekli.
                    case "LS003F5esRwzAPt33psnJdEt7eJkT":
                    //LOGINSTATUS_KEY_4 (TOKEN METHODU İÇİN) Token mevcut, geçerli fakat kullanıcının gönderdiği değer yanlış!
                    case "LS004GUcuNEM67D2P5PbUXqTLPHTt":
                    //LOGINSTATUS_KEY_5 (PAROLA METHODU İÇİN) Hesap şuan kullanımda (token başkasında.)
                    case "LS004rPrCHnnYLHUREjrh2fUggjQJ":
                    //LOGINSTATUS_KEY_1 (PAROLA METHODU İÇİN) ID veya Parola yanlış.
                    case "LS001Gs84DmanHUWmrWwLgDKysrFk":
                        StaticReference.ShowError((XtraForm)MainForm, loginResult.Message);
                        // failure, redirect to login page
                        using (frmLogin login = new frmLogin())
                        {
                            login.ShowDialog();
                        }
                        break;
                    //LOGINSTATUS_KEY_2 (TOKEN METHODU İÇİN)  Token mevcut, geçerli ve doğru. 
                    case "LS002RvkzvsDWeLdGDGCKHDKx8SuP":
                    //LOGINSTATUS_KEY_T (PAROLA METHODU İÇİN) ID ve Parola doğru, token değeri JSON içerisinde token kısmına eklenir.
                    case "LS00TF5esRwzAPt33psnJdEt7eJkT":
                        RegistrySettings.LoggedIn = true;
                        break;
                    //LOGINSTATUS_KEY_E
                    case "LS00Ef9TV4vPbmGh9tytn7HdTMZp2":
                        StaticReference.ShowError((XtraForm)MainForm, loginResult.Message);
                        break;
                }
            }
            else
            {
                using (frmLogin login = new frmLogin())
                {
                    login.ShowDialog();
                }
            }
            if (RegistrySettings.LoggedIn)
            {
                MainForm = new mainFrm();
               
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
    static class Program 
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) 
                SetProcessDPIAware();

            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            WindowsFormsSettings.AllowDpiScale = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
          //  Application.Run(new frmBulkConvert());//   Application.Run(new frmEncryptionSelect("y"));
            new SingleInstanceApp().Run(Environment.GetCommandLineArgs());
           // Application.Run(new mainFrm());
        }

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
