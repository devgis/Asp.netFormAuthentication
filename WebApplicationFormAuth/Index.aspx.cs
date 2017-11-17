using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationFormAuth
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //System.Web.Security.FormsAuthentication.SignOut();
            if (Context.User.Identity.IsAuthenticated) 
            {
                Response.Write(User.Identity.Name);
                Response.Write("登录成功！");
                 //你已通过验证，知道该怎么做了吧？
            } 
            //else
            //{
            //    Response.Redirect("Login.aspx");
            //}

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut();
        }
    }
}