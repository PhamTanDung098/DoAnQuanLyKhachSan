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
    public partial class DichVu : Form
    {
        KetNoi conn = new KetNoi();
        //private string _massage;
        public DichVu()
        {
            InitializeComponent();
        }
        //truyền dữ liệu
        /*public QuanLyDichVu(String Message)
            : this()
        {
            _massage = Message;
            lbTenPhong.Text = _massage;
        }*/
       
        private void QuanLyDichVu_Load(object sender, EventArgs e)
        {
            loadComboBox_DichVu();
            //lbMaDV.Visible = false;
            
            load_cbo();
        }
        //
        private void loadComboBox_DichVu()
        {
            conn.OpenConnection();
            string str = "SELECT * FROM LoaiDichVu";
            SqlDataAdapter da = new SqlDataAdapter(str, conn.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboLoaiDichVu.DataSource = dt;
            cboLoaiDichVu.DisplayMember = "TenDV";
            cboLoaiDichVu.ValueMember = "MaDV";
            conn.CloseConnection();
            
        }
        private void load_cbo()
        {
            conn.OpenConnection();
            string s = "select * from THUEPHONG";
            comboBox1.DataSource = conn.DataTable(s);
            comboBox1.DisplayMember = "MaPhong";
            comboBox1.ValueMember = "MaPhong";
            comboBox1.SelectedIndex = 0;
            conn.CloseConnection();
        
        }

        private void btnthemdv_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "INSERT INTO DichVu VALUES('"+comboBox1.Text+"', '" + cboLoaiDichVu.SelectedValue.ToString() + "', '" + Convert.ToInt32(numsoluongdv.Value).ToString() + "', '" + dtpngaydat.Text + "')";
                conn.Update(str);
                SqlDataAdapter da = new SqlDataAdapter(str, conn.strConnection);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                MessageBox.Show("Thành Công");
				loadComboBox_DichVu();
                
            }
            catch//(Exception ex)
            {
                try
                {
                    string str = "UPDATE DichVu  SET SoLuong = SoLuong + '" + Convert.ToInt32(numsoluongdv.Value).ToString() + "'";
                    conn.Update(str);
                    MessageBox.Show("Thành Công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //txtTenPhong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
        }
        //đổ dữ liệu từ combobox sang label
       



    }
}
