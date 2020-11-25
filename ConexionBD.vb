Imports System.Data.SqlClient

Public Class ConexionBD
<<<<<<< HEAD
    Public conexion As New SqlConnection("Data Source=DESKTOP-UH7R3KP;Initial Catalog=finalDes5;Integrated Security=True")
=======
    Dim conexion As New SqlConnection("Data Source=RYL;Initial Catalog=finalDes5;Integrated Security=True")

>>>>>>> 25a4d8e5464e4ed60bc4daa08f88b94f1e8131b9
    Sub enlace()
        Try
            conexion.Open()

        Catch ex As Exception
        End Try
    End Sub

    Sub cerrar()
        conexion.Close()
    End Sub
<<<<<<< HEAD

=======
>>>>>>> 25a4d8e5464e4ed60bc4daa08f88b94f1e8131b9
End Class
