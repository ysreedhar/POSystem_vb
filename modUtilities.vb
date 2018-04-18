Option Strict Off
Option Explicit On
Module modUtilities
	Public Sub udp_GenerateError(ByRef errMod As String, ByRef errProc As String, ByRef dErrorNumber As Double, ByRef sErrorDescription As String)
		Dim SqlDate As Object
		
		On Error GoTo Errhand
		Dim MaxErrNo As String
		Dim sqlstr, msgText As String
		CheckConnection()
		sErrorDescription = Replace(sErrorDescription, "'", "''")
		'Error_Code,Error_Date,Error_Module,Error_Proc,Error_Text  - {fields of tekErrorLog table}
		On Error GoTo Errhand
		
		If dErrorNumber = 0 Then Exit Sub
		
		'UPGRADE_WARNING: Couldn't resolve default property of object SqlDate. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MaxErrNo = adoCon.Execute("select isnull(max(Error_Code),0) from ErrorLog where convert(varchar(10),Error_Date,101) = '" & VB6.Format(Now, SqlDate) & "'").Fields(0).Value
		MaxErrNo = VB6.Format(Val(MaxErrNo) + 1, "0000000")
		
		'format the string check for single quotes / double quotes before insertion
		'into database
		msgText = dErrorNumber & " - " & sErrorDescription
		
		'Error record insertion into table
		If msgText = "" Then
			msgText = "General Error"
		End If
		
		sqlstr = "insert into ErrorLog (Error_Code,Error_Date,Error_Module,Error_Proc,Error_Text) values ('" & MaxErrNo & "','" & VB6.Format(Now, "mm/dd/yyyy HH:MM:SS") & "','" & errMod & "','" & errProc & "','" & msgText & "')"
		adoCon.Execute(sqlstr)
		Exit Sub
		
Errhand: 
		If Err.Number = -2147467259 Then
			
			MsgBox("Test the connection from Server Settings in Edit Menu", MsgBoxStyle.Information, My.Application.Info.Title)
		Else
			MsgBox(Err.Number & " - " & Err.Description, MsgBoxStyle.Critical, My.Application.Info.Title)
		End If
		
	End Sub
	Public Sub udpClearControls(ByRef fName As Object)
		Dim C As System.Windows.Forms.Control
		On Error Resume Next
        'For	Each C In fName
        '	If C.Tag <> "U" Then
        '		'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		If (TypeOf C Is System.Windows.Forms.TextBox) Or (TypeOf C Is System.Windows.Forms.ComboBox) Then C.Text = ""
        '		'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		'UPGRADE_WARNING: Couldn't resolve default property of object C.Value. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		If (TypeOf C Is System.Windows.Forms.CheckBox) Then C.Value = System.Windows.Forms.CheckState.Unchecked
        '		'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		'UPGRADE_WARNING: Couldn't resolve default property of object C.Value. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		If TypeOf C Is AxMSComCtl2.AxDTPicker Then C.Value = Now
        '		'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		If TypeOf C Is System.Windows.Forms.Label And Left(C.Name, 6) = "lblTxt" Then C.Text = ""
        '	End If
        'Next C
	End Sub
	Public Sub udpLockControls(ByRef fName As Object, ByRef bval As Boolean)
		Dim C As System.Windows.Forms.Control
        'For	Each C In fName
        '	If C.Tag <> "U" Then
        '		'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		'UPGRADE_WARNING: Couldn't resolve default property of object C.Locked. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		If (TypeOf C Is System.Windows.Forms.TextBox) Or (TypeOf C Is System.Windows.Forms.ComboBox) Then C.Locked = bval
        '		'UPGRADE_ISSUE: MSComCtl2.UpDown object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '		'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		If TypeOf C Is AxMSComCtl2.AxDTPicker Or (TypeOf C Is System.Windows.Forms.Label) Then C.Enabled = Not bval
        '	Else
        '		'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		'UPGRADE_WARNING: Couldn't resolve default property of object C.Locked. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		If (TypeOf C Is System.Windows.Forms.TextBox) Or (TypeOf C Is System.Windows.Forms.ComboBox) Then C.Locked = False
        '	End If
        'Next C
	End Sub
	
	Public Function ReplaceTextInTextBox(ByRef MyTextBox As Object, ByRef TextOld As Object, ByRef TextNew As Object) As Object
		Dim ReturnValue As Object
		'The object reference is made form the form
		'you use to call this module.
		'Assumed you have a text1, text2 and text3 text box on your form
		'where 1 is used for the text you wish to replace text in
		'2 is the one containing text you are searching for
		'3 is the new text you wish to see entered in its place.
		'The replacement function being called
		
		'UPGRADE_WARNING: Couldn't resolve default property of object TextNew.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object TextOld.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MyTextBox.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call ReplaceText(MyTextBox.Text, TextOld.Text, TextNew.Text)
		
		'Replace textview and refresh your form
		
		'UPGRADE_WARNING: Couldn't resolve default property of object MyTextBox.Text. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object ReturnValue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MyTextBox.Text = ReturnValue
		'UPGRADE_WARNING: Couldn't resolve default property of object MyTextBox.Refresh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MyTextBox.Refresh()
		
	End Function
	Public Function ReplaceText(ByRef CleanThis As String, ByRef OldText As String, ByRef NewText As String) As Object
		Dim ReplaceInString As Object
		
		'To get the len of the string
		Dim StrLn As Integer
		
		'To split the string
		Dim PartA, PartB As String
		
		'If search string is found, get its start position
		Dim FoundP As Integer
		Dim OldLn As Integer
		On Error GoTo ErrHandle
		
		'Set a value for the len of the old text to be replaced
		OldLn = Len(OldText)
		StrLn = Len(CleanThis)
		
		'Loop through the string until all occurences are eliminated
		
		Do While InStr(1, CleanThis, OldText) <> 0
			FoundP = InStr(1, CleanThis, OldText)
			
			'Get PartA of the string (before found occurance)
			PartA = Left(CleanThis, FoundP - 1)
			
			'Get PartB of the string (after found occurance)
			PartB = Right(CleanThis, StrLn - FoundP - OldLn + 1)
			
			'*NOTE ON THE ADDITION AND SUBTRACTION**
			'******************************************************
			'+ 1 to avoid a skip in adding found len and old len
			'The previous line could also be written
			'
			'PartB = Right(CleanThis, StrLn - (FoundP + OldLn - 1))
			'******************************************************
			'REBUILD THE STRING BEFORE NEXT LOOP
			'This adds a space before and after NewText
			'and trims out unneccessary spaces too!
			
			CleanThis = Trim(PartA) & " " & Trim(NewText) & " " & Trim(PartB)
			'GET NEW LEN BEFORE LOOPING
			StrLn = Len(CleanThis)
		Loop 
		
		'Set result of the function
		'UPGRADE_WARNING: Couldn't resolve default property of object ReplaceInString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ReplaceInString = CleanThis
		
		
		'Avoid error handling
		Exit Function
		'Add your own error code hereafter
ErrHandle: 
		Select Case Err.Number
			Case Err.Number
				MsgBox("Your function executed with an error " & Err.Number & vbCrLf & vbCrLf & Err.Description, MsgBoxStyle.Exclamation, "Error " & Err.Number)
				Err.Clear()
		End Select
		Resume Next
	End Function
	Function NumToWords(ByVal nNumber As Double) As String
		Dim nTrillions As Object
		Dim nBillions As Object
		Dim nMillions As Object
		Dim nThousands As Object
		Dim nRest As Object
		Dim nHundredsPlace As Object
		Dim nOnesPlace As Object
		Dim nTensPlace As Object
		Dim cDigitWord As Object
		Dim nDigit As Object
		Dim nFrac As Object
		Dim cWords As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cWords = ""
		
		If nNumber < 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cWords = "Negative " & NumToWords(-1 * nNumber)
			
		ElseIf nNumber <> Int(nNumber) Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cWords = NumToWords(Int(nNumber))
			'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cWords = cWords + " point"
			'UPGRADE_WARNING: Couldn't resolve default property of object nFrac. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			nFrac = nNumber - Int(nNumber)
			Do 
				'UPGRADE_WARNING: Couldn't resolve default property of object nFrac. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				nFrac = nFrac * 10
				'UPGRADE_WARNING: Couldn't resolve default property of object nDigit. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				nDigit = Int(CDbl(nFrac))
				'UPGRADE_WARNING: Couldn't resolve default property of object nDigit. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object nFrac. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				nFrac = nFrac - nDigit
				
				'UPGRADE_WARNING: Couldn't resolve default property of object nDigit. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If nDigit > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object nDigit. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object cDigitWord. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cDigitWord = NumToWords(nDigit)
					'UPGRADE_WARNING: Couldn't resolve default property of object cDigitWord. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = cWords + " " + cDigitWord
				Else
					Exit Do
				End If
			Loop 
			
		ElseIf nNumber < 20 Then 
			Select Case nNumber
				Case 0
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Zero"
				Case 1
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "One"
				Case 2
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Two"
				Case 3
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Three"
				Case 4
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Four"
				Case 5
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Five"
				Case 6
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Six"
				Case 7
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Seven"
				Case 8
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Eight"
				Case 9
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Nine"
				Case 10
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Ten"
				Case 11
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Eleven"
				Case 12
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Twelve"
				Case 13
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Thirteen"
				Case 14
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Fourteen"
				Case 15
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Fifteen"
				Case 16
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Sixteen"
				Case 17
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Seventeen"
				Case 18
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Eighteen"
				Case 19
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Ninteen"
			End Select
			
		ElseIf nNumber < 100 Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object nTensPlace. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			nTensPlace = Int(nNumber / 10)
			'UPGRADE_WARNING: Mod has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object nOnesPlace. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			nOnesPlace = nNumber Mod 10
			'UPGRADE_WARNING: Couldn't resolve default property of object nTensPlace. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Select Case nTensPlace * 10
				Case 20
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Twenty"
				Case 30
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Thirty"
				Case 40
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Forty"
				Case 50
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Fifty"
				Case 60
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Sixty"
				Case 70
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Seventy"
				Case 80
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Eighty"
				Case 90
					'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cWords = "Ninty"
			End Select
			'UPGRADE_WARNING: Couldn't resolve default property of object nOnesPlace. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If nOnesPlace > 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cWords = cWords + " " + NumToWords(nOnesPlace)
			End If
			
		ElseIf nNumber < 1000 Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object nHundredsPlace. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			nHundredsPlace = Int(nNumber / 100)
			'UPGRADE_WARNING: Mod has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object nRest. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			nRest = nNumber Mod 100
			'UPGRADE_WARNING: Couldn't resolve default property of object nHundredsPlace. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cWords = NumToWords(nHundredsPlace)
			'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cWords = cWords + " Hundred"
			'UPGRADE_WARNING: Couldn't resolve default property of object nRest. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If nRest > 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cWords = cWords + " " + NumToWords(nRest)
			End If
			
		ElseIf nNumber < 1000000 Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object nThousands. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			nThousands = Int(nNumber / 1000)
			'UPGRADE_WARNING: Mod has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object nRest. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			nRest = nNumber Mod 1000
			'UPGRADE_WARNING: Couldn't resolve default property of object nThousands. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cWords = NumToWords(nThousands)
			'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cWords = cWords + " Thousand"
			'UPGRADE_WARNING: Couldn't resolve default property of object nRest. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If nRest > 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cWords = cWords + " " + NumToWords(nRest)
			End If
			
		ElseIf nNumber < 1000000000 Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object nMillions. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			nMillions = Int(nNumber / 1000000)
			'UPGRADE_WARNING: Mod has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object nRest. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			nRest = Int(nNumber Mod 1000000)
			'UPGRADE_WARNING: Couldn't resolve default property of object nMillions. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cWords = NumToWords(nMillions)
			'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cWords = cWords + " Million"
			'UPGRADE_WARNING: Couldn't resolve default property of object nRest. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If nRest > 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cWords = cWords + " " + NumToWords(nRest)
			End If
			
		ElseIf nNumber < 1000000000000# Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object nBillions. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			nBillions = Int(nNumber / 1000000000)
			'UPGRADE_WARNING: Mod has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object nRest. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			nRest = Int(nNumber Mod 1000000000)
			'UPGRADE_WARNING: Couldn't resolve default property of object nBillions. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cWords = NumToWords(nBillions)
			'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cWords = cWords + " Billion"
			'UPGRADE_WARNING: Couldn't resolve default property of object nRest. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If nRest > 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cWords = cWords + " " + NumToWords(nRest)
			End If
			
		ElseIf nNumber < 1E+15 Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object nTrillions. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			nTrillions = Int(nNumber / 1000000000000#)
			'UPGRADE_WARNING: Mod has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object nRest. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			nRest = Int(nNumber Mod 1000000000000#)
			'UPGRADE_WARNING: Couldn't resolve default property of object nTrillions. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cWords = NumToWords(nTrillions)
			'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cWords = cWords + " Trillion"
			'UPGRADE_WARNING: Couldn't resolve default property of object nRest. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If nRest > 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cWords = cWords + " " + NumToWords(nRest)
			End If
			
			' You can follow the pattern of the Millions / Billions / Trillions
			'  if you need bigger numbers.
			
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object cWords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NumToWords = cWords
	End Function
End Module