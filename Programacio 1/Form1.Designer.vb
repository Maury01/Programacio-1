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
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(70, 35)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(47, 13)
        Me.lblNumero.TabIndex = 0
        Me.lblNumero.Text = "Número:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(118, 32)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(83, 20)
        Me.txtNumero.TabIndex = 3
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuesta.Location = New System.Drawing.Point(207, 35)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(28, 16)
        Me.lblRespuesta.TabIndex = 6
        Me.lblRespuesta.Text = "= ?"
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(156, 85)
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
        Me.ClientSize = New System.Drawing.Size(305, 138)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblNumero)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Ejercicio Interes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumero As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents btnCalcular As Button
End Class
