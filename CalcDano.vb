Imports FirebirdSql
Imports FirebirdSql.Data
Imports FirebirdSql.Data.FirebirdClient
Public Class CalcDano
    Dim StringConnection As New FbConnectionStringBuilder
    Private conexao As New FbConnection("User=SYSDBA;Password=masterkey;Database=C:\Axies.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=True;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;")
    Private comando As FbCommand
    Private da As FbDataAdapter
    Private dr As FbDataReader
    Dim varaxie1_classe, varaxie2_classe, varaxie3_classe, varaxie1_boca, varaxie1_chifre, varaxie1_costas, varaxie1_rabo, varaxie2_boca, varaxie2_chifre, varaxie2_costas, varaxie2_rabo, varaxie3_boca, varaxie3_chifre, varaxie3_costas, varaxie3_rabo As String
    'Declarar skill dos axies
    Dim skill_axie1, skill_axie2, skill_axie3, skill_axie4 As Integer

    'Declarar os danos e defesas dos axies 1 a 3
    Dim axie1dano, axie1defesa, axie2dano, axie2defesa, axie3dano, axie3defesa As Integer
    'DECLARAR AXIE1
    'declarar boca axie1
    Dim axie1_boca_classe As String
    Dim axie1_boca_ataque, axie1_boca_defesa, axie1_boca_custo, axie1_boca_dano, axie1_boca_escudo As Integer
    'declarar chifre axie1
    Dim axie1_chifre_ataque, axie1_chifre_custo, axie1_chifre_defesa, axie1_chifre_dano, axie1_chifre_escudo As Integer
    Dim axie1_chifre_classe As String
    'declarar costas axie1
    Dim axie1_costas_ataque, axie1_costas_custo, axie1_costas_defesa, axie1_costas_dano, axie1_costas_escudo As Integer
    Dim axie1_costas_classe As String
    'declarar rabo axie1
    Dim axie1_rabo_ataque, axie1_rabo_custo, axie1_rabo_defesa, axie1_rabo_dano, axie1_rabo_escudo As Integer

    Private Sub axie1_dano_Click(sender As Object, e As EventArgs) Handles axie1_dano.Click

    End Sub

    Dim axie1_rabo_classe As String
    'DECLARAÇÃO DO AXIE 2
    'declarar boca axie2
    Dim axie2_boca_classe As String
    Dim axie2_boca_ataque, axie2_boca_defesa, axie2_boca_custo, axie2_boca_dano, axie2_boca_escudo As Integer
    'declarar chifre axie2
    Dim axie2_chifre_ataque, axie2_chifre_custo, axie2_chifre_defesa, axie2_chifre_dano, axie2_chifre_escudo As Integer
    Dim axie2_chifre_classe As String
    'declarar costas axie2
    Dim axie2_costas_ataque, axie2_costas_custo, axie2_costas_defesa, axie2_costas_dano, axie2_costas_escudo As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles limpar.Click
        limpartudo()

    End Sub

    Dim axie2_costas_classe As String
    'declarar rabo axie2
    Dim axie2_rabo_ataque, axie2_rabo_custo, axie2_rabo_defesa, axie2_rabo_dano, axie2_rabo_escudo As Integer
    Dim axie2_rabo_classe As String
    'DECLARAÇÃO DO AXIE 3
    'declarar boca axie3
    Dim axie3_boca_classe As String
    Dim axie3_boca_ataque, axie3_boca_defesa, axie3_boca_custo, axie3_boca_dano, axie3_boca_escudo As Integer
    'declarar chifre axie3
    Dim axie3_chifre_ataque, axie3_chifre_custo, axie3_chifre_defesa, axie3_chifre_dano, axie3_chifre_escudo As Integer
    Dim axie3_chifre_classe As String
    'declarar costas axie3
    Dim axie3_costas_ataque, axie3_costas_custo, axie3_costas_defesa, axie3_costas_dano, axie3_costas_escudo As Integer
    Dim axie3_costas_classe As String
    'declarar rabo axie3
    Dim axie3_rabo_ataque, axie3_rabo_custo, axie3_rabo_defesa, axie3_rabo_dano, axie3_rabo_escudo As Integer
    Dim axie3_rabo_classe As String

    Private Sub ConsultarNoBancoAxie()
        comando = New FbCommand("SELECT * FROM AXIES WHERE NOME = @NOME", conexao)
        'comando.Parameters.AddWithValue("@NOME", nome_combo.Text)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
        End While
        conexao.Close()
    End Sub
    'AXIE 1 FUNÇÃO DE PESQUISAR OS DADOS DAS CARTAS
    Private Sub ConsultarNoBancoCarta_Axie1()
        Dim axie1_id_int As Integer
        axie1_id_int = axie1_id.Text
        'procurar em AXIES a boca, o chifre, as costas, o rabo e a classe do Axie
        comando = New FbCommand("SELECT * FROM AXIES WHERE AXIEID = @AXIEID", conexao)
        comando.Parameters.AddWithValue("@AXIEID", axie1_id_int)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            varaxie1_boca = dr("BOCA")
            varaxie1_chifre = dr("CHIFRE")
            varaxie1_costas = dr("COSTAS")
            varaxie1_rabo = dr("RABO")
            varaxie1_classe = dr("CLASSE")
            skill_axie1 = dr("SKILL")
            'Axie1HP.Text = dr("HEALTH")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta boca do axie
        Try
            comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @NOME", conexao)
            comando.Parameters.AddWithValue("@NOME", varaxie1_boca)
            conexao.Open()
            dr = comando.ExecuteReader()
            While dr.Read
                axie1_boca_ataque = dr("ATAQUE")
                axie1_boca_classe = dr("CLASSE")
                axie1_boca_custo = dr("CUSTO")
                axie1_boca_defesa = dr("DEFESA")
            End While
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'procurar ataque, defesa, classe e custo da carta chifre do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @AXIE1_CHIFRE", conexao)
        comando.Parameters.AddWithValue("@AXIE1_CHIFRE", varaxie1_chifre)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie1_chifre_ataque = dr("ATAQUE")
            axie1_chifre_classe = dr("CLASSE")
            axie1_chifre_custo = dr("CUSTO")
            axie1_chifre_defesa = dr("DEFESA")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta costas do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @AXIE1_COSTAS", conexao)
        comando.Parameters.AddWithValue("@AXIE1_COSTAS", varaxie1_costas)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie1_costas_ataque = dr("ATAQUE")
            axie1_costas_classe = dr("CLASSE")
            axie1_costas_custo = dr("CUSTO")
            axie1_costas_defesa = dr("DEFESA")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta costas do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @AXIE1_RABO", conexao)
        comando.Parameters.AddWithValue("@AXIE1_RABO", varaxie1_rabo)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie1_rabo_ataque = dr("ATAQUE")
            axie1_rabo_classe = dr("CLASSE")
            axie1_rabo_custo = dr("CUSTO")
            axie1_rabo_defesa = dr("DEFESA")
        End While
        conexao.Close()

    End Sub
    'AXIE 2 FUNÇÃO DE PESQUISAR OS DADOS DAS CARTAS
    Private Sub ConsultarNoBancoCarta_axie2()
        Dim axie2_id_int As Integer
        axie2_id_int = axie2_id.Text
        'procurar em AXIES a boca, o chifre, as costas, o rabo e a classe do Axie
        comando = New FbCommand("SELECT * FROM AXIES WHERE AXIEID = @AXIEID", conexao)
        comando.Parameters.AddWithValue("@AXIEID", axie2_id_int)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            varaxie2_boca = dr("BOCA")
            varaxie2_chifre = dr("CHIFRE")
            varaxie2_costas = dr("COSTAS")
            varaxie2_rabo = dr("RABO")
            varaxie2_classe = dr("CLASSE")
            skill_axie2 = dr("SKILL")
            'axie2HP.Text = dr("HEALTH")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta boca do axie
        Try
            comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @NOME", conexao)
            comando.Parameters.AddWithValue("@NOME", varaxie2_boca)
            conexao.Open()
            dr = comando.ExecuteReader()
            While dr.Read
                axie2_boca_ataque = dr("ATAQUE")
                axie2_boca_classe = dr("CLASSE")
                axie2_boca_custo = dr("CUSTO")
                axie2_boca_defesa = dr("DEFESA")
            End While
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'procurar ataque, defesa, classe e custo da carta chifre do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @axie2_CHIFRE", conexao)
        comando.Parameters.AddWithValue("@axie2_CHIFRE", varaxie2_chifre)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie2_chifre_ataque = dr("ATAQUE")
            axie2_chifre_classe = dr("CLASSE")
            axie2_chifre_custo = dr("CUSTO")
            axie2_chifre_defesa = dr("DEFESA")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta costas do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @axie2_COSTAS", conexao)
        comando.Parameters.AddWithValue("@axie2_COSTAS", varaxie2_costas)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie2_costas_ataque = dr("ATAQUE")
            axie2_costas_classe = dr("CLASSE")
            axie2_costas_custo = dr("CUSTO")
            axie2_costas_defesa = dr("DEFESA")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta costas do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @axie2_RABO", conexao)
        comando.Parameters.AddWithValue("@axie2_RABO", varaxie2_rabo)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie2_rabo_ataque = dr("ATAQUE")
            axie2_rabo_classe = dr("CLASSE")
            axie2_rabo_custo = dr("CUSTO")
            axie2_rabo_defesa = dr("DEFESA")
        End While
        conexao.Close()

    End Sub
    'AXIE 3 FUNÇÃO DE PESQUIASR OS DADOS DAS CARTAS
    Private Sub ConsultarNoBancoCarta_axie3()
        Dim axie3_id_int As Integer
        axie3_id_int = axie3_id.Text
        'procurar em AXIES a boca, o chifre, as costas, o rabo e a classe do Axie
        comando = New FbCommand("SELECT * FROM AXIES WHERE AXIEID = @AXIEID", conexao)
        comando.Parameters.AddWithValue("@AXIEID", axie3_id_int)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            varaxie3_boca = dr("BOCA")
            varaxie3_chifre = dr("CHIFRE")
            varaxie3_costas = dr("COSTAS")
            varaxie3_rabo = dr("RABO")
            varaxie3_classe = dr("CLASSE")
            skill_axie3 = dr("SKILL")
            'axie3HP.Text = dr("HEALTH")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta boca do axie
        Try
            comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @NOME", conexao)
            comando.Parameters.AddWithValue("@NOME", varaxie3_boca)
            conexao.Open()
            dr = comando.ExecuteReader()
            While dr.Read
                axie3_boca_ataque = dr("ATAQUE")
                axie3_boca_classe = dr("CLASSE")
                axie3_boca_custo = dr("CUSTO")
                axie3_boca_defesa = dr("DEFESA")
            End While
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'procurar ataque, defesa, classe e custo da carta chifre do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @axie3_CHIFRE", conexao)
        comando.Parameters.AddWithValue("@axie3_CHIFRE", varaxie3_chifre)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie3_chifre_ataque = dr("ATAQUE")
            axie3_chifre_classe = dr("CLASSE")
            axie3_chifre_custo = dr("CUSTO")
            axie3_chifre_defesa = dr("DEFESA")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta costas do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @axie3_COSTAS", conexao)
        comando.Parameters.AddWithValue("@axie3_COSTAS", varaxie3_costas)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie3_costas_ataque = dr("ATAQUE")
            axie3_costas_classe = dr("CLASSE")
            axie3_costas_custo = dr("CUSTO")
            axie3_costas_defesa = dr("DEFESA")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta costas do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @axie3_RABO", conexao)
        comando.Parameters.AddWithValue("@axie3_RABO", varaxie3_rabo)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie3_rabo_ataque = dr("ATAQUE")
            axie3_rabo_classe = dr("CLASSE")
            axie3_rabo_custo = dr("CUSTO")
            axie3_rabo_defesa = dr("DEFESA")
        End While
        conexao.Close()

    End Sub

    'AXIE1 FUNÇÃO DE PESQUISAR OS DADOS DAS CARTAS PELO NOME DO AXIE
    Private Sub ConsultarNoBancoCarta_Axie1_nome()
        Dim axie1_id_int As String
        axie1_id_int = axie1_id.Text
        'procurar em AXIES a boca, o chifre, as costas, o rabo e a classe do Axie
        comando = New FbCommand("SELECT * FROM AXIES WHERE NAME = @NAME", conexao)
        comando.Parameters.AddWithValue("@NAME", axie1_id_int)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            varaxie1_boca = dr("BOCA")
            varaxie1_chifre = dr("CHIFRE")
            varaxie1_costas = dr("COSTAS")
            varaxie1_rabo = dr("RABO")
            varaxie1_classe = dr("CLASSE")
            skill_axie1 = dr("SKILL")
            'Axie1HP.Text = dr("HEALTH")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta boca do axie
        Try
            comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @NOME", conexao)
            comando.Parameters.AddWithValue("@NOME", varaxie1_boca)
            conexao.Open()
            dr = comando.ExecuteReader()
            While dr.Read
                axie1_boca_ataque = dr("ATAQUE")
                axie1_boca_classe = dr("CLASSE")
                axie1_boca_custo = dr("CUSTO")
                axie1_boca_defesa = dr("DEFESA")
            End While
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'procurar ataque, defesa, classe e custo da carta chifre do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @AXIE1_CHIFRE", conexao)
        comando.Parameters.AddWithValue("@AXIE1_CHIFRE", varaxie1_chifre)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie1_chifre_ataque = dr("ATAQUE")
            axie1_chifre_classe = dr("CLASSE")
            axie1_chifre_custo = dr("CUSTO")
            axie1_chifre_defesa = dr("DEFESA")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta costas do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @AXIE1_COSTAS", conexao)
        comando.Parameters.AddWithValue("@AXIE1_COSTAS", varaxie1_costas)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie1_costas_ataque = dr("ATAQUE")
            axie1_costas_classe = dr("CLASSE")
            axie1_costas_custo = dr("CUSTO")
            axie1_costas_defesa = dr("DEFESA")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta costas do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @AXIE1_RABO", conexao)
        comando.Parameters.AddWithValue("@AXIE1_RABO", varaxie1_rabo)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie1_rabo_ataque = dr("ATAQUE")
            axie1_rabo_classe = dr("CLASSE")
            axie1_rabo_custo = dr("CUSTO")
            axie1_rabo_defesa = dr("DEFESA")
        End While
        conexao.Close()

    End Sub
    'axie2 FUNÇÃO DE PESQUISAR OS DADOS DAS CARTAS PELO NOME DO AXIE
    Private Sub ConsultarNoBancoCarta_axie2_nome()
        Dim axie2_id_int As String
        axie2_id_int = axie2_id.Text
        'procurar em AXIES a boca, o chifre, as costas, o rabo e a classe do Axie
        comando = New FbCommand("SELECT * FROM AXIES WHERE NAME = @NAME", conexao)
        comando.Parameters.AddWithValue("@NAME", axie2_id_int)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            varaxie2_boca = dr("BOCA")
            varaxie2_chifre = dr("CHIFRE")
            varaxie2_costas = dr("COSTAS")
            varaxie2_rabo = dr("RABO")
            varaxie2_classe = dr("CLASSE")
            skill_axie2 = dr("SKILL")
            'axie2HP.Text = dr("HEALTH")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta boca do axie
        Try
            comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @NOME", conexao)
            comando.Parameters.AddWithValue("@NOME", varaxie2_boca)
            conexao.Open()
            dr = comando.ExecuteReader()
            While dr.Read
                axie2_boca_ataque = dr("ATAQUE")
                axie2_boca_classe = dr("CLASSE")
                axie2_boca_custo = dr("CUSTO")
                axie2_boca_defesa = dr("DEFESA")
            End While
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'procurar ataque, defesa, classe e custo da carta chifre do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @axie2_CHIFRE", conexao)
        comando.Parameters.AddWithValue("@axie2_CHIFRE", varaxie2_chifre)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie2_chifre_ataque = dr("ATAQUE")
            axie2_chifre_classe = dr("CLASSE")
            axie2_chifre_custo = dr("CUSTO")
            axie2_chifre_defesa = dr("DEFESA")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta costas do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @axie2_COSTAS", conexao)
        comando.Parameters.AddWithValue("@axie2_COSTAS", varaxie2_costas)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie2_costas_ataque = dr("ATAQUE")
            axie2_costas_classe = dr("CLASSE")
            axie2_costas_custo = dr("CUSTO")
            axie2_costas_defesa = dr("DEFESA")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta costas do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @axie2_RABO", conexao)
        comando.Parameters.AddWithValue("@axie2_RABO", varaxie2_rabo)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie2_rabo_ataque = dr("ATAQUE")
            axie2_rabo_classe = dr("CLASSE")
            axie2_rabo_custo = dr("CUSTO")
            axie2_rabo_defesa = dr("DEFESA")
        End While
        conexao.Close()

    End Sub
    'axie3 FUNÇÃO DE PESQUISAR OS DADOS DAS CARTAS PELO NOME DO AXIE
    Private Sub ConsultarNoBancoCarta_axie3_nome()
        Dim axie3_id_int As String
        axie3_id_int = axie3_id.Text
        'procurar em AXIES a boca, o chifre, as costas, o rabo e a classe do Axie
        comando = New FbCommand("SELECT * FROM AXIES WHERE NAME = @NAME", conexao)
        comando.Parameters.AddWithValue("@NAME", axie3_id_int)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            varaxie3_boca = dr("BOCA")
            varaxie3_chifre = dr("CHIFRE")
            varaxie3_costas = dr("COSTAS")
            varaxie3_rabo = dr("RABO")
            varaxie3_classe = dr("CLASSE")
            skill_axie3 = dr("SKILL")
            'axie3HP.Text = dr("HEALTH")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta boca do axie
        Try
            comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @NOME", conexao)
            comando.Parameters.AddWithValue("@NOME", varaxie3_boca)
            conexao.Open()
            dr = comando.ExecuteReader()
            While dr.Read
                axie3_boca_ataque = dr("ATAQUE")
                axie3_boca_classe = dr("CLASSE")
                axie3_boca_custo = dr("CUSTO")
                axie3_boca_defesa = dr("DEFESA")
            End While
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'procurar ataque, defesa, classe e custo da carta chifre do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @axie3_CHIFRE", conexao)
        comando.Parameters.AddWithValue("@axie3_CHIFRE", varaxie3_chifre)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie3_chifre_ataque = dr("ATAQUE")
            axie3_chifre_classe = dr("CLASSE")
            axie3_chifre_custo = dr("CUSTO")
            axie3_chifre_defesa = dr("DEFESA")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta costas do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @axie3_COSTAS", conexao)
        comando.Parameters.AddWithValue("@axie3_COSTAS", varaxie3_costas)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie3_costas_ataque = dr("ATAQUE")
            axie3_costas_classe = dr("CLASSE")
            axie3_costas_custo = dr("CUSTO")
            axie3_costas_defesa = dr("DEFESA")
        End While
        conexao.Close()
        'procurar ataque, defesa, classe e custo da carta costas do axie
        comando = New FbCommand("SELECT * FROM CARTA WHERE NOME = @axie3_RABO", conexao)
        comando.Parameters.AddWithValue("@axie3_RABO", varaxie3_rabo)
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            axie3_rabo_ataque = dr("ATAQUE")
            axie3_rabo_classe = dr("CLASSE")
            axie3_rabo_custo = dr("CUSTO")
            axie3_rabo_defesa = dr("DEFESA")
        End While
        conexao.Close()

    End Sub
    Private Function testaraxie1()
        'axie1_boca_ataque
        'axie1_chifre_ataque
        'axie1_costas_ataque
        'axie1_rabo_ataque
    End Function

    'Preencher as combobox nome
    Private Sub ListarNoBancoAxie1()
        Dim ds As New DataSet
        da = New FbDataAdapter("SELECT * FROM AXIES", conexao)
        Dim table As New DataTable
        da.Fill(table)
        axie1_id.DataSource = table
        axie1_id.DisplayMember = "NAME"
        axie1_id.ValueMember = "AXIEID"


    End Sub
    Private Sub ListarNoBancoAxie2()
        Dim ds As New DataSet
        da = New FbDataAdapter("SELECT * FROM AXIES", conexao)
        Dim table As New DataTable
        da.Fill(table)

        axie2_id.DataSource = table
        axie2_id.DisplayMember = "NAME"
        axie2_id.ValueMember = "AXIEID"

    End Sub
    Private Sub ListarNoBancoAxie3()
        Dim ds As New DataSet
        da = New FbDataAdapter("SELECT * FROM AXIES", conexao)
        Dim table As New DataTable
        da.Fill(table)


        axie3_id.DataSource = table
        axie3_id.DisplayMember = "NAME"
        axie3_id.ValueMember = "AXIEID"
    End Sub
    Private Function reduzirtamanho()
        Me.Size = New Size(213, 183)
    End Function
    Private Sub confirmar_Click(sender As Object, e As EventArgs) Handles confirmar.Click
        reduzirtamanho()
        ConsultarNoBancoCarta_Axie1_nome()
        ConsultarNoBancoCarta_axie2_nome()
        ConsultarNoBancoCarta_axie3_nome()
    End Sub
    'BOTÃO DA BOCA, CHIFRE, COSTAS E RABO DO AXIE1
    Dim axie1bocauso As Integer = 0
    Dim axie1chifreuso As Integer = 0
    Dim axie1costasuso As Integer = 0
    Dim axie1rabouso As Integer = 0
    'BOTÃO DA BOCA, CHIFRE, COSTAS E RABO DO axie2
    Dim axie2bocauso As Integer = 0
    Dim axie2chifreuso As Integer = 0
    Dim axie2costasuso As Integer = 0
    Dim axie2rabouso As Integer = 0
    'BOTÃO DA BOCA, CHIFRE, COSTAS E RABO DO axie3
    Dim axie3bocauso As Integer = 0
    Dim axie3chifreuso As Integer = 0
    Dim axie3costasuso As Integer = 0
    Dim axie3rabouso As Integer = 0
    'CÁLCULO DO BÔNUS DE SKILL DOS AXIES
    Dim bonus_skill_axie1 As Integer = skill_axie1 / 500
    Dim bonus_skill_axie2 As Integer = skill_axie2 / 500
    Dim bonus_skill_axie3 As Integer = skill_axie3 / 500
    '------------------------------------------------------------------------------------------ FUNÇÕES DE DANO DO AXIE 1
    Private Function DanoAxie1_Boca_Com_Ifs()
        Try
            If axie1bocauso < 2 Then
                axie1bocauso += 1
                axie1_boca_dano += axie1_boca_ataque
                axie1_boca_escudo += axie1_boca_defesa
                If axie1_boca_classe = varaxie1_classe Then
                    axie1_boca_dano = axie1_boca_dano * 1.08
                    axie1_boca_escudo = axie1_boca_escudo * 1.08
                End If
                axie1_dano.Text += axie1_boca_dano
                axie1_defesa.Text += axie1_boca_escudo
            ElseIf axie1bocauso = 2 Then
                axie1bocauso = 0

                axie1_dano.Text -= axie1_boca_dano
                axie1_defesa.Text -= axie1_boca_escudo
                axie1_dano.Text -= axie1_boca_dano
                axie1_defesa.Text -= axie1_boca_escudo
                axie1_boca_dano = 0
                axie1_boca_escudo = 0
            End If
            'lbaxie1bocauso.Text = axie1bocauso
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Private Function Dano_axie1_boca_selectcase()
        Select Case axie1bocauso
            Case 0
                axie1bocauso += 1
                If axie1_boca_classe = varaxie1_classe Then
                    axie1_boca_dano = axie1_boca_ataque * 1.1
                    axie1_boca_escudo = axie1_boca_defesa * 1.1
                Else
                    axie1_boca_dano += axie1_boca_ataque
                    axie1_boca_escudo += axie1_boca_defesa
                End If
                axie1_dano.Text += axie1_boca_dano
                axie1_defesa.Text += axie1_boca_escudo
                axie1_boca.BackColor = Color.Lime
            Case 1
                axie1bocauso += 1
                axie1_dano.Text += axie1_boca_dano
                axie1_defesa.Text += axie1_boca_escudo
                axie1_boca.BackColor = Color.Red
            Case 2
                axie1bocauso = 0
                axie1_dano.Text -= axie1_boca_dano
                axie1_defesa.Text -= axie1_boca_escudo
                axie1_dano.Text -= axie1_boca_dano
                axie1_defesa.Text -= axie1_boca_escudo
                axie1_boca_dano = 0
                axie1_boca_escudo = 0
                axie1_boca.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie1_chifre_selectcase()
        Select Case axie1chifreuso
            Case 0
                axie1chifreuso += 1
                If axie1_chifre_classe = varaxie1_classe Then
                    axie1_chifre_dano = axie1_chifre_ataque * 1.1
                    axie1_chifre_escudo = axie1_chifre_defesa * 1.1
                Else
                    axie1_chifre_dano += axie1_chifre_ataque
                    axie1_chifre_escudo += axie1_chifre_defesa
                End If
                axie1_dano.Text += axie1_chifre_dano
                axie1_defesa.Text += axie1_chifre_escudo
                axie1_chifre.BackColor = Color.Lime
            Case 1
                axie1chifreuso += 1
                axie1_dano.Text += axie1_chifre_dano
                axie1_defesa.Text += axie1_chifre_escudo
                axie1_chifre.BackColor = Color.Red
            Case 2
                axie1chifreuso = 0
                axie1_dano.Text -= axie1_chifre_dano
                axie1_defesa.Text -= axie1_chifre_escudo
                axie1_dano.Text -= axie1_chifre_dano
                axie1_defesa.Text -= axie1_chifre_escudo
                axie1_chifre_dano = 0
                axie1_chifre_escudo = 0
                axie1_chifre.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie1_costas_selectcase()
        Select Case axie1costasuso
            Case 0
                axie1costasuso += 1
                If axie1_costas_classe = varaxie1_classe Then
                    axie1_costas_dano = axie1_costas_ataque * 1.1
                    axie1_costas_escudo = axie1_costas_defesa * 1.1
                Else
                    axie1_costas_dano += axie1_costas_ataque
                    axie1_costas_escudo += axie1_costas_defesa
                End If
                axie1_dano.Text += axie1_costas_dano
                axie1_defesa.Text += axie1_costas_escudo
                axie1_costas.BackColor = Color.Lime
            Case 1
                axie1costasuso += 1
                axie1_dano.Text += axie1_costas_dano
                axie1_defesa.Text += axie1_costas_escudo
                axie1_costas.BackColor = Color.Red
            Case 2
                axie1costasuso = 0
                axie1_dano.Text -= axie1_costas_dano
                axie1_defesa.Text -= axie1_costas_escudo
                axie1_dano.Text -= axie1_costas_dano
                axie1_defesa.Text -= axie1_costas_escudo
                axie1_costas_dano = 0
                axie1_costas_escudo = 0
                axie1_costas.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie1_rabo_selectcase()
        Select Case axie1rabouso
            Case 0
                axie1rabouso += 1
                If axie1_rabo_classe = varaxie1_classe Then
                    axie1_rabo_dano = axie1_rabo_ataque * 1.1
                    axie1_rabo_escudo = axie1_rabo_defesa * 1.1
                Else
                    axie1_rabo_dano += axie1_rabo_ataque
                    axie1_rabo_escudo += axie1_rabo_defesa
                End If
                axie1_dano.Text += axie1_rabo_dano
                axie1_defesa.Text += axie1_rabo_escudo
                axie1_rabo.BackColor = Color.Lime
            Case 1
                axie1rabouso += 1
                axie1_dano.Text += axie1_rabo_dano
                axie1_defesa.Text += axie1_rabo_escudo
                axie1_rabo.BackColor = Color.Red
            Case 2
                axie1rabouso = 0
                axie1_dano.Text -= axie1_rabo_dano
                axie1_defesa.Text -= axie1_rabo_escudo
                axie1_dano.Text -= axie1_rabo_dano
                axie1_defesa.Text -= axie1_rabo_escudo
                axie1_rabo_dano = 0
                axie1_rabo_escudo = 0
                axie1_rabo.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Skill_Bonus_Axie1()
        Dim comboativado_axie1, calculo_dano_axie1 As Integer
        calculo_dano_axie1 = axie1_dano.Text

        comboativado_axie1 = axie1bocauso + axie1chifreuso + axie1costasuso + axie1rabouso
        If comboativado_axie1 > 0 Then
            axie1_dano.Text = calculo_dano_axie1 * 1 + bonus_skill_axie1
        End If
    End Function
    '----------------------------------------------------------------------------------------- FUNÇÕES DE DANO DO AXIE 2
    Private Function Dano_axie2_boca_selectcase()
        Select Case axie2bocauso
            Case 0
                axie2bocauso += 1
                If axie2_boca_classe = varaxie2_classe Then
                    axie2_boca_dano = axie2_boca_ataque * 1.1
                    axie2_boca_escudo = axie2_boca_defesa * 1.1
                Else
                    axie2_boca_dano += axie2_boca_ataque
                    axie2_boca_escudo += axie2_boca_defesa
                End If
                axie2_dano.Text += axie2_boca_dano
                axie2_defesa.Text += axie2_boca_escudo
                axie2_boca.BackColor = Color.Lime
            Case 1
                axie2bocauso += 1
                axie2_dano.Text += axie2_boca_dano
                axie2_defesa.Text += axie2_boca_escudo
                axie2_boca.BackColor = Color.Red
            Case 2
                axie2bocauso = 0
                axie2_dano.Text -= axie2_boca_dano
                axie2_defesa.Text -= axie2_boca_escudo
                axie2_dano.Text -= axie2_boca_dano
                axie2_defesa.Text -= axie2_boca_escudo
                axie2_boca_dano = 0
                axie2_boca_escudo = 0
                axie2_boca.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie2_chifre_selectcase()
        Select Case axie2chifreuso
            Case 0
                axie2chifreuso += 1
                If axie2_chifre_classe = varaxie2_classe Then
                    axie2_chifre_dano = axie2_chifre_ataque * 1.1
                    axie2_chifre_escudo = axie2_chifre_defesa * 1.1
                Else
                    axie2_chifre_dano += axie2_chifre_ataque
                    axie2_chifre_escudo += axie2_chifre_defesa
                End If
                axie2_dano.Text += axie2_chifre_dano
                axie2_defesa.Text += axie2_chifre_escudo
                axie2_chifre.BackColor = Color.Lime
            Case 1
                axie2chifreuso += 1
                axie2_dano.Text += axie2_chifre_dano
                axie2_defesa.Text += axie2_chifre_escudo
                axie2_chifre.BackColor = Color.Red
            Case 2
                axie2chifreuso = 0
                axie2_dano.Text -= axie2_chifre_dano
                axie2_defesa.Text -= axie2_chifre_escudo
                axie2_dano.Text -= axie2_chifre_dano
                axie2_defesa.Text -= axie2_chifre_escudo
                axie2_chifre_dano = 0
                axie2_chifre_escudo = 0
                axie2_chifre.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie2_costas_selectcase()
        Select Case axie2costasuso
            Case 0
                axie2costasuso += 1
                If axie2_costas_classe = varaxie2_classe Then
                    axie2_costas_dano = axie2_costas_ataque * 1.1
                    axie2_costas_escudo = axie2_costas_defesa * 1.1
                Else
                    axie2_costas_dano += axie2_costas_ataque
                    axie2_costas_escudo += axie2_costas_defesa
                End If
                axie2_dano.Text += axie2_costas_dano
                axie2_defesa.Text += axie2_costas_escudo
                axie2_costas.BackColor = Color.Lime
            Case 1
                axie2costasuso += 1
                axie2_dano.Text += axie2_costas_dano
                axie2_defesa.Text += axie2_costas_escudo
                axie2_costas.BackColor = Color.Red
            Case 2
                axie2costasuso = 0
                axie2_dano.Text -= axie2_costas_dano
                axie2_defesa.Text -= axie2_costas_escudo
                axie2_dano.Text -= axie2_costas_dano
                axie2_defesa.Text -= axie2_costas_escudo
                axie2_costas_dano = 0
                axie2_costas_escudo = 0
                axie2_costas.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie2_rabo_selectcase()
        Select Case axie2rabouso
            Case 0
                axie2rabouso += 1
                If axie2_rabo_classe = varaxie2_classe Then
                    axie2_rabo_dano = axie2_rabo_ataque * 1.1
                    axie2_rabo_escudo = axie2_rabo_defesa * 1.1
                Else
                    axie2_rabo_dano += axie2_rabo_ataque
                    axie2_rabo_escudo += axie2_rabo_defesa
                End If
                axie2_dano.Text += axie2_rabo_dano
                axie2_defesa.Text += axie2_rabo_escudo
                axie2_rabo.BackColor = Color.Lime
            Case 1
                axie2rabouso += 1
                axie2_dano.Text += axie2_rabo_dano
                axie2_defesa.Text += axie2_rabo_escudo
                axie2_rabo.BackColor = Color.Red
            Case 2
                axie2rabouso = 0
                axie2_dano.Text -= axie2_rabo_dano
                axie2_defesa.Text -= axie2_rabo_escudo
                axie2_dano.Text -= axie2_rabo_dano
                axie2_defesa.Text -= axie2_rabo_escudo
                axie2_rabo_dano = 0
                axie2_rabo_escudo = 0
                axie2_rabo.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Skill_Bonus_axie2()
        Dim comboativado_axie2, calculo_dano_axie2 As Integer
        calculo_dano_axie2 = axie2_dano.Text

        comboativado_axie2 = axie2bocauso + axie2chifreuso + axie2costasuso + axie2rabouso
        If comboativado_axie2 > 0 Then
            axie2_dano.Text = calculo_dano_axie2 * 1 + bonus_skill_axie2
        End If
    End Function
    '----------------------------------------------------------------------------------------- FUNÇÕES DE DANO DO axie3
    Private Function Dano_axie3_boca_selectcase()
        Select Case axie3bocauso
            Case 0
                axie3bocauso += 1
                If axie3_boca_classe = varaxie3_classe Then
                    axie3_boca_dano = axie3_boca_ataque * 1.1
                    axie3_boca_escudo = axie3_boca_defesa * 1.1
                Else
                    axie3_boca_dano += axie3_boca_ataque
                    axie3_boca_escudo += axie3_boca_defesa
                End If
                axie3_dano.Text += axie3_boca_dano
                axie3_defesa.Text += axie3_boca_escudo
                axie3_boca.BackColor = Color.Lime
            Case 1
                axie3bocauso += 1
                axie3_dano.Text += axie3_boca_dano
                axie3_defesa.Text += axie3_boca_escudo
                axie3_boca.BackColor = Color.Red
            Case 2
                axie3bocauso = 0
                axie3_dano.Text -= axie3_boca_dano
                axie3_defesa.Text -= axie3_boca_escudo
                axie3_dano.Text -= axie3_boca_dano
                axie3_defesa.Text -= axie3_boca_escudo
                axie3_boca_dano = 0
                axie3_boca_escudo = 0
                axie3_boca.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie3_chifre_selectcase()
        Select Case axie3chifreuso
            Case 0
                axie3chifreuso += 1
                If axie3_chifre_classe = varaxie3_classe Then
                    axie3_chifre_dano = axie3_chifre_ataque * 1.1
                    axie3_chifre_escudo = axie3_chifre_defesa * 1.1
                Else
                    axie3_chifre_dano += axie3_chifre_ataque
                    axie3_chifre_escudo += axie3_chifre_defesa
                End If
                axie3_dano.Text += axie3_chifre_dano
                axie3_defesa.Text += axie3_chifre_escudo
                axie3_chifre.BackColor = Color.Lime
            Case 1
                axie3chifreuso += 1
                axie3_dano.Text += axie3_chifre_dano
                axie3_defesa.Text += axie3_chifre_escudo
                axie3_chifre.BackColor = Color.Red
            Case 2
                axie3chifreuso = 0
                axie3_dano.Text -= axie3_chifre_dano
                axie3_defesa.Text -= axie3_chifre_escudo
                axie3_dano.Text -= axie3_chifre_dano
                axie3_defesa.Text -= axie3_chifre_escudo
                axie3_chifre_dano = 0
                axie3_chifre_escudo = 0
                axie3_chifre.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie3_costas_selectcase()
        Select Case axie3costasuso
            Case 0
                axie3costasuso += 1
                If axie3_costas_classe = varaxie3_classe Then
                    axie3_costas_dano = axie3_costas_ataque * 1.1
                    axie3_costas_escudo = axie3_costas_defesa * 1.1
                Else
                    axie3_costas_dano += axie3_costas_ataque
                    axie3_costas_escudo += axie3_costas_defesa
                End If
                axie3_dano.Text += axie3_costas_dano
                axie3_defesa.Text += axie3_costas_escudo
                axie3_costas.BackColor = Color.Lime
            Case 1
                axie3costasuso += 1
                axie3_dano.Text += axie3_costas_dano
                axie3_defesa.Text += axie3_costas_escudo
                axie3_costas.BackColor = Color.Red
            Case 2
                axie3costasuso = 0
                axie3_dano.Text -= axie3_costas_dano
                axie3_defesa.Text -= axie3_costas_escudo
                axie3_dano.Text -= axie3_costas_dano
                axie3_defesa.Text -= axie3_costas_escudo
                axie3_costas_dano = 0
                axie3_costas_escudo = 0
                axie3_costas.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie3_rabo_selectcase()
        Select Case axie3rabouso
            Case 0
                axie3rabouso += 1
                If axie3_rabo_classe = varaxie3_classe Then
                    axie3_rabo_dano = axie3_rabo_ataque * 1.1
                    axie3_rabo_escudo = axie3_rabo_defesa * 1.1
                Else
                    axie3_rabo_dano += axie3_rabo_ataque
                    axie3_rabo_escudo += axie3_rabo_defesa
                End If
                axie3_dano.Text += axie3_rabo_dano
                axie3_defesa.Text += axie3_rabo_escudo
                axie3_rabo.BackColor = Color.Lime
            Case 1
                axie3rabouso += 1
                axie3_dano.Text += axie3_rabo_dano
                axie3_defesa.Text += axie3_rabo_escudo
                axie3_rabo.BackColor = Color.Red
            Case 2
                axie3rabouso = 0
                axie3_dano.Text -= axie3_rabo_dano
                axie3_defesa.Text -= axie3_rabo_escudo
                axie3_dano.Text -= axie3_rabo_dano
                axie3_defesa.Text -= axie3_rabo_escudo
                axie3_rabo_dano = 0
                axie3_rabo_escudo = 0
                axie3_rabo.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Skill_Bonus_axie3()
        Dim comboativado_axie3, calculo_dano_axie3 As Integer
        calculo_dano_axie3 = axie3_dano.Text

        comboativado_axie3 = axie3bocauso + axie3chifreuso + axie3costasuso + axie3rabouso
        If comboativado_axie3 > 0 Then
            axie3_dano.Text = calculo_dano_axie3 * 1 + bonus_skill_axie3
        End If
    End Function
    '----------------------------------------------------------------------------------------- FUNÇÕES DE LIMPEZA
    Private Function limpartudo()
        'axie1
        axie1_boca_dano = 0
        axie1_boca_escudo = 0
        axie1_chifre_dano = 0
        axie1_chifre_escudo = 0
        axie1_costas_dano = 0
        axie1_costas_escudo = 0
        axie1_rabo_dano = 0
        axie1_rabo_escudo = 0
        axie1_dano.Text = 0
        axie1_defesa.Text = 0
        'axie2
        axie2_boca_dano = 0
        axie2_boca_escudo = 0
        axie2_chifre_dano = 0
        axie2_chifre_escudo = 0
        axie2_costas_dano = 0
        axie2_costas_escudo = 0
        axie2_rabo_dano = 0
        axie2_rabo_escudo = 0
        axie2_dano.Text = 0
        axie2_defesa.Text = 0
        'axie3
        axie3_boca_dano = 0
        axie3_boca_escudo = 0
        axie3_chifre_dano = 0
        axie3_chifre_escudo = 0
        axie3_costas_dano = 0
        axie3_costas_escudo = 0
        axie3_rabo_dano = 0
        axie3_rabo_escudo = 0
        axie3_dano.Text = 0
        axie3_defesa.Text = 0
        'botões axie1
        axie1_boca.BackColor = Color.White
        axie1_chifre.BackColor = Color.White
        axie1_costas.BackColor = Color.White
        axie1_rabo.BackColor = Color.White
        'botões axie2
        axie2_boca.BackColor = Color.White
        axie2_chifre.BackColor = Color.White
        axie2_costas.BackColor = Color.White
        axie2_rabo.BackColor = Color.White
        'botões axie3
        axie3_boca.BackColor = Color.White
        axie3_chifre.BackColor = Color.White
        axie3_costas.BackColor = Color.White
        axie3_rabo.BackColor = Color.White
        'reset dos contadores de uso dos botões

        'contadores do axie1
        axie1bocauso = 0
        axie1chifreuso = 0
        axie1costasuso = 0
        axie1rabouso = 0
        'contadores do axie2
        axie2bocauso = 0
        axie2chifreuso = 0
        axie2costasuso = 0
        axie2rabouso = 0
        'contadores do axie3
        axie3bocauso = 0
        axie3chifreuso = 0
        axie3costasuso = 0
        axie3rabouso = 0


    End Function
    '----------------------------------------------------------------------------------------- FUNÇÕES DOS BOTÕES AXIE 1
    Private Sub axie1_boca_Click(sender As Object, e As EventArgs) Handles axie1_boca.Click
        Dano_axie1_boca_selectcase()
        Skill_Bonus_Axie1()
    End Sub
    Private Sub axie1_chifre_Click(sender As Object, e As EventArgs) Handles axie1_chifre.Click
        Dano_axie1_chifre_selectcase()
        Skill_Bonus_Axie1()
    End Sub
    Private Sub axie1_rabo_Click(sender As Object, e As EventArgs) Handles axie1_rabo.Click
        Dano_axie1_rabo_selectcase()
        Skill_Bonus_Axie1()
    End Sub
    Private Sub axie1_costas_Click(sender As Object, e As EventArgs) Handles axie1_costas.Click
        Dano_axie1_costas_selectcase()
        Skill_Bonus_Axie1()
    End Sub
    '---------------------------------------------------------------------------------------- FUNÇÕES DOS BOTÕES AXIE2
    Private Sub axie2_boca_Click(sender As Object, e As EventArgs) Handles axie2_boca.Click
        Dano_axie2_boca_selectcase()
        Skill_Bonus_axie2()
    End Sub
    Private Sub axie2_chifre_Click(sender As Object, e As EventArgs) Handles axie2_chifre.Click
        Dano_axie2_chifre_selectcase()
        Skill_Bonus_axie2()
    End Sub
    Private Sub axie2_rabo_Click(sender As Object, e As EventArgs) Handles axie2_rabo.Click
        Dano_axie2_rabo_selectcase()
        Skill_Bonus_axie2()
    End Sub
    Private Sub axie2_costas_Click(sender As Object, e As EventArgs) Handles axie2_costas.Click
        Dano_axie2_costas_selectcase()
        Skill_Bonus_axie2()
    End Sub
    '---------------------------------------------------------------------------------------- FUNÇÕES DOS BOTÕES AXIE3
    Private Sub axie3_boca_Click(sender As Object, e As EventArgs) Handles axie3_boca.Click
        Dano_axie3_boca_selectcase()
        Skill_Bonus_axie3()
    End Sub
    Private Sub axie3_chifre_Click(sender As Object, e As EventArgs) Handles axie3_chifre.Click
        Dano_axie3_chifre_selectcase()
        Skill_Bonus_axie3()
    End Sub
    Private Sub axie3_rabo_Click(sender As Object, e As EventArgs) Handles axie3_rabo.Click
        Dano_axie3_rabo_selectcase()
        Skill_Bonus_axie3()
    End Sub
    Private Sub axie3_costas_Click(sender As Object, e As EventArgs) Handles axie3_costas.Click
        Dano_axie3_costas_selectcase()
        Skill_Bonus_axie3()
    End Sub


    Private Sub CalcDano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarNoBancoAxie1()
        ListarNoBancoAxie3()
        ListarNoBancoAxie2()

    End Sub


End Class