//using System;
//using System.Text.RegularExpressions;
//using System.Windows.Forms;

//namespace ArtRepositorySystem
//{
//    internal class User
//    {

//        public String id;
//        public String name;
//        public String userName;
//        public String email;
//        public String password;
//        private UserDb db;
    
//        public User(String name, String userName, String email, String password) {
//            this.db = this.createDb();
//            this.id = this.getNumberOfRecords().ToString();
//            this.name = name;
//            this.userName = userName;
//            this.email = email; 
//            this.password = password;   
//        }

//        public User(){
//            db = this.createDb();
        
//        }

//        private bool isMatch(String input, String pattern)
//        {
            
//             Regex rx = new Regex($@"{pattern}", RegexOptions.Compiled | RegexOptions.IgnoreCase);
//             return rx.IsMatch(input);
//        }

//        private UserDb createDb()
//        {
//            return new UserDb();
//        }


//        public void saveUserData(){
//            if (isMatch(this.email, @"^[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*$")) { 
//                if (isMatch(this.password, @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{8,10})"))
//                {
//                    db.saveToDb(this);
//                }
//                else
//                {
//                    MessageBox.Show("\n\n" +
//                                      "1) must contains one digit from 0 - 9\n" +
//                                      "2) must contains one lowercase characters\n" +
//                                      "3) must contains one uppercase characters\n" +
//                                      "4) must contains one special symbols in the list '@#$%'\n" +
//                                      "5) length at least 8 characters and maximum of 10 ",caption: "Password", buttons:MessageBoxButtons.OK , icon: MessageBoxIcon.Error);
//                }
//            }
//            else
//            {
//                MessageBox.Show( "\n\n" +
//                                    "1. email should not contain any space or special characters(excep @ and .)\n" +
//                                    "2. email should not start with dot(.) or should not end with .(before @ symbot)\n" +
//                                    "3. two dots should not come near.\n" +
//                                    "4. @ symbol should not repeat.\n", caption: "Email",buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error
//                    );
//            }

//        }

//        public int getNumberOfRecords()
//        {
//            return db.getTotalNumberOfRecord();
//        }


//        public void logUser(String uname, String pwd)
//        {
//            db.checkUserCredential(uname,pwd);

//        }

//    }
//    }
