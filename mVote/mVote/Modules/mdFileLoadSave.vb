Module mdFileLoadSave
    Public Const FILE_PATH As String = ".\mVote\"
    Public VoteLists() As String
    Public VoteListID() As Long
    Public Function fnSaveConfig(FileName) As Long
        Dim FileNum As Long = FreeFile()
Line_FileOpen:
        Try
            FileOpen(FileNum, FileName, OpenMode.Output)
        Catch ex As System.IO.DirectoryNotFoundException
            MkDir(FILE_PATH)
            GoTo Line_FileOpen
        End Try
        Write(FileNum, "SavedConfig")
        FileClose(FileNum)
    End Function
    Public Function fnLoadVoteList(ByVal FileName As String) As Long
        'Dim FileNum As Long = FreeFile()

        fnLoadVoteList = 0
        ReDim VoteLists(-1)
        ReDim VoteListID(-1)
Line_FileOpen:

        Try
            Dim S As String = System.IO.File.ReadAllText(FileName, System.Text.Encoding.UTF8)
        Catch ex As System.IO.DirectoryNotFoundException

        End Try
        'FileOpen(FileNum, FileName, OpenMode.Binary)
        'Get(filenum,)
        ' FileClose(FileNum)
    End Function
    Public Function fnSaveVoteList(ByVal FileName As String) As Long
        fnSaveVoteList = 0
        Dim S As String = ""
        Dim S1 As String = ""
        Dim L1 As Long = 0
        For L As Long = 0 To UBound(VoteLists)
            S1 = VoteLists(L)
            L1 = VoteListID(L)
            If S = "" Then
                S = S1
            Else
                S = vbCrLf & S1
            End If
        Next
        'Dim t As System.IO.StreamWriter = New System.IO.StreamWriter(FileName, True, System.Text.Encoding.UTF8)
        't.Write(TextTB.Text)
        't.Close()
    End Function
End Module
