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
            background-color:#CCCCCC;
            font-size:medium;
        }
        #tbAVR1C1 {
            text-align:center;
        }
        #tbAVR1C2 {
            text-align:center;
        }
        #tbAVR1C3 {
            text-align:center;
        }
        td.Col1 {
            width:10%;
            text-align:center;
            background-color:#EEEEEE;
        }
        td.Col2 {
            width:80%;
            background-color:#EEEEEE;
        }
        td.Col3 {
            width:10%;
            text-align:center;
            background-color:#EEEEEE;
        }td.Add1 {
            text-align:center;
            background-color:#EEEEEE;
        }
    </style>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="tbAllVotes" runat="server">
                <asp:TableRow runat="server" ID="tbAVR1">
                    <asp:TableCell runat="server" ID="tbAVR1C1" CssClass="Col1">项目ID</asp:TableCell>
                    <asp:TableCell runat="server" ID="tbAVR1C2" CssClass="Col2">项目名称</asp:TableCell>
                    <asp:TableCell runat="server" ID="tbAVR1C3" Cssclass="Col3">操作</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" CssClass="Col1">1</asp:TableCell>
                    <asp:TableCell runat="server" CssClass="Col2">NAme</asp:TableCell>
                    <asp:TableCell runat="server" CssClass="Col3">复制 删除</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" CssClass="Add1" >
                        <asp:Button ID="btnAdd" runat="server" Text="增加" BorderStyle="None" CssClass="Add1" Font-Size="Medium" /></asp:TableCell>
                    <asp:TableCell runat="server" CssClass="Add1" colspan="2"></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
