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
    public partial class frmThemNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}