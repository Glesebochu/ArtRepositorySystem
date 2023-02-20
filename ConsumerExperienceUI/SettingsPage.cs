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
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void updatePictureClick(object sender, EventArgs e)
        {
            string imagelocation;

            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpg files(*.jpg)|*.jpg| png files(*.png)|*.png| all files(*.*)|*.*";

            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK) { 
                imagelocation = op.FileName;
                guna2PictureBox1.ImageLocation = imagelocation;
                 //guna2PictureBox1.BackgroundImage = Image.FromFile(op.FileName);
            }
        }

        private void saveChangedPassword(object sender, EventArgs e)
        {
            if (guna2TextBox14.Text == guna2TextBox13.Text)
            {
                //update db
                MessageBox.Show("Password change confirmed.");

            }
            else {
                MessageBox.Show("Make sure the passwords you have entered match and try again.");
            }
        }

        private void saveChangedProfilePicture(object sender, EventArgs e)
        {

        }
    }
}
