using ArtRepositorySystem.ConsumerExperienceUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtRepositorySystem
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void App_Load(object sender, EventArgs e)
        {
            //This will be replaced by the verified User object from the Login page.
            //Create User object.
            User ekele = new User();
            ekele.FirstName = "Yelelew";
            ekele.LastName = "Aymertim";
            ekele.Username = "ekele";
            Image DispalayedImage5 = Properties.Resources.Afewerk_Tekle;
            byte[] byteImage5 = ImageToByteArray(DispalayedImage5);
            ekele.ProfilePic = byteImage5;

            //Create a ConsumerExperience object from the User object.
            ConsumerExperience consumerExperience = new ConsumerExperience(ekele);
            //Add the ConsumerExperience object to this Form.
            this.Controls.Add(consumerExperience);
            //Set the Dock property of the ConsumerExperience object to Fill.
            consumerExperience.Dock = DockStyle.Fill;
        }
    }
}
