<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanosTriangulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DanosTriangulo))
        Me.triangulo = New System.Windows.Forms.PictureBox()
        Me.bgnum = New System.Windows.Forms.Label()
        Me.TrocarBG = New System.Windows.Forms.Button()
        Me.BGBox = New System.Windows.Forms.ComboBox()
        CType(Me.triangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'triangulo
        '
        Me.triangulo.BackColor = System.Drawing.Color.Transparent
        Me.triangulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.triangulo.Image = Global.Calculadora_Axie.My.Resources.Resources.bonusdeclasse_azul
        Me.triangulo.Location = New System.Drawing.Point(0, 0)
        Me.triangulo.Name = "triangulo"
        Me.triangulo.Size = New System.Drawing.Size(222, 208)
        Me.triangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.triangulo.TabIndex = 0
        Me.triangulo.TabStop = False
        '
        'bgnum
        '
        Me.bgnum.AutoSize = True
        Me.bgnum.Location = New System.Drawing.Point(178, 5)
        Me.bgnum.Name = "bgnum"
        Me.bgnum.Size = New System.Drawing.Size(13, 13)
        Me.bgnum.TabIndex = 47
        Me.bgnum.Text = "0"
        Me.bgnum.Visible = False
        '
        'TrocarBG
        '
        Me.TrocarBG.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TrocarBG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TrocarBG.Font = New System.Drawing.Font("Roboto Slab", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrocarBG.Location = New System.Drawing.Point(197, 0)
        Me.TrocarBG.Name = "TrocarBG"
        Me.TrocarBG.Size = New System.Drawing.Size(25, 22)
        Me.TrocarBG.TabIndex = 46
        Me.TrocarBG.Text = "..."
        Me.TrocarBG.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TrocarBG.UseVisualStyleBackColor = False
        '
        'BGBox
        '
        Me.BGBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BGBox.FormattingEnabled = True
        Me.BGBox.Items.AddRange(New Object() {"1", "Black", "White"})
        Me.BGBox.Location = New System.Drawing.Point(131, 1)
        Me.BGBox.Name = "BGBox"
        Me.BGBox.Size = New System.Drawing.Size(60, 21)
        Me.BGBox.TabIndex = 48
        '
        'DanosTriangulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.Calculadora_Axie.My.Resources.Resources.backgroundwhite_jpg
        Me.ClientSize = New System.Drawing.Size(222, 208)
        Me.Controls.Add(Me.BGBox)
        Me.Controls.Add(Me.bgnum)
        Me.Controls.Add(Me.TrocarBG)
        Me.Controls.Add(Me.triangulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DanosTriangulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bônus de Classe"
        Me.TopMost = True
        CType(Me.triangulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents triangulo As PictureBox
    Friend WithEvents bgnum As Label
    Friend WithEvents TrocarBG As Button
    Friend WithEvents BGBox As ComboBox
End Class
