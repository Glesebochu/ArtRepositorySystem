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
            User user = new User();
            user.logUser(textBox5.Text, textBox6.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(textBox1.Text, "@" + textBox2.Text, textBox3.Text, textBox4.Text);
            user.saveUserData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            //User user = new User(textBox1.Text, "@" + textBox2.Text, textBox3.Text, textBox4.Text);
            //user.saveUserData();

            //Code for calling the User experience from here.

            //This will be replaced by the verified User object from the Login page.
            //Create User object.
            User user = new User();
            user.FirstName = "Yelelew";
            user.LastName = "Aymertim";
            user.Username = "user";
            user.ProfilePic = Properties.Resources.Afewerk_Tekle;

            //Create a ConsumerExperience object from the User object.
            UserExperience consumerExperience = new UserExperience(user);
            //Add the ConsumerExperience object to this Form.
            this.Controls.Add(consumerExperience);
            //Set the Dock property of the ConsumerExperience object to Fill.
            consumerExperience.Dock = DockStyle.Fill;
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
