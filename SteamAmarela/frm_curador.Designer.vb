<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_curador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_curador))
        dgv_jogos = New DataGridView()
        GameID = New DataGridViewTextBoxColumn()
        Title = New DataGridViewTextBoxColumn()
        Description = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        Aprovar = New DataGridViewTextBoxColumn()
        Rejeitar = New DataGridViewTextBoxColumn()
        CType(dgv_jogos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_jogos
        ' 
        dgv_jogos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_jogos.Columns.AddRange(New DataGridViewColumn() {GameID, Title, Description, Price, Aprovar, Rejeitar})
        dgv_jogos.Dock = DockStyle.Fill
        dgv_jogos.Location = New Point(0, 0)
        dgv_jogos.Name = "dgv_jogos"
        dgv_jogos.RowHeadersWidth = 51
        dgv_jogos.Size = New Size(800, 450)
        dgv_jogos.TabIndex = 0
        ' 
        ' GameID
        ' 
        GameID.HeaderText = "Id"
        GameID.MinimumWidth = 6
        GameID.Name = "GameID"
        GameID.Width = 125
        ' 
        ' Title
        ' 
        Title.HeaderText = "Title"
        Title.MinimumWidth = 6
        Title.Name = "Title"
        Title.Width = 125
        ' 
        ' Description
        ' 
        Description.HeaderText = "Description"
        Description.MinimumWidth = 6
        Description.Name = "Description"
        Description.Width = 125
        ' 
        ' Price
        ' 
        Price.HeaderText = "Price"
        Price.MinimumWidth = 6
        Price.Name = "Price"
        Price.Width = 125
        ' 
        ' Aprovar
        ' 
        Aprovar.HeaderText = "Aprovar"
        Aprovar.MinimumWidth = 6
        Aprovar.Name = "Aprovar"
        Aprovar.Width = 125
        ' 
        ' Rejeitar
        ' 
        Rejeitar.HeaderText = "Rejeitar"
        Rejeitar.MinimumWidth = 6
        Rejeitar.Name = "Rejeitar"
        Rejeitar.Width = 125
        ' 
        ' frm_curador
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(800, 450)
        Controls.Add(dgv_jogos)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_curador"
        Text = "Curadoria"
        WindowState = FormWindowState.Maximized
        CType(dgv_jogos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_jogos As DataGridView
    Friend WithEvents GameID As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Aprovar As DataGridViewTextBoxColumn
    Friend WithEvents Rejeitar As DataGridViewTextBoxColumn
End Class
