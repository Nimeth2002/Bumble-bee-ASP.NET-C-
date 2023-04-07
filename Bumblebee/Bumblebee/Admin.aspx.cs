using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Bumblebee
{
    public partial class Admin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ASP.NET;Integrated Security=True");
        AdminServiceReference.AdminPanelWebServiceSoapClient obj = new AdminServiceReference.AdminPanelWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Manage values('" + txtproductid.Text + "','" + txtProductname.Text + "','" + txtproductprice + "','" + txtcategoryname.Text + "','" + txtbrandname.Text + "')";
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Response.Write("Successfully Details added to the database!!!");
                }
                else
                {
                    Response.Write("Error Adding record!!!");
                }


            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Manage set Producy_ID='" + txtproductid.Text + "',Product_Name='" + txtProductname.Text + "',Producy_Price='" + txtproductprice.Text + "',Category_N" + txtcategoryname.Text + "'where Brand_NN='" + txtbrandname.Text + "'", con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("Updated successfully !!!");
            }
            else
            {
                Response.Write("Error while updating");
            }
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Delete from Mange where Product_ID='" + txtproductid.Text + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Successfully deleted!!!");
            }
            else
            {
                Response.Write("Error deleting record!!!");
            }
        }
    }
} 