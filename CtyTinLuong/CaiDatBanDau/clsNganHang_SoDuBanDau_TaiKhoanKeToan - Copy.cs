///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'NganHang_SoDuBanDau_TaiKhoanKeToan'
// Generated by LLBLGen v1.3.5996.26197 Final on: Saturday, January 23, 2021, 10:25:03 AM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace CtyTinLuong
{
	/// <summary>
	/// Purpose: Data Access class for the table 'NganHang_SoDuBanDau_TaiKhoanKeToan'.
	/// </summary>
	public partial class clsNganHang_SoDuBanDau_TaiKhoanKeToan : clsDBInteractionBase
	{
        public DataTable SelectAll_HienThi()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_NganHang_SoDuBanDau_TaiKhoanKeToan_SelectAll_HienThi]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_NganHang_SoDuBanDau_TaiKhoanKeToan_SelectAll_HienThi");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                 // Execute query.
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_NganHang_SoDuBanDau_TaiKhoanKeToan_SelectAll_HienThi", ex);
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
