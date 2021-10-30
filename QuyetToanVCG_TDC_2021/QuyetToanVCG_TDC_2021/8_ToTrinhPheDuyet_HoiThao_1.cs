using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace QuyetToanVCG_TDC_2021
{
    public partial class _8_ToTrinhPheDuyet_HoiThao_1 : DevExpress.XtraReports.UI.XtraReport
    {
        string tentotrinh, cancuhopdong, cancukehoac;
        DateTime ngaythang;
        int mid_hopdong___;
        public _8_ToTrinhPheDuyet_HoiThao_1(int xid_hd_, DateTime xngaythang)
        {
            mid_hopdong___ = xid_hd_;
            ngaythang = xngaythang;
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            clsTbhopdong cls = new QuyetToanVCG_TDC_2021.clsTbhopdong();
            cls.iId_hopdong = mid_hopdong___;
            DataTable dt = cls.SelectOne();
            clsDaTa cls2 = new QuyetToanVCG_TDC_2021.clsDaTa();
            DataTable dt2 = cls2.tbNgayThang_SA_ID_HD_and_id_the_stt(mid_hopdong___, 6);
            tentotrinh = "TỜ TRÌNH\nĐề nghị phê duyệt kế hoạch hội thảo thông qua quy trình " + cls.sTenhopdong.Value + "";
            cancuhopdong= "         Căn cứ vào hợp đồng số " + cls.sSohopdong.Value + " ngày " + cls.daNgayhopdong.Value.ToString("dd/MM/yyyy") + " giữa Viện KT cơ giới quân sự và Cục TC-ĐL-CL về việc " + cls.sTenhopdong.Value.ToString() + "";
            cancukehoac = "         Căn cứ kế hoạch và tiến độ thực hiện nhiệm vụ Kỹ thuật;\n         Phòng Đo lường - Thí nghiệm kính đề nghị Viện trưởng Viện KT cơ giới quân sự phê duyệt Kế hoạch Hội thảo thông qua quy trình "+cls.sTenhopdong.Value+"";

            pToTrinh.Value = tentotrinh;
            pCanCuHopDong.Value = cancuhopdong;
            pCanCuKeHoach.Value = cancukehoac;
            pNgayThang.Value = "Hà Nội, ngày "+ ngaythang.ToString("dd")+ " tháng " + ngaythang.ToString("MM") + " năm " + ngaythang.ToString("yyyy") + "";
        }
    }
}
