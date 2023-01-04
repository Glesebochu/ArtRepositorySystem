using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtRepositorySystem.UserControls
{
    public partial class uscMyWorks : UserControl
    {
        public uscMyWorks()
        {
            InitializeComponent();
        }

       
        //when the search button is cliked it automatically runs the search alogrithm and 
        //returns all the art works that match it and displays it on the content panel
        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlContentPanel.Controls.Clear();
            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "server =.;database = dbArtWorkRepositorySystem;integrated security = true;";
                con.Open();
                SqlCommand cmd = new SqlCommand("SpSearchForArt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchedText", txtSearchBox.Text);

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

                        pnlContentPanel.Controls.Add(pictureBoxes[i]);

                        Label artDescriptionLabel = new Label();
                        artDescriptionLabel.Text = (string)ds.Tables[0].Rows[count - i - 1]["ArtDescription"];
                        artDescriptionLabel.AutoSize = true;
                        artDescriptionLabel.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        pnlContentPanel.Controls.Add(artDescriptionLabel);
                    }
                    con.Close();
                }
            }
            catch (SqlException sqlExp)
            {
                MessageBox.Show(sqlExp.Message);
            }
        }
    }
}
