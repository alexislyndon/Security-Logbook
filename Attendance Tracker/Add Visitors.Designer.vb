<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Visitors
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim Visitor_IDLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim DestinationLabel As System.Windows.Forms.Label
        Dim Purposelbl As System.Windows.Forms.Label
        Me.CheckIn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WewDataSet = New Attendance_Tracker.wewDataSet()
        Me.MARIAABADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MARIAABADTableAdapter = New Attendance_Tracker.wewDataSetTableAdapters.MARIAABADTableAdapter()
        Me.TableAdapterManager = New Attendance_Tracker.wewDataSetTableAdapters.TableAdapterManager()
        Me.Visitor_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.AddNew = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.badgestar = New System.Windows.Forms.Label()
        Me.lnamestar = New System.Windows.Forms.Label()
        Me.fnamestar = New System.Windows.Forms.Label()
        Me.mnamestar = New System.Windows.Forms.Label()
        Me.phonestar = New System.Windows.Forms.Label()
        Me.deststar = New System.Windows.Forms.Label()
        Me.Purposetxbx = New System.Windows.Forms.TextBox()
        Me.purposestar = New System.Windows.Forms.Label()
        Visitor_IDLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        DestinationLabel = New System.Windows.Forms.Label()
        Purposelbl = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.WewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MARIAABADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Visitor_IDLabel
        '
        Visitor_IDLabel.AutoSize = True
        Visitor_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Visitor_IDLabel.Location = New System.Drawing.Point(150, 198)
        Visitor_IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Visitor_IDLabel.Name = "Visitor_IDLabel"
        Visitor_IDLabel.Size = New System.Drawing.Size(129, 20)
        Visitor_IDLabel.TabIndex = 13
        Visitor_IDLabel.Text = "Visitor ID Badge:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(150, 239)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(90, 20)
        Last_NameLabel.TabIndex = 14
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(150, 275)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(90, 20)
        First_NameLabel.TabIndex = 15
        First_NameLabel.Text = "First Name:"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Middle_NameLabel.Location = New System.Drawing.Point(150, 311)
        Middle_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(105, 20)
        Middle_NameLabel.TabIndex = 16
        Middle_NameLabel.Text = "Middle Name:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NumberLabel.Location = New System.Drawing.Point(150, 349)
        Phone_NumberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(119, 20)
        Phone_NumberLabel.TabIndex = 17
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DestinationLabel.Location = New System.Drawing.Point(150, 384)
        DestinationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(94, 20)
        DestinationLabel.TabIndex = 21
        DestinationLabel.Text = "Destination:"
        '
        'Purposelbl
        '
        Purposelbl.AutoSize = True
        Purposelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Purposelbl.Location = New System.Drawing.Point(150, 420)
        Purposelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Purposelbl.Name = "Purposelbl"
        Purposelbl.Size = New System.Drawing.Size(68, 20)
        Purposelbl.TabIndex = 17
        Purposelbl.Text = "Purpose"
        '
        'CheckIn
        '
        Me.CheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckIn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.ForeColor = System.Drawing.Color.White
        Me.CheckIn.Location = New System.Drawing.Point(446, 458)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(109, 35)
        Me.CheckIn.TabIndex = 8
        Me.CheckIn.Text = "Check in"
        Me.CheckIn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(808, 156)
        Me.Panel2.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(20, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Add Visitor"
        '
        'WewDataSet
        '
        Me.WewDataSet.DataSetName = "wewDataSet"
        Me.WewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MARIAABADBindingSource
        '
        Me.MARIAABADBindingSource.DataMember = "MARIAABAD"
        Me.MARIAABADBindingSource.DataSource = Me.WewDataSet
        '
        'MARIAABADTableAdapter
        '
        Me.MARIAABADTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MARIAABADTableAdapter = Me.MARIAABADTableAdapter
        Me.TableAdapterManager.UpdateOrder = Attendance_Tracker.wewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Visitor_IDTextBox
        '
        Me.Visitor_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARIAABADBindingSource, "Visitor ID", True))
        Me.Visitor_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visitor_IDTextBox.Location = New System.Drawing.Point(310, 195)
        Me.Visitor_IDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Visitor_IDTextBox.Multiline = True
        Me.Visitor_IDTextBox.Name = "Visitor_IDTextBox"
        Me.Visitor_IDTextBox.Size = New System.Drawing.Size(245, 28)
        Me.Visitor_IDTextBox.TabIndex = 1
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARIAABADBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(310, 236)
        Me.Last_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Last_NameTextBox.Multiline = True
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(245, 28)
        Me.Last_NameTextBox.TabIndex = 2
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARIAABADBindingSource, "First Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(310, 272)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.First_NameTextBox.Multiline = True
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(245, 28)
        Me.First_NameTextBox.TabIndex = 3
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARIAABADBindingSource, "Middle Name", True))
        Me.Middle_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(310, 308)
        Me.Middle_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Middle_NameTextBox.Multiline = True
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(245, 28)
        Me.Middle_NameTextBox.TabIndex = 4
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARIAABADBindingSource, "Phone Number", True))
        Me.Phone_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(310, 346)
        Me.Phone_NumberTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Phone_NumberTextBox.Multiline = True
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(245, 28)
        Me.Phone_NumberTextBox.TabIndex = 5
        '
        'AddNew
        '
        Me.AddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNew.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNew.ForeColor = System.Drawing.Color.White
        Me.AddNew.Location = New System.Drawing.Point(310, 458)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(109, 35)
        Me.AddNew.TabIndex = 9
        Me.AddNew.Text = "Clear"
        Me.AddNew.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Finance", "Registrar", "College of Computer Studies", "Office of the President", "Admissions", "Magis", "OSA", "SEC Mall", "Security Office"})
        Me.ComboBox1.Location = New System.Drawing.Point(310, 381)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(245, 28)
        Me.ComboBox1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(294, 508)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Successfully Checked In Visitor"
        Me.Label1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'badgestar
        '
        Me.badgestar.AutoSize = True
        Me.badgestar.BackColor = System.Drawing.Color.Transparent
        Me.badgestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.badgestar.ForeColor = System.Drawing.Color.Magenta
        Me.badgestar.Location = New System.Drawing.Point(561, 188)
        Me.badgestar.Name = "badgestar"
        Me.badgestar.Size = New System.Drawing.Size(23, 31)
        Me.badgestar.TabIndex = 26
        Me.badgestar.Text = "-"
        '
        'lnamestar
        '
        Me.lnamestar.AutoSize = True
        Me.lnamestar.BackColor = System.Drawing.Color.Transparent
        Me.lnamestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnamestar.ForeColor = System.Drawing.Color.Magenta
        Me.lnamestar.Location = New System.Drawing.Point(561, 229)
        Me.lnamestar.Name = "lnamestar"
        Me.lnamestar.Size = New System.Drawing.Size(23, 31)
        Me.lnamestar.TabIndex = 26
        Me.lnamestar.Text = "-"
        '
        'fnamestar
        '
        Me.fnamestar.AutoSize = True
        Me.fnamestar.BackColor = System.Drawing.Color.Transparent
        Me.fnamestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnamestar.ForeColor = System.Drawing.Color.Magenta
        Me.fnamestar.Location = New System.Drawing.Point(561, 265)
        Me.fnamestar.Name = "fnamestar"
        Me.fnamestar.Size = New System.Drawing.Size(23, 31)
        Me.fnamestar.TabIndex = 26
        Me.fnamestar.Text = "-"
        '
        'mnamestar
        '
        Me.mnamestar.AutoSize = True
        Me.mnamestar.BackColor = System.Drawing.Color.Transparent
        Me.mnamestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnamestar.ForeColor = System.Drawing.Color.Magenta
        Me.mnamestar.Location = New System.Drawing.Point(561, 301)
        Me.mnamestar.Name = "mnamestar"
        Me.mnamestar.Size = New System.Drawing.Size(23, 31)
        Me.mnamestar.TabIndex = 26
        Me.mnamestar.Text = "-"
        '
        'phonestar
        '
        Me.phonestar.AutoSize = True
        Me.phonestar.BackColor = System.Drawing.Color.Transparent
        Me.phonestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonestar.ForeColor = System.Drawing.Color.Magenta
        Me.phonestar.Location = New System.Drawing.Point(561, 339)
        Me.phonestar.Name = "phonestar"
        Me.phonestar.Size = New System.Drawing.Size(23, 31)
        Me.phonestar.TabIndex = 26
        Me.phonestar.Text = "-"
        '
        'deststar
        '
        Me.deststar.AutoSize = True
        Me.deststar.BackColor = System.Drawing.Color.Transparent
        Me.deststar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deststar.ForeColor = System.Drawing.Color.Magenta
        Me.deststar.Location = New System.Drawing.Point(561, 374)
        Me.deststar.Name = "deststar"
        Me.deststar.Size = New System.Drawing.Size(23, 31)
        Me.deststar.TabIndex = 26
        Me.deststar.Text = "-"
        '
        'Purposetxbx
        '
        Me.Purposetxbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Purposetxbx.Location = New System.Drawing.Point(310, 417)
        Me.Purposetxbx.Margin = New System.Windows.Forms.Padding(2)
        Me.Purposetxbx.Multiline = True
        Me.Purposetxbx.Name = "Purposetxbx"
        Me.Purposetxbx.Size = New System.Drawing.Size(245, 28)
        Me.Purposetxbx.TabIndex = 18
        '
        'purposestar
        '
        Me.purposestar.AutoSize = True
        Me.purposestar.BackColor = System.Drawing.Color.Transparent
        Me.purposestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purposestar.ForeColor = System.Drawing.Color.Magenta
        Me.purposestar.Location = New System.Drawing.Point(561, 410)
        Me.purposestar.Name = "purposestar"
        Me.purposestar.Size = New System.Drawing.Size(23, 31)
        Me.purposestar.TabIndex = 26
        Me.purposestar.Text = "-"
        '
        'Add_Visitors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.purposestar)
        Me.Controls.Add(Me.deststar)
        Me.Controls.Add(Me.phonestar)
        Me.Controls.Add(Me.mnamestar)
        Me.Controls.Add(Me.fnamestar)
        Me.Controls.Add(Me.lnamestar)
        Me.Controls.Add(Me.badgestar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.AddNew)
        Me.Controls.Add(DestinationLabel)
        Me.Controls.Add(Purposelbl)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Purposetxbx)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(Middle_NameLabel)
        Me.Controls.Add(Me.Middle_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Visitor_IDLabel)
        Me.Controls.Add(Me.Visitor_IDTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CheckIn)
        Me.Name = "Add_Visitors"
        Me.Size = New System.Drawing.Size(767, 585)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.WewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MARIAABADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckIn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents WewDataSet As wewDataSet
    Friend WithEvents MARIAABADBindingSource As BindingSource
    Friend WithEvents MARIAABADTableAdapter As wewDataSetTableAdapters.MARIAABADTableAdapter
    Friend WithEvents TableAdapterManager As wewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Visitor_IDTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Middle_NameTextBox As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents AddNew As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents badgestar As Label
    Friend WithEvents lnamestar As Label
    Friend WithEvents fnamestar As Label
    Friend WithEvents mnamestar As Label
    Friend WithEvents phonestar As Label
    Friend WithEvents deststar As Label
    Friend WithEvents Purposetxbx As TextBox
    Friend WithEvents purposestar As Label
End Class
