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
	public partial class DatPhong : Form
	{
		KetNoi conn = new KetNoi();
		public DatPhong()
		{
			InitializeComponent();
		}

		private void btnTroVe_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void DatPhong_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult r;
			r = MessageBox.Show("Bạn có thực sự muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (r == DialogResult.Cancel)
				e.Cancel = true;
		}
		private string phatsinhMa()
		{
			string str = "SELECT COUNT(*) FROM dbo.KHACHHANG";
			if (conn.GetCount(str) < 1)
				return "KH1";
			else
			{
				conn.OpenConnection();
				SqlCommand cmd = new SqlCommand("SELECT Max(MaKhachHang) FROM KHACHHANG", conn.Conn);
				str = cmd.ExecuteScalar().ToString();
				conn.CloseConnection();
				str = str.Substring(2);
				str = "KH" + (Convert.ToInt32(str) + 1).ToString();
				return str;
			}
		}
		private void btnNhanPhong_Click(object sender, EventArgs e)
		{

			try
			{
				this.dtpNgayGio.CustomFormat = "MM/dd/yyyy";
				this.dtpNgayGio.Format = DateTimePickerFormat.Custom;
				string MaKH = phatsinhMa();
				string str = "INSERT INTO dbo.KHACHHANG VALUES('" + MaKH + "',N'" + txtHoTen.Text + "','" + txtSoCMND.Text + "','" + txtSDT.Text + "','" + dtpNgayGio.Text + "')";
				conn.Update(str);
				str = "UPDATE dbo.DanhSachPhong SET TinhTrang = 1 WHERE MaPhong = '" + cboPhong.SelectedValue.ToString() + "'";
				conn.Update(str);
				str = "INSERT INTO dbo.ThuePhong VALUES ('" + cboPhong.SelectedValue.ToString() + "','" + MaKH + "','" + dtpNgayGio.Text + "','" + Convert.ToInt32(numSL.Value) + "')";
				conn.Update(str);
				MessageBox.Show("Đặt phòng thành công!!!");

			}
			catch
			{
				MessageBox.Show("Đặt phòng Thất Bại");
			}
			foreach (Control item in groupBox2.Controls)
			{
				if (item.GetType() == typeof(TextBox))
					item.ResetText();
			}
		}
		private void loadComboBox_LoaiPhong()
		{
			string str = "SELECT * FROM dbo.LoaiPhong";
			cboLoaiPhong.DataSource = conn.DataTable(str);
			cboLoaiPhong.DisplayMember = "TenLoai";
			cboLoaiPhong.ValueMember = "MaLoai";
		}
		private void loadComboBox_Phong()
		{
			string str = "SELECT * FROM dbo.DanhSachPhong WHERE TinhTrang = 0 AND MaLoai = '" + cboLoaiPhong.SelectedValue.ToString() + "'";
			cboPhong.DataSource = conn.DataTable(str);
			cboPhong.DisplayMember = "MaPhong";
			cboPhong.ValueMember = "MaPhong";

		}
		private void DatPhong_Load(object sender, EventArgs e)
		{
			loadComboBox_LoaiPhong();
			loadComboBox_Phong();
		}

		private void txtSDT_TextChanged(object sender, EventArgs e)
		{
			if (!txtHoTen.Text.Equals(string.Empty) && !txtSoCMND.Text.Equals(string.Empty))
				btnNhanPhong.Enabled = true;
		}

		private void txtSoCMND_TextChanged(object sender, EventArgs e)
		{
			if (!txtHoTen.Text.Equals(string.Empty) && !txtSDT.Text.Equals(string.Empty))
				btnNhanPhong.Enabled = true;
            if (kiemtra(txtSoCMND.Text))
            {
                conn.OpenConnection();
                string s = "select Hoten from KHACHHANG where CMND = '" + txtSoCMND.Text + "'";
                SqlCommand cmd = new SqlCommand(s, conn.Conn);
                string g= (string)cmd.ExecuteScalar();
                txtHoTen.Text = g.Trim();
                string d = "select SDT from KHACHHANG where CMND ='" + txtSoCMND.Text + "'";
                SqlCommand mnd = new SqlCommand(d, conn.Conn);
                string h = (string)mnd.ExecuteScalar();
                txtSDT.Text = h.Trim();

            }
		}

		private void txtHoTen_TextChanged(object sender, EventArgs e)
		{
			if (!txtSDT.Text.Equals(string.Empty) && !txtSoCMND.Text.Equals(string.Empty))
				btnNhanPhong.Enabled = true;
           
            
		}
        bool kiemtra(string s)
        {
            conn.OpenConnection();
            string d = "select count(*) from KHACHHANG where CMND='"+s+"'";
            SqlCommand cmd = new SqlCommand(d, conn.Conn);
            int count = (int)cmd.ExecuteScalar();
            conn.CloseConnection();
            if (count <= 0)
                return false;
            return true;
        }
		private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
		{
			loadComboBox_Phong();
		}

		private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show(" Nhập vào một số");
			}
		}

		private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("Họ tên phải là kí tự chữ ", "Thông Báo ");
			}
		}
	}
}
