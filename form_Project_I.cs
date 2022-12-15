using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Project_I
{
    public partial class form_Project_I : Form
    {
        public form_Project_I()
        {
            InitializeComponent();
        }


        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;
        SqlConnection conn = null;
        SqlCommand command = new SqlCommand();
        string strConn;
        bool isCheck_Database = false;
        int checkStart =0;
        void StartCamera()
        {
                try
                {
                    filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                    videoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString);
                    videoCapture.NewFrame += new NewFrameEventHandler(Camera_On);
                    videoCapture.Start();
                    checkStart = 1;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }
        void resetInfo()
        {
            pic2.Image = null;
            txtID.Text = null;
            lblName.Text = null;
            lblMSSV.Text = null;
            lblClass.Text = null;
            lblK.Text = null;
        }
        void Reset()
        {
            try
            {
                if (videoCapture != null && videoCapture.IsRunning)
                {
                    videoCapture.Stop();
                    checkStart = 0;
                }
                resetInfo();        
            }
            catch (Exception)
            {
                return;
            }
        }
        void TakeImage()
        {
            DateTime today=DateTime.Now;
            string strTime=today.Year+"-"+today.Month+"-"+today.Day+"_"+today.Hour+"."+today.Minute+"."+today.Second;   
            string fileName = @"C:\\Users\\doann\\Desktop\\ProjectI\\Example\\"+strTime+"_"+txtID.Text + ".jpg";
            var bitmap = new Bitmap(pic2.Width, pic2.Height);
            pic2.DrawToBitmap(bitmap, pic2.ClientRectangle);
            System.Drawing.Imaging.ImageFormat imageFormat = null;
            imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            bitmap.Save(fileName, imageFormat);
        }
        private void Check()
        {
            if (isCheck_Database == false)
            {
                MessageBox.Show("Vui lòng kết nối cơ sở dữ liêu");
            }
            else
            {
                if (checkStart == 1)
                {
                    if (conn == null)
                        conn = new SqlConnection(strConn);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from Student where IdCard=" + txtID.Text + "or MSSV=" + txtID.Text;
                    command.Connection = conn;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true) //có dữ liệu
                    {
                        lblMSSV.Text = "MSSV: " + reader.GetInt32(1) + "";
                        lblName.Text = "Họ và tên: " + reader.GetString(2);
                        lblClass.Text = "Lớp: " + reader.GetString(3);
                        lblK.Text = "Khóa: " + reader.GetInt32(4);
                        pic2.Image = pic1.Image;
                    }
                    else
                    {
                        resetInfo();
                        MessageBox.Show("Thông tin của bạn chưa có trong CSDL"); ;
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng bật Camera!");
                }
            }
            
        }




        void phanquyenTK()
        {
            switch (Const_P.user.Type)
            {
                case "nhanvien":
                    quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
                    break;
            }

        }

        private void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {
            pic1.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void form_Project_I_Load(object sender, EventArgs e)
        {
            group_Database.Hide();
            phanquyenTK();
            fQLTK_load();
        }


        private void form_Project_I_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reset();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Check();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (videoCapture != null && videoCapture.IsRunning)
            {
                videoCapture.Stop();
            }
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TakeImage();
        }

        private void thiếtLậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCamera();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            strConn = "Server=" + txtServername.Text + ";database=" + txtDB.Text + ";user id=" + txtUser.Text + ";password=" + txtPW.Text;
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                MessageBox.Show("Bạn kết nối cơ sở dữ liệu thành công");
                isCheck_Database = true;
                group_Database.Hide();
                group_Home.Show();
            }
            catch (Exception ex)
            {
                isCheck_Database=false;
                MessageBox.Show(ex.Message);
            }

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            pic1.Image = null;
            pic2.Image = null;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group_Database.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            group_Database.Hide();
            group_Home.Show();
        }
        #region methodQLTK
        string Status = "";
        int index = -1;
        void fQLTK_load()
        {
            EnableControls(false, true);
            createColumnforDtgv();
            LoadlistUsers();
            btn_Cancel.Enabled = btn_Save.Enabled = false;
        }
        void createColumnforDtgv()
        {
            var colFullname = new DataGridViewTextBoxColumn();
            var colUser = new DataGridViewTextBoxColumn();
            var colPW = new DataGridViewTextBoxColumn();
            var colType = new DataGridViewTextBoxColumn();
            colFullname.Width = 180;
            colUser.Width = 120;
            colPW.Width = 120;
            colType.Width = 150;

            colFullname.DataPropertyName = "Fullname";
            colUser.DataPropertyName = "Username";
            colPW.DataPropertyName = "Password";
            colType.DataPropertyName = "Type";
       
            colFullname.HeaderText = "Họ và tên";
            colUser.HeaderText = "Tên đăng nhập";
            colPW.HeaderText = "Mật khẩu";
            colType.HeaderText = "loại tài khoản";
            dataGridView_Users.Columns.AddRange(new DataGridViewColumn[] { colFullname, colUser, colPW, colType });
        }
        void LoadlistUsers()
        {
            dataGridView_Users.DataSource = null;
            createColumnforDtgv();
            dataGridView_Users.DataSource = List_User.Instance.List_users;
            dataGridView_Users.Refresh();

        }
        void EnableControls(bool isEnableTextbox, bool isNableDatagridview)
        {
            txb_crFullname.Enabled =txb_crUser.Enabled = txb_crPW.Enabled = txb_crType.Enabled = isEnableTextbox;
            dataGridView_Users.Enabled = isNableDatagridview;
        }
        void clearTextbox()
        {
            foreach (var item in this.Controls)
            {
                TextBox item1 = item as TextBox;
                if (item1 != null)
                {
                    item1.Clear();
                }
            }
        }
        #endregion

        #region evenQLTK


        private void btn_Add_Click(object sender, EventArgs e)
        {
            EnableControls(true, false);
            btn_Delete.Enabled = btn_Edit.Enabled = false;
            btn_Cancel.Enabled =btn_Save.Enabled = true;
            Status = "Add";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string fullname = txb_crFullname.Text;
            string user = txb_crUser.Text;
            string pw = txb_crPW.Text;
            string type = txb_crType.Text;

            if (Status == "Add")
            {
                List_User.Instance.List_users.Add(new User(fullname, user, pw, type));
            }
            if (Status == "Edit")
            {
                List_User.Instance.List_users[index].Fullname = txb_crFullname.Text;
                List_User.Instance.List_users[index].Username = txb_crUser.Text;
                List_User.Instance.List_users[index].Password = txb_crPW.Text;
                List_User.Instance.List_users[index].Type = txb_crType.Text;

            }
            EnableControls(true, false);
            LoadlistUsers();
            clearTextbox();
            btn_Delete.Enabled = btn_Add.Enabled = btn_Edit.Enabled = true;
            btn_Cancel.Enabled = btn_Save.Enabled = false;
        }
       
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Hay chon mot ban ghi", "canh bao");
                return;
            }
            EnableControls(true, false);
            btn_Delete.Enabled = btn_Add.Enabled = btn_Edit.Enabled = false;
            btn_Cancel.Enabled = btn_Save.Enabled = true;

            txb_crFullname.Text = List_User.Instance.List_users[index].Fullname;
            txb_crUser.Text = List_User.Instance.List_users[index].Username;
            txb_crUser.Text = List_User.Instance.List_users[index].Password;
            txb_crType.Text = List_User.Instance.List_users[index].Type;


            Status = "Edit";
        }
        
        private void dataGridView_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            clearTextbox();
            EnableControls(false, true);
            btn_Delete.Enabled = btn_Cancel.Enabled = btn_Edit.Enabled = true;
            btn_Cancel.Enabled = btn_Save.Enabled = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Hay chon mot ban ghi", "canh bao");
                return;
            }
            List_User.Instance.List_users.RemoveAt(index);
            LoadlistUsers();
        }
        #endregion

    }
}
