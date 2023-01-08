using Project_I.Properties;
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

        List<User2> f_list_Users = List_User.Instance.List_users;
        DataTable datatableRead = new DataTable();
        DataSet datasetRead = new DataSet();

        /// <summary>
        /// Đọc file data.xml ra list_users
        /// </summary>
        void readXML()
        {
            datasetRead.ReadXml("data.xml"); //đọc file data.xml
            datatableRead = datasetRead.Tables[0]; //cho dữ liệu vào datatable
            foreach (DataRow item in datatableRead.Rows)
            {
                User2 newUser = new User2(item);
                List_User.Instance.List_users.Add(newUser);
            }
        }
        /// <summary>
        /// Kiểm tra trạng đăng nhập
        /// </summary>
        /// <param name="ten_tk">Tên đăng nhập. ví dụ: Admin</param>
        /// <param name="Mk">Mật khẩu. ví dụ:123456</param>
        /// <returns></returns>
        bool check_DangNhap(string ten_tk, string Mk)
        {
            for (int i = 0; i < List_User.Instance.List_users.Count; i++)
            {
                if (ten_tk == List_User.Instance.List_users[i].username && Mk == List_User.Instance.List_users[i].password)
                {
                    Const_P.user2 = List_User.Instance.List_users[i];
                    return true;
                }
            }
            return false;
        }
    /// <summary>
    /// Sự kiện khi click vào nút Đăng nhập
    /// </summary>
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
                txt_TaiKhoan.Focus(); //chuyển con trỏ tới chỗ nhập tên tài khoản
            }
        }

        /// <summary>
        /// Sự kiện khi click vào nút thoát
        /// </summary>
        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            Close(); //đóng form đăng nhập
        }

        private void form_DangNhap_Load(object sender, EventArgs e)
        {
            readXML();
        }

        private void txt_TaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            //Nhấn phím Enter để chuyển tới textbox nhập mật khẩu
            if(e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            //nhấn phím Enter thay cho click vào nút đăng nhập
            if(e.KeyCode== Keys.Enter) 
            {
                btn_DangNhap.PerformClick();
            }
        }
    }
}
