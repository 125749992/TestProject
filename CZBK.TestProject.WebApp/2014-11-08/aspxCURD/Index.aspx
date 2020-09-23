<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CZBK.TestProject.WebApp._2014_11_8.aspxCURD.Index" %>
<%@ Import Namespace="CZBK.TestProject.Model" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        window.onload = function () {
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <a href="AddUserInfo.aspx">添加用户</a>
    <table>
        <tr>
            <th>编号</th><th>用户名</th><th>密码</th><th>时间</th><th>邮箱</th><th>详细</th><th>删除</th><th>编辑</th>
        </tr>
        <%--<%=StrHtml %>--%>
        <%foreach(UserInfo userInfo in UserInfoList){%>
          <tr>
              <td><%=userInfo.ID %></td>
                 <td><%=userInfo.UserName %></td>
                 <td><%=userInfo.UserPass %></td>
                 <td><%=userInfo.RegTime.ToShortDateString() %></td>
                 <td><%=userInfo.Email %></td>
              <td><a href="ShowDetail.aspx?id=<%=userInfo.ID %>">详细</a></td>
               <td><a href="Delete.ashx?id=<%=userInfo.ID %>">删除</a></td>
               <td><a href="Edit.aspx?id=<%=userInfo.ID %>">编辑</a></td>
          </tr>
        <%} %>
    </table>
    </div>
    </form>
</body>
</html>
