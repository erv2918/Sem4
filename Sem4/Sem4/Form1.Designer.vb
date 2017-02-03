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
        Me.lblFiguras = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblDato1 = New System.Windows.Forms.Label()
        Me.lblDato2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtCalcular = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFiguras
        '
        Me.lblFiguras.AutoSize = True
        Me.lblFiguras.Location = New System.Drawing.Point(34, 20)
        Me.lblFiguras.Name = "lblFiguras"
        Me.lblFiguras.Size = New System.Drawing.Size(150, 13)
        Me.lblFiguras.TabIndex = 0
        Me.lblFiguras.Text = "Seleccione la figura a Calcular"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cuadrado", "Rectangulo", "Triangulo", "Paralelogramo"})
        Me.ComboBox1.Location = New System.Drawing.Point(37, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'lblDato1
        '
        Me.lblDato1.AutoSize = True
        Me.lblDato1.Location = New System.Drawing.Point(34, 95)
        Me.lblDato1.Name = "lblDato1"
        Me.lblDato1.Size = New System.Drawing.Size(36, 13)
        Me.lblDato1.TabIndex = 2
        Me.lblDato1.Text = "Dato1"
        '
        'lblDato2
        '
        Me.lblDato2.AutoSize = True
        Me.lblDato2.Location = New System.Drawing.Point(193, 95)
        Me.lblDato2.Name = "lblDato2"
        Me.lblDato2.Size = New System.Drawing.Size(36, 13)
        Me.lblDato2.TabIndex = 3
        Me.lblDato2.Text = "Dato2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 125)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(149, 125)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 5
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(83, 163)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtCalcular
        '
        Me.txtCalcular.Location = New System.Drawing.Point(70, 218)
        Me.txtCalcular.Name = "txtCalcular"
        Me.txtCalcular.Size = New System.Drawing.Size(101, 20)
        Me.txtCalcular.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtCalcular)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblDato2)
        Me.Controls.Add(Me.lblDato1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblFiguras)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFiguras As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblDato1 As Label
    Friend WithEvents lblDato2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtCalcular As TextBox
End Class
