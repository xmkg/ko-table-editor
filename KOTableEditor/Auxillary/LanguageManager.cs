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
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
/* 
 * Author : Mustafa K. GILOR
 * 11.10.2017
  */
namespace KOTableEditor.Auxillary
{
    public enum SupportedLanguage
    {
        English,
        Türkçe,
        Español
    }
    public static class LanguageManager
    {
        static ResourceManager _resManager;
        static CultureInfo _culture;
        /* Default language is Turkish.*/
        public static SupportedLanguage Language = SupportedLanguage.Türkçe;
        public static String Get(string label)
        {
            return _resManager.GetString(label, _culture);
        }
        public static void ChangeLanguage(SupportedLanguage newLanguage, Form requestingForm)
        {
            Language = newLanguage;
            if(_resManager == null)
            {
                _resManager= new ResourceManager("KOTableEditor.Resources.Lang", typeof(Interface.mainFrm).Assembly);
            }
            switch (newLanguage)
            {
                case SupportedLanguage.English:
                    _culture = CultureInfo.CreateSpecificCulture("en");
                    break;
                case SupportedLanguage.Türkçe:
                    _culture = CultureInfo.CreateSpecificCulture("tr");
                    break;
                case SupportedLanguage.Español:
                    _culture = CultureInfo.CreateSpecificCulture("es");
                    break;
            }
            if (requestingForm == null)
                return;
            LoadInterfaceLanguage(requestingForm);
        }

        public static void LoadInterfaceLanguage(Form targetForm)
        {
            /* Force handle creation */

            IntPtr handle = targetForm.Handle;
            if (targetForm is Interface.mainFrm)
            {
                /* mainFrm specific localization here.*/
                Interface.mainFrm m = targetForm as Interface.mainFrm;
                m.Invoke(new Action(() =>
                {
                    m.Text = Get("mainFrm_Title");
                    if(Language == SupportedLanguage.English)
                    {
                        m.beLanguage.Caption = LanguageManager.Get("mainFrm_LanguageLabel");

                    }
                    else
                    {
                        m.beLanguage.Caption = LanguageManager.Get("mainFrm_LanguageLabel") + "(Language)";
                    }
                    
                    m.ngFile.Caption = Get("mainFrm_Menu_File");
                    m.ngFile_Open.Caption = Get("mainFrm_Menu_File_Open");
                    m.ngFile_Save.Caption = Get("mainFrm_Menu_File_Save");
                    m.ngFile_SaveAs.Caption = Get("mainFrm_Menu_File_SaveAs");
                    m.ngFile_BulkConvert.Caption = Get("mainFrm_Menu_File_BulkConvert");
                    m.ngFile_SQLExport.Caption = Get("mainFrm_Menu_File_SqlExport");
                    m.ngFile_Logout.Caption = Get("mainFrm_Menu_File_Logout");
                    m.ngEdit.Caption = Get("mainFrm_Menu_Edit");
                    m.ngEdit_NewRow.Caption = Get("mainFrm_Menu_Edit_NewRow");
                    m.ngEdit_NewColumn.Caption = Get("mainFrm_Menu_Edit_ColumnEditor");
                    m.ngEdit_RowCopy.Caption = Get("mainFrm_Menu_Edit_RowCopy");
                    m.ngEdit_RowPaste.Caption = Get("mainFrm_Menu_Edit_RowPaste");
                    m.ngEdit_RowDelete.Caption = Get("mainFrm_Menu_Edit_RowDelete");
                    m.ngSearch.Caption = Get("mainFrm_Menu_Search");
                    m.ngSearch_Find.Caption = Get("mainFrm_Menu_Search_Find");
                    m.ngSearch_FindAndReplace.Caption = Get("mainFrm_Menu_Search_FindAndReplace");
                    m.ngFileInformation.Caption = Get("mainFrm_Menu_FInfo");
                    m.ngFileInfo_L_Filename.Text = Get("mainFrm_Menu_FInfo_Filename");
                    m.ngFileInfo_L_Size.Text = Get("mainFrm_Menu_FInfo_Size");
                    m.ngFileInfo_L_Path.Text = Get("mainFrm_Menu_FInfo_Path");
                    m.ngFileInfo_L_Encryption.Text = Get("mainFrm_Menu_FInfo_Encryption");
                    m.ngFileInfo_L_ColumnCount.Text = Get("mainFrm_Menu_FInfo_ColumnCount");
                    m.ngFileInfo_L_RowCount.Text = Get("mainFrm_Menu_FInfo_RowCount");
                    m.ngFileInfo_L_CreatedAt.Text = Get("mainFrm_Menu_FInfo_Created");
                    m.ngFileInfo_L_LastAccess.Text = Get("mainFrm_Menu_FInfo_LastAccess");
                    m.ngFileInfo_L_LastModified.Text = Get("mainFrm_Menu_FInfo_LastModify");
                    m.ngAbout.Caption = Get("mainFrm_Menu_About");
                    m.ngAbout_Product.Text = Get("mainFrm_Menu_About_Program");
                    m.ngAbout_Version.Text = Get("mainFrm_Menu_About_Version");
                    m.ngAbout_Author.Text = Get("mainFrm_Menu_About_Author");
                    //m.ngAbout_Copyright.Text = Get("mainFrm_Menu_About_Copyright");
                    m.ngAbout_Description.Text = Get("mainFrm_Menu_About_Share");
                }
                ));
            }
            else if (targetForm is Interface.frmColumnEditor)
            {
                Interface.frmColumnEditor m = targetForm as Interface.frmColumnEditor;
                m.Invoke(new Action(() =>
                {
                    m.Text = Get("frmColumnEditor_Title");
                    m.btnRemoveChecked.Text = Get("frmColumnEditor_Button_RemoveChecked");
                    m.btnAddColumn.Text = Get("frmColumnEditor_Button_Add");
                    m.btnUpdateColumn.Text = Get("frmColumnEditor_Button_Update");
                    m.gcEditColumn.Text = Get("frmColumnEditor_GroupBox_EditColumn");
                    m.gcNewColumn.Text = Get("frmColumnEditor_GroupBox_NewColumn");
                    m.lblChangeDataType.Text = Get("frmColumnEditor_Label_ChangeDataType");
                    m.lblDataType.Text = Get("frmColumnEditor_Label_DataType");
                    m.lblDefaultValue.Text = Get("frmColumnEditor_Label_DefaultValue");
                }
                ));
            }
            else if (targetForm is Interface.frmExportAsSQL)
            {
                Interface.frmExportAsSQL m = targetForm as Interface.frmExportAsSQL;
                m.Invoke(new Action(() =>
                {
                    m.Text = Get("frmExportAsSQL_Title");
                    m.lblColumns.Text = Get("frmExportAsSQL_Label_Columns");
                    m.lblColumnNames.Text = Get("frmExportAsSQL_Label_ColumnNames");
                    m.gcTableOptions.Text = Get("frmExportAsSQL_GroupBox_TableOptions");
                    m.ceCreateTable.Text = Get("frmExportAsSQL_CheckBox_IncludeCreate");
                    m.ceDropTable.Text = Get("frmExportAsSQL_CheckBox_DropPrevious");
                    m.ceTruncateTable.Text = Get("frmExportAsSQL_CheckBox_Truncate");
                    m.btnCheckAll.Text = Get("frmExportAsSQL_Button_CheckAllColumns");
                    m.btnUncheckAll.Text = Get("frmExportAsSQL_Button_UncheckAllColumns");
                    m.btnExport.Text = Get("frmExportAsSQL_Button_Export");
                    m.meDescription.Text = Get("frmExportAsSQL_TextBox_Description");
                }
                ));
            }
            else if (targetForm is Interface.frmFindAndReplace)
            {
                Interface.frmFindAndReplace m = targetForm as Interface.frmFindAndReplace;
                m.Invoke(new Action(() =>
                {
                    m.Text = Get("frmFindAndReplace_Title");
                    m.lblFindWhat.Text = Get("frmFindAndReplace_Label_FindWhat");
                    m.lblReplaceWith.Text = Get("frmFindAndReplace_Label_ReplaceWith");
                    m.cbCaseSensitive.Text = Get("frmFindAndReplace_CheckBox_CaseSensitive");
                    m.cbMatchWhole.Text = Get("frmFindAndReplace_CheckBox_MatchWhole");
                    m.btnCancel.Text = Get("frmFindAndReplace_Button_Close");
                    m.btnRepNext.Text = Get("frmFindAndReplace_Button_ReplaceNext");
                    m.btnRepAll.Text = Get("frmFindAndReplace_Button_ReplaceAll");
                }
                ));
            }
            else if (targetForm is Interface.frmSaveAs)
            {
                Interface.frmSaveAs m = targetForm as Interface.frmSaveAs;
                m.Invoke(new Action(() =>
                {
                    m.Text = Get("frmSaveAs_Title");
                    m.lblMethod.Text = Get("frmSaveAs_Label_Method");
                    m.lblMethodDesc.Text = Get("frmSaveAs_Label_Description");
                    m.btnSave.Text = Get("frmSaveAs_Button_SaveAs");
                }
                ));
            }
             
                
        }
    }
}
