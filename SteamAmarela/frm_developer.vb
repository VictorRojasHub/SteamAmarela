Public Class frm_developer

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        ' Valida se os campos essenciais foram preenchidos
        If txt_title.Text = "" Or txt_description.Text = "" Or PictureBox1.Image Is Nothing Or txt_price.Text = "" Then
            MsgBox("Por favor, preencha o título, a descrição, o preço e insira pelo menos uma imagem.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
            Exit Sub
        End If

        ' Valida se o campo de preço é um valor numérico válido
        Dim price As Decimal
        If Not Decimal.TryParse(txt_price.Text, price) OrElse price < 0 Then
            MsgBox("Por favor, insira um valor de preço válido.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
            Exit Sub
        End If

        Try

            ' SQL para inserir o novo jogo na tabela Games
            SQL = "INSERT INTO Games (Title, Description, DeveloperID, Status, Image1, Image2, Image3, Price) " &
                  "VALUES ('" & txt_title.Text & "', '" & txt_description.Text & "', " &
                  "'" & CurrentDeveloperID & "', 'Pending', " &
                  "'" & imgPath1 & "', '" & imgPath2 & "', '" & imgPath3 & "', '" & price & "')"

            ' Executa o comando SQL
            rs = db.Execute(SQL)

            ' Exibe mensagem de sucesso
            MsgBox("Jogo submetido com sucesso! Aguardando aprovação.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")

            ' Limpa o formulário
            ClearForm()

        Catch ex As Exception
            ' Em caso de erro
            MsgBox("Erro ao tentar submeter o jogo: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    ' Variáveis para armazenar o caminho das imagens
    Private imgPath1 As String = ""
    Private imgPath2 As String = ""
    Private imgPath3 As String = ""

    ' Função para abrir o OpenFileDialog e selecionar a imagem
    Private Sub btn_selectImage1_Click(sender As Object, e As EventArgs) Handles btn_selectImage1.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            imgPath1 = ofd.FileName
            PictureBox1.Image = Image.FromFile(imgPath1)
        End If
    End Sub

    Private Sub btn_selectImage2_Click(sender As Object, e As EventArgs) Handles btn_selectImage2.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            imgPath2 = ofd.FileName
            PictureBox2.Image = Image.FromFile(imgPath2)
        End If
    End Sub

    Private Sub btn_selectImage3_Click(sender As Object, e As EventArgs) Handles btn_selectImage3.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            imgPath3 = ofd.FileName
            PictureBox3.Image = Image.FromFile(imgPath3)
        End If
    End Sub

    ' Função para limpar os campos do formulário
    Private Sub ClearForm()
        txt_title.Text = ""
        txt_description.Text = ""
        txt_price.Text = ""
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        imgPath1 = ""
        imgPath2 = ""
        imgPath3 = ""
    End Sub

    ' Botão de limpar formulário
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearForm()
    End Sub

    Private Sub frm_developer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
