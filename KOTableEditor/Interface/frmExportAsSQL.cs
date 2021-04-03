/**
 * ______________________________________________________
 * This file is part of ko-table-editor project.
 * 
 * @author       Mustafa Kemal Gılor <mustafagilor@gmail.com> (2017)
 * .
 * SPDX-License-Identifier:	MIT
 * ______________________________________________________
 */

using System.Data;
using KOTableEditor.Auxillary;
using System.Collections.Generic;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;
using System.IO;
using System;
using System.Text;
using DevExpress.XtraEditors;

namespace KOTableEditor.Interface
{
    public partial class frmExportAsSQL : DevExpress.XtraEditors.XtraForm
    {
        private KOTableFile _tbl;
        private readonly string _tableName;
        private List<DevExpress.XtraEditors.TextEdit> _columnNames = new List<DevExpress.XtraEditors.TextEdit>();
        public frmExportAsSQL(string tableName)
        {
            _tableName = tableName;
            InitializeComponent();
            LanguageManager.LoadInterfaceLanguage(this);

        }

        void PopulateColumns()
        {
            clbColumns.Items.Clear();
            _columnNames.Clear();
            int index = 0;
            foreach (DataColumn v in _tbl.Table.Columns)
            {
                clbColumns.Items.Add($"{index++}, ({v.DataType.ToString()})");

                var textEdit = new DevExpress.XtraEditors.TextEdit();
                textEdit.Parent = lblColumnNames;
                textEdit.Dock = System.Windows.Forms.DockStyle.Top;

                textEdit.ReadOnly = true; // false if only selected.
                textEdit.ToolTip = $"Column name for column {v.Ordinal}";
                textEdit.Name = $"column{v.Ordinal}name";
                switch (v.DataType.FullName)
                {
                    case "System.UInt64":
                    case "System.Int64":
                        textEdit.Text = $"llu_{v.Ordinal}";
                        break;
                    case "System.Double":
                    case "System.Single":
                        textEdit.Text = $"d_{v.Ordinal}";
                        break;
                    case "System.UInt32":
                    case "System.Int32":
                        textEdit.Text = $"n_{v.Ordinal}";
                        break;
                    case "System.UInt16":
                    case "System.Int16":
                        textEdit.Text = $"s_{v.Ordinal}";
                        break;
                    case "System.SByte":
                    case "System.Byte":
                        textEdit.Text = $"by_{v.Ordinal}";
                        break;
                    case "System.String":
                        textEdit.Text = $"str_{v.Ordinal}";
                        break;
                    default:
                        textEdit.Text = $"unk_{v.Ordinal}";
                        break;
                } /* EOF cell type switch */
                xscColumnNames.Controls.Add(textEdit);
                _columnNames.Add(textEdit);
                textEdit.BringToFront();
            }

        }

        private void frmExportAsSQL_Load(object sender, System.EventArgs e)
        {
            _tbl = StaticReference.GetTableByFullName(_tableName);
            if (_tbl == null)
            {
                StaticReference.ShowError(this, LanguageManager.Get("Message_NoFileOpen"));
                Close();
                return;
            }
            PopulateColumns();
           // meDescription.Text = StaticReference.GenerateKey(256);
        }

        private void clbColumns_CheckMemberChanged(object sender, System.EventArgs e)
        {
            return;
        }

        private void clbColumns_EnabledChanged(object sender, System.EventArgs e)
        {
            return;
        }

        private void clbColumns_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            _columnNames[e.Index].ReadOnly = !(e.State == System.Windows.Forms.CheckState.Checked);
        }

        private void btnCheckAll_Click(object sender, System.EventArgs e)
        {

            foreach (CheckedListBoxItem v in clbColumns.Items)
            {
                v.CheckState = System.Windows.Forms.CheckState.Checked;
            }
        }

        private void simpleButton2_Click(object sender, System.EventArgs e)
        {
            foreach (CheckedListBoxItem v in clbColumns.Items)
            {
                v.CheckState = System.Windows.Forms.CheckState.Unchecked;
            }
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            if (clbColumns.CheckedItems.Count == 0)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoCheckedItems"));
                return;
            }
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = LanguageManager.Get("frmExportAsSQL_Filter");
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    /* Let's begin */
                    StringBuilder insertQuery = new StringBuilder();

                    StringBuilder createQuery = new StringBuilder();
                    int batch = 0;
                    if (ceDropTable.Checked)
                    {
                        createQuery.Append($"DROP TABLE {teTableName.Text};\n");
                    }
                    createQuery.Append($"CREATE TABLE {teTableName.Text}(");
                    if (ceTruncateTable.Checked)
                    {
                        insertQuery.Append($"TRUNCATE TABLE {teTableName.Text};\n");
                    }
                    insertQuery.Append($"INSERT INTO {teTableName.Text} VALUES \n");

                    foreach (CheckedListBoxItem clbi in clbColumns.CheckedItems)
                    {
                        string[] zzz = Convert.ToString(clbi.Value).Split(',');
                        int ind = Convert.ToInt32(zzz[0]);
                        TextEdit te = _columnNames[ind];
                        createQuery.Append(te.Text);
                        switch (_tbl.Table.Columns[ind].DataType.FullName)
                        {
                            case "System.UInt64":
                            case "System.Int64":
                                createQuery.Append($" bigint,\n");
                                break;
                            case "System.Double":
                            case "System.Single":
                                createQuery.Append($" real,\n");
                                break;
                            case "System.UInt32":
                            case "System.Int32":
                                createQuery.Append($" int,\n");
                                break;
                            case "System.UInt16":
                            case "System.Int16":
                                createQuery.Append($" smallint,\n");
                                break;
                            case "System.SByte":
                            case "System.Byte":
                                createQuery.Append($" tinyint,\n");
                                break;
                            case "System.String":
                                createQuery.Append($" varchar(MAX),\n");
                                break;
                            default:
                                createQuery.Append($" unknown(MAX),\n");
                                break;
                        } /* EOF cell type switch */
                    }
                    int insertedRows = 0;

                    foreach (DataRow v in _tbl.Table.Rows)
                    {
                        insertQuery.Append("(");
                        foreach (CheckedListBoxItem clbi in clbColumns.CheckedItems)
                        {
                            string[] zzz = Convert.ToString(clbi.Value).Split(',');
                            int ind = Convert.ToInt32(zzz[0]);
                            DataColumn clmn = _tbl.Table.Columns[ind];
                            if (clmn.DataType.FullName == "System.String")
                            {
                                insertQuery.Append(("'" + v[clmn].ToString().Replace('\'', '’').Replace("\\", "\\\\") + "',"));
                            }
                            else if (clmn.DataType.FullName == "System.Single" || clmn.DataType.FullName == "System.Double")
                            {
                                /* Convert float notation from ',' to '.' */
                                insertQuery.Append(Convert.ToString(Convert.ToDouble(v[clmn].ToString())).Replace(",", ".") + ",");
                            }
                            else
                            {
                                insertQuery.Append(v[clmn] + ",");
                            }
                        }
                        insertQuery.Remove(insertQuery.Length - 1, 1);
                        insertQuery.Append("),\n");
                        if (++insertedRows == 999)
                        {
                            /* We need to break it to several parts. */
                            insertQuery.Remove(insertQuery.Length - 2, 2);
                            insertQuery.Append(";");
                            File.WriteAllText(sfd.FileName.Replace(".sql", "") + "_data" + (batch++) + ".sql", insertQuery.ToString());
                            insertQuery.Clear();
                            /* prepare for next batch */
                            insertQuery.Append($"INSERT INTO {teTableName.Text} VALUES \n");
                            insertedRows = 0;
                        }
                    }
                    insertQuery.Remove(insertQuery.Length - 2, 2);
                    insertQuery.Append(";");
                    createQuery.Remove(createQuery.Length - 2, 2);
                    createQuery.Append(");\n\n");
                    if (ceCreateTable.Checked)
                    {
                        File.WriteAllText(sfd.FileName.Replace(".sql", "") + "_ddl" + ".sql", createQuery.ToString());
                    }
                    File.AppendAllText(sfd.FileName.Replace(".sql", "") + "_data" + (batch++) + ".sql", insertQuery.ToString());
                }

            }
            StaticReference.ShowInformation(this, LanguageManager.Get("Message_ExportComplete"));
        }



        private void ceCreateTable_CheckedChanged(object sender, EventArgs e)
        {
            ceDropTable.Enabled = ceCreateTable.Checked;
        }
    }
}