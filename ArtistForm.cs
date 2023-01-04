using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

using System.Data.SqlClient;
using System.IO;
using ArtRepositorySystem.CustomControls;
using System.Data;
using FontAwesome.Sharp;



namespace ArtRepositorySystem
{
    public partial class ArtistForm : Form
    {
        private static IconButton currentButton;
        public ArtistForm()
        {
            InitializeComponent();
        }

        private void ArtistForm_Load(object sender, EventArgs e)
        {

        }
        //method that changes the fontawesome button when it is clicked
        public static void CustomizeButton(Object senderButton ,Color color)
        {
            DisableButton();
            if(senderButton != null)
            {
                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation =TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

            }
        }
        //method that returns a fontawesome button when another button is clicked
       public static void DisableButton()
        {
            if (currentButton != null)
            {
               
                currentButton.BackColor = Color.White;
                currentButton.ForeColor = Color.Black;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Black;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        //method used to add user controls to the navigation panel
        public void addUserControlNavigation(UserControl userControl)
        {
            
            userControl.Dock = DockStyle.Fill;
            pnlSidePanel.Controls.Clear();
            pnlSidePanel.Controls.Add(userControl);
            userControl.BringToFront();
            

        }
      
        //method used to add usercontrols to content panel
        public void addUserControl(UserControl userControl)
        {
            if (userControl != null)
            {
                userControl.Dock = DockStyle.Fill;
                contentPanel.Controls.Clear();
                contentPanel.Controls.Add(userControl);   
                userControl.BringToFront();

            }
        }
        //methods used to remove user controls from content panel
        public void removeUserControl(UserControl userControl)
        {
            contentPanel.Controls.Remove(userControl);
        }

        private void btnModeClick(object sender, EventArgs e)
        {

            if (btnMode.Text == "Artist Mode")
            {
                
                btnMode.Text = "Consumer Mode";
                pnlSidePanel.Controls.Clear();//remove the contents from the panels
                contentPanel.Controls.Clear();
                btnMode.IconChar = IconChar.ToggleOn;
                
            }
            else
            {
                uscpnlArtist newArtistPanel = new uscpnlArtist();
                addUserControlNavigation(newArtistPanel);
                btnMode.Text = "Artist Mode";
                btnMode.IconChar = IconChar.ToggleOff;
                
            }
        }

        //adding a browse for images function when the profile oval PCB is clicked
        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.png;*.jpeg;*.bmp)|*.JPEG;*.PNG;*.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ovalPictureBox1.ImageLocation = ofd.FileName;
            }
        }
    }
}
