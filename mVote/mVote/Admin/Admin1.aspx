<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Admin1.aspx.vb" Inherits="mVote.Admin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvAllLists" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="2" CellSpacing="1" DataSourceID="XmlDataSourceMVoteAll" EnableModelValidation="True" ForeColor="#333333" GridLines="None" PageSize="20" Width="100%">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="项目ID" HeaderText="项目ID" SortExpression="项目ID" />
                    <asp:BoundField DataField="创建日期" HeaderText="创建日期" SortExpression="创建日期" />
                    <asp:BoundField DataField="项目名称" HeaderText="项目名称" SortExpression="项目名称" />
                    <asp:CommandField HeaderText="操作" ShowDeleteButton="True" ShowInsertButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
            <asp:XmlDataSource ID="XmlDataSourceMVoteAll" runat="server" DataFile="~/Admin/mVoteAll.xml" EnableCaching="False" TransformFile="~/Admin/XSLTFile1.xslt"></asp:XmlDataSource>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
