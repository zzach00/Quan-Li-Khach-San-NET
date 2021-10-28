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
    public partial class FrmThongTinNhanVien : Form
    {
        
        public FrmThongTinNhanVien()
        {
            InitializeComponent();
            
        }

        public void LayBangNhanVien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From nhanvien");
            dataGridViewNhanVien.DataSource = dta;
            HIENTHI_DULIEU();
        }

        private void HIENTHI_DULIEU()
        {
            txtMaNhanVien.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "manv");
            cboMaChucVu.DataBindings.Clear();
            cboMaChucVu.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "macv");
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "hoten");
            dateNgaySinh.DataBindings.Clear();
            dateNgaySinh.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "ngaysinh");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "gioitinh");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "sdt");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "cmnd");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "diachi");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "email");


        }

        Ketnoi kn = new Ketnoi();
        private void FrmThongTinNhanVien_Load (object sender , EventArgs e)
        {
            DataTable dtamcv = kn.Lay_DulieuBang("Select * from chucvu order by macv");
            cboMaChucVu.DataSource = dtamcv;
            cboMaChucVu.DisplayMember = "macv";
            LayBangNhanVien();

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = "";
            txtGioiTinh.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtHoVaTen.Text = "";
            txtDiaChi.Text = "";
            txtMaNhanVien.Focus();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try {
                string sql_xoa;
                sql_xoa = "delete nhanvien where manv = '" + txtMaNhanVien.Text + "'";
                kn.ThucThi(sql_xoa);
                LayBangNhanVien();
            } catch (System.Data.SqlClient.SqlException)
            {
                string message = "Nhân viên đang hoạt động ! ";
                MessageBox.Show(message);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
                kn.KetNoi_Dulieu();
                string strKtra = "SELECT hoten from nhanvien where manv = '" + txtMaNhanVien.Text + "'";
                SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
                SqlDataReader doc_dl = cmd.ExecuteReader();
                if (doc_dl.Read() == true)
                {
                    MessageBox.Show("Nguoi nay da co o tren du lieu", "Thong bao");
                    txtMaNhanVien.Focus();
                    doc_dl.Close();
                    doc_dl.Dispose();
                }
                else
                {
                    try
                    {
                        string sql_luu = "Insert into nhanvien Values('"+ txtMaNhanVien.Text + "','" + cboMaChucVu.Text + "','" + txtHoVaTen.Text + "','" + dateNgaySinh.Value + "','" +txtGioiTinh.Text+ "','" + txtSDT.Text+ "','" +txtCMND.Text+ "','" + txtDiaChi.Text + "','" + txtEmail.Text+"')";
                        kn.ThucThi(sql_luu);
                        LayBangNhanVien();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        string message = "Lỗi!";
                        MessageBox.Show(message);
                    }


                }

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_Sua = "Update nhanvien SET macv = '" + cboMaChucVu.Text + "', hoten = '" + txtHoVaTen.Text + "', ngaysinh = '" + dateNgaySinh.Value + "', gioitinh = '" + txtGioiTinh.Text + "', sdt = '" + txtSDT.Text + "', cmnd = '" + txtCMND.Text + "', diachi = '" + txtDiaChi.Text + "', email = '" + txtEmail.Text + "'  where manv = '" + txtMaNhanVien.Text + "'";
            kn.ThucThi(sql_Sua);
            LayBangNhanVien();

        }
    }
}
