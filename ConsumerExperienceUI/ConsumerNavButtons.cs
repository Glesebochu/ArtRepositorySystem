using ArtRepositorySystem.ArtForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtRepositorySystem.ConsumerExperienceUI
{
    public partial class ConsumerNavButtons : UserControl
    {
        UserExperience currentExperience;
        public ConsumerNavButtons()
        {
            InitializeComponent();
        }

        private void BtnMyFeed_Click(object sender, EventArgs e)
        {
            //Database fetch for the specific feed of this user
            List<Art> arts = UserExperience.GetDummyArts();

            currentExperience.AddToPanelContent(new MyFeedPage(arts));
        }
        private void BtnTopArtists_Click(object sender, EventArgs e)
        {
            currentExperience.AddToPanelContent(new TopArtistsPage());
        }
        private void BtnTopArtworks_Click(object sender, EventArgs e)
        {
            currentExperience.AddToPanelContent(new TopArtworksPage());
        }
        private void BtnMyPlaylist_Click(object sender, EventArgs e)
        {
            currentExperience.AddToPanelContent(new MyPlaylistsPage());
        }
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            currentExperience.AddToPanelContent(new SettingsPage());
        }
        private void ConsumerExperienceNavButtons_Load(object sender, EventArgs e)
        {
            //Get the current UserExperience.
            currentExperience = (this.FindForm().Controls.Find("UserExperience", true)[0]) as UserExperience;
        }
    }
}
