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
            this.button1 = new System.Windows.Forms.Button();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelHeader.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.LblPageTitle.Text = "My Page";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 196);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.Transparent;
            this.PanelHeader.Controls.Add(this.LblPageTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Padding = new System.Windows.Forms.Padding(20);
            this.PanelHeader.Size = new System.Drawing.Size(1129, 84);
            this.PanelHeader.TabIndex = 2;
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.tableLayoutPanel1);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 84);
            this.PanelContent.Margin = new System.Windows.Forms.Padding(10);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Padding = new System.Windows.Forms.Padding(20);
            this.PanelContent.Size = new System.Drawing.Size(1129, 646);
            this.PanelContent.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1089, 606);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // MyFeedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelHeader);
            this.Name = "MyFeedPage";
            this.Size = new System.Drawing.Size(1129, 730);
            this.PanelHeader.ResumeLayout(false);
            this.PanelContent.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label LblPageTitle;
        private Button button1;
        private Panel PanelHeader;
        private Panel PanelContent;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
