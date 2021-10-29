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
    public partial class frmVatTuHangHoa : Form
    {
        public frmVatTuHangHoa()
        {
            InitializeComponent();
        }
        private void Load_DaTa()
        {
            clsTbvthh cls = new clsTbvthh();
            DataTable dt = cls.SelectAll();
            gridControl1.DataSource = dt;
        }
       
        private void frmVatTuHangHoa_Load(object sender, EventArgs e)
        {            
            Load_DaTa();
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            clsTbvthh cls = new clsTbvthh();
            cls.sTenvthh = gridView1.GetFocusedRowCellValue(cltenvthh).ToString();
            cls.sDonvitinh = gridView1.GetFocusedRowCellValue(cldonvitinh).ToString();
            cls.bKhoa =Convert.ToBoolean(gridView1.GetFocusedRowCellValue(clkhoa).ToString());
            if(gridView1.GetFocusedRowCellValue(clid_vthh).ToString()=="")
            {
                cls.Insert();
            }
            else
            {
                cls.iId_vthh = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_vthh).ToString());
                cls.Update();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clid_vthh).ToString() != "")
            {
                if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue(clkhoa).ToString()) == true)
                {
                    MessageBox.Show("Đã khoá ! không thể xoá");
                    return;
                }
                else
                {
                    clsTbvthh cls = new clsTbvthh();
                    cls.iId_vthh = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_vthh).ToString());
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

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue(clkhoa, false);
        }
    }
}
