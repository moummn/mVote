<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Admin_EditP.aspx.vb" Inherits="mVote.Admin_EditP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .tbProjectInfo{
            width:100%;
            border-spacing:0px;
            border-collapse:collapse;
            background-color:#E0E0E0;
        }
        .tbProjectInfo td{
            border:solid 1px Black;
        }
        .tbProjectInfo td.tdLeft {
            text-align:center;
            height: 21px;
            width: 90px;
        }
        .tbProjectInfo td.tdRight {
            height: 21px;
        }

        .tbProjectInfo td.tdLastRow{
            border:none;
            height: 21px;
            background-color:white;
        }
        .tbProjectInfo td.tdLastRow input[type=submit]{
            margin:3px 0px 0px 0px;
        }
        #tbPName{
            border:none;
            margin:-1px -1px -1px -1px;
            height:20px;
        }
        /*
        .tbBasicInfo{
            width:100%;
            border-spacing:0px;
            border-collapse:collapse;
        }
        .tbBasicInfo td{
            border:solid 1px Black;
        }
        .tbBasicInfo td.tdLeft{
            text-align:center;
            height: 21px;
            width: 90px;
        }
        .tbBasicInfo td.tdRight{
            height: 21px;
        }
            */
        
    </style>
</head>
<body>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mVoteConnectionString %>" SelectCommand="SELECT * FROM [mvoteindex]"></asp:SqlDataSource>        
    <form id="form1" runat="server">
        <div>
            项目信息<br />
                <table class="tbProjectInfo" style="width:100%;">
                    <tr>
                        <td class="tdLeft" >项目ID</td>
                        <td class="tdRight">
                            <asp:Label ID="lblid" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="tdLeft">创建时间</td>
                        <td><asp:Label ID="lblCDatetime" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="tdLeft">项目名称</td>
                        <td><asp:TextBox ID="tbPName" runat="server" Width="100%"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="tdLeft">起始时间</td>
                        <td class="tdRight"></td>
                    </tr>
                    <tr>
                        <td class="tdLeft">结束时间</td>
                        <td class="tdRight"></td>
                    </tr>
                    <tr style="display:none">
                        <td class="tdLeft">其他属性</td>
                        <td class="tdRight"></td>
                    </tr>
                    <tr>
                        <td colspan="2" class="tdLastRow">
                            <asp:Button ID="btnSave" runat="server" Text="保存" />
                            &nbsp;
                            <asp:Button ID="BtnCancel" runat="server" Text="取消" />
                            <br />
                            <asp:Button ID="btnEditVoteTemplate" runat="server" Text="编辑投票模板" />

                        </td>
                    </tr>
                </table>
            
            </div>
        
        
    </form>
</body>
</html>
