using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArtRepositorySystem
{
    internal class UserDb
    {

        SqlConnection conn;
        string connectionString =
            "Data Source=(local);Initial Catalog=UserDb;" + "Integrated Security=true";


        public int getTotalNumberOfRecord(){
            int totalRecords = 0;
            using (SqlConnection conn = new SqlConnection(
                       connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserTable", conn);
                    conn.Open();
                    totalRecords = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return totalRecords + 1;
        }


        public void checkUserCredential(String uname, String pwd)
        {

            using (conn = new SqlConnection(connectionString)){
                using (var cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandType = CommandType.StoredProcedure
                })
                {
                    cmd.CommandText = "ReturnUserForLogin";
                    cmd.Parameters.AddWithValue("@uname", "@" + uname);

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read()) { 
                            String password = reader["password"].ToString();
                            if (pwd == password)
                            {
                                MessageBox.Show("Loged In.");

                            } else {

                            MessageBox.Show("Please Try again.");
                        }

                        }
                        else
                        {
                            MessageBox.Show("No user with this UserName Found!");
                        }
                                               
                        reader.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }

                }
            }
        }


        private bool isUserExist(String userName, String email)
        {
            using (conn = new SqlConnection(connectionString)){
                using (var cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandType = CommandType.StoredProcedure
                })
                {
                    cmd.CommandText = "ReturnUsersForSignUp";
                    cmd.Parameters.AddWithValue("@uname", userName);
                    cmd.Parameters.AddWithValue("@email", email);

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }
                    return false;

                }
            }

        }

        public void saveToDb(User userObject)
        {

            using (conn = new SqlConnection(connectionString)){
                using (var cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandType = CommandType.StoredProcedure
                })
                {
                    cmd.CommandText = "InsertUser";
                
                    try
                    {
                        conn.Open();

                        
                        if (this.isUserExist(userObject.userName,userObject.email))
                        {
                            MessageBox.Show("User with this Credential already exist!");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id", userObject.id);
                            cmd.Parameters.AddWithValue("@name", userObject.name);
                            cmd.Parameters.AddWithValue("@uname", userObject.userName);
                            cmd.Parameters.AddWithValue("@email", userObject.email);
                            cmd.Parameters.AddWithValue("@password", userObject.password);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thank you for signing up!");
                        }
                    
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }

                }
            }
        }

       }
}
