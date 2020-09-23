<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminIndex.aspx.cs" Inherits="CZBK.TestProject.WebApp._2014_11_13.AdminIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
    <div>
欢迎<span style="font-size:14px;color:red"><%=UserInfo.UserName %></span>登录    Itcast网站后台管理页面.  <a href="LoginOut.ashx"> 退出</a>

    </div>
    </form>
</body>
</html>
