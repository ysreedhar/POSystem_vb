Option Strict Off
Option Explicit On
Friend Class frmPrintPO
	Inherits System.Windows.Forms.Form
	Dim CON As New ADODB.Connection
	Private Declare Function ShellExecute Lib "shell32.dll"  Alias "ShellExecuteA"(ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	Dim i As Short
	Dim ReportTotal As Double
	
	Private Sub cmdExit_Click()
		Me.Close() 'SafeExit
	End Sub
	
	'UPGRADE_WARNING: Event chkShowPrinted.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkShowPrinted_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkShowPrinted.CheckStateChanged
		If chkShowPrinted.CheckState Then LoadPos(True)
	End Sub
	
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
		GetShapedRS(CDbl(cboPurchaseOrders.Text), False)
		'rptResults.PrintReport True
		'rptResults.Hide
	End Sub
	
	Private Sub frmPrintPO_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		If CON.State Then CON.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CON.Open(ConnectString)
		LoadPos(False)
	End Sub
	
	Private Sub frmPrintPO_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_NOTE: Object frmPOreport may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		frmPOreport = Nothing
	End Sub
	Private Sub LoadPos(ByRef boolShowPrinted As Boolean)
		Dim rsPos As New ADODB.Recordset
		Dim strCommand As String
		cboPurchaseOrders.Items.Clear()
		If boolShowPrinted = True Then
			strCommand = "Select distinct(PO_OrderNo) from PO_header where status in (1,2) order by PO_orderNo"
		Else
			strCommand = "Select distinct(PO_OrderNo) from PO_header where status = 1 order by po_OrderNo asc"
		End If
		If rsPos.State Then rsPos.Close()
		rsPos.Open(strCommand, CON, 3, 2)
		While Not rsPos.EOF
			cboPurchaseOrders.Items.Add(rsPos.Fields(0).Value)
			rsPos.MoveNext()
		End While
	End Sub
	
	Public Function GetShapedRS(ByRef dblPOnumber As Double, ByRef boolPrintPONumber As Boolean) As Object
		Dim rptResults As Object
		
		'Instantiate the Recordset Object
		Dim RS As ADODB.Recordset
		RS = New ADODB.Recordset
		
		'Build the Connection String
		'Dim strConnect As String
		'strConnect = "Data Provider=Microsoft.Jet.OLEDB.4.0; " & _
		''             "Provider=MSDataShape;Data Source=" & vPubConnectString & ";"
		
		'Build the SQL String for a Shaped recordset
		Dim strSQL As String
		
		strSQL = "select * from vHeader join po_details on vHeader.poid = po_details.poid"
		i = 0
		With RS
			.let_ActiveConnection(CON)
			.Open(strSQL, CON, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
			
			'Display a populated data report
			'UPGRADE_WARNING: Couldn't resolve default property of object rptResults.DataSource. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rptResults.DataSource = RS
			'Display or Hide the PO Number
			
			'UPGRADE_WARNING: Couldn't resolve default property of object rptResults.Sections. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If boolPrintPONumber = True Then rptResults.Sections.Item("GroupHeader").Controls.Item("txtPONumber").Visible = True
			'UPGRADE_WARNING: Couldn't resolve default property of object rptResults.Sections. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rptResults.Sections.Item("GroupFooter").Controls.Item("lblTotal").Caption = RS.Fields("Currency").Value & ". " & VB6.Format(RS.Fields("GrandTotal").Value, "###,###,##0.00")
			'UPGRADE_WARNING: Couldn't resolve default property of object rptResults.Sections. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rptResults.Sections.Item("GroupFooter").Controls.Item("lblAmountinwords").Caption = "Amount in Words : " & RS.Fields("Currency").Value & ". " & NumToWords(CDbl(RS.Fields("Grandtotal").Value)) & " Only"
			
			'Display the report
			'UPGRADE_WARNING: Couldn't resolve default property of object rptResults.Show. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rptResults.Show(VB6.FormShowConstants.Modal, Me)
			
			.Close()
		End With
		
		'Cleanup
		'UPGRADE_NOTE: Object RS may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		RS = Nothing
		
	End Function
	
	'Private Sub PrintTbl(RS, indent)
	'
	'Dim s As String
	'Dim col As Field
	'Dim rsChild As Recordset
	'
	' ' This routine distinguishes between columns in the recordset with
	' ' data, i.e. type <> adChapter, and those which contain a child
	' ' recordset, for example, type = adChapter.
	'  Do While Not RS.EOF
	'
	'   s = Space(indent)
	'   For Each col In RS.Fields
	'     If col.Type <> adChapter Then
	'       If Len(s) > indent Then s = s & " | "
	'       s = s & col.Value
	'     Else
	'       ' Display data columns encountered so far (if any).
	'       If Len(s) > indent Then Debug.Print Space(indent) & s
	'       ' Recursively call printtbl to display child recordset.
	'       Set rsChild = col.Value
	'       PrintTbl rsChild, indent + 4
	'       ' Reset in case there are further data columns.
	'       s = Space(indent)
	'     End If
	'   Next
	'
	'   ' In case we have any data columns that have not been
	'   ' displayed yet.
	'   If Len(s) > indent Then Debug.Print s
	'
	'   RS.MoveNext
	' Loop
	'
	'End Sub
End Class