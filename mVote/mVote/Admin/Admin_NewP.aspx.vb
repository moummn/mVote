Public Class Admin_NewP
    Inherits System.Web.UI.Page
    Dim NewID As Long = 0
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        NewID = Int(Val(Request.QueryString("id").ToString))
        If NewID <= 0 Then
            NewID = 0
        Else
            Dim dv As DataView = SqlDataSource1.Select(DataSourceSelectArguments.Empty)
            lblid.Text = dv.Table.Rows(0).Item(0).ToString
            lblCDatetime.Text = dv.Table.Rows(0).Item(1).ToString
        End If
    End Sub

End Class