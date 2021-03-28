namespace Voting_system
{
    partial class addf
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addf));
            this.textBOX_Show_Read = new System.Windows.Forms.TextBox();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.BTN_Send = new System.Windows.Forms.Button();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ff = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Signoutbtn = new FontAwesome.Sharp.IconButton();
            this.Reportbtn = new FontAwesome.Sharp.IconButton();
            this.logo = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBOX_Show_Read
            // 
            this.textBOX_Show_Read.Location = new System.Drawing.Point(3, 85);
            this.textBOX_Show_Read.Multiline = true;
            this.textBOX_Show_Read.Name = "textBOX_Show_Read";
            this.textBOX_Show_Read.Size = new System.Drawing.Size(302, 219);
            this.textBOX_Show_Read.TabIndex = 0;
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(3, 30);
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(221, 20);
            this.textBox_Send.TabIndex = 1;
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(3, 56);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Port.TabIndex = 5;
            // 
            // BTN_Send
            // 
            this.BTN_Send.Location = new System.Drawing.Point(230, 30);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(75, 23);
            this.BTN_Send.TabIndex = 2;
            this.BTN_Send.Text = "Send";
            this.BTN_Send.UseVisualStyleBackColor = true;
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Location = new System.Drawing.Point(230, 56);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(75, 23);
            this.BTN_Stop.TabIndex = 4;
            this.BTN_Stop.Text = "Stop";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(149, 56);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(75, 23);
            this.BTN_Start.TabIndex = 3;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fingerprint Sonsor Controller";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.ff);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(539, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 324);
            this.panel2.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 101);
            this.button2.TabIndex = 33;
            this.button2.Text = "Countinue Registration";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ff
            // 
            this.ff.AutoSize = true;
            this.ff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ff.Location = new System.Drawing.Point(183, 7);
            this.ff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(0, 26);
            this.ff.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 42);
            this.button1.TabIndex = 31;
            this.button1.Text = "Refresh Fingerprint ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(25, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Voter\'s Fingerprint ID is:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBOX_Show_Read);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Send);
            this.panel1.Controls.Add(this.comboBox_Port);
            this.panel1.Controls.Add(this.BTN_Send);
            this.panel1.Controls.Add(this.BTN_Stop);
            this.panel1.Controls.Add(this.BTN_Start);
            this.panel1.Location = new System.Drawing.Point(213, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 324);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 44);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fingerprint Registration";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.logo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 421);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(2, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 285);
            this.panel4.TabIndex = 2;
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
            this.Reportbtn.Text = "Register Voter";
            this.Reportbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reportbtn.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(196, 95);
            this.logo.TabIndex = 1;
            // 
            // addf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(821, 421);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addf";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBOX_Show_Read;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.Button BTN_Send;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.Button BTN_Start;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton Signoutbtn;
        private FontAwesome.Sharp.IconButton Reportbtn;
        private System.Windows.Forms.Panel logo;
    }
}