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
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.cboMoneda1 = New System.Windows.Forms.ComboBox()
        Me.txtCantMoneda = New System.Windows.Forms.TextBox()
        Me.txtResultadoMoneda = New System.Windows.Forms.TextBox()
        Me.cboMoneda2 = New System.Windows.Forms.ComboBox()
        Me.btnConvertirMoneda = New System.Windows.Forms.Button()
        Me.btnConvertirVolumen = New System.Windows.Forms.Button()
        Me.cboVolumen2 = New System.Windows.Forms.ComboBox()
        Me.txtResultadoVolumen = New System.Windows.Forms.TextBox()
        Me.txtCantVolumen = New System.Windows.Forms.TextBox()
        Me.cboVolumen1 = New System.Windows.Forms.ComboBox()
        Me.lblVolumen = New System.Windows.Forms.Label()
        Me.btnConvertirAlmacenamiento = New System.Windows.Forms.Button()
        Me.cboAlmacenamiento2 = New System.Windows.Forms.ComboBox()
        Me.txtResultadoAlmacenamiento = New System.Windows.Forms.TextBox()
        Me.txtCantAlmacenamiento = New System.Windows.Forms.TextBox()
        Me.cboAlmacenamiento1 = New System.Windows.Forms.ComboBox()
        Me.lblAlmacenamiento = New System.Windows.Forms.Label()
        Me.btnConvertirMasa = New System.Windows.Forms.Button()
        Me.cboMasa2 = New System.Windows.Forms.ComboBox()
        Me.txtResultadoMasa = New System.Windows.Forms.TextBox()
        Me.txtCantMasa = New System.Windows.Forms.TextBox()
        Me.cboMasa1 = New System.Windows.Forms.ComboBox()
        Me.lblMasa = New System.Windows.Forms.Label()
        Me.btmConvertirLongitud = New System.Windows.Forms.Button()
        Me.cboLongitud2 = New System.Windows.Forms.ComboBox()
        Me.txtResultadoLongitud = New System.Windows.Forms.TextBox()
        Me.txtCantLongitud = New System.Windows.Forms.TextBox()
        Me.cboLongitud1 = New System.Windows.Forms.ComboBox()
        Me.lblLongitud = New System.Windows.Forms.Label()
        Me.btnConvertirTiempo = New System.Windows.Forms.Button()
        Me.cboTiempo2 = New System.Windows.Forms.ComboBox()
        Me.txtResultadoTiempo = New System.Windows.Forms.TextBox()
        Me.txtCantTiempo = New System.Windows.Forms.TextBox()
        Me.cboTiempo1 = New System.Windows.Forms.ComboBox()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoneda.Location = New System.Drawing.Point(138, 9)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(82, 20)
        Me.lblMoneda.TabIndex = 0
        Me.lblMoneda.Text = "Monedas"
        '
        'cboMoneda1
        '
        Me.cboMoneda1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda1.FormattingEnabled = True
        Me.cboMoneda1.Items.AddRange(New Object() {"", "Dolar Estadounidense", "Euro", "Yen", "Colon de El Salvador", "Bitcoin", "Soles", "Peso Mexicano", "Libra Esterlina", "Dolar Canadiense", "Yuan"})
        Me.cboMoneda1.Location = New System.Drawing.Point(29, 68)
        Me.cboMoneda1.Name = "cboMoneda1"
        Me.cboMoneda1.Size = New System.Drawing.Size(100, 21)
        Me.cboMoneda1.TabIndex = 1
        '
        'txtCantMoneda
        '
        Me.txtCantMoneda.Location = New System.Drawing.Point(29, 42)
        Me.txtCantMoneda.Name = "txtCantMoneda"
        Me.txtCantMoneda.Size = New System.Drawing.Size(100, 20)
        Me.txtCantMoneda.TabIndex = 2
        '
        'txtResultadoMoneda
        '
        Me.txtResultadoMoneda.Enabled = False
        Me.txtResultadoMoneda.Location = New System.Drawing.Point(228, 42)
        Me.txtResultadoMoneda.Name = "txtResultadoMoneda"
        Me.txtResultadoMoneda.Size = New System.Drawing.Size(100, 20)
        Me.txtResultadoMoneda.TabIndex = 3
        '
        'cboMoneda2
        '
        Me.cboMoneda2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda2.FormattingEnabled = True
        Me.cboMoneda2.Items.AddRange(New Object() {"", "Dolar Estadounidense", "Euro", "Yen", "Colon de El Salvador", "Bitcoin", "Sol Peruano", "Peso Mexicano", "Libra Esterlina", "Dolar Canadiense", "Yuan"})
        Me.cboMoneda2.Location = New System.Drawing.Point(228, 68)
        Me.cboMoneda2.Name = "cboMoneda2"
        Me.cboMoneda2.Size = New System.Drawing.Size(100, 21)
        Me.cboMoneda2.TabIndex = 4
        '
        'btnConvertirMoneda
        '
        Me.btnConvertirMoneda.Location = New System.Drawing.Point(142, 53)
        Me.btnConvertirMoneda.Name = "btnConvertirMoneda"
        Me.btnConvertirMoneda.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertirMoneda.TabIndex = 5
        Me.btnConvertirMoneda.Text = "Convertir"
        Me.btnConvertirMoneda.UseVisualStyleBackColor = True
        '
        'btnConvertirVolumen
        '
        Me.btnConvertirVolumen.Location = New System.Drawing.Point(142, 158)
        Me.btnConvertirVolumen.Name = "btnConvertirVolumen"
        Me.btnConvertirVolumen.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertirVolumen.TabIndex = 11
        Me.btnConvertirVolumen.Text = "Convertir"
        Me.btnConvertirVolumen.UseVisualStyleBackColor = True
        '
        'cboVolumen2
        '
        Me.cboVolumen2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVolumen2.FormattingEnabled = True
        Me.cboVolumen2.Items.AddRange(New Object() {"", "Cucharadita EEUU", "Cucharada eeuu", "Pulgada Cubica", "Taza EEUU", "Onza Liquida EEUU", "Mililitro", "Litro", "Pie Cubico", "Galon EEUU", "Metro Cubico"})
        Me.cboVolumen2.Location = New System.Drawing.Point(228, 173)
        Me.cboVolumen2.Name = "cboVolumen2"
        Me.cboVolumen2.Size = New System.Drawing.Size(100, 21)
        Me.cboVolumen2.TabIndex = 10
        '
        'txtResultadoVolumen
        '
        Me.txtResultadoVolumen.Enabled = False
        Me.txtResultadoVolumen.Location = New System.Drawing.Point(228, 147)
        Me.txtResultadoVolumen.Name = "txtResultadoVolumen"
        Me.txtResultadoVolumen.Size = New System.Drawing.Size(100, 20)
        Me.txtResultadoVolumen.TabIndex = 9
        '
        'txtCantVolumen
        '
        Me.txtCantVolumen.Location = New System.Drawing.Point(29, 147)
        Me.txtCantVolumen.Name = "txtCantVolumen"
        Me.txtCantVolumen.Size = New System.Drawing.Size(100, 20)
        Me.txtCantVolumen.TabIndex = 8
        '
        'cboVolumen1
        '
        Me.cboVolumen1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVolumen1.FormattingEnabled = True
        Me.cboVolumen1.Items.AddRange(New Object() {"", "Cucharadita EEUU", "Cucharada eeuu", "Pulgada Cubica", "Taza EEUU", "Onza Liquida EEUU", "Mililitro", "Litro", "Pie Cubico", "Galon EEUU", "Metro Cubico"})
        Me.cboVolumen1.Location = New System.Drawing.Point(29, 173)
        Me.cboVolumen1.Name = "cboVolumen1"
        Me.cboVolumen1.Size = New System.Drawing.Size(100, 21)
        Me.cboVolumen1.TabIndex = 7
        '
        'lblVolumen
        '
        Me.lblVolumen.AutoSize = True
        Me.lblVolumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolumen.Location = New System.Drawing.Point(141, 114)
        Me.lblVolumen.Name = "lblVolumen"
        Me.lblVolumen.Size = New System.Drawing.Size(79, 20)
        Me.lblVolumen.TabIndex = 6
        Me.lblVolumen.Text = "Volumen"
        '
        'btnConvertirAlmacenamiento
        '
        Me.btnConvertirAlmacenamiento.Location = New System.Drawing.Point(145, 263)
        Me.btnConvertirAlmacenamiento.Name = "btnConvertirAlmacenamiento"
        Me.btnConvertirAlmacenamiento.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertirAlmacenamiento.TabIndex = 17
        Me.btnConvertirAlmacenamiento.Text = "Convertir"
        Me.btnConvertirAlmacenamiento.UseVisualStyleBackColor = True
        '
        'cboAlmacenamiento2
        '
        Me.cboAlmacenamiento2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacenamiento2.FormattingEnabled = True
        Me.cboAlmacenamiento2.Items.AddRange(New Object() {"", "Bit", "Byte", "Kilobyte", "Megabyte", "Gigabyte", "Terabyte", "Petabyte", "Exabyte", "Zettabyte", "YottaByte"})
        Me.cboAlmacenamiento2.Location = New System.Drawing.Point(231, 278)
        Me.cboAlmacenamiento2.Name = "cboAlmacenamiento2"
        Me.cboAlmacenamiento2.Size = New System.Drawing.Size(100, 21)
        Me.cboAlmacenamiento2.TabIndex = 16
        '
        'txtResultadoAlmacenamiento
        '
        Me.txtResultadoAlmacenamiento.Enabled = False
        Me.txtResultadoAlmacenamiento.Location = New System.Drawing.Point(231, 252)
        Me.txtResultadoAlmacenamiento.Name = "txtResultadoAlmacenamiento"
        Me.txtResultadoAlmacenamiento.Size = New System.Drawing.Size(100, 20)
        Me.txtResultadoAlmacenamiento.TabIndex = 15
        '
        'txtCantAlmacenamiento
        '
        Me.txtCantAlmacenamiento.Location = New System.Drawing.Point(32, 252)
        Me.txtCantAlmacenamiento.Name = "txtCantAlmacenamiento"
        Me.txtCantAlmacenamiento.Size = New System.Drawing.Size(100, 20)
        Me.txtCantAlmacenamiento.TabIndex = 14
        '
        'cboAlmacenamiento1
        '
        Me.cboAlmacenamiento1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacenamiento1.FormattingEnabled = True
        Me.cboAlmacenamiento1.Items.AddRange(New Object() {"", "Bit", "Byte", "Kilobyte", "Megabyte", "Gigabyte", "Terabyte", "Petabyte", "Exabyte", "Zettabyte", "YottaByte"})
        Me.cboAlmacenamiento1.Location = New System.Drawing.Point(32, 278)
        Me.cboAlmacenamiento1.Name = "cboAlmacenamiento1"
        Me.cboAlmacenamiento1.Size = New System.Drawing.Size(100, 21)
        Me.cboAlmacenamiento1.TabIndex = 13
        '
        'lblAlmacenamiento
        '
        Me.lblAlmacenamiento.AutoSize = True
        Me.lblAlmacenamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlmacenamiento.Location = New System.Drawing.Point(113, 219)
        Me.lblAlmacenamiento.Name = "lblAlmacenamiento"
        Me.lblAlmacenamiento.Size = New System.Drawing.Size(142, 20)
        Me.lblAlmacenamiento.TabIndex = 12
        Me.lblAlmacenamiento.Text = "Almacenamiento"
        '
        'btnConvertirMasa
        '
        Me.btnConvertirMasa.Location = New System.Drawing.Point(476, 53)
        Me.btnConvertirMasa.Name = "btnConvertirMasa"
        Me.btnConvertirMasa.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertirMasa.TabIndex = 23
        Me.btnConvertirMasa.Text = "Convertir"
        Me.btnConvertirMasa.UseVisualStyleBackColor = True
        '
        'cboMasa2
        '
        Me.cboMasa2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMasa2.FormattingEnabled = True
        Me.cboMasa2.Items.AddRange(New Object() {"", "Tonelada", "Tonelada larga", "Tonelada corta", "Stone", "Onza", "Kilograma", "Libra", "Gramo", "Miligramo", "Microgramo"})
        Me.cboMasa2.Location = New System.Drawing.Point(562, 68)
        Me.cboMasa2.Name = "cboMasa2"
        Me.cboMasa2.Size = New System.Drawing.Size(100, 21)
        Me.cboMasa2.TabIndex = 22
        '
        'txtResultadoMasa
        '
        Me.txtResultadoMasa.Enabled = False
        Me.txtResultadoMasa.Location = New System.Drawing.Point(562, 42)
        Me.txtResultadoMasa.Name = "txtResultadoMasa"
        Me.txtResultadoMasa.Size = New System.Drawing.Size(100, 20)
        Me.txtResultadoMasa.TabIndex = 21
        '
        'txtCantMasa
        '
        Me.txtCantMasa.Location = New System.Drawing.Point(363, 42)
        Me.txtCantMasa.Name = "txtCantMasa"
        Me.txtCantMasa.Size = New System.Drawing.Size(100, 20)
        Me.txtCantMasa.TabIndex = 20
        '
        'cboMasa1
        '
        Me.cboMasa1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMasa1.FormattingEnabled = True
        Me.cboMasa1.Items.AddRange(New Object() {"", "Tonelada", "Tonelada larga", "Tonelada corta", "Stone", "Onza", "Kilograma", "Libra", "Gramo", "Miligramo", "Microgramo"})
        Me.cboMasa1.Location = New System.Drawing.Point(363, 68)
        Me.cboMasa1.Name = "cboMasa1"
        Me.cboMasa1.Size = New System.Drawing.Size(100, 21)
        Me.cboMasa1.TabIndex = 19
        '
        'lblMasa
        '
        Me.lblMasa.AutoSize = True
        Me.lblMasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasa.Location = New System.Drawing.Point(488, 9)
        Me.lblMasa.Name = "lblMasa"
        Me.lblMasa.Size = New System.Drawing.Size(52, 20)
        Me.lblMasa.TabIndex = 18
        Me.lblMasa.Text = "Masa"
        '
        'btmConvertirLongitud
        '
        Me.btmConvertirLongitud.Location = New System.Drawing.Point(476, 158)
        Me.btmConvertirLongitud.Name = "btmConvertirLongitud"
        Me.btmConvertirLongitud.Size = New System.Drawing.Size(75, 23)
        Me.btmConvertirLongitud.TabIndex = 29
        Me.btmConvertirLongitud.Text = "Convertir"
        Me.btmConvertirLongitud.UseVisualStyleBackColor = True
        '
        'cboLongitud2
        '
        Me.cboLongitud2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLongitud2.FormattingEnabled = True
        Me.cboLongitud2.Items.AddRange(New Object() {"", "Milla nautica", "Milla", "Kilometro", "Metro", "Yarda", "Pie", "Pulgada", "Centimetro", "Milimetro", "Micrometro"})
        Me.cboLongitud2.Location = New System.Drawing.Point(562, 173)
        Me.cboLongitud2.Name = "cboLongitud2"
        Me.cboLongitud2.Size = New System.Drawing.Size(100, 21)
        Me.cboLongitud2.TabIndex = 28
        '
        'txtResultadoLongitud
        '
        Me.txtResultadoLongitud.Enabled = False
        Me.txtResultadoLongitud.Location = New System.Drawing.Point(562, 147)
        Me.txtResultadoLongitud.Name = "txtResultadoLongitud"
        Me.txtResultadoLongitud.Size = New System.Drawing.Size(100, 20)
        Me.txtResultadoLongitud.TabIndex = 27
        '
        'txtCantLongitud
        '
        Me.txtCantLongitud.Location = New System.Drawing.Point(363, 147)
        Me.txtCantLongitud.Name = "txtCantLongitud"
        Me.txtCantLongitud.Size = New System.Drawing.Size(100, 20)
        Me.txtCantLongitud.TabIndex = 26
        '
        'cboLongitud1
        '
        Me.cboLongitud1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLongitud1.FormattingEnabled = True
        Me.cboLongitud1.Items.AddRange(New Object() {"", "Milla nautica", "Milla", "Kilometro", "Metro", "Yarda", "Pie", "Pulgada", "Centimetro", "Milimetro", "Micrometro"})
        Me.cboLongitud1.Location = New System.Drawing.Point(363, 173)
        Me.cboLongitud1.Name = "cboLongitud1"
        Me.cboLongitud1.Size = New System.Drawing.Size(100, 21)
        Me.cboLongitud1.TabIndex = 25
        '
        'lblLongitud
        '
        Me.lblLongitud.AutoSize = True
        Me.lblLongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongitud.Location = New System.Drawing.Point(475, 114)
        Me.lblLongitud.Name = "lblLongitud"
        Me.lblLongitud.Size = New System.Drawing.Size(79, 20)
        Me.lblLongitud.TabIndex = 24
        Me.lblLongitud.Text = "Longitud"
        '
        'btnConvertirTiempo
        '
        Me.btnConvertirTiempo.Location = New System.Drawing.Point(476, 263)
        Me.btnConvertirTiempo.Name = "btnConvertirTiempo"
        Me.btnConvertirTiempo.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertirTiempo.TabIndex = 35
        Me.btnConvertirTiempo.Text = "Convertir"
        Me.btnConvertirTiempo.UseVisualStyleBackColor = True
        '
        'cboTiempo2
        '
        Me.cboTiempo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTiempo2.FormattingEnabled = True
        Me.cboTiempo2.Items.AddRange(New Object() {"", "Decada", "Año natural", "Mes", "Semana", "Dia", "Hora", "Minuto", "Segundo", "Milisegundos", "Microsegundo"})
        Me.cboTiempo2.Location = New System.Drawing.Point(562, 278)
        Me.cboTiempo2.Name = "cboTiempo2"
        Me.cboTiempo2.Size = New System.Drawing.Size(100, 21)
        Me.cboTiempo2.TabIndex = 34
        '
        'txtResultadoTiempo
        '
        Me.txtResultadoTiempo.Enabled = False
        Me.txtResultadoTiempo.Location = New System.Drawing.Point(562, 252)
        Me.txtResultadoTiempo.Name = "txtResultadoTiempo"
        Me.txtResultadoTiempo.Size = New System.Drawing.Size(100, 20)
        Me.txtResultadoTiempo.TabIndex = 33
        '
        'txtCantTiempo
        '
        Me.txtCantTiempo.Location = New System.Drawing.Point(363, 252)
        Me.txtCantTiempo.Name = "txtCantTiempo"
        Me.txtCantTiempo.Size = New System.Drawing.Size(100, 20)
        Me.txtCantTiempo.TabIndex = 32
        '
        'cboTiempo1
        '
        Me.cboTiempo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTiempo1.FormattingEnabled = True
        Me.cboTiempo1.Items.AddRange(New Object() {"", "Decada", "Año natural", "Mes", "Semana", "Dia", "Hora", "Minuto", "Segundo", "Milisegundos", "Microsegundo"})
        Me.cboTiempo1.Location = New System.Drawing.Point(363, 278)
        Me.cboTiempo1.Name = "cboTiempo1"
        Me.cboTiempo1.Size = New System.Drawing.Size(100, 21)
        Me.cboTiempo1.TabIndex = 31
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.Location = New System.Drawing.Point(475, 219)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(67, 20)
        Me.lblTiempo.TabIndex = 30
        Me.lblTiempo.Text = "Tiempo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 416)
        Me.Controls.Add(Me.btnConvertirTiempo)
        Me.Controls.Add(Me.cboTiempo2)
        Me.Controls.Add(Me.txtResultadoTiempo)
        Me.Controls.Add(Me.txtCantTiempo)
        Me.Controls.Add(Me.cboTiempo1)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.btmConvertirLongitud)
        Me.Controls.Add(Me.cboLongitud2)
        Me.Controls.Add(Me.txtResultadoLongitud)
        Me.Controls.Add(Me.txtCantLongitud)
        Me.Controls.Add(Me.cboLongitud1)
        Me.Controls.Add(Me.lblLongitud)
        Me.Controls.Add(Me.btnConvertirMasa)
        Me.Controls.Add(Me.cboMasa2)
        Me.Controls.Add(Me.txtResultadoMasa)
        Me.Controls.Add(Me.txtCantMasa)
        Me.Controls.Add(Me.cboMasa1)
        Me.Controls.Add(Me.lblMasa)
        Me.Controls.Add(Me.btnConvertirAlmacenamiento)
        Me.Controls.Add(Me.cboAlmacenamiento2)
        Me.Controls.Add(Me.txtResultadoAlmacenamiento)
        Me.Controls.Add(Me.txtCantAlmacenamiento)
        Me.Controls.Add(Me.cboAlmacenamiento1)
        Me.Controls.Add(Me.lblAlmacenamiento)
        Me.Controls.Add(Me.btnConvertirVolumen)
        Me.Controls.Add(Me.cboVolumen2)
        Me.Controls.Add(Me.txtResultadoVolumen)
        Me.Controls.Add(Me.txtCantVolumen)
        Me.Controls.Add(Me.cboVolumen1)
        Me.Controls.Add(Me.lblVolumen)
        Me.Controls.Add(Me.btnConvertirMoneda)
        Me.Controls.Add(Me.cboMoneda2)
        Me.Controls.Add(Me.txtResultadoMoneda)
        Me.Controls.Add(Me.txtCantMoneda)
        Me.Controls.Add(Me.cboMoneda1)
        Me.Controls.Add(Me.lblMoneda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Conversor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMoneda As Label
    Friend WithEvents cboMoneda1 As ComboBox
    Friend WithEvents txtCantMoneda As TextBox
    Friend WithEvents txtResultadoMoneda As TextBox
    Friend WithEvents cboMoneda2 As ComboBox
    Friend WithEvents btnConvertirMoneda As Button
    Friend WithEvents btnConvertirVolumen As Button
    Friend WithEvents cboVolumen2 As ComboBox
    Friend WithEvents txtResultadoVolumen As TextBox
    Friend WithEvents txtCantVolumen As TextBox
    Friend WithEvents cboVolumen1 As ComboBox
    Friend WithEvents lblVolumen As Label
    Friend WithEvents btnConvertirAlmacenamiento As Button
    Friend WithEvents cboAlmacenamiento2 As ComboBox
    Friend WithEvents txtResultadoAlmacenamiento As TextBox
    Friend WithEvents txtCantAlmacenamiento As TextBox
    Friend WithEvents cboAlmacenamiento1 As ComboBox
    Friend WithEvents lblAlmacenamiento As Label
    Friend WithEvents btnConvertirMasa As Button
    Friend WithEvents cboMasa2 As ComboBox
    Friend WithEvents txtResultadoMasa As TextBox
    Friend WithEvents txtCantMasa As TextBox
    Friend WithEvents cboMasa1 As ComboBox
    Friend WithEvents lblMasa As Label
    Friend WithEvents btmConvertirLongitud As Button
    Friend WithEvents cboLongitud2 As ComboBox
    Friend WithEvents txtResultadoLongitud As TextBox
    Friend WithEvents txtCantLongitud As TextBox
    Friend WithEvents cboLongitud1 As ComboBox
    Friend WithEvents lblLongitud As Label
    Friend WithEvents btnConvertirTiempo As Button
    Friend WithEvents cboTiempo2 As ComboBox
    Friend WithEvents txtResultadoTiempo As TextBox
    Friend WithEvents txtCantTiempo As TextBox
    Friend WithEvents cboTiempo1 As ComboBox
    Friend WithEvents lblTiempo As Label
End Class
