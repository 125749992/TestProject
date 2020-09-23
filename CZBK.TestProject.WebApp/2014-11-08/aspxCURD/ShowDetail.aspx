<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowDetail.aspx.cs" Inherits="CZBK.TestProject.WebApp._2014_11_8.aspxCURD.ShowDetail" %>
<%@ Import Namespace="CZBK.TestProject.Model" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td>用户名</td><td><%=Users.UserName %></td></tr>
          <tr><td>密码</td><td><%=Users.UserPass %></td></tr>
    </table>
    </div>
    </form>
</body>
</html>
