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

    public partial class MyFeedPage : UserControl
    {
        //For testing purposes
        VisualArt? p;
        public MyFeedPage()
        {
            InitializeComponent();
            InitializeDummyObjects();
        }
        public void InitializeDummyObjects()
        {
            p = new VisualArt();
            p.Title = "The Total Liberation of Africa";
            p.Image = Properties.Resources.TheTotalLiberationOfAfrica;
            p.Description = @"
                In 1958, Ethiopian multi-disciplinary artist Afewerk Tekle created arguably his greatest work: a 
                stained-glass triptych entitled 'The Total Liberation of Africa', commissioned to be installed in 
                the newly established Africa Hall, the headquarters of the United Nations Economic Commission for 
                Africa, in Addis Ababa.
            ";
            p.Shape = VisualArtShape.Rectangle;

            User afewerk = new User();
            afewerk.Username = "afewerk_tekle";
            afewerk.FirstName = "Afewerk";
            afewerk.LastName = "Tekle";
            afewerk.Bio = "The Shit.";
            afewerk.Works = new List<Art>();
            afewerk.Works.Add(p);

            p.Artists = new List<User> { afewerk };
            
            button1.BackgroundImage = p.Image;
            
        }
        private Rectangle GetAvailableSpace()
        {
            Rectangle availableSpace = new Rectangle();
            availableSpace.Width = (int)(this.Width * 0.6);
            availableSpace.Height = (int)(this.Height * 0.6);
            availableSpace.X = (int)(this.Width * 0.2);
            availableSpace.Y = (int)(this.Height * 0.2);
            return availableSpace;
        }
        private Rectangle GetPanelForDisplay(VisualArt visualArt)
        {
            //The image that determines the size of the rectangle
            Image image = visualArt.Image;
            //The rectangle to be returned
            Rectangle requiredSize = new Rectangle();

            //The space available for displaying the art
            Rectangle availableSpace = GetAvailableSpace();

            //The x-to-y ratio of the image that represents the shape of the image mathematically
            double xToYRatio = Convert.ToDouble(image.Width) / image.Height;

            ///<summary>
            ///Calculating the size of the rectangle to be returned
            ///</summary>

            double availableSpaceToImageRatio;

            //Check which side of the image is longer
            if (image.Width > image.Height)
            {
                //For images whose width is longer than their height
                availableSpaceToImageRatio = Convert.ToDouble(availableSpace.Width) / image.Width;
                requiredSize.Width = availableSpace.Width;
                requiredSize.Height = (int)(image.Height * availableSpaceToImageRatio);
                requiredSize.X = availableSpace.X;

                //The difference between the height of the image and the available space
                int diffBetweenImageAndAvailableSpace = requiredSize.Height - availableSpace.Height;
                if (diffBetweenImageAndAvailableSpace < 0)
                {
                    requiredSize.Y = availableSpace.Y - diffBetweenImageAndAvailableSpace;
                }
                else
                {
                    requiredSize.Y = availableSpace.Y;
                }
            }
            else
            {
                //For images whose height is longer than their width 
                availableSpaceToImageRatio = Convert.ToDouble(availableSpace.Height) / image.Height;
                requiredSize.Height = availableSpace.Height;
                requiredSize.Width = (int)(image.Width * availableSpaceToImageRatio);
                requiredSize.Y = availableSpace.Y;

                //The difference between the width of the image and the available space
                int diffBetweenImageAndAvailableSpace = requiredSize.Width - availableSpace.Width;
                if (diffBetweenImageAndAvailableSpace < 0)
                {
                    requiredSize.X = availableSpace.X - diffBetweenImageAndAvailableSpace;
                }
                else
                {
                    requiredSize.X = availableSpace.X;
                }
            }

            ///<summary>
            ///Calculating the location of the rectangle
            ///</summary>


            return requiredSize;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Get an Art object based on the picture box that was clicked and make sure all its properties are filled
            //Create a new panel that hovers above everything
            //This panel is a card layout panel that has 4 cards {art, description & artist, feedback, analytic}
            // art
            // description & artist
            // feedback form
            // analytics
            //Buttons appear to the right and left of the panel for navigating through the cards
            // The button on the left is disabled when on page 1
            // The button on the right is disabled when on page 4

            PanelArtworkDisplay panelArtworkDisplay = new PanelArtworkDisplay(p);
            Rectangle panelForDisplay = GetPanelForDisplay(p);
            panelArtworkDisplay.Width = panelForDisplay.Width;
            panelArtworkDisplay.Height = panelForDisplay.Height;
            panelArtworkDisplay.Location = new Point(panelForDisplay.X, panelForDisplay.Y);
            panelArtworkDisplay.Anchor = AnchorStyles.None;
            panelArtworkDisplay.Dock = DockStyle.None;
            //panelArtworkDisplay.Location
            this.Controls.Add(panelArtworkDisplay);
            panelArtworkDisplay.BringToFront();


        }
    }
}
