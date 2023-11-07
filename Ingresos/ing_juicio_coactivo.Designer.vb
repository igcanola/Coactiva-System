<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ing_juicio_coactivo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.dtp_fecha_emision = New System.Windows.Forms.DateTimePicker
        Me.lbl_fecha_emision = New System.Windows.Forms.Label
        Me.txt_abogado = New System.Windows.Forms.TextBox
        Me.lbl_abogado = New System.Windows.Forms.Label
        Me.txt_juicio = New System.Windows.Forms.TextBox
        Me.lbl_juicio = New System.Windows.Forms.Label
        Me.txt_titulo = New System.Windows.Forms.TextBox
        Me.lbl_titulo = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_valor_total = New System.Windows.Forms.TextBox
        Me.lbl_valor_total = New System.Windows.Forms.Label
        Me.txt_valor_titulo = New System.Windows.Forms.TextBox
        Me.lbl_valor_titulo = New System.Windows.Forms.Label
        Me.txt_ruc_patronal = New System.Windows.Forms.TextBox
        Me.lbl_ruc_patronal = New System.Windows.Forms.Label
        Me.txt_razon_social = New System.Windows.Forms.TextBox
        Me.lbl_razon_social = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lbl_fecha_cancelacion = New System.Windows.Forms.Label
        Me.cbx_estado_cancelacion = New System.Windows.Forms.ComboBox
        Me.dtp_fecha_cancelacion = New System.Windows.Forms.DateTimePicker
        Me.lbl_estado_cancelacion = New System.Windows.Forms.Label
        Me.btn_ingresar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_emision)
        Me.GroupBox1.Controls.Add(Me.lbl_fecha_emision)
        Me.GroupBox1.Controls.Add(Me.txt_abogado)
        Me.GroupBox1.Controls.Add(Me.lbl_abogado)
        Me.GroupBox1.Controls.Add(Me.txt_juicio)
        Me.GroupBox1.Controls.Add(Me.lbl_juicio)
        Me.GroupBox1.Controls.Add(Me.txt_titulo)
        Me.GroupBox1.Controls.Add(Me.lbl_titulo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(365, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtp_fecha_emision
        '
        Me.dtp_fecha_emision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_emision.Location = New System.Drawing.Point(512, 46)
        Me.dtp_fecha_emision.Name = "dtp_fecha_emision"
        Me.dtp_fecha_emision.Size = New System.Drawing.Size(227, 20)
        Me.dtp_fecha_emision.TabIndex = 7
        '
        'lbl_fecha_emision
        '
        Me.lbl_fecha_emision.AutoSize = True
        Me.lbl_fecha_emision.Location = New System.Drawing.Point(416, 54)
        Me.lbl_fecha_emision.Name = "lbl_fecha_emision"
        Me.lbl_fecha_emision.Size = New System.Drawing.Size(82, 13)
        Me.lbl_fecha_emision.TabIndex = 6
        Me.lbl_fecha_emision.Text = "Fecha Emisión :"
        '
        'txt_abogado
        '
        Me.txt_abogado.Location = New System.Drawing.Point(105, 47)
        Me.txt_abogado.Name = "txt_abogado"
        Me.txt_abogado.Size = New System.Drawing.Size(244, 20)
        Me.txt_abogado.TabIndex = 5
        '
        'lbl_abogado
        '
        Me.lbl_abogado.AutoSize = True
        Me.lbl_abogado.Location = New System.Drawing.Point(9, 54)
        Me.lbl_abogado.Name = "lbl_abogado"
        Me.lbl_abogado.Size = New System.Drawing.Size(56, 13)
        Me.lbl_abogado.TabIndex = 4
        Me.lbl_abogado.Text = "Abogado :"
        '
        'txt_juicio
        '
        Me.txt_juicio.Location = New System.Drawing.Point(512, 15)
        Me.txt_juicio.Name = "txt_juicio"
        Me.txt_juicio.Size = New System.Drawing.Size(227, 20)
        Me.txt_juicio.TabIndex = 3
        '
        'lbl_juicio
        '
        Me.lbl_juicio.AutoSize = True
        Me.lbl_juicio.Location = New System.Drawing.Point(416, 22)
        Me.lbl_juicio.Name = "lbl_juicio"
        Me.lbl_juicio.Size = New System.Drawing.Size(95, 13)
        Me.lbl_juicio.TabIndex = 2
        Me.lbl_juicio.Text = "Número de Juicio :"
        '
        'txt_titulo
        '
        Me.txt_titulo.Location = New System.Drawing.Point(105, 19)
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(244, 20)
        Me.txt_titulo.TabIndex = 1
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Location = New System.Drawing.Point(9, 26)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(90, 13)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "Titulo de Credito :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_valor_total)
        Me.GroupBox2.Controls.Add(Me.lbl_valor_total)
        Me.GroupBox2.Controls.Add(Me.txt_valor_titulo)
        Me.GroupBox2.Controls.Add(Me.lbl_valor_titulo)
        Me.GroupBox2.Controls.Add(Me.txt_ruc_patronal)
        Me.GroupBox2.Controls.Add(Me.lbl_ruc_patronal)
        Me.GroupBox2.Controls.Add(Me.txt_razon_social)
        Me.GroupBox2.Controls.Add(Me.lbl_razon_social)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(745, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txt_valor_total
        '
        Me.txt_valor_total.Location = New System.Drawing.Point(108, 77)
        Me.txt_valor_total.Name = "txt_valor_total"
        Me.txt_valor_total.Size = New System.Drawing.Size(241, 20)
        Me.txt_valor_total.TabIndex = 13
        '
        'lbl_valor_total
        '
        Me.lbl_valor_total.AutoSize = True
        Me.lbl_valor_total.Location = New System.Drawing.Point(12, 84)
        Me.lbl_valor_total.Name = "lbl_valor_total"
        Me.lbl_valor_total.Size = New System.Drawing.Size(64, 13)
        Me.lbl_valor_total.TabIndex = 12
        Me.lbl_valor_total.Text = "Valor Total :"
        '
        'txt_valor_titulo
        '
        Me.txt_valor_titulo.Location = New System.Drawing.Point(108, 42)
        Me.txt_valor_titulo.Name = "txt_valor_titulo"
        Me.txt_valor_titulo.Size = New System.Drawing.Size(241, 20)
        Me.txt_valor_titulo.TabIndex = 11
        '
        'lbl_valor_titulo
        '
        Me.lbl_valor_titulo.AutoSize = True
        Me.lbl_valor_titulo.Location = New System.Drawing.Point(12, 49)
        Me.lbl_valor_titulo.Name = "lbl_valor_titulo"
        Me.lbl_valor_titulo.Size = New System.Drawing.Size(66, 13)
        Me.lbl_valor_titulo.TabIndex = 10
        Me.lbl_valor_titulo.Text = "Valor Titulo :"
        '
        'txt_ruc_patronal
        '
        Me.txt_ruc_patronal.Location = New System.Drawing.Point(512, 9)
        Me.txt_ruc_patronal.Name = "txt_ruc_patronal"
        Me.txt_ruc_patronal.Size = New System.Drawing.Size(227, 20)
        Me.txt_ruc_patronal.TabIndex = 9
        '
        'lbl_ruc_patronal
        '
        Me.lbl_ruc_patronal.AutoSize = True
        Me.lbl_ruc_patronal.Location = New System.Drawing.Point(416, 16)
        Me.lbl_ruc_patronal.Name = "lbl_ruc_patronal"
        Me.lbl_ruc_patronal.Size = New System.Drawing.Size(78, 13)
        Me.lbl_ruc_patronal.TabIndex = 8
        Me.lbl_ruc_patronal.Text = "RUC Patronal :"
        '
        'txt_razon_social
        '
        Me.txt_razon_social.Location = New System.Drawing.Point(108, 9)
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(241, 20)
        Me.txt_razon_social.TabIndex = 7
        '
        'lbl_razon_social
        '
        Me.lbl_razon_social.AutoSize = True
        Me.lbl_razon_social.Location = New System.Drawing.Point(12, 16)
        Me.lbl_razon_social.Name = "lbl_razon_social"
        Me.lbl_razon_social.Size = New System.Drawing.Size(76, 13)
        Me.lbl_razon_social.TabIndex = 6
        Me.lbl_razon_social.Text = "Razón Social :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_fecha_cancelacion)
        Me.GroupBox3.Controls.Add(Me.cbx_estado_cancelacion)
        Me.GroupBox3.Controls.Add(Me.dtp_fecha_cancelacion)
        Me.GroupBox3.Controls.Add(Me.lbl_estado_cancelacion)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 217)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(745, 45)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'lbl_fecha_cancelacion
        '
        Me.lbl_fecha_cancelacion.AutoSize = True
        Me.lbl_fecha_cancelacion.Location = New System.Drawing.Point(416, 16)
        Me.lbl_fecha_cancelacion.Name = "lbl_fecha_cancelacion"
        Me.lbl_fecha_cancelacion.Size = New System.Drawing.Size(43, 13)
        Me.lbl_fecha_cancelacion.TabIndex = 12
        Me.lbl_fecha_cancelacion.Text = "Fecha :"
        Me.lbl_fecha_cancelacion.Visible = False
        '
        'cbx_estado_cancelacion
        '
        Me.cbx_estado_cancelacion.FormattingEnabled = True
        Me.cbx_estado_cancelacion.Items.AddRange(New Object() {"Pendiente", "Cancelado"})
        Me.cbx_estado_cancelacion.Location = New System.Drawing.Point(108, 13)
        Me.cbx_estado_cancelacion.Name = "cbx_estado_cancelacion"
        Me.cbx_estado_cancelacion.Size = New System.Drawing.Size(241, 21)
        Me.cbx_estado_cancelacion.TabIndex = 11
        '
        'dtp_fecha_cancelacion
        '
        Me.dtp_fecha_cancelacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_cancelacion.Location = New System.Drawing.Point(512, 9)
        Me.dtp_fecha_cancelacion.Name = "dtp_fecha_cancelacion"
        Me.dtp_fecha_cancelacion.Size = New System.Drawing.Size(100, 20)
        Me.dtp_fecha_cancelacion.TabIndex = 10
        Me.dtp_fecha_cancelacion.Visible = False
        '
        'lbl_estado_cancelacion
        '
        Me.lbl_estado_cancelacion.AutoSize = True
        Me.lbl_estado_cancelacion.Location = New System.Drawing.Point(12, 16)
        Me.lbl_estado_cancelacion.Name = "lbl_estado_cancelacion"
        Me.lbl_estado_cancelacion.Size = New System.Drawing.Size(72, 26)
        Me.lbl_estado_cancelacion.TabIndex = 8
        Me.lbl_estado_cancelacion.Text = "Estado de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cancelacion :"
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Location = New System.Drawing.Point(331, 268)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(140, 23)
        Me.btn_ingresar.TabIndex = 3
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'ing_juicio_coactivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(769, 302)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ing_juicio_coactivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Juicio Coactivo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_titulo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents txt_juicio As System.Windows.Forms.TextBox
    Friend WithEvents lbl_juicio As System.Windows.Forms.Label
    Friend WithEvents txt_abogado As System.Windows.Forms.TextBox
    Friend WithEvents lbl_abogado As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_emision As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fecha_emision As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_valor_titulo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_valor_titulo As System.Windows.Forms.Label
    Friend WithEvents txt_ruc_patronal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ruc_patronal As System.Windows.Forms.Label
    Friend WithEvents txt_razon_social As System.Windows.Forms.TextBox
    Friend WithEvents lbl_razon_social As System.Windows.Forms.Label
    Friend WithEvents txt_valor_total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_valor_total As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_estado_cancelacion As System.Windows.Forms.Label
    Friend WithEvents btn_ingresar As System.Windows.Forms.Button
    Friend WithEvents lbl_fecha_cancelacion As System.Windows.Forms.Label
    Friend WithEvents cbx_estado_cancelacion As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fecha_cancelacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
