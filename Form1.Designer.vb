<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.menuStrip = New System.Windows.Forms.MenuStrip
        Me.Archivo = New System.Windows.Forms.ToolStripMenuItem
        Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mniDesconectar = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.salirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Usuario = New System.Windows.Forms.ToolStripMenuItem
        Me.undoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ingreso = New System.Windows.Forms.ToolStripMenuItem
        Me.mantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Consulta = New System.Windows.Forms.ToolStripMenuItem
        Me.JuicioCoactivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.sts_usuario = New System.Windows.Forms.ToolStripStatusLabel
        Me.sts_mostrar = New System.Windows.Forms.ToolStripStatusLabel
        Me.menuStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Archivo, Me.Usuario, Me.ingreso, Me.Consulta})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(671, 24)
        Me.menuStrip.TabIndex = 1
        Me.menuStrip.Text = "MenuStrip"
        '
        'Archivo
        '
        Me.Archivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.mniDesconectar, Me.toolStripSeparator3, Me.salirToolStripMenuItem})
        Me.Archivo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.Archivo.Name = "Archivo"
        Me.Archivo.Size = New System.Drawing.Size(55, 20)
        Me.Archivo.Text = "&Archivo"
        '
        'newToolStripMenuItem
        '
        Me.newToolStripMenuItem.Image = CType(resources.GetObject("newToolStripMenuItem.Image"), System.Drawing.Image)
        Me.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
        Me.newToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.newToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.newToolStripMenuItem.Tag = ""
        Me.newToolStripMenuItem.Text = "C&onectar"
        '
        'mniDesconectar
        '
        Me.mniDesconectar.Enabled = False
        Me.mniDesconectar.Image = CType(resources.GetObject("mniDesconectar.Image"), System.Drawing.Image)
        Me.mniDesconectar.ImageTransparentColor = System.Drawing.Color.Black
        Me.mniDesconectar.Name = "mniDesconectar"
        Me.mniDesconectar.Size = New System.Drawing.Size(169, 22)
        Me.mniDesconectar.Text = "Desconectar"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(166, 6)
        '
        'salirToolStripMenuItem
        '
        Me.salirToolStripMenuItem.Image = CType(resources.GetObject("salirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.salirToolStripMenuItem.Name = "salirToolStripMenuItem"
        Me.salirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.salirToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.salirToolStripMenuItem.Text = "&Salir"
        '
        'Usuario
        '
        Me.Usuario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.undoToolStripMenuItem})
        Me.Usuario.Enabled = False
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(55, 20)
        Me.Usuario.Text = "&Usuario"
        '
        'undoToolStripMenuItem
        '
        Me.undoToolStripMenuItem.Image = CType(resources.GetObject("undoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.undoToolStripMenuItem.Name = "undoToolStripMenuItem"
        Me.undoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.undoToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.undoToolStripMenuItem.Text = "Cambiar Contraseña"
        '
        'ingreso
        '
        Me.ingreso.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mantenimientosToolStripMenuItem})
        Me.ingreso.Enabled = False
        Me.ingreso.Name = "ingreso"
        Me.ingreso.Size = New System.Drawing.Size(56, 20)
        Me.ingreso.Text = "Ingreso"
        '
        'mantenimientosToolStripMenuItem
        '
        Me.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem"
        Me.mantenimientosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.mantenimientosToolStripMenuItem.Text = "Juicio Coactivo"
        '
        'Consulta
        '
        Me.Consulta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JuicioCoactivoToolStripMenuItem})
        Me.Consulta.Enabled = False
        Me.Consulta.Name = "Consulta"
        Me.Consulta.Size = New System.Drawing.Size(109, 20)
        Me.Consulta.Text = "Consulta/Reportes"
        '
        'JuicioCoactivoToolStripMenuItem
        '
        Me.JuicioCoactivoToolStripMenuItem.Name = "JuicioCoactivoToolStripMenuItem"
        Me.JuicioCoactivoToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.JuicioCoactivoToolStripMenuItem.Text = "Juicio Coactivo"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sts_usuario, Me.sts_mostrar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 403)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(671, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sts_usuario
        '
        Me.sts_usuario.Name = "sts_usuario"
        Me.sts_usuario.Size = New System.Drawing.Size(0, 17)
        '
        'sts_mostrar
        '
        Me.sts_mostrar.Name = "sts_mostrar"
        Me.sts_mostrar.Size = New System.Drawing.Size(120, 17)
        Me.sts_mostrar.Text = "Modo Desconectado   : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(671, 425)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.menuStrip)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Sistema de Control de Juicios Coactivos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Private WithEvents Archivo As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mniDesconectar As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents salirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents Usuario As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents undoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ingreso As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mantenimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JuicioCoactivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents sts_usuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sts_mostrar As System.Windows.Forms.ToolStripStatusLabel

End Class
