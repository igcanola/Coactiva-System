Imports System.Data
Imports System.Data.OleDb
Imports System.Text

Public Class ing_juicio_coactivo
    Dim cadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Documents and Settings\Javier\Mis documentos\Sistema IESS\Sistema de Control de Juicios\Base\BASE_IESS.mdb; Jet OLEDB:Database Password=; "
    Public id As Integer
    Public FECHA As String

    'Public Sub Prueba()
    '    Dim dr As OleDbDataReader
    '    Dim cadenaSQL = New StringBuilder
    '    Dim miConexion As New OleDbConnection(Me.cadenaConexion)
    '    miConexion.Open()

    '    cadenaSQL.Append("SELECT * FROM BD_JUICIOS_COACTIVAS_2 WHERE Id = 1")
    '    'cadenaSQL.Append("(id, descripcion) ")
    '    'cadenaSQL.Append("VALUES(@id, @descripcion) ")

    '    Dim dbCommand As New OleDbCommand
    '    dbCommand.Connection = miConexion
    '    dbCommand.CommandText = cadenaSQL.ToString

    '    dr = dbCommand.ExecuteReader
    '    If dr.Read Then
    '        MessageBox.Show("Si lo lee")
    '    End If
    '    'dbCommand.Parameters.Add(New OleDbParameter("@descripcion", "Desc"))

    '    'Para controlar un posible error 
    '    Try
    '        dbCommand.ExecuteNonQuery()
    '        MessageBox.Show("Se conecto")
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        'Return False
    '    End Try
    '    miConexion.Close() 'cerramos la conexion
    'End Sub

    Private Sub cbx_estado_cancelacion_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_estado_cancelacion.SelectedValueChanged
        If cbx_estado_cancelacion.Text = "Cancelado" Then
            lbl_fecha_cancelacion.Visible = True
            dtp_fecha_cancelacion.Visible = True
        Else
            lbl_fecha_cancelacion.Visible = False
            dtp_fecha_cancelacion.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As New consulta_abogado

        a.ShowDialog()
        txt_abogado.Text = a.Nombre
        id = a.id
    End Sub

    Private Sub ing_juicio_coactivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbx_estado_cancelacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_estado_cancelacion.SelectedIndexChanged
        If cbx_estado_cancelacion.Text = "Pendiente" Then
            FECHA = ""
        Else
            FECHA = dtp_fecha_cancelacion.Value = Date.Today.ToString
        End If
    End Sub

    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click

        Dim cmd As New OleDbCommand
        Dim conex As New OleDb.OleDbConnection
        conex.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Documents and Settings\Javier\Mis documentos\Sistema IESS\Sistema de Control de Juicios\Base\BASE_IESS.mdb; Jet OLEDB:Database Password=; "
        conex.Open()

        '(JUICIO_COACTIVA,TITULO_CREDITO,FECHA_EMISION, PATRONAL_RUC, RAZON_SOCIAL, VALOR_TITULO, FECHA_CANCELADO, ESTA_CANCELADO, VALOR_TOTAL,ABOGADO_ASIGNADO)
        Try
            With cmd
                .Connection = conex
                '.CommandText = "INSERT INTO TB_JUCIOS_COACTIVAS_2 VALUES (" & 1111111 & "," & txt_juicio.Text & "," & txt_titulo.Text & ",'" & dtp_fecha_emision.Text & "'," & txt_ruc_patronal.Text & ",'" & txt_razon_social.Text & "', " & txt_valor_titulo.Text & ", " & dtp_fecha_cancelacion.Text & ",'" & cbx_estado_cancelacion.Text & "', " & txt_valor_total.Text & ",'" & txt_abogado.Text & "')"
                .CommandText = "INSERT INTO TB_JUICIOS_COACTIVAS_2(JUICIO_COACTIVA,FECHA_EMISION_T_C,TITULO_CREDITO, PATRONAL_RUC, RAZON_SOCIAL,FECHA_CANCELADO, VALOR_TITULO,ESTA_CANCELADO, VALOR_TOTAL,ABOGADO_ASIGNADO,IDENTIFICADOR) VALUES('" & txt_juicio.Text & "','" & dtp_fecha_emision.Text & "','" & txt_titulo.Text & "','" & txt_ruc_patronal.Text & "','" & txt_razon_social.Text & "','" & FECHA & "'," & txt_valor_titulo.Text & " ,'" & cbx_estado_cancelacion.Text & "'," & txt_valor_total.Text & ",'" & txt_abogado.Text & "'," & id & ")"
                .CommandType = CommandType.Text
            End With
            cmd.ExecuteNonQuery()
            MessageBox.Show("Datos Grabados Correctamente")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


End Class