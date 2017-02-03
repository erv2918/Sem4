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
        Me.cbxFiguras = New System.Windows.Forms.ComboBox()
        Me.lblDato1 = New System.Windows.Forms.Label()
        Me.lblDato2 = New System.Windows.Forms.Label()
        Me.txtDato1 = New System.Windows.Forms.TextBox()
        Me.txtDato2 = New System.Windows.Forms.TextBox()
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
        'cbxFiguras
        '
        Me.cbxFiguras.FormattingEnabled = True
        Me.cbxFiguras.Items.AddRange(New Object() {"Cuadrado", "Rectangulo", "Triangulo", "Paralelogramo"})
        Me.cbxFiguras.Location = New System.Drawing.Point(37, 36)
        Me.cbxFiguras.Name = "cbxFiguras"
        Me.cbxFiguras.Size = New System.Drawing.Size(121, 21)
        Me.cbxFiguras.TabIndex = 1
        '
        'lblDato1
        '
        Me.lblDato1.AutoSize = True
        Me.lblDato1.Location = New System.Drawing.Point(34, 95)
        Me.lblDato1.Name = "lblDato1"
        Me.lblDato1.Size = New System.Drawing.Size(36, 13)
        Me.lblDato1.TabIndex = 2
        Me.lblDato1.Text = "Dato1"
        Me.lblDato1.Visible = False
        '
        'lblDato2
        '
        Me.lblDato2.AutoSize = True
        Me.lblDato2.Location = New System.Drawing.Point(193, 95)
        Me.lblDato2.Name = "lblDato2"
        Me.lblDato2.Size = New System.Drawing.Size(36, 13)
        Me.lblDato2.TabIndex = 3
        Me.lblDato2.Text = "Dato2"
        Me.lblDato2.Visible = False
        '
        'txtDato1
        '
        Me.txtDato1.Location = New System.Drawing.Point(12, 125)
        Me.txtDato1.Name = "txtDato1"
        Me.txtDato1.Size = New System.Drawing.Size(100, 20)
        Me.txtDato1.TabIndex = 4
        Me.txtDato1.Visible = False
        '
        'txtDato2
        '
        Me.txtDato2.Location = New System.Drawing.Point(149, 125)
        Me.txtDato2.Name = "txtDato2"
        Me.txtDato2.Size = New System.Drawing.Size(100, 20)
        Me.txtDato2.TabIndex = 5
        Me.txtDato2.Visible = False
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
        Me.txtCalcular.Location = New System.Drawing.Point(12, 218)
        Me.txtCalcular.Name = "txtCalcular"
        Me.txtCalcular.Size = New System.Drawing.Size(237, 20)
        Me.txtCalcular.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtCalcular)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtDato2)
        Me.Controls.Add(Me.txtDato1)
        Me.Controls.Add(Me.lblDato2)
        Me.Controls.Add(Me.lblDato1)
        Me.Controls.Add(Me.cbxFiguras)
        Me.Controls.Add(Me.lblFiguras)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFiguras As Label
    Friend WithEvents cbxFiguras As ComboBox
    Friend WithEvents lblDato1 As Label
    Friend WithEvents lblDato2 As Label
    Friend WithEvents txtDato1 As TextBox
    Friend WithEvents txtDato2 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtCalcular As TextBox
End Class
