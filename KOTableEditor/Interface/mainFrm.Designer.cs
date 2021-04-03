using DevExpress.XtraEditors;

namespace KOTableEditor.Interface
{
    public partial class mainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.SplashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager();
            this.navBarMain = new DevExpress.XtraNavBar.NavBarControl();
            this.ngFile = new DevExpress.XtraNavBar.NavBarGroup();
            this.ngFile_Open = new DevExpress.XtraNavBar.NavBarItem();
            this.ngFile_Save = new DevExpress.XtraNavBar.NavBarItem();
            this.ngFile_SaveAs = new DevExpress.XtraNavBar.NavBarItem();
            this.ngFile_BulkConvert = new DevExpress.XtraNavBar.NavBarItem();
            this.ngFile_SQLExport = new DevExpress.XtraNavBar.NavBarItem();
            this.ngFile_Logout = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.ngFileInfo_LastModify = new DevExpress.XtraEditors.TextEdit();
            this.ngFileInfo_L_LastModified = new DevExpress.XtraEditors.LabelControl();
            this.ngFileInfo_LastAccess = new DevExpress.XtraEditors.TextEdit();
            this.ngFileInfo_L_LastAccess = new DevExpress.XtraEditors.LabelControl();
            this.ngFileInfo_CreatedAt = new DevExpress.XtraEditors.TextEdit();
            this.ngFileInfo_L_CreatedAt = new DevExpress.XtraEditors.LabelControl();
            this.ngFileInfo_ColumnCount = new DevExpress.XtraEditors.TextEdit();
            this.ngFileInfo_L_ColumnCount = new DevExpress.XtraEditors.LabelControl();
            this.ngFileInfo_RowCount = new DevExpress.XtraEditors.TextEdit();
            this.ngFileInfo_L_RowCount = new DevExpress.XtraEditors.LabelControl();
            this.ngFileInfo_Encryption = new DevExpress.XtraEditors.TextEdit();
            this.ngFileInfo_L_Encryption = new DevExpress.XtraEditors.LabelControl();
            this.ngFileInfo_Path = new DevExpress.XtraEditors.TextEdit();
            this.ngFileInfo_L_Path = new DevExpress.XtraEditors.LabelControl();
            this.ngFileInfo_Size = new DevExpress.XtraEditors.TextEdit();
            this.ngFileInfo_L_Size = new DevExpress.XtraEditors.LabelControl();
            this.ngFileInfo_Name = new DevExpress.XtraEditors.TextEdit();
            this.ngFileInfo_L_Filename = new DevExpress.XtraEditors.LabelControl();
            this.navBarGroupControlContainer2 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.pbKODevelopers = new System.Windows.Forms.PictureBox();
            this.ngAbout_Description = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.hyperlinkLabelControl2 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControl3 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ngAbout_Product = new DevExpress.XtraEditors.LabelControl();
            this.ngAbout_Version = new DevExpress.XtraEditors.LabelControl();
            this.ngAbout_Author = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.ngEdit = new DevExpress.XtraNavBar.NavBarGroup();
            this.ngEdit_NewRow = new DevExpress.XtraNavBar.NavBarItem();
            this.ngEdit_NewColumn = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem1 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarSeparatorItem2 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.ngEdit_RowCopy = new DevExpress.XtraNavBar.NavBarItem();
            this.ngEdit_RowPaste = new DevExpress.XtraNavBar.NavBarItem();
            this.ngEdit_RowDelete = new DevExpress.XtraNavBar.NavBarItem();
            this.ngSearch = new DevExpress.XtraNavBar.NavBarGroup();
            this.ngSearch_Find = new DevExpress.XtraNavBar.NavBarItem();
            this.ngSearch_FindAndReplace = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem3 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.ngFileInformation = new DevExpress.XtraNavBar.NavBarGroup();
            this.ngAbout = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BarAndDockingController = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.SkinChooser = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.lblUsername = new DevExpress.XtraBars.BarStaticItem();
            this.lblOpenFile = new DevExpress.XtraBars.BarStaticItem();
            this.beLanguage = new DevExpress.XtraBars.BarEditItem();
            this.cbLanguages = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.repositoryItemColorPickEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.repositoryItemBreadCrumbEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.GridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tpcmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tpcmSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tpcmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tpcmCloseAllButThis = new System.Windows.Forms.ToolStripMenuItem();
            this.tpcmCloseAllToLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tpcmCloseAllToRight = new System.Windows.Forms.ToolStripMenuItem();
            this.tpcmOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navBarMain)).BeginInit();
            this.navBarMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_LastModify.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_LastAccess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_CreatedAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_ColumnCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_RowCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_Encryption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_Path.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_Size.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKODevelopers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarAndDockingController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLanguages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBreadCrumbEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.GridContextMenu.SuspendLayout();
            this.TabContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarMain
            // 
            this.navBarMain.ActiveGroup = this.ngFile;
            this.navBarMain.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarMain.Controls.Add(this.navBarGroupControlContainer2);
            this.navBarMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.ngFile,
            this.ngEdit,
            this.ngSearch,
            this.ngFileInformation,
            this.ngAbout});
            this.navBarMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.ngFile_Open,
            this.ngFile_Save,
            this.ngFile_SaveAs,
            this.ngFile_BulkConvert,
            this.ngEdit_NewRow,
            this.ngEdit_NewColumn,
            this.navBarSeparatorItem1,
            this.navBarSeparatorItem2,
            this.ngSearch_Find,
            this.ngSearch_FindAndReplace,
            this.navBarSeparatorItem3,
            this.navBarItem2,
            this.navBarItem3,
            this.ngFile_SQLExport,
            this.ngFile_Logout,
            this.ngEdit_RowCopy,
            this.ngEdit_RowPaste,
            this.ngEdit_RowDelete});
            this.navBarMain.Location = new System.Drawing.Point(0, 52);
            this.navBarMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navBarMain.Name = "navBarMain";
            this.navBarMain.OptionsNavPane.ExpandedWidth = 219;
            this.navBarMain.Size = new System.Drawing.Size(219, 645);
            this.navBarMain.TabIndex = 0;
            this.navBarMain.Text = "navBarControl1";
            // 
            // ngFile
            // 
            this.ngFile.Caption = "File";
            this.ngFile.Expanded = true;
            this.ngFile.Name = "ngFile";
            this.ngFile.SmallImage = global::KOTableEditor.Properties.Resources.if_document_open_118911;
            // 
            // ngFile_Open
            // 
            this.ngFile_Open.Caption = "Open new table";
            this.ngFile_Open.Name = "ngFile_Open";
            this.ngFile_Open.SmallImage = global::KOTableEditor.Properties.Resources.if_Open_1493293;
            this.ngFile_Open.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ngFile_Open_LinkPressed);
            // 
            // ngFile_Save
            // 
            this.ngFile_Save.Caption = "Save table";
            this.ngFile_Save.Name = "ngFile_Save";
            this.ngFile_Save.SmallImage = global::KOTableEditor.Properties.Resources.if_save_173091;
            this.ngFile_Save.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ngFile_Save_LinkPressed);
            // 
            // ngFile_SaveAs
            // 
            this.ngFile_SaveAs.Caption = "Save table as..";
            this.ngFile_SaveAs.Name = "ngFile_SaveAs";
            this.ngFile_SaveAs.SmallImage = global::KOTableEditor.Properties.Resources.if_Save_as_70651;
            this.ngFile_SaveAs.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ngFile_SaveAs_LinkClicked);
            // 
            // ngFile_BulkConvert
            // 
            this.ngFile_BulkConvert.Caption = "Bulk convert";
            this.ngFile_BulkConvert.Name = "ngFile_BulkConvert";
            this.ngFile_BulkConvert.SmallImage = global::KOTableEditor.Properties.Resources.if_Switch_105248;
            this.ngFile_BulkConvert.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ngFile_BulkConvert_LinkClicked);
            // 
            // ngFile_SQLExport
            // 
            this.ngFile_SQLExport.Caption = "SQL Export";
            this.ngFile_SQLExport.Name = "ngFile_SQLExport";
            this.ngFile_SQLExport.SmallImage = global::KOTableEditor.Properties.Resources.if_icon_89_document_file_sql_315887;
            this.ngFile_SQLExport.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiSqlExport_LinkPressed);
            // 
            // ngFile_Logout
            // 
            this.ngFile_Logout.Caption = "Logout";
            this.ngFile_Logout.Name = "ngFile_Logout";
            this.ngFile_Logout.SmallImage = global::KOTableEditor.Properties.Resources.if_Exit_728935;
            this.ngFile_Logout.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiLoginTest_LinkClicked);
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_LastModify);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_L_LastModified);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_LastAccess);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_L_LastAccess);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_CreatedAt);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_L_CreatedAt);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_ColumnCount);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_L_ColumnCount);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_RowCount);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_L_RowCount);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_Encryption);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_L_Encryption);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_Path);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_L_Path);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_Size);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_L_Size);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_Name);
            this.navBarGroupControlContainer1.Controls.Add(this.ngFileInfo_L_Filename);
            this.navBarGroupControlContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(211, 284);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // ngFileInfo_LastModify
            // 
            this.ngFileInfo_LastModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_LastModify.Location = new System.Drawing.Point(0, 261);
            this.ngFileInfo_LastModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_LastModify.Name = "ngFileInfo_LastModify";
            // 
            // 
            // 
            this.ngFileInfo_LastModify.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ngFileInfo_LastModify.Properties.Appearance.Options.UseFont = true;
            this.ngFileInfo_LastModify.Properties.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_LastModify.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_LastModify.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_LastModify.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.ngFileInfo_LastModify.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_LastModify.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_LastModify.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.ngFileInfo_LastModify.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_LastModify.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_LastModify.Properties.ReadOnly = true;
            this.ngFileInfo_LastModify.Size = new System.Drawing.Size(211, 18);
            this.ngFileInfo_LastModify.TabIndex = 17;
            // 
            // ngFileInfo_L_LastModified
            // 
            this.ngFileInfo_L_LastModified.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_L_LastModified.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_L_LastModified.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ngFileInfo_L_LastModified.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_L_LastModified.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ngFileInfo_L_LastModified.LineVisible = true;
            this.ngFileInfo_L_LastModified.Location = new System.Drawing.Point(0, 248);
            this.ngFileInfo_L_LastModified.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_L_LastModified.Name = "ngFileInfo_L_LastModified";
            this.ngFileInfo_L_LastModified.Size = new System.Drawing.Size(211, 13);
            this.ngFileInfo_L_LastModified.TabIndex = 25;
            this.ngFileInfo_L_LastModified.Text = "Last modified";
            // 
            // ngFileInfo_LastAccess
            // 
            this.ngFileInfo_LastAccess.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_LastAccess.Location = new System.Drawing.Point(0, 230);
            this.ngFileInfo_LastAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_LastAccess.Name = "ngFileInfo_LastAccess";
            // 
            // 
            // 
            this.ngFileInfo_LastAccess.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ngFileInfo_LastAccess.Properties.Appearance.Options.UseFont = true;
            this.ngFileInfo_LastAccess.Properties.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_LastAccess.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_LastAccess.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_LastAccess.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.ngFileInfo_LastAccess.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_LastAccess.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_LastAccess.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.ngFileInfo_LastAccess.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_LastAccess.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_LastAccess.Properties.ReadOnly = true;
            this.ngFileInfo_LastAccess.Size = new System.Drawing.Size(211, 18);
            this.ngFileInfo_LastAccess.TabIndex = 15;
            // 
            // ngFileInfo_L_LastAccess
            // 
            this.ngFileInfo_L_LastAccess.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_L_LastAccess.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_L_LastAccess.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ngFileInfo_L_LastAccess.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_L_LastAccess.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ngFileInfo_L_LastAccess.LineVisible = true;
            this.ngFileInfo_L_LastAccess.Location = new System.Drawing.Point(0, 217);
            this.ngFileInfo_L_LastAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_L_LastAccess.Name = "ngFileInfo_L_LastAccess";
            this.ngFileInfo_L_LastAccess.Size = new System.Drawing.Size(211, 13);
            this.ngFileInfo_L_LastAccess.TabIndex = 24;
            this.ngFileInfo_L_LastAccess.Text = "Last access time";
            // 
            // ngFileInfo_CreatedAt
            // 
            this.ngFileInfo_CreatedAt.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_CreatedAt.Location = new System.Drawing.Point(0, 199);
            this.ngFileInfo_CreatedAt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_CreatedAt.Name = "ngFileInfo_CreatedAt";
            // 
            // 
            // 
            this.ngFileInfo_CreatedAt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ngFileInfo_CreatedAt.Properties.Appearance.Options.UseFont = true;
            this.ngFileInfo_CreatedAt.Properties.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_CreatedAt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_CreatedAt.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_CreatedAt.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.ngFileInfo_CreatedAt.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_CreatedAt.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_CreatedAt.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.ngFileInfo_CreatedAt.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_CreatedAt.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_CreatedAt.Properties.ReadOnly = true;
            this.ngFileInfo_CreatedAt.Size = new System.Drawing.Size(211, 18);
            this.ngFileInfo_CreatedAt.TabIndex = 13;
            // 
            // ngFileInfo_L_CreatedAt
            // 
            this.ngFileInfo_L_CreatedAt.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_L_CreatedAt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_L_CreatedAt.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ngFileInfo_L_CreatedAt.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_L_CreatedAt.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ngFileInfo_L_CreatedAt.LineVisible = true;
            this.ngFileInfo_L_CreatedAt.Location = new System.Drawing.Point(0, 186);
            this.ngFileInfo_L_CreatedAt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_L_CreatedAt.Name = "ngFileInfo_L_CreatedAt";
            this.ngFileInfo_L_CreatedAt.Size = new System.Drawing.Size(211, 13);
            this.ngFileInfo_L_CreatedAt.TabIndex = 23;
            this.ngFileInfo_L_CreatedAt.Text = "Created at";
            // 
            // ngFileInfo_ColumnCount
            // 
            this.ngFileInfo_ColumnCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_ColumnCount.Location = new System.Drawing.Point(0, 168);
            this.ngFileInfo_ColumnCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_ColumnCount.Name = "ngFileInfo_ColumnCount";
            // 
            // 
            // 
            this.ngFileInfo_ColumnCount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ngFileInfo_ColumnCount.Properties.Appearance.Options.UseFont = true;
            this.ngFileInfo_ColumnCount.Properties.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_ColumnCount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_ColumnCount.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_ColumnCount.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.ngFileInfo_ColumnCount.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_ColumnCount.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_ColumnCount.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.ngFileInfo_ColumnCount.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_ColumnCount.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_ColumnCount.Properties.ReadOnly = true;
            this.ngFileInfo_ColumnCount.Size = new System.Drawing.Size(211, 18);
            this.ngFileInfo_ColumnCount.TabIndex = 11;
            // 
            // ngFileInfo_L_ColumnCount
            // 
            this.ngFileInfo_L_ColumnCount.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_L_ColumnCount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_L_ColumnCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ngFileInfo_L_ColumnCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_L_ColumnCount.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ngFileInfo_L_ColumnCount.LineVisible = true;
            this.ngFileInfo_L_ColumnCount.Location = new System.Drawing.Point(0, 155);
            this.ngFileInfo_L_ColumnCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_L_ColumnCount.Name = "ngFileInfo_L_ColumnCount";
            this.ngFileInfo_L_ColumnCount.Size = new System.Drawing.Size(211, 13);
            this.ngFileInfo_L_ColumnCount.TabIndex = 22;
            this.ngFileInfo_L_ColumnCount.Text = "Column count";
            // 
            // ngFileInfo_RowCount
            // 
            this.ngFileInfo_RowCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_RowCount.Location = new System.Drawing.Point(0, 137);
            this.ngFileInfo_RowCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_RowCount.Name = "ngFileInfo_RowCount";
            // 
            // 
            // 
            this.ngFileInfo_RowCount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ngFileInfo_RowCount.Properties.Appearance.Options.UseFont = true;
            this.ngFileInfo_RowCount.Properties.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_RowCount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_RowCount.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_RowCount.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.ngFileInfo_RowCount.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_RowCount.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_RowCount.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.ngFileInfo_RowCount.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_RowCount.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_RowCount.Properties.ReadOnly = true;
            this.ngFileInfo_RowCount.Size = new System.Drawing.Size(211, 18);
            this.ngFileInfo_RowCount.TabIndex = 10;
            // 
            // ngFileInfo_L_RowCount
            // 
            this.ngFileInfo_L_RowCount.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_L_RowCount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_L_RowCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ngFileInfo_L_RowCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_L_RowCount.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ngFileInfo_L_RowCount.LineVisible = true;
            this.ngFileInfo_L_RowCount.Location = new System.Drawing.Point(0, 124);
            this.ngFileInfo_L_RowCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_L_RowCount.Name = "ngFileInfo_L_RowCount";
            this.ngFileInfo_L_RowCount.Size = new System.Drawing.Size(211, 13);
            this.ngFileInfo_L_RowCount.TabIndex = 21;
            this.ngFileInfo_L_RowCount.Text = "Row count";
            // 
            // ngFileInfo_Encryption
            // 
            this.ngFileInfo_Encryption.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_Encryption.Location = new System.Drawing.Point(0, 106);
            this.ngFileInfo_Encryption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_Encryption.Name = "ngFileInfo_Encryption";
            // 
            // 
            // 
            this.ngFileInfo_Encryption.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ngFileInfo_Encryption.Properties.Appearance.Options.UseFont = true;
            this.ngFileInfo_Encryption.Properties.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_Encryption.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_Encryption.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_Encryption.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.ngFileInfo_Encryption.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_Encryption.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_Encryption.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.ngFileInfo_Encryption.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_Encryption.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_Encryption.Properties.ReadOnly = true;
            this.ngFileInfo_Encryption.Size = new System.Drawing.Size(211, 18);
            this.ngFileInfo_Encryption.TabIndex = 7;
            // 
            // ngFileInfo_L_Encryption
            // 
            this.ngFileInfo_L_Encryption.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_L_Encryption.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_L_Encryption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ngFileInfo_L_Encryption.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_L_Encryption.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ngFileInfo_L_Encryption.LineVisible = true;
            this.ngFileInfo_L_Encryption.Location = new System.Drawing.Point(0, 93);
            this.ngFileInfo_L_Encryption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_L_Encryption.Name = "ngFileInfo_L_Encryption";
            this.ngFileInfo_L_Encryption.Size = new System.Drawing.Size(211, 13);
            this.ngFileInfo_L_Encryption.TabIndex = 20;
            this.ngFileInfo_L_Encryption.Text = "Encryption method";
            // 
            // ngFileInfo_Path
            // 
            this.ngFileInfo_Path.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_Path.Location = new System.Drawing.Point(0, 75);
            this.ngFileInfo_Path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_Path.Name = "ngFileInfo_Path";
            // 
            // 
            // 
            this.ngFileInfo_Path.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ngFileInfo_Path.Properties.Appearance.Options.UseFont = true;
            this.ngFileInfo_Path.Properties.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_Path.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_Path.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_Path.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.ngFileInfo_Path.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_Path.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_Path.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.ngFileInfo_Path.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_Path.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_Path.Properties.ReadOnly = true;
            this.ngFileInfo_Path.Size = new System.Drawing.Size(211, 18);
            this.ngFileInfo_Path.TabIndex = 5;
            // 
            // ngFileInfo_L_Path
            // 
            this.ngFileInfo_L_Path.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_L_Path.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_L_Path.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ngFileInfo_L_Path.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_L_Path.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ngFileInfo_L_Path.LineVisible = true;
            this.ngFileInfo_L_Path.Location = new System.Drawing.Point(0, 62);
            this.ngFileInfo_L_Path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_L_Path.Name = "ngFileInfo_L_Path";
            this.ngFileInfo_L_Path.Size = new System.Drawing.Size(211, 13);
            this.ngFileInfo_L_Path.TabIndex = 19;
            this.ngFileInfo_L_Path.Text = "Path";
            // 
            // ngFileInfo_Size
            // 
            this.ngFileInfo_Size.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_Size.Location = new System.Drawing.Point(0, 44);
            this.ngFileInfo_Size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_Size.Name = "ngFileInfo_Size";
            // 
            // 
            // 
            this.ngFileInfo_Size.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ngFileInfo_Size.Properties.Appearance.Options.UseFont = true;
            this.ngFileInfo_Size.Properties.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_Size.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_Size.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_Size.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.ngFileInfo_Size.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_Size.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_Size.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.ngFileInfo_Size.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_Size.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_Size.Properties.ReadOnly = true;
            this.ngFileInfo_Size.Size = new System.Drawing.Size(211, 18);
            this.ngFileInfo_Size.TabIndex = 3;
            // 
            // ngFileInfo_L_Size
            // 
            this.ngFileInfo_L_Size.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_L_Size.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_L_Size.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ngFileInfo_L_Size.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_L_Size.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ngFileInfo_L_Size.LineVisible = true;
            this.ngFileInfo_L_Size.Location = new System.Drawing.Point(0, 31);
            this.ngFileInfo_L_Size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_L_Size.Name = "ngFileInfo_L_Size";
            this.ngFileInfo_L_Size.Size = new System.Drawing.Size(211, 13);
            this.ngFileInfo_L_Size.TabIndex = 4;
            this.ngFileInfo_L_Size.Text = "Size";
            // 
            // ngFileInfo_Name
            // 
            this.ngFileInfo_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_Name.Location = new System.Drawing.Point(0, 13);
            this.ngFileInfo_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_Name.Name = "ngFileInfo_Name";
            // 
            // 
            // 
            this.ngFileInfo_Name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ngFileInfo_Name.Properties.Appearance.Options.UseFont = true;
            this.ngFileInfo_Name.Properties.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_Name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_Name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_Name.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.ngFileInfo_Name.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_Name.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_Name.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.ngFileInfo_Name.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_Name.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngFileInfo_Name.Properties.ReadOnly = true;
            this.ngFileInfo_Name.Size = new System.Drawing.Size(211, 18);
            this.ngFileInfo_Name.TabIndex = 1;
            // 
            // ngFileInfo_L_Filename
            // 
            this.ngFileInfo_L_Filename.Appearance.Options.UseTextOptions = true;
            this.ngFileInfo_L_Filename.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngFileInfo_L_Filename.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ngFileInfo_L_Filename.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngFileInfo_L_Filename.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.ngFileInfo_L_Filename.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ngFileInfo_L_Filename.LineVisible = true;
            this.ngFileInfo_L_Filename.Location = new System.Drawing.Point(0, 0);
            this.ngFileInfo_L_Filename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngFileInfo_L_Filename.Name = "ngFileInfo_L_Filename";
            this.ngFileInfo_L_Filename.Size = new System.Drawing.Size(211, 13);
            this.ngFileInfo_L_Filename.TabIndex = 18;
            this.ngFileInfo_L_Filename.Text = "Filename";
            // 
            // navBarGroupControlContainer2
            // 
            this.navBarGroupControlContainer2.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer2.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer2.Controls.Add(this.pbKODevelopers);
            this.navBarGroupControlContainer2.Controls.Add(this.ngAbout_Description);
            this.navBarGroupControlContainer2.Controls.Add(this.panelControl2);
            this.navBarGroupControlContainer2.Controls.Add(this.panelControl1);
            this.navBarGroupControlContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navBarGroupControlContainer2.Name = "navBarGroupControlContainer2";
            this.navBarGroupControlContainer2.Size = new System.Drawing.Size(211, 184);
            this.navBarGroupControlContainer2.TabIndex = 1;
            // 
            // pbKODevelopers
            // 
            this.pbKODevelopers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbKODevelopers.Image = global::KOTableEditor.Properties.Resources.Psd1;
            this.pbKODevelopers.Location = new System.Drawing.Point(0, 108);
            this.pbKODevelopers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbKODevelopers.Name = "pbKODevelopers";
            this.pbKODevelopers.Size = new System.Drawing.Size(211, 68);
            this.pbKODevelopers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKODevelopers.TabIndex = 5;
            this.pbKODevelopers.TabStop = false;
            this.pbKODevelopers.Click += new System.EventHandler(this.pbKODevelopers_Click);
            // 
            // ngAbout_Description
            // 
            this.ngAbout_Description.Appearance.Options.UseTextOptions = true;
            this.ngAbout_Description.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngAbout_Description.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngAbout_Description.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ngAbout_Description.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ngAbout_Description.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngAbout_Description.LineLocation = DevExpress.XtraEditors.LineLocation.Top;
            this.ngAbout_Description.LineVisible = true;
            this.ngAbout_Description.Location = new System.Drawing.Point(0, 66);
            this.ngAbout_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngAbout_Description.Name = "ngAbout_Description";
            this.ngAbout_Description.Size = new System.Drawing.Size(211, 42);
            this.ngAbout_Description.TabIndex = 7;
            this.ngAbout_Description.Text = "This program is only shared for KODevelopers Knight OnLine Development Platform.";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.hyperlinkLabelControl2);
            this.panelControl2.Controls.Add(this.hyperlinkLabelControl3);
            this.panelControl2.Controls.Add(this.hyperlinkLabelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 48);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(211, 18);
            this.panelControl2.TabIndex = 12;
            // 
            // hyperlinkLabelControl2
            // 
            this.hyperlinkLabelControl2.Appearance.Options.UseTextOptions = true;
            this.hyperlinkLabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.hyperlinkLabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.hyperlinkLabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.hyperlinkLabelControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlinkLabelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hyperlinkLabelControl2.Location = new System.Drawing.Point(51, 2);
            this.hyperlinkLabelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hyperlinkLabelControl2.Name = "hyperlinkLabelControl2";
            this.hyperlinkLabelControl2.Size = new System.Drawing.Size(107, 14);
            this.hyperlinkLabelControl2.TabIndex = 9;
            this.hyperlinkLabelControl2.Text = "<href=skype:must1fy?chat>Skype</href>";
            this.hyperlinkLabelControl2.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.hlBlogLink_HyperlinkClick);
            // 
            // hyperlinkLabelControl3
            // 
            this.hyperlinkLabelControl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlinkLabelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.hyperlinkLabelControl3.Location = new System.Drawing.Point(158, 2);
            this.hyperlinkLabelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hyperlinkLabelControl3.Name = "hyperlinkLabelControl3";
            this.hyperlinkLabelControl3.Padding = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.hyperlinkLabelControl3.Size = new System.Drawing.Size(51, 13);
            this.hyperlinkLabelControl3.TabIndex = 10;
            this.hyperlinkLabelControl3.Text = "<href=https://www.kodevelopers.com/members/pentagram.html>Forum</href>";
            this.hyperlinkLabelControl3.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.hlBlogLink_HyperlinkClick);
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlinkLabelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(2, 2);
            this.hyperlinkLabelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(49, 13);
            this.hyperlinkLabelControl1.TabIndex = 8;
            this.hyperlinkLabelControl1.Text = "<href=mailto:mustafa@kodevelopers.com>E-Mail</href>";
            this.hyperlinkLabelControl1.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.hlBlogLink_HyperlinkClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.ngAbout_Product);
            this.panelControl1.Controls.Add(this.ngAbout_Version);
            this.panelControl1.Controls.Add(this.ngAbout_Author);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(211, 48);
            this.panelControl1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::KOTableEditor.Properties.Resources.datasheet_256;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 44);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ngAbout_Product
            // 
            this.ngAbout_Product.Location = new System.Drawing.Point(51, 5);
            this.ngAbout_Product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngAbout_Product.Name = "ngAbout_Product";
            this.ngAbout_Product.Size = new System.Drawing.Size(124, 13);
            this.ngAbout_Product.TabIndex = 0;
            this.ngAbout_Product.Text = "Knight OnLine table editor";
            // 
            // ngAbout_Version
            // 
            this.ngAbout_Version.Location = new System.Drawing.Point(51, 17);
            this.ngAbout_Version.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngAbout_Version.Name = "ngAbout_Version";
            this.ngAbout_Version.Size = new System.Drawing.Size(54, 13);
            this.ngAbout_Version.TabIndex = 6;
            this.ngAbout_Version.Text = "Version 1.3";
            // 
            // ngAbout_Author
            // 
            this.ngAbout_Author.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ngAbout_Author.Location = new System.Drawing.Point(51, 30);
            this.ngAbout_Author.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngAbout_Author.Name = "ngAbout_Author";
            this.ngAbout_Author.Size = new System.Drawing.Size(130, 13);
            this.ngAbout_Author.TabIndex = 4;
            this.ngAbout_Author.Text = "Developed by <href=http://insomniacoder.blogspot.com>PENTAGRAM</href>";
            this.ngAbout_Author.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.hlBlogLink_HyperlinkClick);
            // 
            // ngEdit
            // 
            this.ngEdit.Caption = "Edit";
            this.ngEdit.Expanded = true;
            this.ngEdit.Name = "ngEdit";
            this.ngEdit.SmallImage = global::KOTableEditor.Properties.Resources.if_accessories_text_editor_118805;
            // 
            // ngEdit_NewRow
            // 
            this.ngEdit_NewRow.Caption = "New row";
            this.ngEdit_NewRow.Name = "ngEdit_NewRow";
            this.ngEdit_NewRow.SmallImage = global::KOTableEditor.Properties.Resources.if_sign_add_299068;
            this.ngEdit_NewRow.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ngEdit_NewRow_LinkPressed);
            // 
            // ngEdit_NewColumn
            // 
            this.ngEdit_NewColumn.Caption = "Column editor";
            this.ngEdit_NewColumn.Name = "ngEdit_NewColumn";
            this.ngEdit_NewColumn.SmallImage = global::KOTableEditor.Properties.Resources.if_editprofile_101844;
            this.ngEdit_NewColumn.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ngEdit_NewColumn_LinkPressed);
            // 
            // navBarSeparatorItem1
            // 
            this.navBarSeparatorItem1.CanDrag = false;
            this.navBarSeparatorItem1.Enabled = false;
            this.navBarSeparatorItem1.Hint = null;
            this.navBarSeparatorItem1.LargeImageIndex = 0;
            this.navBarSeparatorItem1.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem1.Name = "navBarSeparatorItem1";
            this.navBarSeparatorItem1.SmallImageIndex = 0;
            this.navBarSeparatorItem1.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // navBarSeparatorItem2
            // 
            this.navBarSeparatorItem2.CanDrag = false;
            this.navBarSeparatorItem2.Enabled = false;
            this.navBarSeparatorItem2.Hint = null;
            this.navBarSeparatorItem2.LargeImageIndex = 0;
            this.navBarSeparatorItem2.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem2.Name = "navBarSeparatorItem2";
            this.navBarSeparatorItem2.SmallImageIndex = 0;
            this.navBarSeparatorItem2.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // ngEdit_RowCopy
            // 
            this.ngEdit_RowCopy.Caption = "Row Copy";
            this.ngEdit_RowCopy.Name = "ngEdit_RowCopy";
            this.ngEdit_RowCopy.SmallImage = global::KOTableEditor.Properties.Resources.if_Copy_1493280;
            this.ngEdit_RowCopy.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ngEdit_RowCopy_LinkClicked);
            // 
            // ngEdit_RowPaste
            // 
            this.ngEdit_RowPaste.Caption = "Row Paste";
            this.ngEdit_RowPaste.Name = "ngEdit_RowPaste";
            this.ngEdit_RowPaste.SmallImage = global::KOTableEditor.Properties.Resources.if_Paste_1493290;
            this.ngEdit_RowPaste.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ngEdit_RowPaste_LinkClicked);
            // 
            // ngEdit_RowDelete
            // 
            this.ngEdit_RowDelete.Caption = "Row Delete";
            this.ngEdit_RowDelete.Name = "ngEdit_RowDelete";
            this.ngEdit_RowDelete.SmallImage = global::KOTableEditor.Properties.Resources.if_Delete_1493279;
            this.ngEdit_RowDelete.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ngEdit_RowDelete_LinkClicked);
            // 
            // ngSearch
            // 
            this.ngSearch.Caption = "Search";
            this.ngSearch.Expanded = true;
            this.ngSearch.Name = "ngSearch";
            this.ngSearch.SmallImage = global::KOTableEditor.Properties.Resources.if_edit_find_118922;
            // 
            // ngSearch_Find
            // 
            this.ngSearch_Find.Caption = "Find";
            this.ngSearch_Find.Name = "ngSearch_Find";
            this.ngSearch_Find.SmallImage = global::KOTableEditor.Properties.Resources.if_search_binoculars_find_103854;
            this.ngSearch_Find.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ngSearch_Find_LinkPressed);
            // 
            // ngSearch_FindAndReplace
            // 
            this.ngSearch_FindAndReplace.Caption = "Find & Replace";
            this.ngSearch_FindAndReplace.Name = "ngSearch_FindAndReplace";
            this.ngSearch_FindAndReplace.SmallImage = global::KOTableEditor.Properties.Resources.if_edit_find_replace_1189211;
            this.ngSearch_FindAndReplace.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ngSearch_FindAndReplace_LinkPressed);
            // 
            // navBarSeparatorItem3
            // 
            this.navBarSeparatorItem3.CanDrag = false;
            this.navBarSeparatorItem3.Enabled = false;
            this.navBarSeparatorItem3.Hint = null;
            this.navBarSeparatorItem3.LargeImageIndex = 0;
            this.navBarSeparatorItem3.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem3.Name = "navBarSeparatorItem3";
            this.navBarSeparatorItem3.SmallImageIndex = 0;
            this.navBarSeparatorItem3.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // ngFileInformation
            // 
            this.ngFileInformation.Caption = "File Information";
            this.ngFileInformation.ControlContainer = this.navBarGroupControlContainer1;
            this.ngFileInformation.GroupClientHeight = 288;
            this.ngFileInformation.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.ngFileInformation.Name = "ngFileInformation";
            this.ngFileInformation.SmallImage = global::KOTableEditor.Properties.Resources.if_icon_84_document_information_314767;
            // 
            // ngAbout
            // 
            this.ngAbout.Caption = "About..";
            this.ngAbout.ControlContainer = this.navBarGroupControlContainer2;
            this.ngAbout.Expanded = true;
            this.ngAbout.GroupClientHeight = 188;
            this.ngAbout.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.ngAbout.Name = "ngAbout";
            this.ngAbout.SmallImage = global::KOTableEditor.Properties.Resources.if_about_us_465047;
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "File encryption :";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Change encryption";
            this.navBarItem3.Name = "navBarItem3";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.DefaultExt = "tbl";
            this.OpenFileDialog.Filter = "Knight OnLine data tables |*.tbl";
            this.OpenFileDialog.Multiselect = true;
            this.OpenFileDialog.Title = "Open table..";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "tbl";
            this.SaveFileDialog.Filter = "Knight OnLine data tables |*.tbl";
            this.SaveFileDialog.Title = "Save table..";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Controller = this.BarAndDockingController;
            // 
            // 
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.SkinChooser,
            this.barStaticItem1,
            this.lblUsername,
            this.lblOpenFile,
            this.beLanguage});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMarqueeProgressBar1,
            this.repositoryItemColorPickEdit1,
            this.repositoryItemBreadCrumbEdit1,
            this.cbLanguages});
            this.ribbonControl1.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center;
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(977, 52);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // BarAndDockingController
            // 
            this.BarAndDockingController.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.BarAndDockingController.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // SkinChooser
            // 
            this.SkinChooser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.SkinChooser.Caption = "Skins";
            this.SkinChooser.Description = "Choose a skin for the editor";
            this.SkinChooser.Id = 2;
            this.SkinChooser.Name = "SkinChooser";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Version : 1.3";
            this.barStaticItem1.Id = 7;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.ShowImageInToolbar = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Caption = "Logged in as : test";
            this.lblUsername.Id = 8;
            this.lblUsername.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Gray;
            this.lblUsername.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.ShowImageInToolbar = false;
            // 
            // lblOpenFile
            // 
            this.lblOpenFile.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.lblOpenFile.Id = 13;
            this.lblOpenFile.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOpenFile.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DimGray;
            this.lblOpenFile.ItemAppearance.Normal.Options.UseFont = true;
            this.lblOpenFile.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblOpenFile.Name = "lblOpenFile";
            this.lblOpenFile.ShowImageInToolbar = false;
            // 
            // beLanguage
            // 
            this.beLanguage.Caption = "   Language   ";
            this.beLanguage.Edit = this.cbLanguages;
            this.beLanguage.Id = 16;
            this.beLanguage.Name = "beLanguage";
            // 
            // cbLanguages
            // 
            this.cbLanguages.AutoHeight = false;
            this.cbLanguages.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLanguages.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cbLanguages.Name = "cbLanguages";
            this.cbLanguages.Sorted = true;
            this.cbLanguages.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // repositoryItemColorPickEdit1
            // 
            this.repositoryItemColorPickEdit1.AutoHeight = false;
            this.repositoryItemColorPickEdit1.AutomaticColor = System.Drawing.Color.Black;
            this.repositoryItemColorPickEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit1.Name = "repositoryItemColorPickEdit1";
            // 
            // repositoryItemBreadCrumbEdit1
            // 
            this.repositoryItemBreadCrumbEdit1.AutoHeight = false;
            this.repositoryItemBreadCrumbEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBreadCrumbEdit1.Name = "repositoryItemBreadCrumbEdit1";
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Page 0";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(1217, 737);
            this.tabFormContentContainer1.TabIndex = 4;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // tcMain
            // 
            this.tcMain.AllowDrop = true;
            this.tcMain.AppearancePage.Header.Options.UseTextOptions = true;
            this.tcMain.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tcMain.AppearancePage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tcMain.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.Teal;
            this.tcMain.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.tcMain.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.tcMain.AppearancePage.HeaderActive.Options.UseFont = true;
            this.tcMain.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.tcMain.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            this.tcMain.AppearancePage.HeaderHotTracked.Options.UseTextOptions = true;
            this.tcMain.AppearancePage.HeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tcMain.AppearancePage.HeaderHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.HeaderButtons = ((DevExpress.XtraTab.TabButtons)(((DevExpress.XtraTab.TabButtons.Prev | DevExpress.XtraTab.TabButtons.Next) 
            | DevExpress.XtraTab.TabButtons.Default)));
            this.tcMain.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.tcMain.Location = new System.Drawing.Point(219, 52);
            this.tcMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcMain.Name = "tcMain";
            this.tcMain.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.True;
            this.tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.tcMain.Size = new System.Drawing.Size(758, 645);
            this.tcMain.TabIndex = 1;
            this.tcMain.HeaderButtonClick += new DevExpress.XtraTab.ViewInfo.HeaderButtonEventHandler(this.tcMain_HeaderButtonClick);
            this.tcMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tcMain_KeyDown);
            this.tcMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcMain_KeyPress);
            this.tcMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tcMain_MouseClick);
            // 
            // GridContextMenu
            // 
            this.GridContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.GridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyRowToolStripMenuItem,
            this.pasteRowToolStripMenuItem,
            this.deleteRowToolStripMenuItem});
            this.GridContextMenu.Name = "GridContextMenu";
            this.GridContextMenu.Size = new System.Drawing.Size(168, 70);
            // 
            // copyRowToolStripMenuItem
            // 
            this.copyRowToolStripMenuItem.Name = "copyRowToolStripMenuItem";
            this.copyRowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyRowToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.copyRowToolStripMenuItem.Text = "Copy row";
            this.copyRowToolStripMenuItem.Click += new System.EventHandler(this.copyRowToolStripMenuItem_Click);
            // 
            // pasteRowToolStripMenuItem
            // 
            this.pasteRowToolStripMenuItem.Name = "pasteRowToolStripMenuItem";
            this.pasteRowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteRowToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pasteRowToolStripMenuItem.Text = "Paste row";
            this.pasteRowToolStripMenuItem.Click += new System.EventHandler(this.pasteRowToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // TabContextMenu
            // 
            this.TabContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TabContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tpcmSave,
            this.tpcmSaveAs,
            this.tpcmClose,
            this.tpcmCloseAllButThis,
            this.tpcmCloseAllToLeft,
            this.tpcmCloseAllToRight,
            this.tpcmOpenFolder});
            this.TabContextMenu.Name = "TabContextMenu";
            this.TabContextMenu.Size = new System.Drawing.Size(198, 158);
            // 
            // tpcmSave
            // 
            this.tpcmSave.Name = "tpcmSave";
            this.tpcmSave.Size = new System.Drawing.Size(197, 22);
            this.tpcmSave.Text = "Save";
            this.tpcmSave.Click += new System.EventHandler(this.TabContextMenuClick);
            // 
            // tpcmSaveAs
            // 
            this.tpcmSaveAs.Name = "tpcmSaveAs";
            this.tpcmSaveAs.Size = new System.Drawing.Size(197, 22);
            this.tpcmSaveAs.Text = "Save as..";
            this.tpcmSaveAs.Click += new System.EventHandler(this.TabContextMenuClick);
            // 
            // tpcmClose
            // 
            this.tpcmClose.Name = "tpcmClose";
            this.tpcmClose.Size = new System.Drawing.Size(197, 22);
            this.tpcmClose.Text = "Close";
            this.tpcmClose.Click += new System.EventHandler(this.TabContextMenuClick);
            // 
            // tpcmCloseAllButThis
            // 
            this.tpcmCloseAllButThis.Name = "tpcmCloseAllButThis";
            this.tpcmCloseAllButThis.Size = new System.Drawing.Size(197, 22);
            this.tpcmCloseAllButThis.Text = "Close ALL BUT this";
            this.tpcmCloseAllButThis.Click += new System.EventHandler(this.TabContextMenuClick);
            // 
            // tpcmCloseAllToLeft
            // 
            this.tpcmCloseAllToLeft.Name = "tpcmCloseAllToLeft";
            this.tpcmCloseAllToLeft.Size = new System.Drawing.Size(197, 22);
            this.tpcmCloseAllToLeft.Text = "Close ALL to the left";
            this.tpcmCloseAllToLeft.Click += new System.EventHandler(this.TabContextMenuClick);
            // 
            // tpcmCloseAllToRight
            // 
            this.tpcmCloseAllToRight.Name = "tpcmCloseAllToRight";
            this.tpcmCloseAllToRight.Size = new System.Drawing.Size(197, 22);
            this.tpcmCloseAllToRight.Text = "Close ALL to the right";
            this.tpcmCloseAllToRight.Click += new System.EventHandler(this.TabContextMenuClick);
            // 
            // tpcmOpenFolder
            // 
            this.tpcmOpenFolder.Name = "tpcmOpenFolder";
            this.tpcmOpenFolder.Size = new System.Drawing.Size(197, 22);
            this.tpcmOpenFolder.Text = "Open containing folder";
            this.tpcmOpenFolder.Click += new System.EventHandler(this.TabContextMenuClick);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseTextOptions = true;
            this.labelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl14.Location = new System.Drawing.Point(1, 1);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(954, 725);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "No file opened.\r\nOpen a file via clicking \"Open new table\" menu\r\nor you can drag " +
    "&& drop files here";
            // 
            // mainFrm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 697);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.navBarMain);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "mainFrm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knight OnLine Table Editor :: PENTAGRAM, 2017, KODEVELOPERS EDITION";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarMain)).EndInit();
            this.navBarMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_LastModify.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_LastAccess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_CreatedAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_ColumnCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_RowCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_Encryption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_Path.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_Size.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngFileInfo_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKODevelopers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarAndDockingController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLanguages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBreadCrumbEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.GridContextMenu.ResumeLayout(false);
            this.TabContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.PictureBox pbKODevelopers;
        internal DevExpress.XtraBars.TabFormPage tabFormPage1;
        internal System.Windows.Forms.ContextMenuStrip TabContextMenu;
        internal System.Windows.Forms.ToolStripMenuItem tpcmSave;
        internal System.Windows.Forms.ToolStripMenuItem tpcmSaveAs;
        internal System.Windows.Forms.ToolStripMenuItem tpcmClose;
        internal System.Windows.Forms.ToolStripMenuItem tpcmCloseAllButThis;
        internal System.Windows.Forms.ToolStripMenuItem tpcmCloseAllToLeft;
        internal System.Windows.Forms.ToolStripMenuItem tpcmCloseAllToRight;
        internal System.Windows.Forms.ToolStripMenuItem tpcmOpenFolder;
        internal System.Windows.Forms.ContextMenuStrip GridContextMenu;
        internal System.Windows.Forms.ToolStripMenuItem copyRowToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem pasteRowToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private DevExpress.XtraBars.BarStaticItem lblOpenFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbLanguages;
        private DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit repositoryItemBreadCrumbEdit1;
        private PanelControl panelControl2;
        private PanelControl panelControl1;
        private DevExpress.XtraSplashScreen.SplashScreenManager SplashScreenManager;
        private DevExpress.XtraNavBar.NavBarControl navBarMain;
        private DevExpress.XtraNavBar.NavBarGroup ngFile;
        private DevExpress.XtraNavBar.NavBarItem ngFile_Open;
        private DevExpress.XtraNavBar.NavBarItem ngFile_Save;
        private DevExpress.XtraNavBar.NavBarItem ngFile_SaveAs;
        private DevExpress.XtraNavBar.NavBarItem ngFile_BulkConvert;
        private DevExpress.XtraNavBar.NavBarGroup ngEdit;
        private DevExpress.XtraNavBar.NavBarGroup ngAbout;
        private DevExpress.XtraNavBar.NavBarItem ngEdit_NewRow;
        private DevExpress.XtraNavBar.NavBarItem ngEdit_NewColumn;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem1;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem2;
        private DevExpress.XtraNavBar.NavBarGroup ngSearch;
        private DevExpress.XtraNavBar.NavBarItem ngSearch_Find;
        private DevExpress.XtraNavBar.NavBarItem ngSearch_FindAndReplace;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraNavBar.NavBarGroup ngFileInformation;
        private TextEdit ngFileInfo_Name;
        private TextEdit ngFileInfo_Size;
        private TextEdit ngFileInfo_Encryption;
        private TextEdit ngFileInfo_Path;
        private LabelControl ngFileInfo_L_Size;
        private TextEdit ngFileInfo_RowCount;
        private TextEdit ngFileInfo_ColumnCount;
        private TextEdit ngFileInfo_CreatedAt;
        private TextEdit ngFileInfo_LastAccess;
        private TextEdit ngFileInfo_LastModify;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer2;
        private LabelControl ngAbout_Product;
        private HyperlinkLabelControl ngAbout_Author;
        private DevExpress.XtraNavBar.NavBarItem ngFile_SQLExport;
        private LabelControl ngFileInfo_L_LastModified;
        private LabelControl ngFileInfo_L_LastAccess;
        private LabelControl ngFileInfo_L_CreatedAt;
        private LabelControl ngFileInfo_L_ColumnCount;
        private LabelControl ngFileInfo_L_RowCount;
        private LabelControl ngFileInfo_L_Encryption;
        private LabelControl ngFileInfo_L_Path;
        private LabelControl ngFileInfo_L_Filename;
        private DevExpress.XtraNavBar.NavBarItem ngFile_Logout;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraTab.XtraTabControl tcMain;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem SkinChooser;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit1;
        private LabelControl ngAbout_Description;
        private LabelControl ngAbout_Version;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private LabelControl labelControl14;
        private DevExpress.XtraNavBar.NavBarItem ngEdit_RowCopy;
        private DevExpress.XtraNavBar.NavBarItem ngEdit_RowPaste;
        private DevExpress.XtraNavBar.NavBarItem ngEdit_RowDelete;
        private DevExpress.XtraBars.BarStaticItem lblUsername;
        private DevExpress.XtraBars.BarAndDockingController BarAndDockingController;
        private DevExpress.XtraBars.BarEditItem beLanguage;
        private HyperlinkLabelControl hyperlinkLabelControl1;
        private HyperlinkLabelControl hyperlinkLabelControl3;
        private HyperlinkLabelControl hyperlinkLabelControl2;
    }
}

