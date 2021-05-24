using System;
using System.Collections.Generic;
using System.Text;

namespace WineStar.Models
{
    public class Account
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Account() { }
        public Account (string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }
    }
}
