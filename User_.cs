using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ArtRepositorySystem
{
    partial class User
    {

        private String _id;
        private String _name;
        private string _userName;
        private String _email;
        private String _password;
        public string id
        { 
            get { return _id; } 
        }
        public string name
        { 
            get { return _name; } 
        }
        public string email
        { 
            get { return _email; } 
        }
        //public string password
        //{ 
        //    get { return _password; } 
        //}
        public string Username
        { 
            get { return _userName; } 
            set { _userName = value; } 
        }

        private UserDb db;

        public User(String name, String userName, String email, String password)
        {
            this.db = this.createDb();
            this._id = this.getNumberOfRecords().ToString();
            this._name = name;
            this.Username = userName;
            this._email = email;
            this._password = password;
            this.ProfilePic = UserExperience.ImageToByteArray(Properties.Resources.user_icon);
        }

        public User(bool _)
        {
            db = this.createDb();

        }

        private bool isMatch(String input, String pattern)
        {

            Regex rx = new Regex($@"{pattern}", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return rx.IsMatch(input);
        }

        private UserDb createDb()
        {
            return new UserDb();
        }


        public void saveUserData()
        {
            if (isMatch(this.email, @"^[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*$"))
            {
                if (isMatch(this.password, @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{8,10})"))
                {
                    db.saveToDb(this);
                }
                else
                {
                    MessageBox.Show("\n\n" +
                                      "1) must contains one digit from 0 - 9\n" +
                                      "2) must contains one lowercase characters\n" +
                                      "3) must contains one uppercase characters\n" +
                                      "4) must contains one special symbols in the list '@#$%'\n" +
                                      "5) length at least 8 characters and maximum of 10 ", caption: "Password", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("\n\n" +
                                    "1. email should not contain any space or special characters(excep @ and .)\n" +
                                    "2. email should not start with dot(.) or should not end with .(before @ symbot)\n" +
                                    "3. two dots should not come near.\n" +
                                    "4. @ symbol should not repeat.\n", caption: "Email", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error
                    );
            }

        }

        public int getNumberOfRecords()
        {
            return db.getTotalNumberOfRecord();
        }


        public void logUser(String uname, String pwd)
        {
            db.checkUserCredential(uname, pwd);

        }

    }
}
