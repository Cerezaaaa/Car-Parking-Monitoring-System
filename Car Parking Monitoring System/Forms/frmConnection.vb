Imports System.IO
Imports System.IO.Ports
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Text

Public Class frmConnection

    Dim objIniFile As New clsIni(Application.StartupPath & "/Config.ini")
    Dim access() As Integer = {0, 0}

    Private key() As Byte = {}
    Private IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
    Private Const EncryptionKey As String = "abcdefgh"

    Private Sub frmConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(Application.StartupPath & "/Config.ini") Then
            LoadConfig()
        Else
            'Set default values
        End If
    End Sub

#Region "Encryp | Decrypt"
    Public Function Decrypt(ByVal stringToDecrypt As String) As String
        Try
            Dim inputByteArray(stringToDecrypt.Length) As Byte
            key = System.Text.Encoding.UTF8.GetBytes((EncryptionKey.Substring(0, 8)))
            Dim des As New DESCryptoServiceProvider
            inputByteArray = Convert.FromBase64String(stringToDecrypt)
            Dim ms As New MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8
            Return encoding.GetString(ms.ToArray())
        Catch ex As Exception
            'oops - add your exception logic
        End Try
    End Function

    Public Function Encrypt(ByVal stringToEncrypt As String) As String
        Try
            key = System.Text.Encoding.UTF8.GetBytes((EncryptionKey.Substring(0, 8)))
            Dim des As New DESCryptoServiceProvider
            Dim inputByteArray() As Byte = Encoding.UTF8.GetBytes(stringToEncrypt)
            Dim ms As New MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())
        Catch ex As Exception
            'oops - add your exception logic
        End Try
    End Function
#End Region

#Region "Minimize and Exit"
    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub
#End Region

#Region "Test | Scan | Continue"
    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        If BunifuCustomTextbox1.Text = Nothing And BunifuCustomTextbox2.Text = Nothing And BunifuCustomTextbox3.Text = Nothing And BunifuCustomTextbox4.Text = Nothing Then
            ShowAlert("Please fill up MYSQL Info", frmNotify.AlertTypeEnum.Error)
        ElseIf BunifuCustomTextbox5.Text = Nothing Then
            ShowAlert("Please fill up Database Name", frmNotify.AlertTypeEnum.Error)
        ElseIf ComboBox1.Items.Count = Nothing Then
            ShowAlert("Please scan Arduino Port first", frmNotify.AlertTypeEnum.Error)
        ElseIf ComboBox1.Text = Nothing Then
            ShowAlert("Please select an Arduino Port", frmNotify.AlertTypeEnum.Error)
        ElseIf BunifuCustomTextbox6.Text = Nothing Then
            ShowAlert("Please fill up Baud Rate", frmNotify.AlertTypeEnum.Error)
        Else
            SaveConfig()
            TestConnectionDB()
        End If
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        ComboBox1.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox1.Items.AddRange(myPort)
        i = ComboBox1.Items.Count
        i = i - i
        Try
            ComboBox1.SelectedIndex = i
        Catch ex As Exception
            ShowAlert("No COM port detected", frmNotify.AlertTypeEnum.Warning)
            ComboBox1.Text = ""
            ComboBox1.Items.Clear()
        End Try
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If access.All(Function(s) s.Equals(1)) Then
            SaveConfig()
            If (Application.OpenForms.OfType(Of frmNotify).Count() > 0) Then
                Application.OpenForms.Cast(Of Form)() _
                    .Except({Me}) _
                    .ToList() _
                    .ForEach(Sub(form) form.Close())
            End If
            frmMain.Show()
            Close()
        ElseIf access(0) = 0 And access(1) = 0 Then
            ShowAlert("Test your DB and Arduino connection first", frmNotify.AlertTypeEnum.Info)
        ElseIf access(0) = 0 Then
            ShowAlert("Check your DB connection", frmNotify.AlertTypeEnum.Info)
        ElseIf access(1) = 0 Then
            ShowAlert("Check your Arduino connection", frmNotify.AlertTypeEnum.Info)
        Else
            ShowAlert("Please test connection again!", frmNotify.AlertTypeEnum.Warning)
        End If
    End Sub
#End Region

#Region "Test Connection DB & Port"
    Private Sub TestConnectionDB()
        ' Retrieve the server, port, username, password, and database values from the INI file
        GlobalClass.SQLServer = objIniFile.GetString("Server", "SQLServer", "")
        GlobalClass.SQLPort = objIniFile.GetString("Server", "SQLPort", "")
        GlobalClass.SQLUser = objIniFile.GetString("Server", "SQLUser", "")
        GlobalClass.SQLPass = Decrypt(objIniFile.GetString("Server", "SQLPass", ""))
        GlobalClass.SQLDB = objIniFile.GetString("Server", "SQLDb", "")

        ' Create the connection string using the retrieved values
        Dim connectionString As String = "server=" & GlobalClass.SQLServer & ";user=" & GlobalClass.SQLUser & ";database=" & GlobalClass.SQLDB & ";port=" & GlobalClass.SQLPort & ";password=" & GlobalClass.SQLPass & ";"
        ' Create a MySqlConnection object using the connection string
        Dim con As New MySql.Data.MySqlClient.MySqlConnection(connectionString)

        Try
            ' Open the connection asynchronously using Task.Run [changed to run]
            con.Open()
            ' Display a success message
            ShowAlert("DB Connection Successful", frmNotify.AlertTypeEnum.Success)
            ' Set the access flag to true
            access(0) = 1
        Catch ex As Exception
            ' An exception occurred, so display an error message
            ShowAlert("DB Connection Failed", frmNotify.AlertTypeEnum.Error)
            ' Set the access flag to false
            access(0) = 0
        Finally
            ' Close and dispose of the connection
            con.Close()
            con.Dispose()
            TestConnectionPort()
        End Try
    End Sub

    Private Sub TestConnectionPort()
        GlobalClass.ArduinoPort = ComboBox1.SelectedItem
        GlobalClass.ArduinoBaud = BunifuCustomTextbox6.Text

        SerialPort1.BaudRate = BunifuCustomTextbox6.Text
        SerialPort1.PortName = ComboBox1.SelectedItem
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default
        SerialPort1.Close()
        Try
            SerialPort1.Open()
            ShowAlert("Port Connection Successful", frmNotify.AlertTypeEnum.Success)
            access(1) = 1
        Catch ex As Exception
            MsgBox(ex.Message)
            ShowAlert("Port Connection Failed", frmNotify.AlertTypeEnum.Error)
            access(1) = 0
        Finally
            SerialPort1.Close()
            SerialPort1.Dispose()
        End Try
    End Sub
#End Region

#Region "Save and Load Config"
    Private Sub SaveConfig()
        Try
            objIniFile.WriteString("Server", "SQLServer", BunifuCustomTextbox1.Text)
            objIniFile.WriteString("Server", "SQLPort", BunifuCustomTextbox2.Text)
            objIniFile.WriteString("Server", "SQLUser", BunifuCustomTextbox3.Text)
            objIniFile.WriteString("Server", "SQLPass", Encrypt(BunifuCustomTextbox4.Text))
            objIniFile.WriteString("Server", "SQLDb", BunifuCustomTextbox5.Text)
            objIniFile.WriteString("Server", "ArduinoPort", ComboBox1.Text)
            objIniFile.WriteString("Server", "ArduinoBaud", BunifuCustomTextbox6.Text)
            'ShowAlert("Configuration file saved successfully", frmNotify.AlertTypeEnum.Success)
        Catch ex As Exception
            'ShowAlert("Error Creating Config.ini file", frmNotify.AlertTypeEnum.Error)
        End Try
    End Sub

    Private Sub LoadConfig()
        Try
            BunifuCustomTextbox1.Text = objIniFile.GetString("Server", "SQLServer", "")
            BunifuCustomTextbox2.Text = objIniFile.GetString("Server", "SQLPort", "")
            BunifuCustomTextbox3.Text = objIniFile.GetString("Server", "SQLUser", "")
            BunifuCustomTextbox4.Text = Decrypt(objIniFile.GetString("Server", "SQLPass", ""))
            BunifuCustomTextbox5.Text = objIniFile.GetString("Server", "SQLDb", "")
            BunifuCustomTextbox6.Text = objIniFile.GetString("Server", "ArduinoBaud", "")
            ShowAlert("Configuration file loaded successfully", frmNotify.AlertTypeEnum.Success)
        Catch ex As Exception
            ShowAlert("Error loading Config.ini file", frmNotify.AlertTypeEnum.Error)
        End Try
    End Sub
#End Region

#Region " Show Alert [ Notify ]"
    Public Sub ShowAlert(msg As String, type As frmNotify.AlertTypeEnum)
        Dim f As frmNotify = New frmNotify
        f.SetAlert(msg, type)
    End Sub
#End Region

End Class