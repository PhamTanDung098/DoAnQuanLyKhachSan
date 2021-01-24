using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;

namespace DoAn_QuanLyKhachSan
{
    public partial class VatTuTrongPhong : Form
    {
        KetNoi conn = new KetNoi();
        private string _message1;
        private string _message2;
        private string _message3;
        public VatTuTrongPhong()
        {
            InitializeComponent();
        }
        public VatTuTrongPhong(string Message1, string Message2, string Message3)
            : this()
        {
            _message1 = Message1;
            lbTenPhong.Text = _message1;
            _message2 = Message2;
            lbLoaiPhong.Text = _message2;
            _message3 = Message3;
            lbMaLoai.Text = _message3;
        }
        private void btnVTThem_Click(object sender, EventArgs e)
        {
            if (btnVTThem.ImageIndex == 1)
            {
                btnVTThem.Text = "  Hủy";
                btnVTThem.ImageIndex = 8;
                cboVTPhong.Enabled = true;
                numSLVTPhong.Enabled = true;
                btnVTUpdate.Enabled = true;
                txtVTMaLoai.Enabled = true;
            }
            else
            {
                btnVTThem.Text = " Thêm";
                btnVTThem.ImageIndex = 1;
                cboVTPhong.Enabled = false;
                numSLVTPhong.Enabled = false;
                txtVTMaLoai.Enabled = false;
                btnVTUpdate.Enabled = false;
            }
        }

        private void VatTuTrongPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
        }
        //
        private void VatTuTrongPhong_Load(object sender, EventArgs e)
        {
            btnVTUpdate.Enabled = false;
            btnVTXoa.Enabled = false;
            cboVTPhong.Enabled = false;
            numSLVTPhong.Enabled = false;
            loadCombobox_VatTuTrongPhong();
            load_dgvVatTuPhong();
            lbMaLoai.Visible = false;
            txtVTMaLoai.Visible = false;
            lbMaLoai1.Visible = false;
        }

        private void loadCombobox_VatTuTrongPhong()
        {
            string str = "SELECT * FROM dbo.VatTu";
            cboVTPhong.DataSource = conn.DataTable(str);
            cboVTPhong.DisplayMember = "TenVatTu";
            cboVTPhong.ValueMember = "MaVatTu";
            cboVTPhong.SelectedIndex = 0;
        }

        private void load_dgvVatTuPhong()
        {
            //string str = "SELECT TenVT,SoLuong FROM DanhSachPhong, BoTri, VatTu WHERE DanhSachPhong.MaLoai = BoTri.MaLoai AND BoTri.MaVT = VatTu.MaVT";
            string str = "SELECT TenVatTu, SoLuong FROM BoTri, VatTu WHERE MaLoai = '" + lbMaLoai.Text + "' AND BoTri.MaVatTu = VatTu.MaVatTu";
            dgvVatTu.DataSource = conn.DataTable(str);
            //Update();
            for (int i = 0; i < dgvVatTu.Rows.Count; i++)
            {
                dgvVatTu.Rows[i].Cells[0].Value = i + 1;
            }
        }

        /*public bool ktTrungKhoaChinhVT(string Key1)
        {
            string strSQL = "SELECT count(*) FROM dbo.VatTu WHERE MaVT ='" + Key1 + "'";
            if (conn.GetCount(strSQL) > 0)
                return true;
            return false;
        }*/

        private void btnVTUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //string str = "INSERT INTO VatTu(MaVT, TenVT) VALUES('" + txtVTMaLoai.Text + "', N'" + cboVTPhong.Text + "')";
                //conn.Update(str);
                string str1 = "UPDATE BoTri SET SoLuong =SoLuong + '"+ Convert.ToInt32(numSLVTPhong.Value).ToString() +"' WHERE MaLoai = '"+lbMaLoai.Text+"' AND MaVatTu = '"+txtVTMaLoai.Text+"'";
                conn.Update(str1);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        //
        private void dgvVatTu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cboVTPhong.Text = Convert.ToString(dgvVatTu.CurrentRow.Cells[1].Value);
                numSLVTPhong.Text = Convert.ToString(dgvVatTu.CurrentRow.Cells[2].Value);
                cboVTPhong.Enabled = true;
                numSLVTPhong.Enabled = true;
                lbMaLoai1.Visible = false;
                btnVTUpdate.Enabled = true;
                //txtVTMaLoai.Visible = true;
                btnVTXoa.Enabled = true;
            }
        }

        private void btnVTXoa_Click(object sender, EventArgs e)
        {
            dgvVatTu.Rows.RemoveAt(0);
            try
            {
                Update();
                string str = "DELETE dbo.BoTri WHERE MaVatTu = '" + cboVTPhong.SelectedValue.ToString() + "'";
                conn.Update(str);
                MessageBox.Show("Xóa thành công!!!");

            }
            catch
            {
                MessageBox.Show("Xóa thất bại!!!");
            }
        }
        //đổ dữ liệu từ combobox sang textbox
        private void cboVTPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVTMaLoai.Text = cboVTPhong.SelectedValue.ToString();
        }
        //--------------------------------------------
        private void btnVT_Click(object sender, EventArgs e)
        {
            try
            {
                //string str = "INSERT INTO VatTu(MaVatTu, TenVatTu) VALUES('" + txtVTMaLoai.Text + "', N'" + cboVTPhong.Text + "')";
                //conn.Update(str);
                string str1 = "INSERT INTO BoTri(MaLoai, MaVatTu, SoLuong) VALUES('" + lbMaLoai.Text + "', '" + txtVTMaLoai.Text + "', '" + Convert.ToInt32(numSLVTPhong.Value).ToString() + "')";
                conn.Update(str1);
                MessageBox.Show("Thêm Thành Công");
            }
            catch
            {
                MessageBox.Show("Đã tồn tại");
            }
        }
        //-------------------------------------------------------------
    }
}
