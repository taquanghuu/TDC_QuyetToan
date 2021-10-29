using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QuyetToanVCG_TDC_2021
{
	public class clsTbnhansu : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bKhoa;
			private SqlInt32		m_iId_chucdanh, m_iId_donvi, m_iId_chucvu, m_iId_nhansu, m_iId_capbac;
			private SqlString		m_sHoten;
		#endregion


		public clsTbnhansu()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbnhansu_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@shoten", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sHoten));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_capbac", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_capbac));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_chucvu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_chucvu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_chucdanh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_chucdanh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bkhoa", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bKhoa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_donvi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_donvi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhansu", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhansu));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iId_nhansu = (SqlInt32)scmCmdToExecute.Parameters["@iid_nhansu"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbnhansu::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbnhansu_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhansu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhansu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@shoten", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sHoten));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_capbac", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_capbac));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_chucvu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_chucvu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_chucdanh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_chucdanh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bkhoa", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bKhoa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_donvi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_donvi));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbnhansu::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbnhansu_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhansu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhansu));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbnhansu::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbnhansu_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbnhansu");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhansu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhansu));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iId_nhansu = (Int32)dtToReturn.Rows[0]["id_nhansu"];
					m_sHoten = (string)dtToReturn.Rows[0]["hoten"];
					m_iId_capbac = (Int32)dtToReturn.Rows[0]["id_capbac"];
					m_iId_chucvu = (Int32)dtToReturn.Rows[0]["id_chucvu"];
					m_iId_chucdanh = (Int32)dtToReturn.Rows[0]["id_chucdanh"];
					m_bKhoa = (bool)dtToReturn.Rows[0]["khoa"];
					m_iId_donvi = (Int32)dtToReturn.Rows[0]["id_donvi"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbnhansu::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbnhansu_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbnhansu");
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
				throw new Exception("clsTbnhansu::SelectAll::Error occured.", ex);
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


		public SqlString sHoten
		{
			get
			{
				return m_sHoten;
			}
			set
			{
				SqlString sHotenTmp = (SqlString)value;
				if(sHotenTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sHoten", "sHoten can't be NULL");
				}
				m_sHoten = value;
			}
		}


		public SqlInt32 iId_capbac
		{
			get
			{
				return m_iId_capbac;
			}
			set
			{
				SqlInt32 iId_capbacTmp = (SqlInt32)value;
				if(iId_capbacTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_capbac", "iId_capbac can't be NULL");
				}
				m_iId_capbac = value;
			}
		}


		public SqlInt32 iId_chucvu
		{
			get
			{
				return m_iId_chucvu;
			}
			set
			{
				SqlInt32 iId_chucvuTmp = (SqlInt32)value;
				if(iId_chucvuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_chucvu", "iId_chucvu can't be NULL");
				}
				m_iId_chucvu = value;
			}
		}


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


		public SqlInt32 iId_donvi
		{
			get
			{
				return m_iId_donvi;
			}
			set
			{
				SqlInt32 iId_donviTmp = (SqlInt32)value;
				if(iId_donviTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_donvi", "iId_donvi can't be NULL");
				}
				m_iId_donvi = value;
			}
		}
		#endregion
	}
}
