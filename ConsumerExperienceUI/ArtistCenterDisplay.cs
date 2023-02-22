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
        public ArtistCenterDisplay(User artist)
        {
            InitializeComponent();
            this.Artist = artist;
            
        }
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        private void ArtistCenterDisplay_Load(object sender, EventArgs e)
        {
            //Set the text of the label representing the artist's name.
            LblArtistName.Text = $"{Artist.FirstName} {Artist.LastName}";

            //Fill the profile tab.
            Image ProfileImage = byteArrayToImage(Artist.ProfilePic);
            tabPageProfilePic.BackgroundImage = ProfileImage;
            tabPageProfilePic.BackgroundImageLayout = ImageLayout.Zoom;

            //Fill the bio tab.
            richTextBoxBio.Text = Artist.Bio;

            //Fill the works tab.
            int artistId = Artist.UserId;

            List<VisualArt> visualsFromArtist = Art.ToVisualArt(UserExperience.GetWorksOfArtist(artistId));

            //Get a list of CategoryTemplateDisplay objects from a list of VisualArt objects using 
            //the ConsumerExperience.GetCategoriesFromVisualArts() function.
            List<CategoryTemplateDisplay> categories = UserExperience.GetCategoriesFromVisualArts(visualsFromArtist);
            foreach (CategoryTemplateDisplay category in categories)
            {
                //Add each category to the TableLayoutPanel in this UserControl.
                UserExperience.AddToPanel(category, tableLayoutPanelArtistWorkCategories);
            }

        }

        private void ArtistCenterDisplay_Click(object sender, EventArgs e)
        {
            //Whenever the empty space around the TabControl is clicked,
            //hide this UserControl. This enables the user to easily return
            //to the page he/she was before clicking on the artist to be viewed.
            this.Hide();
        }
    }
}
