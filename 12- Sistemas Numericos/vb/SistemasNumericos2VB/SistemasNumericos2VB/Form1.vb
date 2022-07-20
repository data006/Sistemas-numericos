Public Class frmSistemasNumericosVB

    Dim dec, rep, modulo As Integer
    Dim binario(69696), octal(69696), hex(69696), salida, hexa, salidaInt As String




    Private Sub btnTransformar_Click(sender As Object, e As EventArgs) Handles btnTransformar.Click

        If Not txtIn.Text = String.Empty Then

            rep = 0

            If radBinarioOut.Checked Then

                If radDecimal.Checked Then

                    decToBin(0)

                ElseIf radOctal.Checked Then

                    octToDec(1)
                    decToBin(1)

                ElseIf radHexa.Checked Then

                    hexToDec(1)
                    decToBin(1)

                End If

            ElseIf radHexaOut.Checked Then

                If radOctal.Checked Then
                    octToDec(1)
                    decToHex(1)

                ElseIf radBinario.Checked Then

                    binToDec(1)
                    decToHex(1)

                ElseIf radDecimal.Checked Then

                    decToHex(0)

                End If

            ElseIf radDecimalOut.Checked Then

                If radOctal.Checked Then

                    octToDec(0)

                ElseIf radBinario.Checked Then

                    binToDec(0)

                ElseIf radHexa.Checked Then

                    hexToDec(0)

                End If

            ElseIf radOctalOut.Checked Then

                If radDecimal.Checked Then

                    decToOct(0)

                ElseIf radBinario.Checked Then

                    binToDec(1)
                    decToOct(1)

                ElseIf radHexa.Checked Then

                    hexToDec(1)
                    decToOct(1)

                End If

            End If

        End If

        dec = 0
        salidaInt = 0
        salida = ""



    End Sub








    'Decimal a Binario
    Sub decToBin(ex As Integer)

        If ex = 0 Then
            dec = txtIn.Text
        End If


        While dec > 0
            modulo = dec Mod 2
            binario(rep) = modulo
            dec = dec \ 2
            salida &= binario(rep)
            rep += 1
        End While


        txtOut.Text = StrReverse(salida)
        Array.Clear(binario, 0, binario.Length)

    End Sub




    'Decimal a Hexadecimal
    Sub decToHex(ex As Integer)

        If ex = 0 Then
            dec = txtIn.Text
        End If



        While dec > 0
            modulo = dec Mod 16
            hex(rep) = modulo
            dec = dec \ 16
            Select Case hex(rep)
                Case 15
                    salida &= "F"
                Case 14
                    salida &= "E"
                Case 13
                    salida &= "D"
                Case 12
                    salida &= "C"
                Case 11
                    salida &= "B"
                Case 10
                    salida &= "A"
                Case Else
                    salida &= hex(rep)
            End Select
            rep += 1
        End While


        txtOut.Text = StrReverse(salida)

    End Sub





    'Decimal a Octal
    Sub decToOct(ex As Integer)

        If ex = 0 Then
            dec = txtIn.Text
        End If


        While dec > 0
            modulo = dec Mod 8
            octal(rep) = modulo
            dec = dec \ 8
            salida &= octal(rep)
            rep += 1
        End While


        txtOut.Text = StrReverse(salida)
        Array.Clear(octal, 0, octal.Length)

    End Sub









    'Hexadecimal a Decimal
    Sub hexToDec(ex As Integer)


        Dim largo As String = txtIn.Text.Length


        For Each j As Char In txtIn.Text
            Select Case j
                Case "F"
                    hexa = "15"
                Case "E"
                    hexa = "14"
                Case "D"
                    hexa = "13"
                Case "C"
                    hexa = "12"
                Case "B"
                    hexa = "11"
                Case "A"
                    hexa = "10"
                Case Else
                    hexa = j
            End Select
            salidaInt += Double.Parse(hexa) * Math.Pow(16, largo - 1)
            largo -= 1
            rep += 1
        Next




        If ex = 0 Then
            txtOut.Text = salidaInt
        ElseIf ex = 1 Then
            dec = salidaInt
            salidaInt = 0
        End If



    End Sub











    'Binario a Decimal
    Sub binToDec(ex As Integer)

        Dim largo = txtIn.Text.Length



        For Each j As Char In txtIn.Text
            salidaInt += Double.Parse(j) * Math.Pow(2, largo - 1)
            largo -= 1
            rep += 1
        Next



        If ex = 0 Then
            txtOut.Text = salidaInt
        ElseIf ex = 1 Then
            dec = salidaInt
            salidaInt = 0
        End If



    End Sub







    'Octal a Decimal
    Sub octToDec(ex As Integer)

        Dim largo = txtIn.Text.Length



        For Each j As Char In txtIn.Text
            salidaInt += Double.Parse(j) * Math.Pow(8, largo - 1)
            largo -= 1
            rep += 1
        Next




        If ex = 0 Then
            txtOut.Text = salidaInt
        ElseIf ex = 1 Then
            dec = salidaInt
            salidaInt = 0
        End If



    End Sub









    'Bloqueo de radiobotones
    Private Sub radBin_CheckedChanged(sender As Object, e As EventArgs) Handles radBinario.CheckedChanged

        If radBinario.Checked Then
            radBinarioOut.Enabled = False
            radBinarioOut.Checked = False
        ElseIf Not radBinario.Checked Then
            radBinarioOut.Enabled = True
            txtIn.Text = String.Empty
        End If

    End Sub





    Private Sub radOct_CheckedChanged(sender As Object, e As EventArgs) Handles radOctal.CheckedChanged

        If radOctal.Checked Then
            radOctalOut.Enabled = False
            radOctalOut.Checked = False
        ElseIf Not radOctal.Checked Then
            radOctalOut.Enabled = True
            txtIn.Text = String.Empty
        End If

    End Sub





    Private Sub radDecimal_CheckedChanged(sender As Object, e As EventArgs) Handles radDecimal.CheckedChanged

        If radDecimal.Checked Then
            radDecimalOut.Enabled = False
            radDecimalOut.Checked = False
        ElseIf Not radDecimal.Checked Then
            radDecimalOut.Enabled = True
            txtIn.Text = String.Empty
        End If

    End Sub






    Private Sub radHex_CheckedChanged(sender As Object, e As EventArgs) Handles radHexa.CheckedChanged

        If radHexa.Checked Then
            radHexaOut.Enabled = False
            radHexaOut.Checked = False
        ElseIf Not radHexa.Checked Then
            radHexaOut.Enabled = True
            txtIn.Text = String.Empty
        End If

    End Sub










    'Bloqueo de teclas segun el sistema seleccionado
    Private Sub txtEntrada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIn.KeyPress


        'Binario
        If radBinario.Checked Then

            e.Handled = Not e.KeyChar = "1" And Not e.KeyChar = "0" And Not Char.IsControl(e.KeyChar)



            'Decimal
        ElseIf radDecimal.Checked Then

            e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar)





            'Octal
        ElseIf radOctal.Checked Then

            e.Handled = Not e.KeyChar = "0" And Not e.KeyChar = "1" And Not e.KeyChar = "2" And Not e.KeyChar = "3" And Not e.KeyChar = "4" And Not e.KeyChar = "5" And Not e.KeyChar = "6" And Not e.KeyChar = "7" And Not Char.IsControl(e.KeyChar)







            'Hexadecimal
        ElseIf radHexa.Checked Then

            e.Handled = Not e.KeyChar = "0" And Not e.KeyChar = "1" And Not e.KeyChar = "2" And Not e.KeyChar = "3" And Not e.KeyChar = "4" And Not e.KeyChar = "5" And Not e.KeyChar = "6" And Not e.KeyChar = "7" And Not e.KeyChar = "8" And Not e.KeyChar = "9" And Not e.KeyChar = "A" And Not e.KeyChar = "B" And Not e.KeyChar = "C" And Not e.KeyChar = "D" And Not e.KeyChar = "E" And Not e.KeyChar = "F" And Not Char.IsControl(e.KeyChar)

        End If




    End Sub

End Class
