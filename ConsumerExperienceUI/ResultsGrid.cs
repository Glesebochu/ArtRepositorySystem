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
    enum TypeOfDataToBeDisplayed
    {
        VisualArt,
        User
    }
    public partial class ResultsGrid : UserControl
    {
        private List<Button>? buttonList;
        private List<User>? artists;
        private List<VisualArt>? visuals;
        private TypeOfDataToBeDisplayed typeOfDataToBeDisplayed;
        public ResultsGrid()
        {
            InitializeComponent();
        }
        public ResultsGrid(List<User> toBeDisplayed)
        {
            InitializeComponent();
            artists = toBeDisplayed;
            typeOfDataToBeDisplayed = TypeOfDataToBeDisplayed.User;
            PopulateResultsGrid();
        }
        public ResultsGrid(List<VisualArt> toBeDisplayed)
        {
            InitializeComponent();
            visuals = toBeDisplayed;
            typeOfDataToBeDisplayed = TypeOfDataToBeDisplayed.VisualArt;
            PopulateResultsGrid();
        }

        private void ResultsGrid_Load(object sender, EventArgs e)
        {
            PopulateResultsGrid();
        }
        private void PopulateResultsGrid()
        {
            //If the object created was an empty one
            if (visuals != null || artists != null)
            {
                //Check which constructor was used to create the object
                if (typeOfDataToBeDisplayed == TypeOfDataToBeDisplayed.VisualArt)
                {
                    //VisualArts were sent
                    buttonList = ConsumerExperience.CreateButtonsFromVisualArtworks(visuals);
                    for (int i = 0; i < buttonList.Count(); i++)
                    {
                        //Associate the specific visual art with the button to make the artist accessible in the event
                        buttonList[i].Tag = visuals[i];
                    }
                }
                else
                {
                    //Users were sent
                    buttonList = ConsumerExperience.CreateButtonsFromUsers(artists);
                    for (int i = 0; i < buttonList.Count(); i++)
                    {
                        //Associate the specific artist with the button to make the artist accessible in the event
                        buttonList[i].Tag = artists[i];
                    }
                }

                for(int i=0; i<buttonList.Count(); i++)
                {
                    //Adding the buttonResult_Click event to the button's list of events
                    buttonList[i].Click += new System.EventHandler(buttonResult_Click);
                    //Defining the minimum size of the button to avoid unnecessary shrinking
                    buttonList[i].MinimumSize = new Size(200,200);
                    //Adding the button to the table layout panel
                    tableLayoutPanelResults.Controls.Add(buttonList[i]);
                    //Setting the button's Dock property to Fill (so that it can occupy all the space in the cell)
                    buttonList[i].Dock = DockStyle.Fill;
                    //Adding space between each button by defining its margin
                    buttonList[i].Margin = new Padding(5,5,5,5);
                }
                
            }

        }
        private void buttonResult_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (typeOfDataToBeDisplayed == TypeOfDataToBeDisplayed.VisualArt)
            {
                //VisualArts were sent
                //Code for extracting an Art object from a button
                VisualArt visualArt = (VisualArt)btn.Tag;

                //Get the PanelContent that is found in ConsumerExperience
                Panel requiredPanel = (Panel)(this.FindForm().Controls.Find("PanelContent", true)[0]);
                
                //Create a center display for the visual art
                ConsumerExperience.CreateCenterDisplayFor(visualArt, requiredPanel);
            }
            else
            {
                //Users were sent
                //Code for extracting a User object from a button
                User user = (User)btn.Tag;

                //Get the PanelContent that is found in ConsumerExperience
                Panel requiredPanel = (Panel)(this.FindForm().Controls.Find("PanelContent", true)[0]);

                //Code for displaying an artist on the center of the screen
                //...
            }

        }
    }
}
