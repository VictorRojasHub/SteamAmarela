<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_biblioteca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_biblioteca))
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1 = New Panel()
        PictureBox = New PictureBox()
        btnDownload = New Button()
        Label2 = New Label()
        Label1 = New Label()
        FlowLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Panel1)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(807, 430)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox)
        Panel1.Controls.Add(btnDownload)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(236, 253)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox
        ' 
        PictureBox.Location = New Point(-3, 35)
        PictureBox.Name = "PictureBox"
        PictureBox.Size = New Size(236, 175)
        PictureBox.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox.TabIndex = 2
        PictureBox.TabStop = False
        ' 
        ' btnDownload
        ' 
        btnDownload.Location = New Point(116, 220)
        btnDownload.Name = "btnDownload"
        btnDownload.Size = New Size(94, 29)
        btnDownload.TabIndex = 1
        btnDownload.Text = "Download"
        btnDownload.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(4, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(3, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' frm_biblioteca
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(807, 430)
        Controls.Add(FlowLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_biblioteca"
        Text = "Biblioteca de Jogos"
        WindowState = FormWindowState.Maximized
        FlowLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents btnDownload As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
