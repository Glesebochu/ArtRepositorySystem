namespace ArtRepositorySystem.ConsumerExperienceUI
{
    partial class ArtworkCenterDisplay
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
            this.LblArtworkTitle = new System.Windows.Forms.Label();
            this.tabControlArtworkInfo = new System.Windows.Forms.TabControl();
            this.artPage = new System.Windows.Forms.TabPage();
            this.descriptionPage = new System.Windows.Forms.TabPage();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.feedbackPage = new System.Windows.Forms.TabPage();
            this.analyticsPage = new System.Windows.Forms.TabPage();
            this.tabControlArtworkInfo.SuspendLayout();
            this.descriptionPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblArtworkTitle
            // 
            this.LblArtworkTitle.AutoEllipsis = true;
            this.LblArtworkTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblArtworkTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblArtworkTitle.Location = new System.Drawing.Point(120, 120);
            this.LblArtworkTitle.Name = "LblArtworkTitle";
            this.LblArtworkTitle.Size = new System.Drawing.Size(858, 95);
            this.LblArtworkTitle.TabIndex = 1;
            this.LblArtworkTitle.Text = "...";
            this.LblArtworkTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlArtworkInfo
            // 
            this.tabControlArtworkInfo.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlArtworkInfo.Controls.Add(this.artPage);
            this.tabControlArtworkInfo.Controls.Add(this.descriptionPage);
            this.tabControlArtworkInfo.Controls.Add(this.feedbackPage);
            this.tabControlArtworkInfo.Controls.Add(this.analyticsPage);
            this.tabControlArtworkInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlArtworkInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControlArtworkInfo.ItemSize = new System.Drawing.Size(64, 40);
            this.tabControlArtworkInfo.Location = new System.Drawing.Point(120, 215);
            this.tabControlArtworkInfo.Name = "tabControlArtworkInfo";
            this.tabControlArtworkInfo.Padding = new System.Drawing.Point(40, 3);
            this.tabControlArtworkInfo.SelectedIndex = 0;
            this.tabControlArtworkInfo.Size = new System.Drawing.Size(858, 383);
            this.tabControlArtworkInfo.TabIndex = 2;
            // 
            // artPage
            // 
            this.artPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.artPage.Location = new System.Drawing.Point(4, 44);
            this.artPage.Name = "artPage";
            this.artPage.Size = new System.Drawing.Size(850, 335);
            this.artPage.TabIndex = 0;
            this.artPage.Text = "Artwork";
            // 
            // descriptionPage
            // 
            this.descriptionPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.descriptionPage.Controls.Add(this.textBoxDescription);
            this.descriptionPage.Location = new System.Drawing.Point(4, 44);
            this.descriptionPage.Name = "descriptionPage";
            this.descriptionPage.Size = new System.Drawing.Size(850, 335);
            this.descriptionPage.TabIndex = 1;
            this.descriptionPage.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(0, 0);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(850, 335);
            this.textBoxDescription.TabIndex = 0;
            this.textBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // feedbackPage
            // 
            this.feedbackPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.feedbackPage.Location = new System.Drawing.Point(4, 44);
            this.feedbackPage.Name = "feedbackPage";
            this.feedbackPage.Size = new System.Drawing.Size(850, 335);
            this.feedbackPage.TabIndex = 2;
            this.feedbackPage.Text = "Feedback";
            // 
            // analyticsPage
            // 
            this.analyticsPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.analyticsPage.Location = new System.Drawing.Point(4, 44);
            this.analyticsPage.Name = "analyticsPage";
            this.analyticsPage.Size = new System.Drawing.Size(850, 335);
            this.analyticsPage.TabIndex = 3;
            this.analyticsPage.Text = "Analytics";
            // 
            // ArtworkCenterDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabControlArtworkInfo);
            this.Controls.Add(this.LblArtworkTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ArtworkCenterDisplay";
            this.Padding = new System.Windows.Forms.Padding(120);
            this.Size = new System.Drawing.Size(1098, 718);
            this.Load += new System.EventHandler(this.CenterDisplay_Load);
            this.Click += new System.EventHandler(this.CenterDisplay_Click);
            this.tabControlArtworkInfo.ResumeLayout(false);
            this.descriptionPage.ResumeLayout(false);
            this.descriptionPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label LblArtworkTitle;
        private TabControl tabControlArtworkInfo;
        private TabPage artPage;
        private TabPage descriptionPage;
        private TabPage feedbackPage;
        private TabPage analyticsPage;
        private TextBox textBoxDescription;
    }
}
