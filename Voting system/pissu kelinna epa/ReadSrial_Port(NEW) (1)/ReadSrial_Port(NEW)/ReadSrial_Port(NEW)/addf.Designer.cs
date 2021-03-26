namespace ReadSrial_Port_NEW_
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Party = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBOX_Show_Read
            // 
            this.textBOX_Show_Read.Location = new System.Drawing.Point(4, 131);
            this.textBOX_Show_Read.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBOX_Show_Read.Multiline = true;
            this.textBOX_Show_Read.Name = "textBOX_Show_Read";
            this.textBOX_Show_Read.Size = new System.Drawing.Size(451, 335);
            this.textBOX_Show_Read.TabIndex = 0;
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(4, 46);
            this.textBox_Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(330, 26);
            this.textBox_Send.TabIndex = 1;
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(4, 86);
            this.comboBox_Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(180, 28);
            this.comboBox_Port.TabIndex = 5;
            // 
            // BTN_Send
            // 
            this.BTN_Send.Location = new System.Drawing.Point(345, 46);
            this.BTN_Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(112, 35);
            this.BTN_Send.TabIndex = 2;
            this.BTN_Send.Text = "Send";
            this.BTN_Send.UseVisualStyleBackColor = true;
            this.BTN_Send.Click += new System.EventHandler(this.BTN_Send_Click_1);
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Location = new System.Drawing.Point(345, 86);
            this.BTN_Stop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(112, 35);
            this.BTN_Stop.TabIndex = 4;
            this.BTN_Stop.Text = "Stop";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(224, 86);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(112, 35);
            this.BTN_Start.TabIndex = 3;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fingerprint Sonsor Controller";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.Party);
            this.panel2.Location = new System.Drawing.Point(503, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 499);
            this.panel2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 142);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.MaxLength = 12;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 26);
            this.textBox1.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "Add Finger Print ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 32);
            this.label3.TabIndex = 30;
            this.label3.Text = "Voter\'s Fingerprint ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 56);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.MaxLength = 12;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(294, 26);
            this.textBox2.TabIndex = 28;
            // 
            // Party
            // 
            this.Party.AutoSize = true;
            this.Party.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Party.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Party.Location = new System.Drawing.Point(3, 14);
            this.Party.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Party.Name = "Party";
            this.Party.Size = new System.Drawing.Size(347, 32);
            this.Party.TabIndex = 27;
            this.Party.Text = "National Idemtity Card number";
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
            this.panel1.Location = new System.Drawing.Point(23, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 499);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Museo 100", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(825, 67);
            this.label2.TabIndex = 12;
            this.label2.Text = "e-Voting fingerprint Registration";
            // 
            // addf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1089, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addf";
            this.Text = "e-Voting fingerprint Registration";
            this.Load += new System.EventHandler(this.addf_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Party;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}