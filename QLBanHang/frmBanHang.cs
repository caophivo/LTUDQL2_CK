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
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        public frmBanHang()
        {
            InitializeComponent();

            uscBanHang_PhieuXuatHang.Visible = true;
            uscBanHang_PhieuXuatHang.Dock = DockStyle.Fill;

            uscBanHang_TheoChungTu.Visible = false;
            uscBanHang_TheoChungTu.Dock = DockStyle.Fill;

            uscBanHang_TheoHangHoa.Visible = false;
            uscBanHang_TheoHangHoa.Dock = DockStyle.Fill;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navBarItem_PhieuNhapHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            navBarGroup_ThemDanhMuc.Visible = true;
            uscBanHang_TheoChungTu.Visible = false;
            uscBanHang_TheoHangHoa.Visible = false;
            uscBanHang_PhieuXuatHang.Visible = true;
        }

        private void navBarItem_TheoChungTu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            navBarGroup_ThemDanhMuc.Visible = false;
            uscBanHang_PhieuXuatHang.Visible = false;
            uscBanHang_TheoHangHoa.Visible = false;
            uscBanHang_TheoChungTu.Visible = true;
        }

        private void navBarItem_TheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            navBarGroup_ThemDanhMuc.Visible = false;
            uscBanHang_PhieuXuatHang.Visible = false;
            uscBanHang_TheoChungTu.Visible = false;
            uscBanHang_TheoHangHoa.Visible = true;
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