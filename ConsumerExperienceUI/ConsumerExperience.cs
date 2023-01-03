using System.Globalization;

namespace ArtRepositorySystem.ConsumerExperienceUI
{
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
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(userControl);
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

    }
}