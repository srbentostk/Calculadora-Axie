<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Placar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Placar))
        Me.win_bt = New System.Windows.Forms.Button()
        Me.draw_bt = New System.Windows.Forms.Button()
        Me.lose_bt = New System.Windows.Forms.Button()
        Me.win = New System.Windows.Forms.Label()
        Me.draw = New System.Windows.Forms.Label()
        Me.lose = New System.Windows.Forms.Label()
        Me.BGBox = New System.Windows.Forms.ComboBox()
        Me.TrocarBG = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'win_bt
        '
        Me.win_bt.Font = New System.Drawing.Font("Roboto Slab", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.win_bt.Location = New System.Drawing.Point(12, 56)
        Me.win_bt.Name = "win_bt"
        Me.win_bt.Size = New System.Drawing.Size(56, 28)
        Me.win_bt.TabIndex = 0
        Me.win_bt.Text = "Win"
        Me.win_bt.UseVisualStyleBackColor = True
        '
        'draw_bt
        '
        Me.draw_bt.Font = New System.Drawing.Font("Roboto Slab", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.draw_bt.Location = New System.Drawing.Point(74, 56)
        Me.draw_bt.Name = "draw_bt"
        Me.draw_bt.Size = New System.Drawing.Size(56, 28)
        Me.draw_bt.TabIndex = 1
        Me.draw_bt.Text = "Draw"
        Me.draw_bt.UseVisualStyleBackColor = True
        '
        'lose_bt
        '
        Me.lose_bt.Font = New System.Drawing.Font("Roboto Slab", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lose_bt.Location = New System.Drawing.Point(136, 56)
        Me.lose_bt.Name = "lose_bt"
        Me.lose_bt.Size = New System.Drawing.Size(56, 28)
        Me.lose_bt.TabIndex = 2
        Me.lose_bt.Text = "Lose"
        Me.lose_bt.UseVisualStyleBackColor = True
        '
        'win
        '
        Me.win.AutoSize = True
        Me.win.BackColor = System.Drawing.Color.Transparent
        Me.win.Font = New System.Drawing.Font("Roboto Slab", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.win.ForeColor = System.Drawing.Color.DarkGreen
        Me.win.Location = New System.Drawing.Point(25, 16)
        Me.win.Name = "win"
        Me.win.Size = New System.Drawing.Size(32, 37)
        Me.win.TabIndex = 3
        Me.win.Text = "0"
        '
        'draw
        '
        Me.draw.AutoSize = True
        Me.draw.BackColor = System.Drawing.Color.Transparent
        Me.draw.Font = New System.Drawing.Font("Roboto Slab", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.draw.Location = New System.Drawing.Point(89, 16)
        Me.draw.Name = "draw"
        Me.draw.Size = New System.Drawing.Size(32, 37)
        Me.draw.TabIndex = 4
        Me.draw.Text = "0"
        '
        'lose
        '
        Me.lose.AutoSize = True
        Me.lose.BackColor = System.Drawing.Color.Transparent
        Me.lose.Font = New System.Drawing.Font("Roboto Slab", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lose.ForeColor = System.Drawing.Color.Red
        Me.lose.Location = New System.Drawing.Point(150, 16)
        Me.lose.Name = "lose"
        Me.lose.Size = New System.Drawing.Size(32, 37)
        Me.lose.TabIndex = 5
        Me.lose.Text = "0"
        '
        'BGBox
        '
        Me.BGBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BGBox.FormattingEnabled = True
        Me.BGBox.Items.AddRange(New Object() {"0", "1", "2", "3", "Black", "White"})
        Me.BGBox.Location = New System.Drawing.Point(118, 0)
        Me.BGBox.Name = "BGBox"
        Me.BGBox.Size = New System.Drawing.Size(60, 21)
        Me.BGBox.TabIndex = 50
        Me.BGBox.Visible = False
        '
        'TrocarBG
        '
        Me.TrocarBG.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TrocarBG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TrocarBG.Font = New System.Drawing.Font("Roboto Slab", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrocarBG.Location = New System.Drawing.Point(179, 0)
        Me.TrocarBG.Name = "TrocarBG"
        Me.TrocarBG.Size = New System.Drawing.Size(25, 22)
        Me.TrocarBG.TabIndex = 49
        Me.TrocarBG.Text = "..."
        Me.TrocarBG.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TrocarBG.UseVisualStyleBackColor = False
        Me.TrocarBG.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = Global.Calculadora_Axie.My.Resources.Resources.settings_icon
        Me.Button1.Location = New System.Drawing.Point(-1, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 51
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Placar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Calculadora_Axie.My.Resources.Resources.bgplacar
        Me.ClientSize = New System.Drawing.Size(204, 84)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BGBox)
        Me.Controls.Add(Me.TrocarBG)
        Me.Controls.Add(Me.lose)
        Me.Controls.Add(Me.draw)
        Me.Controls.Add(Me.win)
        Me.Controls.Add(Me.lose_bt)
        Me.Controls.Add(Me.draw_bt)
        Me.Controls.Add(Me.win_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Placar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Placar"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents win_bt As Button
    Friend WithEvents draw_bt As Button
    Friend WithEvents lose_bt As Button
    Friend WithEvents win As Label
    Friend WithEvents draw As Label
    Friend WithEvents lose As Label
    Friend WithEvents BGBox As ComboBox
    Friend WithEvents TrocarBG As Button
    Friend WithEvents Button1 As Button
End Class
