using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Quan_Li_Khach_San_NET
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();
        
        private void btmTimKiemThongTin_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();

            string Acc = txtTenDangNhap.Text;
            string Pw = txtMatKhau.Text;
            string sql_Login = "Select * from quyennv where manv = '" + Acc + "' and matkhau = '" + Pw + "'";

            SqlCommand cmd = new SqlCommand(sql_Login, kn.cnn);
            SqlDataReader dataRead = cmd.ExecuteReader();

            if (dataRead.Read() == true)
            {
                MessageBox.Show("Ban da dang nhap thanh cong");
                Form frmain = new FrmHome();
                frmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dang nhap lai");
                txtTenDangNhap.Focus();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
