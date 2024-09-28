<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        txt_usuario = New TextBox()
        txt_senha = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btn_login = New Button()
        btn_cadastrar = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        PictureBox2 = New PictureBox()
        OcultarSenha = New CheckBox()
        GroupBox2 = New GroupBox()
        chk_concordo = New CheckBox()
        txt_email = New TextBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txt_usuario
        ' 
        txt_usuario.Location = New Point(82, 26)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.Size = New Size(235, 27)
        txt_usuario.TabIndex = 0
        ' 
        ' txt_senha
        ' 
        txt_senha.Location = New Point(82, 59)
        txt_senha.Name = "txt_senha"
        txt_senha.Size = New Size(180, 27)
        txt_senha.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label1.Location = New Point(5, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 2
        Label1.Text = "Usuário:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label2.Location = New Point(17, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 20)
        Label2.TabIndex = 3
        Label2.Text = "Senha:"
        ' 
        ' btn_login
        ' 
        btn_login.Location = New Point(223, 92)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(94, 29)
        btn_login.TabIndex = 4
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' btn_cadastrar
        ' 
        btn_cadastrar.Location = New Point(203, 60)
        btn_cadastrar.Name = "btn_cadastrar"
        btn_cadastrar.Size = New Size(114, 29)
        btn_cadastrar.TabIndex = 5
        btn_cadastrar.Text = "Cadastre-se"
        btn_cadastrar.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.MainIcon
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(127, 60)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(70, 68)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(OcultarSenha)
        GroupBox1.Controls.Add(btn_login)
        GroupBox1.Controls.Add(txt_usuario)
        GroupBox1.Controls.Add(txt_senha)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(336, 145)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Login"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.GrayText
        PictureBox2.Image = My.Resources.Resources.eye
        PictureBox2.InitialImage = My.Resources.Resources.eye
        PictureBox2.Location = New Point(292, 62)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 24)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' OcultarSenha
        ' 
        OcultarSenha.AutoSize = True
        OcultarSenha.Checked = True
        OcultarSenha.CheckState = CheckState.Checked
        OcultarSenha.Location = New Point(268, 65)
        OcultarSenha.Name = "OcultarSenha"
        OcultarSenha.Size = New Size(18, 17)
        OcultarSenha.TabIndex = 5
        OcultarSenha.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(chk_concordo)
        GroupBox2.Controls.Add(txt_email)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Controls.Add(btn_cadastrar)
        GroupBox2.Location = New Point(12, 163)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(336, 175)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Cadastre-se"
        ' 
        ' chk_concordo
        ' 
        chk_concordo.AutoSize = True
        chk_concordo.Location = New Point(6, 145)
        chk_concordo.Name = "chk_concordo"
        chk_concordo.Size = New Size(198, 24)
        chk_concordo.TabIndex = 7
        chk_concordo.Text = "Concordo com os termos"
        chk_concordo.UseVisualStyleBackColor = True
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(82, 27)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(235, 27)
        txt_email.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label3.Location = New Point(5, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 6
        Label3.Text = "Email:"
        ' 
        ' frm_login
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(375, 358)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chk_concordo As CheckBox
    Friend WithEvents OcultarSenha As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
