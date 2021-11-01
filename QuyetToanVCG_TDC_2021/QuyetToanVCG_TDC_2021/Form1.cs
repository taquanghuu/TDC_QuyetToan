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
      
        private void copy_bangke(int miid_hd_hientai,int id_hopdongmoi_)
        {         
            clsDaTa cls = new clsDaTa();
            DataTable dt = cls.tbBangKe_SA_ID_HD(miid_hd_hientai);

            clsTbBangKe cls2 = new clsTbBangKe();           
            for(int i=0; i<dt.Rows.Count; i++)
            {
                cls2.iId_hopdong = id_hopdongmoi_;
                cls2.sSohoadon = dt.Rows[i]["sohoadon"].ToString();
                cls2.daNgayhoadon= Convert.ToDateTime(dt.Rows[i]["ngayhoadon"].ToString());
                cls2.sDiengiai= dt.Rows[i]["diengiai"].ToString();
                cls2.fSotien = Convert.ToDouble(dt.Rows[i]["sotien"].ToString());
                cls2.bTontai = Convert.ToBoolean(dt.Rows[i]["tontai"].ToString());
                cls2.bKhoa = Convert.ToBoolean(dt.Rows[i]["khoa"].ToString());
                cls2.bDanhSachCapTien = Convert.ToBoolean(dt.Rows[i]["DanhSachCapTien"].ToString());
                cls2.iId_loaihoadon = Convert.ToInt32(dt.Rows[i]["id_loaihoadon"].ToString());
                cls2.Insert();
            }
        }
        private void copy_BaoGia(int miid_hd_hientai, int id_hopdongmoi_)
        {
            clsDaTa cls = new clsDaTa();
            DataTable dt = cls.tbbaogia_SA_id_HD(miid_hd_hientai);

            clsTbbaogia cls2 = new clsTbbaogia();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cls2.iId_hopdong = id_hopdongmoi_;              
                cls2.iId_vthh = Convert.ToInt32(dt.Rows[i]["ngayhoadon"].ToString());               
                cls2.fSoluong = Convert.ToDouble(dt.Rows[i]["soluong"].ToString());
                cls2.fDongia1 = Convert.ToDouble(dt.Rows[i]["dongia1"].ToString());
                cls2.fDongia2 = Convert.ToDouble(dt.Rows[i]["dongia2"].ToString());
                cls2.fDongia3 = Convert.ToDouble(dt.Rows[i]["dongia3"].ToString());
                cls2.fThanhtien1 = Convert.ToDouble(dt.Rows[i]["thanhtien1"].ToString());
                cls2.fThanhtien2 = Convert.ToDouble(dt.Rows[i]["thanhtien2"].ToString());
                cls2.fThanhtien3 = Convert.ToDouble(dt.Rows[i]["thanhtien3"].ToString());              
                cls2.bTontai = Convert.ToBoolean(dt.Rows[i]["tontai"].ToString());               
                cls2.Insert();
            }
        }
        private void copy_DanhSach_NCC_Cho_troi(int miid_hd_hientai, int id_hopdongmoi_)
        {
            clsDaTa cls = new clsDaTa();
            DataTable dt = cls.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD(miid_hd_hientai);

            clsTbbaogia_DanhSach_NCC_Cho cls2 = new clsTbbaogia_DanhSach_NCC_Cho();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cls2.iId_hopdong = id_hopdongmoi_;
                cls2.iId_nhacungcap = Convert.ToInt32(dt.Rows[i]["id_nhacungcap"].ToString());
                cls2.iTrungthau_1_Phu_2_Phu_3 = Convert.ToInt32(dt.Rows[i]["trungthau_1_Phu_2_Phu_3"].ToString());                
                cls2.Insert();
            }
        }

        private void copy_BaoGia_VPP_XangDau(int miid_hd_hientai, int id_hopdongmoi_)
        {
            clsDaTa cls = new clsDaTa();
            DataTable dt = cls.tbBaoGia_VPP_XangDau_SA_ID_HD(miid_hd_hientai);

            clsTbBaoGia_VPP_XangDau cls2 = new clsTbBaoGia_VPP_XangDau();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cls2.iId_hopdong = id_hopdongmoi_;
                cls2.iId_nhacungcap = Convert.ToInt32(dt.Rows[i]["id_nhacungcap"].ToString());
                cls2.iId_vthh = Convert.ToInt32(dt.Rows[i]["id_vthh"].ToString());
                cls2.fSoluong = Convert.ToDouble(dt.Rows[i]["soluong"].ToString());
                cls2.fDongia = Convert.ToDouble(dt.Rows[i]["dongia"].ToString());
                cls2.fThanhtien = Convert.ToDouble(dt.Rows[i]["thanhtien"].ToString());
                cls2.bTontai = Convert.ToBoolean(dt.Rows[i]["tontai"].ToString());
                cls2.iVPP_1_XangDau_2 = Convert.ToInt32(dt.Rows[i]["VPP_1_XangDau_2"].ToString());               
                cls2.Insert();
            }
        }
        private void copy_HoiThao(int miid_hd_hientai, int id_hopdongmoi_)
        {
            clsDaTa cls = new clsDaTa();
            DataTable dt = cls.tbHoiThao_SA_ID_HD(miid_hd_hientai);
            clsTbHoiThao cls2 = new clsTbHoiThao();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cls2.iId_hopdong = id_hopdongmoi_;
                cls2.iId_nhansu = Convert.ToInt32(dt.Rows[i]["id_nhansu"].ToString());
                cls2.sDiengiai = dt.Rows[i]["diengiai"].ToString();              
                cls2.bTontai = Convert.ToBoolean(dt.Rows[i]["tontai"].ToString());
                cls2.bKhoa = Convert.ToBoolean(dt.Rows[i]["khoa"].ToString());
                cls2.Insert();
            }
        }
        private void copy_NgayThang(int miid_hd_hientai, int id_hopdongmoi_)
        {
            clsDaTa cls = new clsDaTa();
            DataTable dt = cls.tbNgayThang_SA_ID_HD(miid_hd_hientai);
            clsTbngaythang cls2 = new clsTbngaythang();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cls2.iId_hopdong = id_hopdongmoi_;
                
                cls2.sDiengiai = dt.Rows[i]["diengiai"].ToString();
                cls2.daNgaythang = Convert.ToDateTime(dt.Rows[i]["ngaythang"].ToString());
                cls2.bTontai = Convert.ToBoolean(dt.Rows[i]["tontai"].ToString());
                cls2.bKhoa = Convert.ToBoolean(dt.Rows[i]["khoa"].ToString());
                cls2.bCheck_In_An = Convert.ToBoolean(dt.Rows[i]["Check_In_An"].ToString());
                cls2.iId_the_STT = Convert.ToInt32(dt.Rows[i]["id_the_STT"].ToString());
                cls2.Insert();
            }
        }

        private void copy_PhuLucXangDau(int miid_hd_hientai, int id_hopdongmoi_)
        {
            clsDaTa cls = new clsDaTa();
            DataTable dt = cls.tbPhuLuc_XangDau_SA_ID_HD(miid_hd_hientai);
            clsTbPhuLuc_XangDau cls2 = new clsTbPhuLuc_XangDau();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cls2.iId_hopdong = id_hopdongmoi_;

                cls2.sNoidung = dt.Rows[i]["noidung"].ToString();
                cls2.sNgay = dt.Rows[i]["ngay"].ToString();
                cls2.sDonvitinh = dt.Rows[i]["donvitinh"].ToString();
                cls2.fSoluong = Convert.ToDouble(dt.Rows[i]["soluong"].ToString());
                cls2.sGhichu = dt.Rows[i]["ghichu"].ToString();
                cls2.Insert();
            }
        }

        private void copy_DuToanBenCuc(int miid_hd_hientai, int id_hopdongmoi_)
        {
            clsDaTa cls = new clsDaTa();
            DataTable dt = cls.tbDuToan_ben_Cuc_SA_ID_HD(miid_hd_hientai);

            clsTbDuToan_ben_Cuc cls2 = new clsTbDuToan_ben_Cuc();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cls2.iId_hopdong = id_hopdongmoi_;                
                cls2.iId_vthh = Convert.ToInt32(dt.Rows[i]["id_vthh"].ToString());
                cls2.fSoluong = Convert.ToDouble(dt.Rows[i]["soluong"].ToString());
                cls2.fDongia = Convert.ToDouble(dt.Rows[i]["dongia"].ToString());
                cls2.fThanhtien = Convert.ToDouble(dt.Rows[i]["thanhtien"].ToString());
                cls2.bTontai = Convert.ToBoolean(dt.Rows[i]["tontai"].ToString());
                cls2.iId_loaihoadon = Convert.ToInt32(dt.Rows[i]["id_loaihoadon"].ToString());
                cls2.Insert();
            }
        }
        private void Copyyyyyyyyyyyyyyy(int miid_hd_hientai)
        {
            clsTbhopdong cls = new clsTbhopdong();
            cls.sTenhopdong = gridView1.GetFocusedRowCellValue(cltenhopdong).ToString();
            cls.daNgayhopdong = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(clngayhopdong).ToString());
            cls.sSohopdong = gridView1.GetFocusedRowCellValue(clsohopdong).ToString();
            cls.fSotien = Convert.ToDouble(gridView1.GetFocusedRowCellValue(clsotien).ToString());
            cls.bKhoa = false;
            cls.bTonTai = true;
            cls.sGhiChu = gridView1.GetFocusedRowCellValue(clGhiChu).ToString();
            cls.Insert();
            int iid_hd_ = cls.iId_hopdong.Value;
            copy_bangke(miid_hd_hientai, iid_hd_);
            copy_BaoGia(miid_hd_hientai, iid_hd_);
            copy_DanhSach_NCC_Cho_troi(miid_hd_hientai, iid_hd_);
            copy_BaoGia_VPP_XangDau(miid_hd_hientai, iid_hd_);
            copy_HoiThao(miid_hd_hientai, iid_hd_);
            copy_NgayThang(miid_hd_hientai, iid_hd_);
            copy_PhuLucXangDau(miid_hd_hientai, iid_hd_);
            copy_DuToanBenCuc(miid_hd_hientai, iid_hd_);
        }
        private void btCopy_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clid_hopdong).ToString() != "")
            {
               int xxidmiid_hd_hientai= Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_hopdong).ToString());
                Copyyyyyyyyyyyyyyy(xxidmiid_hd_hientai);
                Load_DaTa();
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
