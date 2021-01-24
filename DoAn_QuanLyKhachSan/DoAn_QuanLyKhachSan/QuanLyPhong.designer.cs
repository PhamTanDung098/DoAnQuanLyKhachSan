namespace DoAn_QuanLyKhachSan
{
    partial class QuanLyPhong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lsvLoaiPhong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabctrPhong = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.dgvphong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuuGia = new System.Windows.Forms.Button();
            this.btbXoa = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.cmbTenLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabLoaiphong = new System.Windows.Forms.TabPage();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnthemloaiphong = new System.Windows.Forms.Button();
            this.btnLuuLoaiPhong = new System.Windows.Forms.Button();
            this.btnxoaloaiphong = new System.Windows.Forms.Button();
            this.loi = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabctrPhong.SuspendLayout();
            this.tabPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).BeginInit();
            this.tabLoaiphong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số người:";
            // 
            // lsvLoaiPhong
            // 
            this.lsvLoaiPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvLoaiPhong.FullRowSelect = true;
            this.lsvLoaiPhong.GridLines = true;
            this.lsvLoaiPhong.Location = new System.Drawing.Point(314, 24);
            this.lsvLoaiPhong.MultiSelect = false;
            this.lsvLoaiPhong.Name = "lsvLoaiPhong";
            this.lsvLoaiPhong.Size = new System.Drawing.Size(366, 376);
            this.lsvLoaiPhong.TabIndex = 8;
            this.lsvLoaiPhong.UseCompatibleStateImageBehavior = false;
            this.lsvLoaiPhong.View = System.Windows.Forms.View.Details;
            this.lsvLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.lsvLoaiPhong_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã loại";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số người";
            this.columnHeader4.Width = 101;
            // 
            // tabctrPhong
            // 
            this.tabctrPhong.Controls.Add(this.tabPhong);
            this.tabctrPhong.Controls.Add(this.tabLoaiphong);
            this.tabctrPhong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctrPhong.ImageList = this.imageList1;
            this.tabctrPhong.Location = new System.Drawing.Point(0, 3);
            this.tabctrPhong.Name = "tabctrPhong";
            this.tabctrPhong.SelectedIndex = 0;
            this.tabctrPhong.Size = new System.Drawing.Size(762, 484);
            this.tabctrPhong.TabIndex = 19;
            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.dgvphong);
            this.tabPhong.Controls.Add(this.btnThem);
            this.tabPhong.Controls.Add(this.btnThoat);
            this.tabPhong.Controls.Add(this.btnLuuGia);
            this.tabPhong.Controls.Add(this.btbXoa);
            this.tabPhong.Controls.Add(this.lb_title);
            this.tabPhong.Controls.Add(this.cmbTenLoaiPhong);
            this.tabPhong.Controls.Add(this.label7);
            this.tabPhong.Controls.Add(this.txtPhong);
            this.tabPhong.Controls.Add(this.label5);
            this.tabPhong.ImageIndex = 7;
            this.tabPhong.Location = new System.Drawing.Point(4, 32);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(754, 448);
            this.tabPhong.TabIndex = 0;
            this.tabPhong.Text = "Quản Lý Phòng";
            this.tabPhong.UseVisualStyleBackColor = true;
            // 
            // dgvphong
            // 
            this.dgvphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenLoai,
            this.SoNguoi,
            this.DonGia});
            this.dgvphong.Location = new System.Drawing.Point(279, 16);
            this.dgvphong.Name = "dgvphong";
            this.dgvphong.Size = new System.Drawing.Size(476, 375);
            this.dgvphong.TabIndex = 43;
            this.dgvphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphong_CellClick);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Loại Phòng";
            this.TenLoai.Name = "TenLoai";
            // 
            // SoNguoi
            // 
            this.SoNguoi.DataPropertyName = "SoLuong";
            this.SoNguoi.HeaderText = "Số Người";
            this.SoNguoi.Name = "SoNguoi";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Giá";
            this.DonGia.Name = "DonGia";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Green;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageIndex = 1;
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(6, 234);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 41);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "   Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1024px-Crystal_Clear_action_exit.svg.png");
            this.imageList1.Images.SetKeyName(1, "1024px-Fairytale_button_add.svg.png");
            this.imageList1.Images.SetKeyName(2, "42340515_322462061861385_8135218540287361024_n.jpg");
            this.imageList1.Images.SetKeyName(3, "42404862_2265656083461872_8176739226088374272_n.png");
            this.imageList1.Images.SetKeyName(4, "aaaaa.jpg");
            this.imageList1.Images.SetKeyName(5, "Cancel.png");
            this.imageList1.Images.SetKeyName(6, "delete-a-file.png");
            this.imageList1.Images.SetKeyName(7, "home_481.png");
            this.imageList1.Images.SetKeyName(8, "module-icon-9.png");
            this.imageList1.Images.SetKeyName(9, "NhaCungUng.png");
            this.imageList1.Images.SetKeyName(10, "profile-icon-lrg.png");
            this.imageList1.Images.SetKeyName(11, "save-14.jpg");
            this.imageList1.Images.SetKeyName(12, "Transformation.png");
            this.imageList1.Images.SetKeyName(13, "830326-5195b07124aa87335e2ab766936f50f6.png");
            this.imageList1.Images.SetKeyName(14, "AWT-Meal.png");
            this.imageList1.Images.SetKeyName(15, "Case Study.png");
            this.imageList1.Images.SetKeyName(16, "content-marketing.png");
            this.imageList1.Images.SetKeyName(17, "flaticon-technical-facts.png");
            this.imageList1.Images.SetKeyName(18, "food-flat.png");
            this.imageList1.Images.SetKeyName(19, "Help.png");
            this.imageList1.Images.SetKeyName(20, "home-48616_960_720.png");
            this.imageList1.Images.SetKeyName(21, "icon-medium-transparent.png");
            this.imageList1.Images.SetKeyName(22, "module-icon-9.png");
            this.imageList1.Images.SetKeyName(23, "profile-icon-lrg.png");
            this.imageList1.Images.SetKeyName(24, "Registration_help-02.png");
            this.imageList1.Images.SetKeyName(25, "u4088.png");
            this.imageList1.Images.SetKeyName(26, "WikiProject_Council_project_list_icon.svg_.png");
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.ImageIndex = 0;
            this.btnThoat.ImageList = this.imageList1;
            this.btnThoat.Location = new System.Drawing.Point(81, 301);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 42);
            this.btnThoat.TabIndex = 39;
            this.btnThoat.Text = "   Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuuGia
            // 
            this.btnLuuGia.Enabled = false;
            this.btnLuuGia.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuGia.ForeColor = System.Drawing.Color.Blue;
            this.btnLuuGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuGia.ImageIndex = 11;
            this.btnLuuGia.ImageList = this.imageList1;
            this.btnLuuGia.Location = new System.Drawing.Point(190, 234);
            this.btnLuuGia.Name = "btnLuuGia";
            this.btnLuuGia.Size = new System.Drawing.Size(83, 42);
            this.btnLuuGia.TabIndex = 40;
            this.btnLuuGia.Text = "    Lưu";
            this.btnLuuGia.UseVisualStyleBackColor = true;
            this.btnLuuGia.Click += new System.EventHandler(this.btnLuuGia_Click);
            // 
            // btbXoa
            // 
            this.btbXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbXoa.ImageIndex = 5;
            this.btbXoa.ImageList = this.imageList1;
            this.btbXoa.Location = new System.Drawing.Point(101, 234);
            this.btbXoa.Name = "btbXoa";
            this.btbXoa.Size = new System.Drawing.Size(83, 42);
            this.btbXoa.TabIndex = 42;
            this.btbXoa.Text = "    Xóa";
            this.btbXoa.UseVisualStyleBackColor = true;
            this.btbXoa.Click += new System.EventHandler(this.btbXoa_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.Red;
            this.lb_title.Location = new System.Drawing.Point(44, 16);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(215, 26);
            this.lb_title.TabIndex = 33;
            this.lb_title.Text = "QUẢN LÝ PHÒNG";
            // 
            // cmbTenLoaiPhong
            // 
            this.cmbTenLoaiPhong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTenLoaiPhong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTenLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLoaiPhong.Enabled = false;
            this.cmbTenLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenLoaiPhong.FormattingEnabled = true;
            this.cmbTenLoaiPhong.Location = new System.Drawing.Point(37, 177);
            this.cmbTenLoaiPhong.Name = "cmbTenLoaiPhong";
            this.cmbTenLoaiPhong.Size = new System.Drawing.Size(189, 29);
            this.cmbTenLoaiPhong.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Loại Phòng";
            // 
            // txtPhong
            // 
            this.txtPhong.Enabled = false;
            this.txtPhong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhong.Location = new System.Drawing.Point(37, 94);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(189, 29);
            this.txtPhong.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phòng:";
            // 
            // tabLoaiphong
            // 
            this.tabLoaiphong.Controls.Add(this.txtLoaiPhong);
            this.tabLoaiphong.Controls.Add(this.txtGia);
            this.tabLoaiphong.Controls.Add(this.txtMaLoai);
            this.tabLoaiphong.Controls.Add(this.lbLoaiPhong);
            this.tabLoaiphong.Controls.Add(this.numSoNguoi);
            this.tabLoaiphong.Controls.Add(this.button1);
            this.tabLoaiphong.Controls.Add(this.btnthemloaiphong);
            this.tabLoaiphong.Controls.Add(this.btnLuuLoaiPhong);
            this.tabLoaiphong.Controls.Add(this.btnxoaloaiphong);
            this.tabLoaiphong.Controls.Add(this.label1);
            this.tabLoaiphong.Controls.Add(this.label3);
            this.tabLoaiphong.Controls.Add(this.label4);
            this.tabLoaiphong.Controls.Add(this.lsvLoaiPhong);
            this.tabLoaiphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLoaiphong.ImageIndex = 26;
            this.tabLoaiphong.Location = new System.Drawing.Point(4, 32);
            this.tabLoaiphong.Name = "tabLoaiphong";
            this.tabLoaiphong.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoaiphong.Size = new System.Drawing.Size(754, 448);
            this.tabLoaiphong.TabIndex = 1;
            this.tabLoaiphong.Text = "Loại Phòng";
            this.tabLoaiphong.UseVisualStyleBackColor = true;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(27, 253);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(210, 29);
            this.txtLoaiPhong.TabIndex = 50;
            this.txtLoaiPhong.Visible = false;
            this.txtLoaiPhong.TextChanged += new System.EventHandler(this.txtLoaiPhong_TextChanged);
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Location = new System.Drawing.Point(27, 117);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(210, 29);
            this.txtGia.TabIndex = 50;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Location = new System.Drawing.Point(27, 50);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(210, 29);
            this.txtMaLoai.TabIndex = 50;
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.Location = new System.Drawing.Point(27, 229);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(100, 21);
            this.lbLoaiPhong.TabIndex = 49;
            this.lbLoaiPhong.Text = "Loại Phòng:";
            this.lbLoaiPhong.Visible = false;
            // 
            // numSoNguoi
            // 
            this.numSoNguoi.Enabled = false;
            this.numSoNguoi.Location = new System.Drawing.Point(31, 185);
            this.numSoNguoi.Name = "numSoNguoi";
            this.numSoNguoi.Size = new System.Drawing.Size(206, 29);
            this.numSoNguoi.TabIndex = 48;
            this.numSoNguoi.ValueChanged += new System.EventHandler(this.numSoNguoi_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(571, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 42);
            this.button1.TabIndex = 46;
            this.button1.Text = "   Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnthemloaiphong
            // 
            this.btnthemloaiphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemloaiphong.ForeColor = System.Drawing.Color.Green;
            this.btnthemloaiphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemloaiphong.ImageIndex = 1;
            this.btnthemloaiphong.ImageList = this.imageList1;
            this.btnthemloaiphong.Location = new System.Drawing.Point(19, 297);
            this.btnthemloaiphong.Name = "btnthemloaiphong";
            this.btnthemloaiphong.Size = new System.Drawing.Size(83, 41);
            this.btnthemloaiphong.TabIndex = 43;
            this.btnthemloaiphong.Text = "   Thêm";
            this.btnthemloaiphong.UseVisualStyleBackColor = true;
            this.btnthemloaiphong.Click += new System.EventHandler(this.btnthemloaiphong_Click);
            // 
            // btnLuuLoaiPhong
            // 
            this.btnLuuLoaiPhong.Enabled = false;
            this.btnLuuLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuLoaiPhong.ForeColor = System.Drawing.Color.Blue;
            this.btnLuuLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuLoaiPhong.ImageIndex = 11;
            this.btnLuuLoaiPhong.ImageList = this.imageList1;
            this.btnLuuLoaiPhong.Location = new System.Drawing.Point(206, 297);
            this.btnLuuLoaiPhong.Name = "btnLuuLoaiPhong";
            this.btnLuuLoaiPhong.Size = new System.Drawing.Size(83, 42);
            this.btnLuuLoaiPhong.TabIndex = 44;
            this.btnLuuLoaiPhong.Text = "    Lưu";
            this.btnLuuLoaiPhong.UseVisualStyleBackColor = true;
            this.btnLuuLoaiPhong.Click += new System.EventHandler(this.btnLuuLoaiPhong_Click);
            // 
            // btnxoaloaiphong
            // 
            this.btnxoaloaiphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoaloaiphong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnxoaloaiphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoaloaiphong.ImageIndex = 5;
            this.btnxoaloaiphong.ImageList = this.imageList1;
            this.btnxoaloaiphong.Location = new System.Drawing.Point(117, 298);
            this.btnxoaloaiphong.Name = "btnxoaloaiphong";
            this.btnxoaloaiphong.Size = new System.Drawing.Size(83, 42);
            this.btnxoaloaiphong.TabIndex = 45;
            this.btnxoaloaiphong.Text = "    Xóa";
            this.btnxoaloaiphong.UseVisualStyleBackColor = true;
            this.btnxoaloaiphong.Click += new System.EventHandler(this.btnxoaloaiphong_Click);
            // 
            // loi
            // 
            this.loi.ContainerControl = this;
            // 
            // QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 484);
            this.Controls.Add(this.tabctrPhong);
            this.Name = "QuanLyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Phong_FormClosing);
            this.Load += new System.EventHandler(this.Phong_Load);
            this.tabctrPhong.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            this.tabPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).EndInit();
            this.tabLoaiphong.ResumeLayout(false);
            this.tabLoaiphong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lsvLoaiPhong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabControl tabctrPhong;
        private System.Windows.Forms.TabPage tabLoaiphong;
        private System.Windows.Forms.ErrorProvider loi;
        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.ComboBox cmbTenLoaiPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuuGia;
        private System.Windows.Forms.Button btbXoa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnthemloaiphong;
        private System.Windows.Forms.Button btnLuuLoaiPhong;
        private System.Windows.Forms.Button btnxoaloaiphong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvphong;
        private System.Windows.Forms.NumericUpDown numSoNguoi;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtLoaiPhong;
    }
}