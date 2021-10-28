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

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
