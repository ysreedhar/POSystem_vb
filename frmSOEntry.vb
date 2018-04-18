Option Strict Off
Option Explicit On
Friend Class frmSOEntry
	Inherits System.Windows.Forms.Form
	Dim Bookmark As Double
	Dim addflag As String
	Dim i As Short
	Dim rsVendors As New ADODB.Recordset
	Dim rsDeliveryPoints As New ADODB.Recordset
	Dim dbltotal As Double
	Dim verify As Boolean
	Private Sub LoadVendors()
		cboVendorName.Items.Clear()
		If rsVendors.State Then RS.Close()
		rsVendors.Open("Select v_name from Vendor order by v_name", con, 3, 2)
		While Not rsVendors.EOF
			cboVendorName.Items.Add(rsVendors.Fields(0).Value)
			rsVendors.MoveNext()
		End While
		If rsVendors.State Then rsVendors.Close()
	End Sub
	Private Sub LoadDeliveryPoints()
		cboDeliveryPoint.Items.Clear()
		If rsDeliveryPoints.State Then RS.Close()
		rsDeliveryPoints.Open("Select DeliveryPointName from DeliveryPoints ", con, 3, 2)
		While Not rsDeliveryPoints.EOF
			cboDeliveryPoint.Items.Add(rsDeliveryPoints.Fields(0).Value)
			rsDeliveryPoints.MoveNext()
		End While
		If rsDeliveryPoints.State Then rsDeliveryPoints.Close()
	End Sub
	Function GetVendorAddress() As Object
		If Len(cboVendorName.Text) > 0 Then
			If rsVendors.State Then RS.Close()
			rsVendors.Open("Select v_address,v_phone,v_fax,v_contactperson   from Vendor where v_name = '" & cboVendorName.Text & "'", con, 3, 2)
			If Not rsVendors.EOF Then
				txtAddress.Text = rsVendors.Fields(0).Value & vbNewLine & "TEL.:" & rsVendors.Fields(1).Value & vbNewLine & "FAX:" & rsVendors.Fields(2).Value & vbNewLine & "ATTN:" & rsVendors.Fields(3).Value
			End If
		End If
		If rsVendors.State Then rsVendors.Close()
	End Function
	Function GetDeliveryPointInfo() As Object
		If Len(cboDeliveryPoint.Text) > 0 Then
			If rsDeliveryPoints.State Then RS.Close()
			rsDeliveryPoints.Open("Select DeliveryPointAddress  from DeliveryPoints where DeliveryPointName = '" & cboDeliveryPoint.Text & "'", con, 3, 2)
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
		Else
			ex_validate_fields = True
		End If
	End Function
	
	Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
		Dim alert As String
		alert = CStr(MsgBox("Do you want to Save this Service Order?", MsgBoxStyle.OKCancel))
		Dim RsAdd As New ADODB.Recordset
		If alert = CStr(MsgBoxResult.OK) Then
			If RsAdd.State Then RsAdd.Close()
			RsAdd.Open("Select * from SO_Details", con, 3, 2)
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
			RsAdd.Update()
			If RsAdd.State Then RsAdd.Close()
		End If
		Exit Sub
Xit: 
		Err.Clear()
	End Sub
	
	Private Sub frmSOEntry_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		dtpPODate.Value = VB6.Format(Today, "dd/mm/yyyy")
		LoadDeliveryPoints()
		LoadVendors()
	End Sub
End Class