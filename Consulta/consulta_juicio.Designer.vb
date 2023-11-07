<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consulta_juicio
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
        Me.rdbTitulo = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbAbogado = New System.Windows.Forms.RadioButton
        Me.rdbRazonSocial = New System.Windows.Forms.RadioButton
        Me.rdbNumeroJ = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.dgvMostrarGrid = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvMostrarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdbTitulo
        '
        Me.rdbTitulo.AutoSize = True
        Me.rdbTitulo.Location = New System.Drawing.Point(76, 20)
        Me.rdbTitulo.Name = "rdbTitulo"
        Me.rdbTitulo.Size = New System.Drawing.Size(87, 17)
        Me.rdbTitulo.TabIndex = 0
        Me.rdbTitulo.TabStop = True
        Me.rdbTitulo.Text = "Titulo Credito"
        Me.rdbTitulo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.rdbAbogado)
        Me.GroupBox1.Controls.Add(Me.rdbRazonSocial)
        Me.GroupBox1.Controls.Add(Me.rdbNumeroJ)
        Me.GroupBox1.Controls.Add(Me.rdbTitulo)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 45)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por"
        '
        'rdbAbogado
        '
        Me.rdbAbogado.AutoSize = True
        Me.rdbAbogado.Location = New System.Drawing.Point(651, 19)
        Me.rdbAbogado.Name = "rdbAbogado"
        Me.rdbAbogado.Size = New System.Drawing.Size(68, 17)
        Me.rdbAbogado.TabIndex = 3
        Me.rdbAbogado.TabStop = True
        Me.rdbAbogado.Text = "Abogado"
        Me.rdbAbogado.UseVisualStyleBackColor = True
        '
        'rdbRazonSocial
        '
        Me.rdbRazonSocial.AutoSize = True
        Me.rdbRazonSocial.Location = New System.Drawing.Point(449, 19)
        Me.rdbRazonSocial.Name = "rdbRazonSocial"
        Me.rdbRazonSocial.Size = New System.Drawing.Size(88, 17)
        Me.rdbRazonSocial.TabIndex = 2
        Me.rdbRazonSocial.TabStop = True
        Me.rdbRazonSocial.Text = "Razón Social"
        Me.rdbRazonSocial.UseVisualStyleBackColor = True
        '
        'rdbNumeroJ
        '
        Me.rdbNumeroJ.AutoSize = True
        Me.rdbNumeroJ.Location = New System.Drawing.Point(268, 20)
        Me.rdbNumeroJ.Name = "rdbNumeroJ"
        Me.rdbNumeroJ.Size = New System.Drawing.Size(92, 17)
        Me.rdbNumeroJ.TabIndex = 1
        Me.rdbNumeroJ.TabStop = True
        Me.rdbNumeroJ.Text = "Numero Juicio"
        Me.rdbNumeroJ.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.dgvMostrarGrid)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 275)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(270, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtBuscar.Location = New System.Drawing.Point(14, 19)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(250, 20)
        Me.txtBuscar.TabIndex = 1
        Me.txtBuscar.Text = "( Inserte texto a buscar )"
        '
        'dgvMostrarGrid
        '
        Me.dgvMostrarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMostrarGrid.Location = New System.Drawing.Point(14, 59)
        Me.dgvMostrarGrid.Name = "dgvMostrarGrid"
        Me.dgvMostrarGrid.Size = New System.Drawing.Size(751, 200)
        Me.dgvMostrarGrid.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(426, 355)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Reporte"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'consulta_juicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(794, 386)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "consulta_juicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Juicio de Coactiva"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvMostrarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdbTitulo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbRazonSocial As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNumeroJ As System.Windows.Forms.RadioButton
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgvMostrarGrid As System.Windows.Forms.DataGridView
    Friend WithEvents rdbAbogado As System.Windows.Forms.RadioButton
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
