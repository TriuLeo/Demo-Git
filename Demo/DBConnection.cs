using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public class DBConnection
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.connStr);
        public DBConnection() { }

        public void ThucThi(string query)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("thuc thi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable GetDataFromDatabase(string table)
        {
            DataTable dataTable = new DataTable();

            try
            {
                // Mở kết nối
                conn.Open();

                // Tạo câu lệnh SQL để lấy dữ liệu
                string sqlStr = $"SELECT * FROM {table}";

                // Tạo SqlCommand
                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                // Tạo SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Sử dụng SqlDataAdapter để lấy dữ liệu
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }

            return dataTable;
        }
        //public DataTable load()
        //{
        //    DataTable dttable = new DataTable();
        //    DBConnection dbc = new DBConnection();
        //    dbc.GetDataFromDatabase("HocSinh");
        //    dttable = dbc.GetDataFromDatabase("HocSinh"); ;
        //    return dttable;
        //}
    }
}
