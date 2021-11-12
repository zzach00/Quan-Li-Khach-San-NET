using Quan_Li_Khach_San_NET.KhachHang;
using Quan_Li_Khach_San_NET.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Khach_San_NET
{
    public partial class FrmHome : Form
    {
        private int childFormNumber = 0;

        public FrmHome()
        {
            InitializeComponent();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongTinKhachHang frm1 = new FrmThongTinKhachHang();
            frm1.Show();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatPhong frm2 = new FrmDatPhong();
            frm2.Show();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDon frm3 = new FrmHoaDon();
            frm3.Show();
        }

        private void stripMenuLoaiPhong_Click(object sender, EventArgs e)
        {
            FrmLoaiPhong frm4 = new FrmLoaiPhong();
            frm4.Show();
        }

        private void tìnhTrạngPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongTinPhong frm5 = new FrmThongTinPhong();
            frm5.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongTinNhanVien frm6 = new FrmThongTinNhanVien();
            frm6.Show();
        }

        private void thôngTinChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChucVu frm7 = new FrmChucVu();
            frm7.Show();
        }

        Ketnoi kn = new Ketnoi();

        private void FrmHome_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From khachhang");
            dataGridViewTimKiemThongTin.DataSource = dta;
            
            dta = kn.Lay_DulieuBang("Select * From loaiphong");
            cboTenLoaiPhong.DataSource = dta;
            cboTenLoaiPhong.DisplayMember = "tenlp";

            dta = kn.Lay_DulieuBang("Select * From phong");
            cboTenPhong.DataSource = dta;
            cboTenPhong.DisplayMember = "maphong";

            dta = kn.Lay_DulieuBang("Select * From nhanvien");
            cboMaNhanVien.DataSource = dta;
            cboMaNhanVien.DisplayMember = "manv";
        }


        private void báoCáoDoanhThuTheoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoDoanhThu frm8 = new FrmBaoCaoDoanhThu();
            frm8.Show();
        }

        private void báoCáoDnahSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoNhanVien frm9 = new FrmBaoCaoNhanVien();
            frm9.Show();
        }

        private void báoCáoPhòngĐangSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoPhong frm9 = new FrmBaoCaoPhong();
            frm9.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            this.Hide();
        }

        private void rbtnTenKH_CheckedChanged(object sender, EventArgs e)
        {
            txtKhachHang.Enabled = true;
            txtKhachHang.Focus();
            cboTenLoaiPhong.Enabled = false;
            cboTenPhong.Enabled = false;
            cboMaNhanVien.Enabled = false;
        }

        private void rbtnTenLoaiPhong_CheckedChanged(object sender, EventArgs e)
        {
            txtKhachHang.Clear();
            txtKhachHang.Enabled = false;
            cboTenLoaiPhong.Enabled = true;
            cboTenPhong.Enabled = false;
            cboMaNhanVien.Enabled = false;
        }

        private void rbtnTenPhong_CheckedChanged(object sender, EventArgs e)
        {
            txtKhachHang.Clear();
            txtKhachHang.Enabled = false;
            cboTenLoaiPhong.Enabled = false;
            cboTenPhong.Enabled = true;
            cboMaNhanVien.Enabled = false;
        }

        private void rbtnMaNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            txtKhachHang.Clear();
            txtKhachHang.Enabled = false;
            cboTenLoaiPhong.Enabled = false;
            cboTenPhong.Enabled = false;
            cboMaNhanVien.Enabled = true;
        }

        private void btmTimKiemThongTin_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql_tim_kiem;

            if (rbtnTenKH.Checked)
            {
                sql_tim_kiem = "Select * from khachhang where hoten like '%" + txtKhachHang.Text + "%'";
                dta = kn.Lay_DulieuBang(sql_tim_kiem);
            }

            if (rbtnTenLoaiPhong.Checked)
            {
                sql_tim_kiem = "Select * from loaiphong where tenlp like '%" + cboTenLoaiPhong.Text + "%'";
                dta = kn.Lay_DulieuBang(sql_tim_kiem);
            }

            if (rbtnTenPhong.Checked)
            {
                sql_tim_kiem = "Select * from phong where maphong like '%" + cboTenPhong.Text + "%'";
                dta = kn.Lay_DulieuBang(sql_tim_kiem);
            }

            if (rbtnMaNhanVien.Checked)
            {
                sql_tim_kiem = "Select * from nhanvien where manv like '%" + cboMaNhanVien.Text + "%'";
                dta = kn.Lay_DulieuBang(sql_tim_kiem);
            }

            dataGridViewTimKiemThongTin.DataSource = dta;
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chiTiếtPhòngĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChiTietDatPhong frm10 = new FrmChiTietDatPhong();
            frm10.Show();
        }
    }
}
