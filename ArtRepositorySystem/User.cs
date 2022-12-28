using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationApp
{
    internal class User
    {

        public String id;
        public String name;
        public String userName;
        public String email;
        public String password;
        private UserDb db;
    
        public User(String name, String userName, String email, String password) {
            this.id = this.getNumberOfRecords().ToString();
            this.name = name;  
            this.email = email; 
            this.password = password;   
            this.db = this.createDb();
        }

        public User(){}

        private UserDb createDb()
        {
            return new UserDb();
        }

        public void saveUserData(){
            db.saveToDb(this);

        }

        public int getNumberOfRecords()
        {
            return db.getTotalNumberOfRecord();
        }


        public void logUser(String uname, String pwd)
        {
            db.checkUserCredential(uname,pwd);

        }


    }

   
    }
