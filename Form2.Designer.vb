<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroPaciente
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbCorregimiento = New System.Windows.Forms.ComboBox()
        Me.nudEdad = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnRetroceder1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFemenino = New System.Windows.Forms.RadioButton()
        Me.radMasculino = New System.Windows.Forms.RadioButton()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FinalDes5DataSet = New PF_Eq01_tema.finalDes5DataSet()
        Me.EquiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquiposTableAdapter = New PF_Eq01_tema.finalDes5DataSetTableAdapters.equiposTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FinalDes5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.cbCorregimiento)
        Me.Panel1.Controls.Add(Me.nudEdad)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtCorreo)
        Me.Panel1.Controls.Add(Me.btnRetroceder1)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtCedula)
        Me.Panel1.Controls.Add(Me.txtCelular)
        Me.Panel1.Controls.Add(Me.txtUbicacion)
        Me.Panel1.Controls.Add(Me.txtApellido)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 751)
        Me.Panel1.TabIndex = 0
        '
        'cbCorregimiento
        '
        Me.cbCorregimiento.DataSource = Me.EquiposBindingSource
        Me.cbCorregimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCorregimiento.FormattingEnabled = True
        Me.cbCorregimiento.Location = New System.Drawing.Point(106, 446)
        Me.cbCorregimiento.Name = "cbCorregimiento"
        Me.cbCorregimiento.Size = New System.Drawing.Size(217, 24)
        Me.cbCorregimiento.TabIndex = 5
        '
        'nudEdad
        '
        Me.nudEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudEdad.Location = New System.Drawing.Point(334, 249)
        Me.nudEdad.Name = "nudEdad"
        Me.nudEdad.Size = New System.Drawing.Size(159, 26)
        Me.nudEdad.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(101, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Correo"
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(104, 323)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(145, 28)
        Me.txtCorreo.TabIndex = 7
        '
        'btnRetroceder1
        '
        Me.btnRetroceder1.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRetroceder1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetroceder1.ForeColor = System.Drawing.Color.White
        Me.btnRetroceder1.Location = New System.Drawing.Point(159, 681)
        Me.btnRetroceder1.Name = "btnRetroceder1"
        Me.btnRetroceder1.Size = New System.Drawing.Size(281, 52)
        Me.btnRetroceder1.TabIndex = 2
        Me.btnRetroceder1.Text = "Retroceder"
        Me.btnRetroceder1.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(159, 623)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(281, 52)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(329, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 25)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Edad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(329, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 25)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Cedula"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(101, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Celular"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(101, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ubicacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(329, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(101, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.radFemenino)
        Me.GroupBox1.Controls.Add(Me.radMasculino)
        Me.GroupBox1.Location = New System.Drawing.Point(334, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 102)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Genero"
        '
        'radFemenino
        '
        Me.radFemenino.AutoSize = True
        Me.radFemenino.Location = New System.Drawing.Point(27, 61)
        Me.radFemenino.Name = "radFemenino"
        Me.radFemenino.Size = New System.Drawing.Size(91, 21)
        Me.radFemenino.TabIndex = 1
        Me.radFemenino.TabStop = True
        Me.radFemenino.Text = "Femenino"
        Me.radFemenino.UseVisualStyleBackColor = True
        '
        'radMasculino
        '
        Me.radMasculino.AutoSize = True
        Me.radMasculino.BackColor = System.Drawing.Color.Transparent
        Me.radMasculino.Location = New System.Drawing.Point(27, 34)
        Me.radMasculino.Name = "radMasculino"
        Me.radMasculino.Size = New System.Drawing.Size(92, 21)
        Me.radMasculino.TabIndex = 0
        Me.radMasculino.TabStop = True
        Me.radMasculino.Text = "Masculino"
        Me.radMasculino.UseVisualStyleBackColor = False
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(334, 175)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(145, 28)
        Me.txtCedula.TabIndex = 1
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(104, 249)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(145, 28)
        Me.txtCelular.TabIndex = 1
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Location = New System.Drawing.Point(104, 171)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(145, 28)
        Me.txtUbicacion.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(334, 91)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(145, 28)
        Me.txtApellido.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(104, 91)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(145, 28)
        Me.txtNombre.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(760, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 69)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Logo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(101, 418)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Corregimiento"
        '
        'FinalDes5DataSet
        '
        Me.FinalDes5DataSet.DataSetName = "finalDes5DataSet"
        Me.FinalDes5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EquiposBindingSource
        '
        Me.EquiposBindingSource.DataMember = "equipos"
        Me.EquiposBindingSource.DataSource = Me.FinalDes5DataSet
        '
        'EquiposTableAdapter
        '
        Me.EquiposTableAdapter.ClearBeforeFill = True
        '
        'frmRegistroPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 745)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmRegistroPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FinalDes5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRetroceder1 As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radFemenino As RadioButton
    Friend WithEvents radMasculino As RadioButton
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents nudEdad As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents cbCorregimiento As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FinalDes5DataSet As finalDes5DataSet
    Friend WithEvents EquiposBindingSource As BindingSource
    Friend WithEvents EquiposTableAdapter As finalDes5DataSetTableAdapters.equiposTableAdapter
End Class
