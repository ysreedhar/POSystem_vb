Option Strict Off
Option Explicit On
Module ModSoho01
	'Public ws As Workspace
	Public cn As ADODB.Connection
	Public cnShape As ADODB.Connection
	Public RS As ADODB.Recordset
	Public rst As ADODB.Recordset
	Public C As System.Windows.Forms.Control
	'UPGRADE_NOTE: Char was upgraded to Char_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Doc As Object
	Public Char_Renamed As String
	Public From_Menu As String
	Public Type_doctor As Boolean
	Public id As String
	Public Check1 As Boolean
	Public Username As String
	Public Pass As String
	'Public DB_Accounts As Database
	Public Wlno_Call As Integer
	Public CI As Short
	Public ICno_i As String
	Public doctor As String
	Public Vpub_tkno As Object
	'Public varAccessStr
	Public strRecFlag As Object
	Public strId As Short
	Public BRemarks As String
	Public amtpaid As Short
	Public billingID As Short
	Public billflag As String
	'************************************************************
	Public vPubFax, vPubRegno, vPubCompanyName, vPubAddress, vPubPhone, vPubEmail As Object
	'************************************************************
	
	Public pubUserName, pubUserDept As Object
	Public strRetrieve As String
	Public Function IsEMailAddress(ByVal sEmail As String, Optional ByRef sReason As String = "") As Boolean
		Dim nCharacter As Short
		Dim sBuffer As String
		sEmail = Trim(sEmail)
		
		If Len(sEmail) < 8 Then
			
			IsEMailAddress = False
			
			sReason = "Too short"
			
			Exit Function
			
		End If
		If InStr(sEmail, "@") = 0 Then
			
			IsEMailAddress = False
			
			sReason = "Missing the @"
			
			Exit Function
			
		End If
		If InStr(InStr(sEmail, "@") + 1, sEmail, "@") <> 0 Then
			
			IsEMailAddress = False
			
			sReason = "Too many @"
			
			Exit Function
			
		End If
		
		
		
		
		
		If InStr(sEmail, ".") = 0 Then
			
			IsEMailAddress = False
			
			sReason = "Missing the period"
			
			Exit Function
			
		End If
		
		
		
		If InStr(sEmail, "@") = 1 Or InStr(sEmail, "@") = Len(sEmail) Or InStr(sEmail, ".") = 1 Or InStr(sEmail, ".") = Len(sEmail) Then
			
			IsEMailAddress = False
			
			sReason = "Invalid format"
			
			Exit Function
			
		End If
		
		For nCharacter = 1 To Len(sEmail)
			
			sBuffer = Mid(sEmail, nCharacter, 1)
			
			If Not (LCase(sBuffer) Like "[a-z]" Or sBuffer = "@" Or sBuffer = "." Or sBuffer = "-" Or sBuffer = "_" Or IsNumeric(sBuffer)) Then
				IsEMailAddress = False : sReason = "Invalid character" : Exit Function
			End If
			
		Next nCharacter
		
		nCharacter = 0
		
		'On Error Resume Next
		
		sBuffer = Right(sEmail, 4)
		
		If InStr(sBuffer, ".") = 0 Then GoTo TooLong
		
		If Left(sBuffer, 1) = "." Then sBuffer = Right(sBuffer, 3)
		
		If Left(Right(sBuffer, 3), 1) = "." Then sBuffer = Right(sBuffer, 2)
		
		If Left(Right(sBuffer, 2), 1) = "." Then sBuffer = Right(sBuffer, 1)
		
		If Len(sBuffer) < 2 Then
			
			IsEMailAddress = False
			
			sReason = "Suffix too short"
			
			Exit Function
			
		End If
TooLong: 
		If Len(sBuffer) > 3 Then
			
			IsEMailAddress = False
			
			sReason = "Suffix too long"
			
			Exit Function
			
		End If
		sReason = CStr(Nothing)
		IsEMailAddress = True
	End Function
	Public Sub UPPER_CASE(ByRef KeyAscii As Short)
		If KeyAscii = CDbl("13") Then System.Windows.Forms.SendKeys.Send("{TAB}")
		Char_Renamed = Chr(KeyAscii)
		KeyAscii = Asc(UCase(Char_Renamed))
	End Sub
	Public Sub CLEAR_TEXT(ByRef a As System.Windows.Forms.Form)
		'Dim c1 As Control
		For	Each C In a.Controls
			'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeOf C Is System.Windows.Forms.TextBox Then
				C.Text = ""
			End If
			'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeOf C Is System.Windows.Forms.CheckBox Then
				'UPGRADE_WARNING: Couldn't resolve default property of object C.Value. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'C.Value = 0
			End If
		Next C
	End Sub
	Public Sub ERROR_HANDLING()
		Dim Msg As Object
		If Err.Number = CDbl("3024") Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Msg = MsgBox("File not found for the selected Company" & vbCrLf & "Enter through the ADMINISTRATOR login and Restore the file", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "Clinic")
		ElseIf Err.Number = CDbl("94") Then 
		ElseIf Err.Number = CDbl("5") Then 
			Err.Clear()
		ElseIf Err.Number = CDbl("3200") Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Msg = MsgBox("This Record Can't Be Deleted.Because It Has Some Transactions", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "CLinic")
			
		ElseIf Err.Number = CDbl("53") Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Msg = MsgBox("File Not Found In the Given Drive", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "Clinic")
		ElseIf Err.Number = CDbl("70") Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Msg = MsgBox("Restore Not Done Properly. May Be The File is Already Existing", MsgBoxStyle.Critical, "Clinic")
			
		ElseIf Err.Number = CDbl("3022") Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Msg = MsgBox("You Have Tried To Insert Duplicate Record", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "Clinic")
			
		ElseIf Err.Number = CDbl("71") Then 
			MsgBox(Err.Description, MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "Clinic")
		End If
	End Sub
	Public Sub NumericOnly(ByRef KeyAscii As Short)
		If Not (Chr(KeyAscii) Like "[0-9.]") Then
			Beep()
			KeyAscii = 0
		End If
	End Sub
	Public Function validate(ByRef TempKeyAscii As Short, Optional ByRef TempInt As Short = 0) As Short
		Select Case TempInt
			Case 0 ' FOR ACCEPT ONLY A-Z AND a-z  and  backspace and space AND CONVERT UPPER CASE
				
				If (Not Chr(TempKeyAscii) Like "[A-Za-z]") And (Not CStr(TempKeyAscii) Like CStr(8)) And (Not CStr(TempKeyAscii) Like CStr(32)) Then
					
					validate = 0
				Else
					validate = Asc(UCase(Chr(TempKeyAscii)))
					
				End If
				
			Case 1 ' FOR ACCEPT ONLY A-Z and a-z  and  backspace and  dot and spase and convert upper case
				If (Not Chr(TempKeyAscii) Like "[A-Za-z]") And (Not CStr(TempKeyAscii) Like CStr(8)) And (Not CStr(TempKeyAscii) Like CStr(32)) And (Not CStr(TempKeyAscii) Like CStr(46)) Then
					
					validate = 0
				Else
					validate = Asc(UCase(Chr(TempKeyAscii)))
				End If
				
			Case 2 ' FOR ACCEPT ONLY A-Z and a-z  and  backspace and  dot and spase and convert uppercase
				If (Not Chr(TempKeyAscii) Like "[A-Za-z]") And (Not CStr(TempKeyAscii) Like CStr(8)) And (Not CStr(TempKeyAscii) Like CStr(32)) And (Not CStr(TempKeyAscii) Like CStr(46)) And (Not CStr(TempKeyAscii) Like CStr(44)) Then
					
					validate = 0
				Else
					validate = Asc(UCase(Chr(TempKeyAscii)))
				End If
			Case 3 ' FOR ACCEPT ONLY A-Z and a-z  and  backspace and  convert uppercase
				If (Not Chr(TempKeyAscii) Like "[A-Za-z]") And (Not CStr(TempKeyAscii) Like CStr(8)) Then
					
					validate = 0
				Else
					validate = Asc(UCase(Chr(TempKeyAscii)))
					
				End If
			Case 4 ' FOR ACCEPT ONLY 0-9  and  backspace and space and dot and coma
				If (Not Chr(TempKeyAscii) Like "[0-9]") And (Not CStr(TempKeyAscii) Like CStr(8)) And (Not CStr(TempKeyAscii) Like CStr(32)) And (Not CStr(TempKeyAscii) Like CStr(46)) And (Not CStr(TempKeyAscii) Like CStr(44)) Then
					
					
					validate = 0
				Else
					validate = TempKeyAscii
					
				End If
			Case 5 ' FOR ACCEPT ONLY 0-9  and  backspace
				If (Not Chr(TempKeyAscii) Like "[0-9]") And (Not CStr(TempKeyAscii) Like CStr(8)) Then
					
					
					validate = 0
				Else
					validate = TempKeyAscii
					
				End If
			Case 6 ' FOR ACCEPT ONLY 0-9  and  backspace and minus(-)
				If (Not Chr(TempKeyAscii) Like "[0-9]") And (Not CStr(TempKeyAscii) Like CStr(8)) And (Not CStr(TempKeyAscii) Like CStr(45)) Then
					
					
					validate = 0
				Else
					validate = TempKeyAscii
					
				End If
			Case 7 ' FOR ACCEPT ONLY 0-9  and  backspace AND COLON(:)
				If (Not Chr(TempKeyAscii) Like "[0-9]") And (Not CStr(TempKeyAscii) Like CStr(58)) And (Not CStr(TempKeyAscii) Like CStr(8)) Then
					
					
					validate = 0
				Else
					validate = TempKeyAscii
					
				End If
				'59, 58, 34, 39, 44, 60, 46, 62, 47, 61, 43, 63, 123, 125, 92, 124, 96, 126, 33, 37, 94, 38, 95
			Case 8 'FOR MOMILE NO
				If (CStr(TempKeyAscii) Like CStr(59)) Or (CStr(TempKeyAscii) Like CStr(58)) Or (CStr(TempKeyAscii) Like CStr(34)) Or (CStr(TempKeyAscii) Like CStr(39)) Or (CStr(TempKeyAscii) Like CStr(44)) Or (CStr(TempKeyAscii) Like CStr(60)) Or (CStr(TempKeyAscii) Like CStr(46)) Or (CStr(TempKeyAscii) Like CStr(62)) Or (CStr(TempKeyAscii) Like CStr(47)) Or (CStr(TempKeyAscii) Like CStr(61)) Or (CStr(TempKeyAscii) Like CStr(43)) Or (CStr(TempKeyAscii) Like CStr(63)) Or (CStr(TempKeyAscii) Like CStr(123)) Or (CStr(TempKeyAscii) Like CStr(125)) Or (CStr(TempKeyAscii) Like CStr(92)) Or (CStr(TempKeyAscii) Like CStr(124)) Or (CStr(TempKeyAscii) Like CStr(96)) Or (CStr(TempKeyAscii) Like CStr(126)) Or (CStr(TempKeyAscii) Like CStr(33)) Or (CStr(TempKeyAscii) Like CStr(37)) Or (CStr(TempKeyAscii) Like CStr(94)) Or (CStr(TempKeyAscii) Like CStr(38)) Or (CStr(TempKeyAscii) Like CStr(95)) Then
					validate = 0
				Else
					validate = TempKeyAscii
				End If
				
			Case 9 ' FOR ACCEPT ONLY 0-9  and  backspace and minus(-) and opening small brakit(  and closing small brakit )
				If (Not Chr(TempKeyAscii) Like "[0-9]") And (Not CStr(TempKeyAscii) Like CStr(8)) And (Not CStr(TempKeyAscii) Like CStr(45)) And (Not CStr(TempKeyAscii) Like CStr(40)) And (Not CStr(TempKeyAscii) Like CStr(41)) Then
					
					
					validate = 0
				Else
					validate = TempKeyAscii
					
				End If
			Case 10 'not accept ' "
				If (CStr(TempKeyAscii) Like CStr(34)) Or (CStr(TempKeyAscii) Like CStr(39)) Then
					validate = 0
				Else
					validate = TempKeyAscii
				End If
			Case 11 ' FOR ACCEPT ONLY 0-9  and  backspace and space and dot and
				If (Not Chr(TempKeyAscii) Like "[0-9]") And (Not CStr(TempKeyAscii) Like CStr(8)) And (Not CStr(TempKeyAscii) Like CStr(32)) And (Not CStr(TempKeyAscii) Like CStr(46)) Then
					
					
					validate = 0
				Else
					validate = TempKeyAscii
					
				End If
			Case 12 ' FOR ACCEPT ONLY A-Z AND a-z  and 0-9 and  backspace and AND CONVERT UPPER CASE
				
				If (Not Chr(TempKeyAscii) Like "[A-Za-z]") And (Not Chr(TempKeyAscii) Like "[0-9]") And (Not CStr(TempKeyAscii) Like CStr(8)) Then
					
					validate = 0
				Else
					validate = Asc(UCase(Chr(TempKeyAscii)))
					
				End If
				
				
			Case 13 ' FOR ACCEPT ONLY A-Z AND a-z  and 0-9 and  backspace and AND SPACE AND DOT AND minus(-) and opening small brakit(  and closing small brakit )and coma CONVERT UPPER CASE
				
				If (Not Chr(TempKeyAscii) Like "[A-Za-z]") And (Not Chr(TempKeyAscii) Like "[0-9]") And (Not CStr(TempKeyAscii) Like CStr(8)) And (Not CStr(TempKeyAscii) Like CStr(32)) And (Not CStr(TempKeyAscii) Like CStr(46)) And (Not CStr(TempKeyAscii) Like CStr(45)) And (Not CStr(TempKeyAscii) Like CStr(40)) And (Not CStr(TempKeyAscii) Like CStr(41)) And (Not CStr(TempKeyAscii) Like CStr(44)) Then
					
					validate = 0
				Else
					validate = Asc(UCase(Chr(TempKeyAscii)))
					
				End If
			Case 14 ' FOR ACCEPT ONLY A-Z AND a-z  and 0-9 and  backspace and AND SPACE AND DOT AND minus(-) and / and opening small brakit(  and closing small brakit )  and   CONVERT UPPER CASE
				If (Not Chr(TempKeyAscii) Like "[A-Za-z]") And (Not Chr(TempKeyAscii) Like "[0-9]") And (Not CStr(TempKeyAscii) Like CStr(8)) And (Not CStr(TempKeyAscii) Like CStr(32)) And (Not CStr(TempKeyAscii) Like CStr(46)) And (Not CStr(TempKeyAscii) Like CStr(45)) And (Not CStr(TempKeyAscii) Like CStr(40)) And (Not CStr(TempKeyAscii) Like CStr(41)) And (Not CStr(TempKeyAscii) Like CStr(47)) And (Not CStr(TempKeyAscii) Like CStr(44)) Then
					validate = 0
				Else
					validate = Asc(UCase(Chr(TempKeyAscii)))
				End If
			Case 15 ' FOR ACCEPT ONLY 0-9  and  backspace and minus(-) and /
				If (Not Chr(TempKeyAscii) Like "[0-9]") And (Not CStr(TempKeyAscii) Like CStr(8)) And (Not CStr(TempKeyAscii) Like CStr(45)) And (Not CStr(TempKeyAscii) Like CStr(47)) Then
					validate = 0
				Else
					validate = TempKeyAscii
				End If
			Case 16 'for blood group
				If Not CStr(TempKeyAscii) Like CStr(45) And Not CStr(TempKeyAscii) Like CStr(43) And Not Chr(TempKeyAscii) Like "[A-Za-z]" And (Not CStr(TempKeyAscii) Like CStr(8)) And (Not CStr(TempKeyAscii) Like CStr(32)) Then
					validate = 0
				Else
					validate = TempKeyAscii
				End If
		End Select
		
	End Function
	
	Public Function GF_AllowCapitalOnly(ByRef L_IntKeyAscii As Short) As Short
		If L_IntKeyAscii > 47 And L_IntKeyAscii < 58 Then
			GF_AllowCapitalOnly = 0
		ElseIf L_IntKeyAscii > 96 And L_IntKeyAscii < 123 Then 
			GF_AllowCapitalOnly = L_IntKeyAscii - 32
		Else
			GF_AllowCapitalOnly = L_IntKeyAscii
		End If
	End Function
	Public Function GF_ProcessSingleQuote(ByRef L_StrText As String) As String
		'Funtion returing a string representing L_StrText after single quotes in the concerned
		'string is replaced by two single quotes.
		Dim L_IntPosition As Short 'Integer to store the start position of search for the string to be found.
		Dim L_StrQuote As String 'String to store the search string.
		'On Error GoTo errorhandler
		L_StrQuote = "'" 'Assign search string as single quote.
		Do 
			'Store position of occurance of single quotes in the L_StrText.
			L_IntPosition = InStr(L_IntPosition + 1, L_StrText, L_StrQuote)
			'If no occurance found then exit loop.
			If L_IntPosition = 0 Then
				Exit Do
			End If
			'Replace single quote with two single quote.
			L_StrText = Mid(L_StrText, 1, L_IntPosition - 1) & "'" & Mid(L_StrText, L_IntPosition)
			'Increment the Start Position for search by 1 of the last occurance.
			L_IntPosition = L_IntPosition + 1
		Loop 
		GF_ProcessSingleQuote = L_StrText 'Return the replaced string.
		Exit Function
errorhandler: 
		MsgBox(" Error Encountered while Processing Single Quote in text string.." & Chr(13) & " Error Number: " & Err.Number & " Error Description: " & Err.Description, MsgBoxStyle.Information, " Process Single Quote")
	End Function
	Public Sub GS_FillComboBox(ByRef LcmbCombo As System.Windows.Forms.ComboBox, ByRef LRsRecSet As ADODB.Recordset, Optional ByRef LIntFieldNum As Short = 0)
		'Sub to Fill Combo control represented in LcmbCombo parameter using the
		'LRsRecset recordset parameter with the field value specified in the LIntFieldNum field number
		'if specified else with the first field in the recordset.
		'On Error GoTo errorhandler
		'Clearing the combo content.
		LcmbCombo.Items.Clear()
		'Adding field values to the Combo control.
		While Not LRsRecSet.EOF
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(LRsRecSet.Fields(LIntFieldNum).Value) Then
				LcmbCombo.Items.Add(LRsRecSet.Fields(LIntFieldNum).Value)
			End If
			LRsRecSet.MoveNext() 'Moving to next record.
		End While
		LRsRecSet.MoveFirst()
		Exit Sub
errorhandler: 
		MsgBox("No Records Retrived !" & Chr(13) & Chr(13) & "Error Number - " & Err.Number & Chr(13) & "Error Description - " & Err.Description, MsgBoxStyle.Information, "Error No Record")
	End Sub
	Public Sub fncFillCombo(ByRef cboctrl As System.Windows.Forms.Control, ByRef SQLquery As String)
		Dim adors As New ADODB.Recordset
		Dim iColCount As Short
		Dim sValue As String
		'UPGRADE_WARNING: Couldn't resolve default property of object cboctrl.Clear. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'cboctrl.Clear()
		adors.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		
		adors.Open(SQLquery, Con)
		While Not adors.EOF
			iColCount = 0
			sValue = ""
			While iColCount < adors.Fields.Count
				If iColCount <> 0 Then sValue = sValue & " ~ "
				sValue = sValue & adors.Fields(iColCount).Value
				iColCount = iColCount + 1
			End While
			'UPGRADE_WARNING: Couldn't resolve default property of object cboctrl.AddItem. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'cboctrl.AddItem(sValue)
			adors.MoveNext()
		End While
		adors.Close()
	End Sub
	Public Function GF_IncrementPriKey(ByRef L_StruniqId As String) As String
		'Funtion returning a string representing the Incremented primary key value.
		Dim L_strPriKey As String 'To Store String part of Primary Key (including 0 (Zero))
		Dim L_lngPriKey As Integer 'To Store Integr part of Primary Key
		Dim L_IntCounter As Short 'To count the number of iterations
		'On Error GoTo errorhandler
		For L_IntCounter = 1 To Len(L_StruniqId) 'Loop to access each character of the L_StruniqId at a time.
			'If the retrieved character is a number, retrieve the complete string from this position
			'and store the same to L_lngPriKey long variable and exit the For loop.
			If Mid(L_StruniqId, L_IntCounter, 1) >= Chr(49) And Mid(L_StruniqId, L_IntCounter, 1) <= Chr(57) Then
				L_lngPriKey = CInt(Mid(L_StruniqId, L_IntCounter))
				If L_IntCounter > 1 Then
					If Len(CStr(L_lngPriKey + 1)) > Len(CStr(L_lngPriKey)) And Mid(L_StruniqId, L_IntCounter - 1, 1) = Chr(48) Then
						L_strPriKey = Mid(L_strPriKey, 1, Len(L_strPriKey) - 1)
					End If
				End If
				Exit For
			Else
				L_strPriKey = L_strPriKey & Mid(L_StruniqId, L_IntCounter, 1)
			End If
		Next L_IntCounter
		'Increment the Primary numeric portion value by one.
		
		L_lngPriKey = L_lngPriKey + 1
		'Form the new primary key value, if consisted alpha portion concatenate the
		'numeric portion to the alpha string. Else assign only the numeric portion
		'after converting to string.
		If L_strPriKey <> "0" Then
			L_strPriKey = L_strPriKey & CStr(L_lngPriKey)
		Else
			L_strPriKey = CStr(L_lngPriKey)
		End If
		'Return the Primary Key string.
		GF_IncrementPriKey = L_strPriKey
		Exit Function
errorhandler: 
		MsgBox("Error Encountered while Incrementing Primary Key value.." & Chr(13) & "Error Number: " & Err.Number & "Error Description: " & Err.Description, MsgBoxStyle.Information, "Incrementing Primary Key")
	End Function
	Public Function GF_AllowRealNumberOnly(ByRef lKeyAscii As Short) As Short
		'On Error GoTo errorhandler
		'Sub allowing Real Number entry only by turning keyascii to value zero.
		If Not (lKeyAscii >= 48 And lKeyAscii <= 57) And lKeyAscii <> 8 And lKeyAscii <> 46 Then
			lKeyAscii = 0
		End If
		If lKeyAscii = 46 Then
			lKeyAscii = 0
		End If
		GF_AllowRealNumberOnly = lKeyAscii
		Exit Function
errorhandler: 
		MsgBox("Error Encountered while Allowing real number entry only.." & Chr(13) & "Error Number: " & Err.Number & "Error Description: " & Err.Description, MsgBoxStyle.Information, "Real Number Only")
	End Function
	
	
	Public Function TxtAcceptString(ByRef obj As Object, ByVal KeyAscii As Short) As Short
		If KeyAscii = 8 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object obj.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Len(obj.Text) >= 1 Then
				TxtAcceptString = KeyAscii
				Exit Function
			Else
				TxtAcceptString = 0
			End If
		End If
		If KeyAscii = 13 Then System.Windows.Forms.SendKeys.Send("{TAB}") : TxtAcceptString = 0 : Exit Function
		If KeyAscii = 34 Or KeyAscii = 39 Then TxtAcceptString = 0 : Exit Function
		
		TxtAcceptString = KeyAscii
	End Function
	
	Public Sub SearchString(ByVal StrQry As Object, ByVal obj As Object)
		'Dim rs2 As New ADODB.Recordset
		'rs2.Open StrQry, cn
		'Dialog.List1.Clear
		'While Not rs2.EOF
		'If rs2.Fields.Count = 2 Then
		'    Dialog.List1.AddItem rs2(1) & "--" & rs2(0)
		'Else
		'    Dialog.List1.AddItem rs2(0)
		'End If
		'rs2.MoveNext
		'Wend
		'rs2.Close
		'
		'Set Dialog.varfrm = obj
		'Dialog.Show
	End Sub
	
	Public Function autogen(ByVal qry As Object, ByVal paddstr As Object, ByRef Con As Object) As String
		On Error GoTo Xit
		Dim auto2, auto1, i As Object
		Dim rs1 As New ADODB.Recordset
		Dim a() As Object
		
		rs1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rs1.Open(qry, Con, 3, 2, 1)
		If rs1.RecordCount = 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object paddstr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			autogen = paddstr & "1"
		Else
			rs1.MoveFirst()
			'UPGRADE_WARNING: Couldn't resolve default property of object auto1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			auto1 = 1
			ReDim a(rs1.RecordCount)
			For i = 1 To rs1.RecordCount
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object paddstr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object a(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				a(i) = Replace(UCase(rs1.Fields(0).Value), UCase(paddstr), "", 1, Len(rs1.Fields(0).Value))
				'UPGRADE_WARNING: Couldn't resolve default property of object auto1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object a(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object a(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object auto1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If CDbl(a(i)) > CDbl(auto1) Then auto1 = CDbl(a(i))
				rs1.MoveNext()
			Next i
			'UPGRADE_WARNING: Couldn't resolve default property of object auto1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object auto2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			auto2 = CInt(auto1) + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object auto2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object paddstr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			autogen = paddstr & auto2
		End If
		rs1.Close()
Xit: 
	End Function
	Public Sub flxAcceptMoney(ByRef obj As Object, ByRef KeyAscii As Short)
		On Error Resume Next
		If KeyAscii = 8 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object obj.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			obj.Text = Mid(obj.Text, 1, Len(obj.Text) - 1) : Exit Sub
		End If
		If KeyAscii >= 48 And KeyAscii <= 57 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object obj.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			obj.Text = obj.Text & Chr(KeyAscii)
			Exit Sub
		End If
		If KeyAscii = 46 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object obj.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If InStr(obj.Text, ".") Then
				Exit Sub
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object obj.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				obj.Text = obj.Text & Chr(KeyAscii)
			End If
		End If
	End Sub
	Public Function GetCode(ByVal qry As Object) As String
		Dim RS As New ADODB.Recordset
		RS.Open(qry, Con, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		If Not RS.EOF Then GetCode = RS.Fields(0).Value
		RS.Close()
	End Function
	Public Sub StockUpdate(ByVal IC As Object, ByVal Iq As Object)
		'UPGRADE_WARNING: Couldn't resolve default property of object IC. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Iq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cn.Execute("Update Itemmaster set stock = stock +" & Iq & " Where itemdescription='" & Trim(IC) & "'")
	End Sub
End Module