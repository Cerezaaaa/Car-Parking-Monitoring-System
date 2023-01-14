Public Class GlobalClass

	Private Shared _sqlserver As String = ""
	Private Shared _sqluser As String = ""
	Private Shared _sqlport As String = ""
	Private Shared _sqlpass As String = ""
	Private Shared _sqldb As String = ""
	Private Shared _arduinoport As String = ""
	Private Shared _arduinobaud As String = ""

	Public Shared access As Integer

	Public Shared Property SQLServer As String
		Get
			Return _sqlserver
		End Get
		Set(ByVal value As String)
			_sqlserver = value
		End Set
	End Property

	Public Shared Property SQLPort As String
		Get
			Return _sqlport
		End Get
		Set(ByVal value As String)
			_sqlport = value
		End Set
	End Property

	Public Shared Property SQLUser As String
		Get
			Return _sqluser
		End Get
		Set(ByVal value As String)
			_sqluser = value
		End Set
	End Property

	Public Shared Property SQLPass As String
		Get
			Return _sqlpass
		End Get
		Set(ByVal value As String)
			_sqlpass = value
		End Set
	End Property

	Public Shared Property SQLDB As String
		Get
			Return _sqldb
		End Get
		Set(ByVal value As String)
			_sqldb = value
		End Set
	End Property

	Public Shared Property ArduinoPort As String
		Get
			Return _arduinoport
		End Get
		Set(ByVal value As String)
			_arduinoport = value
		End Set
	End Property

	Public Shared Property ArduinoBaud As String
		Get
			Return _arduinobaud
		End Get
		Set(ByVal value As String)
			_arduinobaud = value
		End Set
	End Property
End Class
