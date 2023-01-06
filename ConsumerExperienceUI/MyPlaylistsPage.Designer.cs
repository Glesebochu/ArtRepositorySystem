﻿namespace ArtRepositorySystem.ConsumerExperienceUI
{
    partial class MyPlaylistsPage
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
            this.PanelContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanelAllArtworks = new System.Windows.Forms.TableLayoutPanel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LblPageTitle = new System.Windows.Forms.Label();
            this.PanelContent.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.tableLayoutPanelAllArtworks);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 74);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Padding = new System.Windows.Forms.Padding(20);
            this.PanelContent.Size = new System.Drawing.Size(966, 545);
            this.PanelContent.TabIndex = 4;
            // 
            // tableLayoutPanelAllArtworks
            // 
            this.tableLayoutPanelAllArtworks.AutoScroll = true;
            this.tableLayoutPanelAllArtworks.ColumnCount = 3;
            this.tableLayoutPanelAllArtworks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelAllArtworks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelAllArtworks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelAllArtworks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAllArtworks.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanelAllArtworks.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelAllArtworks.MinimumSize = new System.Drawing.Size(400, 400);
            this.tableLayoutPanelAllArtworks.Name = "tableLayoutPanelAllArtworks";
            this.tableLayoutPanelAllArtworks.RowCount = 3;
            this.tableLayoutPanelAllArtworks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAllArtworks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAllArtworks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAllArtworks.Size = new System.Drawing.Size(926, 505);
            this.tableLayoutPanelAllArtworks.TabIndex = 3;
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.LblPageTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Padding = new System.Windows.Forms.Padding(20);
            this.PanelHeader.Size = new System.Drawing.Size(966, 74);
            this.PanelHeader.TabIndex = 3;
            // 
            // LblPageTitle
            // 
            this.LblPageTitle.AutoSize = true;
            this.LblPageTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblPageTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPageTitle.Location = new System.Drawing.Point(20, 20);
            this.LblPageTitle.Name = "LblPageTitle";
            this.LblPageTitle.Size = new System.Drawing.Size(179, 37);
            this.LblPageTitle.TabIndex = 1;
            this.LblPageTitle.Text = "My Playlists";
            // 
            // MyPlaylistsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelHeader);
            this.Name = "MyPlaylistsPage";
            this.Size = new System.Drawing.Size(966, 619);
            this.PanelContent.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelContent;
        private TableLayoutPanel tableLayoutPanelAllArtworks;
        private Panel PanelHeader;
        private Label LblPageTitle;
    }
}
