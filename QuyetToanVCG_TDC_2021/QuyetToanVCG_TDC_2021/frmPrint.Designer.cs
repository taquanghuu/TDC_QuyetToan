namespace QuyetToanVCG_TDC_2021
{
    partial class frmPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrint));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cldiengiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.clMau1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btPrint1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.clMau3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clMau2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clid_ngaythang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clCheck_In_An = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clid_the_STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clngaythang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnoidung2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.clngaythang2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clsoluong2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cldonvitinh2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.clid_xd2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPrint1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btPrint1,
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(642, 711);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.cldiengiai,
            this.clMau1,
            this.clMau3,
            this.clMau2,
            this.clid_ngaythang,
            this.clCheck_In_An,
            this.clid_the_STT,
            this.clngaythang});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            // 
            // clSTT
            // 
            this.clSTT.Caption = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.OptionsColumn.AllowEdit = false;
            this.clSTT.Width = 40;
            // 
            // cldiengiai
            // 
            this.cldiengiai.Caption = "Diễn giải";
            this.cldiengiai.ColumnEdit = this.repositoryItemMemoEdit1;
            this.cldiengiai.FieldName = "diengiai";
            this.cldiengiai.Name = "cldiengiai";
            this.cldiengiai.OptionsColumn.AllowEdit = false;
            this.cldiengiai.Visible = true;
            this.cldiengiai.VisibleIndex = 1;
            this.cldiengiai.Width = 470;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // clMau1
            // 
            this.clMau1.Caption = "Print";
            this.clMau1.ColumnEdit = this.btPrint1;
            this.clMau1.Name = "clMau1";
            this.clMau1.OptionsColumn.FixedWidth = true;
            this.clMau1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.clMau1.Visible = true;
            this.clMau1.VisibleIndex = 3;
            this.clMau1.Width = 50;
            // 
            // btPrint1
            // 
            this.btPrint1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btPrint1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btPrint1.Name = "btPrint1";
            this.btPrint1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btPrint1.Click += new System.EventHandler(this.btPrint1_Click);
            // 
            // clMau3
            // 
            this.clMau3.Caption = "Mẫu 3";
            this.clMau3.Name = "clMau3";
            // 
            // clMau2
            // 
            this.clMau2.Caption = "Mẫu 2";
            this.clMau2.Name = "clMau2";
            // 
            // clid_ngaythang
            // 
            this.clid_ngaythang.Caption = "id_ngaythang";
            this.clid_ngaythang.FieldName = "id_ngaythang";
            this.clid_ngaythang.Name = "clid_ngaythang";
            // 
            // clCheck_In_An
            // 
            this.clCheck_In_An.Caption = "IN";
            this.clCheck_In_An.FieldName = "Check_In_An";
            this.clCheck_In_An.Name = "clCheck_In_An";
            // 
            // clid_the_STT
            // 
            this.clid_the_STT.AppearanceCell.Options.UseTextOptions = true;
            this.clid_the_STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clid_the_STT.Caption = "STT";
            this.clid_the_STT.FieldName = "id_the_STT";
            this.clid_the_STT.Name = "clid_the_STT";
            this.clid_the_STT.OptionsColumn.AllowEdit = false;
            this.clid_the_STT.Visible = true;
            this.clid_the_STT.VisibleIndex = 0;
            this.clid_the_STT.Width = 44;
            // 
            // clngaythang
            // 
            this.clngaythang.Caption = "Ngày tháng";
            this.clngaythang.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.clngaythang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clngaythang.FieldName = "ngaythang";
            this.clngaythang.Name = "clngaythang";
            this.clngaythang.OptionsColumn.AllowEdit = false;
            this.clngaythang.Visible = true;
            this.clngaythang.VisibleIndex = 2;
            this.clngaythang.Width = 90;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(661, 36);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemMemoEdit2});
            this.gridControl2.Size = new System.Drawing.Size(546, 663);
            this.gridControl2.TabIndex = 3;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.Row.Options.UseTextOptions = true;
            this.gridView2.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT2,
            this.clnoidung2,
            this.clngaythang2,
            this.clsoluong2,
            this.cldonvitinh2,
            this.clid_xd2});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView2_CustomDrawCell);
            this.gridView2.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView2_ValidateRow);
            // 
            // clSTT2
            // 
            this.clSTT2.Caption = "STT";
            this.clSTT2.Name = "clSTT2";
            this.clSTT2.OptionsColumn.AllowEdit = false;
            this.clSTT2.Visible = true;
            this.clSTT2.VisibleIndex = 0;
            this.clSTT2.Width = 38;
            // 
            // clnoidung2
            // 
            this.clnoidung2.Caption = "Nội dung";
            this.clnoidung2.ColumnEdit = this.repositoryItemMemoEdit2;
            this.clnoidung2.FieldName = "noidung";
            this.clnoidung2.Name = "clnoidung2";
            this.clnoidung2.OptionsColumn.AllowEdit = false;
            this.clnoidung2.Visible = true;
            this.clnoidung2.VisibleIndex = 2;
            this.clnoidung2.Width = 300;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // clngaythang2
            // 
            this.clngaythang2.Caption = "Ngày tháng";
            this.clngaythang2.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.clngaythang2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clngaythang2.FieldName = "ngaythang";
            this.clngaythang2.Name = "clngaythang2";
            this.clngaythang2.OptionsColumn.AllowEdit = false;
            this.clngaythang2.Visible = true;
            this.clngaythang2.VisibleIndex = 1;
            this.clngaythang2.Width = 89;
            // 
            // clsoluong2
            // 
            this.clsoluong2.Caption = "SL";
            this.clsoluong2.FieldName = "soluong";
            this.clsoluong2.Name = "clsoluong2";
            this.clsoluong2.Visible = true;
            this.clsoluong2.VisibleIndex = 4;
            this.clsoluong2.Width = 50;
            // 
            // cldonvitinh2
            // 
            this.cldonvitinh2.Caption = "ĐVT";
            this.cldonvitinh2.FieldName = "donvitinh";
            this.cldonvitinh2.Name = "cldonvitinh2";
            this.cldonvitinh2.Visible = true;
            this.cldonvitinh2.VisibleIndex = 3;
            this.cldonvitinh2.Width = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(816, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phụ lục kế hoạch xăng dầu";
            // 
            // clid_xd2
            // 
            this.clid_xd2.Caption = "id_xd";
            this.clid_xd2.FieldName = "id_xd";
            this.clid_xd2.Name = "clid_xd2";
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmPrint";
            this.Text = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPrint1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn cldiengiai;
        private DevExpress.XtraGrid.Columns.GridColumn clMau1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btPrint1;
        private DevExpress.XtraGrid.Columns.GridColumn clMau3;
        private DevExpress.XtraGrid.Columns.GridColumn clMau2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn clid_ngaythang;
        private DevExpress.XtraGrid.Columns.GridColumn clCheck_In_An;
        private DevExpress.XtraGrid.Columns.GridColumn clid_the_STT;
        private DevExpress.XtraGrid.Columns.GridColumn clngaythang;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT2;
        private DevExpress.XtraGrid.Columns.GridColumn clnoidung2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn clngaythang2;
        private DevExpress.XtraGrid.Columns.GridColumn clsoluong2;
        private DevExpress.XtraGrid.Columns.GridColumn cldonvitinh2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn clid_xd2;
    }
}