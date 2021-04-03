namespace KOTableEditor.Interface
{
    partial class frmFindAndReplace
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
            this.teFindValue = new DevExpress.XtraEditors.TextEdit();
            this.lblFindWhat = new DevExpress.XtraEditors.LabelControl();
            this.lblReplaceWith = new DevExpress.XtraEditors.LabelControl();
            this.teReplaceValue = new DevExpress.XtraEditors.TextEdit();
            this.cbCaseSensitive = new DevExpress.XtraEditors.CheckEdit();
            this.btnRepNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnRepAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cbMatchWhole = new DevExpress.XtraEditors.CheckEdit();
            this.bgwFindNext = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.teFindValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teReplaceValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCaseSensitive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMatchWhole.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teFindValue
            // 
            this.teFindValue.Location = new System.Drawing.Point(13, 36);
            this.teFindValue.Name = "teFindValue";
            this.teFindValue.Size = new System.Drawing.Size(340, 22);
            this.teFindValue.TabIndex = 0;
            // 
            // lblFindWhat
            // 
            this.lblFindWhat.Location = new System.Drawing.Point(13, 14);
            this.lblFindWhat.Name = "lblFindWhat";
            this.lblFindWhat.Size = new System.Drawing.Size(61, 16);
            this.lblFindWhat.TabIndex = 1;
            this.lblFindWhat.Text = "Find what:";
            // 
            // lblReplaceWith
            // 
            this.lblReplaceWith.Location = new System.Drawing.Point(13, 57);
            this.lblReplaceWith.Name = "lblReplaceWith";
            this.lblReplaceWith.Size = new System.Drawing.Size(78, 16);
            this.lblReplaceWith.TabIndex = 3;
            this.lblReplaceWith.Text = "Replace with:";
            // 
            // teReplaceValue
            // 
            this.teReplaceValue.Location = new System.Drawing.Point(13, 79);
            this.teReplaceValue.Name = "teReplaceValue";
            this.teReplaceValue.Size = new System.Drawing.Size(340, 22);
            this.teReplaceValue.TabIndex = 2;
            // 
            // cbCaseSensitive
            // 
            this.cbCaseSensitive.Location = new System.Drawing.Point(12, 113);
            this.cbCaseSensitive.Name = "cbCaseSensitive";
            this.cbCaseSensitive.Properties.Caption = "Case sensitive";
            this.cbCaseSensitive.Size = new System.Drawing.Size(155, 20);
            this.cbCaseSensitive.TabIndex = 4;
            // 
            // btnRepNext
            // 
            this.btnRepNext.Location = new System.Drawing.Point(391, 34);
            this.btnRepNext.Name = "btnRepNext";
            this.btnRepNext.Size = new System.Drawing.Size(164, 23);
            this.btnRepNext.TabIndex = 5;
            this.btnRepNext.Text = "Replace next";
            this.btnRepNext.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnRepAll
            // 
            this.btnRepAll.Location = new System.Drawing.Point(391, 78);
            this.btnRepAll.Name = "btnRepAll";
            this.btnRepAll.Size = new System.Drawing.Size(164, 23);
            this.btnRepAll.TabIndex = 6;
            this.btnRepAll.Text = "Replace all";
            this.btnRepAll.Click += new System.EventHandler(this.btnRepAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(391, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbMatchWhole
            // 
            this.cbMatchWhole.Location = new System.Drawing.Point(198, 113);
            this.cbMatchWhole.Name = "cbMatchWhole";
            this.cbMatchWhole.Properties.Caption = "Match whole";
            this.cbMatchWhole.Size = new System.Drawing.Size(155, 20);
            this.cbMatchWhole.TabIndex = 8;
            // 
            // bgwFindNext
            // 
            this.bgwFindNext.WorkerSupportsCancellation = true;
            this.bgwFindNext.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFindNext_DoWork);
            // 
            // frmFindAndReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 159);
            this.Controls.Add(this.cbMatchWhole);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRepAll);
            this.Controls.Add(this.btnRepNext);
            this.Controls.Add(this.cbCaseSensitive);
            this.Controls.Add(this.lblReplaceWith);
            this.Controls.Add(this.teReplaceValue);
            this.Controls.Add(this.lblFindWhat);
            this.Controls.Add(this.teFindValue);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.Name = "frmFindAndReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find and Replace";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmFindAndReplace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teFindValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teReplaceValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCaseSensitive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMatchWhole.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.TextEdit teFindValue;
        internal DevExpress.XtraEditors.LabelControl lblFindWhat;
        internal DevExpress.XtraEditors.LabelControl lblReplaceWith;
        internal DevExpress.XtraEditors.TextEdit teReplaceValue;
        internal DevExpress.XtraEditors.CheckEdit cbCaseSensitive;
        internal DevExpress.XtraEditors.SimpleButton btnRepNext;
        internal DevExpress.XtraEditors.SimpleButton btnRepAll;
        internal DevExpress.XtraEditors.SimpleButton btnCancel;
        internal DevExpress.XtraEditors.CheckEdit cbMatchWhole;
        internal System.ComponentModel.BackgroundWorker bgwFindNext;
    }
}