<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListaPositivos
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
        Dim Id_pacienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PacientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTotalMujeres = New System.Windows.Forms.Label()
        Me.lblTotalHombres = New System.Windows.Forms.Label()
        Me.lblPorcentajeMujeres = New System.Windows.Forms.Label()
        Me.lblPorcentajeHombres = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnActualizarRecuperado = New System.Windows.Forms.Button()
        Me.btnReportesAtencion = New System.Windows.Forms.Button()
        Me.btnRastreo = New System.Windows.Forms.Button()
        Me.btnRetroceder = New System.Windows.Forms.Button()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvPacientesPositivos = New System.Windows.Forms.DataGridView()
        Me.txtIdPaciente = New System.Windows.Forms.TextBox()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalDes5DataSet = New PF_Eq01_tema.finalDes5DataSet()
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
        Me.IdequipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinalDes5DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesTableAdapter = New PF_Eq01_tema.finalDes5DataSetTableAdapters.pacientesTableAdapter()
        Me.TableAdapterManager = New PF_Eq01_tema.finalDes5DataSetTableAdapters.TableAdapterManager()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Id_pacienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        CedulaLabel = New System.Windows.Forms.Label()
        CType(Me.PacientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPacientesPositivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalDes5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalDes5DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'PacientesBindingSource1
        '
        Me.PacientesBindingSource1.DataMember = "pacientes"
        Me.PacientesBindingSource1.DataSource = Me.FinalDes5DataSetBindingSource
        '
        'lblTotalMujeres
        '
        Me.lblTotalMujeres.AutoSize = True
        Me.lblTotalMujeres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMujeres.Location = New System.Drawing.Point(379, 630)
        Me.lblTotalMujeres.Name = "lblTotalMujeres"
        Me.lblTotalMujeres.Size = New System.Drawing.Size(23, 25)
        Me.lblTotalMujeres.TabIndex = 59
        Me.lblTotalMujeres.Text = "0"
        '
        'lblTotalHombres
        '
        Me.lblTotalHombres.AutoSize = True
        Me.lblTotalHombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHombres.Location = New System.Drawing.Point(379, 592)
        Me.lblTotalHombres.Name = "lblTotalHombres"
        Me.lblTotalHombres.Size = New System.Drawing.Size(23, 25)
        Me.lblTotalHombres.TabIndex = 58
        Me.lblTotalHombres.Text = "0"
        '
        'lblPorcentajeMujeres
        '
        Me.lblPorcentajeMujeres.AutoSize = True
        Me.lblPorcentajeMujeres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentajeMujeres.Location = New System.Drawing.Point(470, 630)
        Me.lblPorcentajeMujeres.Name = "lblPorcentajeMujeres"
        Me.lblPorcentajeMujeres.Size = New System.Drawing.Size(23, 25)
        Me.lblPorcentajeMujeres.TabIndex = 57
        Me.lblPorcentajeMujeres.Text = "0"
        '
        'lblPorcentajeHombres
        '
        Me.lblPorcentajeHombres.AutoSize = True
        Me.lblPorcentajeHombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentajeHombres.Location = New System.Drawing.Point(470, 592)
        Me.lblPorcentajeHombres.Name = "lblPorcentajeHombres"
        Me.lblPorcentajeHombres.Size = New System.Drawing.Size(23, 25)
        Me.lblPorcentajeHombres.TabIndex = 56
        Me.lblPorcentajeHombres.Text = "0"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(379, 552)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(23, 25)
        Me.lblTotal.TabIndex = 55
        Me.lblTotal.Text = "0"
        '
        'btnActualizarRecuperado
        '
        Me.btnActualizarRecuperado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarRecuperado.Location = New System.Drawing.Point(927, 452)
        Me.btnActualizarRecuperado.Name = "btnActualizarRecuperado"
        Me.btnActualizarRecuperado.Size = New System.Drawing.Size(168, 81)
        Me.btnActualizarRecuperado.TabIndex = 54
        Me.btnActualizarRecuperado.Text = "Actualizar a Recuperado"
        Me.btnActualizarRecuperado.UseVisualStyleBackColor = True
        '
        'btnReportesAtencion
        '
        Me.btnReportesAtencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportesAtencion.Location = New System.Drawing.Point(927, 373)
        Me.btnReportesAtencion.Name = "btnReportesAtencion"
        Me.btnReportesAtencion.Size = New System.Drawing.Size(168, 73)
        Me.btnReportesAtencion.TabIndex = 53
        Me.btnReportesAtencion.Text = "Reportes de atencion"
        Me.btnReportesAtencion.UseVisualStyleBackColor = True
        '
        'btnRastreo
        '
        Me.btnRastreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRastreo.Location = New System.Drawing.Point(414, 673)
        Me.btnRastreo.Name = "btnRastreo"
        Me.btnRastreo.Size = New System.Drawing.Size(398, 58)
        Me.btnRastreo.TabIndex = 52
        Me.btnRastreo.Text = "Iniciar Rastreo"
        Me.btnRastreo.UseVisualStyleBackColor = True
        '
        'btnRetroceder
        '
        Me.btnRetroceder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetroceder.Location = New System.Drawing.Point(927, 539)
        Me.btnRetroceder.Name = "btnRetroceder"
        Me.btnRetroceder.Size = New System.Drawing.Size(168, 58)
        Me.btnRetroceder.TabIndex = 51
        Me.btnRetroceder.Text = "Retroceder"
        Me.btnRetroceder.UseVisualStyleBackColor = True
        '
        'txtBuscador
        '
        Me.txtBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscador.Location = New System.Drawing.Point(400, 361)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(202, 30)
        Me.txtBuscador.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(100, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(267, 25)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Buscar Paciente (Cedula):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(100, 630)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 25)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Porcentaje de Mujeres:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 592)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 25)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Porcentaje de Hombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 552)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 25)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Total de contagiados:"
        '
        'dgvPacientesPositivos
        '
        Me.dgvPacientesPositivos.AllowUserToAddRows = False
        Me.dgvPacientesPositivos.AllowUserToDeleteRows = False
        Me.dgvPacientesPositivos.AutoGenerateColumns = False
        Me.dgvPacientesPositivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientesPositivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpacienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.GeneroDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.IdequipoDataGridViewTextBoxColumn})
        Me.dgvPacientesPositivos.DataSource = Me.PacientesBindingSource
        Me.dgvPacientesPositivos.Location = New System.Drawing.Point(68, 113)
        Me.dgvPacientesPositivos.Name = "dgvPacientesPositivos"
        Me.dgvPacientesPositivos.ReadOnly = True
        Me.dgvPacientesPositivos.RowHeadersWidth = 51
        Me.dgvPacientesPositivos.RowTemplate.Height = 24
        Me.dgvPacientesPositivos.Size = New System.Drawing.Size(1027, 225)
        Me.dgvPacientesPositivos.TabIndex = 71
        '
        'Id_pacienteLabel
        '
        Id_pacienteLabel.AutoSize = True
        Id_pacienteLabel.Location = New System.Drawing.Point(113, 417)
        Id_pacienteLabel.Name = "Id_pacienteLabel"
        Id_pacienteLabel.Size = New System.Drawing.Size(81, 17)
        Id_pacienteLabel.TabIndex = 71
        Id_pacienteLabel.Text = "id paciente:"
        '
        'txtIdPaciente
        '
        Me.txtIdPaciente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "id_paciente", True))
        Me.txtIdPaciente.Location = New System.Drawing.Point(200, 414)
        Me.txtIdPaciente.Name = "txtIdPaciente"
        Me.txtIdPaciente.ReadOnly = True
        Me.txtIdPaciente.Size = New System.Drawing.Size(100, 22)
        Me.txtIdPaciente.TabIndex = 72
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
        'IdequipoDataGridViewTextBoxColumn
        '
        Me.IdequipoDataGridViewTextBoxColumn.DataPropertyName = "id_equipo"
        Me.IdequipoDataGridViewTextBoxColumn.HeaderText = "id_equipo"
        Me.IdequipoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdequipoDataGridViewTextBoxColumn.Name = "IdequipoDataGridViewTextBoxColumn"
        Me.IdequipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdequipoDataGridViewTextBoxColumn.Width = 125
        '
        'FinalDes5DataSetBindingSource
        '
        Me.FinalDes5DataSetBindingSource.DataSource = Me.FinalDes5DataSet
        Me.FinalDes5DataSetBindingSource.Position = 0
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
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(113, 446)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(60, 17)
        NombreLabel.TabIndex = 72
        NombreLabel.Text = "nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(200, 446)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(100, 22)
        Me.txtNombre.TabIndex = 73
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(113, 479)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(61, 17)
        ApellidoLabel.TabIndex = 73
        ApellidoLabel.Text = "apellido:"
        '
        'txtApellido
        '
        Me.txtApellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "apellido", True))
        Me.txtApellido.Location = New System.Drawing.Point(200, 479)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ReadOnly = True
        Me.txtApellido.Size = New System.Drawing.Size(100, 22)
        Me.txtApellido.TabIndex = 74
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Location = New System.Drawing.Point(113, 511)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(54, 17)
        CedulaLabel.TabIndex = 74
        CedulaLabel.Text = "cedula:"
        '
        'txtCedula
        '
        Me.txtCedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "cedula", True))
        Me.txtCedula.Location = New System.Drawing.Point(200, 508)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(100, 22)
        Me.txtCedula.TabIndex = 75
        '
        'frmListaPositivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1199, 762)
        Me.Controls.Add(CedulaLabel)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Id_pacienteLabel)
        Me.Controls.Add(Me.txtIdPaciente)
        Me.Controls.Add(Me.dgvPacientesPositivos)
        Me.Controls.Add(Me.lblTotalMujeres)
        Me.Controls.Add(Me.lblTotalHombres)
        Me.Controls.Add(Me.lblPorcentajeMujeres)
        Me.Controls.Add(Me.lblPorcentajeHombres)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnActualizarRecuperado)
        Me.Controls.Add(Me.btnReportesAtencion)
        Me.Controls.Add(Me.btnRastreo)
        Me.Controls.Add(Me.btnRetroceder)
        Me.Controls.Add(Me.txtBuscador)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmListaPositivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.PacientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPacientesPositivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalDes5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalDes5DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents FinalDes5DataSet As finalDes5DataSet
    Friend WithEvents PacientesBindingSource As BindingSource
    Friend WithEvents PacientesTableAdapter As finalDes5DataSetTableAdapters.pacientesTableAdapter
    Friend WithEvents PacientesBindingSource1 As BindingSource
    Friend WithEvents FinalDes5DataSetBindingSource As BindingSource
    Friend WithEvents lblTotalMujeres As Label
    Friend WithEvents lblTotalHombres As Label
    Friend WithEvents lblPorcentajeMujeres As Label
    Friend WithEvents lblPorcentajeHombres As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnActualizarRecuperado As Button
    Friend WithEvents btnReportesAtencion As Button
    Friend WithEvents btnRastreo As Button
    Friend WithEvents btnRetroceder As Button
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableAdapterManager As finalDes5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvPacientesPositivos As DataGridView
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
    Friend WithEvents IdequipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtIdPaciente As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCedula As TextBox
End Class
