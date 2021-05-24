
namespace Voting_system
{
    partial class Register_Voter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Voter));
            this.logo = new System.Windows.Forms.Panel();
            this.Content = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gntxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.nictxt = new System.Windows.Forms.TextBox();
            this.tptxt = new System.Windows.Forms.TextBox();
            this.Tele = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Party = new System.Windows.Forms.Label();
            this.CDmName = new System.Windows.Forms.Label();
            this.VTRname = new System.Windows.Forms.TextBox();
            this.Submitbtn = new FontAwesome.Sharp.IconButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Signoutbtn = new FontAwesome.Sharp.IconButton();
            this.Registerbtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.logo.BackgroundImage = global::Voting_system.Properties.Resources.election;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(208, 1);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(591, 126);
            this.logo.TabIndex = 1;
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.Content.Controls.Add(this.button1);
            this.Content.Controls.Add(this.label2);
            this.Content.Controls.Add(this.gntxt);
            this.Content.Controls.Add(this.label1);
            this.Content.Controls.Add(this.idtxt);
            this.Content.Controls.Add(this.nictxt);
            this.Content.Controls.Add(this.tptxt);
            this.Content.Controls.Add(this.Tele);
            this.Content.Controls.Add(this.dateTimePicker1);
            this.Content.Controls.Add(this.label4);
            this.Content.Controls.Add(this.Party);
            this.Content.Controls.Add(this.CDmName);
            this.Content.Controls.Add(this.VTRname);
            this.Content.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Content.Location = new System.Drawing.Point(205, 148);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(594, 589);
            this.Content.TabIndex = 2;
            this.Content.Paint += new System.Windows.Forms.PaintEventHandler(this.Content_Paint);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(168, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Grama Niladhari Division";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gntxt
            // 
            this.gntxt.Location = new System.Drawing.Point(43, 468);
            this.gntxt.Name = "gntxt";
            this.gntxt.Size = new System.Drawing.Size(366, 20);
            this.gntxt.TabIndex = 27;
            this.gntxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Voter\'s Fingerprint ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(43, 370);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(366, 20);
            this.idtxt.TabIndex = 25;
            this.idtxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nictxt
            // 
            this.nictxt.Location = new System.Drawing.Point(46, 129);
            this.nictxt.MaxLength = 12;
            this.nictxt.Name = "nictxt";
            this.nictxt.Size = new System.Drawing.Size(366, 20);
            this.nictxt.TabIndex = 24;
            // 
            // tptxt
            // 
            this.tptxt.Location = new System.Drawing.Point(46, 287);
            this.tptxt.Name = "tptxt";
            this.tptxt.Size = new System.Drawing.Size(366, 20);
            this.tptxt.TabIndex = 23;
            // 
            // Tele
            // 
            this.Tele.AutoSize = true;
            this.Tele.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tele.Location = new System.Drawing.Point(42, 242);
            this.Tele.Name = "Tele";
            this.Tele.Size = new System.Drawing.Size(129, 25);
            this.Tele.TabIndex = 22;
            this.Tele.Text = "Telephone No";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 198);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(41, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date Of Birth";
            // 
            // Party
            // 
            this.Party.AutoSize = true;
            this.Party.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Party.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Party.Location = new System.Drawing.Point(39, 81);
            this.Party.Name = "Party";
            this.Party.Size = new System.Drawing.Size(273, 25);
            this.Party.TabIndex = 6;
            this.Party.Text = "National Idemtity Card number";
            // 
            // CDmName
            // 
            this.CDmName.AutoSize = true;
            this.CDmName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDmName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CDmName.Location = new System.Drawing.Point(41, 11);
            this.CDmName.Name = "CDmName";
            this.CDmName.Size = new System.Drawing.Size(166, 25);
            this.CDmName.TabIndex = 2;
            this.CDmName.Text = "Full name of Voter";
            // 
            // VTRname
            // 
            this.VTRname.Location = new System.Drawing.Point(46, 53);
            this.VTRname.Name = "VTRname";
            this.VTRname.Size = new System.Drawing.Size(366, 20);
            this.VTRname.TabIndex = 0;
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
            this.Submitbtn.Location = new System.Drawing.Point(706, 979);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(93, 31);
            this.Submitbtn.TabIndex = 13;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 487);
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
            this.panel5.Controls.Add(this.Registerbtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 575);
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
            // 
            // Registerbtn
            // 
            this.Registerbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Registerbtn.FlatAppearance.BorderSize = 0;
            this.Registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registerbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Registerbtn.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.Registerbtn.IconColor = System.Drawing.Color.Gainsboro;
            this.Registerbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Registerbtn.IconSize = 33;
            this.Registerbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registerbtn.Location = new System.Drawing.Point(0, 0);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Registerbtn.Size = new System.Drawing.Size(197, 60);
            this.Registerbtn.TabIndex = 21;
            this.Registerbtn.Text = "Register voter";
            this.Registerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registerbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Registerbtn.UseVisualStyleBackColor = true;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 95);
            this.panel1.TabIndex = 1;
            // 
            // Register_Voter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register_Voter";
            this.Text = "Register_Voter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Party;
        private System.Windows.Forms.Label CDmName;
        private System.Windows.Forms.TextBox VTRname;
        private FontAwesome.Sharp.IconButton Submitbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox nictxt;
        private System.Windows.Forms.TextBox tptxt;
        private System.Windows.Forms.Label Tele;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gntxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton Signoutbtn;
        private FontAwesome.Sharp.IconButton Registerbtn;
        private System.Windows.Forms.Panel panel1;
    }
}