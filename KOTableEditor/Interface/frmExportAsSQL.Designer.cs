namespace KOTableEditor.Interface
{
    partial class frmExportAsSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportAsSQL));
            this.gcTableOptions = new DevExpress.XtraEditors.GroupControl();
            this.btnUncheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
            this.btnCheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.ceTruncateTable = new DevExpress.XtraEditors.CheckEdit();
            this.ceDropTable = new DevExpress.XtraEditors.CheckEdit();
            this.ceCreateTable = new DevExpress.XtraEditors.CheckEdit();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.teTableName = new DevExpress.XtraEditors.TextEdit();
            this.lblTableName = new DevExpress.XtraEditors.LabelControl();
            this.clbColumns = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.lblColumns = new DevExpress.XtraEditors.GroupControl();
            this.lblColumnNames = new DevExpress.XtraEditors.GroupControl();
            this.xscColumnNames = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcTableOptions)).BeginInit();
            this.gcTableOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTruncateTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceDropTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCreateTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTableName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblColumns)).BeginInit();
            this.lblColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblColumnNames)).BeginInit();
            this.lblColumnNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcTableOptions
            // 
            this.gcTableOptions.Controls.Add(this.btnUncheckAll);
            this.gcTableOptions.Controls.Add(this.meDescription);
            this.gcTableOptions.Controls.Add(this.btnCheckAll);
            this.gcTableOptions.Controls.Add(this.ceTruncateTable);
            this.gcTableOptions.Controls.Add(this.ceDropTable);
            this.gcTableOptions.Controls.Add(this.ceCreateTable);
            this.gcTableOptions.Controls.Add(this.btnExport);
            this.gcTableOptions.Controls.Add(this.teTableName);
            this.gcTableOptions.Controls.Add(this.lblTableName);
            this.gcTableOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTableOptions.Location = new System.Drawing.Point(420, 0);
            this.gcTableOptions.Name = "gcTableOptions";
            this.gcTableOptions.Size = new System.Drawing.Size(462, 353);
            this.gcTableOptions.TabIndex = 7;
            this.gcTableOptions.Text = "Table options";
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.AutoSize = true;
            this.btnUncheckAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUncheckAll.Location = new System.Drawing.Point(2, 150);
            this.btnUncheckAll.Margin = new System.Windows.Forms.Padding(10);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(458, 27);
            this.btnUncheckAll.TabIndex = 10;
            this.btnUncheckAll.Text = "Uncheck all columns";
            this.btnUncheckAll.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // meDescription
            // 
            this.meDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.meDescription.EditValue = resources.GetString("meDescription.EditValue");
            this.meDescription.Location = new System.Drawing.Point(2, 238);
            this.meDescription.Name = "meDescription";
            this.meDescription.Properties.ReadOnly = true;
            this.meDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.meDescription.Size = new System.Drawing.Size(458, 86);
            this.meDescription.TabIndex = 9;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.AutoSize = true;
            this.btnCheckAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckAll.Location = new System.Drawing.Point(2, 123);
            this.btnCheckAll.Margin = new System.Windows.Forms.Padding(10);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(458, 27);
            this.btnCheckAll.TabIndex = 9;
            this.btnCheckAll.Text = "Check all columns";
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // ceTruncateTable
            // 
            this.ceTruncateTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ceTruncateTable.Location = new System.Drawing.Point(2, 103);
            this.ceTruncateTable.Name = "ceTruncateTable";
            this.ceTruncateTable.Properties.Caption = "Truncate target table (TRUNCATE)";
            this.ceTruncateTable.Size = new System.Drawing.Size(458, 20);
            this.ceTruncateTable.TabIndex = 8;
            // 
            // ceDropTable
            // 
            this.ceDropTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ceDropTable.Enabled = false;
            this.ceDropTable.Location = new System.Drawing.Point(2, 83);
            this.ceDropTable.Name = "ceDropTable";
            this.ceDropTable.Properties.Caption = "Drop previous existing table (DROP TABLE)";
            this.ceDropTable.Size = new System.Drawing.Size(458, 20);
            this.ceDropTable.TabIndex = 7;
            // 
            // ceCreateTable
            // 
            this.ceCreateTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ceCreateTable.Location = new System.Drawing.Point(2, 63);
            this.ceCreateTable.Name = "ceCreateTable";
            this.ceCreateTable.Properties.Caption = "Include CREATE TABLE";
            this.ceCreateTable.Size = new System.Drawing.Size(458, 20);
            this.ceCreateTable.TabIndex = 6;
            this.ceCreateTable.CheckedChanged += new System.EventHandler(this.ceCreateTable_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExport.Location = new System.Drawing.Point(2, 324);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(458, 27);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export selected columns as insert query";
            this.btnExport.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // teTableName
            // 
            this.teTableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.teTableName.Location = new System.Drawing.Point(2, 41);
            this.teTableName.Name = "teTableName";
            this.teTableName.Size = new System.Drawing.Size(458, 22);
            this.teTableName.TabIndex = 2;
            // 
            // lblTableName
            // 
            this.lblTableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTableName.Location = new System.Drawing.Point(2, 25);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(68, 16);
            this.lblTableName.TabIndex = 5;
            this.lblTableName.Text = "Table name";
            // 
            // clbColumns
            // 
            this.clbColumns.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.clbColumns.Appearance.Options.UseFont = true;
            this.clbColumns.Cursor = System.Windows.Forms.Cursors.Default;
            this.clbColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbColumns.Location = new System.Drawing.Point(2, 25);
            this.clbColumns.Name = "clbColumns";
            this.clbColumns.Size = new System.Drawing.Size(206, 326);
            this.clbColumns.TabIndex = 8;
            this.clbColumns.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.clbColumns_ItemCheck);
            this.clbColumns.CheckMemberChanged += new System.EventHandler(this.clbColumns_CheckMemberChanged);
            this.clbColumns.EnabledChanged += new System.EventHandler(this.clbColumns_EnabledChanged);
            // 
            // lblColumns
            // 
            this.lblColumns.Controls.Add(this.clbColumns);
            this.lblColumns.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblColumns.Location = new System.Drawing.Point(0, 0);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(210, 353);
            this.lblColumns.TabIndex = 9;
            this.lblColumns.Text = "Columns";
            // 
            // lblColumnNames
            // 
            this.lblColumnNames.Controls.Add(this.xscColumnNames);
            this.lblColumnNames.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblColumnNames.Location = new System.Drawing.Point(210, 0);
            this.lblColumnNames.Name = "lblColumnNames";
            this.lblColumnNames.Size = new System.Drawing.Size(210, 353);
            this.lblColumnNames.TabIndex = 10;
            this.lblColumnNames.Text = "Column names";
            // 
            // xscColumnNames
            // 
            this.xscColumnNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xscColumnNames.Location = new System.Drawing.Point(2, 25);
            this.xscColumnNames.Name = "xscColumnNames";
            this.xscColumnNames.Size = new System.Drawing.Size(206, 326);
            this.xscColumnNames.TabIndex = 0;
            // 
            // frmExportAsSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 353);
            this.Controls.Add(this.gcTableOptions);
            this.Controls.Add(this.lblColumnNames);
            this.Controls.Add(this.lblColumns);
            this.Name = "frmExportAsSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Table as SQL Query";
            this.Load += new System.EventHandler(this.frmExportAsSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcTableOptions)).EndInit();
            this.gcTableOptions.ResumeLayout(false);
            this.gcTableOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTruncateTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceDropTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCreateTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTableName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblColumns)).EndInit();
            this.lblColumns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblColumnNames)).EndInit();
            this.lblColumnNames.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.GroupControl gcTableOptions;
        internal DevExpress.XtraEditors.SimpleButton btnExport;
        internal DevExpress.XtraEditors.TextEdit teTableName;
        internal DevExpress.XtraEditors.CheckedListBoxControl clbColumns;
        internal DevExpress.XtraEditors.MemoEdit meDescription;
        internal DevExpress.XtraEditors.CheckEdit ceTruncateTable;
        internal DevExpress.XtraEditors.CheckEdit ceDropTable;
        internal DevExpress.XtraEditors.CheckEdit ceCreateTable;
        internal DevExpress.XtraEditors.LabelControl lblTableName;
        internal DevExpress.XtraEditors.GroupControl lblColumns;
        internal DevExpress.XtraEditors.GroupControl lblColumnNames;
        internal DevExpress.XtraEditors.XtraScrollableControl xscColumnNames;
        internal DevExpress.XtraEditors.SimpleButton btnUncheckAll;
        internal DevExpress.XtraEditors.SimpleButton btnCheckAll;
    }
}