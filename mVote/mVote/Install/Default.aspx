<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="mVote.InitalizeSQL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>欢迎安装数据库，以下是您的数据库连接信息：</div>
        <div><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div>
        <div>请核对以上连接信息是否正确，如需要修改，请停止IIS，并编辑web.config</div>
        <div>
        </div>
    </form>
</body>
</html>
