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
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void btnThemVaiTro_Click(object sender, EventArgs e)
        {
            frmThemVaiTro frm = new frmThemVaiTro();
            frm.ShowDialog();
        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            frmThemNguoiDung frm = new frmThemNguoiDung();
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSua_PhanQuyen frm = new frmSua_PhanQuyen();
            frm.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}