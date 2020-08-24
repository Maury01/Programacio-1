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
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.grdEstadistica = New System.Windows.Forms.DataGridView()
        Me.X1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X1xF1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X21xF1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.lblRespuestaMedia = New System.Windows.Forms.Label()
        Me.lblRespuetaVarianza = New System.Windows.Forms.Label()
        Me.lblVarianza = New System.Windows.Forms.Label()
        Me.lblRespuestaDesvTipica = New System.Windows.Forms.Label()
        Me.lblDesvTipica = New System.Windows.Forms.Label()
        Me.lblTotalF1 = New System.Windows.Forms.Label()
        Me.lblTotalX1xF1 = New System.Windows.Forms.Label()
        Me.lblTotalX21xF1 = New System.Windows.Forms.Label()
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(25, 30)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(34, 13)
        Me.lblSerie.TabIndex = 0
        Me.lblSerie.Text = "Serie:"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(65, 27)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(128, 20)
        Me.txtSerie.TabIndex = 1
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(28, 177)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(118, 32)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular serie"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'grdEstadistica
        '
        Me.grdEstadistica.AllowUserToDeleteRows = False
        Me.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEstadistica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.X1, Me.F1, Me.N1, Me.X1xF1, Me.X21xF1})
        Me.grdEstadistica.Location = New System.Drawing.Point(199, 27)
        Me.grdEstadistica.Name = "grdEstadistica"
        Me.grdEstadistica.Size = New System.Drawing.Size(538, 309)
        Me.grdEstadistica.TabIndex = 3
        '
        'X1
        '
        Me.X1.HeaderText = "X1"
        Me.X1.Name = "X1"
        '
        'F1
        '
        Me.F1.HeaderText = "F1"
        Me.F1.Name = "F1"
        '
        'N1
        '
        Me.N1.HeaderText = "N1"
        Me.N1.Name = "N1"
        '
        'X1xF1
        '
        Me.X1xF1.HeaderText = "X1xF1"
        Me.X1xF1.Name = "X1xF1"
        '
        'X21xF1
        '
        Me.X21xF1.HeaderText = "X21xF1"
        Me.X21xF1.Name = "X21xF1"
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Location = New System.Drawing.Point(25, 74)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(39, 13)
        Me.lblMedia.TabIndex = 4
        Me.lblMedia.Text = "Media:"
        '
        'lblRespuestaMedia
        '
        Me.lblRespuestaMedia.AutoSize = True
        Me.lblRespuestaMedia.Location = New System.Drawing.Point(101, 74)
        Me.lblRespuestaMedia.Name = "lblRespuestaMedia"
        Me.lblRespuestaMedia.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaMedia.TabIndex = 5
        Me.lblRespuestaMedia.Text = "?"
        '
        'lblRespuetaVarianza
        '
        Me.lblRespuetaVarianza.AutoSize = True
        Me.lblRespuetaVarianza.Location = New System.Drawing.Point(101, 112)
        Me.lblRespuetaVarianza.Name = "lblRespuetaVarianza"
        Me.lblRespuetaVarianza.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuetaVarianza.TabIndex = 7
        Me.lblRespuetaVarianza.Text = "?"
        '
        'lblVarianza
        '
        Me.lblVarianza.AutoSize = True
        Me.lblVarianza.Location = New System.Drawing.Point(25, 112)
        Me.lblVarianza.Name = "lblVarianza"
        Me.lblVarianza.Size = New System.Drawing.Size(51, 13)
        Me.lblVarianza.TabIndex = 6
        Me.lblVarianza.Text = "Varianza:"
        '
        'lblRespuestaDesvTipica
        '
        Me.lblRespuestaDesvTipica.AutoSize = True
        Me.lblRespuestaDesvTipica.Location = New System.Drawing.Point(101, 148)
        Me.lblRespuestaDesvTipica.Name = "lblRespuestaDesvTipica"
        Me.lblRespuestaDesvTipica.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaDesvTipica.TabIndex = 9
        Me.lblRespuestaDesvTipica.Text = "?"
        '
        'lblDesvTipica
        '
        Me.lblDesvTipica.AutoSize = True
        Me.lblDesvTipica.Location = New System.Drawing.Point(25, 148)
        Me.lblDesvTipica.Name = "lblDesvTipica"
        Me.lblDesvTipica.Size = New System.Drawing.Size(70, 13)
        Me.lblDesvTipica.TabIndex = 8
        Me.lblDesvTipica.Text = "Desv. Tipica:"
        '
        'lblTotalF1
        '
        Me.lblTotalF1.AutoSize = True
        Me.lblTotalF1.Location = New System.Drawing.Point(390, 339)
        Me.lblTotalF1.Name = "lblTotalF1"
        Me.lblTotalF1.Size = New System.Drawing.Size(28, 13)
        Me.lblTotalF1.TabIndex = 10
        Me.lblTotalF1.Text = "0.00"
        '
        'lblTotalX1xF1
        '
        Me.lblTotalX1xF1.AutoSize = True
        Me.lblTotalX1xF1.Location = New System.Drawing.Point(592, 339)
        Me.lblTotalX1xF1.Name = "lblTotalX1xF1"
        Me.lblTotalX1xF1.Size = New System.Drawing.Size(28, 13)
        Me.lblTotalX1xF1.TabIndex = 11
        Me.lblTotalX1xF1.Text = "0.00"
        '
        'lblTotalX21xF1
        '
        Me.lblTotalX21xF1.AutoSize = True
        Me.lblTotalX21xF1.Location = New System.Drawing.Point(688, 339)
        Me.lblTotalX21xF1.Name = "lblTotalX21xF1"
        Me.lblTotalX21xF1.Size = New System.Drawing.Size(28, 13)
        Me.lblTotalX21xF1.TabIndex = 12
        Me.lblTotalX21xF1.Text = "0.00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 380)
        Me.Controls.Add(Me.lblTotalX21xF1)
        Me.Controls.Add(Me.lblTotalX1xF1)
        Me.Controls.Add(Me.lblTotalF1)
        Me.Controls.Add(Me.lblRespuestaDesvTipica)
        Me.Controls.Add(Me.lblDesvTipica)
        Me.Controls.Add(Me.lblRespuetaVarianza)
        Me.Controls.Add(Me.lblVarianza)
        Me.Controls.Add(Me.lblRespuestaMedia)
        Me.Controls.Add(Me.lblMedia)
        Me.Controls.Add(Me.grdEstadistica)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.lblSerie)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Matrices y POO"
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSerie As Label
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents grdEstadistica As DataGridView
    Friend WithEvents X1 As DataGridViewTextBoxColumn
    Friend WithEvents F1 As DataGridViewTextBoxColumn
    Friend WithEvents N1 As DataGridViewTextBoxColumn
    Friend WithEvents X1xF1 As DataGridViewTextBoxColumn
    Friend WithEvents X21xF1 As DataGridViewTextBoxColumn
    Friend WithEvents lblMedia As Label
    Friend WithEvents lblRespuestaMedia As Label
    Friend WithEvents lblRespuetaVarianza As Label
    Friend WithEvents lblVarianza As Label
    Friend WithEvents lblRespuestaDesvTipica As Label
    Friend WithEvents lblDesvTipica As Label
    Friend WithEvents lblTotalF1 As Label
    Friend WithEvents lblTotalX1xF1 As Label
    Friend WithEvents lblTotalX21xF1 As Label
End Class
