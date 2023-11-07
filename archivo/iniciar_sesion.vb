Imports System.Data
Imports System.Data.OleDb
Imports System.Text
'Imports Clases.clsConeccion

Public Class iniciar_sesion

    Dim conex As New OleDb.OleDbConnection
    Dim coman As New OleDb.OleDbCommand
    Dim dr As OleDbDataReader
    Dim adap As New OleDb.OleDbDataAdapter

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            conex.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Documents and Settings\Javier\Mis documentos\Sistema IESS\Sistema de Control de Juicios\Base\BASE_IESS.mdb; Jet OLEDB:Database Password=; "
            conex.Open()
            'conectarse()

            coman.Connection = conex
            coman.CommandText = "Select * from Usuarios where USUARIO=  '" & Me.txtUsuario.Text & "' and CLAVE= '" & Me.txtContraseña.Text & "' "
            coman.CommandType = CommandType.Text

            dr = coman.ExecuteReader
            If dr.Read Then
                MessageBox.Show("Ud. ha iniciado sesion", Me.txtUsuario.Text)
                Form1.sts_mostrar.Text = "Usuario Conectado  :"
                Form1.sts_usuario.Text = Me.txtUsuario.Text
                If Me.txtUsuario.Text = "Supervisor" Then
                    Form1.Activar_Menu()
                Else
                    Form1.Activar_Menu_Otro()
                End If
                Form1.habilita_desconectar()
                Me.Close()
                dr.Close()
            Else
                MessageBox.Show("Usuario Incorrecto")
            End If
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conex.Close()
        End Try
        
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class