using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ThuVien;
namespace DoAn_QuanLyKhachSan
{
    public partial class TraPhong : Form
    {
        KetNoi conn = new KetNoi();
        public TraPhong()
        {
            InitializeComponent();
        }

        private void labTDV_Click(object sender, EventArgs e)
        {

        }
        private void load_phong()
        {
            string str = "SELECT * FROM dbo.DanhSachPhong WHERE TinhTrang = 1";
            cboPhong.DataSource = conn.DataTable(str);
            cboPhong.DisplayMember = "MaPhong";
            cboPhong.ValueMember = "MaPhong";
        }
        private void load_dgvDichVu()
        {
            try
            {
                string str = "SELECT TenDV,SoLuong,DonGia, SoLuong * DonGia AS ThanhTien FROM dbo.DichVu, dbo.LoaiDichVu WHERE DichVu.MaDichVu = LoaiDichVu.MaDV AND MaPhong = '" + cboPhong.SelectedValue.ToString() + "'";
                drv1.DataSource = conn.DataTable(str);
            }
            catch
            {
                MessageBox.Show("Chưa phòng được thuê");
            }
           
        }
        private void load_dgvPhong()
        {
           try
           {
                string str = "SELECT ThuePhong.MaPhong, DonGia, CONVERT(char(10),NgayThue,101) AS NgayThue, '" + dtpNgay.Text + "' AS NgayDi, DATEDIFF(dd, NgayThue, '" + dtpNgay.Text + "') AS SoNgayO, DonGia*DATEDIFF(dd, NgayThue, '" + dtpNgay.Text + "') AS ThanhTien FROM dbo.ThuePhong, dbo.LoaiPhong, dbo.DanhSachPhong WHERE ThuePhong.MaPhong = DanhSachPhong.MaPhong AND LoaiPhong.MaLoai = DanhSachPhong.Maloai AND ThuePhong.MaPhong = '" + cboPhong.SelectedValue.ToString() + "'";
                dgvPhong.DataSource = conn.DataTable(str);
           }
           catch
           {
               MessageBox.Show("Chưa phòng được thuê");
           }
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            btnInhoadon.Visible = true;
            lblTienPhong.Text = dgvPhong.Rows[0].Cells[5].Value.ToString();
            int sc = drv1.Rows.Count;
            //tinh tong tien dich vu
            int thanhtien=0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(drv1.Rows[i].Cells["ThanhTien"].Value.ToString());
            lblTienDV.Text = thanhtien.ToString();
            //---------------------------------------
            lblTongTien.Text = (int.Parse(lblTienPhong.Text) + int.Parse(lblTienDV.Text)).ToString();
            lblMaHD.Text = phatsinhMa();
            string str = "DELETE dbo.HoaDon";
            conn.Update(str);
            //Định dạng lại ngày tháng phù hợp với SQL
            this.dtpNgay.CustomFormat = "MM/dd/yyyy";
            this.dtpNgay.Format = DateTimePickerFormat.Custom;
            //insert hoa don vào data
            str = "INSERT INTO dbo.HoaDon VALUES ('" + lblMaHD.Text + "','"+dtpNgay.Text+"','" + lblTongTien.Text + "','" + cboPhong.SelectedValue.ToString() + "','"+lay_MaKH()+"','"+txtThuNgan.Text+"')";
            conn.Update(str);
            //xoa du lieu phong da thue
            string n = lay_MaKH();
            str = "DELETE dbo.ThuePhong WHERE MaKhachHang = '"+lay_MaKH()+"' AND MaPhong = '"+cboPhong.SelectedValue.ToString()+"'";
            conn.Update(str);
            //Thay doi tinh trang cua phong
            str = "UPDATE dbo.DanhSachPhong SET TinhTrang = 0 WHERE MaPhong = '" + cboPhong.SelectedValue.ToString() + "'";
            conn.Update(str);
            str = "DELETE KHACHHANG Where MaKhachHang='" + n + "'";
            conn.Update(str);
            n="";

        }
        //lấy mã khách hàng từ combo box
        private string lay_MaKH()
        {
            try
            {
                string str = "SELECT KHACHHANG.MaKhachHang FROm dbo.KHACHHANG, dbo.ThuePhong WHERE KHACHHANG.MaKhachHang = ThuePhong.MaKhachHang AND MaPhong = '" + cboPhong.SelectedValue.ToString() + "'";
                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand(str, conn.Conn);
                str = cmd.ExecuteScalar().ToString();
                conn.CloseConnection();
                return str;
            }
            catch
            {
                MessageBox.Show("Có biến");
                return null;
            }
        }
        //-----------------------------------------------------------
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //----------------------------------------------------------
        private void TraPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có thực sự muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTienDV.ResetText();
            lblMaHD.ResetText();
            lblTienPhong.ResetText();
            lblTongTien.ResetText();
            btnInhoadon.Visible = false;
            load_dgvDichVu();
            load_dgvPhong();
        }

        private void TraPhong_Load(object sender, EventArgs e)
        {
            load_phong();
            load_dgvDichVu();
            load_dgvPhong();
        }
        //phat sinh mã hóa đơn
        private string phatsinhMa()
        {
            string str = "SELECT COUNT(*) FROM dbo.HoaDon";
            if (conn.GetCount(str) < 1)
                    return "HD1";
            else
            {
                    conn.OpenConnection();
                    SqlCommand cmd = new SqlCommand("SELECT Max(MaHoaDon) FROM HoaDon", conn.Conn);
                    str = cmd.ExecuteScalar().ToString();
                    conn.CloseConnection();
                    str = str.Substring(2);
                    str = "HD" + (Convert.ToInt32(str) + 1).ToString();
                    return str;
            }
        }
        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {

            
        }
    }
}
