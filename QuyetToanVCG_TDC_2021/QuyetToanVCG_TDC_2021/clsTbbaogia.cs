using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QuyetToanVCG_TDC_2021
{
	public class clsTbbaogia : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTontai;
			private SqlDouble		m_fThanhtien2, m_fDongia2, m_fThanhtien3, m_fDongia3, m_fThanhtien1, m_fSoluong, m_fDongia1;
			private SqlInt32		m_iId_baogia, m_iId_hopdong, m_iId_vthh;
		#endregion


		public clsTbbaogia()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbbaogia_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_vthh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_vthh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fsoluong", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSoluong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fdongia1", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDongia1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fthanhtien1", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fThanhtien1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fdongia2", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDongia2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fthanhtien2", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fThanhtien2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fdongia3", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDongia3));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fthanhtien3", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fThanhtien3));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@btontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTontai));
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
				throw new Exception("clsTbbaogia::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbbaogia_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_baogia", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_baogia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_vthh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_vthh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fsoluong", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSoluong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fdongia1", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDongia1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fthanhtien1", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fThanhtien1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fdongia2", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDongia2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fthanhtien2", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fThanhtien2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fdongia3", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDongia3));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fthanhtien3", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fThanhtien3));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@btontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTontai));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbbaogia::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbbaogia_Delete]";
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
				throw new Exception("clsTbbaogia::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbbaogia_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbbaogia");
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
					m_iId_vthh = (Int32)dtToReturn.Rows[0]["id_vthh"];
					m_fSoluong = (double)dtToReturn.Rows[0]["soluong"];
					m_fDongia1 = (double)dtToReturn.Rows[0]["dongia1"];
					m_fThanhtien1 = (double)dtToReturn.Rows[0]["thanhtien1"];
					m_fDongia2 = (double)dtToReturn.Rows[0]["dongia2"];
					m_fThanhtien2 = (double)dtToReturn.Rows[0]["thanhtien2"];
					m_fDongia3 = (double)dtToReturn.Rows[0]["dongia3"];
					m_fThanhtien3 = (double)dtToReturn.Rows[0]["thanhtien3"];
					m_bTontai = (bool)dtToReturn.Rows[0]["tontai"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbbaogia::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbbaogia_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbbaogia");
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
				throw new Exception("clsTbbaogia::SelectAll::Error occured.", ex);
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


		public SqlDouble fDongia1
		{
			get
			{
				return m_fDongia1;
			}
			set
			{
				SqlDouble fDongia1Tmp = (SqlDouble)value;
				if(fDongia1Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fDongia1", "fDongia1 can't be NULL");
				}
				m_fDongia1 = value;
			}
		}


		public SqlDouble fThanhtien1
		{
			get
			{
				return m_fThanhtien1;
			}
			set
			{
				SqlDouble fThanhtien1Tmp = (SqlDouble)value;
				if(fThanhtien1Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fThanhtien1", "fThanhtien1 can't be NULL");
				}
				m_fThanhtien1 = value;
			}
		}


		public SqlDouble fDongia2
		{
			get
			{
				return m_fDongia2;
			}
			set
			{
				SqlDouble fDongia2Tmp = (SqlDouble)value;
				if(fDongia2Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fDongia2", "fDongia2 can't be NULL");
				}
				m_fDongia2 = value;
			}
		}


		public SqlDouble fThanhtien2
		{
			get
			{
				return m_fThanhtien2;
			}
			set
			{
				SqlDouble fThanhtien2Tmp = (SqlDouble)value;
				if(fThanhtien2Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fThanhtien2", "fThanhtien2 can't be NULL");
				}
				m_fThanhtien2 = value;
			}
		}


		public SqlDouble fDongia3
		{
			get
			{
				return m_fDongia3;
			}
			set
			{
				SqlDouble fDongia3Tmp = (SqlDouble)value;
				if(fDongia3Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fDongia3", "fDongia3 can't be NULL");
				}
				m_fDongia3 = value;
			}
		}


		public SqlDouble fThanhtien3
		{
			get
			{
				return m_fThanhtien3;
			}
			set
			{
				SqlDouble fThanhtien3Tmp = (SqlDouble)value;
				if(fThanhtien3Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fThanhtien3", "fThanhtien3 can't be NULL");
				}
				m_fThanhtien3 = value;
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
		#endregion
	}
}
