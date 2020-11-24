Imports System.Data.SqlClient

Public Class ConexionBD
    Dim conexion As New SqlConnection("Data Source=DESKTOP-UH7R3KP;Initial Catalog=pruebaBD;Integrated Security=True")

    Sub enlace()
        Try
            conexion.Open()

        Catch ex As Exception
        End Try
    End Sub

    Sub cerrar()
        conexion.Close()
    End Sub
End Class
