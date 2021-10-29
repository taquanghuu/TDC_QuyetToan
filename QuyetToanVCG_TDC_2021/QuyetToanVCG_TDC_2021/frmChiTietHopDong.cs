using DevExpress.XtraEditors;
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
    public partial class frmChiTietHopDong : Form
    {
        int mid_hopdong_;
        public frmChiTietHopDong(int xid_hopdong)
        {
            mid_hopdong_ = xid_hopdong;
            InitializeComponent();
        }
        private void Load_Lockup()
        {
            clsDaTa cls = new clsDaTa();
            DataTable dt = cls.tbNhanSu_SA_HienThi();
            search_NhanSu.DataSource = dt;
            search_NhanSu.DisplayMember = "hoten";
            search_NhanSu.ValueMember = "id_nhansu";
        }
        private void Load_DaTa()
        {
            clsTbhopdong cls1 = new clsTbhopdong();
            cls1.iId_hopdong = mid_hopdong_;
            DataTable dt1 = cls1.SelectOne();
            txtTenHopDong.Text = cls1.sTenhopdong.Value;
            txtSoHopDong.Text = cls1.sSohopdong.Value;
            dteNgayHopDong.EditValue = cls1.daNgayhopdong.Value;
            txtSoTien.Text = cls1.fSotien.Value.ToString();
            txtGhiChu.Text = cls1.sGhiChu.Value;

            clsDaTa cls2 = new clsDaTa();
            DataTable dt2 = cls2.tbBangKe_SA_ID_HD(mid_hopdong_);
            gridControl_BangKe.DataSource = dt2;

          
            DataTable dt3 = cls2.tbHoiThao_SA_ID_HD(mid_hopdong_);
            gridControl_HoiThao.DataSource = dt3;

           
            DataTable dt4 = cls2.tbNgayThang_SA_ID_HD(mid_hopdong_);
            gridControl_NgayThang.DataSource = dt4;
        }
        private void Luu_duLieu_bangke()
        {
            clsDaTa cls = new clsDaTa();
            cls.tbBangKe_update_all_tontai_W_id_hd(mid_hopdong_, false);

            clsTbBangKe cls2 = new clsTbBangKe();

                       
            DataTable dt2 = (DataTable)gridControl_BangKe.DataSource;
            if (dt2 != null)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    cls2.iId_hopdong = mid_hopdong_;
                    cls2.sSohoadon = dt2.Rows[i]["sohoadon"].ToString();
                    cls2.daNgayhoadon =Convert.ToDateTime(dt2.Rows[i]["ngayhoadon"].ToString());
                    cls2.sDiengiai = dt2.Rows[i]["diengiai"].ToString();
                    cls2.fSotien = Convert.ToDouble(dt2.Rows[i]["sotien"].ToString());
                    cls2.bTontai = true;
                    cls2.bKhoa = false;
                    cls2.bDanhSachCapTien= Convert.ToBoolean(dt2.Rows[i]["DanhSachCapTien"].ToString());
                    if (dt2.Rows[i]["id_bangke"].ToString() == "")
                        cls2.Insert();
                    else
                    {
                        cls2.iId_bangke = Convert.ToInt32(dt2.Rows[i]["id_bangke"].ToString());
                        cls2.Update();
                    }
                }
                // xoá tồn tại = false
                DataTable dtmoi_false = cls.tbBangKe_SA_ID_HD_TonTai_False(mid_hopdong_);
                if(dtmoi_false.Rows.Count>0)
                {
                    for (int i = 0; i < dtmoi_false.Rows.Count; i++)
                    {                        
                        cls2.iId_bangke = Convert.ToInt32(dtmoi_false.Rows[i]["id_bangke"].ToString()); ;
                        cls2.Delete();
                    }
                }
            }
        }

        private void Luu_duLieu_HoiThao()
        {
            clsDaTa cls = new clsDaTa();
            cls.tbHoiThao_update_all_tontai_W_id_hd(mid_hopdong_, false);

            clsTbHoiThao cls2 = new clsTbHoiThao();


            DataTable dt2 = (DataTable)gridControl_HoiThao.DataSource;
            if (dt2 != null)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    cls2.iId_hopdong = mid_hopdong_;
                    cls2.iId_nhansu = Convert.ToInt32(dt2.Rows[i]["id_nhansu"].ToString());
                    cls2.sDiengiai = "";                  
                    cls2.bTontai = true;
                    cls2.bKhoa = false;
                    if (dt2.Rows[i]["id_hoithao"].ToString() == "")
                        cls2.Insert();
                    else
                    {
                        cls2.iId_hoithao = Convert.ToInt32(dt2.Rows[i]["id_hoithao"].ToString());
                        cls2.Update();
                    }
                }
                // xoá tồn tại = false
                DataTable dtmoi_false = cls.tbHoiThao_SA_ID_HD_TonTai_False(mid_hopdong_);
                if (dtmoi_false.Rows.Count > 0)
                {
                    for (int i = 0; i < dtmoi_false.Rows.Count; i++)
                    {
                        cls2.iId_hoithao = Convert.ToInt32(dtmoi_false.Rows[i]["id_hoithao"].ToString()); ;
                        cls2.Delete();
                    }
                }
            }
        }

        private void Luu_duLieu_NgayThang()
        {
            clsDaTa cls = new clsDaTa();
            cls.tbngaythang_update_all_tontai_W_id_hd(mid_hopdong_, false);

            clsTbngaythang cls2 = new clsTbngaythang();


            DataTable dt2 = (DataTable)gridControl_NgayThang.DataSource;
            if (dt2 != null)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    cls2.iId_hopdong = mid_hopdong_;
                    cls2.daNgaythang = Convert.ToDateTime(dt2.Rows[i]["ngaythang"].ToString());
                    cls2.sDiengiai = dt2.Rows[i]["diengiai"].ToString();
                    cls2.bTontai = true;
                    cls2.bKhoa = false;
                    cls2.bCheck_In_An= Convert.ToBoolean(dt2.Rows[i]["Check_In_An"].ToString());
                    cls2.iId_the_STT= Convert.ToInt32(dt2.Rows[i]["id_the_STT"].ToString());
                    if (dt2.Rows[i]["id_ngaythang"].ToString() == "")
                        cls2.Insert();
                    else
                    {
                        cls2.iId_ngaythang = Convert.ToInt32(dt2.Rows[i]["id_ngaythang"].ToString());
                        cls2.Update();
                    }
                }
                // xoá tồn tại = false
                DataTable dtmoi_false = cls.tbngaythang_SA_ID_HD_TonTai_False(mid_hopdong_);
                if (dtmoi_false.Rows.Count > 0)
                {
                    for (int i = 0; i < dtmoi_false.Rows.Count; i++)
                    {
                        cls2.iId_ngaythang = Convert.ToInt32(dtmoi_false.Rows[i]["id_ngaythang"].ToString()); ;
                        cls2.Delete();
                    }
                }
            }
        }
        private void Luu_DuLieu()
        {
            clsTbhopdong cls1 = new clsTbhopdong();
            cls1.daNgayhopdong = dteNgayHopDong.DateTime;
            cls1.sTenhopdong = txtTenHopDong.Text;
            cls1.sSohopdong = txtSoHopDong.Text;
            cls1.sGhiChu = txtGhiChu.Text;
            cls1.bTonTai = true;
            cls1.bKhoa = false;
            cls1.fSotien = Convert.ToDouble(txtSoTien.Text);
            cls1.iId_hopdong = mid_hopdong_;
            cls1.Update();

            Luu_duLieu_bangke();
            Luu_duLieu_HoiThao();
            Luu_duLieu_NgayThang();
            MessageBox.Show("Đã lưu");
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietHopDong_Load(object sender, EventArgs e)
        {
            Load_Lockup();
            Load_DaTa();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            Luu_DuLieu();
        }

       

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            
        }
        //int id_hopdong_x_=0;
        bool themmoi_x_=false;
        double xsotien = 0;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBaoGia ff = new frmBaoGia(mid_hopdong_, themmoi_x_, xsotien);
            ff.Show();
        }

        private void gridControl_BangKe_Click(object sender, EventArgs e)
        {

        }
        double sotiendinhmuc = 0; string chucdanh = "";
        private void search_NhanSu_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)((SearchLookUpEdit)sender).GetSelectedDataRow()).Row;
            sotiendinhmuc = Convert.ToDouble(row["dinhmucsotien"].ToString());
            chucdanh = row["tenchucdanh"].ToString();
        }

        private void gridView_HoiThao_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == clid_nhansu)
            {
                gridView_HoiThao.SetRowCellValue(e.RowHandle, cltenchucdanh, chucdanh);
                gridView_HoiThao.SetRowCellValue(e.RowHandle, cldinhmucsotien, sotiendinhmuc);
            }

        }

       

        private void txtSoTien_Leave(object sender, EventArgs e)
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

        private void gridView_NgayThang_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT3)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView_HoiThao_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT2)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

       

        private void btPrint_Click_1(object sender, EventArgs e)
        {
            frmPrint ff = new QuyetToanVCG_TDC_2021.frmPrint(mid_hopdong_);
            ff.Show();
        }

        private void gridView_BangKe_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView_BangKe.SetFocusedRowCellValue(clDanhSachCapTien, false);
        }
    }
}
