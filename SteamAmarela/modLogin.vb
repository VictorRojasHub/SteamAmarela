Module modLogin
    ' Variáveis globais
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public SQL As String
    Public cont As Integer
    Public CurrentDeveloperID As Integer
    Public CurrentUserIDINT As Integer


    ' Sub para conexão com o banco de dados
    Sub Conecta_banco()
        Try
            ' Cria a conexão ADO com o SQL Server
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=localhost\SQLEXPRESS01;Initial Catalog=steamAmarelaDB;trusted_connection=yes;")
            MsgBox("Conexão ok", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


    Public Sub CurrentUserID()
        Try
            Conecta_banco()
            ' Supondo que rs já contenha o resultado da consulta após o login
            If Not rs.EOF Then
                ' Armazena o UserID na variável global
                CurrentUserIDINT = Convert.ToInt32(rs.Fields("UserID").Value)
            Else
                MsgBox("Erro: Usuário não encontrado.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Erro ao definir UserID: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Sub AbrirBiblioteca()
        Dim frm_biblioteca As New frm_biblioteca()
        frm_biblioteca.MdiParent = Form1 ' Define Frm_Principal como pai MDI
        frm_biblioteca.Show() ' Abre o formulário dentro do formulário principal
    End Sub

    Sub AbrirLoja()
        Dim loja As New loja()
        loja.MdiParent = Form1 ' Define Frm_Principal como pai MDI
        loja.Show() ' Abre o formulário dentro do formulário principal
    End Sub

    Sub AbrirComunidade()
        Dim frm_comunidade As New frm_comunidade()
        frm_comunidade.MdiParent = Form1 ' Define Frm_Principal como pai MDI
        frm_comunidade.Show() ' Abre o formulário dentro do formulário principal
    End Sub

    Sub AbrirAmigos()
        Dim frm_amigos As New frm_amigos()
        frm_amigos.MdiParent = Form1 ' Define Frm_Principal como pai MDI
        frm_amigos.Show() ' Abre o formulário dentro do formulário principal
    End Sub

    Sub AbrirDeveloper()
        Dim frm_developer As New frm_developer()
        frm_developer.MdiParent = Form1 ' Define Frm_Principal como pai MDI
        frm_developer.Show() ' Abre o formulário dentro do formulário principal
    End Sub

    Sub AbrirCurador()
        Dim frm_curador As New frm_curador()
        frm_curador.MdiParent = Form1 ' Define Frm_Principal como pai MDI
        frm_curador.Show() ' Abre o formulário dentro do formulário principal
    End Sub

    Sub AbrirAdmin()
        Dim frm_admin As New frm_admin()
        frm_admin.MdiParent = Form1 ' Define Frm_Principal como pai MDI
        frm_admin.Show() ' Abre o formulário dentro do formulário principal
    End Sub

    Sub CarregaLogin()
        Dim frm_login As New frm_login()
        frm_login.MdiParent = Form1 ' Define Frm_Principal como pai MDI
        frm_login.Show() ' Abre o formulário dentro do formulário principal
    End Sub

    ' Função para Login
    Public Function Login(username As String, password As String) As Boolean
        Try
            ' SQL para verificar o usuário e senha no banco
            SQL = "SELECT * FROM Users WHERE Username = '" & username & "' AND PasswordHash = '" & HashPassword(password) & "'"
            rs = db.Execute(SQL)

            ' Verifica se encontrou o usuário
            If Not rs.EOF Then
                If rs.Fields("role").Value = "admin" Then
                    Form1.IsAdmin = True ' Define que o usuário é admin
                ElseIf rs.Fields("role").Value = "curador" Then
                    Form1.IsCurador = True
                ElseIf rs.Fields("role").Value = "developer" Then
                    Form1.IsDeveloper = True
                ElseIf rs.Fields("role").Value = "user" Then
                    Form1.IsUser = True
                Else
                    Form1.IsAdmin = False
                    Form1.IsCurador = False
                    Form1.IsDeveloper = False
                    Form1.IsUser = False
                End If


                If rs.Fields("role").Value = "developer" Then
                    CurrentDeveloperID = rs.Fields("UserID").Value ' Captura o ID do desenvolvedor logado
                    Return True ' Login bem-sucedido
                End If

                Dim walletValue As Decimal = rs.Fields("wallet").Value
                Form1.lbl_wallet.Text = "Saldo: R$ " & walletValue.ToString("F2")


                Return True ' Login bem-sucedido

            Else
                MsgBox("Usuário ou senha incorretos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                Return False ' Falha no login
            End If

        Catch ex As Exception
            MsgBox("Erro ao tentar fazer login: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Return False
        End Try


    End Function

    ' Função para Cadastro
    Public Function Register(username As String, password As String, email As String) As Boolean
        Try
            If username = "" Or email = "" Or password = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")

                Return False
            End If



            ' Verifica se o nome já existe na tabela Users
            SQL = "SELECT * FROM Users WHERE username = '" & username & "'"
            rs = db.Execute(SQL)

            If Not rs.EOF Then
                MsgBox("Já existe um usuário com este nome!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
                Return False
            End If

            ' SQL para inserir novo usuário
            SQL = "INSERT INTO Users (Username, PasswordHash, Email) " &
                  "VALUES ('" & username & "', '" & HashPassword(password) & "', '" & email & "')"
            db.Execute(SQL)

            MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Return True

        Catch ex As Exception
            MsgBox("Erro ao tentar cadastrar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Return False
        End Try
    End Function

    ' Função para Hash da senha (simples, apenas para exemplo)
    Private Function HashPassword(password As String) As String
        ' Uma função simples de hash (SHA256) para proteção de senha
        Dim sha As New System.Security.Cryptography.SHA256Managed()
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha.ComputeHash(bytes)
        Return BitConverter.ToString(hash).Replace("-", "").ToLower()
    End Function

    Public Sub AtualizarWallet()

        Try
            ' Verifica se o CurrentUserIDINT foi definido corretamente
            If CurrentUserIDINT = 0 Then
                MsgBox("ID do usuário não está definido.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
                Exit Sub
            End If

            ' Consulta para obter o saldo da carteira com base no UserID armazenado
            SQL = "SELECT wallet FROM Users WHERE UserID = " & CurrentUserIDINT

            ' Executa a consulta
            rs = db.Execute(SQL)

            ' Verifica se o Recordset retornou dados corretamente
            If Not rs Is Nothing AndAlso Not rs.EOF Then
                ' Lê o valor do saldo
                Dim walletValue As Decimal = Convert.ToDecimal(rs.Fields("wallet").Value)
                ' Atualiza o label da wallet no Form1
                Form1.lbl_wallet.Text = "Saldo: R$ " & walletValue.ToString("F2")
            Else
                MsgBox("Saldo da carteira não encontrado para o usuário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
            End If

        Catch ex As Exception
            ' Captura qualquer erro e exibe uma mensagem
            MsgBox("Erro ao tentar carregar o saldo: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub


    Public Function ObterSaldoUsuario() As Decimal
        Try
            ' SQL para obter o saldo do usuário logado
            Dim SQL As String = "SELECT wallet FROM Users WHERE UserID = " & CurrentUserIDINT
            Dim rs = db.Execute(SQL)

            If Not rs.EOF Then
                Return Convert.ToDecimal(rs.Fields("wallet").Value)
            End If
        Catch ex As Exception
            MsgBox("Erro ao obter saldo do usuário: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try

        Return 0 ' Retorna 0 se não encontrar o saldo
    End Function





End Module
