<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Admin_EditP.aspx.vb" Inherits="mVote.Admin_EditP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .tbLeft {
            height: 21px;
            width: 90px;
        }
        .tbRight {
            height: 21px;
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            详细信息<br />
        <table style="width:100%;">
            <tr>
                <td class="tbLeft" >项目ID：</td>
                <td class="tbRight">
                    <asp:Label ID="lblid" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="tbLeft">创建时间：</td>
                <td><asp:Label ID="lblCDatetime" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="tbLeft">项目名称：</td>
                <td><asp:TextBox ID="tbPName" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td colspan="2" class="tbLeft">
                    <asp:Button ID="btnSave" runat="server" Text="保存" />

                &nbsp;<asp:Button ID="BtnCancel" runat="server" Text="取消" />

                </td>
            </tr>
        </table>
            
        </div>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mVoteConnectionString %>" SelectCommand="SELECT * FROM [mvoteindex]"></asp:SqlDataSource>        
    </form>
</body>
</html>
