Public Class Form1

    Dim op As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFiguras.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFiguras.SelectedIndexChanged
        op = cbxFiguras.SelectedIndex
        Select Case op
            Case 0
                lblDato1.Visible = True
                lblDato1.Text = "lado"
                txtDato1.Visible = True
                txtDato1.Text = "0"
        End Select
    End Sub

    Private Sub txtDato1_Click(sender As Object, e As EventArgs) Handles lblDato1.Click

    End Sub

    Private Sub txtDato1_TextChanged(sender As Object, e As EventArgs) Handles txtDato1.TextChanged

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim area As Integer
        Select Case op
            Case 0
                area = Int(txtDato1.Text) * Int(txtDato1.Text)

        End Select
        txtCalcular.Visible = True
        txtCalcular.Text = "El area de la figura es " & area
    End Sub

    Private Sub txtCalcular_TextChanged(sender As Object, e As EventArgs) Handles txtCalcular.TextChanged

    End Sub
End Class
