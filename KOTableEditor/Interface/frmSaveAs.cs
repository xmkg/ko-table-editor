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
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KOTableEditor.Auxillary;

namespace KOTableEditor.Interface
{
    public partial class frmSaveAs : XtraForm
    {
        private readonly string _tableName;
        public frmSaveAs(string tblName)
        {
            _tableName = tblName;
            InitializeComponent();
            LanguageManager.LoadInterfaceLanguage(this);
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = @"Select path and enter filename";
                sfd.Filter = @"Knight OnLine data tables |*.tbl";
                sfd.OverwritePrompt = true;
                if (DialogResult.OK == sfd.ShowDialog())
                {
                    var tbl = StaticReference.GetTableByFullName(_tableName);

                    if (tbl == null)
                    {
                        StaticReference.ShowError(this, LanguageManager.Get("Message_FileNotOpen"));
                        Close();
                        return;
                    }

                    foreach (var v in StaticReference.EncryptionMethods.Where(v => string.Compare(v.Name(), cbEncryptionList.Text, StringComparison.Ordinal) == 0))
                    {
                        tbl.SetEncryption(v);
                    }
                    tbl.SaveAs(sfd.FileName);
                    StaticReference.ShowInformation(this, LanguageManager.Get("Message_Done"));
                    Close();
                    // tePath.Text = sfd.FileName;
                }
            }
        }

        private void frmEncryptionSelect_Load(object sender, EventArgs e)
        {
            foreach (var v in StaticReference.EncryptionMethods)
            {
                cbEncryptionList.Properties.Items.Add(v.Name());
            }
        }

        private void cbEncryptionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var v in StaticReference.EncryptionMethods.Where(v => string.Compare(v.Name(), cbEncryptionList.Text, StringComparison.Ordinal) == 0))
            {
                meDescription.Text = v.Description();
            }
        }
    }
}