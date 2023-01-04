namespace ArtRepositorySystem
{
    partial class ArtistForm
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
        public void InitializeComponent()
        {
            this.pnlSidePanel = new System.Windows.Forms.Panel();
            this.pnlPersonal = new System.Windows.Forms.Panel();
            this.ovalPictureBox1 = new ArtRepositorySystem.OvalPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMode = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.pnlPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidePanel
            // 
            this.pnlSidePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSidePanel.BackColor = System.Drawing.Color.White;
            this.pnlSidePanel.Location = new System.Drawing.Point(0, 120);
            this.pnlSidePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSidePanel.Name = "pnlSidePanel";
            this.pnlSidePanel.Size = new System.Drawing.Size(257, 330);
            this.pnlSidePanel.TabIndex = 0;
            // 
            // pnlPersonal
            // 
            this.pnlPersonal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlPersonal.Controls.Add(this.ovalPictureBox1);
            this.pnlPersonal.Controls.Add(this.label1);
            this.pnlPersonal.Controls.Add(this.btnMode);
            this.pnlPersonal.Controls.Add(this.pictureBox1);
            this.pnlPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPersonal.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPersonal.Name = "pnlPersonal";
            this.pnlPersonal.Size = new System.Drawing.Size(800, 114);
            this.pnlPersonal.TabIndex = 2;
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.White;
            this.ovalPictureBox1.Image = global::ArtRepositorySystem.Properties.Resources.profile1;
            this.ovalPictureBox1.InitialImage = global::ArtRepositorySystem.Properties.Resources.profile1;
            this.ovalPictureBox1.Location = new System.Drawing.Point(375, 12);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(117, 99);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ovalPictureBox1.TabIndex = 3;
            this.ovalPictureBox1.TabStop = false;
            this.ovalPictureBox1.Click += new System.EventHandler(this.ovalPictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(599, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brought to you by ግለሰቦች";
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMode.ForeColor = System.Drawing.Color.Black;
            this.btnMode.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            this.btnMode.IconColor = System.Drawing.Color.Black;
            this.btnMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMode.Location = new System.Drawing.Point(606, 3);
            this.btnMode.Margin = new System.Windows.Forms.Padding(0);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(194, 53);
            this.btnMode.TabIndex = 1;
            this.btnMode.Text = "Consumer Mode";
            this.btnMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMode.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnModeClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ArtRepositorySystem.Properties.Resources.mededaNew1;
            this.pictureBox1.Image = global::ArtRepositorySystem.Properties.Resources.mededaNew1;
            this.pictureBox1.Location = new System.Drawing.Point(4, -12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.contentPanel.Location = new System.Drawing.Point(261, 120);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(539, 330);
            this.contentPanel.TabIndex = 3;
            // 
            // ArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.pnlPersonal);
            this.Controls.Add(this.pnlSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ArtistForm";
            this.Text = "Artist";
            this.Load += new System.EventHandler(this.ArtistForm_Load);
            this.pnlPersonal.ResumeLayout(false);
            this.pnlPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSidePanel;
        private System.Windows.Forms.Panel pnlPersonal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMode;
        public  Panel contentPanel;
        private Label label1;
        private OvalPictureBox ovalPictureBox1;
    }
}