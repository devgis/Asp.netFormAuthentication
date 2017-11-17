# Asp.netFormAuthentication
Asp.net Form Authentication asp.net Form方式认证

首先web.config中需要配置一下
    <system.web>
        <compilation debug="true" targetFramework="4.0" />
      <authentication  mode="Forms">
        <forms  cookieless="UseCookies" loginUrl="Login.aspx" name=".ASPXAUTH">
        </forms>
      </authentication>
      <authorization>
        <deny users = "?"/>
      </authorization>
    </system.web>

Login.Aspx进行认证：
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

判断是否授权
if (Context.User.Identity.IsAuthenticated) 
{
    Response.Write(User.Identity.Name);
    Response.Write("登录成功！");
     //你已通过验证，知道该怎么做了吧？
} 

退出登录
System.Web.Security.FormsAuthentication.SignOut();
