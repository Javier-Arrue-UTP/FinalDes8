Public Class frmRastreo
    Private Sub btnRetroceder_Click(sender As Object, e As EventArgs) Handles btnRetroceder.Click
        Me.Hide()
        frmListaPositivos.Show()
    End Sub
End Class