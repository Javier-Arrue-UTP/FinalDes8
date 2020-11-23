Public Class frmMenu
    Private Sub btrRegistrar_Click(sender As Object, e As EventArgs) Handles btrRegistrar.Click
        Me.Hide()
        frmRegistroPaciente.Show()
    End Sub

    Private Sub btnListaEspera_Click(sender As Object, e As EventArgs) Handles btnListaEspera.Click
        Me.Hide()
        frmListaEspera.Show()
    End Sub

    Private Sub btnListaPositivos_Click(sender As Object, e As EventArgs) Handles btnListaPositivos.Click
        Me.Hide()
        frmListaPositivos.Show()
    End Sub

    Private Sub btnListaNegativos_Click(sender As Object, e As EventArgs) Handles btnListaNegativos.Click
        Me.Hide()
        frmListaNegativos.Show()
    End Sub

    Private Sub btnRastreo_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmRastreo.Show()
    End Sub

    Private Sub btnResumen_Click(sender As Object, e As EventArgs) Handles btnResumen.Click
        Me.Hide()
        frmResumen.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnListaRecuperados.Click
        Me.Hide()
        frmRecuperados.Show()
    End Sub
End Class
