Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class frmRegistroPaciente
    Private Sub btnRetroceder1_Click(sender As Object, e As EventArgs) Handles btnRetroceder1.Click
        Me.Hide()
        frmMenu.Show()

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
        Dim id_equipo As String = 1

        'Nueva conexion para ejecutar el procedimiento
        Dim conn As New SqlConnection("Data Source=DESKTOP-UH7R3KP;Initial Catalog=finalDes5;Integrated Security=True")
        'Objeto comando.
        Dim command As SqlCommand = conn.CreateCommand
        'TIpo de comando
        command.CommandType = CommandType.StoredProcedure
        'Nombre del procedimiento
        command.CommandText = "insertarPaciente"
        'Creando parametros
        Dim params(9) As SqlParameter
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


        'Añadiendo parametros al comando
        command.Parameters.AddRange(params)
        'Abriendo conexion y ejecutando el comando(procedimiento almacenado)
        conn.Open()

        Dim ejecucion As Integer = command.ExecuteNonQuery()
        conn.Close()

        If (ejecucion = 1) Then
            MsgBox("Cliente registrado", MessageBoxIcon.Information)
        End If

        Dim emailMessage As New MailMessage()
        Try
            emailMessage.From = New MailAddress("armandoutp1@gmail.com")
            emailMessage.To.Add(correo)
            emailMessage.Subject = "Hisopado COVID - 19"
            emailMessage.Body = "Usted ha sido testeado para la prueba del virus covid-19. 
                                Se le enviara otro correo con los resultados una vez haya sido procesado.
                                No responder a este mensaje."
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("armandoutp1@gmail.com", "maldeamores1")
            SMTP.Send(emailMessage)
        Catch ex As Exception

        End Try

    End Sub


End Class