Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '-----Panel Menú Principal-----'
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        pnlRegistrar.Visible = True
        pnlEspera.Visible = False
    End Sub

    Private Sub btnListaEspera_Click(sender As Object, e As EventArgs) Handles btnListaEspera.Click
        pnlRegistrar.Visible = True
        pnlEspera.Visible = True
        pnlPositivo.Visible = False
    End Sub

    Private Sub btnListaPositivos_Click(sender As Object, e As EventArgs) Handles btnListaPositivos.Click
        pnlRegistrar.Visible = True
        pnlEspera.Visible = True
        pnlPositivo.Visible = True
        pnlPositivoRastreo.Visible = False
    End Sub

    Private Sub btnListaNegativos_Click(sender As Object, e As EventArgs) Handles btnListaNegativos.Click
        pnlRegistrar.Visible = True
        pnlEspera.Visible = True
        pnlPositivo.Visible = True
        pnlPositivoRastreo.Visible = True
        pnlPositivoAtendido.Visible = True
        pnlNegativos.Visible = True
        pnlRecuperados.Visible = False
    End Sub

    Private Sub btnRastreo_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmRastreo.Show()
    End Sub

    Private Sub btnListaRecuperados_Click(sender As Object, e As EventArgs) Handles btnListaRecuperados.Click
        pnlRegistrar.Visible = True
        pnlEspera.Visible = True
        pnlPositivo.Visible = True
        pnlPositivoRastreo.Visible = True
        pnlPositivoAtendido.Visible = True
        pnlNegativos.Visible = True
        pnlRecuperados.Visible = True
        pnlResumen.Visible = False
    End Sub

    Private Sub btnResumen_Click(sender As Object, e As EventArgs) Handles btnResumen.Click
        pnlRegistrar.Visible = True
        pnlEspera.Visible = True
        pnlPositivo.Visible = True
        pnlPositivoRastreo.Visible = True
        pnlPositivoAtendido.Visible = True
        pnlNegativos.Visible = True
        pnlRecuperados.Visible = True
        pnlResumen.Visible = True
        pnlSobreNosotros.Visible = False
    End Sub

    '-----Botones Superiores-----'
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        pnlRegistrar.Visible = True
        pnlEspera.Visible = True
        pnlPositivo.Visible = True
        pnlPositivoRastreo.Visible = True
        pnlPositivoAtendido.Visible = True
        pnlNegativos.Visible = True
        pnlRecuperados.Visible = True
        pnlResumen.Visible = True
        pnlSobreNosotros.Visible = True
        pnlInicio.Visible = True
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        pnlPrincipal.Visible = True
        pnlRegistrar.Visible = False
    End Sub

    Private Sub btnSobreNosotros_Click(sender As Object, e As EventArgs) Handles btnSobreNosotros.Click
        pnlRegistrar.Visible = True
        pnlEspera.Visible = True
        pnlPositivo.Visible = True
        pnlPositivoRastreo.Visible = True
        pnlPositivoAtendido.Visible = True
        pnlNegativos.Visible = True
        pnlRecuperados.Visible = True
        pnlResumen.Visible = True
        pnlSobreNosotros.Visible = True
        pnlInicio.Visible = False
    End Sub

    '-----Panel Registrar Paciente-----'
    Private Sub Registrar_btnRetroceder_Click(sender As Object, e As EventArgs) Handles Registrar_btnRetroceder.Click
        pnlPrincipal.Visible = True
        pnlRegistrar.Visible = False
    End Sub

    '-----Panel En Espera-----'
    Private Sub Espera_btnRetroceder_Click(sender As Object, e As EventArgs) Handles Espera_btnRetroceder.Click
        pnlPrincipal.Visible = True
        pnlRegistrar.Visible = False
    End Sub

    '-----Panel Pacientes Positivos----'
    Private Sub Positivos_btnRetroceder_Click(sender As Object, e As EventArgs) Handles Positivos_btnRetroceder.Click
        pnlPrincipal.Visible = True
        pnlRegistrar.Visible = False
    End Sub

    Private Sub btnIniciarRastreo_Click(sender As Object, e As EventArgs) Handles btnIniciarRastreo.Click
        pnlPositivoRastreo.Visible = True
        pnlPositivoAtendido.Visible = False
    End Sub

    Private Sub PositivoRastreo_btnRetroceder_Click(sender As Object, e As EventArgs) Handles PositivoRastreo_btnRetroceder.Click
        pnlPositivoRastreo.Visible = False
    End Sub

    Private Sub Positivos_btnReporte_Click(sender As Object, e As EventArgs) Handles Positivos_btnReporte.Click
        pnlPositivoRastreo.Visible = True
        pnlPositivoAtendido.Visible = True
        pnlNegativos.Visible = False
    End Sub

    Private Sub PositivosAtendidos_btnRetroceder_Click(sender As Object, e As EventArgs) Handles PositivosAtendidos_btnRetroceder.Click
        pnlPositivoAtendido.Visible = False
        pnlPositivoRastreo.Visible = False
    End Sub

    '-----Panel Pacientes Negativos----'
    Private Sub Negativos_btnRetroceder_Click(sender As Object, e As EventArgs) Handles Negativos_btnRetroceder.Click
        pnlPrincipal.Visible = True
        pnlRegistrar.Visible = False
    End Sub

    '-----Panel Pacientes Recuperados----'
    Private Sub Recuperados_btnRetroceder_Click(sender As Object, e As EventArgs) Handles Recuperados_btnRetroceder.Click
        pnlPrincipal.Visible = True
        pnlRegistrar.Visible = False
    End Sub

    '-----Panel Resumen Estadísticos----'
    Private Sub pnlResumen_btnRetroceder_Click(sender As Object, e As EventArgs) Handles pnlResumen_btnRetroceder.Click
        pnlPrincipal.Visible = True
        pnlRegistrar.Visible = False
    End Sub

    '-----Panel Sobre Nosotros----'
    Private Sub SobreNosotros_btnRetroceder_Click(sender As Object, e As EventArgs) Handles SobreNosotros_btnRetroceder.Click
        pnlPrincipal.Visible = True
        pnlRegistrar.Visible = False
    End Sub

    '-----Panel Inicio----'
    Private Sub Inicio_btnComienza_Click(sender As Object, e As EventArgs) Handles Inicio_btnComienza.Click
        pnlPrincipal.Visible = True
        pnlRegistrar.Visible = False
    End Sub

    '-----Botón para Salir----'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    '-----Botón para Minimizar----'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
