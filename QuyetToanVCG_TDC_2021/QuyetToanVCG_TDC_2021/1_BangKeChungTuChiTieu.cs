using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
namespace QuyetToanVCG_TDC_2021
{
    public partial class _1_BangKeChungTuChiTieu : DevExpress.XtraReports.UI.XtraReport
    {
        double tongsotien_ = 0;
        string tenhopdong_ = ""; int mid_hpdong_;
        public _1_BangKeChungTuChiTieu(double xtongsotien, int xid_hd)
        {
            tongsotien_ = xtongsotien;
            mid_hpdong_ = xid_hd;
            InitializeComponent();
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            clsSoTienBangChu cls = new QuyetToanVCG_TDC_2021.clsSoTienBangChu();
            pTongSoTien.Value = tongsotien_;
            psotienbangchu.Value = cls.DocTienBangChu(tongsotien_," đồng ./.");
            clsTbhopdong cls2 = new clsTbhopdong();
            cls2.iId_hopdong = mid_hpdong_;
            DataTable dt = cls2.SelectOne();
            string ngay = cls2.daNgayhopdong.Value.ToString("dd");
            string thang = cls2.daNgayhopdong.Value.ToString("MM");
            string nam = cls2.daNgayhopdong.Value.ToString("yyyy");
            tenhopdong_ = "Hợp đồng số "+cls2.sSohopdong.Value+" ký ngày "+ngay+" tháng "+thang+" năm "+nam+" giữa Viện Kỹ thuật cơ giới quân sự với Cục Tiêu chuẩn - Đo lường - Chất lượng.";
            pTenHopDong.Value = "Khoản: "+ tenhopdong_ + "";
        }
    }
}
