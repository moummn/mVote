Public Class Admin_EditP
    Inherits System.Web.UI.Page
    Dim sqlID As Long = 0
    'Dim sqlcDatetime As Date = Now
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sqlID = Int(Val(Request.QueryString("id")))
        If sqlID <= 0 Then
            'SqlDataSource1.SelectCommand = "SELECT IDENT_CURRENT('mvoteindex')"
            'Dim dv As DataView = SqlDataSource1.Select(DataSourceSelectArguments.Empty)
            'NewID = Int(Val(dv.Table.Rows(0).Item(0).ToString))
            'lblid.Text = CStr(NewID)
            'lblCDatetime.Text = sqlcDatetime.ToString

        Else
            SqlDataSource1.SelectCommand = "SELECT * FROM [mvoteindex] WHERE id=" & CStr(sqlID)
            Dim dv As DataView = SqlDataSource1.Select(DataSourceSelectArguments.Empty)
            Try
                lblid.Text = dv.Table.Rows(0).Item(0).ToString
                lblCDatetime.Text = dv.Table.Rows(0).Item(1).ToString
                tbPName.Text = dv.Table.Rows(0).Item(2).ToString
            Catch ex As System.IndexOutOfRangeException
            End Try

        End If
    End Sub

End Class