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
            this.SuspendLayout();
            // 
            // LblPageTitle
            // 
            this.LblPageTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPageTitle.Location = new System.Drawing.Point(28, 32);
            this.LblPageTitle.Name = "LblPageTitle";
            this.LblPageTitle.Size = new System.Drawing.Size(175, 41);
            this.LblPageTitle.TabIndex = 0;
            this.LblPageTitle.Text = "My Page";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 115);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MyFeedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblPageTitle);
            this.Name = "MyFeedPage";
            this.Size = new System.Drawing.Size(689, 496);
            this.ResumeLayout(false);

        }

        #endregion

        private Label LblPageTitle;
        private Button button1;
    }
}
