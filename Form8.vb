
Imports System.Data.SqlClient
Public Class frmReporte
    Private Sub btnRetroceder_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmListaPositivos.Show()
    End Sub

    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PacientesTableAdapter.NoAtendidos(Me.FinalDes5DataSet.pacientes)
        Me.PacientesTableAdapter1.Atendidos(Me.FinalDes5DataSet1.pacientes)
    End Sub


    Private Sub btnActualizarAtendido_Click(sender As Object, e As EventArgs) Handles btnActualizarAtendido.Click
        Dim opcion
        opcion = MsgBox("¿Deseas actualizar este cliente a Atendido?", vbYesNo + vbQuestion, "Actualizar paciente")
        If (opcion = DialogResult.Yes) Then
            Try

                actualizarPaciente(txtIdPaciente.Text)

                Me.PacientesTableAdapter.NoAtendidos(Me.FinalDes5DataSet.pacientes)
                Me.PacientesTableAdapter1.Atendidos(Me.FinalDes5DataSet1.pacientes)

                txtIdPaciente.Text = ""
                txtNombre.Text = ""
                txtApellido.Text = ""
                txtCedula.Text = ""

            Catch ex As Exception
                MsgBox("Debes seleccionar un paciente de la lista", MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub actualizarPaciente(id As Integer)

        'Nueva conexion para ejecutar el procedimiento

        Dim conn = New SqlConnection("server=(local) ; database=finalDes5 ; integrated security = true")
        'Objeto comando.
        Dim command As SqlCommand = conn.CreateCommand
        'TIpo de comando
        command.CommandType = CommandType.StoredProcedure
        'Nombre del procedimiento
        command.CommandText = "actualizarPacienteAtendido"
        Dim params(0) As SqlParameter
        params(0) = New SqlParameter("@id_paciente", SqlDbType.VarChar)
        params(0).Value = id


        'Añadiendo parametros al comando
        command.Parameters.AddRange(params)

        'Abriendo conexion y ejecutando el comando(procedimiento almacenado)
        conn.Open()
        Dim ejecucion As Integer = command.ExecuteNonQuery()
        conn.Close()

    End Sub
End Class