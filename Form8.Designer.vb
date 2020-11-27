<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte
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
        Dim Id_pacienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRetroceder = New System.Windows.Forms.Button()
        Me.btnActualizarAtendido = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PacientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalDes5DataSet = New PF_Eq01_tema.finalDes5DataSet()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalDes5DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesTableAdapter = New PF_Eq01_tema.finalDes5DataSetTableAdapters.pacientesTableAdapter()
        Me.TableAdapterManager = New PF_Eq01_tema.finalDes5DataSetTableAdapters.TableAdapterManager()
        Me.txtIdPaciente = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
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
        Me.IdequipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AtendidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdrastreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdpacienteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneroDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbicacionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdequipoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AtendidoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdrastreoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacientesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalDes5DataSet1 = New PF_Eq01_tema.finalDes5DataSet1()
        Me.PacientesTableAdapter1 = New PF_Eq01_tema.finalDes5DataSet1TableAdapters.pacientesTableAdapter()
        Id_pacienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        CedulaLabel = New System.Windows.Forms.Label()
        CType(Me.PacientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalDes5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalDes5DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalDes5DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_pacienteLabel
        '
        Id_pacienteLabel.AutoSize = True
        Id_pacienteLabel.Location = New System.Drawing.Point(369, 407)
        Id_pacienteLabel.Name = "Id_pacienteLabel"
        Id_pacienteLabel.Size = New System.Drawing.Size(81, 17)
        Id_pacienteLabel.TabIndex = 75
        Id_pacienteLabel.Text = "id paciente:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(369, 442)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(60, 17)
        NombreLabel.TabIndex = 76
        NombreLabel.Text = "nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(369, 478)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(61, 17)
        ApellidoLabel.TabIndex = 77
        ApellidoLabel.Text = "apellido:"
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Location = New System.Drawing.Point(369, 516)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(54, 17)
        CedulaLabel.TabIndex = 78
        CedulaLabel.Text = "cedula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(54, 400)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 29)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Paciente seleccionado:"
        '
        'btnRetroceder
        '
        Me.btnRetroceder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetroceder.Location = New System.Drawing.Point(756, 898)
        Me.btnRetroceder.Name = "btnRetroceder"
        Me.btnRetroceder.Size = New System.Drawing.Size(168, 58)
        Me.btnRetroceder.TabIndex = 62
        Me.btnRetroceder.Text = "Retroceder"
        Me.btnRetroceder.UseVisualStyleBackColor = True
        '
        'btnActualizarAtendido
        '
        Me.btnActualizarAtendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarAtendido.Location = New System.Drawing.Point(852, 427)
        Me.btnActualizarAtendido.Name = "btnActualizarAtendido"
        Me.btnActualizarAtendido.Size = New System.Drawing.Size(168, 58)
        Me.btnActualizarAtendido.TabIndex = 61
        Me.btnActualizarAtendido.Text = "Actualizar"
        Me.btnActualizarAtendido.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(98, 561)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 69)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Lista atendidos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(98, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(530, 69)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Lista no atendidos"
        '
        'PacientesBindingSource1
        '
        Me.PacientesBindingSource1.DataMember = "pacientes"
        Me.PacientesBindingSource1.DataSource = Me.FinalDes5DataSet
        '
        'FinalDes5DataSet
        '
        Me.FinalDes5DataSet.DataSetName = "finalDes5DataSet"
        Me.FinalDes5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "pacientes"
        Me.PacientesBindingSource.DataSource = Me.FinalDes5DataSet
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
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.equiposTableAdapter = Nothing
        Me.TableAdapterManager.integrantesTableAdapter = Nothing
        Me.TableAdapterManager.pacientesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PF_Eq01_tema.finalDes5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtIdPaciente
        '
        Me.txtIdPaciente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "id_paciente", True))
        Me.txtIdPaciente.Location = New System.Drawing.Point(456, 407)
        Me.txtIdPaciente.Name = "txtIdPaciente"
        Me.txtIdPaciente.ReadOnly = True
        Me.txtIdPaciente.Size = New System.Drawing.Size(100, 22)
        Me.txtIdPaciente.TabIndex = 76
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(456, 442)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(100, 22)
        Me.txtNombre.TabIndex = 77
        '
        'txtApellido
        '
        Me.txtApellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "apellido", True))
        Me.txtApellido.Location = New System.Drawing.Point(456, 478)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ReadOnly = True
        Me.txtApellido.Size = New System.Drawing.Size(100, 22)
        Me.txtApellido.TabIndex = 78
        '
        'txtCedula
        '
        Me.txtCedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "cedula", True))
        Me.txtCedula.Location = New System.Drawing.Point(456, 516)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(100, 22)
        Me.txtCedula.TabIndex = 79
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpacienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.GeneroDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.IdequipoDataGridViewTextBoxColumn, Me.AtendidoDataGridViewTextBoxColumn, Me.IdrastreoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PacientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(82, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(897, 162)
        Me.DataGridView1.TabIndex = 80
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
        'AtendidoDataGridViewTextBoxColumn
        '
        Me.AtendidoDataGridViewTextBoxColumn.DataPropertyName = "atendido"
        Me.AtendidoDataGridViewTextBoxColumn.HeaderText = "atendido"
        Me.AtendidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AtendidoDataGridViewTextBoxColumn.Name = "AtendidoDataGridViewTextBoxColumn"
        Me.AtendidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AtendidoDataGridViewTextBoxColumn.Width = 125
        '
        'IdrastreoDataGridViewTextBoxColumn
        '
        Me.IdrastreoDataGridViewTextBoxColumn.DataPropertyName = "id_rastreo"
        Me.IdrastreoDataGridViewTextBoxColumn.HeaderText = "id_rastreo"
        Me.IdrastreoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdrastreoDataGridViewTextBoxColumn.Name = "IdrastreoDataGridViewTextBoxColumn"
        Me.IdrastreoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdrastreoDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpacienteDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn1, Me.ApellidoDataGridViewTextBoxColumn1, Me.CedulaDataGridViewTextBoxColumn1, Me.EdadDataGridViewTextBoxColumn1, Me.GeneroDataGridViewTextBoxColumn1, Me.UbicacionDataGridViewTextBoxColumn1, Me.CelularDataGridViewTextBoxColumn1, Me.CorreoDataGridViewTextBoxColumn1, Me.EstadoDataGridViewTextBoxColumn1, Me.IdequipoDataGridViewTextBoxColumn1, Me.AtendidoDataGridViewTextBoxColumn1, Me.IdrastreoDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.PacientesBindingSource2
        Me.DataGridView2.Location = New System.Drawing.Point(82, 707)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(897, 162)
        Me.DataGridView2.TabIndex = 80
        '
        'IdpacienteDataGridViewTextBoxColumn1
        '
        Me.IdpacienteDataGridViewTextBoxColumn1.DataPropertyName = "id_paciente"
        Me.IdpacienteDataGridViewTextBoxColumn1.HeaderText = "id_paciente"
        Me.IdpacienteDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IdpacienteDataGridViewTextBoxColumn1.Name = "IdpacienteDataGridViewTextBoxColumn1"
        Me.IdpacienteDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdpacienteDataGridViewTextBoxColumn1.Width = 125
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        Me.NombreDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn1.Width = 125
        '
        'ApellidoDataGridViewTextBoxColumn1
        '
        Me.ApellidoDataGridViewTextBoxColumn1.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn1.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.ApellidoDataGridViewTextBoxColumn1.Name = "ApellidoDataGridViewTextBoxColumn1"
        Me.ApellidoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ApellidoDataGridViewTextBoxColumn1.Width = 125
        '
        'CedulaDataGridViewTextBoxColumn1
        '
        Me.CedulaDataGridViewTextBoxColumn1.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn1.HeaderText = "cedula"
        Me.CedulaDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.CedulaDataGridViewTextBoxColumn1.Name = "CedulaDataGridViewTextBoxColumn1"
        Me.CedulaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CedulaDataGridViewTextBoxColumn1.Width = 125
        '
        'EdadDataGridViewTextBoxColumn1
        '
        Me.EdadDataGridViewTextBoxColumn1.DataPropertyName = "edad"
        Me.EdadDataGridViewTextBoxColumn1.HeaderText = "edad"
        Me.EdadDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.EdadDataGridViewTextBoxColumn1.Name = "EdadDataGridViewTextBoxColumn1"
        Me.EdadDataGridViewTextBoxColumn1.ReadOnly = True
        Me.EdadDataGridViewTextBoxColumn1.Width = 125
        '
        'GeneroDataGridViewTextBoxColumn1
        '
        Me.GeneroDataGridViewTextBoxColumn1.DataPropertyName = "genero"
        Me.GeneroDataGridViewTextBoxColumn1.HeaderText = "genero"
        Me.GeneroDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.GeneroDataGridViewTextBoxColumn1.Name = "GeneroDataGridViewTextBoxColumn1"
        Me.GeneroDataGridViewTextBoxColumn1.ReadOnly = True
        Me.GeneroDataGridViewTextBoxColumn1.Width = 125
        '
        'UbicacionDataGridViewTextBoxColumn1
        '
        Me.UbicacionDataGridViewTextBoxColumn1.DataPropertyName = "ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn1.HeaderText = "ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.UbicacionDataGridViewTextBoxColumn1.Name = "UbicacionDataGridViewTextBoxColumn1"
        Me.UbicacionDataGridViewTextBoxColumn1.ReadOnly = True
        Me.UbicacionDataGridViewTextBoxColumn1.Width = 125
        '
        'CelularDataGridViewTextBoxColumn1
        '
        Me.CelularDataGridViewTextBoxColumn1.DataPropertyName = "celular"
        Me.CelularDataGridViewTextBoxColumn1.HeaderText = "celular"
        Me.CelularDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.CelularDataGridViewTextBoxColumn1.Name = "CelularDataGridViewTextBoxColumn1"
        Me.CelularDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CelularDataGridViewTextBoxColumn1.Width = 125
        '
        'CorreoDataGridViewTextBoxColumn1
        '
        Me.CorreoDataGridViewTextBoxColumn1.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn1.HeaderText = "correo"
        Me.CorreoDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.CorreoDataGridViewTextBoxColumn1.Name = "CorreoDataGridViewTextBoxColumn1"
        Me.CorreoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CorreoDataGridViewTextBoxColumn1.Width = 125
        '
        'EstadoDataGridViewTextBoxColumn1
        '
        Me.EstadoDataGridViewTextBoxColumn1.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn1.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn1.Name = "EstadoDataGridViewTextBoxColumn1"
        Me.EstadoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn1.Width = 125
        '
        'IdequipoDataGridViewTextBoxColumn1
        '
        Me.IdequipoDataGridViewTextBoxColumn1.DataPropertyName = "id_equipo"
        Me.IdequipoDataGridViewTextBoxColumn1.HeaderText = "id_equipo"
        Me.IdequipoDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IdequipoDataGridViewTextBoxColumn1.Name = "IdequipoDataGridViewTextBoxColumn1"
        Me.IdequipoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdequipoDataGridViewTextBoxColumn1.Width = 125
        '
        'AtendidoDataGridViewTextBoxColumn1
        '
        Me.AtendidoDataGridViewTextBoxColumn1.DataPropertyName = "atendido"
        Me.AtendidoDataGridViewTextBoxColumn1.HeaderText = "atendido"
        Me.AtendidoDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.AtendidoDataGridViewTextBoxColumn1.Name = "AtendidoDataGridViewTextBoxColumn1"
        Me.AtendidoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.AtendidoDataGridViewTextBoxColumn1.Width = 125
        '
        'IdrastreoDataGridViewTextBoxColumn1
        '
        Me.IdrastreoDataGridViewTextBoxColumn1.DataPropertyName = "id_rastreo"
        Me.IdrastreoDataGridViewTextBoxColumn1.HeaderText = "id_rastreo"
        Me.IdrastreoDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IdrastreoDataGridViewTextBoxColumn1.Name = "IdrastreoDataGridViewTextBoxColumn1"
        Me.IdrastreoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdrastreoDataGridViewTextBoxColumn1.Width = 125
        '
        'PacientesBindingSource2
        '
        Me.PacientesBindingSource2.DataMember = "pacientes"
        Me.PacientesBindingSource2.DataSource = Me.FinalDes5DataSet1
        '
        'FinalDes5DataSet1
        '
        Me.FinalDes5DataSet1.DataSetName = "finalDes5DataSet1"
        Me.FinalDes5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PacientesTableAdapter1
        '
        Me.PacientesTableAdapter1.ClearBeforeFill = True
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 1055)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(CedulaLabel)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Id_pacienteLabel)
        Me.Controls.Add(Me.txtIdPaciente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRetroceder)
        Me.Controls.Add(Me.btnActualizarAtendido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PacientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalDes5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalDes5DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalDes5DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRetroceder As Button
    Friend WithEvents btnActualizarAtendido As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FinalDes5DataSetBindingSource As BindingSource
    Friend WithEvents FinalDes5DataSet As finalDes5DataSet
    Friend WithEvents PacientesBindingSource As BindingSource
    Friend WithEvents PacientesTableAdapter As finalDes5DataSetTableAdapters.pacientesTableAdapter
    Friend WithEvents TableAdapterManager As finalDes5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtIdPaciente As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents PacientesBindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents AtendidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdrastreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents IdpacienteDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GeneroDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdequipoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AtendidoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdrastreoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FinalDes5DataSet1 As finalDes5DataSet1
    Friend WithEvents PacientesBindingSource2 As BindingSource
    Friend WithEvents PacientesTableAdapter1 As finalDes5DataSet1TableAdapters.pacientesTableAdapter
End Class
