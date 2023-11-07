Imports System.Data.OleDb
Public Module Conectar
    Dim conexion As OleDbConnection
    Dim cadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Documents and Settings\Javier\Mis documentos\Sistema IESS\Sistema de Control de Juicios\Base\BASE_IESS.mdb; Jet OLEDB:Database Password=; "

    Sub conectarse()
        Try
            conexion.ConnectionString = cadenaConexion
            conexion.Open()
            Console.WriteLine("conexion ok")
        Catch ex As Exception
            Console.Write("Error" & ex.Message)
        End Try
    End Sub
    Sub Desconectar()
        Try
            conexion.Close()
            Console.WriteLine("conexion ok")
        Catch ex As Exception
            Console.WriteLine("Error" & ex.Message)
        End Try
    End Sub
End Module