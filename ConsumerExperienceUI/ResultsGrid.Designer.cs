namespace ArtRepositorySystem.ConsumerExperienceUI
{
    partial class ResultsGrid
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
            this.tableLayoutPanelResults = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanelResults
            // 
            this.tableLayoutPanelResults.AutoScroll = true;
            this.tableLayoutPanelResults.ColumnCount = 3;
            this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelResults.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanelResults.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelResults.MinimumSize = new System.Drawing.Size(400, 400);
            this.tableLayoutPanelResults.Name = "tableLayoutPanelResults";
            this.tableLayoutPanelResults.RowCount = 3;
            this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelResults.Size = new System.Drawing.Size(957, 554);
            this.tableLayoutPanelResults.TabIndex = 3;
            // 
            // ResultsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelResults);
            this.Name = "ResultsGrid";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(997, 594);
            this.Load += new System.EventHandler(this.ResultsGrid_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanelResults;
    }
}
