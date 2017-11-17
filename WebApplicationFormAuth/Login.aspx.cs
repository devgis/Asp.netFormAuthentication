using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationFormAuth
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btLogin_Click(object sender, EventArgs e)
        {

            if (this.tbUser.Text == "admin" && this.tbPassword.Text == "123456")
            {
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(this.tbUser.Text, false);

                //System.Web.Security.FormsAuthentication.SetAuthCookie(this.Txt_UserName.Text,false);
                //Response.Redirect("Default.aspx"); 
            }
            else
            {
                Response.Write("用户名或密码错误！");
            }
        }
    }
}