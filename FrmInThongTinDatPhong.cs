using System;
using Quan_Li_Khach_San_NET;
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
    public partial class FrmInThongTinDatPhong : Form
    {
        private String maDatPhong;
        public FrmInThongTinDatPhong(string maDatPhong)
        {
            InitializeComponent();
            this.maDatPhong = maDatPhong;
        }

        Ketnoi kn = new Ketnoi();

        private void FrmInThongTinDatPhong_Load(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_DulieuBang("SELECT * FROM thongtindat where madp ='"+ maDatPhong+"'");
            RpInThongTinDP bc_ThongTinDP = new RpInThongTinDP();
            bc_ThongTinDP.SetDataSource(dta);
            CRV.ReportSource = bc_ThongTinDP;
        }
    }
}
