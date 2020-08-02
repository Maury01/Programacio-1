<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.TxtNum1 = New System.Windows.Forms.TextBox()
        Me.TxtNum2 = New System.Windows.Forms.TextBox()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.optSuma = New System.Windows.Forms.RadioButton()
        Me.optResta = New System.Windows.Forms.RadioButton()
        Me.optDivision = New System.Windows.Forms.RadioButton()
        Me.optPotencia = New System.Windows.Forms.RadioButton()
        Me.optMultiplicacion = New System.Windows.Forms.RadioButton()
        Me.optResiduo = New System.Windows.Forms.RadioButton()
        Me.optPorcentaje = New System.Windows.Forms.RadioButton()
        Me.cbpOperaciones = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(41, 38)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(56, 13)
        Me.lblNum1.TabIndex = 0
        Me.lblNum1.Text = "Numero 1:"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(41, 62)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(56, 13)
        Me.lblNum2.TabIndex = 1
        Me.lblNum2.Text = "Numero 2:"
        '
        'TxtNum1
        '
        Me.TxtNum1.Location = New System.Drawing.Point(103, 35)
        Me.TxtNum1.Name = "TxtNum1"
        Me.TxtNum1.Size = New System.Drawing.Size(71, 20)
        Me.TxtNum1.TabIndex = 2
        '
        'TxtNum2
        '
        Me.TxtNum2.Location = New System.Drawing.Point(103, 59)
        Me.TxtNum2.Name = "TxtNum2"
        Me.TxtNum2.Size = New System.Drawing.Size(71, 20)
        Me.TxtNum2.TabIndex = 3
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuesta.Location = New System.Drawing.Point(49, 265)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(116, 20)
        Me.lblRespuesta.TabIndex = 4
        Me.lblRespuesta.Text = "Respuesta: ?"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(70, 228)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 5
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.Checked = True
        Me.optSuma.Location = New System.Drawing.Point(66, 102)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(31, 17)
        Me.optSuma.TabIndex = 6
        Me.optSuma.TabStop = True
        Me.optSuma.Text = "+"
        Me.optSuma.UseVisualStyleBackColor = True
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.Location = New System.Drawing.Point(113, 102)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(28, 17)
        Me.optResta.TabIndex = 7
        Me.optResta.Text = "-"
        Me.optResta.UseVisualStyleBackColor = True
        '
        'optDivision
        '
        Me.optDivision.AutoSize = True
        Me.optDivision.Location = New System.Drawing.Point(113, 125)
        Me.optDivision.Name = "optDivision"
        Me.optDivision.Size = New System.Drawing.Size(30, 17)
        Me.optDivision.TabIndex = 8
        Me.optDivision.Text = "/"
        Me.optDivision.UseVisualStyleBackColor = True
        '
        'optPotencia
        '
        Me.optPotencia.AutoSize = True
        Me.optPotencia.Location = New System.Drawing.Point(66, 148)
        Me.optPotencia.Name = "optPotencia"
        Me.optPotencia.Size = New System.Drawing.Size(31, 17)
        Me.optPotencia.TabIndex = 9
        Me.optPotencia.Text = "^"
        Me.optPotencia.UseVisualStyleBackColor = True
        '
        'optMultiplicacion
        '
        Me.optMultiplicacion.AutoSize = True
        Me.optMultiplicacion.Location = New System.Drawing.Point(66, 125)
        Me.optMultiplicacion.Name = "optMultiplicacion"
        Me.optMultiplicacion.Size = New System.Drawing.Size(29, 17)
        Me.optMultiplicacion.TabIndex = 10
        Me.optMultiplicacion.Text = "*"
        Me.optMultiplicacion.UseVisualStyleBackColor = True
        '
        'optResiduo
        '
        Me.optResiduo.AutoSize = True
        Me.optResiduo.Location = New System.Drawing.Point(113, 148)
        Me.optResiduo.Name = "optResiduo"
        Me.optResiduo.Size = New System.Drawing.Size(46, 17)
        Me.optResiduo.TabIndex = 11
        Me.optResiduo.Text = "Mod"
        Me.optResiduo.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Location = New System.Drawing.Point(66, 171)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(33, 17)
        Me.optPorcentaje.TabIndex = 12
        Me.optPorcentaje.Text = "%"
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'cbpOperaciones
        '
        Me.cbpOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpOperaciones.FormattingEnabled = True
        Me.cbpOperaciones.Items.AddRange(New Object() {" ", "Suma", "Resta", "Multiplicacion", "Division", "Potenciacion", "Residuo", "Porcentaje"})
        Me.cbpOperaciones.Location = New System.Drawing.Point(53, 194)
        Me.cbpOperaciones.Name = "cbpOperaciones"
        Me.cbpOperaciones.Size = New System.Drawing.Size(121, 21)
        Me.cbpOperaciones.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 295)
        Me.Controls.Add(Me.cbpOperaciones)
        Me.Controls.Add(Me.optPorcentaje)
        Me.Controls.Add(Me.optResiduo)
        Me.Controls.Add(Me.optMultiplicacion)
        Me.Controls.Add(Me.optPotencia)
        Me.Controls.Add(Me.optDivision)
        Me.Controls.Add(Me.optResta)
        Me.Controls.Add(Me.optSuma)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.TxtNum2)
        Me.Controls.Add(Me.TxtNum1)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents TxtNum1 As TextBox
    Friend WithEvents TxtNum2 As TextBox
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents optSuma As RadioButton
    Friend WithEvents optResta As RadioButton
    Friend WithEvents optDivision As RadioButton
    Friend WithEvents optPotencia As RadioButton
    Friend WithEvents optMultiplicacion As RadioButton
    Friend WithEvents optResiduo As RadioButton
    Friend WithEvents optPorcentaje As RadioButton
    Friend WithEvents cbpOperaciones As ComboBox
End Class
