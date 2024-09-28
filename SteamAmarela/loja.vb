Imports System.Drawing

Public Class loja
    Dim images As New List(Of String)
    Dim currentImageIndex As Integer = 0
    Dim WithEvents carouselTimer As New Timer() With {.Interval = 3000} ' Ajustado para 3 segundos



    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarJogos()

        If images.Count > 0 Then
            PictureBoxCarrossel.ImageLocation = images(currentImageIndex)
            carouselTimer.Start()
        End If
    End Sub

    Private Sub CarregarJogos()
        Dim SQL As String = "SELECT * FROM Games WHERE Status = 'Approved'"
        Dim rs = db.Execute(SQL)

        FlowLayoutPanel1.Controls.Clear()
        images.Clear() ' Limpa a lista de imagens antes de carregar novos jogos

        While Not rs.EOF
            Dim jogoPanel As New Panel With {
                .Size = New Size(200, 300),
                .BorderStyle = BorderStyle.FixedSingle,
                .Margin = New Padding(10)
            }

            Dim jogoTitulo As New Label With {
                .Text = rs.Fields("Title").Value.ToString(),
                .Font = New Font("Arial", 10, FontStyle.Bold),
                .Dock = DockStyle.Top
            }

            Dim jogoPreco As New Label With {
                .Text = "Preço: R$ " & rs.Fields("Price").Value.ToString(),
                .Dock = DockStyle.Top
            }

            Dim jogoImagem As New PictureBox With {
                .Size = New Size(200, 150),
                .ImageLocation = rs.Fields("Image1").Value.ToString(),
                .SizeMode = PictureBoxSizeMode.Zoom,
                .Dock = DockStyle.Fill
            }

            Dim btnComprar As New Button With {
                .Text = "Comprar",
                 .Dock = DockStyle.Bottom,
                 .Tag = rs.Fields("GameID").Value ' Atribui o GameID ao Tag do botão
                    }
            AddHandler btnComprar.Click, AddressOf btnComprar_Click

            jogoPanel.Controls.Add(btnComprar)
            jogoPanel.Controls.Add(jogoPreco)
            jogoPanel.Controls.Add(jogoTitulo)
            jogoPanel.Controls.Add(jogoImagem)

            FlowLayoutPanel1.Controls.Add(jogoPanel)

            ' Adiciona as imagens à lista para o carrossel
            images.Add(rs.Fields("Image1").Value.ToString())
            images.Add(rs.Fields("Image2").Value.ToString())
            images.Add(rs.Fields("Image3").Value.ToString())

            rs.MoveNext()
        End While
    End Sub

    Private Sub carouselTimer_Tick(sender As Object, e As EventArgs) Handles carouselTimer.Tick
        currentImageIndex += 1
        If currentImageIndex >= images.Count Then
            currentImageIndex = 0
        End If
        PictureBoxCarrossel.ImageLocation = images(currentImageIndex)
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs)
        Try
            ' Obtém o preço do jogo e o saldo atual do usuário
            Dim gameID As Integer = CInt(DirectCast(sender, Button).Tag)
            Dim precoDoJogo As Decimal = ObterPrecoDoJogo(gameID) ' Suponha que essa função já esteja definida
            Dim saldoAtual As Decimal = ObterSaldoUsuario()

            ' Verifica se o saldo é suficiente para a compra
            If saldoAtual >= precoDoJogo Then
                ' Subtrai o valor do jogo do saldo
                Dim novoSaldo As Decimal = saldoAtual - precoDoJogo

                ' Atualiza o saldo do usuário
                Dim updateSQL As String = "UPDATE Users SET wallet = " & novoSaldo.ToString("F2").Replace(",", ".") & " WHERE UserID = " & CurrentUserIDINT
                db.Execute(updateSQL)

                ' Atualiza a label do saldo no form principal
                Form1.lbl_wallet.Text = "Saldo: R$ " & novoSaldo.ToString("F2")

                ' Registra a compra na tabela Purchases
                Dim purchaseSQL As String = "INSERT INTO Purchases (UserID, GameID, Price) VALUES (" & CurrentUserIDINT & ", " & gameID & ", " & precoDoJogo.ToString("F2").Replace(",", ".") & ")"
                db.Execute(purchaseSQL)

                ' Mensagem de sucesso
                MsgBox("Compra realizada com sucesso!", MsgBoxStyle.Information, "Compra Concluída")
            Else
                ' Saldo insuficiente
                MsgBox("Saldo insuficiente para realizar a compra!", MsgBoxStyle.Critical, "Erro")
            End If

        Catch ex As Exception
            MsgBox("Erro ao realizar compra: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub


    ' Função para obter o preço do jogo
    Private Function ObterPrecoDoJogo(gameID As Integer) As Decimal
        Try
            ' Consulta para obter o preço do jogo
            Dim SQL As String = "SELECT Price FROM Games WHERE GameID = " & gameID
            Dim rs = db.Execute(SQL)

            If Not rs.EOF Then
                Return rs.Fields("Price").Value
            End If
        Catch ex As Exception
            MsgBox("Erro ao obter preço do jogo: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try

        Return 0 ' Retorna 0 se não encontrar o preço
    End Function


    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub


End Class
