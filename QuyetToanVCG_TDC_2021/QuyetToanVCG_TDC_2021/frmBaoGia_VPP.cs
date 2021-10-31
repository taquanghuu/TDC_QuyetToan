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
    public partial class frmBaoGia_VPP : Form
    {
        int mid_hopdong_; 
        public frmBaoGia_VPP(int xid_hopdong_)
        {
            mid_hopdong_ = xid_hopdong_;
           
            InitializeComponent();
        }

        private void Load_lockup()
        {
            clsTbnhacungcap cls = new clsTbnhacungcap();
            DataTable dt = cls.SelectAll();
         

            gridvanphongpham.Properties.DataSource = dt;
            gridvanphongpham.Properties.DisplayMember = "tennhacungcap";
            gridvanphongpham.Properties.ValueMember = "id_nhacungcap";
       
            clsTbvthh cls2 = new clsTbvthh();
            DataTable dt2 = cls2.SelectAll();        

            search_mahang_VPP.DataSource = dt2;
            search_mahang_VPP.DisplayMember = "tenvthh";
            search_mahang_VPP.ValueMember = "id_vthh";
           
        }

        private void Load_DaTa()
        {
         

            clsDaTa cls = new clsDaTa();
            


            DataTable dt2 = cls.tbVPP_SA_ID_HD(mid_hopdong_);
            gridControl_VPP.DataSource = dt2;
            if (dt2.Rows.Count > 0)
            {
                gridvanphongpham.EditValue = Convert.ToInt32(dt2.Rows[0]["id_nhacungcap"].ToString());
            }

          
        }
       
        private void Luu_DuLieu()
        {
            clsDaTa cls = new clsDaTa();
            cls.tbbaogia_VPP_update_all_tontai_W_id_hd(mid_hopdong_, false);

            clsTbBaoGia_VPP_XangDau cls2 = new clsTbBaoGia_VPP_XangDau();


            DataTable dt2 = (DataTable)gridControl_VPP.DataSource;
            if (dt2 != null)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    cls2.iId_hopdong = mid_hopdong_;
                    cls2.iId_nhacungcap = Convert.ToInt32(gridvanphongpham.EditValue.ToString());
                    cls2.iId_vthh = Convert.ToInt32(dt2.Rows[i]["id_vthh"].ToString());
                    cls2.fSoluong = Convert.ToDouble(dt2.Rows[i]["soluong"].ToString());
                    cls2.fDongia = Convert.ToDouble(dt2.Rows[i]["dongia"].ToString());
                    cls2.fThanhtien = Convert.ToDouble(dt2.Rows[i]["thanhtien"].ToString());
                    cls2.bTontai = true;
                    cls2.iVPP_1_XangDau_2 = 1;
                    if (dt2.Rows[i]["id_baogia"].ToString() == "")
                        cls2.Insert();
                    else
                    {
                        cls2.iId_baogia = Convert.ToInt32(dt2.Rows[i]["id_baogia"].ToString());
                        cls2.Update();
                    }
                }
                // xoá tồn tại = false
                DataTable dtmoi_false = cls.tbbaogia_VPP_SA_ID_HD_TonTai_False(mid_hopdong_);
                if (dtmoi_false.Rows.Count > 0)
                {
                    for (int i = 0; i < dtmoi_false.Rows.Count; i++)
                    {
                        cls2.iId_baogia = Convert.ToInt32(dtmoi_false.Rows[i]["id_baogia"].ToString()); ;
                        cls2.Delete();
                    }
                }
                MessageBox.Show("Đã lưu");
                Load_DaTa();
            }
        }

        private void frmBaoGia_VPP_Load(object sender, EventArgs e)
        {
            Load_lockup();
            Load_DaTa();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            Luu_DuLieu();
        }

        private void gridView_VPP_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                double soluong__ = 0;
                double dongia__ = 0;
                double thanhtien__ = 0;
                if(e.Column==clid_vthh_VPP)
                    gridView_VPP.SetFocusedRowCellValue(clsoluong_VPP, 1);
                if (e.Column == clsoluong_VPP)
                {
                    dongia__ = CheckString.ConvertToDouble_My(gridView_VPP.GetFocusedRowCellValue(cldongia_VPP));
                    soluong__ = CheckString.ConvertToDouble_My(gridView_VPP.GetFocusedRowCellValue(clsoluong_VPP));
                    thanhtien__ = soluong__ * dongia__;
                    gridView_VPP.SetFocusedRowCellValue(clthanhtien_VPP, thanhtien__);
                }
                if (e.Column == cldongia_VPP)
                {
                    dongia__ = CheckString.ConvertToDouble_My(gridView_VPP.GetFocusedRowCellValue(cldongia_VPP));
                    soluong__ = CheckString.ConvertToDouble_My(gridView_VPP.GetFocusedRowCellValue(clsoluong_VPP));
                    thanhtien__ = soluong__ * dongia__;
                    gridView_VPP.SetFocusedRowCellValue(clthanhtien_VPP, thanhtien__);
                }


            }
            catch
            {

            }
        }

        private void gridView_VPP_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT2)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            frmPrint ff = new frmPrint(mid_hopdong_);
            ff.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
