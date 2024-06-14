Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles N1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Equal.Click
        Resultado.Text = Int(N1.Text) + Int(N2.Text)
        MsgBox("Joder flipante", MsgBoxStyle.Critical, "Viva España")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Resultado.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Resultado.Text = ""

    End Sub

    Private Sub Plox_Click(sender As Object, e As EventArgs) Handles Plox.Click

    End Sub
End Class
