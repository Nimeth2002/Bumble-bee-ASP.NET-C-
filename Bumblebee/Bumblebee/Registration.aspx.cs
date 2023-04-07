using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace Bumblebee
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=DB_Bumblee;Integrated Security=True");
        RegistrationServiceReference.RegistrationWebServiceSoapClient obj = new RegistrationServiceReference.RegistrationWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Customer_Registration values('" + txtcustomerid.Text + "','" + txtfullname.Text + "','" + txtdateofbirth.Text + "','" + txtloanbalance.Text + "','" + txtuseramount.Text + "','" + txtinstallementplan.Text + "')";
            cmd.ExecuteNonQuery();
            Response.Write("Regstration succeed !!! ");
            cn.Close();

        }
    }
}