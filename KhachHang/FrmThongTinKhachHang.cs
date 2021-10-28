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
    public partial class FrmThongTinKhachHang : Form
    {
        public FrmThongTinKhachHang()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();
        public void LayBangKhachHang()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From khachhang");
            dataGridViewThongTinKH.DataSource = dta;
            HIENTHI_DULIEU();
        }

        private void HIENTHI_DULIEU()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dataGridViewThongTinKH.DataSource, "makh");
            txtHoTenKH.DataBindings.Clear();
            txtHoTenKH.DataBindings.Add("Text", dataGridViewThongTinKH.DataSource, "hoten");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dataGridViewThongTinKH.DataSource, "sdt");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dataGridViewThongTinKH.DataSource, "cmnd");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataGridViewThongTinKH.DataSource, "diachi");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGridViewThongTinKH.DataSource, "email");


        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtMaKH.Focus();
        }

        private void FrmThongTinKhachHang_Load(object sender, EventArgs e)
        {
            LayBangKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_Sua = "Update khachhang SET hoten = '" + txtHoTenKH.Text + "', cmnd = '" + txtCMND.Text + "', sdt = '" + txtSDT.Text + "', email = '" + txtEmail.Text + "', diachi = '" + txtDiaChi.Text + "' where makh = '" + txtMaKH.Text + "'";
            kn.ThucThi(sql_Sua);
            LayBangKhachHang();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            string strKtra = "SELECT hoten from khachhang where makh = '" + txtMaKH.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Khach hang da co o tren du lieu", "Thong bao");
                txtMaKH.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                try
                {
                    string sql_luu = "Insert into khachhang Values('" + txtMaKH.Text + "','" + txtHoTenKH.Text + "','" + txtCMND.Text + "','" + txtSDT.Text + "','" + txtEmail.Text + "','" + txtDiaChi.Text + "')";
                    kn.ThucThi(sql_luu);
                    LayBangKhachHang();
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
                sql_xoa = "delete khachhang where makh = '" + txtMaKH.Text + "'";
                kn.ThucThi(sql_xoa);
                LayBangKhachHang();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                string message = "Khách hàng đang được phục vụ ! ";
                MessageBox.Show(message);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
