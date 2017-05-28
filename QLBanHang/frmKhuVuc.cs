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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace QLBanHang
{

    

    public partial class frmKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmKhuVuc()
        {
            InitializeComponent();
            List <temp> ad = new List<temp>() {
                new temp("a", "b", "c", true),
                new temp("a1", "b1", "c1", false),
                new temp("a2", "b2", "c2", true)
            };

            gridControl_KhuVuc.DataSource = ad;
            gridView1.RowCellClick += GridView1_RowCellClick;
            gridView1.DoubleClick += GridView1_DoubleClick;
           
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private static void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
            }
        }

        private void GridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            //object cellValue = e.CellValue;
            //frmCapNhatKhuVuc frm = new frmCapNhatKhuVuc();
            //frm.ShowDialog();
            //MessageBox.Show(cellValue.ToString());
        }

        private void simpleButton_Them_Click(object sender, EventArgs e)
        {
            frmThemKhuVuc frm = new frmThemKhuVuc();
            frm.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton_CapNhat_Click(object sender, EventArgs e)
        {
            frmCapNhatKhuVuc frm = new frmCapNhatKhuVuc();
            frm.ShowDialog();
        }
    }
}

public class temp
{
    public string Ma { get; set; }
    public string Ten { get; set; }
    public string GhiChu { get; set; }
    public bool ConQuanLy { get; set; }

    public temp(string m, string t, string g, bool c)
    {
        Ma = m;
        Ten = t;
        GhiChu = g;
        ConQuanLy = c;
    }
}