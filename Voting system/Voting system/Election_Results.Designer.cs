
namespace Voting_system
{
    partial class Election_Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Election_Results));
            this.logo = new System.Windows.Forms.Panel();
            this.Results = new System.Windows.Forms.Label();
            this.Resultspanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dates = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Signoutbtn = new FontAwesome.Sharp.IconButton();
            this.DetailedReportbtn = new FontAwesome.Sharp.IconButton();
            this.Reportbtn = new FontAwesome.Sharp.IconButton();
            this.Resultspanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
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
            // Results
            // 
            this.Results.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Results.Location = new System.Drawing.Point(-6, 5);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(228, 32);
            this.Results.TabIndex = 2;
            this.Results.Text = "Election Results Of";
            // 
            // Resultspanel
            // 
            this.Resultspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(122)))));
            this.Resultspanel.Controls.Add(this.panel1);
            this.Resultspanel.Controls.Add(this.panel4);
            this.Resultspanel.Controls.Add(this.dataGridView1);
            this.Resultspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Resultspanel.Location = new System.Drawing.Point(0, 0);
            this.Resultspanel.Name = "Resultspanel";
            this.Resultspanel.Size = new System.Drawing.Size(800, 450);
            this.Resultspanel.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Results);
            this.panel1.Location = new System.Drawing.Point(239, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 40);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(241, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "as";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(122)))));
            this.panel4.BackgroundImage = global::Voting_system.Properties.Resources.election;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(208, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 95);
            this.panel4.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(205, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // dates
            // 
            this.dates.AutoSize = true;
            this.dates.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dates.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dates.Location = new System.Drawing.Point(448, 121);
            this.dates.Name = "dates";
            this.dates.Size = new System.Drawing.Size(0, 29);
            this.dates.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 450);
            this.panel2.TabIndex = 18;
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
            this.panel5.Controls.Add(this.DetailedReportbtn);
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
            this.Signoutbtn.Location = new System.Drawing.Point(0, 120);
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
            // DetailedReportbtn
            // 
            this.DetailedReportbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DetailedReportbtn.FlatAppearance.BorderSize = 0;
            this.DetailedReportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailedReportbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DetailedReportbtn.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.DetailedReportbtn.IconColor = System.Drawing.Color.Gainsboro;
            this.DetailedReportbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DetailedReportbtn.IconSize = 33;
            this.DetailedReportbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DetailedReportbtn.Location = new System.Drawing.Point(0, 60);
            this.DetailedReportbtn.Name = "DetailedReportbtn";
            this.DetailedReportbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.DetailedReportbtn.Size = new System.Drawing.Size(197, 60);
            this.DetailedReportbtn.TabIndex = 19;
            this.DetailedReportbtn.Text = "Detailed Report";
            this.DetailedReportbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DetailedReportbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DetailedReportbtn.UseVisualStyleBackColor = true;
            this.DetailedReportbtn.Click += new System.EventHandler(this.DetailedReportbtn_Click);
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
            this.Reportbtn.Text = "Report";
            this.Reportbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reportbtn.UseVisualStyleBackColor = true;
            this.Reportbtn.Click += new System.EventHandler(this.Reportbtn_Click);
            // 
            // Election_Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dates);
            this.Controls.Add(this.Resultspanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Election_Results";
            this.Text = "Results_Election";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Election_Results_Load);
            this.Resultspanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.Panel Resultspanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dates;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton Signoutbtn;
        private FontAwesome.Sharp.IconButton Reportbtn;
        private FontAwesome.Sharp.IconButton DetailedReportbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}