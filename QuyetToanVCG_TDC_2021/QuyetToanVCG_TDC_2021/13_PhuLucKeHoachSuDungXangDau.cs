using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuyetToanVCG_TDC_2021
{
    public partial class _13_PhuLucKeHoachSuDungXangDau : DevExpress.XtraReports.UI.XtraReport
    {
        DateTime ngaykehoach_;
        public _13_PhuLucKeHoachSuDungXangDau(DateTime xxngaykehoach)
        {
            ngaykehoach_ = xxngaykehoach;
            InitializeComponent();
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            pngaythang.Value = "(Kèm theo kế hoạch số       /KH-ĐL ngày "+ngaykehoach_.ToString("dd/MM/yyyy")+")";
        }
    }
}
