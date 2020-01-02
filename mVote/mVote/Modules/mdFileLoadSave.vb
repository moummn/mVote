Module mdFileLoadSave
    Public Const FILE_PATH As String = ".\mVote\"
    Public VoteLists() As String
    Public VoteListID() As Long
    Public VLIDSN As Long
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
    Public Function fnLoadVoteList(ByVal FilePath As String, ByVal FileName As String) As Long
        'Dim FileNum As Long = FreeFile()
        VLIDSN = 0
        Dim St() As String
        fnLoadVoteList = 0
        ReDim VoteLists(-1)
        ReDim VoteListID(-1)
        Dim I As Long = 0
Line_FileOpen:

        Try
            Dim S As String = System.IO.File.ReadAllText(FilePath & FileName, System.Text.Encoding.UTF8)
            St = Split(S, vbCrLf, Compare:=CompareMethod.Binary)
            For L As Long = 0 To UBound(St)
                If L <= 0 Then '读首行
                    VLIDSN = Val(Trim(St(L)))
                Else '读其他行
                    I = InStr(1, St(L), "|", CompareMethod.Binary)
                    If I > 0 Then
                        ReDim Preserve VoteListID(UBound(VoteListID) + 1)
                        ReDim Preserve VoteLists(UBound(VoteLists) + 1)
                        VoteListID(UBound(VoteListID)) = Val(Trim(Left(St(L), I - 1)))
                        VoteLists(UBound(VoteLists)) = Mid(St(L), I + 1, Len(St(L)) - I)
                        VoteLists(UBound(VoteLists)) = Replace(VoteLists(UBound(VoteLists)), "<crlf>", vbCrLf, Compare:=CompareMethod.Binary)
                    End If
                End If
            Next
        Catch ex As System.IO.DirectoryNotFoundException
        Catch ex As System.IO.FileNotFoundException

        End Try
        'FileOpen(FileNum, FileName, OpenMode.Binary)
        'Get(filenum,)
        ' FileClose(FileNum)
    End Function
    Public Function fnSaveVoteList(ByVal FilePath As String, ByVal FileName As String) As Long
        fnSaveVoteList = 0
        Dim S As String = ""
        Dim S1 As String = ""
        Dim L1 As Long = 0
        S = CStr(VLIDSN)
        For L As Long = 0 To UBound(VoteLists)
            S1 = VoteLists(L)
            S1 = Replace(S1, vbCrLf, "<crlf>", Compare:=CompareMethod.Binary)
            L1 = VoteListID(L)
            S &= vbCrLf & L1 & "|" & S1
        Next
Line_FileSave:
        Try
            Dim t As System.IO.StreamWriter = New System.IO.StreamWriter(FilePath & FileName, False, System.Text.Encoding.UTF8)
            t.Write(S)
            t.Close()
        Catch ex As System.IO.DirectoryNotFoundException
            System.IO.Directory.CreateDirectory(FilePath)
            GoTo Line_FileSave
        End Try

    End Function
End Module
