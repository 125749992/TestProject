<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="CZBK.TestProject.WebApp._2014_11_8.aspxCURD.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <input type="hidden" name="txtId" value="<%=Users.ID %>" />
   <table>
        <tr><td>用户名</td><td><input type="text" name="txtName" value="<%=Users.UserName %>" /></td></tr>
          <tr><td>密码</td><td><input type="text" name="txtPwd" value="<%=Users.UserPass %>" /></td></tr>
          <tr><td>邮箱</td><td><input type="text" name="txtEmail"  value="<%=Users.Email %>"/></td></tr>
           <tr><td>日期时间</td><td><input type="text" name="txtRegTime"  value="<%=Users.RegTime %>"/></td></tr>
        <tr><td colspan="4"><input type="submit" value="修改用户" /></td></tr>
    </table>
    </form>
</body>
</html>
