using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QuyetToanVCG_TDC_2021
{
	public class clsTbvthh : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bKhoa;
			private SqlInt32		m_iId_vthh;
			private SqlString		m_sTenvthh, m_sDonvitinh;
		#endregion


		public clsTbvthh()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbvthh_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@stenvthh", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenvthh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sdonvitinh", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDonvitinh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bkhoa", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bKhoa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_vthh", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iId_vthh));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iId_vthh = (SqlInt32)scmCmdToExecute.Parameters["@iid_vthh"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbvthh::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbvthh_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_vthh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_vthh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@stenvthh", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenvthh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sdonvitinh", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDonvitinh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bkhoa", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bKhoa));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbvthh::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbvthh_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_vthh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_vthh));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbvthh::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbvthh_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbvthh");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_vthh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_vthh));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iId_vthh = (Int32)dtToReturn.Rows[0]["id_vthh"];
					m_sTenvthh = (string)dtToReturn.Rows[0]["tenvthh"];
					m_sDonvitinh = (string)dtToReturn.Rows[0]["donvitinh"];
					m_bKhoa = (bool)dtToReturn.Rows[0]["khoa"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbvthh::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbvthh_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbvthh");
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
				throw new Exception("clsTbvthh::SelectAll::Error occured.", ex);
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


		public SqlString sTenvthh
		{
			get
			{
				return m_sTenvthh;
			}
			set
			{
				SqlString sTenvthhTmp = (SqlString)value;
				if(sTenvthhTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sTenvthh", "sTenvthh can't be NULL");
				}
				m_sTenvthh = value;
			}
		}


		public SqlString sDonvitinh
		{
			get
			{
				return m_sDonvitinh;
			}
			set
			{
				SqlString sDonvitinhTmp = (SqlString)value;
				if(sDonvitinhTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sDonvitinh", "sDonvitinh can't be NULL");
				}
				m_sDonvitinh = value;
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
