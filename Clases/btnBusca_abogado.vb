Public Class btnBusca_abogado

    Sub cargar_grid(ByVal grid As System.Windows.Forms.DataGridView, ByVal dset As DataSet)
        dset.Clear()
        Dim conex As New OleDb.OleDbConnection
        Dim coman As New OleDb.OleDbCommand
        Dim adap As New OleDb.OleDbDataAdapter
        Dim table As New DataTable


        conex.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Documents and Settings\Javier\Mis documentos\Sistema IESS\Sistema de Control de Juicios\Base\BASE_IESS.mdb; Jet OLEDB:Database Password=; "
        conex.Open()

        coman.Connection = conex
        coman.CommandText = "Select Id, Abogado from TB_ABOGADOS"
        coman.CommandType = CommandType.Text

        adap.SelectCommand = coman
        adap.Fill(dset, "TB_ABOGADOS")

        dset.Tables.Add(table)

        grid.DataSource = dset
        grid.DataMember = "TB_ABOGADOS"
        conex.Close()
    End Sub
End Class
