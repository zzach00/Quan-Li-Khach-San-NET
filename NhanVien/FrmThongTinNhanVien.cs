using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = "";
            txtGioiTinh.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtHoVaTen.Text = "";
            txtMaNhanVien.Focus();
        }

        private void cboMaChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
