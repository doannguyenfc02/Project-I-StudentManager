using System;
using System.Collections.Generic;
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
        private dataTypeUser type;
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public dataTypeUser Type { get => type; set => type = value; }
        public string Fullname { get => fullname; set => fullname = value; }

        public enum dataTypeUser
        {
            giamdoc,
            quanly,
            nhanvien
        }
        public User(string full_name, string user_name, string pass_word, dataTypeUser type_user)
        {
            this.fullname = full_name;
            this.username = user_name;
            this.password = pass_word;
            this.type = type_user;
        }

    }
}
