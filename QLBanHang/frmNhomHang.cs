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
    public partial class frmNhomHang : DevExpress.XtraEditors.XtraForm
    {
        public frmNhomHang()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton_Them_Click(object sender, EventArgs e)
        {
            frmThemNhomHangHoa frm = new frmThemNhomHangHoa();
            frm.ShowDialog();
        }

        private void simpleButton_CapNhat_Click(object sender, EventArgs e)
        {
            frmCapNhapNhomHangHoa frm = new frmCapNhapNhomHangHoa();
            frm.ShowDialog();
        }
    }
}