using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchMod1Week5Assessment
{
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        private string Password { get; set; }
        public bool IsLoggedIn { get; set; }
        
        

        public User(string name, string email)
        {
            Name = name;
            Email = email;
            IsLoggedIn = false;
           
        }

        public bool IsSetupComplete()
        {
            if (Name != null && Email != null && Password != null)
            {
               return true;
            }
            else
            {
                return false;
            }
        }

        public string CreatePassword(string email, string password)
        {
            var confirmation = "Password Created";
            if (email == Email && password != null)
            {
                Password = password;
            }
            return confirmation;
            //Returned confirmation instead of password to keep password "Secure" - Tests did run returning password instead of confirmation
            //Also combined the two if statements into one for ease

        }

        public string LogIn(string password)
        {
            if (password == Password)
            {
                IsLoggedIn = true;
                return "Logged In";
            }
            return "Not Logged In";
        }

        public bool LogOut()
        {
            IsLoggedIn = false;
            return IsLoggedIn; //I preferred keeping the boolean nature of the variable IsLOggedIn if its not going to return a string
        }
    }
}
