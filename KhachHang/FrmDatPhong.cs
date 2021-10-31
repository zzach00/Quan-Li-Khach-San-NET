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
    public partial class FrmDatPhong : Form
    {
        public FrmDatPhong()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();

        private void BANG_DATPHONG()
        {
            DataTable dataTable = new DataTable();
            dataTable = kn.Lay_DulieuBang("SELECT * FROM datphong");
            dataGridViewDatPhong.DataSource = dataTable;
        }

        private void BANG_NHANVIEN()
        {
            DataTable dataTable = new DataTable();
            dataTable = kn.Lay_DulieuBang("SELECT * FROM nhanvien");
            cboMaNhanVien.DataSource = dataTable;
            cboMaNhanVien.DisplayMember = "manv";
        }

        private void BANG_LOAIPHONG()
        {
            DataTable dataTable = new DataTable();
            dataTable = kn.Lay_DulieuBang("SELECT * FROM loaiphong");
            cboTenLoaiPhong.DataSource = dataTable;
            cboTenLoaiPhong.DisplayMember = "tenlp";
        }

        private void BANG_KHACHHANG()
        {
            DataTable dataTable = new DataTable();
            dataTable = kn.Lay_DulieuBang("SELECT * FROM khachhang");
            cboMaKhach.DataSource = dataTable;
            cboMaKhach.DisplayMember = "makh";
        }
        private void LAY_TRANGTHAI()
        {
            DataTable dataTable = new DataTable();
            dataTable = kn.Lay_DulieuBang("SELECT DISTINCT trangthai FROM datphong");
            cboTrangThai.DataSource = dataTable;
            cboTrangThai.DisplayMember = "trangthai";
        }

        private void HIENTHI_DULIEU()
        {
            txtMaDatPhong.DataBindings.Clear();
            txtMaDatPhong.DataBindings.Add("Text", dataGridViewDatPhong.DataSource, "madp");

            cboMaNhanVien.DataBindings.Clear();
            cboMaNhanVien.DataBindings.Add("Text", dataGridViewDatPhong.DataSource, "manv");

            cboMaKhach.DataBindings.Clear();
            cboMaKhach.DataBindings.Add("Text", dataGridViewDatPhong.DataSource, "makh");

            cboTenLoaiPhong.DataBindings.Clear();
            cboTenLoaiPhong.DataBindings.Add("Text", dataGridViewDatPhong.DataSource, "tenlp");

            dateNgayDat.DataBindings.Clear();
            dateNgayDat.DataBindings.Add("Value", dataGridViewDatPhong.DataSource, "ngaydi");

            dateNgayDen.DataBindings.Clear();
            dateNgayDen.DataBindings.Add("Value", dataGridViewDatPhong.DataSource, "ngayden");

            dateNgayDi.DataBindings.Clear();
            dateNgayDi.DataBindings.Add("Value", dataGridViewDatPhong.DataSource, "ngaydi");

            txtTienDatCoc.DataBindings.Clear();
            txtTienDatCoc.DataBindings.Add("Text", dataGridViewDatPhong.DataSource, "tiendatcoc");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dataGridViewDatPhong.DataSource, "soluong");

            cboTrangThai.DataBindings.Clear();
            cboTrangThai.DataBindings.Add("Text", dataGridViewDatPhong.DataSource, "trangthai");
        }

        private void FrmDatPhong_Load(object sender, EventArgs e)
        {
            BANG_DATPHONG();
            BANG_NHANVIEN();
            BANG_LOAIPHONG();
            BANG_KHACHHANG();
            LAY_TRANGTHAI();
        }

        private void dataGridViewDatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HIENTHI_DULIEU();
        }

        private void btmTimKiemPhong_Click(object sender, EventArgs e)
        {
            FrmInThongTinDatPhong frmInThongTinDatPhong = new FrmInThongTinDatPhong(txtMaDatPhong.Text);
            frmInThongTinDatPhong.Show();
        }


        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaDatPhong.Text = "";
            cboMaNhanVien.SelectedIndex = 0;
            cboMaKhach.SelectedIndex = 0;
            cboTenLoaiPhong.SelectedIndex = 0;
            dateNgayDat.Text = "";
            dateNgayDen.Text = "";
            dateNgayDi.Text = "";
            txtTienDatCoc.Text = "";
            txtSoLuong.Text = "";
            cboTrangThai.SelectedIndex = 0;
            txtMaDatPhong.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql_ktra = "Select madp from datphong where madp ='" + txtMaDatPhong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql_ktra, kn.cnn);
            SqlDataReader dataRead = cmd.ExecuteReader();
            if (dataRead.Read() == true)
            {
                MessageBox.Show("Đã tồn tại mã đặt phòng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDatPhong.Focus();
                dataRead.Close();
                dataRead.Dispose();
            }
            else
            {
                int trangthai = cboTrangThai.Text == "False" ? 0 : 1;
                    string sql_luu = "Insert into datphong values('" + txtMaDatPhong.Text + "','" + cboMaNhanVien.Text + "','" + cboMaKhach.Text + "', '" + cboTenLoaiPhong.Text + "', '" + dateNgayDat.Text + "', '" + dateNgayDen.Text + "', '"
                    + dateNgayDi.Value + "', '" + txtTienDatCoc.Text + "', '" + txtSoLuong.Text + "', '" + trangthai + "' )";
                    kn.ThucThi(sql_luu);
                    BANG_DATPHONG();
                
                 
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int trangthai = cboTrangThai.Text == "False" ? 0 : 1;
            string sql_sua = "Update datphong Set manv = '" + cboMaNhanVien.Text + "',";
            sql_sua = sql_sua + "makh = '" + cboMaKhach.Text + "',";
            sql_sua = sql_sua + "tenlp = '" + cboTenLoaiPhong.Text + "',";
            sql_sua = sql_sua + "ngaydat = '" + dateNgayDat.Text + "',";
            sql_sua = sql_sua + "ngayden = '" + dateNgayDen.Text + "',";
            sql_sua = sql_sua + "ngaydi = '" + dateNgayDi.Text + "',";
            sql_sua = sql_sua + "tiendatcoc = '" + txtTienDatCoc.Text + "',";
            sql_sua = sql_sua + "soluong = '" + txtSoLuong.Text + "',";
            sql_sua = sql_sua + "trangthai = '" + trangthai + "' where madp ='" + txtMaDatPhong.Text + "'";
            kn.ThucThi(sql_sua);
            BANG_DATPHONG();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_xoa = "Delete datphong where madp = '" + txtMaDatPhong.Text + "'";
            kn.ThucThi(sql_xoa);
            BANG_DATPHONG();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
