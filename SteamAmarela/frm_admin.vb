Public Class frm_admin
    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        ConfigurarDataGridView()
        carregarDgvAdmin()
    End Sub


    Sub carregarDgvAdmin()
        Try
            ' SQL para selecionar todos os usuários com a coluna Blocked
            SQL = "SELECT Username, Email, Role, Blocked FROM Users ORDER BY UserID ASC"
            rs = db.Execute(SQL)

            ' Limpa o DataGridView antes de carregar novos dados
            dgvUsers.Rows.Clear()

            ' Verifica se há registros
            If rs.EOF = False Then
                ' Adiciona as linhas ao DataGridView
                Do While Not rs.EOF
                    dgvUsers.Rows.Add(rs.Fields("Username").Value, rs.Fields("Email").Value, rs.Fields("Role").Value, rs.Fields("Blocked").Value)
                    rs.MoveNext()
                Loop
            End If

        Catch ex As Exception
            MsgBox("Erro ao carregar dados: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub BlockUser(username As String, isBlocked As Boolean)
        Try
            ' Define a consulta SQL com base no estado de bloqueio atual
            Dim newBlockedStatus As Integer = If(isBlocked, 0, 1) ' Alterna entre bloquear e desbloquear

            ' SQL para atualizar o status de bloqueio do usuário
            SQL = "UPDATE Users SET Blocked = " & newBlockedStatus & " WHERE Username = '" & username & "'"
            db.Execute(SQL)

            ' Exibe uma mensagem indicando se o usuário foi bloqueado ou desbloqueado
            If newBlockedStatus = 1 Then
                MsgBox("Usuário bloqueado com sucesso!", MsgBoxStyle.Information)
            Else
                MsgBox("Usuário desbloqueado com sucesso!", MsgBoxStyle.Information)
            End If

            ' Recarregar os dados no DataGridView após atualizar o bloqueio
            carregarDgvAdmin()

        Catch ex As Exception
            ' Mensagem de erro em caso de falha
            MsgBox("Erro ao atualizar o status de bloqueio do usuário: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub ConfigurarDataGridView()
        ' Limpa as colunas existentes
        dgvUsers.Columns.Clear()

        ' Adiciona colunas principais
        dgvUsers.Columns.Add("Username", "Username")
        dgvUsers.Columns.Add("Email", "Email")
        dgvUsers.Columns.Add("Role", "Role")

        ' Adiciona coluna para o status de bloqueio
        dgvUsers.Columns.Add("Blocked", "Blocked")

        ' Definir largura das colunas
        dgvUsers.Columns("Username").Width = 150
        dgvUsers.Columns("Email").Width = 200
        dgvUsers.Columns("Role").Width = 100
        dgvUsers.Columns("Blocked").Width = 80 ' Largura da coluna Blocked

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

        ' Adiciona coluna de botão BlockUser
        Dim btnBlockUser As New DataGridViewButtonColumn
        btnBlockUser.Name = "btnBlockUser"
        btnBlockUser.HeaderText = "Block User"
        btnBlockUser.Text = "Block"
        btnBlockUser.UseColumnTextForButtonValue = True
        dgvUsers.Columns.Add(btnBlockUser)
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

                Case "btnBlockUser"
                    ' Pega o status de bloqueio atual do usuário
                    Dim isBlocked As Boolean = Convert.ToBoolean(dgvUsers.Rows(e.RowIndex).Cells("Blocked").Value)
                    Block1(selectedUsername)
                    ' Chama a função para bloquear/desbloquear o usuário
                    BlockUser(selectedUsername, isBlocked)
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


    Private Sub Block1(username As String)
        Try
            SQL = "UPDATE Users SET Role = 'blocked' WHERE Username = '" & username & "'"
            db.Execute(SQL)
            MsgBox("Usuário bloqueado!!", MsgBoxStyle.Information)
            carregarDgvAdmin() ' Recarrega os dados no DataGridView
        Catch ex As Exception
            MsgBox("Erro ao rebaixar usuário: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



End Class