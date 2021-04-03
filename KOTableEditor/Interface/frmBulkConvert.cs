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
using System.Data;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KOTableEditor.Auxillary;
using KOTableEditor.Auxillary.Encryption;

namespace KOTableEditor.Interface
{
    public partial class frmBulkConvert : XtraForm
    {
        private string _sourceFolder;
        private string _destinationFolder;
        private readonly Dictionary<string, KOTableFile> _loadedTables = new Dictionary<string, KOTableFile>();
        public frmBulkConvert()
        {
            InitializeComponent();
        }

        private void frmBulkConvert_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            foreach (var v in StaticReference.EncryptionMethods)
            {
                cbEncryption.Properties.Items.Add(v.Name());
            }
        }

        private void btnSelectSourceFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    _sourceFolder = fbd.SelectedPath;
                    meLog.Text = "";
                    meLog.Text += $"Source folder is set to {_sourceFolder}" + Environment.NewLine;
                    ThreadPool.QueueUserWorkItem(LoadFolder);
                }
            }
        }

        private void LoadFolder(object state)
        {
            _loadedTables.Clear();
            lbLoadedTables.Items.Clear();
         
            meLog.Text += $"Populating and loading tables in {_sourceFolder}" + Environment.NewLine;
            string[] files = Directory.GetFiles(_sourceFolder);
            foreach (string path in files)
            {
                FileInfo fi = new FileInfo(path);
                if (!fi.Exists || fi.Extension != ".tbl")
                    continue;

                DataTable table = null;
                KOEncryptionBase encryption = null;
                /* Try to decrypt file. */
                foreach (var encryptionMethod in StaticReference.EncryptionMethods)
                {
                    table = encryptionMethod.GetDataTableFromFile(path, fi.Name);
                    if (table == null)
                        continue;
                    encryption = encryptionMethod;
                    break;
                }

                if (table == null)
                {
                    lbLoadedTables.Items.Add($"{fi.Name} - Load failed.");
                  
                }
                else
                {
                    lbLoadedTables.Items.Add($"{fi.Name} [{encryption.Name()}] - OK");
                    var newTable = new KOTableFile(fi, table, encryption);
                    _loadedTables.Add(path, newTable);
                }
                
            }
          

          
        }

        private void btnSelectDestinationFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select the output folder";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    _destinationFolder= fbd.SelectedPath;
                    meLog.Text += $"Destination folder is set to {_destinationFolder}" + Environment.NewLine;
                    // LoadFolder();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_loadedTables.Count == 0)
            {
                StaticReference.ShowWarning(this, "There are no loaded tables to convert.");
                return;
            }
            if (string.IsNullOrEmpty(_destinationFolder))
            {
                StaticReference.ShowWarning(this,"Destination folder is not set.");
                return;
            }
            if (!Directory.Exists(_destinationFolder))
            {
                try
                {
                    Directory.CreateDirectory(_destinationFolder);
                }
                catch(Exception ex)
                {
                    StaticReference.ShowWarning(this,$"An exception occured while creating destination directory.\nException : {ex.Message}");
                    return;
                }
            }

            var encMethod = StaticReference.EncryptionMethods.FirstOrDefault(v => string.Compare(v.Name(), cbEncryption.Text, StringComparison.Ordinal) == 0);

            if (encMethod == null)
            {
                StaticReference.ShowWarning(this, $"Encryption load error.");
                return;
            }
            foreach (var tbl in _loadedTables)
            {
                meLog.Text += $"Saving {_destinationFolder}\\{tbl.Value.Name}" + Environment.NewLine;
                tbl.Value.SetEncryption(encMethod);
                tbl.Value.SaveAs($"{_destinationFolder}\\{tbl.Value.Name}");
            }

            StaticReference.ShowInformation(this, "Done.");
        }
    }
}