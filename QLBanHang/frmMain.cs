using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLBanHang
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            Ribbon.SelectedPage = ribbonPage3;
        }

        frmMuaHang frm = new frmMuaHang();
        private void btnMuaHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(frm.IsDisposed == true)
            {
                frm = new frmMuaHang();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        frmBanHang frm1 = new frmBanHang();
        private void btnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm1.IsDisposed == true)
            {
                frm1 = new frmBanHang();
            }
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void btnKetThuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongTin frm = new frmThongTin();
            frm.ShowDialog();
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        frmPhanQuyen frm_phanquyen = new frmPhanQuyen();
        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_phanquyen.IsDisposed == true)
            {
                frm_phanquyen = new frmPhanQuyen();
            }
            frm_phanquyen.MdiParent = this;
            frm_phanquyen.Show();
        }

        frmNhatKyHeThong frm_NK = new frmNhatKyHeThong();
        private void btnNhatKyHeThong_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_NK.IsDisposed == true)
            {
                frm_NK = new frmNhatKyHeThong();
            }
            frm_NK.MdiParent = this;
            frm_NK.Show();
        }

        frmChuyenKho frm_CK = new frmChuyenKho();
        private void btnChuyenKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_CK.IsDisposed == true)
            {
                frm_CK = new frmChuyenKho();
            }
            frm_CK.MdiParent = this;
            frm_CK.Show();
        }

        frmTonKho frm_TK = new frmTonKho();
        private void btnTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_TK.IsDisposed == true)
            {
                frm_TK = new frmTonKho();
            }
            frm_TK.MdiParent = this;
            frm_TK.Show();
        }

        frmThuTien frm_ThuTien = new frmThuTien();
        private void btnThuTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_ThuTien.IsDisposed == true)
            {
                frm_ThuTien = new frmThuTien();
            }
            frm_ThuTien.MdiParent = this;
            frm_ThuTien.Show();
        }

        frmTraTien frm_TraTien = new frmTraTien();
        private void btnTraTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_TraTien.IsDisposed == true)
            {
                frm_TraTien = new frmTraTien();
            }
            frm_TraTien.MdiParent = this;
            frm_TraTien.Show();
        }
    }
}