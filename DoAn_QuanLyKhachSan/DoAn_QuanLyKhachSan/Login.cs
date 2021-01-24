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
    public partial class Login : Form
    {
        KetNoi conn = new KetNoi();
        public Login()
        {
            InitializeComponent();
        }
        public static string ID = "";
        private string getID(string username, string pass)
        {
            string id = "";
            try
            {
                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Name ='" + username + "' and PassWord='" + pass + "'", conn.Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["ID"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                return "fail";
            }
            finally
            {
                conn.CloseConnection();
            }
            return id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ID = getID(txtDangNhap.Text, txtPassWord.Text);
            if(ID == "fail")
                MessageBox.Show("Có lỗi xảy ra !");
            else if (ID != "")
            {
                Trangchu fmain = new Trangchu(ID);
                this.Hide();
                fmain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //hiển thị mật khẩu
        private void show_CheckedChanged(object sender, EventArgs e)
        {
            if (show1.Checked == true)
                txtPassWord.UseSystemPasswordChar = false;
            else
                txtPassWord.UseSystemPasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }

    }
}

