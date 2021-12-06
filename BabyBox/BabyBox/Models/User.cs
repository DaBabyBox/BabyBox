using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabyBox.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public User(int userID, string username, string password, string email )
        {
            UserID = userID;
            Username = username;
            Password = password;
            Email = email;
        }
        public User()
        {

        }
    }
}
