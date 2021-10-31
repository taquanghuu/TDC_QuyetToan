using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
namespace QuyetToanVCG_TDC_2021
{
    public partial class _17_BaoGia_VPP : DevExpress.XtraReports.UI.XtraReport
    {
        DateTime ngaythang_;
        double tongsotien_;
        int mid_hopdong_;
        public _17_BaoGia_VPP(int xid_hd_, DateTime ngay, double xtongtien)
        {
            mid_hopdong_ = xid_hd_;
            ngaythang_ = ngay;
            tongsotien_ = xtongtien;
            InitializeComponent();
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            clsDaTa cls = new clsDaTa();
            DataTable dt = cls.tbVPP_SA_ID_HD(mid_hopdong_);
            string stennccx = dt.Rows[0]["tennhacungcap"].ToString();
            string sdiachix = dt.Rows[0]["diachi"].ToString();
            string smasothuex = dt.Rows[0]["masothue"].ToString();
            ptencuahang.Value = ""+ stennccx + "";
            pdiachi_masothue.Value = "Địa chỉ: "+sdiachix+"\n Mã số thuế: "+smasothuex+"";
            pngaythang.Value= "Ngày " + ngaythang_.ToString("dd") + " tháng " + ngaythang_.ToString("MM") + " năm " + ngaythang_.ToString("yyyy") + "";

            clsSoTienBangChu cls2 = new QuyetToanVCG_TDC_2021.clsSoTienBangChu();
            ptongsotien.Value = tongsotien_;
            psotienbangchu.Value = "Bằng chữ: " + cls2.DocTienBangChu(tongsotien_, " đồng ./.") + "";
        }
    }
}
