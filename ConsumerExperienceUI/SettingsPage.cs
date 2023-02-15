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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "(choose a picture) | *.jpg; *.png; *.jpeg";
            if (op.ShowDialog() == DialogResult.OK) { 
            profilepicture.BackgroundImage = Image.FromFile(op.FileName);
            }
        }
    }
}
