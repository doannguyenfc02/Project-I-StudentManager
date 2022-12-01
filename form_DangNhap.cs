using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_I
{
    public partial class form_DangNhap : Form
    {
        public form_DangNhap()
        {
            InitializeComponent();
        }

        List<User> f_list_Users = List_User.Instance.List_users;
        bool check_DangNhap(string ten_tk, string Mk)
        {
            for (int i = 0; i < f_list_Users.Count; i++)
            {
                if (ten_tk == f_list_Users[i].Username && Mk == f_list_Users[i].Password)
                {
                    Const_P.user = f_list_Users[i];
                    return true;
                }
            }
            return false;
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (check_DangNhap(txt_TaiKhoan.Text, txtMatKhau.Text) == true)
            {
                form_Project_I fr1 = new form_Project_I();
                fr1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập");
            }
        }

        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
