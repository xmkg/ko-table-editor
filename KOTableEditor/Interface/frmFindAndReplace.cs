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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using KOTableEditor.Auxillary;

namespace KOTableEditor.Interface
{
    public partial class frmFindAndReplace : DevExpress.XtraEditors.XtraForm
    {

        class indexColumnPair
        {
            public int index;
            public GridColumn m_column;
        }

        ManualResetEvent mre = new ManualResetEvent(false);
        mainFrm _parent;

        private GridView _gridView;
        public frmFindAndReplace(mainFrm mainFrm,GridView view)
        {
            _parent = mainFrm;
            _gridView = view;

            InitializeComponent();
            Auxillary.LanguageManager.LoadInterfaceLanguage(this);
            bgwFindNext.RunWorkerAsync();
        }

        private void frmFindAndReplace_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            mre.Set();
        }

        private IEnumerable<indexColumnPair> findNextMatch(bool findAllFlag)
        {
            
            for(int i =0; i < _gridView.DataRowCount; i++)
            {
               foreach(GridColumn column in _gridView.Columns)
               {
                    this.Invoke(new Action(() => 
                    {
                        btnRepNext.Enabled = false;
                        btnRepAll.Enabled = false;
                        btnRepNext.Text = Auxillary.LanguageManager.Get("Message_Searching");
                        btnRepAll.Text = Auxillary.LanguageManager.Get("Message_PleaseWait");
                    }));
                    
                    var cellValue = Convert.ToString(_gridView.GetRowCellValue(i, column));
                    bool yieldReturnCurrent = false;
                    if (cbCaseSensitive.Checked && cbMatchWhole.Checked)
                    {
                        if (cellValue.Equals(teFindValue.Text))
                             yieldReturnCurrent = true;
                        
                    }
                    else if (cbCaseSensitive.Checked)
                    {
                        if (cellValue.Contains(teFindValue.Text))
                            yieldReturnCurrent = true;

                    }
                    else if (cbMatchWhole.Checked)
                    {
                        if (cellValue.ToLowerInvariant().Equals(teFindValue.Text.ToLowerInvariant()))
                            yieldReturnCurrent = true;
                    }
                    else
                    {
                        if (cellValue.ToLowerInvariant().Contains(teFindValue.Text.ToLowerInvariant()))
                            yieldReturnCurrent = true;
                        
                    }

                    if (yieldReturnCurrent)
                    {
                        if (!findAllFlag)
                        {
                            this.Invoke(new Action(() =>
                            {
                                btnRepNext.Enabled = true;
                                btnRepAll.Enabled = true;
                                btnRepNext.Text = Auxillary.LanguageManager.Get("frmFindAndReplace_Button_ReplaceNext");
                                btnRepAll.Text = Auxillary.LanguageManager.Get("frmFindAndReplace_Button_ReplaceAll");
                            }));
                        }
                        yield return new indexColumnPair() { index = i, m_column = column };
                    }
               } 
            }
            this.Invoke(new Action(() =>
            {
                btnRepNext.Enabled = true;
                btnRepAll.Enabled = true;
                btnRepNext.Text = Auxillary.LanguageManager.Get("frmFindAndReplace_Button_ReplaceNext");
                btnRepAll.Text = Auxillary.LanguageManager.Get("frmFindAndReplace_Button_ReplaceAll");
            }));
        }

        private void bgwFindNext_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true && !bgwFindNext.CancellationPending)
            {
                mre.WaitOne();
                mre.Reset();
                IEnumerable<indexColumnPair> resultSet = findNextMatch(false);
                IEnumerator<indexColumnPair> resultEnum = resultSet.GetEnumerator();
                if (!resultEnum.MoveNext() || resultEnum.Current == null)
                {
                   

                    this.Invoke(new Action(() => { StaticReference.ShowInformation(this, Auxillary.LanguageManager.Get("Message_NoMoreMatches")); }));
                }
                else
                {
                    do
                    {
                       // MessageBox.Show(_gridView.GetRowCellValue(resultEnum.Current.index, resultEnum.Current.m_column).ToString());
                        _parent.Invoke(new Action(() => {
                            _gridView.FocusedRowHandle = resultEnum.Current.index;
                            _gridView.FocusedColumn = resultEnum.Current.m_column;
                            _gridView.SetRowCellValue(resultEnum.Current.index, resultEnum.Current.m_column, teReplaceValue.Text);
                        }));
                     
                        mre.WaitOne();
                        mre.Reset();
                        
                    }
                    while (resultEnum.MoveNext() && !bgwFindNext.CancellationPending);
                    
                    this.Invoke(new Action(() => { StaticReference.ShowInformation(this, Auxillary.LanguageManager.Get("Message_NoMoreMatches")); }));
                    
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bgwFindNext.CancelAsync();
            this.Close();
        }

        private void btnRepAll_Click(object sender, EventArgs e)
        {
            int replacementCount = 0;
            foreach(var v in findNextMatch(true))
            {
                _parent.Invoke(new Action(() => {
                    _gridView.FocusedRowHandle = v.index;
                    _gridView.FocusedColumn = v.m_column;
                    string rowCellValue = Convert.ToString(_gridView.GetRowCellValue(v.index, v.m_column));
                    rowCellValue = rowCellValue.Replace(teFindValue.Text, teReplaceValue.Text);
                    _gridView.SetRowCellValue(v.index, v.m_column, rowCellValue);
                }));
                replacementCount++;
            }
         
            this.Invoke(new Action(() => { StaticReference.ShowInformation(this, string.Format(Auxillary.LanguageManager.Get("Message_NMatchesReplaced"), replacementCount)); }));
           
        }
    }
}