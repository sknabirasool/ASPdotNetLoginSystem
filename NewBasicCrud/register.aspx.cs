using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewBasicCrud
{
    public partial class register : System.Web.UI.Page
    {

        int user;
        string usname;
        string Con = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void clearFields()
        {
            txtEmail.Text = "";
            txtUserName.Text = "";
            
        }
        public void CheckForDuplicates()
        {
            //HttpContext con = HttpContext.Current;

            SqlConnection connection = new SqlConnection(Con);
            connection.Close();
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_users where email = '" + txtEmail.Text + "'", connection);

            DataSet ds = new DataSet();
            da.Fill(ds, "tab");

            if (ds.Tables[0].Rows.Count > 0)
            {
                user = 1;
                Response.Redirect("webhome/login.aspx");
            }
            else
            {
                user = 0;

            }

            connection.Close();
        }


        public void Register()
        {
             SqlConnection connection = new SqlConnection(Con);
            try
            {
                CheckForDuplicates();
                if (user == 1)
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('User Exists in our Database');window.location='login.aspx';", true);
                }
                else
                {
                    SqlConnection sn = new SqlConnection(Con);
                    cmd = new SqlCommand("insert into tbl_users(user_name,email,password) values(@user_name,@email,@password)", sn);
                    sn.Open();
                    cmd.Parameters.AddWithValue("@user_name", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                    sn.Close();

                    LabelMessage.Text="Record Inserted Successfully";

                    clearFields();
                
                    //GVConceptsList.DataBind();
                    connection.Close();
                    //ClearTextBoxes(Page);

                }

            }
            catch (Exception ex)
            {
                LabelMessage.Text = ex.Message;

            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Register();
        }
    }
}