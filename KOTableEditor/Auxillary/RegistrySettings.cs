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
using System;
using System.Security.AccessControl;

namespace KOTableEditor.Auxillary
{
    static class RegistrySettings
    {
        public static string _key = "VVJsSWFubW9UeHNNbTB0TCttanpkQT09LFUzZEVUNjkzYW5XQTFKSCtxRGdIMHlTN1BEcUFsMlFRWUVjcHljdll4ODg9";
        public static int _keySize = 256;
        public static bool LoggedIn = false;
        public static string Username = "null";
        public static string Password = "null";
        public static bool KeepLoggedIn = false;
        public static bool RememberMe = false;
        public static string SkinName = "DevExpress Style";
        // Available options : en-EN, tr-TR
        public static string Language = "en-EN";

        public static bool Load()
        {
            RegistryKey _lmSoftware = null;
            RegistryKey _koDevelopers = null;
            RegistryKey _pentagram = null;
            RegistryKey _tbl = null;
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
                _pentagram = _koDevelopers.CreateSubKey("PENTAGRAM", RegistryKeyPermissionCheck.ReadWriteSubTree, rs);
                _tbl = _pentagram.CreateSubKey("TBLEditor", RegistryKeyPermissionCheck.ReadWriteSubTree, rs);

                Username = Convert.ToString(_tbl.GetValue("Username", "__emptyuser"));
                Password = Convert.ToString(_tbl.GetValue("Password", "__emptypassword"));
                KeepLoggedIn = Convert.ToBoolean(_tbl.GetValue("KeepLoggedIn", false));
                RememberMe = Convert.ToBoolean(_tbl.GetValue("RememberMe", false));
                SkinName = Convert.ToString(_tbl.GetValue("SkinName", "DevExpress Style"));
                Language = Convert.ToString(_tbl.GetValue("Language", "en-EN"));
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool Save()
        {
            RegistryKey _lmSoftware = null;
            RegistryKey _koDevelopers = null;
            RegistryKey _pentagram = null;
            RegistryKey _tbl = null;
            try
            {
                string user = Environment.UserDomainName + "\\" + Environment.UserName;
                RegistrySecurity rs = new RegistrySecurity();

                rs.AddAccessRule(new RegistryAccessRule(user,
                            RegistryRights.WriteKey | RegistryRights.ReadKey | RegistryRights.Delete,
                            InheritanceFlags.None,
                            PropagationFlags.None,
                            AccessControlType.Allow));
                _lmSoftware = Registry.CurrentUser.OpenSubKey("SOFTWARE",true);
           
                _koDevelopers = _lmSoftware.CreateSubKey("KODevelopers",RegistryKeyPermissionCheck.ReadWriteSubTree, rs);
                _pentagram = _koDevelopers.CreateSubKey("PENTAGRAM", RegistryKeyPermissionCheck.ReadWriteSubTree, rs);
                _tbl = _pentagram.CreateSubKey("TBLEditor", RegistryKeyPermissionCheck.ReadWriteSubTree, rs);
                

                _tbl.SetValue("Username", Username);
                _tbl.SetValue("Password", Password);
                _tbl.SetValue("KeepLoggedIn", KeepLoggedIn);
                _tbl.SetValue("RememberMe", RememberMe);
                _tbl.SetValue("SkinName", SkinName);
                _tbl.SetValue("Language", Language);
                return true;
            }
            catch (Exception e)
            {
                StaticReference.ShowError(null, e.Message);
                return false;
            }


        }
    }
}
