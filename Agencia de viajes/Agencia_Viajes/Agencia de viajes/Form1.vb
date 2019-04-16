' Autor: Cristian Andres Fajardo Morales
' Desarrollo de software 3 semestre

Public Class Form1
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Dim silla As String

        ' Se quita el caracter inicial si corresponde al menos, esto para que al buscar el control lo encuentre
        If TxbSilla.Text.Chars(0) = "-" Then
            silla = TxbSilla.Text.Substring(1)
        Else
            silla = TxbSilla.Text
        End If

        ' Se busca el control en la lista de controles
        Dim control = Me.Controls.Find("Pnl_" + silla.ToUpper(), True)
        ' Se restablece el valor del label de mensajes
        LblMensaje.Text = ""

        ' Si no encontro el control arroja el error
        If control.Length = 0 Then
            LblMensaje.Text = "No se encontro la silla solicitada"
        Else
            ' Válida que el texto tenga dos caracteres, si es asi pinta el panel correspondiente
            If TxbSilla.Text.Length = 2 Then
                If control.First().BackColor = Color.Red Then
                    ' Si el panel ya tenia el color rojo ya estaba seleccionado, arroja un mensaje de error
                    LblMensaje.Text = "La silla solicitada ya habia sido seleccionada"
                Else
                    ' Si el panel no tenia color lo pinta
                    control.First().BackColor = Color.Red
                End If
            Else
                ' Deja el panel sin color
                control.First().BackColor = Nothing
            End If
        End If

    End Sub
End Class
