<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRastreo
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
        Me.btnRetroceder = New System.Windows.Forms.Button()
        Me.txtIdPacienteRastreo = New System.Windows.Forms.TextBox()
        Me.la = New System.Windows.Forms.Label()
        Me.txtIdPaciente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.c = New System.Windows.Forms.Label()
        Me.cbCorregimiento = New System.Windows.Forms.ComboBox()
        Me.EquiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalDes5DataSet = New PF_Eq01_tema.finalDes5DataSet()
        Me.nudEdad = New System.Windows.Forms.NumericUpDown()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvRastreo = New System.Windows.Forms.DataGridView()
        Me.btnNegativo = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnPositivo = New System.Windows.Forms.Button()
        Me.lblNombreCompleto = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFemenino = New System.Windows.Forms.RadioButton()
        Me.radMasculino = New System.Windows.Forms.RadioButton()
        Me.FinalDes5DataSet1 = New PF_Eq01_tema.finalDes5DataSet1()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesTableAdapter = New PF_Eq01_tema.finalDes5DataSet1TableAdapters.pacientesTableAdapter()
        Me.EquiposTableAdapter = New PF_Eq01_tema.finalDes5DataSetTableAdapters.equiposTableAdapter()
        Me.EquiposBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCorreoSeleccion = New System.Windows.Forms.TextBox()
        CType(Me.EquiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalDes5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRastreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FinalDes5DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquiposBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRetroceder
        '
        Me.btnRetroceder.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRetroceder.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetroceder.ForeColor = System.Drawing.Color.White
        Me.btnRetroceder.Location = New System.Drawing.Point(51, 732)
        Me.btnRetroceder.Name = "btnRetroceder"
        Me.btnRetroceder.Size = New System.Drawing.Size(177, 52)
        Me.btnRetroceder.TabIndex = 2
        Me.btnRetroceder.Text = "Retroceder"
        Me.btnRetroceder.UseVisualStyleBackColor = False
        '
        'txtIdPacienteRastreo
        '
        Me.txtIdPacienteRastreo.Location = New System.Drawing.Point(415, 557)
        Me.txtIdPacienteRastreo.Name = "txtIdPacienteRastreo"
        Me.txtIdPacienteRastreo.Size = New System.Drawing.Size(100, 22)
        Me.txtIdPacienteRastreo.TabIndex = 72
        Me.txtIdPacienteRastreo.Visible = False
        '
        'la
        '
        Me.la.AutoSize = True
        Me.la.BackColor = System.Drawing.Color.Transparent
        Me.la.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.la.ForeColor = System.Drawing.Color.Black
        Me.la.Location = New System.Drawing.Point(826, 56)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(40, 25)
        Me.la.TabIndex = 71
        Me.la.Text = "ID:"
        '
        'txtIdPaciente
        '
        Me.txtIdPaciente.Location = New System.Drawing.Point(872, 60)
        Me.txtIdPaciente.Name = "txtIdPaciente"
        Me.txtIdPaciente.ReadOnly = True
        Me.txtIdPaciente.Size = New System.Drawing.Size(100, 22)
        Me.txtIdPaciente.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(46, 504)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 25)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Cedula"
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(42, 532)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(145, 28)
        Me.txtCedula.TabIndex = 68
        '
        'c
        '
        Me.c.AutoSize = True
        Me.c.BackColor = System.Drawing.Color.Transparent
        Me.c.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c.ForeColor = System.Drawing.Color.Black
        Me.c.Location = New System.Drawing.Point(141, 580)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(147, 25)
        Me.c.TabIndex = 67
        Me.c.Text = "Corregimineto"
        '
        'cbCorregimiento
        '
        Me.cbCorregimiento.DataSource = Me.EquiposBindingSource
        Me.cbCorregimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCorregimiento.FormattingEnabled = True
        Me.cbCorregimiento.Location = New System.Drawing.Point(111, 608)
        Me.cbCorregimiento.Name = "cbCorregimiento"
        Me.cbCorregimiento.Size = New System.Drawing.Size(217, 24)
        Me.cbCorregimiento.TabIndex = 66
        '
        'EquiposBindingSource
        '
        Me.EquiposBindingSource.DataMember = "equipos"
        Me.EquiposBindingSource.DataSource = Me.FinalDes5DataSet
        '
        'FinalDes5DataSet
        '
        Me.FinalDes5DataSet.DataSetName = "finalDes5DataSet"
        Me.FinalDes5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'nudEdad
        '
        Me.nudEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudEdad.Location = New System.Drawing.Point(233, 307)
        Me.nudEdad.Name = "nudEdad"
        Me.nudEdad.Size = New System.Drawing.Size(145, 28)
        Me.nudEdad.TabIndex = 65
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(233, 227)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(145, 28)
        Me.txtCorreo.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(273, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 25)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Edad:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(257, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 25)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Correo:"
        '
        'dgvRastreo
        '
        Me.dgvRastreo.AllowUserToAddRows = False
        Me.dgvRastreo.AllowUserToDeleteRows = False
        Me.dgvRastreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRastreo.Location = New System.Drawing.Point(415, 152)
        Me.dgvRastreo.Name = "dgvRastreo"
        Me.dgvRastreo.ReadOnly = True
        Me.dgvRastreo.RowHeadersWidth = 51
        Me.dgvRastreo.RowTemplate.Height = 24
        Me.dgvRastreo.Size = New System.Drawing.Size(685, 399)
        Me.dgvRastreo.TabIndex = 61
        '
        'btnNegativo
        '
        Me.btnNegativo.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnNegativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNegativo.ForeColor = System.Drawing.Color.White
        Me.btnNegativo.Location = New System.Drawing.Point(620, 666)
        Me.btnNegativo.Name = "btnNegativo"
        Me.btnNegativo.Size = New System.Drawing.Size(281, 52)
        Me.btnNegativo.TabIndex = 60
        Me.btnNegativo.Text = "Actualizar a negativo"
        Me.btnNegativo.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(462, 29)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Paciente seleccionado para el rastreo:"
        '
        'btnPositivo
        '
        Me.btnPositivo.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnPositivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPositivo.ForeColor = System.Drawing.Color.White
        Me.btnPositivo.Location = New System.Drawing.Point(620, 608)
        Me.btnPositivo.Name = "btnPositivo"
        Me.btnPositivo.Size = New System.Drawing.Size(281, 52)
        Me.btnPositivo.TabIndex = 58
        Me.btnPositivo.Text = "Actualizar a positivo"
        Me.btnPositivo.UseVisualStyleBackColor = False
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.AutoSize = True
        Me.lblNombreCompleto.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCompleto.ForeColor = System.Drawing.Color.Black
        Me.lblNombreCompleto.Location = New System.Drawing.Point(532, 56)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(185, 25)
        Me.lblNombreCompleto.TabIndex = 57
        Me.lblNombreCompleto.Text = "Nombre Completo"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(127, 638)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(177, 52)
        Me.btnGuardar.TabIndex = 49
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(413, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 69)
        Me.Label6.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(39, 433)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Celular"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(43, 227)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(145, 28)
        Me.txtNombre.TabIndex = 46
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(42, 307)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(145, 28)
        Me.txtApellido.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(39, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Ubicacion"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Location = New System.Drawing.Point(42, 383)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(145, 28)
        Me.txtUbicacion.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(37, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Apellido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(40, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 25)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Nombre"
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(42, 461)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(145, 28)
        Me.txtCelular.TabIndex = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.radFemenino)
        Me.GroupBox1.Controls.Add(Me.radMasculino)
        Me.GroupBox1.Location = New System.Drawing.Point(233, 383)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 102)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Genero"
        '
        'radFemenino
        '
        Me.radFemenino.AutoSize = True
        Me.radFemenino.Location = New System.Drawing.Point(28, 61)
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
        'FinalDes5DataSet1
        '
        Me.FinalDes5DataSet1.DataSetName = "finalDes5DataSet1"
        Me.FinalDes5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "pacientes"
        Me.PacientesBindingSource.DataSource = Me.FinalDes5DataSet1
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'EquiposTableAdapter
        '
        Me.EquiposTableAdapter.ClearBeforeFill = True
        '
        'EquiposBindingSource1
        '
        Me.EquiposBindingSource1.DataMember = "equipos"
        Me.EquiposBindingSource1.DataSource = Me.FinalDes5DataSet
        '
        'txtCorreoSeleccion
        '
        Me.txtCorreoSeleccion.AcceptsReturn = True
        Me.txtCorreoSeleccion.Location = New System.Drawing.Point(554, 557)
        Me.txtCorreoSeleccion.Name = "txtCorreoSeleccion"
        Me.txtCorreoSeleccion.Size = New System.Drawing.Size(100, 22)
        Me.txtCorreoSeleccion.TabIndex = 72
        Me.txtCorreoSeleccion.Visible = False
        '
        'frmRastreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1131, 791)
        Me.Controls.Add(Me.txtCorreoSeleccion)
        Me.Controls.Add(Me.txtIdPacienteRastreo)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.txtIdPaciente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.cbCorregimiento)
        Me.Controls.Add(Me.nudEdad)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvRastreo)
        Me.Controls.Add(Me.btnNegativo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnPositivo)
        Me.Controls.Add(Me.lblNombreCompleto)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUbicacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRetroceder)
        Me.Name = "frmRastreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        CType(Me.EquiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalDes5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRastreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FinalDes5DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquiposBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRetroceder As Button
    Friend WithEvents txtIdPacienteRastreo As TextBox
    Friend WithEvents la As Label
    Friend WithEvents txtIdPaciente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents c As Label
    Friend WithEvents cbCorregimiento As ComboBox
    Friend WithEvents nudEdad As NumericUpDown
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvRastreo As DataGridView
    Friend WithEvents btnNegativo As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnPositivo As Button
    Friend WithEvents lblNombreCompleto As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radFemenino As RadioButton
    Friend WithEvents radMasculino As RadioButton
    Friend WithEvents FinalDes5DataSet1 As finalDes5DataSet1
    Friend WithEvents PacientesBindingSource As BindingSource
    Friend WithEvents PacientesTableAdapter As finalDes5DataSet1TableAdapters.pacientesTableAdapter
    Friend WithEvents FinalDes5DataSet As finalDes5DataSet
    Friend WithEvents EquiposBindingSource As BindingSource
    Friend WithEvents EquiposTableAdapter As finalDes5DataSetTableAdapters.equiposTableAdapter
    Friend WithEvents EquiposBindingSource1 As BindingSource
    Friend WithEvents txtCorreoSeleccion As TextBox
End Class
