Public Class busca_numero_juicio

    Sub cargar_grid(ByVal grid As System.Windows.Forms.DataGridView, ByVal dset As DataSet, ByVal buscar As String)
        dset.Clear()
        Dim conex As New OleDb.OleDbConnection
        Dim coman As New OleDb.OleDbCommand
        Dim adap As New OleDb.OleDbDataAdapter
        Dim table As New DataTable


        conex.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Documents and Settings\Javier\Mis documentos\Sistema IESS\Sistema de Control de Juicios\Base\BASE_IESS.mdb; Jet OLEDB:Database Password=; "
        conex.Open()

        coman.Connection = conex
        coman.CommandText = "Select * from TB_JUICIOS_COACTIVAS_2 where JUICIO_COACTIVA=  '" & buscar & "' "
        coman.CommandType = CommandType.Text

        adap.SelectCommand = coman
        adap.Fill(dset, "TB_JUICIOS_COACTIVAS_2")

        dset.Tables.Add(table)

        grid.DataSource = dset
        grid.DataMember = "TB_JUICIOS_COACTIVAS_2"

    End Sub
End Class
