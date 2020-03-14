Public Class Form3
    Dim user As String = "User"
    Dim password As String = "p@s$w0rD123!"
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Button1.Enter
        Form2.Hide()
        Form1.Hide()
        Form4.Hide()
        Form5.Hide()
        Form6.Hide()
        Form7.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If Textbox_User.Text = user And TextBox_Pass.Text = password Then

            Form2.Show()

        Else
            Form7.Show()
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Textbox_User.Text = ""
        TextBox_Pass.Text = ""
    End Sub

End Class