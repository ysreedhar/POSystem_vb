Option Strict Off
Option Explicit On
Friend Class frmVendor
	Inherits System.Windows.Forms.Form
	Dim rowno As Short
	Dim verify As Boolean
	Private Sub cmdclose1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdclose1.ClickEvent
		Me.Close()
	End Sub
	Private Sub cmdclosevendor_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdclosevendor.ClickEvent
		Me.Close()
	End Sub
	Private Sub frmVendor_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call UPPER_CASE(KeyAscii)
		If KeyAscii = CDbl("27") Then Call Image2_Click(Image2, New System.EventArgs())
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub Image2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image2.Click
		Me.Close()
	End Sub
	Private Function validate_fields() As Boolean
		verify = False
		If Len(Trim(txtVendorFirmName.Text)) = 0 Then
			MsgBox("Please enter the Vendor's firm name", MsgBoxStyle.Exclamation)
			txtVendorFirmName.Focus()
			validate_fields = False
		ElseIf Len(Trim(txtVendorName.Text)) = 0 Then 
			MsgBox("Please enter the Vendor's name", MsgBoxStyle.Exclamation)
			txtVendorName.Focus()
			validate_fields = False
		ElseIf Len(Trim(txtVendorAdd.Text)) = 0 Then 
			MsgBox("Please enter the Vendor's address", MsgBoxStyle.Exclamation)
			txtVendorAdd.Focus()
			validate_fields = False
		ElseIf Len(Trim(txtVendorCity.Text)) = 0 Then 
			MsgBox("Please enter the Vendor's city", MsgBoxStyle.Exclamation)
			txtVendorCity.Focus()
			validate_fields = False
		ElseIf Len(Trim(txtVendorCountry.Text)) = 0 Then 
			MsgBox("Please enter the Vendor's country", MsgBoxStyle.Exclamation)
			txtVendorCountry.Focus()
			validate_fields = False
		ElseIf Len(Trim(TxtRegNo.Text)) = 0 Then 
			MsgBox("Please enter the registration No.", MsgBoxStyle.Exclamation)
			TxtRegNo.Focus()
			validate_fields = False
		Else
			validate_fields = True
		End If
	End Function
	Private Sub cmdExVenDelete_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExVenDelete.ClickEvent
		'On Error Resume Next
		Dim Style, Msg, response As Object
		If txtExVID.Text = "" Then
			MsgBox("First Select Any Record", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical)
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Msg = "Do you really want to delete this record ?" ' Define message.
			'UPGRADE_WARNING: Couldn't resolve default property of object Style. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Style = MsgBoxStyle.YesNo + MsgBoxStyle.Critical ' Define buttons.
			'UPGRADE_WARNING: Couldn't resolve default property of object Style. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object response. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			response = MsgBox(Msg, Style)
			If response = MsgBoxResult.Yes Then ' User chose Yes.
				cn.Execute(" Update Vendor set  v_status='No'  where vendor_id=" & txtExVID.Text)
				Call Vendor_Detail()
				Call ClearText()
				Call Disable_Existing_Vendor()
			End If
		End If
	End Sub
	Private Sub cmdExVenSave_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExVenSave.ClickEvent
		'On Error Resume Next
		Dim Style, Msg, response As Object
		verify = ex_validate_fields
		Dim RS As New ADODB.Recordset
		If verify = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Msg = "Do you really want to update this record ?" ' Define message.
			'UPGRADE_WARNING: Couldn't resolve default property of object Style. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Style = MsgBoxStyle.YesNo + MsgBoxStyle.Critical ' Define buttons.
			'UPGRADE_WARNING: Couldn't resolve default property of object Style. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object response. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			response = MsgBox(Msg, Style)
			If response = MsgBoxResult.Yes Then ' User chose Yes.
				RS.Open(("select * from  vendor where vendor_id =" & txtExVID.Text), CON, 3, 2)
				If RS.EOF Then RS.AddNew()
				RS.Fields("v_name").Value = txtExVFirm.Text
				RS.Fields("v_contactperson").Value = txtExVName.Text
				RS.Fields("v_address").Value = txtExVAddress.Text
				RS.Fields("v_city").Value = txtExVCity.Text
				RS.Fields("v_country").Value = txtExVCountry.Text
				RS.Fields("v_phone").Value = txtExVPh.Text
				RS.Fields("v_mobile").Value = txtExVMob.Text
				RS.Fields("v_zip").Value = txtExVZip.Text
				RS.Fields("v_status").Value = "Yes"
				RS.Fields("v_fax").Value = txtExVFax.Text
				RS.Fields("v_email").Value = txtExVEmai.Text
				RS.Fields("v_regno").Value = TxtRegNoM.Text
				RS.Fields("VendorCode").Value = txtVendorCodeM.Text
				RS.Fields("AVL").Value = chkAVLM.CheckState
				RS.Update()
				RS.Close()
				Call Vendor_Detail()
				Call ClearText()
				Call Disable_Existing_Vendor()
			End If
		End If
	End Sub
	Private Function ex_validate_fields() As Boolean
		verify = False
		If Not IsNumeric(txtExVID.Text) Then
			MsgBox("Please Choose the Vendor's ID", MsgBoxStyle.Exclamation)
			ex_validate_fields = False
		ElseIf Trim(txtExVFirm.Text) = "" Then 
			MsgBox("Please enter the Vendor's firm name", MsgBoxStyle.Exclamation)
			txtExVFirm.Focus()
			ex_validate_fields = False
		ElseIf Trim(txtExVName.Text) = "" Then 
			MsgBox("Please enter the Vendor's name", MsgBoxStyle.Exclamation)
			txtExVName.Focus()
			ex_validate_fields = False
		ElseIf Trim(txtExVAddress.Text) = "" Then 
			MsgBox("Please enter the Vendor's address", MsgBoxStyle.Exclamation)
			txtExVAddress.Focus()
			ex_validate_fields = False
		ElseIf Trim(txtExVCity.Text) = "" Then 
			MsgBox("Please enter the Vendor's city", MsgBoxStyle.Exclamation)
			txtExVCity.Focus()
			ex_validate_fields = False
		ElseIf Trim(txtExVCountry.Text) = "" Then 
			MsgBox("Please enter the Vendor's country", MsgBoxStyle.Exclamation)
			txtExVCountry.Focus()
			ex_validate_fields = False
		ElseIf Len(Trim(TxtRegNoM.Text)) = 0 Then 
			MsgBox("Please enter the Registration No", MsgBoxStyle.Exclamation)
			TxtRegNoM.Focus()
			ex_validate_fields = False
		Else
			ex_validate_fields = True
		End If
	End Function
	Private Sub ClearTextNewVendor()
		txtVendorAdd.Text = ""
		txtVendorCity.Text = ""
		txtVendorCountry.Text = ""
		txtVendorEmail.Text = ""
		txtVendorFax.Text = ""
		txtVendorFirmName.Text = ""
		txtVendorId.Text = ""
		txtVendorMob.Text = ""
		txtVendorName.Text = ""
		txtVendorPh.Text = ""
		txtVendorZip.Text = ""
		TxtRegNo.Text = ""
		txtVendorFirmName.Focus()
	End Sub
	Private Sub ClearText()
		txtExVAddress.Text = ""
		txtExVEmai.Text = ""
		txtExVFax.Text = ""
		txtExVFirm.Text = ""
		txtExVMob.Text = ""
		txtExVID.Text = ""
		txtExVName.Text = ""
		txtExVPh.Text = ""
		txtExVZip.Text = ""
		txtExVCity.Text = ""
		txtExVCountry.Text = ""
		TxtRegNoM.Text = ""
		
	End Sub
	
	Private Sub cmdSaveVendor_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSaveVendor.ClickEvent
		'On Error Resume Next
		Dim Style, Msg, response As Object
		verify = validate_fields
		Dim RS As New ADODB.Recordset
		If verify = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Msg = "Do you really want to save this record ....?" ' Define message.
			'UPGRADE_WARNING: Couldn't resolve default property of object Style. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Style = MsgBoxStyle.YesNo + MsgBoxStyle.Critical ' Define buttons.
			'UPGRADE_WARNING: Couldn't resolve default property of object Style. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object response. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			response = MsgBox(Msg, Style)
			If response = MsgBoxResult.Yes Then ' User chose Yes.
				RS.Open(("select * from  vendor"), CON, 3, 2)
				RS.AddNew()
				RS.Fields("v_name").Value = txtVendorFirmName.Text
				RS.Fields("v_contactperson").Value = txtVendorName.Text
				RS.Fields("v_address").Value = txtVendorAdd.Text
				RS.Fields("v_city").Value = txtVendorCity.Text
				RS.Fields("v_country").Value = txtVendorCountry.Text
				RS.Fields("v_phone").Value = txtVendorPh.Text
				RS.Fields("v_mobile").Value = txtVendorMob.Text
				RS.Fields("v_zip").Value = txtVendorZip.Text
				RS.Fields("v_status").Value = "Yes"
				RS.Fields("v_fax").Value = txtVendorFax.Text
				RS.Fields("v_email").Value = txtVendorEmail.Text
				RS.Fields("v_regno").Value = Trim(TxtRegNo.Text)
				'UPGRADE_WARNING: Couldn't resolve default property of object DTPicker1.Value. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				RS.Fields("REGDATE").Value = DTPicker1.Value
				RS.Fields("VendorCode").Value = txtVendorCode.Text
				RS.Fields("AVL").Value = chkAVL.CheckState
				RS.Update()
				RS.Close()
				Call ClearTextNewVendor()
			Else
				Call VendorID()
				txtVendorFirmName.Focus()
			End If
		End If
	End Sub
	
	Private Sub frmVendor_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		If CON.State Then CON.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CON.Open(ConnectString)
		
		'  Call connect
		Call VendorID()
		Call Vendor_Detail()
		Call Disable_Existing_Vendor()
		
		
		
		
	End Sub
	
	Private Sub SSTab1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SSTab1.SelectedIndexChanged
		Static PreviousTab As Short = SSTab1.SelectedIndex()
		If SSTab1.SelectedIndex = 0 Then
			Call ClearTextNewVendor()
			Call VendorID()
			txtVendorFirmName.Focus()
		ElseIf SSTab1.SelectedIndex = 1 Then 
			Call Vendor_Detail()
			Call Disable_Existing_Vendor()
			Call ClearText()
			txtExVFirm.Focus()
		End If
		PreviousTab = SSTab1.SelectedIndex()
	End Sub
	Private Sub Enable_Existing_Vendor()
		
	End Sub
	
	Private Sub Disable_Existing_Vendor()
		
	End Sub
	Private Sub MSFlexGrid1_SelChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MSFlexGrid1.SelChange
		'On Error Resume Next
		TxtRegNoM.Text = ""
		MSFlexGrid1.Col = 1
		rowno = CShort(MSFlexGrid1.Text)
		Dim RS As New ADODB.Recordset
		RS.Open(("Select * from vendor where vendor_id = " & rowno), CON, 3, 2)
		txtExVID.Text = RS.Fields("vendor_id").Value
		txtExVAddress.Text = RS.Fields("v_address").Value
		txtExVFax.Text = RS.Fields("v_fax").Value
		txtExVFirm.Text = RS.Fields("v_name").Value
		txtExVMob.Text = RS.Fields("v_mobile").Value
		txtExVName.Text = RS.Fields("v_contactperson").Value
		txtExVPh.Text = RS.Fields("v_phone").Value
		txtExVZip.Text = RS.Fields("v_zip").Value
		txtExVEmai.Text = "" & RS.Fields("v_email").Value
		txtExVCity.Text = RS.Fields("v_city").Value
		txtExVCountry.Text = RS.Fields("v_country").Value
		TxtRegNoM.Text = RS.Fields("v_regno").Value
		RS.Close()
		Call Disable_Existing_Vendor()
	End Sub
	Private Sub VendorID()
		'On Error Resume Next
		Dim RS As New ADODB.Recordset
		
		RS.Open(("Select  Max(Vendor_id) from vendor"), CON, 3, 2)
		If RS.Fields(0).Value > 0 Then
			txtVendorId.Text = CStr(Val(RS.Fields(0).Value) + 1)
		Else
			txtVendorId.Text = CStr(1)
		End If
	End Sub
	Public Sub Vendor_Detail()
		Dim j As Object
		Dim k As Object
		'On Error Resume Next
		Dim RS As New ADODB.Recordset
		RS.Open(("Select Vendor_id,v_name,v_contactperson,v_address,v_city,v_country,v_phone,v_mobile,v_zip,v_fax,v_email,v_regno from Vendor where v_status = 'Yes' order by v_name"), CON, 3, 2)
		Dim i As Short
		While Not RS.EOF
			i = i + 1
			RS.MoveNext()
		End While
		MSFlexGrid1.Cols = 13
		MSFlexGrid1.Rows = i + 1
		MSFlexGrid1.Row = 0
		
		MSFlexGrid1.Col = 0
		MSFlexGrid1.CellFontBold = True
		MSFlexGrid1.CellAlignment = 4
		MSFlexGrid1.Text = "S.No."
		MSFlexGrid1.set_ColWidth(0, 550)
		
		MSFlexGrid1.Col = 1
		MSFlexGrid1.Text = "ID"
		MSFlexGrid1.set_ColWidth(1, 0)
		
		MSFlexGrid1.Col = 2
		MSFlexGrid1.CellFontBold = True
		MSFlexGrid1.CellAlignment = 4
		MSFlexGrid1.Text = "Company / Firm Name"
		MSFlexGrid1.set_ColWidth(2, 2950)
		
		MSFlexGrid1.Col = 3
		MSFlexGrid1.CellFontBold = True
		MSFlexGrid1.CellAlignment = 4
		MSFlexGrid1.Text = "Contact Person"
		MSFlexGrid1.set_ColWidth(3, 2000)
		
		MSFlexGrid1.Col = 4
		MSFlexGrid1.CellFontBold = True
		MSFlexGrid1.CellAlignment = 4
		MSFlexGrid1.Text = " Address "
		MSFlexGrid1.set_ColWidth(4, 2500)
		
		MSFlexGrid1.Col = 5
		MSFlexGrid1.CellFontBold = True
		MSFlexGrid1.CellAlignment = 4
		MSFlexGrid1.Text = " City "
		MSFlexGrid1.set_ColWidth(5, 1500)
		
		MSFlexGrid1.Col = 6
		MSFlexGrid1.CellFontBold = True
		MSFlexGrid1.CellAlignment = 4
		MSFlexGrid1.Text = " Country "
		MSFlexGrid1.set_ColWidth(6, 1000)
		
		MSFlexGrid1.Col = 7
		MSFlexGrid1.CellFontBold = True
		MSFlexGrid1.CellAlignment = 4
		MSFlexGrid1.Text = "Phone"
		MSFlexGrid1.set_ColWidth(7, 1000)
		
		MSFlexGrid1.Col = 8
		MSFlexGrid1.CellFontBold = True
		MSFlexGrid1.CellAlignment = 4
		MSFlexGrid1.Text = "Mobile"
		MSFlexGrid1.set_ColWidth(8, 1000)
		
		MSFlexGrid1.Col = 9
		MSFlexGrid1.CellFontBold = True
		MSFlexGrid1.CellAlignment = 4
		MSFlexGrid1.Text = "Zip"
		MSFlexGrid1.set_ColWidth(9, 1000)
		
		MSFlexGrid1.Col = 10
		MSFlexGrid1.CellFontBold = True
		MSFlexGrid1.CellAlignment = 4
		MSFlexGrid1.Text = "Fax"
		MSFlexGrid1.set_ColWidth(10, 1000)
		
		MSFlexGrid1.Col = 11
		MSFlexGrid1.CellFontBold = True
		MSFlexGrid1.CellAlignment = 4
		MSFlexGrid1.Text = "Email"
		MSFlexGrid1.set_ColWidth(11, 3000)
		
		MSFlexGrid1.Col = 12
		MSFlexGrid1.CellFontBold = True
		MSFlexGrid1.CellAlignment = 4
		MSFlexGrid1.Text = "Registration No."
		MSFlexGrid1.set_ColWidth(12, 3000)
		i = 1
		If RS.State = 1 Then
			RS.Close()
		End If
		RS.Open(("Select Vendor_id,v_name,v_contactperson,v_address,v_city,v_country,v_phone,v_mobile,v_zip,v_fax,v_email,v_regno from Vendor where v_status = 'Yes' order by v_name"), CON, 3, 2)
		
		While Not RS.EOF
			MSFlexGrid1.Row = i
			'UPGRADE_WARNING: Couldn't resolve default property of object k. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			k = 0
			MSFlexGrid1.Col = 0
			MSFlexGrid1.CellAlignment = 4
			MSFlexGrid1.CellFontBold = True
			MSFlexGrid1.Text = CStr(i)
			For j = 1 To 12
				'UPGRADE_WARNING: Couldn't resolve default property of object j. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MSFlexGrid1.Col = j
				MSFlexGrid1.Text = "" & RS.Fields(k).Value
				'UPGRADE_WARNING: Couldn't resolve default property of object k. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				k = k + 1
			Next j
			RS.MoveNext()
			i = i + 1
		End While
	End Sub
	
	Private Sub txtExVAddress_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtExVAddress.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then GoTo EventExitSub
		KeyAscii = TxtAcceptString((Me.txtExVAddress), KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtExVAddress_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtExVAddress.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtExVCity_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtExVCity.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then GoTo EventExitSub
		KeyAscii = TxtAcceptString((Me.txtExVCity), KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtExVCity_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtExVCity.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtExVCountry_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtExVCountry.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then GoTo EventExitSub
		KeyAscii = TxtAcceptString((Me.txtExVCountry), KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtExVCountry_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtExVCountry.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	
	Private Sub txtExVEmai_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtExVEmai.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then GoTo EventExitSub
		
		KeyAscii = TxtAcceptString((Me.txtExVEmai), KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtExVEmai_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtExVEmai.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtExVFax_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtExVFax.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then GoTo EventExitSub
		KeyAscii = TxtAcceptString((Me.txtExVFax), KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtExVFax_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtExVFax.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtExVFirm_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtExVFirm.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then GoTo EventExitSub
		KeyAscii = TxtAcceptString((Me.txtExVFirm), KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtExVFirm_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtExVFirm.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtExVMob_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtExVMob.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim TxtAcceptNumeric As Object
		If KeyAscii = 13 Then GoTo EventExitSub
		'UPGRADE_WARNING: Couldn't resolve default property of object TxtAcceptNumeric(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		KeyAscii = TxtAcceptNumeric(Me.txtExVMob, KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtExVMob_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtExVMob.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtExVName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtExVName.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then GoTo EventExitSub
		KeyAscii = TxtAcceptString((Me.txtExVName), KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtExVName_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtExVName.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtExVPh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtExVPh.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim TxtAcceptNumeric As Object
		If KeyAscii = 13 Then GoTo EventExitSub
		'UPGRADE_WARNING: Couldn't resolve default property of object TxtAcceptNumeric(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		KeyAscii = TxtAcceptNumeric(Me.txtExVPh, KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtExVPh_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtExVPh.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtExVZip_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtExVZip.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim TxtAcceptNumeric As Object
		If KeyAscii = 13 Then GoTo EventExitSub
		'UPGRADE_WARNING: Couldn't resolve default property of object TxtAcceptNumeric(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		KeyAscii = TxtAcceptNumeric(Me.txtExVZip, KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtExVZip_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtExVZip.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub TxtRegNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtRegNo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim TxtAcceptNumeric As Object
		If KeyAscii = 13 Then GoTo EventExitSub
		'UPGRADE_WARNING: Couldn't resolve default property of object TxtAcceptNumeric(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		KeyAscii = TxtAcceptNumeric(Me.TxtRegNo, KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtregno_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtregno.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub TxtRegNoM_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtRegNoM.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim TxtAcceptNumeric As Object
		If KeyAscii = 13 Then GoTo EventExitSub
		'UPGRADE_WARNING: Couldn't resolve default property of object TxtAcceptNumeric(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		KeyAscii = TxtAcceptNumeric(Me.TxtRegNoM, KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TxtRegNoM_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles TxtRegNoM.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtVendorAdd_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVendorAdd.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then GoTo EventExitSub
		KeyAscii = TxtAcceptString((Me.txtVendorAdd), KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtVendorAdd_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVendorAdd.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtVendorCity_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVendorCity.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then GoTo EventExitSub
		KeyAscii = TxtAcceptString((Me.txtVendorCity), KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtVendorCity_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVendorCity.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtVendorCountry_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVendorCountry.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then GoTo EventExitSub
		KeyAscii = TxtAcceptString((Me.txtVendorCountry), KeyAscii)
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtVendorCountry_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVendorCountry.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtVendorEmail_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVendorEmail.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then GoTo EventExitSub
		KeyAscii = TxtAcceptString((Me.txtVendorEmail), KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtVendorEmail_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVendorEmail.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtVendorFax_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVendorFax.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim TxtAcceptNumeric As Object
		If KeyAscii = 13 Then GoTo EventExitSub
		
		'UPGRADE_WARNING: Couldn't resolve default property of object TxtAcceptNumeric(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		KeyAscii = TxtAcceptNumeric(Me.txtVendorFax, KeyAscii)
		
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtVendorFax_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVendorFax.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtVendorFirmName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVendorFirmName.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then GoTo EventExitSub
		KeyAscii = TxtAcceptString((Me.txtVendorFirmName), KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtVendorFirmName_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVendorFirmName.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtVendorMob_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVendorMob.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim TxtAcceptNumeric As Object
		If KeyAscii = 13 Then GoTo EventExitSub
		'UPGRADE_WARNING: Couldn't resolve default property of object TxtAcceptNumeric(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		KeyAscii = TxtAcceptNumeric(Me.txtVendorMob, KeyAscii)
		
		
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtVendorMob_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVendorMob.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtVendorName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVendorName.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then GoTo EventExitSub
		KeyAscii = TxtAcceptString((Me.txtVendorName), KeyAscii)
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtVendorName_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVendorName.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtVendorPh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVendorPh.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim TxtAcceptNumeric As Object
		If KeyAscii = 13 Then GoTo EventExitSub
		'UPGRADE_WARNING: Couldn't resolve default property of object TxtAcceptNumeric(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		KeyAscii = TxtAcceptNumeric(Me.txtVendorPh, KeyAscii)
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtVendorPh_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVendorPh.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
	
	Private Sub txtVendorZip_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVendorZip.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim TxtAcceptNumeric As Object
		If KeyAscii = 13 Then GoTo EventExitSub
		'UPGRADE_WARNING: Couldn't resolve default property of object TxtAcceptNumeric(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		KeyAscii = TxtAcceptNumeric(Me.txtVendorZip, KeyAscii)
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtVendorZip_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVendorZip.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'If KeyCode = 13 Then SendKeys "{TAB}"
	End Sub
End Class