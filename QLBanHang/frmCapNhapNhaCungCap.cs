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
    public partial class frmCapNhapNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhapNhaCungCap()
        {
            InitializeComponent();
        }

        private void buttonEdit_ThemKhuVuc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                frmThemKhuVuc frm = new frmThemKhuVuc();
                frm.ShowDialog();
            }

            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)
            {
                //code
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}