Public Class Admin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim S As String = ""
        For I As Long = 0 To gvAllLists.Rows.Count - 1
            S = gvAllLists.Rows(I).Cells(2).Text
            gvAllLists.Rows(I).Cells(2).Text = "<a href="".\Admin_EditP.aspx?id=" & gvAllLists.Rows(I).Cells(0).Text & """ target=""_blank"">" & S & "</a>"
        Next
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs)
        Dim RowIndex As Integer = sender.BindingContainer.RowIndex
        'Todo
    End Sub
End Class