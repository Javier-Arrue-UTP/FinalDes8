<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btrRegistrar = New System.Windows.Forms.Button()
        Me.btnListaEspera = New System.Windows.Forms.Button()
        Me.btnListaPositivos = New System.Windows.Forms.Button()
        Me.btnListaNegativos = New System.Windows.Forms.Button()
        Me.btnResumen = New System.Windows.Forms.Button()
        Me.btnListaRecuperados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btrRegistrar
        '
        Me.btrRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btrRegistrar.Location = New System.Drawing.Point(89, 63)
        Me.btrRegistrar.Name = "btrRegistrar"
        Me.btrRegistrar.Size = New System.Drawing.Size(419, 65)
        Me.btrRegistrar.TabIndex = 0
        Me.btrRegistrar.Text = "Registrar Paciente"
        Me.btrRegistrar.UseVisualStyleBackColor = True
        '
        'btnListaEspera
        '
        Me.btnListaEspera.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaEspera.Location = New System.Drawing.Point(89, 134)
        Me.btnListaEspera.Name = "btnListaEspera"
        Me.btnListaEspera.Size = New System.Drawing.Size(419, 65)
        Me.btnListaEspera.TabIndex = 2
        Me.btnListaEspera.Text = "Lista de Espera"
        Me.btnListaEspera.UseVisualStyleBackColor = True
        '
        'btnListaPositivos
        '
        Me.btnListaPositivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaPositivos.Location = New System.Drawing.Point(89, 214)
        Me.btnListaPositivos.Name = "btnListaPositivos"
        Me.btnListaPositivos.Size = New System.Drawing.Size(419, 65)
        Me.btnListaPositivos.TabIndex = 3
        Me.btnListaPositivos.Text = "Lista de Pacientes Positivos"
        Me.btnListaPositivos.UseVisualStyleBackColor = True
        '
        'btnListaNegativos
        '
        Me.btnListaNegativos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaNegativos.Location = New System.Drawing.Point(89, 292)
        Me.btnListaNegativos.Name = "btnListaNegativos"
        Me.btnListaNegativos.Size = New System.Drawing.Size(419, 65)
        Me.btnListaNegativos.TabIndex = 4
        Me.btnListaNegativos.Text = "Lista de Pacientes Negativos"
        Me.btnListaNegativos.UseVisualStyleBackColor = True
        '
        'btnResumen
        '
        Me.btnResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResumen.Location = New System.Drawing.Point(89, 453)
        Me.btnResumen.Name = "btnResumen"
        Me.btnResumen.Size = New System.Drawing.Size(419, 65)
        Me.btnResumen.TabIndex = 5
        Me.btnResumen.Text = "Resumen Estadisticos"
        Me.btnResumen.UseVisualStyleBackColor = True
        '
        'btnListaRecuperados
        '
        Me.btnListaRecuperados.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaRecuperados.Location = New System.Drawing.Point(46, 375)
        Me.btnListaRecuperados.Name = "btnListaRecuperados"
        Me.btnListaRecuperados.Size = New System.Drawing.Size(488, 65)
        Me.btnListaRecuperados.TabIndex = 6
        Me.btnListaRecuperados.Text = "Lista de Pacientes Recuperados"
        Me.btnListaRecuperados.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(589, 590)
        Me.Controls.Add(Me.btnListaRecuperados)
        Me.Controls.Add(Me.btnResumen)
        Me.Controls.Add(Me.btnListaNegativos)
        Me.Controls.Add(Me.btnListaPositivos)
        Me.Controls.Add(Me.btnListaEspera)
        Me.Controls.Add(Me.btrRegistrar)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btrRegistrar As Button
    Friend WithEvents btnListaEspera As Button
    Friend WithEvents btnListaPositivos As Button
    Friend WithEvents btnListaNegativos As Button
    Friend WithEvents btnResumen As Button
    Friend WithEvents btnListaRecuperados As Button
End Class
