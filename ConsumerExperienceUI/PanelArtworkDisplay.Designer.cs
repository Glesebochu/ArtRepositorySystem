namespace ArtRepositorySystem.ConsumerExperienceUI
{
    partial class PanelArtworkDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControlArtwork = new System.Windows.Forms.TabControl();
            this.artPage = new System.Windows.Forms.TabPage();
            this.picBoxArtwork = new System.Windows.Forms.PictureBox();
            this.descriptionPage = new System.Windows.Forms.TabPage();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.feedbackPage = new System.Windows.Forms.TabPage();
            this.analyticsPage = new System.Windows.Forms.TabPage();
            this.LblArtworkTitle = new System.Windows.Forms.Label();
            this.TabControlArtwork.SuspendLayout();
            this.artPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArtwork)).BeginInit();
            this.descriptionPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlArtwork
            // 
            this.TabControlArtwork.Controls.Add(this.artPage);
            this.TabControlArtwork.Controls.Add(this.descriptionPage);
            this.TabControlArtwork.Controls.Add(this.feedbackPage);
            this.TabControlArtwork.Controls.Add(this.analyticsPage);
            this.TabControlArtwork.Location = new System.Drawing.Point(3, 87);
            this.TabControlArtwork.Name = "TabControlArtwork";
            this.TabControlArtwork.SelectedIndex = 0;
            this.TabControlArtwork.Size = new System.Drawing.Size(674, 422);
            this.TabControlArtwork.TabIndex = 0;
            // 
            // artPage
            // 
            this.artPage.Controls.Add(this.picBoxArtwork);
            this.artPage.ForeColor = System.Drawing.Color.Transparent;
            this.artPage.Location = new System.Drawing.Point(4, 29);
            this.artPage.Name = "artPage";
            this.artPage.Padding = new System.Windows.Forms.Padding(3);
            this.artPage.Size = new System.Drawing.Size(666, 389);
            this.artPage.TabIndex = 0;
            this.artPage.Text = "Art";
            this.artPage.UseVisualStyleBackColor = true;
            // 
            // picBoxArtwork
            // 
            this.picBoxArtwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxArtwork.Location = new System.Drawing.Point(6, 6);
            this.picBoxArtwork.Name = "picBoxArtwork";
            this.picBoxArtwork.Size = new System.Drawing.Size(654, 377);
            this.picBoxArtwork.TabIndex = 0;
            this.picBoxArtwork.TabStop = false;
            // 
            // descriptionPage
            // 
            this.descriptionPage.Controls.Add(this.txtBoxDescription);
            this.descriptionPage.Location = new System.Drawing.Point(4, 29);
            this.descriptionPage.Name = "descriptionPage";
            this.descriptionPage.Padding = new System.Windows.Forms.Padding(3);
            this.descriptionPage.Size = new System.Drawing.Size(666, 389);
            this.descriptionPage.TabIndex = 1;
            this.descriptionPage.Text = "Description";
            this.descriptionPage.UseVisualStyleBackColor = true;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDescription.Location = new System.Drawing.Point(6, 6);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(654, 377);
            this.txtBoxDescription.TabIndex = 0;
            this.txtBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // feedbackPage
            // 
            this.feedbackPage.Location = new System.Drawing.Point(4, 29);
            this.feedbackPage.Name = "feedbackPage";
            this.feedbackPage.Padding = new System.Windows.Forms.Padding(3);
            this.feedbackPage.Size = new System.Drawing.Size(666, 389);
            this.feedbackPage.TabIndex = 2;
            this.feedbackPage.Text = "Feedback";
            this.feedbackPage.UseVisualStyleBackColor = true;
            // 
            // analyticsPage
            // 
            this.analyticsPage.Location = new System.Drawing.Point(4, 29);
            this.analyticsPage.Name = "analyticsPage";
            this.analyticsPage.Padding = new System.Windows.Forms.Padding(3);
            this.analyticsPage.Size = new System.Drawing.Size(666, 389);
            this.analyticsPage.TabIndex = 3;
            this.analyticsPage.Text = "Analytics";
            this.analyticsPage.UseVisualStyleBackColor = true;
            // 
            // LblArtworkTitle
            // 
            this.LblArtworkTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblArtworkTitle.AutoEllipsis = true;
            this.LblArtworkTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblArtworkTitle.Location = new System.Drawing.Point(96, 25);
            this.LblArtworkTitle.Name = "LblArtworkTitle";
            this.LblArtworkTitle.Size = new System.Drawing.Size(474, 48);
            this.LblArtworkTitle.TabIndex = 1;
            this.LblArtworkTitle.Text = "...";
            this.LblArtworkTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelArtworkDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LblArtworkTitle);
            this.Controls.Add(this.TabControlArtwork);
            this.Name = "PanelArtworkDisplay";
            this.Size = new System.Drawing.Size(680, 512);
            this.Load += new System.EventHandler(this.PanelArtworkDisplay_Load);
            this.TabControlArtwork.ResumeLayout(false);
            this.artPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArtwork)).EndInit();
            this.descriptionPage.ResumeLayout(false);
            this.descriptionPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabControlArtwork;
        private TabPage artPage;
        private TabPage descriptionPage;
        private TabPage feedbackPage;
        private TabPage analyticsPage;
        private Label LblArtworkTitle;
        private PictureBox picBoxArtwork;
        private TextBox txtBoxDescription;
    }
}
