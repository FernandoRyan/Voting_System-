
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logo = new System.Windows.Forms.Panel();
            this.Results = new System.Windows.Forms.Label();
            this.Submitbtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.logo.BackgroundImage = global::Voting_system.Properties.Resources.election;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(51, 2);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(738, 95);
            this.logo.TabIndex = 1;
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Results.Location = new System.Drawing.Point(328, 126);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(130, 21);
            this.Results.TabIndex = 2;
            this.Results.Text = "Election Results";
            // 
            // Submitbtn
            // 
            this.Submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Submitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(200)))), ((int)(((byte)(221)))));
            this.Submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submitbtn.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpenText;
            this.Submitbtn.IconColor = System.Drawing.Color.Black;
            this.Submitbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Submitbtn.IconSize = 22;
            this.Submitbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Submitbtn.Location = new System.Drawing.Point(705, 416);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(93, 31);
            this.Submitbtn.TabIndex = 13;
            this.Submitbtn.Text = "Show";
            this.Submitbtn.UseVisualStyleBackColor = false;
            // 
            // Election_Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Election_Results";
            this.Text = "Results_Election";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label Results;
        private FontAwesome.Sharp.IconButton Submitbtn;
    }
}