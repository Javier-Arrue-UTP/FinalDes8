

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

    Private Sub frmListaPositivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        'TODO: esta línea de código carga datos en la tabla 'FinalDes5DataSet.pacientes' Puede moverla o quitarla según sea necesario.
        Me.PacientesTableAdapter.Fill(Me.FinalDes5DataSet.pacientes)


    End Sub
End Class