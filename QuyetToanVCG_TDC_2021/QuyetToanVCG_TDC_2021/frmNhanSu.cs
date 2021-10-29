using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuyetToanVCG_TDC_2021
{
    public partial class frmNhanSu : Form
    {
        public frmNhanSu()
        {
            InitializeComponent();
        }
        private void Load_DaTa()
        {
            clsTbnhansu cls = new clsTbnhansu();
            DataTable dt = cls.SelectAll();
            gridControl1.DataSource = dt;
        }
        private void Load_Lockup()
        {
            clsTbdonvi cls1 = new clsTbdonvi();
            DataTable dt1 = cls1.SelectAll();
            search_DonVi.DataSource = dt1;
            search_DonVi.ValueMember = "id_donvi";
            search_DonVi.DisplayMember = "tendonvi_daydu";

            clsTbcapbac cls2 = new clsTbcapbac();
            DataTable dt2 = cls2.SelectAll();
            search_CapBac.DataSource = dt2;
            search_CapBac.ValueMember = "id_capbac";
            search_CapBac.DisplayMember = "capbac_daydu";

            clsTbchucvu cls3 = new clsTbchucvu();
            DataTable dt3 = cls3.SelectAll();
            search_ChucVu.DataSource = dt3;
            search_ChucVu.ValueMember = "id_chucvu";
            search_ChucVu.DisplayMember = "tenchucvu";

            clsTbchucdanh cls4 = new clsTbchucdanh();
            DataTable dt4 = cls4.SelectAll();
            search_ChucDanh.DataSource = dt4;
            search_ChucDanh.ValueMember = "id_chucdanh";
            search_ChucDanh.DisplayMember = "tenchucdanh";
        }
        private void frmNhanSu_Load(object sender, EventArgs e)
        {
            Load_Lockup();
            Load_DaTa();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clid_nhansu).ToString() != "")
            {
                if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue(clkhoa).ToString()) == true)
                {
                    MessageBox.Show("Đã khoá ! không thể xoá");
                    return;
                }
                else
                {
                    clsTbnhansu cls = new clsTbnhansu();
                    cls.iId_nhansu = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_nhansu).ToString());
                    cls.Delete();
                    MessageBox.Show("Đã xoá");
                    Load_DaTa();
                }

            }
            else gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            clsTbnhansu cls = new clsTbnhansu();
            cls.sHoten = gridView1.GetFocusedRowCellValue(clhoten).ToString();
            cls.iId_capbac =Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_capbac).ToString());
            cls.iId_chucdanh = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_chucdanh).ToString());
            cls.iId_chucvu = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_chucvu).ToString());
            cls.iId_donvi = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_donvi).ToString());   
            cls.bKhoa = Convert.ToBoolean(gridView1.GetFocusedRowCellValue(clkhoa).ToString());
            if (gridView1.GetFocusedRowCellValue(clid_nhansu).ToString() == "")
            {
                cls.Insert();
            }
            else
            {
                cls.iId_nhansu = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_nhansu).ToString());
                cls.Update();
            }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue(clkhoa, false);
        }
    }
}
