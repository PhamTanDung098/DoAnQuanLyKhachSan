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
    public partial class QuanLyDichvu : Form
    {
		KetNoi conn = new KetNoi();
		DataSet ds;
		SqlDataAdapter da;
        public QuanLyDichvu()
        {
            InitializeComponent();
        }
        public bool ktTrungKhoaChinh(string Key1)
        {
            string strSQL = "SELECT count(*) FROM dbo.LoaiDichVu WHERE MaDV ='" + Key1 + "'";
            if (conn.GetCount(strSQL) > 0)
                return true;
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string key1 = txtMaDV.Text;

            if (ktTrungKhoaChinh(key1))
            {
                MessageBox.Show("Trùng khóa chính");

            }
            else
            {
                try
                {
                    String strSQL = "INSERT into dbo.LoaiDichVu VALUES('" + key1 + "',N'" + txtTenDV.Text + "', '" + txtGia.Text + "',N'" + cboDVT.SelectedItem.ToString() + "')";
                    conn.Update(strSQL);
                    MessageBox.Show("Thêm thành công!!!");
					
					//chay xem chu t bt dau ma chay

				}
                catch
                {
                    //MessageBox.Show("Thêm Thất Bại");
                }
				load_lsvDichVu();
			}
           
        }
		private void load_lsvDichVu()
		{
			SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.LoaiDichVu", conn.strConnection);

			DataTable tb = new DataTable();

			da.Fill(tb);
			lsvDichVu.Items.Clear();
			lsvDichVu.View = View.Details;
			//lsvDichVu.Columns.Add("MADV");
			//lsvDichVu.Columns.Add("TENDV");
			//lsvDichVu.Columns.Add("DONGIA");//DM DM DM DM
			//lsvDichVu.Columns.Add("DONVITINH"); RỒI Á MAN, XÓA CHƯA ĐC MÀ
			lsvDichVu.GridLines = true;
			lsvDichVu.FullRowSelect = true;

			int i = 0;
			foreach (DataRow row in tb.Rows)
			{
				lsvDichVu.Items.Add(row["MaDV"].ToString());
				lsvDichVu.Items[i].SubItems.Add(row["TenDV"].ToString());
				lsvDichVu.Items[i].SubItems.Add(row["DonGia"].ToString());
				lsvDichVu.Items[i].SubItems.Add(row["DonViTinh"].ToString());
				i++;
			}
			Dataningding(tb);
		}
        private void loadComboBox_DonViTinh()
        {
            string[] dv = { "Phần", "Chai", "Lon", "Đĩa", "Bịch", "Lượt" };
            foreach (string s in dv)
            {
                    cboDVT.Items.Add(s);
            }
            cboDVT.SelectedIndex = 0;
            
        }
        private void Dichvu_Load(object sender, EventArgs e)
        {
            load_lsvDichVu();
            loadComboBox_DonViTinh();
           
        }

        private void lsvDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem items in lsvDichVu.SelectedItems)
            {
                txtMaDV.Text = items.SubItems[0].Text;
                txtTenDV.Text = items.SubItems[1].Text;
                txtGia.Text = items.SubItems[2].Text;
                //cboDVT.SelectedItem = items.SubItems[3].Text;
                cboDVT.Text = items.SubItems[3].Text;
            }
        }

        private void btbXoa_Click(object sender, EventArgs e)
        {

            try
            {
                string str = "DELETE dbo.LoaiDichVu WHERE MaDV = '" + txtMaDV.Text + "'";
                conn.Update(str);
                MessageBox.Show("Xóa thành công!!!");

            }
            catch 
            {
                MessageBox.Show("Dịch vụ này đang được sử dụng");
            }
			load_lsvDichVu();// xong luôn, ê m bên cái quản lý phòng nãy còn cái kia chưa chỉnh xong 
        }

		void Dataningding(DataTable pDT)
		{
			txtMaDV.DataBindings.Clear();
			txtTenDV.DataBindings.Clear();
			cboDVT.DataBindings.Clear();
			txtGia.DataBindings.Clear();
			

			////////////////////////////////////////////
			txtMaDV.DataBindings.Add("Text", pDT, "MaDV");
			txtTenDV.DataBindings.Add("Text", pDT, "TenDv");
			cboDVT.DataBindings.Add("Text", pDT, "DonViTinh");
			txtGia.DataBindings.Add("Text", pDT, "DonGia");
		}// xong á coi cái nào nữa k// để t chạy coi thử

		private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "UPDATE dbo.LoaiDichVu SET TenDV = N'" +txtTenDV.Text+ "', DonGia = '"+Convert.ToInt32(txtGia.Text)+"', DonViTinh = N'"+cboDVT.Text+"' WHERE MaDV = '" +txtMaDV.Text+ "'";
                conn.Update(strSQL);
                MessageBox.Show("Cập nhật thành công!!!");

            }
            catch
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Cập nhật Thất Bại");
            }
			load_lsvDichVu();
		}

        private void cboDVT_Click(object sender, EventArgs e)
        {
            //string [] dv = {"Phần", "Chai", "Lon", "Đĩa", "Bịch", "Lượt"};
            //foreach (string s in dv)
            //{
            //    cboDVT.Items.Add(s);
            //}
        }

		private void txtGia_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show(" Nhập vào một số");
			}
		}
	}
}
