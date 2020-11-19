Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '加载配置

        Me.tbUser.Text = My.Settings.LoginUser
        Me.tbPasw.Text = My.Settings.LoginPasw
        Me.cbAutoLogin.Checked = My.Settings.AutoLogin
        ActiveControl = Me.tbUser
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        '保存配置

        My.Settings.LoginUser = Me.tbUser.Text
        My.Settings.AutoLogin = Me.cbAutoLogin.Checked
        If Me.cbAutoLogin.Checked = True Then
            My.Settings.LoginPasw = Me.tbPasw.Text
        Else
            My.Settings.LoginPasw = ""
        End If

        Me.Close()
    End Sub
End Class