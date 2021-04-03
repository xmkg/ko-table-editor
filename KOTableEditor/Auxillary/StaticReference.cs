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
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using KOTableEditor.Auxillary.Encryption;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Collections.Specialized;

namespace KOTableEditor.Auxillary
{

    public static class StaticReference
    {

        static StaticReference()
        {
            ReadCustomEncryptions();
        }

        public static object GetDefault(this Type type)
        {
            // If no Type was supplied, if the Type was a reference type, or if the Type was a System.Void, return null
            if (type == null || !type.IsValueType || type == typeof(void))
                return null;

            // If the supplied Type has generic parameters, its default value cannot be determined
            if (type.ContainsGenericParameters)
                throw new ArgumentException(
                    "{" + MethodBase.GetCurrentMethod() + "} Error:\n\nThe supplied value type <" + type +
                    "> contains generic parameters, so the default value cannot be retrieved");

            // If the Type is a primitive type, or if it is another publicly-visible value type (i.e. struct/enum), return a 
            //  default instance of the value type
            if (type.IsPrimitive || !type.IsNotPublic)
            {
                try
                {
                    return Activator.CreateInstance(type);
                }
                catch (Exception e)
                {
                    throw new ArgumentException(
                        "{" + MethodBase.GetCurrentMethod() + "} Error:\n\nThe Activator.CreateInstance method could not " +
                        "create a default instance of the supplied value type <" + type +
                        "> (Inner Exception message: \"" + e.Message + "\")", e);
                }
            }

            // Fail with exception
            throw new ArgumentException("{" + MethodBase.GetCurrentMethod() + "} Error:\n\nThe supplied value type <" + type +
                "> is not a publicly-visible type, so the default value cannot be retrieved");
        }
        #region Forum login
        public static string Login(string username,string password)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.Headers.Add("user-agent", "Microsoft URL Control");
                    var values = new NameValueCollection();
                    //?username=test&password=tset
                    values["username"] = username;
                    values["password"] = password;

                    var response = client.UploadValues("https://www.kodevelopers.com/must1fy.php", values);

                    return Encoding.Default.GetString(response);

                }
            }
            catch(Exception ex)
            {
                return "4";
            }
        }
        #endregion

        #region AES256
        public static string GenerateKey(int iKeySize)
        {
            RijndaelManaged aesEncryption = new RijndaelManaged();
            aesEncryption.KeySize = iKeySize;
            aesEncryption.BlockSize = 128;
            aesEncryption.Mode = CipherMode.CBC;
            aesEncryption.Padding = PaddingMode.PKCS7;
            aesEncryption.GenerateIV();
            string ivStr = Convert.ToBase64String(aesEncryption.IV);
            aesEncryption.GenerateKey();
            string keyStr = Convert.ToBase64String(aesEncryption.Key);
            string completeKey = ivStr + "," + keyStr;

            return Convert.ToBase64String(ASCIIEncoding.UTF8.GetBytes(completeKey));
        }
        /// <summary>
        /// Encrypt
        /// </summary>
        public static string Encrypt(string iPlainStr, string iCompleteEncodedKey, int iKeySize)
        {
            if (iPlainStr == null)
                return String.Empty;
            RijndaelManaged aesEncryption = new RijndaelManaged();
            aesEncryption.KeySize = iKeySize;
            aesEncryption.BlockSize = 128;
            aesEncryption.Mode = CipherMode.CBC;
            aesEncryption.Padding = PaddingMode.PKCS7;
            aesEncryption.IV = Convert.FromBase64String(ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(iCompleteEncodedKey)).Split(',')[0]);
            aesEncryption.Key = Convert.FromBase64String(ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(iCompleteEncodedKey)).Split(',')[1]);
            byte[] plainText = ASCIIEncoding.UTF8.GetBytes(iPlainStr);
            ICryptoTransform crypto = aesEncryption.CreateEncryptor();
            byte[] cipherText = crypto.TransformFinalBlock(plainText, 0, plainText.Length);
            return Convert.ToBase64String(cipherText);
        }

        /// <summary>
        /// Decrypt
        /// </summary>
        public static string Decrypt(string iEncryptedText, string iCompleteEncodedKey, int iKeySize)
        {
            if (iEncryptedText == null)
                return String.Empty;
            RijndaelManaged aesEncryption = new RijndaelManaged();
            aesEncryption.KeySize = iKeySize;
            aesEncryption.BlockSize = 128;
            aesEncryption.Mode = CipherMode.CBC;
            aesEncryption.Padding = PaddingMode.PKCS7;
            aesEncryption.IV = Convert.FromBase64String(ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(iCompleteEncodedKey)).Split(',')[0]);
            aesEncryption.Key = Convert.FromBase64String(ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(iCompleteEncodedKey)).Split(',')[1]);
            ICryptoTransform decrypto = aesEncryption.CreateDecryptor();
            byte[] encryptedBytes = Convert.FromBase64CharArray(iEncryptedText.ToCharArray(), 0, iEncryptedText.Length);
            return ASCIIEncoding.UTF8.GetString(decrypto.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length));
        }
        #endregion



        #region Table operation
        private static readonly object TableLock = new object();
        private static readonly Dictionary<string, KOTableFile> Tables = new Dictionary<string, KOTableFile>();

        public static void AddNewTable(KOTableFile table)
        {
            lock (TableLock)
            {
                if (Tables.ContainsKey(table.FileInformation.FullName))
                    throw new Exception("The specified table is already open.");
                Tables[table.FullName] = table;
            }
        }

        public static List<string> GetAllOpenTableNames()
        {
            lock (TableLock)
            {
                string []list = new string[Tables.Keys.Count];
                Tables.Keys.CopyTo(list, 0);
                return new List<string>(list);
            }
        }

        public static KOTableFile GetTableByFullName(string tableName)
        {
            lock (TableLock)
            {
                if (Tables.ContainsKey(tableName))
                    return Tables[tableName];}
            return null;
        }

        public static void RemoveTableByFullName(string tableName)
        {
            lock (TableLock)
            {
                KOTableFile tbl = GetTableByFullName(tableName);
                if (tbl != null)
                {
                    Tables.Remove(tbl.FullName);
                }
                else
                {
                    throw new Exception("The table with given name does not exist.");
                }
            }
        }
        #endregion

        public static readonly List<KOEncryptionBase> EncryptionMethods = new List<KOEncryptionBase>
        {
            new KOEncryptionStandart(),new KOEncryptionChaosExpansion(),
            new KOEncryptionNoEncryption(),new KOEncryptionForgottenFrontiers()
        };

        private static void ReadCustomEncryptions()
        {
           // ShowInformation(null, AppDomain.CurrentDomain.BaseDirectory);
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Encryption")) 
                return;

            foreach (var file in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\Encryption"))
            {
                var fi = new FileInfo(file);
                if (!fi.Exists || fi.Extension != ".xml" || fi.Name == "Sample.xml") 
                    continue;

                var doc = XDocument.Load(fi.FullName);
                string name = "no name", desc = "no desc";
                ushort vkey = 0x0816, ckey1 = 0x6081, ckey2 = 0x1608;
                if (doc.Root != null)
                    foreach (var v in doc.Root.Elements())
                    {
                      
                        if (v.Name == "Name")
                            name = v.Value;

                        else if (v.Name == "Desc")
                            desc = v.Value;
                        else if (v.Name == "VolatileKey")
                            vkey = Convert.ToUInt16(v.Value, 16);
                        else if (v.Name == "CipherKey1")
                            ckey1 = Convert.ToUInt16(v.Value, 16);
                        else if (v.Name == "CipherKey2")
                            ckey2= Convert.ToUInt16(v.Value, 16);

                    }
                
                EncryptionMethods.Add(new KOEncryptionStandartCustom(name, desc, vkey, ckey1, ckey2));
            }
        }

        #region Messagebox

        public static void ShowError(XtraForm sender, string message)
        {
            XtraMessageBox.Show(sender, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInformation(XtraForm sender, string message)
        {

            XtraMessageBox.Show(sender, message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowWarning(XtraForm sender, string message)
        {
            XtraMessageBox.Show(sender, message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowQuestion(XtraForm sender, string question)
        {
            return XtraMessageBox.Show(sender, question, "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }


        #endregion

    }
}
