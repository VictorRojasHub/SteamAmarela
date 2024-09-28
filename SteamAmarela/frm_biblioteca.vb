Imports System.Data.SqlClient
Imports System.Net.Mime.MediaTypeNames
Imports System.Drawing


Public Class frm_biblioteca
    Private Sub frm_biblioteca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentUserID()
        CarregarJogosComprados()
    End Sub
    Private Sub CarregarJogosComprados()
        Dim SQL As String = "SELECT g.Title, g.Image1, g.Price " &
                        "FROM Purchases p " &
                        "JOIN Games g ON p.GameID = g.GameID " &
                        "WHERE p.UserID = " & CurrentUserIDINT ' Substitua pelo ID do usuário logado

        Try
            ' Executa a consulta no banco de dados
            rs = db.Execute(SQL)

            ' Limpa o FlowLayoutPanel para evitar sobreposição de dados
            FlowLayoutPanel1.Controls.Clear()

            ' Verifica se há registros retornados
            If Not rs.EOF Then
                ' Percorre os resultados da consulta
                Do While Not rs.EOF
                    ' Cria um painel para cada jogo
                    Dim jogoPanel As New Panel With {
                    .Size = New Size(200, 300),
                    .BorderStyle = BorderStyle.FixedSingle,
                    .Margin = New Padding(10)
                }

                    ' Cria e configura o título do jogo
                    Dim jogoTitulo As New Label With {
                    .Text = rs.Fields("Title").Value.ToString(),
                    .Font = New Drawing.Font("Arial", 10, FontStyle.Bold),
                    .Dock = DockStyle.Top
                }

                    ' Cria e configura o preço do jogo
                    Dim jogoPreco As New Label With {
                    .Text = "Preço: R$ " & Convert.ToDecimal(rs.Fields("Price").Value).ToString("F2"),
                    .Dock = DockStyle.Top
                }

                    ' Cria e configura a imagem do jogo
                    Dim jogoImagem As New PictureBox With {
                    .Size = New Size(200, 150),
                    .ImageLocation = rs.Fields("Image1").Value.ToString(),
                    .SizeMode = PictureBoxSizeMode.Zoom,
                    .Dock = DockStyle.Fill
                }

                    ' Cria o botão de download
                    Dim btnDownload As New Button With {
                    .Text = "Download",
                    .Dock = DockStyle.Bottom
                }
                    ' Adiciona o evento de clique ao botão de download
                    AddHandler btnDownload.Click, AddressOf btnDownload_Click

                    ' Adiciona os controles ao painel
                    jogoPanel.Controls.Add(btnDownload)
                    jogoPanel.Controls.Add(jogoPreco)
                    jogoPanel.Controls.Add(jogoTitulo)
                    jogoPanel.Controls.Add(jogoImagem)

                    ' Adiciona o painel ao FlowLayoutPanel
                    FlowLayoutPanel1.Controls.Add(jogoPanel)

                    ' Move para o próximo registro
                    rs.MoveNext()
                Loop
            Else
                ' Exibe uma mensagem se não houver jogos comprados
                MsgBox("Nenhum jogo comprado encontrado.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de exceção
            MsgBox("Erro ao carregar jogos comprados: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnDownload_Click(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Dim panel As Panel = CType(button.Parent, Panel)

        ' Obtém o título do jogo a partir do Label no painel
        Dim titulo As String = CType(panel.Controls(0), Label).Text

        ' Aqui você pode implementar a lógica de download do jogo
        MsgBox("Iniciando download de: " & titulo)
    End Sub

End Class
