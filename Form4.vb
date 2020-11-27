Imports System.Data.SqlClient
Public Class frmListaPositivos
    Dim conexion As SqlConnection
    Dim comando As SqlCommand



    Private Sub frmListaPositivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=(local) ; database=finalDes5 ; integrated security = true")
        conexion.Open()

        Me.PacientesTableAdapter.Positivos(Me.FinalDes5DataSet.pacientes)
        lblTotal.Text = dgvPacientesPositivos.Rows.Count

        calcularTotalHombresPositivos()
        calcularTotalMujeresPositivos()
        'LIMPIO LOS TEXTBOX
        txtIdPaciente.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCedula.Text = ""
    End Sub

    Public Sub recargarFormulario()
        conexion = New SqlConnection("server=(local) ; database=finalDes5 ; integrated security = true")
        conexion.Open()

        Me.PacientesTableAdapter.Positivos(Me.FinalDes5DataSet.pacientes)
        lblTotal.Text = dgvPacientesPositivos.Rows.Count

        calcularTotalHombresPositivos()
        calcularTotalMujeresPositivos()
        'LIMPIO LOS TEXTBOX
        txtIdPaciente.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCedula.Text = ""
    End Sub

    Private Sub btnActualizarRecuperado_Click(sender As Object, e As EventArgs) Handles btnActualizarRecuperado.Click

        Dim opcion
        opcion = MsgBox("¿Deseas actualizar este cliente a recuperado?", vbYesNo + vbQuestion, "Actualizar paciente")
        If (opcion = DialogResult.Yes) Then
            Try
                actualizarPaciente(txtIdPaciente.Text)
                Me.PacientesTableAdapter.Positivos(Me.FinalDes5DataSet.pacientes)
                lblTotal.Text = dgvPacientesPositivos.Rows.Count

                calcularTotalHombresPositivos()
                calcularTotalMujeresPositivos()

                'LIMPIO LOS TEXTBOX
                txtIdPaciente.Text = ""
                txtNombre.Text = ""
                txtApellido.Text = ""
                txtCedula.Text = ""
            Catch ex As Exception
                MsgBox("Debe seleccionar un paciente de la lista", MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub actualizarPaciente(id As Integer)

        'Nueva conexion para ejecutar el procedimiento

        'Objeto comando.
        Dim command As SqlCommand = conexion.CreateCommand
        'TIpo de comando
        command.CommandType = CommandType.StoredProcedure
        'Nombre del procedimiento
        command.CommandText = "actualizarPacienteRecuperado"
        Dim params(0) As SqlParameter
        params(0) = New SqlParameter("@id_paciente", SqlDbType.VarChar)
        params(0).Value = id

        'Añadiendo parametros al comando
        command.Parameters.AddRange(params)

        'Abriendo conexion y ejecutando el comando(procedimiento almacenado)

        Dim ejecucion As Integer = command.ExecuteNonQuery()


    End Sub


    Private Sub calcularTotalHombresPositivos()
        Try
            Dim cadena2 = "totalHombresPositivos"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando
            lblTotalHombres.Text = comando.Parameters("@total").Value
            lblPorcentajeHombres.Text = CStr(Math.Round((CInt(lblTotalHombres.Text) / CInt(lblTotal.Text)) * 100)) + "%"

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

    End Sub

    Private Sub calcularTotalMujeresPositivos()
        Try
            Dim cadena2 = "totalMujeresPositivos"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando
            lblTotalMujeres.Text = comando.Parameters("@total").Value
            lblPorcentajeMujeres.Text = CStr(Math.Round((CInt(lblTotalMujeres.Text) / CInt(lblTotal.Text)) * 100)) + "%"

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

    End Sub

    Private Sub btnRetroceder_Click(sender As Object, e As EventArgs) Handles btnRetroceder.Click
        conexion.Close()
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnReportesAtencion_Click(sender As Object, e As EventArgs) Handles btnReportesAtencion.Click
        Me.Hide()
        frmReporte.Show()
    End Sub

    Private Sub btnRastreo_Click(sender As Object, e As EventArgs) Handles btnRastreo.Click
        If txtIdPaciente.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtCedula.Text = "" Then
            MsgBox("Escoja al paciente que desea hacerle el rastreo", MessageBoxIcon.Warning)

        Else
            frmReporte.txtIdPaciente.Text = txtIdPaciente.Text
            frmReporte.txtNombre.Text = txtNombre.Text
            frmReporte.txtApellido.Text = txtApellido.Text

            Dim rastreo = New frmRastreo

            Me.Hide()
            frmRastreo.Show()
        End If
    End Sub

    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.TextChanged
        'EL BUSCADOR FUNCIONA POR CEDULA
        PacientesBindingSource.Filter = "cedula LIKE '" + txtBuscador.Text + "%'"
    End Sub

End Class