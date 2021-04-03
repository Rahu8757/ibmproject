using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace march17
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Membership.ValidateUser(Login1.UserName, Login1.Password))
            {
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);

                if (Login1.RememberMeSet == true)
                {
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true);
                }

            }
        }
    }
}