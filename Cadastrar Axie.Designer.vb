<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastrar_Axie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastrar_Axie))
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.valor_moral2 = New System.Windows.Forms.TextBox()
        Me.valor_skill2 = New System.Windows.Forms.TextBox()
        Me.valor_speed2 = New System.Windows.Forms.TextBox()
        Me.valor_hp2 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RABO_NOME = New System.Windows.Forms.TextBox()
        Me.COSTAS_NOME = New System.Windows.Forms.TextBox()
        Me.CHIFRE_NOME = New System.Windows.Forms.TextBox()
        Me.BOCA_NOME = New System.Windows.Forms.TextBox()
        Me.RABOLABEL = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.AXIEID_01 = New System.Windows.Forms.TextBox()
        Me.SalvarBD = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AXIE_CLASSE = New System.Windows.Forms.ComboBox()
        Me.axie_nome_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(465, 39)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(52, 13)
        Me.Label50.TabIndex = 42
        Me.Label50.Text = "MORALE"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(426, 39)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(36, 13)
        Me.Label51.TabIndex = 41
        Me.Label51.Text = "SKILL"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(380, 39)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(43, 13)
        Me.Label52.TabIndex = 40
        Me.Label52.Text = "SPEED"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(324, 39)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(50, 13)
        Me.Label53.TabIndex = 39
        Me.Label53.Text = "HEALTH"
        '
        'valor_moral2
        '
        Me.valor_moral2.Location = New System.Drawing.Point(468, 55)
        Me.valor_moral2.Name = "valor_moral2"
        Me.valor_moral2.Size = New System.Drawing.Size(49, 20)
        Me.valor_moral2.TabIndex = 38
        Me.valor_moral2.Text = "0"
        '
        'valor_skill2
        '
        Me.valor_skill2.Location = New System.Drawing.Point(429, 55)
        Me.valor_skill2.Name = "valor_skill2"
        Me.valor_skill2.Size = New System.Drawing.Size(33, 20)
        Me.valor_skill2.TabIndex = 37
        Me.valor_skill2.Text = "0"
        '
        'valor_speed2
        '
        Me.valor_speed2.Location = New System.Drawing.Point(383, 55)
        Me.valor_speed2.Name = "valor_speed2"
        Me.valor_speed2.Size = New System.Drawing.Size(40, 20)
        Me.valor_speed2.TabIndex = 36
        Me.valor_speed2.Text = "0"
        '
        'valor_hp2
        '
        Me.valor_hp2.Location = New System.Drawing.Point(327, 55)
        Me.valor_hp2.Name = "valor_hp2"
        Me.valor_hp2.Size = New System.Drawing.Size(42, 20)
        Me.valor_hp2.TabIndex = 35
        Me.valor_hp2.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RABO_NOME)
        Me.Panel3.Controls.Add(Me.COSTAS_NOME)
        Me.Panel3.Controls.Add(Me.CHIFRE_NOME)
        Me.Panel3.Controls.Add(Me.BOCA_NOME)
        Me.Panel3.Controls.Add(Me.RABOLABEL)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.Label32)
        Me.Panel3.Location = New System.Drawing.Point(10, 77)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(426, 82)
        Me.Panel3.TabIndex = 33
        '
        'RABO_NOME
        '
        Me.RABO_NOME.Location = New System.Drawing.Point(294, 47)
        Me.RABO_NOME.Name = "RABO_NOME"
        Me.RABO_NOME.Size = New System.Drawing.Size(120, 20)
        Me.RABO_NOME.TabIndex = 52
        '
        'COSTAS_NOME
        '
        Me.COSTAS_NOME.Location = New System.Drawing.Point(58, 15)
        Me.COSTAS_NOME.Name = "COSTAS_NOME"
        Me.COSTAS_NOME.Size = New System.Drawing.Size(120, 20)
        Me.COSTAS_NOME.TabIndex = 51
        '
        'CHIFRE_NOME
        '
        Me.CHIFRE_NOME.Location = New System.Drawing.Point(58, 41)
        Me.CHIFRE_NOME.Name = "CHIFRE_NOME"
        Me.CHIFRE_NOME.Size = New System.Drawing.Size(120, 20)
        Me.CHIFRE_NOME.TabIndex = 50
        '
        'BOCA_NOME
        '
        Me.BOCA_NOME.Location = New System.Drawing.Point(294, 18)
        Me.BOCA_NOME.Name = "BOCA_NOME"
        Me.BOCA_NOME.Size = New System.Drawing.Size(120, 20)
        Me.BOCA_NOME.TabIndex = 46
        '
        'RABOLABEL
        '
        Me.RABOLABEL.AutoSize = True
        Me.RABOLABEL.Location = New System.Drawing.Point(252, 50)
        Me.RABOLABEL.Name = "RABOLABEL"
        Me.RABOLABEL.Size = New System.Drawing.Size(36, 17)
        Me.RABOLABEL.TabIndex = 23
        Me.RABOLABEL.Text = "RABO"
        Me.RABOLABEL.UseCompatibleTextRendering = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(1, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 17)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "COSTAS"
        Me.Label26.UseCompatibleTextRendering = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 44)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(46, 17)
        Me.Label29.TabIndex = 13
        Me.Label29.Text = "CHIFRE"
        Me.Label29.UseCompatibleTextRendering = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(252, 21)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(36, 17)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "BOCA"
        Me.Label32.UseCompatibleTextRendering = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 13)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "AXIE ID:"
        '
        'AXIEID_01
        '
        Me.AXIEID_01.Location = New System.Drawing.Point(9, 56)
        Me.AXIEID_01.Name = "AXIEID_01"
        Me.AXIEID_01.Size = New System.Drawing.Size(161, 20)
        Me.AXIEID_01.TabIndex = 44
        '
        'SalvarBD
        '
        Me.SalvarBD.Location = New System.Drawing.Point(442, 122)
        Me.SalvarBD.Name = "SalvarBD"
        Me.SalvarBD.Size = New System.Drawing.Size(75, 23)
        Me.SalvarBD.TabIndex = 45
        Me.SalvarBD.Text = "Salvar"
        Me.SalvarBD.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(191, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "CLASSE"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'AXIE_CLASSE
        '
        Me.AXIE_CLASSE.FormattingEnabled = True
        Me.AXIE_CLASSE.Items.AddRange(New Object() {"Beast", "Plant", "Bug", "Mech", "Dusk", "Aquatic", "Bird", "Reptile", "Dawn"})
        Me.AXIE_CLASSE.Location = New System.Drawing.Point(190, 55)
        Me.AXIE_CLASSE.Name = "AXIE_CLASSE"
        Me.AXIE_CLASSE.Size = New System.Drawing.Size(121, 21)
        Me.AXIE_CLASSE.TabIndex = 62
        '
        'axie_nome_txt
        '
        Me.axie_nome_txt.Location = New System.Drawing.Point(9, 18)
        Me.axie_nome_txt.Name = "axie_nome_txt"
        Me.axie_nome_txt.Size = New System.Drawing.Size(161, 20)
        Me.axie_nome_txt.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "NOME:"
        '
        'Cadastrar_Axie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 149)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.axie_nome_txt)
        Me.Controls.Add(Me.AXIE_CLASSE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SalvarBD)
        Me.Controls.Add(Me.AXIEID_01)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.valor_moral2)
        Me.Controls.Add(Me.valor_skill2)
        Me.Controls.Add(Me.valor_speed2)
        Me.Controls.Add(Me.valor_hp2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label24)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cadastrar_Axie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar_Axie"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents valor_moral2 As TextBox
    Friend WithEvents valor_skill2 As TextBox
    Friend WithEvents valor_speed2 As TextBox
    Friend WithEvents valor_hp2 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RABOLABEL As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents AXIEID_01 As TextBox
    Friend WithEvents SalvarBD As Button
    Friend WithEvents RABO_NOME As TextBox
    Friend WithEvents COSTAS_NOME As TextBox
    Friend WithEvents CHIFRE_NOME As TextBox
    Friend WithEvents BOCA_NOME As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AXIE_CLASSE As ComboBox
    Friend WithEvents axie_nome_txt As TextBox
    Friend WithEvents Label1 As Label
End Class
