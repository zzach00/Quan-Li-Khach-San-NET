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
    public partial class FrmBaoCaoNhanVien : Form
    {
        public FrmBaoCaoNhanVien()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();

        private void CRV_Load(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_DulieuBang("SELECT * FROM nhanvien");
            RpBaoCaoDSNhanVien bc_NhanVien = new RpBaoCaoDSNhanVien();
            bc_NhanVien.SetDataSource(dta);
            CRV.ReportSource = bc_NhanVien;
        }
    }
}
