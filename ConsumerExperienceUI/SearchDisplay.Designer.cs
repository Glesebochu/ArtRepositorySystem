﻿namespace ArtRepositorySystem.ConsumerExperienceUI
{
    partial class SearchDisplay
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
            TextBoxSearchBar = new TextBox();
            PanelSearchBar = new Panel();
            PanelSearchResults = new Panel();
            TableLayoutPanelSearchResults = new TableLayoutPanel();
            PanelArtistsSection = new Panel();
            PanelHeaderArtistsSection = new Panel();
            LblArtists = new Label();
            PanelArtworksSection = new Panel();
            PanelHeaderArtworksSection = new Panel();
            LblArtworks = new Label();
            PanelContent = new Panel();
            tableLayoutPanelArtistResults = new TableLayoutPanel();
            PanelSearchBar.SuspendLayout();
            PanelSearchResults.SuspendLayout();
            TableLayoutPanelSearchResults.SuspendLayout();
            PanelArtistsSection.SuspendLayout();
            PanelHeaderArtistsSection.SuspendLayout();
            PanelArtworksSection.SuspendLayout();
            PanelHeaderArtworksSection.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxSearchBar
            // 
            TextBoxSearchBar.AcceptsReturn = true;
            TextBoxSearchBar.BorderStyle = BorderStyle.None;
            TextBoxSearchBar.Dock = DockStyle.Fill;
            TextBoxSearchBar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxSearchBar.ForeColor = SystemColors.ActiveCaptionText;
            TextBoxSearchBar.Location = new Point(40, 40);
            TextBoxSearchBar.Margin = new Padding(3, 3, 21, 3);
            TextBoxSearchBar.Name = "TextBoxSearchBar";
            TextBoxSearchBar.PlaceholderText = "Interested in...";
            TextBoxSearchBar.Size = new Size(320, 36);
            TextBoxSearchBar.TabIndex = 0;
            TextBoxSearchBar.KeyUp += TextBoxSearchBar_KeyUp;
            // 
            // PanelSearchBar
            // 
            PanelSearchBar.Controls.Add(TextBoxSearchBar);
            PanelSearchBar.Dock = DockStyle.Top;
            PanelSearchBar.Location = new Point(0, 0);
            PanelSearchBar.Name = "PanelSearchBar";
            PanelSearchBar.Padding = new Padding(40);
            PanelSearchBar.Size = new Size(400, 112);
            PanelSearchBar.TabIndex = 1;
            // 
            // PanelSearchResults
            // 
            PanelSearchResults.AutoScroll = true;
            PanelSearchResults.AutoSize = true;
            PanelSearchResults.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelSearchResults.Controls.Add(TableLayoutPanelSearchResults);
            PanelSearchResults.Dock = DockStyle.Fill;
            PanelSearchResults.Location = new Point(0, 112);
            PanelSearchResults.MinimumSize = new Size(400, 400);
            PanelSearchResults.Name = "PanelSearchResults";
            PanelSearchResults.Padding = new Padding(40, 0, 40, 40);
            PanelSearchResults.Size = new Size(400, 400);
            PanelSearchResults.TabIndex = 2;
            // 
            // TableLayoutPanelSearchResults
            // 
            TableLayoutPanelSearchResults.AutoSize = true;
            TableLayoutPanelSearchResults.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanelSearchResults.ColumnCount = 1;
            TableLayoutPanelSearchResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelSearchResults.Controls.Add(PanelArtistsSection, 1, 0);
            TableLayoutPanelSearchResults.Controls.Add(PanelArtworksSection, 0, 1);
            TableLayoutPanelSearchResults.Dock = DockStyle.Top;
            TableLayoutPanelSearchResults.Location = new Point(40, 0);
            TableLayoutPanelSearchResults.Name = "TableLayoutPanelSearchResults";
            TableLayoutPanelSearchResults.RowCount = 2;
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle());
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle());
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.Size = new Size(320, 162);
            TableLayoutPanelSearchResults.TabIndex = 0;
            // 
            // PanelArtistsSection
            // 
            PanelArtistsSection.AutoScroll = true;
            PanelArtistsSection.AutoSize = true;
            PanelArtistsSection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelArtistsSection.BackColor = Color.Transparent;
            PanelArtistsSection.Controls.Add(PanelHeaderArtistsSection);
            PanelArtistsSection.Dock = DockStyle.Top;
            PanelArtistsSection.Location = new Point(3, 3);
            PanelArtistsSection.Name = "PanelArtistsSection";
            PanelArtistsSection.Size = new Size(314, 75);
            PanelArtistsSection.TabIndex = 0;
            // 
            // PanelHeaderArtistsSection
            // 
            PanelHeaderArtistsSection.AutoScroll = true;
            PanelHeaderArtistsSection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelHeaderArtistsSection.Controls.Add(LblArtists);
            PanelHeaderArtistsSection.Dock = DockStyle.Top;
            PanelHeaderArtistsSection.Location = new Point(0, 0);
            PanelHeaderArtistsSection.Name = "PanelHeaderArtistsSection";
            PanelHeaderArtistsSection.Padding = new Padding(0, 20, 21, 20);
            PanelHeaderArtistsSection.Size = new Size(314, 75);
            PanelHeaderArtistsSection.TabIndex = 1;
            // 
            // LblArtists
            // 
            LblArtists.AutoSize = true;
            LblArtists.BackColor = Color.Transparent;
            LblArtists.Dock = DockStyle.Left;
            LblArtists.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LblArtists.Location = new Point(0, 20);
            LblArtists.Name = "LblArtists";
            LblArtists.Size = new Size(100, 37);
            LblArtists.TabIndex = 1;
            LblArtists.Text = "Artists";
            // 
            // PanelArtworksSection
            // 
            PanelArtworksSection.AutoScroll = true;
            PanelArtworksSection.AutoSize = true;
            PanelArtworksSection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelArtworksSection.Controls.Add(PanelHeaderArtworksSection);
            PanelArtworksSection.Dock = DockStyle.Top;
            PanelArtworksSection.Location = new Point(3, 84);
            PanelArtworksSection.Name = "PanelArtworksSection";
            PanelArtworksSection.Size = new Size(314, 75);
            PanelArtworksSection.TabIndex = 1;
            // 
            // PanelHeaderArtworksSection
            // 
            PanelHeaderArtworksSection.AutoScroll = true;
            PanelHeaderArtworksSection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelHeaderArtworksSection.Controls.Add(LblArtworks);
            PanelHeaderArtworksSection.Dock = DockStyle.Top;
            PanelHeaderArtworksSection.Location = new Point(0, 0);
            PanelHeaderArtworksSection.Name = "PanelHeaderArtworksSection";
            PanelHeaderArtworksSection.Padding = new Padding(0, 20, 21, 20);
            PanelHeaderArtworksSection.Size = new Size(314, 75);
            PanelHeaderArtworksSection.TabIndex = 1;
            // 
            // LblArtworks
            // 
            LblArtworks.AutoSize = true;
            LblArtworks.BackColor = Color.Transparent;
            LblArtworks.Dock = DockStyle.Left;
            LblArtworks.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LblArtworks.Location = new Point(0, 20);
            LblArtworks.Name = "LblArtworks";
            LblArtworks.Size = new Size(141, 37);
            LblArtworks.TabIndex = 1;
            LblArtworks.Text = "Artworks";
            // 
            // PanelContent
            // 
            PanelContent.Location = new Point(0, 0);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(200, 100);
            PanelContent.TabIndex = 0;
            // 
            // tableLayoutPanelArtistResults
            // 
            tableLayoutPanelArtistResults.AutoScroll = true;
            tableLayoutPanelArtistResults.ColumnCount = 3;
            tableLayoutPanelArtistResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanelArtistResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanelArtistResults.Dock = DockStyle.Fill;
            tableLayoutPanelArtistResults.Location = new Point(0, 0);
            tableLayoutPanelArtistResults.Margin = new Padding(10);
            tableLayoutPanelArtistResults.MinimumSize = new Size(400, 400);
            tableLayoutPanelArtistResults.Name = "tableLayoutPanelArtistResults";
            tableLayoutPanelArtistResults.RowCount = 3;
            tableLayoutPanelArtistResults.Size = new Size(400, 400);
            tableLayoutPanelArtistResults.TabIndex = 0;
            // 
            // SearchDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Transparent;
            Controls.Add(PanelSearchResults);
            Controls.Add(PanelSearchBar);
            Name = "SearchDisplay";
            Size = new Size(400, 512);
            Load += SearchDisplay_Load;
            PanelSearchBar.ResumeLayout(false);
            PanelSearchBar.PerformLayout();
            PanelSearchResults.ResumeLayout(false);
            PanelSearchResults.PerformLayout();
            TableLayoutPanelSearchResults.ResumeLayout(false);
            TableLayoutPanelSearchResults.PerformLayout();
            PanelArtistsSection.ResumeLayout(false);
            PanelHeaderArtistsSection.ResumeLayout(false);
            PanelHeaderArtistsSection.PerformLayout();
            PanelArtworksSection.ResumeLayout(false);
            PanelHeaderArtworksSection.ResumeLayout(false);
            PanelHeaderArtworksSection.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxSearchBar;
        private Panel PanelSearchBar;
        private Panel PanelSearchResults;
        private TableLayoutPanel TableLayoutPanelSearchResults;
        private Panel PanelContent;
        private TableLayoutPanel tableLayoutPanelArtistResults;
        private Panel PanelArtworksSection;
        private Panel PanelArtistsSection;
        private Panel PanelHeaderArtworksSection;
        private Label LblArtworks;
        private Panel PanelHeaderArtistsSection;
        private Label LblArtists;
    }
}
