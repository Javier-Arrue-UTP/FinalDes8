﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecuperados
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
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnMTodos = New System.Windows.Forms.Button()
        Me.txtAp = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblMuj1 = New System.Windows.Forms.Label()
        Me.lblHom1 = New System.Windows.Forms.Label()
        Me.lblTotR = New System.Windows.Forms.Label()
        Me.lblAp1 = New System.Windows.Forms.Label()
        Me.lblNom1 = New System.Windows.Forms.Label()
        Me.lblBuscarP = New System.Windows.Forms.Label()
        Me.dgvRecuperados = New System.Windows.Forms.DataGridView()
        Me.lblTit1 = New System.Windows.Forms.Label()
        Me.lbCantMujeres = New System.Windows.Forms.Label()
        Me.lbPMujeres = New System.Windows.Forms.Label()
        Me.lbCantHombres = New System.Windows.Forms.Label()
        Me.lbPHombres = New System.Windows.Forms.Label()
        Me.lbTotRecuperados = New System.Windows.Forms.Label()
        CType(Me.dgvRecuperados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRegresar.Location = New System.Drawing.Point(710, 367)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(148, 49)
        Me.btnRegresar.TabIndex = 33
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLimpiar.Location = New System.Drawing.Point(75, 446)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(267, 33)
        Me.btnLimpiar.TabIndex = 32
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscar.Location = New System.Drawing.Point(75, 403)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(267, 34)
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnMTodos
        '
        Me.btnMTodos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMTodos.Location = New System.Drawing.Point(709, 292)
        Me.btnMTodos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMTodos.Name = "btnMTodos"
        Me.btnMTodos.Size = New System.Drawing.Size(159, 53)
        Me.btnMTodos.TabIndex = 30
        Me.btnMTodos.Text = "Mostrar Todos"
        Me.btnMTodos.UseVisualStyleBackColor = False
        '
        'txtAp
        '
        Me.txtAp.Location = New System.Drawing.Point(178, 364)
        Me.txtAp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAp.Name = "txtAp"
        Me.txtAp.Size = New System.Drawing.Size(157, 22)
        Me.txtAp.TabIndex = 26
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(178, 313)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(157, 22)
        Me.txtNom.TabIndex = 25
        '
        'lblMuj1
        '
        Me.lblMuj1.AutoSize = True
        Me.lblMuj1.Location = New System.Drawing.Point(61, 625)
        Me.lblMuj1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMuj1.Name = "lblMuj1"
        Me.lblMuj1.Size = New System.Drawing.Size(130, 17)
        Me.lblMuj1.TabIndex = 24
        Me.lblMuj1.Text = "Porcentaje Mujeres"
        '
        'lblHom1
        '
        Me.lblHom1.AutoSize = True
        Me.lblHom1.Location = New System.Drawing.Point(61, 589)
        Me.lblHom1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHom1.Name = "lblHom1"
        Me.lblHom1.Size = New System.Drawing.Size(137, 17)
        Me.lblHom1.TabIndex = 23
        Me.lblHom1.Text = "Porcentaje Hombres"
        '
        'lblTotR
        '
        Me.lblTotR.AutoSize = True
        Me.lblTotR.Location = New System.Drawing.Point(61, 542)
        Me.lblTotR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotR.Name = "lblTotR"
        Me.lblTotR.Size = New System.Drawing.Size(129, 17)
        Me.lblTotR.TabIndex = 22
        Me.lblTotR.Text = "Total Recuperados"
        '
        'lblAp1
        '
        Me.lblAp1.AutoSize = True
        Me.lblAp1.Location = New System.Drawing.Point(72, 367)
        Me.lblAp1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAp1.Name = "lblAp1"
        Me.lblAp1.Size = New System.Drawing.Size(58, 17)
        Me.lblAp1.TabIndex = 21
        Me.lblAp1.Text = "Apellido"
        '
        'lblNom1
        '
        Me.lblNom1.AutoSize = True
        Me.lblNom1.Location = New System.Drawing.Point(72, 317)
        Me.lblNom1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNom1.Name = "lblNom1"
        Me.lblNom1.Size = New System.Drawing.Size(58, 17)
        Me.lblNom1.TabIndex = 20
        Me.lblNom1.Text = "Nombre"
        '
        'lblBuscarP
        '
        Me.lblBuscarP.AutoSize = True
        Me.lblBuscarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarP.Location = New System.Drawing.Point(64, 292)
        Me.lblBuscarP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuscarP.Name = "lblBuscarP"
        Me.lblBuscarP.Size = New System.Drawing.Size(126, 17)
        Me.lblBuscarP.TabIndex = 19
        Me.lblBuscarP.Text = "Buscar Paciente"
        '
        'dgvRecuperados
        '
        Me.dgvRecuperados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecuperados.Location = New System.Drawing.Point(143, 83)
        Me.dgvRecuperados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRecuperados.Name = "dgvRecuperados"
        Me.dgvRecuperados.RowHeadersWidth = 51
        Me.dgvRecuperados.Size = New System.Drawing.Size(715, 186)
        Me.dgvRecuperados.TabIndex = 18
        '
        'lblTit1
        '
        Me.lblTit1.AutoSize = True
        Me.lblTit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit1.Location = New System.Drawing.Point(158, 31)
        Me.lblTit1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTit1.Name = "lblTit1"
        Me.lblTit1.Size = New System.Drawing.Size(649, 52)
        Me.lblTit1.TabIndex = 17
        Me.lblTit1.Text = "Lista de Pacientes Recuperados"
        Me.lblTit1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbCantMujeres
        '
        Me.lbCantMujeres.AutoSize = True
        Me.lbCantMujeres.Location = New System.Drawing.Point(215, 625)
        Me.lbCantMujeres.Name = "lbCantMujeres"
        Me.lbCantMujeres.Size = New System.Drawing.Size(16, 17)
        Me.lbCantMujeres.TabIndex = 56
        Me.lbCantMujeres.Text = "0"
        '
        'lbPMujeres
        '
        Me.lbPMujeres.AutoSize = True
        Me.lbPMujeres.Location = New System.Drawing.Point(267, 626)
        Me.lbPMujeres.Name = "lbPMujeres"
        Me.lbPMujeres.Size = New System.Drawing.Size(16, 17)
        Me.lbPMujeres.TabIndex = 57
        Me.lbPMujeres.Text = "0"
        '
        'lbCantHombres
        '
        Me.lbCantHombres.AutoSize = True
        Me.lbCantHombres.Location = New System.Drawing.Point(215, 594)
        Me.lbCantHombres.Name = "lbCantHombres"
        Me.lbCantHombres.Size = New System.Drawing.Size(16, 17)
        Me.lbCantHombres.TabIndex = 58
        Me.lbCantHombres.Text = "0"
        '
        'lbPHombres
        '
        Me.lbPHombres.AutoSize = True
        Me.lbPHombres.Location = New System.Drawing.Point(267, 594)
        Me.lbPHombres.Name = "lbPHombres"
        Me.lbPHombres.Size = New System.Drawing.Size(16, 17)
        Me.lbPHombres.TabIndex = 59
        Me.lbPHombres.Text = "0"
        '
        'lbTotRecuperados
        '
        Me.lbTotRecuperados.AutoSize = True
        Me.lbTotRecuperados.Location = New System.Drawing.Point(215, 542)
        Me.lbTotRecuperados.Name = "lbTotRecuperados"
        Me.lbTotRecuperados.Size = New System.Drawing.Size(16, 17)
        Me.lbTotRecuperados.TabIndex = 60
        Me.lbTotRecuperados.Text = "0"
        '
        'frmRecuperados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 728)
        Me.Controls.Add(Me.lbTotRecuperados)
        Me.Controls.Add(Me.lbCantMujeres)
        Me.Controls.Add(Me.lbPMujeres)
        Me.Controls.Add(Me.lbCantHombres)
        Me.Controls.Add(Me.lbPHombres)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnMTodos)
        Me.Controls.Add(Me.txtAp)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblMuj1)
        Me.Controls.Add(Me.lblHom1)
        Me.Controls.Add(Me.lblTotR)
        Me.Controls.Add(Me.lblAp1)
        Me.Controls.Add(Me.lblNom1)
        Me.Controls.Add(Me.lblBuscarP)
        Me.Controls.Add(Me.dgvRecuperados)
        Me.Controls.Add(Me.lblTit1)
        Me.Name = "frmRecuperados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form9"
        CType(Me.dgvRecuperados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnMTodos As Button
    Friend WithEvents txtAp As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lblMuj1 As Label
    Friend WithEvents lblHom1 As Label
    Friend WithEvents lblTotR As Label
    Friend WithEvents lblAp1 As Label
    Friend WithEvents lblNom1 As Label
    Friend WithEvents lblBuscarP As Label
    Friend WithEvents dgvRecuperados As DataGridView
    Friend WithEvents lblTit1 As Label
    Friend WithEvents lbCantMujeres As Label
    Friend WithEvents lbPMujeres As Label
    Friend WithEvents lbCantHombres As Label
    Friend WithEvents lbPHombres As Label
    Friend WithEvents lbTotRecuperados As Label
End Class
