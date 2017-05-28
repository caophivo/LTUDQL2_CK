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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region thêm nhân viên
        private void simpleButton_Them_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frm = new frmThemNhanVien();
            frm.ShowDialog();
        }
        #endregion

        #region cập nhật nhân viên
        private void simpleButton_CapNhat_Click(object sender, EventArgs e)
        {
            frmCapNhatNhanVien frm = new frmCapNhatNhanVien();
            frm.ShowDialog();
        }
        #endregion
    }
}