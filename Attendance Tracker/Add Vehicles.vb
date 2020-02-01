Public Class Add_Vehicles
    Dim ctr As Integer
    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click
        Dim errored As Boolean = False
        If platebx.Text = "" Then
            errored = True
            plateestar.Text = "*"
        End If

        If makebx.Text = "" Then
            errored = True
            makestar.Text = "*"
        End If

        If modelbx.Text = "" Then
            errored = True
            modelstar.Text = "*"
        End If

        If ComboBox1.Text = "" Then
            errored = True
            colorstar.Text = "*"
        End If

        If Not errored Then
            ctr = 0
            Timer1.Start()
            'database insert here
            clearer()
            Label1.ForeColor = Color.Green
            Label1.Visible = True
            Label1.Text = "Successfully checked in VEHICLE"
            'MessageBox.Show("Successfully checked in visitor")
        Else
            ctr = 0
            Timer1.Start()
            Label1.ForeColor = Color.Magenta
            Label1.Visible = True
            Label1.Text = "There was an error"
            'MessageBox.Show("Please fill out all fields.")
        End If

    End Sub

    Private Sub Add_Vehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearer()
    End Sub

    Public Function clearer()
        makebx.Text = ""
        platebx.Clear()
        modelbx.Clear()
        ComboBox1.Text = ""
        Label1.Text = ""
        plateestar.Text = ""
        makestar.Text = ""
        modelstar.Text = ""
        colorstar.Text = ""
    End Function

    Private Sub colorstar_Click(sender As Object, e As EventArgs) Handles ComboBox1.GotFocus
        colorstar.Text = ""
    End Sub

    Private Sub makestar_Click(sender As Object, e As EventArgs) Handles makebx.GotFocus
        makestar.Text = ""
    End Sub

    Private Sub modelstar_Click(sender As Object, e As EventArgs) Handles modelbx.GotFocus
        modelstar.Text = ""
    End Sub

    Private Sub plateestar_Click(sender As Object, e As EventArgs) Handles platebx.GotFocus
        plateestar.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ctr += 1
        If ctr = 3 Then
            Label1.Visible = False
            Timer1.Stop()
        End If
    End Sub
End Class
