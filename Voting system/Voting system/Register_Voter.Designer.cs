﻿
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
            this.button2 = new System.Windows.Forms.Button();
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
            this.Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.logo.BackgroundImage = global::Voting_system.Properties.Resources.election;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(2, 2);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 5, 3, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1197, 194);
            this.logo.TabIndex = 1;
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.Content.Controls.Add(this.button2);
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
            this.Content.Location = new System.Drawing.Point(2, 245);
            this.Content.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(946, 906);
            this.Content.TabIndex = 2;
            this.Content.Paint += new System.Windows.Forms.PaintEventHandler(this.Content_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 733);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 60);
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
            this.label2.Location = new System.Drawing.Point(58, 671);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 40);
            this.label2.TabIndex = 28;
            this.label2.Text = "Grama Niladhari Division";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gntxt
            // 
            this.gntxt.Location = new System.Drawing.Point(65, 723);
            this.gntxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gntxt.Name = "gntxt";
            this.gntxt.Size = new System.Drawing.Size(547, 26);
            this.gntxt.TabIndex = 27;
            this.gntxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(63, 563);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "Voter\'s Fingerprint ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(70, 615);
            this.idtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(547, 26);
            this.idtxt.TabIndex = 25;
            this.idtxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nictxt
            // 
            this.nictxt.Location = new System.Drawing.Point(69, 188);
            this.nictxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nictxt.MaxLength = 12;
            this.nictxt.Name = "nictxt";
            this.nictxt.Size = new System.Drawing.Size(547, 26);
            this.nictxt.TabIndex = 24;
            // 
            // tptxt
            // 
            this.tptxt.Location = new System.Drawing.Point(69, 509);
            this.tptxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tptxt.Name = "tptxt";
            this.tptxt.Size = new System.Drawing.Size(547, 26);
            this.tptxt.TabIndex = 23;
            // 
            // Tele
            // 
            this.Tele.AutoSize = true;
            this.Tele.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tele.Location = new System.Drawing.Point(63, 452);
            this.Tele.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tele.Name = "Tele";
            this.Tele.Size = new System.Drawing.Size(194, 40);
            this.Tele.TabIndex = 22;
            this.Tele.Text = "Telephone No";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 294);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(62, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date Of Birth";
            // 
            // Party
            // 
            this.Party.AutoSize = true;
            this.Party.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Party.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Party.Location = new System.Drawing.Point(58, 125);
            this.Party.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Party.Name = "Party";
            this.Party.Size = new System.Drawing.Size(415, 40);
            this.Party.TabIndex = 6;
            this.Party.Text = "National Idemtity Card number";
            // 
            // CDmName
            // 
            this.CDmName.AutoSize = true;
            this.CDmName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDmName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CDmName.Location = new System.Drawing.Point(62, 17);
            this.CDmName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CDmName.Name = "CDmName";
            this.CDmName.Size = new System.Drawing.Size(250, 40);
            this.CDmName.TabIndex = 2;
            this.CDmName.Text = "Full name of Voter";
            // 
            // VTRname
            // 
            this.VTRname.Location = new System.Drawing.Point(69, 69);
            this.VTRname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VTRname.Name = "VTRname";
            this.VTRname.Size = new System.Drawing.Size(547, 26);
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
            this.Submitbtn.Location = new System.Drawing.Point(1059, 1103);
            this.Submitbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(140, 48);
            this.Submitbtn.TabIndex = 13;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Register_Voter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1200, 1050);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register_Voter";
            this.Text = "Register_Voter";
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private System.Windows.Forms.Button button2;
    }
}