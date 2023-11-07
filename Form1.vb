
Public Class Form1

    Private Sub newToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newToolStripMenuItem.Click
        Dim a As New iniciar_sesion
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub undoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles undoToolStripMenuItem.Click
        Dim a As New cambiar_clave
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub salirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub mantenimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mantenimientosToolStripMenuItem.Click
        Dim a As New ing_juicio_coactivo
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Consulta.Click
 
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub JuicioCoactivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JuicioCoactivoToolStripMenuItem.Click
        Dim a As New consulta_juicio
        a.MdiParent = Me
        a.Show()
    End Sub

    Sub habilita_desconectar()
        mniDesconectar.Enabled = True
    End Sub

    Sub Activar_Menu()
        Usuario.Enabled = True
        ingreso.Enabled = True
        Consulta.Enabled = True
    End Sub

    Sub Activar_Menu_Otro()
        Usuario.Enabled = True
        ingreso.Enabled = True
    End Sub

    Sub Desconecta_Menu()
        Usuario.Enabled = False
        ingreso.Enabled = False
        Consulta.Enabled = False
        sts_mostrar.Text = "Modo Desconectado"
        sts_usuario.Text = ""
    End Sub

    Private Sub openToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniDesconectar.Click
        Desconecta_Menu()
    End Sub
End Class
