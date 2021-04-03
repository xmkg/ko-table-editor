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
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using KOTableEditor.Auxillary;

namespace KOTableEditor.Interface
{
    public partial class frmColumnEditor : XtraForm
    {
        private readonly string _tableName;

        private KOTableFile _tbl;

        private readonly System.Type[] _dataTypeList = 
        {
            typeof(string),
            typeof(byte),
            typeof(sbyte),
            typeof(short),
            typeof(ushort),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
            typeof(float),
            typeof(double)
        };
        public frmColumnEditor(string tableName)
        {
            _tableName = tableName;
        
            InitializeComponent();
            LanguageManager.LoadInterfaceLanguage(this);
            Text = string.Format(LanguageManager.Get("frmColumnEditor_Title"), tableName);
           
        }

        void PopulateColumns()
        {
            clbColumns.Items.Clear();
            int index = 0;
            foreach (DataColumn v in _tbl.Table.Columns)
            {
                clbColumns.Items.Add($"{index++}, ({v.DataType.ToString()})");
                
            }
        }

        private void frmColumnEditor_Load(object sender, EventArgs e)
        {
            _tbl = StaticReference.GetTableByFullName(_tableName);
            if (_tbl == null)
            {
                StaticReference.ShowError(this, LanguageManager.Get("Message_NoFileOpen"));
                Close();
                return;
            }
            PopulateColumns();

            foreach (var v in _dataTypeList)
            {
                cbColumnDataType_Add.Properties.Items.Add(v);
                cbColumnDataType_Update.Properties.Items.Add(v);
            }

        }

        private void btnRemoveChecked_Click(object sender, EventArgs e)
        {
            if (clbColumns.CheckedItems.Count == 0)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoCheckedItems"));
                return;
            }

            foreach (CheckedListBoxItem v in clbColumns.CheckedItems)
            {
                string[] zzz = Convert.ToString(v.Value).Split(',');
                int ind = Convert.ToInt32(zzz[0]);
                _tbl.Table.Columns.RemoveAt(ind);
              
                //  v
                // Columnindex = 0;
            }
            PopulateColumns();
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            if (cbColumnDataType_Add.SelectedIndex == -1)
                return;
            Type tp = _dataTypeList[cbColumnDataType_Add.SelectedIndex];
            DataColumn dc = new DataColumn($"[{_tbl.Table.Columns.Count + 1}]", tp);
            _tbl.Table.Columns.Add(dc);
            PopulateColumns();
        }

        private void btnUpdateColumn_Click(object sender, EventArgs e)
        {
            if (clbColumns.CheckedItems.Count == 0)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoCheckedItems"));
                return;
            }
            Type tp = _dataTypeList[cbColumnDataType_Update.SelectedIndex];
            DataTable dtCloned = _tbl.Table.Clone();
            dtCloned.Columns[0].DataType = typeof(Int32);

            foreach (CheckedListBoxItem v in clbColumns.CheckedItems)
            {
                string[] zzz = Convert.ToString(v.Value).Split(',');
                int ind = Convert.ToInt32(zzz[0]);

                if (_tbl.Table.Columns.GetType() == tp)
                {
                    /* same type */
                }
                else
                {
                    dtCloned.Columns[ind].DataType = tp;
                }
                //_tbl.Table.Columns.RemoveAt(ind);

                //  v
                // Columnindex = 0;
            }

            foreach (DataRow row in _tbl.Table.Rows)
            {
                dtCloned.ImportRow(row);
            }
            _tbl.Table = dtCloned;
           
            PopulateColumns();
        }

      
    }
}