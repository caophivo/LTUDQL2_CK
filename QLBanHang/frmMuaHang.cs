using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLBanHang
{
    public partial class frmMuaHang : DevExpress.XtraEditors.XtraForm
    {
        public frmMuaHang()
        {
            InitializeComponent();

            uscMuaHang_PhieuNhapHang.Visible = true;
            uscMuaHang_PhieuNhapHang.Dock = DockStyle.Fill;

            uscMuaHang_TheoChungTu.Visible = false;
            uscMuaHang_TheoChungTu.Dock = DockStyle.Fill;

            uscMuaHang_TheoHangHoa.Visible = false;
            uscMuaHang_TheoHangHoa.Dock = DockStyle.Fill;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navBarItem_PhieuNhapHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            navBarGroup_ThemDanhMuc.Visible = true;
            uscMuaHang_TheoChungTu.Visible = false;
            uscMuaHang_TheoHangHoa.Visible = false;
            uscMuaHang_PhieuNhapHang.Visible = true;
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            navBarGroup_ThemDanhMuc.Visible = false;
            uscMuaHang_PhieuNhapHang.Visible = false;
            uscMuaHang_TheoHangHoa.Visible = false;
            uscMuaHang_TheoChungTu.Visible = true;
        }

        private void navBarItem_TheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            navBarGroup_ThemDanhMuc.Visible = false;
            uscMuaHang_PhieuNhapHang.Visible = false;
            uscMuaHang_TheoChungTu.Visible = false;
            uscMuaHang_TheoHangHoa.Visible = true;
        }

        private void navBarItem_ThemHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemHangHoa frm = new frmThemHangHoa();
            frm.ShowDialog();
        }

        private void navBarItem_ThemKhachHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemKhachHang frm = new frmThemKhachHang();
            frm.ShowDialog();
        }

        private void navBarItem_ThemKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemKho frm = new frmThemKho();
            frm.ShowDialog();
        }
    }
}