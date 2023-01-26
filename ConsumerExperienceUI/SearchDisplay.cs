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
    public partial class SearchDisplay : UserControl
    {
        public SearchDisplay()
        {
            InitializeComponent();
        }

        private void SearchDisplay_Load(object sender, EventArgs e)
        {
            //This will be replaced by a database fetch
            //Maybe a list of the recent searches the user made
            ResultsGrid resultsGridArtists = new ResultsGrid(ConsumerExperience.GetDummyUsers());
            ConsumerExperience.AddToPanel(resultsGridArtists, PanelArtistsSection);

            List<VisualArt> visuals = Art.ToVisualArt(ConsumerExperience.GetDummyArts());
            ResultsGrid resultsGridArtworks = new ResultsGrid(visuals);
            ConsumerExperience.AddToPanel(resultsGridArtworks, PanelArtworksSection);

        }

        private void TextBoxSearchBar_Click(object sender, EventArgs e)
        {
            TextBoxSearchBar.ForeColor = Color.Black;
        }

        private void TextBoxSearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Call the search algorithm with the user's input
                MessageBox.Show($"You searched for: {TextBoxSearchBar.Text}.");
                
            }
        }
    }
}
