Public Class frmAdicionarFundo

    ' Variáveis para armazenar o valor e método de pagamento selecionado
    Private valorFundo As Decimal
    Private metodoPagamento As String

    ' Carregar o formulário
    Private Sub frmAdicionarFundo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Popula o ComboBox com opções de pagamento
        cboMetodoPagamento.Items.Add("Cartão de Crédito")
        cboMetodoPagamento.Items.Add("Boleto")
        cboMetodoPagamento.Items.Add("PIX")
        cboMetodoPagamento.Items.Add("PayPal")
        cboMetodoPagamento.SelectedIndex = 0 ' Seleciona o primeiro método por padrão
    End Sub

    ' Botão para confirmar a adição de fundos
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        ' Verifica se o valor inserido é válido
        If Decimal.TryParse(txtValor.Text, valorFundo) AndAlso valorFundo > 0 Then
            metodoPagamento = cboMetodoPagamento.SelectedItem.ToString()

            ' Aqui você pode implementar a lógica de pagamento ou apenas simular o processo
            ' Exemplo: Mostrar uma mensagem com os detalhes do pagamento
            MsgBox("Valor a ser adicionado: R$ " & valorFundo.ToString("F2") & vbCrLf &
                   "Método de pagamento: " & metodoPagamento, MsgBoxStyle.Information, "Confirmação de Pagamento")

            ' Atualiza o saldo da carteira (simulação)
            AtualizarSaldoUsuario(valorFundo)

            ' Fecha o formulário após a confirmação
            Me.Close()
        Else
            MsgBox("Por favor, insira um valor válido.", MsgBoxStyle.Exclamation, "Valor Inválido")
        End If
    End Sub

    ' Função para atualizar o saldo da carteira
    Private Sub AtualizarSaldoUsuario(valor As Decimal)
        ' Atualiza o saldo no banco de dados
        Try
            Dim SQL As String = "UPDATE Users SET wallet = wallet + " & valor & " WHERE UserID = " & CurrentUserIDINT
            db.Execute(SQL)
            MsgBox("Saldo atualizado com sucesso!", MsgBoxStyle.Information, "Saldo Atualizado")

            ' Atualiza o valor exibido no form principal
            Form1.lbl_wallet.Text = "Saldo: R$ " & (ObterSaldoUsuario()).ToString("F2")

        Catch ex As Exception
            MsgBox("Erro ao atualizar saldo: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    ' Função para obter o saldo atual do usuário
    Private Function ObterSaldoUsuario() As Decimal
        Dim SQL As String = "SELECT wallet FROM Users WHERE UserID = " & CurrentUserIDINT
        Dim rs = db.Execute(SQL)

        If Not rs.EOF Then
            Return rs.Fields("wallet").Value
        End If

        Return 0
    End Function

    ' Botão para cancelar a operação
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close() ' Fecha o formulário
    End Sub

End Class
