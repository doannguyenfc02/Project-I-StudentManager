using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_I
{
    public class List_User
    {
        private static List_User instance;
        public static List_User Instance
        {
            get
            {
                if (instance == null)
                    instance = new List_User();
                return instance;
            }
            set => instance = value;
        }


        List<User> list_users;

        public List<User> List_users
        {
            get => list_users;
            set => list_users = value;
        }

        List_User()
        {
            list_users = new List<User>();
            list_users.Add(new User("ADMIN", "Admin", "123456", "quanly"));
            list_users.Add(new User("Đoàn Sỹ Nguyên", "Doannguyen", "20200445", "nhanvien"));
            list_users.Add(new User("USER1", "User1", "123456", "nhan vien"));
        }
    }
}
