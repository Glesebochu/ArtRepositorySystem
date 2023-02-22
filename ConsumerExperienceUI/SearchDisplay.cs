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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ArtRepositorySystem.ConsumerExperienceUI
{
    public partial class SearchDisplay : UserControl
    {
        ResultsGrid? resultsGridArtists;
        ResultsGrid? resultsGridArtworks;
        public SearchDisplay()
        {
            InitializeComponent();
        }

        private void SearchDisplay_Load(object sender, EventArgs e)
        {
            //This will be replaced by a database fetch of a list of the recent searches the user made.
            List<User> artists = UserExperience.GetDummyUsers();
            //Create a ResultsGrid object from the list of Users.
            resultsGridArtists = new ResultsGrid(artists);
            //Add the ResultsGrid object to PanelArtistsSection.
            UserExperience.AddToPanel(resultsGridArtists, PanelArtistsSection);

            //This will be replaced by a database fetch of a list of the recent searches the user made.
            List<VisualArt> visuals = Art.ToVisualArt(UserExperience.GetDummyArts());
            //Create a ResultsGrid object from the list of VisualArts.
            resultsGridArtworks = new ResultsGrid(visuals);
            //Add the ResultsGrid object to PanelArtworksSection.
            UserExperience.AddToPanel(resultsGridArtworks, PanelArtworksSection);

        }
        //Event for hitting "Enter" after typing in a few characters in the text box.
        private void TextBoxSearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Call the search algorithm with the user's input here...

                MededaContext searchedArtsContext= new MededaContext();
                List<VisualArt> searchedArts = (from artworks in searchedArtsContext.VisualArts
                                               where artworks.Description.Contains(TextBoxSearchBar.Text.ToString())
                                               || artworks.Title.Contains(TextBoxSearchBar.Text.ToString())
                                                select artworks).ToList();

                List<User> searchedArtists = (from artists in searchedArtsContext.Users
                                              where artists.FirstName.Contains(TextBoxSearchBar.Text.ToString())
                                              || artists.LastName.Contains(TextBoxSearchBar.Text.ToString())
                                              || artists.Bio.Contains(TextBoxSearchBar.Text.ToString())
                                              select artists).ToList();

                //Clear the contents of the default search display
                PanelArtistsSection.Controls.Remove(resultsGridArtists);
                PanelArtworksSection.Controls.Remove(resultsGridArtworks);

                //Create a ResultsGrid object from the list of Users.
                resultsGridArtists = new ResultsGrid(searchedArtists);
                //Add the ResultsGrid object to PanelArtistsSection.
                //UserExperience.AddToPanel(resultsGridArtists, PanelArtistsSection);

                //Create a ResultsGrid object from the list of VisualArts.
                resultsGridArtworks = new ResultsGrid(searchedArts);
                //Add the ResultsGrid object to PanelArtworksSection.
                UserExperience.AddToPanel(resultsGridArtworks, PanelArtworksSection);


                
            }
        }
    }
}
