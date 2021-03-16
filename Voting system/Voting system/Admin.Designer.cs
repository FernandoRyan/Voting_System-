
namespace Voting_system
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.Cntpanel = new System.Windows.Forms.Panel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.lgAdmin = new System.Windows.Forms.PictureBox();
            this.PWD = new System.Windows.Forms.TextBox();
            this.uName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.Cntpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.Cntpanel);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 569);
            this.panel1.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.logo.BackgroundImage = global::Voting_system.Properties.Resources.election;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(29, 4);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 4, 3, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1020, 129);
            this.logo.TabIndex = 3;
            // 
            // Cntpanel
            // 
            this.Cntpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cntpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.Cntpanel.Controls.Add(this.LoginBtn);
            this.Cntpanel.Controls.Add(this.lgAdmin);
            this.Cntpanel.Controls.Add(this.PWD);
            this.Cntpanel.Controls.Add(this.uName);
            this.Cntpanel.Location = new System.Drawing.Point(29, 140);
            this.Cntpanel.Margin = new System.Windows.Forms.Padding(4);
            this.Cntpanel.Name = "Cntpanel";
            this.Cntpanel.Size = new System.Drawing.Size(1020, 398);
            this.Cntpanel.TabIndex = 2;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginBtn.Location = new System.Drawing.Point(392, 263);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(188, 52);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // lgAdmin
            // 
            this.lgAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lgAdmin.Image = global::Voting_system.Properties.Resources.Admin;
            this.lgAdmin.Location = new System.Drawing.Point(421, 39);
            this.lgAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.lgAdmin.Name = "lgAdmin";
            this.lgAdmin.Size = new System.Drawing.Size(133, 85);
            this.lgAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lgAdmin.TabIndex = 2;
            this.lgAdmin.TabStop = false;
            // 
            // PWD
            // 
            this.PWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PWD.Location = new System.Drawing.Point(321, 220);
            this.PWD.Margin = new System.Windows.Forms.Padding(4);
            this.PWD.Name = "PWD";
            this.PWD.PasswordChar = '*';
            this.PWD.Size = new System.Drawing.Size(328, 22);
            this.PWD.TabIndex = 1;
            this.PWD.Text = "Password";
            this.PWD.Enter += new System.EventHandler(this.txtPassEnter);
            this.PWD.Leave += new System.EventHandler(this.txtPassLeave);
            // 
            // uName
            // 
            this.uName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uName.Location = new System.Drawing.Point(321, 177);
            this.uName.Margin = new System.Windows.Forms.Padding(4);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(328, 22);
            this.uName.TabIndex = 0;
            this.uName.Text = "Username";
            this.uName.TextChanged += new System.EventHandler(this.uName_TextChanged);
            this.uName.Leave += new System.EventHandler(this.txtUserLeave);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.Cntpanel.ResumeLayout(false);
            this.Cntpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Cntpanel;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.PictureBox lgAdmin;
        private System.Windows.Forms.TextBox PWD;
        private System.Windows.Forms.TextBox uName;
        private System.Windows.Forms.Panel logo;
    }
}

