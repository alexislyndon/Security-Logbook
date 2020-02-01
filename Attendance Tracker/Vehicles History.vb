Public Class View_History_Vehicles
    Private Sub MaaweBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MaaweBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VehiclesDataSet)

    End Sub
End Class
