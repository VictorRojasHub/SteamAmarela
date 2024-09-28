Public Class Form1


    Public IsAdmin As Boolean = False
    Public IsCurador As Boolean = False
    Public IsDeveloper As Boolean = False
    Public IsUser As Boolean = False
    Public IsLoggedIn As Boolean = False ' Verifica se o usuário está logado

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True ' Define este formulário como o contêiner MDI
        AdminToolStripMenuItem.Enabled = False
        DeveloperToolStripMenuItem.Enabled = False
        CuradorToolStripMenuItem.Enabled = False
        BibliotecaToolStripMenuItem.Enabled = False
        ComunidadeToolStripMenuItem.Enabled = False
        AmigosToolStripMenuItem.Enabled = False
        AtualizarLoginMenuItem()
        CarregaLogin()

    End Sub
    Public Sub VerificaPermissaoAdmin()
        If IsAdmin Then
            ' Habilita as opções de admin no MenuStrip
            AdminToolStripMenuItem.Enabled = True
            DeveloperToolStripMenuItem.Enabled = True
            CuradorToolStripMenuItem.Enabled = True
            BibliotecaToolStripMenuItem.Enabled = True
            ComunidadeToolStripMenuItem.Enabled = True
            AmigosToolStripMenuItem.Enabled = True
        End If
    End Sub

    Public Sub VerificaPermissaoCurador()
        If IsCurador Then
            ' Habilita as opções de admin no MenuStrip
            DeveloperToolStripMenuItem.Enabled = True
            CuradorToolStripMenuItem.Enabled = True
            BibliotecaToolStripMenuItem.Enabled = True
            ComunidadeToolStripMenuItem.Enabled = True
            AmigosToolStripMenuItem.Enabled = True
        End If
    End Sub

    Public Sub VerificaPermissaoDeveloper()
        If IsDeveloper Then
            ' Habilita as opções de admin no MenuStrip
            DeveloperToolStripMenuItem.Enabled = True
            BibliotecaToolStripMenuItem.Enabled = True
            ComunidadeToolStripMenuItem.Enabled = True
            AmigosToolStripMenuItem.Enabled = True
        End If
    End Sub

    Public Sub VerificaPermissaoUser()
        If IsUser Then
            BibliotecaToolStripMenuItem.Enabled = True
            ComunidadeToolStripMenuItem.Enabled = True
            AmigosToolStripMenuItem.Enabled = True
        End If
    End Sub


    Private Sub UsuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuToolStripMenuItem.Click
        AbrirLoja()
    End Sub



    Private Sub BibliotecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BibliotecaToolStripMenuItem.Click
        AbrirBiblioteca()
    End Sub
    Private Sub AbrirBiblioteca()
        ' Verifica se a biblioteca já está aberta
        For Each form As Form In Me.MdiChildren
            If TypeOf form Is frm_biblioteca Then
                form.Focus() ' Se já estiver aberto, traz o formulário para frente
                Return
            End If
        Next

        ' Se não estiver aberto, cria uma nova instância
        Dim biblioteca As New frm_biblioteca()
        biblioteca.MdiParent = Me
        biblioteca.Show()
    End Sub

    Private Sub AbrirAmigos()
        ' Verifica se a biblioteca já está aberta
        For Each form As Form In Me.MdiChildren
            If TypeOf form Is frm_amigos Then
                form.Focus() ' Se já estiver aberto, traz o formulário para frente
                Return
            End If
        Next

        ' Se não estiver aberto, cria uma nova instância
        Dim Amigos As New frm_amigos()
        Amigos.MdiParent = Me
        Amigos.Show()
    End Sub

    Private Sub AbrirComunidade()
        ' Verifica se a biblioteca já está aberta
        For Each form As Form In Me.MdiChildren
            If TypeOf form Is frm_comunidade Then
                form.Focus() ' Se já estiver aberto, traz o formulário para frente
                Return
            End If
        Next

        ' Se não estiver aberto, cria uma nova instância
        Dim comunidade As New frm_comunidade()
        comunidade.MdiParent = Me
        comunidade.Show()
    End Sub

    Private Sub AbrirDeveloper()
        ' Verifica se a biblioteca já está aberta
        For Each form As Form In Me.MdiChildren
            If TypeOf form Is frm_developer Then
                form.Focus() ' Se já estiver aberto, traz o formulário para frente
                Return
            End If
        Next

        ' Se não estiver aberto, cria uma nova instância
        Dim developer As New frm_developer()
        developer.MdiParent = Me
        developer.Show()
    End Sub

    Private Sub AbrirLoja()
        ' Verifica se a biblioteca já está aberta
        For Each form As Form In Me.MdiChildren
            If TypeOf form Is loja Then
                form.Focus() ' Se já estiver aberto, traz o formulário para frente
                Return
            End If
        Next

        ' Se não estiver aberto, cria uma nova instância
        Dim loja As New loja()
        loja.MdiParent = Me
        loja.Show()
    End Sub

    Private Sub AbrirCurador()
        ' Verifica se a biblioteca já está aberta
        For Each form As Form In Me.MdiChildren
            If TypeOf form Is frm_curador Then
                form.Focus() ' Se já estiver aberto, traz o formulário para frente
                Return
            End If
        Next

        ' Se não estiver aberto, cria uma nova instância
        Dim curador As New frm_curador()
        curador.MdiParent = Me
        curador.Show()
    End Sub

    Private Sub AbrirAdmin()
        ' Verifica se a biblioteca já está aberta
        For Each form As Form In Me.MdiChildren
            If TypeOf form Is frm_admin Then
                form.Focus() ' Se já estiver aberto, traz o formulário para frente
                Return
            End If
        Next

        ' Se não estiver aberto, cria uma nova instância
        Dim admin As New frm_admin()
        admin.MdiParent = Me
        admin.Show()
    End Sub



    Private Sub ComunidadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComunidadeToolStripMenuItem.Click
        AbrirComunidade()
    End Sub

    Private Sub AmigosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AmigosToolStripMenuItem.Click
        AbrirAmigos()
    End Sub

    Private Sub DeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeveloperToolStripMenuItem.Click
        AbrirDeveloper()
    End Sub

    Private Sub CuradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuradorToolStripMenuItem.Click
        AbrirCurador()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        AbrirAdmin()
    End Sub

    ' Método para alternar entre "Login" e "Logout"
    Public Sub AtualizarLoginMenuItem()
        If IsLoggedIn Then
            LoginToolStripMenuItem.Text = "Logout"
        Else
            LoginToolStripMenuItem.Text = "Login"
            lbl_wallet.Text = "Saldo: R$ 0,00"
        End If
    End Sub

    ' Clique no MenuStrip para fazer Login/Logout
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If IsLoggedIn Then
            ' Se já estiver logado, desloga o usuário
            Logout()
        Else
            ' Abre o formulário de login
            frm_login.ShowDialog()
        End If
    End Sub

    ' Método para processar o logout
    Public Sub Logout()
        IsLoggedIn = False
        IsAdmin = False
        IsCurador = False
        IsDeveloper = False
        AdminToolStripMenuItem.Enabled = False
        CuradorToolStripMenuItem.Enabled = False
        DeveloperToolStripMenuItem.Enabled = False
        BibliotecaToolStripMenuItem.Enabled = False
        ComunidadeToolStripMenuItem.Enabled = False
        AmigosToolStripMenuItem.Enabled = False
        MsgBox("Você foi desconectado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Logout")
        AtualizarLoginMenuItem() ' Atualiza o MenuStrip
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AdicionarSaldoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AdicionarFundoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarFundoToolStripMenuItem.Click
        Dim frm As New frmAdicionarFundo
        frm.ShowDialog() ' Mostra o formulário modal
    End Sub
End Class
