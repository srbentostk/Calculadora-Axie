Imports FirebirdSql
Imports FirebirdSql.Data
Imports FirebirdSql.Data.FirebirdClient
Public Class Placar
    Private conexao As New FbConnection("User=SYSDBA;Password=masterkey;Database=C:\Axies.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=True;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;")
    Private comando As FbCommand
    Private da As FbDataAdapter
    Private dr As FbDataReader
    '-------------------------------- FUNÇÕES DO PLACAR
    Private Sub win_bt_Click(sender As Object, e As EventArgs) Handles win_bt.Click
        Dim Win_nb As Integer = win.Text
        win.Text = Win_nb + 1

    End Sub

    Private Sub draw_bt_Click(sender As Object, e As EventArgs) Handles draw_bt.Click
        Dim Draw_nb As Integer = draw.Text
        draw.Text = Draw_nb + 1
    End Sub

    Private Sub lose_bt_Click(sender As Object, e As EventArgs) Handles lose_bt.Click
        Dim Lose_nb As Integer = lose.Text
        lose.Text = Lose_nb + 1
    End Sub


    '--------------------------------- FUNÇÕES DE TROCAR BACKGROUND
    Private Sub EditarBGCalculadora()
        comando = New FbCommand("UPDATE BACKGROUND SET BGPLACAR = @BGPLACAR", conexao)
        comando.Parameters.AddWithValue("@BGPLACAR", BGBox.Text)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub
    Private Sub ConsultarNoBancoBG()
        Dim BGPLACAR As String
        comando = New FbCommand("SELECT * FROM BACKGROUND", conexao)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            BGPLACAR = dr("BGPLACAR")
        End While
        conexao.Close()
        Select Case BGPLACAR
            Case 0
                Me.BackgroundImage = My.Resources.Resources.bgplacar
                draw.ForeColor = Color.Black
            Case 1
                Me.BackgroundImage = My.Resources.Resources.bgplacar1
                draw.ForeColor = Color.Black
            Case 2
                Me.BackgroundImage = My.Resources.Resources.bgplacar2
                draw.ForeColor = Color.Black
            Case 3
                Me.BackgroundImage = My.Resources.Resources.bgplacar3
                draw.ForeColor = Color.Black
            Case "White"
                Me.BackgroundImage = My.Resources.Resources.backgroundwhite_jpg
                draw.ForeColor = Color.Black
            Case "Black"
                Me.BackgroundImage = My.Resources.Resources.backgroundblack_jpg
                draw.ForeColor = Color.WhiteSmoke
        End Select
    End Sub

    Private Function bgmudar()
        Dim bgvar As String = BGBox.Text
        Select Case bgvar
            Case 0
                Me.BackgroundImage = My.Resources.Resources.bgplacar
                draw.ForeColor = Color.Black
            Case 1
                Me.BackgroundImage = My.Resources.Resources.bgplacar1
                draw.ForeColor = Color.Black
            Case 2
                Me.BackgroundImage = My.Resources.Resources.bgplacar2
                draw.ForeColor = Color.Black
            Case 3
                Me.BackgroundImage = My.Resources.Resources.bgplacar3
                draw.ForeColor = Color.Black
            Case "White"
                Me.BackgroundImage = My.Resources.Resources.backgroundwhite_jpg
                draw.ForeColor = Color.Black
            Case "Black"
                Me.BackgroundImage = My.Resources.Resources.backgroundblack_jpg
                draw.ForeColor = Color.WhiteSmoke
        End Select
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BGBox.Visible = True
        TrocarBG.Visible = True
        Button1.Visible = False
    End Sub

    Private Sub TrocarBG_Click(sender As Object, e As EventArgs) Handles TrocarBG.Click
        bgmudar()
        EditarBGCalculadora()

        Button1.Visible = True
        TrocarBG.Visible = False
        BGBox.Visible = False

    End Sub

    Private Sub Placar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarNoBancoBG()

    End Sub
End Class