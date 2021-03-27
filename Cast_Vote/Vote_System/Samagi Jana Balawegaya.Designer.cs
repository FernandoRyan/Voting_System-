
namespace Vote_System
{
    partial class Samagi_Jana_Balawegaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Samagi_Jana_Balawegaya));
            this.logopanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.votebtn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.candidatetbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voting_systemDbDataSet = new Vote_System.Voting_systemDbDataSet();
            this.candidate_tbTableAdapter = new Vote_System.Voting_systemDbDataSetTableAdapters.candidate_tbTableAdapter();
            this.logopanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.FLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatetbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // logopanel
            // 
            this.logopanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logopanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(130)))));
            this.logopanel.Controls.Add(this.panel2);
            this.logopanel.Controls.Add(this.panel1);
            this.logopanel.Location = new System.Drawing.Point(1, -5);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(799, 488);
            this.logopanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(60, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 86);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.FLP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 360);
            this.panel1.TabIndex = 1;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(698, 326);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 31);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.Text = "Back";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            this.iconButton2.MouseEnter += new System.EventHandler(this.iconButton2_MouseEnter);
            this.iconButton2.MouseLeave += new System.EventHandler(this.iconButton2_MouseLeave);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.iconPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox2.BackgroundImage")));
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 57;
            this.iconPictureBox2.Location = new System.Drawing.Point(345, 3);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(57, 57);
            this.iconPictureBox2.TabIndex = 8;
            this.iconPictureBox2.TabStop = false;
            // 
            // FLP
            // 
            this.FLP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FLP.Controls.Add(this.dataGridView1);
            this.FLP.Controls.Add(this.votebtn);
            this.FLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLP.Location = new System.Drawing.Point(3, 102);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(757, 218);
            this.FLP.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // votebtn
            // 
            this.votebtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.votebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.votebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.votebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.votebtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.votebtn.IconColor = System.Drawing.Color.Black;
            this.votebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.votebtn.Location = new System.Drawing.Point(320, 159);
            this.votebtn.Name = "votebtn";
            this.votebtn.Size = new System.Drawing.Size(108, 31);
            this.votebtn.TabIndex = 9;
            this.votebtn.Text = "Vote";
            this.votebtn.UseVisualStyleBackColor = false;
            this.votebtn.Click += new System.EventHandler(this.iconButton1_Click);
            this.votebtn.MouseEnter += new System.EventHandler(this.votebtn_MouseEnter);
            this.votebtn.MouseLeave += new System.EventHandler(this.votebtn_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(170, 63);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(408, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vote for Candidates by placing a trick";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // candidatetbBindingSource
            // 
            this.candidatetbBindingSource.DataMember = "candidate_tb";
            this.candidatetbBindingSource.DataSource = this.voting_systemDbDataSet;
            // 
            // voting_systemDbDataSet
            // 
            this.voting_systemDbDataSet.DataSetName = "Voting_systemDbDataSet";
            this.voting_systemDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidate_tbTableAdapter
            // 
            this.candidate_tbTableAdapter.ClearBeforeFill = true;
            // 
            // Samagi_Jana_Balawegaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.logopanel);
            this.Name = "Samagi_Jana_Balawegaya";
            this.Text = "Samagi_Jana_Balawegaya";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Samagi_Jana_Balawegaya_Load);
            this.logopanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.FLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatetbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton votebtn;
        private Voting_systemDbDataSet voting_systemDbDataSet;
        private System.Windows.Forms.BindingSource candidatetbBindingSource;
        private Voting_systemDbDataSetTableAdapters.candidate_tbTableAdapter candidate_tbTableAdapter;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}