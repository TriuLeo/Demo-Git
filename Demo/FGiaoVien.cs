using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class FGiaoVien : Form
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.connStr);

        public FGiaoVien()
        {
            InitializeComponent();
        }
        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM GiaoVien");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtGiaoVien = new DataTable();
                adapter.Fill(dtGiaoVien);
                gvGiaoVien.DataSource = dtGiaoVien; /// gvHsinh = name cua data gridview
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnChuyen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FHocSinh fhs = new FHocSinh();
            fhs.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Ket noi
                conn.Open();
                string sqlStr = string.Format("INSERT INTO GiaoVien(Ten , Diachi , Cmnd, NgaySinh) VALUES ('{0}', '{1}', '{2}', '{3}')"
                    , txtHovaTen.Text, txtDiaChi.Text, txtCCCD.Text, dtpNgaySinh.Value.ToString("dd-MM-yyyy"));
                GiaoVien gv = new GiaoVien();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("them thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("DELETE FROM GiaoVien WHERE Cmnd = '{0}'", txtCCCD.Text);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("xoa thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("xoa that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("UPDATE GiaoVien SET Ten = '{0}', DiaChi = '{1}', NgaySinh = '{3}' WHERE Cmnd = '{2}'"
                    , txtHovaTen.Text, txtDiaChi.Text, txtCCCD.Text, dtpNgaySinh.Value.ToString("dd-MM-yyyy"));
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("sua thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("sua that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private DataTable GetDataFromDatabase()
        {
            DataTable dataTable = new DataTable();

            try
            {
                // Mở kết nối
                conn.Open();

                // Tạo câu lệnh SQL để lấy dữ liệu
                string sqlStr = "SELECT * FROM GiaoVien";

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
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Giả sử GetDataFromDatabase() là phương thức lấy dữ liệu từ CSDL
            DataTable dataTable = GetDataFromDatabase();
            // Cập nhật DataSource của gvHsinh
            gvGiaoVien.DataSource = dataTable;
        }
    }
}
