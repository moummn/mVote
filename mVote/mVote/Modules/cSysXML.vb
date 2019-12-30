Imports Microsoft.VisualBasic

Public Class CSysXML
    Dim mXmlDoc As New System.Xml.XmlDocument
    Public XmlFile As String

    Public Sub New(ByVal File As String)
        MyClass.XmlFile = File
        MyClass.mXmlDoc.Load(MyClass.XmlFile)       '加载配置文件  
    End Sub

    '功能：取得元素值  
    '参数：node--节点       element--元素名          
    '返回：元素值   字符型  
    '             $--表示出错误  
    Public Function GetElement(ByVal node As String, ByVal element As String) As String
        On Error GoTo Err
        Dim mXmlNode As System.Xml.XmlNode = mXmlDoc.SelectSingleNode("//" + node)

        '读数据  
        Dim xmlNode As System.Xml.XmlNode = mXmlNode.SelectSingleNode(element)
        Return xmlNode.InnerText.ToString
Err:
        Return "$"
    End Function
    '  
    '功能：保存元素值  
    '参数：node--节点名称     element--元素名       val--值  
    '返回：True--保存成功     False--保存失败  
    Public Function SaveElement(ByVal node As String, ByVal element As String, ByVal val As String) As Boolean
        On Error GoTo err
        Dim mXmlNode As System.Xml.XmlNode = mXmlDoc.SelectSingleNode("//" + node)
        Dim xmlNodeNew As System.Xml.XmlNode

        xmlNodeNew = mXmlNode.SelectSingleNode(element)
        xmlNodeNew.InnerText = val
        mXmlDoc.Save(MyClass.XmlFile)
        Return True
err:
        Return False
    End Function
End Class


'例如：

'XML：

'<?xml version="1.0" encoding="gb2312"?>
'<SystemIP>
'<IP>
'<num>192.168.0.6</num>
'</IP>
'</SystemIP>

'程序调用：

'Public Class Form1
'    Dim xml As New CSysXML("IP.xml")
'    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
'        Dim str As String = xml.GetElement("IP", "num")
'        TextBox1.Text = str
'    End Sub
'End Class
'————————————————
'版权声明： 本文为CSDN博主「骷髅会-北极熊」的原创文章，遵循 CC 4.0 BY-SA 版权协议，转载请附上原文出处链接及本声明。
'原文链接： https : //blog.csdn.net/wang19850219/article/details/41543473