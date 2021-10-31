using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuyetToanVCG_TDC_2021
{
    public partial class clsDaTa : clsDBInteractionBase
    {
        public DataTable tbvthh_SO_TenVTHH(string xtenvthh)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbvthh_SO_TenVTHH]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbvthh_SO_TenVTHH");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                scmCmdToExecute.Parameters.Add(new SqlParameter("@_tenvthh", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, xtenvthh));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbvthh_SO_TenVTHH", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable tbPhuLuc_XangDau_SA_ID_HD(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbPhuLuc_XangDau_SA_ID_HD]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbPhuLuc_XangDau_SA_ID_HD");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbPhuLuc_XangDau_SA_ID_HD", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable tbngaythang_SA_Print(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbngaythang_SA_Print]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbngaythang_SA_Print");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbngaythang_SA_Print", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_TrungThau(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_TrungThau]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_TrungThau");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_TrungThau", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu2(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu2]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu2");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu2", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu3(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu3]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu3");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Tbbaogia_DanhSach_NCC_Cho_SA_ID_HD_Phu3", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public void tbBangKe_update_all_tontai_W_id_hd(int xid_hopdong, bool xontai)
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbBangKe_update_all_tontai_W_id_hd]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
               
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_tontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, xontai));
              
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbBangKe_update_all_tontai_W_id_hd::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public DataTable tbBangKe_SA_ID_HD_TonTai_False(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbBangKe_SA_ID_HD_TonTai_False]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbBangKe_SA_ID_HD_TonTai_False");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbBangKe_SA_ID_HD_TonTai_False", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public void tbbaogia_update_all_tontai_W_id_hd(int xid_hopdong, bool xontai)
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbbaogia_update_all_tontai_W_id_hd]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {

                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_tontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, xontai));

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbbaogia_update_all_tontai_W_id_hd::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public DataTable tbbaogia_SA_ID_HD_TonTai_False(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbbaogia_SA_ID_HD_TonTai_False]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbbaogia_SA_ID_HD_TonTai_False");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbBangKe_SA_ID_HD_TonTai_False", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public void tbbaogia_VPP_update_all_tontai_W_id_hd(int xid_hopdong, bool xontai)
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbbaogia_VPP_update_all_tontai_W_id_hd]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {

                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_tontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, xontai));

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbbaogia_VPP_update_all_tontai_W_id_hd::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public DataTable tbbaogia_VPP_SA_ID_HD_TonTai_False(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbbaogia_VPP_SA_ID_HD_TonTai_False]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbbaogia_VPP_SA_ID_HD_TonTai_False");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbbaogia_VPP_SA_ID_HD_TonTai_False", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public void tbbaogia_XangDau_update_all_tontai_W_id_hd(int xid_hopdong, bool xontai)
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbbaogia_XangDau_update_all_tontai_W_id_hd]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {

                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_tontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, xontai));

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbbaogia_XangDau_update_all_tontai_W_id_hd::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public DataTable tbbaogia_XangDau_SA_ID_HD_TonTai_False(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbbaogia_XangDau_SA_ID_HD_TonTai_False]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbbaogia_XangDau_SA_ID_HD_TonTai_False");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbbaogia_XangDau_SA_ID_HD_TonTai_False", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public void tbHoiThao_update_all_tontai_W_id_hd(int xid_hopdong, bool xontai)
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbHoiThao_update_all_tontai_W_id_hd]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {

                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_tontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, xontai));

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbHoiThao_update_all_tontai_W_id_hd::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }

        public void tbngaythang_update_all_tontai_W_id_hd(int xid_hopdong, bool xontai)
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbngaythang_update_all_tontai_W_id_hd]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {

                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_tontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, xontai));

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbngaythang_update_all_tontai_W_id_hd::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }

        public DataTable tbNhanSu_SA_HienThi()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbNhanSu_SA_HienThi]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbNhanSu_SA_HienThi");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbNhanSu_SA_HienThi", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable tbNgayThang_SA_ID_HD(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbNgayThang_SA_ID_HD]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbNgayThang_SA_ID_HD");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbNgayThang_SA_ID_HD", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable tbNgayThang_SA_ID_HD_and_id_the_stt(int xid_hopdong_, int xid_the_stt_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbNgayThang_SA_ID_HD_and_id_the_stt]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbNgayThang_SA_ID_HD_and_id_the_stt");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_the_stt_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_the_stt_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbNgayThang_SA_ID_HD_and_id_the_stt", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable tbngaythang_SA_ID_HD_TonTai_False(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbngaythang_SA_ID_HD_TonTai_False]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbngaythang_SA_ID_HD_TonTai_False");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbngaythang_SA_ID_HD_TonTai_False", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable tbHoiThao_SA_ID_HD(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbHoiThao_SA_ID_HD]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbHoiThao_SA_ID_HD");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbHoiThao_SA_ID_HD", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public DataTable tbHoiThao_SA_ID_HD_TonTai_False(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbHoiThao_SA_ID_HD_TonTai_False]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbHoiThao_SA_ID_HD_TonTai_False");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbHoiThao_SA_ID_HD_TonTai_False", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable tbBangKe_SA_ID_HD(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbBangKe_SA_ID_HD]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbBangKe_SA_ID_HD");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbBangKe_SA_ID_HD", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

       
        public DataTable tbbaogia_SA_id_HD(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbbaogia_SA_id_HD]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbbaogia_SA_id_HD");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbbaogia_SA_id_HD", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public DataTable tbVPP_SA_ID_HD(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbVPP_SA_ID_HD]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbVPP_SA_ID_HD");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbVPP_SA_ID_HD", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public DataTable tbXangDau_SA_ID_HD(int xid_hopdong_)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[tbXangDau_SA_ID_HD]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbXangDau_SA_ID_HD");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@_id_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_hopdong_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbXangDau_SA_ID_HD", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
    }
}
