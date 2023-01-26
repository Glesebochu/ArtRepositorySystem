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
using ArtRepositorySystem.ArtForms.VisualArts;

namespace ArtRepositorySystem.ConsumerExperienceUI
{
    public partial class TopArtworksPage : UserControl
    {
        List<Art>? arts;
        public TopArtworksPage()
        {
            InitializeComponent();
        }

        private void TopArtworksPage_Load(object sender, EventArgs e)
        {
            //This will be replaced by a database fetch for the arts that are specific to the user
            arts = ConsumerExperience.GetDummyArts();

            //Convert art objects into visual art objects
            List<VisualArt> visuals = Art.ToVisualArt(arts);

            //Possible algorithm for picking the top ranking artworks
            //ConsumerExperience.GetDummyArts().FindAll(top => top.Analytics[0] > 500);

            //Get a list of categories based on the visual arts sent
            List<CategoryTemplateDisplay> categories = ConsumerExperience.GetCategoriesFromVisualArts(visuals);

            //Add each category to the table layout panel
            foreach (CategoryTemplateDisplay c in categories)
            {
                ConsumerExperience.AddToPanel(c, tableLayoutPanelAllArtworks);
            }
        }
    }
}
