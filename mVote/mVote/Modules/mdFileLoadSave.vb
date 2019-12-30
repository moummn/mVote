Module mdFileLoadSave
    Public Const FILE_PATH As String = ".\mVote\"
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
End Module
