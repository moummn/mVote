Public Class TEST
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Long = Val(TextBox1.Text) + 1
        TextBox2.Text = A.ToString
    End Sub
End Class