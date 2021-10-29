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
    public partial class frmNhaCungCap : Form
    {
        private void Load_DaTa()
        {
            clsTbnhacungcap cls = new clsTbnhacungcap();
            DataTable dt = cls.SelectAll();
            gridControl1.DataSource = dt;
        }
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clid_nhacungcap).ToString() != "")
            {
                if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue(clkhoa).ToString()) == true)
                {
                    MessageBox.Show("Đã khoá ! không thể xoá");
                    return;
                }
                else
                {
                    clsTbnhacungcap cls = new clsTbnhacungcap();
                    cls.iId_nhacungcap = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_nhacungcap).ToString());
                    cls.Delete();
                    MessageBox.Show("Đã xoá");
                    Load_DaTa();
                }

            }
            else gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            Load_DaTa();
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            clsTbnhacungcap cls = new clsTbnhacungcap();
            cls.sTennhacungcap = gridView1.GetFocusedRowCellValue(cltennhacungcap).ToString();
            cls.sNguoibaogia = gridView1.GetFocusedRowCellValue(clnguoibaogia).ToString();
            cls.sMasothue = gridView1.GetFocusedRowCellValue(clmasothue).ToString();
            cls.sDiachi = gridView1.GetFocusedRowCellValue(cldiachi).ToString();
            cls.bKhoa = Convert.ToBoolean(gridView1.GetFocusedRowCellValue(clkhoa).ToString());
            if (gridView1.GetFocusedRowCellValue(clid_nhacungcap).ToString() == "")
            {
                cls.Insert();
            }
            else
            {
                cls.iId_nhacungcap = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_nhacungcap).ToString());
                cls.Update();
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue(clkhoa, false);
        }
    }
}
