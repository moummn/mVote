<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Admin.aspx.vb" Inherits="mVote._Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/layout.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <style>
        #tbAllVotes {
            width:100%;
        }
        #tbAVR1C1 {
            width:10%;
            text-align:center;
        }
        #tbAVR1C2 {
            width:80%;
            text-align:center;
        }
        #tbAVR1C3 {
            width:10%;
            text-align:center;
        }
    </style>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="tbAllVotes" runat="server">
                <asp:TableRow runat="server" ID="tbAVR1">
                    <asp:TableCell runat="server" ID="tbAVR1C1">项目ID</asp:TableCell>
                    <asp:TableCell runat="server" ID="tbAVR1C2">项目名称</asp:TableCell>
                    <asp:TableCell runat="server" ID="tbAVR1C3">操作</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">1</asp:TableCell>
                    <asp:TableCell runat="server">NAme</asp:TableCell>
                    <asp:TableCell runat="server">删除</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
