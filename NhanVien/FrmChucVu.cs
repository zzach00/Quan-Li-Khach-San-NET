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


namespace Quan_Li_Khach_San_NET.NhanVien
{
    public partial class FrmChucVu : Form
    {
        public FrmChucVu()
        {
            InitializeComponent();
        }


        Ketnoi kn = new Ketnoi();
        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            LayBangChucVu();
        }
        public void LayBangChucVu()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From chucvu");
            dataGridViewChucVu.DataSource = dta;
            HIENTHI_DULIEU();
        }

        private void HIENTHI_DULIEU()
        {
            txtMaChucVu.DataBindings.Clear();
            txtMaChucVu.DataBindings.Add("Text", dataGridViewChucVu.DataSource, "macv");

            txtTenChucVu.DataBindings.Clear();
            txtTenChucVu.DataBindings.Add("Text", dataGridViewChucVu.DataSource, "tencv");

        }
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
            txtMaChucVu.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_Sua = "Update CHUCVU SET tencv = '" + txtTenChucVu.Text + "' where macv = '" + txtMaChucVu.Text + "'";
            kn.ThucThi(sql_Sua);
            LayBangChucVu();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            string strKtra = "SELECT tencv from chucvu where macv = '" + txtMaChucVu.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Ma chuc vu nay da ton tai, nhap lai ma khac", "Thong bao");
                txtMaChucVu.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                try
                {
                    string sql_luu = "Insert into chucvu Values('" + txtMaChucVu.Text + "','" + txtTenChucVu.Text + "')";
                    kn.ThucThi(sql_luu);
                    LayBangChucVu();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    string message = "Mã chức vụ lỗi ! Định dạng là 2 kí tự";
                    MessageBox.Show(message);
                }


            }

        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_xoa;
            sql_xoa = "delete chucvu where macv = '" + txtMaChucVu.Text + "'";
            kn.ThucThi(sql_xoa);
            LayBangChucVu();
        }
    }
}
