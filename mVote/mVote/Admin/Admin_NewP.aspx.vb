Public Class Admin_NewP
    Inherits System.Web.UI.Page
    Dim SourceID As Long = 0
    Dim sqlcDatetime As Date = Now
    Dim NewID As Long = 0
    Private Function FnGetNewID() As Long
        SqlDataSource1.SelectCommand = "SELECT IDENT_CURRENT('mvoteindex')"
        Dim dv As DataView = SqlDataSource1.Select(DataSourceSelectArguments.Empty)
        Return Int(Val(dv.Table.Rows(0).Item(0).ToString))
    End Function
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SourceID = Int(Val(Request.QueryString("id")))
        NewID = FnGetNewID() + 1
        If SourceID <= 0 OrElse SourceID > NewID Then
            SourceID = 0
        Else
            SqlDataSource1.SelectCommand = "SELECT * FROM [mvoteindex] WHERE id=" & CStr(SourceID)
            Dim dv As DataView = SqlDataSource1.Select(DataSourceSelectArguments.Empty)
            Try
                tbPName.Text = dv.Table.Rows(0).Item(2).ToString
            Catch ex As System.IndexOutOfRangeException
            End Try
        End If
        lblid.Text = CStr(NewID)
        lblCDatetime.Text = sqlcDatetime.ToString
    End Sub
    Protected Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Response.Write("<script>window.opener=null;window.close();</script>")
    End Sub
    Protected Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SqlDataSource1.InsertCommand = "INSERT INTO mvoteindex ( cdatetime, pname) VALUES ('" &
            sqlcDatetime.ToString & "', '" & tbPName.Text & "')"
        'SqlDataSource1.InsertCommand = "INSERT INTO mvoteindex ( cdatetime, pname) VALUES (" &
        '    CStr(NewID) & ", '" & sqlcDatetime.ToString & "', '" & tbPName.Text & "')"
        SqlDataSource1.Insert()
        Response.Write("<script>window.opener=null;window.close();</script>")
    End Sub
End Class