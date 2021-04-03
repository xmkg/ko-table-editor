namespace KOTableEditor.Interface
{
    partial class frmSaveAs
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
            this.cbEncryptionList = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblMethod = new DevExpress.XtraEditors.LabelControl();
            this.lblMethodDesc = new DevExpress.XtraEditors.LabelControl();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbEncryptionList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEncryptionList
            // 
            this.cbEncryptionList.Location = new System.Drawing.Point(139, 19);
            this.cbEncryptionList.Name = "cbEncryptionList";
            this.cbEncryptionList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEncryptionList.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbEncryptionList.Size = new System.Drawing.Size(265, 22);
            this.cbEncryptionList.TabIndex = 0;
            this.cbEncryptionList.SelectedIndexChanged += new System.EventHandler(this.cbEncryptionList_SelectedIndexChanged);
            // 
            // lblMethod
            // 
            this.lblMethod.Location = new System.Drawing.Point(12, 22);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(55, 16);
            this.lblMethod.TabIndex = 1;
            this.lblMethod.Text = "Method : ";
            // 
            // lblMethodDesc
            // 
            this.lblMethodDesc.Location = new System.Drawing.Point(12, 67);
            this.lblMethodDesc.Name = "lblMethodDesc";
            this.lblMethodDesc.Size = new System.Drawing.Size(108, 16);
            this.lblMethodDesc.TabIndex = 2;
            this.lblMethodDesc.Text = "Method description";
            // 
            // meDescription
            // 
            this.meDescription.Location = new System.Drawing.Point(12, 89);
            this.meDescription.Name = "meDescription";
            this.meDescription.Properties.ReadOnly = true;
            this.meDescription.Size = new System.Drawing.Size(392, 96);
            this.meDescription.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(392, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save as..";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSaveAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 224);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.meDescription);
            this.Controls.Add(this.lblMethodDesc);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.cbEncryptionList);
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.Name = "frmSaveAs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select the encryption method";
            this.Load += new System.EventHandler(this.frmEncryptionSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbEncryptionList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.ComboBoxEdit cbEncryptionList;
        internal DevExpress.XtraEditors.LabelControl lblMethod;
        internal DevExpress.XtraEditors.LabelControl lblMethodDesc;
        internal DevExpress.XtraEditors.MemoEdit meDescription;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
    }
}