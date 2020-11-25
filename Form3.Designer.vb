<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListaEspera
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim Id_pacienteLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPositivo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnRetroceder = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdpacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalDes5DataSet = New PF_Eq01_tema.finalDes5DataSet()
        Me.PacientesTableAdapter = New PF_Eq01_tema.finalDes5DataSetTableAdapters.pacientesTableAdapter()
        Me.TableAdapterManager = New PF_Eq01_tema.finalDes5DataSetTableAdapters.TableAdapterManager()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNegativo = New System.Windows.Forms.Button()
        Me.txtIdPaciente = New System.Windows.Forms.TextBox()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.lbPorcentajeMujeres = New System.Windows.Forms.Label()
        Me.lbPorcentajeHombres = New System.Windows.Forms.Label()
        Me.lbCantHombres = New System.Windows.Forms.Label()
        Me.lbCantMujeres = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        Id_pacienteLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalDes5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(71, 515)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(60, 17)
        NombreLabel.TabIndex = 29
        NombreLabel.Text = "nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(71, 543)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(61, 17)
        ApellidoLabel.TabIndex = 30
        ApellidoLabel.Text = "apellido:"
        '
        'Id_pacienteLabel
        '
        Id_pacienteLabel.AutoSize = True
        Id_pacienteLabel.Location = New System.Drawing.Point(71, 487)
        Id_pacienteLabel.Name = "Id_pacienteLabel"
        Id_pacienteLabel.Size = New System.Drawing.Size(81, 17)
        Id_pacienteLabel.TabIndex = 31
        Id_pacienteLabel.Text = "id paciente:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(69, 571)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(53, 17)
        CorreoLabel.TabIndex = 32
        CorreoLabel.Text = "correo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(70, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(458, 69)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Lista de Espera"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 608)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Total en espera:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 644)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Porcentaje de Hombres:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 682)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Porcentaje de Mujeres:"
        '
        'btnPositivo
        '
        Me.btnPositivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPositivo.Location = New System.Drawing.Point(769, 470)
        Me.btnPositivo.Name = "btnPositivo"
        Me.btnPositivo.Size = New System.Drawing.Size(291, 45)
        Me.btnPositivo.TabIndex = 18
        Me.btnPositivo.Text = "Actualizar a positivo"
        Me.btnPositivo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(567, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 25)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Buscar Paciente (cédula):"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(859, 79)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(224, 30)
        Me.txtBusqueda.TabIndex = 20
        '
        'btnRetroceder
        '
        Me.btnRetroceder.AllowDrop = True
        Me.btnRetroceder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetroceder.Location = New System.Drawing.Point(779, 630)
        Me.btnRetroceder.Name = "btnRetroceder"
        Me.btnRetroceder.Size = New System.Drawing.Size(168, 58)
        Me.btnRetroceder.TabIndex = 28
        Me.btnRetroceder.Text = "Retroceder"
        Me.btnRetroceder.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpacienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.GeneroDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PacientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(30, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1053, 308)
        Me.DataGridView1.TabIndex = 29
        '
        'IdpacienteDataGridViewTextBoxColumn
        '
        Me.IdpacienteDataGridViewTextBoxColumn.DataPropertyName = "id_paciente"
        Me.IdpacienteDataGridViewTextBoxColumn.HeaderText = "id_paciente"
        Me.IdpacienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdpacienteDataGridViewTextBoxColumn.Name = "IdpacienteDataGridViewTextBoxColumn"
        Me.IdpacienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdpacienteDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidoDataGridViewTextBoxColumn.Width = 125
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CedulaDataGridViewTextBoxColumn.Width = 125
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "edad"
        Me.EdadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        Me.EdadDataGridViewTextBoxColumn.ReadOnly = True
        Me.EdadDataGridViewTextBoxColumn.Width = 125
        '
        'GeneroDataGridViewTextBoxColumn
        '
        Me.GeneroDataGridViewTextBoxColumn.DataPropertyName = "genero"
        Me.GeneroDataGridViewTextBoxColumn.HeaderText = "genero"
        Me.GeneroDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GeneroDataGridViewTextBoxColumn.Name = "GeneroDataGridViewTextBoxColumn"
        Me.GeneroDataGridViewTextBoxColumn.ReadOnly = True
        Me.GeneroDataGridViewTextBoxColumn.Width = 125
        '
        'UbicacionDataGridViewTextBoxColumn
        '
        Me.UbicacionDataGridViewTextBoxColumn.DataPropertyName = "ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.HeaderText = "ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UbicacionDataGridViewTextBoxColumn.Name = "UbicacionDataGridViewTextBoxColumn"
        Me.UbicacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.UbicacionDataGridViewTextBoxColumn.Width = 125
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "celular"
        Me.CelularDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.ReadOnly = True
        Me.CelularDataGridViewTextBoxColumn.Width = 125
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "correo"
        Me.CorreoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoDataGridViewTextBoxColumn.Width = 125
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Width = 125
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "pacientes"
        Me.PacientesBindingSource.DataSource = Me.FinalDes5DataSet
        '
        'FinalDes5DataSet
        '
        Me.FinalDes5DataSet.DataSetName = "finalDes5DataSet"
        Me.FinalDes5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.equiposTableAdapter = Nothing
        Me.TableAdapterManager.integrantesTableAdapter = Nothing
        Me.TableAdapterManager.pacientesTableAdapter = Me.PacientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = PF_Eq01_tema.finalDes5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(158, 512)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(100, 22)
        Me.txtNombre.TabIndex = 30
        '
        'txtApellido
        '
        Me.txtApellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "apellido", True))
        Me.txtApellido.Location = New System.Drawing.Point(158, 540)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ReadOnly = True
        Me.txtApellido.Size = New System.Drawing.Size(100, 22)
        Me.txtApellido.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 453)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Paciente Seleccionado"
        '
        'btnNegativo
        '
        Me.btnNegativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNegativo.Location = New System.Drawing.Point(769, 524)
        Me.btnNegativo.Name = "btnNegativo"
        Me.btnNegativo.Size = New System.Drawing.Size(291, 45)
        Me.btnNegativo.TabIndex = 18
        Me.btnNegativo.Text = "Actualizar a Negativo"
        Me.btnNegativo.UseVisualStyleBackColor = True
        '
        'txtIdPaciente
        '
        Me.txtIdPaciente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "id_paciente", True))
        Me.txtIdPaciente.Location = New System.Drawing.Point(158, 484)
        Me.txtIdPaciente.Name = "txtIdPaciente"
        Me.txtIdPaciente.ReadOnly = True
        Me.txtIdPaciente.Size = New System.Drawing.Size(100, 22)
        Me.txtIdPaciente.TabIndex = 32
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(367, 608)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(24, 25)
        Me.lbTotal.TabIndex = 8
        Me.lbTotal.Text = "0"
        '
        'lbPorcentajeMujeres
        '
        Me.lbPorcentajeMujeres.AutoSize = True
        Me.lbPorcentajeMujeres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPorcentajeMujeres.Location = New System.Drawing.Point(416, 682)
        Me.lbPorcentajeMujeres.Name = "lbPorcentajeMujeres"
        Me.lbPorcentajeMujeres.Size = New System.Drawing.Size(43, 25)
        Me.lbPorcentajeMujeres.TabIndex = 8
        Me.lbPorcentajeMujeres.Text = "0%"
        '
        'lbPorcentajeHombres
        '
        Me.lbPorcentajeHombres.AutoSize = True
        Me.lbPorcentajeHombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPorcentajeHombres.Location = New System.Drawing.Point(416, 644)
        Me.lbPorcentajeHombres.Name = "lbPorcentajeHombres"
        Me.lbPorcentajeHombres.Size = New System.Drawing.Size(43, 25)
        Me.lbPorcentajeHombres.TabIndex = 8
        Me.lbPorcentajeHombres.Text = "0%"
        '
        'lbCantHombres
        '
        Me.lbCantHombres.AutoSize = True
        Me.lbCantHombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCantHombres.Location = New System.Drawing.Point(358, 644)
        Me.lbCantHombres.Name = "lbCantHombres"
        Me.lbCantHombres.Size = New System.Drawing.Size(43, 25)
        Me.lbCantHombres.TabIndex = 8
        Me.lbCantHombres.Text = "0%"
        '
        'lbCantMujeres
        '
        Me.lbCantMujeres.AutoSize = True
        Me.lbCantMujeres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCantMujeres.Location = New System.Drawing.Point(358, 682)
        Me.lbCantMujeres.Name = "lbCantMujeres"
        Me.lbCantMujeres.Size = New System.Drawing.Size(43, 25)
        Me.lbCantMujeres.TabIndex = 8
        Me.lbCantMujeres.Text = "0%"
        '
        'txtCorreo
        '
        Me.txtCorreo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "correo", True))
        Me.txtCorreo.Location = New System.Drawing.Point(158, 568)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(100, 22)
        Me.txtCorreo.TabIndex = 33
        '
        'frmListaEspera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1103, 729)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Id_pacienteLabel)
        Me.Controls.Add(Me.txtIdPaciente)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnRetroceder)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnNegativo)
        Me.Controls.Add(Me.btnPositivo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbCantHombres)
        Me.Controls.Add(Me.lbPorcentajeHombres)
        Me.Controls.Add(Me.lbCantMujeres)
        Me.Controls.Add(Me.lbPorcentajeMujeres)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmListaEspera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalDes5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPositivo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnRetroceder As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FinalDes5DataSet As finalDes5DataSet
    Friend WithEvents PacientesBindingSource As BindingSource
    Friend WithEvents PacientesTableAdapter As finalDes5DataSetTableAdapters.pacientesTableAdapter
    Friend WithEvents IdpacienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeneroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As finalDes5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNegativo As Button
    Friend WithEvents txtIdPaciente As TextBox
    Friend WithEvents lbTotal As Label
    Friend WithEvents lbPorcentajeMujeres As Label
    Friend WithEvents lbPorcentajeHombres As Label
    Friend WithEvents lbCantHombres As Label
    Friend WithEvents lbCantMujeres As Label
    Friend WithEvents txtCorreo As TextBox
End Class
