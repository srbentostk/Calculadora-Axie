Imports FirebirdSql
Imports FirebirdSql.Data
Imports FirebirdSql.Data.FirebirdClient
Public Class CadCartas
    Dim StringConnection As New FbConnectionStringBuilder
    Private conexao As New FbConnection("User=SYSDBA;Password=masterkey;Database=C:\Axies.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=True;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;")
    Private comando As FbCommand
    Private da As FbDataAdapter
    Private dr As FbDataReader
    Private Sub AbreConexao()
        'conexao.ConnectionString = StringConnection.ToString
        'conexao.Open()
    End Sub
    Private Sub SalvaNoBanco()
        Try
            comando = New FbCommand("INSERT INTO CARTA (CUSTO, PARTE, NOME, CLASSE, ATAQUE, DEFESA, EFEITO) values (@CUSTO, @PARTE, @NOME, @CLASSE, @ATAQUE, @DEFESA, @EFEITO)", conexao)
            comando.Parameters.AddWithValue("PARTE", parte_combo.Text)
            comando.Parameters.AddWithValue("NOME", nome_combo.Text)
            comando.Parameters.AddWithValue("CLASSE", classe_combo.Text)
            comando.Parameters.AddWithValue("ATAQUE", ataque_text.Text)
            comando.Parameters.AddWithValue("DEFESA", defesa_text.Text)
            comando.Parameters.AddWithValue("EFEITO", efeito_text.Text)
            comando.Parameters.AddWithValue("CUSTO", custo_valor.Text)
            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SalvaNoBancoAxie()
        Try
            comando = New FbCommand("INSERT INTO AXIES (AXIEID, HEALTH, SPEED, SKILL, MORALE, BOCA, CHIFRE, COSTAS, RABO, CLASSE) VALUES (@AXIEID, @HEALTH, @SPEED, @SKILL, @MORALE, @BOCA, @CHIFRE, @COSTAS, @RABO, @CLASSE)", conexao)

            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditarNoBanco()
        comando = New FbCommand("UPDATE CARTA SET CUSTO = @CUSTO, PARTE = @PARTE, CLASSE = @CLASSE, ATAQUE = @ATAQUE, DEFESA = @DEFESA, EFEITO = @EFEITO WHERE NOME = @NOME", conexao)
        comando.Parameters.AddWithValue("@NOME", nome_combo.Text)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub
    Private Sub DeletarNoBanco()
        comando = New FbCommand("DELETE FROM CARTA WHERE NOME = @NOME", conexao)
        comando.Parameters.AddWithValue("@NOME", nome_combo.Text)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub
    'LISTA PARA CASO DE PREENCHER ALGUMA LISTA PARA EXIBIR A TABELA DO BANCO DE DADOS
    Private Sub ListarNoBanco()
        Dim ds As New DataSet
        da = New FbDataAdapter("SELECT * FROM CARTA", conexao)
        da.Fill(ds)
    End Sub
    Private Sub ConsultarNoBanco()
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @NOME", conexao)
        comando.Parameters.AddWithValue("@NOME", nome_combo.Text)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            nome_combo.Text = dr("NOME")
            parte_combo.Text = dr("PARTE")
            classe_combo.Text = dr("CLASSE")
            ataque_text.Text = dr("ATAQUE")
            defesa_text.Text = dr("DEFESA")
            efeito_text.Text = dr("EFEITO")
            custo_valor.TextAlign = dr("CUSTO")
        End While
        conexao.Close()
    End Sub
    Private Sub FechaConexao()
        conexao.Close()
    End Sub
    Private Sub PreparaConexao()
        StringConnection.ServerType = FbServerType.Default
        StringConnection.DataSource = "127.0.0.1" 'Aqui é o ip da máquina onde fica o banco de dados
        StringConnection.UserID = "SYSDBA"
        StringConnection.Port = 3050
        StringConnection.Password = "masterkey"
        StringConnection.Dialect = 3
        StringConnection.Database = "D:\Axie\Axies.fdb" 'caminho do banco de dados
        StringConnection.Pooling = False

    End Sub
    Private Sub CadCartas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreparaConexao()

    End Sub
    Private Function Limpar()
        Me.Close()
    End Function
    Private Sub salvar_btn_Click(sender As Object, e As EventArgs) Handles salvar_btn.Click
        SalvaNoBanco()
        FechaConexao()
        MsgBox("Feito!")
        Limpar()
    End Sub
End Class