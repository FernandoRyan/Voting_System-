namespace ReadSrial_Port_NEW_
{
    partial class varifi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(varifi));
            this.textBOX_Show_Read = new System.Windows.Forms.TextBox();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nictxt = new System.Windows.Forms.TextBox();
            this.Party = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBOX_Show_Read
            // 
            this.textBOX_Show_Read.Location = new System.Drawing.Point(3, 58);
            this.textBOX_Show_Read.Multiline = true;
            this.textBOX_Show_Read.Name = "textBOX_Show_Read";
            this.textBOX_Show_Read.Size = new System.Drawing.Size(302, 265);
            this.textBOX_Show_Read.TabIndex = 0;
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(148, 33);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(75, 23);
            this.BTN_Start.TabIndex = 3;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Location = new System.Drawing.Point(229, 33);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(75, 23);
            this.BTN_Stop.TabIndex = 4;
            this.BTN_Stop.Text = "Stop";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(1, 33);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Port.TabIndex = 5;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.textBOX_Show_Read);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_Port);
            this.panel1.Controls.Add(this.BTN_Stop);
            this.panel1.Controls.Add(this.BTN_Start);
            this.panel1.Location = new System.Drawing.Point(59, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 324);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.fid);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nictxt);
            this.panel2.Controls.Add(this.Party);
            this.panel2.Location = new System.Drawing.Point(393, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 324);
            this.panel2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 24);
            this.button2.TabIndex = 35;
            this.button2.Text = "QR Scanner";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(21, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Voter\'s NIC no is:";
            // 
            // fid
            // 
            this.fid.AutoSize = true;
            this.fid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fid.Location = new System.Drawing.Point(64, 158);
            this.fid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fid.Name = "fid";
            this.fid.Size = new System.Drawing.Size(0, 20);
            this.fid.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 27);
            this.button1.TabIndex = 31;
            this.button1.Text = "Find Finger Print ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Voter\'s Fingerprint ID is:";
            // 
            // nictxt
            // 
            this.nictxt.Location = new System.Drawing.Point(11, 36);
            this.nictxt.MaxLength = 12;
            this.nictxt.Name = "nictxt";
            this.nictxt.Size = new System.Drawing.Size(197, 20);
            this.nictxt.TabIndex = 28;
            this.nictxt.TextChanged += new System.EventHandler(this.nictxt_TextChanged);
            // 
            // Party
            // 
            this.Party.AutoSize = true;
            this.Party.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Party.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Party.Location = new System.Drawing.Point(2, 9);
            this.Party.Name = "Party";
            this.Party.Size = new System.Drawing.Size(224, 21);
            this.Party.TabIndex = 27;
            this.Party.Text = "National Identity Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(553, 44);
            this.label2.TabIndex = 9;
            this.label2.Text = "e-Voting fingerprint Varification ";
            // 
            // varifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(694, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "varifi";
            this.Text = "e-Voting fingerprint Varification ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBOX_Show_Read;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nictxt;
        private System.Windows.Forms.Label Party;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}

