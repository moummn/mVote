Public Class _Default1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub MKXML_Click1(sender As Object, e As EventArgs) Handles MKXML.Click
        Dim xml As New CSysXML("IP.xml")
        Label1.Text = xml.SaveElement("node", "Element", "Val")
        xml = Nothing
    End Sub
End Class