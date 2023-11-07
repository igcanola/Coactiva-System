Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Imports Clases.clsConeccion

Public Class consulta_juicio

    Dim dataset2 As New DataSet
    Dim _id As String
    Dim _juicio_coactiva As String
    Dim _fecha_emision_t_c As String
    Dim _patronal_ruc As String
    Dim _razon_social As String
    Dim _valor_titulo As String
    Dim _fecha_cancelado As String
    Dim _valor_total As String
    Dim _abogado As String

    Property Id()
        Get
            Return _id
        End Get
        Set(ByVal value)
            _id = value
        End Set
    End Property
    Property Jucio_Coactiva()
        Get
            Return _juicio_coactiva
        End Get
        Set(ByVal value)
            _juicio_coactiva = value
        End Set
    End Property
    Property Fecha_emision()
        Get
            Return _fecha_emision_t_c
        End Get
        Set(ByVal value)
            _fecha_emision_t_c = value
        End Set
    End Property
    Property Patronal_Ruc()
        Get
            Return _patronal_ruc
        End Get
        Set(ByVal value)
            _patronal_ruc = value
        End Set
    End Property
    Property Razon_social()
        Get
            Return _razon_social
        End Get
        Set(ByVal value)
            _razon_social = value
        End Set
    End Property
    Property Valor_titulo()
        Get
            Return _valor_titulo
        End Get
        Set(ByVal value)
            _valor_titulo = value
        End Set
    End Property

    Property Fecha_cancelado()
        Get
            Return _fecha_cancelado
        End Get
        Set(ByVal value)
            _fecha_cancelado = value
        End Set
    End Property

    Property Valor_total()
        Get
            Return _valor_total
        End Get
        Set(ByVal value)
            _valor_total = value
        End Set
    End Property

    Property Abogado()
        Get
            Return _abogado
        End Get
        Set(ByVal value)
            _abogado = value
        End Set
    End Property

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTitulo.CheckedChanged
        If rdbTitulo.Checked = True Then
            rdbAbogado.Checked = False
            rdbNumeroJ.Checked = False
            rdbRazonSocial.Checked = False
            txtBuscar.Focus()
            txtBuscar.Text = ""
        End If
        If rdbAbogado.Checked = True Then
            rdbTitulo.Checked = False
            rdbNumeroJ.Checked = False
            rdbRazonSocial.Checked = False
            txtBuscar.Focus()
            txtBuscar.Text = ""
        End If
        If rdbNumeroJ.Checked = True Then
            rdbTitulo.Checked = False
            rdbAbogado.Checked = False
            rdbRazonSocial.Checked = False
            txtBuscar.Focus()
            txtBuscar.Text = ""
        End If
        If rdbRazonSocial.Checked = True Then
            rdbTitulo.Checked = False
            rdbAbogado.Checked = False
            rdbNumeroJ.Checked = False
            txtBuscar.Focus()
            txtBuscar.Text = ""
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If rdbTitulo.Checked = True Then
            Dim lec As New Clases.busca_titulo
            lec.cargar_grid(Me.dgvMostrarGrid, dataset2, Me.txtBuscar.Text)
        End If
        If rdbAbogado.Checked = True Then
            Dim lec As New Clases.busca_abogado
            lec.cargar_grid(Me.dgvMostrarGrid, dataset2, Me.txtBuscar.Text)
        End If
        If rdbNumeroJ.Checked = True Then
            Dim lec As New Clases.busca_numero_juicio
            lec.cargar_grid(Me.dgvMostrarGrid, dataset2, Me.txtBuscar.Text)
        End If
        If rdbRazonSocial.Checked = True Then
            Dim lec As New Clases.busca_razon_social
            lec.cargar_grid(Me.dgvMostrarGrid, dataset2, Me.txtBuscar.Text)
        End If

    End Sub

    Private Sub dgvMostrarGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMostrarGrid.CellContentClick
        _id = dgvMostrarGrid.Item(0, e.RowIndex).Value
        _juicio_coactiva = dgvMostrarGrid.Item(1, e.RowIndex).Value
        _fecha_emision_t_c = dgvMostrarGrid.Item(2, e.RowIndex).Value
        _patronal_ruc = dgvMostrarGrid.Item(3, e.RowIndex).Value
        _razon_social = dgvMostrarGrid.Item(4, e.RowIndex).Value
        _valor_titulo = dgvMostrarGrid.Item(5, e.RowIndex).Value
        _fecha_cancelado = dgvMostrarGrid.Item(6, e.RowIndex).Value
        _valor_total = dgvMostrarGrid.Item(7, e.RowIndex).Value
        _abogado = dgvMostrarGrid.Item(8, e.RowIndex).Value
    End Sub

    'Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
    '    Dim dataset1 As New DataSet
    '    dataset1.Tables("BD_JUICIOS_COACTIVAS_2").DefaultView.RowFilter = "id where '%" & 1 & "%'"
    '    Me.dgvMostrarGrid.DataSource = dataset1.Tables("BD_JUICIOS_COACTIVAS_2").DefaultView
    'End Sub

End Class