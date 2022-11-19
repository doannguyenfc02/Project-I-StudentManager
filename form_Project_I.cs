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
        string strConn = "Server=DESKTOP-6LU74U9\\DOANNGUYEN;database=HUST;user id=sa;password=20200445";

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
            if (checkStart==1)
            {
                    
                    if (conn == null)
                        conn = new SqlConnection(strConn);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    SqlCommand command = new SqlCommand();
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
                MessageBox.Show("Vui lòng start!");
            }
        }


        private void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {
            pic1.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void form_Project_I_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartCamera();
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            Reset();
            pic1.Image = null;
            pic2.Image = null;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
