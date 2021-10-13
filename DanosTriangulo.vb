Imports FirebirdSql
Imports FirebirdSql.Data
Imports FirebirdSql.Data.FirebirdClient
Public Class DanosTriangulo
    Dim StringConnection As New FbConnectionStringBuilder
    Private conexao As New FbConnection("User=SYSDBA;Password=masterkey;Database=C:\Axies.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=True;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;")
    Private comando As FbCommand
    Private da As FbDataAdapter
    Private dr As FbDataReader
    Private Sub DanosTriangulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarNoBancoBG()
    End Sub
    Private Function TrocarBg1()
        Me.BackgroundImage = My.Resources.Resources.bgbonusdeclasse
    End Function
    Private Function TrocarBg2()
        Me.BackgroundImage = My.Resources.Resources.background

    End Function
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles TrocarBG.Click
        bgmudar()
        EditarBGCalculadora()
    End Sub
    Private Sub EditarBGCalculadora()
        comando = New FbCommand("UPDATE BACKGROUND SET BGBONUSDECLASSE = @BGBONUSDECLASSE", conexao)
        comando.Parameters.AddWithValue("@BGBONUSDECLASSE", BGBox.Text)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub
    Private Sub ConsultarNoBancoBG()
        Dim BGBONUSDECLASSE As String
        comando = New FbCommand("SELECT * FROM BACKGROUND", conexao)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            BGBONUSDECLASSE = dr("BGBONUSDECLASSE")
        End While
        conexao.Close()
        Select Case BGBONUSDECLASSE
            Case 1
                Me.BackgroundImage = My.Resources.Resources.bgbonusdeclasse
                triangulo.Image = My.Resources.Resources.bonusdeclasse
            Case "White"
                Me.BackgroundImage = My.Resources.Resources.backgroundwhite_jpg
                triangulo.Image = My.Resources.Resources.bonusdeclasse_azul
            Case "Black"
                Me.BackgroundImage = My.Resources.Resources.backgroundblack_jpg
                triangulo.Image = My.Resources.Resources.bonusdeclasse
        End Select
    End Sub

    Private Function bgmudar()
        Dim bgvar As String = BGBox.Text
        Select Case bgvar
            Case 1
                Me.BackgroundImage = My.Resources.Resources.bgbonusdeclasse
                triangulo.Image = My.Resources.Resources.bonusdeclasse

            Case "White"
                Me.BackgroundImage = My.Resources.Resources.backgroundwhite_jpg
                triangulo.Image = My.Resources.Resources.bonusdeclasse_azul
            Case "Black"
                Me.BackgroundImage = My.Resources.Resources.backgroundblack_jpg
                triangulo.Image = My.Resources.Resources.bonusdeclasse
        End Select
    End Function

    Private Sub TrocarBG_Click(sender As Object, e As EventArgs) Handles TrocarBG.Click

    End Sub
End Class