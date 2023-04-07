using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Bumblebee
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=DB_Bumblee;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Username,pass from CustomerLogin where Username ='" + txtusername.Text + "' and pass = '" + txtpassword.Text + "' ", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["id"] = txtusername.Text;
                Response.Redirect("Admin.aspx");
            }
            else
            {
                Response.Write("Username or password is incorect. Try again !!! ");
            }

        }
    }
}