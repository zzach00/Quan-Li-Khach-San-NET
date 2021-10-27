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
    public partial class FrmBaoCaoPhong : Form
    {
        public FrmBaoCaoPhong()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();

        private void FrmBaoCaoPhong_Load(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_DulieuBang("SELECT * FROM phong");
            RpBaoCaoDanhSachPhong bc_Phong = new RpBaoCaoDanhSachPhong();
            bc_Phong.SetDataSource(dta);
            CRV.ReportSource = bc_Phong;

            dta = kn.Lay_DulieuBang("SELECT DISTINCT tinhtrang FROM phong ");
            cboTinhTrang.DataSource = dta;
            cboTinhTrang.DisplayMember = "tinhtrang";
        }

        private void cboTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tinhtrang = cboTinhTrang.Text == "False" ? 0 : 1;
            string sql = "Select * from phong where tinhtrang = " + tinhtrang;
            DataTable dta = kn.Lay_DulieuBang(sql);
            RpBaoCaoDanhSachPhong bc_Phong = new RpBaoCaoDanhSachPhong();
            bc_Phong.SetDataSource(dta);
            CRV.ReportSource = bc_Phong;
        }
    }
}
