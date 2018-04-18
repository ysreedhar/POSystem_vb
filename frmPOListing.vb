Option Strict Off
Option Explicit On
Friend Class frmPOListing
	Inherits System.Windows.Forms.Form
	Dim con As New ADODB.Connection
	Function RepaintFlexGrid() As Object
		Dim flxcls As Object
		Dim ch As Object
		' Reset the backcolor
		For ch = 1 To flxPurchaseOrders.Rows - 1
			For flxcls = 0 To flxPurchaseOrders.Cols - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object ch. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				flxPurchaseOrders.Row = ch
				'UPGRADE_WARNING: Couldn't resolve default property of object flxcls. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				flxPurchaseOrders.Col = flxcls
				If flxPurchaseOrders.CellBackColor.equals(System.Drawing.Color.Yellow) Then flxPurchaseOrders.CellBackColor = System.Drawing.Color.White
			Next flxcls
			
		Next ch
	End Function
	
	'UPGRADE_WARNING: Event chkShowCancelled.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkShowCancelled_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkShowCancelled.CheckStateChanged
		If chkShowCancelled.CheckState Then
			LoadPurchaseOrders((True))
		End If
	End Sub
	
	
	Private Sub flxPurchaseOrders_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxPurchaseOrders.ClickEvent
		Dim vprev As Object
		Dim i As Object
		Dim current As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object current. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		current = flxPurchaseOrders.Row
		RepaintFlexGrid()
		'Current  row
		'UPGRADE_WARNING: Couldn't resolve default property of object current. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		flxPurchaseOrders.Row = current
		For i = 1 To flxPurchaseOrders.Cols - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			flxPurchaseOrders.Col = i
			flxPurchaseOrders.CellBackColor = System.Drawing.Color.Yellow
		Next 
		LoadPurchaseOrderDetails()
		'UPGRADE_WARNING: Couldn't resolve default property of object vprev. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vprev = flxPurchaseOrders.Row
		flxPurchaseOrders.Col = 1
	End Sub
	
	Private Sub frmPOListing_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		If con.State Then con.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		con.Open(ConnectString)
		LoadFlexTitles()
		LoadPurchaseOrders((False))
	End Sub
	Private Sub LoadFlexTitles()
		On Error Resume Next
		With flxPurchaseOrders
			.Row = 0 : .Col = 0
			.set_ColWidth(0, 400)
			.set_TextMatrix(0, 0, "POID")
			.set_ColWidth(1, 500)
			.set_TextMatrix(0, 1, "VendorName")
			.set_ColWidth(2, 3000)
			.set_TextMatrix(0, 2, "VendorAddress")
			.set_ColWidth(3, 3300)
			.set_ColAlignment(2, 0)
			.set_TextMatrix(0, 3, "Order #")
			.set_ColWidth(3, 1100)
			.set_ColAlignment(3, 0)
			.set_TextMatrix(0, 4, "Date")
			.set_ColWidth(5, 1600)
			.set_ColAlignment(4, 0)
			.set_TextMatrix(0, 5, "Req. Order#")
			.set_ColWidth(5, 1000)
			.set_ColAlignment(5, 0)
			.set_TextMatrix(0, 6, "Cost Center")
			.set_ColWidth(7, 1000)
			.set_TextMatrix(0, 7, "Ordered by")
			.set_ColWidth(7, 2000)
			.set_TextMatrix(0, 8, "Approved by")
			.set_ColWidth(8, 2000)
			.set_TextMatrix(0, 9, "Remarks")
			.set_ColWidth(9, 2650)
			.set_TextMatrix(0, 10, "Del. Terms")
			.set_ColWidth(11, 1000)
			.set_TextMatrix(0, 11, "Currency")
			.set_ColWidth(11, 600)
			.set_TextMatrix(0, 12, "Status")
			.set_ColWidth(12, 600)
		End With
		
		With flxPODetails
			.Row = 0 : .Col = 0
			.set_ColWidth(0, 100)
			flxPODetails.set_TextMatrix(0, 1, "Item Description")
			flxPODetails.set_ColWidth(1, 3500)
			flxPODetails.set_TextMatrix(0, 2, "Quantity")
			flxPODetails.set_ColWidth(2, 1000)
			flxPODetails.set_TextMatrix(0, 3, "UOM")
			flxPODetails.set_ColWidth(3, 600)
			flxPODetails.set_TextMatrix(0, 4, "Account Code")
			flxPODetails.set_ColWidth(4, 1200)
			flxPODetails.set_TextMatrix(0, 5, "Unit Price")
			flxPODetails.set_ColWidth(5, 1300)
			flxPODetails.set_TextMatrix(0, 6, "Total")
			flxPODetails.set_ColWidth(6, 1300)
		End With
	End Sub
	
	Private Sub LoadPurchaseOrders(ByRef boolShowCancelled As Boolean)
		Dim fldata3 As New ADODB.Recordset
		If fldata3.State Then fldata3.Close()
		If boolShowCancelled = True Then
			fldata3.Open("select * from PO_header", con, 3, 2)
		Else
			fldata3.Open("select * from PO_header where status <> 6", con, 3, 2)
		End If
		With flxPurchaseOrders
			.Rows = 1
			While Not fldata3.EOF
				.Rows = .Rows + 1
				.set_TextMatrix(.Rows - 1, 0, fldata3.Fields("POID").Value)
				.set_TextMatrix(.Rows - 1, 1, fldata3.Fields("VendorName").Value)
				.set_TextMatrix(.Rows - 1, 2, Replace(fldata3.Fields("VendorAddress").Value, vbNewLine, ""))
				.set_TextMatrix(.Rows - 1, 3, fldata3.Fields("PO_OrderNo").Value)
				.set_TextMatrix(.Rows - 1, 4, fldata3.Fields("PO_Date").Value)
				.set_TextMatrix(.Rows - 1, 5, fldata3.Fields("Requisition_OrderNo").Value)
				.set_TextMatrix(.Rows - 1, 6, fldata3.Fields("CostCenter").Value)
				.set_TextMatrix(.Rows - 1, 7, fldata3.Fields("Orderedby").Value)
				.set_TextMatrix(.Rows - 1, 8, fldata3.Fields("Approvedby").Value)
				.set_TextMatrix(.Rows - 1, 9, fldata3.Fields("Remarks").Value)
				.set_TextMatrix(.Rows - 1, 10, fldata3.Fields("DeliveryTerms").Value)
				.set_TextMatrix(.Rows - 1, 11, fldata3.Fields("Currency").Value)
				.set_TextMatrix(.Rows - 1, 12, fldata3.Fields("Status").Value)
				fldata3.MoveNext()
			End While
		End With
		If fldata3.State Then fldata3.Close()
	End Sub
	
	Private Sub LoadPurchaseOrderDetails()
		Dim dbltotal As Object
		Dim fldata3 As New ADODB.Recordset
		If fldata3.State Then fldata3.Close()
		Dim intPOID As Short
		If flxPurchaseOrders.Row > 0 Then intPOID = CShort(flxPurchaseOrders.get_TextMatrix(flxPurchaseOrders.Row, 0))
		fldata3.Open("select * from PO_Details where POID =" & intPOID, con, 3, 2)
		With flxPODetails
			.Rows = 1
			While Not fldata3.EOF
				.Rows = .Rows + 1
				.set_TextMatrix(.Rows - 1, 0, .get_RowPos(.Rows - 1))
				.set_TextMatrix(.Rows - 1, 1, fldata3.Fields("ItemDescription").Value)
				.set_TextMatrix(.Rows - 1, 2, fldata3.Fields("quantity").Value)
				.set_TextMatrix(.Rows - 1, 3, fldata3.Fields("UOM").Value)
				.set_TextMatrix(.Rows - 1, 4, fldata3.Fields("AccountCode").Value)
				.set_TextMatrix(.Rows - 1, 5, fldata3.Fields("UnitPrice").Value)
				.set_TextMatrix(.Rows - 1, 6, fldata3.Fields("quantity").Value * fldata3.Fields("UnitPrice").Value)
				'UPGRADE_WARNING: Couldn't resolve default property of object dbltotal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				dbltotal = fldata3.Fields("quantity").Value * fldata3.Fields("UnitPrice").Value + dbltotal
				fldata3.MoveNext()
			End While
		End With
		If fldata3.State Then fldata3.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object dbltotal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If dbltotal > 0 Then lblPOtotal.Text = "Total Value of Purchase Order = " & flxPurchaseOrders.get_TextMatrix(flxPurchaseOrders.Row, 11) & "." & VB6.Format(dbltotal, "###,###,##0.00") Else lblPOtotal.Text = ""
	End Sub
End Class