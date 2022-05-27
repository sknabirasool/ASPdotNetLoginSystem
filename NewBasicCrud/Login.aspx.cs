using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace NewBasicCrud
{
    public partial class Login : System.Web.UI.Page
    {
 
        int user;
        string usname;
        string Con = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {


            SqlConnection sn = new SqlConnection(Con);
            sn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_users where email='" + txtUserName.Text +"' and password = '"+txtPassword.Text +"'",sn);
            DataSet ds = new DataSet();
            da.Fill(ds,"tab");
            if(ds.Tables[0].Rows.Count > 0)
            {
                user = 1;
                usname = ds.Tables[0].Rows[0][1].ToString();
                Response.Redirect("webhome/userhome.aspx?uname="+usname);
            }
            else
            {
                user = 0;
                LabelMessage.Text = "User Name and Password Invalid";
            }
        }
    }
}