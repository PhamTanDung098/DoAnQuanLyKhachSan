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
using System.Data.SqlClient;

namespace DoAn_QuanLyKhachSan
{
    public partial class DoiMatKhau : Form
    {
        KetNoi conn = new KetNoi();
        public string ID;
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        //Lấy ID đăng nhập
        public DoiMatKhau(string Message1) : this()
        {
            ID = Message1;
        }
        //lấy mật khẩu dựa vào ID
        private string layMK()
        {
            conn.OpenConnection();
            String str = "SELECT PassWord FROM dbo.Login WHERE ID = '"+ ID +"'";
            SqlCommand cmd = new SqlCommand(str, conn.Conn);
            str = cmd.ExecuteScalar().ToString();
            conn.CloseConnection();
            return str;
        }
        //lưu lại mật khẩu mới
        private void btnXN_Click(object sender, EventArgs e)
        {
            if (txtMKC.Text == "")
                MessageBox.Show("Chưa nhâp Pass cũ");
            else if (txtMKMoi.Text == "")
                MessageBox.Show("Chưa nhâp Pass mới");
            else if (txtMKMoiAgain.Text == "")
                MessageBox.Show("chưa nhập lại Pass mới");
            else
            {
                if (txtMKC.Text.Trim().Equals(layMK()))
                {
                    MessageBox.Show("Nhap sai mat khau cu");
                }
                else
                {
                    if (txtMKMoi.Text != txtMKMoiAgain.Text)
                    {
                        MessageBox.Show("Nhap sai mat khau moi");
                    }
                    else
                    {
                        string mk = "UPDATE dbo.Login SET PassWord = '" + txtMKMoi.Text + "' WHERE ID = '"+ ID +"'";
                        conn.Update(mk);
                        MessageBox.Show("Thanh Cong");
                        foreach (Control item in this.Controls)
                            if (item.GetType() == typeof(TextBox))
                                item.ResetText();
                    }
                }
              
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
