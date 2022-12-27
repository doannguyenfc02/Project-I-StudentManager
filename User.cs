using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_I
{
    public class User
    {
        private string fullname;
        private string username;
        private string password;
        private string type;
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Type { get => type; set => type = value; }

        public User(string full_name, string user_name, string pass_word, string type_user)
        {
            this.Fullname = full_name;
            this.Username = user_name;
            this.Password = pass_word;
            this.Type = type_user;
        }
        public User(DataRow row) 
        {
            this.Fullname = row[0].ToString();
            this.Username = row[1].ToString();
            this.Password = row[2].ToString();
            this.Type = row[3].ToString();

        }

    }
}
