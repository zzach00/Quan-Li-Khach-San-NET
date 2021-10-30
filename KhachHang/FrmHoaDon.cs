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


namespace Quan_Li_Khach_San_NET.KhachHang
{
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }


        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            FrmInHoaDon frm1 = new FrmInHoaDon();
            frm1.Show();
        }

        Ketnoi kn = new Ketnoi();

        public void ShowData ()
        {
            txtMaHoaDon.DataBindings.Clear();
            txtMaHoaDon.DataBindings.Add("Text", dataGridViewHoadon.DataSource, "mahd");
            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dataGridViewHoadon.DataSource, "tongtien");
            cboMaDatPhong.DataBindings.Clear();
            cboMaDatPhong.DataBindings.Add("Text", dataGridViewHoadon.DataSource, "madp");
            dateNgayLap.DataBindings.Add("Text", dataGridViewHoadon.DataSource, "ngaylap");
            dateNgayLap.DataBindings.Clear();

        }


        public void GET_TABLE_HOADON()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From hoadon");
            dataGridViewHoadon.DataSource = dta;
            ShowData();
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dtamcv = kn.Lay_DulieuBang("Select * from datphong order by madp");
            cboMaDatPhong.DataSource = dtamcv;
            cboMaDatPhong.DisplayMember = "madp";
            GET_TABLE_HOADON();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = "";
            txtTongTien.Text = "";
            cboMaDatPhong.Text = "";
            dateNgayLap.Text = "";
            txtMaHoaDon.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_Sua = "Update hoadon SET madp = '" + cboMaDatPhong.Text + "', ngaylap = '" + dateNgayLap.Value + "', tongtien = '" + txtTongTien.Text +  "'  where mahd = '" + txtMaHoaDon.Text + "'";
            kn.ThucThi(sql_Sua);
            GET_TABLE_HOADON();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            string strKtra = "SELECT mahd from hoadon where mahd = '" + txtMaHoaDon.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Ma hoa don nay da co o tren du lieu", "Thong bao");
                txtMaHoaDon.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                try
                {
                    string sql_luu = "Insert into hoadon  Values('" + txtMaHoaDon.Text + "','" + cboMaDatPhong.Text + "','" + dateNgayLap.Value + "','" + txtTongTien.Text +  "')";
                    kn.ThucThi(sql_luu);
                    GET_TABLE_HOADON();

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
                sql_xoa = "delete hoadon where mahd = '" + txtMaHoaDon.Text + "'";
                kn.ThucThi(sql_xoa);
                GET_TABLE_HOADON();
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
    }
}
