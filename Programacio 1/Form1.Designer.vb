<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.cboDepartamento = New System.Windows.Forms.ComboBox()
        Me.cboMunicipio = New System.Windows.Forms.ComboBox()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboDepartamento
        '
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.Location = New System.Drawing.Point(12, 48)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(121, 21)
        Me.cboDepartamento.TabIndex = 0
        '
        'cboMunicipio
        '
        Me.cboMunicipio.FormattingEnabled = True
        Me.cboMunicipio.Location = New System.Drawing.Point(180, 48)
        Me.cboMunicipio.Name = "cboMunicipio"
        Me.cboMunicipio.Size = New System.Drawing.Size(121, 21)
        Me.cboMunicipio.TabIndex = 1
        '
        'cboArea
        '
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(342, 48)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(121, 21)
        Me.cboArea.TabIndex = 2
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(40, 25)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(77, 13)
        Me.lblDepartamento.TabIndex = 3
        Me.lblDepartamento.Text = "Departamento:"
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Location = New System.Drawing.Point(221, 25)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(55, 13)
        Me.lblMunicipio.TabIndex = 4
        Me.lblMunicipio.Text = "Municipio:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(392, 25)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(32, 13)
        Me.lblArea.TabIndex = 5
        Me.lblArea.Text = "Area:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 138)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblMunicipio)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.cboMunicipio)
        Me.Controls.Add(Me.cboDepartamento)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Combos Dinamicos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboDepartamento As ComboBox
    Friend WithEvents cboMunicipio As ComboBox
    Friend WithEvents cboArea As ComboBox
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents lblArea As Label
End Class
