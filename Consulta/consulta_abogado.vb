Public Class consulta_abogado

    Dim dataset2 As New DataSet
    Dim _id As String
    Dim _cedula As String
    Dim _nombre As String
    Dim _apellido As String
   
    Property Id()
        Get
            Return _id
        End Get
        Set(ByVal value)
            _id = value
        End Set
    End Property
    'Property Cedula()
    '    Get
    '        Return _cedula
    '    End Get
    '    Set(ByVal value)
    '        _cedula = value
    '    End Set
    'End Property
    Property Nombre()
        Get
            Return _nombre
        End Get
        Set(ByVal value)
            _nombre = value
        End Set
    End Property
    'Property Apellido()
    '    Get
    '        Return _apellido
    '    End Get
    '    Set(ByVal value)
    '        _apellido = value
    '    End Set
    'End Property
 

    'Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
    '    dataset2.Tables("doctor").DefaultView.RowFilter = "apellido like '%" & Me.TextBox1.Text & "%'"
    '    Me.DataGridView1.DataSource = dataset2.Tables("doctor").DefaultView

    'End Sub


    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        _id = DataGridView1.Item(0, e.RowIndex).Value
        _nombre = DataGridView1.Item(1, e.RowIndex).Value
        '_apellido = DataGridView1.Item(3, e.RowIndex).Value
        Me.Close()
    End Sub

    Private Sub consulta_abogado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lec As New Clases.btnBusca_abogado
        lec.cargar_grid(Me.DataGridView1, dataset2)
    End Sub
End Class