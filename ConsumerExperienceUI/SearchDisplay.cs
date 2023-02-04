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
            //This will be replaced by a database fetch of a list of the recent searches the user made.
            List<User> artists = ConsumerExperience.GetDummyUsers();
            //Create a ResultsGrid object from the list of Users.
            ResultsGrid resultsGridArtists = new ResultsGrid(artists);
            //Add the ResultsGrid object to PanelArtistsSection.
            ConsumerExperience.AddToPanel(resultsGridArtists, PanelArtistsSection);

            //This will be replaced by a database fetch of a list of the recent searches the user made.
            List<VisualArt> visuals = Art.ToVisualArt(ConsumerExperience.GetDummyArts());
            //Create a ResultsGrid object from the list of VisualArts.
            ResultsGrid resultsGridArtworks = new ResultsGrid(visuals);
            //Add the ResultsGrid object to PanelArtworksSection.
            ConsumerExperience.AddToPanel(resultsGridArtworks, PanelArtworksSection);

        }
        //Event for hitting "Enter" after typing in a few characters in the text box.
        private void TextBoxSearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                //Call the search algorithm with the user's input here...

                //For confirmation purposes.
                MessageBox.Show($"You searched for: {TextBoxSearchBar.Text}.");
                
            }
        }
    }
}
