using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QuyetToanVCG_TDC_2021
{
	public class clsTbBangKe : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTontai, m_bKhoa, m_bDanhSachCapTien;
			private SqlDateTime		m_daNgayhoadon;
			private SqlDouble		m_fSotien;
			private SqlInt32		m_iId_hopdong, m_iId_bangke, m_iId_loaihoadon;
			private SqlString		m_sDiengiai, m_sSohoadon;
		#endregion


		public clsTbBangKe()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbBangKe_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ssohoadon", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSohoadon));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dangayhoadon", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayhoadon));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sdiengiai", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDiengiai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fsotien", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSotien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@btontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTontai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bkhoa", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bKhoa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bDanhSachCapTien", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bDanhSachCapTien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_loaihoadon", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_loaihoadon));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_bangke", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iId_bangke));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iId_bangke = (SqlInt32)scmCmdToExecute.Parameters["@iid_bangke"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbBangKe::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbBangKe_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_bangke", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_bangke));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_hopdong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_hopdong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ssohoadon", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSohoadon));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dangayhoadon", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayhoadon));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sdiengiai", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDiengiai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fsotien", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSotien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@btontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTontai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bkhoa", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bKhoa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bDanhSachCapTien", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bDanhSachCapTien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_loaihoadon", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_loaihoadon));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbBangKe::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbBangKe_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_bangke", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_bangke));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbBangKe::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbBangKe_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbBangKe");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_bangke", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_bangke));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iId_bangke = (Int32)dtToReturn.Rows[0]["id_bangke"];
					m_iId_hopdong = (Int32)dtToReturn.Rows[0]["id_hopdong"];
					m_sSohoadon = (string)dtToReturn.Rows[0]["sohoadon"];
					m_daNgayhoadon = (DateTime)dtToReturn.Rows[0]["ngayhoadon"];
					m_sDiengiai = (string)dtToReturn.Rows[0]["diengiai"];
					m_fSotien = (double)dtToReturn.Rows[0]["sotien"];
					m_bTontai = (bool)dtToReturn.Rows[0]["tontai"];
					m_bKhoa = (bool)dtToReturn.Rows[0]["khoa"];
					m_bDanhSachCapTien = (bool)dtToReturn.Rows[0]["DanhSachCapTien"];
					m_iId_loaihoadon = (Int32)dtToReturn.Rows[0]["id_loaihoadon"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbBangKe::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbBangKe_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbBangKe");
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
				throw new Exception("clsTbBangKe::SelectAll::Error occured.", ex);
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
		public SqlInt32 iId_bangke
		{
			get
			{
				return m_iId_bangke;
			}
			set
			{
				SqlInt32 iId_bangkeTmp = (SqlInt32)value;
				if(iId_bangkeTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_bangke", "iId_bangke can't be NULL");
				}
				m_iId_bangke = value;
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


		public SqlString sSohoadon
		{
			get
			{
				return m_sSohoadon;
			}
			set
			{
				SqlString sSohoadonTmp = (SqlString)value;
				if(sSohoadonTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sSohoadon", "sSohoadon can't be NULL");
				}
				m_sSohoadon = value;
			}
		}


		public SqlDateTime daNgayhoadon
		{
			get
			{
				return m_daNgayhoadon;
			}
			set
			{
				SqlDateTime daNgayhoadonTmp = (SqlDateTime)value;
				if(daNgayhoadonTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("daNgayhoadon", "daNgayhoadon can't be NULL");
				}
				m_daNgayhoadon = value;
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


		public SqlBoolean bDanhSachCapTien
		{
			get
			{
				return m_bDanhSachCapTien;
			}
			set
			{
				SqlBoolean bDanhSachCapTienTmp = (SqlBoolean)value;
				if(bDanhSachCapTienTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bDanhSachCapTien", "bDanhSachCapTien can't be NULL");
				}
				m_bDanhSachCapTien = value;
			}
		}


		public SqlInt32 iId_loaihoadon
		{
			get
			{
				return m_iId_loaihoadon;
			}
			set
			{
				SqlInt32 iId_loaihoadonTmp = (SqlInt32)value;
				if(iId_loaihoadonTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_loaihoadon", "iId_loaihoadon can't be NULL");
				}
				m_iId_loaihoadon = value;
			}
		}
		#endregion
	}
}
