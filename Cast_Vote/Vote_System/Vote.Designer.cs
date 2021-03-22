
namespace Vote_System
{
    partial class Vote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vote));
            this.logopanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.voten = new System.Windows.Forms.Label();
            this.Vote_Btn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logopanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logopanel
            // 
            this.logopanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logopanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.logopanel.Controls.Add(this.panel1);
            this.logopanel.Controls.Add(this.panel2);
            this.logopanel.Location = new System.Drawing.Point(3, -3);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(799, 460);
            this.logopanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.voten);
            this.panel1.Controls.Add(this.Vote_Btn);
            this.panel1.Location = new System.Drawing.Point(9, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 332);
            this.panel1.TabIndex = 1;
            // 
            // voten
            // 
            this.voten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.voten.AutoSize = true;
            this.voten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voten.Location = new System.Drawing.Point(334, 48);
            this.voten.Name = "voten";
            this.voten.Size = new System.Drawing.Size(112, 25);
            this.voten.TabIndex = 1;
            this.voten.Text = "Vote Now";
            // 
            // Vote_Btn
            // 
            this.Vote_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Vote_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Vote_Btn.BackgroundImage")));
            this.Vote_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Vote_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vote_Btn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Vote_Btn.IconColor = System.Drawing.Color.Black;
            this.Vote_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Vote_Btn.Location = new System.Drawing.Point(232, 116);
            this.Vote_Btn.Name = "Vote_Btn";
            this.Vote_Btn.Size = new System.Drawing.Size(304, 156);
            this.Vote_Btn.TabIndex = 0;
            this.Vote_Btn.UseVisualStyleBackColor = true;
            this.Vote_Btn.Click += new System.EventHandler(this.Vote_Btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(54, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 88);
            this.panel2.TabIndex = 0;
            // 
            // Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logopanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vote";
            this.Text = "Vote";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.logopanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label voten;
        private FontAwesome.Sharp.IconButton Vote_Btn;
    }
}

