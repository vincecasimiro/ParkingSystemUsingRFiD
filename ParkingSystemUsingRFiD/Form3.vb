Public Class Form3
    Dim user As String = "User"
    Dim password As String = "p@s$w0rD123!"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If Textbox_User.Text = user And TextBox_Pass.Text = password Then

            Form2.Show()

        Else
            Form7.Show()
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Button1.Enter
        Form2.Close()
        Form1.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Textbox_User.Text = ""
        TextBox_Pass.Text = ""
    End Sub
End Class