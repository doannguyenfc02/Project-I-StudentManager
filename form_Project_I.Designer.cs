namespace Project_I
{
    partial class form_Project_I
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label3;
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.GroupBox();
            this.lblK = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.group_Home = new System.Windows.Forms.GroupBox();
            this.group_Database = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtServername = new System.Windows.Forms.TextBox();
            this.lblDB = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblServername = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thiếtLậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.group_QLTK = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.txb_crPW = new System.Windows.Forms.TextBox();
            this.txb_crUser = new System.Windows.Forms.TextBox();
            this.txb_crType = new System.Windows.Forms.TextBox();
            this.txb_crFullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCreate_fullname = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.Information.SuspendLayout();
            this.group_Home.SuspendLayout();
            this.group_Database.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.group_QLTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(246, 201);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 13);
            label3.TabIndex = 5;
            label3.Text = "Note:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Card/MSSV:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(113, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(231, 20);
            this.txtID.TabIndex = 3;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(364, 23);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Location = new System.Drawing.Point(6, 61);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(224, 129);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 5;
            this.pic1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Camera";
            // 
            // pic2
            // 
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic2.Location = new System.Drawing.Point(6, 217);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(224, 129);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 5;
            this.pic2.TabStop = false;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImage.Location = new System.Drawing.Point(3, 201);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(41, 13);
            this.labelImage.TabIndex = 5;
            this.labelImage.Text = "Image";
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.Cyan;
            this.Information.Controls.Add(this.lblK);
            this.Information.Controls.Add(this.lblClass);
            this.Information.Controls.Add(this.lblMSSV);
            this.Information.Controls.Add(this.lblName);
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(249, 61);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(200, 129);
            this.Information.TabIndex = 5;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(10, 98);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(0, 13);
            this.lblK.TabIndex = 3;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(10, 75);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(0, 13);
            this.lblClass.TabIndex = 2;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(10, 49);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(0, 13);
            this.lblMSSV.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 0;
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(248, 217);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(201, 129);
            this.txtNote.TabIndex = 5;
            this.txtNote.Text = "";
            this.txtNote.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(206, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 21);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // group_Home
            // 
            this.group_Home.Controls.Add(this.group_Database);
            this.group_Home.Controls.Add(this.btnCheck);
            this.group_Home.Controls.Add(this.txtID);
            this.group_Home.Controls.Add(this.label1);
            this.group_Home.Controls.Add(this.btnSave);
            this.group_Home.Controls.Add(this.pic1);
            this.group_Home.Controls.Add(this.pic2);
            this.group_Home.Controls.Add(label3);
            this.group_Home.Controls.Add(this.label2);
            this.group_Home.Controls.Add(this.txtNote);
            this.group_Home.Controls.Add(this.labelImage);
            this.group_Home.Controls.Add(this.Information);
            this.group_Home.Location = new System.Drawing.Point(12, 37);
            this.group_Home.Name = "group_Home";
            this.group_Home.Size = new System.Drawing.Size(454, 377);
            this.group_Home.TabIndex = 1;
            this.group_Home.TabStop = false;
            // 
            // group_Database
            // 
            this.group_Database.Controls.Add(this.label4);
            this.group_Database.Controls.Add(this.btnHome);
            this.group_Database.Controls.Add(this.btnConnect);
            this.group_Database.Controls.Add(this.txtDB);
            this.group_Database.Controls.Add(this.txtPW);
            this.group_Database.Controls.Add(this.txtUser);
            this.group_Database.Controls.Add(this.txtServername);
            this.group_Database.Controls.Add(this.lblDB);
            this.group_Database.Controls.Add(this.lblPW);
            this.group_Database.Controls.Add(this.lblUser);
            this.group_Database.Controls.Add(this.lblServername);
            this.group_Database.Location = new System.Drawing.Point(0, 0);
            this.group_Database.Name = "group_Database";
            this.group_Database.Size = new System.Drawing.Size(454, 377);
            this.group_Database.TabIndex = 2;
            this.group_Database.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Menu;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(135, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "KẾT NỐI CƠ SỞ DỮ LIỆU";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(302, 238);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(58, 23);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(194, 238);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(79, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(167, 193);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(254, 20);
            this.txtDB.TabIndex = 3;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(167, 158);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(254, 20);
            this.txtPW.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(167, 112);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(254, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtServername
            // 
            this.txtServername.Location = new System.Drawing.Point(167, 69);
            this.txtServername.Name = "txtServername";
            this.txtServername.Size = new System.Drawing.Size(254, 20);
            this.txtServername.TabIndex = 0;
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDB.Location = new System.Drawing.Point(84, 196);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(82, 17);
            this.lblDB.TabIndex = 3;
            this.lblDB.Text = "Database:";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPW.Location = new System.Drawing.Point(84, 161);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(82, 17);
            this.lblPW.TabIndex = 2;
            this.lblPW.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(84, 112);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 17);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User:";
            // 
            // lblServername
            // 
            this.lblServername.AutoSize = true;
            this.lblServername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServername.Location = new System.Drawing.Point(84, 70);
            this.lblServername.Name = "lblServername";
            this.lblServername.Size = new System.Drawing.Size(77, 17);
            this.lblServername.TabIndex = 0;
            this.lblServername.Text = "Sername:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thiếtLậpToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // thiếtLậpToolStripMenuItem
            // 
            this.thiếtLậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.thiếtLậpToolStripMenuItem.Name = "thiếtLậpToolStripMenuItem";
            this.thiếtLậpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.thiếtLậpToolStripMenuItem.Text = "Thiết lập";
            this.thiếtLậpToolStripMenuItem.Click += new System.EventHandler(this.thiếtLậpToolStripMenuItem_Click);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.unconnectToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // unconnectToolStripMenuItem
            // 
            this.unconnectToolStripMenuItem.Name = "unconnectToolStripMenuItem";
            this.unconnectToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.unconnectToolStripMenuItem.Text = "Unconnect";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(391, 420);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // group_QLTK
            // 
            this.group_QLTK.Controls.Add(this.btn_Save);
            this.group_QLTK.Controls.Add(this.btn_Delete);
            this.group_QLTK.Controls.Add(this.btn_Cancel);
            this.group_QLTK.Controls.Add(this.btn_Edit);
            this.group_QLTK.Controls.Add(this.btn_Add);
            this.group_QLTK.Controls.Add(this.dataGridView_Users);
            this.group_QLTK.Controls.Add(this.txb_crPW);
            this.group_QLTK.Controls.Add(this.txb_crUser);
            this.group_QLTK.Controls.Add(this.txb_crType);
            this.group_QLTK.Controls.Add(this.txb_crFullname);
            this.group_QLTK.Controls.Add(this.label5);
            this.group_QLTK.Controls.Add(this.label9);
            this.group_QLTK.Controls.Add(this.label8);
            this.group_QLTK.Controls.Add(this.label6);
            this.group_QLTK.Controls.Add(this.lblCreate_fullname);
            this.group_QLTK.Location = new System.Drawing.Point(483, 37);
            this.group_QLTK.Name = "group_QLTK";
            this.group_QLTK.Size = new System.Drawing.Size(452, 377);
            this.group_QLTK.TabIndex = 8;
            this.group_QLTK.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(369, 347);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(187, 347);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(278, 347);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(106, 348);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(14, 348);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Users.Location = new System.Drawing.Point(14, 117);
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.Size = new System.Drawing.Size(430, 208);
            this.dataGridView_Users.TabIndex = 10;
            this.dataGridView_Users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Users_CellClick);
            // 
            // txb_crPW
            // 
            this.txb_crPW.Location = new System.Drawing.Point(329, 61);
            this.txb_crPW.Name = "txb_crPW";
            this.txb_crPW.Size = new System.Drawing.Size(123, 20);
            this.txb_crPW.TabIndex = 9;
            // 
            // txb_crUser
            // 
            this.txb_crUser.Location = new System.Drawing.Point(95, 65);
            this.txb_crUser.Name = "txb_crUser";
            this.txb_crUser.Size = new System.Drawing.Size(137, 20);
            this.txb_crUser.TabIndex = 8;
            // 
            // txb_crType
            // 
            this.txb_crType.Location = new System.Drawing.Point(329, 23);
            this.txb_crType.Name = "txb_crType";
            this.txb_crType.Size = new System.Drawing.Size(123, 20);
            this.txb_crType.TabIndex = 7;
            // 
            // txb_crFullname
            // 
            this.txb_crFullname.Location = new System.Drawing.Point(95, 19);
            this.txb_crFullname.Name = "txb_crFullname";
            this.txb_crFullname.Size = new System.Drawing.Size(137, 20);
            this.txb_crFullname.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-3, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên đăng nhập:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(238, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mật khẩu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(238, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Loại tài khoản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-172, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // lblCreate_fullname
            // 
            this.lblCreate_fullname.AutoSize = true;
            this.lblCreate_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate_fullname.Location = new System.Drawing.Point(4, 25);
            this.lblCreate_fullname.Name = "lblCreate_fullname";
            this.lblCreate_fullname.Size = new System.Drawing.Size(67, 13);
            this.lblCreate_fullname.TabIndex = 0;
            this.lblCreate_fullname.Text = "Họ và tên:";
            // 
            // form_Project_I
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 466);
            this.Controls.Add(this.group_QLTK);
            this.Controls.Add(this.group_Home);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_Project_I";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project I";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Project_I_FormClosing);
            this.Load += new System.EventHandler(this.form_Project_I_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.group_Home.ResumeLayout(false);
            this.group_Home.PerformLayout();
            this.group_Database.ResumeLayout(false);
            this.group_Database.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.group_QLTK.ResumeLayout(false);
            this.group_QLTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox group_Home;
        private System.Windows.Forms.GroupBox group_Database;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thiếtLậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtServername;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblServername;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox group_QLTK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCreate_fullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dataGridView_Users;
        private System.Windows.Forms.TextBox txb_crPW;
        private System.Windows.Forms.TextBox txb_crUser;
        private System.Windows.Forms.TextBox txb_crType;
        private System.Windows.Forms.TextBox txb_crFullname;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
    }
}

