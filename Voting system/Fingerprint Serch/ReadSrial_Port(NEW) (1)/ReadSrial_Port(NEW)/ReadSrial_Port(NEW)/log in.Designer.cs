namespace ReadSrial_Port_NEW_
{
    partial class log_in
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.Controls.Add(this.Cntpanel);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 522);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.Cntpanel.Location = new System.Drawing.Point(33, 122);
            this.Cntpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cntpanel.Name = "Cntpanel";
            this.Cntpanel.Size = new System.Drawing.Size(693, 361);
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
            this.LoginBtn.Location = new System.Drawing.Point(213, 261);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(212, 65);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // lgAdmin
            // 
            this.lgAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lgAdmin.Location = new System.Drawing.Point(246, 49);
            this.lgAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lgAdmin.Name = "lgAdmin";
            this.lgAdmin.Size = new System.Drawing.Size(114, 86);
            this.lgAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lgAdmin.TabIndex = 2;
            this.lgAdmin.TabStop = false;
            // 
            // PWD
            // 
            this.PWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PWD.Location = new System.Drawing.Point(134, 207);
            this.PWD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PWD.Name = "PWD";
            this.PWD.PasswordChar = '*';
            this.PWD.Size = new System.Drawing.Size(368, 26);
            this.PWD.TabIndex = 1;
            this.PWD.Text = "Password";
            // 
            // uName
            // 
            this.uName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uName.Location = new System.Drawing.Point(134, 154);
            this.uName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(368, 26);
            this.uName.TabIndex = 0;
            this.uName.Text = "Username";
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.panel1);
            this.Name = "log_in";
            this.Text = "log_in";
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
    }
}