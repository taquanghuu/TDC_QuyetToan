using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
namespace QuyetToanVCG_TDC_2021
{
    public partial class _15_PhieuGiaoNhan_Xang : DevExpress.XtraReports.UI.XtraReport
    {
        DateTime ngaythang_;
        double tongtien_;
        int mid_hopdong_;
        int mid_loahoadon_;
        public _15_PhieuGiaoNhan_Xang(int id_hd_x, int xid_loaihoadon, DateTime ngay, double xtongtien)
        {
            mid_hopdong_ = id_hd_x;
            mid_loahoadon_ = xid_loaihoadon;
            ngaythang_ = ngay;
            tongtien_ = xtongtien;
            InitializeComponent();
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            clsDaTa cls1 = new clsDaTa();
            DataTable dt = cls1.tbBangKe_SA_id_hopdong_W_id_loaihoadon(mid_hopdong_, mid_loahoadon_);
            string ssohoadon = dt.Rows[0]["sohoadon"].ToString();
            DateTime ngayhoadon = Convert.ToDateTime(dt.Rows[0]["ngayhoadon"].ToString());
            ptenhoadon.Value = "Theo hoá đơn số: "+ssohoadon+" ngày "+ngayhoadon.ToString("dd/MM/yyyy")+"";
            pngaythang.Value = "Ngày "+ ngaythang_.ToString("dd")+ " tháng " + ngaythang_.ToString("MM") + " năm " + ngaythang_.ToString("yyyy") + "";
            ptongsotien.Value = tongtien_;
        }
    }
}
