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
    public partial class PanelArtworkDisplay : UserControl
    {
        Art Art { get; set; }
        //public PanelArtworkDisplay()
        //{
        //    InitializeComponent();
        //}

        internal PanelArtworkDisplay(Art art)
        {
            InitializeComponent();
            Art = art;
        }

        private void PanelArtworkDisplay_Load(object sender, EventArgs e)
        {
            LblArtworkTitle.Text = Art.Title;
            VisualArt p = (VisualArt)Art;

            picBoxArtwork.BackgroundImage = p.Image;
            txtBoxDescription.Text = p.Description;

        }
    }
}
