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

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        Form7.Hide()
    End Sub

End Class