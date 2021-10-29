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
    public partial class frmBaoGia : Form
    {
        int mid_hopdong_; bool mbthemmoi; double msotien_;
        public frmBaoGia(int xid_hopdong_, bool xthemoi_, double xsotien_)
        {
            mid_hopdong_ = xid_hopdong_;
            mbthemmoi = xthemoi_;
            msotien_ = xsotien_;
            InitializeComponent();
           
        }
        private void Luu_DanhSach_NCC_BaoGia_Cho()
        {
            clsTbbaogia_DanhSach_NCC_Cho cls = new clsTbbaogia_DanhSach_NCC_Cho();
            cls.iId_hopdong = mid_hopdong_;
            cls.iId_nhacungcap = Convert.ToInt32(gridtrungthaucho.EditValue.ToString());
            cls.iTrungthau_1_Phu_2_Phu_3 = 1;

            clsDaTa cls2 = new clsDaTa();
            DataTable dt2 = cls2.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_TrungThau(mid_hopdong_);
            if (dt2.Rows.Count > 0)
            {
                int id___ = Convert.ToInt32(dt2.Rows[0][0].ToString());
                cls.iId_baogia_danhsach = id___;
                cls.Update();
            }
            else cls.Insert();

            cls = new clsTbbaogia_DanhSach_NCC_Cho();
            cls.iId_hopdong = mid_hopdong_;
            cls.iId_nhacungcap = Convert.ToInt32(gridthauphu2.EditValue.ToString());
            cls.iTrungthau_1_Phu_2_Phu_3 = 2;
            DataTable dt3 = cls2.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu2(mid_hopdong_);
            if (dt3.Rows.Count > 0)
            {
                int id___ = Convert.ToInt32(dt3.Rows[0][0].ToString());
                cls.iId_baogia_danhsach = id___;
                cls.Update();
            }
            else cls.Insert();

            cls = new clsTbbaogia_DanhSach_NCC_Cho();
            cls.iId_hopdong = mid_hopdong_;
            cls.iId_nhacungcap = Convert.ToInt32(gridthauphu2.EditValue.ToString());
            cls.iTrungthau_1_Phu_2_Phu_3 = 3;
            DataTable dt4 = cls2.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu3(mid_hopdong_);
            if (dt4.Rows.Count > 0)
            {
                int id___ = Convert.ToInt32(dt4.Rows[0][0].ToString());
                cls.iId_baogia_danhsach = id___;
                cls.Update();
            }
            else cls.Insert();
        }
        private void Luu_duLieu_BaoGia_Cho()
        {
            clsDaTa cls = new clsDaTa();
            cls.tbbaogia_update_all_tontai_W_id_hd(mid_hopdong_, false);

            clsTbbaogia cls2 = new clsTbbaogia();


            DataTable dt2 = (DataTable)gridControl_Cho.DataSource;
            if (dt2 != null)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    cls2.iId_hopdong = mid_hopdong_;
                    //cls2.iId_nhacungcap = Convert.ToInt32(gridtrungthaucho.EditValue.ToString());
                    cls2.iId_vthh = Convert.ToInt32(dt2.Rows[i]["id_vthh"].ToString());
                    cls2.fSoluong= Convert.ToDouble(dt2.Rows[i]["soluong"].ToString());
                    cls2.fDongia1 = Convert.ToDouble(dt2.Rows[i]["dongia1"].ToString());
                    cls2.fThanhtien1 = Convert.ToDouble(dt2.Rows[i]["thanhtien1"].ToString());
                    cls2.fDongia2 = Convert.ToDouble(dt2.Rows[i]["dongia2"].ToString());
                    cls2.fThanhtien2 = Convert.ToDouble(dt2.Rows[i]["thanhtien2"].ToString());
                    cls2.fDongia3 = Convert.ToDouble(dt2.Rows[i]["dongia3"].ToString());
                    cls2.fThanhtien3 = Convert.ToDouble(dt2.Rows[i]["thanhtien3"].ToString());                 
                    cls2.bTontai = true;                    
                    if (dt2.Rows[i]["id_baogia"].ToString() == "")
                        cls2.Insert();
                    else
                    {
                        cls2.iId_baogia = Convert.ToInt32(dt2.Rows[i]["id_baogia"].ToString());
                        cls2.Update();
                    }
                }
                // xoá tồn tại = false
                DataTable dtmoi_false = cls.tbbaogia_SA_ID_HD_TonTai_False(mid_hopdong_);
                if (dtmoi_false.Rows.Count > 0)
                {
                    for (int i = 0; i < dtmoi_false.Rows.Count; i++)
                    {
                        cls2.iId_baogia = Convert.ToInt32(dtmoi_false.Rows[i]["id_baogia"].ToString()); ;
                        cls2.Delete();
                    }
                }
            }
        }

        private void Luu_duLieu_BaoGia_VPP()
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
                    cls2.iId_nhacungcap= Convert.ToInt32(gridvanphongpham.EditValue.ToString());
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
            }
        }

        private void Luu_duLieu_BaoGia_XangDau()
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
            }
        }

        private void Luu_DuLieu()
        {
            Luu_DanhSach_NCC_BaoGia_Cho();
            Luu_duLieu_BaoGia_Cho();
            Luu_duLieu_BaoGia_VPP();
            Luu_duLieu_BaoGia_XangDau();
            MessageBox.Show("Đã lưu");
        }
        private void Load_lockup()
        {
            clsTbnhacungcap cls = new clsTbnhacungcap();
            DataTable dt = cls.SelectAll();
            gridtrungthaucho.Properties.DataSource = dt;
            gridtrungthaucho.Properties.DisplayMember = "tennhacungcap";
            gridtrungthaucho.Properties.ValueMember = "id_nhacungcap";
            //gridthauphu3
            gridthauphu2.Properties.DataSource = dt;
            gridthauphu2.Properties.DisplayMember = "tennhacungcap";
            gridthauphu2.Properties.ValueMember = "id_nhacungcap";

            gridthauphu3.Properties.DataSource = dt;
            gridthauphu3.Properties.DisplayMember = "tennhacungcap";
            gridthauphu3.Properties.ValueMember = "id_nhacungcap";

            gridvanphongpham.Properties.DataSource = dt;
            gridvanphongpham.Properties.DisplayMember = "tennhacungcap";
            gridvanphongpham.Properties.ValueMember = "id_nhacungcap";

            gridxangdau.Properties.DataSource = dt;
            gridxangdau.Properties.DisplayMember = "tennhacungcap";
            gridxangdau.Properties.ValueMember = "id_nhacungcap";

            clsTbvthh cls2 = new clsTbvthh();
            DataTable dt2 = cls2.SelectAll();
            search_mahang_cho.DataSource = dt2;
            search_mahang_cho.DisplayMember = "tenvthh";
            search_mahang_cho.ValueMember = "id_vthh";

            search_mahang_VPP.DataSource = dt2;
            search_mahang_VPP.DisplayMember = "tenvthh";
            search_mahang_VPP.ValueMember = "id_vthh";

            search_mahang_XangDau.DataSource = dt2;
            search_mahang_XangDau.DisplayMember = "tenvthh";
            search_mahang_XangDau.ValueMember = "id_vthh";
        }

        private void Load_DaTa()
        {
            txtSoTien.Text = msotien_.ToString();

            clsDaTa cls = new clsDaTa();
            DataTable dt1 = cls.tbbaogia_SA_id_HD(mid_hopdong_);
            gridControl_Cho.DataSource = dt1;


            DataTable dt2 = cls.tbVPP_SA_ID_HD(mid_hopdong_);
            gridControl_VPP.DataSource = dt2;
            if (dt2.Rows.Count > 0)
            {
                gridvanphongpham.EditValue = Convert.ToInt32(dt2.Rows[0]["id_nhacungcap"].ToString());
            }

            DataTable dt3 = cls.tbXangDau_SA_ID_HD(mid_hopdong_);
            gridControl_XangDau.DataSource = dt3;
            if (dt3.Rows.Count > 0)
            {
                gridxangdau.EditValue = Convert.ToInt32(dt3.Rows[0]["id_nhacungcap"].ToString());
            }

            DataTable dt4 = cls.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_TrungThau(mid_hopdong_);
            if (dt4.Rows.Count > 0)
            {
                gridtrungthaucho.EditValue = Convert.ToInt32(dt4.Rows[0]["id_nhacungcap"].ToString());
            }
            DataTable dt5 = cls.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu2(mid_hopdong_);
            if (dt5.Rows.Count > 0)
            {
                gridthauphu2.EditValue = Convert.ToInt32(dt5.Rows[0]["id_nhacungcap"].ToString());
            }
            DataTable dt6 = cls.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu3(mid_hopdong_);
            if (dt6.Rows.Count > 0)
            {
                gridthauphu3.EditValue = Convert.ToInt32(dt6.Rows[0]["id_nhacungcap"].ToString());
            }
        }
        private void frmBaoGia_Load(object sender, EventArgs e)
        {
            Load_lockup();
            Load_DaTa();
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtSoTien.Text);
                //txtSoTien.Text = String.Format("{0:#,##0.00}", value);
                txtSoTien.Text = value.ToString("N2");

            }
            catch
            {

            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            Luu_DuLieu();
        }

        private void gridControl_Cho_Click(object sender, EventArgs e)
        {

        }

        private void gridView_Cho_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                double soluong__ = 0;
                double dongia_1_ = 0;
                double thanhtien_1_ = 0;

                
                double dongia_2_ = 0;
                double thanhtien_2_ = 0;

               
                double dongia_3_ = 0;
                double thanhtien_3_ = 0;

                if (e.Column == clsoluong)
                {
                    dongia_1_ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(cldongia1));
                    soluong__ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(clsoluong));
                    thanhtien_1_ = soluong__ * dongia_1_;
                    gridView_Cho.SetFocusedRowCellValue(clthanhtien1, thanhtien_1_);
                }
                if (e.Column == cldongia1)
                {
                    dongia_1_ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(cldongia1));
                    soluong__ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(clsoluong));
                    thanhtien_1_ = soluong__ * dongia_1_;
                    gridView_Cho.SetFocusedRowCellValue(clthanhtien1, thanhtien_1_);
                }
             
                if (e.Column == cldongia2)
                {
                    dongia_2_ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(cldongia2));
                    soluong__ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(clsoluong));
                    thanhtien_2_ = soluong__ * dongia_2_;
                    gridView_Cho.SetFocusedRowCellValue(clthanhtien2, thanhtien_2_);
                }
               
                if (e.Column == cldongia3)
                {
                    dongia_3_ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(cldongia3));
                    soluong__ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(clsoluong));
                    thanhtien_3_ = soluong__ * dongia_3_;
                    gridView_Cho.SetFocusedRowCellValue(clthanhtien3, thanhtien_3_);
                }
            }
            catch
            {

            }
        }

        private void gridView_VPP_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                double soluong__ = 0;
                double dongia__ = 0;
                double thanhtien__ = 0;
                
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

        private void gridView_Cho_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT1)
                e.DisplayText = (e.RowHandle + 1).ToString();
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
    }
}
