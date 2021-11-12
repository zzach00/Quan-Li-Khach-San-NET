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

namespace Quan_Li_Khach_San_NET.KhachHang
{
    public partial class FrmChiTietDatPhong : Form
    {
        public FrmChiTietDatPhong()
        {
            InitializeComponent();
        }

        private void FrmChiTietDatPhong_Load(object sender, EventArgs e)
        {
            DataTable dta1 = kn.Lay_DulieuBang("Select * from datphong order by madp");
            cboMaDp.DataSource = dta1;
            cboMaDp.DisplayMember = "madp";

            DataTable dta2 = kn.Lay_DulieuBang("Select * from phong order by maphong");
            cboMaPhong.DataSource = dta2;
            cboMaPhong.DisplayMember = "maphong";
            LayBangChiTiet();
        }


        Ketnoi kn = new Ketnoi();

        public void LayBangChiTiet()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From ctphongdat");
            dataGridViewCtDp.DataSource = dta;
            HIENTHI_DULIEU();
        }

        private void HIENTHI_DULIEU()
        {
            cboMaDp.DataBindings.Clear();
            cboMaDp.DataBindings.Add("Text", dataGridViewCtDp.DataSource, "madp");

            cboMaPhong.DataBindings.Clear();
            cboMaPhong.DataBindings.Add("Text", dataGridViewCtDp.DataSource, "maphong");

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            cboMaDp.Text = "";
            cboMaPhong.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_Sua = "Update ctphongdat SET  maphong = '" + cboMaPhong.Text + "' where madp = '" + cboMaDp.Text + "'  and maphong = '" + cboMaPhong.Text + "'";
                kn.ThucThi(sql_Sua);
                LayBangChiTiet();

            }
            catch (System.Data.SqlClient.SqlException)
            {
                string message = "Lỗi!";
                MessageBox.Show(message);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            string strKtra = "SELECT maphong from ctphongdat where maphong = '" + cboMaPhong.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Ma phong nay da co o tren du lieu", "Thong bao");
                cboMaPhong.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                try
                {
                    string sql_luu = "Insert into ctphongdat  Values('" + cboMaDp.Text + "','" + cboMaPhong.Text + "')";
                    kn.ThucThi(sql_luu);
                    LayBangChiTiet();

                }
                catch (System.Data.SqlClient.SqlException)
                {
                    string message = "Lỗi!";
                    MessageBox.Show(message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_xoa;
                sql_xoa = "delete ctphongdat where madp = '" + cboMaDp.Text + "'";
                kn.ThucThi(sql_xoa);
                LayBangChiTiet();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                string message = "Xoa khong thanh cong! ";
                MessageBox.Show(message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql_tim_kiem;
            sql_tim_kiem = "Select * from ctphongdat where madp like '%" + cboMaDp.Text + "%'";
            dta = kn.Lay_DulieuBang(sql_tim_kiem);
            dataGridViewCtDp.DataSource = dta;
        }
    }
}
