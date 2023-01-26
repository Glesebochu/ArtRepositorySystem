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

        private void App_Load(object sender, EventArgs e)
        {
            //Get user object from login page
            User ekele = new User();
            ekele.FirstName = "Yelelew";
            ekele.LastName = "Aymertim";
            ekele.Username = "ekele";
            ekele.ProfilePic = Properties.Resources.Afewerk_Tekle;

            ConsumerExperience consumerExperience = new ConsumerExperience(ekele);
            this.Controls.Add(consumerExperience);
            consumerExperience.Dock = DockStyle.Fill;
        }
    }
}
