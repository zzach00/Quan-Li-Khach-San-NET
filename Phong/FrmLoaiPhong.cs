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

namespace Quan_Li_Khach_San_NET
{
    public partial class FrmLoaiPhong : Form
    {
        public FrmLoaiPhong()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();

        public void GET_TABLE_LOAIPHONG()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From loaiphong");
            dataGridViewLoaiPhong.DataSource = dta;
            GET_DATA();
        }

        public void GET_DATA()
        {
            txtTenLoaiPhong.DataBindings.Clear();
            txtTenLoaiPhong.DataBindings.Add("Text", dataGridViewLoaiPhong.DataSource, "tenlp");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dataGridViewLoaiPhong.DataSource, "soluong");

            txtGiaPhong.DataBindings.Clear();
            txtGiaPhong.DataBindings.Add("Text", dataGridViewLoaiPhong.DataSource, "giaphong");
        }

        private void thôngTinPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stripMenuLoaiPhong_Click(object sender, EventArgs e)
        {

        }

        private void FrmLoaiPhong_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtTenLoaiPhong.Text = "";
            txtGiaPhong.Text = "";
            txtSoLuong.Text = "";
            txtTenLoaiPhong.Focus();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string sql_Sua = "Update loaiphong SET soluong = '" + txtSoLuong.Text + "' , giaphong = '" + txtGiaPhong.Text + "' where tenlp = '" + txtTenLoaiPhong.Text + "'";
            kn.ThucThi(sql_Sua);
            GET_TABLE_LOAIPHONG();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            string strKtra = "SELECT tenlp from loaiphong where tenlp = '" + txtTenLoaiPhong.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Ma loai phong nay da ton tai, nhap lai ma khac", "Thong bao");
                txtTenLoaiPhong.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                try
                {
                    string sql_luu = "Insert into loaiphong Values('" + txtTenLoaiPhong.Text + "','" + txtSoLuong.Text + "', '" + txtGiaPhong.Text + "')";
                    kn.ThucThi(sql_luu);
                    GET_TABLE_LOAIPHONG();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    string message = "Mã loại phòng lỗi !";
                    MessageBox.Show(message);
                }


            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string sql_xoa;
            sql_xoa = "delete loaiphong where tenlp = '" + txtTenLoaiPhong.Text + "'";
            kn.ThucThi(sql_xoa);
            GET_TABLE_LOAIPHONG();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
