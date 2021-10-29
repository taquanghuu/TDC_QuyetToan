using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QuyetToanVCG_TDC_2021
{
	public class clsTbHoiThao : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTontai, m_bKhoa;
			private SqlInt32		m_iId_hoithao, m_iId_hopdong, m_iId_nhansu;
			private SqlString		m_sDiengiai;
		#endregion


		public clsTbHoiThao()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbHoiThao_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhansu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhansu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sdiengiai", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDiengiai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@btontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTontai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bkhoa", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bKhoa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hoithao", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hoithao));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iId_hoithao = (SqlInt32)scmCmdToExecute.Parameters["@iid_hoithao"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbHoiThao::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbHoiThao_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hoithao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hoithao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhansu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhansu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sdiengiai", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDiengiai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@btontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTontai));
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
				throw new Exception("clsTbHoiThao::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbHoiThao_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hoithao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hoithao));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbHoiThao::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbHoiThao_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbHoiThao");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hoithao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hoithao));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iId_hoithao = (Int32)dtToReturn.Rows[0]["id_hoithao"];
					m_iId_hopdong = (Int32)dtToReturn.Rows[0]["id_hopdong"];
					m_iId_nhansu = (Int32)dtToReturn.Rows[0]["id_nhansu"];
					m_sDiengiai = (string)dtToReturn.Rows[0]["diengiai"];
					m_bTontai = (bool)dtToReturn.Rows[0]["tontai"];
					m_bKhoa = (bool)dtToReturn.Rows[0]["khoa"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbHoiThao::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbHoiThao_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbHoiThao");
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
				throw new Exception("clsTbHoiThao::SelectAll::Error occured.", ex);
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
		public SqlInt32 iId_hoithao
		{
			get
			{
				return m_iId_hoithao;
			}
			set
			{
				SqlInt32 iId_hoithaoTmp = (SqlInt32)value;
				if(iId_hoithaoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_hoithao", "iId_hoithao can't be NULL");
				}
				m_iId_hoithao = value;
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


		public SqlInt32 iId_nhansu
		{
			get
			{
				return m_iId_nhansu;
			}
			set
			{
				SqlInt32 iId_nhansuTmp = (SqlInt32)value;
				if(iId_nhansuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_nhansu", "iId_nhansu can't be NULL");
				}
				m_iId_nhansu = value;
			}
		}


		public SqlString sDiengiai
		{
			get
			{
				return m_sDiengiai;
			}
			set
			{
				SqlString sDiengiaiTmp = (SqlString)value;
				if(sDiengiaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sDiengiai", "sDiengiai can't be NULL");
				}
				m_sDiengiai = value;
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
