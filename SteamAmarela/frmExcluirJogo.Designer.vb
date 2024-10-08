<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExcluirJogo
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
        dgvJogos = New DataGridView()
        btnExcluir = New Button()
        CType(dgvJogos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvJogos
        ' 
        dgvJogos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJogos.Location = New Point(8, 78)
        dgvJogos.Name = "dgvJogos"
        dgvJogos.RowHeadersWidth = 51
        dgvJogos.Size = New Size(780, 351)
        dgvJogos.TabIndex = 0
        ' 
        ' btnExcluir
        ' 
        btnExcluir.Location = New Point(571, 35)
        btnExcluir.Name = "btnExcluir"
        btnExcluir.Size = New Size(94, 29)
        btnExcluir.TabIndex = 1
        btnExcluir.Text = "Excluir"
        btnExcluir.UseVisualStyleBackColor = True
        ' 
        ' frmExcluirJogo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExcluir)
        Controls.Add(dgvJogos)
        Name = "frmExcluirJogo"
        Text = "frmExcluirJogo"
        CType(dgvJogos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvJogos As DataGridView
    Friend WithEvents btnExcluir As Button
End Class
