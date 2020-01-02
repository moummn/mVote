Public Class _Default1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fnLoadVoteList(FILE_PATH, "Votelists.mvo")
        Dim tbr(UBound(VoteListID)) As TableRow
        Dim tbc1(UBound(VoteListID)), tbc2(UBound(VoteListID)), tbc3(UBound(VoteListID)) As TableCell
        For L As Long = 0 To UBound(VoteListID)
            Dim co As Control
            tbr(L) = New TableRow
            tbc1(L) = New TableCell
            tbc2(L) = New TableCell
            tbc3(L) = New TableCell
            tbc1(L).Text = CStr(VoteListID(L))
            tbc2(L).Text = VoteLists(L)
            'tbc3(L).Controls.Add()
            tbc3(L).Text = "复制 删除"
            tbc1(L).CssClass = "Col1"
            tbc2(L).CssClass = "Col2"
            tbc3(L).CssClass = "Col3"
            tbr(L).Cells.Add(tbc1(L))
            tbr(L).Cells.Add(tbc2(L))
            tbr(L).Cells.Add(tbc3(L))
            tbAllVotes.Rows.AddAt(tbAllVotes.Rows.Count - 1, tbr(L))
        Next

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        VLIDSN = VLIDSN + 1
        ReDim Preserve VoteListID(UBound(VoteListID) + 1)
        ReDim Preserve VoteLists(UBound(VoteLists) + 1)
        VoteListID(UBound(VoteListID)) = VLIDSN
        VoteLists(UBound(VoteLists)) = "新建项目"
        fnSaveVoteList(FILE_PATH, "Votelists.mvo")
        Response.Redirect(Request.Url.ToString())
    End Sub
End Class