using ArtRepositorySystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtRepositorySystem.CustomControls
{
    public partial class uscpnlArtist : UserControl
    {
        public uscpnlArtist()
        {
            InitializeComponent();
        }
        uscMyWorks myworks = new uscMyWorks();
        ArtistForm artist = Application.OpenForms.OfType<ArtistForm>().FirstOrDefault();

        private void btnHome_Click(object sender, EventArgs e)
        {
            Color color = Color.SteelBlue;
            ArtistForm.CustomizeButton(sender, color);
            SqlConnection con1 = new SqlConnection();
            
            con1.ConnectionString = ConfigurationManager.ConnectionStrings["DBCS"].ToString();
            con1.Open();

            string selectAll = "SELECT * FROM tblArtWork;";
            SqlCommand cmd = new SqlCommand(selectAll, con1);

            cmd.CommandType = CommandType.Text;
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dadapter.Fill(ds);
            int count = ds.Tables[0].Rows.Count;

            if (count > 0)
            {

                PictureBox[] pictureBoxes = new PictureBox[count];
                for (int i = 0; i < count; i++)
                {
                    var data = (Byte[])ds.Tables[0].Rows[count - i - 1]["Image"];
                    var stream = new MemoryStream(data);
                    pictureBoxes[i] = new PictureBox();
                    pictureBoxes[i].Image = Image.FromStream(stream);
                    pictureBoxes[i].SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBoxes[i].Size = new Size(250, 250);
                    
                    myworks.flowLayoutPanel1.Controls.Add(pictureBoxes[i]);

                    Label artDescriptionLabel = new Label();
                    artDescriptionLabel.Text = (string)ds.Tables[0].Rows[count - i - 1]["ArtDescription"];
                    artDescriptionLabel.AutoSize = true;
                    artDescriptionLabel.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    myworks.flowLayoutPanel1.Controls.Add(artDescriptionLabel);

                    

                }
            }
          
            
            artist.addUserControl(myworks);
            
        
    }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Color color = Color.SteelBlue;
            ArtistForm.CustomizeButton(sender, color);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            Color color = Color.SteelBlue;
            ArtistForm.CustomizeButton(sender, color);
        }
    }
}
