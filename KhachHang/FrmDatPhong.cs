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
    public partial class FrmDatPhong : Form
    {
        public FrmDatPhong()
        {
            InitializeComponent();
        }

        private void btmTimKiemPhong_Click(object sender, EventArgs e)
        {
            FrmInThongTinDatPhong frmInThongTinDatPhong = new FrmInThongTinDatPhong(txtMaDatPhong.Text);
            frmInThongTinDatPhong.Show();
        }
    }
}
