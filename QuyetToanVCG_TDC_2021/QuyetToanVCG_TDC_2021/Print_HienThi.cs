using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuyetToanVCG_TDC_2021
{
    public partial class Print_HienThi : Form
    {
        int mi_id_STT, mid_hopdong;
        DateTime mdangaythang;
        public Print_HienThi(int xid_stt, int id_hopdongxxx, DateTime xngaythang )
        {
            InitializeComponent();
            mi_id_STT = xid_stt;
            mid_hopdong = id_hopdongxxx;
            mdangaythang = xngaythang;
        }
        private void _1_Print_BangKeChungTuChiTieu()
        {
            clsTbBangKe cls = new clsTbBangKe();
            DataTable dt3 = cls.SelectAll();
            double xtongtien__= Convert.ToDouble(dt3.Compute("SUM(sotien)", string.Empty));
           
            _1_BangKeChungTuChiTieu xtr111 = new _1_BangKeChungTuChiTieu(xtongtien__, mid_hopdong);
         
            DataSet_TDC ds = new DataSet_TDC();
            ds.tbBangKeHoaDon.Clone();
            ds.tbBangKeHoaDon.Clear();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                DataRow _ravi = ds.tbBangKeHoaDon.NewRow();
                _ravi["STT"] = (i + 1).ToString();              
                _ravi["diengiai"] = dt3.Rows[i]["diengiai"].ToString();
                _ravi["ngayhoadon"] =Convert.ToDateTime(dt3.Rows[i]["ngayhoadon"].ToString());
                _ravi["sohoadon"] = dt3.Rows[i]["sohoadon"].ToString();
                _ravi["sotien"] = CheckString.ConvertToDouble_My(dt3.Rows[i]["sotien"].ToString());
                ds.tbBangKeHoaDon.Rows.Add(_ravi);
            }
            xtr111.DataSource = null;
            xtr111.DataSource = ds.tbBangKeHoaDon;
            xtr111.DataMember = "tbBangKeHoaDon";          
            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;

        }

        private void _2_GiayThanhToanTamUng()
        {
            clsTbBangKe cls = new clsTbBangKe();
            DataTable dt3 = cls.SelectAll();
            double xtongtien__ = Convert.ToDouble(dt3.Compute("SUM(sotien)", string.Empty));

            _2_GiayThanhToanTamUng xtr111 = new _2_GiayThanhToanTamUng(xtongtien__);
           

            DataSet_TDC ds = new DataSet_TDC();
            ds.tbBangKeHoaDon.Clone();
            ds.tbBangKeHoaDon.Clear();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                DataRow _ravi = ds.tbBangKeHoaDon.NewRow();
                _ravi["STT"] = (i + 1).ToString();
                
                string sxdiengiai= dt3.Rows[i]["diengiai"].ToString();
                string sohoadon = dt3.Rows[i]["sohoadon"].ToString();
                DateTime ngayxx= Convert.ToDateTime(dt3.Rows[i]["ngayhoadon"].ToString());
                bool xdscaptien= Convert.ToBoolean(dt3.Rows[i]["DanhSachCapTien"].ToString());
                _ravi["sotien"] = CheckString.ConvertToDouble_My(dt3.Rows[i]["sotien"].ToString());
                if (xdscaptien == true)
                    _ravi["diengiai"] = "Danh sách cấp tiền ngày "+ ngayxx.ToString("dd/MM/yyyy")+ " ";
                else _ravi["diengiai"] = "Hoá đơn mua hàng số "+sohoadon+" ngày " + ngayxx.ToString("dd/MM/yyyy") + " ";

                ds.tbBangKeHoaDon.Rows.Add(_ravi);
            }
            xtr111.DataSource = null;
            xtr111.DataSource = ds.tbBangKeHoaDon;
            xtr111.DataMember = "tbBangKeHoaDon";
            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;


        }
        private void _5_KeHoach_hoiThao_1()
        {
            _5_KeHoachHoiThao_1_ThongQuaQuyTrinh xtr111 = new _5_KeHoachHoiThao_1_ThongQuaQuyTrinh(mid_hopdong);
         
            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;

        }

        private void _6_PhuLuc_KeHoach_hoiThao_1()
        {
            _6_PhuLucKeHoachHoiThao_1 xtr111 = new _6_PhuLucKeHoachHoiThao_1(mid_hopdong);
            clsDaTa cls = new clsDaTa();
            DataTable dt3 = cls.tbHoiThao_SA_ID_HD(mid_hopdong);
        

            DataSet_TDC ds = new DataSet_TDC();
            ds.tbHoiThao.Clone();
            ds.tbHoiThao.Clear();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                DataRow _ravi = ds.tbHoiThao.NewRow();
                _ravi["STT"] = (i + 1).ToString();
                _ravi["HoTen"] = dt3.Rows[i]["hoten_phuluchoithao"].ToString();
                if (dt3.Rows[i]["tenchucvu"].ToString() == "Trợ lý KHQS")
                    _ravi["ChucVu"] = "Trợ lý KHQS";
                else _ravi["ChucVu"] = dt3.Rows[i]["chucvu_phuluchoithao"].ToString();
                _ravi["CuongVi"] = dt3.Rows[i]["tenchucdanh"].ToString();
                ds.tbHoiThao.Rows.Add(_ravi);
            }
            xtr111.DataSource = null;
            xtr111.DataSource = ds.tbHoiThao;
            xtr111.DataMember = "tbHoiThao";
            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;

        }
        private void _7_DanhSachBoiDuong_HoiThao_1()
        {
           
           

          
            clsDaTa cls = new clsDaTa();
            DataTable dt3 = cls.tbHoiThao_SA_ID_HD(mid_hopdong);
            double xtongtien__ = Convert.ToDouble(dt3.Compute("SUM(dinhmucsotien)", string.Empty));

            _7_DanhSachBoiDuong_HoiThao_1 xtr111 = new _7_DanhSachBoiDuong_HoiThao_1(xtongtien__,mid_hopdong,mdangaythang);

            DataSet_TDC ds = new DataSet_TDC();
            ds.tbHoiThao.Clone();
            ds.tbHoiThao.Clear();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                DataRow _ravi = ds.tbHoiThao.NewRow();
                _ravi["STT"] = (i + 1).ToString();
                _ravi["HoTen"] = dt3.Rows[i]["hoten_phuluchoithao"].ToString();
                if (dt3.Rows[i]["tenchucvu"].ToString() == "Trợ lý KHQS")
                    _ravi["ChucVu"] = "Trợ lý KHQS";
                else _ravi["ChucVu"] = dt3.Rows[i]["chucvu_phuluchoithao"].ToString();
                _ravi["CuongVi"] = dt3.Rows[i]["tenchucdanh"].ToString();
                ds.tbHoiThao.Rows.Add(_ravi);
            }
            xtr111.DataSource = null;
            xtr111.DataSource = ds.tbHoiThao;
            xtr111.DataMember = "tbHoiThao";
            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;

        }
        //
        private void Print_____()
        {
            if (mi_id_STT == 1) _1_Print_BangKeChungTuChiTieu();
            else if (mi_id_STT == 2) _2_GiayThanhToanTamUng();
            else if (mi_id_STT == 5) _5_KeHoach_hoiThao_1();
            else if (mi_id_STT == 6) _6_PhuLuc_KeHoach_hoiThao_1();
        }
        private void Print_HienThi_Load(object sender, EventArgs e)
        {
            Print_____();
        }
    }
}
