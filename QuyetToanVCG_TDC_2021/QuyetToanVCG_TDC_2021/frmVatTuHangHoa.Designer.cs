namespace QuyetToanVCG_TDC_2021
{
    partial class frmVatTuHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatTuHangHoa));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clid_vthh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cltenvthh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cldonvitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clkhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.btXoa});
            this.gridControl1.Size = new System.Drawing.Size(883, 452);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.clid_vthh,
            this.cltenvthh,
            this.cldonvitinh,
            this.clkhoa,
            this.clXoa});
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
            this.clSTT.OptionsColumn.FixedWidth = true;
            this.clSTT.Visible = true;
            this.clSTT.VisibleIndex = 0;
            this.clSTT.Width = 40;
            // 
            // clid_vthh
            // 
            this.clid_vthh.Caption = "id_vthh";
            this.clid_vthh.FieldName = "id_vthh";
            this.clid_vthh.Name = "clid_vthh";
            this.clid_vthh.Width = 249;
            // 
            // cltenvthh
            // 
            this.cltenvthh.Caption = "Tên VTHH";
            this.cltenvthh.FieldName = "tenvthh";
            this.cltenvthh.Name = "cltenvthh";
            this.cltenvthh.Visible = true;
            this.cltenvthh.VisibleIndex = 1;
            this.cltenvthh.Width = 352;
            // 
            // cldonvitinh
            // 
            this.cldonvitinh.Caption = "ĐVT";
            this.cldonvitinh.FieldName = "donvitinh";
            this.cldonvitinh.Name = "cldonvitinh";
            this.cldonvitinh.Visible = true;
            this.cldonvitinh.VisibleIndex = 2;
            this.cldonvitinh.Width = 358;
            // 
            // clkhoa
            // 
            this.clkhoa.Caption = "khoa";
            this.clkhoa.FieldName = "khoa";
            this.clkhoa.Name = "clkhoa";
            this.clkhoa.OptionsColumn.AllowEdit = false;
            this.clkhoa.OptionsColumn.FixedWidth = true;
            this.clkhoa.Visible = true;
            this.clkhoa.VisibleIndex = 3;
            this.clkhoa.Width = 40;
            // 
            // clXoa
            // 
            this.clXoa.Caption = "Xoá";
            this.clXoa.ColumnEdit = this.btXoa;
            this.clXoa.Name = "clXoa";
            this.clXoa.OptionsColumn.FixedWidth = true;
            this.clXoa.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.clXoa.Visible = true;
            this.clXoa.VisibleIndex = 4;
            this.clXoa.Width = 40;
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
            // frmVatTuHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 452);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmVatTuHangHoa";
            this.Text = "frmVatTuHangHoa";
            this.Load += new System.EventHandler(this.frmVatTuHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn clid_vthh;
        private DevExpress.XtraGrid.Columns.GridColumn cltenvthh;
        private DevExpress.XtraGrid.Columns.GridColumn cldonvitinh;
        private DevExpress.XtraGrid.Columns.GridColumn clkhoa;
        private DevExpress.XtraGrid.Columns.GridColumn clXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoa;
    }
}