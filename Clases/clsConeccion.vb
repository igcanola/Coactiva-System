Imports System.Data.OleDb

Public Class clsConeccion
    Public conexion As New OleDbConnection
    Dim cadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Documents and Settings\Javier\Mis documentos\Sistema IESS\Sistema de Control de Juicios\Base\BASE_IESS.mdb; Jet OLEDB:Database Password=; "

    Public Sub conectarse()
        Try
            conexion.ConnectionString = cadenaConexion
            conexion.Open()
            Console.WriteLine("conexion ok")
        Catch ex As Exception
            Console.Write("Error" & ex.Message)
        End Try
    End Sub
End Class

