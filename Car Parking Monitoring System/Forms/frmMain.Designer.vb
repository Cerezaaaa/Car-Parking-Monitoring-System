<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim Animation8 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.DragPanel = New System.Windows.Forms.Panel()
        Me.MinimizeButton = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ExitButton = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ApplicationName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ApplicationIcon = New System.Windows.Forms.PictureBox()
        Me.DragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.OverviewPanel = New System.Windows.Forms.Panel()
        Me.chckBoxSlot6 = New System.Windows.Forms.CheckBox()
        Me.chckBoxSlot5 = New System.Windows.Forms.CheckBox()
        Me.chckBoxSlot4 = New System.Windows.Forms.CheckBox()
        Me.chckBoxSlot3 = New System.Windows.Forms.CheckBox()
        Me.chckBoxSlot2 = New System.Windows.Forms.CheckBox()
        Me.chckBoxSlot1 = New System.Windows.Forms.CheckBox()
        Me.txtboxcData = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel17 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblEmptySlot = New Bunifu.Framework.UI.BunifuTileButton()
        Me.SlotPictureBox6 = New System.Windows.Forms.PictureBox()
        Me.SlotPictureBox5 = New System.Windows.Forms.PictureBox()
        Me.SlotPictureBox4 = New System.Windows.Forms.PictureBox()
        Me.SlotPictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SlotPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SlotPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.InfoPanel = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.OverviewBackPictureBox = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblSlotStatus = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblSlotNumber = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SlotStatusPictureBox = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel20 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel21 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblTimeOut = New Bunifu.Framework.UI.BunifuTileButton()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblTimeIn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuCustomLabel19 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblRFID = New Bunifu.Framework.UI.BunifuTileButton()
        Me.ExportPanel = New System.Windows.Forms.Panel()
        Me.ZoomOutPictureBox = New System.Windows.Forms.PictureBox()
        Me.ZoomInPictureBox = New System.Windows.Forms.PictureBox()
        Me.btnRefreshFile = New System.Windows.Forms.Button()
        Me.btnSaveFile = New System.Windows.Forms.Button()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.SearchPanel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radStatusSearch = New System.Windows.Forms.RadioButton()
        Me.radSlotNumberSearch = New System.Windows.Forms.RadioButton()
        Me.searchDataGrid = New System.Windows.Forms.DataGridView()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbSlotSelection = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnSlotNumberSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnStatusSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cmbStatusSelection = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.AdminPanel = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btndbRefresh = New System.Windows.Forms.Button()
        Me.adminDataGrid = New System.Windows.Forms.DataGridView()
        Me.btnlogTimeOut = New System.Windows.Forms.Button()
        Me.btnlogTimeIn = New System.Windows.Forms.Button()
        Me.btnMakeFree = New System.Windows.Forms.Button()
        Me.btnMakeFull = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbdbSlot = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TransitionControl = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.LineSeparator = New Bunifu.Framework.UI.BunifuSeparator()
        Me.OverviewLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.InformationLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SearchLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ExportLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.AdminLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DataReceiver = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Misc = New System.Windows.Forms.Timer(Me.components)
        Me.DragPanel.SuspendLayout()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.OverviewPanel.SuspendLayout()
        CType(Me.SlotPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlotPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlotPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlotPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlotPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlotPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoPanel.SuspendLayout()
        CType(Me.OverviewBackPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlotStatusPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExportPanel.SuspendLayout()
        CType(Me.ZoomOutPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZoomInPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.searchDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.AdminPanel.SuspendLayout()
        CType(Me.adminDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DragPanel
        '
        Me.DragPanel.Controls.Add(Me.MinimizeButton)
        Me.DragPanel.Controls.Add(Me.ExitButton)
        Me.DragPanel.Controls.Add(Me.ApplicationName)
        Me.DragPanel.Controls.Add(Me.ApplicationIcon)
        Me.TransitionControl.SetDecoration(Me.DragPanel, BunifuAnimatorNS.DecorationType.None)
        Me.DragPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DragPanel.Location = New System.Drawing.Point(0, 0)
        Me.DragPanel.Name = "DragPanel"
        Me.DragPanel.Size = New System.Drawing.Size(560, 35)
        Me.DragPanel.TabIndex = 0
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.MinimizeButton, BunifuAnimatorNS.DecorationType.None)
        Me.MinimizeButton.Image = CType(resources.GetObject("MinimizeButton.Image"), System.Drawing.Image)
        Me.MinimizeButton.ImageActive = Nothing
        Me.MinimizeButton.Location = New System.Drawing.Point(485, 2)
        Me.MinimizeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(30, 30)
        Me.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MinimizeButton.TabIndex = 42
        Me.MinimizeButton.TabStop = False
        Me.MinimizeButton.Zoom = 10
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.ExitButton, BunifuAnimatorNS.DecorationType.None)
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.ImageActive = Nothing
        Me.ExitButton.Location = New System.Drawing.Point(519, 2)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(30, 30)
        Me.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ExitButton.TabIndex = 41
        Me.ExitButton.TabStop = False
        Me.ExitButton.Zoom = 10
        '
        'ApplicationName
        '
        Me.ApplicationName.AutoSize = True
        Me.ApplicationName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.ApplicationName, BunifuAnimatorNS.DecorationType.None)
        Me.ApplicationName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationName.ForeColor = System.Drawing.Color.Silver
        Me.ApplicationName.Location = New System.Drawing.Point(48, 7)
        Me.ApplicationName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ApplicationName.Name = "ApplicationName"
        Me.ApplicationName.Size = New System.Drawing.Size(278, 21)
        Me.ApplicationName.TabIndex = 40
        Me.ApplicationName.Text = ".:: Car Parking Monitoring System ::."
        '
        'ApplicationIcon
        '
        Me.ApplicationIcon.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransitionControl.SetDecoration(Me.ApplicationIcon, BunifuAnimatorNS.DecorationType.None)
        Me.ApplicationIcon.Image = CType(resources.GetObject("ApplicationIcon.Image"), System.Drawing.Image)
        Me.ApplicationIcon.Location = New System.Drawing.Point(8, 1)
        Me.ApplicationIcon.Name = "ApplicationIcon"
        Me.ApplicationIcon.Size = New System.Drawing.Size(30, 30)
        Me.ApplicationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ApplicationIcon.TabIndex = 21
        Me.ApplicationIcon.TabStop = False
        '
        'DragControl
        '
        Me.DragControl.Fixed = True
        Me.DragControl.Horizontal = True
        Me.DragControl.TargetControl = Me.DragPanel
        Me.DragControl.Vertical = True
        '
        'MainPanel
        '
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.OverviewPanel)
        Me.MainPanel.Controls.Add(Me.InfoPanel)
        Me.MainPanel.Controls.Add(Me.ExportPanel)
        Me.MainPanel.Controls.Add(Me.SearchPanel)
        Me.MainPanel.Controls.Add(Me.AdminPanel)
        Me.TransitionControl.SetDecoration(Me.MainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.MainPanel.Location = New System.Drawing.Point(8, 77)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(541, 315)
        Me.MainPanel.TabIndex = 20
        '
        'OverviewPanel
        '
        Me.OverviewPanel.Controls.Add(Me.chckBoxSlot6)
        Me.OverviewPanel.Controls.Add(Me.chckBoxSlot5)
        Me.OverviewPanel.Controls.Add(Me.chckBoxSlot4)
        Me.OverviewPanel.Controls.Add(Me.chckBoxSlot3)
        Me.OverviewPanel.Controls.Add(Me.chckBoxSlot2)
        Me.OverviewPanel.Controls.Add(Me.chckBoxSlot1)
        Me.OverviewPanel.Controls.Add(Me.txtboxcData)
        Me.OverviewPanel.Controls.Add(Me.BunifuCustomLabel6)
        Me.OverviewPanel.Controls.Add(Me.BunifuCustomLabel17)
        Me.OverviewPanel.Controls.Add(Me.lblEmptySlot)
        Me.OverviewPanel.Controls.Add(Me.SlotPictureBox6)
        Me.OverviewPanel.Controls.Add(Me.SlotPictureBox5)
        Me.OverviewPanel.Controls.Add(Me.SlotPictureBox4)
        Me.OverviewPanel.Controls.Add(Me.SlotPictureBox3)
        Me.OverviewPanel.Controls.Add(Me.SlotPictureBox2)
        Me.OverviewPanel.Controls.Add(Me.SlotPictureBox1)
        Me.TransitionControl.SetDecoration(Me.OverviewPanel, BunifuAnimatorNS.DecorationType.None)
        Me.OverviewPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OverviewPanel.Location = New System.Drawing.Point(0, 0)
        Me.OverviewPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.OverviewPanel.Name = "OverviewPanel"
        Me.OverviewPanel.Size = New System.Drawing.Size(539, 313)
        Me.OverviewPanel.TabIndex = 12
        '
        'chckBoxSlot6
        '
        Me.chckBoxSlot6.AutoCheck = False
        Me.chckBoxSlot6.AutoSize = True
        Me.TransitionControl.SetDecoration(Me.chckBoxSlot6, BunifuAnimatorNS.DecorationType.None)
        Me.chckBoxSlot6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.chckBoxSlot6.ForeColor = System.Drawing.Color.Silver
        Me.chckBoxSlot6.Location = New System.Drawing.Point(435, 153)
        Me.chckBoxSlot6.Name = "chckBoxSlot6"
        Me.chckBoxSlot6.Size = New System.Drawing.Size(62, 25)
        Me.chckBoxSlot6.TabIndex = 109
        Me.chckBoxSlot6.Text = "Free"
        Me.chckBoxSlot6.UseVisualStyleBackColor = True
        '
        'chckBoxSlot5
        '
        Me.chckBoxSlot5.AutoCheck = False
        Me.chckBoxSlot5.AutoSize = True
        Me.TransitionControl.SetDecoration(Me.chckBoxSlot5, BunifuAnimatorNS.DecorationType.None)
        Me.chckBoxSlot5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.chckBoxSlot5.ForeColor = System.Drawing.Color.Silver
        Me.chckBoxSlot5.Location = New System.Drawing.Point(356, 153)
        Me.chckBoxSlot5.Name = "chckBoxSlot5"
        Me.chckBoxSlot5.Size = New System.Drawing.Size(62, 25)
        Me.chckBoxSlot5.TabIndex = 108
        Me.chckBoxSlot5.Text = "Free"
        Me.chckBoxSlot5.UseVisualStyleBackColor = True
        '
        'chckBoxSlot4
        '
        Me.chckBoxSlot4.AutoCheck = False
        Me.chckBoxSlot4.AutoSize = True
        Me.TransitionControl.SetDecoration(Me.chckBoxSlot4, BunifuAnimatorNS.DecorationType.None)
        Me.chckBoxSlot4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.chckBoxSlot4.ForeColor = System.Drawing.Color.Silver
        Me.chckBoxSlot4.Location = New System.Drawing.Point(277, 153)
        Me.chckBoxSlot4.Name = "chckBoxSlot4"
        Me.chckBoxSlot4.Size = New System.Drawing.Size(62, 25)
        Me.chckBoxSlot4.TabIndex = 107
        Me.chckBoxSlot4.Text = "Free"
        Me.chckBoxSlot4.UseVisualStyleBackColor = True
        '
        'chckBoxSlot3
        '
        Me.chckBoxSlot3.AutoCheck = False
        Me.chckBoxSlot3.AutoSize = True
        Me.TransitionControl.SetDecoration(Me.chckBoxSlot3, BunifuAnimatorNS.DecorationType.None)
        Me.chckBoxSlot3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.chckBoxSlot3.ForeColor = System.Drawing.Color.Silver
        Me.chckBoxSlot3.Location = New System.Drawing.Point(198, 153)
        Me.chckBoxSlot3.Name = "chckBoxSlot3"
        Me.chckBoxSlot3.Size = New System.Drawing.Size(62, 25)
        Me.chckBoxSlot3.TabIndex = 106
        Me.chckBoxSlot3.Text = "Free"
        Me.chckBoxSlot3.UseVisualStyleBackColor = True
        '
        'chckBoxSlot2
        '
        Me.chckBoxSlot2.AutoCheck = False
        Me.chckBoxSlot2.AutoSize = True
        Me.TransitionControl.SetDecoration(Me.chckBoxSlot2, BunifuAnimatorNS.DecorationType.None)
        Me.chckBoxSlot2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.chckBoxSlot2.ForeColor = System.Drawing.Color.Silver
        Me.chckBoxSlot2.Location = New System.Drawing.Point(119, 153)
        Me.chckBoxSlot2.Name = "chckBoxSlot2"
        Me.chckBoxSlot2.Size = New System.Drawing.Size(62, 25)
        Me.chckBoxSlot2.TabIndex = 105
        Me.chckBoxSlot2.Text = "Free"
        Me.chckBoxSlot2.UseVisualStyleBackColor = True
        '
        'chckBoxSlot1
        '
        Me.chckBoxSlot1.AutoCheck = False
        Me.chckBoxSlot1.AutoSize = True
        Me.TransitionControl.SetDecoration(Me.chckBoxSlot1, BunifuAnimatorNS.DecorationType.None)
        Me.chckBoxSlot1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.chckBoxSlot1.ForeColor = System.Drawing.Color.Silver
        Me.chckBoxSlot1.Location = New System.Drawing.Point(40, 153)
        Me.chckBoxSlot1.Name = "chckBoxSlot1"
        Me.chckBoxSlot1.Size = New System.Drawing.Size(62, 25)
        Me.chckBoxSlot1.TabIndex = 104
        Me.chckBoxSlot1.Text = "Free"
        Me.chckBoxSlot1.UseVisualStyleBackColor = True
        '
        'txtboxcData
        '
        Me.TransitionControl.SetDecoration(Me.txtboxcData, BunifuAnimatorNS.DecorationType.None)
        Me.txtboxcData.Location = New System.Drawing.Point(33, 188)
        Me.txtboxcData.Name = "txtboxcData"
        Me.txtboxcData.Size = New System.Drawing.Size(473, 20)
        Me.txtboxcData.TabIndex = 102
        Me.txtboxcData.Visible = False
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(185, 17)
        Me.BunifuCustomLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(179, 19)
        Me.BunifuCustomLabel6.TabIndex = 95
        Me.BunifuCustomLabel6.Text = ".:: List of Parking Slots ::."
        '
        'BunifuCustomLabel17
        '
        Me.BunifuCustomLabel17.AutoSize = True
        Me.BunifuCustomLabel17.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel17.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransitionControl.SetDecoration(Me.BunifuCustomLabel17, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel17.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel17.Location = New System.Drawing.Point(220, 269)
        Me.BunifuCustomLabel17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel17.Name = "BunifuCustomLabel17"
        Me.BunifuCustomLabel17.Size = New System.Drawing.Size(98, 21)
        Me.BunifuCustomLabel17.TabIndex = 100
        Me.BunifuCustomLabel17.Text = "Empty Slots"
        '
        'lblEmptySlot
        '
        Me.lblEmptySlot.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblEmptySlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmptySlot.color = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblEmptySlot.colorActive = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblEmptySlot.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TransitionControl.SetDecoration(Me.lblEmptySlot, BunifuAnimatorNS.DecorationType.None)
        Me.lblEmptySlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblEmptySlot.ForeColor = System.Drawing.Color.Silver
        Me.lblEmptySlot.Image = Nothing
        Me.lblEmptySlot.ImagePosition = 11
        Me.lblEmptySlot.ImageZoom = 50
        Me.lblEmptySlot.LabelPosition = 25
        Me.lblEmptySlot.LabelText = ""
        Me.lblEmptySlot.Location = New System.Drawing.Point(211, 224)
        Me.lblEmptySlot.Margin = New System.Windows.Forms.Padding(4)
        Me.lblEmptySlot.Name = "lblEmptySlot"
        Me.lblEmptySlot.Size = New System.Drawing.Size(117, 37)
        Me.lblEmptySlot.TabIndex = 96
        '
        'SlotPictureBox6
        '
        Me.SlotPictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.SlotPictureBox6, BunifuAnimatorNS.DecorationType.None)
        Me.SlotPictureBox6.Image = Global.Car_Parking_Monitoring_System.My.Resources.Resources.icons8_garage_64
        Me.SlotPictureBox6.Location = New System.Drawing.Point(435, 88)
        Me.SlotPictureBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.SlotPictureBox6.Name = "SlotPictureBox6"
        Me.SlotPictureBox6.Size = New System.Drawing.Size(60, 60)
        Me.SlotPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SlotPictureBox6.TabIndex = 17
        Me.SlotPictureBox6.TabStop = False
        '
        'SlotPictureBox5
        '
        Me.SlotPictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.SlotPictureBox5, BunifuAnimatorNS.DecorationType.None)
        Me.SlotPictureBox5.Image = Global.Car_Parking_Monitoring_System.My.Resources.Resources.icons8_garage_64
        Me.SlotPictureBox5.Location = New System.Drawing.Point(356, 88)
        Me.SlotPictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.SlotPictureBox5.Name = "SlotPictureBox5"
        Me.SlotPictureBox5.Size = New System.Drawing.Size(60, 60)
        Me.SlotPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SlotPictureBox5.TabIndex = 16
        Me.SlotPictureBox5.TabStop = False
        '
        'SlotPictureBox4
        '
        Me.SlotPictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.SlotPictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.SlotPictureBox4.Image = Global.Car_Parking_Monitoring_System.My.Resources.Resources.icons8_garage_64
        Me.SlotPictureBox4.Location = New System.Drawing.Point(277, 88)
        Me.SlotPictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.SlotPictureBox4.Name = "SlotPictureBox4"
        Me.SlotPictureBox4.Size = New System.Drawing.Size(60, 60)
        Me.SlotPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SlotPictureBox4.TabIndex = 15
        Me.SlotPictureBox4.TabStop = False
        '
        'SlotPictureBox3
        '
        Me.SlotPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.SlotPictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.SlotPictureBox3.Image = Global.Car_Parking_Monitoring_System.My.Resources.Resources.icons8_garage_64
        Me.SlotPictureBox3.Location = New System.Drawing.Point(198, 88)
        Me.SlotPictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.SlotPictureBox3.Name = "SlotPictureBox3"
        Me.SlotPictureBox3.Size = New System.Drawing.Size(60, 60)
        Me.SlotPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SlotPictureBox3.TabIndex = 14
        Me.SlotPictureBox3.TabStop = False
        '
        'SlotPictureBox2
        '
        Me.SlotPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.SlotPictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.SlotPictureBox2.Image = Global.Car_Parking_Monitoring_System.My.Resources.Resources.icons8_garage_64
        Me.SlotPictureBox2.Location = New System.Drawing.Point(119, 88)
        Me.SlotPictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.SlotPictureBox2.Name = "SlotPictureBox2"
        Me.SlotPictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.SlotPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SlotPictureBox2.TabIndex = 13
        Me.SlotPictureBox2.TabStop = False
        '
        'SlotPictureBox1
        '
        Me.SlotPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.SlotPictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.SlotPictureBox1.Image = Global.Car_Parking_Monitoring_System.My.Resources.Resources.icons8_garage_64
        Me.SlotPictureBox1.Location = New System.Drawing.Point(40, 88)
        Me.SlotPictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.SlotPictureBox1.Name = "SlotPictureBox1"
        Me.SlotPictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.SlotPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SlotPictureBox1.TabIndex = 12
        Me.SlotPictureBox1.TabStop = False
        '
        'InfoPanel
        '
        Me.InfoPanel.Controls.Add(Me.btnRefresh)
        Me.InfoPanel.Controls.Add(Me.OverviewBackPictureBox)
        Me.InfoPanel.Controls.Add(Me.BunifuCustomLabel4)
        Me.InfoPanel.Controls.Add(Me.lblSlotStatus)
        Me.InfoPanel.Controls.Add(Me.lblSlotNumber)
        Me.InfoPanel.Controls.Add(Me.SlotStatusPictureBox)
        Me.InfoPanel.Controls.Add(Me.BunifuCustomLabel20)
        Me.InfoPanel.Controls.Add(Me.BunifuCustomLabel21)
        Me.InfoPanel.Controls.Add(Me.PictureBox5)
        Me.InfoPanel.Controls.Add(Me.lblTimeOut)
        Me.InfoPanel.Controls.Add(Me.PictureBox6)
        Me.InfoPanel.Controls.Add(Me.lblTimeIn)
        Me.InfoPanel.Controls.Add(Me.BunifuCustomLabel19)
        Me.InfoPanel.Controls.Add(Me.PictureBox4)
        Me.InfoPanel.Controls.Add(Me.lblRFID)
        Me.TransitionControl.SetDecoration(Me.InfoPanel, BunifuAnimatorNS.DecorationType.None)
        Me.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoPanel.Location = New System.Drawing.Point(0, 0)
        Me.InfoPanel.Name = "InfoPanel"
        Me.InfoPanel.Size = New System.Drawing.Size(539, 313)
        Me.InfoPanel.TabIndex = 14
        '
        'btnRefresh
        '
        Me.TransitionControl.SetDecoration(Me.btnRefresh, BunifuAnimatorNS.DecorationType.None)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.Silver
        Me.btnRefresh.Location = New System.Drawing.Point(368, 251)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(134, 39)
        Me.btnRefresh.TabIndex = 106
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'OverviewBackPictureBox
        '
        Me.OverviewBackPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.OverviewBackPictureBox, BunifuAnimatorNS.DecorationType.None)
        Me.OverviewBackPictureBox.Image = CType(resources.GetObject("OverviewBackPictureBox.Image"), System.Drawing.Image)
        Me.OverviewBackPictureBox.Location = New System.Drawing.Point(17, 17)
        Me.OverviewBackPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.OverviewBackPictureBox.Name = "OverviewBackPictureBox"
        Me.OverviewBackPictureBox.Size = New System.Drawing.Size(30, 30)
        Me.OverviewBackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OverviewBackPictureBox.TabIndex = 105
        Me.OverviewBackPictureBox.TabStop = False
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransitionControl.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(169, 17)
        Me.BunifuCustomLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(206, 19)
        Me.BunifuCustomLabel4.TabIndex = 43
        Me.BunifuCustomLabel4.Text = ".:: Customer Information ::."
        '
        'lblSlotStatus
        '
        Me.lblSlotStatus.AutoSize = True
        Me.lblSlotStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransitionControl.SetDecoration(Me.lblSlotStatus, BunifuAnimatorNS.DecorationType.None)
        Me.lblSlotStatus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlotStatus.ForeColor = System.Drawing.Color.Silver
        Me.lblSlotStatus.Location = New System.Drawing.Point(101, 64)
        Me.lblSlotStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSlotStatus.Name = "lblSlotStatus"
        Me.lblSlotStatus.Size = New System.Drawing.Size(43, 21)
        Me.lblSlotStatus.TabIndex = 104
        Me.lblSlotStatus.Text = "Free"
        '
        'lblSlotNumber
        '
        Me.lblSlotNumber.AutoSize = True
        Me.lblSlotNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransitionControl.SetDecoration(Me.lblSlotNumber, BunifuAnimatorNS.DecorationType.None)
        Me.lblSlotNumber.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlotNumber.ForeColor = System.Drawing.Color.Silver
        Me.lblSlotNumber.Location = New System.Drawing.Point(63, 212)
        Me.lblSlotNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSlotNumber.Name = "lblSlotNumber"
        Me.lblSlotNumber.Size = New System.Drawing.Size(123, 21)
        Me.lblSlotNumber.TabIndex = 103
        Me.lblSlotNumber.Text = "Slot Number: --"
        '
        'SlotStatusPictureBox
        '
        Me.TransitionControl.SetDecoration(Me.SlotStatusPictureBox, BunifuAnimatorNS.DecorationType.None)
        Me.SlotStatusPictureBox.Image = Global.Car_Parking_Monitoring_System.My.Resources.Resources.icons8_garage_64
        Me.SlotStatusPictureBox.Location = New System.Drawing.Point(61, 89)
        Me.SlotStatusPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SlotStatusPictureBox.Name = "SlotStatusPictureBox"
        Me.SlotStatusPictureBox.Size = New System.Drawing.Size(120, 120)
        Me.SlotStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlotStatusPictureBox.TabIndex = 102
        Me.SlotStatusPictureBox.TabStop = False
        '
        'BunifuCustomLabel20
        '
        Me.BunifuCustomLabel20.AutoSize = True
        Me.BunifuCustomLabel20.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransitionControl.SetDecoration(Me.BunifuCustomLabel20, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel20.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel20.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel20.Location = New System.Drawing.Point(220, 179)
        Me.BunifuCustomLabel20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel20.Name = "BunifuCustomLabel20"
        Me.BunifuCustomLabel20.Size = New System.Drawing.Size(81, 21)
        Me.BunifuCustomLabel20.TabIndex = 101
        Me.BunifuCustomLabel20.Text = "Time Out"
        '
        'BunifuCustomLabel21
        '
        Me.BunifuCustomLabel21.AutoSize = True
        Me.BunifuCustomLabel21.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransitionControl.SetDecoration(Me.BunifuCustomLabel21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel21.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel21.Location = New System.Drawing.Point(237, 137)
        Me.BunifuCustomLabel21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel21.Name = "BunifuCustomLabel21"
        Me.BunifuCustomLabel21.Size = New System.Drawing.Size(65, 21)
        Me.BunifuCustomLabel21.TabIndex = 100
        Me.BunifuCustomLabel21.Text = "Time In"
        '
        'PictureBox5
        '
        Me.TransitionControl.SetDecoration(Me.PictureBox5, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(463, 169)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(39, 36)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 99
        Me.PictureBox5.TabStop = False
        '
        'lblTimeOut
        '
        Me.lblTimeOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimeOut.color = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblTimeOut.colorActive = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblTimeOut.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TransitionControl.SetDecoration(Me.lblTimeOut, BunifuAnimatorNS.DecorationType.None)
        Me.lblTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTimeOut.ForeColor = System.Drawing.Color.Silver
        Me.lblTimeOut.Image = Nothing
        Me.lblTimeOut.ImagePosition = 11
        Me.lblTimeOut.ImageZoom = 50
        Me.lblTimeOut.LabelPosition = 25
        Me.lblTimeOut.LabelText = ""
        Me.lblTimeOut.Location = New System.Drawing.Point(310, 169)
        Me.lblTimeOut.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.Size = New System.Drawing.Size(148, 37)
        Me.lblTimeOut.TabIndex = 98
        '
        'PictureBox6
        '
        Me.TransitionControl.SetDecoration(Me.PictureBox6, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(463, 129)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(39, 36)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 97
        Me.PictureBox6.TabStop = False
        '
        'lblTimeIn
        '
        Me.lblTimeIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblTimeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimeIn.color = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblTimeIn.colorActive = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblTimeIn.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TransitionControl.SetDecoration(Me.lblTimeIn, BunifuAnimatorNS.DecorationType.None)
        Me.lblTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTimeIn.ForeColor = System.Drawing.Color.Silver
        Me.lblTimeIn.Image = Nothing
        Me.lblTimeIn.ImagePosition = 11
        Me.lblTimeIn.ImageZoom = 50
        Me.lblTimeIn.LabelPosition = 25
        Me.lblTimeIn.LabelText = ""
        Me.lblTimeIn.Location = New System.Drawing.Point(310, 129)
        Me.lblTimeIn.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTimeIn.Name = "lblTimeIn"
        Me.lblTimeIn.Size = New System.Drawing.Size(148, 37)
        Me.lblTimeIn.TabIndex = 96
        '
        'BunifuCustomLabel19
        '
        Me.BunifuCustomLabel19.AutoSize = True
        Me.BunifuCustomLabel19.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel19.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransitionControl.SetDecoration(Me.BunifuCustomLabel19, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel19.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel19.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel19.Location = New System.Drawing.Point(256, 96)
        Me.BunifuCustomLabel19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel19.Name = "BunifuCustomLabel19"
        Me.BunifuCustomLabel19.Size = New System.Drawing.Size(45, 21)
        Me.BunifuCustomLabel19.TabIndex = 95
        Me.BunifuCustomLabel19.Text = "RFID"
        '
        'PictureBox4
        '
        Me.TransitionControl.SetDecoration(Me.PictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(463, 89)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(39, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 95
        Me.PictureBox4.TabStop = False
        '
        'lblRFID
        '
        Me.lblRFID.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRFID.color = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblRFID.colorActive = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblRFID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TransitionControl.SetDecoration(Me.lblRFID, BunifuAnimatorNS.DecorationType.None)
        Me.lblRFID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblRFID.ForeColor = System.Drawing.Color.Silver
        Me.lblRFID.Image = Nothing
        Me.lblRFID.ImagePosition = 11
        Me.lblRFID.ImageZoom = 50
        Me.lblRFID.LabelPosition = 25
        Me.lblRFID.LabelText = ""
        Me.lblRFID.Location = New System.Drawing.Point(310, 89)
        Me.lblRFID.Margin = New System.Windows.Forms.Padding(4)
        Me.lblRFID.Name = "lblRFID"
        Me.lblRFID.Size = New System.Drawing.Size(148, 37)
        Me.lblRFID.TabIndex = 94
        '
        'ExportPanel
        '
        Me.ExportPanel.Controls.Add(Me.ZoomOutPictureBox)
        Me.ExportPanel.Controls.Add(Me.ZoomInPictureBox)
        Me.ExportPanel.Controls.Add(Me.btnRefreshFile)
        Me.ExportPanel.Controls.Add(Me.btnSaveFile)
        Me.ExportPanel.Controls.Add(Me.PrintPreviewControl1)
        Me.TransitionControl.SetDecoration(Me.ExportPanel, BunifuAnimatorNS.DecorationType.None)
        Me.ExportPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExportPanel.Location = New System.Drawing.Point(0, 0)
        Me.ExportPanel.Name = "ExportPanel"
        Me.ExportPanel.Size = New System.Drawing.Size(539, 313)
        Me.ExportPanel.TabIndex = 110
        '
        'ZoomOutPictureBox
        '
        Me.ZoomOutPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.ZoomOutPictureBox, BunifuAnimatorNS.DecorationType.None)
        Me.ZoomOutPictureBox.Image = CType(resources.GetObject("ZoomOutPictureBox.Image"), System.Drawing.Image)
        Me.ZoomOutPictureBox.Location = New System.Drawing.Point(48, 269)
        Me.ZoomOutPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ZoomOutPictureBox.Name = "ZoomOutPictureBox"
        Me.ZoomOutPictureBox.Size = New System.Drawing.Size(30, 30)
        Me.ZoomOutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ZoomOutPictureBox.TabIndex = 15
        Me.ZoomOutPictureBox.TabStop = False
        '
        'ZoomInPictureBox
        '
        Me.ZoomInPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.ZoomInPictureBox, BunifuAnimatorNS.DecorationType.None)
        Me.ZoomInPictureBox.Image = CType(resources.GetObject("ZoomInPictureBox.Image"), System.Drawing.Image)
        Me.ZoomInPictureBox.Location = New System.Drawing.Point(14, 269)
        Me.ZoomInPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ZoomInPictureBox.Name = "ZoomInPictureBox"
        Me.ZoomInPictureBox.Size = New System.Drawing.Size(30, 30)
        Me.ZoomInPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ZoomInPictureBox.TabIndex = 14
        Me.ZoomInPictureBox.TabStop = False
        '
        'btnRefreshFile
        '
        Me.TransitionControl.SetDecoration(Me.btnRefreshFile, BunifuAnimatorNS.DecorationType.None)
        Me.btnRefreshFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshFile.ForeColor = System.Drawing.Color.Silver
        Me.btnRefreshFile.Location = New System.Drawing.Point(434, 269)
        Me.btnRefreshFile.Name = "btnRefreshFile"
        Me.btnRefreshFile.Size = New System.Drawing.Size(90, 30)
        Me.btnRefreshFile.TabIndex = 2
        Me.btnRefreshFile.Text = "Refresh"
        Me.btnRefreshFile.UseVisualStyleBackColor = True
        '
        'btnSaveFile
        '
        Me.TransitionControl.SetDecoration(Me.btnSaveFile, BunifuAnimatorNS.DecorationType.None)
        Me.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveFile.ForeColor = System.Drawing.Color.Silver
        Me.btnSaveFile.Location = New System.Drawing.Point(338, 269)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(90, 30)
        Me.btnSaveFile.TabIndex = 1
        Me.btnSaveFile.Text = "Save"
        Me.btnSaveFile.UseVisualStyleBackColor = True
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.TransitionControl.SetDecoration(Me.PrintPreviewControl1, BunifuAnimatorNS.DecorationType.None)
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(14, 17)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(510, 244)
        Me.PrintPreviewControl1.TabIndex = 0
        Me.PrintPreviewControl1.Zoom = 1.0R
        '
        'SearchPanel
        '
        Me.SearchPanel.Controls.Add(Me.GroupBox1)
        Me.SearchPanel.Controls.Add(Me.searchDataGrid)
        Me.SearchPanel.Controls.Add(Me.BunifuCustomLabel2)
        Me.SearchPanel.Controls.Add(Me.GroupBox2)
        Me.SearchPanel.Controls.Add(Me.GroupBox3)
        Me.TransitionControl.SetDecoration(Me.SearchPanel, BunifuAnimatorNS.DecorationType.None)
        Me.SearchPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchPanel.Location = New System.Drawing.Point(0, 0)
        Me.SearchPanel.Name = "SearchPanel"
        Me.SearchPanel.Size = New System.Drawing.Size(539, 313)
        Me.SearchPanel.TabIndex = 111
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radStatusSearch)
        Me.GroupBox1.Controls.Add(Me.radSlotNumberSearch)
        Me.TransitionControl.SetDecoration(Me.GroupBox1, BunifuAnimatorNS.DecorationType.None)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(14, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 65)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Type"
        '
        'radStatusSearch
        '
        Me.radStatusSearch.AutoSize = True
        Me.TransitionControl.SetDecoration(Me.radStatusSearch, BunifuAnimatorNS.DecorationType.None)
        Me.radStatusSearch.Location = New System.Drawing.Point(133, 27)
        Me.radStatusSearch.Name = "radStatusSearch"
        Me.radStatusSearch.Size = New System.Drawing.Size(68, 22)
        Me.radStatusSearch.TabIndex = 1
        Me.radStatusSearch.Text = "Status"
        Me.radStatusSearch.UseVisualStyleBackColor = True
        '
        'radSlotNumberSearch
        '
        Me.radSlotNumberSearch.AutoSize = True
        Me.radSlotNumberSearch.Checked = True
        Me.TransitionControl.SetDecoration(Me.radSlotNumberSearch, BunifuAnimatorNS.DecorationType.None)
        Me.radSlotNumberSearch.Location = New System.Drawing.Point(13, 27)
        Me.radSlotNumberSearch.Name = "radSlotNumberSearch"
        Me.radSlotNumberSearch.Size = New System.Drawing.Size(109, 22)
        Me.radSlotNumberSearch.TabIndex = 0
        Me.radSlotNumberSearch.TabStop = True
        Me.radSlotNumberSearch.Text = "Slot Number"
        Me.radSlotNumberSearch.UseVisualStyleBackColor = True
        '
        'searchDataGrid
        '
        Me.searchDataGrid.AllowUserToAddRows = False
        Me.searchDataGrid.AllowUserToDeleteRows = False
        Me.searchDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.searchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransitionControl.SetDecoration(Me.searchDataGrid, BunifuAnimatorNS.DecorationType.None)
        Me.searchDataGrid.Location = New System.Drawing.Point(14, 129)
        Me.searchDataGrid.Name = "searchDataGrid"
        Me.searchDataGrid.ReadOnly = True
        Me.searchDataGrid.Size = New System.Drawing.Size(510, 170)
        Me.searchDataGrid.TabIndex = 108
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransitionControl.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(179, 17)
        Me.BunifuCustomLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(187, 19)
        Me.BunifuCustomLabel2.TabIndex = 107
        Me.BunifuCustomLabel2.Text = ".:: Search Information ::."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbSlotSelection)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox2.Controls.Add(Me.btnSlotNumberSearch)
        Me.TransitionControl.SetDecoration(Me.GroupBox2, BunifuAnimatorNS.DecorationType.None)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox2.Location = New System.Drawing.Point(232, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 65)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Slot Number Search"
        '
        'cmbSlotSelection
        '
        Me.cmbSlotSelection.BackColor = System.Drawing.Color.Transparent
        Me.cmbSlotSelection.BorderRadius = 3
        Me.TransitionControl.SetDecoration(Me.cmbSlotSelection, BunifuAnimatorNS.DecorationType.None)
        Me.cmbSlotSelection.DisabledColor = System.Drawing.Color.Gray
        Me.cmbSlotSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbSlotSelection.ForeColor = System.Drawing.Color.White
        Me.cmbSlotSelection.Items = New String() {"1", "2", "3", "4", "5", "6"}
        Me.cmbSlotSelection.Location = New System.Drawing.Point(75, 25)
        Me.cmbSlotSelection.Name = "cmbSlotSelection"
        Me.cmbSlotSelection.NomalColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cmbSlotSelection.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.cmbSlotSelection.selectedIndex = 0
        Me.cmbSlotSelection.Size = New System.Drawing.Size(83, 29)
        Me.cmbSlotSelection.TabIndex = 109
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransitionControl.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(31, 29)
        Me.BunifuCustomLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(38, 18)
        Me.BunifuCustomLabel3.TabIndex = 110
        Me.BunifuCustomLabel3.Text = "Slot:"
        '
        'btnSlotNumberSearch
        '
        Me.btnSlotNumberSearch.Activecolor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSlotNumberSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSlotNumberSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSlotNumberSearch.BorderRadius = 0
        Me.btnSlotNumberSearch.ButtonText = "Search"
        Me.btnSlotNumberSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.btnSlotNumberSearch, BunifuAnimatorNS.DecorationType.None)
        Me.btnSlotNumberSearch.DisabledColor = System.Drawing.Color.Gray
        Me.btnSlotNumberSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnSlotNumberSearch.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSlotNumberSearch.Iconimage = Global.Car_Parking_Monitoring_System.My.Resources.Resources.Checkmark_28px
        Me.btnSlotNumberSearch.Iconimage_right = Nothing
        Me.btnSlotNumberSearch.Iconimage_right_Selected = Nothing
        Me.btnSlotNumberSearch.Iconimage_Selected = Nothing
        Me.btnSlotNumberSearch.IconMarginLeft = 0
        Me.btnSlotNumberSearch.IconMarginRight = 0
        Me.btnSlotNumberSearch.IconRightVisible = True
        Me.btnSlotNumberSearch.IconRightZoom = 0R
        Me.btnSlotNumberSearch.IconVisible = True
        Me.btnSlotNumberSearch.IconZoom = 50.0R
        Me.btnSlotNumberSearch.IsTab = False
        Me.btnSlotNumberSearch.Location = New System.Drawing.Point(165, 25)
        Me.btnSlotNumberSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSlotNumberSearch.Name = "btnSlotNumberSearch"
        Me.btnSlotNumberSearch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSlotNumberSearch.OnHovercolor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSlotNumberSearch.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSlotNumberSearch.selected = False
        Me.btnSlotNumberSearch.Size = New System.Drawing.Size(96, 29)
        Me.btnSlotNumberSearch.TabIndex = 111
        Me.btnSlotNumberSearch.Text = "Search"
        Me.btnSlotNumberSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSlotNumberSearch.Textcolor = System.Drawing.Color.White
        Me.btnSlotNumberSearch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnStatusSearch)
        Me.GroupBox3.Controls.Add(Me.cmbStatusSelection)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel5)
        Me.TransitionControl.SetDecoration(Me.GroupBox3, BunifuAnimatorNS.DecorationType.None)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox3.Location = New System.Drawing.Point(232, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(292, 65)
        Me.GroupBox3.TabIndex = 114
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status Search"
        '
        'btnStatusSearch
        '
        Me.btnStatusSearch.Activecolor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnStatusSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnStatusSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStatusSearch.BorderRadius = 0
        Me.btnStatusSearch.ButtonText = "Search"
        Me.btnStatusSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.btnStatusSearch, BunifuAnimatorNS.DecorationType.None)
        Me.btnStatusSearch.DisabledColor = System.Drawing.Color.Gray
        Me.btnStatusSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnStatusSearch.Iconcolor = System.Drawing.Color.Transparent
        Me.btnStatusSearch.Iconimage = Global.Car_Parking_Monitoring_System.My.Resources.Resources.Checkmark_28px
        Me.btnStatusSearch.Iconimage_right = Nothing
        Me.btnStatusSearch.Iconimage_right_Selected = Nothing
        Me.btnStatusSearch.Iconimage_Selected = Nothing
        Me.btnStatusSearch.IconMarginLeft = 0
        Me.btnStatusSearch.IconMarginRight = 0
        Me.btnStatusSearch.IconRightVisible = True
        Me.btnStatusSearch.IconRightZoom = 0R
        Me.btnStatusSearch.IconVisible = True
        Me.btnStatusSearch.IconZoom = 50.0R
        Me.btnStatusSearch.IsTab = False
        Me.btnStatusSearch.Location = New System.Drawing.Point(165, 25)
        Me.btnStatusSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStatusSearch.Name = "btnStatusSearch"
        Me.btnStatusSearch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnStatusSearch.OnHovercolor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnStatusSearch.OnHoverTextColor = System.Drawing.Color.White
        Me.btnStatusSearch.selected = False
        Me.btnStatusSearch.Size = New System.Drawing.Size(96, 29)
        Me.btnStatusSearch.TabIndex = 112
        Me.btnStatusSearch.Text = "Search"
        Me.btnStatusSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatusSearch.Textcolor = System.Drawing.Color.White
        Me.btnStatusSearch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cmbStatusSelection
        '
        Me.cmbStatusSelection.BackColor = System.Drawing.Color.Transparent
        Me.cmbStatusSelection.BorderRadius = 3
        Me.TransitionControl.SetDecoration(Me.cmbStatusSelection, BunifuAnimatorNS.DecorationType.None)
        Me.cmbStatusSelection.DisabledColor = System.Drawing.Color.Gray
        Me.cmbStatusSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbStatusSelection.ForeColor = System.Drawing.Color.White
        Me.cmbStatusSelection.Items = New String() {"Free", "Full"}
        Me.cmbStatusSelection.Location = New System.Drawing.Point(75, 25)
        Me.cmbStatusSelection.Name = "cmbStatusSelection"
        Me.cmbStatusSelection.NomalColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cmbStatusSelection.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.cmbStatusSelection.selectedIndex = 0
        Me.cmbStatusSelection.Size = New System.Drawing.Size(83, 29)
        Me.cmbStatusSelection.TabIndex = 109
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransitionControl.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(14, 29)
        Me.BunifuCustomLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(54, 18)
        Me.BunifuCustomLabel5.TabIndex = 110
        Me.BunifuCustomLabel5.Text = "Status:"
        '
        'AdminPanel
        '
        Me.AdminPanel.Controls.Add(Me.BunifuCustomLabel7)
        Me.AdminPanel.Controls.Add(Me.btndbRefresh)
        Me.AdminPanel.Controls.Add(Me.adminDataGrid)
        Me.AdminPanel.Controls.Add(Me.btnlogTimeOut)
        Me.AdminPanel.Controls.Add(Me.btnlogTimeIn)
        Me.AdminPanel.Controls.Add(Me.btnMakeFree)
        Me.AdminPanel.Controls.Add(Me.btnMakeFull)
        Me.AdminPanel.Controls.Add(Me.Label2)
        Me.AdminPanel.Controls.Add(Me.cmbdbSlot)
        Me.TransitionControl.SetDecoration(Me.AdminPanel, BunifuAnimatorNS.DecorationType.None)
        Me.AdminPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminPanel.Location = New System.Drawing.Point(0, 0)
        Me.AdminPanel.Name = "AdminPanel"
        Me.AdminPanel.Size = New System.Drawing.Size(539, 313)
        Me.AdminPanel.TabIndex = 112
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransitionControl.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(184, 17)
        Me.BunifuCustomLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(182, 19)
        Me.BunifuCustomLabel7.TabIndex = 104
        Me.BunifuCustomLabel7.Text = ".:: Database Modifier ::."
        '
        'btndbRefresh
        '
        Me.TransitionControl.SetDecoration(Me.btndbRefresh, BunifuAnimatorNS.DecorationType.None)
        Me.btndbRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndbRefresh.ForeColor = System.Drawing.Color.Silver
        Me.btndbRefresh.Location = New System.Drawing.Point(337, 57)
        Me.btndbRefresh.Name = "btndbRefresh"
        Me.btndbRefresh.Size = New System.Drawing.Size(187, 52)
        Me.btndbRefresh.TabIndex = 103
        Me.btndbRefresh.Text = "Refresh Data"
        Me.btndbRefresh.UseVisualStyleBackColor = True
        '
        'adminDataGrid
        '
        Me.adminDataGrid.AllowUserToAddRows = False
        Me.adminDataGrid.AllowUserToDeleteRows = False
        Me.adminDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.adminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransitionControl.SetDecoration(Me.adminDataGrid, BunifuAnimatorNS.DecorationType.None)
        Me.adminDataGrid.Location = New System.Drawing.Point(14, 120)
        Me.adminDataGrid.Name = "adminDataGrid"
        Me.adminDataGrid.ReadOnly = True
        Me.adminDataGrid.Size = New System.Drawing.Size(510, 173)
        Me.adminDataGrid.TabIndex = 102
        '
        'btnlogTimeOut
        '
        Me.TransitionControl.SetDecoration(Me.btnlogTimeOut, BunifuAnimatorNS.DecorationType.None)
        Me.btnlogTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogTimeOut.ForeColor = System.Drawing.Color.Silver
        Me.btnlogTimeOut.Location = New System.Drawing.Point(239, 86)
        Me.btnlogTimeOut.Name = "btnlogTimeOut"
        Me.btnlogTimeOut.Size = New System.Drawing.Size(92, 23)
        Me.btnlogTimeOut.TabIndex = 101
        Me.btnlogTimeOut.Text = "Time Out"
        Me.btnlogTimeOut.UseVisualStyleBackColor = True
        '
        'btnlogTimeIn
        '
        Me.TransitionControl.SetDecoration(Me.btnlogTimeIn, BunifuAnimatorNS.DecorationType.None)
        Me.btnlogTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogTimeIn.ForeColor = System.Drawing.Color.Silver
        Me.btnlogTimeIn.Location = New System.Drawing.Point(141, 86)
        Me.btnlogTimeIn.Name = "btnlogTimeIn"
        Me.btnlogTimeIn.Size = New System.Drawing.Size(92, 23)
        Me.btnlogTimeIn.TabIndex = 100
        Me.btnlogTimeIn.Text = "Time In"
        Me.btnlogTimeIn.UseVisualStyleBackColor = True
        '
        'btnMakeFree
        '
        Me.TransitionControl.SetDecoration(Me.btnMakeFree, BunifuAnimatorNS.DecorationType.None)
        Me.btnMakeFree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMakeFree.ForeColor = System.Drawing.Color.Silver
        Me.btnMakeFree.Location = New System.Drawing.Point(239, 57)
        Me.btnMakeFree.Name = "btnMakeFree"
        Me.btnMakeFree.Size = New System.Drawing.Size(92, 23)
        Me.btnMakeFree.TabIndex = 99
        Me.btnMakeFree.Text = "Free Slot"
        Me.btnMakeFree.UseVisualStyleBackColor = True
        '
        'btnMakeFull
        '
        Me.TransitionControl.SetDecoration(Me.btnMakeFull, BunifuAnimatorNS.DecorationType.None)
        Me.btnMakeFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMakeFull.ForeColor = System.Drawing.Color.Silver
        Me.btnMakeFull.Location = New System.Drawing.Point(141, 57)
        Me.btnMakeFull.Name = "btnMakeFull"
        Me.btnMakeFull.Size = New System.Drawing.Size(92, 23)
        Me.btnMakeFull.TabIndex = 98
        Me.btnMakeFull.Text = "Full Slot"
        Me.btnMakeFull.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TransitionControl.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(19, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Slot:"
        '
        'cmbdbSlot
        '
        Me.TransitionControl.SetDecoration(Me.cmbdbSlot, BunifuAnimatorNS.DecorationType.None)
        Me.cmbdbSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdbSlot.FormattingEnabled = True
        Me.cmbdbSlot.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbdbSlot.Location = New System.Drawing.Point(67, 74)
        Me.cmbdbSlot.Name = "cmbdbSlot"
        Me.cmbdbSlot.Size = New System.Drawing.Size(59, 21)
        Me.cmbdbSlot.TabIndex = 96
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransitionControl.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.DataGridView1.Location = New System.Drawing.Point(-949, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(510, 88)
        Me.DataGridView1.TabIndex = 93
        '
        'TransitionControl
        '
        Me.TransitionControl.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.TransitionControl.Cursor = Nothing
        Animation8.AnimateOnlyDifferences = True
        Animation8.BlindCoeff = CType(resources.GetObject("Animation8.BlindCoeff"), System.Drawing.PointF)
        Animation8.LeafCoeff = 1.0!
        Animation8.MaxTime = 1.0!
        Animation8.MinTime = 0!
        Animation8.MosaicCoeff = CType(resources.GetObject("Animation8.MosaicCoeff"), System.Drawing.PointF)
        Animation8.MosaicShift = CType(resources.GetObject("Animation8.MosaicShift"), System.Drawing.PointF)
        Animation8.MosaicSize = 0
        Animation8.Padding = New System.Windows.Forms.Padding(0)
        Animation8.RotateCoeff = 0!
        Animation8.RotateLimit = 0!
        Animation8.ScaleCoeff = CType(resources.GetObject("Animation8.ScaleCoeff"), System.Drawing.PointF)
        Animation8.SlideCoeff = CType(resources.GetObject("Animation8.SlideCoeff"), System.Drawing.PointF)
        Animation8.TimeCoeff = 0!
        Animation8.TransparencyCoeff = 0!
        Me.TransitionControl.DefaultAnimation = Animation8
        '
        'LineSeparator
        '
        Me.LineSeparator.BackColor = System.Drawing.Color.Transparent
        Me.TransitionControl.SetDecoration(Me.LineSeparator, BunifuAnimatorNS.DecorationType.None)
        Me.LineSeparator.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.LineSeparator.LineThickness = 1
        Me.LineSeparator.Location = New System.Drawing.Point(12, 59)
        Me.LineSeparator.Name = "LineSeparator"
        Me.LineSeparator.Size = New System.Drawing.Size(85, 35)
        Me.LineSeparator.TabIndex = 21
        Me.LineSeparator.Transparency = 255
        Me.LineSeparator.Vertical = False
        '
        'OverviewLabel
        '
        Me.OverviewLabel.AutoSize = True
        Me.OverviewLabel.BackColor = System.Drawing.Color.Transparent
        Me.OverviewLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.OverviewLabel, BunifuAnimatorNS.DecorationType.None)
        Me.OverviewLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverviewLabel.ForeColor = System.Drawing.Color.Silver
        Me.OverviewLabel.Location = New System.Drawing.Point(12, 48)
        Me.OverviewLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.OverviewLabel.Name = "OverviewLabel"
        Me.OverviewLabel.Size = New System.Drawing.Size(86, 21)
        Me.OverviewLabel.TabIndex = 22
        Me.OverviewLabel.Text = "Overview"
        '
        'InformationLabel
        '
        Me.InformationLabel.AutoSize = True
        Me.InformationLabel.BackColor = System.Drawing.Color.Transparent
        Me.InformationLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.InformationLabel, BunifuAnimatorNS.DecorationType.None)
        Me.InformationLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformationLabel.ForeColor = System.Drawing.Color.Silver
        Me.InformationLabel.Location = New System.Drawing.Point(100, 48)
        Me.InformationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.InformationLabel.Name = "InformationLabel"
        Me.InformationLabel.Size = New System.Drawing.Size(101, 21)
        Me.InformationLabel.TabIndex = 94
        Me.InformationLabel.Text = "Information"
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.BackColor = System.Drawing.Color.Transparent
        Me.SearchLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.SearchLabel, BunifuAnimatorNS.DecorationType.None)
        Me.SearchLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.ForeColor = System.Drawing.Color.Silver
        Me.SearchLabel.Location = New System.Drawing.Point(269, 48)
        Me.SearchLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(64, 21)
        Me.SearchLabel.TabIndex = 95
        Me.SearchLabel.Text = "Search"
        '
        'ExportLabel
        '
        Me.ExportLabel.AutoSize = True
        Me.ExportLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExportLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.ExportLabel, BunifuAnimatorNS.DecorationType.None)
        Me.ExportLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportLabel.ForeColor = System.Drawing.Color.Silver
        Me.ExportLabel.Location = New System.Drawing.Point(205, 48)
        Me.ExportLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ExportLabel.Name = "ExportLabel"
        Me.ExportLabel.Size = New System.Drawing.Size(60, 21)
        Me.ExportLabel.TabIndex = 96
        Me.ExportLabel.Text = "Export"
        '
        'AdminLabel
        '
        Me.AdminLabel.AutoSize = True
        Me.AdminLabel.BackColor = System.Drawing.Color.Transparent
        Me.AdminLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionControl.SetDecoration(Me.AdminLabel, BunifuAnimatorNS.DecorationType.None)
        Me.AdminLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel.ForeColor = System.Drawing.Color.Silver
        Me.AdminLabel.Location = New System.Drawing.Point(337, 48)
        Me.AdminLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AdminLabel.Name = "AdminLabel"
        Me.AdminLabel.Size = New System.Drawing.Size(62, 21)
        Me.AdminLabel.TabIndex = 97
        Me.AdminLabel.Text = "Admin"
        '
        'DataReceiver
        '
        Me.DataReceiver.Interval = 1000
        '
        'SerialPort1
        '
        '
        'PrintDocument1
        '
        '
        'Misc
        '
        Me.Misc.Enabled = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(560, 403)
        Me.Controls.Add(Me.AdminLabel)
        Me.Controls.Add(Me.ExportLabel)
        Me.Controls.Add(Me.SearchLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.InformationLabel)
        Me.Controls.Add(Me.OverviewLabel)
        Me.Controls.Add(Me.DragPanel)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.LineSeparator)
        Me.TransitionControl.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:: Car Parking Monitoring System ::."
        Me.DragPanel.ResumeLayout(False)
        Me.DragPanel.PerformLayout()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.OverviewPanel.ResumeLayout(False)
        Me.OverviewPanel.PerformLayout()
        CType(Me.SlotPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlotPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlotPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlotPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlotPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlotPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfoPanel.ResumeLayout(False)
        Me.InfoPanel.PerformLayout()
        CType(Me.OverviewBackPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlotStatusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExportPanel.ResumeLayout(False)
        CType(Me.ZoomOutPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZoomInPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchPanel.ResumeLayout(False)
        Me.SearchPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.searchDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.AdminPanel.ResumeLayout(False)
        Me.AdminPanel.PerformLayout()
        CType(Me.adminDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DragPanel As Panel
    Friend WithEvents ApplicationIcon As PictureBox
    Friend WithEvents ApplicationName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents MinimizeButton As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ExitButton As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents DragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents MainPanel As Panel
    Friend WithEvents OverviewPanel As Panel
    Friend WithEvents SlotPictureBox6 As PictureBox
    Friend WithEvents SlotPictureBox5 As PictureBox
    Friend WithEvents SlotPictureBox4 As PictureBox
    Friend WithEvents SlotPictureBox3 As PictureBox
    Friend WithEvents SlotPictureBox2 As PictureBox
    Friend WithEvents SlotPictureBox1 As PictureBox
    Friend WithEvents TransitionControl As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents LineSeparator As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents OverviewLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BunifuCustomLabel17 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblEmptySlot As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents InfoPanel As Panel
    Friend WithEvents InformationLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblSlotStatus As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblSlotNumber As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SlotStatusPictureBox As PictureBox
    Friend WithEvents BunifuCustomLabel20 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel21 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblTimeOut As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblTimeIn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuCustomLabel19 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblRFID As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SearchLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DataReceiver As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents txtboxcData As TextBox
    Friend WithEvents chckBoxSlot6 As CheckBox
    Friend WithEvents chckBoxSlot5 As CheckBox
    Friend WithEvents chckBoxSlot4 As CheckBox
    Friend WithEvents chckBoxSlot3 As CheckBox
    Friend WithEvents chckBoxSlot2 As CheckBox
    Friend WithEvents chckBoxSlot1 As CheckBox
    Friend WithEvents OverviewBackPictureBox As PictureBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents ExportPanel As Panel
    Friend WithEvents btnRefreshFile As Button
    Friend WithEvents btnSaveFile As Button
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents ExportLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ZoomOutPictureBox As PictureBox
    Friend WithEvents ZoomInPictureBox As PictureBox
    Friend WithEvents SearchPanel As Panel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cmbSlotSelection As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents searchDataGrid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radStatusSearch As RadioButton
    Friend WithEvents radSlotNumberSearch As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSlotNumberSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnStatusSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cmbStatusSelection As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Misc As Timer
    Friend WithEvents AdminLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents AdminPanel As Panel
    Friend WithEvents btndbRefresh As Button
    Friend WithEvents adminDataGrid As DataGridView
    Friend WithEvents btnlogTimeOut As Button
    Friend WithEvents btnlogTimeIn As Button
    Friend WithEvents btnMakeFree As Button
    Friend WithEvents btnMakeFull As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbdbSlot As ComboBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
