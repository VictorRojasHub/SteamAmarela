<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        UsuToolStripMenuItem = New ToolStripMenuItem()
        AdicionarFundoToolStripMenuItem = New ToolStripMenuItem()
        BibliotecaToolStripMenuItem = New ToolStripMenuItem()
        ComunidadeToolStripMenuItem = New ToolStripMenuItem()
        AmigosToolStripMenuItem = New ToolStripMenuItem()
        DeveloperToolStripMenuItem = New ToolStripMenuItem()
        CuradorToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        lbl_wallet = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ExcluirJogosToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {LoginToolStripMenuItem, UsuToolStripMenuItem, BibliotecaToolStripMenuItem, ComunidadeToolStripMenuItem, AmigosToolStripMenuItem, DeveloperToolStripMenuItem, CuradorToolStripMenuItem, AdminToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1075, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.Size = New Size(60, 24)
        LoginToolStripMenuItem.Text = "Login"
        ' 
        ' UsuToolStripMenuItem
        ' 
        UsuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AdicionarFundoToolStripMenuItem})
        UsuToolStripMenuItem.Name = "UsuToolStripMenuItem"
        UsuToolStripMenuItem.Size = New Size(51, 24)
        UsuToolStripMenuItem.Text = "Loja"
        ' 
        ' AdicionarFundoToolStripMenuItem
        ' 
        AdicionarFundoToolStripMenuItem.Name = "AdicionarFundoToolStripMenuItem"
        AdicionarFundoToolStripMenuItem.Size = New Size(213, 26)
        AdicionarFundoToolStripMenuItem.Text = "Adicionar Fundo $"
        ' 
        ' BibliotecaToolStripMenuItem
        ' 
        BibliotecaToolStripMenuItem.Enabled = False
        BibliotecaToolStripMenuItem.Name = "BibliotecaToolStripMenuItem"
        BibliotecaToolStripMenuItem.Size = New Size(90, 24)
        BibliotecaToolStripMenuItem.Text = "Biblioteca"
        ' 
        ' ComunidadeToolStripMenuItem
        ' 
        ComunidadeToolStripMenuItem.Enabled = False
        ComunidadeToolStripMenuItem.Name = "ComunidadeToolStripMenuItem"
        ComunidadeToolStripMenuItem.Size = New Size(108, 24)
        ComunidadeToolStripMenuItem.Text = "Comunidade"
        ' 
        ' AmigosToolStripMenuItem
        ' 
        AmigosToolStripMenuItem.Enabled = False
        AmigosToolStripMenuItem.Name = "AmigosToolStripMenuItem"
        AmigosToolStripMenuItem.Size = New Size(74, 24)
        AmigosToolStripMenuItem.Text = "Amigos"
        ' 
        ' DeveloperToolStripMenuItem
        ' 
        DeveloperToolStripMenuItem.Enabled = False
        DeveloperToolStripMenuItem.ForeColor = Color.RoyalBlue
        DeveloperToolStripMenuItem.Name = "DeveloperToolStripMenuItem"
        DeveloperToolStripMenuItem.Size = New Size(92, 24)
        DeveloperToolStripMenuItem.Text = "Developer"
        ' 
        ' CuradorToolStripMenuItem
        ' 
        CuradorToolStripMenuItem.Enabled = False
        CuradorToolStripMenuItem.ForeColor = Color.Red
        CuradorToolStripMenuItem.Name = "CuradorToolStripMenuItem"
        CuradorToolStripMenuItem.Size = New Size(76, 24)
        CuradorToolStripMenuItem.Text = "Curador"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExcluirJogosToolStripMenuItem})
        AdminToolStripMenuItem.Enabled = False
        AdminToolStripMenuItem.ForeColor = Color.ForestGreen
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(67, 24)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' lbl_wallet
        ' 
        lbl_wallet.AutoSize = True
        lbl_wallet.Location = New Point(934, 28)
        lbl_wallet.Name = "lbl_wallet"
        lbl_wallet.Size = New Size(102, 20)
        lbl_wallet.TabIndex = 2
        lbl_wallet.Text = "Saldo: R$ 0,00"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' ExcluirJogosToolStripMenuItem
        ' 
        ExcluirJogosToolStripMenuItem.Name = "ExcluirJogosToolStripMenuItem"
        ExcluirJogosToolStripMenuItem.Size = New Size(224, 26)
        ExcluirJogosToolStripMenuItem.Text = "Excluir Jogos"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(1075, 582)
        Controls.Add(lbl_wallet)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Steam Amarela"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BibliotecaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComunidadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AmigosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeveloperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuradorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_wallet As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AdicionarFundoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirJogosToolStripMenuItem As ToolStripMenuItem

End Class
