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
    //An enumeration for holding the type of data to be displayed by the ResultsGrid.
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
        public ResultsGrid(List<User> toBeDisplayed)
        {
            InitializeComponent();
            artists = toBeDisplayed;
            //Set the typeOfDataToBeDisplayed property to User.
            typeOfDataToBeDisplayed = TypeOfDataToBeDisplayed.User;
        }
        public ResultsGrid(List<VisualArt> toBeDisplayed)
        {
            InitializeComponent();
            visuals = toBeDisplayed;
            //Set the typeOfDataToBeDisplayed property to VisualArt.
            typeOfDataToBeDisplayed = TypeOfDataToBeDisplayed.VisualArt;
        }

        private void ResultsGrid_Load(object sender, EventArgs e)
        {
            PopulateResultsGrid();
        }
        private void PopulateResultsGrid()
        {
            //If the object created was not empty
            if (visuals != null || artists != null)
            {
                //Check which constructor was used to create the object
                if (typeOfDataToBeDisplayed == TypeOfDataToBeDisplayed.VisualArt)
                {
                    //VisualArts were sent
                    //Use the ConsumerExperience.CreateButtonsFromVisualArtworks() function to create Buttons from VisualArt objects.
                    buttonList = ConsumerExperience.CreateButtonsFromVisualArtworks(visuals);
                    for (int i = 0; i < buttonList.Count(); i++)
                    {
                        //Associate the specific visual art with the button to make the Artist accessible in the event
                        buttonList[i].Tag = visuals[i];
                    }
                }
                else
                {
                    //Users were sent
                    //Use the ConsumerExperience.CreateButtonsFromVisualArtworks() function to create Buttons from User objects.
                    buttonList = ConsumerExperience.CreateButtonsFromUsers(artists);
                    for (int i = 0; i < buttonList.Count(); i++)
                    {
                        //Associate the specific Artist with the button to make the Artist accessible in the event
                        buttonList[i].Tag = artists[i];
                    }
                }

                for(int i=0; i<buttonList.Count(); i++)
                {
                    //Adding the buttonResult_Click event to the button's list of events
                    buttonList[i].Click += new System.EventHandler(buttonResult_Click);
                    //Defining the minimum size of the button to avoid unnecessary shrinking
                    buttonList[i].MinimumSize = new Size(250,200);
                    //Adding the button to the table layout panel
                    tableLayoutPanelResults.Controls.Add(buttonList[i]);
                    //Setting the button's Dock property to Fill (so that it can occupy all the space in the cell)
                    buttonList[i].Dock = DockStyle.Fill;
                    //Adding space between each button by defining its margin
                    buttonList[i].Margin = new Padding(5,5,5,5);
                }
                
            }

        }
        //Event that is associated with all artwork or artist buttons.
        //It displays the artist or the artwork in the center of the screen.
        private void buttonResult_Click(object sender, EventArgs e)
        {
            //Get the PanelContent that is found in ConsumerExperience
            Panel requiredPanel = (Panel)(this.FindForm().Controls.Find("PanelContent", true)[0]);

            Button btn = (Button)sender;
            if (typeOfDataToBeDisplayed == TypeOfDataToBeDisplayed.VisualArt)
            {
                //VisualArts were sent
                //Code for extracting a VisualArt object from a button
                VisualArt visualArt = (VisualArt)btn.Tag;
                
                //Create a center display for the visual art
                ConsumerExperience.CreateCenterDisplayForArt(visualArt, requiredPanel);
            }
            else
            {
                //Users were sent
                //Code for extracting a User object from a button
                User artist = (User)btn.Tag;

                //Create a center display for the artist
                ConsumerExperience.CreateCenterDisplayForArtist(artist, requiredPanel);
            }

        }
    }
}
