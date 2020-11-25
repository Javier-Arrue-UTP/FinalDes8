Imports System.Data.SqlClient
Public Class frmResumen
    Dim conexion As SqlConnection
    Dim cadena As String

    Private Sub btnRetroceder_Click(sender As Object, e As EventArgs) Handles btnRetroceder.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub frmResumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion = New SqlConnection("server=(local) ; database=finalDes5 ; integrated security = true")

        Try
            conexion.Open()
            totalPendientes()
            totalTests()
            totalNegativos()
            totalPositivos()
            totalRecuperados()
            llenarListViewHombres()
            llenarListViewMujeres()

            conexion.Close()

        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos")
        End Try

    End Sub

    Private Sub totalPendientes()
        Dim comando As SqlCommand
        Try
            Dim cadena2 = "pa_PacientesPendientes"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando
            lbEspera.Text = comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub totalTests()
        Dim comando As SqlCommand
        Try
            Dim cadena2 = "pa_TotalTests"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando
            lbTotalTest.Text = comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub totalNegativos()
        Dim comando As SqlCommand
        Try
            Dim cadena2 = "pa_TotNegativo"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando
            lbTotalNegativos.Text = comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub totalPositivos()
        Dim comando As SqlCommand
        Try
            Dim cadena2 = "pa_TotPositivo"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando
            lbTotalPositivos.Text = comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub totalRecuperados()
        Dim comando As SqlCommand
        Try
            Dim cadena2 = "pa_TotRecuperados"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando
            lbTotalRecuperados.Text = comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub


    Private Sub llenarListViewHombres()

        lvHombres.Columns(0).Width = 70
        lvHombres.Columns(1).Width = 80
        lvHombres.Columns(2).Width = 80
        lvHombres.Columns(3).Width = 80

        Dim porcentajeNegativo As String
        Dim porcentajePositivo As String

        porcentajeNegativo = CStr(Math.Round((CInt(totalHombresNegativos()) / CInt(totalHombresTesteados())) * 100)) + "%"
        porcentajePositivo = CStr(Math.Round((CInt(totalHombresPositivos()) / CInt(totalHombresTesteados())) * 100)) + "%"
        Dim item As New ListViewItem(totalHombresTesteados())
        item.SubItems.Add(totalHombresPositivos() + " (" + porcentajePositivo + ")")
        item.SubItems.Add(totalHombresNegativos() + " (" + porcentajeNegativo + ")")
        item.SubItems.Add(totalHombresRecuperados)
        lvHombres.Items.Add(item)

    End Sub

    Private Function totalHombresTesteados() As String
        Dim comando As SqlCommand
        Try
            Dim cadena2 = "pa_TotHombres"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando

            Return comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        Return ""
    End Function

    Private Function totalHombresPositivos() As String
        Dim comando As SqlCommand
        Try
            Dim cadena2 = "pa_HombresPositivos"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando

            Return comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        Return ""
    End Function

    Private Function totalHombresNegativos() As String
        Dim comando As SqlCommand
        Try
            Dim cadena2 = "pa_HombresNegativos"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando

            Return comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        Return ""
    End Function

    Private Function totalHombresRecuperados() As String
        Dim comando As SqlCommand
        Try
            Dim cadena2 = "pa_HombresRecuperados"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando

            Return comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        Return ""
    End Function

    Private Sub llenarListViewMujeres()

        lvMujeres.Columns(0).Width = 70
        lvMujeres.Columns(1).Width = 80
        lvMujeres.Columns(2).Width = 80
        lvMujeres.Columns(3).Width = 80

        Dim porcentajeNegativo As String
        Dim porcentajePositivo As String

        porcentajeNegativo = CStr(Math.Round((CInt(totalMujeresNegativas()) / CInt(totalMujeresTesteadas())) * 100)) + "%"
        porcentajePositivo = CStr(Math.Round((CInt(totaMujeresPositivas()) / CInt(totalMujeresTesteadas())) * 100)) + "%"
        Dim item As New ListViewItem(totalMujeresTesteadas())
        item.SubItems.Add(totaMujeresPositivas() + " (" + porcentajePositivo + ")")
        item.SubItems.Add(totalMujeresNegativas() + " (" + porcentajeNegativo + ")")
        item.SubItems.Add(totalMujeresRecuperadas())
        lvMujeres.Items.Add(item)

    End Sub


    Private Function totalMujeresTesteadas() As String
        Dim comando As SqlCommand
        Try
            Dim cadena2 = "pa_TotMujeres"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando

            Return comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        Return ""
    End Function

    Private Function totaMujeresPositivas() As String
        Dim comando As SqlCommand
        Try
            Dim cadena2 = "pa_MujeresPositivas"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando

            Return comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        Return ""
    End Function

    Private Function totalMujeresNegativas() As String
        Dim comando As SqlCommand
        Try
            Dim cadena2 = "pa_MujeresNegativas"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando

            Return comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        Return ""
    End Function

    Private Function totalMujeresRecuperadas() As String
        Dim comando As SqlCommand
        Try
            Dim cadena2 = "pa_MujeresRecuperadas"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando

            Return comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        Return ""
    End Function

End Class