namespace Uifs_Green
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.credentialsgbx = new System.Windows.Forms.GroupBox();
            this.registerlinklbl = new System.Windows.Forms.LinkLabel();
            this.passErrorlbl = new System.Windows.Forms.Label();
            this.usernameErrorlbl = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.savepasschkbx = new System.Windows.Forms.CheckBox();
            this.passtxb = new System.Windows.Forms.TextBox();
            this.userNametxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNamelbl = new System.Windows.Forms.Label();
            this.loginStatusBar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.registergbx = new System.Windows.Forms.GroupBox();
            this.repassErrorlbl = new System.Windows.Forms.Label();
            this.repasswdtxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailErrorlbl = new System.Windows.Forms.Label();
            this.emailtxb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.regCanelbtn = new System.Windows.Forms.Button();
            this.regpassErrorlbl = new System.Windows.Forms.Label();
            this.registerbtn = new System.Windows.Forms.Button();
            this.regnameErrorlbl = new System.Windows.Forms.Label();
            this.registerpasstxb = new System.Windows.Forms.TextBox();
            this.registerusernametxb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lastnameErrolbl = new System.Windows.Forms.Label();
            this.firstnametbx = new System.Windows.Forms.TextBox();
            this.firstnameErrlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastnametxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.credentialsgbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            this.registergbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // credentialsgbx
            // 
            this.credentialsgbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.credentialsgbx, "credentialsgbx");
            this.credentialsgbx.Controls.Add(this.registerlinklbl);
            this.credentialsgbx.Controls.Add(this.passErrorlbl);
            this.credentialsgbx.Controls.Add(this.usernameErrorlbl);
            this.credentialsgbx.Controls.Add(this.cancelbtn);
            this.credentialsgbx.Controls.Add(this.loginbtn);
            this.credentialsgbx.Controls.Add(this.savepasschkbx);
            this.credentialsgbx.Controls.Add(this.passtxb);
            this.credentialsgbx.Controls.Add(this.userNametxb);
            this.credentialsgbx.Controls.Add(this.label2);
            this.credentialsgbx.Controls.Add(this.userNamelbl);
            this.credentialsgbx.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.credentialsgbx.Name = "credentialsgbx";
            this.credentialsgbx.TabStop = false;
            // 
            // registerlinklbl
            // 
            resources.ApplyResources(this.registerlinklbl, "registerlinklbl");
            this.registerlinklbl.Name = "registerlinklbl";
            this.registerlinklbl.TabStop = true;
            this.registerlinklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // passErrorlbl
            // 
            resources.ApplyResources(this.passErrorlbl, "passErrorlbl");
            this.passErrorlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.passErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.passErrorlbl.Name = "passErrorlbl";
            // 
            // usernameErrorlbl
            // 
            resources.ApplyResources(this.usernameErrorlbl, "usernameErrorlbl");
            this.usernameErrorlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.usernameErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.usernameErrorlbl.Name = "usernameErrorlbl";
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelbtn, "cancelbtn");
            this.cancelbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.loginbtn, "loginbtn");
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // savepasschkbx
            // 
            resources.ApplyResources(this.savepasschkbx, "savepasschkbx");
            this.savepasschkbx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savepasschkbx.Name = "savepasschkbx";
            this.savepasschkbx.UseVisualStyleBackColor = true;
            // 
            // passtxb
            // 
            resources.ApplyResources(this.passtxb, "passtxb");
            this.passtxb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.passtxb.Name = "passtxb";
            // 
            // userNametxb
            // 
            resources.ApplyResources(this.userNametxb, "userNametxb");
            this.userNametxb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.userNametxb.Name = "userNametxb";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Name = "label2";
            // 
            // userNamelbl
            // 
            resources.ApplyResources(this.userNamelbl, "userNamelbl");
            this.userNamelbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.userNamelbl.Name = "userNamelbl";
            // 
            // loginStatusBar
            // 
            resources.ApplyResources(this.loginStatusBar, "loginStatusBar");
            this.loginStatusBar.Name = "loginStatusBar";
            this.loginStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel2});
            this.loginStatusBar.ShowPanels = true;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            resources.ApplyResources(this.statusBarPanel2, "statusBarPanel2");
            // 
            // registergbx
            // 
            this.registergbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.registergbx.Controls.Add(this.repassErrorlbl);
            this.registergbx.Controls.Add(this.repasswdtxb);
            this.registergbx.Controls.Add(this.label3);
            this.registergbx.Controls.Add(this.emailErrorlbl);
            this.registergbx.Controls.Add(this.emailtxb);
            this.registergbx.Controls.Add(this.label10);
            this.registergbx.Controls.Add(this.regCanelbtn);
            this.registergbx.Controls.Add(this.regpassErrorlbl);
            this.registergbx.Controls.Add(this.registerbtn);
            this.registergbx.Controls.Add(this.regnameErrorlbl);
            this.registergbx.Controls.Add(this.registerpasstxb);
            this.registergbx.Controls.Add(this.registerusernametxb);
            this.registergbx.Controls.Add(this.label8);
            this.registergbx.Controls.Add(this.label9);
            this.registergbx.Controls.Add(this.lastnameErrolbl);
            this.registergbx.Controls.Add(this.firstnametbx);
            this.registergbx.Controls.Add(this.firstnameErrlbl);
            this.registergbx.Controls.Add(this.label5);
            this.registergbx.Controls.Add(this.lastnametxb);
            this.registergbx.Controls.Add(this.label4);
            resources.ApplyResources(this.registergbx, "registergbx");
            this.registergbx.Name = "registergbx";
            this.registergbx.TabStop = false;
            // 
            // repassErrorlbl
            // 
            resources.ApplyResources(this.repassErrorlbl, "repassErrorlbl");
            this.repassErrorlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.repassErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.repassErrorlbl.Name = "repassErrorlbl";
            // 
            // repasswdtxb
            // 
            resources.ApplyResources(this.repasswdtxb, "repasswdtxb");
            this.repasswdtxb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.repasswdtxb.Name = "repasswdtxb";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Name = "label3";
            // 
            // emailErrorlbl
            // 
            resources.ApplyResources(this.emailErrorlbl, "emailErrorlbl");
            this.emailErrorlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.emailErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.emailErrorlbl.Name = "emailErrorlbl";
            // 
            // emailtxb
            // 
            resources.ApplyResources(this.emailtxb, "emailtxb");
            this.emailtxb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.emailtxb.Name = "emailtxb";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Name = "label10";
            // 
            // regCanelbtn
            // 
            this.regCanelbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.regCanelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.regCanelbtn, "regCanelbtn");
            this.regCanelbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regCanelbtn.Name = "regCanelbtn";
            this.regCanelbtn.UseVisualStyleBackColor = false;
            this.regCanelbtn.Click += new System.EventHandler(this.regCanelbtn_Click);
            // 
            // regpassErrorlbl
            // 
            resources.ApplyResources(this.regpassErrorlbl, "regpassErrorlbl");
            this.regpassErrorlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.regpassErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.regpassErrorlbl.Name = "regpassErrorlbl";
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.registerbtn, "registerbtn");
            this.registerbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // regnameErrorlbl
            // 
            resources.ApplyResources(this.regnameErrorlbl, "regnameErrorlbl");
            this.regnameErrorlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.regnameErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.regnameErrorlbl.Name = "regnameErrorlbl";
            // 
            // registerpasstxb
            // 
            resources.ApplyResources(this.registerpasstxb, "registerpasstxb");
            this.registerpasstxb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerpasstxb.Name = "registerpasstxb";
            // 
            // registerusernametxb
            // 
            resources.ApplyResources(this.registerusernametxb, "registerusernametxb");
            this.registerusernametxb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerusernametxb.Name = "registerusernametxb";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Name = "label9";
            // 
            // lastnameErrolbl
            // 
            resources.ApplyResources(this.lastnameErrolbl, "lastnameErrolbl");
            this.lastnameErrolbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lastnameErrolbl.ForeColor = System.Drawing.Color.Red;
            this.lastnameErrolbl.Name = "lastnameErrolbl";
            // 
            // firstnametbx
            // 
            resources.ApplyResources(this.firstnametbx, "firstnametbx");
            this.firstnametbx.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.firstnametbx.Name = "firstnametbx";
            // 
            // firstnameErrlbl
            // 
            resources.ApplyResources(this.firstnameErrlbl, "firstnameErrlbl");
            this.firstnameErrlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.firstnameErrlbl.ForeColor = System.Drawing.Color.Red;
            this.firstnameErrlbl.Name = "firstnameErrlbl";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Name = "label5";
            // 
            // lastnametxb
            // 
            resources.ApplyResources(this.lastnametxb, "lastnametxb");
            this.lastnametxb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lastnametxb.Name = "lastnametxb";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Name = "label4";
            // 
            // StartForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancelbtn;
            this.Controls.Add(this.registergbx);
            this.Controls.Add(this.loginStatusBar);
            this.Controls.Add(this.credentialsgbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.credentialsgbx.ResumeLayout(false);
            this.credentialsgbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.registergbx.ResumeLayout(false);
            this.registergbx.PerformLayout();
            this.ResumeLayout(false);

        }

        //public string UserName
        //{
        //    get { return this.userNametxb.Text; }
        //}

        #endregion

        
        private System.Windows.Forms.GroupBox credentialsgbx;
        private System.Windows.Forms.TextBox passtxb;
        private System.Windows.Forms.TextBox userNametxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userNamelbl;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.CheckBox savepasschkbx;
        private System.Windows.Forms.Label passErrorlbl;
        private System.Windows.Forms.Label usernameErrorlbl;
        private System.Windows.Forms.LinkLabel registerlinklbl;
        private System.Windows.Forms.StatusBar loginStatusBar;
        private System.Windows.Forms.StatusBarPanel statusBarPanel2;
        private System.Windows.Forms.GroupBox registergbx;
        private System.Windows.Forms.Label emailErrorlbl;
        private System.Windows.Forms.TextBox emailtxb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button regCanelbtn;
        private System.Windows.Forms.Label regpassErrorlbl;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label regnameErrorlbl;
        private System.Windows.Forms.TextBox registerpasstxb;
        private System.Windows.Forms.TextBox registerusernametxb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lastnameErrolbl;
        private System.Windows.Forms.TextBox firstnametbx;
        private System.Windows.Forms.Label firstnameErrlbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastnametxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label repassErrorlbl;
        private System.Windows.Forms.TextBox repasswdtxb;
        private System.Windows.Forms.Label label3;


        
    }
}

