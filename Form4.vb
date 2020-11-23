Public Class frmListaPositivos
    Private Sub btnRetroceder_Click(sender As Object, e As EventArgs) Handles btnRetroceder.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub btnRastreo_Click(sender As Object, e As EventArgs) Handles btnRastreo.Click
        Me.Hide()
        frmRastreo.Show()
    End Sub

    Private Sub btnReportesAtencion_Click(sender As Object, e As EventArgs) Handles btnReportesAtencion.Click
        Me.Hide()
        frmReporte.Show()

    End Sub
End Class