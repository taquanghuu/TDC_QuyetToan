using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace QuyetToanVCG_TDC_2021
{
    public partial class _7_DanhSachBoiDuong_HoiThao_1 : DevExpress.XtraReports.UI.XtraReport
    {
        string tenhoithao_;
        int mid_hopdong___;
        double tongsotien_ = 0;
        DateTime ngaynhantien_;
        public _7_DanhSachBoiDuong_HoiThao_1(double xtongsotien, int xid_hd_, DateTime ngaynhantien)
        {
            tongsotien_ = xtongsotien;
            mid_hopdong___ = xid_hd_;
            ngaynhantien_ = ngaynhantien;
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            clsTbhopdong cls = new QuyetToanVCG_TDC_2021.clsTbhopdong();
            cls.iId_hopdong = mid_hopdong___;
            DataTable dt = cls.SelectOne();
            tenhoithao_ = "DANH SÁCH BỒI DƯỠNG THÙ LAO\n Hội thảo thông qua quy trình " + cls.sTenhopdong.Value + "";
            pTenHoiThao.Value = tenhoithao_;

            clsSoTienBangChu cls2 = new QuyetToanVCG_TDC_2021.clsSoTienBangChu();
            pTongSoTien.Value = tongsotien_;
            psotienbangchu.Value = "       Tổng số tiền bằng chữ: "+ cls2.DocTienBangChu(tongsotien_, " đồng ./.") + "";
            pngaythang.Value = "Ngày " + ngaynhantien_.ToString("dd") + " tháng " + ngaynhantien_.ToString("MM") + " năm " + ngaynhantien_.ToString("yyyy") + "";
          
        }
    }
}
