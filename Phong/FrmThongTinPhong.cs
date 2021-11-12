

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
    public partial class FrmThongTinPhong : Form
    {
        public FrmThongTinPhong()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();

        public void GET_TABLE_THONGTINPHONG()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From phong");
            dataGridViewPhong.DataSource = dta;
            GET_DATA();
        }

        public void GET_DATA()
        {
            txtMaPhong.DataBindings.Clear();
            txtMaPhong.DataBindings.Add("Text", dataGridViewPhong.DataSource, "maphong");

            cboTenLoaiPhong.DataBindings.Clear();
            cboTenLoaiPhong.DataBindings.Add("Text", dataGridViewPhong.DataSource, "tenlp");

            cboTinhTrang.DataBindings.Clear();
            cboTinhTrang.DataBindings.Add("Text", dataGridViewPhong.DataSource, "tinhtrang");
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = "";
            cboTenLoaiPhong.Text = "";
            cboTinhTrang.Text = "";
            txtMaPhong.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_Sua = "Update phong SET tenlp = '" + cboTenLoaiPhong.Text + "' , tinhtrang = '" + cboTinhTrang.Text + "' where maphong = '" + txtMaPhong.Text + "'";
            kn.ThucThi(sql_Sua);
            GET_TABLE_THONGTINPHONG();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            string strKtra = "SELECT maphong from phong where maphong = '" + txtMaPhong.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Ma  phong nay da ton tai, nhap lai ma khac", "Thong bao");
                txtMaPhong.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                try
                {
                    string sql_luu = "Insert into phong Values('" + txtMaPhong.Text + "','" + cboTenLoaiPhong.Text + "', '" + cboTinhTrang.Text + "')";
                    kn.ThucThi(sql_luu);
                    GET_TABLE_THONGTINPHONG();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    string message = "Mã phòng lỗi !";
                    MessageBox.Show(message);
                }


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_xoa;
            sql_xoa = "delete phong where maphong = '" + txtMaPhong.Text + "'";
            kn.ThucThi(sql_xoa);
            GET_TABLE_THONGTINPHONG();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmThongTinPhong_Load(object sender, EventArgs e)
        {
            DataTable dtamcv = kn.Lay_DulieuBang("Select * from loaiphong order by tenlp");
            cboTenLoaiPhong.DataSource = dtamcv;
            cboTenLoaiPhong.DisplayMember = "tenlp";
            GET_TABLE_THONGTINPHONG();

        }

        private void btmTimKiemLoaiPhong_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql_tim_kiem;
            sql_tim_kiem = "Select * from phong where tenlp like '%" + cboTenLoaiPhong.Text + "%'";
            dta = kn.Lay_DulieuBang(sql_tim_kiem);
            dataGridViewPhong.DataSource = dta;
        }
    }
}
