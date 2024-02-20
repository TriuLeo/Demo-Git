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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Demo
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.connStr);

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtSinhVien = new DataTable();
            HocSinhDAO hsDAO = new HocSinhDAO();
            dtSinhVien = hsDAO.Load();
            gvHsinh.DataSource = dtSinhVien; /// gvHsinh = name cua data gridview
        }
        public FHocSinh()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinhDAO hsDAO = new HocSinhDAO();
            hsDAO.Them(txtHovaTen.Text, txtDiaChi.Text, txtCCCD.Text, dtpNgaySinh.Value.ToString("dd-MM-yyyy"));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinhDAO hsDAO = new HocSinhDAO();
            hsDAO.Xoa(txtCCCD.Text);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinhDAO hsDAO = new HocSinhDAO();
            hsDAO.Sua(txtHovaTen.Text, txtDiaChi.Text, txtCCCD.Text, dtpNgaySinh.Value.ToString("dd-MM-yyyy"));
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FGiaoVien fgv = new FGiaoVien();
            fgv.Show();
        }
        
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HocSinhDAO hsDAO = new HocSinhDAO();
            hsDAO.LamMoi(gvHsinh);
        }
    }
}

