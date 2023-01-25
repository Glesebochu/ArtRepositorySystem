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
    public partial class TopArtworksPage : UserControl
    {
        List<VisualArt>? visuals;
        public TopArtworksPage()
        {
            InitializeComponent();
        }

        private void TopArtworksPage_Load(object sender, EventArgs e)
        {
            //This will be replaced by a database fetch for the visuals that are rated as the top
            visuals = ConsumerExperience.GetDummyVisualArts();

            tableLayoutPanelAllArtworks.Controls.Remove(categoryTemplateDisplay1);
            tableLayoutPanelAllArtworks.Controls.Remove(categoryTemplateDisplay2);
            tableLayoutPanelAllArtworks.Controls.Remove(categoryTemplateDisplay3);

            categoryTemplateDisplay1 = new CategoryTemplateDisplay(PaintingGenre.Renaissance.ToString(), visuals);
            tableLayoutPanelAllArtworks.Controls.Add(categoryTemplateDisplay1);
            categoryTemplateDisplay1.Dock = DockStyle.Fill;
            categoryTemplateDisplay1.BringToFront();

            categoryTemplateDisplay2 = new CategoryTemplateDisplay(PaintingGenre.Rococo.ToString(), visuals);
            tableLayoutPanelAllArtworks.Controls.Add(categoryTemplateDisplay2);
            categoryTemplateDisplay2.Dock = DockStyle.Fill;
            categoryTemplateDisplay2.BringToFront();

            categoryTemplateDisplay3 = new CategoryTemplateDisplay(PaintingGenre.Surrealism.ToString(), visuals);
            tableLayoutPanelAllArtworks.Controls.Add(categoryTemplateDisplay3);
            categoryTemplateDisplay3.Dock = DockStyle.Fill;
            categoryTemplateDisplay3.BringToFront();

        }
    }
}
