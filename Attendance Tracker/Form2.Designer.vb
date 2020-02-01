<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Add_Visitors3 = New Attendance_Tracker.Add_Visitors()
        Me.View_Visitors1 = New Attendance_Tracker.View_Visitors()
        Me.View_Students1 = New Attendance_Tracker.View_Students()
        Me.Add_Vehicles1 = New Attendance_Tracker.Add_Vehicles()
        Me.View_Checked_in_vehicles1 = New Attendance_Tracker.View_Checked_in_vehicles()
        Me.View_History_Vehicles2 = New Attendance_Tracker.View_History_Vehicles()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(956, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "X"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 585)
        Me.Panel1.TabIndex = 3
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(0, 442)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(215, 50)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Vehicles History"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(0, 392)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(215, 50)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "View Checked in Vehicle"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(0, 343)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(215, 50)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Add Vehicle"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Seven Segment", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label3.Location = New System.Drawing.Point(6, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 49)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "00:00:00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Seven Segment", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Date"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(215, 50)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Visitor History"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(215, 51)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "View Checked in Visitors"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 57)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add Visitor"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(212, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(688, 585)
        Me.Panel3.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Add_Visitors3
        '
        Me.Add_Visitors3.Location = New System.Drawing.Point(212, 0)
        Me.Add_Visitors3.Margin = New System.Windows.Forms.Padding(4)
        Me.Add_Visitors3.Name = "Add_Visitors3"
        Me.Add_Visitors3.Size = New System.Drawing.Size(767, 585)
        Me.Add_Visitors3.TabIndex = 7
        '
        'View_Visitors1
        '
        Me.View_Visitors1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View_Visitors1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.View_Visitors1.Location = New System.Drawing.Point(212, 0)
        Me.View_Visitors1.Margin = New System.Windows.Forms.Padding(2)
        Me.View_Visitors1.Name = "View_Visitors1"
        Me.View_Visitors1.Size = New System.Drawing.Size(767, 585)
        Me.View_Visitors1.TabIndex = 16
        '
        'View_Students1
        '
        Me.View_Students1.Location = New System.Drawing.Point(212, 0)
        Me.View_Students1.Margin = New System.Windows.Forms.Padding(4)
        Me.View_Students1.Name = "View_Students1"
        Me.View_Students1.Size = New System.Drawing.Size(767, 585)
        Me.View_Students1.TabIndex = 17
        '
        'Add_Vehicles1
        '
        Me.Add_Vehicles1.Location = New System.Drawing.Point(212, 0)
        Me.Add_Vehicles1.Margin = New System.Windows.Forms.Padding(2)
        Me.Add_Vehicles1.Name = "Add_Vehicles1"
        Me.Add_Vehicles1.Size = New System.Drawing.Size(767, 585)
        Me.Add_Vehicles1.TabIndex = 19
        '
        'View_Checked_in_vehicles1
        '
        Me.View_Checked_in_vehicles1.Location = New System.Drawing.Point(212, 0)
        Me.View_Checked_in_vehicles1.Margin = New System.Windows.Forms.Padding(2)
        Me.View_Checked_in_vehicles1.Name = "View_Checked_in_vehicles1"
        Me.View_Checked_in_vehicles1.Size = New System.Drawing.Size(767, 585)
        Me.View_Checked_in_vehicles1.TabIndex = 22
        '
        'View_History_Vehicles2
        '
        Me.View_History_Vehicles2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.View_History_Vehicles2.Location = New System.Drawing.Point(212, 0)
        Me.View_History_Vehicles2.Margin = New System.Windows.Forms.Padding(2)
        Me.View_History_Vehicles2.Name = "View_History_Vehicles2"
        Me.View_History_Vehicles2.Size = New System.Drawing.Size(767, 585)
        Me.View_History_Vehicles2.TabIndex = 23
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 585)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Add_Visitors3)
        Me.Controls.Add(Me.View_Visitors1)
        Me.Controls.Add(Me.View_Students1)
        Me.Controls.Add(Me.Add_Vehicles1)
        Me.Controls.Add(Me.View_Checked_in_vehicles1)
        Me.Controls.Add(Me.View_History_Vehicles2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Add_Visitors1 As Add_Visitors
    Friend WithEvents Add_Visitors3 As Add_Visitors
    Friend WithEvents View_Visitors1 As View_Visitors
    Friend WithEvents View_Students1 As View_Students
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Add_Vehicles1 As Add_Vehicles
    Friend WithEvents View_Checked_in_vehicles1 As View_Checked_in_vehicles
    Friend WithEvents View_History_Vehicles2 As View_History_Vehicles
End Class
