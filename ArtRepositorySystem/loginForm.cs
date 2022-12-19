using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtRepositorySystem
{
    public partial class loginForm : Form
    {
         public static SqlConnection con;
        public loginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private  void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Data Source ="+ txtIPAdress.Text+","+txtPortNo.Text+"; Network Library = DBMSSOCN; Initial Catalog = dbArtWorkRepositorySystem; User ID ="+ txtUserName.Text+"; Password ="+ txtPassword.Text;
                con.Open();
                Form1 newForm = new Form1();
                newForm.Show();

            }
            catch(SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
