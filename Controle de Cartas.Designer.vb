<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Controle_de_Cartas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Controle_de_Cartas))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.axie3_defesa = New System.Windows.Forms.Label()
        Me.axie3_dano = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.axie2_defesa = New System.Windows.Forms.Label()
        Me.axie2_dano = New System.Windows.Forms.Label()
        Me.Axie1GB = New System.Windows.Forms.GroupBox()
        Me.axie1_defesa = New System.Windows.Forms.Label()
        Me.axie1_dano = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BGBox = New System.Windows.Forms.ComboBox()
        Me.TrocarBG = New System.Windows.Forms.Button()
        Me.limpar = New System.Windows.Forms.Button()
        Me.axie3_rabo = New System.Windows.Forms.Button()
        Me.axie3_costas = New System.Windows.Forms.Button()
        Me.axie3_chifre = New System.Windows.Forms.Button()
        Me.axie3_boca = New System.Windows.Forms.Button()
        Me.axie2_rabo = New System.Windows.Forms.Button()
        Me.axie2_costas = New System.Windows.Forms.Button()
        Me.axie2_chifre = New System.Windows.Forms.Button()
        Me.axie2_boca = New System.Windows.Forms.Button()
        Me.axie1_rabo = New System.Windows.Forms.Button()
        Me.axie1_costas = New System.Windows.Forms.Button()
        Me.axie1_chifre = New System.Windows.Forms.Button()
        Me.axie1_boca = New System.Windows.Forms.Button()
        Me.pinbt = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Axie1GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.axie3_rabo)
        Me.GroupBox2.Controls.Add(Me.axie3_costas)
        Me.GroupBox2.Controls.Add(Me.axie3_chifre)
        Me.GroupBox2.Controls.Add(Me.axie3_defesa)
        Me.GroupBox2.Controls.Add(Me.axie3_boca)
        Me.GroupBox2.Controls.Add(Me.axie3_dano)
        Me.GroupBox2.Location = New System.Drawing.Point(135, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(59, 70)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Axie3"
        '
        'axie3_defesa
        '
        Me.axie3_defesa.AutoSize = True
        Me.axie3_defesa.Font = New System.Drawing.Font("Roboto Slab", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie3_defesa.ForeColor = System.Drawing.Color.Blue
        Me.axie3_defesa.Location = New System.Drawing.Point(6, 84)
        Me.axie3_defesa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.axie3_defesa.Name = "axie3_defesa"
        Me.axie3_defesa.Size = New System.Drawing.Size(15, 18)
        Me.axie3_defesa.TabIndex = 21
        Me.axie3_defesa.Text = "0"
        '
        'axie3_dano
        '
        Me.axie3_dano.AutoSize = True
        Me.axie3_dano.Font = New System.Drawing.Font("Roboto Slab", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie3_dano.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.axie3_dano.Location = New System.Drawing.Point(6, 69)
        Me.axie3_dano.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.axie3_dano.Name = "axie3_dano"
        Me.axie3_dano.Size = New System.Drawing.Size(15, 18)
        Me.axie3_dano.TabIndex = 9
        Me.axie3_dano.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.axie2_rabo)
        Me.GroupBox1.Controls.Add(Me.axie2_costas)
        Me.GroupBox1.Controls.Add(Me.axie2_chifre)
        Me.GroupBox1.Controls.Add(Me.axie2_defesa)
        Me.GroupBox1.Controls.Add(Me.axie2_boca)
        Me.GroupBox1.Controls.Add(Me.axie2_dano)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(61, 70)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Axie2"
        '
        'axie2_defesa
        '
        Me.axie2_defesa.AutoSize = True
        Me.axie2_defesa.Font = New System.Drawing.Font("Roboto Slab", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie2_defesa.ForeColor = System.Drawing.Color.Blue
        Me.axie2_defesa.Location = New System.Drawing.Point(6, 84)
        Me.axie2_defesa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.axie2_defesa.Name = "axie2_defesa"
        Me.axie2_defesa.Size = New System.Drawing.Size(15, 18)
        Me.axie2_defesa.TabIndex = 21
        Me.axie2_defesa.Text = "0"
        '
        'axie2_dano
        '
        Me.axie2_dano.AutoSize = True
        Me.axie2_dano.Font = New System.Drawing.Font("Roboto Slab", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie2_dano.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.axie2_dano.Location = New System.Drawing.Point(6, 69)
        Me.axie2_dano.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.axie2_dano.Name = "axie2_dano"
        Me.axie2_dano.Size = New System.Drawing.Size(15, 18)
        Me.axie2_dano.TabIndex = 9
        Me.axie2_dano.Text = "0"
        '
        'Axie1GB
        '
        Me.Axie1GB.Controls.Add(Me.axie1_rabo)
        Me.Axie1GB.Controls.Add(Me.axie1_costas)
        Me.Axie1GB.Controls.Add(Me.axie1_chifre)
        Me.Axie1GB.Controls.Add(Me.axie1_defesa)
        Me.Axie1GB.Controls.Add(Me.axie1_boca)
        Me.Axie1GB.Controls.Add(Me.axie1_dano)
        Me.Axie1GB.Location = New System.Drawing.Point(7, 22)
        Me.Axie1GB.Name = "Axie1GB"
        Me.Axie1GB.Size = New System.Drawing.Size(59, 70)
        Me.Axie1GB.TabIndex = 31
        Me.Axie1GB.TabStop = False
        Me.Axie1GB.Text = "Axie1"
        '
        'axie1_defesa
        '
        Me.axie1_defesa.AutoSize = True
        Me.axie1_defesa.Font = New System.Drawing.Font("Roboto Slab", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie1_defesa.ForeColor = System.Drawing.Color.Blue
        Me.axie1_defesa.Location = New System.Drawing.Point(6, 84)
        Me.axie1_defesa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.axie1_defesa.Name = "axie1_defesa"
        Me.axie1_defesa.Size = New System.Drawing.Size(15, 18)
        Me.axie1_defesa.TabIndex = 21
        Me.axie1_defesa.Text = "0"
        '
        'axie1_dano
        '
        Me.axie1_dano.AutoSize = True
        Me.axie1_dano.Font = New System.Drawing.Font("Roboto Slab", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie1_dano.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.axie1_dano.Location = New System.Drawing.Point(6, 69)
        Me.axie1_dano.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.axie1_dano.Name = "axie1_dano"
        Me.axie1_dano.Size = New System.Drawing.Size(15, 18)
        Me.axie1_dano.TabIndex = 9
        Me.axie1_dano.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Slab", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 30)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "1=Boca;2=Chifre;3=Costas;4=Rabo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ";"
        Me.Label4.Visible = False
        '
        'BGBox
        '
        Me.BGBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BGBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.BGBox.FormattingEnabled = True
        Me.BGBox.Items.AddRange(New Object() {"Black", "White"})
        Me.BGBox.Location = New System.Drawing.Point(98, 2)
        Me.BGBox.Name = "BGBox"
        Me.BGBox.Size = New System.Drawing.Size(69, 17)
        Me.BGBox.TabIndex = 48
        '
        'TrocarBG
        '
        Me.TrocarBG.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TrocarBG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TrocarBG.Font = New System.Drawing.Font("Roboto Slab", 6.0!, System.Drawing.FontStyle.Bold)
        Me.TrocarBG.Location = New System.Drawing.Point(171, 2)
        Me.TrocarBG.Name = "TrocarBG"
        Me.TrocarBG.Size = New System.Drawing.Size(25, 17)
        Me.TrocarBG.TabIndex = 47
        Me.TrocarBG.Text = "..."
        Me.TrocarBG.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TrocarBG.UseVisualStyleBackColor = False
        '
        'limpar
        '
        Me.limpar.BackColor = System.Drawing.Color.Gold
        Me.limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.limpar.Image = Global.Calculadora_Axie.My.Resources.Resources.RESETpeq2
        Me.limpar.Location = New System.Drawing.Point(7, 5)
        Me.limpar.Name = "limpar"
        Me.limpar.Size = New System.Drawing.Size(64, 14)
        Me.limpar.TabIndex = 49
        Me.limpar.UseVisualStyleBackColor = False
        '
        'axie3_rabo
        '
        Me.axie3_rabo.BackColor = System.Drawing.Color.White
        Me.axie3_rabo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.axie3_rabo.Font = New System.Drawing.Font("Roboto Slab", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie3_rabo.Image = Global.Calculadora_Axie.My.Resources.Resources.rabo_20x20
        Me.axie3_rabo.Location = New System.Drawing.Point(31, 41)
        Me.axie3_rabo.Margin = New System.Windows.Forms.Padding(4)
        Me.axie3_rabo.Name = "axie3_rabo"
        Me.axie3_rabo.Size = New System.Drawing.Size(20, 20)
        Me.axie3_rabo.TabIndex = 24
        Me.axie3_rabo.UseVisualStyleBackColor = False
        '
        'axie3_costas
        '
        Me.axie3_costas.BackColor = System.Drawing.Color.White
        Me.axie3_costas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.axie3_costas.Font = New System.Drawing.Font("Roboto Slab", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie3_costas.Image = Global.Calculadora_Axie.My.Resources.Resources.costas_20x20
        Me.axie3_costas.Location = New System.Drawing.Point(31, 18)
        Me.axie3_costas.Margin = New System.Windows.Forms.Padding(4)
        Me.axie3_costas.Name = "axie3_costas"
        Me.axie3_costas.Size = New System.Drawing.Size(20, 20)
        Me.axie3_costas.TabIndex = 23
        Me.axie3_costas.UseVisualStyleBackColor = False
        '
        'axie3_chifre
        '
        Me.axie3_chifre.BackColor = System.Drawing.Color.White
        Me.axie3_chifre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.axie3_chifre.Font = New System.Drawing.Font("Roboto Slab", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie3_chifre.Image = Global.Calculadora_Axie.My.Resources.Resources.chifre_20x20
        Me.axie3_chifre.Location = New System.Drawing.Point(9, 18)
        Me.axie3_chifre.Margin = New System.Windows.Forms.Padding(4)
        Me.axie3_chifre.Name = "axie3_chifre"
        Me.axie3_chifre.Size = New System.Drawing.Size(20, 20)
        Me.axie3_chifre.TabIndex = 22
        Me.axie3_chifre.UseVisualStyleBackColor = False
        '
        'axie3_boca
        '
        Me.axie3_boca.BackColor = System.Drawing.Color.White
        Me.axie3_boca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.axie3_boca.Font = New System.Drawing.Font("Roboto Slab", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie3_boca.Image = Global.Calculadora_Axie.My.Resources.Resources.boca_20x20
        Me.axie3_boca.Location = New System.Drawing.Point(9, 41)
        Me.axie3_boca.Margin = New System.Windows.Forms.Padding(4)
        Me.axie3_boca.Name = "axie3_boca"
        Me.axie3_boca.Size = New System.Drawing.Size(20, 20)
        Me.axie3_boca.TabIndex = 17
        Me.axie3_boca.UseVisualStyleBackColor = False
        '
        'axie2_rabo
        '
        Me.axie2_rabo.BackColor = System.Drawing.Color.White
        Me.axie2_rabo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.axie2_rabo.Font = New System.Drawing.Font("Roboto Slab", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie2_rabo.Image = Global.Calculadora_Axie.My.Resources.Resources.rabo_20x20
        Me.axie2_rabo.Location = New System.Drawing.Point(31, 41)
        Me.axie2_rabo.Margin = New System.Windows.Forms.Padding(4)
        Me.axie2_rabo.Name = "axie2_rabo"
        Me.axie2_rabo.Size = New System.Drawing.Size(20, 20)
        Me.axie2_rabo.TabIndex = 24
        Me.axie2_rabo.UseVisualStyleBackColor = False
        '
        'axie2_costas
        '
        Me.axie2_costas.BackColor = System.Drawing.Color.White
        Me.axie2_costas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.axie2_costas.Font = New System.Drawing.Font("Roboto Slab", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie2_costas.Image = Global.Calculadora_Axie.My.Resources.Resources.costas_20x20
        Me.axie2_costas.Location = New System.Drawing.Point(31, 18)
        Me.axie2_costas.Margin = New System.Windows.Forms.Padding(4)
        Me.axie2_costas.Name = "axie2_costas"
        Me.axie2_costas.Size = New System.Drawing.Size(20, 20)
        Me.axie2_costas.TabIndex = 23
        Me.axie2_costas.UseVisualStyleBackColor = False
        '
        'axie2_chifre
        '
        Me.axie2_chifre.BackColor = System.Drawing.Color.White
        Me.axie2_chifre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.axie2_chifre.Font = New System.Drawing.Font("Roboto Slab", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie2_chifre.Image = Global.Calculadora_Axie.My.Resources.Resources.chifre_20x20
        Me.axie2_chifre.Location = New System.Drawing.Point(9, 18)
        Me.axie2_chifre.Margin = New System.Windows.Forms.Padding(4)
        Me.axie2_chifre.Name = "axie2_chifre"
        Me.axie2_chifre.Size = New System.Drawing.Size(20, 20)
        Me.axie2_chifre.TabIndex = 22
        Me.axie2_chifre.UseVisualStyleBackColor = False
        '
        'axie2_boca
        '
        Me.axie2_boca.BackColor = System.Drawing.Color.White
        Me.axie2_boca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.axie2_boca.Font = New System.Drawing.Font("Roboto Slab", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie2_boca.Image = Global.Calculadora_Axie.My.Resources.Resources.boca_20x20
        Me.axie2_boca.Location = New System.Drawing.Point(9, 41)
        Me.axie2_boca.Margin = New System.Windows.Forms.Padding(4)
        Me.axie2_boca.Name = "axie2_boca"
        Me.axie2_boca.Size = New System.Drawing.Size(20, 20)
        Me.axie2_boca.TabIndex = 17
        Me.axie2_boca.UseVisualStyleBackColor = False
        '
        'axie1_rabo
        '
        Me.axie1_rabo.BackColor = System.Drawing.Color.White
        Me.axie1_rabo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.axie1_rabo.Font = New System.Drawing.Font("Roboto Slab", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie1_rabo.Image = Global.Calculadora_Axie.My.Resources.Resources.rabo_20x20
        Me.axie1_rabo.Location = New System.Drawing.Point(31, 41)
        Me.axie1_rabo.Margin = New System.Windows.Forms.Padding(4)
        Me.axie1_rabo.Name = "axie1_rabo"
        Me.axie1_rabo.Size = New System.Drawing.Size(20, 20)
        Me.axie1_rabo.TabIndex = 24
        Me.axie1_rabo.UseVisualStyleBackColor = False
        '
        'axie1_costas
        '
        Me.axie1_costas.BackColor = System.Drawing.Color.Black
        Me.axie1_costas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.axie1_costas.Font = New System.Drawing.Font("Roboto Slab", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie1_costas.Image = Global.Calculadora_Axie.My.Resources.Resources.costas_20x20
        Me.axie1_costas.Location = New System.Drawing.Point(31, 18)
        Me.axie1_costas.Margin = New System.Windows.Forms.Padding(4)
        Me.axie1_costas.Name = "axie1_costas"
        Me.axie1_costas.Size = New System.Drawing.Size(20, 20)
        Me.axie1_costas.TabIndex = 23
        Me.axie1_costas.UseVisualStyleBackColor = False
        '
        'axie1_chifre
        '
        Me.axie1_chifre.BackColor = System.Drawing.Color.White
        Me.axie1_chifre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.axie1_chifre.Font = New System.Drawing.Font("Roboto Slab", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie1_chifre.Image = Global.Calculadora_Axie.My.Resources.Resources.chifre_20x20
        Me.axie1_chifre.Location = New System.Drawing.Point(9, 18)
        Me.axie1_chifre.Margin = New System.Windows.Forms.Padding(4)
        Me.axie1_chifre.Name = "axie1_chifre"
        Me.axie1_chifre.Size = New System.Drawing.Size(20, 20)
        Me.axie1_chifre.TabIndex = 22
        Me.axie1_chifre.UseVisualStyleBackColor = False
        '
        'axie1_boca
        '
        Me.axie1_boca.BackColor = System.Drawing.Color.White
        Me.axie1_boca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.axie1_boca.Font = New System.Drawing.Font("Roboto Slab", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.axie1_boca.Image = Global.Calculadora_Axie.My.Resources.Resources.boca_20x20
        Me.axie1_boca.Location = New System.Drawing.Point(9, 41)
        Me.axie1_boca.Margin = New System.Windows.Forms.Padding(4)
        Me.axie1_boca.Name = "axie1_boca"
        Me.axie1_boca.Size = New System.Drawing.Size(20, 20)
        Me.axie1_boca.TabIndex = 17
        Me.axie1_boca.UseVisualStyleBackColor = False
        '
        'pinbt
        '
        Me.pinbt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pinbt.BackgroundImage = Global.Calculadora_Axie.My.Resources.Resources.pin_25x22
        Me.pinbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pinbt.Font = New System.Drawing.Font("Roboto Slab", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pinbt.Location = New System.Drawing.Point(72, 1)
        Me.pinbt.Name = "pinbt"
        Me.pinbt.Size = New System.Drawing.Size(25, 22)
        Me.pinbt.TabIndex = 50
        Me.pinbt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pinbt.UseVisualStyleBackColor = False
        '
        'Controle_de_Cartas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 108)
        Me.Controls.Add(Me.pinbt)
        Me.Controls.Add(Me.limpar)
        Me.Controls.Add(Me.BGBox)
        Me.Controls.Add(Me.TrocarBG)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Axie1GB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Controle_de_Cartas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Card Counter"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Axie1GB.ResumeLayout(False)
        Me.Axie1GB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents axie3_rabo As Button
    Friend WithEvents axie3_costas As Button
    Friend WithEvents axie3_chifre As Button
    Friend WithEvents axie3_defesa As Label
    Friend WithEvents axie3_boca As Button
    Friend WithEvents axie3_dano As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents axie2_rabo As Button
    Friend WithEvents axie2_costas As Button
    Friend WithEvents axie2_chifre As Button
    Friend WithEvents axie2_defesa As Label
    Friend WithEvents axie2_boca As Button
    Friend WithEvents axie2_dano As Label
    Friend WithEvents Axie1GB As GroupBox
    Friend WithEvents axie1_rabo As Button
    Friend WithEvents axie1_costas As Button
    Friend WithEvents axie1_chifre As Button
    Friend WithEvents axie1_defesa As Label
    Friend WithEvents axie1_boca As Button
    Friend WithEvents axie1_dano As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BGBox As ComboBox
    Friend WithEvents TrocarBG As Button
    Friend WithEvents limpar As Button
    Friend WithEvents pinbt As Button
End Class
