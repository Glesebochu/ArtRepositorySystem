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
    public partial class TopArtistsPage : UserControl
    {
        public TopArtistsPage()
        {
            InitializeComponent();
        }

        private void TopArtistsPage_Load(object sender, EventArgs e)
        {
            //Will be replaced by a databse fetch of the top artists
            List<User> artists = ConsumerExperience.GetDummyUsers();

            //Create results grid of the top artists
            ResultsGrid resultsGrid = new ResultsGrid(artists);

            //Add the results grid to the content panel
            ConsumerExperience.AddToPanel(resultsGrid, PanelContentTopArtists);
        }
    }
}
