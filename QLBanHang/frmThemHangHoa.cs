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
    public partial class frmThemHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmThemHangHoa()
        {
            InitializeComponent();
        }

        private void comboBoxEdit3_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if(e.Button.Kind == ButtonPredefines.Plus)
            {
                frmThemKho frm = new frmThemKho();
                frm.ShowDialog();
            }

            if (e.Button.Kind == ButtonPredefines.DropDown)
            {
                //code
            }
        }

        private void comboBoxEdit4_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                frmThemNhomHangHoa frm = new frmThemNhomHangHoa();
                frm.ShowDialog();
            }

            if (e.Button.Kind == ButtonPredefines.DropDown)
            {
                //code
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxEdit_DonVi_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                frmThemDonViTinh frm = new frmThemDonViTinh();
                frm.ShowDialog();
            }

            if (e.Button.Kind == ButtonPredefines.DropDown)
            {
                //code
            }
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