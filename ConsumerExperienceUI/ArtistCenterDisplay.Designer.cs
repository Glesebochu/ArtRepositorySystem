namespace ArtRepositorySystem.ConsumerExperienceUI
{
    partial class ArtistCenterDisplay
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
            this.richTextBoxBio = new System.Windows.Forms.RichTextBox();
            this.tabControlArtistInfo = new System.Windows.Forms.TabControl();
            this.tabPageProfilePic = new System.Windows.Forms.TabPage();
            this.tabPageBio = new System.Windows.Forms.TabPage();
            this.tabPageWorks = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelArtistWorkCategories = new System.Windows.Forms.TableLayoutPanel();
            this.LblArtistName = new System.Windows.Forms.Label();
            this.tabControlArtistInfo.SuspendLayout();
            this.tabPageBio.SuspendLayout();
            this.tabPageWorks.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxBio
            // 
            this.richTextBoxBio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxBio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxBio.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxBio.Name = "richTextBoxBio";
            this.richTextBoxBio.ReadOnly = true;
            this.richTextBoxBio.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxBio.Size = new System.Drawing.Size(800, 389);
            this.richTextBoxBio.TabIndex = 1;
            this.richTextBoxBio.Text = "";
            // 
            // tabControlArtistInfo
            // 
            this.tabControlArtistInfo.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlArtistInfo.Controls.Add(this.tabPageProfilePic);
            this.tabControlArtistInfo.Controls.Add(this.tabPageBio);
            this.tabControlArtistInfo.Controls.Add(this.tabPageWorks);
            this.tabControlArtistInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlArtistInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControlArtistInfo.ItemSize = new System.Drawing.Size(75, 50);
            this.tabControlArtistInfo.Location = new System.Drawing.Point(110, 189);
            this.tabControlArtistInfo.Multiline = true;
            this.tabControlArtistInfo.Name = "tabControlArtistInfo";
            this.tabControlArtistInfo.Padding = new System.Drawing.Point(40, 3);
            this.tabControlArtistInfo.SelectedIndex = 0;
            this.tabControlArtistInfo.Size = new System.Drawing.Size(814, 453);
            this.tabControlArtistInfo.TabIndex = 1;
            // 
            // tabPageProfilePic
            // 
            this.tabPageProfilePic.BackColor = System.Drawing.Color.Transparent;
            this.tabPageProfilePic.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPageProfilePic.Location = new System.Drawing.Point(4, 54);
            this.tabPageProfilePic.Name = "tabPageProfilePic";
            this.tabPageProfilePic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfilePic.Size = new System.Drawing.Size(806, 395);
            this.tabPageProfilePic.TabIndex = 0;
            this.tabPageProfilePic.Text = "Profile";
            // 
            // tabPageBio
            // 
            this.tabPageBio.BackColor = System.Drawing.Color.Transparent;
            this.tabPageBio.Controls.Add(this.richTextBoxBio);
            this.tabPageBio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPageBio.Location = new System.Drawing.Point(4, 54);
            this.tabPageBio.Name = "tabPageBio";
            this.tabPageBio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBio.Size = new System.Drawing.Size(806, 395);
            this.tabPageBio.TabIndex = 1;
            this.tabPageBio.Text = "Bio";
            // 
            // tabPageWorks
            // 
            this.tabPageWorks.BackColor = System.Drawing.Color.Transparent;
            this.tabPageWorks.Controls.Add(this.tableLayoutPanelArtistWorkCategories);
            this.tabPageWorks.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPageWorks.Location = new System.Drawing.Point(4, 54);
            this.tabPageWorks.Name = "tabPageWorks";
            this.tabPageWorks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorks.Size = new System.Drawing.Size(806, 395);
            this.tabPageWorks.TabIndex = 2;
            this.tabPageWorks.Text = "Works";
            // 
            // tableLayoutPanelArtistWorkCategories
            // 
            this.tableLayoutPanelArtistWorkCategories.AutoScroll = true;
            this.tableLayoutPanelArtistWorkCategories.AutoSize = true;
            this.tableLayoutPanelArtistWorkCategories.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelArtistWorkCategories.ColumnCount = 1;
            this.tableLayoutPanelArtistWorkCategories.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelArtistWorkCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelArtistWorkCategories.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelArtistWorkCategories.Name = "tableLayoutPanelArtistWorkCategories";
            this.tableLayoutPanelArtistWorkCategories.RowCount = 1;
            this.tableLayoutPanelArtistWorkCategories.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelArtistWorkCategories.Size = new System.Drawing.Size(800, 389);
            this.tableLayoutPanelArtistWorkCategories.TabIndex = 0;
            // 
            // LblArtistName
            // 
            this.LblArtistName.AutoEllipsis = true;
            this.LblArtistName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblArtistName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblArtistName.Location = new System.Drawing.Point(110, 110);
            this.LblArtistName.Name = "LblArtistName";
            this.LblArtistName.Size = new System.Drawing.Size(814, 79);
            this.LblArtistName.TabIndex = 2;
            this.LblArtistName.Text = "...";
            this.LblArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArtistCenterDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabControlArtistInfo);
            this.Controls.Add(this.LblArtistName);
            this.Name = "ArtistCenterDisplay";
            this.Padding = new System.Windows.Forms.Padding(110);
            this.Size = new System.Drawing.Size(1034, 752);
            this.Load += new System.EventHandler(this.ArtistCenterDisplay_Load);
            this.Click += new System.EventHandler(this.ArtistCenterDisplay_Click);
            this.tabControlArtistInfo.ResumeLayout(false);
            this.tabPageBio.ResumeLayout(false);
            this.tabPageWorks.ResumeLayout(false);
            this.tabPageWorks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RichTextBox richTextBoxBio;
        private TabControl tabControlArtistInfo;
        private TabPage tabPageProfilePic;
        private TabPage tabPageBio;
        private TabPage tabPageWorks;
        private Label LblArtistName;
        private TableLayoutPanel tableLayoutPanelArtistWorkCategories;
    }
}
