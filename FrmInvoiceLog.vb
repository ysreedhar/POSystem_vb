Option Strict Off
Option Explicit On
Friend Class FrmInvoiceLog
	Inherits System.Windows.Forms.Form
	Const strChecked As String = "þ"
	Const strUnChecked As String = "q"
	Dim strInvoiceCurrency As String
	Dim rsLogInvoice As New ADODB.Recordset
	Dim Finaltotal As Double
	Dim con As New ADODB.Connection
	'UPGRADE_WARNING: Event cboPurchaseOrders.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	'UPGRADE_WARNING: ComboBox event cboPurchaseOrders.Change was upgraded to cboPurchaseOrders.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
	Private Sub cboPurchaseOrders_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPurchaseOrders.TextChanged
		LoadPurchaseOrderDetails()
	End Sub
	'UPGRADE_WARNING: Event cboPurchaseOrders.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboPurchaseOrders_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPurchaseOrders.SelectedIndexChanged
		LoadPurchaseOrderDetails()
	End Sub
	Private Sub cmdLogInvoice_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLogInvoice.Click
		Dim response As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object response. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		response = MsgBox("Are you sure you want Log this Invoice?", MsgBoxStyle.YesNo, My.Application.Info.Title)
		If response = MsgBoxResult.Yes Then
			If rsLogInvoice.State Then rsLogInvoice.Close()
			rsLogInvoice.Open("Select * from tblInvoices", con, 3, 2)
			rsLogInvoice.AddNew()
			rsLogInvoice.Fields("InvoiceNumber").Value = txtInvoiceNumber.Text
			rsLogInvoice.Fields("Invoice_Value").Value = Finaltotal
			rsLogInvoice.Fields("PO_Number").Value = cboPurchaseOrders.Text
			rsLogInvoice.Fields("InvoiceDate").Value = VB6.Format(dtpInvoiceDate.Value, "dd/MM/yyyy")
			rsLogInvoice.Fields("ReceiptDate").Value = VB6.Format(dtpReceiptDate.Value, "dd/MM/yyyy")
			rsLogInvoice.Update() '
			If rsLogInvoice.State Then rsLogInvoice.Close()
			MsgBox("Invoice Logged Successfully!", MsgBoxStyle.Information, My.Application.Info.Title)
			cmdReset_Click(cmdReset, New System.EventArgs())
		End If
	End Sub
	Private Sub cmdReset_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReset.Click
		flxPODetails.Rows = 1
		cboPurchaseOrders.Text = ""
		txtInvoiceNumber.Text = ""
		lblInvoiceValue.Text = ""
		dtpInvoiceDate.Value = Today
		dtpReceiptDate.Value = Today
	End Sub
	Private Sub FrmInvoiceLog_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		If con.State Then con.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		con.Open(ConnectString)
		dtpInvoiceDate.Value = Today
		dtpReceiptDate.Value = Today
		LoadPos()
		With flxPODetails
			.Row = 0 : .Col = 0
			.set_ColWidth(0, 100)
			.set_TextMatrix(0, 1, "Select")
			.set_ColWidth(1, 500)
			flxPODetails.set_TextMatrix(0, 2, "Item Description")
			flxPODetails.set_ColWidth(2, 3500)
			flxPODetails.set_TextMatrix(0, 3, "Req. Quantity")
			flxPODetails.set_ColWidth(3, 1000)
			flxPODetails.set_TextMatrix(0, 4, "UOM")
			flxPODetails.set_ColWidth(4, 600)
			flxPODetails.set_TextMatrix(0, 5, "Unit Price")
			flxPODetails.set_ColWidth(5, 1300)
			flxPODetails.set_TextMatrix(0, 6, "Inv. Quantity")
			flxPODetails.set_ColWidth(6, 1300)
		End With
	End Sub
	Private Sub LoadPos()
		Dim rsPos As New ADODB.Recordset
		Dim strCommand As String
		cboPurchaseOrders.Items.Clear()
		strCommand = "Select distinct(PO_OrderNo) from PO_header where status = 1 order by po_OrderNo asc"
		If rsPos.State Then rsPos.Close()
		rsPos.Open(strCommand, con, 3, 2)
		While Not rsPos.EOF
			cboPurchaseOrders.Items.Add(rsPos.Fields(0).Value)
			rsPos.MoveNext()
		End While
	End Sub
	Private Sub LoadPurchaseOrderDetails()
		Dim Y As Object
		Dim rowtotal As Object
		flxPODetails.Rows = 1
		Dim fldata3 As New ADODB.Recordset
		If fldata3.State Then fldata3.Close()
		fldata3.Open("select * from PO_Details where POID in (select POID from PO_header where PO_OrderNo = '" & cboPurchaseOrders.Text & "')", con, 3, 2)
		With flxPODetails
			.Rows = 1
			While Not fldata3.EOF
				.Rows = .Rows + 1
				.set_TextMatrix(.Rows - 1, 0, .get_RowPos(.Rows - 1))
				.set_TextMatrix(.Rows - 1, 2, fldata3.Fields("ItemDescription").Value)
				.set_TextMatrix(.Rows - 1, 3, fldata3.Fields("quantity").Value)
				.set_TextMatrix(.Rows - 1, 4, fldata3.Fields("UOM").Value)
				.set_TextMatrix(.Rows - 1, 5, fldata3.Fields("UnitPrice").Value)
				.set_TextMatrix(.Rows - 1, 6, fldata3.Fields("quantity").Value)
				'UPGRADE_WARNING: Couldn't resolve default property of object rowtotal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				rowtotal = fldata3.Fields("quantity").Value * fldata3.Fields("UnitPrice").Value + rowtotal
				fldata3.MoveNext()
				'define fields as checkbox
				For Y = 1 To .Rows - 1
					'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					.Row = Y
					.Col = 1
					.CellFontName = "Wingdings"
					.CellFontSize = 14
					.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
					.Text = strChecked
				Next Y
			End While
		End With
		
		If fldata3.State Then fldata3.Close()
		fldata3.Open("select vendorName, Currency from PO_header where PO_OrderNo = '" & cboPurchaseOrders.Text & "'", con, 3, 2)
		If Not fldata3.EOF Then
			lblVendorName.Text = fldata3.Fields(0).Value
			strInvoiceCurrency = fldata3.Fields(1).Value
			If fldata3.State Then fldata3.Close()
			ComputeTotal()
		End If
	End Sub
	
	Private Sub txtEditFlexMatrix_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtEditFlexMatrix.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If flxPODetails.Col < 6 Then Exit Sub
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
				
		End Select
	End Sub
	' Do not beep on Return or Escape.
	Private Sub txtEditFlexMatrix_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtEditFlexMatrix.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii = System.Windows.Forms.Keys.Return) Or (KeyAscii = System.Windows.Forms.Keys.Escape) Then KeyAscii = 0
		Select Case flxPODetails.Col
			Case 6
				KeyAscii = TxtAcceptMoney((Me.txtEditFlexMatrix), KeyAscii)
				'          If flxPODetails.Col = 6 And flxPODetails.TextMatrix(flxPODetails.Row, 1) <> "" And flxPODetails.TextMatrix(flxPODetails.Row, 4) <> "" Then flxPODetails.TextMatrix(flxPODetails.Row, 5) = Format(flxPODetails.TextMatrix(flxPODetails.Row, 1) * flxPODetails.TextMatrix(flxPODetails.Row, 4), "###,###,##0.00") Else flxPODetails.TextMatrix(flxPODetails.Row, 5) = 0
				ComputeTotal()
			Case Else
				KeyAscii = 0
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Function ComputeTotal() As Object
		Dim i As Object
		Dim dbltotal As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object dbltotal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dbltotal = 0
		For i = 1 To flxPODetails.Rows - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object dbltotal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dbltotal = IIf(flxPODetails.get_TextMatrix(i, 6) = "", 0, (CDbl(flxPODetails.get_TextMatrix(i, 5)) * CDbl(flxPODetails.get_TextMatrix(i, 6)))) + dbltotal
		Next i
		'UPGRADE_WARNING: Couldn't resolve default property of object dbltotal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If dbltotal > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object dbltotal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblInvoiceValue.Text = "Total Value of Invoice = " & strInvoiceCurrency & ". " & VB6.Format(dbltotal, "###,###,##0.00")
			'UPGRADE_WARNING: Couldn't resolve default property of object dbltotal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Finaltotal = dbltotal
		Else
			lblInvoiceValue.Text = ""
			Finaltotal = 0
		End If
	End Function
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
End Class