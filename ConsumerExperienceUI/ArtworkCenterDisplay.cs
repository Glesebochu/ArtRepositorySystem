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
            Art = art;
        }

        private void CenterDisplay_Load(object sender, EventArgs e)
        {
            LblArtworkTitle.Text = Art.Title;
            VisualArt visualArt = (VisualArt)Art;

            //tabControlArtworkInfo.Size = new Size(visualArt.Image.Width,visualArt.Image.Height);
            //The above wont work because the tab control is docked to fill.

            //picBoxArtwork.BackgroundImage = visualArt.Image;
            artPage.BackgroundImage = visualArt.Image;
            artPage.BackgroundImageLayout = ImageLayout.Zoom;
            textBoxDescription.Text = visualArt.Description;
            
            //Stopped here...
            
        }

        private void CenterDisplay_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
