<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cbAutoLogin = New System.Windows.Forms.CheckBox()
        Me.tbPasw = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(12, 26)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(257, 23)
        Me.tbUser.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "密码"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 149)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(111, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "确定(&O)"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(158, 149)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "取消(&C)"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cbAutoLogin
        '
        Me.cbAutoLogin.AutoSize = True
        Me.cbAutoLogin.Location = New System.Drawing.Point(12, 119)
        Me.cbAutoLogin.Name = "cbAutoLogin"
        Me.cbAutoLogin.Size = New System.Drawing.Size(103, 18)
        Me.cbAutoLogin.TabIndex = 3
        Me.cbAutoLogin.Text = "自动登录(&A)"
        Me.cbAutoLogin.UseVisualStyleBackColor = True
        '
        'tbPasw
        '
        Me.tbPasw.Location = New System.Drawing.Point(12, 82)
        Me.tbPasw.Name = "tbPasw"
        Me.tbPasw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPasw.Size = New System.Drawing.Size(257, 23)
        Me.tbPasw.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "用户名"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(284, 188)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbPasw)
        Me.Controls.Add(Me.cbAutoLogin)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "登录mVote"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cbAutoLogin As CheckBox
    Friend WithEvents tbPasw As TextBox
    Friend WithEvents Label2 As Label
End Class
