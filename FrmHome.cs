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
            LayBangNhanVien();
        }

        public void LayBangNhanVien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From nhanvien");
            dataGridViewTimKiemThongTin.DataSource = dta;
        }

        private void btmTimKiemThongTin_Click(object sender, EventArgs e)
        {

        }
    }
}
