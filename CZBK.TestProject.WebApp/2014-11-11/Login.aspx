﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CZBK.TestProject.WebApp._2014_11_11.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    用户名:<input type="text" name="txtName"  value="<%=UserName %>"/><br />
        密码:<input type="password" name="txtPwd" /><br />
        <input type="submit" value="登录" />
    </div>
    </form>
</body>
</html>
