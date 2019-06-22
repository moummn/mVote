Public Class InitalizeSQL
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = Web.Configuration.WebConfigurationManager.ConnectionStrings(0).ConnectionString

    End Sub

End Class