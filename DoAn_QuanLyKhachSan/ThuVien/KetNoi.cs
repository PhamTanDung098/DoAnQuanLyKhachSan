using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ThuVien
{
    public class KetNoi
    {
        private SqlConnection conn;
        private String strconn;
        private DataSet dset;

        public KetNoi()
        {
            strConnection = @"Data source =DESKTOP-KMNS09Q\SQLEXPRESS; Initial Catalog = QUANLYKHACHSAN;User ID=sa;Password=sa2012";
            conn = new SqlConnection(strConnection);
            Dset = new DataSet();
        }
        public KetNoi(string pStrConn)
        {
            strConnection = "@" + pStrConn;
            conn = new SqlConnection(strConnection);
            dset = new DataSet();
        }
        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        public String strConnection
        {
            get { return strconn; }
            set { strconn = value; }
        }
        public DataSet Dset
        {
            get { return dset; }
            set { dset = value; }
        }
        public void OpenConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = strConnection;
            conn.Open();
        }
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Dispose();
        }
        public void Update(string strSQL)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public int GetCount(string strSQL)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = strSQL;
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            CloseConnection();
            return count;
        }
        public bool checkForExistence(string str)
        {
            int count = GetCount(str);
            if (count > 0)
                return true;
            return false;
        }
        public SqlDataReader getDataReader(string str)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = str;
            SqlDataReader data = cmd.ExecuteReader();
            CloseConnection();
            return data;
        }
        public SqlDataAdapter addTableToDataSet(string str, string tableName)
        {
            SqlDataAdapter data = new SqlDataAdapter(str, conn);
            data.Fill(Dset, tableName);
            return data;
        }
        public DataTable DataTable(string str)
        {
            SqlDataAdapter data = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            data.Fill(dt);/// 
            return dt;
        }
    }
	
}
