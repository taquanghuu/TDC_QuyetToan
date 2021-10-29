using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QuyetToanVCG_TDC_2021
{
	public class clsTbchucdanh : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlDouble		m_fDinhmucsotien;
			private SqlInt32		m_iId_chucdanh;
			private SqlString		m_sTenchucdanh;
		#endregion


		public clsTbchucdanh()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbchucdanh_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@stenchucdanh", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenchucdanh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fdinhmucsotien", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDinhmucsotien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_chucdanh", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iId_chucdanh));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iId_chucdanh = (SqlInt32)scmCmdToExecute.Parameters["@iid_chucdanh"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbchucdanh::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbchucdanh_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_chucdanh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_chucdanh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@stenchucdanh", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenchucdanh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fdinhmucsotien", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDinhmucsotien));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbchucdanh::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbchucdanh_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_chucdanh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_chucdanh));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbchucdanh::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbchucdanh_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbchucdanh");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_chucdanh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_chucdanh));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iId_chucdanh = (Int32)dtToReturn.Rows[0]["id_chucdanh"];
					m_sTenchucdanh = (string)dtToReturn.Rows[0]["tenchucdanh"];
					m_fDinhmucsotien = (double)dtToReturn.Rows[0]["dinhmucsotien"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbchucdanh::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbchucdanh_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbchucdanh");
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
				throw new Exception("clsTbchucdanh::SelectAll::Error occured.", ex);
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
		public SqlInt32 iId_chucdanh
		{
			get
			{
				return m_iId_chucdanh;
			}
			set
			{
				SqlInt32 iId_chucdanhTmp = (SqlInt32)value;
				if(iId_chucdanhTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_chucdanh", "iId_chucdanh can't be NULL");
				}
				m_iId_chucdanh = value;
			}
		}


		public SqlString sTenchucdanh
		{
			get
			{
				return m_sTenchucdanh;
			}
			set
			{
				SqlString sTenchucdanhTmp = (SqlString)value;
				if(sTenchucdanhTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sTenchucdanh", "sTenchucdanh can't be NULL");
				}
				m_sTenchucdanh = value;
			}
		}


		public SqlDouble fDinhmucsotien
		{
			get
			{
				return m_fDinhmucsotien;
			}
			set
			{
				SqlDouble fDinhmucsotienTmp = (SqlDouble)value;
				if(fDinhmucsotienTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fDinhmucsotien", "fDinhmucsotien can't be NULL");
				}
				m_fDinhmucsotien = value;
			}
		}
		#endregion
	}
}
