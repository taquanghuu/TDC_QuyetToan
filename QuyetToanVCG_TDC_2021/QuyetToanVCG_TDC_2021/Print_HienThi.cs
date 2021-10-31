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
                //if (dt3.Rows[i]["tenchucvu"].ToString() == "Trợ lý KHQS")
                //    _ravi["ChucVu"] = "Trợ lý KHQS -";
                //else _ravi["ChucVu"] = dt3.Rows[i]["chucvu_danhsachcaptien"].ToString();
                _ravi["ChucVu"] = dt3.Rows[i]["chucvu_danhsachcaptien"].ToString();
                _ravi["DinhMuc"] =Convert.ToDouble(dt3.Rows[i]["dinhmucsotien"].ToString());
                ds.tbHoiThao.Rows.Add(_ravi);
            }
            xtr111.DataSource = null;
            xtr111.DataSource = ds.tbHoiThao;
            xtr111.DataMember = "tbHoiThao";
            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;

        }

        private void _8_ToTrinh_hoiThao_1()
        {
            _8_ToTrinhPheDuyet_HoiThao_1 xtr111 = new _8_ToTrinhPheDuyet_HoiThao_1(mid_hopdong, mdangaythang);

            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;

        }

        private void _13_PrintPhuLuc_KeHoach_XangDau()
        {
            _13_PhuLucKeHoachSuDungXangDau xtr111 = new _13_PhuLucKeHoachSuDungXangDau(mdangaythang);
            clsDaTa cls = new clsDaTa();
            DataTable dt3 = cls.tbPhuLuc_XangDau_SA_ID_HD(mid_hopdong);
            
            DataSet_TDC ds = new DataSet_TDC();
            ds.tbXangDau.Clone();
            ds.tbXangDau.Clear();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                DataRow _ravi = ds.tbXangDau.NewRow();
                _ravi["STT"] = (i + 1).ToString();
                _ravi["ngay"] = Convert.ToDateTime(dt3.Rows[i]["ngay"].ToString());
                _ravi["donvitinh"] = dt3.Rows[i]["donvitinh"].ToString();
                _ravi["soluong"] =Convert.ToDouble(dt3.Rows[i]["soluong"].ToString());
                _ravi["noidung"] = dt3.Rows[i]["noidung"].ToString();
                ds.tbXangDau.Rows.Add(_ravi);
            }
            xtr111.DataSource = null;
            xtr111.DataSource = ds.tbXangDau;
            xtr111.DataMember = "tbXangDau";
            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;

        }

        private void _16_Print_PhieuGiaoNHanVTHH()
        {
            clsDaTa cls = new clsDaTa();
            DataTable dt3 = cls.tbXangDau_SA_ID_HD(mid_hopdong);
            double xtongtien__ = Convert.ToDouble(dt3.Compute("SUM(thanhtien)", string.Empty));
            _15_PhieuGiaoNhan_Xang xtr111 = new _15_PhieuGiaoNhan_Xang(mdangaythang, xtongtien__);

       
            DataSet_TDC ds = new DataSet_TDC();
            ds.tbvthh.Clone();
            ds.tbvthh.Clear();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                DataRow _ravi = ds.tbvthh.NewRow();
                _ravi["STT"] = (i + 1).ToString();
                _ravi["tenvthh"] = dt3.Rows[i]["tenvthh"].ToString();
                _ravi["donvitinh"] = dt3.Rows[i]["donvitinh"].ToString();
                _ravi["soluong"] = Convert.ToDouble(dt3.Rows[i]["soluong"].ToString());
                _ravi["dongia"] = Convert.ToDouble(dt3.Rows[i]["dongia"].ToString());
                _ravi["thanhtien"] = Convert.ToDouble(dt3.Rows[i]["thanhtien"].ToString());
                ds.tbvthh.Rows.Add(_ravi);
            }
            xtr111.DataSource = null;
            xtr111.DataSource = ds.tbvthh;
            xtr111.DataMember = "tbvthh";
            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;

        }
        private void Print_____()
        {
            if (mi_id_STT == 1) _1_Print_BangKeChungTuChiTieu();
            else if (mi_id_STT == 2) _2_GiayThanhToanTamUng();
            else if (mi_id_STT == 5) _5_KeHoach_hoiThao_1();
            else if (mi_id_STT == 6) _6_PhuLuc_KeHoach_hoiThao_1();
            else if (mi_id_STT == 7) _7_DanhSachBoiDuong_HoiThao_1();
            else if (mi_id_STT == 8) _8_ToTrinh_hoiThao_1();
            else if (mi_id_STT == 13) _13_PrintPhuLuc_KeHoach_XangDau();
            else if (mi_id_STT == 16) _16_Print_PhieuGiaoNHanVTHH();
        }
        private void Print_HienThi_Load(object sender, EventArgs e)
        {
            Print_____();
        }
    }
}
