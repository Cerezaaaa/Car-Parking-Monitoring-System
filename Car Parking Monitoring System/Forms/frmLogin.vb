Public Class frmLogin

    Private sqlQuery As New ExecQueryFunctions

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ShowAlert("Admin Log-in cancelled", frmNotify.AlertTypeEnum.Error)
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtboxUser.Text = Nothing Then
            ShowAlert("Please input your username", frmNotify.AlertTypeEnum.Warning)
        ElseIf txtboxPass.Text = Nothing Then
            ShowAlert("Please input your password", frmNotify.AlertTypeEnum.Warning)
        Else
            If sqlQuery.DoAdminLogin(txtboxUser.Text, txtboxPass.Text) = True Then
                ShowAlert("Successfully Logged In", frmNotify.AlertTypeEnum.Success)
                GlobalClass.access = 1
                txtboxUser.Text = ""
                txtboxPass.Text = ""
                Me.Close()
            Else
                ShowAlert("Invalid Username Or Password", frmNotify.AlertTypeEnum.Error)
                GlobalClass.access = 0
            End If
        End If

    End Sub

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

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
    End Sub
#End Region

End Class