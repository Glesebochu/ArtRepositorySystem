using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtRepositorySystem.ArtForms;

namespace ArtRepositorySystem.ConsumerExperienceUI
{
    public partial class ArtworkCenterDisplay : UserControl
    {
        Art Art { get; set; }
        public ArtworkCenterDisplay(Art art)
        {
            InitializeComponent();
            this.Art = art;
        }

        private void CenterDisplay_Load(object sender, EventArgs e)
        {
            //Set the label representing the title of the artwork.
            LblArtworkTitle.Text = Art.Title;

            //Convert the Art object into a VisualArt object.
            VisualArt visualArt = (VisualArt)Art;
            
            //Set the background image of the artPage (tab in the TabControl) to the image of the VisualArt.
            artPage.BackgroundImage = visualArt.Image;
            //Set the layout of the background image of the artPage.
            artPage.BackgroundImageLayout = ImageLayout.Zoom;
            //Set the text of the TextBox representing the description of the art.
            textBoxDescription.Text = visualArt.Description;
            
        }

        private void CenterDisplay_Click(object sender, EventArgs e)
        {
            //Whenever the empty space around the TabControl is clicked,
            //hide this UserControl. This enables the user to easily return
            //to the page he/she was before clicking on the artwork to be viewed.
            this.Hide();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void feedbackPage_Click(object sender, EventArgs e)
        {

        }

        private void analyticsPage_Click(object sender, EventArgs e)
        {

        }

        private void feedbackPage_Click_1(object sender, EventArgs e)
        {

        }

        private void tabControlArtworkInfo_TabIndexChanged(object sender, EventArgs e)
        {
            FeedBackFormUi feedbackForm = new FeedBackFormUi();
            feedbackPage.BackColor = Color.LightGray;
            feedbackForm.Width = 850;
            feedbackForm.Height = 290;
            feedbackForm.Location = new Point(0, 0);
            feedbackPage.Controls.Add(feedbackForm);

        }
    }
}
