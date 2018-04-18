Option Strict Off
Option Explicit On
Friend Class frmLogin
	Inherits System.Windows.Forms.Form
	Dim RS As New ADODB.Recordset
	Dim rs1 As New ADODB.Recordset
	Dim Con As New ADODB.Connection
	
	Private Sub cmbName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cmbName.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = TxtAcceptString((Me.cmbName), KeyAscii)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cmdContinue_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdContinue.Click
		If (cmbName.Text = "") Or (txtPassword.Text = "") Then
			MsgBox("You cannot leave username or password as blank", MsgBoxStyle.Critical)
			If cmbName.Text = "" Then
				cmbName.Focus()
			Else
				txtPassword.Focus()
			End If
		Else
			If rs1.State = 1 Then rs1.Close()
			
			rs1.Open("Select * from tblusers where UserID='" & cmbName.Text & "' and password='" & txtPassword.Text & "'", Con, 1, 1)
			If Not rs1.EOF Then
				
				If rs1.Fields("type").Value = "Yes" Then
					Type_doctor = True
				End If
				
				Username = cmbName.Text
				Pass = txtPassword.Text
				'UPGRADE_WARNING: Couldn't resolve default property of object pubUserName. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				pubUserName = rs1.Fields("Name").Value
				'UPGRADE_WARNING: Couldn't resolve default property of object pubUserDept. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				pubUserDept = rs1.Fields("Department").Value
				
				'  MDIMain.Administration_User.Visible = UCase(Username) = "ADMIN"
				MDIMain.mnuAdministration.Visible = Mid(rs1.Fields("accessrights").Value, 1, 1) = "1"
				MDIMain.mnuTransactions.Visible = Mid(rs1.Fields("accessrights").Value, 2, 1) = "1"
				MDIMain.mnuInvoiceTransactions.Visible = Mid(rs1.Fields("accessrights").Value, 3, 1) = "1"
				'UPGRADE_WARNING: Couldn't resolve default property of object VarLogName. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				VarLogName = rs1.Fields(0).Value
				'UPGRADE_WARNING: Couldn't resolve default property of object VarPwd. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				VarPwd = rs1.Fields(1).Value
				VarLogged = rs1.Fields(5).Value
				varAccessStr = "logged In"
				Me.Close()
				
				MDIMain.Show()
			Else
				MsgBox("You have entered wrong password", MsgBoxStyle.Critical)
				txtPassword.Text = ""
				txtPassword.Focus()
			End If
		End If
		
		'Patient Payables
		strRetrieve = "FALSE"
	End Sub
	
	Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
		'On Error Resume Next
		'Unload frmLogin
		End
	End Sub
	
	'UPGRADE_WARNING: Form event frmLogin.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmLogin_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - Me.ClientRectangle.Width) \ 2 - 2000)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - Me.ClientRectangle.Height) \ 2 - 2200)
		
	End Sub
	
	Private Sub frmLogin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = CDbl("27") Then Call cmdExit_Click(cmdExit, New System.EventArgs())
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub frmLogin_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		'GetConnectionString
		
		CheckConnection()
		If Con.State Then Con.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Con.Open(ConnectString)
		GetCompanyInformation()
		rs1 = New ADODB.Recordset
		RS = New ADODB.Recordset
		RS.let_ActiveConnection(Con)
		RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		RS.CursorType = ADODB.CursorTypeEnum.adOpenDynamic
		RS.LockType = ADODB.LockTypeEnum.adLockOptimistic
		rs1.let_ActiveConnection(Con)
		rs1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rs1.CursorType = ADODB.CursorTypeEnum.adOpenDynamic
		rs1.LockType = ADODB.LockTypeEnum.adLockOptimistic
	End Sub
	Public Sub GetCompanyInformation()
		Dim pubFlashMsg As Object
		Dim RS As New ADODB.Recordset
		RS.Open("Select * from Company ", Con, 1, 1)
		If Not RS.EOF Then
			'UPGRADE_WARNING: Couldn't resolve default property of object vPubCompanyName. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			vPubCompanyName = RS.Fields("CompanyName").Value
			'UPGRADE_WARNING: Couldn't resolve default property of object vPubAddress. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			vPubAddress = RS.Fields("Address").Value
			'UPGRADE_WARNING: Couldn't resolve default property of object vPubRegno. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			vPubRegno = RS.Fields("regno").Value
			'UPGRADE_WARNING: Couldn't resolve default property of object vPubPhone. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			vPubPhone = RS.Fields("phone").Value
			'UPGRADE_WARNING: Couldn't resolve default property of object vPubFax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			vPubFax = RS.Fields("fax").Value
			'UPGRADE_WARNING: Couldn't resolve default property of object vPubEmail. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			vPubEmail = RS.Fields("email").Value
			'UPGRADE_WARNING: Couldn't resolve default property of object pubFlashMsg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			pubFlashMsg = RS.Fields("flashmsg").Value
		End If
		If RS.State Then RS.Close()
	End Sub
	
	Public Sub Password()
		If rs1.State = 1 Then rs1.Close()
		rs1.Open("select password, type, Name,Department from username where UserID='" & cmbName.Text & "'")
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
	End Function
	
	
	
	Public Function TxtAcceptNumeric(ByRef obj As Object, ByVal KeyAscii As Short) As Short
		If KeyAscii = 8 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object obj.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Len(obj.Text) >= 1 Then
				TxtAcceptNumeric = KeyAscii
				Exit Function
			Else
				TxtAcceptNumeric = 0
			End If
		End If
		If KeyAscii = 13 Then System.Windows.Forms.SendKeys.Send("{TAB}") : TxtAcceptNumeric = 0 : Exit Function
		If KeyAscii >= 48 And KeyAscii <= 57 Then TxtAcceptNumeric = KeyAscii : Exit Function
		TxtAcceptNumeric = 0
	End Function
	'Function used to check whether the file exists or not
	'Output will be either TRUE or FALSE
	'If the file exist then it will be TRUE else FALSE
	Public Function exists(ByVal sFilename As String) As Boolean
		Dim OF_EXIST As Object
		Dim OpenFile As Object
		'UPGRADE_ISSUE: OFSTRUCT object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        'Dim typOfStruct As OFSTRUCT
		'On Error Resume Next
		If Len(sFilename) > 0 Then
            'OpenFile(sFilename, typOfStruct, OF_EXIST)
			'UPGRADE_WARNING: Couldn't resolve default property of object typOfStruct.nErrCode. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'exists = typOfStruct.nErrCode <> 2
		End If
	End Function
	Public Sub flxAcceptNumeric(ByRef obj As Object, ByRef KeyAscii As Short)
		' On Error Resume Next
		
		If KeyAscii = 8 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object obj.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			obj.Text = Mid(obj.Text, 1, Len(obj.Text) - 1) : Exit Sub
		End If
		If (KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 46 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object obj.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			obj.Text = obj.Text & Chr(KeyAscii)
			Exit Sub
		End If
		
	End Sub
	Public Sub SafeExit()
		
		On Error Resume Next
		
		'Method for ensuring that all forms are unloaded from memory
		'before exiting the program
		'UPGRADE_NOTE: Form was upgraded to Form_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Form_Renamed As System.Windows.Forms.Form
		
        For Each Form_Renamed In Application.OpenForms
            Form_Renamed.Close()
            'UPGRADE_NOTE: Object Form_Renamed may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            Form_Renamed = Nothing
        Next Form_Renamed
		
	End Sub
	
	
	Private Sub txtPassword_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then Call cmdContinue_Click(cmdContinue, New System.EventArgs()) : GoTo EventExitSub
		KeyAscii = TxtAcceptString((Me.txtPassword), KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class