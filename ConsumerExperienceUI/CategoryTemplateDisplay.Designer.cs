namespace ArtRepositorySystem.ConsumerExperienceUI
{
    partial class CategoryTemplateDisplay
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
            this.PanelCategoryHeader = new System.Windows.Forms.Panel();
            this.LblCategoryName = new System.Windows.Forms.Label();
            this.resultsGridCategoryResults = new ArtRepositorySystem.ConsumerExperienceUI.ResultsGrid();
            this.PanelCategoryHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCategoryHeader
            // 
            this.PanelCategoryHeader.Controls.Add(this.LblCategoryName);
            this.PanelCategoryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCategoryHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelCategoryHeader.Name = "PanelCategoryHeader";
            this.PanelCategoryHeader.Padding = new System.Windows.Forms.Padding(20);
            this.PanelCategoryHeader.Size = new System.Drawing.Size(1095, 74);
            this.PanelCategoryHeader.TabIndex = 3;
            // 
            // LblCategoryName
            // 
            this.LblCategoryName.AutoSize = true;
            this.LblCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.LblCategoryName.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblCategoryName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCategoryName.Location = new System.Drawing.Point(20, 20);
            this.LblCategoryName.Name = "LblCategoryName";
            this.LblCategoryName.Size = new System.Drawing.Size(258, 37);
            this.LblCategoryName.TabIndex = 1;
            this.LblCategoryName.Text = "Category_Name";
            // 
            // resultsGridCategoryResults
            // 
            this.resultsGridCategoryResults.BackColor = System.Drawing.Color.Transparent;
            this.resultsGridCategoryResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGridCategoryResults.Location = new System.Drawing.Point(0, 74);
            this.resultsGridCategoryResults.Name = "resultsGridCategoryResults";
            this.resultsGridCategoryResults.Padding = new System.Windows.Forms.Padding(20);
            this.resultsGridCategoryResults.Size = new System.Drawing.Size(1095, 615);
            this.resultsGridCategoryResults.TabIndex = 4;
            // 
            // CategoryTemplateDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.resultsGridCategoryResults);
            this.Controls.Add(this.PanelCategoryHeader);
            this.Name = "CategoryTemplateDisplay";
            this.Size = new System.Drawing.Size(1095, 689);
            this.PanelCategoryHeader.ResumeLayout(false);
            this.PanelCategoryHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ResultsGrid resultsGridArtworks;
        private Panel PanelCategoryHeader;
        private Label LblCategoryName;
        private ResultsGrid resultsGridCategory;
        private ResultsGrid resultsGridCategoryResults;
    }
}
