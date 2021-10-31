using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuyetToanVCG_TDC_2021
{
    public partial class _15_PhieuGiaoNhan_Xang : DevExpress.XtraReports.UI.XtraReport
    {
        DateTime ngaythang_;
        double tongtien_;
        public _15_PhieuGiaoNhan_Xang(DateTime ngay, double xtongtien)
        {
            ngaythang_ = ngay;
            tongtien_ = xtongtien;
            InitializeComponent();
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            pngaythang.Value = "Ngày "+ ngaythang_.ToString("dd")+ " tháng " + ngaythang_.ToString("MM") + " năm " + ngaythang_.ToString("yyyy") + "";
            ptongsotien.Value = tongtien_;
        }
    }
}
