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
        Me.lblNTabla = New System.Windows.Forms.Label()
        Me.lstTabla = New System.Windows.Forms.ListBox()
        Me.txtNTabla = New System.Windows.Forms.TextBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNTabla
        '
        Me.lblNTabla.AutoSize = True
        Me.lblNTabla.Location = New System.Drawing.Point(1, 34)
        Me.lblNTabla.Name = "lblNTabla"
        Me.lblNTabla.Size = New System.Drawing.Size(54, 13)
        Me.lblNTabla.TabIndex = 0
        Me.lblNTabla.Text = "Tabla del:"
        '
        'lstTabla
        '
        Me.lstTabla.FormattingEnabled = True
        Me.lstTabla.Location = New System.Drawing.Point(119, 34)
        Me.lstTabla.Name = "lstTabla"
        Me.lstTabla.Size = New System.Drawing.Size(149, 160)
        Me.lstTabla.TabIndex = 1
        '
        'txtNTabla
        '
        Me.txtNTabla.Location = New System.Drawing.Point(61, 31)
        Me.txtNTabla.Name = "txtNTabla"
        Me.txtNTabla.Size = New System.Drawing.Size(42, 20)
        Me.txtNTabla.TabIndex = 2
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(12, 57)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(91, 23)
        Me.btnGenerar.TabIndex = 3
        Me.btnGenerar.Text = "Generar tabla"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 211)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txtNTabla)
        Me.Controls.Add(Me.lstTabla)
        Me.Controls.Add(Me.lblNTabla)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Tabla de multiplicar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNTabla As Label
    Friend WithEvents lstTabla As ListBox
    Friend WithEvents txtNTabla As TextBox
    Friend WithEvents btnGenerar As Button
End Class
