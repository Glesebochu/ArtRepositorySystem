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

namespace UserRegistrationApp
{
    public partial class Form1 : Form
    {
        bool toogler = false;
        static int id = 1;
        SqlConnection conn;
        string connectionString =
            "Data Source=(local);Initial Catalog=UserDb;"
            + "Integrated Security=true";
        public Form1()
        {
            InitializeComponent();
              }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // SignUp Button
        private void button1_Click(object sender, EventArgs e){
            User user = new User(textBox1.Text, "@" + textBox2.Text, textBox3.Text, textBox4.Text);
            user.saveUserData();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            toogler = !toogler;
            if (toogler)
            {
                button3.Text = "SignUp";
            }
            else
            {
                button3.Text = "SignIn";
            }
        }

        // SignIn Button
        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.logUser(textBox5.Text, textBox6.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home Page");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (toogler) {
                if(panel3.Height > 500)
                {

                    timer1.Stop();
                }
                else
                {
                    panel3.Height += 50;
                }
            }
            else
            {
                if(panel3.Height <= 0)
                {
                    timer1.Stop();
                }
                else
                {
                    panel3.Height -= 50;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
