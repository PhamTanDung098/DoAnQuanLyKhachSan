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
    public partial class QLKhachHang : Form
    {
        KetNoi conn = new KetNoi();
        public QLKhachHang()
        {
            InitializeComponent();
        }

        private void Khachhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có thực sự muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (btnTimKiem.Text == "   Tìm kiếm")
            {
                btnTimKiem.Text = "Hủy";
                btnTimKiem.ImageIndex = 3;
                foreach (Control item in this.Controls)
                    if (item.GetType() == typeof(Label) || item.GetType() == typeof(TextBox) || item.GetType() == typeof(Button))
                        item.Visible = true;
                drvTimKiem.Visible = true;
            }
            else
            {
                btnTimKiem.Text = "   Tìm kiếm";
                btnTimKiem.ImageIndex = 1;
                foreach (Control item in this.Controls)
                    if (item.GetType() == typeof(Label) || item.GetType() == typeof(TextBox))
                        item.Visible = true;
                btnXacNhan.Visible = false;
                drvTimKiem.Visible = false;
            }
        }
        private void load_drvKhachHang()
        {
            try
            {
                string str = "SELECT MaPhong, HoTen, CMND, SDT, ThuePhong.NgayThue FROM dbo.ThuePhong, dbo.KHACHHANG WHERE KHACHHANG.MaKhachHang = ThuePhong.MaKhachHang";
                drvKhachHang.DataSource = conn.DataTable(str);
                for (int i = 0; i < drvKhachHang.Rows.Count - 1; i++)
                {
                    drvKhachHang.Rows[i].Cells[0].Value = i + 1;
                }
            }
            catch
            {
                MessageBox.Show("Có biến");
            }
        }
        private void load_drvTimKiem()
        {
            try
            {
                string str = "SELECT MaPhong, HoTen, CMND, SDT, ThuePhong.NgayThue FROM dbo.ThuePhong, dbo.KHACHHANG WHERE KHACHHANG.MaKhachHang = ThuePhong.MaKhachHang AND (ThuePhong.MaPhong = '"+txtMKH.Text+"' OR HoTen = N'"+txtTenKH.Text+"' OR CMND = '"+txtCMND.Text+"' OR SDT = '"+txtSoDT.Text+"')";
                drvTimKiem.DataSource = conn.DataTable(str);
                for (int i = 0; i < drvTimKiem.Rows.Count - 1; i++)
                {
                    drvTimKiem.Rows[i].Cells[0].Value = i + 1;
                }
            }
            catch
            {
                MessageBox.Show("Có biến");
            }
        }
        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            load_drvKhachHang();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            load_drvTimKiem();
            foreach (Control item in this.Controls)
                if (item.GetType() == typeof(TextBox))
                    item.ResetText();
        }

        private void drvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
				e.Handled = true;
				MessageBox.Show("Họ tên phải là kí tự chữ ", "Thông Báo ");
			}
		}

		private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("kí tự số ", "Thông Báo ");
			}
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }
	}
}
