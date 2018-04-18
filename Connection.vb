Option Strict Off
Option Explicit On
Module Connection
	'Declaration for combobox autofill
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As String) As Integer
	Const CB_ERR As Short = (-1)
	Const CB_FINDSTRING As Short = &H14Cs
	Const WM_USER As Short = &H400s
	Const CB_SHOWDROPDOWN As Short = &H14Fs
	'End
	
	Public TestQ As String
	Public strFormName As String
	
	'Login Screen *****************************************
	Public varAccessStr As String
	Public VarDept, VarLogName, VarPwd, vPublicUserCategory As Object
	Public CHKFlag As String
	Public AdjChk2, AdjChk1, AdjChk3 As Object
	'******************************************************
	
	'Previous Production No********************************
	Public varPrevDate, varRGD, varProductionNo, varPrevMaterial, varPrevModel As Object
	Public varPrevSNo As String
	Public YAl, YMo, YCu, YP, YSi, YC, YMn, YS, YCr, YTi, YSb As Object
	Public YNi As String
	Public AlTi, AlCr, AlS, AlMn, AlC, AlSi, AlP, AlCu, AlMo, AlSb As Object
	Public AlNi As String
	'******************************************************
	
	'*********************CONNECTION STRING
	Public ConnectString As Object
	'Public libConnectString
	Public MasterModelConString As Object
	Public varFilePath As Object
	Dim CON As New ADODB.Connection
	'*********************CONNECTION STRING
	
	'Public hlpobj As New hlpcls
	Public strWhich As String
	'Public STUMEMBER As Boolean
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
	
	Public Const MAX_PATH As Short = 260
	
	Structure FILETIME ' 8 Bytes
		Dim dwLowDateTime As Integer
		Dim dwHighDateTime As Integer
	End Structure
	
	Structure WIN32_FIND_DATA ' 318 Bytes
		Dim dwFileAttributes As Integer
		Dim ftCreationTime As FILETIME
		Dim ftLastAccessTime As FILETIME
		Dim ftLastWriteTime As FILETIME
		Dim nFileSizeHigh As Integer
		Dim nFileSizeLow As Integer
		Dim dwReserved_ As Integer
		Dim dwReserved1 As Integer
		'UPGRADE_WARNING: Fixed-length string size must fit in the buffer. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
		<VBFixedString(MAX_PATH),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray,SizeConst:=MAX_PATH)> Public cFileName() As Char
		'UPGRADE_WARNING: Fixed-length string size must fit in the buffer. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
		<VBFixedString(14),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray,SizeConst:=14)> Public cAlternate() As Char
	End Structure
	'Getting ComputerName
	Public CompName As String
	Private Declare Function GetComputerName Lib "kernel32"  Alias "GetComputerNameA"(ByVal lpBuffer As String, ByRef nSize As Integer) As Integer
	
	Private Const MAX_COMPUTERNAME_LENGTH As Integer = 31
	
	'UPGRADE_WARNING: Structure WIN32_FIND_DATA may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Public Declare Function FindFirstFile Lib "kernel32"  Alias "FindFirstFileA"(ByVal lpFileName As String, ByRef lpFindFileData As WIN32_FIND_DATA) As Integer
	Public Declare Function FindClose Lib "kernel32" (ByVal hFindFile As Integer) As Integer
	
	Public Sub GetConnectionString()
		'****************************************
		'Get Connection Function Gets Properties of Connectionstring from
		'ServerSetup.ini
		'****************************************
		
		'On Error GoTo ErrHandler
		
		Dim SectionName As String
		Dim VariableName As String
		Dim ValueFrom As String
		Dim iret As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConnectString = "Driver={SQL Server};Persist Security Info = False;"
		'libConnectString = "Driver={Sql Server};Persist Security Info = False;"
		'Server Name
		ValueFrom = New String(Chr(0), 256)
		iret = GetPrivateProfileString("DB", "Server", "", ValueFrom, Len(ValueFrom), My.Application.Info.DirectoryPath & "\ServerSetup.ini")
		If iret > 0 Then
			ValueFrom = Left(ValueFrom, iret)
		Else
			ValueFrom = ""
			GoTo ErrHandler
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConnectString = ConnectString & "Server=" & ValueFrom & ";"
		'libConnectString = libConnectString & "Server=" & ValueFrom & ";"
		
		'Database
		ValueFrom = New String(Chr(0), 256)
		iret = GetPrivateProfileString("DB", "Database", "", ValueFrom, Len(ValueFrom), My.Application.Info.DirectoryPath & "\ServerSetup.ini")
		If iret > 0 Then
			ValueFrom = Left(ValueFrom, iret)
		Else
			ValueFrom = ""
			GoTo ErrHandler
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConnectString = ConnectString & "Database=" & ValueFrom & ";"
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConnectString = ConnectString & "Network Library=ddmssocn;"
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConnectString = ConnectString & "Initial Catalog=pubs;"
		'UID
		ValueFrom = New String(Chr(0), 256)
		iret = GetPrivateProfileString("DB", "UID", "", ValueFrom, Len(ValueFrom), My.Application.Info.DirectoryPath & "\ServerSetup.ini")
		If iret > 0 Then
			ValueFrom = Left(ValueFrom, iret)
		Else
			ValueFrom = ""
			'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ConnectString = ConnectString & "TRUSTED_CONNECTION=YES;"
			Exit Sub
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConnectString = ConnectString & "UID=" & ValueFrom & ";"
		'PWD
		ValueFrom = New String(Chr(0), 256)
		iret = GetPrivateProfileString("DB", "PWD", "", ValueFrom, Len(ValueFrom), My.Application.Info.DirectoryPath & "\ServerSetup.ini")
		If iret > 0 Then
			ValueFrom = Left(ValueFrom, iret)
		Else
			ValueFrom = ""
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConnectString = ConnectString & "PWD=" & ValueFrom & ";"
		
		Exit Sub
ErrHandler: 
		MsgBox("Change Database Connection Path in ServerSetup.ini", MsgBoxStyle.Information)
		Err.Clear()
	End Sub
	
	'UPGRADE_WARNING: Application will terminate when Sub Main() finishes. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="E08DDC71-66BA-424F-A612-80AF11498FF8"'
	Public Sub Main()
		GetConnectionString()
		If CON.State Then CON.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'CON.Open(ConnectString)
        CON.Open(Constr)
		'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
        'Load(MDIMain)
        MDIMain.Show(s)
		
	End Sub
	Public Sub CheckConnection()
		If adoCon.State <> ADODB.ObjectStateEnum.adStateOpen Then
			OpenConnection()
		End If
	End Sub
	Public Sub OpenConnection()
		OpenSQLCon()
		Exit Sub
Err_OpenConnection: 
		MsgBox(Err.Number & " - " & Err.Description, MsgBoxStyle.Critical, My.Application.Info.Title)
	End Sub
	
	Private Sub OpenSQLCon()
		Dim CurrentDate As Object
		Dim DateDMY As Object
		
		Dim adors As New ADODB.Recordset
		On Error GoTo err_OpenSQLCon
		
		If adoCon.State Then adoCon.Close()
		
		
		
		adoCon.CommandTimeout = 180
		adoCon.ConnectionTimeout = 0
		'adoCon.Open BrConnectString
		
		adoCon.Execute("set language 'british english'")
		adoCon.Execute("SET dateformat MDY")
		
		'For gettting up the Server Date
		If adors.State Then adors.Close()
		adors.Open("select getdate() as dt", adoCon)
		'UPGRADE_WARNING: Couldn't resolve default property of object DateDMY. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object CurrentDate. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CurrentDate = VB6.Format(adors.Fields(0).Value, DateDMY)
		
		
		Exit Sub
err_OpenSQLCon: 
		Err.Clear()
	End Sub
	
	
	Public Function TxtAcceptMoney(ByRef obj As Object, ByVal KeyAscii As Short) As Short
		If KeyAscii = 8 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object obj.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Len(obj.Text) >= 1 Then
				TxtAcceptMoney = KeyAscii
				Exit Function
			Else
				KeyAscii = 0
			End If
		End If
		
		If KeyAscii = 13 Then System.Windows.Forms.SendKeys.Send("{TAB}") : TxtAcceptMoney = 0 : Exit Function
		
		If KeyAscii = 46 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object obj.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If InStr(obj.Text, ".") Then
				TxtAcceptMoney = 0
			Else
				TxtAcceptMoney = KeyAscii : Exit Function
			End If
		End If
		
		If KeyAscii >= 48 And KeyAscii <= 57 Then
			TxtAcceptMoney = KeyAscii
			Exit Function
		Else
			TxtAcceptMoney = 0
		End If
		If KeyAscii = 13 Then KeyAscii = 13
	End Function
	
	Function HideForms() As Object
		Dim i As Object
        'For i = 0 To My.Application.OpenForms.Count - 1
        '	If My.Application.OpenForms.Item(i).Name <> "MDIForm1" Then
        '		My.Application.OpenForms.Item(i).Hide()
        '	End If
        'Next i
	End Function
	
	Public Sub cboBox_KeyPress(ByRef KeyAscii As Short, ByRef cboBox As System.Windows.Forms.ComboBox)
		On Error Resume Next
		Dim cb As Integer
		Dim FindString As String
		
		If KeyAscii < 32 Or KeyAscii > 127 Then Exit Sub
		
		If cboBox.SelectionLength = 0 Then
			FindString = cboBox.Text & Chr(KeyAscii)
		Else
			FindString = Left(cboBox.Text, cboBox.SelectionStart) & Chr(KeyAscii)
		End If
		
		cb = SendMessage(cboBox.Handle.ToInt32, CB_FINDSTRING, -1, FindString)
		
		If cb <> CB_ERR Then
			cboBox.SelectedIndex = cb
			cboBox.SelectionStart = Len(FindString)
			cboBox.SelectionLength = Len(cboBox.Text) - cboBox.SelectionStart
			KeyAscii = 0
		End If
		
	End Sub
	Public Sub cboBox_GotFocus(ByRef cboBox As System.Windows.Forms.ComboBox)
		Dim i As Integer
		i = SendMessage(cboBox.Handle.ToInt32, CB_SHOWDROPDOWN, True, 0)
	End Sub
	
	Public Sub NumericOnly(ByRef KeyAscii As Short)
		If Not (Chr(KeyAscii) Like "[0-9.]") Then
			Beep()
			KeyAscii = 0
		End If
	End Sub
	
	Function MyFileSize(ByRef strFileName As String) As Object
		Dim WFD As WIN32_FIND_DATA
		Dim hFindFirst As Integer
		Dim Hi, Lo As Decimal
		
		hFindFirst = FindFirstFile(strFileName, WFD)
		
		If hFindFirst > 0 Then
			FindClose(hFindFirst)
			Hi = WFD.nFileSizeHigh
			Lo = WFD.nFileSizeLow
			If Hi < 0 Then Hi = Hi + (2 ^ 32)
			If Lo < 0 Then Lo = Lo + (2 ^ 32)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object MyFileSize. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MyFileSize = (Hi * (2 ^ 32)) + Lo
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object MyFileSize. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MyFileSize = 0
		End If
	End Function
	
	Public Function GetCompName() As String
		Dim ComputerName As Object
		
		Dim dwLen As Integer
		Dim strString As String
		
		'Create a buffer
		dwLen = MAX_COMPUTERNAME_LENGTH + 1
		strString = New String("X", dwLen)
		
		'Get the computer name
		GetComputerName(strString, dwLen)
		
		'get only the actual data
		'UPGRADE_WARNING: Couldn't resolve default property of object ComputerName. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ComputerName = Left(strString, dwLen)
		'UPGRADE_WARNING: Couldn't resolve default property of object ComputerName. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetCompName = ComputerName
	End Function
End Module