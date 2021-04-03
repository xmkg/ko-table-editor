namespace KOTableEditor.Interface
{
    partial class frmColumnEditor
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
            this.clbColumns = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.btnRemoveChecked = new DevExpress.XtraEditors.SimpleButton();
            this.gcNewColumn = new DevExpress.XtraEditors.GroupControl();
            this.btnAddColumn = new DevExpress.XtraEditors.SimpleButton();
            this.lblDefaultValue = new DevExpress.XtraEditors.LabelControl();
            this.teColumnDefaultValue = new DevExpress.XtraEditors.TextEdit();
            this.lblDataType = new DevExpress.XtraEditors.LabelControl();
            this.cbColumnDataType_Add = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gcEditColumn = new DevExpress.XtraEditors.GroupControl();
            this.btnUpdateColumn = new DevExpress.XtraEditors.SimpleButton();
            this.lblChangeDataType = new DevExpress.XtraEditors.LabelControl();
            this.cbColumnDataType_Update = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.clbColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNewColumn)).BeginInit();
            this.gcNewColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teColumnDefaultValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbColumnDataType_Add.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEditColumn)).BeginInit();
            this.gcEditColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbColumnDataType_Update.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // clbColumns
            // 
            this.clbColumns.Cursor = System.Windows.Forms.Cursors.Default;
            this.clbColumns.Location = new System.Drawing.Point(12, 12);
            this.clbColumns.Name = "clbColumns";
            this.clbColumns.Size = new System.Drawing.Size(208, 227);
            this.clbColumns.TabIndex = 0;
            // 
            // btnRemoveChecked
            // 
            this.btnRemoveChecked.Location = new System.Drawing.Point(12, 245);
            this.btnRemoveChecked.Name = "btnRemoveChecked";
            this.btnRemoveChecked.Size = new System.Drawing.Size(208, 23);
            this.btnRemoveChecked.TabIndex = 1;
            this.btnRemoveChecked.Text = "Remove checked";
            this.btnRemoveChecked.Click += new System.EventHandler(this.btnRemoveChecked_Click);
            // 
            // gcNewColumn
            // 
            this.gcNewColumn.Controls.Add(this.btnAddColumn);
            this.gcNewColumn.Controls.Add(this.lblDefaultValue);
            this.gcNewColumn.Controls.Add(this.teColumnDefaultValue);
            this.gcNewColumn.Controls.Add(this.lblDataType);
            this.gcNewColumn.Controls.Add(this.cbColumnDataType_Add);
            this.gcNewColumn.Location = new System.Drawing.Point(226, 108);
            this.gcNewColumn.Name = "gcNewColumn";
            this.gcNewColumn.Size = new System.Drawing.Size(289, 160);
            this.gcNewColumn.TabIndex = 2;
            this.gcNewColumn.Text = "New Column";
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(14, 119);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(259, 23);
            this.btnAddColumn.TabIndex = 4;
            this.btnAddColumn.Text = "Add";
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // lblDefaultValue
            // 
            this.lblDefaultValue.Location = new System.Drawing.Point(14, 75);
            this.lblDefaultValue.Name = "lblDefaultValue";
            this.lblDefaultValue.Size = new System.Drawing.Size(87, 16);
            this.lblDefaultValue.TabIndex = 3;
            this.lblDefaultValue.Text = "Default value : ";
            // 
            // teColumnDefaultValue
            // 
            this.teColumnDefaultValue.Location = new System.Drawing.Point(129, 72);
            this.teColumnDefaultValue.Name = "teColumnDefaultValue";
            this.teColumnDefaultValue.Size = new System.Drawing.Size(144, 22);
            this.teColumnDefaultValue.TabIndex = 2;
            // 
            // lblDataType
            // 
            this.lblDataType.Location = new System.Drawing.Point(14, 34);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(67, 16);
            this.lblDataType.TabIndex = 1;
            this.lblDataType.Text = "Data type : ";
            // 
            // cbColumnDataType_Add
            // 
            this.cbColumnDataType_Add.Location = new System.Drawing.Point(129, 31);
            this.cbColumnDataType_Add.Name = "cbColumnDataType_Add";
            this.cbColumnDataType_Add.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbColumnDataType_Add.Size = new System.Drawing.Size(144, 22);
            this.cbColumnDataType_Add.TabIndex = 0;
            // 
            // gcEditColumn
            // 
            this.gcEditColumn.Controls.Add(this.btnUpdateColumn);
            this.gcEditColumn.Controls.Add(this.lblChangeDataType);
            this.gcEditColumn.Controls.Add(this.cbColumnDataType_Update);
            this.gcEditColumn.Location = new System.Drawing.Point(226, 12);
            this.gcEditColumn.Name = "gcEditColumn";
            this.gcEditColumn.Size = new System.Drawing.Size(289, 86);
            this.gcEditColumn.TabIndex = 3;
            this.gcEditColumn.Text = "Edit Column";
            // 
            // btnUpdateColumn
            // 
            this.btnUpdateColumn.Location = new System.Drawing.Point(18, 50);
            this.btnUpdateColumn.Name = "btnUpdateColumn";
            this.btnUpdateColumn.Size = new System.Drawing.Size(255, 23);
            this.btnUpdateColumn.TabIndex = 5;
            this.btnUpdateColumn.Text = "Update";
            this.btnUpdateColumn.Click += new System.EventHandler(this.btnUpdateColumn_Click);
            // 
            // lblChangeDataType
            // 
            this.lblChangeDataType.Location = new System.Drawing.Point(18, 25);
            this.lblChangeDataType.Name = "lblChangeDataType";
            this.lblChangeDataType.Size = new System.Drawing.Size(109, 16);
            this.lblChangeDataType.TabIndex = 6;
            this.lblChangeDataType.Text = "Change data type: ";
            // 
            // cbColumnDataType_Update
            // 
            this.cbColumnDataType_Update.Location = new System.Drawing.Point(133, 22);
            this.cbColumnDataType_Update.Name = "cbColumnDataType_Update";
            this.cbColumnDataType_Update.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbColumnDataType_Update.Size = new System.Drawing.Size(140, 22);
            this.cbColumnDataType_Update.TabIndex = 5;
            // 
            // frmColumnEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 273);
            this.Controls.Add(this.gcEditColumn);
            this.Controls.Add(this.gcNewColumn);
            this.Controls.Add(this.btnRemoveChecked);
            this.Controls.Add(this.clbColumns);
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.Name = "frmColumnEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editing columns of table (z)";
            this.Load += new System.EventHandler(this.frmColumnEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clbColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNewColumn)).EndInit();
            this.gcNewColumn.ResumeLayout(false);
            this.gcNewColumn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teColumnDefaultValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbColumnDataType_Add.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEditColumn)).EndInit();
            this.gcEditColumn.ResumeLayout(false);
            this.gcEditColumn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbColumnDataType_Update.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.CheckedListBoxControl clbColumns;
        internal DevExpress.XtraEditors.SimpleButton btnRemoveChecked;
        internal DevExpress.XtraEditors.GroupControl gcNewColumn;
        internal DevExpress.XtraEditors.SimpleButton btnAddColumn;
        internal DevExpress.XtraEditors.LabelControl lblDefaultValue;
        internal DevExpress.XtraEditors.TextEdit teColumnDefaultValue;
        internal DevExpress.XtraEditors.LabelControl lblDataType;
        internal DevExpress.XtraEditors.ComboBoxEdit cbColumnDataType_Add;
        internal DevExpress.XtraEditors.GroupControl gcEditColumn;
        internal DevExpress.XtraEditors.SimpleButton btnUpdateColumn;
        internal DevExpress.XtraEditors.LabelControl lblChangeDataType;
        internal DevExpress.XtraEditors.ComboBoxEdit cbColumnDataType_Update;
    }
}