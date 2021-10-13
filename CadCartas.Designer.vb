<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadCartas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadCartas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ataque_text = New System.Windows.Forms.TextBox()
        Me.defesa_text = New System.Windows.Forms.TextBox()
        Me.efeito_text = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.classe_combo = New System.Windows.Forms.ComboBox()
        Me.nome_combo = New System.Windows.Forms.ComboBox()
        Me.parte_combo = New System.Windows.Forms.ComboBox()
        Me.salvar_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.custo_valor = New System.Windows.Forms.NumericUpDown()
        CType(Me.custo_valor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Parte:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ataque:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 141)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Defesa:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 183)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Efeito:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 22)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Classe:"
        '
        'ataque_text
        '
        Me.ataque_text.Location = New System.Drawing.Point(70, 105)
        Me.ataque_text.Margin = New System.Windows.Forms.Padding(5)
        Me.ataque_text.Name = "ataque_text"
        Me.ataque_text.Size = New System.Drawing.Size(38, 29)
        Me.ataque_text.TabIndex = 4
        Me.ataque_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'defesa_text
        '
        Me.defesa_text.Location = New System.Drawing.Point(70, 138)
        Me.defesa_text.Margin = New System.Windows.Forms.Padding(5)
        Me.defesa_text.Name = "defesa_text"
        Me.defesa_text.Size = New System.Drawing.Size(38, 29)
        Me.defesa_text.TabIndex = 5
        Me.defesa_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'efeito_text
        '
        Me.efeito_text.Font = New System.Drawing.Font("Roboto Slab", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.efeito_text.Location = New System.Drawing.Point(2, 210)
        Me.efeito_text.Margin = New System.Windows.Forms.Padding(5)
        Me.efeito_text.Multiline = True
        Me.efeito_text.Name = "efeito_text"
        Me.efeito_text.Size = New System.Drawing.Size(267, 82)
        Me.efeito_text.TabIndex = 6
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "arena.png")
        Me.ImageList1.Images.SetKeyName(1, "arenagrande.jpg")
        Me.ImageList1.Images.SetKeyName(2, "background.jpg")
        Me.ImageList1.Images.SetKeyName(3, "background2.jpg")
        Me.ImageList1.Images.SetKeyName(4, "background3.jpg")
        Me.ImageList1.Images.SetKeyName(5, "background4.jpg")
        Me.ImageList1.Images.SetKeyName(6, "bgbonusdeclasse.jpg")
        Me.ImageList1.Images.SetKeyName(7, "bgplacar.jpg")
        Me.ImageList1.Images.SetKeyName(8, "Captura de tela 2021-09-27 171048.jpg")
        Me.ImageList1.Images.SetKeyName(9, "endturn.png")
        Me.ImageList1.Images.SetKeyName(10, "energia.png")
        Me.ImageList1.Images.SetKeyName(11, "energia5050.png")
        Me.ImageList1.Images.SetKeyName(12, "energiapeq.png")
        Me.ImageList1.Images.SetKeyName(13, "energiapequena.png")
        Me.ImageList1.Images.SetKeyName(14, "icone.ico")
        Me.ImageList1.Images.SetKeyName(15, "icone.png")
        Me.ImageList1.Images.SetKeyName(16, "img_106832.png")
        Me.ImageList1.Images.SetKeyName(17, "img_1068322.png")
        '
        'classe_combo
        '
        Me.classe_combo.FormattingEnabled = True
        Me.classe_combo.Items.AddRange(New Object() {"Beast", "Plant", "Bug", "Mech", "Dusk", "Aquatic", "Bird", "Reptile", "Dawn"})
        Me.classe_combo.Location = New System.Drawing.Point(70, 72)
        Me.classe_combo.Name = "classe_combo"
        Me.classe_combo.Size = New System.Drawing.Size(79, 30)
        Me.classe_combo.TabIndex = 3
        '
        'nome_combo
        '
        Me.nome_combo.FormattingEnabled = True
        Me.nome_combo.Location = New System.Drawing.Point(70, 38)
        Me.nome_combo.Name = "nome_combo"
        Me.nome_combo.Size = New System.Drawing.Size(189, 30)
        Me.nome_combo.TabIndex = 2
        '
        'parte_combo
        '
        Me.parte_combo.FormattingEnabled = True
        Me.parte_combo.Items.AddRange(New Object() {"Boca", "Chifre", "Costas", "Rabo"})
        Me.parte_combo.Location = New System.Drawing.Point(70, 6)
        Me.parte_combo.Name = "parte_combo"
        Me.parte_combo.Size = New System.Drawing.Size(79, 30)
        Me.parte_combo.TabIndex = 1
        '
        'salvar_btn
        '
        Me.salvar_btn.BackColor = System.Drawing.Color.DarkGreen
        Me.salvar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.salvar_btn.Location = New System.Drawing.Point(194, 300)
        Me.salvar_btn.Name = "salvar_btn"
        Me.salvar_btn.Size = New System.Drawing.Size(75, 23)
        Me.salvar_btn.TabIndex = 7
        Me.salvar_btn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(157, 6)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 22)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Custo:"
        '
        'custo_valor
        '
        Me.custo_valor.Location = New System.Drawing.Point(222, 4)
        Me.custo_valor.Name = "custo_valor"
        Me.custo_valor.Size = New System.Drawing.Size(37, 29)
        Me.custo_valor.TabIndex = 6
        Me.custo_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CadCartas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 329)
        Me.Controls.Add(Me.custo_valor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.salvar_btn)
        Me.Controls.Add(Me.parte_combo)
        Me.Controls.Add(Me.nome_combo)
        Me.Controls.Add(Me.classe_combo)
        Me.Controls.Add(Me.efeito_text)
        Me.Controls.Add(Me.defesa_text)
        Me.Controls.Add(Me.ataque_text)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Roboto Slab", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "CadCartas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Cartas"
        Me.TopMost = True
        CType(Me.custo_valor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ataque_text As TextBox
    Friend WithEvents defesa_text As TextBox
    Friend WithEvents efeito_text As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents classe_combo As ComboBox
    Friend WithEvents nome_combo As ComboBox
    Friend WithEvents parte_combo As ComboBox
    Friend WithEvents salvar_btn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents custo_valor As NumericUpDown
End Class
