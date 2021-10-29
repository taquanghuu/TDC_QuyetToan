using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
namespace QuyetToanVCG_TDC_2021
{
    public partial class _5_KeHoachHoiThao_1_ThongQuaQuyTrinh : DevExpress.XtraReports.UI.XtraReport
    {
        string tenhoithao_, mucdich_, cancu_, noidung_, kinhphi_, thoigian_;
        int mid_hopdong___;
        public _5_KeHoachHoiThao_1_ThongQuaQuyTrinh(int xid_hd_)
        {
            mid_hopdong___ = xid_hd_;
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            clsTbhopdong cls = new QuyetToanVCG_TDC_2021.clsTbhopdong();
            cls.iId_hopdong = mid_hopdong___;
            DataTable dt = cls.SelectOne();
            clsDaTa cls2 = new QuyetToanVCG_TDC_2021.clsDaTa();
            DataTable dt2 = cls2.tbNgayThang_SA_ID_HD_and_id_the_stt(mid_hopdong___,6);
            string xngay = ""; string xthang = ""; string xnam = "";
            if(dt2.Rows.Count>0)
            {
                DateTime ngaylaytien = Convert.ToDateTime(dt2.Rows[0]["ngaythang"].ToString());
                xngay = ngaylaytien.ToString("dd");
                xthang = ngaylaytien.ToString("MM");
                xnam = ngaylaytien.ToString("yyyy");
            }
            //string daucham = @".";
            //string dauchamphay = @";";
            //string dauchamseccham = @"./.";
            //8 dấu cách
            tenhoithao_ = "Hội thảo thông qua quy trình "+cls.sTenhopdong.Value+"";
            mucdich_ = "         Thực hiện hội thảo, tìm phương án tốt nhất để "+cls.sTenhopdong.Value.ToString()+"";
            cancu_ = "         Căn cứ vào hợp đồng số " + cls.sSohopdong.Value + " ngày " + cls.daNgayhopdong.Value.ToString("dd/MM/yyyy") + " giữa Viện KT cơ giới quân sự và Cục TC-ĐL-CL về việc " + cls.sTenhopdong.Value.ToString() + "";
            noidung_ = "        - " + cls.sTenhopdong.Value + "";
            thoigian_ = "        - 8h00 ngày "+xngay+" tháng "+xthang+" năm "+xnam+"";
            kinhphi_ = "        Kinh phí lấy theo hợp đồng số "+cls.sSohopdong.Value+ " ngày " + cls.daNgayhopdong.Value.ToString("dd/MM/yyyy") + " giữa Viện KT cơ giới quân sự và Cục TC-ĐL-CL về việc " + cls.sTenhopdong.Value + "";

            pTenHoiThao.Value = tenhoithao_;        
            pmucdich.Value = mucdich_;
            pCanCu.Value = cancu_;
            pNoidung.Value = noidung_;
            pThoiGian.Value = thoigian_;
            pKinhPhi.Value = kinhphi_;
        }
    }
}
