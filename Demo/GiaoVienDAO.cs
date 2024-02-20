using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public class GiaoVienDAO : PersonDAO
    {
        //Giao vien Data Access Object
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.connStr);
        public GiaoVienDAO() { }

        //public void ThucThi(string query)
        //{
        //    try
        //    {
        //        // Ket noi
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        if (cmd.ExecuteNonQuery() > 0)
        //            MessageBox.Show("thuc thi thanh cong");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("thuc thi that bai" + ex);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        public void Them(string hoTen, string diaChi, string cmnd, string ngaySinh)
        {
            string sqlStr = string.Format("INSERT INTO GiaoVien(Ten , Diachi , Cmnd, NgaySinh) VALUES ('{0}', '{1}', '{2}', '{3}')"
                    , hoTen, diaChi, cmnd, ngaySinh);
            DBConnection dbc = new DBConnection();
            dbc.ThucThi(sqlStr);
            HocSinh hs = new HocSinh(hoTen, diaChi, cmnd, ngaySinh);
        }

        public void Xoa(string cmnd)
        {
            string SQL = string.Format("DELETE FROM GiaoVien WHERE Cmnd = '{0}'", cmnd);
            DBConnection dbc = new DBConnection();
            dbc.ThucThi(SQL);
        }

        public void Sua(string hoTen, string diaChi, string cmnd, string ngaySinh)
        {
            string SQL = string.Format("UPDATE GiaoVien SET Ten = '{0}', DiaChi = '{1}', NgaySinh = '{3}' WHERE Cmnd = '{2}'"
                    , hoTen, diaChi, cmnd, ngaySinh);
            DBConnection dbc = new DBConnection();
            dbc.ThucThi(SQL);
        }

        //public DataTable GetDataFromDatabase()
        //{
        //    DataTable dataTable = new DataTable();

        //    try
        //    {
        //        // Mở kết nối
        //        conn.Open();

        //        // Tạo câu lệnh SQL để lấy dữ liệu
        //        string sqlStr = "SELECT * FROM GiaoVien";

        //        // Tạo SqlCommand
        //        SqlCommand cmd = new SqlCommand(sqlStr, conn);

        //        // Tạo SqlDataAdapter
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        //        // Sử dụng SqlDataAdapter để lấy dữ liệu
        //        adapter.Fill(dataTable);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
        //    }
        //    finally
        //    {
        //        // Đóng kết nối
        //        conn.Close();
        //    }

        //    return dataTable;
        //}

        public void LamMoi(DataGridView gvGiaoVien)
        {
            DBConnection dbc = new DBConnection();
            DataTable dataTable = dbc.GetDataFromDatabase("GiaoVien");
            gvGiaoVien.DataSource = dataTable;
        }

        public DataTable Load()
        {
            DataTable dttable = new DataTable();
            DBConnection dbc = new DBConnection();
            dttable = dbc.GetDataFromDatabase("GiaoVien");
            return dttable;
        }
    }
}
