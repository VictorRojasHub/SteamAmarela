Public Class frm_admin
    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        ConfigurarDataGridView()
        carregarDgvAdmin()
    End Sub


    Sub carregarDgvAdmin()
        Try
            ' SQL para selecionar todos os usuários
            SQL = "SELECT Username, Email, Role FROM Users ORDER BY UserID ASC"
            rs = db.Execute(SQL)

            ' Limpa o DataGridView antes de carregar novos dados
            dgvUsers.Rows.Clear()

            ' Verifica se há registros
            If rs.EOF = False Then
                ' Adiciona as linhas ao DataGridView
                Do While Not rs.EOF
                    dgvUsers.Rows.Add(rs.Fields("Username").Value, rs.Fields("Email").Value, rs.Fields("Role").Value)
                    rs.MoveNext()
                Loop
            End If

        Catch ex As Exception
            MsgBox("Erro ao carregar dados: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub ConfigurarDataGridView()
        ' Limpa as colunas existentes
        dgvUsers.Columns.Clear()

        ' Adiciona colunas principais
        dgvUsers.Columns.Add("Username", "Username")
        dgvUsers.Columns.Add("Email", "Email")
        dgvUsers.Columns.Add("Role", "Role")

        ' Definir largura das colunas
        dgvUsers.Columns("Username").Width = 150
        dgvUsers.Columns("Email").Width = 200
        dgvUsers.Columns("Role").Width = 100

        ' Adiciona coluna de botão Promote
        Dim btnPromote As New DataGridViewButtonColumn
        btnPromote.Name = "Promote"
        btnPromote.HeaderText = "Promote"
        btnPromote.Text = "Promote"
        btnPromote.UseColumnTextForButtonValue = True
        dgvUsers.Columns.Add(btnPromote)

        ' Adiciona coluna de botão Downgrade
        Dim btnDowngrade As New DataGridViewButtonColumn
        btnDowngrade.Name = "Downgrade"
        btnDowngrade.HeaderText = "Downgrade"
        btnDowngrade.Text = "Downgrade"
        btnDowngrade.UseColumnTextForButtonValue = True
        dgvUsers.Columns.Add(btnDowngrade)

        ' Adiciona coluna de botão Edit
        Dim btnEdit As New DataGridViewButtonColumn
        btnEdit.Name = "Edit"
        btnEdit.HeaderText = "Edit"
        btnEdit.Text = "Edit"
        btnEdit.UseColumnTextForButtonValue = True
        dgvUsers.Columns.Add(btnEdit)

        ' Adiciona coluna de botão Delete
        Dim btnDelete As New DataGridViewButtonColumn
        btnDelete.Name = "Delete"
        btnDelete.HeaderText = "Delete"
        btnDelete.Text = "Delete"
        btnDelete.UseColumnTextForButtonValue = True
        dgvUsers.Columns.Add(btnDelete)
    End Sub


    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
        ' Verifica se o clique foi em um botão
        If e.RowIndex >= 0 Then
            Dim selectedUsername As String = dgvUsers.Rows(e.RowIndex).Cells("Username").Value.ToString()

            ' Verifica qual botão foi clicado
            Select Case dgvUsers.Columns(e.ColumnIndex).Name
                Case "Promote"
                    Dim role As String = dgvUsers.Rows(e.RowIndex).Cells("Role").Value.ToString()

                    ' Lógica de promoção
                    If role = "user" Then
                        AtualizarRole(e.RowIndex, "developer")
                    ElseIf role = "developer" Then
                        AtualizarRole(e.RowIndex, "curador")
                    End If

                Case "Downgrade"
                    ' Lógica para rebaixar usuário
                    DowngradeUser(selectedUsername)

                Case "Edit"
                    ' Lógica para editar usuário
                    EditUser(selectedUsername)

                Case "Delete"
                    ' Lógica para excluir usuário
                    DeleteUser(selectedUsername)
            End Select
        End If
    End Sub

    Private Sub PromoteUser(username As String)
        Try
            SQL = "UPDATE Users SET Role = '' WHERE Username = '" & username & "'"
            db.Execute(SQL)
            MsgBox("Usuário promovido para admin!", MsgBoxStyle.Information)
            carregarDgvAdmin() ' Recarrega os dados no DataGridView
        Catch ex As Exception
            MsgBox("Erro ao promover usuário: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub DowngradeUser(username As String)
        Try
            SQL = "UPDATE Users SET Role = 'user' WHERE Username = '" & username & "'"
            db.Execute(SQL)
            MsgBox("Usuário rebaixado para user!", MsgBoxStyle.Information)
            carregarDgvAdmin() ' Recarrega os dados no DataGridView
        Catch ex As Exception
            MsgBox("Erro ao rebaixar usuário: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub DeleteUser(username As String)
        Try
            Dim confirm = MsgBox("Tem certeza que deseja excluir o usuário '" & username & "'?", MsgBoxStyle.YesNo)
            If confirm = MsgBoxResult.Yes Then
                SQL = "DELETE FROM Users WHERE Username = '" & username & "'"
                db.Execute(SQL)
                MsgBox("Usuário excluído com sucesso!", MsgBoxStyle.Information)
                carregarDgvAdmin() ' Recarrega os dados no DataGridView
            End If
        Catch ex As Exception
            MsgBox("Erro ao excluir usuário: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub EditUser(username As String)
        Try
            SQL = "UPDATE Users SET Role = 'user' WHERE Username = '" & username & "'"
            db.Execute(SQL)
            MsgBox("Usuário rebaixado para user!", MsgBoxStyle.Information)
            carregarDgvAdmin() ' Recarrega os dados no DataGridView
        Catch ex As Exception
            MsgBox("Erro ao rebaixar usuário: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub AtualizarRole(rowIndex As Integer, novoRole As String)
        Try
            Dim username As String = dgvUsers.Rows(rowIndex).Cells("Username").Value.ToString()
            SQL = "UPDATE Users SET Role = '" & novoRole & "' WHERE Username = '" & username & "'"
            db.Execute(SQL)

            ' Atualiza o DataGridView com o novo role
            dgvUsers.Rows(rowIndex).Cells("Role").Value = novoRole
            MsgBox("Usuário promovido para " & novoRole, MsgBoxStyle.Information, "Sucesso")
        Catch ex As Exception
            MsgBox("Erro ao promover usuário: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
End Class