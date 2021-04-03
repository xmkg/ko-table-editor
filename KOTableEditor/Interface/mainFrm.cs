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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraNavBar;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using KOTableEditor.Auxillary;
using KOTableEditor.Auxillary.Encryption;
using System.Drawing;
using DevExpress.LookAndFeel;

namespace KOTableEditor.Interface
{
    public sealed partial class mainFrm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /* Contains the row handles of newly added rows */
        Dictionary<GridView, List<DataRow>> _newRows = new Dictionary<GridView, List<DataRow>>();

        /* Contains the cell and row handles of changed cell values. */
        Dictionary<GridView, List<KeyValuePair<int, int>>> _editedCells = new Dictionary<GridView, List<KeyValuePair<int, int>>>();
        static class InternalClipboard
        {
            private static List<DataRow> _contents = new List<DataRow>();
            public static void Copy(ref List<DataRow> data)
            {
                _contents.Clear();
                _contents.AddRange(data);
            }

           public static List<DataRow> GetContents() { return _contents; }
            public static int GetSize() { return _contents.Count; }
            public static IEnumerable<DataRow> GetNext() { foreach (var v in _contents) { yield return v; } }
           public static bool DataExists() { return _contents.Count > 0; }
        }

        public mainFrm()
        {

            /* Component initialization code by designer. */
            InitializeComponent();
            LanguageManager.LoadInterfaceLanguage(this);
            foreach (string name in Enum.GetNames(typeof(SupportedLanguage)))
            {
                cbLanguages.Items.Add(name);
            }
           

            cbLanguages.EditValueChanging += CbLanguages_EditValueChanging;
     
            SetTabProperties();
            tcMain.HeaderLocation = TabHeaderLocation.Top;
            tcMain.AllowDrop = true;
            tcMain.DragDrop += HandleDragDrop;
            tcMain.DragEnter += HandleDragEnter;
            AllowDrop = true;
            DragDrop += HandleDragDrop;
            DragEnter += HandleDragEnter;
            // SkinManager.
        
            BarAndDockingController.LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            //BarAndDockingController.LookAndFeel.ac
           
        }

        #region New row highlight //v1.3//
        bool NewRowHighlightEnabled(GridView view, DataRow row)
        {
            lock (_newRows)
            {
                if (_newRows.ContainsKey(view))
                {
                    return _newRows[view].Contains(row);
                }
            }
            return false;
        }
        void AddNewRowHighlight(GridView view, DataRow row)
        {
            lock (_newRows)
            {
                if (!_newRows.ContainsKey(view))
                {
                    _newRows.Add(view, new List<DataRow>());
                }
                _newRows[view].Add(row);
            }
        }
        void RemoveNewRowHighlight(GridView view, DataRow row)
        {
            lock (_newRows)
            {
                if (!_newRows.ContainsKey(view))
                    return;
                _newRows[view].Remove(row);
            }
        }

        void ClearNewRowHighlight(GridView view)
        {
            lock (_newRows)
                _newRows.Remove(view);
        }

        #endregion

        private void CbLanguages_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        
            foreach (string name in Enum.GetNames(typeof(SupportedLanguage)))
            {
                if (e.NewValue.ToString().CompareTo(name) == 0)
                {
                    LanguageManager.ChangeLanguage((SupportedLanguage)Enum.Parse(typeof(SupportedLanguage), name), this);
                    RegistrySettings.Language = name;
                    RegistrySettings.Save();
                    break;
                }
            }
        }

   
        private void LookAndFeel_StyleChanged(object sender, EventArgs e)
        {
            RegistrySettings.SkinName = UserLookAndFeel.Default.SkinName;
            RegistrySettings.Save();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            ProcessCommandlineArguments(Environment.GetCommandLineArgs());
           
            lblUsername.Caption = string.Format(LanguageManager.Get("mainFrm_User"), StaticReference.Decrypt(RegistrySettings.Username, RegistrySettings._key, RegistrySettings._keySize));
        }

        private void RedrawFileInformation(KOTableFile tbl)
        {
            Trace.Assert(tbl != null, "RedrawFileInformation() - Table is null.");ngFileInfo_Name.Text = string.Format("{0}", tbl.FileInformation.Name);
            ngFileInfo_Path.Text = string.Format("{0}", tbl.FileInformation.DirectoryName);
            ngFileInfo_CreatedAt.Text = string.Format("{0}", tbl.FileInformation.CreationTimeUtc.ToLocalTime());
            ngFileInfo_LastAccess.Text = string.Format("{0}", tbl.FileInformation.LastAccessTimeUtc.ToLocalTime());
            ngFileInfo_LastModify.Text = string.Format("{0}", tbl.FileInformation.LastWriteTimeUtc.ToLocalTime());
            ngFileInfo_ColumnCount.Text = tbl.Table.Columns.Count.ToString();
            ngFileInfo_RowCount.Text = tbl.Table.Rows.Count.ToString();
            ngFileInfo_Size.Text = string.Format("{0} kb", tbl.FileInformation.Length/1024);
            ngFileInfo_Encryption.Text = string.Format("{0}", tbl.Encryption.Name());
        }

        #region Known table headers


        private readonly Dictionary<string, string[]> _itemTableHeaders = new Dictionary<string, string[]>
        {
            {
                "item_ext",
                new[]
                {
                    "extensionId",
                    "szHeader",
                    "baseItemID",
                    "Description",
                    "EffectID",
                    "dxtID",
                    "iconID",
                    "byItemType",
                    "Damage",
                    "AtkInterval",
                    "HitRate",
                    "EvasionRate",
                    "MaxDurability",
                    "PriceMultiply",
                    "Defense",
                    "DaggerDefense",
                    "SwordDefense",
                    "ClubDefense",
                    "AxeDefense",
                    "SpearDefense",
                    "ArrowDefense",
                    "FireDamage",
                    "GlacierDamage",
                    "LightningDamage",
                    "PoisonDamage",
                    "HPRecovery",
                    "MPDamage",
                    "MPRecovery",
                    "RepelPhysDamage",
                    "bySoulBind",
                    "strB",
                    "hpB",
                    "dexB",
                    "intB",
                    "mpB",
                    "bonusHealth",
                    "bonusMP",
                    "FireResist",
                    "IceResist",
                    "LightningResist",
                    "MagicResist",
                    "PoisonResist",
                    "CurseResist",
                    "dwEffectID1",
                    "dwEffectID2",
                    "reqLevel",
                    "reqRank",
                    "reqTitle",
                    "reqStrength",
                    "reqHP",
                    "reqDexterity",
                    "reqInt",
                    "reqMP",
                    "Unknown",
                    "Unknown",
                    "Unknown",
                    "Unknown",

                }
            },
            {
                "item_org",
                new[]
                {
                    "Num",
                    "extNum",
                    "strName",
                    "Description",
                    "Unknown",
                    "Unknown",
                    "IconID",
                    "dxtID",
                    "Unknown",
                    "Unknown",
                    "Kind",
                    "Unk",
                    "Slot",
                    "Unk",
                    "Class",
                    "Attack",
                    "Delay",
                    "Range",
                    "Weight",
                    "Duration",
                    "repairPrice",
                    "sellingPrice",
                    "AC",
                    "isCountable",
                    "Effect1",
                    "Effect2",
                    "ReqLevelMin",
                    "ReqLevelMax",
                    "Unknown",
                    "Unknown",
                    "ReqStr",
                    "ReqHp",
                    "ReqDex",
                    "ReqInt",
                    "ReqMp",
                    "SellingGroup",
                    "ItemGrade",
                    "Unknown",
                    "Unknown",
                    "Unknown",
                    "Unknown",
                }
            },

            {
                "skill_ext_1",
                new[]
                {
                    "iNum",
                    "Type",
                    "HitRate",
                    "Hit",
                    "Delay",
                    "ComboType",
                    "ComboCount",
                    "ComboDamage",
                    "Range",
                    "Unknown",
                    "Unknown",
                    "Unknown",
                }

            },
            {
                "skill_ext_2",
                new[]
                {
                    "iNum",
                    "HitType",
                    "HitRate",
                    "AddDamage",
                    "AddRange",
                    "NeedArrow"
                }
            },
            {
                "skill_ext_3",
                new[]
                {
                    "iNum",
                    "Radius",
                    "DirectType",
                    "FirstDamage",
                    "TimeDamage",
                    "Duration",
                    "Attribute"
                }
            },

            {
                "skill_ext_4",
                new[]
                {
                    "iNum",
                    "BuffType",
                    "Radius",
                    "Duration",
                    "AttackSpeed",
                    "Speed",
                    "AC",
                    "ACPct",
                    "Attack",
                    "MagicAttack",
                    "MaxHP",
                    "MaxHPPct",
                    "MaxMP",
                    "MaxMPPct",
                    "Str",
                    "Sta",
                    "Dex",
                    "Intel",
                    "Cha",
                    "FireR",
                    "ColdR",
                    "LightR",
                    "MagicR",
                    "DiseaseR",
                    "PoisonR",
                    "ExpPct"
                }
            },
            {
                "skill_ext_5",
                new[]
                {
                    "iNum",
                    "Name",
                    "Type",
                    "ExpRecover",
                    "NeedStone"
                }
            },
            {
                "skill_ext_6",
                new[]
                {
                    "iNum",
                    "Name",
                    "Desc",
                    "Size",
                    "TransformID",
                    "Duration",
                    "MaxHP",
                    "MaxMP",
                    "Speed",
                    "AttackSpeed",
                    "TotalHit",
                    "TotalAC",
                    "TotalHitRate",
                    "TotalEvasionRate",
                    "TotalFireR",
                    "TotalColdR",
                    "TotalLightR",
                    "TotalMagicR",
                    "TotalDiseaseR",
                    "TotalPoisonR",
                    "Unknown",
                    "Class",
                    "UserSkillUse",
                    "NeedItem",
                    "SkillSuccessRate",
                    "MonsterFriendly",
                    "LHandWeapon",
                    "RHandWeapon"
                }
            },
            {
                "skill_ext_9",
                new[]
                {
                    "iNum",
                    "Name",
                    "Desc",
                    "ValidGroup",
                    "NationChange",
                    "MonsterNum",
                    "TargetChange",
                    "StateChange",
                    "Radius",
                    "HitRate",
                    "Duration",
                    "AddDamage",
                    "Vision",
                    "NeedItem"
                }
            },
            {
                "skill_magic_main",
                new[]
                {
                    "MagicNum",
                    "KrName",
                    "EnName",
                    "Description",
                    "SelfAni1",
                    "BeforeAction",
                    "TargetAction",
                    "SelfEffect1",
                    "SelfPart1",
                    "SelfEffect2",
                    "SelfPart2",
                    "FlyingEffect",
                    "TargetEffect",
                    "TargetPart",
                    "Moral",
                    "SkillLevel",
                    "Skill",
                    "MSP",
                    "HP",
                    "ItemGroup",
                    "UseItem",
                    "CastTime",
                    "RecastTime",
                    "TempMemory1",
                    "TempMemory2",
                    "SuccessRate",
                    "Type1",
                    "Type2",
                    "Range",
                    "Etc",
                    "Event"
                }
            }
        };
        #endregion

        #region Argument related

        public void ProcessCommandlineArguments(string[] args)
        {
            
            if (args.Length > 1)
            {
                using (frmLoading l = new frmLoading())
                {
                    l.Show();
                    OpenFile(args[1]);
                   l.Close();
                }
            }
        }

        #endregion

        #region Drag 'n Drop

        private void HandleDragDrop(object sender, DragEventArgs e)
        {

            var data = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (data == null || data.Length == 0)
                return;
            using (frmLoading l = new frmLoading())
            {
                l.Show();

                
                foreach (var s in data)
                {
                    OpenFile(s);
                }
                l.Close();
            }
        }

        private static void HandleDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        #endregion

        #region File Operation

        private void OpenFile(object ofileName)
        {
            string fileName = ofileName as string;
            var fi = new FileInfo(fileName);
            if (!fi.Exists)
            {
                ;
                StaticReference.ShowWarning(this, string.Format(LanguageManager.Get("Message_FileOpenError"), fileName));
                return;
            }

            if (StaticReference.GetTableByFullName(fi.FullName) != null)
            {
                this.Invoke(new Action(() => { SwitchToTabpage(fi.FullName); }));

                return; 
            }

            DataTable table = null;
            KOEncryptionBase encryption = null;
            /* Try to decrypt file. */
            foreach (var encryptionMethod in StaticReference.EncryptionMethods)
            {
                table = encryptionMethod.GetDataTableFromFile(fileName, fi.Name);
                if (table == null)
                    continue;
                encryption = encryptionMethod;
                break;
            }

            if (table == null)
            {
                this.Invoke(new Action(()=> {
                    StaticReference.ShowWarning(this, string.Format(LanguageManager.Get("Message_FileEncryptionError"), fi.Name)); return;
                }));
                return;
            }
            var newTable = new KOTableFile(fi, table, encryption);
            /* Otherwise, we've succeeded to open file */
            StaticReference.AddNewTable(newTable);
            this.Invoke(new Action(() => 
            {
                CreateNewTabPage(newTable.Name, newTable.FullName);
                var grid = GetTabPageGrid(newTable.FullName);
                grid.KeyPress += Grid_KeyPress;
                grid.MouseClick += Grid_MouseClick;

                Trace.Assert(grid != null, "OpenFile() - Grid is null!");



                grid.BeginUpdate();
                grid.DataSource = table;
                var view = grid.MainView as GridView;

                Trace.Assert(view != null, "OpenFile() - GridView is null!");

                view.Tag = newTable.FullName;

                foreach (var v in _itemTableHeaders.Where(v => newTable.Name.ToLowerInvariant().Contains(v.Key)))
                {
                    view.ColumnPanelRowHeight += 20;
                    for (var i = 0; i < view.Columns.Count; i++)
                    {
                        if (i < v.Value.Length)
                            view.Columns[i].Caption = string.Format("{0}\n{1}\n{2}", v.Value[i], i, ColumnTypes.GetColumnTypeNameFromFullName(view.Columns[i].ColumnType.FullName));
                    }
                }
                //view.
                foreach (GridColumn col in view.Columns)
                {
                    col.AppearanceCell.Options.UseTextOptions = true;
                    col.AppearanceHeader.Options.UseTextOptions = true;

                    col.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                    col.AppearanceCell.TextOptions.VAlignment = VertAlignment.Center;
                    col.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                    col.AppearanceHeader.TextOptions.VAlignment = VertAlignment.Center;
                    col.MinWidth = col.ColumnType != typeof(string) ? 150 : 200;
                    col.OptionsColumn.FixedWidth = true;
                }

                grid.Refresh();
                grid.EndUpdate();
            }));
           
        }

        private void Grid_MouseClick(object sender, MouseEventArgs e)
        {
           if(e.Button == MouseButtons.Right)
            {
                Point pt = MousePosition;
               // var q = ((GridView)sender).PointToClient(pt);
                GridContextMenu.Show(pt);
            }
        }

        private void Grid_KeyPress(object sender, KeyPressEventArgs e)
        {
           // MessageBox.Show("onkeypress");
            //throw new NotImplementedException();
        }

        private bool CloseFile(string tableName)
        {
            var tbl = StaticReference.GetTableByFullName(tableName);

            if (tbl == null) 
                return true;

            if (tbl.Altered)
            {
              string q = string.Format(LanguageManager.Get("Message_SaveConfirmChanges"), tableName);

                switch (StaticReference.ShowQuestion(this,q))
                {
                    case DialogResult.Yes:
                        tbl.Save(); // save           
                        break;
                    case DialogResult.Cancel:
                        return false;
                }
            }

            try
            {
                /* Clear edited cell value if exist */
                var page = GetTabPageByFilename(tableName);
                var view = GetViewFromTabPage(page);
                if (_editedCells.ContainsKey(view))
                {
                    _editedCells.Remove(view);
                    view.Invalidate();
                }
                ClearNewRowHighlight(view);
                StaticReference.RemoveTableByFullName(tableName);
            }
            catch
            {
                // ignored
            }
            
            return true;
        }
        enum CloseAllType
        {
            CloseAll,
            CloseAllLeft,
            CloseAllRight,
            CloseAllButThis
        }
        private void CloseAll(string tableName,CloseAllType type)
        {
            List<XtraTabPage> disposeList = new List<XtraTabPage>();
            switch (type)
            {
                case CloseAllType.CloseAll:
                    {
                        foreach (XtraTabPage tp in tcMain.TabPages)
                        {
                            if(CloseFile(tp.Tag as string))
                            {
                                disposeList.Add(tp);
                            }
                        }
                    }
                    break;
                case CloseAllType.CloseAllLeft:
                    {
                        foreach(XtraTabPage tp in tcMain.TabPages)
                        {
                            string v = tp.Tag as string;
                            if(String.CompareOrdinal(tableName,v) == 0)
                            {
                                break; // do not continue closing.
                            }
                            if (CloseFile(v))
                            {
                                disposeList.Add(tp);
                            }
                        }
                    }
                    break;
                case CloseAllType.CloseAllRight:
                    {
                        bool close = false;
                        foreach (XtraTabPage tp in tcMain.TabPages)
                        {
                            string v = tp.Tag as string;
                            if (String.CompareOrdinal(tableName, v) == 0)
                            {
                                close = true;
                                continue;
                            }
                            if (!close)
                                continue;
                            if (CloseFile(v))
                            {
                                disposeList.Add(tp);
                            }
                        }
                    }
                    break;
                case CloseAllType.CloseAllButThis:
                    {
                        foreach (XtraTabPage tp in tcMain.TabPages)
                        {
                            string v = tp.Tag as string;
                            if (String.CompareOrdinal(tableName, v) == 0)

                                continue;
                            if (CloseFile(v))
                            {
                                disposeList.Add(tp);
                            }
                        }
                    }
                    break;
            }

            foreach(var tp in disposeList)
            {
                tcMain.TabPages.Remove(tp);
                tp.Dispose();
            }
            disposeList.Clear();
        }

        private bool SaveFile(string tableName)
        {
            var tbl = StaticReference.GetTableByFullName(tableName);

            if (tbl == null)
                return true;

            tbl.Save(); // save   
            tbl.Altered = false;
            if (tcMain.SelectedTabPage.Text.Contains("(*)"))
            {
                tcMain.SelectedTabPage.Text = tcMain.SelectedTabPage.Text.Replace("(*)", "");
            }
            var page = GetTabPageByFilename(tableName);
            var view = GetViewFromTabPage(page);
            if (_editedCells.ContainsKey(view))
            {
                _editedCells.Remove(view);
                view.Invalidate();
            }
            ClearNewRowHighlight(view);
            StaticReference.ShowInformation(this, LanguageManager.Get("Message_SaveSuccess"));
            return true;
        }

        private void ShowOpenFileDialog()
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.OK) 
                return;
            using (frmLoading l = new frmLoading())
            {
              
                this.SuspendLayout();
                l.Show();
                foreach (var s in OpenFileDialog.FileNames)
                {
                    OpenFile(s);
                    
                }
                this.ResumeLayout();
            }
        }

        #endregion

        #region Tab operation

        private void SetTabProperties()
        {
            tcMain.ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;
            tcMain.CloseButtonClick += tcMain_CloseButtonClick;
            tcMain.SelectedPageChanged += tcMain_SelectedPageChanged;
            tcMain.TabPages.Clear();
        }

        void tcMain_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            var er = e as TabPageChangedEventArgs;
            if (er != null)
            {
                if (er.Page == null)
                    return;
                //Text = LanguageManager.Get("mainFrm_Menu_About_Program") + $" - {er.Page.Tag as string}";
                lblOpenFile.Caption = er.Page.Tag as string;
                KOTableFile tbl = StaticReference.GetTableByFullName(er.Page.Tag as string);
                RedrawFileInformation(tbl);
                //ngFile.Caption = $"File ({tbl.Name})";
            }

        }

        private GridView GetViewFromTabPage(XtraTabPage q)
        {
            if (tcMain.TabPages.Count == 0)
                return null;
            return ((GridControl)q.Controls["tabPageMainGrid"]).MainView as GridView;
        }

        private GridView GetViewFromSelectedTabPage()
        {
            if (tcMain.TabPages.Count == 0)
                return null;
            /* We're fucking sure that exist.*/
            return ((GridControl) tcMain.SelectedTabPage.Controls["tabPageMainGrid"]).MainView as GridView;
        }

        private void SwitchToTabpage(string fileName)
        {
            var page = GetTabPageByFilename(fileName);
            if (page != null)
                tcMain.SelectedTabPage = page;
        }

        private XtraTabPage GetSelectedTabpage()
        {
            return tcMain.SelectedTabPage;
        }


        private XtraTabPage GetTabPageByFilename(string fileName)
        {
            foreach (XtraTabPage v in tcMain.TabPages)
                if ((string)v.Tag == fileName)
                {
                    return v;
                }
            return null;
        }
        private void CreateNewTabPage(string title,string fullname)
        {
            FileInfo fi = new FileInfo(fullname);
            string pageprefix = "";
            if (fi.Exists)
            {
                if (fi.Directory.Exists)
                {
                    if (fi.Directory.Parent.Exists)
                    {
                        try
                        {
                            pageprefix = "[" + fi.Directory.Parent.Name + "]\n";
                        }
                        catch(Exception e)
                        {

                        }
                    }
                }
                
            }
            
            tcMain.TabPages.Add(new XtraTabPage { Text =  pageprefix+ title, Tag = fullname, ShowCloseButton = DefaultBoolean.True });
            //pcTest.Collection.Add(new DevExpress.XtraBars.Ribbon.RibbonPageCategory("asd",System.Drawing.Color.Red));

            var newPage = GetTabPageByFilename(fullname);
            //newPage.ContextMenuStrip = GridContextMenu;
            Trace.Assert(newPage != null, "CreateNewTabPage() - newPage is null!");

            var tabPageMainGrid = new GridControl {Name = "tabPageMainGrid", Dock = DockStyle.Fill, AllowDrop = true};
            GridView mainView = new GridView(tabPageMainGrid)
            {
                ColumnPanelRowHeight = 40,
                BestFitMaxRowCount = int.MaxValue,
                IndicatorWidth = 50,
             
            };
            mainView.CellValueChanged += View_CellValueChanged;
            mainView.RowCellStyle += View_RowCellStyle;

            tabPageMainGrid.MainView = mainView;
            mainView.OptionsSelection.MultiSelect = true;
            mainView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            mainView.OptionsView.ShowIndicator = true;
            mainView.CustomDrawRowIndicator += GridViewEvent_CustomDrawRowIndicator;
            mainView.ValidateRow +=GridViewEvent_ValidateRow;
            tabPageMainGrid.DragEnter += HandleDragEnter;
            tabPageMainGrid.DragDrop += HandleDragDrop;
            newPage.AllowDrop = true;
            newPage.DragDrop += HandleDragDrop;
            newPage.DragEnter += HandleDragEnter;
        
            newPage.Controls.Add(tabPageMainGrid);
            tcMain.SelectedTabPage = newPage;
        }


        private void View_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = GetViewFromSelectedTabPage();
            KOTableFile tbl = StaticReference.GetTableByFullName(view.Tag as string);
            if (e.RowHandle < 0 || e.Column.AbsoluteIndex < 0)
                return;
            if (!(tbl == null))
            {
               
                /* New row highlight */
                if (NewRowHighlightEnabled(view, tbl.Table.Rows[e.RowHandle]))
                {
                    e.Appearance.BackColor = Color.FromArgb(128, Color.ForestGreen);
                }
            }
            if (_editedCells.ContainsKey(view))
            {
               
                /* Edited cell highlight */
                foreach (KeyValuePair<int, int> kvp in _editedCells[view])
                {
                    int cIndex = kvp.Value;
                    int rIndex = kvp.Key;
                    if (e.Column.AbsoluteIndex == cIndex && e.RowHandle == rIndex)
                    {
                        e.Appearance.BackColor = Color.FromArgb(128, Color.Gold);
                        break;
                    }
                }
            }
            //throw new NotImplementedException();
        }

        private void View_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView view = GetViewFromSelectedTabPage();
            if (null == view)
                return;
            lock (_editedCells)
            {
                if (!_editedCells.ContainsKey(view))
                {
                    _editedCells[view] = new List<KeyValuePair<int, int>>();

                }
                _editedCells[view].Add(new KeyValuePair<int, int>(e.RowHandle, e.Column.AbsoluteIndex));
            }
        }




        private void GridViewEvent_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var gridView = sender as GridView;

            if (gridView == null)
                return;

            var tbl = StaticReference.GetTableByFullName(gridView.Tag as string);
            if (tbl != null)
            {

                // var page = GetTabPageByFilename();
                var page = GetTabPageByFilename(tbl.FullName);
                if(null != page)
                {
                    if (!page.Text.Contains("(*)"))
                        page.Text += "(*)";
                }
               
                tbl.Altered = true;
            }

        }


        static void GridViewEvent_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!e.Info.IsRowIndicator || e.RowHandle < 0) 
                return;
            e.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            e.Appearance.TextOptions.VAlignment = VertAlignment.Center;
            e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private GridControl GetTabPageGrid(string title)
        {
            var page = GetTabPageByFilename(title);

            if (page == null)
                return null;
            if (page.Controls.ContainsKey("tabPageMainGrid"))
                return page.Controls["tabPageMainGrid"] as GridControl;
            return null;
        }

        #endregion

        #region UI Events

        private void tcMain_CloseButtonClick(object sender, EventArgs e)
        {
            var arg = e as ClosePageButtonEventArgs;var page = arg?.Page as XtraTabPage;
            if (page == null)
                return;


            var tblFileName = page.Tag as string;
            if (CloseFile(tblFileName))
            {
                tcMain.TabPages.Remove(page);/* */
                page.Dispose();
            }
        }

  

   

        // NavGroups : ngFile //
        private void ngFile_Open_LinkPressed(object sender, NavBarLinkEventArgs e)
        {
            ShowOpenFileDialog();
        }

        // NavGroups : ngSearch //
        private void ngSearch_Find_LinkPressed(object sender, NavBarLinkEventArgs e)
        {
            GridView view = GetViewFromSelectedTabPage();
            if (view == null)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_SelectPageFirst"));
                return;
            }
            view.ShowFindPanel();
        }

        private void hlBlogLink_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            ngAbout_Author.LinkVisited = true;
            Process.Start(e.Link);
        }



        #endregion

        private void ngFile_SaveAs_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (tcMain.SelectedTabPageIndex == -1 || tcMain.SelectedTabPage == null)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoFileOpen"));
                return;
            }
            string fileName = tcMain.SelectedTabPage.Tag as string;
            using (frmSaveAs encSelect = new frmSaveAs(fileName))
            {
                encSelect.ShowDialog();
            }
        }

        private void ngEdit_NewRow_LinkPressed(object sender, NavBarLinkEventArgs e)
        {
            if (tcMain.SelectedTabPageIndex == -1 || tcMain.SelectedTabPage == null)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoFileOpen"));
                return;
            }
            string fileName = tcMain.SelectedTabPage.Tag as string;
            KOTableFile tbl = StaticReference.GetTableByFullName(fileName);
            var view = GetViewFromSelectedTabPage();
            var row = tbl.Table.NewRow();
            tbl.Table.Rows.Add(row);
            AddNewRowHighlight(view, row);
            view.FocusedRowHandle = view.RowCount - 1;
            view.TopRowIndex = view.RowCount - 1;
            view.RefreshData();
            view.Invalidate();
        }

        private void ngEdit_NewColumn_LinkPressed(object sender, NavBarLinkEventArgs e)
        {
            if (tcMain.SelectedTabPageIndex == -1 || tcMain.SelectedTabPage == null)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoFileOpen"));
                return;
            }
            string fileName = tcMain.SelectedTabPage.Tag as string;
            using (frmColumnEditor columnEditor = new frmColumnEditor(fileName))
            {
                columnEditor.ShowDialog();
            }

            var grid = GetTabPageGrid(fileName);
            var newTable = StaticReference.GetTableByFullName(fileName);
            // TODO : Refresh datagrid
       /*     grid.DataSource = null;
            grid.DataSource = newTable;
            grid.ResetBindings();
            grid.RefreshDataSource();*/
            //   GetViewFromSelectedTabPage().SynchronizeData();
        }

        private void ngFile_BulkConvert_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            using (frmBulkConvert bc = new frmBulkConvert())

            {
                bc.ShowDialog();
            }
        }

        private void ngSearch_FindAndReplace_LinkPressed(object sender, NavBarLinkEventArgs e)
        {
            GridView view = GetViewFromSelectedTabPage();
            if (view == null)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_SelectPageFirst"));
                return;
            }
            
            using(frmFindAndReplace far = new frmFindAndReplace(this,view))
            {
                far.ShowDialog();
            }
        }

        private void ngFile_Save_LinkPressed(object sender, NavBarLinkEventArgs e)
        {
            if (tcMain.SelectedTabPageIndex == -1 || tcMain.SelectedTabPage == null)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoFileOpen"));
                return;
            }
            string fileName = tcMain.SelectedTabPage.Tag as string;

            if (SaveFile(fileName))
            { }
        }

        private void nbiSqlExport_LinkPressed(object sender, NavBarLinkEventArgs e)
        {
            if (tcMain.SelectedTabPageIndex == -1 || tcMain.SelectedTabPage == null)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoFileOpen"));
                return;
            }
            string fileName = tcMain.SelectedTabPage.Tag as string;
            using (frmExportAsSQL export= new frmExportAsSQL(fileName))
            {
                export.ShowDialog();
            }
        }

        private void pbKODevelopers_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.kodevelopers.com");
        }

        private void nbiLoginTest_LinkClicked(object sender, NavBarLinkEventArgs e)
        {     
            RegistrySettings.Username = "_empty";
            RegistrySettings.Password = "_empty";
            RegistrySettings.LoggedIn = false;
            RegistrySettings.KeepLoggedIn = false;
            RegistrySettings.RememberMe = false;       
            RegistrySettings.Save();
            Close();
        }

        private void TabContextMenuClick(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            if (null == tsmi)
                return;
            if (tcMain.SelectedTabPageIndex == -1 || tcMain.SelectedTabPage == null)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoFileOpen"));
                return;
            }
            string fileName = tcMain.SelectedTabPage.Tag as string;
            switch (tsmi.Name)
            {
                case "tpcmSave":
                    {          
                        SaveFile(fileName);
                    }
                    break;
                case "tpcmSaveAs":
                    using (frmSaveAs encSelect = new frmSaveAs(fileName))
                    {
                        encSelect.ShowDialog();
                    }
                    break;
                case "tpcmClose":
                    {
                        if (CloseFile(fileName))
                        {
                            var q = tcMain.SelectedTabPage;
                            tcMain.TabPages.Remove(q);/* */
                            q.Dispose();
                            //.Dispose();
                        }
                    }
                    break;
                case "tpcmCloseAllButThis":
                    CloseAll(fileName, CloseAllType.CloseAllButThis); 
                    break;
                case "tpcmCloseAllToLeft":
                    CloseAll(fileName, CloseAllType.CloseAllLeft);
                    break;
                case "tpcmCloseAllToRight":
                    CloseAll(fileName, CloseAllType.CloseAllRight);
                    break;
                case "tpcmCloseAll":
                    CloseAll(fileName, CloseAllType.CloseAll);
                    break;
                case "tpcmOpenFolder":
                    {
                        FileInfo fi = new FileInfo(fileName);
                        {
                            if (fi.Exists)
                            {
                                Process.Start("explorer.exe", fi.Directory.FullName);
                            }
                        }
                    }
                    break;
            }
        }

        private void tcMain_HeaderButtonClick(object sender, HeaderButtonEventArgs e)
        {
            //e.
        }

        private void tcMain_MouseClick(object sender, MouseEventArgs e)
        {
           if(e.Button == MouseButtons.Right)
            {
                XtraTabControl tabCtrl = sender as XtraTabControl;
                Point pt = MousePosition;
                XtraTabHitInfo info = tabCtrl.CalcHitInfo(tabCtrl.PointToClient(pt));
                if (info.HitTest == XtraTabHitTest.PageHeader)
                {
                    //contextPage = info.Page;
                    
                   TabContextMenu.Show(pt);
                    
                }
                else
                {
                   
                }
            }
        }

        private void tcMain_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.
        }

        private void tcMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.C:
                        MessageBox.Show("keyc");
                        break;
                    case Keys.V:
                        MessageBox.Show("keyv");
                        break;
                }
            }
        }

        private void copyRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tcMain.SelectedTabPageIndex == -1 || tcMain.SelectedTabPage == null)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoFileOpen"));
                return;
            }
            string fileName = tcMain.SelectedTabPage.Tag as string;
            
            var tbl = StaticReference.GetTableByFullName(fileName);
            GridView view = GetViewFromSelectedTabPage();
            
            if (view == null || tbl == null)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_SelectPageFirst"));
                return;
            }
            

           // MessageBox.Show("ctrlc");
            if(view.SelectedRowsCount == 0)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoRowsSelected"));
                return;
            }
            List<DataRow> drList = new List<DataRow>();
            for(int i = 0; i <view.SelectedRowsCount; i++)
            {

                drList.Add(tbl.Table.Rows[view.GetSelectedRows()[i]]);
                //view.GetSelectedRows().cl
            }
            /* Copy the content of selected rows to the internal clipboard. */
            InternalClipboard.Copy(ref drList);
            view.ClearSelection();
            StaticReference.ShowInformation(this, string.Format(LanguageManager.Get("Message_NRowsCopied"), InternalClipboard.GetSize()));
        }

        private void pasteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tcMain.SelectedTabPageIndex == -1 || tcMain.SelectedTabPage == null)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoFileOpen"));
                return;
            }

            string fileName = tcMain.SelectedTabPage.Tag as string;
            KOTableFile tbl = StaticReference.GetTableByFullName(fileName);
            GridView view = GetViewFromSelectedTabPage();
           
            if (null == tbl ||null == view)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_PasteError"));
                return;
            }
            if (InternalClipboard.DataExists())
            {
                /*
                 * Let's check if copied datarow matches the column length of current table
                 * */
                int successfulRows = 0;
                foreach(var copiedRow in InternalClipboard.GetNext())
                {
                    /* 
                     * 1. Column count of both tables should be same
                     * 2. Data types of columns for both tables should match
                     */
                    bool column_ok = true;
                    DataRow newRow = tbl.Table.NewRow();
                    if (tbl.Table.Columns.Count == copiedRow.Table.Columns.Count)
                    {
                        foreach (DataColumn cColumn in copiedRow.Table.Columns)
                        {
                            if (tbl.Table.Columns[cColumn.Ordinal].DataType != cColumn.DataType)
                            {
                                column_ok = false;
                                break;
                            }
                            else
                            {
                                newRow[cColumn.Ordinal] = copiedRow[cColumn];
                            }
                        }
                    }
                    else
                        column_ok = false;
                    if (column_ok)
                    {
                        successfulRows++;
                        /* Create a new row in table */
                        /* Insert the row.*/
                        tbl.Table.Rows.Add(newRow);
                        AddNewRowHighlight(view, newRow);
                    }
                }
                /* Scroll to bottom */
                view.FocusedRowHandle = view.RowCount - 1;
                view.TopRowIndex = view.RowCount - 1;
             
                if (successfulRows == InternalClipboard.GetSize())
                {
                    StaticReference.ShowInformation(this, string.Format(LanguageManager.Get("Message_NRowsAddSuccess"), successfulRows));
                }
                else
                {
                    StaticReference.ShowWarning(this, string.Format(LanguageManager.Get("Message_CopyError"), successfulRows, InternalClipboard.GetSize()));
                }
             
            }
            else
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_PasteNoRows"));
        }

        
        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tcMain.SelectedTabPageIndex == -1 || tcMain.SelectedTabPage == null)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoFileOpen"));
                return;
            }
            string fileName = tcMain.SelectedTabPage.Tag as string;

            var tbl = StaticReference.GetTableByFullName(fileName);
            GridView view = GetViewFromSelectedTabPage();

            if (view == null || tbl == null)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_SelectPageFirst"));
                return;
            }

            if (view.SelectedRowsCount == 0)
            {
                StaticReference.ShowWarning(this, LanguageManager.Get("Message_NoRowsSelected"));
                return;
            }
            if (StaticReference.ShowQuestion(this, string.Format(LanguageManager.Get("Message_DeleteConfirm"), view.SelectedRowsCount)) == DialogResult.Yes)
            {
                List<DataRow> selectedRows = new List<DataRow>();

                for (int i = 0; i < view.SelectedRowsCount; i++)
                {
                    selectedRows.Add(tbl.Table.Rows[view.GetSelectedRows()[i]]);
                }

                if (_editedCells.ContainsKey(view))
                {
                    foreach (var q in view.GetSelectedRows())
                    {
                        _editedCells[view].RemoveAll(i => i.Key == q);
                    }
                    view.Invalidate();
                }
                foreach (var t in selectedRows)
                {
                    tbl.Table.Rows.Remove(t);
                    RemoveNewRowHighlight(view, t);
                }
                view.ClearSelection();
                StaticReference.ShowInformation(this, string.Format(LanguageManager.Get("Message_DeleteSuccess"), selectedRows.Count));
            }



        }

        private void ngEdit_RowCopy_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            copyRowToolStripMenuItem.PerformClick();
        }

        private void ngEdit_RowPaste_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            pasteRowToolStripMenuItem.PerformClick();
        }

        private void ngEdit_RowDelete_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            deleteRowToolStripMenuItem.PerformClick();
        }
    }
}
