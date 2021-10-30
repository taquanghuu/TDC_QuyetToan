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
    public partial class frmPrint : Form
    {
        int mid_hopdong_;
        public frmPrint(int xid_hd)
        {
            mid_hopdong_ = xid_hd;
            InitializeComponent();
        }
        private void Print_MuaVatTu()
        {
          

            Dictionary<string, string> dic = new Dictionary<string, string>();
     
            //dic.Add("TenGoiThau", msTenGoiThau);//
            //dic.Add("HopDongNguon", msHopDongNguon);//
            //dic.Add("DonViChuQuan", msDonViChuQuan);//            //
            //dic.Add("SoTien", msSoTien);//
            //dic.Add("msSoTienBangChu", msSoTienBangChu);//

        
            
                WordUltil wd = new WordUltil(@"C:\Users\Public\Documents\DATA_TDC\_8_ToTrinhPheDuyetHoiThao1.dot", true);
                wd.WriteFields(dic);
            
            MessageBox.Show("Đã xong");
        }


        private void btPrint1_Click(object sender, EventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue(clid_ngaythang).ToString()!="")
            {
               DateTime xngay= Convert.ToDateTime(gridView1.GetFocusedRowCellValue(clngaythang).ToString());
                int xid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid_the_STT).ToString());
                Print_HienThi ff = new Print_HienThi(xid, mid_hopdong_, xngay);
                ff.Show();
            }
           
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            clsDaTa cls = new clsDaTa();
            DataTable dt = cls.tbngaythang_SA_Print(mid_hopdong_);
            gridControl1.DataSource = dt;
        }
    }
}
