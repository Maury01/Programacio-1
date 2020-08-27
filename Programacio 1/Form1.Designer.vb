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
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.lblInteres = New System.Windows.Forms.Label()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.lblInteresSimple = New System.Windows.Forms.Label()
        Me.lblInteresCompuesto = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCapital
        '
        Me.lblCapital.AutoSize = True
        Me.lblCapital.Location = New System.Drawing.Point(45, 75)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(42, 13)
        Me.lblCapital.TabIndex = 0
        Me.lblCapital.Text = "Capital:"
        '
        'lblInteres
        '
        Me.lblInteres.AutoSize = True
        Me.lblInteres.Location = New System.Drawing.Point(198, 75)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(42, 13)
        Me.lblInteres.TabIndex = 1
        Me.lblInteres.Text = "Interes:"
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Location = New System.Drawing.Point(316, 75)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(45, 13)
        Me.lblTiempo.TabIndex = 2
        Me.lblTiempo.Text = "Tiempo:"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(93, 72)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(83, 20)
        Me.txtCapital.TabIndex = 3
        '
        'txtInteres
        '
        Me.txtInteres.Location = New System.Drawing.Point(262, 72)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(48, 20)
        Me.txtInteres.TabIndex = 4
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(367, 72)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(53, 20)
        Me.txtTiempo.TabIndex = 5
        '
        'lblInteresSimple
        '
        Me.lblInteresSimple.AutoSize = True
        Me.lblInteresSimple.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInteresSimple.Location = New System.Drawing.Point(111, 130)
        Me.lblInteresSimple.Name = "lblInteresSimple"
        Me.lblInteresSimple.Size = New System.Drawing.Size(120, 16)
        Me.lblInteresSimple.TabIndex = 6
        Me.lblInteresSimple.Text = "Interer Simple: ?"
        '
        'lblInteresCompuesto
        '
        Me.lblInteresCompuesto.AutoSize = True
        Me.lblInteresCompuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInteresCompuesto.Location = New System.Drawing.Point(90, 161)
        Me.lblInteresCompuesto.Name = "lblInteresCompuesto"
        Me.lblInteresCompuesto.Size = New System.Drawing.Size(141, 16)
        Me.lblInteresCompuesto.TabIndex = 7
        Me.lblInteresCompuesto.Text = "Interes Copuesto: ?"
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(201, 197)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(86, 28)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 244)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblInteresCompuesto)
        Me.Controls.Add(Me.lblInteresSimple)
        Me.Controls.Add(Me.txtTiempo)
        Me.Controls.Add(Me.txtInteres)
        Me.Controls.Add(Me.txtCapital)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.lblInteres)
        Me.Controls.Add(Me.lblCapital)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Ejercicio Interes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCapital As Label
    Friend WithEvents lblInteres As Label
    Friend WithEvents lblTiempo As Label
    Friend WithEvents txtCapital As TextBox
    Friend WithEvents txtInteres As TextBox
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents lblInteresSimple As Label
    Friend WithEvents lblInteresCompuesto As Label
    Friend WithEvents btnCalcular As Button
End Class
