<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Admin.aspx.vb" Inherits="mVote.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvAllLists" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource_mvoteindex" EnableModelValidation="True" AllowPaging="True" CellPadding="2" CellSpacing="1" ForeColor="#333333" GridLines="None" Width="100%" Font-Names="黑体" ShowFooter="True">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="项目ID" ReadOnly="True" SortExpression="id" >
                    <HeaderStyle Width="10%" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="cdatetime" HeaderText="创建日期时间" SortExpression="cdatetime" InsertVisible="False" ReadOnly="True" >
                    <HeaderStyle Width="20%" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="pname" HeaderText="名称" SortExpression="pname" >
                    <HeaderStyle Width="50%" />
                    </asp:BoundField>
                    <%--<asp:CommandField ButtonType="Button" HeaderText="操作" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" EditText="重命名" NewText="复制" ShowInsertButton="True" >
                    <HeaderStyle Width="20%" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:CommandField>--%>
                    <asp:TemplateField HeaderText="操作">
                        <EditItemTemplate>
                            <asp:Button ID="Button1" runat="server" CausesValidation="True" CommandName="Update" Text="更新" />
                            &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandName="Edit" Text="重命名" />
                            &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="New" Text="复制" />
                            &nbsp;<asp:Button ID="Button3" runat="server" CausesValidation="False" CommandName="Delete" Text="删除" />
                        </ItemTemplate>
                        <HeaderStyle Width="20%" />
                        <FooterTemplate>
                            <asp:Button ID="Button4" runat="server" Text="新建" />
                        </FooterTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                        <FooterStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                    
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource_mvoteindex" runat="server" ConnectionString="<%$ ConnectionStrings:mVoteConnectionString %>" SelectCommand="SELECT * FROM [mvoteindex]" DeleteCommand="DELETE FROM [mvoteindex] WHERE [id] = @id" InsertCommand="INSERT INTO [mvoteindex] ([id], [cdatetime], [pname]) VALUES (@id, @cdatetime, @pname)" UpdateCommand="UPDATE [mvoteindex] SET [pname] = @pname WHERE [id] = @id">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                    <asp:Parameter DbType="DateTime2" Name="cdatetime" />
                    <asp:Parameter Name="pname" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter DbType="DateTime2" Name="cdatetime" />
                    <asp:Parameter Name="pname" Type="String" />
                    <asp:Parameter Name="id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
