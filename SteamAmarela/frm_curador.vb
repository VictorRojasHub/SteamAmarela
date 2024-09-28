Public Class frm_curador

    Private Sub frm_curador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarJogos()
    End Sub

    Private Sub CarregarJogos()
        Dim SQL As String = "SELECT * FROM Games WHERE Status = 'Pending'"
        Dim rs = db.Execute(SQL)
        dgv_jogos.Rows.Clear()

        While Not rs.EOF
            dgv_jogos.Rows.Add(rs.Fields("GameID").Value, rs.Fields("Title").Value, rs.Fields("Description").Value,
                               rs.Fields("Price").Value, "Aprovar", "Rejeitar")
            rs.MoveNext()
        End While
    End Sub

    Private Sub dgv_jogos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_jogos.CellContentClick
        If e.RowIndex >= 0 Then
            Dim gameId As Integer = dgv_jogos.Rows(e.RowIndex).Cells("GameID").Value

            If e.ColumnIndex = dgv_jogos.Columns("Aprovar").Index Then
                AprovarJogo(gameId)
            ElseIf e.ColumnIndex = dgv_jogos.Columns("Rejeitar").Index Then
                RejeitarJogo(gameId)
            End If
        End If
    End Sub

    Private Sub AprovarJogo(gameId As Integer)
        Dim SQL As String = "UPDATE Games SET Status = 'Approved' WHERE GameID = " & gameId
        db.Execute(SQL)
        MsgBox("Jogo aprovado com sucesso!", MsgBoxStyle.Information)
        CarregarJogos() ' Atualiza a lista de jogos
    End Sub

    Private Sub RejeitarJogo(gameId As Integer)
        Dim SQL As String = "UPDATE Games SET Status = 'Rejected' WHERE GameID = " & gameId
        db.Execute(SQL)
        MsgBox("Jogo rejeitado com sucesso!", MsgBoxStyle.Information)
        CarregarJogos() ' Atualiza a lista de jogos
    End Sub
End Class
