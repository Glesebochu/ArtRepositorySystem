using ArtRepositorySystem.ArtForms;

using ArtRepositorySystem.ArtForms.VisualArts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtRepositorySystem.ArtistExperienceUI
{
    public partial class Upload : UserControl
    {
        
        public Upload()
        {
            InitializeComponent();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btnImage.Visible = false;
            pictureBox1.Visible = true;

            // Show the open file dialog to allow the user to select an image file.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image file into a Bitmap object.
                Bitmap image = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = image;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            VisualArt VA = new VisualArt();
            UserExperience.currentUser.FirstName = "test";
            VA.Artists = new List<User> { UserExperience.currentUser };
            VA.Image = UserExperience.ImageToByteArray(pictureBox1.Image);
            VA.Title = txtTitle.Text; 
            VA.Description= txtDescription.Text;
            VA.Genre = cmbGenre.Text;


            if (cmbVisualArtType.Text == "Painting")
            {
                VA.VisualArtType = VisualArtType.Painting;
            }
            else if (cmbVisualArtType.Text == "Photograph")
            {
                VA.VisualArtType = VisualArtType.Photograph;
            }
            else if (cmbVisualArtType.Text == "Building")
            {
                VA.VisualArtType = VisualArtType.Building;
            }
            else if (cmbVisualArtType.Text == "NonBuildingStructureg")
            {
                VA.VisualArtType = VisualArtType.NonBuildingStructure;
            }
            else if (cmbVisualArtType.Text == "Ceramic")
            {
                VA.VisualArtType = VisualArtType.Ceramic;
            }
            else if (cmbVisualArtType.Text == "Film")
            {
                VA.VisualArtType = VisualArtType.Film;
            }
            else if (cmbVisualArtType.Text == "Sculpture")
            {
                VA.VisualArtType = VisualArtType.Sculpture;
            }
            else if (cmbVisualArtType.Text == "Drawing")
            {
                VA.VisualArtType = VisualArtType.Drawing;
            }
            else
            {
                MessageBox.Show("Did you choose a visual art type?");
            }

            if (UserExperience.currentUser != null)
            {
                using (MededaContext mededaContext = new MededaContext())
                {
                    List<int> id = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    FeedbackForm DefaultFeedBackForm = mededaContext.FeedbackForm.SingleOrDefault
                        (DefaultFeedBackForm => DefaultFeedBackForm.FeedbackFromId == 3);
                    VA.FeedbackForm = DefaultFeedBackForm;
                    mededaContext.VisualArts.Add(VA);
                    mededaContext.SaveChanges();
                }
            }

        }
    }
}
