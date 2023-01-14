<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnection))
        Me.DragPanel = New System.Windows.Forms.Panel()
        Me.MinimizeButton = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ExitButton = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ApplicationName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ApplicationIcon = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomTextbox4 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomTextbox2 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomTextbox3 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomTextbox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomTextbox5 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        Me.DragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomTextbox6 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DragPanel.SuspendLayout()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DragPanel
        '
        Me.DragPanel.Controls.Add(Me.MinimizeButton)
        Me.DragPanel.Controls.Add(Me.ExitButton)
        Me.DragPanel.Controls.Add(Me.ApplicationName)
        Me.DragPanel.Controls.Add(Me.ApplicationIcon)
        Me.DragPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DragPanel.Location = New System.Drawing.Point(0, 0)
        Me.DragPanel.Name = "DragPanel"
        Me.DragPanel.Size = New System.Drawing.Size(517, 35)
        Me.DragPanel.TabIndex = 1
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MinimizeButton.Image = CType(resources.GetObject("MinimizeButton.Image"), System.Drawing.Image)
        Me.MinimizeButton.ImageActive = Nothing
        Me.MinimizeButton.Location = New System.Drawing.Point(442, 1)
        Me.MinimizeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(30, 30)
        Me.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MinimizeButton.TabIndex = 44
        Me.MinimizeButton.TabStop = False
        Me.MinimizeButton.Zoom = 10
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.ImageActive = Nothing
        Me.ExitButton.Location = New System.Drawing.Point(476, 1)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(30, 30)
        Me.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ExitButton.TabIndex = 43
        Me.ExitButton.TabStop = False
        Me.ExitButton.Zoom = 10
        '
        'ApplicationName
        '
        Me.ApplicationName.AutoSize = True
        Me.ApplicationName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ApplicationName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationName.ForeColor = System.Drawing.Color.Silver
        Me.ApplicationName.Location = New System.Drawing.Point(48, 7)
        Me.ApplicationName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ApplicationName.Name = "ApplicationName"
        Me.ApplicationName.Size = New System.Drawing.Size(218, 21)
        Me.ApplicationName.TabIndex = 40
        Me.ApplicationName.Text = ".:: Database Connection ::."
        '
        'ApplicationIcon
        '
        Me.ApplicationIcon.Cursor = System.Windows.Forms.Cursors.Default
        Me.ApplicationIcon.Image = CType(resources.GetObject("ApplicationIcon.Image"), System.Drawing.Image)
        Me.ApplicationIcon.Location = New System.Drawing.Point(8, 1)
        Me.ApplicationIcon.Name = "ApplicationIcon"
        Me.ApplicationIcon.Size = New System.Drawing.Size(30, 30)
        Me.ApplicationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ApplicationIcon.TabIndex = 21
        Me.ApplicationIcon.TabStop = False
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(270, 117)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(76, 19)
        Me.BunifuCustomLabel6.TabIndex = 68
        Me.BunifuCustomLabel6.Text = "Password:"
        '
        'BunifuCustomTextbox4
        '
        Me.BunifuCustomTextbox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuCustomTextbox4.BorderColor = System.Drawing.Color.Fuchsia
        Me.BunifuCustomTextbox4.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.BunifuCustomTextbox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BunifuCustomTextbox4.Location = New System.Drawing.Point(351, 115)
        Me.BunifuCustomTextbox4.Name = "BunifuCustomTextbox4"
        Me.BunifuCustomTextbox4.Size = New System.Drawing.Size(136, 21)
        Me.BunifuCustomTextbox4.TabIndex = 67
        Me.BunifuCustomTextbox4.Text = "admin"
        Me.BunifuCustomTextbox4.UseSystemPasswordChar = True
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(306, 89)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(39, 19)
        Me.BunifuCustomLabel5.TabIndex = 66
        Me.BunifuCustomLabel5.Text = "Port:"
        '
        'BunifuCustomTextbox2
        '
        Me.BunifuCustomTextbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuCustomTextbox2.BorderColor = System.Drawing.Color.Fuchsia
        Me.BunifuCustomTextbox2.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.BunifuCustomTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BunifuCustomTextbox2.Location = New System.Drawing.Point(351, 87)
        Me.BunifuCustomTextbox2.Name = "BunifuCustomTextbox2"
        Me.BunifuCustomTextbox2.Size = New System.Drawing.Size(136, 21)
        Me.BunifuCustomTextbox2.TabIndex = 65
        Me.BunifuCustomTextbox2.Text = "1433"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(18, 117)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(81, 19)
        Me.BunifuCustomLabel4.TabIndex = 64
        Me.BunifuCustomLabel4.Text = "Username:"
        '
        'BunifuCustomTextbox3
        '
        Me.BunifuCustomTextbox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuCustomTextbox3.BorderColor = System.Drawing.Color.Fuchsia
        Me.BunifuCustomTextbox3.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.BunifuCustomTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BunifuCustomTextbox3.Location = New System.Drawing.Point(105, 115)
        Me.BunifuCustomTextbox3.Name = "BunifuCustomTextbox3"
        Me.BunifuCustomTextbox3.Size = New System.Drawing.Size(136, 21)
        Me.BunifuCustomTextbox3.TabIndex = 63
        Me.BunifuCustomTextbox3.Text = "admin"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(30, 89)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(69, 19)
        Me.BunifuCustomLabel3.TabIndex = 62
        Me.BunifuCustomLabel3.Text = "Server IP:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(8, 49)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(136, 19)
        Me.BunifuCustomLabel2.TabIndex = 60
        Me.BunifuCustomLabel2.Text = "MYSQL Information"
        '
        'BunifuCustomTextbox1
        '
        Me.BunifuCustomTextbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuCustomTextbox1.BorderColor = System.Drawing.Color.Fuchsia
        Me.BunifuCustomTextbox1.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.BunifuCustomTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BunifuCustomTextbox1.Location = New System.Drawing.Point(105, 88)
        Me.BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(136, 21)
        Me.BunifuCustomTextbox1.TabIndex = 59
        Me.BunifuCustomTextbox1.Text = "127.0.0.1"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(32, 193)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(67, 19)
        Me.BunifuCustomLabel8.TabIndex = 78
        Me.BunifuCustomLabel8.Text = "Car Info:"
        '
        'BunifuCustomTextbox5
        '
        Me.BunifuCustomTextbox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuCustomTextbox5.BorderColor = System.Drawing.Color.Fuchsia
        Me.BunifuCustomTextbox5.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.BunifuCustomTextbox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BunifuCustomTextbox5.Location = New System.Drawing.Point(105, 193)
        Me.BunifuCustomTextbox5.Name = "BunifuCustomTextbox5"
        Me.BunifuCustomTextbox5.Size = New System.Drawing.Size(136, 21)
        Me.BunifuCustomTextbox5.TabIndex = 77
        Me.BunifuCustomTextbox5.Text = "--"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(12, 152)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(124, 19)
        Me.BunifuCustomLabel7.TabIndex = 75
        Me.BunifuCustomLabel7.Text = "Database Name"
        '
        'btnScan
        '
        Me.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScan.Location = New System.Drawing.Point(272, 279)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(215, 54)
        Me.btnScan.TabIndex = 85
        Me.btnScan.Text = "Scan"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Location = New System.Drawing.Point(272, 368)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(215, 23)
        Me.btnContinue.TabIndex = 84
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnTestConnection
        '
        Me.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestConnection.Location = New System.Drawing.Point(26, 368)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(215, 23)
        Me.btnTestConnection.TabIndex = 83
        Me.btnTestConnection.Text = "Test Connection"
        Me.btnTestConnection.UseVisualStyleBackColor = True
        '
        'DragControl
        '
        Me.DragControl.Fixed = True
        Me.DragControl.Horizontal = True
        Me.DragControl.TargetControl = Me.DragPanel
        Me.DragControl.Vertical = True
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(16, 162)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(489, 35)
        Me.BunifuSeparator2.TabIndex = 76
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 233)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(144, 19)
        Me.BunifuCustomLabel1.TabIndex = 86
        Me.BunifuCustomLabel1.Text = "Arduino Information"
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(16, 243)
        Me.BunifuSeparator3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(489, 35)
        Me.BunifuSeparator3.TabIndex = 87
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(60, 279)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(39, 19)
        Me.BunifuCustomLabel9.TabIndex = 88
        Me.BunifuCustomLabel9.Text = "Port:"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(12, 312)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(87, 19)
        Me.BunifuCustomLabel10.TabIndex = 91
        Me.BunifuCustomLabel10.Text = "Baud Rate:"
        '
        'BunifuCustomTextbox6
        '
        Me.BunifuCustomTextbox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuCustomTextbox6.BorderColor = System.Drawing.Color.Fuchsia
        Me.BunifuCustomTextbox6.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.BunifuCustomTextbox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BunifuCustomTextbox6.Location = New System.Drawing.Point(105, 312)
        Me.BunifuCustomTextbox6.Name = "BunifuCustomTextbox6"
        Me.BunifuCustomTextbox6.Size = New System.Drawing.Size(136, 21)
        Me.BunifuCustomTextbox6.TabIndex = 90
        Me.BunifuCustomTextbox6.Text = "--"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(105, 279)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox1.TabIndex = 92
        '
        'frmConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(517, 427)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.BunifuCustomTextbox6)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnTestConnection)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.BunifuCustomTextbox5)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuCustomTextbox4)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomTextbox2)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomTextbox3)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomTextbox1)
        Me.Controls.Add(Me.DragPanel)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConnection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:: Database Connection ::."
        Me.DragPanel.ResumeLayout(False)
        Me.DragPanel.PerformLayout()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DragPanel As Panel
    Friend WithEvents ApplicationName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ApplicationIcon As PictureBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomTextbox4 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomTextbox2 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomTextbox3 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomTextbox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomTextbox5 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnScan As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnTestConnection As Button
    Friend WithEvents DragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents MinimizeButton As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ExitButton As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomTextbox6 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ComboBox1 As ComboBox
End Class
