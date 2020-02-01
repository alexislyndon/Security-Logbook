<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Vehicles
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Visitor_IDLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.makebx = New System.Windows.Forms.ComboBox()
        Me.AddNew = New System.Windows.Forms.Button()
        Me.modelbx = New System.Windows.Forms.TextBox()
        Me.platebx = New System.Windows.Forms.TextBox()
        Me.CheckIn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.plateestar = New System.Windows.Forms.Label()
        Me.makestar = New System.Windows.Forms.Label()
        Me.modelstar = New System.Windows.Forms.Label()
        Me.colorstar = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Middle_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Visitor_IDLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Middle_NameLabel.Location = New System.Drawing.Point(147, 348)
        Middle_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(50, 20)
        Middle_NameLabel.TabIndex = 32
        Middle_NameLabel.Text = "Color:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(147, 299)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(56, 20)
        First_NameLabel.TabIndex = 30
        First_NameLabel.Text = "Model:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(147, 250)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(52, 20)
        Last_NameLabel.TabIndex = 28
        Last_NameLabel.Text = "Make:"
        '
        'Visitor_IDLabel
        '
        Visitor_IDLabel.AutoSize = True
        Visitor_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Visitor_IDLabel.Location = New System.Drawing.Point(143, 202)
        Visitor_IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Visitor_IDLabel.Name = "Visitor_IDLabel"
        Visitor_IDLabel.Size = New System.Drawing.Size(109, 20)
        Visitor_IDLabel.TabIndex = 27
        Visitor_IDLabel.Text = "Plate Number:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(143, 397)
        Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(77, 20)
        Label7.TabIndex = 32
        Label7.Text = "Remarks:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(808, 156)
        Me.Panel2.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(20, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Add Vehicle"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 501)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Successfully Checked In Vehicle"
        '
        'makebx
        '
        Me.makebx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.makebx.FormattingEnabled = True
        Me.makebx.Items.AddRange(New Object() {"Toyota", "Mitsubishi", "Honda", "Isuzu", "Hyundai", "Kia"})
        Me.makebx.Location = New System.Drawing.Point(310, 247)
        Me.makebx.Name = "makebx"
        Me.makebx.Size = New System.Drawing.Size(245, 28)
        Me.makebx.TabIndex = 39
        '
        'AddNew
        '
        Me.AddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNew.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNew.ForeColor = System.Drawing.Color.White
        Me.AddNew.Location = New System.Drawing.Point(310, 445)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(109, 35)
        Me.AddNew.TabIndex = 38
        Me.AddNew.Text = "Clear"
        Me.AddNew.UseVisualStyleBackColor = False
        '
        'modelbx
        '
        Me.modelbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelbx.Location = New System.Drawing.Point(310, 296)
        Me.modelbx.Margin = New System.Windows.Forms.Padding(2)
        Me.modelbx.Multiline = True
        Me.modelbx.Name = "modelbx"
        Me.modelbx.Size = New System.Drawing.Size(245, 28)
        Me.modelbx.TabIndex = 33
        '
        'platebx
        '
        Me.platebx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.platebx.Location = New System.Drawing.Point(310, 195)
        Me.platebx.Margin = New System.Windows.Forms.Padding(2)
        Me.platebx.Multiline = True
        Me.platebx.Name = "platebx"
        Me.platebx.Size = New System.Drawing.Size(245, 28)
        Me.platebx.TabIndex = 29
        '
        'CheckIn
        '
        Me.CheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckIn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.ForeColor = System.Drawing.Color.White
        Me.CheckIn.Location = New System.Drawing.Point(446, 445)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(109, 35)
        Me.CheckIn.TabIndex = 26
        Me.CheckIn.Text = "Check in"
        Me.CheckIn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(241, 501)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 41
        '
        'plateestar
        '
        Me.plateestar.AutoSize = True
        Me.plateestar.BackColor = System.Drawing.Color.Transparent
        Me.plateestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plateestar.ForeColor = System.Drawing.Color.Magenta
        Me.plateestar.Location = New System.Drawing.Point(565, 192)
        Me.plateestar.Name = "plateestar"
        Me.plateestar.Size = New System.Drawing.Size(23, 31)
        Me.plateestar.TabIndex = 42
        Me.plateestar.Text = "-"
        '
        'makestar
        '
        Me.makestar.AutoSize = True
        Me.makestar.BackColor = System.Drawing.Color.Transparent
        Me.makestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.makestar.ForeColor = System.Drawing.Color.Magenta
        Me.makestar.Location = New System.Drawing.Point(565, 240)
        Me.makestar.Name = "makestar"
        Me.makestar.Size = New System.Drawing.Size(23, 31)
        Me.makestar.TabIndex = 42
        Me.makestar.Text = "-"
        '
        'modelstar
        '
        Me.modelstar.AutoSize = True
        Me.modelstar.BackColor = System.Drawing.Color.Transparent
        Me.modelstar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelstar.ForeColor = System.Drawing.Color.Magenta
        Me.modelstar.Location = New System.Drawing.Point(565, 289)
        Me.modelstar.Name = "modelstar"
        Me.modelstar.Size = New System.Drawing.Size(23, 31)
        Me.modelstar.TabIndex = 42
        Me.modelstar.Text = "-"
        '
        'colorstar
        '
        Me.colorstar.AutoSize = True
        Me.colorstar.BackColor = System.Drawing.Color.Transparent
        Me.colorstar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorstar.ForeColor = System.Drawing.Color.Magenta
        Me.colorstar.Location = New System.Drawing.Point(565, 338)
        Me.colorstar.Name = "colorstar"
        Me.colorstar.Size = New System.Drawing.Size(23, 31)
        Me.colorstar.TabIndex = 42
        Me.colorstar.Text = "-"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(310, 394)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 28)
        Me.TextBox1.TabIndex = 35
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"White", "Black", "Silver/Thermalyte", "Red", "Brown", "Green", "Blue"})
        Me.ComboBox1.Location = New System.Drawing.Point(310, 345)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(245, 28)
        Me.ComboBox1.TabIndex = 39
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Add_Vehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.colorstar)
        Me.Controls.Add(Me.modelstar)
        Me.Controls.Add(Me.makestar)
        Me.Controls.Add(Me.plateestar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.makebx)
        Me.Controls.Add(Me.AddNew)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Middle_NameLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.modelbx)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Visitor_IDLabel)
        Me.Controls.Add(Me.platebx)
        Me.Controls.Add(Me.CheckIn)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Add_Vehicles"
        Me.Size = New System.Drawing.Size(767, 585)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents makebx As ComboBox
    Friend WithEvents AddNew As Button
    Friend WithEvents modelbx As TextBox
    Friend WithEvents platebx As TextBox
    Friend WithEvents CheckIn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents plateestar As Label
    Friend WithEvents makestar As Label
    Friend WithEvents modelstar As Label
    Friend WithEvents colorstar As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Timer1 As Timer
End Class
