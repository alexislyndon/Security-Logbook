Public Class Form2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add_Visitors3.Visible = True
        View_Visitors1.Visible = False
        View_Students1.Visible = False
        View_Checked_in_vehicles1.Visible = False
        Add_Vehicles1.Visible = False
        View_History_Vehicles2.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Add_Visitors3.Visible = False
        View_Visitors1.Visible = True
        View_Students1.Visible = False
        View_Checked_in_vehicles1.Visible = False
        Add_Vehicles1.Visible = False
        View_History_Vehicles2.Visible = False

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dddd") & vbCrLf & vbCrLf & Date.Now.ToString("dd - MMM - yyyy")
        'Label1.Text = Format(Now, "Long Date")
        Label3.Text = Date.Now.ToString(" hh:mm:ss")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Add_Visitors3.Visible = False
        View_Visitors1.Visible = False
        View_Students1.Visible = True
        View_Checked_in_vehicles1.Visible = False
        Add_Vehicles1.Visible = False
        View_History_Vehicles2.Visible = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Add_Visitors3.Visible = False
        View_Visitors1.Visible = False
        View_Students1.Visible = False
        View_Checked_in_vehicles1.Visible = True
        Add_Vehicles1.Visible = False
        View_History_Vehicles2.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Add_Visitors3.Visible = False
        View_Visitors1.Visible = False
        View_Students1.Visible = False
        View_Checked_in_vehicles1.Visible = False
        Add_Vehicles1.Visible = True
        View_History_Vehicles2.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Add_Visitors3.Visible = False
        View_Visitors1.Visible = False
        View_Students1.Visible = False
        View_Checked_in_vehicles1.Visible = False
        Add_Vehicles1.Visible = False
        View_History_Vehicles2.Visible = True

    End Sub

End Class