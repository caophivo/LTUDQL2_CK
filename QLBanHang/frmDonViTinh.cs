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
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton_Them_Click(object sender, EventArgs e)
        {
            frmThemDonViTinh frm = new frmThemDonViTinh();
            frm.ShowDialog();
        }

        private void simpleButton_CapNhat_Click(object sender, EventArgs e)
        {
            frmCapNhatDonViTinh frm = new frmCapNhatDonViTinh();
            frm.ShowDialog();
        }
    }
}