Option Strict Off
Option Explicit On
Friend Class frmPOEntry
	Inherits System.Windows.Forms.Form
	Dim Bookmark As Double
	Dim addflag As String
	Dim i As Object
	Dim newRecordID As Short
	Dim rsVendors As New ADODB.Recordset
	Dim rsDeliveryPoints As New ADODB.Recordset
	Dim dbltotal As Double
	Dim verify As Boolean
	Dim Con As New ADODB.Connection
	Private Sub LoadVendors()
		cboVendorName.Items.Clear()
		If rsVendors.State Then RS.Close()
		rsVendors.Open("Select v_name from Vendor order by v_name", Con, 3, 2)
		While Not rsVendors.EOF
			cboVendorName.Items.Add(rsVendors.Fields(0).Value)
			rsVendors.MoveNext()
		End While
		If rsVendors.State Then rsVendors.Close()
	End Sub
	Private Sub LoadDeliveryPoints()
		cboDeliveryPoint.Items.Clear()
		If rsDeliveryPoints.State Then RS.Close()
		rsDeliveryPoints.Open("Select DeliveryPointName from DeliveryPoints ", Con, 3, 2)
		While Not rsDeliveryPoints.EOF
			cboDeliveryPoint.Items.Add(rsDeliveryPoints.Fields(0).Value)
			rsDeliveryPoints.MoveNext()
		End While
		If rsDeliveryPoints.State Then rsDeliveryPoints.Close()
	End Sub
	Function GetVendorAddress() As Object
		If Len(cboVendorName.Text) > 0 Then
			If rsVendors.State Then RS.Close()
			rsVendors.Open("Select v_address,v_phone,v_fax,v_contactperson   from Vendor where v_name = '" & cboVendorName.Text & "'", Con, 3, 2)
			If Not rsVendors.EOF Then
				txtAddress.Text = rsVendors.Fields(0).Value & vbNewLine & "TEL.:" & rsVendors.Fields(1).Value & vbNewLine & "FAX:" & rsVendors.Fields(2).Value & vbNewLine & "ATTN:" & rsVendors.Fields(3).Value
			End If
		End If
		If rsVendors.State Then rsVendors.Close()
	End Function
	Function GetDeliveryPointInfo() As Object
		If Len(cboDeliveryPoint.Text) > 0 Then
			If rsDeliveryPoints.State Then RS.Close()
			rsDeliveryPoints.Open("Select DeliveryPointAddress  from DeliveryPoints where DeliveryPointName = '" & cboDeliveryPoint.Text & "'", Con, 3, 2)
			If Not rsDeliveryPoints.EOF Then
				txtDeliveryTerms.Text = cboDeliveryPoint.Text & vbNewLine & "Address.:" & rsDeliveryPoints.Fields(0).Value
			End If
		End If
		If rsDeliveryPoints.State Then rsDeliveryPoints.Close()
	End Function
	'UPGRADE_WARNING: Event cboDeliveryPoint.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	'UPGRADE_WARNING: ComboBox event cboDeliveryPoint.Change was upgraded to cboDeliveryPoint.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
	Private Sub cboDeliveryPoint_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDeliveryPoint.TextChanged
		GetDeliveryPointInfo()
	End Sub
	'UPGRADE_WARNING: Event cboDeliveryPoint.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboDeliveryPoint_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDeliveryPoint.SelectedIndexChanged
		GetDeliveryPointInfo()
	End Sub
	'UPGRADE_WARNING: Event cboVendorName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	'UPGRADE_WARNING: ComboBox event cboVendorName.Change was upgraded to cboVendorName.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
	Private Sub cboVendorName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVendorName.TextChanged
		txtAddress.Text = ""
		GetVendorAddress()
	End Sub
	'UPGRADE_WARNING: Event cboVendorName.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboVendorName_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVendorName.SelectedIndexChanged
		txtAddress.Text = ""
		GetVendorAddress()
	End Sub
	Private Function ex_validate_fields() As Boolean
		verify = False
		If cboVendorName.Text = "" Then
			MsgBox("Please Choose the Vendor's Name", MsgBoxStyle.Exclamation)
			ex_validate_fields = False
		ElseIf txtAddress.Text = "" Then 
			MsgBox("Please Enter the Vendor's Address!", MsgBoxStyle.Exclamation)
			ex_validate_fields = False
		ElseIf txtPONumber.Text = "" Then 
			MsgBox("Please Enter the PO Number!", MsgBoxStyle.Exclamation)
			ex_validate_fields = False
		ElseIf txtRemarks.Text = "" Then 
			MsgBox("Please Enter the Remarks / Project Information!", MsgBoxStyle.Exclamation)
			ex_validate_fields = False
		ElseIf txtDeliveryTerms.Text = "" Then 
			MsgBox("Please Enter the Delivery Terms Information!", MsgBoxStyle.Exclamation)
			ex_validate_fields = False
		ElseIf txtReqOrderNo.Text = "" Then 
			MsgBox("Please Enter the Request Order Number!", MsgBoxStyle.Exclamation)
			ex_validate_fields = False
		ElseIf txtCostCenter.Text = "" Then 
			MsgBox("Please Enter the Cost Center!", MsgBoxStyle.Exclamation)
			ex_validate_fields = False
		ElseIf txtOrderedBy.Text = "" Then 
			MsgBox("Please Enter Ordered by!", MsgBoxStyle.Exclamation)
			ex_validate_fields = False
		ElseIf txtApprovedBy.Text = "" Then 
			MsgBox("Please Enter the Approving Authority!", MsgBoxStyle.Exclamation)
			ex_validate_fields = False
		ElseIf txtCurrency.Text = "" Then 
			MsgBox("Please Enter the Currency!", MsgBoxStyle.Exclamation)
			ex_validate_fields = False
		ElseIf cboDeliveryPoint.Text = "" Then 
			MsgBox("Please Choose the Delivery Point Information!", MsgBoxStyle.Exclamation)
			ex_validate_fields = False
		ElseIf flxPODetails.get_TextMatrix(1, 0) = "" Then 
			MsgBox("Please Enter atleast one Item to Enter!", MsgBoxStyle.Exclamation)
			ex_validate_fields = False
		Else
			ex_validate_fields = True
		End If
	End Function
	Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
		On Error Resume Next
		If ex_validate_fields = False Then Exit Sub
		Dim alert As String
		alert = CStr(MsgBox("Do you want to Save this record?", MsgBoxStyle.OKCancel))
		Dim RsAdd As New ADODB.Recordset
		If alert = CStr(MsgBoxResult.OK) Then
			If RsAdd.State Then RsAdd.Close()
			RsAdd.Open("Select * from PO_Header", Con, 3, 2)
			RsAdd.AddNew()
			RsAdd.Fields("VendorName").Value = cboVendorName.Text
			RsAdd.Fields("VendorAddress").Value = txtAddress.Text
			RsAdd.Fields("PO_OrderNo").Value = txtPONumber.Text
			RsAdd.Fields("PO_Date").Value = VB6.Format(dtpPODate.Value, "MM/dd/yyyy")
			RsAdd.Fields("Requisition_OrderNo").Value = txtReqOrderNo.Text
			RsAdd.Fields("CostCenter").Value = txtCostCenter.Text
			RsAdd.Fields("Orderedby").Value = txtOrderedBy.Text
			RsAdd.Fields("Approvedby").Value = txtApprovedBy.Text
			RsAdd.Fields("Remarks").Value = txtRemarks.Text
			RsAdd.Fields("DeliveryTerms").Value = txtDeliveryTerms.Text
			RsAdd.Fields("Currency").Value = txtCurrency.Text
			RsAdd.Fields("CnctPerson").Value = ""
			RsAdd.Fields("VendorRef").Value = ""
			RsAdd.Fields("Project").Value = ""
			RsAdd.Fields("VesselName").Value = ""
			RsAdd.Fields("EndUser").Value = ""
			RsAdd.Fields("Buyer").Value = ""
			RsAdd.Fields("Type").Value = ""
			RsAdd.Update()
			Bookmark = RsAdd.AbsolutePosition ' First, store the location of the cursor
			RsAdd.Requery()
			RsAdd.AbsolutePosition = Bookmark
			newRecordID = RsAdd.Fields("POID").Value
			If RsAdd.State Then RsAdd.Close()
			'Save the Detail
			For i = 1 To flxPODetails.Rows - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If flxPODetails.get_TextMatrix(i, 0) <> "" Then
					RsAdd.Open("Select * from PO_Details", Con, 3, 2)
					RsAdd.AddNew()
					RsAdd.Fields("POID").Value = newRecordID
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					RsAdd.Fields("ItemDescription").Value = flxPODetails.get_TextMatrix(i, 0)
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					RsAdd.Fields("quantity").Value = flxPODetails.get_TextMatrix(i, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					RsAdd.Fields("UOM").Value = flxPODetails.get_TextMatrix(i, 2)
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					RsAdd.Fields("AccountCode").Value = flxPODetails.get_TextMatrix(i, 3)
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					RsAdd.Fields("UnitPrice").Value = flxPODetails.get_TextMatrix(i, 4)
					RsAdd.Update() '
					If RsAdd.State Then RsAdd.Close()
				End If
			Next i
			MsgBox("Purchase Order Saved Successfully", MsgBoxStyle.Information, My.Application.Info.Title)
			'cmdReset_Click
		End If
Xit: 
		Err.Clear()
	End Sub
	Private Sub frmPOEntry_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		If Con.State Then Con.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Con.Open(ConnectString)
		Dim r As Short
		Dim C As Short
		Dim max_len As Single
		Dim new_len As Single
		dtpPODate.Value = VB6.Format(Today, "dd/mm/yyyy")
		' Use no border.
		txtEditFlexMatrix.BorderStyle = System.Windows.Forms.FormBorderStyle.None
		' Match the grid's font.
		txtEditFlexMatrix.Font = VB6.FontChangeName(txtEditFlexMatrix.Font, flxPODetails.Font.Name)
		txtEditFlexMatrix.Font = VB6.FontChangeSize(txtEditFlexMatrix.Font, flxPODetails.Font.SizeInPoints)
		txtEditFlexMatrix.Visible = False
		' Create some data.
		flxPODetails.FixedCols = 0
		flxPODetails.Cols = 6
		flxPODetails.FixedRows = 1
		flxPODetails.Rows = 10
		flxPODetails.set_TextMatrix(0, 0, "Item Description")
		flxPODetails.set_ColWidth(0, 3500)
		flxPODetails.set_TextMatrix(0, 1, "Quantity")
		flxPODetails.set_ColWidth(1, 1000)
		flxPODetails.set_TextMatrix(0, 2, "UOM")
		flxPODetails.set_ColWidth(2, 600)
		flxPODetails.set_TextMatrix(0, 3, "Account Code")
		flxPODetails.set_ColWidth(3, 1200)
		flxPODetails.set_TextMatrix(0, 4, "Unit Price")
		flxPODetails.set_ColWidth(4, 1300)
		flxPODetails.set_TextMatrix(0, 5, "Total")
		flxPODetails.set_ColWidth(4, 1300)
		LoadDeliveryPoints()
		LoadVendors()
		txtPONumber.Text = autogen("select PO_OrderNo from PO_header", "", Con)
	End Sub
	Private Sub GridEdit(ByRef KeyAscii As Short)
		' Position the TextBox over the cell.
		txtEditFlexMatrix.Left = VB6.TwipsToPixelsX(flxPODetails.CellLeft + VB6.PixelsToTwipsX(flxPODetails.Left))
		txtEditFlexMatrix.Top = VB6.TwipsToPixelsY(flxPODetails.CellTop + VB6.PixelsToTwipsY(flxPODetails.Top))
		txtEditFlexMatrix.Width = VB6.TwipsToPixelsX(flxPODetails.CellWidth)
		txtEditFlexMatrix.Height = VB6.TwipsToPixelsY(flxPODetails.CellHeight)
		txtEditFlexMatrix.Visible = True
		txtEditFlexMatrix.Focus()
		Select Case KeyAscii
			Case 0 To Asc(" ")
				txtEditFlexMatrix.Text = flxPODetails.Text
				txtEditFlexMatrix.SelectionStart = Len(txtEditFlexMatrix.Text)
			Case Else
				txtEditFlexMatrix.Text = Chr(KeyAscii)
				txtEditFlexMatrix.SelectionStart = 1
		End Select
	End Sub
	Private Sub txtEditFlexMatrix_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtEditFlexMatrix.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			Case System.Windows.Forms.Keys.Escape
				' Leave the text unchanged.
				txtEditFlexMatrix.Visible = False
				flxPODetails.Focus()
				
			Case System.Windows.Forms.Keys.Return
				' Finish editing.
				flxPODetails.Focus()
			Case System.Windows.Forms.Keys.Down
				' Move down 1 row.
				flxPODetails.Focus()
				System.Windows.Forms.Application.DoEvents()
				If flxPODetails.Row < flxPODetails.Rows - 1 Then
					flxPODetails.Row = flxPODetails.Row + 1
				End If
			Case System.Windows.Forms.Keys.Up
				' Move up 1 row.
				flxPODetails.Focus()
				System.Windows.Forms.Application.DoEvents()
				If flxPODetails.Row > flxPODetails.FixedRows Then
					flxPODetails.Row = flxPODetails.Row - 1
				End If
				If flxPODetails.Col = 4 And flxPODetails.get_TextMatrix(flxPODetails.Row, 1) <> "" Then flxPODetails.set_TextMatrix(flxPODetails.Row, 5, CDbl(flxPODetails.get_TextMatrix(flxPODetails.Row, 1)) * CDbl(flxPODetails.get_TextMatrix(flxPODetails.Row, 4)))
				
		End Select
	End Sub
	Private Function ComputeTotal() As Object
		dbltotal = 0
		For i = 1 To flxPODetails.Rows - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dbltotal = IIf(flxPODetails.get_TextMatrix(i, 5) = "", 0, flxPODetails.get_TextMatrix(i, 5)) + dbltotal
		Next i
		If dbltotal > 0 Then lblPOtotal.Text = "Total Value of Purchase Order = " & txtCurrency.Text & ". " & VB6.Format(dbltotal, "###,###,##0.00") Else lblPOtotal.Text = ""
	End Function
	' Do not beep on Return or Escape.
	Private Sub txtEditFlexMatrix_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtEditFlexMatrix.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii = System.Windows.Forms.Keys.Return) Or (KeyAscii = System.Windows.Forms.Keys.Escape) Then KeyAscii = 0
		Select Case flxPODetails.Col
			Case 0, 2, 3
				KeyAscii = TxtAcceptString((Me.txtEditFlexMatrix), KeyAscii)
			Case 1, 4
				KeyAscii = TxtAcceptMoney((Me.txtEditFlexMatrix), KeyAscii)
				If flxPODetails.Col = 4 And flxPODetails.get_TextMatrix(flxPODetails.Row, 1) <> "" And flxPODetails.get_TextMatrix(flxPODetails.Row, 4) <> "" Then
					flxPODetails.set_TextMatrix(flxPODetails.Row, 5, VB6.Format(CDbl(flxPODetails.get_TextMatrix(flxPODetails.Row, 1)) * CDbl(flxPODetails.get_TextMatrix(flxPODetails.Row, 4)), "###,###,##0.00"))
					ComputeTotal()
				Else
					flxPODetails.set_TextMatrix(flxPODetails.Row, 5, 0)
					ComputeTotal()
				End If
			Case Else
				KeyAscii = 0
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub flxPODetails_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxPODetails.DblClick
		GridEdit(Asc(" "))
	End Sub
	Private Sub flxPODetails_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_KeyPressEvent) Handles flxPODetails.KeyPressEvent
		GridEdit(eventArgs.KeyAscii)
	End Sub
	Private Sub flxPODetails_LeaveCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxPODetails.LeaveCell
		If txtEditFlexMatrix.Visible Then
			flxPODetails.Text = txtEditFlexMatrix.Text
			txtEditFlexMatrix.Visible = False
		End If
	End Sub
	Private Sub flxPODetails_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxPODetails.Enter
		If txtEditFlexMatrix.Visible Then
			flxPODetails.Text = txtEditFlexMatrix.Text
			txtEditFlexMatrix.Visible = False
		End If
	End Sub
End Class