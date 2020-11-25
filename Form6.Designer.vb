<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumen
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvHombres = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbTotalTest = New System.Windows.Forms.Label()
        Me.lbTotalPositivos = New System.Windows.Forms.Label()
        Me.lbTotalNegativos = New System.Windows.Forms.Label()
        Me.btnRetroceder = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ImprimirEnPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbTotalRecuperados = New System.Windows.Forms.Label()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvMujeres = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbEspera = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(249, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(609, 69)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Resumen Estadistico"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(343, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(286, 25)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Total de paciente testeados:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(341, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Total de pacientes positivos:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Total de pacientes Negativos:"
        '
        'lvHombres
        '
        Me.lvHombres.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lvHombres.HideSelection = False
        Me.lvHombres.Location = New System.Drawing.Point(56, 440)
        Me.lvHombres.Name = "lvHombres"
        Me.lvHombres.Size = New System.Drawing.Size(519, 248)
        Me.lvHombres.TabIndex = 34
        Me.lvHombres.UseCompatibleStateImageBehavior = False
        Me.lvHombres.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Total"
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(870, 726)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(8, 8)
        Me.PrintPreviewControl1.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(234, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Hombres"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(841, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Mujeres"
        '
        'lbTotalTest
        '
        Me.lbTotalTest.AutoSize = True
        Me.lbTotalTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalTest.Location = New System.Drawing.Point(705, 161)
        Me.lbTotalTest.Name = "lbTotalTest"
        Me.lbTotalTest.Size = New System.Drawing.Size(108, 25)
        Me.lbTotalTest.TabIndex = 41
        Me.lbTotalTest.Text = "Resultado"
        '
        'lbTotalPositivos
        '
        Me.lbTotalPositivos.AutoSize = True
        Me.lbTotalPositivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalPositivos.Location = New System.Drawing.Point(705, 239)
        Me.lbTotalPositivos.Name = "lbTotalPositivos"
        Me.lbTotalPositivos.Size = New System.Drawing.Size(108, 25)
        Me.lbTotalPositivos.TabIndex = 42
        Me.lbTotalPositivos.Text = "Resultado"
        '
        'lbTotalNegativos
        '
        Me.lbTotalNegativos.AutoSize = True
        Me.lbTotalNegativos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalNegativos.Location = New System.Drawing.Point(705, 285)
        Me.lbTotalNegativos.Name = "lbTotalNegativos"
        Me.lbTotalNegativos.Size = New System.Drawing.Size(108, 25)
        Me.lbTotalNegativos.TabIndex = 43
        Me.lbTotalNegativos.Text = "Resultado"
        '
        'btnRetroceder
        '
        Me.btnRetroceder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetroceder.Location = New System.Drawing.Point(910, 777)
        Me.btnRetroceder.Name = "btnRetroceder"
        Me.btnRetroceder.Size = New System.Drawing.Size(168, 58)
        Me.btnRetroceder.TabIndex = 44
        Me.btnRetroceder.Text = "Retroceder"
        Me.btnRetroceder.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirEnPDFToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1188, 30)
        Me.MenuStrip1.TabIndex = 45
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImprimirEnPDFToolStripMenuItem
        '
        Me.ImprimirEnPDFToolStripMenuItem.Name = "ImprimirEnPDFToolStripMenuItem"
        Me.ImprimirEnPDFToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.ImprimirEnPDFToolStripMenuItem.Text = "Imprimir en PDF"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(341, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(330, 25)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Total de pacientes Recuperados:"
        '
        'lbTotalRecuperados
        '
        Me.lbTotalRecuperados.AutoSize = True
        Me.lbTotalRecuperados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalRecuperados.Location = New System.Drawing.Point(705, 328)
        Me.lbTotalRecuperados.Name = "lbTotalRecuperados"
        Me.lbTotalRecuperados.Size = New System.Drawing.Size(108, 25)
        Me.lbTotalRecuperados.TabIndex = 47
        Me.lbTotalRecuperados.Text = "Resultado"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Positivos (%)"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Negativos (%)"
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Recuperados"
        '
        'lvMujeres
        '
        Me.lvMujeres.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvMujeres.HideSelection = False
        Me.lvMujeres.Location = New System.Drawing.Point(625, 440)
        Me.lvMujeres.Name = "lvMujeres"
        Me.lvMujeres.Size = New System.Drawing.Size(519, 248)
        Me.lvMujeres.TabIndex = 34
        Me.lvMujeres.UseCompatibleStateImageBehavior = False
        Me.lvMujeres.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Total"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Positivos (%)"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Negativos (%)"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Recuperados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(341, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(298, 25)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Total de paciente pendientes:"
        '
        'lbEspera
        '
        Me.lbEspera.AutoSize = True
        Me.lbEspera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEspera.Location = New System.Drawing.Point(705, 196)
        Me.lbEspera.Name = "lbEspera"
        Me.lbEspera.Size = New System.Drawing.Size(108, 25)
        Me.lbEspera.TabIndex = 41
        Me.lbEspera.Text = "Resultado"
        '
        'frmResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1188, 904)
        Me.Controls.Add(Me.lbTotalRecuperados)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnRetroceder)
        Me.Controls.Add(Me.lbTotalNegativos)
        Me.Controls.Add(Me.lbTotalPositivos)
        Me.Controls.Add(Me.lbEspera)
        Me.Controls.Add(Me.lbTotalTest)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Controls.Add(Me.lvMujeres)
        Me.Controls.Add(Me.lvHombres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmResumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lvHombres As ListView
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents lbTotalTest As Label
    Friend WithEvents lbTotalPositivos As Label
    Friend WithEvents lbTotalNegativos As Label
    Friend WithEvents btnRetroceder As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ImprimirEnPDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label10 As Label
    Friend WithEvents lbTotalRecuperados As Label
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents lvMujeres As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents lbEspera As Label
End Class
