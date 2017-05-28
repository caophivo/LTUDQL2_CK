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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton_Them_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap frm = new frmThemNhaCungCap();
            frm.ShowDialog();
        }

        private void simpleButton_CapNhat_Click(object sender, EventArgs e)
        {
            frmCapNhapNhaCungCap frm = new frmCapNhapNhaCungCap();
            frm.ShowDialog();
        }
    }
}