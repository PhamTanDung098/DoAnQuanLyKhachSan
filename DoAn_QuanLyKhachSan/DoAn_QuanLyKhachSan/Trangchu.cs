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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }
        public string ID;
        //lấy ID của người đăng nhập 
        public Trangchu(string Message1) : this()
        {
            ID = Message1;
        }
        private void Trangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
           
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            QLKhachHang kh = new QLKhachHang();
            kh.Show();
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            QuanLyPhong p = new QuanLyPhong();
            p.Show();
        }

        private void btnQuanLyVatTu_Click(object sender, EventArgs e)
        {
            QuanLyVatTu vt = new QuanLyVatTu();
            vt.Show();
        }

        private void btnQuanLyDichVu_Click(object sender, EventArgs e)
        {
            QuanLyDichvu dv = new QuanLyDichvu();
            dv.Show();
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            DatPhong dt = new DatPhong();
            dt.Show();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            TraPhong tp = new TraPhong();
            tp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            dv.Show();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau mk = new DoiMatKhau(ID);
            mk.Show();
        }
        //Phân quyền người sử dụng, nếu không phải admin thì ko sửa được cái bố trí trong khách sạn
        private void Trangchu_Load(object sender, EventArgs e)
        {
            if (ID.Trim().CompareTo("ID01") == 0)
            {
                btnQuanLyDichVu.Enabled = true;
                btnQuanLyKhachHang.Enabled = true;
                btnQuanLyPhong.Enabled = true;
                btnQuanLyVatTu.Enabled = true;
            }
            
        }
       
        
    }
}
