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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPrint1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btPrint1,
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(604, 711);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
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
            this.clid_the_STT});
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
            this.clSTT.Visible = true;
            this.clSTT.VisibleIndex = 0;
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
            this.cldiengiai.Width = 506;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // clMau1
            // 
            this.clMau1.Caption = "Mẫu 1";
            this.clMau1.ColumnEdit = this.btPrint1;
            this.clMau1.Name = "clMau1";
            this.clMau1.OptionsColumn.FixedWidth = true;
            this.clMau1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.clMau1.Visible = true;
            this.clMau1.VisibleIndex = 2;
            this.clMau1.Width = 40;
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
            this.clid_the_STT.Caption = "id_the_STT";
            this.clid_the_STT.FieldName = "id_the_STT";
            this.clid_the_STT.Name = "clid_the_STT";
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 711);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmPrint";
            this.Text = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPrint1)).EndInit();
            this.ResumeLayout(false);

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
    }
}