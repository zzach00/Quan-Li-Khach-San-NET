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
    public partial class FrmBaoCaoDoanhThu : Form
    {
        public FrmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();

        private void FrmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_DulieuBang("SELECT * FROM doanhthu");
            RpBaoCaoDoanhThu bc_DoanhThu = new RpBaoCaoDoanhThu();
            bc_DoanhThu.SetDataSource(dta);
            CRV.ReportSource = bc_DoanhThu;
        }

    }
}
