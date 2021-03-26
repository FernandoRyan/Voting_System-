
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NIC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.PartyAffilation = new System.Windows.Forms.ComboBox();
            this.CandidateNO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Party = new System.Windows.Forms.Label();
            this.CDmName = new System.Windows.Forms.Label();
            this.CDname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Submitbtn = new FontAwesome.Sharp.IconButton();
            this.logo = new System.Windows.Forms.Panel();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.Content.Controls.Add(this.textBox2);
            this.Content.Controls.Add(this.NIC);
            this.Content.Controls.Add(this.textBox1);
            this.Content.Controls.Add(this.Address);
            this.Content.Controls.Add(this.PartyAffilation);
            this.Content.Controls.Add(this.CandidateNO);
            this.Content.Controls.Add(this.label4);
            this.Content.Controls.Add(this.Party);
            this.Content.Controls.Add(this.CDmName);
            this.Content.Controls.Add(this.CDname);
            this.Content.ForeColor = System.Drawing.Color.White;
            this.Content.Location = new System.Drawing.Point(3, 265);
            this.Content.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(946, 555);
            this.Content.TabIndex = 1;
            this.Content.Paint += new System.Windows.Forms.PaintEventHandler(this.Content_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 482);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(548, 26);
            this.textBox2.TabIndex = 14;
            // 
            // NIC
            // 
            this.NIC.AutoSize = true;
            this.NIC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIC.ForeColor = System.Drawing.Color.White;
            this.NIC.Location = new System.Drawing.Point(62, 440);
            this.NIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NIC.Name = "NIC";
            this.NIC.Size = new System.Drawing.Size(203, 40);
            this.NIC.TabIndex = 13;
            this.NIC.Text = "Candidate NIC";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 386);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 26);
            this.textBox1.TabIndex = 12;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.White;
            this.Address.Location = new System.Drawing.Point(62, 329);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(257, 40);
            this.Address.TabIndex = 11;
            this.Address.Text = "Candidate Address";
            // 
            // PartyAffilation
            // 
            this.PartyAffilation.FormattingEnabled = true;
            this.PartyAffilation.Items.AddRange(new object[] {
            "Sri Lanka People\'s Freedom Alliance",
            "Samagi Jana Balawegaya",
            "Tamil National Alliance",
            "National People\'s Power",
            "Tamil National People\'s Front"});
            this.PartyAffilation.Location = new System.Drawing.Point(64, 162);
            this.PartyAffilation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PartyAffilation.Name = "PartyAffilation";
            this.PartyAffilation.Size = new System.Drawing.Size(548, 28);
            this.PartyAffilation.TabIndex = 10;
            // 
            // CandidateNO
            // 
            this.CandidateNO.Location = new System.Drawing.Point(64, 275);
            this.CandidateNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CandidateNO.Name = "CandidateNO";
            this.CandidateNO.Size = new System.Drawing.Size(548, 26);
            this.CandidateNO.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Candidate No ";
            // 
            // Party
            // 
            this.Party.AutoSize = true;
            this.Party.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Party.ForeColor = System.Drawing.Color.White;
            this.Party.Location = new System.Drawing.Point(62, 103);
            this.Party.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Party.Name = "Party";
            this.Party.Size = new System.Drawing.Size(212, 40);
            this.Party.TabIndex = 6;
            this.Party.Text = "Party Affiliation";
            // 
            // CDmName
            // 
            this.CDmName.AutoSize = true;
            this.CDmName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDmName.ForeColor = System.Drawing.Color.White;
            this.CDmName.Location = new System.Drawing.Point(62, 17);
            this.CDmName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CDmName.Name = "CDmName";
            this.CDmName.Size = new System.Drawing.Size(312, 40);
            this.CDmName.TabIndex = 2;
            this.CDmName.Text = "Full name of Candidate";
            // 
            // CDname
            // 
            this.CDname.Location = new System.Drawing.Point(64, 68);
            this.CDname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CDname.Name = "CDname";
            this.CDname.Size = new System.Drawing.Size(547, 26);
            this.CDname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(262, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 40);
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
            this.Submitbtn.Location = new System.Drawing.Point(1042, 772);
            this.Submitbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(140, 48);
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
            this.logo.Location = new System.Drawing.Point(3, 5);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 5, 3, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1197, 194);
            this.logo.TabIndex = 0;
            // 
            // Register_Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1200, 838);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register_Candidate";
            this.Text = "Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.TextBox CandidateNO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Party;
        private System.Windows.Forms.Label  CDmName;
        private System.Windows.Forms.TextBox CDname;
        private System.Windows.Forms.ComboBox PartyAffilation;
        private FontAwesome.Sharp.IconButton Submitbtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label NIC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label1;
    }
}