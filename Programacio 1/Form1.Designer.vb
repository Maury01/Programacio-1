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
        Me.lblTabla = New System.Windows.Forms.Label()
        Me.txtNTabla = New System.Windows.Forms.TextBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.lstTabla = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblTabla
        '
        Me.lblTabla.AutoSize = True
        Me.lblTabla.Location = New System.Drawing.Point(12, 37)
        Me.lblTabla.Name = "lblTabla"
        Me.lblTabla.Size = New System.Drawing.Size(54, 13)
        Me.lblTabla.TabIndex = 0
        Me.lblTabla.Text = "Tabla del:"
        '
        'txtNTabla
        '
        Me.txtNTabla.Location = New System.Drawing.Point(72, 34)
        Me.txtNTabla.Name = "txtNTabla"
        Me.txtNTabla.Size = New System.Drawing.Size(47, 20)
        Me.txtNTabla.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(26, 60)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(93, 23)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar tabla"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'lstTabla
        '
        Me.lstTabla.FormattingEnabled = True
        Me.lstTabla.Location = New System.Drawing.Point(125, 34)
        Me.lstTabla.Name = "lstTabla"
        Me.lstTabla.Size = New System.Drawing.Size(151, 160)
        Me.lstTabla.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 213)
        Me.Controls.Add(Me.lstTabla)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txtNTabla)
        Me.Controls.Add(Me.lblTabla)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Tabla de multiplicar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTabla As Label
    Friend WithEvents txtNTabla As TextBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents lstTabla As ListBox
End Class
