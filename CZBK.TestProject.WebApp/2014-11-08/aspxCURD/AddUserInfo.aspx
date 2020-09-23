<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUserInfo.aspx.cs" Inherits="CZBK.TestProject.WebApp._2014_11_8.aspxCURD.AddUserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1"  runat="server">
        <input  type="hidden" name="isPostBack" value="1" />
    <div>
   <table>
        <tr><td>用户名</td><td><input type="text" name="txtName" /></td></tr>
          <tr><td>密码</td><td><input type="password" name="txtPwd" /></td></tr>
          <tr><td>邮箱</td><td><input type="text" name="txtEmail" /></td></tr>
        <tr><td colspan="3"><input type="submit" value="添加用户" />
            <span><%=ErrorMsg %></span>
            </td></tr>
    </table>
    </div>
    </form>
   
</body>
</html>
