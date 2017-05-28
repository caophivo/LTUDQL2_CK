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
    public partial class frmBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region thêm bộ phận
        private void simpleButton_Them_Click(object sender, EventArgs e)
        {
            frmThemBoPhan frm = new frmThemBoPhan();
            frm.ShowDialog();
        }
        #endregion

        #region cập nhật bộ phận
        private void simpleButton_CapNhat_Click(object sender, EventArgs e)
        {
            frmCapNhatBoPhan frm = new frmCapNhatBoPhan();
            frm.ShowDialog();
        }
        #endregion
    }
}