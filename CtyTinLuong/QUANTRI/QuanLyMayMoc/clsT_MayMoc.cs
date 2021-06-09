///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'T_MayMoc'
// Generated by LLBLGen v1.3.5996.26197 Final on: Tuesday, December 22, 2020, 10:04:25 AM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace CtyTinLuong
{
	/// <summary>
	/// Purpose: Data Access class for the table 'T_MayMoc'.
	/// </summary>
	public partial class clsT_MayMoc : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTonTai, m_bNgungTheoDoi;
			private SqlInt32		m_iId, m_iId_loai, m_iId_tinhtrang;
			private SqlString		m_sMaMay, m_sTenMay, m_sGhichu;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public clsT_MayMoc()
		{
			// Nothing for now.
		}


		/// <summary>
		/// Purpose: Insert method. This method will insert one new row into the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iId_loai. May be SqlInt32.Null</LI>
		///		 <LI>iId_tinhtrang. May be SqlInt32.Null</LI>
		///		 <LI>sMaMay. May be SqlString.Null</LI>
		///		 <LI>sTenMay. May be SqlString.Null</LI>
		///		 <LI>sGhichu. May be SqlString.Null</LI>
		///		 <LI>bTonTai. May be SqlBoolean.Null</LI>
		///		 <LI>bNgungTheoDoi. May be SqlBoolean.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iId</LI>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_T_MayMoc_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_loai", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_loai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_tinhtrang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_tinhtrang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMaMay", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMaMay));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTenMay", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenMay));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sghichu", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhichu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iId));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iId = (SqlInt32)scmCmdToExecute.Parameters["@iid"].Value;
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_T_MayMoc_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsT_MayMoc::Insert::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method. This method will Update one existing row in the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iId</LI>
		///		 <LI>iId_loai. May be SqlInt32.Null</LI>
		///		 <LI>iId_tinhtrang. May be SqlInt32.Null</LI>
		///		 <LI>sMaMay. May be SqlString.Null</LI>
		///		 <LI>sTenMay. May be SqlString.Null</LI>
		///		 <LI>sGhichu. May be SqlString.Null</LI>
		///		 <LI>bTonTai. May be SqlBoolean.Null</LI>
		///		 <LI>bNgungTheoDoi. May be SqlBoolean.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_T_MayMoc_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_loai", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_loai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_tinhtrang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_tinhtrang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMaMay", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMaMay));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTenMay", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenMay));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sghichu", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhichu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_T_MayMoc_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsT_MayMoc::Update::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Delete method. This method will Delete one existing row in the database, based on the Primary Key.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iId</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_T_MayMoc_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_T_MayMoc_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsT_MayMoc::Delete::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Select method. This method will Select one existing row from the database, based on the Primary Key.
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iId</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		///		 <LI>iId</LI>
		///		 <LI>iId_loai</LI>
		///		 <LI>iId_tinhtrang</LI>
		///		 <LI>sMaMay</LI>
		///		 <LI>sTenMay</LI>
		///		 <LI>sGhichu</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_T_MayMoc_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("T_MayMoc");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_T_MayMoc_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_iId = (Int32)dtToReturn.Rows[0]["id"];
					m_iId_loai = dtToReturn.Rows[0]["id_loai"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["id_loai"];
					m_iId_tinhtrang = dtToReturn.Rows[0]["id_tinhtrang"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["id_tinhtrang"];
					m_sMaMay = dtToReturn.Rows[0]["MaMay"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["MaMay"];
					m_sTenMay = dtToReturn.Rows[0]["TenMay"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["TenMay"];
					m_sGhichu = dtToReturn.Rows[0]["ghichu"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["ghichu"];
					m_bTonTai = dtToReturn.Rows[0]["TonTai"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["TonTai"];
					m_bNgungTheoDoi = dtToReturn.Rows[0]["NgungTheoDoi"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["NgungTheoDoi"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsT_MayMoc::SelectOne::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		/// <summary>
		/// Purpose: SelectAll method. This method will Select all rows from the table.
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override DataTable SelectAll()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_T_MayMoc_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("T_MayMoc");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_T_MayMoc_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsT_MayMoc::SelectAll::Error occured.", ex);
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
		public SqlInt32 iId
		{
			get
			{
				return m_iId;
			}
			set
			{
				SqlInt32 iIdTmp = (SqlInt32)value;
				if(iIdTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId", "iId can't be NULL");
				}
				m_iId = value;
			}
		}


		public SqlInt32 iId_loai
		{
			get
			{
				return m_iId_loai;
			}
			set
			{
				SqlInt32 iId_loaiTmp = (SqlInt32)value;
				if(iId_loaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_loai", "iId_loai can't be NULL");
				}
				m_iId_loai = value;
			}
		}


		public SqlInt32 iId_tinhtrang
		{
			get
			{
				return m_iId_tinhtrang;
			}
			set
			{
				SqlInt32 iId_tinhtrangTmp = (SqlInt32)value;
				if(iId_tinhtrangTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_tinhtrang", "iId_tinhtrang can't be NULL");
				}
				m_iId_tinhtrang = value;
			}
		}


		public SqlString sMaMay
		{
			get
			{
				return m_sMaMay;
			}
			set
			{
				SqlString sMaMayTmp = (SqlString)value;
				if(sMaMayTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sMaMay", "sMaMay can't be NULL");
				}
				m_sMaMay = value;
			}
		}


		public SqlString sTenMay
		{
			get
			{
				return m_sTenMay;
			}
			set
			{
				SqlString sTenMayTmp = (SqlString)value;
				if(sTenMayTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sTenMay", "sTenMay can't be NULL");
				}
				m_sTenMay = value;
			}
		}


		public SqlString sGhichu
		{
			get
			{
				return m_sGhichu;
			}
			set
			{
				SqlString sGhichuTmp = (SqlString)value;
				if(sGhichuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sGhichu", "sGhichu can't be NULL");
				}
				m_sGhichu = value;
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


		public SqlBoolean bNgungTheoDoi
		{
			get
			{
				return m_bNgungTheoDoi;
			}
			set
			{
				SqlBoolean bNgungTheoDoiTmp = (SqlBoolean)value;
				if(bNgungTheoDoiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bNgungTheoDoi", "bNgungTheoDoi can't be NULL");
				}
				m_bNgungTheoDoi = value;
			}
		}
		#endregion
	}
}