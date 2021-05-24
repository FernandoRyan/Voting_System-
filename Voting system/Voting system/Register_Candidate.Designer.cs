
namespace Voting_system
{
    partial class Register_Candidate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Candidate));
            this.Content = new System.Windows.Forms.Panel();
            this.cdadd = new System.Windows.Forms.TextBox();
            this.NIC = new System.Windows.Forms.Label();
            this.cdno = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.cdmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CDmName = new System.Windows.Forms.Label();
            this.cdnic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Submitbtn = new FontAwesome.Sharp.IconButton();
            this.logo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Signoutbtn = new FontAwesome.Sharp.IconButton();
            this.Reportbtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cdparty = new System.Windows.Forms.TextBox();
            this.cddob = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cdname = new System.Windows.Forms.TextBox();
            this.Content.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.Content.Controls.Add(this.cdname);
            this.Content.Controls.Add(this.label5);
            this.Content.Controls.Add(this.label3);
            this.Content.Controls.Add(this.label2);
            this.Content.Controls.Add(this.cddob);
            this.Content.Controls.Add(this.cdparty);
            this.Content.Controls.Add(this.cdadd);
            this.Content.Controls.Add(this.NIC);
            this.Content.Controls.Add(this.cdno);
            this.Content.Controls.Add(this.Address);
            this.Content.Controls.Add(this.cdmail);
            this.Content.Controls.Add(this.label4);
            this.Content.Controls.Add(this.CDmName);
            this.Content.Controls.Add(this.cdnic);
            this.Content.ForeColor = System.Drawing.Color.White;
            this.Content.Location = new System.Drawing.Point(218, 160);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(582, 482);
            this.Content.TabIndex = 1;
            this.Content.Paint += new System.Windows.Forms.PaintEventHandler(this.Content_Paint);
            // 
            // cdadd
            // 
            this.cdadd.Location = new System.Drawing.Point(43, 299);
            this.cdadd.Name = "cdadd";
            this.cdadd.Size = new System.Drawing.Size(415, 20);
            this.cdadd.TabIndex = 14;
            // 
            // NIC
            // 
            this.NIC.AutoSize = true;
            this.NIC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIC.ForeColor = System.Drawing.Color.White;
            this.NIC.Location = new System.Drawing.Point(41, 17);
            this.NIC.Name = "NIC";
            this.NIC.Size = new System.Drawing.Size(134, 25);
            this.NIC.TabIndex = 13;
            this.NIC.Text = "Candidate NIC";
            // 
            // cdno
            // 
            this.cdno.Location = new System.Drawing.Point(43, 238);
            this.cdno.Name = "cdno";
            this.cdno.Size = new System.Drawing.Size(237, 20);
            this.cdno.TabIndex = 12;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.White;
            this.Address.Location = new System.Drawing.Point(41, 271);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(170, 25);
            this.Address.TabIndex = 11;
            this.Address.Text = "Candidate Address";
            // 
            // cdmail
            // 
            this.cdmail.Location = new System.Drawing.Point(42, 435);
            this.cdmail.Name = "cdmail";
            this.cdmail.Size = new System.Drawing.Size(416, 20);
            this.cdmail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Candidate No ";
            // 
            // CDmName
            // 
            this.CDmName.AutoSize = true;
            this.CDmName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDmName.ForeColor = System.Drawing.Color.White;
            this.CDmName.Location = new System.Drawing.Point(41, 77);
            this.CDmName.Name = "CDmName";
            this.CDmName.Size = new System.Drawing.Size(207, 25);
            this.CDmName.TabIndex = 2;
            this.CDmName.Text = "Full name of Candidate";
            // 
            // cdnic
            // 
            this.cdnic.Location = new System.Drawing.Point(43, 44);
            this.cdnic.Name = "cdnic";
            this.cdnic.Size = new System.Drawing.Size(237, 20);
            this.cdnic.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(334, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Application of Registration for Candidates";
            // 
            // Submitbtn
            // 
            this.Submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Submitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(200)))), ((int)(((byte)(221)))));
            this.Submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submitbtn.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.Submitbtn.IconColor = System.Drawing.Color.Black;
            this.Submitbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Submitbtn.IconSize = 22;
            this.Submitbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Submitbtn.Location = new System.Drawing.Point(695, 652);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(93, 31);
            this.Submitbtn.TabIndex = 12;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.logo.BackgroundImage = global::Voting_system.Properties.Resources.election;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(218, 3);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(571, 126);
            this.logo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 634);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(2, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 285);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Signoutbtn);
            this.panel5.Controls.Add(this.Reportbtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 294);
            this.panel5.TabIndex = 24;
            // 
            // Signoutbtn
            // 
            this.Signoutbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Signoutbtn.FlatAppearance.BorderSize = 0;
            this.Signoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signoutbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Signoutbtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Signoutbtn.IconColor = System.Drawing.Color.Gainsboro;
            this.Signoutbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Signoutbtn.IconSize = 33;
            this.Signoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Signoutbtn.Location = new System.Drawing.Point(0, 60);
            this.Signoutbtn.Name = "Signoutbtn";
            this.Signoutbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Signoutbtn.Size = new System.Drawing.Size(197, 60);
            this.Signoutbtn.TabIndex = 22;
            this.Signoutbtn.Text = "Log out";
            this.Signoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Signoutbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Signoutbtn.UseVisualStyleBackColor = true;
            this.Signoutbtn.Click += new System.EventHandler(this.Signoutbtn_Click);
            // 
            // Reportbtn
            // 
            this.Reportbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reportbtn.FlatAppearance.BorderSize = 0;
            this.Reportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reportbtn.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.Reportbtn.IconColor = System.Drawing.Color.Gainsboro;
            this.Reportbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reportbtn.IconSize = 33;
            this.Reportbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportbtn.Location = new System.Drawing.Point(0, 0);
            this.Reportbtn.Name = "Reportbtn";
            this.Reportbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Reportbtn.Size = new System.Drawing.Size(197, 60);
            this.Reportbtn.TabIndex = 21;
            this.Reportbtn.Text = "Register Candidate";
            this.Reportbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reportbtn.UseVisualStyleBackColor = true;
            this.Reportbtn.Click += new System.EventHandler(this.Reportbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(8, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 95);
            this.panel1.TabIndex = 1;
            // 
            // cdparty
            // 
            this.cdparty.Location = new System.Drawing.Point(42, 366);
            this.cdparty.Name = "cdparty";
            this.cdparty.Size = new System.Drawing.Size(416, 20);
            this.cdparty.TabIndex = 15;
            // 
            // cddob
            // 
            this.cddob.Location = new System.Drawing.Point(43, 171);
            this.cddob.Name = "cddob";
            this.cddob.Size = new System.Drawing.Size(237, 20);
            this.cddob.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Date Of Brith";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Party Affiliation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "E-mail";
            // 
            // cdname
            // 
            this.cdname.Location = new System.Drawing.Point(42, 102);
            this.cdname.Name = "cdname";
            this.cdname.Size = new System.Drawing.Size(510, 20);
            this.cdname.TabIndex = 21;
            // 
            // Register_Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register_Candidate";
            this.Text = "Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.TextBox cdmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label  CDmName;
        private System.Windows.Forms.TextBox cdnic;
        private FontAwesome.Sharp.IconButton Submitbtn;
        private System.Windows.Forms.TextBox cdadd;
        private System.Windows.Forms.Label NIC;
        private System.Windows.Forms.TextBox cdno;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton Signoutbtn;
        private FontAwesome.Sharp.IconButton Reportbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cdname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker cddob;
        private System.Windows.Forms.TextBox cdparty;
    }
}