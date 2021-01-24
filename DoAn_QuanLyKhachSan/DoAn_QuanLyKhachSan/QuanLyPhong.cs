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
    public partial class QuanLyPhong : Form
    {
        KetNoi conn = new KetNoi();
		DataSet ds;
		SqlDataAdapter da;
		public QuanLyPhong()
        {
            InitializeComponent();
        }
        //LOAIPHONG
        private void btnthemloaiphong_Click(object sender, EventArgs e)
        {
            if (btnthemloaiphong.ImageIndex == 1)
            {
                btnthemloaiphong.Text = "  Hủy";
                btnthemloaiphong.ImageIndex = 5;
                txtMaLoai.Enabled = true;
                txtGia.Enabled = true;
                numSoNguoi.Enabled = true;
                txtLoaiPhong.Visible = true;
                lbLoaiPhong.Visible = true;
                btnLuuLoaiPhong.Enabled = true;
            }
            else
            {
                btnthemloaiphong.Text = " Thêm";
                btnthemloaiphong.ImageIndex = 1;
                txtMaLoai.Enabled = false;
                txtGia.Enabled = false;
                numSoNguoi.Enabled = false;
                txtLoaiPhong.Visible = false;
                lbLoaiPhong.Visible = false;
                btnLuuLoaiPhong.Enabled = false;
            }
        }
        //PHONG
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.ImageIndex == 1)//khi nhấm thêm thì nút thêm trở thành "Hủy"
            {
                btnThem.Text = "  Hủy";
                btnThem.ImageIndex = 5;
                txtPhong.Enabled = true;
                cmbTenLoaiPhong.Enabled = true;
                txtPhong.Focus();
                btnLuuGia.Enabled = true;
				
			}
            else
            {
                btnThem.Text = " Thêm";
                btnThem.ImageIndex = 1;
                txtPhong.Text = "";
                txtPhong.Enabled = false;
                cmbTenLoaiPhong.Enabled = false;
                btnLuuGia.Enabled = false;
            }
        }

        private void Phong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //PHONG
        private void loadComboBox_LoaiPhong()
        {
            string str = "SELECT * FROM dbo.LoaiPhong";
            cmbTenLoaiPhong.DataSource = conn.DataTable(str);
            cmbTenLoaiPhong.DisplayMember = "TenLoai";
            cmbTenLoaiPhong.ValueMember = "MaLoai";
            cmbTenLoaiPhong.SelectedIndex = 0;
        }

        private void Phong_Load(object sender, EventArgs e)
        {
           
            loadComboBox_LoaiPhong();
            load_dgvphong();
         
            //LOAIPHONG
            load_ListView();
        }
        //PHONG
        private void load_dgvphong()
        {
			
			//string str = "SELECT MaPhong, TenLoai, SoLuong, DonGia FROM DanhSachPhong, LoaiPhong WHERE LoaiPhong.MaLoai = DanhSachPhong.MaLoai ";
			//dgvphong.DataSource = conn.DataTable(str);
			//con.Open();
			string hthi = "SELECT MaPhong, TenLoai, SoLuong, DonGia FROM DanhSachPhong, LoaiPhong WHERE LoaiPhong.MaLoai = DanhSachPhong.MaLoai ";
			SqlDataAdapter da = new SqlDataAdapter(hthi,conn.strConnection);
			// cmd.ExecuteReader();
			// DataTable dt = new DataTable();
			DataSet ds = new DataSet();
			//SqlDataAdapter da = new SqlDataAdapter(cmd);
			//da.Fill(dt);
			da.Fill(ds, "DMHang");// 
			dgvphong.DataSource = ds.Tables[0];
		
		}
        
        //PHONG
        private void btnLuuGia_Click(object sender, EventArgs e)
        {
            try
            {
                string str1 = "INSERT INTO dbo.DanhSachPhong VALUES('" + txtPhong.Text + "', '"+ 0 +"', '" + cmbTenLoaiPhong.SelectedValue.ToString() + "')";
                conn.Update(str1);
                MessageBox.Show("Thêm Thành Công");
				
				
				//load_ListView();


			}
            catch
            {
                MessageBox.Show("Thêm Thất bại");
            }
			load_dgvphong();
			//loadComboBox_LoaiPhong();
		}
        //PHONG
        private void btbXoa_Click(object sender, EventArgs e)
        {
				try
				{
					dgvphong.Rows.RemoveAt(dgvphong.CurrentRow.Index);
					Update();
					string upstr = "DELETE dbo.DanhSachPhong WHERE MaPhong = '" + txtPhong.Text.Trim() + "'";
					conn.Update(upstr);
					MessageBox.Show("Xóa Thành công");
				}
				catch //(Exception ex)
				{
					MessageBox.Show("Không xóa được");
				}
			load_dgvphong();
			
			}
        //PHONG
        private void dgvphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtPhong.Text = Convert.ToString(dgvphong.CurrentRow.Cells[0].Value);
                cmbTenLoaiPhong.Text = Convert.ToString(dgvphong.CurrentRow.Cells[1].Value);
                txtPhong.Enabled = true;
                cmbTenLoaiPhong.Enabled = true;
                btbXoa.Enabled = true;
            }
        }
       
        //LOAIPHONG
        private void btnLuuLoaiPhong_Click(object sender, EventArgs e)
        {
			
			try
			{
				ListViewItem item = new ListViewItem();
				item.Text = txtMaLoai.Text;
				item.SubItems.Add(txtGia.Text);
				item.SubItems.Add(Convert.ToInt32(numSoNguoi.Value).ToString());
				lsvLoaiPhong.Items.Add(item);
				load_dgvphong();
			}
			catch
			{
				MessageBox.Show("hãy thử lại");
			}
			//lưu dữ liệu vào database
				try
				{
					String strSQL = "INSERT INTO LoaiPhong(MaLoai, TenLoai, DonGia, SoLuong) VALUES('" + txtMaLoai.Text + "', N'" + txtLoaiPhong.Text + "', '" + txtGia.Text + "','" + Convert.ToInt32(numSoNguoi.Value).ToString() + "')";
					conn.Update(strSQL);
					MessageBox.Show("Thêm thành công!!!");

					

				}
				catch
				{
					//MessageBox.Show("Thêm Thất Bại");
				}
			//load_dgvphong();
			//lsvLoaiPhong.Items.Clear();
			load_ListView();
		}
       
        //LOAIPHONG
		
        private void load_ListView()
        {
			SqlDataAdapter da = new SqlDataAdapter("SELECT MaLoai, DonGia, SoLuong FROM LoaiPhong", conn.strConnection);

			DataTable tb = new DataTable();

			da.Fill(tb);
			lsvLoaiPhong.Items.Clear();
			lsvLoaiPhong.View = View.Details;
			//lsvDichVu.Columns.Add("MADV");
			//lsvDichVu.Columns.Add("TENDV");
			//lsvDichVu.Columns.Add("DONGIA");//DM DM DM DM
			//lsvDichVu.Columns.Add("DONVITINH"); RỒI Á MAN, XÓA CHƯA ĐC MÀ
			lsvLoaiPhong.GridLines = true;
			lsvLoaiPhong.FullRowSelect = true;

			int i = 0;
			foreach (DataRow row in tb.Rows)
			{
				lsvLoaiPhong.Items.Add(row["MaLoai"].ToString());
				lsvLoaiPhong.Items[i].SubItems.Add(row["DonGia"].ToString());
				lsvLoaiPhong.Items[i].SubItems.Add(row["SoLuong"].ToString());
				i++;
			}
			Dataningding(tb);
		}
        //LOAIPHONG
        //load dữ liệu từ listview sang combobox
        private void lsvLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
			foreach (ListViewItem items in lsvLoaiPhong.SelectedItems)
			{
				txtMaLoai.Text = items.SubItems[0].Text;
				txtGia.Text = items.SubItems[1].Text;
				numSoNguoi.Text = items.SubItems[2].Text;
				txtMaLoai.Enabled = true;
				txtGia.Enabled = true;
				numSoNguoi.Enabled = true;
				btnxoaloaiphong.Enabled = true;
			}
		}
		//LOAIPHONG
		void Dataningding(DataTable pDT)
		{
			txtMaLoai.DataBindings.Clear();
			txtGia.DataBindings.Clear();
			numSoNguoi.DataBindings.Clear();


			////////////////////////////////////////////
			txtMaLoai.DataBindings.Add("Text", pDT, "MaLoai");
			txtGia.DataBindings.Add("Text", pDT, "DonGia");
			numSoNguoi.DataBindings.Add("Text", pDT, "SoLuong");
		}// xong á coi cái nào nữa k// để t chạy coi thử





		private void btnxoaloaiphong_Click(object sender, EventArgs e)
        {
			try
			{
				string str = "DELETE dbo.LoaiPhong WHERE MaLoai = '" + txtMaLoai.Text.Trim() + "'";
				conn.Update(str);
				MessageBox.Show("Xóa thành công!!!");
				
			}
			catch
			{
				MessageBox.Show("Dịch vụ này đang được sử dụng");
			}
			load_ListView();



			//try
			//         {
			//	DataRow dr = ds.Tables[0].Rows.Find(txtMaLoai.Text);
			//	if (dr != null)
			//	{
			//		dr.Delete();

			//	}
			//	SqlCommandBuilder cb = new SqlCommandBuilder(da);
			//	da.Update(ds, "dbo.LoaiPhong");
			//	MessageBox.Show("Xóa thành công");

			//Update();
			//            string str = "DELETE dbo.LoaiPhong WHERE MaLoai = '" + txtMaLoai.Text.Trim() + "'";
			//            conn.Update(str);
			//            lsvLoaiPhong.Items.RemoveAt(lsvLoaiPhong.SelectedItems[0].Index);
			//             MessageBox.Show("Xóa thành công!!!");
			//	load_ListView();

			//}
			//         catch
			//         {
			//             MessageBox.Show("Xóa thất bại!!!");
			//         }
		}
        //gọi form con
        private void btnQLVT_Click(object sender, EventArgs e)
        {
            VatTuTrongPhong vt = new VatTuTrongPhong(txtPhong.Text, cmbTenLoaiPhong.Text, cmbTenLoaiPhong.SelectedValue.ToString());
            vt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            dv.Show();
        }
        //Lay don gia cua loai phong
        private string lay_DonGia()
        {
            string str = "SELECT DonGia FROm dbo.LoaiPhong WHERE MaLoai = '" + cmbTenLoaiPhong.SelectedValue.ToString() + "'";
            conn.OpenConnection();
            SqlCommand cmd = new SqlCommand(str, conn.Conn);
            str = cmd.ExecuteScalar().ToString();
            conn.CloseConnection();
            return str;
        }
        //Lay so luong nguoi cua loai phong
        private string lay_SoLuong()
        {
            string str = "SELECT SoLuong FROm dbo.LoaiPhong WHERE MaLoai = '" + cmbTenLoaiPhong.SelectedValue.ToString() + "'";
            conn.OpenConnection();
            SqlCommand cmd = new SqlCommand(str, conn.Conn);
            str = cmd.ExecuteScalar().ToString();
            conn.CloseConnection();
            return str;
        }

        private void txtLoaiPhong_TextChanged(object sender, EventArgs e)
        {

        }

		private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				e.Handled = true;
		}

		private void numSoNguoi_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
//để ta chạy coi còn nào ko
