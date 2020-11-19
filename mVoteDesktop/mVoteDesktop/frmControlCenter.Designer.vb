<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlCenter
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.高级功能ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.初始化数据库IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.用户账号UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.登录LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "选择常用功能"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.用户账号UToolStripMenuItem, Me.高级功能ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '高级功能ToolStripMenuItem
        '
        Me.高级功能ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.初始化数据库IToolStripMenuItem})
        Me.高级功能ToolStripMenuItem.Name = "高级功能ToolStripMenuItem"
        Me.高级功能ToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.高级功能ToolStripMenuItem.Text = "高级功能(&A)"
        '
        '初始化数据库IToolStripMenuItem
        '
        Me.初始化数据库IToolStripMenuItem.Name = "初始化数据库IToolStripMenuItem"
        Me.初始化数据库IToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.初始化数据库IToolStripMenuItem.Text = "初始化数据库(&I)"
        '
        '用户账号UToolStripMenuItem
        '
        Me.用户账号UToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.登录LToolStripMenuItem})
        Me.用户账号UToolStripMenuItem.Name = "用户账号UToolStripMenuItem"
        Me.用户账号UToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.用户账号UToolStripMenuItem.Text = "用户账号(&U)"
        '
        '登录LToolStripMenuItem
        '
        Me.登录LToolStripMenuItem.Name = "登录LToolStripMenuItem"
        Me.登录LToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.登录LToolStripMenuItem.Text = "登录(&L)"
        '
        'frmControlCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmControlCenter"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mVote控制中心"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 高级功能ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 初始化数据库IToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 用户账号UToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 登录LToolStripMenuItem As ToolStripMenuItem
End Class
