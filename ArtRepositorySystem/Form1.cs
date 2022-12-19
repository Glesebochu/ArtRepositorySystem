using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ArtRepositorySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();


                //SqlConnection con = new SqlConnection();
                //con.ConnectionString = ConfigurationManager.ConnectionStrings["DBCS"].ToString();
                //con.Open();
                //MessageBox.Show("connection succesful");

                SqlCommand cmd = new SqlCommand("SpSearchForArt",loginForm.con);
                cmd.CommandType = CommandType.StoredProcedure;
                var arrlist = new ArrayList();
              
                int counter = 0;
                int counter1 = 0;
                char[] charArr = new char[50];
                txtSearchBox.Text += ' ';
          
                
                for(int i =0; i<txtSearchBox.Text.Length; i++)
                {
                    if(!Char.IsWhiteSpace(txtSearchBox.Text[i]))
                    {
                        charArr[counter1]=txtSearchBox.Text[i];
                       
                        counter1++;
                    }
                    
                    else
                    {
                        
                        counter1 = 0;
                        string word = new string(charArr);
                        Array.Clear(charArr, 0, charArr.Length);
                        arrlist.Insert(counter, word);
                        counter++;
                    }
                }

                //foreach (string item in arrlist)
                //{
                //    MessageBox.Show(item);


                //}
                cmd.Parameters.AddWithValue("@SearchedText",txtSearchBox.Text.Remove(txtSearchBox.Text.Length - 1));
                
                SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dadapter.Fill(ds);

                
                dgvSearchAlgorithm.DataSource = ds.Tables[0];
                int count = ds.Tables[0].Rows.Count;

                if (count > 0)
                {
             
                    PictureBox[] pictureBoxes = new PictureBox[count];
                    for(int i =0; i < count; i++)
                    {
                        var data = (Byte[])ds.Tables[0].Rows[count - i - 1]["Image"];
                        var stream = new MemoryStream(data);
                        pictureBoxes[i] = new PictureBox();
                        pictureBoxes[i].Image = Image.FromStream(stream);
                        pictureBoxes[i].SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBoxes[i].Size = new Size(250,250);

                        flowLayoutPanel1.Controls.Add(pictureBoxes[i]);

                        Label artDescriptionLabel = new Label();
                        artDescriptionLabel.Text = (string)ds.Tables[0].Rows[count - i - 1]["ArtDescription"];
                        artDescriptionLabel.AutoSize = true;
                        artDescriptionLabel.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                       
                        flowLayoutPanel1.Controls.Add(artDescriptionLabel);
                        
                        
                    }
                    
                }
                loginForm.con.Close();

            }
            catch(SqlException sqlExp)
            {
                MessageBox.Show(sqlExp.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlPicturesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
