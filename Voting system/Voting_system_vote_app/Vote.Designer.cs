
namespace Voting_system_vote_app
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
            this.logo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartVote = new FontAwesome.Sharp.IconButton();
            this.vte = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.logo.BackgroundImage = global::Voting_system_vote_app.Properties.Resources.election;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(0, 2);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(798, 126);
            this.logo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vte);
            this.panel1.Controls.Add(this.StartVote);
            this.panel1.Location = new System.Drawing.Point(0, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 320);
            this.panel1.TabIndex = 2;
            // 
            // StartVote
            // 
            this.StartVote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(200)))), ((int)(((byte)(221)))));
            this.StartVote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartVote.IconChar = FontAwesome.Sharp.IconChar.VoteYea;
            this.StartVote.IconColor = System.Drawing.SystemColors.Highlight;
            this.StartVote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StartVote.IconSize = 150;
            this.StartVote.Location = new System.Drawing.Point(207, 114);
            this.StartVote.Name = "StartVote";
            this.StartVote.Size = new System.Drawing.Size(380, 123);
            this.StartVote.TabIndex = 0;
            this.StartVote.UseVisualStyleBackColor = false;
            // 
            // vte
            // 
            this.vte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vte.AutoSize = true;
            this.vte.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vte.Location = new System.Drawing.Point(242, 49);
            this.vte.Name = "vte";
            this.vte.Size = new System.Drawing.Size(328, 37);
            this.vte.TabIndex = 1;
            this.vte.Text = "Click Below to Start voting";
            // 
            // Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vote";
            this.Text = "Voting System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label vte;
        private FontAwesome.Sharp.IconButton StartVote;
    }
}

