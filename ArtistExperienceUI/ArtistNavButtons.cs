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
using ArtRepositorySystem.ConsumerExperienceUI;

namespace ArtRepositorySystem.ArtistExperienceUI
{
    public partial class ArtistNavButtons : UserControl
    {
        UserExperience currentExperience;
        public ArtistNavButtons()
        {
            InitializeComponent();
        }

        private void ArtistNavButtons_Load(object sender, EventArgs e)
        {
            //Get the current UserExperience.
            currentExperience = (this.FindForm().Controls.Find("UserExperience", true)[0]) as UserExperience;
        }

        private void btnMyWorks_Click(object sender, EventArgs e)
        {
            //Database fetch for the specific artworks by this user
            List<Art> arts = UserExperience.GetDummyArts();

            //Actual code
            List<Art> CurrentUserarts = UserExperience.GetCurrentUsersArts();

            currentExperience.AddToPanelContent(new MyWorksPage(CurrentUserarts));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            currentExperience.AddToPanelContent(new Upload());
        }
    }
}
