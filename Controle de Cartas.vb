﻿Public Class Controle_de_Cartas
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
    '-----------------Funções do AXIE1
    Private Function Dano_axie1_boca_selectcase()
        Select Case axie1bocauso
            Case 0
                axie1bocauso += 1
                axie1_boca.BackColor = Color.Lime
            Case 1
                axie1bocauso += 1
                axie1_boca.BackColor = Color.Red
            Case 2
                axie1bocauso = 0
                axie1_boca.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie1_chifre_selectcase()
        Select Case axie1chifreuso
            Case 0
                axie1chifreuso += 1
                axie1_chifre.BackColor = Color.Lime
            Case 1
                axie1chifreuso += 1
                axie1_chifre.BackColor = Color.Red
            Case 2
                axie1chifreuso = 0
                axie1_chifre.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie1_costas_selectcase()
        Select Case axie1costasuso
            Case 0
                axie1costasuso += 1
                axie1_costas.BackColor = Color.Lime
            Case 1
                axie1costasuso += 1
                axie1_costas.BackColor = Color.Red
            Case 2
                axie1costasuso = 0
                axie1_costas.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie1_rabo_selectcase()
        Select Case axie1rabouso
            Case 0
                axie1rabouso += 1
                axie1_rabo.BackColor = Color.Lime
            Case 1
                axie1rabouso += 1
                axie1_rabo.BackColor = Color.Red
            Case 2
                axie1rabouso = 0
                axie1_rabo.BackColor = Color.White
            Case Else
        End Select
    End Function
    '-----------------Funções do axie2
    Private Function Dano_axie2_boca_selectcase()
        Select Case axie2bocauso
            Case 0
                axie2bocauso += 1
                axie2_boca.BackColor = Color.Lime
            Case 1
                axie2bocauso += 1
                axie2_boca.BackColor = Color.Red
            Case 2
                axie2bocauso = 0
                axie2_boca.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie2_chifre_selectcase()
        Select Case axie2chifreuso
            Case 0
                axie2chifreuso += 1
                axie2_chifre.BackColor = Color.Lime
            Case 1
                axie2chifreuso += 1
                axie2_chifre.BackColor = Color.Red
            Case 2
                axie2chifreuso = 0
                axie2_chifre.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie2_costas_selectcase()
        Select Case axie2costasuso
            Case 0
                axie2costasuso += 1
                axie2_costas.BackColor = Color.Lime
            Case 1
                axie2costasuso += 1
                axie2_costas.BackColor = Color.Red
            Case 2
                axie2costasuso = 0
                axie2_costas.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie2_rabo_selectcase()
        Select Case axie2rabouso
            Case 0
                axie2rabouso += 1
                axie2_rabo.BackColor = Color.Lime
            Case 1
                axie2rabouso += 1
                axie2_rabo.BackColor = Color.Red
            Case 2
                axie2rabouso = 0
                axie2_rabo.BackColor = Color.White
            Case Else
        End Select
    End Function
    '-----------------Funções do axie3
    Private Function Dano_axie3_boca_selectcase()
        Select Case axie3bocauso
            Case 0
                axie3bocauso += 1
                axie3_boca.BackColor = Color.Lime
            Case 1
                axie3bocauso += 1
                axie3_boca.BackColor = Color.Red
            Case 2
                axie3bocauso = 0
                axie3_boca.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie3_chifre_selectcase()
        Select Case axie3chifreuso
            Case 0
                axie3chifreuso += 1
                axie3_chifre.BackColor = Color.Lime
            Case 1
                axie3chifreuso += 1
                axie3_chifre.BackColor = Color.Red
            Case 2
                axie3chifreuso = 0
                axie3_chifre.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie3_costas_selectcase()
        Select Case axie3costasuso
            Case 0
                axie3costasuso += 1
                axie3_costas.BackColor = Color.Lime
            Case 1
                axie3costasuso += 1
                axie3_costas.BackColor = Color.Red
            Case 2
                axie3costasuso = 0
                axie3_costas.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Function Dano_axie3_rabo_selectcase()
        Select Case axie3rabouso
            Case 0
                axie3rabouso += 1
                axie3_rabo.BackColor = Color.Lime
            Case 1
                axie3rabouso += 1
                axie3_rabo.BackColor = Color.Red
            Case 2
                axie3rabouso = 0
                axie3_rabo.BackColor = Color.White
            Case Else
        End Select
    End Function
    Private Sub Controle_de_Cartas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '----------------- Funções dos botões do AXIE1
    Private Sub axie1_costas_Click(sender As Object, e As EventArgs) Handles axie1_costas.Click
        Dano_axie1_costas_selectcase()

    End Sub

    Private Sub axie1_boca_Click(sender As Object, e As EventArgs) Handles axie1_boca.Click
        Dano_axie1_boca_selectcase()

    End Sub

    Private Sub axie1_chifre_Click(sender As Object, e As EventArgs) Handles axie1_chifre.Click
        Dano_axie1_chifre_selectcase()

    End Sub

    Private Sub axie1_rabo_Click(sender As Object, e As EventArgs) Handles axie1_rabo.Click
        Dano_axie1_rabo_selectcase()

    End Sub
    '----------------- Funções dos botões do axie2
    Private Sub axie2_costas_Click(sender As Object, e As EventArgs) Handles axie2_costas.Click
        Dano_axie2_costas_selectcase()

    End Sub

    Private Sub axie2_boca_Click(sender As Object, e As EventArgs) Handles axie2_boca.Click
        Dano_axie2_boca_selectcase()

    End Sub

    Private Sub axie2_chifre_Click(sender As Object, e As EventArgs) Handles axie2_chifre.Click
        Dano_axie2_chifre_selectcase()

    End Sub

    Private Sub axie2_rabo_Click(sender As Object, e As EventArgs) Handles axie2_rabo.Click
        Dano_axie2_rabo_selectcase()

    End Sub
    '----------------- Funções dos botões do axie3
    Private Sub axie3_costas_Click(sender As Object, e As EventArgs) Handles axie3_costas.Click
        Dano_axie3_costas_selectcase()

    End Sub

    Private Sub axie3_boca_Click(sender As Object, e As EventArgs) Handles axie3_boca.Click
        Dano_axie3_boca_selectcase()

    End Sub

    Private Sub axie3_chifre_Click(sender As Object, e As EventArgs) Handles axie3_chifre.Click
        Dano_axie3_chifre_selectcase()

    End Sub

    Private Sub axie3_rabo_Click(sender As Object, e As EventArgs) Handles axie3_rabo.Click
        Dano_axie3_rabo_selectcase()

    End Sub

    '------------------------ FUNÇÃO DE LIMPEZA
    Private Function limpartudo()

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
    '------------------------ Função de Trocar o BACKGROUND
    Private Sub TrocarBG_Click(sender As Object, e As EventArgs) Handles TrocarBG.Click
        Dim bgvar As String = BGBox.Text
        Select Case bgvar
            Case "Black"
                Me.BackgroundImage = My.Resources.Resources.backgroundblack_jpg
            Case "White"
                Me.BackgroundImage = My.Resources.Resources.backgroundwhite_jpg
        End Select
    End Sub

    Private Sub limpar_Click(sender As Object, e As EventArgs) Handles limpar.Click
        limpartudo()

    End Sub
End Class