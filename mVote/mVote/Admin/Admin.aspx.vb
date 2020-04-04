Public Class Admin
    Inherits System.Web.UI.Page
    Private Function FnGetNewID() As Long
        SqlDataSource1.SelectCommand = "SELECT IDENT_CURRENT('mvoteindex')"
        Dim dv As DataView = SqlDataSource1.Select(DataSourceSelectArguments.Empty)
        Return Int(Val(dv.Table.Rows(0).Item(0).ToString))
    End Function
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim S As String = ""
        For I As Long = 0 To gvAllLists.Rows.Count - 1
            S = gvAllLists.Rows(I).Cells(2).Text
            gvAllLists.Rows(I).Cells(2).Text = "<a href="".\Admin_EditP.aspx?id=" & gvAllLists.Rows(I).Cells(0).Text & """ target=""newwindow"">" & S & "</a>"
        Next
    End Sub

    Protected Sub BtnCopy_Click(sender As Object, e As EventArgs)
        Dim RowIndex As Integer = sender.BindingContainer.RowIndex
        Dim RowID As Long = CLng(gvAllLists.Rows(RowIndex).Cells(0).Text)
        Response.Redirect("Admin_NewP.aspx?id=" & CStr(RowID))
        'Response.Write("<script language='javascript'>window.open('Admin_NewP.aspx?id=" & CStr(RowID) & "','newwindow','width=600,height=600')</script>")
        'Response.Write("<script>window.showModelessDialog('Admin_NewP.aspx')</script>")

        Exit Sub
ErrLine:
    End Sub
    Protected Sub BtnNew_Click(sender As Object, e As EventArgs)
        Response.Write("<script language='javascript'>window.open('Admin_NewP.aspx','_blank','width=600,height=600')</script>")
    End Sub

    Protected Sub BtnRefresh_Click(sender As Object, e As EventArgs)
        Response.Redirect(Request.RawUrl)
    End Sub

End Class