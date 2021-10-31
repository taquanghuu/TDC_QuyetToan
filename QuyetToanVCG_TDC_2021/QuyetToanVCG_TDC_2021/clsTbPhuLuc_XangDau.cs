using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QuyetToanVCG_TDC_2021
{
	public class clsTbPhuLuc_XangDau : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlDateTime		m_daNgay;
			private SqlDouble		m_fSoluong;
			private SqlInt32		m_iId_hopdong, m_iId_xd;
			private SqlString		m_sNoidung, m_sDonvitinh;
		#endregion


		public clsTbPhuLuc_XangDau()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbPhuLuc_XangDau_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dangay", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@snoidung", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNoidung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sdonvitinh", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDonvitinh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fsoluong", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSoluong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_xd", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iId_xd));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iId_xd = (SqlInt32)scmCmdToExecute.Parameters["@iid_xd"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbPhuLuc_XangDau::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbPhuLuc_XangDau_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_xd", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_xd));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dangay", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@snoidung", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNoidung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sdonvitinh", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDonvitinh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fsoluong", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSoluong));
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
				throw new Exception("clsTbPhuLuc_XangDau::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbPhuLuc_XangDau_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_xd", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_xd));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbPhuLuc_XangDau::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbPhuLuc_XangDau_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbPhuLuc_XangDau");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_xd", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_xd));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iId_xd = (Int32)dtToReturn.Rows[0]["id_xd"];
					m_daNgay = (DateTime)dtToReturn.Rows[0]["ngay"];
					m_sNoidung = (string)dtToReturn.Rows[0]["noidung"];
					m_sDonvitinh = (string)dtToReturn.Rows[0]["donvitinh"];
					m_fSoluong = (double)dtToReturn.Rows[0]["soluong"];
					m_iId_hopdong = (Int32)dtToReturn.Rows[0]["id_hopdong"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbPhuLuc_XangDau::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbPhuLuc_XangDau_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbPhuLuc_XangDau");
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
				throw new Exception("clsTbPhuLuc_XangDau::SelectAll::Error occured.", ex);
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
		public SqlInt32 iId_xd
		{
			get
			{
				return m_iId_xd;
			}
			set
			{
				SqlInt32 iId_xdTmp = (SqlInt32)value;
				if(iId_xdTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_xd", "iId_xd can't be NULL");
				}
				m_iId_xd = value;
			}
		}


		public SqlDateTime daNgay
		{
			get
			{
				return m_daNgay;
			}
			set
			{
				SqlDateTime daNgayTmp = (SqlDateTime)value;
				if(daNgayTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("daNgay", "daNgay can't be NULL");
				}
				m_daNgay = value;
			}
		}


		public SqlString sNoidung
		{
			get
			{
				return m_sNoidung;
			}
			set
			{
				SqlString sNoidungTmp = (SqlString)value;
				if(sNoidungTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sNoidung", "sNoidung can't be NULL");
				}
				m_sNoidung = value;
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
		#endregion
	}
}
