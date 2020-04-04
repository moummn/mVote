<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Admin.aspx.vb" Inherits="mVote.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <script type="text/javascript">
        //<![CDATA[
        var theForm = document.forms['form1'];
        if (!theForm) {
            theForm = document.form1;
        }
        function __doPostBack(eventTarget, eventArgument) {
            if (!theForm.onsubmit || (theForm.onsubmit() != false)) {
                theForm.__EVENTTARGET.value = eventTarget;
                theForm.__EVENTARGUMENT.value = eventArgument;
                theForm.submit();
            }
        }
        //]]>
    </script>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvAllLists" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource_mvoteindex" EnableModelValidation="True" AllowPaging="True" CellPadding="2" CellSpacing="1" ForeColor="#333333" GridLines="None" Width="100%" Font-Names="黑体" ShowFooter="True" PageSize="20">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="项目ID" ReadOnly="True" SortExpression="id" >
                    <HeaderStyle Width="10%" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="cdatetime" HeaderText="创建日期时间" SortExpression="cdatetime" >
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
                        <HeaderTemplate>
                            <asp:Button ID="BtnRefresh" runat="server" OnClick="BtnRefresh_Click" Text="刷新" />
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Button ID="BtnCopy" runat="server" CausesValidation="False" CommandName="Copy" Text="复制" OnClick="BtnCopy_Click" />
                            &nbsp;<asp:Button ID="BtnDelete" runat="server" CausesValidation="False" CommandName="Delete" Text="删除" />
                        </ItemTemplate>
                        <HeaderStyle Width="20%" />
                        <FooterTemplate>
                            <asp:Button ID="BtnNew" runat="server" Text="新建" OnClick="BtnNew_Click" />
                        </FooterTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                        <FooterStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                    
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerSettings FirstPageText="首页" LastPageText="尾页" Mode="NextPreviousFirstLast" NextPageText="下页" PreviousPageText="上页" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource_mvoteindex" runat="server" ConnectionString="<%$ ConnectionStrings:mVoteConnectionString %>" SelectCommand="SELECT * FROM [mvoteindex]" DeleteCommand="DELETE FROM [mvoteindex] WHERE [id] = @id" InsertCommand="INSERT INTO [mvoteindex] ([id], [cdatetime], [pname]) VALUES (@id, @cdatetime, @pname)" UpdateCommand="UPDATE [mvoteindex] SET [cdatetime] = @cdatetime, [pname] = @pname WHERE [id] = @id">
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mVoteConnectionString %>" SelectCommand="SELECT * FROM [mvoteindex]"></asp:SqlDataSource>
    </form>
</body>
</html>
