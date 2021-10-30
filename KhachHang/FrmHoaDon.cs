using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string sql_Sua = "Update nhanvien SET macv = '" + cboMaChucVu.Text + "', hoten = '" + txtHoVaTen.Text + "', ngaysinh = '" + dateNgaySinh.Value + "', gioitinh = '" + txtGioiTinh.Text + "', sdt = '" + txtSDT.Text + "', cmnd = '" + txtCMND.Text + "', diachi = '" + txtDiaChi.Text + "', email = '" + txtEmail.Text + "'  where manv = '" + txtMaNhanVien.Text + "'";
            kn.ThucThi(sql_Sua);
            GET_TABLE_HOADON();
        }
    }
}
