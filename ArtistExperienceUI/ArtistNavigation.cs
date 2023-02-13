using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtRepositorySystem.ConsumerExperienceUI;

namespace ArtRepositorySystem.ArtistExperienceUI
{
    public partial class ArtistNavigation : UserControl
    {
        public ArtistNavigation()
        {
            InitializeComponent();
        }

        private void btnMyWorks_Click(object sender, EventArgs e)
        {
            ConsumerExperience currentExperience = Application.OpenForms.OfType<ConsumerExperience>().FirstOrDefault();
            currentExperience.Visible = false;
            
            
        }
    }
}
