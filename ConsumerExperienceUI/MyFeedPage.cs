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
        List<VisualArt>? visuals;
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
            
            //button1.BackgroundImage = p.Image;

            visuals = new List<VisualArt>();
            visuals.Add(p);
            visuals.Add(p);
            visuals.Add(p);
            visuals.Add(p);
            visuals.Add(p);
            visuals.Add(p);
        }
        private void CreateCenterDisplayFor(Art art)
        {
            //Get the major form
            Form mainForm = this.FindForm();
            //Create center display
            CenterDisplay centerDisplay = new CenterDisplay(art);
            
            //Set the paddding of this userControl to 20% of the form's dimensions (x and y)
            int xPadding = (int)(mainForm.Width * 0.2);
            int yPadding = (int)(mainForm.Height * 0.2);
            centerDisplay.Padding = new Padding(xPadding, (yPadding/2), xPadding, yPadding);

            centerDisplay.Dock = DockStyle.Fill;

            mainForm.Controls.Add(centerDisplay);
            centerDisplay.BringToFront();

        }
        private List<Button> CreateButtonsFromVisualArtworks(List<VisualArt> visualArts)
        {
            List<Button> buttonList = new List<Button>();
            for(int i=0; i < visualArts.Count(); i++)
            {
                buttonList.ElementAt(i).BackgroundImage = visualArts.ElementAt(i).Image;
                buttonList.ElementAt(i).Text = "";
            }

            return buttonList;
        }
        private void buttonArtwork_Click(object sender, EventArgs e)
        {
            //Get an Art object based on the picture box that was clicked and make sure all its properties are filled
            //Create a new panel that hovers above everything
            //This panel is a card layout panel that has 4 cards {art, description & artist, feedback, analytic}
            // art
            // description & artist
            // feedback form
            // analytics

            CreateCenterDisplayFor(p);
        }

        private void MyFeedPage_Load(object sender, EventArgs e)
        {
            List<Button> buttonList = CreateButtonsFromVisualArtworks(visuals);
            //tableLayoutPanelAllArtworks.Controls.AddRange();

            //Stopped here...
        }
    }
}
