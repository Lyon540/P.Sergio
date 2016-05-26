Public Class Form1

    Private Sub Btn_Calcular_Click(sender As Object, e As EventArgs) Handles Btn_Calcular.Click
        Dim P1 As Single
        Dim P2 As Single
        Dim ExF As Single
        Dim Tareas As Single
        Dim PF As Single
        Dim Total As Single

        P1 = TextBox1.Text * 0.2
        If P1 >= 14 Then
            TextBox1.BackColor = Color.LightGreen
        Else
            TextBox1.BackColor = Color.Tomato
        End If

        P2 = TextBox2.Text * 0.2
        If P2 >= 14 Then
            TextBox2.BackColor = Color.LightGreen
        Else
            TextBox2.BackColor = Color.Tomato
        End If

        ExF = TextBox3.Text * 0.3
        If ExF >= 21 Then
            TextBox3.BackColor = Color.LightGreen
        Else
            TextBox3.BackColor = Color.Tomato
        End If

        Tareas = TextBox4.Text * 0.1
        If Tareas >= 7 Then
            TextBox4.BackColor = Color.LightGreen
        Else
            TextBox4.BackColor = Color.Tomato
        End If

        PF = TextBox5.Text * 0.2
        If PF >= 14 Then
            TextBox5.BackColor = Color.LightGreen
        Else
            TextBox5.BackColor = Color.Tomato
        End If

        Total = P1 + P2 + ExF + Tareas + PF
        TextBox6.Text = Total
        If Total >= 70 Then
            TextBox6.BackColor = Color.LightGreen
        Else
            TextBox6.BackColor = Color.Tomato
        End If

        If Total >= 70 Then
            TextBox7.Text = "Aprovado"
            TextBox7.BackColor = Color.LightGreen
        Else
            TextBox7.Text = "Reprovado"
            TextBox7.BackColor = Color.Tomato
        End If
    End Sub

    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox1.BackColor = Color.White
        TextBox2.BackColor = Color.White
        TextBox3.BackColor = Color.White
        TextBox4.BackColor = Color.White
        TextBox5.BackColor = Color.White
        TextBox6.BackColor = Color.White
        TextBox7.BackColor = Color.White
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Me.Close()
    End Sub
End Class
