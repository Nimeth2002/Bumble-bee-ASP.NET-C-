using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;


namespace Client
{
    /// <summary>
    /// Summary description for RegistrationWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RegistrationWebService : System.Web.Services.WebService
    {
        SqlConnection sqlCon = null;
        public SqlConnection GetConnection()
        {
            try
            {
                sqlCon = new SqlConnection(@"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=DB_Bumblee;Integrated Security=True");
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to Db" + ex);
            }
            return sqlCon;
        }
        [WebMethod]
        public string insertCustomer(string Name, string Email, string Address, string Password, string ConfirmPassword)
        {
            int noRecords = 0;

            try
            {
                GetConnection();
                SqlCommand cmd = new SqlCommand("insert into Customer_Registration values ('" + Name + "','" + Email + "','" + Address + "','" + Password + "','" + ConfirmPassword + "');", sqlCon);

                noRecords = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return noRecords.ToString();
        }

    }

}

