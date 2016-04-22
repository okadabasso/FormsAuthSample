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

using SecurityCheck.Services;

namespace SecurityCheck.Shared
{
    public partial class LoginControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AuthenticationService service = new AuthenticationService();
            if (service.IsAuthenticated())
            {
                LoginPanel.Visible = true;
                UserName.Text = HttpUtility.HtmlEncode(service.GetIdentity().Name);
                LogoutPanel1.Visible = false;
            }
            else
            {
                LoginPanel.Visible = false;
                LogoutPanel1.Visible = true;
            }
            
        }
    }
}