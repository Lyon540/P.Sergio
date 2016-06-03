Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Single
        Dim y As Single
        Dim z As Single
        x = TextBox1.Text
        y = TextBox2.Text
        If y <> 1.99 Then
            z = y * x + x
            TextBox3.Text = z
        End If
        z = x * y
        TextBox3.Text = z
    End Sub
End Class
