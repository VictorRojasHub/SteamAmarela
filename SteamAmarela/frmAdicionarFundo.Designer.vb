<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdicionarFundo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdicionarFundo))
        Label1 = New Label()
        txtValor = New TextBox()
        cboMetodoPagamento = New ComboBox()
        btnConfirmar = New Button()
        btnCancelar = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 0
        Label1.Text = "Digite o valor:"
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(120, 12)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(205, 27)
        txtValor.TabIndex = 1
        ' 
        ' cboMetodoPagamento
        ' 
        cboMetodoPagamento.FormattingEnabled = True
        cboMetodoPagamento.Location = New Point(174, 49)
        cboMetodoPagamento.Name = "cboMetodoPagamento"
        cboMetodoPagamento.Size = New Size(151, 28)
        cboMetodoPagamento.TabIndex = 2
        ' 
        ' btnConfirmar
        ' 
        btnConfirmar.Location = New Point(195, 97)
        btnConfirmar.Name = "btnConfirmar"
        btnConfirmar.Size = New Size(94, 29)
        btnConfirmar.TabIndex = 3
        btnConfirmar.Text = "Confirmar"
        btnConfirmar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(73, 97)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(94, 29)
        btnCancelar.TabIndex = 4
        btnCancelar.Text = " Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 20)
        Label2.TabIndex = 5
        Label2.Text = "Forma de pagamento:"
        ' 
        ' frmAdicionarFundo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(362, 150)
        Controls.Add(Label2)
        Controls.Add(btnCancelar)
        Controls.Add(btnConfirmar)
        Controls.Add(cboMetodoPagamento)
        Controls.Add(txtValor)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAdicionarFundo"
        Text = "Adicionar Fundo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents cboMetodoPagamento As ComboBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label2 As Label
End Class
