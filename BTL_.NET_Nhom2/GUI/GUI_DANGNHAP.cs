using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class GUI_DANGNHAP : DevExpress.XtraEditors.XtraForm
    {
        DTO_DangNhap dn = new DTO_DangNhap();
        BLL_TaiKhoan _TK = new BLL_TaiKhoan();
        public GUI_DANGNHAP()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dn.tk = txtTK.Text;
            if (txtMK.Text == _TK.DangNhap(dn))
            {
                Main_Form main = new Main_Form(txtTK.Text,txtMK.Text);
                this.Hide();
                main.ShowDialog();
                this.Close();
            }    
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }
    }
}