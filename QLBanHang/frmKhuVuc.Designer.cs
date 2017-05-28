namespace QLBanHang
{
    partial class frmKhuVuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhuVuc));
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.layoutControl7 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl_KhuVuc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem100 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Them = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl7)).BeginInit();
            this.layoutControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.panel6);
            this.groupControl7.Controls.Add(this.panelControl4);
            this.groupControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl7.Location = new System.Drawing.Point(0, 0);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.ShowCaption = false;
            this.groupControl7.Size = new System.Drawing.Size(801, 354);
            this.groupControl7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.layoutControl7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(2, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(797, 312);
            this.panel6.TabIndex = 3;
            // 
            // layoutControl7
            // 
            this.layoutControl7.Controls.Add(this.gridControl_KhuVuc);
            this.layoutControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl7.Location = new System.Drawing.Point(0, 0);
            this.layoutControl7.Name = "layoutControl7";
            this.layoutControl7.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(603, 320, 250, 350);
            this.layoutControl7.Root = this.layoutControlGroup7;
            this.layoutControl7.Size = new System.Drawing.Size(797, 312);
            this.layoutControl7.TabIndex = 0;
            this.layoutControl7.Text = "layoutControl7";
            // 
            // gridControl_KhuVuc
            // 
            this.gridControl_KhuVuc.Location = new System.Drawing.Point(12, 12);
            this.gridControl_KhuVuc.MainView = this.gridView1;
            this.gridControl_KhuVuc.Name = "gridControl_KhuVuc";
            this.gridControl_KhuVuc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl_KhuVuc.Size = new System.Drawing.Size(773, 288);
            this.gridControl_KhuVuc.TabIndex = 24;
            this.gridControl_KhuVuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ma,
            this.Ten,
            this.GhiChu,
            this.layoutViewColumn4});
            this.gridView1.GridControl = this.gridControl_KhuVuc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // Ma
            // 
            this.Ma.Caption = "Mã";
            this.Ma.FieldName = "Ma";
            this.Ma.Name = "Ma";
            this.Ma.Visible = true;
            this.Ma.VisibleIndex = 0;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi Chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 2;
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.Caption = "Còn Quản Lý";
            this.layoutViewColumn4.ColumnEdit = this.repositoryItemCheckEdit1;
            this.layoutViewColumn4.FieldName = "ConQuanLy";
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            this.layoutViewColumn4.Visible = true;
            this.layoutViewColumn4.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup7.GroupBordersVisible = false;
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem100});
            this.layoutControlGroup7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup7.Name = "Root";
            this.layoutControlGroup7.Size = new System.Drawing.Size(797, 312);
            this.layoutControlGroup7.TextVisible = false;
            // 
            // layoutControlItem100
            // 
            this.layoutControlItem100.Control = this.gridControl_KhuVuc;
            this.layoutControlItem100.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem100.Name = "layoutControlItem23";
            this.layoutControlItem100.Size = new System.Drawing.Size(777, 292);
            this.layoutControlItem100.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem100.TextVisible = false;
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.Controls.Add(this.simpleButton3);
            this.panelControl4.Controls.Add(this.simpleButton2);
            this.panelControl4.Controls.Add(this.simpleButton1);
            this.panelControl4.Controls.Add(this.btnDong);
            this.panelControl4.Controls.Add(this.simpleButton_CapNhat);
            this.panelControl4.Controls.Add(this.simpleButton_Them);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(797, 38);
            this.panelControl4.TabIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(385, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 34);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Đóng";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(310, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 34);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Xuất";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(235, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 34);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Nạp Lại";
            // 
            // btnDong
            // 
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(160, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 34);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Xóa";
            // 
            // simpleButton_CapNhat
            // 
            this.simpleButton_CapNhat.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_CapNhat.Image")));
            this.simpleButton_CapNhat.Location = new System.Drawing.Point(85, 2);
            this.simpleButton_CapNhat.Name = "simpleButton_CapNhat";
            this.simpleButton_CapNhat.Size = new System.Drawing.Size(75, 34);
            this.simpleButton_CapNhat.TabIndex = 2;
            this.simpleButton_CapNhat.Text = "Sửa Chữa";
            this.simpleButton_CapNhat.Click += new System.EventHandler(this.simpleButton_CapNhat_Click);
            // 
            // simpleButton_Them
            // 
            this.simpleButton_Them.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton_Them.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Them.Image")));
            this.simpleButton_Them.Location = new System.Drawing.Point(2, 2);
            this.simpleButton_Them.Name = "simpleButton_Them";
            this.simpleButton_Them.Size = new System.Drawing.Size(83, 34);
            this.simpleButton_Them.TabIndex = 0;
            this.simpleButton_Them.Text = "Thêm";
            this.simpleButton_Them.Click += new System.EventHandler(this.simpleButton_Them_Click);
            // 
            // frmKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 354);
            this.Controls.Add(this.groupControl7);
            this.Name = "frmKhuVuc";
            this.Text = "Khu Vực";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl7)).EndInit();
            this.layoutControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl7;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraLayout.LayoutControl layoutControl7;
        private DevExpress.XtraGrid.GridControl gridControl_KhuVuc;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem100;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton simpleButton_CapNhat;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Them;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Ma;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn layoutViewColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}