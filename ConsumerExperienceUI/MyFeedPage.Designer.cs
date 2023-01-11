namespace ArtRepositorySystem.ConsumerExperienceUI
{
    partial class MyFeedPage
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
            this.LblPageTitle = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanelAllArtworks = new System.Windows.Forms.TableLayoutPanel();
            this.categoryTemplateDisplay1 = new ArtRepositorySystem.ConsumerExperienceUI.CategoryTemplateDisplay();
            this.categoryTemplateDisplay2 = new ArtRepositorySystem.ConsumerExperienceUI.CategoryTemplateDisplay();
            this.categoryTemplateDisplay3 = new ArtRepositorySystem.ConsumerExperienceUI.CategoryTemplateDisplay();
            this.PanelHeader.SuspendLayout();
            this.tableLayoutPanelAllArtworks.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPageTitle
            // 
            this.LblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblPageTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblPageTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPageTitle.Location = new System.Drawing.Point(20, 20);
            this.LblPageTitle.Name = "LblPageTitle";
            this.LblPageTitle.Size = new System.Drawing.Size(175, 44);
            this.LblPageTitle.TabIndex = 0;
            this.LblPageTitle.Text = "My Feed";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.Transparent;
            this.PanelHeader.Controls.Add(this.LblPageTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(20, 20);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Padding = new System.Windows.Forms.Padding(20);
            this.PanelHeader.Size = new System.Drawing.Size(1089, 84);
            this.PanelHeader.TabIndex = 2;
            // 
            // tableLayoutPanelAllArtworks
            // 
            this.tableLayoutPanelAllArtworks.AutoScroll = true;
            this.tableLayoutPanelAllArtworks.ColumnCount = 1;
            this.tableLayoutPanelAllArtworks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelAllArtworks.Controls.Add(this.categoryTemplateDisplay3, 0, 2);
            this.tableLayoutPanelAllArtworks.Controls.Add(this.categoryTemplateDisplay2, 0, 1);
            this.tableLayoutPanelAllArtworks.Controls.Add(this.categoryTemplateDisplay1, 0, 0);
            this.tableLayoutPanelAllArtworks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAllArtworks.Location = new System.Drawing.Point(20, 104);
            this.tableLayoutPanelAllArtworks.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelAllArtworks.MinimumSize = new System.Drawing.Size(400, 400);
            this.tableLayoutPanelAllArtworks.Name = "tableLayoutPanelAllArtworks";
            this.tableLayoutPanelAllArtworks.RowCount = 3;
            this.tableLayoutPanelAllArtworks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAllArtworks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAllArtworks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAllArtworks.Size = new System.Drawing.Size(1089, 606);
            this.tableLayoutPanelAllArtworks.TabIndex = 2;
            // 
            // categoryTemplateDisplay1
            // 
            this.categoryTemplateDisplay1.BackColor = System.Drawing.Color.Transparent;
            this.categoryTemplateDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryTemplateDisplay1.Location = new System.Drawing.Point(3, 3);
            this.categoryTemplateDisplay1.Name = "categoryTemplateDisplay1";
            this.categoryTemplateDisplay1.Size = new System.Drawing.Size(1083, 196);
            this.categoryTemplateDisplay1.TabIndex = 0;
            // 
            // categoryTemplateDisplay2
            // 
            this.categoryTemplateDisplay2.BackColor = System.Drawing.Color.Transparent;
            this.categoryTemplateDisplay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryTemplateDisplay2.Location = new System.Drawing.Point(3, 205);
            this.categoryTemplateDisplay2.Name = "categoryTemplateDisplay2";
            this.categoryTemplateDisplay2.Size = new System.Drawing.Size(1083, 196);
            this.categoryTemplateDisplay2.TabIndex = 1;
            // 
            // categoryTemplateDisplay3
            // 
            this.categoryTemplateDisplay3.BackColor = System.Drawing.Color.Transparent;
            this.categoryTemplateDisplay3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryTemplateDisplay3.Location = new System.Drawing.Point(3, 407);
            this.categoryTemplateDisplay3.Name = "categoryTemplateDisplay3";
            this.categoryTemplateDisplay3.Size = new System.Drawing.Size(1083, 196);
            this.categoryTemplateDisplay3.TabIndex = 2;
            // 
            // MyFeedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelAllArtworks);
            this.Controls.Add(this.PanelHeader);
            this.Name = "MyFeedPage";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1129, 730);
            this.Load += new System.EventHandler(this.MyFeedPage_Load);
            this.PanelHeader.ResumeLayout(false);
            this.tableLayoutPanelAllArtworks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label LblPageTitle;
        private Panel PanelHeader;
        private TableLayoutPanel tableLayoutPanelAllArtworks;
        private CategoryTemplateDisplay categoryTemplateDisplay3;
        private CategoryTemplateDisplay categoryTemplateDisplay2;
        private CategoryTemplateDisplay categoryTemplateDisplay1;
    }
}
