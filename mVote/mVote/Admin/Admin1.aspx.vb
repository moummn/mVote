Public Class Admin1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub gvAllLists_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles gvAllLists.RowDeleting
        Label1.Text = e.RowIndex
        'XmlDataSourceMVoteAll
        'e.Cancel = True
    End Sub
End Class