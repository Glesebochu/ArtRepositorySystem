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
        public void addUserControlNavigation(UserControl userControl)
        {
            
            userControl.Dock = DockStyle.Fill;
            pnlSidePanel.Controls.Clear();
            pnlSidePanel.Controls.Add(userControl);
            userControl.BringToFront();
            

        }
      

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
        private void button1_Click(object sender, EventArgs e) { }
        //{
        //    SqlConnection con1 = new SqlConnection();
        //    con1.ConnectionString = ConfigurationManager.ConnectionStrings["DBCS"].ToString();
        //    con1.Open();
            
        //    string selectAll = "SELECT * FROM tblArtWork;";
        //    SqlCommand cmd = new SqlCommand(selectAll,con1);
            
        //    cmd.CommandType = CommandType.Text;
        //    SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            
        //    DataSet ds = new DataSet();
        //    dadapter.Fill(ds);
        //    int count = ds.Tables[0].Rows.Count;
        //    uscMyWorks csc = new uscMyWorks();

        //    if (count > 0)
        //    {

        //        PictureBox[] pictureBoxes = new PictureBox[count];
        //        for (int i = 0; i < count; i++)
        //        {
        //            var data = (Byte[])ds.Tables[0].Rows[count - i - 1]["Image"];
        //            var stream = new MemoryStream(data);
        //            pictureBoxes[i] = new PictureBox();
        //            pictureBoxes[i].Image = Image.FromStream(stream);
        //            pictureBoxes[i].SizeMode = PictureBoxSizeMode.Zoom;
        //            pictureBoxes[i].Size = new Size(250, 250);
                   
        //            csc.flowLayoutPanel1.Controls.Add(pictureBoxes[i]);

        //            Label artDescriptionLabel = new Label();
        //            artDescriptionLabel.Text = (string)ds.Tables[0].Rows[count - i - 1]["ArtDescription"];
        //            artDescriptionLabel.AutoSize = true;
        //            artDescriptionLabel.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        //            csc.flowLayoutPanel1.Controls.Add(artDescriptionLabel);
                   


        //        }
        //    }
        //    addUserControl(csc);
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
             
        }

        private void UserControlsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModeClick(object sender, EventArgs e)
        {

            if (btnMode.Text == "Artist Mode")
            {
                
                btnMode.Text = "Consumer Mode";
                pnlSidePanel.Controls.Clear();
                btnMode.IconChar = IconChar.ToggleOn;
                
            }
            else
            {
                uscpnlArtist newPanel = new uscpnlArtist();
                addUserControlNavigation(newPanel);
                btnMode.Text = "Artist Mode";
                btnMode.IconChar = IconChar.ToggleOff;
                
            }
        }

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
