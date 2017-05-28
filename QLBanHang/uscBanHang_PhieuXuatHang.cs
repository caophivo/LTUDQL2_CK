using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace QLBanHang
{
    public partial class uscBanHang_PhieuXuatHang : DevExpress.XtraEditors.XtraUserControl
    {
        public uscBanHang_PhieuXuatHang()
        {
            InitializeComponent();
        }

        private void comboBoxEdit_ThemNhaCungCap_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                frmThemNhaCungCap frm = new frmThemNhaCungCap();
                frm.ShowDialog();
            }

            if (e.Button.Kind == ButtonPredefines.DropDown)
            {
                //code
            }
        }
    }
}
