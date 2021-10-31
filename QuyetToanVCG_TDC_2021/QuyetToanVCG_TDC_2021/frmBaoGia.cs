using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuyetToanVCG_TDC_2021
{
    public partial class frmBaoGia : Form
    {
        int mid_hopdong_; bool mbthemmoi; double msotien_;
        public frmBaoGia(int xid_hopdong_, bool xthemoi_, double xsotien_)
        {
            mid_hopdong_ = xid_hopdong_;
            mbthemmoi = xthemoi_;
            msotien_ = xsotien_;
            InitializeComponent();
           
        }
        private void Luu_DanhSach_NCC_BaoGia_Cho()
        {
            clsTbbaogia_DanhSach_NCC_Cho cls = new clsTbbaogia_DanhSach_NCC_Cho();
            cls.iId_hopdong = mid_hopdong_;
            cls.iId_nhacungcap = Convert.ToInt32(gridtrungthaucho.EditValue.ToString());
            cls.iTrungthau_1_Phu_2_Phu_3 = 1;

            clsDaTa cls2 = new clsDaTa();
            DataTable dt2 = cls2.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_TrungThau(mid_hopdong_);
            if (dt2.Rows.Count > 0)
            {
                int id___ = Convert.ToInt32(dt2.Rows[0][0].ToString());
                cls.iId_baogia_danhsach = id___;
                cls.Update();
            }
            else cls.Insert();

            cls = new clsTbbaogia_DanhSach_NCC_Cho();
            cls.iId_hopdong = mid_hopdong_;
            cls.iId_nhacungcap = Convert.ToInt32(gridthauphu2.EditValue.ToString());
            cls.iTrungthau_1_Phu_2_Phu_3 = 2;
            DataTable dt3 = cls2.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu2(mid_hopdong_);
            if (dt3.Rows.Count > 0)
            {
                int id___ = Convert.ToInt32(dt3.Rows[0][0].ToString());
                cls.iId_baogia_danhsach = id___;
                cls.Update();
            }
            else cls.Insert();

            cls = new clsTbbaogia_DanhSach_NCC_Cho();
            cls.iId_hopdong = mid_hopdong_;
            cls.iId_nhacungcap = Convert.ToInt32(gridthauphu2.EditValue.ToString());
            cls.iTrungthau_1_Phu_2_Phu_3 = 3;
            DataTable dt4 = cls2.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu3(mid_hopdong_);
            if (dt4.Rows.Count > 0)
            {
                int id___ = Convert.ToInt32(dt4.Rows[0][0].ToString());
                cls.iId_baogia_danhsach = id___;
                cls.Update();
            }
            else cls.Insert();
        }
        private void Luu_duLieu_BaoGia_Cho()
        {
            clsDaTa cls = new clsDaTa();
            cls.tbbaogia_update_all_tontai_W_id_hd(mid_hopdong_, false);

            clsTbbaogia cls2 = new clsTbbaogia();


            DataTable dt2 = (DataTable)gridControl_Cho.DataSource;
            if (dt2 != null)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    cls2.iId_hopdong = mid_hopdong_;
                    //cls2.iId_nhacungcap = Convert.ToInt32(gridtrungthaucho.EditValue.ToString());
                    cls2.iId_vthh = Convert.ToInt32(dt2.Rows[i]["id_vthh"].ToString());
                    cls2.fSoluong= Convert.ToDouble(dt2.Rows[i]["soluong"].ToString());
                    cls2.fDongia1 = Convert.ToDouble(dt2.Rows[i]["dongia1"].ToString());
                    cls2.fThanhtien1 = Convert.ToDouble(dt2.Rows[i]["thanhtien1"].ToString());
                    cls2.fDongia2 = Convert.ToDouble(dt2.Rows[i]["dongia2"].ToString());
                    cls2.fThanhtien2 = Convert.ToDouble(dt2.Rows[i]["thanhtien2"].ToString());
                    cls2.fDongia3 = Convert.ToDouble(dt2.Rows[i]["dongia3"].ToString());
                    cls2.fThanhtien3 = Convert.ToDouble(dt2.Rows[i]["thanhtien3"].ToString());                 
                    cls2.bTontai = true;                    
                    if (dt2.Rows[i]["id_baogia"].ToString() == "")
                        cls2.Insert();
                    else
                    {
                        cls2.iId_baogia = Convert.ToInt32(dt2.Rows[i]["id_baogia"].ToString());
                        cls2.Update();
                    }
                }
                // xoá tồn tại = false
                DataTable dtmoi_false = cls.tbbaogia_SA_ID_HD_TonTai_False(mid_hopdong_);
                if (dtmoi_false.Rows.Count > 0)
                {
                    for (int i = 0; i < dtmoi_false.Rows.Count; i++)
                    {
                        cls2.iId_baogia = Convert.ToInt32(dtmoi_false.Rows[i]["id_baogia"].ToString()); ;
                        cls2.Delete();
                    }
                }
            }
        }
              

        private void Luu_DuLieu()
        {
            Luu_DanhSach_NCC_BaoGia_Cho();
            Luu_duLieu_BaoGia_Cho();           
            MessageBox.Show("Đã lưu");
            Load_DaTa();
        }
        private void Load_lockup()
        {
            clsTbnhacungcap cls = new clsTbnhacungcap();
            DataTable dt = cls.SelectAll();
            gridtrungthaucho.Properties.DataSource = dt;
            gridtrungthaucho.Properties.DisplayMember = "tennhacungcap";
            gridtrungthaucho.Properties.ValueMember = "id_nhacungcap";
            //gridthauphu3
            gridthauphu2.Properties.DataSource = dt;
            gridthauphu2.Properties.DisplayMember = "tennhacungcap";
            gridthauphu2.Properties.ValueMember = "id_nhacungcap";

            gridthauphu3.Properties.DataSource = dt;
            gridthauphu3.Properties.DisplayMember = "tennhacungcap";
            gridthauphu3.Properties.ValueMember = "id_nhacungcap";


            clsTbvthh cls2 = new clsTbvthh();
            DataTable dt2 = cls2.SelectAll();
            search_mahang_cho.DataSource = dt2;
            search_mahang_cho.DisplayMember = "tenvthh";
            search_mahang_cho.ValueMember = "id_vthh";

        
        }

        private void Load_DaTa()
        {
            txtSoTien.Text = msotien_.ToString();

            clsDaTa cls = new clsDaTa();
            DataTable dt1 = cls.tbbaogia_SA_id_HD(mid_hopdong_);
            gridControl_Cho.DataSource = dt1;


          
            DataTable dt4 = cls.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_TrungThau(mid_hopdong_);
            if (dt4.Rows.Count > 0)
            {
                gridtrungthaucho.EditValue = Convert.ToInt32(dt4.Rows[0]["id_nhacungcap"].ToString());
            }
            DataTable dt5 = cls.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu2(mid_hopdong_);
            if (dt5.Rows.Count > 0)
            {
                gridthauphu2.EditValue = Convert.ToInt32(dt5.Rows[0]["id_nhacungcap"].ToString());
            }
            DataTable dt6 = cls.Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu3(mid_hopdong_);
            if (dt6.Rows.Count > 0)
            {
                gridthauphu3.EditValue = Convert.ToInt32(dt6.Rows[0]["id_nhacungcap"].ToString());
            }
        }
        private void frmBaoGia_Load(object sender, EventArgs e)
        {
            Load_lockup();
            Load_DaTa();
            cldongia1.Caption = "Đơn\ngiá 1";
            clthanhtien1.Caption = "Thành\ntiền 1";
            cldongia2.Caption = "Đơn\ngiá 2";
            clthanhtien2.Caption = "Thành\ntiền 2";
            cldongia3.Caption = "Đơn\ngiá 3";
            clthanhtien3.Caption = "Thành\ntiền 3";
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtSoTien.Text);
                //txtSoTien.Text = String.Format("{0:#,##0.00}", value);
                txtSoTien.Text = value.ToString("N2");

            }
            catch
            {

            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            Luu_DuLieu();
        }

        private void gridControl_Cho_Click(object sender, EventArgs e)
        {

        }

        private void gridView_Cho_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                double soluong__ = 0;
                double dongia_1_ = 0;
                double thanhtien_1_ = 0;

                
                double dongia_2_ = 0;
                double thanhtien_2_ = 0;

               
                double dongia_3_ = 0;
                double thanhtien_3_ = 0;
                if (e.Column == clsoluong)
                {
                    dongia_1_ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(cldongia1));
                    soluong__ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(clsoluong));
                    thanhtien_1_ = soluong__ * dongia_1_;
                    gridView_Cho.SetFocusedRowCellValue(clthanhtien1, thanhtien_1_);
                }
                if (e.Column == cldongia1)
                {
                    dongia_1_ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(cldongia1));
                    soluong__ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(clsoluong));
                    thanhtien_1_ = soluong__ * dongia_1_;
                    gridView_Cho.SetFocusedRowCellValue(clthanhtien1, thanhtien_1_);
                }
             
                if (e.Column == cldongia2)
                {
                    dongia_2_ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(cldongia2));
                    soluong__ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(clsoluong));
                    thanhtien_2_ = soluong__ * dongia_2_;
                    gridView_Cho.SetFocusedRowCellValue(clthanhtien2, thanhtien_2_);
                }
               
                if (e.Column == cldongia3)
                {
                    dongia_3_ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(cldongia3));
                    soluong__ = CheckString.ConvertToDouble_My(gridView_Cho.GetFocusedRowCellValue(clsoluong));
                    thanhtien_3_ = soluong__ * dongia_3_;
                    gridView_Cho.SetFocusedRowCellValue(clthanhtien3, thanhtien_3_);
                }
            }
            catch
            {

            }
        }

   
        private void gridView_Cho_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT1)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

      

        private void btPrint_Click(object sender, EventArgs e)
        {
            frmPrint ff = new frmPrint(mid_hopdong_);
            ff.Show();
        }
        private void insert_vthh()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "File (*.xls)|*.xls";
            f.Multiselect = false;
            f.Title = "Chon CSDL";
            // f.InitialDirectory = @"Local\Libraries\Documents\QLKH:";
            if (f.ShowDialog() == DialogResult.OK)
            {
                clsTbvthh cls = new clsTbvthh();

                OleDbConnection con = new OleDbConnection();
                string Tenfile_Execl;
                DataTable dt = new DataTable();
                DataTable dtNganhang = new DataTable();
                Tenfile_Execl = f.FileName;
                string str_con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Tenfile_Execl + ";Extended Properties=Excel 8.0";
                con = new OleDbConnection(str_con);
                con.Open();


                OleDbDataAdapter adapter = new OleDbDataAdapter();
                string str_adapter = "Select * from [Sheet1$]";
                adapter = new OleDbDataAdapter(str_adapter, con);
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cls.sTenvthh = dt.Rows[i][0].ToString();
                    cls.sDonvitinh = dt.Rows[i][1].ToString();
                    cls.bKhoa = true;
                    cls.Insert();
                }
                MessageBox.Show("đã xong");
            }
        }
        private void btExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "File (*.xls)|*.xls";
            f.Multiselect = false;
            f.Title = "Chon CSDL";
            // f.InitialDirectory = @"Local\Libraries\Documents\QLKH:";
            if (f.ShowDialog() == DialogResult.OK)
            {
                

                OleDbConnection con = new OleDbConnection();
                string Tenfile_Execl;
                DataTable dt = new DataTable();
                DataTable dtNganhang = new DataTable();
                Tenfile_Execl = f.FileName;
                string str_con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Tenfile_Execl + ";Extended Properties=Excel 8.0";
                con = new OleDbConnection(str_con);
                con.Open();


                OleDbDataAdapter adapter = new OleDbDataAdapter();
                string str_adapter = "Select * from [Sheet1$]";
                adapter = new OleDbDataAdapter(str_adapter, con);
                adapter.Fill(dt);
                DataTable dt2 = new DataTable();

                dt2.Columns.Add("id_vthh", typeof(int));
                dt2.Columns.Add("soluong", typeof(int));
                dt2.Columns.Add("dongia1", typeof(double));
                dt2.Columns.Add("thanhtien1", typeof(double));

                dt2.Columns.Add("dongia2", typeof(double));
                dt2.Columns.Add("thanhtien2", typeof(double));

                dt2.Columns.Add("dongia3", typeof(double));
                dt2.Columns.Add("thanhtien3", typeof(double));

           
                clsTbvthh cls1 = new clsTbvthh();
                clsDaTa cls2 = new clsDaTa();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int id_vthh__;
                    string tenvthhxxx= dt.Rows[i][0].ToString().Trim();
                    DataTable dtvthhh = cls2.tbvthh_SO_TenVTHH(tenvthhxxx);
                    if(dtvthhh.Rows.Count>0)
                    {
                        id_vthh__ = Convert.ToInt32(dtvthhh.Rows[0]["id_vthh"].ToString());
                    }
                    else
                    {
                        cls1.sTenvthh = dt.Rows[i][0].ToString();
                        cls1.sDonvitinh = dt.Rows[i][1].ToString();
                        cls1.bKhoa = true;
                        cls1.Insert();
                        id_vthh__ = cls1.iId_vthh.Value;
                    }
                    DataRow _ravi = dt2.NewRow();
                    _ravi["id_vthh"] = id_vthh__;
                    _ravi["soluong"] = 1;
                    _ravi["dongia1"] = 0;
                    _ravi["thanhtien1"] = 0;
                    _ravi["dongia2"] = 0;
                    _ravi["thanhtien2"] = 0;
                    _ravi["dongia3"] = 0;
                    _ravi["thanhtien3"] = 0;
                    
                    dt2.Rows.Add(_ravi);
                  
                }
                gridControl_Cho.DataSource = dt2;
            }
        }
    
        private void search_mahang_cho_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    DataRow row = ((DataRowView)((SearchLookUpEdit)sender).GetSelectedDataRow()).Row;
            //    id_vthh_cho = CheckString.ConvertTo_Int_My(row["id_vthh"].ToString());
            //    tenvthh_cho = row["tenvthh"].ToString();
            //    dvt_vthh_cho = row["donvitinh"].ToString();
            //}
            //catch (Exception ea)
            //{
            //    MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
