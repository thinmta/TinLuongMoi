///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'KhoNPL_tbNhapKho'
// Generated by LLBLGen v1.3.5996.26197 Final on: Friday, March 19, 2021, 3:08:26 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace CtyTinLuong
{
	/// <summary>
	/// Purpose: Data Access class for the table 'KhoNPL_tbNhapKho'.
	/// </summary>
	public partial class clsKhoNPL_tbNhapKho : clsDBInteractionBase
	{

        public DataTable SelectOne_W_ThamChieu_NhapKho_DaiLy()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_KhoNPL_tbNhapKho_SelectOne_W_ThamChieu_NhapKho_DaiLy]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_KhoNPL_tbNhapKho_SelectOne_W_ThamChieu_NhapKho_DaiLy");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sThamChieu", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sThamChieu));
                // Execute query.
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_KhoNPL_tbNhapKho_SelectOne_W_ThamChieu_NhapKho_DaiLy", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
    }
}