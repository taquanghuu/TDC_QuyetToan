using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuyetToanVCG_TDC_2021
{
    public partial class _8_ToTrinhPheDuyet_HoiThao_1 : DevExpress.XtraReports.UI.XtraReport
    {
        string tentotrinh, cancuhopdong, cancukehoac, ngaythang;
        int mid_hopdong___;
        public _8_ToTrinhPheDuyet_HoiThao_1(int xid_hd_)
        {
            mid_hopdong___ = xid_hd_;
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            pToTrinh.Value = tentotrinh;
            pCanCuHopDong.Value = cancuhopdong;
            pCanCuKeHoach.Value = cancukehoac;
            pNgayThang.Value = ngaythang;
        }
    }
}
