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
    public partial class frmBaoGia_XangDau : Form
    {
        int mid_hopdong_;
        public frmBaoGia_XangDau(int xid_hopdong_)
        {
            mid_hopdong_ = xid_hopdong_;
            InitializeComponent();
        }
     
        private void Luu_DuLieu()
        {
            clsDaTa cls = new clsDaTa();
            cls.tbbaogia_XangDau_update_all_tontai_W_id_hd(mid_hopdong_, false);

            clsTbBaoGia_VPP_XangDau cls2 = new clsTbBaoGia_VPP_XangDau();


            DataTable dt2 = (DataTable)gridControl_XangDau.DataSource;
            if (dt2 != null)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    cls2.iId_hopdong = mid_hopdong_;
                    cls2.iId_nhacungcap = Convert.ToInt32(gridxangdau.EditValue.ToString());
                    cls2.iId_vthh = Convert.ToInt32(dt2.Rows[i]["id_vthh"].ToString());
                    cls2.fSoluong = Convert.ToDouble(dt2.Rows[i]["soluong"].ToString());
                    cls2.fDongia = Convert.ToDouble(dt2.Rows[i]["dongia"].ToString());
                    cls2.fThanhtien = Convert.ToDouble(dt2.Rows[i]["thanhtien"].ToString());
                    cls2.bTontai = true;
                    cls2.iVPP_1_XangDau_2 = 2;
                    if (dt2.Rows[i]["id_baogia"].ToString() == "")
                        cls2.Insert();
                    else
                    {
                        cls2.iId_baogia = Convert.ToInt32(dt2.Rows[i]["id_baogia"].ToString());
                        cls2.Update();
                    }
                }
                // xoá tồn tại = false
                DataTable dtmoi_false = cls.tbbaogia_XangDau_SA_ID_HD_TonTai_False(mid_hopdong_);
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

        private void Load_lockup()
        {
            clsTbnhacungcap cls = new clsTbnhacungcap();
            DataTable dt = cls.SelectAll();
          

            gridxangdau.Properties.DataSource = dt;
            gridxangdau.Properties.DisplayMember = "tennhacungcap";
            gridxangdau.Properties.ValueMember = "id_nhacungcap";

            clsTbvthh cls2 = new clsTbvthh();
            DataTable dt2 = cls2.SelectAll();
           

            search_mahang_XangDau.DataSource = dt2;
            search_mahang_XangDau.DisplayMember = "tenvthh";
            search_mahang_XangDau.ValueMember = "id_vthh";
        }

        private void Load_DaTa()
        {
            

            clsDaTa cls = new clsDaTa();
          
            DataTable dt3 = cls.tbXangDau_SA_ID_HD(mid_hopdong_);
            gridControl_XangDau.DataSource = dt3;
            if (dt3.Rows.Count > 0)
            {
                gridxangdau.EditValue = Convert.ToInt32(dt3.Rows[0]["id_nhacungcap"].ToString());
            }

           
        }
        private void frmBaoGia_XangDau_Load(object sender, EventArgs e)
        {
            Load_lockup();
            Load_DaTa();
        }

        private void btThoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuu2_Click(object sender, EventArgs e)
        {
            Luu_DuLieu();
        }

        private void gridView_XangDau_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT3)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView_XangDau_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                double soluong__ = 0;
                double dongia__ = 0;
                double thanhtien__ = 0;

                if (e.Column == clsoluong_xd)
                {
                    dongia__ = CheckString.ConvertToDouble_My(gridView_XangDau.GetFocusedRowCellValue(cldongiaxd));
                    soluong__ = CheckString.ConvertToDouble_My(gridView_XangDau.GetFocusedRowCellValue(clsoluong_xd));
                    thanhtien__ = soluong__ * dongia__;
                    gridView_XangDau.SetFocusedRowCellValue(clthanhtien_xd, thanhtien__);
                }
                if (e.Column == cldongiaxd)
                {
                    dongia__ = CheckString.ConvertToDouble_My(gridView_XangDau.GetFocusedRowCellValue(cldongiaxd));
                    soluong__ = CheckString.ConvertToDouble_My(gridView_XangDau.GetFocusedRowCellValue(clsoluong_xd));
                    thanhtien__ = soluong__ * dongia__;
                    gridView_XangDau.SetFocusedRowCellValue(clthanhtien_xd, thanhtien__);
                }


            }
            catch
            {

            }
        }

        private void btPrint2_Click(object sender, EventArgs e)
        {
            frmPrint ff = new frmPrint(mid_hopdong_);
            ff.Show();
        }
    }
}
