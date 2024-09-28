<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_developer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_developer))
        txt_title = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        txt_price = New TextBox()
        txt_description = New TextBox()
        btn_submit = New Button()
        btn_clear = New Button()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        btn_selectImage1 = New Button()
        btn_selectImage2 = New Button()
        btn_selectImage3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_title
        ' 
        txt_title.Location = New Point(133, 39)
        txt_title.Name = "txt_title"
        txt_title.Size = New Size(464, 27)
        txt_title.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 20)
        Label1.TabIndex = 1
        Label1.Text = "Título do Game"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 20)
        Label2.TabIndex = 2
        Label2.Text = "Submeter jogos"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 3
        Label3.Text = "Descrição"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(619, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 4
        Label4.Text = "Preço"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 72)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(245, 184)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' txt_price
        ' 
        txt_price.Location = New Point(671, 39)
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(88, 27)
        txt_price.TabIndex = 6
        ' 
        ' txt_description
        ' 
        txt_description.Location = New Point(12, 302)
        txt_description.Multiline = True
        txt_description.Name = "txt_description"
        txt_description.Size = New Size(747, 101)
        txt_description.TabIndex = 7
        ' 
        ' btn_submit
        ' 
        btn_submit.Location = New Point(665, 406)
        btn_submit.Name = "btn_submit"
        btn_submit.Size = New Size(94, 29)
        btn_submit.TabIndex = 8
        btn_submit.Text = "Submeter"
        btn_submit.UseVisualStyleBackColor = True
        ' 
        ' btn_clear
        ' 
        btn_clear.Location = New Point(12, 406)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(94, 29)
        btn_clear.TabIndex = 9
        btn_clear.Text = "Limpar"
        btn_clear.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(263, 72)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(245, 184)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(514, 72)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(245, 184)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' btn_selectImage1
        ' 
        btn_selectImage1.Location = New Point(160, 262)
        btn_selectImage1.Name = "btn_selectImage1"
        btn_selectImage1.Size = New Size(97, 34)
        btn_selectImage1.TabIndex = 12
        btn_selectImage1.Text = "Selecionar"
        btn_selectImage1.UseVisualStyleBackColor = True
        ' 
        ' btn_selectImage2
        ' 
        btn_selectImage2.Location = New Point(411, 262)
        btn_selectImage2.Name = "btn_selectImage2"
        btn_selectImage2.Size = New Size(97, 34)
        btn_selectImage2.TabIndex = 13
        btn_selectImage2.Text = "Selecionar"
        btn_selectImage2.UseVisualStyleBackColor = True
        ' 
        ' btn_selectImage3
        ' 
        btn_selectImage3.Location = New Point(662, 262)
        btn_selectImage3.Name = "btn_selectImage3"
        btn_selectImage3.Size = New Size(97, 34)
        btn_selectImage3.TabIndex = 14
        btn_selectImage3.Text = "Selecionar"
        btn_selectImage3.UseVisualStyleBackColor = True
        ' 
        ' frm_developer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(765, 443)
        Controls.Add(btn_selectImage3)
        Controls.Add(btn_selectImage2)
        Controls.Add(btn_selectImage1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(btn_clear)
        Controls.Add(btn_submit)
        Controls.Add(txt_description)
        Controls.Add(txt_price)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_title)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_developer"
        Text = "Desenvolvedor"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_title As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents btn_submit As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_selectImage1 As Button
    Friend WithEvents btn_selectImage2 As Button
    Friend WithEvents btn_selectImage3 As Button
End Class
