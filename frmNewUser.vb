Option Strict Off
Option Explicit On
Friend Class frmNewUser
	Inherits System.Windows.Forms.Form
	Dim Lflag As String
	Dim Uid As Integer
	Dim MaxNo As Integer
	Dim verify As Boolean
	Dim RS As ADODB.Recordset
	Dim listval As String
	Dim CON As New ADODB.Connection
	Private Function validate_fields() As Boolean
		verify = False
		If txtUsername.Text = "" Then
			MsgBox("Please enter the username", MsgBoxStyle.Exclamation)
			txtUsername.Focus()
			validate_fields = False
		ElseIf txtNewPassword.Text = "" Then 
			MsgBox("Please enter the password", MsgBoxStyle.Exclamation)
			txtNewPassword.Focus()
			validate_fields = False
		ElseIf txtConfirmPassword.Text = "" Then 
			MsgBox("Please re-enter the new password", MsgBoxStyle.Exclamation)
			txtConfirmPassword.Focus()
			validate_fields = False
		ElseIf txtConfirmPassword.Text <> txtNewPassword.Text Then 
			MsgBox("New Password and confirm Password should be the same", MsgBoxStyle.Exclamation)
			txtConfirmPassword.Focus()
			validate_fields = False
		Else
			validate_fields = True
		End If
	End Function
	Private Sub cmdcancel_Click()
		Dim Frame1 As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object Frame1.Visible. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Frame1.Visible = False
	End Sub
	
	Private Sub cmdClear_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.ClickEvent
		Dim i As Object
		txtUName.Text = ""
		txtDepartment.Text = ""
		txtUsername.Text = ""
		txtNewPassword.Text = ""
		txtConfirmPassword.Text = ""
		For i = 0 To lstsecurity.Items.Count - 1
			lstsecurity.SetItemChecked(i, False)
		Next 
	End Sub
	
	Private Sub cmdDelete_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.ClickEvent
		'On Error GoTo Xit
		cn.Execute("Delete from tblusers  where Name='" & txtUsername.Text & "' and Password='" & txtNewPassword.Text & "'")
		MsgBox("User Deleted", MsgBoxStyle.Information, My.Application.Info.Title)
Xit: 
		Err.Clear()
	End Sub
	Private Sub cmdExit_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.ClickEvent
		'On Error Resume Next
		Me.Close()
	End Sub
	Private Sub CommandButton1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CommandButton1.ClickEvent
		Dim Style, Msg, response As Object
		Dim Pass As String
		Dim Typ As String
		If Lflag = "Delete" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Msg = MsgBox("do you really want to delete the user", MsgBoxStyle.YesNo + MsgBoxStyle.Information)
			If Msg = MsgBoxResult.Yes Then
				cn.Execute("delete from tblusers where id=" & Uid)
				MsgBox("User name has been deleted", MsgBoxStyle.Information, My.Application.Info.Title)
			End If
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Msg = "Do you really want to update this record ?" ' Define message.
			'UPGRADE_WARNING: Couldn't resolve default property of object Style. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Style = MsgBoxStyle.YesNo + MsgBoxStyle.Critical ' Define buttons.
			'UPGRADE_WARNING: Couldn't resolve default property of object Style. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object response. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			response = MsgBox(Msg, Style)
			If response = MsgBoxResult.Yes Then ' User chose Yes.
				verify = validate_fields
				' verify1 = CheckName
				If optAdministrator.Checked = True Then
					Typ = "Yes"
				Else
					Typ = "No"
				End If
				If verify = True Then
					Pass = UCase(txtConfirmPassword.Text)
					If RS.State Then RS.Close()
					RS.Open("select max(id) from tblusers")
					If RS.RecordCount > 0 Then
						'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
						If Not IsDbNull(RS.Fields(0).Value) Then
							MaxNo = RS.Fields(0).Value + 1
						Else
							MaxNo = 1
						End If
					Else
						MaxNo = 1
					End If
					If RS.State Then RS.Close()
					RS.Open("SELECT * from tblusers where name ='" & txtUsername.Text & "'", CON, 3, 2)
					Call security()
					If RS.EOF Then
						RS.AddNew()
						'rs.Fields(0) = MaxNo
						'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						Msg = "New user has been created sucessfully."
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						Msg = " User Information has been Modified sucessfully."
					End If
					RS.Fields("UserID").Value = txtUsername.Text
					RS.Fields("Name").Value = txtUName.Text
					RS.Fields("Department").Value = txtDepartment.Text
					RS.Fields("Password").Value = txtNewPassword.Text
					RS.Fields("Type").Value = Typ
					RS.Fields("Accessrights").Value = listval
					RS.Update()
					MsgBox(Msg, MsgBoxStyle.Exclamation)
                    'cmdClear_Click()
				End If
			End If
		End If
		
		Lflag = ""
	End Sub
	Function RepaintFlexGrid() As Object
		Dim flxcls As Object
		Dim ch As Object
		' Reset the backcolor
		For ch = 1 To flxUsers.Rows - 1
			For flxcls = 0 To flxUsers.Cols - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object ch. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				flxUsers.Row = ch
				'UPGRADE_WARNING: Couldn't resolve default property of object flxcls. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				flxUsers.Col = flxcls
				If flxUsers.CellBackColor.equals(System.Drawing.Color.Yellow) Then flxUsers.CellBackColor = System.Drawing.Color.White
			Next flxcls
		Next ch
	End Function
	
	Private Sub CommandButton2_Click()
		
	End Sub
    Private Sub cmdclear_Click()

    End Sub
	Private Sub flxUsers_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxUsers.ClickEvent
		Dim vprev As Object
		Dim i As Object
		Dim current As Object
		cmdClear_Click()
		'UPGRADE_WARNING: Couldn't resolve default property of object current. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		current = flxUsers.Row
		RepaintFlexGrid()
		'Current  row
		'UPGRADE_WARNING: Couldn't resolve default property of object current. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		flxUsers.Row = current
		For i = 1 To flxUsers.Cols - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			flxUsers.Col = i
			flxUsers.CellBackColor = System.Drawing.Color.Yellow
		Next 
		LoadUserDetails()
		'UPGRADE_WARNING: Couldn't resolve default property of object vprev. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vprev = flxUsers.Row
		flxUsers.Col = 1
	End Sub
	Sub LoadUserDetails()
        'cmdClear_Click()
		txtUName.Text = flxUsers.get_TextMatrix(flxUsers.Row, 1)
		txtUsername.Text = flxUsers.get_TextMatrix(flxUsers.Row, 2)
		txtDepartment.Text = flxUsers.get_TextMatrix(flxUsers.Row, 3)
		txtNewPassword.Text = flxUsers.get_TextMatrix(flxUsers.Row, 4)
		txtConfirmPassword.Text = flxUsers.get_TextMatrix(flxUsers.Row, 4)
	End Sub
	Private Sub frmNewUser_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call UPPER_CASE(KeyAscii)
		If KeyAscii = CDbl("27") Then Me.Close()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub frmNewUser_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		If CON.State Then CON.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CON.Open(ConnectString)
		LoadFlexTitles()
		LoadUserData()
	End Sub
	Private Sub LoadFlexTitles()
		On Error Resume Next
		With flxUsers
			.Row = 0 : .Col = 0
			.set_ColWidth(0, 0)
			.set_TextMatrix(0, 1, "User Name")
			.set_ColWidth(1, 1500)
			.set_TextMatrix(0, 2, "UserID")
			.set_ColWidth(2, 1000)
			.set_TextMatrix(0, 3, "Department")
			.set_ColWidth(3, 2000)
			.set_TextMatrix(0, 4, "Password")
			.set_ColWidth(4, 1200)
			.set_TextMatrix(0, 5, "Type")
			.set_ColWidth(5, 1000)
			.set_TextMatrix(0, 6, "AccessRights")
			.set_ColWidth(6, 0)
		End With
	End Sub
	
	Private Sub LoadUserData()
		Dim fldata3 As New ADODB.Recordset
		If fldata3.State Then fldata3.Close()
		fldata3.Open("select * from tblusers", CON, 3, 2)
		With flxUsers
			.Rows = 1
			While Not fldata3.EOF
				.Rows = .Rows + 1
				.set_TextMatrix(.Rows - 1, 0, fldata3.Fields("id").Value)
				.set_TextMatrix(.Rows - 1, 1, fldata3.Fields("Name").Value)
				.set_TextMatrix(.Rows - 1, 2, fldata3.Fields("UserID").Value)
				.set_TextMatrix(.Rows - 1, 3, fldata3.Fields("Department").Value)
				.set_TextMatrix(.Rows - 1, 4, fldata3.Fields("Password").Value)
				.set_TextMatrix(.Rows - 1, 5, fldata3.Fields("Type").Value)
				.set_TextMatrix(.Rows - 1, 6, fldata3.Fields("accessrights").Value)
				fldata3.MoveNext()
			End While
		End With
		If fldata3.State Then fldata3.Close()
	End Sub
	
	Private Sub MSFlexGrid1_Click()
		Dim MSFlexGrid1 As Object
		'On Error Resume Next
		'UPGRADE_WARNING: Couldn't resolve default property of object MSFlexGrid1.Row. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MSFlexGrid1.TextMatrix. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtUsername.Text = MSFlexGrid1.TextMatrix(MSFlexGrid1.Row, 0)
		'UPGRADE_WARNING: Couldn't resolve default property of object MSFlexGrid1.Row. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MSFlexGrid1.TextMatrix. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MSFlexGrid1.Row. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MSFlexGrid1.TextMatrix. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If MSFlexGrid1.TextMatrix(MSFlexGrid1.Row, 1) <> "" Then Uid = MSFlexGrid1.TextMatrix(MSFlexGrid1.Row, 1)
		'Frame1.Visible = False
	End Sub
	
	Private Sub txtConfirmPassword_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirmPassword.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = TxtAcceptString((Me.txtConfirmPassword), KeyAscii)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtNewPassword_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNewPassword.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = TxtAcceptString((Me.txtNewPassword), KeyAscii)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtUsername.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtUsername_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUsername.TextChanged
		Dim i As Object
		Dim j As Short
		j = 0
		If RS.State Then RS.Close()
		RS.Open("select * from tblusers where name = '" & txtUsername.Text & "'", CON, 3, 2)
		If Not RS.EOF Then
			txtUsername.Text = RS.Fields("name").Value
			txtNewPassword.Text = RS.Fields("password").Value
			Select Case RS.Fields("type").Value
				Case "Yes"
					optAdministrator.Checked = True
				Case "No"
					optGeneralUser.Checked = True
			End Select
			For i = 1 To lstsecurity.Items.Count - 1
				lstsecurity.SetItemChecked(i, False)
			Next 
			While j < Len(RS.Fields("Accessrights").Value)
				j = j + 1
				If (Mid(RS.Fields("Accessrights").Value, j, 1)) = "1" Then
					lstsecurity.SetItemChecked(j - 1, True)
				End If
			End While
		End If
	End Sub
	
	Private Sub txtUsername_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If KeyCode = System.Windows.Forms.Keys.F2 Then
			SearchString("select name from tblusers", Me.txtUsername)
		End If
	End Sub
	
	Public Sub security()
		Dim i As Object
		listval = ""
		For i = 0 To lstsecurity.Items.Count - 1
			If lstsecurity.GetItemChecked(i) Then
				listval = listval & "1"
			Else
				listval = listval & "0"
			End If
		Next i
	End Sub
	
	Private Sub txtUsername_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = TxtAcceptString((Me.txtUsername), KeyAscii)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class