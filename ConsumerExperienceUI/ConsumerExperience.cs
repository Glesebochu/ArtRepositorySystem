using System.Globalization;

namespace ArtRepositorySystem.ConsumerExperienceUI
{
    //Structure for storing the colors of the app's theme.
    public struct ColorThemes
    {
        public static Color NavigationPanel = Color.LightGray;
        public static Color ContentPanel = Color.White;
    }
    public partial class ConsumerExperience : UserControl
    {
        //For testing purposes
        User? ekele;
        
        public ConsumerExperience()
        {
            InitializeComponent();
        }
        private void ConsumerExperience_Load(object sender, EventArgs e)
        {
            ekele = new User();
            ekele.FirstName = "Yelelew";
            ekele.LastName = "Aymertim";
            ekele.Username = "ekele";
            LblUserMode.Text = ekele.userMode.ToString();
            LblFullName.Text = ekele.FirstName + " " + ekele.LastName;
            LblUsername.Text = "@" + ekele.Username;
        }
        private void addUserControl(UserControl userControl)
        {
            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }

        private void BtnMyFeed_Click(object sender, EventArgs e)
        {
            addUserControl(new MyFeedPage());
        }

        private void BtnTopArtists_Click(object sender, EventArgs e)
        {
            addUserControl(new TopArtistsPage());
        }

        private void BtnTopArtworks_Click(object sender, EventArgs e)
        {
            addUserControl(new TopArtworksPage());
        }

        private void BtnMyPlaylist_Click(object sender, EventArgs e)
        {
            addUserControl(new MyPlaylistsPage());
        }

        private void ToggleSwitchMode_CheckedChanged(object sender, EventArgs e)
        {
            ekele.SwitchMode();
            LblUserMode.Text = ekele.userMode.ToString();
        }


        private void BtnNavigation_Click(object sender, EventArgs e)
        {
            if(SplitContainerAll.Panel1.Visible == true)
            {
                SplitContainerAll.Panel1.Hide();
                SplitContainerAll.Panel2.Dock = DockStyle.Fill;
            }
            else
            {
                SplitContainerAll.Panel1.Show();
                SplitContainerAll.Panel2.Dock = DockStyle.None;
            }
        }


    }
}