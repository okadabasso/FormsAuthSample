using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


namespace SecurityCheck.Account
{
    public partial class LogoutForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Services.AuthenticationService service = new SecurityCheck.Services.AuthenticationService();
            service.Logout();

            Response.Redirect("~/Default.aspx");
        }
    }
}
