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

namespace SecurityCheck
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["bar"] != null)
            {
                LoginDateTime.Text = HttpUtility.HtmlEncode(((DateTime)Session["bar"]).ToString("yyyy-MM-dd HH:mm:ss.fff"));
            }
        }
    }
}
