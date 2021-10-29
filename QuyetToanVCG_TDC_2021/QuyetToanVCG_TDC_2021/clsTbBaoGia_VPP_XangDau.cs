using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QuyetToanVCG_TDC_2021
{
	public class clsTbBaoGia_VPP_XangDau : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTontai;
			private SqlDouble		m_fThanhtien, m_fDongia, m_fSoluong;
			private SqlInt32		m_iVPP_1_XangDau_2, m_iId_nhacungcap, m_iId_hopdong, m_iId_baogia, m_iId_vthh;
		#endregion


		public clsTbBaoGia_VPP_XangDau()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbBaoGia_VPP_XangDau_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhacungcap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhacungcap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_vthh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_vthh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fsoluong", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSoluong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fdongia", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDongia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fthanhtien", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fThanhtien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@btontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTontai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iVPP_1_XangDau_2", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iVPP_1_XangDau_2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_baogia", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iId_baogia));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iId_baogia = (SqlInt32)scmCmdToExecute.Parameters["@iid_baogia"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbBaoGia_VPP_XangDau::Insert::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbBaoGia_VPP_XangDau_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_baogia", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_baogia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhacungcap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhacungcap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_vthh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_vthh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fsoluong", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSoluong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fdongia", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDongia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fthanhtien", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fThanhtien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@btontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTontai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iVPP_1_XangDau_2", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iVPP_1_XangDau_2));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbBaoGia_VPP_XangDau::Update::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbBaoGia_VPP_XangDau_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_baogia", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_baogia));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbBaoGia_VPP_XangDau::Delete::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbBaoGia_VPP_XangDau_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbBaoGia_VPP_XangDau");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_baogia", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_baogia));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iId_baogia = (Int32)dtToReturn.Rows[0]["id_baogia"];
					m_iId_hopdong = (Int32)dtToReturn.Rows[0]["id_hopdong"];
					m_iId_nhacungcap = (Int32)dtToReturn.Rows[0]["id_nhacungcap"];
					m_iId_vthh = (Int32)dtToReturn.Rows[0]["id_vthh"];
					m_fSoluong = (double)dtToReturn.Rows[0]["soluong"];
					m_fDongia = (double)dtToReturn.Rows[0]["dongia"];
					m_fThanhtien = (double)dtToReturn.Rows[0]["thanhtien"];
					m_bTontai = (bool)dtToReturn.Rows[0]["tontai"];
					m_iVPP_1_XangDau_2 = (Int32)dtToReturn.Rows[0]["VPP_1_XangDau_2"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbBaoGia_VPP_XangDau::SelectOne::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		public override DataTable SelectAll()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbBaoGia_VPP_XangDau_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbBaoGia_VPP_XangDau");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbBaoGia_VPP_XangDau::SelectAll::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		#region Class Property Declarations
		public SqlInt32 iId_baogia
		{
			get
			{
				return m_iId_baogia;
			}
			set
			{
				SqlInt32 iId_baogiaTmp = (SqlInt32)value;
				if(iId_baogiaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_baogia", "iId_baogia can't be NULL");
				}
				m_iId_baogia = value;
			}
		}


		public SqlInt32 iId_hopdong
		{
			get
			{
				return m_iId_hopdong;
			}
			set
			{
				SqlInt32 iId_hopdongTmp = (SqlInt32)value;
				if(iId_hopdongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_hopdong", "iId_hopdong can't be NULL");
				}
				m_iId_hopdong = value;
			}
		}


		public SqlInt32 iId_nhacungcap
		{
			get
			{
				return m_iId_nhacungcap;
			}
			set
			{
				SqlInt32 iId_nhacungcapTmp = (SqlInt32)value;
				if(iId_nhacungcapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_nhacungcap", "iId_nhacungcap can't be NULL");
				}
				m_iId_nhacungcap = value;
			}
		}


		public SqlInt32 iId_vthh
		{
			get
			{
				return m_iId_vthh;
			}
			set
			{
				SqlInt32 iId_vthhTmp = (SqlInt32)value;
				if(iId_vthhTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_vthh", "iId_vthh can't be NULL");
				}
				m_iId_vthh = value;
			}
		}


		public SqlDouble fSoluong
		{
			get
			{
				return m_fSoluong;
			}
			set
			{
				SqlDouble fSoluongTmp = (SqlDouble)value;
				if(fSoluongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fSoluong", "fSoluong can't be NULL");
				}
				m_fSoluong = value;
			}
		}


		public SqlDouble fDongia
		{
			get
			{
				return m_fDongia;
			}
			set
			{
				SqlDouble fDongiaTmp = (SqlDouble)value;
				if(fDongiaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fDongia", "fDongia can't be NULL");
				}
				m_fDongia = value;
			}
		}


		public SqlDouble fThanhtien
		{
			get
			{
				return m_fThanhtien;
			}
			set
			{
				SqlDouble fThanhtienTmp = (SqlDouble)value;
				if(fThanhtienTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fThanhtien", "fThanhtien can't be NULL");
				}
				m_fThanhtien = value;
			}
		}


		public SqlBoolean bTontai
		{
			get
			{
				return m_bTontai;
			}
			set
			{
				SqlBoolean bTontaiTmp = (SqlBoolean)value;
				if(bTontaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bTontai", "bTontai can't be NULL");
				}
				m_bTontai = value;
			}
		}


		public SqlInt32 iVPP_1_XangDau_2
		{
			get
			{
				return m_iVPP_1_XangDau_2;
			}
			set
			{
				SqlInt32 iVPP_1_XangDau_2Tmp = (SqlInt32)value;
				if(iVPP_1_XangDau_2Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iVPP_1_XangDau_2", "iVPP_1_XangDau_2 can't be NULL");
				}
				m_iVPP_1_XangDau_2 = value;
			}
		}
		#endregion
	}
}
