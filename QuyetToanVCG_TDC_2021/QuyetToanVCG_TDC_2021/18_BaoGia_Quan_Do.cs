using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
namespace QuyetToanVCG_TDC_2021
{
    public partial class _18_BaoGia_Quan_Do : DevExpress.XtraReports.UI.XtraReport
    {
        int mid_font;
        public _18_BaoGia_Quan_Do()
        {
            InitializeComponent();
        }
        private void Chon_Font_Chu()
        {
            clsTbmafontchu cls = new clsTbmafontchu();
            cls.iId_mafontchu = mid_font;
            DataTable dt= cls.SelectOne();
            string tenfont = cls.sMafont.Value;
            
        }
        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Chon_Font_Chu();
        }
    }
}
