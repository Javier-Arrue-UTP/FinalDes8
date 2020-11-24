Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class frmListaEspera
    Private Sub btnRetroceder_Click(sender As Object, e As EventArgs) Handles btnRetroceder.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub frmListaEspera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FinalDes5DataSet.pacientes' Puede moverla o quitarla según sea necesario.
        Me.PacientesTableAdapter.FillBy1(Me.FinalDes5DataSet.pacientes)
        lbTotal.Text = DataGridView1.Rows.Count
        lbCantHombres.Text = cantidadHombresTesteados()
        lbCantMujeres.Text = cantidadMujeresTesteadas()
        lbPorcentajeHombres.Text = CStr(calcularPorcentaje(CStr(lbCantHombres.Text), CStr(lbTotal.Text))) + "%"
        lbPorcentajeMujeres.Text = CStr(calcularPorcentaje(CStr(lbCantMujeres.Text), CStr(lbTotal.Text))) + "%"

    End Sub

    Private Sub btnPositivo_Click(sender As Object, e As EventArgs) Handles btnPositivo.Click

        Dim opcion = MsgBox("Desea actualizar el estado del paciente a positivo", vbYesNo + vbQuestion, "Confirmación")
        If (opcion = DialogResult.Yes) Then
            enviarEmail("Usted es POSITIVO para Covid-19. En unos pocos días un equipo asignado estara visitando su casa para proveerle de insumos. ", txtCorreo.Text)

            actualizarPaciente("positivo", CInt(txtIdPaciente.Text))
            Me.PacientesTableAdapter.FillBy1(Me.FinalDes5DataSet.pacientes)
            lbTotal.Text = DataGridView1.Rows.Count

            lbCantHombres.Text = cantidadHombresTesteados()
            lbCantMujeres.Text = cantidadMujeresTesteadas()
            lbPorcentajeHombres.Text = CStr(calcularPorcentaje(CStr(lbCantHombres.Text), CStr(lbTotal.Text))) + "%"
            lbPorcentajeMujeres.Text = CStr(calcularPorcentaje(CStr(lbCantMujeres.Text), CStr(lbTotal.Text))) + "%"

        End If

    End Sub

    Private Sub btnNegativo_Click(sender As Object, e As EventArgs) Handles btnNegativo.Click

        Dim opcion = MsgBox("Desea actualizar el estado del paciente a negativo", vbYesNo + vbQuestion, "Confirmación")
        If (opcion = DialogResult.Yes) Then

            enviarEmail("Usted es NEGATIVO para Covid-19. Recuerde seguir cumpliendo con los consejos para combatir el virus Covid-19.", txtCorreo.Text)


            actualizarPaciente("negativo", CInt(txtIdPaciente.Text))
            Me.PacientesTableAdapter.FillBy1(Me.FinalDes5DataSet.pacientes)
            lbTotal.Text = DataGridView1.Rows.Count

            lbCantHombres.Text = cantidadHombresTesteados()
            lbCantMujeres.Text = cantidadMujeresTesteadas()
            lbPorcentajeHombres.Text = CStr(calcularPorcentaje(CStr(lbCantHombres.Text), CStr(lbTotal.Text))) + "%"
            lbPorcentajeMujeres.Text = CStr(calcularPorcentaje(CStr(lbCantMujeres.Text), CStr(lbTotal.Text))) + "%"

        End If

    End Sub


    Private Sub actualizarPaciente(estado As String, id As Integer)

        'Nueva conexion para ejecutar el procedimiento
        Dim conn As New SqlConnection("Data Source=DESKTOP-UH7R3KP;Initial Catalog=finalDes5;Integrated Security=True")
        'Objeto comando.
        Dim command As SqlCommand = conn.CreateCommand
        'TIpo de comando
        command.CommandType = CommandType.StoredProcedure
        'Nombre del procedimiento
        command.CommandText = "actualizarPaciente"
        Dim params(1) As SqlParameter
        params(0) = New SqlParameter("@id_paciente", SqlDbType.VarChar)
        params(0).Value = id

        params(1) = New SqlParameter("@estado", SqlDbType.VarChar)
        params(1).Value = estado

        'Añadiendo parametros al comando
        command.Parameters.AddRange(params)

        'Abriendo conexion y ejecutando el comando(procedimiento almacenado)
        conn.Open()
        Dim ejecucion As Integer = command.ExecuteNonQuery()
        conn.Close()

    End Sub


    Private Function cantidadHombresTesteados() As String
        Dim cantidad As String = ""

        'Nueva conexion para ejecutar el procedimiento
        Dim conn As New SqlConnection("Data Source=DESKTOP-UH7R3KP;Initial Catalog=finalDes5;Integrated Security=True")
        Dim cmdObj As New SqlCommand("select*from cant_hombres_testeados", conn)

        Try
            conn.Open()

            Dim readerObj As SqlDataReader = cmdObj.ExecuteReader

            While readerObj.Read
                cantidad = readerObj("cantidad").ToString
            End While

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return cantidad
    End Function

    Private Function cantidadMujeresTesteadas() As String
        Dim cantidad As String = ""

        'Nueva conexion para ejecutar el procedimiento
        Dim conn As New SqlConnection("Data Source=DESKTOP-UH7R3KP;Initial Catalog=finalDes5;Integrated Security=True")
        Dim cmdObj As New SqlCommand("select*from cant_mujeres_testeadas", conn)

        Try
            conn.Open()

            Dim readerObj As SqlDataReader = cmdObj.ExecuteReader

            While readerObj.Read
                cantidad = readerObj("cantidad").ToString
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Return cantidad

    End Function

    Private Function calcularPorcentaje(numero As Integer, total As Integer) As Double

        Return Math.Round((numero / total) * 100)

    End Function

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

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        PacientesBindingSource.Filter = "nombre LIKE '" + txtBusqueda.Text + "%'"

    End Sub
End Class