Imports System.Data.SqlClient
Public Class frmRecuperados

    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim dt As New DataTable
    Dim dt2 As New DataTable
    Dim adapter As SqlDataAdapter
    Dim cadena As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=(local) ; database=finalDes5 ; integrated security = true")
        Try
            conexion.Open()
            cargarDataGridView()
            calcularTotalRecuperados()
            calcularTotalHombes()
            calcularTotalMujeres()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos")
        End Try
    End Sub

    Private Sub calcularTotalRecuperados()
        Try
            Dim cadena2 = "pa_TotRecuperados"
            comando = New SqlCommand(cadena2, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery()
            lbTotRecuperados.Text = comando.Parameters("@total").Value

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

    End Sub

    Private Sub cargarDataGridView()
        Try
            'Cargar DataGridView
            Dim cadena As String = "select * from pacientes where estado = 'recuperado' "
            dt.Clear()
            comando = New SqlCommand(cadena, conexion)
            Using adapter As New SqlDataAdapter(comando)
                adapter.Fill(dt)
            End Using
            dgvRecuperados.DataSource = dt

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub calcularTotalHombes()
        Try
            Dim cadena2 = "pa_HombresRecuperados"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando
            lbCantHombres.Text = comando.Parameters("@total").Value
            lbPHombres.Text = CStr(Math.Round((CInt(lbCantHombres.Text) / CInt(lbTotRecuperados.Text)) * 100)) + "%"

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub calcularTotalMujeres()
        Try
            Dim cadena2 = "pa_MujeresRecuperadas"
            comando = New SqlCommand(cadena2, conexion) 'LLama al PA
            comando.CommandType = CommandType.StoredProcedure 'Ejecuta un PA
            'Parametro de salida para obtener los datos
            comando.Parameters.Add("@total", SqlDbType.Int)
            comando.Parameters(0).Direction = ParameterDirection.Output
            comando.ExecuteNonQuery() 'Ejecuta el comando
            lbCantMujeres.Text = comando.Parameters("@total").Value
            lbPMujeres.Text = CStr(Math.Round((CInt(lbCantMujeres.Text) / CInt(lbTotRecuperados.Text)) * 100)) + "%"

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub


    Private Sub btnBuscar1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            dt2.Clear()
            cadena = "pa_PromTot"
            comando = New SqlCommand(cadena, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@nombre", txtNom.Text)
            comando.Parameters.AddWithValue("@apellido", txtAp.Text)
            comando.ExecuteNonQuery()
            Using adapter As New SqlDataAdapter(comando)
                adapter.Fill(dt2)
            End Using
            dgvRecuperados.DataSource = dt2
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click_1(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dt2.Clear()
        cargarDataGridView()
        txtNom.Clear()
        txtAp.Clear()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frmMenu.Show()
        conexion.Close()
    End Sub
End Class