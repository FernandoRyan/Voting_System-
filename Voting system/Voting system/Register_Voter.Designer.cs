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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Tele = new System.Windows.Forms.Label();
            this.Fingerprint1A = new System.Windows.Forms.PictureBox();
            this.Fingerprint2A = new System.Windows.Forms.PictureBox();
            this.Fingerprint2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Fingerprint1 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Party = new System.Windows.Forms.Label();
            this.CDmName = new System.Windows.Forms.Label();
            this.VTRname = new System.Windows.Forms.TextBox();
            this.Submitbtn = new FontAwesome.Sharp.IconButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fingerprint1A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fingerprint2A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.logo.BackgroundImage = global::Voting_system.Properties.Resources.election;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(1, 1);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(798, 126);
            this.logo.TabIndex = 1;
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.Content.Controls.Add(this.textBox2);
            this.Content.Controls.Add(this.textBox1);
            this.Content.Controls.Add(this.Tele);
            this.Content.Controls.Add(this.Fingerprint1A);
            this.Content.Controls.Add(this.Fingerprint2A);
            this.Content.Controls.Add(this.Fingerprint2);
            this.Content.Controls.Add(this.checkBox2);
            this.Content.Controls.Add(this.checkBox1);
            this.Content.Controls.Add(this.dateTimePicker1);
            this.Content.Controls.Add(this.Fingerprint1);
            this.Content.Controls.Add(this.Address);
            this.Content.Controls.Add(this.label4);
            this.Content.Controls.Add(this.Party);
            this.Content.Controls.Add(this.CDmName);
            this.Content.Controls.Add(this.VTRname);
            this.Content.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Content.Location = new System.Drawing.Point(1, 159);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(631, 589);
            this.Content.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(366, 20);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 20);
            this.textBox1.TabIndex = 23;
            // 
            // Tele
            // 
            this.Tele.AutoSize = true;
            this.Tele.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tele.Location = new System.Drawing.Point(42, 294);
            this.Tele.Name = "Tele";
            this.Tele.Size = new System.Drawing.Size(129, 25);
            this.Tele.TabIndex = 22;
            this.Tele.Text = "Telephone No";
            // 
            // Fingerprint1A
            // 
            this.Fingerprint1A.BackColor = System.Drawing.Color.Silver;
            this.Fingerprint1A.Location = new System.Drawing.Point(27, 453);
            this.Fingerprint1A.Name = "Fingerprint1A";
            this.Fingerprint1A.Size = new System.Drawing.Size(162, 102);
            this.Fingerprint1A.TabIndex = 21;
            this.Fingerprint1A.TabStop = false;
            // 
            // Fingerprint2A
            // 
            this.Fingerprint2A.BackColor = System.Drawing.Color.Silver;
            this.Fingerprint2A.Location = new System.Drawing.Point(231, 453);
            this.Fingerprint2A.Name = "Fingerprint2A";
            this.Fingerprint2A.Size = new System.Drawing.Size(162, 102);
            this.Fingerprint2A.TabIndex = 20;
            this.Fingerprint2A.TabStop = false;
            // 
            // Fingerprint2
            // 
            this.Fingerprint2.AutoSize = true;
            this.Fingerprint2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fingerprint2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fingerprint2.Location = new System.Drawing.Point(255, 408);
            this.Fingerprint2.Name = "Fingerprint2";
            this.Fingerprint2.Size = new System.Drawing.Size(100, 21);
            this.Fingerprint2.TabIndex = 18;
            this.Fingerprint2.Text = "Fignerprint 2";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox2.Location = new System.Drawing.Point(107, 251);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 24);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "No";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(46, 251);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Yes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // Fingerprint1
            // 
            this.Fingerprint1.AutoSize = true;
            this.Fingerprint1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fingerprint1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fingerprint1.Location = new System.Drawing.Point(40, 408);
            this.Fingerprint1.Name = "Fingerprint1";
            this.Fingerprint1.Size = new System.Drawing.Size(100, 21);
            this.Fingerprint1.TabIndex = 13;
            this.Fingerprint1.Text = "Fignerprint 1";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Address.Location = new System.Drawing.Point(39, 227);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(378, 25);
            this.Address.TabIndex = 11;
            this.Address.Text = "Please state if your are Citizen of Sri lanka ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(41, 156);
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
            this.VTRname.Location = new System.Drawing.Point(46, 45);
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
            this.Submitbtn.Location = new System.Drawing.Point(706, 717);
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
            // Register_Voter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register_Voter";
            this.Text = "Register_Voter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fingerprint1A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fingerprint2A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Label Fingerprint1;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Party;
        private System.Windows.Forms.Label CDmName;
        private System.Windows.Forms.TextBox VTRname;
        private FontAwesome.Sharp.IconButton Submitbtn;
        private System.Windows.Forms.Label Fingerprint2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Tele;
        private System.Windows.Forms.PictureBox Fingerprint1A;
        private System.Windows.Forms.PictureBox Fingerprint2A;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}