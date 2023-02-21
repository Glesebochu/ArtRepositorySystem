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
            guna2Button1.Visible = false;
            pictureBox1.Visible = true;

            // Show the open file dialog to allow the user to select an image file.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image file into a Bitmap object.
                Bitmap image = new Bitmap(openFileDialog.FileName);
                pictureBox1.BackgroundImage = image;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            VisualArt VA = new VisualArt();
            VA.Image = pictureBox1.Image;
            VA.Title = drakeuiTextBox1.Text; 
            VA.Description= drakeuiRichTextBox1.Text;
            VA.Genre = guna2ComboBox1.Text;


            if (guna2ComboBox2.Text == "Painting")
            {
                VA.VisualArtType = VisualArtType.Painting;
            }
            else if (guna2ComboBox2.Text == "Photograph")
            {
                VA.VisualArtType = VisualArtType.Photograph;
            }
            else if (guna2ComboBox2.Text == "Building")
            {
                VA.VisualArtType = VisualArtType.Building;
            }
            else if (guna2ComboBox2.Text == "NonBuildingStructureg")
            {
                VA.VisualArtType = VisualArtType.NonBuildingStructure;
            }
            else if (guna2ComboBox2.Text == "Ceramic")
            {
                VA.VisualArtType = VisualArtType.Ceramic;
            }
            else if (guna2ComboBox2.Text == "Film")
            {
                VA.VisualArtType = VisualArtType.Film;
            }
            else if (guna2ComboBox2.Text == "Sculpture")
            {
                VA.VisualArtType = VisualArtType.Sculpture;
            }
            else if (guna2ComboBox2.Text == "Drawing")
            {
                VA.VisualArtType = VisualArtType.Drawing;
            }

            MessageBox.Show(VA.VisualArtType.ToString());

        }
    }
}
