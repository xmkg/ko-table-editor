namespace KOTableEditor.Interface
{
    partial class frmBulkConvert
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
            this.lbLoadedTables = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSelectSourceFolder = new DevExpress.XtraEditors.SimpleButton();
            this.meLog = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSelectDestinationFolder = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbEncryption = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lbLoadedTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEncryption.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLoadedTables
            // 
            this.lbLoadedTables.Location = new System.Drawing.Point(12, 42);
            this.lbLoadedTables.Name = "lbLoadedTables";
            this.lbLoadedTables.Size = new System.Drawing.Size(419, 302);
            this.lbLoadedTables.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Loaded tables";
            // 
            // btnSelectSourceFolder
            // 
            this.btnSelectSourceFolder.Location = new System.Drawing.Point(16, 350);
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.Size = new System.Drawing.Size(220, 23);
            this.btnSelectSourceFolder.TabIndex = 2;
            this.btnSelectSourceFolder.Text = "Select folder..";
            this.btnSelectSourceFolder.Click += new System.EventHandler(this.btnSelectSourceFolder_Click);
            // 
            // meLog
            // 
            this.meLog.EditValue = "";
            this.meLog.Location = new System.Drawing.Point(443, 42);
            this.meLog.Name = "meLog";
            this.meLog.Size = new System.Drawing.Size(513, 302);
            this.meLog.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(443, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Log";
            // 
            // btnSelectDestinationFolder
            // 
            this.btnSelectDestinationFolder.Location = new System.Drawing.Point(242, 350);
            this.btnSelectDestinationFolder.Name = "btnSelectDestinationFolder";
            this.btnSelectDestinationFolder.Size = new System.Drawing.Size(189, 23);
            this.btnSelectDestinationFolder.TabIndex = 5;
            this.btnSelectDestinationFolder.Text = "Set destination folder";
            this.btnSelectDestinationFolder.Click += new System.EventHandler(this.btnSelectDestinationFolder_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(767, 350);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(189, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(443, 354);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Encryption : ";
            // 
            // cbEncryption
            // 
            this.cbEncryption.Location = new System.Drawing.Point(521, 351);
            this.cbEncryption.Name = "cbEncryption";
            this.cbEncryption.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEncryption.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbEncryption.Size = new System.Drawing.Size(240, 22);
            this.cbEncryption.TabIndex = 8;
            // 
            // frmBulkConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 387);
            this.Controls.Add(this.cbEncryption);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSelectDestinationFolder);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.meLog);
            this.Controls.Add(this.btnSelectSourceFolder);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbLoadedTables);
            this.DoubleBuffered = true;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.Name = "frmBulkConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bulk Table Convert";
            this.Load += new System.EventHandler(this.frmBulkConvert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbLoadedTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEncryption.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl lbLoadedTables;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSelectSourceFolder;
        private DevExpress.XtraEditors.MemoEdit meLog;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSelectDestinationFolder;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbEncryption;
    }
}