Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        PanelUser.Visible = False
        PanelPayment.Visible = False
        PanelConnection.Visible = False
        PanelCheckIn.Visible = False
        PanelCheckOut.Visible = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label24.Text += 1

        Label2.Text = Date.Now.ToString("MMM-dd-yyyy")

        Label3.Text = Date.Now.ToString("hh:mm:ss")

        Label6.Text = Date.Now.ToString("MMM-dd-yyyy")

        Label5.Text = Date.Now.ToString("hh:mm:ss")



        If Label24.Text = 30 Then

            Label31.Text = "Vince Casimiro"
            PictureBox4.Image = My.Resources.Beans
            Label29.Text = "Sta.Mesa"
            Label27.Text = "ABC 123"
            Label25.Text = "P00.00"
            Label34.Text = "11:00"

        ElseIf Label24.Text = 20 Then

            Label9.Text = "Vince Casimiro"
            PictureBox1.Image = My.Resources.Beans
            Label11.Text = "Sta.Mesa"
            Label13.Text = "ABC 123"
            Label15.Text = "P00.00"


        ElseIf Label24.Text = 50 Then

            Label41.Text = "Vince Casimiro"
            PictureBox5.Image = My.Resources.Beans
            Label39.Text = "Sta.Mesa"
            Label37.Text = "ABC 123"
            Label35.Text = "P300.00"
            Label43.Text = "12:00"

        ElseIf Label24.Text = 60 Then

            Label22.Text = "Vince Casimiro"
            Label20.Text = "Sta.Mesa"
            Label18.Text = "ABC 123"
            Label16.Text = "P300.00"

        ElseIf Label24.Text = 70 Then

            Label16.Text = "P00.00"

        End If



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PanelConnection_Paint(sender As Object, e As PaintEventArgs) Handles PanelConnection.Paint, PanelMain.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox3.Image = My.Resources.green

    End Sub

    Private Sub ButtonConnection_Click(sender As Object, e As EventArgs) Handles ButtonConnection.Click
        PanelUser.Visible = False
        PanelPayment.Visible = False
        PanelConnection.Visible = True
        PanelCheckIn.Visible = False
        PanelCheckOut.Visible = False

    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        PanelUser.Visible = False
        PanelPayment.Visible = False
        PanelConnection.Visible = False
        PanelCheckIn.Visible = False
        PanelCheckOut.Visible = False
    End Sub

    Private Sub ButtonUser_Click(sender As Object, e As EventArgs) Handles ButtonUser.Click

        PanelUser.Visible = True
        PanelPayment.Visible = False
        PanelConnection.Visible = False
        PanelCheckIn.Visible = False
        PanelCheckOut.Visible = False
    End Sub

    Private Sub ButtonPayment_Click(sender As Object, e As EventArgs) Handles ButtonPayment.Click
        PanelUser.Visible = False
        PanelPayment.Visible = True
        PanelConnection.Visible = False
        PanelCheckIn.Visible = False
        PanelCheckOut.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PanelUser.Visible = False
        PanelPayment.Visible = False
        PanelConnection.Visible = False
        PanelCheckIn.Visible = True
        PanelCheckOut.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PanelUser.Visible = False
        PanelPayment.Visible = False
        PanelConnection.Visible = False
        PanelCheckIn.Visible = False
        PanelCheckOut.Visible = True
    End Sub

    Private Sub PanelCheckOut_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click

    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click

    End Sub
End Class
