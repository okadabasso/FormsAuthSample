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

namespace SecurityCheck.Services
{
    public class AuthenticationService
    {
        public void Prepare()
        {
            HttpContext context = HttpContext.Current;
            context.Session.Abandon();
            HttpCookie sessionCookie = new HttpCookie("ASP.NET_SessionId", "");
            sessionCookie.Expires = DateTime.Now.AddDays(-1);

            context.Response.Cookies.Add(sessionCookie);
        }
        
        /// <summary>
        /// �F�؃`�F�b�N
        /// </summary>
        /// <param name="loginId">�F�؂�v�����郆�[�U�[�̃��O�C��ID</param>
        /// <param name="password">�F�؂�v�����郆�[�U�[�̃p�X���[�h</param>
        /// <returns>�F�ؗv�����������ꍇ�Atrue</returns>
        public bool Authenticate(string loginId, string password)
        {
            if (loginId == "foo")
            {
                if (password == "opensesami")
                {
                    return true;
                }
            }
            return false;
        }

        public void Logout()
        {
            HttpContext context = HttpContext.Current;
            FormsAuthentication.SignOut();


            context.Session.Abandon();
            HttpCookie sessionCookie = new HttpCookie("ASP.NET_SessionId", "");
            sessionCookie.Expires = DateTime.Now.AddDays(-1);

            context.Response.Cookies.Add(sessionCookie);

        }
        public bool IsAuthenticated()
        {
            HttpContext context = HttpContext.Current;
            IIdentity identity = context.User.Identity ;

            return identity != null;
        }

        /// <summary>
        /// �F�؏��擾
        /// </summary>
        /// <returns>�F�؏��</returns>
        public IIdentity GetIdentity()
        {
            HttpContext context = HttpContext.Current;
            IIdentity identity = context.User.Identity;

            return identity;
        }
    }
}
