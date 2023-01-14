<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.ExportLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DragPanel = New System.Windows.Forms.Panel()
        Me.ExitButton = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ApplicationName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ApplicationIcon = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtboxUser = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtboxPass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.DragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DragPanel.SuspendLayout()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExportLabel
        '
        Me.ExportLabel.AutoSize = True
        Me.ExportLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExportLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExportLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportLabel.ForeColor = System.Drawing.Color.Silver
        Me.ExportLabel.Location = New System.Drawing.Point(163, 73)
        Me.ExportLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ExportLabel.Name = "ExportLabel"
        Me.ExportLabel.Size = New System.Drawing.Size(92, 21)
        Me.ExportLabel.TabIndex = 97
        Me.ExportLabel.Text = "Username:"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(169, 114)
        Me.BunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(86, 21)
        Me.BunifuCustomLabel1.TabIndex = 99
        Me.BunifuCustomLabel1.Text = "Password:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 100
        Me.PictureBox1.TabStop = False
        '
        'DragPanel
        '
        Me.DragPanel.Controls.Add(Me.ExitButton)
        Me.DragPanel.Controls.Add(Me.ApplicationName)
        Me.DragPanel.Controls.Add(Me.ApplicationIcon)
        Me.DragPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DragPanel.Location = New System.Drawing.Point(0, 0)
        Me.DragPanel.Name = "DragPanel"
        Me.DragPanel.Size = New System.Drawing.Size(462, 35)
        Me.DragPanel.TabIndex = 101
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.ImageActive = Nothing
        Me.ExitButton.Location = New System.Drawing.Point(421, 2)
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
        Me.ApplicationName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationName.ForeColor = System.Drawing.Color.Silver
        Me.ApplicationName.Location = New System.Drawing.Point(48, 7)
        Me.ApplicationName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ApplicationName.Name = "ApplicationName"
        Me.ApplicationName.Size = New System.Drawing.Size(139, 21)
        Me.ApplicationName.TabIndex = 40
        Me.ApplicationName.Text = ".:: Admin Login ::."
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
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(349, 161)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(84, 28)
        Me.btnLogin.TabIndex = 102
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtboxUser
        '
        Me.txtboxUser.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtboxUser.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtboxUser.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtboxUser.BorderThickness = 3
        Me.txtboxUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxUser.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtboxUser.ForeColor = System.Drawing.Color.Silver
        Me.txtboxUser.isPassword = False
        Me.txtboxUser.Location = New System.Drawing.Point(261, 69)
        Me.txtboxUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxUser.Name = "txtboxUser"
        Me.txtboxUser.Size = New System.Drawing.Size(172, 25)
        Me.txtboxUser.TabIndex = 105
        Me.txtboxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxPass
        '
        Me.txtboxPass.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtboxPass.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtboxPass.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtboxPass.BorderThickness = 3
        Me.txtboxPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxPass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtboxPass.ForeColor = System.Drawing.Color.Silver
        Me.txtboxPass.isPassword = True
        Me.txtboxPass.Location = New System.Drawing.Point(261, 110)
        Me.txtboxPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxPass.Name = "txtboxPass"
        Me.txtboxPass.Size = New System.Drawing.Size(172, 25)
        Me.txtboxPass.TabIndex = 106
        Me.txtboxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DragControl
        '
        Me.DragControl.Fixed = True
        Me.DragControl.Horizontal = True
        Me.DragControl.TargetControl = Me.DragPanel
        Me.DragControl.Vertical = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(462, 201)
        Me.Controls.Add(Me.txtboxPass)
        Me.Controls.Add(Me.txtboxUser)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.DragPanel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.ExportLabel)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DragPanel.ResumeLayout(False)
        Me.DragPanel.PerformLayout()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExportLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DragPanel As Panel
    Friend WithEvents ExitButton As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ApplicationName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ApplicationIcon As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtboxUser As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtboxPass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents DragControl As Bunifu.Framework.UI.BunifuDragControl
End Class
