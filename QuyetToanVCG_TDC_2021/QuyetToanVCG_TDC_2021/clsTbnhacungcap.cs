using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QuyetToanVCG_TDC_2021
{
	public class clsTbnhacungcap : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bKhoa;
			private SqlInt32		m_iId_nhacungcap;
			private SqlString		m_sMasothue, m_sDiachi, m_sTennhacungcap, m_sNguoibaogia;
		#endregion


		public clsTbnhacungcap()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbnhacungcap_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@stennhacungcap", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTennhacungcap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@snguoibaogia", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNguoibaogia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sdiachi", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDiachi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bkhoa", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bKhoa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@smasothue", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMasothue));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhacungcap", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhacungcap));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iId_nhacungcap = (SqlInt32)scmCmdToExecute.Parameters["@iid_nhacungcap"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbnhacungcap::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbnhacungcap_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhacungcap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhacungcap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@stennhacungcap", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTennhacungcap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@snguoibaogia", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNguoibaogia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sdiachi", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDiachi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bkhoa", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bKhoa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@smasothue", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMasothue));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbnhacungcap::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbnhacungcap_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhacungcap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhacungcap));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbnhacungcap::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbnhacungcap_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbnhacungcap");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhacungcap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhacungcap));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iId_nhacungcap = (Int32)dtToReturn.Rows[0]["id_nhacungcap"];
					m_sTennhacungcap = (string)dtToReturn.Rows[0]["tennhacungcap"];
					m_sNguoibaogia = (string)dtToReturn.Rows[0]["nguoibaogia"];
					m_sDiachi = (string)dtToReturn.Rows[0]["diachi"];
					m_bKhoa = (bool)dtToReturn.Rows[0]["khoa"];
					m_sMasothue = (string)dtToReturn.Rows[0]["masothue"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbnhacungcap::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbnhacungcap_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbnhacungcap");
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
				throw new Exception("clsTbnhacungcap::SelectAll::Error occured.", ex);
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


		public SqlString sTennhacungcap
		{
			get
			{
				return m_sTennhacungcap;
			}
			set
			{
				SqlString sTennhacungcapTmp = (SqlString)value;
				if(sTennhacungcapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sTennhacungcap", "sTennhacungcap can't be NULL");
				}
				m_sTennhacungcap = value;
			}
		}


		public SqlString sNguoibaogia
		{
			get
			{
				return m_sNguoibaogia;
			}
			set
			{
				SqlString sNguoibaogiaTmp = (SqlString)value;
				if(sNguoibaogiaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sNguoibaogia", "sNguoibaogia can't be NULL");
				}
				m_sNguoibaogia = value;
			}
		}


		public SqlString sDiachi
		{
			get
			{
				return m_sDiachi;
			}
			set
			{
				SqlString sDiachiTmp = (SqlString)value;
				if(sDiachiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sDiachi", "sDiachi can't be NULL");
				}
				m_sDiachi = value;
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


		public SqlString sMasothue
		{
			get
			{
				return m_sMasothue;
			}
			set
			{
				SqlString sMasothueTmp = (SqlString)value;
				if(sMasothueTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sMasothue", "sMasothue can't be NULL");
				}
				m_sMasothue = value;
			}
		}
		#endregion
	}
}
