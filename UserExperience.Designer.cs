namespace ArtRepositorySystem
{
    partial class UserExperience
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SplitContainerAll = new SplitContainer();
            PanelNavButtons = new Panel();
            PanelNavAppInfo = new Panel();
            linkLabelAboutPage = new LinkLabel();
            label1 = new Label();
            LblAppName = new Label();
            PanelNavUserInfo = new Panel();
            LblUsername = new Label();
            LblFullName = new Label();
            guna2CirclePictureBoxProfilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ToggleSwitchMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            LblUserMode = new Label();
            PanelContent = new Panel();
            PanelHeader = new Panel();
            BtnNavigation = new Guna.UI2.WinForms.Guna2ImageButton();
            BtnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)SplitContainerAll).BeginInit();
            SplitContainerAll.Panel1.SuspendLayout();
            SplitContainerAll.Panel2.SuspendLayout();
            SplitContainerAll.SuspendLayout();
            PanelNavAppInfo.SuspendLayout();
            PanelNavUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBoxProfilePic).BeginInit();
            PanelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // SplitContainerAll
            // 
            SplitContainerAll.BackColor = SystemColors.ControlLightLight;
            SplitContainerAll.Dock = DockStyle.Fill;
            SplitContainerAll.FixedPanel = FixedPanel.Panel1;
            SplitContainerAll.Location = new Point(0, 0);
            SplitContainerAll.Name = "SplitContainerAll";
            // 
            // SplitContainerAll.Panel1
            // 
            SplitContainerAll.Panel1.AccessibleName = "PanelNavigation";
            SplitContainerAll.Panel1.Controls.Add(PanelNavButtons);
            SplitContainerAll.Panel1.Controls.Add(PanelNavAppInfo);
            SplitContainerAll.Panel1.Controls.Add(PanelNavUserInfo);
            // 
            // SplitContainerAll.Panel2
            // 
            SplitContainerAll.Panel2.AccessibleName = "PanelContent";
            SplitContainerAll.Panel2.AutoScroll = true;
            SplitContainerAll.Panel2.Controls.Add(PanelContent);
            SplitContainerAll.Panel2.Controls.Add(PanelHeader);
            SplitContainerAll.Size = new Size(1200, 715);
            SplitContainerAll.SplitterDistance = 244;
            SplitContainerAll.SplitterWidth = 5;
            SplitContainerAll.TabIndex = 8;
            // 
            // PanelNavButtons
            // 
            PanelNavButtons.BackColor = Color.Transparent;
            PanelNavButtons.Dock = DockStyle.Fill;
            PanelNavButtons.Location = new Point(0, 248);
            PanelNavButtons.Name = "PanelNavButtons";
            PanelNavButtons.Size = new Size(244, 368);
            PanelNavButtons.TabIndex = 17;
            // 
            // PanelNavAppInfo
            // 
            PanelNavAppInfo.BackColor = SystemColors.ControlLight;
            PanelNavAppInfo.Controls.Add(linkLabelAboutPage);
            PanelNavAppInfo.Controls.Add(label1);
            PanelNavAppInfo.Controls.Add(LblAppName);
            PanelNavAppInfo.Dock = DockStyle.Bottom;
            PanelNavAppInfo.Location = new Point(0, 616);
            PanelNavAppInfo.Name = "PanelNavAppInfo";
            PanelNavAppInfo.Size = new Size(244, 99);
            PanelNavAppInfo.TabIndex = 16;
            // 
            // linkLabelAboutPage
            // 
            linkLabelAboutPage.AutoSize = true;
            linkLabelAboutPage.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabelAboutPage.Location = new Point(118, 68);
            linkLabelAboutPage.Name = "linkLabelAboutPage";
            linkLabelAboutPage.Size = new Size(50, 20);
            linkLabelAboutPage.TabIndex = 1;
            linkLabelAboutPage.TabStop = true;
            linkLabelAboutPage.Text = "About";
            linkLabelAboutPage.VisitedLinkColor = Color.DarkOrchid;
            linkLabelAboutPage.LinkClicked += linkLabelAboutPage_LinkClicked;
            linkLabelAboutPage.Click += linkLabelAboutPage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 69);
            label1.Name = "label1";
            label1.Size = new Size(115, 17);
            label1.TabIndex = 0;
            label1.Text = "Version 1.0 x64 -";
            // 
            // LblAppName
            // 
            LblAppName.AutoSize = true;
            LblAppName.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LblAppName.Location = new Point(3, 47);
            LblAppName.Name = "LblAppName";
            LblAppName.Size = new Size(86, 22);
            LblAppName.TabIndex = 0;
            LblAppName.Text = "Mededa";
            // 
            // PanelNavUserInfo
            // 
            PanelNavUserInfo.BackColor = SystemColors.ControlLight;
            PanelNavUserInfo.Controls.Add(LblUsername);
            PanelNavUserInfo.Controls.Add(LblFullName);
            PanelNavUserInfo.Controls.Add(guna2CirclePictureBoxProfilePic);
            PanelNavUserInfo.Controls.Add(ToggleSwitchMode);
            PanelNavUserInfo.Controls.Add(LblUserMode);
            PanelNavUserInfo.Dock = DockStyle.Top;
            PanelNavUserInfo.Location = new Point(0, 0);
            PanelNavUserInfo.Name = "PanelNavUserInfo";
            PanelNavUserInfo.Size = new Size(244, 248);
            PanelNavUserInfo.TabIndex = 13;
            // 
            // LblUsername
            // 
            LblUsername.Anchor = AnchorStyles.None;
            LblUsername.AutoSize = true;
            LblUsername.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblUsername.ForeColor = SystemColors.ControlDarkDark;
            LblUsername.Location = new Point(76, 125);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(92, 18);
            LblUsername.TabIndex = 17;
            LblUsername.Text = "@username";
            LblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblFullName
            // 
            LblFullName.Anchor = AnchorStyles.None;
            LblFullName.AutoSize = true;
            LblFullName.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblFullName.Location = new Point(44, 91);
            LblFullName.Name = "LblFullName";
            LblFullName.Size = new Size(155, 18);
            LblFullName.TabIndex = 17;
            LblFullName.Text = "FirstName LastName";
            LblFullName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBoxProfilePic
            // 
            guna2CirclePictureBoxProfilePic.Anchor = AnchorStyles.None;
            guna2CirclePictureBoxProfilePic.Image = Properties.Resources.user_icon;
            guna2CirclePictureBoxProfilePic.ImageRotate = 0F;
            guna2CirclePictureBoxProfilePic.Location = new Point(95, 16);
            guna2CirclePictureBoxProfilePic.Name = "guna2CirclePictureBoxProfilePic";
            guna2CirclePictureBoxProfilePic.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBoxProfilePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBoxProfilePic.Size = new Size(55, 59);
            guna2CirclePictureBoxProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBoxProfilePic.TabIndex = 16;
            guna2CirclePictureBoxProfilePic.TabStop = false;
            // 
            // ToggleSwitchMode
            // 
            ToggleSwitchMode.Anchor = AnchorStyles.None;
            ToggleSwitchMode.Animated = true;
            ToggleSwitchMode.AutoRoundedCorners = true;
            ToggleSwitchMode.BackColor = Color.Transparent;
            ToggleSwitchMode.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ToggleSwitchMode.CheckedState.BorderRadius = 15;
            ToggleSwitchMode.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ToggleSwitchMode.CheckedState.InnerBorderColor = Color.White;
            ToggleSwitchMode.CheckedState.InnerBorderRadius = 11;
            ToggleSwitchMode.CheckedState.InnerColor = Color.White;
            ToggleSwitchMode.CustomizableEdges = customizableEdges2;
            ToggleSwitchMode.Location = new Point(90, 161);
            ToggleSwitchMode.Name = "ToggleSwitchMode";
            ToggleSwitchMode.ShadowDecoration.CustomizableEdges = customizableEdges3;
            ToggleSwitchMode.Size = new Size(64, 32);
            ToggleSwitchMode.TabIndex = 9;
            ToggleSwitchMode.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ToggleSwitchMode.UncheckedState.BorderRadius = 15;
            ToggleSwitchMode.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            ToggleSwitchMode.UncheckedState.InnerBorderColor = Color.White;
            ToggleSwitchMode.UncheckedState.InnerBorderRadius = 11;
            ToggleSwitchMode.UncheckedState.InnerColor = Color.White;
            ToggleSwitchMode.CheckedChanged += ToggleSwitchMode_CheckedChanged;
            // 
            // LblUserMode
            // 
            LblUserMode.Anchor = AnchorStyles.None;
            LblUserMode.AutoSize = true;
            LblUserMode.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LblUserMode.Location = new Point(111, 211);
            LblUserMode.Name = "LblUserMode";
            LblUserMode.Size = new Size(22, 19);
            LblUserMode.TabIndex = 14;
            LblUserMode.Text = "C";
            LblUserMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelContent
            // 
            PanelContent.AutoScroll = true;
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(0, 85);
            PanelContent.Margin = new Padding(10, 11, 10, 11);
            PanelContent.Name = "PanelContent";
            PanelContent.Padding = new Padding(21, 20, 21, 20);
            PanelContent.Size = new Size(951, 630);
            PanelContent.TabIndex = 10;
            // 
            // PanelHeader
            // 
            PanelHeader.Controls.Add(BtnNavigation);
            PanelHeader.Controls.Add(BtnSearch);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Padding = new Padding(21, 20, 21, 20);
            PanelHeader.Size = new Size(951, 85);
            PanelHeader.TabIndex = 9;
            // 
            // BtnNavigation
            // 
            BtnNavigation.BackColor = Color.Transparent;
            BtnNavigation.CheckedState.ImageSize = new Size(40, 40);
            BtnNavigation.Dock = DockStyle.Left;
            BtnNavigation.HoverState.ImageSize = new Size(45, 45);
            BtnNavigation.Image = Properties.Resources.menu_bar;
            BtnNavigation.ImageOffset = new Point(0, 0);
            BtnNavigation.ImageRotate = 0F;
            BtnNavigation.ImageSize = new Size(40, 40);
            BtnNavigation.Location = new Point(21, 20);
            BtnNavigation.Margin = new Padding(6, 5, 6, 5);
            BtnNavigation.Name = "BtnNavigation";
            BtnNavigation.PressedState.ImageSize = new Size(40, 40);
            BtnNavigation.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnNavigation.Size = new Size(57, 45);
            BtnNavigation.TabIndex = 9;
            BtnNavigation.Click += BtnNavigation_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.AccessibleRole = AccessibleRole.None;
            BtnSearch.BackColor = Color.Transparent;
            BtnSearch.CheckedState.ImageSize = new Size(40, 40);
            BtnSearch.Dock = DockStyle.Right;
            BtnSearch.HoverState.ImageSize = new Size(45, 45);
            BtnSearch.Image = Properties.Resources.loupe;
            BtnSearch.ImageOffset = new Point(0, 0);
            BtnSearch.ImageRotate = 0F;
            BtnSearch.ImageSize = new Size(35, 35);
            BtnSearch.Location = new Point(873, 20);
            BtnSearch.Margin = new Padding(6, 5, 6, 5);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.PressedState.ImageSize = new Size(40, 40);
            BtnSearch.ShadowDecoration.CustomizableEdges = customizableEdges5;
            BtnSearch.Size = new Size(57, 45);
            BtnSearch.TabIndex = 9;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // UserExperience
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLight;
            Controls.Add(SplitContainerAll);
            Name = "UserExperience";
            Size = new Size(1200, 715);
            Load += UserExperience_Load;
            SplitContainerAll.Panel1.ResumeLayout(false);
            SplitContainerAll.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerAll).EndInit();
            SplitContainerAll.ResumeLayout(false);
            PanelNavAppInfo.ResumeLayout(false);
            PanelNavAppInfo.PerformLayout();
            PanelNavUserInfo.ResumeLayout(false);
            PanelNavUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBoxProfilePic).EndInit();
            PanelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer SplitContainerAll;
        private Panel PanelHeader;
        private Panel PanelContent;
        private Label LblUserMode;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitchMode;
        private Panel PanelNavUserInfo;
        private Panel PanelNavAppInfo;
        private Guna.UI2.WinForms.Guna2ImageButton BtnNavigation;
        private Guna.UI2.WinForms.Guna2ImageButton BtnSearch;
        private Label LblFullName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxProfilePic;
        private Label label1;
        private Label LblAppName;
        private Label LblUsername;
        private LinkLabel linkLabelAboutPage;
        private Panel PanelNavButtons;
    }
}