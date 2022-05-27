using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewBasicCrud.webhome
{
    public partial class userhome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelName.Text="Welcome Mr." + Request.QueryString["uname"];
        }
    }
}