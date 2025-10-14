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

namespace DOANNHOM
{
    public partial class frmBaoCaoThongKe : Form
    {
        string connectionString = "data source=(localdb)\\MSSQLLocalDB;initial catalog=QuanLyThuVienDB;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "select S.TenSach, Ls.TenLoaiSach, XB.NhaXuatBan, TG.TacGia, S.SoTrang, S.GiaBan, S.SoLuong from LoaiSach LS join Sach S on LS.MaLoai = S.MaLoai join NhaXuatBan XB on XB.MaXB = S.MaXB join TacGia TG on TG.MaTacGia = S.MaTacGia";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvThongKe.DataSource = dt;
            }
        }
        private void LoadData()
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
