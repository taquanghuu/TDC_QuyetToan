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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vậtTưHàngHoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVatTuHangHoa ff = new frmVatTuHangHoa();
            ff.Show();
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanSu ff = new frmNhanSu();
            ff.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clid_hopdong).ToString() != "")
            {
                if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue(clKhoa).ToString()) == true)
                {
                    MessageBox.Show("Đã khoá ! không thể xoá");
                    return;
                }
                else
                {
                    clsTbhopdong cls = new clsTbhopdong();
                    cls.iId_hopdong = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_hopdong).ToString());
                    cls.Delete();
                    MessageBox.Show("Đã xoá");
                    Load_DaTa();
                }

            }
            else gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }
        private void Load_DaTa()
        {
            clsTbhopdong cls = new clsTbhopdong();
            DataTable dt = cls.SelectAll();
            gridControl1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_DaTa();
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            clsTbhopdong cls = new clsTbhopdong();
            cls.sTenhopdong = gridView1.GetFocusedRowCellValue(cltenhopdong).ToString();
            cls.daNgayhopdong = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(clngayhopdong).ToString());
            cls.sSohopdong = gridView1.GetFocusedRowCellValue(clsohopdong).ToString();
            cls.fSotien = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clsotien).ToString());
            cls.sGhiChu = gridView1.GetFocusedRowCellValue(clGhiChu).ToString();
            cls.bTonTai = true;
            cls.bKhoa = Convert.ToBoolean(gridView1.GetFocusedRowCellValue(clKhoa).ToString());
            if (gridView1.GetFocusedRowCellValue(clid_hopdong).ToString() == "")
            {
                cls.Insert();
            }
            else
            {
                cls.iId_hopdong = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_hopdong).ToString());
                cls.Update();
            }
        }
        int miid_hopdong = 0;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clid_hopdong).ToString() != "")
            {
                miid_hopdong= Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_hopdong).ToString());
                frmChiTietHopDong ff = new frmChiTietHopDong(miid_hopdong);
                ff.Show();
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap ff = new frmNhaCungCap();
            ff.Show();
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clid_hopdong).ToString() != "")
            {
                miid_hopdong = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_hopdong).ToString());
                frmChiTietHopDong ff = new frmChiTietHopDong(miid_hopdong);
                ff.Show();
            }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue(clKhoa, false);
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
