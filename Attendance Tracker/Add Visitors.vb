Public Class Add_Visitors
    Dim ctr As Integer
    Private Sub Add_Visitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearer()
    End Sub

    Private Sub MARIAABADBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MARIAABADBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WewDataSet)

    End Sub

    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click

        'Dim alpha As String = "ABCDEFGHIJKLMNOPQRSTUVabcdefghijklmnopqrstuvwxyz"
        Dim errored As Boolean = False
        Dim err As String

        If Visitor_IDTextBox.Text = "" Then
            errored = True
            badgestar.Text = "*"
        End If

        If Last_NameTextBox.Text = "" Then
            errored = True
            lnamestar.Text = "*"
        End If

        If Middle_NameTextBox.Text = "" Then
            errored = True
            mnamestar.Text = "*"
        End If

        If First_NameTextBox.Text = "" Then
            errored = True
            fnamestar.Text = "*"
        End If

        If Phone_NumberTextBox.Text = "" Then
            errored = True
            phonestar.Text = "*"
        End If

        If ComboBox1.Text = "" Then
            errored = True
            deststar.Text = "*"
        End If

        If Purposetxbx.Text = "" Then
            errored = True
            purposestar.Text = "*"
        End If

        If Not errored Then
            ctr = 0
            Timer1.Start()
            'database insert here
            clearer()
            Label1.ForeColor = Color.Green
            Label1.Visible = True
            Label1.Text = "Successfully checked in visitor"
            'MessageBox.Show("Successfully checked in visitor")
        Else
            'error
            ctr = 0
            Timer1.Start()
            Label1.ForeColor = Color.Magenta
            Label1.Visible = True
            Label1.Text = "There was an error"
            'MessageBox.Show("Please fill out all fields.")
        End If
    End Sub



    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        'clear
        clearer()
    End Sub

    Private Sub RefreshData()
        Try
            Me.MARIAABADBindingSource.Filter = Nothing
            Me.MARIAABADTableAdapter.Fill(Me.WewDataSet.MARIAABAD)
        Catch ex As Exception
            MsgBox("Refresh Failed")
        End Try
    End Sub

    Public Function Is_Alpha(Text As String) As Boolean
        Dim AlphaNumericValidator As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Dim b_Result As Boolean

        If InStr(AlphaNumericValidator, Text) > 0 Then
            b_Result = True
        Else
            b_Result = False
        End If

        Return b_Result

    End Function

    Public Function Is_number(Text As String) As Boolean
        Dim num As String = "0123456789"
        Dim b_Result As Boolean

        If InStr(num, Text) > 0 Then
            b_Result = True
        Else
            b_Result = False
        End If

        Return b_Result

    End Function

    Public Function clearer()
        Visitor_IDTextBox.Clear()
        Last_NameTextBox.Clear()
        First_NameTextBox.Clear()
        Middle_NameTextBox.Clear()
        Phone_NumberTextBox.Clear()
        ComboBox1.Text = ""
        Purposetxbx.Clear()
        Label1.Text = "" 'this is the on panel prompt
        badgestar.Text = ""
        lnamestar.Text = ""
        fnamestar.Text = ""
        mnamestar.Text = ""
        phonestar.Text = ""
        deststar.Text = ""
        purposestar.Text = ""
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.GotFocus
        deststar.Text = ""
    End Sub

    Private Sub Last_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Last_NameTextBox.GotFocus
        lnamestar.Text = ""
    End Sub

    Private Sub First_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles First_NameTextBox.GotFocus
        fnamestar.Text = ""
    End Sub

    Private Sub Middle_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Middle_NameTextBox.GotFocus
        mnamestar.Text = ""
    End Sub

    Private Sub Phone_NumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles Phone_NumberTextBox.GotFocus
        phonestar.Text = ""
    End Sub

    Private Sub Visitor_IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles Visitor_IDTextBox.GotFocus
        badgestar.Text = ""
    End Sub

    Private Sub Purposetxbx_TextChanged(sender As Object, e As EventArgs) Handles Purposetxbx.GotFocus
        purposestar.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ctr += 1
        If ctr = 3 Then
            Label1.Visible = False
            Timer1.Stop()
        End If
    End Sub
End Class
