Public Class Notas

    Private Sub btnsalir_Click(sender As System.Object, e As System.EventArgs) Handles btnsalir.Click
        Me.Close()

    End Sub

    Private Sub LbHora_Click(sender As System.Object, e As System.EventArgs) Handles LbHora.Click

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        LbHora.Text = Date.Now.ToLongDateString


        If LbHora.Text = My.Settings.hora Then

            Me.TopMost = True

        End If

    End Sub
    Private Sub evento()



    End Sub

    Private Sub Notas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class