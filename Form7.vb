Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class frmRastreo
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim dt As New DataTable

    Private Sub frmRastreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.EquiposTableAdapter.Fill(Me.FinalDes5DataSet.equipos)

        conexion = New SqlConnection("server=(local) ; database=finalDes5 ; integrated security = true")

        conexion.Open()
        cbCorregimiento.DisplayMember = "corregimiento"
        cbCorregimiento.ValueMember = "id_equipo"
        cargarDataGridViewRastreo()
        txtIdPaciente.Text = frmListaPositivos.txtIdPaciente.Text

        conexion.Close()

        lblNombreCompleto.Text = frmListaPositivos.txtNombre.Text + " " + frmListaPositivos.txtApellido.Text
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCedula.Text = ""
        nudEdad.Value = 0
        txtUbicacion.Text = ""
        txtCelular.Text = ""
        txtCorreo.Text = ""
    End Sub

    Private Sub cargarDataGridViewRastreo()

        Try
            'Cargar DataGridView
            Dim cadena As String = "select id_paciente,nombre, apellido,cedula,edad, genero, ubicacion,celular,correo,estado from pacientes where id_rastreo =" + frmListaPositivos.txtIdPaciente.Text
            dt.Clear()
            comando = New SqlCommand(cadena, conexion)
            Using adapter As New SqlDataAdapter(comando)
                adapter.Fill(dt)
            End Using
            dgvRastreo.DataSource = dt
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

    End Sub


    Private Sub btnRetroceder_Click(sender As Object, e As EventArgs) Handles btnRetroceder.Click
        Me.Close()
        frmListaPositivos.recargarFormulario()
        frmListaPositivos.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim cedula As String = txtCedula.Text
        Dim edad As Integer = nudEdad.Value
        Dim genero As String = If(radMasculino.Checked, "Masculino", "Femenino")
        Dim ubicacion As String = txtUbicacion.Text
        Dim celular As String = txtCelular.Text
        Dim correo As String = txtCorreo.Text
        Dim estado As String = "pendiente"
        Dim id_equipo As String = cbCorregimiento.SelectedValue.ToString
        Dim id_rastreo As Integer = frmListaPositivos.txtIdPaciente.Text

        If (nombre = "" Or apellido = "" Or cedula = "" Or edad = 0 Or ubicacion = "" Or celular = "" Or correo = "") Then
            MsgBox("Todos los campos son obligatorios", MessageBoxIcon.Warning)
        Else

            'Nueva conexion para ejecutar el procedimiento
            Dim conn As New SqlConnection("server=(local) ; database=finalDes5 ; integrated security = true")

            'Objeto comando.
            Dim command As SqlCommand = conn.CreateCommand
            'TIpo de comando
            command.CommandType = CommandType.StoredProcedure
            'Nombre del procedimiento
            command.CommandText = "insertarPacienteRastreo"
            'Creando y cargando parametros
            Dim params(10) As SqlParameter
            params(0) = New SqlParameter("@nombre", SqlDbType.VarChar)
            params(0).Value = nombre

            params(1) = New SqlParameter("@apellido", SqlDbType.VarChar)
            params(1).Value = apellido

            params(2) = New SqlParameter("@cedula", SqlDbType.VarChar)
            params(2).Value = cedula

            params(3) = New SqlParameter("@edad", SqlDbType.Int)
            params(3).Value = edad

            params(4) = New SqlParameter("@genero", SqlDbType.VarChar)
            params(4).Value = genero

            params(5) = New SqlParameter("@ubicacion", SqlDbType.VarChar)
            params(5).Value = ubicacion

            params(6) = New SqlParameter("@celular", SqlDbType.VarChar)
            params(6).Value = celular

            params(7) = New SqlParameter("@correo", SqlDbType.VarChar)
            params(7).Value = correo

            params(8) = New SqlParameter("@estado", SqlDbType.VarChar)
            params(8).Value = estado

            params(9) = New SqlParameter("@id_equipo", SqlDbType.Int)
            params(9).Value = id_equipo

            params(10) = New SqlParameter("@id_rastreo", SqlDbType.Int)
            params(10).Value = id_rastreo

            'Añadiendo parametros al comando
            command.Parameters.AddRange(params)

            'Abriendo conexion y ejecutando el comando(procedimiento almacenado)
            conn.Open()
            Dim ejecucion As Integer = command.ExecuteNonQuery()

            conn.Close()
            enviarEmail("Usted ha sido agregado en la lista de rastreo de covid-19 debido a que tuvo contacto con: " + lblNombreCompleto.Text, txtCorreo.Text)
            'Vaciando campos rellenados
            txtNombre.Text = ""
            txtApellido.Text = ""
            txtCedula.Text = ""
            nudEdad.Value = 0
            txtUbicacion.Text = ""
            txtCelular.Text = ""
            txtCorreo.Text = ""
            cargarDataGridViewRastreo()



        End If
    End Sub

    Private Sub btnPositivo_Click(sender As Object, e As EventArgs) Handles btnPositivo.Click

        If txtIdPacienteRastreo.Text = "" Or txtCorreoSeleccion.Text = "" Then
            MsgBox("Escoja al paciente que desea actualizar", MessageBoxIcon.Warning)
        Else
            Dim opcion = MsgBox("Desea actualizar el estado del paciente a positivo", vbYesNo + vbQuestion, "Confirmación")
            If (opcion = DialogResult.Yes) Then

                actualizarPaciente("positivo", CInt(txtIdPacienteRastreo.Text))
                enviarEmail("Usted es POSITIVO para Covid-19. En unos pocos días un equipo asignado estara visitando su casa para proveerle de insumos.", txtCorreoSeleccion.Text)
            End If
        End If


    End Sub

    Private Sub btnNegativo_Click(sender As Object, e As EventArgs) Handles btnNegativo.Click

        If txtIdPacienteRastreo.Text = "" Or txtCorreoSeleccion.Text = "" Then
            MsgBox("Escoja al paciente que desea actualizar", MessageBoxIcon.Warning)
        Else
            Dim opcion = MsgBox("Desea actualizar el estado del paciente a Negativo", vbYesNo + vbQuestion, "Confirmación")
            If (opcion = DialogResult.Yes) Then

                actualizarPaciente("negativo", CInt(txtIdPacienteRastreo.Text))
                enviarEmail("Usted es NEGATIVO para Covid-19. Recuerde seguir cumpliendo con los consejos para combatir el virus Covid-19.", txtCorreoSeleccion.Text)
            End If
        End If


    End Sub

    Private Sub actualizarPaciente(estado As String, id As Integer)

        'Nueva conexion para ejecutar el procedimiento
        Dim conn As New SqlConnection("server=(local) ; database=finalDes5 ; integrated security = true")
        'Objeto comando.
        Dim command As SqlCommand = conn.CreateCommand
        'TIpo de comando
        command.CommandType = CommandType.StoredProcedure
        'Nombre del procedimiento
        command.CommandText = "actualizarPacienteRastreo"
        Dim params(1) As SqlParameter
        params(0) = New SqlParameter("@id_paciente", SqlDbType.Int)
        params(0).Value = id

        params(1) = New SqlParameter("@estado", SqlDbType.VarChar)
        params(1).Value = estado

        'Añadiendo parametros al comando
        command.Parameters.AddRange(params)

        'Abriendo conexion y ejecutando el comando(procedimiento almacenado)
        conn.Open()
        Dim ejecucion As Integer = command.ExecuteNonQuery()
        cargarDataGridViewRastreo()
        conn.Close()

    End Sub

    Private Sub dgvRastreoClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRastreo.CellClick
        txtIdPacienteRastreo.Text = dgvRastreo.CurrentRow.Cells(0).Value.ToString()
        txtCorreoSeleccion.Text = dgvRastreo.CurrentRow.Cells(8).Value.ToString()
    End Sub


    Private Sub enviarEmail(mensaje As String, correo As String)

        'Enviar notificacion al email del paciente.
        Dim emailMessage As New MailMessage()
        Try
            emailMessage.From = New MailAddress("sistemaProyectoDes8@gmail.com")
            emailMessage.To.Add(correo)
            emailMessage.Subject = "Hisopado COVID - 19"
            emailMessage.Body = mensaje
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("sistemaProyectoDes8@gmail.com", "estoesunaprueba1")
            SMTP.Send(emailMessage)
        Catch ex As Exception

        End Try

    End Sub


End Class