Option Strict Off
Option Explicit On
Module ConvertRsToWord
	Public strDate As String
	Dim Flag As Boolean
	Dim flag_6 As Boolean
	Dim arr_unit(10) As String
	Dim arr_hundred(10) As String
	Dim arr_spl(10) As String
	Public Function getAmountInWords(ByRef str_amount As Object) As String
		Dim i As Object
		Dim str_token_2 As Object
		'On Error Resume Next
		Flag = False
		flag_6 = False
		arr_unit(0) = ""
		arr_unit(1) = "One"
		arr_unit(2) = "Two"
		arr_unit(3) = "Three"
		arr_unit(4) = "Four"
		arr_unit(5) = "Five"
		arr_unit(6) = "Six"
		arr_unit(7) = "Seven"
		arr_unit(8) = "Eight"
		arr_unit(9) = "Nine"
		arr_hundred(0) = ""
		arr_hundred(1) = "Ten"
		arr_hundred(2) = "Twenty"
		arr_hundred(3) = "Thirty"
		arr_hundred(4) = "Forty"
		arr_hundred(5) = "Fifty"
		arr_hundred(6) = "Sixty"
		arr_hundred(7) = "Seventy"
		arr_hundred(8) = "Eighty"
		arr_hundred(9) = "Ninety"
		arr_spl(0) = ""
		arr_spl(1) = "Eleven"
		arr_spl(2) = "Twelve"
		arr_spl(3) = "Thirteen"
		arr_spl(4) = "Fourteen"
		arr_spl(5) = "Fifteen"
		arr_spl(6) = "Sixteen"
		arr_spl(7) = "Seventeen"
		arr_spl(8) = "Eighteen"
		arr_spl(9) = "Nineteen"
		Dim str_words_ps, str_returnvalue, str_part, str_words_rs, str_token_1 As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		str_part = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		str_returnvalue = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object str_words_rs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		str_words_rs = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object str_words_ps. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		str_words_ps = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object str_token_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		str_token_1 = ""
		flag_6 = False
		
		Dim Temp As Double
		'UPGRADE_WARNING: Couldn't resolve default property of object str_amount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Temp = CDbl(str_amount)
		Dim Ind As Object
		If Err.Number > 0 Then
			MsgBox("Please Enter some Amount", MsgBoxStyle.Information)
			getAmountInWords = ""
			Exit Function
		Else
			
			'UPGRADE_WARNING: Couldn't resolve default property of object str_amount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Ind. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Ind = InStr(str_amount, ".")
			
			'UPGRADE_WARNING: Couldn't resolve default property of object Ind. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If (Ind <> 0) Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Ind. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object str_amount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object str_token_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				str_token_1 = Mid(str_amount, 1, Ind)
				'UPGRADE_WARNING: Couldn't resolve default property of object Ind. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object str_amount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object str_token_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				str_token_2 = Mid(str_amount, Ind + 1, Len(str_amount))
				'UPGRADE_WARNING: Couldn't resolve default property of object str_token_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Len(str_token_2) = 1 Then str_token_2 = str_token_2 & "0"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object str_amount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object str_token_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				str_token_1 = str_amount
				'UPGRADE_WARNING: Couldn't resolve default property of object str_token_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				str_token_2 = ""
			End If
			For i = 1 To Len(str_token_1)
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object str_token_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				str_part = Mid(str_token_1, i, Len(str_token_1))
				'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				str_returnvalue = getWords(str_part)
				'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object str_words_rs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If (str_returnvalue <> "") Then str_words_rs = str_words_rs & str_returnvalue & " "
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If (Flag) Then i = i + 1
			Next 
			'UPGRADE_WARNING: Couldn't resolve default property of object str_token_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If (str_token_2 <> "" And str_token_2 <> "00") Then
				For i = 1 To Len(str_token_2)
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object str_token_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					str_part = Mid(str_token_2, i, Len(str_token_2))
					'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					str_returnvalue = getWords(str_part)
					'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object str_words_ps. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If (str_returnvalue <> "") Then str_words_ps = str_words_ps & str_returnvalue & " "
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If Flag Then i = i + 1
				Next 
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object str_token_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If (str_token_2 <> "" And str_token_2 <> "00") Then
				'UPGRADE_WARNING: Couldn't resolve default property of object str_words_ps. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object str_words_rs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				getAmountInWords = str_words_rs & " And " & str_words_ps & "Cents Only"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object str_words_rs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				getAmountInWords = str_words_rs & " Only"
			End If
		End If
	End Function
	
	
	Public Function getWords(ByRef str_part As Object) As String
		'On Error Resume Next
		Dim val_1, val_2 As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		val_1 = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object val_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		val_2 = ""
		Dim str_returnvalue As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		str_returnvalue = ""
		Flag = False
		Dim k As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object k. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		k = Len(str_part)
		
		Select Case k
			Case 0
			Case 1
				Err.Clear()
				'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				val_1 = CInt(Mid(str_part, 1, 1))
				If Err.Number = 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					str_returnvalue = arr_unit(val_1)
				End If
			Case 2
				Err.Clear()
				'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				val_1 = CInt(Mid(str_part, 1, 1))
				'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				val_2 = CInt(Mid(str_part, 2, 1))
				'UPGRADE_WARNING: Couldn't resolve default property of object val_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If (val_1 = 1 And val_2 <> 0) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object val_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					str_returnvalue = arr_spl(val_2)
					Flag = True
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					str_returnvalue = arr_hundred(val_1)
				End If
				
			Case 3
				'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				val_1 = CInt(Mid(str_part, 1, 1))
				'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If (val_1 = 0) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					str_returnvalue = ""
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					str_returnvalue = arr_unit(val_1) & " " & "Hundred"
				End If
			Case 4
				'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				val_1 = CInt(Mid(str_part, 1, 1))
				'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If (val_1 = 0 And flag_6) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					str_returnvalue = arr_unit(val_1)
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					str_returnvalue = arr_unit(val_1) & " " & "Thousand"
				End If
			Case 5
				Err.Clear()
				'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				val_1 = CInt(Mid(str_part, 1, 1))
				'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				val_2 = CInt(Mid(str_part, 2, 1))
				
				'UPGRADE_WARNING: Couldn't resolve default property of object val_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If (val_1 = 1 And val_2 <> 0) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object val_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					str_returnvalue = arr_spl(val_2) & " " & "Thousand"
					Flag = True
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					str_returnvalue = arr_hundred(val_1)
				End If
				
			Case 6
				Err.Clear()
				'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				val_1 = CInt(Mid(str_part, 1, 1))
				'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				val_2 = CInt(Mid(str_part, 2, 1))
				'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				str_returnvalue = arr_unit(val_1) & " " & "Thousand"
				'UPGRADE_WARNING: Couldn't resolve default property of object val_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If (val_2 = 0) Then flag_6 = True
				
			Case 7
				Err.Clear()
				'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				val_1 = CInt(Mid(str_part, 1, 1))
				'UPGRADE_WARNING: Couldn't resolve default property of object str_part. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				val_2 = CInt(Mid(str_part, 2, 1))
				'UPGRADE_WARNING: Couldn't resolve default property of object val_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If (val_1 = 1 And val_2 <> 0) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object val_2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					str_returnvalue = arr_spl(val_2) & " " & "Million"
					Flag = True
					flag_6 = True
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object val_1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					str_returnvalue = arr_hundred(val_1)
				End If
		End Select
		
		'UPGRADE_WARNING: Couldn't resolve default property of object str_returnvalue. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		getWords = str_returnvalue
	End Function
	
	
End Module