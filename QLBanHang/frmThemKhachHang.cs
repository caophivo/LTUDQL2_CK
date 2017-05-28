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
using DevExpress.XtraEditors.Controls;

namespace QLBanHang
{
    public partial class frmThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_ThemKhuVuc_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                frmThemKhuVuc frm = new frmThemKhuVuc();
                frm.ShowDialog();
            }

            if (e.Button.Kind == ButtonPredefines.DropDown)
            {
                //code
            }
        }
    }
}