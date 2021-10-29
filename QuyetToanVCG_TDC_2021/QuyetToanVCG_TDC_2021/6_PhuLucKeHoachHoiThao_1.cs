using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
namespace QuyetToanVCG_TDC_2021
{
    public partial class _6_PhuLucKeHoachHoiThao_1 : DevExpress.XtraReports.UI.XtraReport
    {
        string tenhoithao_;
        int mid_hopdong___;
        public _6_PhuLucKeHoachHoiThao_1(int xid_hd_)
        {
            mid_hopdong___ = xid_hd_;
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            clsTbhopdong cls = new QuyetToanVCG_TDC_2021.clsTbhopdong();
            cls.iId_hopdong = mid_hopdong___;
            DataTable dt = cls.SelectOne();
            tenhoithao_ = "DANH SÁCH\n Hội thảo thông qua quy trình " + cls.sTenhopdong.Value + "";
            pTenHoiThao.Value = tenhoithao_;
        }
    }
}
