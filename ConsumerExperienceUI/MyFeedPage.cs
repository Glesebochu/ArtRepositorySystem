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
        List<VisualArt>? visuals;
        List<Button>? buttonList;
        public MyFeedPage()
        {
            InitializeComponent();
        }

        private void MyFeedPage_Load(object sender, EventArgs e)
        {
            //This will be replaced by a database fetch for the artworks that are specific to the user
            visuals = ConsumerExperience.GetDummyObjects();
            buttonList = ConsumerExperience.CreateButtonsFromVisualArtworks(visuals);

            foreach(Button button in buttonList)
            {
                tableLayoutPanelAllArtworks.Controls.Add(button);
                button.Click += new System.EventHandler(buttonArtwork_Click);
                button.Dock = DockStyle.Fill;
            }
            //Stopped here...
        }
        
        private void buttonArtwork_Click(object sender, EventArgs e)
        {
            //Code for creating an Art object from a button
            Button btn = (Button)sender;
            VisualArt visualArt = (VisualArt)btn.Tag;
            new ConsumerExperience().CreateCenterDisplayFor(visualArt, (Panel)this.Parent);
        }
    }
}
