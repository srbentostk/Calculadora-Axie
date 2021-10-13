


Public Class Calculadora_axie
    Dim atkboca, roundnum, defboca, energiausada, energiaganha, valorenergia, atkchifre, defchifre, atkcostas, defcostas, atkcauda, defcauda, atkvalor, defvalor, health, speed, skill, morale, atkboca2, defboca2, atkchifre2, defchifre2, atkcostas2, defcostas2, atkcauda2, defcauda2, atkvalor2, defvalor2, atkboca3, defboca3, atkchifre3, defchifre3, atkcostas3, defcostas3, atkcauda3, defcauda3, atkvalor3, defvalor3 As Double

    Private Sub cauda3_classeigual_CheckedChanged(sender As Object, e As EventArgs) Handles cauda3_classeigual.CheckedChanged
        'aqui eu somo quando check dizendo que a classe da carta é igual à do axie
        atkcauda3 = cauda3_atk.Text
        defcauda3 = cauda3_def.Text
        If cauda3_classeigual.Checked = True Then
            atkcauda3 = atkcauda3 * (1.1)
            cauda3_atk.Text = atkcauda3
            defcauda3 = defcauda3 * (1.1)
            cauda3_def.Text = defcauda3
        Else
            atkcauda3 = atkcauda3 / (1.1)
            cauda3_atk.Text = atkcauda3
            defcauda3 = defcauda3 / (1.1)
            cauda3_def.Text = defcauda3
            'adicionar caso coloque banco de dados
        End If
    End Sub
    Private Sub cauda3_usei_CheckedChanged(sender As Object, e As EventArgs) Handles cauda3_usei.CheckedChanged
        'aqui eu somo o valor com o ATAQUE3 se check 1ª caixa da cauda3

        atkvalor3 = VALOR_ATAQUE3.Text
        atkcauda3 = cauda3_atk.Text
        defcauda3 = cauda3_def.Text
        defvalor3 = VALOR_DEFESA3.Text
        defcauda3 = cauda3_def.Text
        If cauda3_usei.Checked = True Then
            VALOR_ATAQUE3.Text = atkvalor3 + atkcauda3
            VALOR_DEFESA3.Text = defvalor3 + defcauda3
        Else
            VALOR_ATAQUE3.Text = atkvalor3 - atkcauda3
            VALOR_DEFESA3.Text = defvalor3 - defcauda3
        End If
    End Sub



    Private Sub cauda3_usei3_CheckedChanged(sender As Object, e As EventArgs) Handles cauda3_usei2.CheckedChanged
        'aqui eu somo o valor com o ATAQUE3 se check 3ª caixa da cauda3
        atkvalor3 = VALOR_ATAQUE3.Text
        atkcauda3 = cauda3_atk.Text
        defcauda3 = cauda3_def.Text
        defvalor3 = VALOR_DEFESA3.Text
        If cauda3_usei2.Checked = True Then
            VALOR_ATAQUE3.Text = atkvalor3 + atkcauda3
            VALOR_DEFESA3.Text = defvalor3 + defcauda3
        Else
            VALOR_ATAQUE3.Text = atkvalor3 - atkcauda3
            VALOR_DEFESA3.Text = defvalor3 - defcauda3
        End If
    End Sub
    Private Sub costas3_classeigual_CheckedChanged(sender As Object, e As EventArgs) Handles costas3_classeigual.CheckedChanged
        'aqui eu somo quando check dizendo que a classe da carta é igual à do axie
        atkcostas3 = costas3_atk.Text
        defcostas3 = costas3_def.Text
        If costas3_classeigual.Checked = True Then
            atkcostas3 = atkcostas3 * (1.1)
            costas3_atk.Text = atkcostas3
            defcostas3 = defcostas3 * (1.1)
            costas3_def.Text = defcostas3
        Else
            atkcostas3 = atkcostas3 / (1.1)
            costas3_atk.Text = atkcostas3
            defcostas3 = defcostas3 / (1.1)
            costas3_def.Text = defcostas3
            'adicionar caso coloque banco de dados
        End If
    End Sub

    Private Sub Boca3_atk_TextChanged(sender As Object, e As EventArgs) Handles boca3_atk.TextChanged

    End Sub

    Private Sub Reset_energias_Click(sender As Object, e As EventArgs) Handles reset_energias.Click
        energias.Text = 3
        round_count.Text = 1
    End Sub

    Private Sub Ganhou_energia_Click(sender As Object, e As EventArgs) Handles ganhou_energia.Click
        ganhar_energia()


    End Sub

    Private Function ganhar_energia()
        energiaganha = energia_ganha.Text
        energiausada = energia_usada.Text
        valorenergia = energias.Text
        energias.Text = valorenergia + energiaganha
        limpar_ganho_de_energia()
    End Function

    Private Sub Prox_round_Click(sender As Object, e As EventArgs) Handles prox_round.Click
        proximoround_energia()

    End Sub

    Private Function proximoround_energia()
        energiaganha = energia_ganha.Text
        energiausada = energia_usada.Text
        roundnum = round_count.Text
        round_count.Text = roundnum + 1
        valorenergia = energias.Text
        energias.Text = valorenergia + 2

    End Function

    Private Sub Calculadora_axie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Function limpar_ganho_de_energia()
        energia_ganha.Text = 0
    End Function
    Private Function limpar_uso_de_energia()
        energia_usada.Text = 0
    End Function
    Private Function usar_energia()
        energiaganha = energia_ganha.Text
        energiausada = energia_usada.Text
        valorenergia = energias.Text
        energias.Text = valorenergia - energiausada
        limpar_uso_de_energia()
    End Function
    Private Sub Usou_energia_Click(sender As Object, e As EventArgs) Handles usou_energia.Click
        usar_energia()


    End Sub

    Private Sub costas3_usei_CheckedChanged(sender As Object, e As EventArgs) Handles costas3_usei.CheckedChanged
        'aqui eu somo o valor com o ATAQUE3 se check 1ª caixa da costas3
        atkvalor3 = VALOR_ATAQUE3.Text
        atkcostas3 = costas3_atk.Text
        defcostas3 = costas3_def.Text
        defvalor3 = VALOR_DEFESA3.Text
        If costas3_usei.Checked = True Then
            VALOR_ATAQUE3.Text = atkvalor3 + atkcostas3
            VALOR_DEFESA3.Text = defvalor3 + defcostas3
        Else
            VALOR_ATAQUE3.Text = atkvalor3 - atkcostas3
            VALOR_DEFESA3.Text = defvalor3 - defcostas3
        End If
    End Sub

    Private Sub costas3_usei3_CheckedChanged(sender As Object, e As EventArgs) Handles costas3_usei2.CheckedChanged
        'aqui eu somo o valor com o ATAQUE3 se check 3ª caixa da costas3
        atkvalor3 = VALOR_ATAQUE3.Text
        atkcostas3 = costas3_atk.Text
        defcostas3 = costas3_def.Text
        defvalor3 = VALOR_DEFESA3.Text
        If costas3_usei2.Checked = True Then
            VALOR_ATAQUE3.Text = atkvalor3 + atkcostas3
            VALOR_DEFESA3.Text = defvalor3 + defcostas3
        Else
            VALOR_ATAQUE3.Text = atkvalor3 - atkcostas3
            VALOR_DEFESA3.Text = defvalor3 - defcostas3
        End If
    End Sub
    Private Sub chifre3_classeigual_CheckedChanged(sender As Object, e As EventArgs) Handles chifre3_classeigual.CheckedChanged
        'aqui eu somo quando check dizendo que a classe da carta é igual à do axie
        atkchifre3 = chifre3_atk.Text
        defchifre3 = chifre3_def.Text
        If chifre3_classeigual.Checked = True Then
            atkchifre3 = atkchifre3 * (1.1)
            chifre3_atk.Text = atkchifre3
            defchifre3 = defchifre3 * (1.1)
            chifre3_def.Text = defchifre3
        Else
            atkchifre3 = atkchifre3 / (1.1)
            chifre3_atk.Text = atkchifre3
            defchifre3 = defchifre3 / (1.1)
            chifre3_def.Text = defchifre3
            'adicionar caso coloque banco de dados
        End If
    End Sub
    Private Sub chifre3_usei_CheckedChanged(sender As Object, e As EventArgs) Handles chifre3_usei.CheckedChanged
        'aqui eu somo o valor com o ATAQUE3 se check 1ª caixa da chifre3
        atkvalor3 = VALOR_ATAQUE3.Text
        atkchifre3 = chifre3_atk.Text
        defchifre3 = chifre3_def.Text
        defvalor3 = VALOR_DEFESA3.Text
        If chifre3_usei.Checked = True Then
            VALOR_ATAQUE3.Text = atkvalor3 + atkchifre3
            VALOR_DEFESA3.Text = defvalor3 + defchifre3
        Else
            VALOR_ATAQUE3.Text = atkvalor3 - atkchifre3
            VALOR_DEFESA3.Text = defvalor3 - defchifre3
        End If
    End Sub

    Private Sub chifre3_usei3_CheckedChanged(sender As Object, e As EventArgs) Handles chifre3_usei2.CheckedChanged
        'aqui eu somo o valor com o ATAQUE3 se check 3ª caixa da chifre3
        atkvalor3 = VALOR_ATAQUE3.Text
        atkchifre3 = chifre3_atk.Text
        defchifre3 = chifre3_def.Text
        defvalor3 = VALOR_DEFESA3.Text
        If chifre3_usei2.Checked = True Then
            VALOR_ATAQUE3.Text = atkvalor3 + atkchifre3
            VALOR_DEFESA3.Text = defvalor3 + defchifre3
        Else
            VALOR_ATAQUE3.Text = atkvalor3 - atkchifre3
            VALOR_DEFESA3.Text = defvalor3 - defchifre3
        End If
    End Sub

    Private Sub boca3_classeigual_CheckedChanged(sender As Object, e As EventArgs) Handles boca3_classeigual.CheckedChanged
        'aqui eu somo quando check dizendo que a classe da carta é igual à do axie
        atkboca3 = boca3_atk.Text
        defboca3 = boca3_def.Text
        defboca3 = boca3_def.Text
        defvalor3 = VALOR_DEFESA3.Text
        If boca3_classeigual.Checked = True Then
            atkboca3 = atkboca3 * (1.1)
            boca3_atk.Text = atkboca3
            defboca3 = defboca3 * (1.1)
            boca3_def.Text = defboca3
        Else
            atkboca3 = atkboca3 / (1.1)
            boca3_atk.Text = atkboca3
            defboca3 = defboca3 / (1.1)
            boca3_def.Text = defboca3
            'adicionar caso coloque banco de dados
        End If
    End Sub

    Private Sub boca3_usei_CheckedChanged(sender As Object, e As EventArgs) Handles boca3_usei.CheckedChanged
        'aqui eu somo o valor com o ATAQUE3 se check 1ª caixa da boca3
        atkvalor3 = VALOR_ATAQUE3.Text
        atkboca3 = boca3_atk.Text
        defboca3 = boca3_def.Text
        defvalor3 = VALOR_DEFESA3.Text
        If boca3_usei.Checked = True Then
            VALOR_ATAQUE3.Text = atkvalor3 + atkboca3
            VALOR_DEFESA3.Text = defvalor3 + defboca3
        Else
            VALOR_ATAQUE3.Text = atkvalor3 - atkboca3
            VALOR_DEFESA3.Text = defvalor3 - defboca3
        End If
    End Sub

    Private Sub boca3_usei3_CheckedChanged(sender As Object, e As EventArgs) Handles boca3_usei2.CheckedChanged
        'aqui eu somo o valor com o ATAQUE3 se check 3ª caixa da boca3
        atkvalor3 = VALOR_ATAQUE3.Text
        atkboca3 = boca3_atk.Text
        defboca3 = boca3_def.Text
        defvalor3 = VALOR_DEFESA3.Text
        If boca3_usei2.Checked = True Then
            VALOR_ATAQUE3.Text = atkvalor3 + atkboca3
            VALOR_DEFESA3.Text = defvalor3 + defboca3
        Else
            VALOR_ATAQUE3.Text = atkvalor3 - atkboca3
            VALOR_DEFESA3.Text = defvalor3 - defboca3
        End If
    End Sub

    Private Sub cauda2_classeigual_CheckedChanged(sender As Object, e As EventArgs) Handles cauda2_classeigual.CheckedChanged
        'aqui eu somo quando check dizendo que a classe da carta é igual à do axie
        atkcauda2 = cauda2_atk.Text
        defcauda2 = cauda2_def.Text
        defcauda2 = cauda2_def.Text
        defvalor2 = VALOR_DEFESA2.Text
        If cauda2_classeigual.Checked = True Then
            atkcauda2 = atkcauda2 * (1.1)
            cauda2_atk.Text = atkcauda2
            defcauda2 = defcauda2 * (1.1)
            cauda2_def.Text = defcauda2
        Else
            atkcauda2 = atkcauda2 / (1.1)
            cauda2_atk.Text = atkcauda2
            defcauda2 = defcauda2 / (1.1)
            cauda2_def.Text = defcauda2
            'adicionar caso coloque banco de dados
        End If
    End Sub
    Private Sub cauda2_usei_CheckedChanged(sender As Object, e As EventArgs) Handles cauda2_usei.CheckedChanged
        'aqui eu somo o valor com o ATAQUE2 se check 1ª caixa da cauda2
        atkvalor2 = VALOR_ATAQUE2.Text
        atkcauda2 = cauda2_atk.Text
        defcauda2 = cauda2_def.Text
        defvalor2 = VALOR_DEFESA2.Text
        'defcauda2 = cauda2_def.Text
        If cauda2_usei.Checked = True Then
            VALOR_ATAQUE2.Text = atkvalor2 + atkcauda2
            VALOR_DEFESA2.Text = defvalor2 + defcauda2
        Else
            VALOR_ATAQUE2.Text = atkvalor2 - atkcauda2
            VALOR_DEFESA2.Text = defvalor2 - defcauda2
        End If
    End Sub



    Private Sub cauda2_usei2_CheckedChanged(sender As Object, e As EventArgs) Handles cauda2_usei2.CheckedChanged
        'aqui eu somo o valor com o ATAQUE2 se check 2ª caixa da cauda2
        atkvalor2 = VALOR_ATAQUE2.Text
        atkcauda2 = cauda2_atk.Text
        defcauda2 = cauda2_def.Text
        defvalor2 = VALOR_DEFESA2.Text
        If cauda2_usei2.Checked = True Then
            VALOR_ATAQUE2.Text = atkvalor2 + atkcauda2
            VALOR_DEFESA2.Text = defvalor2 + defcauda2
        Else
            VALOR_ATAQUE2.Text = atkvalor2 - atkcauda2
            VALOR_DEFESA2.Text = defvalor2 - defcauda2
        End If
    End Sub
    Private Sub costas2_classeigual_CheckedChanged(sender As Object, e As EventArgs) Handles costas2_classeigual.CheckedChanged
        'aqui eu somo quando check dizendo que a classe da carta é igual à do axie
        atkcostas2 = costas2_atk.Text
        defcostas2 = costas2_def.Text
        If costas2_classeigual.Checked = True Then
            atkcostas2 = atkcostas2 * (1.1)
            costas2_atk.Text = atkcostas2
            defcostas2 = defcostas2 * (1.1)
            costas2_def.Text = defcostas2
        Else
            atkcostas2 = atkcostas2 / (1.1)
            costas2_atk.Text = atkcostas2
            defcostas2 = defcostas2 / (1.1)
            costas2_def.Text = defcostas2
            'adicionar caso coloque banco de dados
        End If
    End Sub
    Private Sub costas2_usei_CheckedChanged(sender As Object, e As EventArgs) Handles costas2_usei.CheckedChanged
        'aqui eu somo o valor com o ATAQUE2 se check 1ª caixa da costas2
        atkvalor2 = VALOR_ATAQUE2.Text
        atkcostas2 = costas2_atk.Text
        defcostas2 = costas2_def.Text
        defvalor2 = VALOR_DEFESA2.Text
        If costas2_usei.Checked = True Then
            VALOR_ATAQUE2.Text = atkvalor2 + atkcostas2
            VALOR_DEFESA2.Text = defvalor2 + defcostas2
        Else
            VALOR_ATAQUE2.Text = atkvalor2 - atkcostas2
            VALOR_DEFESA2.Text = defvalor2 - defcostas2
        End If
    End Sub

    Private Sub costas2_usei2_CheckedChanged(sender As Object, e As EventArgs) Handles costas2_usei2.CheckedChanged
        'aqui eu somo o valor com o ATAQUE2 se check 2ª caixa da costas2
        atkvalor2 = VALOR_ATAQUE2.Text
        atkcostas2 = costas2_atk.Text
        defcostas2 = costas2_def.Text
        defvalor2 = VALOR_DEFESA2.Text
        If costas2_usei2.Checked = True Then
            VALOR_ATAQUE2.Text = atkvalor2 + atkcostas2
            VALOR_DEFESA2.Text = defvalor2 + defcostas2
        Else
            VALOR_ATAQUE2.Text = atkvalor2 - atkcostas2
            VALOR_DEFESA2.Text = defvalor2 - defcostas2
        End If
    End Sub
    Private Sub chifre2_classeigual_CheckedChanged(sender As Object, e As EventArgs) Handles chifre2_classeigual.CheckedChanged
        'aqui eu somo quando check dizendo que a classe da carta é igual à do axie
        atkchifre2 = chifre2_atk.Text
        defchifre2 = chifre2_def.Text
        If chifre2_classeigual.Checked = True Then
            atkchifre2 = atkchifre2 * (1.1)
            chifre2_atk.Text = atkchifre2
            defchifre2 = defchifre2 * (1.1)
            chifre2_def.Text = defchifre2
        Else
            atkchifre2 = atkchifre2 / (1.1)
            chifre2_atk.Text = atkchifre2
            defchifre2 = defchifre2 / (1.1)
            chifre2_def.Text = defchifre2
            'adicionar caso coloque banco de dados
        End If
    End Sub
    Private Sub chifre2_usei_CheckedChanged(sender As Object, e As EventArgs) Handles chifre2_usei.CheckedChanged
        'aqui eu somo o valor com o ATAQUE2 se check 1ª caixa da chifre2
        atkvalor2 = VALOR_ATAQUE2.Text
        atkchifre2 = chifre2_atk.Text
        defchifre2 = chifre2_def.Text
        defvalor2 = VALOR_DEFESA2.Text
        If chifre2_usei.Checked = True Then
            VALOR_ATAQUE2.Text = atkvalor2 + atkchifre2
            VALOR_DEFESA2.Text = defvalor2 + defchifre2
        Else
            VALOR_ATAQUE2.Text = atkvalor2 - atkchifre2
            VALOR_DEFESA2.Text = defvalor2 - defchifre2
        End If
    End Sub

    Private Sub chifre2_usei2_CheckedChanged(sender As Object, e As EventArgs) Handles chifre2_usei2.CheckedChanged
        'aqui eu somo o valor com o ATAQUE2 se check 2ª caixa da chifre2
        atkvalor2 = VALOR_ATAQUE2.Text
        atkchifre2 = chifre2_atk.Text
        defchifre2 = chifre2_def.Text
        defvalor2 = VALOR_DEFESA2.Text
        If chifre2_usei2.Checked = True Then
            VALOR_ATAQUE2.Text = atkvalor2 + atkchifre2
            VALOR_DEFESA2.Text = defvalor2 + defchifre2
        Else
            VALOR_ATAQUE2.Text = atkvalor2 - atkchifre2
            VALOR_DEFESA2.Text = defvalor2 - defchifre2
        End If
    End Sub

    Private Sub boca2_classeigual_CheckedChanged(sender As Object, e As EventArgs) Handles boca2_classeigual.CheckedChanged
        'aqui eu somo quando check dizendo que a classe da carta é igual à do axie
        atkboca2 = boca2_atk.Text
        defboca2 = boca2_def.Text
        If boca2_classeigual.Checked = True Then
            atkboca2 = atkboca2 * (1.1)
            boca2_atk.Text = atkboca2
            defboca2 = defboca2 * (1.1)
            boca2_def.Text = defboca2
        Else
            atkboca2 = atkboca2 / (1.1)
            boca2_atk.Text = atkboca2
            defboca2 = defboca2 / (1.1)
            boca2_def.Text = defboca2
            'adicionar caso coloque banco de dados
        End If
    End Sub

    Private Sub boca2_usei_CheckedChanged(sender As Object, e As EventArgs) Handles boca2_usei.CheckedChanged
        'aqui eu somo o valor com o ATAQUE2 se check 1ª caixa da boca2
        atkvalor2 = VALOR_ATAQUE2.Text
        atkboca2 = boca2_atk.Text
        defboca2 = boca2_def.Text
        defvalor2 = VALOR_DEFESA2.Text
        If boca2_usei.Checked = True Then
            VALOR_ATAQUE2.Text = atkvalor2 + atkboca2
            VALOR_DEFESA2.Text = defvalor2 + defboca2
        Else
            VALOR_ATAQUE2.Text = atkvalor2 - atkboca2
            VALOR_DEFESA2.Text = defvalor2 - defboca2
        End If
    End Sub

    Private Sub boca2_usei2_CheckedChanged(sender As Object, e As EventArgs) Handles boca2_usei2.CheckedChanged
        'aqui eu somo o valor com o ATAQUE2 se check 2ª caixa da boca2
        atkvalor2 = VALOR_ATAQUE2.Text
        atkboca2 = boca2_atk.Text
        defboca2 = boca2_def.Text
        defvalor2 = VALOR_DEFESA2.Text
        If boca2_usei2.Checked = True Then
            VALOR_ATAQUE2.Text = atkvalor2 + atkboca2
            VALOR_DEFESA2.Text = defvalor2 + defboca2
        Else
            VALOR_ATAQUE2.Text = atkvalor2 - atkboca2
            VALOR_DEFESA2.Text = defvalor2 - defboca2
        End If
    End Sub
    Private Sub cauda_classeigual_CheckedChanged(sender As Object, e As EventArgs) Handles cauda_classeigual.CheckedChanged
        'aqui eu somo quando check dizendo que a classe da carta é igual à do axie
        atkcauda = cauda_atk.Text
        defcauda = cauda_def.Text
        If cauda_classeigual.Checked = True Then
            atkcauda = atkcauda * (1.1)
            cauda_atk.Text = atkcauda
            defcauda = defcauda * (1.1)
            cauda_def.Text = defcauda
        Else
            atkcauda = atkcauda / (1.1)
            cauda_atk.Text = atkcauda
            defcauda = defcauda / (1.1)
            cauda_def.Text = defcauda
            'adicionar caso coloque banco de dados
        End If
    End Sub
    Private Sub cauda_usei_CheckedChanged(sender As Object, e As EventArgs) Handles cauda_usei.CheckedChanged
        'aqui eu somo o valor com o ataque se check 1ª caixa da cauda
        atkvalor = VALOR_ATAQUE.Text
        atkcauda = cauda_atk.Text
        defcauda = cauda_def.Text
        defvalor = VALOR_DEFESA.Text
        If cauda_usei.Checked = True Then
            VALOR_ATAQUE.Text = atkvalor + atkcauda
            VALOR_DEFESA.Text = defvalor + defcauda
        Else
            VALOR_ATAQUE.Text = atkvalor - atkcauda
            VALOR_DEFESA.Text = defvalor + defcauda
        End If
    End Sub

    Private Sub cauda_usei2_CheckedChanged(sender As Object, e As EventArgs) Handles cauda_usei2.CheckedChanged
        'aqui eu somo o valor com o ataque se check 2ª caixa da cauda
        atkvalor = VALOR_ATAQUE.Text
        atkcauda = cauda_atk.Text
        defcauda = cauda_def.Text
        defvalor = VALOR_DEFESA.Text
        If cauda_usei2.Checked = True Then
            VALOR_ATAQUE.Text = atkvalor + atkcauda
            VALOR_DEFESA.Text = defvalor + defcauda
        Else
            VALOR_ATAQUE.Text = atkvalor - atkcauda
            VALOR_DEFESA.Text = defvalor - defcauda
        End If
    End Sub
    Private Sub costas_classeigual_CheckedChanged(sender As Object, e As EventArgs) Handles costas_classeigual.CheckedChanged
        'aqui eu somo quando check dizendo que a classe da carta é igual à do axie
        atkcostas = costas_atk.Text
        defcostas = costas_def.Text
        If costas_classeigual.Checked = True Then
            atkcostas = atkcostas * (1.1)
            costas_atk.Text = atkcostas
            defcostas = defcostas * (1.1)
            costas_def.Text = defcostas
        Else
            atkcostas = atkcostas / (1.1)
            costas_atk.Text = atkcostas
            defcostas = defcostas / (1.1)
            costas_def.Text = defcostas
            'adicionar caso coloque banco de dados
        End If
    End Sub
    Private Sub costas_usei_CheckedChanged(sender As Object, e As EventArgs) Handles costas_usei.CheckedChanged
        'aqui eu somo o valor com o ataque se check 1ª caixa da costas
        atkvalor = VALOR_ATAQUE.Text
        atkcostas = costas_atk.Text
        defcostas = costas_def.Text
        defvalor = VALOR_DEFESA.Text
        If costas_usei.Checked = True Then
            VALOR_ATAQUE.Text = atkvalor + atkcostas
            VALOR_DEFESA.Text = defvalor + defcostas
        Else
            VALOR_ATAQUE.Text = atkvalor - atkcostas
            VALOR_DEFESA.Text = defvalor - defcostas
        End If
    End Sub

    Private Sub costas_usei2_CheckedChanged(sender As Object, e As EventArgs) Handles costas_usei2.CheckedChanged
        'aqui eu somo o valor com o ataque se check 2ª caixa da costas
        atkvalor = VALOR_ATAQUE.Text
        defcostas = costas_def.Text
        defvalor = VALOR_DEFESA.Text
        atkcostas = costas_atk.Text
        If costas_usei2.Checked = True Then
            VALOR_ATAQUE.Text = atkvalor + atkcostas
            VALOR_DEFESA.Text = defvalor + defcostas
        Else
            VALOR_ATAQUE.Text = atkvalor - atkcostas
            VALOR_DEFESA.Text = defvalor - defcostas
        End If
    End Sub
    Private Sub Chifre_classeigual_CheckedChanged(sender As Object, e As EventArgs) Handles chifre_classeigual.CheckedChanged
        'aqui eu somo quando check dizendo que a classe da carta é igual à do axie
        atkchifre = chifre_atk.Text
        defchifre = chifre_def.Text
        If chifre_classeigual.Checked = True Then
            atkchifre = atkchifre * (1.1)
            chifre_atk.Text = atkchifre
            defchifre = defchifre * (1.1)
            chifre_def.Text = defchifre
        Else
            atkchifre = atkchifre / (1.1)
            chifre_atk.Text = atkchifre
            defchifre = defchifre / (1.1)
            chifre_def.Text = defchifre
            'adicionar caso coloque banco de dados
        End If
    End Sub
    Private Sub chifre_usei_CheckedChanged(sender As Object, e As EventArgs) Handles chifre_usei.CheckedChanged
        'aqui eu somo o valor com o ataque se check 1ª caixa da chifre
        atkvalor = VALOR_ATAQUE.Text
        atkchifre = chifre_atk.Text
        defchifre = chifre_def.Text
        defvalor = VALOR_DEFESA.Text
        If chifre_usei.Checked = True Then
            VALOR_ATAQUE.Text = atkvalor + atkchifre
            VALOR_DEFESA.Text = defvalor + defchifre
        Else
            VALOR_ATAQUE.Text = atkvalor - atkchifre
            VALOR_DEFESA.Text = defvalor - defchifre
        End If
    End Sub

    Private Sub chifre_usei2_CheckedChanged(sender As Object, e As EventArgs) Handles chifre_usei2.CheckedChanged
        'aqui eu somo o valor com o ataque se check 2ª caixa da chifre
        atkvalor = VALOR_ATAQUE.Text
        atkchifre = chifre_atk.Text
        defchifre = chifre_def.Text
        defvalor = VALOR_DEFESA.Text
        If chifre_usei2.Checked = True Then
            VALOR_ATAQUE.Text = atkvalor + atkchifre
            VALOR_DEFESA.Text = defvalor + defchifre
        Else
            VALOR_ATAQUE.Text = atkvalor - atkchifre
            VALOR_DEFESA.Text = defvalor - defchifre
        End If
    End Sub

    Private Sub Boca_classeigual_CheckedChanged(sender As Object, e As EventArgs) Handles boca_classeigual.CheckedChanged
        'aqui eu somo quando check dizendo que a classe da carta é igual à do axie
        atkboca = boca_atk.Text
        defboca = boca_def.Text
        If boca_classeigual.Checked = True Then
            atkboca = atkboca * (1.1)
            boca_atk.Text = atkboca
            defboca = defboca * (1.1)
            boca_def.Text = defboca
        Else
            atkboca = atkboca / (1.1)
            boca_atk.Text = atkboca
            defboca = defboca / (1.1)
            boca_def.Text = defboca
            'adicionar caso coloque banco de dados
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Boca_usei_CheckedChanged(sender As Object, e As EventArgs) Handles boca_usei.CheckedChanged
        'aqui eu somo o valor com o ataque se check 1ª caixa da BOCA
        atkvalor = VALOR_ATAQUE.Text
        atkboca = boca_atk.Text
        defboca = boca_def.Text
        defvalor = VALOR_DEFESA.Text
        If boca_usei.Checked = True Then
            VALOR_ATAQUE.Text = atkvalor + atkboca
            VALOR_DEFESA.Text = defvalor + defboca
        Else
            VALOR_ATAQUE.Text = atkvalor - atkboca
            VALOR_DEFESA.Text = defvalor - defboca
        End If
    End Sub

    Private Sub boca_usei2_CheckedChanged(sender As Object, e As EventArgs) Handles boca_usei2.CheckedChanged
        'aqui eu somo o valor com o ataque se check 2ª caixa da BOCA
        atkvalor = VALOR_ATAQUE.Text
        atkboca = boca_atk.Text
        defboca = boca_def.Text
        defvalor = VALOR_DEFESA.Text
        If boca_usei2.Checked = True Then
            VALOR_ATAQUE.Text = atkvalor + atkboca
            VALOR_DEFESA.Text = defvalor + defboca
        Else
            VALOR_ATAQUE.Text = atkvalor - atkboca
            VALOR_DEFESA.Text = defvalor - defboca
        End If
    End Sub
End Class
