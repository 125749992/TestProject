<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JqueryAjax_Demo.aspx.cs" Inherits="CZBK.TestProject.WebApp._2014_11_13.JqueryAjax_Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../js/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#btnGetDate").click(function () {
                $.post("Ajax_Get.ashx", { "name": "itcast", "pwd": "123" }, function (data) {
                    //从服务端返回的数据自动填充到回调函数的data参数中。
                    //alert(data);
                    var serverData = data.split(':');
                    alert("用户名是:"+serverData[0]+",密码是:"+serverData[1]);
                });
                
            })
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input type="button" value="时间" id="btnGetDate" />
    </div>
    </form>
</body>
</html>
