Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class ExecQueryFunctions
    Dim connectionString As String = "server=" & GlobalClass.SQLServer & ";user=" & GlobalClass.SQLUser & ";database=" & GlobalClass.SQLDB & ";port=" & GlobalClass.SQLPort & ";password=" & GlobalClass.SQLPass & ";"

    Public Sub ShowAlert(msg As String, type As frmNotify.AlertTypeEnum)
        If (Application.OpenForms.OfType(Of frmNotify).Count() = 1) Then
            Application.OpenForms.OfType(Of frmNotify).First().Close()
        End If
        If (Application.OpenForms.OfType(Of frmNotify).Count() = 0) Then
            Dim f As frmNotify = New frmNotify
            f.SetAlert(msg, type)
        End If
    End Sub

    Public Async Function InsertRecordAsync(sql As String, ParamArray parameters As MySqlParameter()) As Task
        Using connection As New MySqlConnection(connectionString)
            Await connection.OpenAsync()
            Using command As New MySqlCommand(sql, connection)
                command.Parameters.AddRange(parameters)
                Await command.ExecuteNonQueryAsync()
            End Using
        End Using
    End Function

    Public Sub ReadTable(ByVal dataGridView As DataGridView, Optional ByVal condition As String = "")
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim command As New MySqlCommand("SELECT * FROM carinfo" & condition, connection)
            Dim dataReader As MySqlDataReader = command.ExecuteReader()

            ' Load the data into a DataTable
            Dim dataTable As New DataTable()
            dataTable.Load(dataReader)

            ' Bind the DataTable to the DataGridView
            dataGridView.DataSource = dataTable
        End Using
    End Sub

    Public Function DoAdminLogin(ByVal user As String, ByVal pass As String) As Boolean
        Dim con As New MySqlConnection(connectionString)
        Dim cmd As New MySqlCommand("SELECT * FROM user_login WHERE username=@username AND password=@password", con)
        cmd.Parameters.AddWithValue("@username", user)
        cmd.Parameters.AddWithValue("@password", pass)

        Try
            con.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim result As Boolean = reader.HasRows
            reader.Close()
            Return result
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
End Class
