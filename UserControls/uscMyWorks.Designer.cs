namespace ArtRepositorySystem.UserControls
{
    partial class uscMyWorks
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
        public void InitializeComponent()
        {
            this.pnlContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContentPanel
            // 
            this.pnlContentPanel.AutoScroll = true;
            this.pnlContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlContentPanel.Name = "pnlContentPanel";
            this.pnlContentPanel.Size = new System.Drawing.Size(703, 467);
            this.pnlContentPanel.TabIndex = 0;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtSearchBox.BackColor = System.Drawing.Color.White;
            this.txtSearchBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearchBox.Location = new System.Drawing.Point(0, 0);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(257, 23);
            this.txtSearchBox.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 23;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(263, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 40);
            this.panel1.TabIndex = 1;
            // 
            // uscMyWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlContentPanel);
            this.Name = "uscMyWorks";
            this.Size = new System.Drawing.Size(703, 467);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel pnlContentPanel;
        private TextBox txtSearchBox;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Panel panel1;
    }
}
