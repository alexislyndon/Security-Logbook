Public Class View_Checked_in_vehicles
    Private Sub MaaweBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MaaweBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VehiclesDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Successfully checked out vehicle with plate# ABC 7890")
    End Sub
End Class
