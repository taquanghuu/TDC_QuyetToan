namespace QuyetToanVCG_TDC_2021
{
    partial class frmNhanSu
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanSu));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clhoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clid_capbac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.search_CapBac = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clid_chucvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.search_ChucVu = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clid_chucdanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.search_ChucDanh = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit4View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clkhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cldinhmucsotien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clid_donvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.search_DonVi = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clxoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.clid_nhansu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_CapBac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ChucDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit4View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_DonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.search_CapBac,
            this.search_ChucVu,
            this.search_DonVi,
            this.search_ChucDanh,
            this.btXoa});
            this.gridControl1.Size = new System.Drawing.Size(879, 501);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.clhoten,
            this.clid_capbac,
            this.clid_chucvu,
            this.clid_chucdanh,
            this.clkhoa,
            this.cldinhmucsotien,
            this.clid_donvi,
            this.clxoa,
            this.clid_nhansu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // clSTT
            // 
            this.clSTT.Caption = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.OptionsColumn.AllowEdit = false;
            this.clSTT.Visible = true;
            this.clSTT.VisibleIndex = 0;
            this.clSTT.Width = 35;
            // 
            // clhoten
            // 
            this.clhoten.Caption = "Họ tên";
            this.clhoten.FieldName = "hoten";
            this.clhoten.Name = "clhoten";
            this.clhoten.Visible = true;
            this.clhoten.VisibleIndex = 1;
            this.clhoten.Width = 111;
            // 
            // clid_capbac
            // 
            this.clid_capbac.Caption = "Cấp bậc";
            this.clid_capbac.ColumnEdit = this.search_CapBac;
            this.clid_capbac.FieldName = "id_capbac";
            this.clid_capbac.Name = "clid_capbac";
            this.clid_capbac.Visible = true;
            this.clid_capbac.VisibleIndex = 2;
            this.clid_capbac.Width = 111;
            // 
            // search_CapBac
            // 
            this.search_CapBac.AutoHeight = false;
            this.search_CapBac.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.search_CapBac.Name = "search_CapBac";
            this.search_CapBac.PopupView = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // clid_chucvu
            // 
            this.clid_chucvu.Caption = "Chức vụ";
            this.clid_chucvu.ColumnEdit = this.search_ChucVu;
            this.clid_chucvu.FieldName = "id_chucvu";
            this.clid_chucvu.Name = "clid_chucvu";
            this.clid_chucvu.Visible = true;
            this.clid_chucvu.VisibleIndex = 3;
            this.clid_chucvu.Width = 111;
            // 
            // search_ChucVu
            // 
            this.search_ChucVu.AutoHeight = false;
            this.search_ChucVu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.search_ChucVu.Name = "search_ChucVu";
            this.search_ChucVu.PopupView = this.repositoryItemSearchLookUpEdit2View;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // clid_chucdanh
            // 
            this.clid_chucdanh.Caption = "Chức danh";
            this.clid_chucdanh.ColumnEdit = this.search_ChucDanh;
            this.clid_chucdanh.FieldName = "id_chucdanh";
            this.clid_chucdanh.Name = "clid_chucdanh";
            this.clid_chucdanh.Visible = true;
            this.clid_chucdanh.VisibleIndex = 5;
            this.clid_chucdanh.Width = 111;
            // 
            // search_ChucDanh
            // 
            this.search_ChucDanh.AutoHeight = false;
            this.search_ChucDanh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.search_ChucDanh.Name = "search_ChucDanh";
            this.search_ChucDanh.PopupView = this.repositoryItemSearchLookUpEdit4View;
            // 
            // repositoryItemSearchLookUpEdit4View
            // 
            this.repositoryItemSearchLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit4View.Name = "repositoryItemSearchLookUpEdit4View";
            this.repositoryItemSearchLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit4View.OptionsView.ShowGroupPanel = false;
            // 
            // clkhoa
            // 
            this.clkhoa.Caption = "khoa";
            this.clkhoa.FieldName = "khoa";
            this.clkhoa.Name = "clkhoa";
            this.clkhoa.OptionsColumn.AllowEdit = false;
            this.clkhoa.OptionsColumn.FixedWidth = true;
            this.clkhoa.Visible = true;
            this.clkhoa.VisibleIndex = 7;
            this.clkhoa.Width = 40;
            // 
            // cldinhmucsotien
            // 
            this.cldinhmucsotien.Caption = "Định mức";
            this.cldinhmucsotien.FieldName = "dinhmucsotien";
            this.cldinhmucsotien.Name = "cldinhmucsotien";
            this.cldinhmucsotien.Width = 116;
            // 
            // clid_donvi
            // 
            this.clid_donvi.Caption = "Đơn vị";
            this.clid_donvi.ColumnEdit = this.search_DonVi;
            this.clid_donvi.FieldName = "id_donvi";
            this.clid_donvi.Name = "clid_donvi";
            this.clid_donvi.Visible = true;
            this.clid_donvi.VisibleIndex = 4;
            this.clid_donvi.Width = 111;
            // 
            // search_DonVi
            // 
            this.search_DonVi.AutoHeight = false;
            this.search_DonVi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.search_DonVi.Name = "search_DonVi";
            this.search_DonVi.PopupView = this.repositoryItemSearchLookUpEdit3View;
            // 
            // repositoryItemSearchLookUpEdit3View
            // 
            this.repositoryItemSearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit3View.Name = "repositoryItemSearchLookUpEdit3View";
            this.repositoryItemSearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // clxoa
            // 
            this.clxoa.Caption = "Xoá";
            this.clxoa.ColumnEdit = this.btXoa;
            this.clxoa.Name = "clxoa";
            this.clxoa.OptionsColumn.FixedWidth = true;
            this.clxoa.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.clxoa.Visible = true;
            this.clxoa.VisibleIndex = 6;
            this.clxoa.Width = 40;
            // 
            // btXoa
            // 
            this.btXoa.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btXoa.Name = "btXoa";
            this.btXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // clid_nhansu
            // 
            this.clid_nhansu.Caption = "id_nhansu";
            this.clid_nhansu.FieldName = "id_nhansu";
            this.clid_nhansu.Name = "clid_nhansu";
            this.clid_nhansu.OptionsColumn.AllowEdit = false;
            this.clid_nhansu.OptionsColumn.FixedWidth = true;
            this.clid_nhansu.Width = 40;
            // 
            // frmNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 501);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmNhanSu";
            this.Text = "frmNhanSu";
            this.Load += new System.EventHandler(this.frmNhanSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_CapBac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ChucDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit4View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_DonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn clhoten;
        private DevExpress.XtraGrid.Columns.GridColumn clid_capbac;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit search_CapBac;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn clid_chucvu;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit search_ChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn clid_chucdanh;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit search_ChucDanh;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit4View;
        private DevExpress.XtraGrid.Columns.GridColumn clkhoa;
        private DevExpress.XtraGrid.Columns.GridColumn cldinhmucsotien;
        private DevExpress.XtraGrid.Columns.GridColumn clid_donvi;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit search_DonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit3View;
        private DevExpress.XtraGrid.Columns.GridColumn clxoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoa;
        private DevExpress.XtraGrid.Columns.GridColumn clid_nhansu;
    }
}