<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplicationFormAuth.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #cccc {
            width: 127px;
        }
    </style>
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function cccc_onclick() {

        }

// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label3" runat="server" Text="登录"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="用户"></asp:Label>
        <asp:TextBox ID="tbUser" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="密码"></asp:Label>
        <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btLogin" runat="server" onclick="btLogin_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
