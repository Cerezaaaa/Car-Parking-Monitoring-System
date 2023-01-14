Imports System.Drawing.Printing
Imports System.IO
Imports System.IO.File
Imports System.IO.Ports
Imports MySql.Data.MySqlClient

Public Class frmMain

    Private sqlQuery As New ExecQueryFunctions

    Delegate Sub settextcallback(ByVal [text] As String)

    Dim slot As Integer

#Region "Form Load [Connect Port]"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectToArduino()
    End Sub
#End Region

#Region "Form Closing [Close Port]"
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If SerialPort1.IsOpen = True Then
            SerialPort1.Close()
            SerialPort1.Dispose()
        End If
    End Sub
#End Region

#Region "Function [Connect Arduino]"
    Private Sub ConnectToArduino()
        SerialPort1.BaudRate = GlobalClass.ArduinoBaud
        SerialPort1.PortName = GlobalClass.ArduinoPort
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default
        SerialPort1.Close()
        Try
            SerialPort1.Open()
            ShowAlert("Retrieving Data", frmNotify.AlertTypeEnum.Info)
        Catch ex As Exception

        Finally
            DataReceiver.Start()
        End Try

    End Sub
#End Region

#Region "Show Alert [ Notify ]"
    Public Sub ShowAlert(msg As String, type As frmNotify.AlertTypeEnum)
        If (Application.OpenForms.OfType(Of frmNotify).Count() = 1) Then
            Application.OpenForms.OfType(Of frmNotify).First().Close()
        End If
        If (Application.OpenForms.OfType(Of frmNotify).Count() = 0) Then
            Dim f As frmNotify = New frmNotify
            f.SetAlert(msg, type)
        End If
    End Sub
#End Region

#Region "Application [ Minimize | Exit ]"
    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub
#End Region

#Region "Application [ Overview | Information | Export ]"
    Private Sub OverviewLabel_Click(sender As Object, e As EventArgs) Handles OverviewLabel.Click
        GoToOverview()
    End Sub

    Private Sub InformationLabel_Click(sender As Object, e As EventArgs) Handles InformationLabel.Click
        If slot = Nothing Then
            ShowAlert("Double Click a slot on Overview tab", frmNotify.AlertTypeEnum.Error)
        Else
            GoToInfo()
        End If
    End Sub

    Private Sub GoToOverview()
        LineSeparator.Width = OverviewLabel.Width
        LineSeparator.Left = OverviewLabel.Left
        OverviewPanel.Visible = False
        OverviewPanel.BringToFront()
        InfoPanel.Hide()
        ExportPanel.Hide()
        AdminPanel.Hide()
        SearchPanel.Hide()
        TransitionControl.ShowSync(OverviewPanel)
        GlobalClass.access = 0
    End Sub

    Private Sub GoToInfo()
        LineSeparator.Width = InformationLabel.Width
        LineSeparator.Left = InformationLabel.Left
        InfoPanel.Visible = False
        InfoPanel.BringToFront()
        OverviewPanel.Hide()
        ExportPanel.Hide()
        SearchPanel.Hide()
        AdminPanel.Hide()
        TransitionControl.ShowSync(InfoPanel)
        GlobalClass.access = 0
    End Sub

    Private Sub GoToExport()
        LineSeparator.Width = ExportLabel.Width
        LineSeparator.Left = ExportLabel.Left
        ExportPanel.Visible = False
        ExportPanel.BringToFront()
        OverviewPanel.Hide()
        InfoPanel.Hide()
        SearchPanel.Hide()
        AdminPanel.Hide()
        TransitionControl.ShowSync(ExportPanel)
        GlobalClass.access = 0
    End Sub

    Private Sub GoToSearch()
        LineSeparator.Width = SearchLabel.Width
        LineSeparator.Left = SearchLabel.Left
        SearchPanel.Visible = False
        SearchPanel.BringToFront()
        OverviewPanel.Hide()
        InfoPanel.Hide()
        ExportPanel.Hide()
        AdminPanel.Hide()
        TransitionControl.ShowSync(SearchPanel)
        GlobalClass.access = 0
    End Sub

    Private Sub GoToAdmin()
        LineSeparator.Width = AdminLabel.Width
        LineSeparator.Left = AdminLabel.Left
        AdminPanel.Visible = False
        AdminPanel.BringToFront()
        OverviewPanel.Hide()
        InfoPanel.Hide()
        ExportPanel.Hide()
        SearchPanel.Hide()
        TransitionControl.ShowSync(AdminPanel)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles OverviewBackPictureBox.Click
        GoToOverview()
        slot = Nothing
    End Sub
#End Region

    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.Columns("SlotNumber").HeaderText = "Slot Number"
        DataGridView1.Columns("TimeIn").HeaderText = "Time In"
        DataGridView1.Columns("TimeOut").HeaderText = "Time Out"
    End Sub

#Region "Serial Data Receiver"
    Private Sub DataReceiver_Tick(sender As Object, e As EventArgs) Handles DataReceiver.Tick
        Dim s As String

        s = txtboxcData.Text + "," + "," + "," + "," + "," + "," + "," + "," + "," + ""

        Dim somestring() As String
        ' Split string based on comma
        somestring = s.Split(New Char() {","c})

        If txtboxcData.Text = "" Then

        Else
            lblEmptySlot.LabelText = somestring(0)

            Dim checkBoxes As CheckBox() = {chckBoxSlot1, chckBoxSlot2, chckBoxSlot3, chckBoxSlot4, chckBoxSlot5, chckBoxSlot6}
            Dim pictureBoxes As PictureBox() = {SlotPictureBox1, SlotPictureBox2, SlotPictureBox3, SlotPictureBox4, SlotPictureBox5, SlotPictureBox6}

            For i As Integer = 0 To checkBoxes.Length - 1
                If somestring(i + 1) = "0" Then
                    checkBoxes(i).Text = "Free"
                    checkBoxes(i).Checked = False
                    pictureBoxes(i).Image = My.Resources.icons8_garage_64
                Else
                    checkBoxes(i).Text = "Full"
                    checkBoxes(i).Checked = True
                    pictureBoxes(i).Image = My.Resources.icons8_parking_64
                End If
            Next
        End If

        txtboxcData.Text = ""
    End Sub

    Dim total As String

    Private Sub DataReceive_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting)
    End Sub

    Private Sub ReceivedText(ByVal [text] As String)
        'Now we display the information
        If txtboxcData.InvokeRequired Then
            Dim x As New settextcallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.txtboxcData.Text &= [text]
        End If
    End Sub
#End Region

#Region "Update MYSQL Database"
    Private Sub ParkSlotCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chckBoxSlot1.CheckedChanged, chckBoxSlot2.CheckedChanged, chckBoxSlot3.CheckedChanged, chckBoxSlot4.CheckedChanged, chckBoxSlot5.CheckedChanged, chckBoxSlot6.CheckedChanged
        Dim checkBox As CheckBox = DirectCast(sender, CheckBox)
        Dim index As Integer = Convert.ToInt32(checkBox.Name.Substring(checkBox.Name.Length - 1))
        DoScan(checkBox, index)
    End Sub

    Private Sub DoScan(ByVal chckbox As CheckBox, ByVal slotnumber As String)
        If chckbox.Checked = True Then
            UpdateCarStatusAsync(slotnumber, "Full", DateTime.Now, "--")
        ElseIf chckbox.Checked = False Then
            UpdateCarStatusAsync(slotnumber, "Free", "--", DateTime.Now)
        End If
    End Sub

    Public Function UpdateCarStatusAsync(slotNumber As Integer, status As String, timeIn As String, timeOut As String) As Task
        Dim sql As String = "UPDATE carinfo SET status=@status, TimeIn=@timein, TimeOut=@timeout WHERE SlotNumber=@slotnumber;"

        Dim parameters As MySqlParameter()

        parameters = {
        New MySqlParameter("@status", MySqlDbType.VarChar, 50) With {
            .Value = status
        },
        New MySqlParameter("@timein", MySqlDbType.VarChar) With {
            .Value = timeIn
        },
        New MySqlParameter("@timeout", MySqlDbType.VarChar) With {
            .Value = timeOut
        },
        New MySqlParameter("@slotnumber", MySqlDbType.Int32) With {
            .Value = slotNumber
        }
    }
        Return Task.Run(Function() sqlQuery.InsertRecordAsync(sql, parameters))
    End Function
#End Region

#Region "Show Slot Info"
    Private Sub SlotPictureBox_DoubleClick(sender As Object, e As EventArgs) Handles SlotPictureBox1.DoubleClick, SlotPictureBox2.DoubleClick, SlotPictureBox3.DoubleClick, SlotPictureBox4.DoubleClick, SlotPictureBox5.DoubleClick, SlotPictureBox6.DoubleClick
        Dim pictureBox As PictureBox = DirectCast(sender, PictureBox)
        Dim index As Integer = Convert.ToInt32(pictureBox.Name.Substring(pictureBox.Name.Length - 1))
        ShowInfo(index)
        GoToInfo()
    End Sub

    Private Sub ShowInfo(ByVal slotnumber As String)
        slot = slotnumber
        Dim query As String = " WHERE SlotNumber=" & slotnumber & ";"
        sqlQuery.ReadTable(DataGridView1, query)

        If DataGridView1.Rows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(0)
            lblSlotNumber.Text = "Slot Number: " & row.Cells(0).Value 'SlotNumber
            lblSlotStatus.Text = row.Cells(1).Value 'Status
            lblTimeIn.LabelText = row.Cells(2).Value 'TimeIn
            lblTimeOut.LabelText = row.Cells(3).Value 'TimeOut
            lblRFID.LabelText = row.Cells(4).Value.ToString() 'RFID

            If lblSlotStatus.Text = "Full" Then
                SlotStatusPictureBox.Image = My.Resources.icons8_parking_64__1_
            Else
                SlotStatusPictureBox.Image = My.Resources.icons8_garage_64
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ShowInfo(slot)
    End Sub
#End Region

#Region "Export Data"
    Private mRow As Integer = 0
    Private newpage As Boolean = True

    Public Sub AddLog(ByVal text As String)
        Dim filename As String = Application.StartupPath & "\saves.log"
        Dim sw As StreamWriter = AppendText(filename)

        sw.WriteLine(Now() & " " & text)
        sw.Close()
    End Sub

    Private Sub btnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click
        If PrintPreviewControl1.Document Is Nothing Then
            ShowAlert("Please refresh data first", frmNotify.AlertTypeEnum.Info)
        Else
            Dim sfd As New SaveFileDialog()

            sfd.Filter = "Portable Document Format (*.pdf)|*.pdf"
            sfd.DefaultExt = "pdf"
            sfd.FilterIndex = 2
            sfd.AddExtension = True
            sfd.RestoreDirectory = True

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    PrintDocument1.PrinterSettings = New PrinterSettings() With {
.PrinterName = "Microsoft Print to PDF",
.PrintToFile = True,
.PrintFileName = Path.Combine(Application.StartupPath, sfd.FileName)}
                    PrintDocument1.DefaultPageSettings.Landscape = False
                    PrintDocument1.Print()
                Catch ex As Exception
                    ShowAlert("Failed to save " & Path.GetFileNameWithoutExtension(sfd.FileName) & ".pdf", frmNotify.AlertTypeEnum.Warning)
                Finally
                    AddLog("Records has been exported as " & Path.GetFileNameWithoutExtension(sfd.FileName) & ".pdf file")
                    ShowAlert("Data named " & Path.GetFileNameWithoutExtension(sfd.FileName) & ".pdf has been saved", frmNotify.AlertTypeEnum.Success)
                End Try
            End If
        End If
    End Sub

    Private Sub DoExportTable()
        sqlQuery.ReadTable(DataGridView1)
        GoToExport()

        If DataGridView1.Rows.Count = 0 Then
            'no data dont export
            If PrintPreviewControl1.Document Is Nothing Then
                ShowAlert("No data found in database", frmNotify.AlertTypeEnum.Error)
            End If
        Else
            PrintDocument1.DefaultPageSettings.Landscape = False
            PrintPreviewControl1.Document = PrintDocument1
            ShowAlert("Data is ready to be saved", frmNotify.AlertTypeEnum.Success)
        End If
    End Sub

    Private Sub btnRefreshFile_Click(sender As Object, e As EventArgs) Handles btnRefreshFile.Click
        DoExportTable()
    End Sub

    Private Sub ExportLabel_Click(sender As Object, e As EventArgs) Handles ExportLabel.Click
        DoExportTable()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim drawFontBold = New Font("Arial", 12, FontStyle.Bold)
        e.Graphics.DrawString("PDF File Output from Data Records | Date & Time: " + DateTime.Now, drawFontBold, Brushes.Black, 130, 50)
        ' sets it to show '...' for long text
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow

        ' print the header text for a new page
        '   use a grey bg just like the control
        If newpage Then
            row = DataGridView1.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invidible columns
                If cell.Visible Then
                    rc = New Rectangle(x + 40, y, cell.Size.Width + 20, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reused in the data pront - should be a function
                    Select Case DataGridView1.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText,
                                            DataGridView1.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False

        ' now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = mRow To DataGridView1.RowCount - 1
            ' no need to try to print the new row
            If DataGridView1.Rows(thisNDX).IsNewRow Then Exit For

            row = DataGridView1.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            x = e.MarginBounds.Left

            ' print the data
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x + 40, y, cell.Size.Width + 20, cell.Size.Height)

                    ' SAMPLE CODE: How To 
                    ' up a RowPrePaint rule
                    'If Convert.ToDecimal(row.Cells(5).Value) < 9.99 Then
                    '    Using br As New SolidBrush(Color.MistyRose)
                    '        e.Graphics.FillRectangle(br, rc)
                    '    End Using
                    'End If

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case DataGridView1.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                      DataGridView1.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h
            ' next row to print
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                ' mRow -= 1   causes last row to rePrint on next page
                newpage = True
                Return
            End If
        Next
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.BeginPrint
        mRow = 0
        newpage = True
    End Sub

    Private Sub ZoomInPictureBox_Click(sender As Object, e As EventArgs) Handles ZoomInPictureBox.Click
        If PrintPreviewControl1.Zoom = 1 Then
            ShowAlert("Maximum Zoom Reached", frmNotify.AlertTypeEnum.Warning)
        Else
            PrintPreviewControl1.Zoom += 0.1
        End If
    End Sub

    Private Sub ZoomOutPictureBox_Click(sender As Object, e As EventArgs) Handles ZoomOutPictureBox.Click
        If PrintPreviewControl1.Zoom <= 0.1 Then
            ShowAlert("Maximum Unzoom Reached", frmNotify.AlertTypeEnum.Warning)
        Else
            PrintPreviewControl1.Zoom -= 0.1
        End If

    End Sub

    Private Sub PrintPreviewControl1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PrintPreviewControl1.MouseWheel
        If e.Delta > 0 Then
            If PrintPreviewControl1.Zoom = 1 Then
                ShowAlert("Maximum Zoom Reached", frmNotify.AlertTypeEnum.Warning)
            Else
                PrintPreviewControl1.Zoom += 0.1
            End If
        Else
            If PrintPreviewControl1.Zoom <= 0.1 Then
                ShowAlert("Maximum Unzoom Reached", frmNotify.AlertTypeEnum.Warning)
            Else
                PrintPreviewControl1.Zoom -= 0.1
            End If
        End If
    End Sub
#End Region

#Region "Search Data"
    Private Sub SearchLabel_Click(sender As Object, e As EventArgs) Handles SearchLabel.Click
        GoToSearch()
    End Sub

    Private Sub Misc_Tick(sender As Object, e As EventArgs) Handles Misc.Tick
        If radSlotNumberSearch.Checked = True Then
            GroupBox2.Visible = True
            GroupBox3.Visible = False
        End If
        If radStatusSearch.Checked = True Then
            GroupBox2.Visible = False
            GroupBox3.Visible = True
        End If
    End Sub

    Private Sub btnSlotNumberSearch_Click(sender As Object, e As EventArgs) Handles btnSlotNumberSearch.Click
        If cmbSlotSelection.selectedIndex = -1 Then
            ShowAlert("Please select first from selection", frmNotify.AlertTypeEnum.Error)
        Else
            sqlQuery.ReadTable(searchDataGrid, " WHERE `SlotNumber`=" & cmbSlotSelection.selectedValue & ";")
        End If
    End Sub

    Private Sub btnStatusSearch_Click(sender As Object, e As EventArgs) Handles btnStatusSearch.Click
        If cmbStatusSelection.selectedIndex = -1 Then
            ShowAlert("Please select first from selection", frmNotify.AlertTypeEnum.Error)
        Else
            sqlQuery.ReadTable(searchDataGrid, " WHERE `Status`=""" & cmbStatusSelection.selectedValue & """;")
        End If
    End Sub

    Private Sub searchDataGrid_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles searchDataGrid.DataBindingComplete
        If searchDataGrid.Rows.Count = 0 Then
            ShowAlert("No result found", frmNotify.AlertTypeEnum.Info)
        Else
            ShowAlert("Search result success", frmNotify.AlertTypeEnum.Success)
            searchDataGrid.Columns("SlotNumber").HeaderText = "Slot Number"
            searchDataGrid.Columns("TimeIn").HeaderText = "Time In"
            searchDataGrid.Columns("TimeOut").HeaderText = "Time Out"
        End If
    End Sub
#End Region

#Region "Admin"
    Private Sub btndbRefresh_Click(sender As Object, e As EventArgs) Handles btndbRefresh.Click
        sqlQuery.ReadTable(adminDataGrid)
    End Sub

    Private Sub btnMakeFull_Click(sender As Object, e As EventArgs) Handles btnMakeFull.Click
        UpdateCarStatusAsync(cmbdbSlot.Text, "Full", "--", "--")
        sqlQuery.ReadTable(adminDataGrid)
    End Sub

    Private Sub btnMakeFree_Click(sender As Object, e As EventArgs) Handles btnMakeFree.Click
        UpdateCarStatusAsync(cmbdbSlot.Text, "Free", "--", "--")
        sqlQuery.ReadTable(adminDataGrid)
    End Sub

    Private Sub btnlogTimeIn_Click(sender As Object, e As EventArgs) Handles btnlogTimeIn.Click
        UpdateCarStatusAsync(cmbdbSlot.Text, "Full", DateTime.Now, "--")
        sqlQuery.ReadTable(adminDataGrid)
    End Sub

    Private Sub btnlogTimeOut_Click(sender As Object, e As EventArgs) Handles btnlogTimeOut.Click
        UpdateCarStatusAsync(cmbdbSlot.Text, "Free", "--", DateTime.Now)
        sqlQuery.ReadTable(adminDataGrid)
    End Sub

    Private Sub AdminLabel_Click(sender As Object, e As EventArgs) Handles AdminLabel.Click
        frmLogin.ShowDialog()
        If GlobalClass.access = 1 Then
            GoToAdmin()
        Else
            'Do Nothing
        End If
    End Sub

    Private Sub adminDataGrid_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles adminDataGrid.DataBindingComplete
        adminDataGrid.Columns("SlotNumber").HeaderText = "Slot Number"
        adminDataGrid.Columns("TimeIn").HeaderText = "Time In"
        adminDataGrid.Columns("TimeOut").HeaderText = "Time Out"
    End Sub
#End Region

End Class