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
    public partial class frmPrint : Form
    {
        int mid_hopdong_;
        public frmPrint(int xid_hd)
        {
            mid_hopdong_ = xid_hd;
            InitializeComponent();
        }
        private void Print_ToTrinh_KeHoach_HoiThao_1(DateTime xngayxx)
        {
            clsTbhopdong cls = new QuyetToanVCG_TDC_2021.clsTbhopdong();
            cls.iId_hopdong = mid_hopdong_;
            DataTable dt = cls.SelectOne();

            string sstentotrinh = "" + cls.sTenhopdong.Value + "";
            string sscancuhopdong = "Căn cứ vào hợp đồng số " + cls.sSohopdong.Value + " ngày " + cls.daNgayhopdong.Value.ToString("dd/MM/yyyy") + " giữa Viện KT cơ giới quân sự và Cục TC-ĐL-CL về việc " + cls.sTenhopdong.Value.ToString() + "";
            string sscancukehoac = "Phòng Đo lường - Thí nghiệm kính đề nghị Viện trưởng Viện KT cơ giới quân sự phê duyệt Kế hoạch Hội thảo thông qua quy trình " + cls.sTenhopdong.Value + "";



            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("tentotrinh", sstentotrinh);//
            dic.Add("ngay", xngayxx.ToString("dd"));//
            dic.Add("thang", xngayxx.ToString("MM"));//
            dic.Add("nam", xngayxx.ToString("yyyy"));//         //
            dic.Add("cancuhopdong", sscancuhopdong);//
            dic.Add("cancukehoach", sscancukehoac);//



            WordUltil wd = new WordUltil(@"C:\Users\Public\Documents\DATA_TDC\_8_ToTrinhPheDuyetHoiThao1.dot", true);
                wd.WriteFields(dic);
            
            //MessageBox.Show("Đã xong");
        }

        private void Print_ToTrinh_KeHoach_XangDau(DateTime xngayxx)
        {
            clsTbhopdong cls = new QuyetToanVCG_TDC_2021.clsTbhopdong();
            cls.iId_hopdong = mid_hopdong_;
            DataTable dt = cls.SelectOne();

            string sstentotrinh = "" + cls.sTenhopdong.Value + "";
            string sscancuhopdong = "Căn cứ vào hợp đồng số " + cls.sSohopdong.Value + " ngày " + cls.daNgayhopdong.Value.ToString("dd/MM/yyyy") + " giữa Viện KT cơ giới quân sự và Cục TC-ĐL-CL về việc " + cls.sTenhopdong.Value.ToString() + "";
            string sscancukehoac = "Phòng Đo lường - Thí nghiệm kính đề nghị Viện trưởng Viện KT cơ giới quân sự phê duyệt Kế hoạch sử dụng xăng dầu " + cls.sTenhopdong.Value + "";



            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("tentotrinh", sstentotrinh);//
            dic.Add("ngay", xngayxx.ToString("dd"));//
            dic.Add("thang", xngayxx.ToString("MM"));//
            dic.Add("nam", xngayxx.ToString("yyyy"));//         //
            dic.Add("cancuhopdong", sscancuhopdong);//
            dic.Add("cancukehoach", sscancukehoac);//



            WordUltil wd = new WordUltil(@"C:\Users\Public\Documents\DATA_TDC\_14_ToTrinhPheDuyetKH_XangDau.dot", true);
            wd.WriteFields(dic);

            //MessageBox.Show("Đã xong");
        }

        private void Print_QuyetDinh_KeHoach_HoiThao_1(DateTime xngayxx)
        {
            clsTbhopdong cls = new QuyetToanVCG_TDC_2021.clsTbhopdong();
            cls.iId_hopdong = mid_hopdong_;
            DataTable dt = cls.SelectOne();

            string sstenquyetdinh = "Phê duyệt Kế hoạch hội thảo thông qua quy trình " + cls.sTenhopdong.Value + "";
            string sscancuhopdong = "Căn cứ vào hợp đồng số " + cls.sSohopdong.Value + " ngày " + cls.daNgayhopdong.Value.ToString("dd/MM/yyyy") + " giữa Viện KT cơ giới quân sự và Cục TC-ĐL-CL về việc " + cls.sTenhopdong.Value.ToString() + "";
            string ssdieu1 = "Phê duyệt Kế hoạch Hội thảo thông qua quy trình " + cls.sTenhopdong.Value + "";



            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("tenquyetdinh", sstenquyetdinh);//           
            dic.Add("cancuhopdong", sscancuhopdong);//
            dic.Add("dieu1", ssdieu1);//



            WordUltil wd = new WordUltil(@"C:\Users\Public\Documents\DATA_TDC\_9_QuyetDinhPheDuyet_HoiThao_1.dot", true);
            wd.WriteFields(dic);

            //MessageBox.Show("Đã xong");
        }

        private void _15_Print_QuyetDinh_XangDau(DateTime xngayxx)
        {
            clsTbhopdong cls = new QuyetToanVCG_TDC_2021.clsTbhopdong();
            cls.iId_hopdong = mid_hopdong_;
            DataTable dt = cls.SelectOne();

            string sstenquyetdinh = "Phê duyệt Kế hoạch sử dụng xăng dầu " + cls.sTenhopdong.Value + "";
            string sscancuhopdong = "Căn cứ vào hợp đồng số " + cls.sSohopdong.Value + " ngày " + cls.daNgayhopdong.Value.ToString("dd/MM/yyyy") + " giữa Viện KT cơ giới quân sự và Cục TC-ĐL-CL về việc " + cls.sTenhopdong.Value.ToString() + "";
            string ssdieu1 = "Phê duyệt Kế hoạch sử dụng xăng dầu" + cls.sTenhopdong.Value + "";



            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("tenquyetdinh", sstenquyetdinh);//           
            dic.Add("cancuhopdong", sscancuhopdong);//
            dic.Add("dieu1", ssdieu1);//



            WordUltil wd = new WordUltil(@"C:\Users\Public\Documents\DATA_TDC\_15_QuyetDinh_XangDau.dot", true);
            wd.WriteFields(dic);

            //MessageBox.Show("Đã xong");
        }

        private void _20_Print_BBKS(DateTime xngayxx)
        {
            clsTbhopdong cls = new QuyetToanVCG_TDC_2021.clsTbhopdong();
            cls.iId_hopdong = mid_hopdong_;
            DataTable dt = cls.SelectOne();
            clsDaTa cls2 = new clsDaTa();
            DataTable dt2 = cls2.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_TrungThau(mid_hopdong_);
            string sscuahangtrungthau = dt2.Rows[0]["tennhacungcap"].ToString();
            string ssdiachi = dt2.Rows[0]["diachi"].ToString().Trim();
            DataTable dt3 = cls2.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu2(mid_hopdong_);
            string nhaxanh2 = dt3.Rows[0]["tennhacungcap"].ToString();
            DataTable dt4 = cls2.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu3(mid_hopdong_);
            string nhaxanh3 = dt4.Rows[0]["tennhacungcap"].ToString();

            string caccuahang = "- "+ sscuahangtrungthau + ";\n- "+nhaxanh2+";\n- "+nhaxanh3+";";
            string sscancuhopdong = "" + cls.sSohopdong.Value + " ngày " + cls.daNgayhopdong.Value.ToString("dd/MM/yyyy") + " giữa Viện KT cơ giới quân sự và Cục TC-ĐL-CL về việc " + cls.sTenhopdong.Value.ToString() + "";
            
            Dictionary<string, string> dic = new Dictionary<string, string>();
                  
            dic.Add("cancuhopdong", sscancuhopdong);//
            dic.Add("caccuahang", caccuahang);//
            dic.Add("cuahangtrungthau", sscuahangtrungthau);//           
            dic.Add("diachi", ssdiachi);//           
            dic.Add("ngay", xngayxx.ToString("dd"));//
            dic.Add("thang", xngayxx.ToString("MM"));//
            dic.Add("nam", xngayxx.ToString("yyyy"));//         


            WordUltil wd = new WordUltil(@"C:\Users\Public\Documents\DATA_TDC\_20_BienBanKhaoSatGia.dot", true);
            wd.WriteFields(dic);

            //MessageBox.Show("Đã xong");
        }

        private void _21_Print_ToTrinh_CHoTroi_ChiDinhThau(DateTime xngayxx)
        {
            clsTbhopdong cls = new QuyetToanVCG_TDC_2021.clsTbhopdong();
            cls.iId_hopdong = mid_hopdong_;
            DataTable dt = cls.SelectOne();

            clsDaTa cls2 = new clsDaTa();
            DataTable dt2 = cls2.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_TrungThau(mid_hopdong_);
            string sscuahangtrungthau = dt2.Rows[0]["tennhacungcap"].ToString();
            string ssdiachi = dt2.Rows[0]["diachi"].ToString().Trim();

            DataTable dt3 = cls2.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu2(mid_hopdong_);
            string nhaxanh2 = dt3.Rows[0]["tennhacungcap"].ToString();
            string ssdiachi_nhaxanh2 = dt3.Rows[0]["diachi"].ToString().Trim();

            DataTable dt4 = cls2.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu3(mid_hopdong_);
            string nhaxanh3 = dt4.Rows[0]["tennhacungcap"].ToString();
            string ssdiachi_nhaxanh3 = dt4.Rows[0]["diachi"].ToString().Trim();

            clsDaTa cls3 = new clsDaTa();
            DataTable xdt = cls3.tbbaogia_SA_id_HD(mid_hopdong_);
            double xgiatrungthau = Convert.ToDouble(xdt.Compute("SUM(thanhtien1)", string.Empty));
            double xgianhaxanh2 = Convert.ToDouble(xdt.Compute("SUM(thanhtien2)", string.Empty));
            double xgianhaxanh3 = Convert.ToDouble(xdt.Compute("SUM(thanhtien3)", string.Empty));
           
            DataTable dt10 = cls3.tbNgayThang_SA_ID_HD_and_id_the_stt(mid_hopdong_, 20);
            DateTime ngaykhaosat = Convert.ToDateTime(dt10.Rows[0]["ngaythang"].ToString());

            clsSoTienBangChu cls4 = new clsSoTienBangChu();
            string sotienbangchuxx = cls4.DocTienBangChu(xgiatrungthau, " đồng");

            string stentotrinh = "Về việc phê duyệt nhà cung cấp vật tư hàng hoá thực hiện nhiệm vụ " + cls.sTenhopdong.Value + "";
            string sscancuhopdong = "" + cls.sSohopdong.Value + " ngày " + cls.daNgayhopdong.Value.ToString("dd/MM/yyyy") + " giữa Viện KT cơ giới quân sự và Cục TC-ĐL-CL về việc " + cls.sTenhopdong.Value.ToString() + "";
            string sstenhopdong = "" + cls.sTenhopdong.Value + "";

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("tentotrinh", stentotrinh);//
            dic.Add("cancuhopdong", sscancuhopdong);//
            dic.Add("tenhopdong", sstenhopdong);//
            dic.Add("ngaykhaosat", ngaykhaosat.ToString("dd/MM/yyyy"));//
            dic.Add("nhatrungthau", sscuahangtrungthau);// 
                     
            dic.Add("nhaxanh2", nhaxanh2);//
            dic.Add("nhaxanh3", nhaxanh3);//
            dic.Add("diachi1", ssdiachi);//

            dic.Add("diachi2", ssdiachi_nhaxanh2);//
            dic.Add("diachi3", ssdiachi_nhaxanh3);//
            dic.Add("giatrungthau", xgiatrungthau.ToString("#,##0"));//
            dic.Add("gianhaxanh2", xgianhaxanh2.ToString("#,##0"));//    
            dic.Add("gianhaxanh3", xgianhaxanh3.ToString("#,##0"));//  
            dic.Add("tienbangchu", sotienbangchuxx);//  
            dic.Add("ngay", xngayxx.ToString("dd"));//
            dic.Add("thang", xngayxx.ToString("MM"));//
            dic.Add("nam", xngayxx.ToString("yyyy"));//         


            WordUltil wd = new WordUltil(@"C:\Users\Public\Documents\DATA_TDC\_21_ToTrinh_ChoTroi.dot", true);
            wd.WriteFields(dic);

            //MessageBox.Show("Đã xong");
        }

        private void _22_Print_QuyetDinh_CHoTroi_ChiDinhThau(DateTime xngayxx)
        {
            clsTbhopdong cls = new QuyetToanVCG_TDC_2021.clsTbhopdong();
            cls.iId_hopdong = mid_hopdong_;
            DataTable dt = cls.SelectOne();

            string sstenquyetdinh = "Vê việc lựa chọn nhà cung cấp vật tư hàng hoá phục vụ " + cls.sTenhopdong.Value + "";
            string sscancuhopdong = "Căn cứ vào hợp đồng số " + cls.sSohopdong.Value + " ngày " + cls.daNgayhopdong.Value.ToString("dd/MM/yyyy") + " giữa Viện KT cơ giới quân sự và Cục TC-ĐL-CL về việc " + cls.sTenhopdong.Value.ToString() + "";
            string ssdieu1 = "Phê duyệt Kế hoạch Hội thảo thông qua quy trình " + cls.sTenhopdong.Value + "";



            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("tenquyetdinh", sstenquyetdinh);//           
            dic.Add("cancuhopdong", sscancuhopdong);//
            dic.Add("dieu1", ssdieu1);//
            dic.Add("dieu2", ssdieu1);//


            WordUltil wd = new WordUltil(@"C:\Users\Public\Documents\DATA_TDC\_22_QuyetDinh_chiDinhThau_ChoTroi.dot", true);
            wd.WriteFields(dic);

            //MessageBox.Show("Đã xong");
        }


        private void Print_KeHoachSuDung_XangDau(DateTime xngayxx)
        {
            clsTbhopdong cls = new QuyetToanVCG_TDC_2021.clsTbhopdong();
            cls.iId_hopdong = mid_hopdong_;
            DataTable dt = cls.SelectOne();

            string stenkehoach = "Phục vụ " + cls.sTenhopdong.Value + "";
            string shopdong = ""+cls.sSohopdong.Value+" ký ngày "+cls.daNgayhopdong.Value.ToString("dd/MM/yyyy")+ " giữa Viện KT cơ giới quân sự và Cục TC-ĐL-CL về việc "+cls.sTenhopdong.Value+"";
            string ssoluong = txtGhiChu.Text;

         
            string sdiadiem = cls.sGhiChu.Value;
           clsDaTa cls2 = new clsDaTa();
            DataTable dttungay = cls2.tbNgayThang_SA_ID_HD_and_id_the_stt(mid_hopdong_, 11);
            DataTable dtdenngay = cls2.tbNgayThang_SA_ID_HD_and_id_the_stt(mid_hopdong_, 12);
            DateTime xtungay = Convert.ToDateTime(dttungay.Rows[0]["ngaythang"].ToString());
            DateTime xdenngay = Convert.ToDateTime(dtdenngay.Rows[0]["ngaythang"].ToString());
          
            string sthoigian = "Từ ngày " + xtungay.ToString("dd/MM/yyyy") + " đến ngày  " + xdenngay.ToString("dd/MM/yyyy") + "";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("tenkehoach", stenkehoach);//
            dic.Add("ngay", xngayxx.ToString("dd"));//
            dic.Add("thang", xngayxx.ToString("MM"));//
            dic.Add("nam", xngayxx.ToString("yyyy"));//         //
            dic.Add("thoigian", sthoigian);//
            dic.Add("diadiem", sdiadiem);//
            dic.Add("hopdong", shopdong);//
            dic.Add("soluong", ssoluong);//
            //WordUltil wd = new WordUltil(@"C:\Users\Public\Documents\DATA_TDC\_10_KeHoachSuDungXangDau.dot", true);
            //wd.WriteFields(dic);

            DataTable dtxangdau = (DataTable)gridControl2.DataSource;
            if (dtxangdau.Rows.Count > 0)
            {
                WordUltil wd = new WordUltil(@"C:\Users\Public\Documents\DATA_TDC\_10_KeHoachSuDungXangDau.dot", true);
                wd.WriteFields(dic);
                //wd.WriteTable(dtxangdau, 2);
            }
            //    //for (int i = 0; i < dtxangdau.Rows.Count; ++i)
            //    //{
            //    //    dtxangdau.Rows[i]["ngay"] = i + 1;
            //    //}

        }
        private void btPrint1_Click(object sender, EventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue(clid_ngaythang).ToString()!="")
            {
               
               DateTime xngay= Convert.ToDateTime(gridView1.GetFocusedRowCellValue(clngaythang).ToString());
                int xid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_the_STT).ToString());
                if (xid == 8)
                    Print_ToTrinh_KeHoach_HoiThao_1(xngay);
                else if (xid == 9)
                    Print_QuyetDinh_KeHoach_HoiThao_1(xngay);
                else if (xid == 10)
                    Print_KeHoachSuDung_XangDau(xngay);
                else if (xid == 14)
                    Print_ToTrinh_KeHoach_XangDau(xngay);
                else if (xid == 15)
                    _15_Print_QuyetDinh_XangDau(xngay);
                else if (xid == 20)
                    _20_Print_BBKS(xngay);
                else if (xid == 21)
                    _21_Print_ToTrinh_CHoTroi_ChiDinhThau(xngay);
                else if (xid == 22)
                    _22_Print_QuyetDinh_CHoTroi_ChiDinhThau(xngay);
                else
                {
                    Print_HienThi ff = new Print_HienThi(xid, mid_hopdong_, xngay);
                    ff.Show();
                }
          
            }
           
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            clsDaTa cls = new clsDaTa();
            DataTable dt = cls.tbngaythang_SA_Print(mid_hopdong_);
            gridControl1.DataSource = dt;

            DataTable dt2 = cls.tbPhuLuc_XangDau_SA_ID_HD(mid_hopdong_);
            gridControl2.DataSource = dt2;
            if(dt2.Rows.Count>0)
            txtGhiChu.Text = dt2.Rows[0]["ghichu"].ToString();
        }

        private void gridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            clsTbPhuLuc_XangDau cls = new clsTbPhuLuc_XangDau();
            cls.sNoidung = gridView2.GetFocusedRowCellValue(clnoidung2).ToString();
            DateTime ngayxx= Convert.ToDateTime(gridView2.GetFocusedRowCellValue(clngaythang2).ToString());
            cls.sNgay = ngayxx.ToString("dd/MM/yyyy");
            cls.sDonvitinh = gridView2.GetFocusedRowCellValue(cldonvitinh2).ToString();
            cls.fSoluong = Convert.ToDouble(gridView2.GetFocusedRowCellValue(clsoluong2).ToString());
            cls.iId_hopdong = mid_hopdong_;
            cls.sGhichu = txtGhiChu.Text;
            if (gridView2.GetFocusedRowCellValue(clid_xd2).ToString() == "")
            {
                cls.Insert();
            }
            else
            {
                cls.iId_xd = Convert.ToInt32(gridView2.GetFocusedRowCellValue(clid_xd2).ToString());
                cls.Update();
            }
        }

        private void gridView2_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT2)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

     
    }
}
