<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="mVote.InitalizeSQL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" SelectCommand="SELECT * FROM [Table]" ConnectionString="<%$ ConnectionStrings:LocalMasterConnectionString %>"></asp:SqlDataSource>
    欢迎安装数据库，您的数据库是：
        <div>
        </div>
    </form>
</body>
</html>
