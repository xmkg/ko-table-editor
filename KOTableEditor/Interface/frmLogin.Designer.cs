namespace KOTableEditor.Interface
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.linkForgottenPass = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.linkNewMember = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teUsername = new DevExpress.XtraEditors.TextEdit();
            this.ceKeepLoggedIn = new DevExpress.XtraEditors.CheckEdit();
            this.ceRememberMe = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnDebug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceKeepLoggedIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRememberMe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::KOTableEditor.Properties.Resources.Psd1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.linkForgottenPass);
            this.groupControl1.Controls.Add(this.linkNewMember);
            this.groupControl1.Controls.Add(this.btnLogin);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.tePassword);
            this.groupControl1.Controls.Add(this.teUsername);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 98);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(465, 131);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Kullanıcı bilgileri / Credentials";
            // 
            // linkForgottenPass
            // 
            this.linkForgottenPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkForgottenPass.Location = new System.Drawing.Point(252, 98);
            this.linkForgottenPass.Name = "linkForgottenPass";
            this.linkForgottenPass.Size = new System.Drawing.Size(201, 16);
            this.linkForgottenPass.TabIndex = 7;
            this.linkForgottenPass.Text = "<href=https://www.kodevelopers.com/login.php?do=lostpw>Şifremi unuttum / Forgot p" +
    "assword</href>\r\n";
            this.linkForgottenPass.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.linkForgottenPass_HyperlinkClick);
            // 
            // linkNewMember
            // 
            this.linkNewMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkNewMember.Location = new System.Drawing.Point(12, 98);
            this.linkNewMember.Name = "linkNewMember";
            this.linkNewMember.Size = new System.Drawing.Size(224, 16);
            this.linkNewMember.TabIndex = 6;
            this.linkNewMember.Text = "<href=https://www.kodevelopers.com/register.php>Şimdi üyelik oluşturun / Create a" +
    "ccount</href>";
            this.linkNewMember.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.linkNewMember_HyperlinkClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(371, 38);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 51);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş / Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Parola / Pass";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Kullanıcı / User";
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(104, 67);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Size = new System.Drawing.Size(261, 22);
            this.tePassword.TabIndex = 1;
            // 
            // teUsername
            // 
            this.teUsername.Location = new System.Drawing.Point(104, 39);
            this.teUsername.Name = "teUsername";
            this.teUsername.Size = new System.Drawing.Size(261, 22);
            this.teUsername.TabIndex = 0;
            // 
            // ceKeepLoggedIn
            // 
            this.ceKeepLoggedIn.Location = new System.Drawing.Point(12, 232);
            this.ceKeepLoggedIn.Name = "ceKeepLoggedIn";
            this.ceKeepLoggedIn.Properties.Caption = "Oturumu açık tut / Keep logged in";
            this.ceKeepLoggedIn.Size = new System.Drawing.Size(215, 20);
            this.ceKeepLoggedIn.TabIndex = 4;
            // 
            // ceRememberMe
            // 
            this.ceRememberMe.Location = new System.Drawing.Point(260, 232);
            this.ceRememberMe.Name = "ceRememberMe";
            this.ceRememberMe.Properties.Caption = "Beni hatırla / Remember me";
            this.ceRememberMe.Size = new System.Drawing.Size(200, 20);
            this.ceRememberMe.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(0, 261);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(465, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "KOTableEditor | PENTAGRAM , 2017";
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(371, 254);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 23);
            this.btnDebug.TabIndex = 7;
            this.btnDebug.Text = "dbg";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 277);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ceRememberMe);
            this.Controls.Add(this.ceKeepLoggedIn);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KODevelopers Forum Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceKeepLoggedIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRememberMe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkForgottenPass;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkNewMember;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teUsername;
        private DevExpress.XtraEditors.CheckEdit ceKeepLoggedIn;
        private DevExpress.XtraEditors.CheckEdit ceRememberMe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btnDebug;
    }
}