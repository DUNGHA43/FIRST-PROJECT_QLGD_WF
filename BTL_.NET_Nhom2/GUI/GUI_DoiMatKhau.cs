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
    public partial class GUI_DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        string tk, mk;
        DTO_DangNhap dn = new DTO_DangNhap();
        BLL_TaiKhoan _TK = new BLL_TaiKhoan();
        public GUI_DoiMatKhau(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
        }

        private void GUI_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTK.Text = tk;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            try
            {
                dn.tk = tk;
                dn.mk = txtMKMoi.Text;
                if (txtMKCu.Text == mk)
                {
                    _TK.DoiMatKhau(dn);
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    mk = txtMKMoi.Text;
                    txtMKCu.Text = null;
                    txtMKMoi.Text = null;
                }
                else if (txtMKCu.Text != mk)
                {
                    MessageBox.Show("Mật khẩu cũ sai!");
                    txtMKCu.Text = null;
                    txtMKMoi.Text = null;
                }    
            }
            catch
            {
                MessageBox.Show("Đổi mật khẩu không thành công!");
            }
            
        }
    }
}