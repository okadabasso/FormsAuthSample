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

using System.Security;
using System.Security.Principal;

namespace SecurityCheck.Account
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Services.AuthenticationService service = new SecurityCheck.Services.AuthenticationService();
                service.Prepare();
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Services.AuthenticationService service = new SecurityCheck.Services.AuthenticationService();

            if (service.Authenticate(LoginUser.UserName, LoginUser.Password))
            {
                // session idが変わるのを確認するためのダミーデータ
                Session["bar"] = DateTime.Now;
                 FormsAuthentication.RedirectFromLoginPage(LoginUser.UserName, LoginUser.RememberMeSet);
            }

        }
    }
}
