Public Class frm_login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ' Conecta ao banco antes de fazer login
        Conecta_banco()

        ' Coleta os dados de login do formulário
        Dim username As String = txt_usuario.Text
        Dim password As String = txt_senha.Text

        ' Tenta fazer login
        If modLogin.Login(username, password) Then
            MsgBox("Login bem-sucedido!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            ' Navega para a próxima tela, por exemplo:
            AbrirBiblioteca()
            Me.Hide()
            Form1.VerificaPermissaoAdmin()
            Form1.VerificaPermissaoCurador()
            Form1.VerificaPermissaoDeveloper()
            Form1.VerificaPermissaoUser()

            ' Define como logado
            Form1.IsLoggedIn = True
            Form1.AtualizarLoginMenuItem() ' Atualiza o texto do MenuStrip
            Form1.VerificaPermissaoAdmin() ' Verifica permissões

            AtualizarWallet()
        End If


    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        ' Conecta ao banco antes de cadastrar
        Conecta_banco()

        ' Coleta os dados de cadastro do formulário
        Dim username As String = txt_usuario.Text
        Dim password As String = txt_senha.Text
        Dim email As String = txt_email.Text

        ' Tenta cadastrar o usuário
        If modLogin.Register(username, password, email) Then
            MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ocultar_senhas(sender As Object, e As EventArgs) Handles MyBase.Load 'BUGADO
        If OcultarSenha.Checked = True Then
            txt_senha.PasswordChar = "*"
        Else
            txt_senha.PasswordChar = String.Empty
        End If
    End Sub

End Class
