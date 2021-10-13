Imports FirebirdSql
Imports FirebirdSql.Data
Imports FirebirdSql.Data.FirebirdClient
Public Class Cadastrar_Axie
    Dim StringConnection As New FbConnectionStringBuilder
    Private conexao As New FbConnection("User=SYSDBA;Password=masterkey;Database=C:\Axies.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=True;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;")
    Private comando As FbCommand
    Private da As FbDataAdapter
    Private dr As FbDataReader
    Private Sub AbreConexao()
        'conexao.ConnectionString = StringConnection.ToString
        'conexao.Open()
    End Sub
    Private Sub SalvaNoBancoAxie()
        Try
            comando = New FbCommand("INSERT INTO AXIES (AXIEID, HEALTH, SPEED, SKILL, MORALE, BOCA, CHIFRE, COSTAS, RABO, CLASSE, NAME) VALUES (@AXIEID, @HEALTH, @SPEED, @SKILL, @MORALE, @BOCA, @CHIFRE, @COSTAS, @RABO, @CLASSE, @NAME)", conexao)
            comando.Parameters.AddWithValue("@AXIEID", AXIEID_01.Text)
            comando.Parameters.AddWithValue("@HEALTH", valor_hp2.Text)
            comando.Parameters.AddWithValue("@SPEED", valor_speed2.Text)
            comando.Parameters.AddWithValue("@SKILL", valor_skill2.Text)
            comando.Parameters.AddWithValue("@MORALE", valor_moral2.Text)
            comando.Parameters.AddWithValue("@BOCA", BOCA_NOME.Text)
            comando.Parameters.AddWithValue("@CHIFRE", CHIFRE_NOME.Text)
            comando.Parameters.AddWithValue("@COSTAS", COSTAS_NOME.Text)
            comando.Parameters.AddWithValue("@RABO", RABO_NOME.Text)
            comando.Parameters.AddWithValue("@CLASSE", AXIE_CLASSE.Text)
            comando.Parameters.AddWithValue("@NAME", axie_nome_txt.Text)
            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SalvaNoBancoCartas()

    End Sub
    Private Sub EditarNoBanco()
        comando = New FbCommand("UPDATE AXIES SET HEALTH = @HEALTH, SPEED = @SPEED, SKILL = @SKILL, MORALE = @MORALE, BOCA = @BOCA, CHIFRE = @CHIFRE, COSTAS = @COSTAS, RABO = @RABO, CLASSE = @CLASSE WHERE AXIEID = @AXIEID", conexao)
        comando.Parameters.AddWithValue("@AXIEID", AXIEID_01.Text)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub
    Private Sub DeletarNoBanco()
        comando = New FbCommand("DELETE FROM AXIES WHERE AXIEID = @AXIEID", conexao)
        comando.Parameters.AddWithValue("@AXIEID", AXIEID_01.Text)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub
    Private Sub ListarNoBanco()
        Dim ds As New DataSet
        da = New FbDataAdapter("SELECT * FROM AXIES", conexao)
        da.Fill(ds)
        'axie1_id.fill(ds)
    End Sub
    Private Sub ConsultarNoBanco()
        comando = New FbCommand("SELECT * FROM AXIES WHERE AXIEID = @AXIEID", conexao)
        comando.Parameters.AddWithValue("@AXIEID", AXIEID_01.Text)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            AXIEID_01.Text = dr("AXIEID")
        End While
        conexao.Close()
    End Sub
    Private Sub FechaConexao()
        conexao.Close()
    End Sub
    Private Sub Cadastrar_Axie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SalvarBD.Click
        SalvaNoBancoAxie()
        FechaConexao()
        MsgBox("Feito!")
        Me.Close()


    End Sub
End Class