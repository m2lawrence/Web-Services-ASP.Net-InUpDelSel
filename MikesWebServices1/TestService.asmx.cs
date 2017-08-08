// Add this web service page, then the 3 libraries below, and then the WebMethod.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

//----add:
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace MikesWebServices1
{
    /// <summary>
    /// Summary description for TestService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TestService : System.Web.Services.WebService
    {

        [WebMethod]
        public int InsertDetail(string PersonName, string PersonCity)
        {
            int retRecord = 0;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("InsertDetail", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("PersonName", SqlDbType.VarChar, 100).Value = PersonName;
                    cmd.Parameters.Add("PersonCity", SqlDbType.VarChar, 100).Value = PersonCity;
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    retRecord = cmd.ExecuteNonQuery();
                }

            }
            return retRecord;
        }
        [WebMethod]
        public int UpdateDetail(int PersonID, string PersonName, string PersonCity)
        {
            int retRecord = 0;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateDetail", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("PersonID", SqlDbType.VarChar, 100).Value = PersonID;
                    cmd.Parameters.Add("PersonName", SqlDbType.VarChar, 100).Value = PersonName;
                    cmd.Parameters.Add("PersonCity", SqlDbType.VarChar, 100).Value = PersonCity;
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    retRecord = cmd.ExecuteNonQuery();
                }

            }
            return retRecord;
        }
        [WebMethod]
        public int DeleteRecord(int PersonID)
        {
            int Rowupdate = 0;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteDetialByID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("PersonID", SqlDbType.Int).Value = PersonID;
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    Rowupdate = cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }

            }
            return Rowupdate;
        }
        [WebMethod]
        public DataSet GetDetialByID(int PersonID)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetDetialByID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("PersonID", SqlDbType.Int).Value = PersonID;
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cmd;
                    adp.Fill(ds);
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }

            }
            return ds;
        }
    }
}
