using Quan_Li_Khach_San_NET.KhachHang;
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
    public partial class FrmInHoaDon : Form
    {
        public FrmInHoaDon()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();

        private void FrmInHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            //dta = kn.Lay_DulieuBang("Select * from NHANVIEN where ma_CV like 'CV3'"); 
            //BaoCaoNhanVien baoCaoNV = new BaoCaoNhanVien(); 
            // khCri tao bao cao 
            dta = kn.Lay_DulieuBang("Select * from hoadon ");
            RpHoaDon InHoaDon = new RpHoaDon();  // khoi tao bao cao 
            InHoaDon.SetDataSource(dta);
            CRVHoaDon.ReportSource = InHoaDon;
        }
    }
}
