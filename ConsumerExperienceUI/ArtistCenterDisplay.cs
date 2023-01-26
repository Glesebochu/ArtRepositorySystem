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
    public partial class ArtistCenterDisplay : UserControl
    {
        User Artist;
        //public ArtistCenterDisplay()
        //{
        //    InitializeComponent();
        //}
        public ArtistCenterDisplay(User artist)
        {
            InitializeComponent();
            this.Artist = artist;
            LblArtistName.Text = $"{artist.FirstName} {artist.LastName}";
        }

        private void ArtistCenterDisplay_Load(object sender, EventArgs e)
        {
            //Fill the profile tab
            tabPageProfilePic.BackgroundImage = Artist.ProfilePic;
            tabPageProfilePic.BackgroundImageLayout = ImageLayout.Zoom;

            //Fill the bio tab
            richTextBoxBio.Text = Artist.Bio;

            //Fill the works tab
            //This will be replaced with a database fetch
            List<VisualArt> visualsFromArtist = Art.ToVisualArt(Artist.Works);
            
            List<CategoryTemplateDisplay> categories = ConsumerExperience.GetCategoriesFromVisualArts(visualsFromArtist);
            foreach (CategoryTemplateDisplay category in categories)
            {
                ConsumerExperience.AddToPanel(category, tableLayoutPanelArtistWorkCategories);
            }

        }

        private void ArtistCenterDisplay_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
