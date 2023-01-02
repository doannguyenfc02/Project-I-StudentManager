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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

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
        /// <summary>
        /// Biến dùng để chứa các câu lệnh truy vấn trong SQL server
        /// </summary>
        SqlCommand command = new SqlCommand();
        /// <summary>
        /// Biến dùng để lưu các thông tin để kết nối cơ sở dữ liệu: Tên Server, tên tài khoản, mật khẩu, tên database
        /// </summary>
        string strConn;
        /// <summary>
        /// dùng để kiểm tra kết nối cơ sở dữ liệu
        /// </summary>
        bool isCheck_Database = false; 
        /// <summary>
        /// Kiểm tra trạng thái của camera
        /// </summary>
        int checkStart =0;

        /// <summary>
        /// Bật camera chương trình
        /// </summary>
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

        /// <summary>
        /// Khởi động lại các thông tin có trên trang chủ
        /// </summary>
        void resetInfo()
        {
            pic2.Image = null;
            txtID.Text = null;
            lblName.Text = null;
            lblMSSV.Text = null;
            lblClass.Text = null;
            lblK.Text = null;
            txtNote.Text = null;
        }

        /// <summary>
        /// Khởi động lại chương trình
        /// </summary>
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

        
        /// <summary>
        /// Tạo ảnh từ camera
        /// </summary>
        void TakeImage()
        {
            //
            DateTime today = DateTime.Now;
            string strTime = today.Year + "-" + today.Month + "-" + today.Day + "_" + today.Hour + "." + today.Minute + "." + today.Second;
            string fileName = @"C:\\Users\\Admin\\Desktop\\DN\\DataProject\\" + strTime + "_" + txtID.Text + ".jpg";
            var bitmap = new Bitmap(pic2.Width, pic2.Height);
            pic2.DrawToBitmap(bitmap, pic2.ClientRectangle);
            System.Drawing.Imaging.ImageFormat imageFormat = null;
            imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            bitmap.Save(fileName, imageFormat);
        }
       
        /// <summary>
        /// Họ và tên của sinh viên lấy từ cơ sở dữ liệu
        /// </summary>
        private string Hovaten;
        /// <summary>
        /// Mã số của sinh viên trong cơ sở dữ liệu
        /// </summary>
        private string mssv;
        /// <summary>
        /// Kiểm tra thông tin của IdCard/MSSV
        /// </summary>
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
                        mssv = reader.GetInt32(1)+"";
                        Hovaten = reader.GetString(2);
                        lblMSSV.Text = "MSSV: " + reader.GetInt32(1) + "";
                        lblName.Text = "Họ và tên: " + reader.GetString(2);
                        lblClass.Text = "Lớp: " + reader.GetString(3);
                        lblK.Text = "Khóa: " + reader.GetInt32(4);
                        pic2.Image = pic1.Image;
                        txtNote.Focus();
                    }
                    else
                    {
                        resetInfo();
                        MessageBox.Show("Thông tin của bạn chưa có trong CSDL");
                        txtID.Focus();
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng bật Camera!");
                }
            }
            
        }



        /// <summary>
        /// Phân quyền các chức năng của từng loại tài khoản
        /// </summary>
        void phanquyenTK()
        {
            switch (Const_P.user.Type)
            {
                case "nhanvien":
                    quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
                    break;
            }

        }

        /// <summary>
        /// Sự kiện bật camera
        /// </summary>
        private void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {
            pic1.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void form_Project_I_Load(object sender, EventArgs e)
        {
            phanquyenTK();
            fQLTK_load();
            fOutput_Load();
            btnHome.Enabled = false;
        }


        private void form_Project_I_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reset();
            fQLTK_closing();
            fOutput_closing();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ô này chỉ cho phép nhập số
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8)
            {
                //không cho phím đó tác động
                e.Handled = true;
            }
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
            List_output.Instance.List_outputs.Add(new Output(Hovaten,mssv, txtNote.Text + " "));
            resetInfo();
            txtID.Focus();
           
        }
        #region menu

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCamera();
        }
        #region KetnoiDatabae
        private void btnConnect_Click(object sender, EventArgs e)
        {
            strConn = "Server=" + txtServername.Text + ";database=" + txtDB.Text + ";user id=" + txtUser.Text + ";password=" + txtPW.Text;
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                MessageBox.Show("Bạn kết nối cơ sở dữ liệu thành công");
                isCheck_Database = true;
                txtServername.Text =null; 
                txtDB.Text =null;
                txtUser.Text =null;
                txtPW.Text =null;
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                isCheck_Database=false;
                MessageBox.Show(ex.Message);
                txtServername.Focus();
            }

        }
        private void unconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isCheck_Database = false;
            conn.Close();
            conn = null;
        }
        #endregion
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            pic1.Image = null;
            pic2.Image = null;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            btnHome.Enabled = true;

        }
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex= 2;
            btnHome.Enabled = true;

        }
        #endregion
        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            btnHome.Enabled = false;
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            form_DangNhap fr2 = new form_DangNhap();
            fr2.Show();
            this.Close();
        }

        #region methodQLTK
        DataTable datatableWrite = new DataTable();
        DataTable datatableRead = new DataTable();


        DataSet datasetWrite = new DataSet();
        DataSet datasetRead = new DataSet();

        string Status = "";
        /// <summary>
        /// Biến chỉ số vị trí đang được chọn
        /// </summary>
        int index = -1;
        /// <summary>
        /// Tạo bảng
        /// </summary>
        /// <returns></returns>
        DataTable createDataTable()
        {
            DataTable dataTB = new DataTable();
            DataColumn colFullname = new DataColumn("Fullname");
            DataColumn colUsername = new DataColumn("Username");
            DataColumn colPW=new DataColumn("Password");
            DataColumn colType = new DataColumn("TypeOfUser");
            dataTB.Columns.Add(colFullname);
            dataTB.Columns.Add(colUsername);
            dataTB.Columns.Add(colPW);
            dataTB.Columns.Add(colType);

            return dataTB;
        }

        /// <summary>
        /// ghi dữ liệu vào file xml
        /// </summary>
        void writeXML()
        {
            datatableWrite = createDataTable();
            foreach(var item in List_User.Instance.List_users)
            {
                datatableWrite.Rows.Add(item.Fullname, item.Username, item.Password,item.Type);
            }
            datasetWrite.Tables.Add(datatableWrite);
            datasetWrite.WriteXml("data.xml"); //lưu dữ liệu vào file data.xml
        }

        /// <summary>
        /// Phân quyền chức năng đối với các loại tài khoản
        /// </summary>
        void fQLTK_load()
        {
            EnableControls(false, true);
            //readXML();
            createColumnforDtgv();
            LoadlistUsers();
            btn_Cancel.Enabled = btn_Save.Enabled = false;
        }

        void fQLTK_closing()
        {
            writeXML();
        }
        /// <summary>
        /// Tạo các cột của datagridview_Users
        /// </summary>
        void createColumnforDtgv()
        {
            var colFullname = new DataGridViewTextBoxColumn();
            var colUser = new DataGridViewTextBoxColumn();
            var colPW = new DataGridViewTextBoxColumn();
            var colType = new DataGridViewTextBoxColumn();
            colFullname.Width = 150;
            colUser.Width =100;
            colPW.Width = 100;
            colType.Width = 75;

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
            //createColumnforDtgv();
            dataGridView_Users.DataSource = List_User.Instance.List_users;
            dataGridView_Users.Refresh();

        }
        /// <summary>
        /// Trạng thái khóa/mở của các chứng năng
        /// </summary>
        /// <param name="isEnableTextbox">trạng thái textbox</param>
        /// <param name="isNableDatagridview">trạng thái của Datagridview_Users</param>
        void EnableControls(bool isEnableTextbox, bool isNableDatagridview)
        {
            txb_crFullname.Enabled =txb_crUser.Enabled = txb_crPW.Enabled = cbbox_crType.Enabled = isEnableTextbox;
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
            txb_crFullname.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string fullname = txb_crFullname.Text;
            string user = txb_crUser.Text;
            string pw = txb_crPW.Text;
            string type = cbbox_crType.Text;

            if (Status == "Add")
            {
                List_User.Instance.List_users.Add(new User(fullname, user, pw, type));
            }
            if (Status == "Edit")
            {
                List_User.Instance.List_users[index].Fullname = txb_crFullname.Text;
                List_User.Instance.List_users[index].Username = txb_crUser.Text;
                List_User.Instance.List_users[index].Password = txb_crPW.Text;
                List_User.Instance.List_users[index].Type = cbbox_crType.Text;

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
            txb_crPW.Text = List_User.Instance.List_users[index].Password;
            cbbox_crType.Text = List_User.Instance.List_users[index].Type;


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
        #region eventsEnter
        //Thay nút Enter để xử lý các sự kiện
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnCheck.PerformClick();
            }    
        }

        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnSave.PerformClick();
            }    
        }

        private void txtServername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUser.Focus();
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPW.Focus();
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDB.Focus();
            }
        }

        private void txtDB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConnect.PerformClick();
            }
        }

        private void txb_crFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbbox_crType.Focus();
            }
        }
        private void cbbox_crType_KeyDown(object sender, KeyEventArgs e)
        {
            bool is_Type = false; //dung de kiem trang khi nhap loai tai khoan
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < cbbox_crType.Items.Count; i++)
                {
                    if (cbbox_crType.Text == cbbox_crType.Items[i].ToString())
                    {
                        is_Type = true;
                        break;
                    }
                }
                if (is_Type == true)
                {
                    MessageBox.Show("Bạn chọn loại tài khoản " + cbbox_crType.Text);
                    txb_crUser.Focus();
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai định dạng");
                }
            }
        }
        private void txb_crType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_crUser.Focus();
            }
        }

        private void txb_crUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_crPW.Focus();
            }
        }

        private void txb_crPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Save.PerformClick();
            }
        }
        #endregion
        #region method_Output

        DataTable datatableWrite_output = new DataTable();
        DataTable datatableRead_output = new DataTable();
        DataSet datasetWrite_output = new DataSet();
        DataSet datasetRead_oput = new DataSet();
        DataTable createDataoutputTable()
        {
            DataTable dataTB = new DataTable();
            DataColumn colFullname = new DataColumn("Fullname");
            DataColumn colMSSV = new DataColumn("Mssv");
            DataColumn colNote = new DataColumn("Note");
            dataTB.Columns.Add(colFullname);
            dataTB.Columns.Add(colMSSV);
            dataTB.Columns.Add(colNote);
            return dataTB;
        }
        void createColumnforDtgv_output()
        {
            var colFullname = new DataGridViewTextBoxColumn();
            var colMSSV = new DataGridViewTextBoxColumn();
            var colNote = new DataGridViewTextBoxColumn();
            colFullname.Width = 150;
            colMSSV.Width = 100;
            colNote.Width = 200;

            colFullname.DataPropertyName = "Fullname";
            colMSSV.DataPropertyName = "Mssv";
            colNote.DataPropertyName = "Note";

            colFullname.HeaderText = "Họ và tên";
            colMSSV.HeaderText = "MSSV";
            colNote.HeaderText = "ghichu";
            dataGridView_Output.Columns.AddRange(new DataGridViewColumn[] { colFullname, colMSSV, colNote });
        }
        void writeoutputXML()
        {
            datatableWrite_output = createDataoutputTable();
            foreach (var item in List_output.Instance.List_outputs)
            {
                datatableWrite_output.Rows.Add(item.Fullname, item.Mssv, item.Note);
            }
            datasetWrite_output.Tables.Add(datatableWrite_output);
            datasetWrite_output.WriteXml("dataoutput.xml"); //lưu dữ liệu vào file data.xml
        }

        /// <summary>
        /// Đọc dữ liệu từ file xml
        /// </summary>
        void readXML_output()
        {
            datasetRead_oput.ReadXml("dataoutput.xml"); //đọc file dataoutput.xml
            datatableRead_output = datasetRead_oput.Tables[0]; //cho dữ liệu vào datatable
            foreach (DataRow item in datatableRead_output.Rows)
            {
                Output newOutput = new Output(item);
                List_output.Instance.List_outputs.Add(newOutput);
            }
        }
        void fOutput_Load()
        {
            readXML_output();
            createColumnforDtgv_output();
            LoadlistOutput();

        }
        void LoadlistOutput()
        {
            dataGridView_Output.DataSource = null;
            dataGridView_Output.DataSource = List_output.Instance.List_outputs;
            dataGridView_Output.Refresh();

        }
        void fOutput_closing()
        {
            writeoutputXML();
        }

        #endregion
        #region xuatExcel

        /// <summary>
        /// Xuất file exel
        /// </summary>
        /// <param name="path">Đường dẫn</param>
        void ExportEcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            //ghi tiêu tiêu đề
            for(int i = 0; i < dataGridView_Output.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView_Output.Columns[i].HeaderText; 
                
            }
            //Ghi nội dung
            for(int i=0;i< dataGridView_Output.Rows.Count; i++)
            {
                for(int j=0;j<dataGridView_Output.Columns.Count; j++)
                {
                    application.Cells[i+2, j + 1] = dataGridView_Output.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveAs(path);
            application.ActiveWorkbook.Saved = true;
      
        }
        private void exportOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            btnHome.Enabled = true;
        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel(*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportEcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file thất bại!" + ex.Message);
                }

            }
        }
        #endregion

    }
}
