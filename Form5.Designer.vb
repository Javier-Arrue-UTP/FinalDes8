<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListaNegativos
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvNegativos = New System.Windows.Forms.DataGridView()
        Me.txtLimpiar = New System.Windows.Forms.Button()
        Me.lblAp = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtAp = New System.Windows.Forms.TextBox()
        Me.btnRet = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblMuj = New System.Windows.Forms.Label()
        Me.lblHom = New System.Windows.Forms.Label()
        Me.lblTotN = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lbTotNeg = New System.Windows.Forms.Label()
        Me.lbPHombres = New System.Windows.Forms.Label()
        Me.lbPMujeres = New System.Windows.Forms.Label()
        Me.lbCantHombres = New System.Windows.Forms.Label()
        Me.lbCantMujeres = New System.Windows.Forms.Label()
        Me.FinalDes5DataSet = New PF_Eq01_tema.finalDes5DataSet()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesTableAdapter = New PF_Eq01_tema.finalDes5DataSetTableAdapters.pacientesTableAdapter()
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
        CType(Me.dgvNegativos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalDes5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(124, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(825, 69)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Lista de Pacientes Negativos"
        '
        'dgvNegativos
        '
        Me.dgvNegativos.AllowUserToAddRows = False
        Me.dgvNegativos.AllowUserToDeleteRows = False
        Me.dgvNegativos.AutoGenerateColumns = False
        Me.dgvNegativos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNegativos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpacienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.GeneroDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.dgvNegativos.DataSource = Me.PacientesBindingSource
        Me.dgvNegativos.Location = New System.Drawing.Point(125, 124)
        Me.dgvNegativos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvNegativos.Name = "dgvNegativos"
        Me.dgvNegativos.ReadOnly = True
        Me.dgvNegativos.RowHeadersWidth = 51
        Me.dgvNegativos.Size = New System.Drawing.Size(852, 247)
        Me.dgvNegativos.TabIndex = 39
        '
        'txtLimpiar
        '
        Me.txtLimpiar.Location = New System.Drawing.Point(778, 511)
        Me.txtLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLimpiar.Name = "txtLimpiar"
        Me.txtLimpiar.Size = New System.Drawing.Size(199, 25)
        Me.txtLimpiar.TabIndex = 54
        Me.txtLimpiar.Text = "Limpiar"
        Me.txtLimpiar.UseVisualStyleBackColor = True
        '
        'lblAp
        '
        Me.lblAp.AutoSize = True
        Me.lblAp.Location = New System.Drawing.Point(765, 450)
        Me.lblAp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAp.Name = "lblAp"
        Me.lblAp.Size = New System.Drawing.Size(58, 17)
        Me.lblAp.TabIndex = 53
        Me.lblAp.Text = "Apellido"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(765, 418)
        Me.lblNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(58, 17)
        Me.lblNom.TabIndex = 52
        Me.lblNom.Text = "Nombre"
        '
        'txtAp
        '
        Me.txtAp.Location = New System.Drawing.Point(832, 446)
        Me.txtAp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAp.Name = "txtAp"
        Me.txtAp.Size = New System.Drawing.Size(132, 22)
        Me.txtAp.TabIndex = 51
        '
        'btnRet
        '
        Me.btnRet.Location = New System.Drawing.Point(781, 578)
        Me.btnRet.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRet.Name = "btnRet"
        Me.btnRet.Size = New System.Drawing.Size(196, 39)
        Me.btnRet.TabIndex = 50
        Me.btnRet.Text = "Retroceder"
        Me.btnRet.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(778, 477)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(199, 26)
        Me.btnBuscar.TabIndex = 49
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblMuj
        '
        Me.lblMuj.AutoSize = True
        Me.lblMuj.Location = New System.Drawing.Point(122, 486)
        Me.lblMuj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMuj.Name = "lblMuj"
        Me.lblMuj.Size = New System.Drawing.Size(130, 17)
        Me.lblMuj.TabIndex = 44
        Me.lblMuj.Text = "Porcentaje Mujeres"
        '
        'lblHom
        '
        Me.lblHom.AutoSize = True
        Me.lblHom.Location = New System.Drawing.Point(115, 454)
        Me.lblHom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHom.Name = "lblHom"
        Me.lblHom.Size = New System.Drawing.Size(137, 17)
        Me.lblHom.TabIndex = 43
        Me.lblHom.Text = "Porcentaje Hombres"
        '
        'lblTotN
        '
        Me.lblTotN.AutoSize = True
        Me.lblTotN.Location = New System.Drawing.Point(143, 422)
        Me.lblTotN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotN.Name = "lblTotN"
        Me.lblTotN.Size = New System.Drawing.Size(107, 17)
        Me.lblTotN.TabIndex = 42
        Me.lblTotN.Text = "Total Negativos"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(832, 414)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(132, 22)
        Me.txtNom.TabIndex = 41
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(666, 391)
        Me.lblBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(126, 17)
        Me.lblBuscar.TabIndex = 40
        Me.lblBuscar.Text = "Buscar Paciente"
        '
        'lbTotNeg
        '
        Me.lbTotNeg.AutoSize = True
        Me.lbTotNeg.Location = New System.Drawing.Point(268, 422)
        Me.lbTotNeg.Name = "lbTotNeg"
        Me.lbTotNeg.Size = New System.Drawing.Size(16, 17)
        Me.lbTotNeg.TabIndex = 55
        Me.lbTotNeg.Text = "0"
        '
        'lbPHombres
        '
        Me.lbPHombres.AutoSize = True
        Me.lbPHombres.Location = New System.Drawing.Point(320, 454)
        Me.lbPHombres.Name = "lbPHombres"
        Me.lbPHombres.Size = New System.Drawing.Size(16, 17)
        Me.lbPHombres.TabIndex = 55
        Me.lbPHombres.Text = "0"
        '
        'lbPMujeres
        '
        Me.lbPMujeres.AutoSize = True
        Me.lbPMujeres.Location = New System.Drawing.Point(320, 486)
        Me.lbPMujeres.Name = "lbPMujeres"
        Me.lbPMujeres.Size = New System.Drawing.Size(16, 17)
        Me.lbPMujeres.TabIndex = 55
        Me.lbPMujeres.Text = "0"
        '
        'lbCantHombres
        '
        Me.lbCantHombres.AutoSize = True
        Me.lbCantHombres.Location = New System.Drawing.Point(268, 454)
        Me.lbCantHombres.Name = "lbCantHombres"
        Me.lbCantHombres.Size = New System.Drawing.Size(16, 17)
        Me.lbCantHombres.TabIndex = 55
        Me.lbCantHombres.Text = "0"
        '
        'lbCantMujeres
        '
        Me.lbCantMujeres.AutoSize = True
        Me.lbCantMujeres.Location = New System.Drawing.Point(268, 485)
        Me.lbCantMujeres.Name = "lbCantMujeres"
        Me.lbCantMujeres.Size = New System.Drawing.Size(16, 17)
        Me.lbCantMujeres.TabIndex = 55
        Me.lbCantMujeres.Text = "0"
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
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
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
        'frmListaNegativos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1095, 657)
        Me.Controls.Add(Me.lbCantMujeres)
        Me.Controls.Add(Me.lbPMujeres)
        Me.Controls.Add(Me.lbCantHombres)
        Me.Controls.Add(Me.lbPHombres)
        Me.Controls.Add(Me.lbTotNeg)
        Me.Controls.Add(Me.txtLimpiar)
        Me.Controls.Add(Me.lblAp)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtAp)
        Me.Controls.Add(Me.btnRet)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblMuj)
        Me.Controls.Add(Me.lblHom)
        Me.Controls.Add(Me.lblTotN)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.dgvNegativos)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmListaNegativos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        CType(Me.dgvNegativos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalDes5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvNegativos As DataGridView
    Friend WithEvents txtLimpiar As Button
    Friend WithEvents lblAp As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents txtAp As TextBox
    Friend WithEvents btnRet As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblMuj As Label
    Friend WithEvents lblHom As Label
    Friend WithEvents lblTotN As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lbTotNeg As Label
    Friend WithEvents lbPHombres As Label
    Friend WithEvents lbPMujeres As Label
    Friend WithEvents lbCantHombres As Label
    Friend WithEvents lbCantMujeres As Label
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
End Class
