<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaPositivos
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRetroceder = New System.Windows.Forms.Button()
        Me.btnRastreo = New System.Windows.Forms.Button()
        Me.btnReportesAtencion = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre, Me.Apellido, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(68, 125)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1050, 237)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 111
        '
        'Apellido
        '
        Me.Apellido.Text = "Apellido"
        Me.Apellido.Width = 122
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ubicacion"
        Me.ColumnHeader1.Width = 108
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Celular"
        Me.ColumnHeader2.Width = 101
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Genero"
        Me.ColumnHeader3.Width = 99
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Edad"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Equipo atendiendo"
        Me.ColumnHeader6.Width = 188
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(439, 509)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 30)
        Me.TextBox5.TabIndex = 23
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(439, 544)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 30)
        Me.TextBox4.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(155, 547)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Porcentaje de Mujeres:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(155, 509)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Porcentaje de Hombres:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(439, 466)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 30)
        Me.TextBox3.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(155, 469)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Total de contagiados:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(160, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(799, 69)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Lista de Pacientes Positivos"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(337, 377)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(202, 30)
        Me.TextBox6.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(155, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Buscar Paciente:"
        '
        'btnRetroceder
        '
        Me.btnRetroceder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetroceder.Location = New System.Drawing.Point(913, 558)
        Me.btnRetroceder.Name = "btnRetroceder"
        Me.btnRetroceder.Size = New System.Drawing.Size(168, 58)
        Me.btnRetroceder.TabIndex = 27
        Me.btnRetroceder.Text = "Retroceder"
        Me.btnRetroceder.UseVisualStyleBackColor = True
        '
        'btnRastreo
        '
        Me.btnRastreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRastreo.Location = New System.Drawing.Point(391, 646)
        Me.btnRastreo.Name = "btnRastreo"
        Me.btnRastreo.Size = New System.Drawing.Size(398, 58)
        Me.btnRastreo.TabIndex = 28
        Me.btnRastreo.Text = "Iniciar Rastreo"
        Me.btnRastreo.UseVisualStyleBackColor = True
        '
        'btnReportesAtencion
        '
        Me.btnReportesAtencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportesAtencion.Location = New System.Drawing.Point(913, 392)
        Me.btnReportesAtencion.Name = "btnReportesAtencion"
        Me.btnReportesAtencion.Size = New System.Drawing.Size(168, 58)
        Me.btnReportesAtencion.TabIndex = 29
        Me.btnReportesAtencion.Text = "Reportes de atencion"
        Me.btnReportesAtencion.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(913, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 68)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Actualizar a Recuperado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmListaPositivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1199, 762)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnReportesAtencion)
        Me.Controls.Add(Me.btnRastreo)
        Me.Controls.Add(Me.btnRetroceder)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmListaPositivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Apellido As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRetroceder As Button
    Friend WithEvents btnRastreo As Button
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btnReportesAtencion As Button
    Friend WithEvents Button1 As Button
End Class
