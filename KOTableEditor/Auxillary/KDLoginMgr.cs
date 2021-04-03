/**
 * ______________________________________________________
 * This file is part of ko-table-editor project.
 * 
 * @author       Mustafa Kemal Gılor <mustafagilor@gmail.com> (2017)
 * .
 * SPDX-License-Identifier:	MIT
 * ______________________________________________________
 */


using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace KOTableEditor.Auxillary
{

    public class token
    {
        [XmlAttribute]
        public string id;
        [XmlAttribute]
        public string value;
    }

    [Serializable]
    public static class KODevLoginManager
    {
        private static string script_url = "https://www.kodevelopers.com/login.apiv2.php";
        private static string application_name = "PENTAGRAMTBL";
        private static string application_version = "v13";
        
        public class KODevelopersLoginResponse
        {

            public KODevelopersLoginResponse()
            {
                Result = "";
                EncryptedToken = "";
                PlainToken = "";
                Message = "";
                Announcement = "";
                UpdateAvailable = false;
                UpdateURL = "";
                ErrorURL = "";
            }
            [XmlIgnore]
            public string Result { get; set; }
            [XmlIgnore]
            public string EncryptedToken { get; set; }
            [XmlIgnore]
            public string PlainToken { get; set; }
            [XmlIgnore]
            public string Message { get; set; }
            [XmlIgnore]
            public string Announcement { get; set; }
            [XmlIgnore]
            public bool UpdateAvailable { get; set; }
            [XmlIgnore]
            public string UpdateURL { get; set; }
            [XmlIgnore]
            public string ErrorURL { get; set; }
            public bool isOK()
            {
                return Result.Substring(0, 29) == "LS00TF5esRwzAPt33psnJdEt7eJkT" || Result.Substring(0, 29) == "LS002RvkzvsDWeLdGDGCKHDKx8SuP";

            }
        }
        private enum KODevLoginStatus
        {
            /* Giriş yapılmamış */
            KDLS_NOT_LOGGED_IN,
            /* Giriş yapılmış */
            KDLS_LOGGED_IN,
            /* Giriş yapılmış, token yenileme sürecinde */
            KDLS_TOKEN_RENEW,
            /* Zaman aşımına uğramış */
            KDLS_TIMEOUT,
            /* Başkası kullanıyor */
            KDLS_ALREADY_LOGGED_IN
        };

        public static bool ValidateToken(string username)
        {
            if (!TokenList.ContainsKey(username))
                return false;
            KODevelopersLoginResponse loginResponse = new KODevelopersLoginResponse();

            using (WebClient client = new WebClient())
            {
                client.Headers["Content-Type"] = "application/x-www-form-urlencoded";
                client.Headers["user-agent"] = "Microsoft URL Control";
                System.Collections.Specialized.NameValueCollection postData =
                new System.Collections.Specialized.NameValueCollection()
                {
                        { "uid", EncryptString(username,key,iv) },
                        { "pwd", EncryptString(TokenList[username],key,iv) },
                        { "app", EncryptString(application_name,key,iv) },
                        { "ver", EncryptString(application_version,key,iv) },
                        { "meth",EncryptString("TOKEN",key,iv) }
                };
                string response = Encoding.UTF8.GetString(client.UploadValues(script_url, postData));
                Dictionary<string, object> jsonFields = JObject.Parse(response.TrimEnd().TrimStart()).ToObject<Dictionary<string, object>>();
                foreach (var v in jsonFields)
                {
                    switch (v.Key)
                    {
                        case "result":
                            loginResponse.Result = DecryptString(v.Value as string, key, iv);
                            break;
                        case "message":
                            loginResponse.Message = v.Value as string;
                            break;
                        case "token":
                            loginResponse.EncryptedToken = v.Value as string;
                            loginResponse.PlainToken = DecryptString(v.Value as string, key, iv);
                            break;

                    }
                }
                if (loginResponse.Result.Substring(0, 29) == "LS002RvkzvsDWeLdGDGCKHDKx8SuP")
                    return true;
            }
            return false;
        }

        public static KODevelopersLoginResponse Login(string username, string password)
        {
            if (!init)
            {
                SHA256 mySHA256 = SHA256Managed.Create();
                key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes("Q3QgesV4wMug5ZtS7DenWAw3"));
                
                iv = new byte[16] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
                init = true;
                LoadTokenList(); // Eğer daha önceden kayıtlı token varsa yükle
            }
            KODevelopersLoginResponse loginResponse = new KODevelopersLoginResponse();
            using (WebClient client = new WebClient())
            {
                retokenize_me:;
                client.Headers["Content-Type"] = "application/x-www-form-urlencoded";
                client.Headers["user-agent"] = "Microsoft URL Control";
                
                //client.Headers["Connection"] = "Keep-alive";
                System.Collections.Specialized.NameValueCollection postData;
                if (TokenList.ContainsKey(username))
                {
                    postData = new System.Collections.Specialized.NameValueCollection()
                    {
                              { "uid", EncryptString(username,key,iv) },
                              { "pwd", EncryptString(TokenList[username],key,iv) },
                              { "app", EncryptString(application_name,key,iv) },
                              { "ver", EncryptString(application_version,key,iv) },
                              { "meth",EncryptString("TOKEN",key,iv) }
                    };
                }
                else
                {
                    postData = new System.Collections.Specialized.NameValueCollection()
                    {
                              { "uid", EncryptString(username,key,iv) },
                              { "pwd", EncryptString(password,key,iv) },
                              { "app", EncryptString(application_name,key,iv) },
                              { "ver", EncryptString(application_version,key,iv) },
                              { "meth",EncryptString("PASSWORD",key,iv) }
                    };
                }
                
                string response = Encoding.UTF8.GetString(client.UploadValues(script_url, postData));
                Dictionary<string, object> jsonFields = JObject.Parse(response.TrimEnd().TrimStart()).ToObject<Dictionary<string, object>>();
                foreach (var v in jsonFields)
                {
                    switch (v.Key)
                    {

                        case "result":
                            loginResponse.Result = DecryptString(v.Value as string, key, iv);
                            break;
                        case "message":
                            loginResponse.Message = v.Value as string;
                            break;
                        case "token":
                            loginResponse.EncryptedToken = v.Value as string;
                            loginResponse.PlainToken = DecryptString(v.Value as string, key, iv);
                            break;

                    }
                }

                switch (loginResponse.Result.Substring(0, 29))
                {
                    case "LS001Gs84DmanHUWmrWwLgDKysrFk":
                        break;
                    case "LS002RvkzvsDWeLdGDGCKHDKx8SuP":
                        break;
                    case "LS003F5esRwzAPt33psnJdEt7eJkT":
                        TokenList.Remove(username); // Expired token removal
                        SaveTokenList();
                        goto retokenize_me;
                    case "LS004GUcuNEM67D2P5PbUXqTLPHTt":
                        TokenList.Remove(username); // Invalid token removal
                        SaveTokenList();
                        break;
                    case "LS004rPrCHnnYLHUREjrh2fUggjQJ":
                        break;
                    case "LS00TF5esRwzAPt33psnJdEt7eJkT":
                        TokenList.Add(username, loginResponse.EncryptedToken);
                        SaveTokenList();
                        break;
                    case "LS00Ef9TV4vPbmGh9tytn7HdTMZp2":
                        break;
                }

            }
            return loginResponse;
        }
        [XmlIgnore]
        static bool init = false;

        // Create sha256 hash
        [XmlIgnore]
        static KODevLoginStatus AccountLoginStatus = KODevLoginStatus.KDLS_NOT_LOGGED_IN;
        [XmlIgnore]
        static string Token;
        [XmlIgnore]
        static string PlainToken;
        static Dictionary<string, string> TokenList = new Dictionary<string, string>();
        [XmlIgnore]
        private static byte[] key;
        [XmlIgnore]
        private static byte[] iv;
        public static string EncryptString(string plainText, byte[] key, byte[] iv)
        {
            // Instantiate a new Aes object to perform string symmetric encryption
            Aes encryptor = Aes.Create();

            encryptor.Mode = CipherMode.CBC;
            //encryptor.KeySize = 256;
            //encryptor.BlockSize = 128;
            //encryptor.Padding = PaddingMode.Zeros;

            // Set key and IV
            encryptor.Key = key;
            encryptor.IV = iv;

            // Instantiate a new MemoryStream object to contain the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();

            // Instantiate a new encryptor from our Aes object
            ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();

            // Instantiate a new CryptoStream object to process the data and write it to the 
            // memory stream
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);

            // Convert the plainText string into a byte array
            byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);

            // Encrypt the input plaintext string
            cryptoStream.Write(plainBytes, 0, plainBytes.Length);

            // Complete the encryption process
            cryptoStream.FlushFinalBlock();

            // Convert the encrypted data from a MemoryStream to a byte array
            byte[] cipherBytes = memoryStream.ToArray();

            // Close both the MemoryStream and the CryptoStream
            memoryStream.Close();
            cryptoStream.Close();
          //  StaticReference.ShowInformation(null, "PURE : " + BitConverter.ToString(cipherBytes, 0, cipherBytes.Length));
            // Convert the encrypted byte array to a base64 encoded string
            string cipherText = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);

            // Return the encrypted data as a string
            return cipherText;
        }

        public static string DecryptString(string cipherText, byte[] key, byte[] iv)
        {
            // Instantiate a new Aes object to perform string symmetric encryption
            Aes encryptor = Aes.Create();

            encryptor.Mode = CipherMode.CBC;
            //encryptor.KeySize = 256;
            //encryptor.BlockSize = 128;
            //encryptor.Padding = PaddingMode.Zeros;

            // Set key and IV
            encryptor.Key = key;
            encryptor.IV = iv;

            // Instantiate a new MemoryStream object to contain the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();

            // Instantiate a new encryptor from our Aes object
            ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();

            // Instantiate a new CryptoStream object to process the data and write it to the 
            // memory stream
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);

            // Will contain decrypted plaintext
            string plainText = String.Empty;

            try
            {
                // Convert the ciphertext string into a byte array
                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                // Decrypt the input ciphertext string
                cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);

                // Complete the decryption process
                cryptoStream.FlushFinalBlock();

                // Convert the decrypted data from a MemoryStream to a byte array
                byte[] plainBytes = memoryStream.ToArray();

                // Convert the encrypted byte array to a base64 encoded string
                plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);
            }
            finally
            {
                // Close both the MemoryStream and the CryptoStream
                memoryStream.Close();
                cryptoStream.Close();
            }

            // Return the encrypted data as a string
            return plainText;
        }


 
        public static bool SaveTokenList()
        {
            RegistryKey _lmSoftware = null;
            RegistryKey _koDevelopers = null;
            RegistryKey _appSession = null;
            try
            {
                string user = Environment.UserDomainName + "\\" + Environment.UserName;
                RegistrySecurity rs = new RegistrySecurity();

                rs.AddAccessRule(new RegistryAccessRule(user,
                            RegistryRights.WriteKey | RegistryRights.ReadKey | RegistryRights.Delete,
                            InheritanceFlags.None,
                            PropagationFlags.None,
                            AccessControlType.Allow));
                _lmSoftware = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);

                _koDevelopers = _lmSoftware.CreateSubKey("KODevelopers", RegistryKeyPermissionCheck.ReadWriteSubTree, rs);
                _appSession = _koDevelopers.CreateSubKey($"Session_{application_name}{application_version}", RegistryKeyPermissionCheck.ReadWriteSubTree, rs);
                foreach(var q in TokenList)
                {
                   // _appSession.CreateSubKey(q.Key);
                    _appSession.SetValue(q.Key, q.Value);
                }
                return true;
            }
            catch (Exception e)
            {
                StaticReference.ShowError(null, e.Message);
                return false;
            }
        }

        public static bool LoadTokenList()
        {
            RegistryKey _lmSoftware = null;
            RegistryKey _koDevelopers = null;
            RegistryKey _appSession = null;
            try
            {
                string user = Environment.UserDomainName + "\\" + Environment.UserName;
                RegistrySecurity rs = new RegistrySecurity();

                rs.AddAccessRule(new RegistryAccessRule(user,
                            RegistryRights.WriteKey | RegistryRights.ReadKey | RegistryRights.Delete,
                            InheritanceFlags.None,
                            PropagationFlags.None,
                            AccessControlType.Allow));
                _lmSoftware = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
                _koDevelopers = _lmSoftware.CreateSubKey("KODevelopers", RegistryKeyPermissionCheck.ReadWriteSubTree, rs);
                _appSession = _koDevelopers.CreateSubKey($"Session_{application_name}{application_version}", RegistryKeyPermissionCheck.ReadWriteSubTree, rs);

                foreach(string svName in _appSession.GetValueNames())
                {
                    TokenList.Add(svName, _appSession.GetValue(svName) as string);
                }
               
                return true;

            }
            catch (Exception ex)
            {
                StaticReference.ShowError(null, ex.Message);
                return false;
            }
        }
    }
}
