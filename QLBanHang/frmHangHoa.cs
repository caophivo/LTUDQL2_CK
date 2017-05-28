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
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region thêm hàng hóa
        private void simpleButton_Them_Click(object sender, EventArgs e)
        {
            frmThemHangHoa frm = new frmThemHangHoa();
            frm.ShowDialog();
        }
        #endregion

        #region cập nhật hàng hóa
        private void simpleButton_CapNhat_Click(object sender, EventArgs e)
        {
            frmCapNhatHangHoa frm = new frmCapNhatHangHoa();
            frm.ShowDialog();
        }
        #endregion
    }
}