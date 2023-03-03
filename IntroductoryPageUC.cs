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
    public partial class IntroductoryPageUC : UserControl
    {
        public IntroductoryPageUC()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage5);
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Display UserRegistration page for login
            //this.FindForm().Controls.Add(new UserRegistration());

            //This is dummy data.
            User user = UserExperience.GetUserByUserName("Leonardo Da Vinci");

            //Code for calling the User experience from here.

            //Create a UserExperience object from the User object.
            UserExperience userExperience = new UserExperience(user);
            //Add the UserExperience object to this Form.
            this.FindForm().Controls.Add(userExperience);
            //Set the Dock property of the UserExperience object to Fill.
            userExperience.Dock = DockStyle.Fill;

            //Make the form resizable.
            this.FindForm().FormBorderStyle = FormBorderStyle.Sizable;
            this.FindForm().MaximizeBox = true;

        }
    }
}
