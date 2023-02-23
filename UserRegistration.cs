using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ArtRepositorySystem
{
    public partial class UserRegistration : UserControl
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel3.Height <= 10)
            {
                timer1.Stop();
            }
            else
            {
                panel3.Height -= 50;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Check if the user is in the users table. 

            //Create User object.

            User user = new User(textBox1.Text, "@" + textBox2.Text, textBox3.Text, textBox4.Text);
            user.saveUserData();



            //This will be replaced by the verified User object from the Login page.

            //This is dummy data.
            //User user = new User();
            //user.UserId= 1;
            //user.FirstName = "Yelelew";
            //user.LastName = "Aymertim";
            //user.Username = "user";
            //user.ProfilePic = UserExperience.ImageToByteArray(Properties.Resources.Afewerk_Tekle);


            //Code for calling the User experience from here.

            //Create a UserExperience object from the User object.
            UserExperience userExperience = new UserExperience(user);
            //Add the UserExperience object to this Form.
            this.FindForm().Controls.Add(userExperience);
            //Set the Dock property of the UserExperience object to Fill.
            userExperience.Dock = DockStyle.Fill;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel3.Height >= 500)
            {
                timer2.Stop();
            }
            else
            {
                panel3.Height += 50;
            }

        }
    }
}
