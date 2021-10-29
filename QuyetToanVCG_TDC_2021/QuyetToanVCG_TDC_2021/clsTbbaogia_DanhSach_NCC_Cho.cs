using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QuyetToanVCG_TDC_2021
{
	public class clsTbbaogia_DanhSach_NCC_Cho : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlInt32		m_iId_nhacungcap, m_iTrungthau_1_Phu_2_Phu_3, m_iId_baogia_danhsach, m_iId_hopdong;
		#endregion


		public clsTbbaogia_DanhSach_NCC_Cho()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbbaogia_DanhSach_NCC_Cho_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhacungcap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhacungcap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@itrungthau_1_Phu_2_Phu_3", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iTrungthau_1_Phu_2_Phu_3));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_baogia_danhsach", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iId_baogia_danhsach));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iId_baogia_danhsach = (SqlInt32)scmCmdToExecute.Parameters["@iid_baogia_danhsach"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbbaogia_DanhSach_NCC_Cho::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbbaogia_DanhSach_NCC_Cho_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_baogia_danhsach", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_baogia_danhsach));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_nhacungcap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_nhacungcap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@itrungthau_1_Phu_2_Phu_3", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iTrungthau_1_Phu_2_Phu_3));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbbaogia_DanhSach_NCC_Cho::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbbaogia_DanhSach_NCC_Cho_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_baogia_danhsach", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_baogia_danhsach));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbbaogia_DanhSach_NCC_Cho::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbbaogia_DanhSach_NCC_Cho_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbbaogia_DanhSach_NCC_Cho");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_baogia_danhsach", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_baogia_danhsach));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iId_baogia_danhsach = (Int32)dtToReturn.Rows[0]["id_baogia_danhsach"];
					m_iId_hopdong = (Int32)dtToReturn.Rows[0]["id_hopdong"];
					m_iId_nhacungcap = (Int32)dtToReturn.Rows[0]["id_nhacungcap"];
					m_iTrungthau_1_Phu_2_Phu_3 = (Int32)dtToReturn.Rows[0]["trungthau_1_Phu_2_Phu_3"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbbaogia_DanhSach_NCC_Cho::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbbaogia_DanhSach_NCC_Cho_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbbaogia_DanhSach_NCC_Cho");
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
				throw new Exception("clsTbbaogia_DanhSach_NCC_Cho::SelectAll::Error occured.", ex);
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
		public SqlInt32 iId_baogia_danhsach
		{
			get
			{
				return m_iId_baogia_danhsach;
			}
			set
			{
				SqlInt32 iId_baogia_danhsachTmp = (SqlInt32)value;
				if(iId_baogia_danhsachTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_baogia_danhsach", "iId_baogia_danhsach can't be NULL");
				}
				m_iId_baogia_danhsach = value;
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


		public SqlInt32 iTrungthau_1_Phu_2_Phu_3
		{
			get
			{
				return m_iTrungthau_1_Phu_2_Phu_3;
			}
			set
			{
				SqlInt32 iTrungthau_1_Phu_2_Phu_3Tmp = (SqlInt32)value;
				if(iTrungthau_1_Phu_2_Phu_3Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iTrungthau_1_Phu_2_Phu_3", "iTrungthau_1_Phu_2_Phu_3 can't be NULL");
				}
				m_iTrungthau_1_Phu_2_Phu_3 = value;
			}
		}
		#endregion
	}
}
