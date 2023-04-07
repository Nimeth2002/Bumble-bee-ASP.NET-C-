using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Client
{
    /// <summary>
    /// Summary description for AdminPanelWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AdminPanelWebService : System.Web.Services.WebService
    {
        SqlConnection sqlCon = null;
        public SqlConnection GetConnection()
        {
            try
            {
                sqlCon = new SqlConnection(@"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ASP.NET;Integrated Security=True");
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to Db" + ex);
            }
            return sqlCon;
        }
        [WebMethod]
        public string Adddetails(string ProductID, string Productname, string ProductPrice, string categoryname, string Brandname)
        {
            int noRecords = 0;

            try
            {
                GetConnection();
                SqlCommand cmd = new SqlCommand("insert into Manage values ('" + ProductID + "','" + Productname + "','" + ProductPrice + "','" + categoryname + "','" + Brandname + "');", sqlCon);

                noRecords = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return noRecords.ToString();
        }
        [WebMethod]
        public string UpdateProduct (string ProductID ,string Productname , string Productprice , string categoryname , string Brandname )
        {
            int noRecords = 0;
            try
            {
                GetConnection();
                SqlCommand cmd = new SqlCommand("Update Manage values set Product_ID ('" + ProductID + "','" + Productname + "','" + Productprice + "','" + categoryname + "','" + Brandname + "');", sqlCon);

                noRecords = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return noRecords.ToString();

        }
        [WebMethod]
        public string DeleteProduct(string ProductID, string Productname, string Productprice, string categoryname, string Brandname)
        {
            int noRecords = 0;
            try
            {
                GetConnection();
                SqlCommand cmd = new SqlCommand("Delete from Manage where Product_ID ('" + ProductID + "');", sqlCon);

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

