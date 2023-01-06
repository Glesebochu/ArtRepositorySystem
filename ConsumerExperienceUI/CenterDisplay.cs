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
    public partial class CenterDisplay : UserControl
    {
        Art? Art { get; set; }
        public CenterDisplay()
        {
            InitializeComponent();
        }

        internal CenterDisplay(Art art)
        {
            InitializeComponent();
            Art = art;
        }

        private void CenterDisplay_Load(object sender, EventArgs e)
        {
            LblArtworkTitle.Text = Art.Title;
            VisualArt p = (VisualArt)Art;

            //tabControlArtworkInfo.Size = new Size(p.Image.Width,p.Image.Height);
            //The above wont work because the tab control is docked to fill.

            //picBoxArtwork.BackgroundImage = p.Image;
            artPage.BackgroundImage = p.Image;
            artPage.BackgroundImageLayout = ImageLayout.Zoom;
            textBoxDescription.Text = p.Description;
            
            //Stopped here...
            
        }

        private void CenterDisplay_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
