namespace DoAn_QuanLyKhachSan
{
    partial class TraPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblTienPhong = new System.Windows.Forms.Label();
            this.lblTienDV = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.drv1 = new System.Windows.Forms.DataGridView();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThuNgan = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.drv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngày thanh toán:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(18, 113);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 21);
            this.label.TabIndex = 29;
            this.label.Text = "Tiền phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tiền dịch vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Số tiền phải trả:";
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhoadon.ForeColor = System.Drawing.Color.Blue;
            this.btnInhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInhoadon.ImageIndex = 28;
            this.btnInhoadon.ImageList = this.imageList1;
            this.btnInhoadon.Location = new System.Drawing.Point(208, 280);
            this.btnInhoadon.Margin = new System.Windows.Forms.Padding(5);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(138, 48);
            this.btnInhoadon.TabIndex = 37;
            this.btnInhoadon.Text = "     Hóa đơn";
            this.btnInhoadon.UseVisualStyleBackColor = true;
            this.btnInhoadon.Visible = false;
            this.btnInhoadon.Click += new System.EventHandler(this.btnInhoadon_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1024px-Crystal_Clear_action_exit.svg.png");
            this.imageList1.Images.SetKeyName(1, "1024px-Fairytale_button_add.svg.png");
            this.imageList1.Images.SetKeyName(2, "2000px-Gnome-application-exit.svg.png");
            this.imageList1.Images.SetKeyName(3, "320140.png");
            this.imageList1.Images.SetKeyName(4, "830326-5195b07124aa87335e2ab766936f50f6.png");
            this.imageList1.Images.SetKeyName(5, "42340515_322462061861385_8135218540287361024_n.jpg");
            this.imageList1.Images.SetKeyName(6, "42404862_2265656083461872_8176739226088374272_n.png");
            this.imageList1.Images.SetKeyName(7, "aaaaa.jpg");
            this.imageList1.Images.SetKeyName(8, "AWT-Meal.png");
            this.imageList1.Images.SetKeyName(9, "Cancel.png");
            this.imageList1.Images.SetKeyName(10, "Case Study.png");
            this.imageList1.Images.SetKeyName(11, "content-marketing.png");
            this.imageList1.Images.SetKeyName(12, "delete-a-file.png");
            this.imageList1.Images.SetKeyName(13, "fire-exit-sign-icon-digital-red-vector-17093188.jpg");
            this.imageList1.Images.SetKeyName(14, "flaticon-technical-facts.png");
            this.imageList1.Images.SetKeyName(15, "food-flat.png");
            this.imageList1.Images.SetKeyName(16, "Help.png");
            this.imageList1.Images.SetKeyName(17, "home_481.png");
            this.imageList1.Images.SetKeyName(18, "home-48616_960_720.png");
            this.imageList1.Images.SetKeyName(19, "icon-medium-transparent.png");
            this.imageList1.Images.SetKeyName(20, "log_logout_door_1563.png");
            this.imageList1.Images.SetKeyName(21, "module-icon-9.png");
            this.imageList1.Images.SetKeyName(22, "NhaCungUng.png");
            this.imageList1.Images.SetKeyName(23, "profile-icon-lrg.png");
            this.imageList1.Images.SetKeyName(24, "Registration_help-02.png");
            this.imageList1.Images.SetKeyName(25, "save-14.jpg");
            this.imageList1.Images.SetKeyName(26, "Transformation.png");
            this.imageList1.Images.SetKeyName(27, "u4088.png");
            this.imageList1.Images.SetKeyName(28, "WikiProject_Council_project_list_icon.svg_.png");
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTinhTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhTien.ImageIndex = 24;
            this.btnTinhTien.ImageList = this.imageList1;
            this.btnTinhTien.Location = new System.Drawing.Point(27, 280);
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(5);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(128, 48);
            this.btnTinhTien.TabIndex = 38;
            this.btnTinhTien.Text = "      Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMaHD.Location = new System.Drawing.Point(230, 35);
            this.lblMaHD.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(0, 21);
            this.lblMaHD.TabIndex = 40;
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.AutoSize = true;
            this.lblTienPhong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTienPhong.Location = new System.Drawing.Point(230, 113);
            this.lblTienPhong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Size = new System.Drawing.Size(0, 21);
            this.lblTienPhong.TabIndex = 42;
            // 
            // lblTienDV
            // 
            this.lblTienDV.AutoSize = true;
            this.lblTienDV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTienDV.Location = new System.Drawing.Point(230, 155);
            this.lblTienDV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTienDV.Name = "lblTienDV";
            this.lblTienDV.Size = new System.Drawing.Size(0, 21);
            this.lblTienDV.TabIndex = 43;
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.ImageIndex = 0;
            this.btnThoat.ImageList = this.imageList1;
            this.btnThoat.Location = new System.Drawing.Point(1588, 76);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(197, 68);
            this.btnThoat.TabIndex = 45;
            this.btnThoat.Text = "     Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTongTien.Location = new System.Drawing.Point(230, 200);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 21);
            this.lblTongTien.TabIndex = 43;
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Items.AddRange(new object[] {
            "Thường đơn",
            "Thường đôi",
            "VIP đơn",
            "VIP đôi"});
            this.cboPhong.Location = new System.Drawing.Point(736, 66);
            this.cboPhong.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(296, 29);
            this.cboPhong.TabIndex = 46;
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(564, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 47;
            this.label8.Text = "Chọn phòng:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // drv1
            // 
            this.drv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDV,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.drv1.Location = new System.Drawing.Point(548, 242);
            this.drv1.Name = "drv1";
            this.drv1.ShowCellToolTips = false;
            this.drv1.Size = new System.Drawing.Size(616, 192);
            this.drv1.TabIndex = 49;
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên Dịch Vụ";
            this.TenDV.Name = "TenDV";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phong,
            this.Gia,
            this.NgayDen,
            this.NgayDi,
            this.SoNgayO,
            this.TongTien});
            this.dgvPhong.Location = new System.Drawing.Point(445, 113);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(779, 123);
            this.dgvPhong.TabIndex = 50;
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);
            // 
            // Phong
            // 
            this.Phong.DataPropertyName = "MaPhong";
            this.Phong.HeaderText = "Phòng";
            this.Phong.Name = "Phong";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "DonGia";
            this.Gia.HeaderText = "Đơn Giá";
            this.Gia.Name = "Gia";
            // 
            // NgayDen
            // 
            this.NgayDen.DataPropertyName = "NgayThue";
            this.NgayDen.HeaderText = "Ngày Đến";
            this.NgayDen.Name = "NgayDen";
            // 
            // NgayDi
            // 
            this.NgayDi.DataPropertyName = "NgayDi";
            this.NgayDi.HeaderText = "Ngày Đi";
            this.NgayDi.Name = "NgayDi";
            // 
            // SoNgayO
            // 
            this.SoNgayO.DataPropertyName = "SoNgayO";
            this.SoNgayO.HeaderText = "Số Ngày Ở";
            this.SoNgayO.Name = "SoNgayO";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "ThanhTien";
            this.TongTien.HeaderText = "Thành Tiền";
            this.TongTien.Name = "TongTien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Thu Ngân";
            // 
            // txtThuNgan
            // 
            this.txtThuNgan.Location = new System.Drawing.Point(732, 22);
            this.txtThuNgan.Name = "txtThuNgan";
            this.txtThuNgan.Size = new System.Drawing.Size(299, 29);
            this.txtThuNgan.TabIndex = 52;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(174, 69);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(190, 29);
            this.dtpNgay.TabIndex = 53;
            // 
            // TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 443);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.txtThuNgan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.drv1);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTienDV);
            this.Controls.Add(this.lblTienPhong);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnInhoadon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TraPhong_FormClosing);
            this.Load += new System.EventHandler(this.TraPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.Label lblTienDV;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView drv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThuNgan;
        private System.Windows.Forms.DateTimePicker dtpNgay;
    }
}