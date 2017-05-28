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
    public partial class frmTyGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTyGia()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region thêm tiền tệ
        private void simpleButton_Them_Click(object sender, EventArgs e)
        {
            frmThemTienTe frm = new frmThemTienTe();
            frm.ShowDialog();
        }
        #endregion

        #region cập nhật tiền tệ
        private void simpleButton_CapNhat_Click(object sender, EventArgs e)
        {
            frmCapNhatTienTe frm = new frmCapNhatTienTe();
            frm.ShowDialog();
        }
        #endregion
    }
}