using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QuyetToanVCG_TDC_2021
{
	public class clsTbhopdong : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTonTai, m_bKhoa;
			private SqlDateTime		m_daNgayhopdong;
			private SqlDouble		m_fSotien;
			private SqlInt32		m_iId_hopdong;
			private SqlString		m_sSohopdong, m_sGhiChu, m_sTenhopdong;
		#endregion


		public clsTbhopdong()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbhopdong_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@stenhopdong", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenhopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dangayhopdong", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayhopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ssohopdong", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSohopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fsotien", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSotien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sGhiChu", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhiChu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bKhoa", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bKhoa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iId_hopdong = (SqlInt32)scmCmdToExecute.Parameters["@iid_hopdong"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbhopdong::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbhopdong_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@stenhopdong", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenhopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dangayhopdong", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayhopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ssohopdong", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSohopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fsotien", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSotien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sGhiChu", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhiChu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bKhoa", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bKhoa));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbhopdong::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbhopdong_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbhopdong::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbhopdong_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbhopdong");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iId_hopdong = (Int32)dtToReturn.Rows[0]["id_hopdong"];
					m_sTenhopdong = (string)dtToReturn.Rows[0]["tenhopdong"];
					m_daNgayhopdong = (DateTime)dtToReturn.Rows[0]["ngayhopdong"];
					m_sSohopdong = (string)dtToReturn.Rows[0]["sohopdong"];
					m_fSotien = (double)dtToReturn.Rows[0]["sotien"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
					m_sGhiChu = (string)dtToReturn.Rows[0]["GhiChu"];
					m_bKhoa = (bool)dtToReturn.Rows[0]["Khoa"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbhopdong::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbhopdong_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbhopdong");
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
				throw new Exception("clsTbhopdong::SelectAll::Error occured.", ex);
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


		public SqlString sTenhopdong
		{
			get
			{
				return m_sTenhopdong;
			}
			set
			{
				SqlString sTenhopdongTmp = (SqlString)value;
				if(sTenhopdongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sTenhopdong", "sTenhopdong can't be NULL");
				}
				m_sTenhopdong = value;
			}
		}


		public SqlDateTime daNgayhopdong
		{
			get
			{
				return m_daNgayhopdong;
			}
			set
			{
				SqlDateTime daNgayhopdongTmp = (SqlDateTime)value;
				if(daNgayhopdongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("daNgayhopdong", "daNgayhopdong can't be NULL");
				}
				m_daNgayhopdong = value;
			}
		}


		public SqlString sSohopdong
		{
			get
			{
				return m_sSohopdong;
			}
			set
			{
				SqlString sSohopdongTmp = (SqlString)value;
				if(sSohopdongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sSohopdong", "sSohopdong can't be NULL");
				}
				m_sSohopdong = value;
			}
		}


		public SqlDouble fSotien
		{
			get
			{
				return m_fSotien;
			}
			set
			{
				SqlDouble fSotienTmp = (SqlDouble)value;
				if(fSotienTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fSotien", "fSotien can't be NULL");
				}
				m_fSotien = value;
			}
		}


		public SqlBoolean bTonTai
		{
			get
			{
				return m_bTonTai;
			}
			set
			{
				SqlBoolean bTonTaiTmp = (SqlBoolean)value;
				if(bTonTaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bTonTai", "bTonTai can't be NULL");
				}
				m_bTonTai = value;
			}
		}


		public SqlString sGhiChu
		{
			get
			{
				return m_sGhiChu;
			}
			set
			{
				SqlString sGhiChuTmp = (SqlString)value;
				if(sGhiChuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sGhiChu", "sGhiChu can't be NULL");
				}
				m_sGhiChu = value;
			}
		}


		public SqlBoolean bKhoa
		{
			get
			{
				return m_bKhoa;
			}
			set
			{
				SqlBoolean bKhoaTmp = (SqlBoolean)value;
				if(bKhoaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bKhoa", "bKhoa can't be NULL");
				}
				m_bKhoa = value;
			}
		}
		#endregion
	}
}
