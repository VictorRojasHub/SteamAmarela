Public Class frmExcluirJogo
    Private Sub frmExcluirJogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarJogos()
    End Sub

    ' Método para carregar jogos no DataGridView
    Private Sub CarregarJogos()
        Try
            ' Consulta SQL para obter os jogos
            Dim SQL As String = "SELECT GameID, Title, DeveloperID FROM Games"
            rs = db.Execute(SQL)

            ' Configura o DataGridView
            dgvJogos.Rows.Clear()
            dgvJogos.Columns.Clear()

            ' Adiciona as colunas ao DataGridView
            dgvJogos.Columns.Add("GameID", "ID")
            dgvJogos.Columns.Add("Title", "Título")
            dgvJogos.Columns.Add("DeveloperID", "ID do Desenvolvedor")

            ' Loop para adicionar os jogos ao DataGridView
            While Not rs.EOF
                dgvJogos.Rows.Add(rs.Fields("GameID").Value, rs.Fields("Title").Value, rs.Fields("DeveloperID").Value)
                rs.MoveNext()
            End While

        Catch ex As Exception
            MsgBox("Erro ao carregar jogos: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    ' Método para excluir o jogo selecionado
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            ' Verifica se há uma linha selecionada no DataGridView
            If dgvJogos.SelectedRows.Count > 0 Then
                Dim GameID As Integer = CInt(dgvJogos.SelectedRows(0).Cells("GameID").Value)

                ' Confirmação de exclusão
                If MsgBox("Deseja realmente excluir o jogo? Isso também excluirá todas as compras relacionadas.", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                    ' Exclui primeiro os registros na tabela Purchases relacionados ao jogo
                    Dim SQLPurchases As String = "DELETE FROM Purchases WHERE GameID = " & GameID
                    db.Execute(SQLPurchases)

                    ' Comando SQL para excluir o jogo
                    Dim SQLGame As String = "DELETE FROM Games WHERE GameID = " & GameID
                    db.Execute(SQLGame)

                    MsgBox("Jogo e compras relacionadas excluídos com sucesso.", MsgBoxStyle.Information, "Sucesso")

                    ' Recarrega os jogos no DataGridView
                    CarregarJogos()
                End If
            Else
                MsgBox("Selecione um jogo para excluir.", MsgBoxStyle.Exclamation, "Atenção")
            End If

        Catch ex As Exception
            MsgBox("Erro ao excluir jogo: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

End Class
