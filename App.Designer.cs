namespace ArtRepositorySystem
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelNavigation = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnNavigation = new System.Windows.Forms.Button();
            this.PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelNavigation
            // 
            this.PanelNavigation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelNavigation.Location = new System.Drawing.Point(12, 12);
            this.PanelNavigation.Name = "PanelNavigation";
            this.PanelNavigation.Size = new System.Drawing.Size(236, 677);
            this.PanelNavigation.TabIndex = 0;
            // 
            // PanelContent
            // 
            this.PanelContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelContent.Controls.Add(this.BtnSearch);
            this.PanelContent.Controls.Add(this.BtnNavigation);
            this.PanelContent.Location = new System.Drawing.Point(254, 12);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(931, 677);
            this.PanelContent.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSearch.BackgroundImage = global::ArtRepositorySystem.Properties.Resources.loupe;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSearch.Location = new System.Drawing.Point(878, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(50, 50);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // BtnNavigation
            // 
            this.BtnNavigation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNavigation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnNavigation.BackgroundImage = global::ArtRepositorySystem.Properties.Resources.menu_bar;
            this.BtnNavigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNavigation.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnNavigation.Location = new System.Drawing.Point(3, 3);
            this.BtnNavigation.Name = "BtnNavigation";
            this.BtnNavigation.Size = new System.Drawing.Size(50, 50);
            this.BtnNavigation.TabIndex = 0;
            this.BtnNavigation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNavigation.UseVisualStyleBackColor = false;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 701);
            this.Controls.Add(this.PanelNavigation);
            this.Controls.Add(this.PanelContent);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArtRepositorySystem";
            this.PanelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelNavigation;
        private Panel PanelContent;
        private Button BtnSearch;
        private Button BtnNavigation;
    }
}