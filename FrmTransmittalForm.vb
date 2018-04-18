Option Strict Off
Option Explicit On
Friend Class FrmTransmittalForm
	Inherits System.Windows.Forms.Form
	Dim intTransmittalNumber As Short
	Dim CON As New ADODB.Connection
	
	Private Function GenerateTransmittalNumber() As Object
		intTransmittalNumber = 1
		Dim rsTNumber As New ADODB.Recordset
		rsTNumber.Open("select max(TransmittalNumber) from tblInvoices", CON, 3, 2)
		If Not rsTNumber.EOF Then
			intTransmittalNumber = rsTNumber.Fields(0).Value + 1
		Else
			intTransmittalNumber = 1
		End If
		If rsTNumber.State Then rsTNumber.Close()
	End Function
	Private Sub cmdView_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdView.Click
		Dim InvSelection As Object
		Dim Sno As Object
		If Trim(txtTransmitToName.Text) = "" Then
			MsgBox("Please Enter Name of the Receiver", MsgBoxStyle.Information, My.Application.Info.Title)
			Exit Sub
		End If
		If Trim(txtTransmitToDept.Text) = "" Then
			MsgBox("Please Enter Department of the Receiver", MsgBoxStyle.Information, My.Application.Info.Title)
			Exit Sub
		End If
		If lstInvoiceNos.CheckedIndices.Count = 0 Then
			MsgBox("Please Choose the Invoices to be Transmitted", MsgBoxStyle.Information, My.Application.Info.Title)
			Exit Sub
		End If
		Dim fso As Object
		Dim WriteObj As Object
		fso = CreateObject("Scripting.FileSystemObject")
		'UPGRADE_WARNING: Couldn't resolve default property of object fso.CreateTextFile. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj = fso.CreateTextFile(My.Application.Info.DirectoryPath & "\report.html", True)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine(" <html>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine(" <head>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine(" <Style>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("    .BODY {FONT-FAMILY: Tahoma; FONT-SIZE: 8pt;}")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("    .TableFont")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("    {")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("        COLOR: Black;")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("        FONT-FAMILY: Tahoma;")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("        FONT-SIZE: 8pt;")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("        TEXT-TRANSFORM: capitalize;")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("    }")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("    .TrFont")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("    {")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("        COLOR: black;")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("        FONT-FAMILY: Tahoma;")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("        FONT-SIZE: 8pt;")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("        TEXT-TRANSFORM: capitalize;")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("        CURSOR:HAND;")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("   }")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("</style></head>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine(" <body class=TableFont>")
		Dim RS As New ADODB.Recordset
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine(" <table border=0 cellspacing=1 cellpadding=2 BORDERCOLOR=GRAY width=95%>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("  <tr bgcolor=white  height=15>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("   <td  colspan=2 align=center valign=top >")
		RS.Open("select * from company ", CON, 1, 1)
		If Not RS.EOF Then
			'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WriteObj.WriteLine("<FONT size=4> " & RS.Fields("CompanyName").Value & "</font><FONT size=2> - [" & RS.Fields("regno").Value & "] </FONT>")
			'WriteObj.WriteLine "<tr><TD  align=center><FONT size=2> " & rs!regno & "," & rs!Address & " </FONT></TD></tr>"
			'WriteObj.WriteLine "<tr><td Width=100% align=center><font size=2.5>Phone: " & rs!phone & "</font><font size=2.5>  Fax: " & rs!fax & "</font><font size=2.5> E-mail: " & rs!email & "</td></tr>"
		End If
		If RS.State Then RS.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("   </td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("  </tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("  <tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("   <td align=center colspan=2>Vendor Invoice  Transmittal Form")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("   </td> </tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("   <tr><td colspan=2><hr></td></tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine(" <tr><td>To: </br>" & UCase(txtTransmitToName.Text) & " </br> " & UCase(txtTransmitToDept.Text) & "</td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("   <td valign='top'>   Transmittal No.:" & VB6.Format(intTransmittalNumber, "0000000") & "   </td></tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object pubUserDept. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object pubUserName. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine(" <tr><td valign=top>From:</br>" & UCase(pubUserName) & " </br>" & UCase(pubUserDept) & " </td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("   <td  valign=top>Date: " & VB6.Format(Today, "dd/MM/yyyy") & " </td></tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("   <tr><td colspan=2><hr></td></tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("  <tr>  <td colspan=2 valign=top >Please receive the following Vendor Invoices:</br></td></tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("  <tr><td  colspan=2 valign=top>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("   <table border=1 cellspacing=1 cellpadding=2>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("    <tr><td align='center' nowrap >Sno.</td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("     <td align='center' nowrap>Vendor</td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("     <td align='center' nowrap>Invoice No.</td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("    <td width=100 align='center' nowrap>Value</td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine(" <td align='center' nowrap>Currency</td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("     <td align='center' nowrap >Inv. Date</td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("     <td align='center' nowrap>Receipt Date</td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("    <td align='center' nowrap >PO / SO #</td></tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object Sno. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sno = 1
		Dim l As Short
		l = 0
		GenerateTransmittalNumber()
		For l = 0 To lstInvoiceNos.Items.Count - 1
			If lstInvoiceNos.GetItemChecked(l) = True Then
				'UPGRADE_WARNING: Couldn't resolve default property of object InvSelection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				InvSelection = Split(VB6.GetItemString(lstInvoiceNos, l), " - ", Len(VB6.GetItemString(lstInvoiceNos, l)), CompareMethod.Text)
				If RS.State Then RS.Close()
				'UPGRADE_WARNING: Couldn't resolve default property of object InvSelection(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				RS.Open("select * from vInvoiceVendorValue where invoiceNumber = '" & InvSelection(0) & "'", CON, 1, 1)
				While Not RS.EOF
					'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					WriteObj.WriteLine("    <tr class='trfont'><td>")
					'UPGRADE_WARNING: Couldn't resolve default property of object Sno. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					WriteObj.WriteLine("     " & Sno & "</td>")
					'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					WriteObj.WriteLine("     <td nowrap>" & RS.Fields("vendorName").Value & "</td>")
					'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					WriteObj.WriteLine("     <td>" & RS.Fields("InvoiceNumber").Value & "</td>")
					'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					WriteObj.WriteLine("    <td align = 'right'>" & VB6.Format(RS.Fields("Invoice_Value").Value, "###,###,##0.00") & "</td>")
					'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					WriteObj.WriteLine(" <td>" & RS.Fields("Currency").Value & "</td>")
					'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					WriteObj.WriteLine("     <td>" & VB6.Format(RS.Fields("InvoiceDate").Value, "dd/MM/yyyy") & "</td>")
					'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					WriteObj.WriteLine("     <td>" & VB6.Format(RS.Fields("ReceiptDate").Value, "dd/MM/yyyy") & "</td>")
					'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					WriteObj.WriteLine("    <td valign=top>" & RS.Fields("PO_oRDERNO").Value & "</td></tr>")
					'UPGRADE_WARNING: Couldn't resolve default property of object Sno. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sno = Sno + 1
					RS.MoveNext()
				End While
				RS.Close()
			End If
		Next l
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("     </table>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("     </td> </tr> ")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("   <tr><td colspan=2><hr></td></tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("    <tr><td>Received By:</br>NAME:</br>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("  DEPARTMENT:</td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("  <td>Signature:</td></tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine(" <tr><td colspan=2>Received Date:</td></tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("</table>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("</body>")
		'UPGRADE_WARNING: Couldn't resolve default property of object WriteObj.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteObj.WriteLine("</html>")
		
		rptViewer.Navigate(New System.URI(My.Application.Info.DirectoryPath & "\report.html"))
	End Sub
	
	Private Sub cmdPreview_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPreview.Click
		'On Error GoTo Xit
		'UPGRADE_ISSUE: Constant OLECMDEXECOPT_PROMPTUSER was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Constant OLECMDID_PRINTPREVIEW was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: SHDocVw.WebBrowser method rptViewer.ExecWB was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'rptViewer.ExecWB(OLECMDID_PRINTPREVIEW, OLECMDEXECOPT_PROMPTUSER)
Xit: 
	End Sub
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
		Dim InvSelection As Object
		Dim l As Object
		'On Error GoTo Xit
		'UPGRADE_ISSUE: Constant OLECMDEXECOPT_DODEFAULT was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: SHDocVw.WebBrowser method rptViewer.ExecWB was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'rptViewer.ExecWB(6, OLECMDEXECOPT_DODEFAULT)
		'rptViewer.ExecWB OLECMDID_PRINT
		' Dim eQuery As OLECMDF       'return value type for QueryStatusWB
		'        On Error Resume Next
		'            eQuery = rptViewer.QueryStatusWB(OLECMDID_PRINT)  'get print command status
		'            If Err.Number = 0 Then
		'                    If eQuery And OLECMDF_ENABLED Then
		'                        rptViewer.ExecWB OLECMDID_PRINT, OLECMDEXECOPT_PROMPTUSER, "", ""    'Ok to Print?
		'                    Else
		'                        MsgBox "The Print command is currently disabled."
		'                    End If
		'            End If
		'            If Err.Number <> 0 Then MsgBox "Print command Error: " & Err.Description
		For l = 0 To lstInvoiceNos.Items.Count - 1
			If lstInvoiceNos.GetItemChecked(l) = True Then
				'UPGRADE_WARNING: Couldn't resolve default property of object InvSelection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				InvSelection = Split(VB6.GetItemString(lstInvoiceNos, l), " - ", Len(VB6.GetItemString(lstInvoiceNos, l)), CompareMethod.Text)
				'UPGRADE_WARNING: Couldn't resolve default property of object InvSelection(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cn.Execute("update tblinvoices set transmittalnumber = " & intTransmittalNumber & "  where invoiceNumber = '" & InvSelection(0) & "'")
			End If
		Next l
		txtTransmitToName.Text = ""
		txtTransmitToDept.Text = ""
Xit: 
	End Sub
	Private Sub cmdPageSetup_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPageSetup.Click
		'On Error GoTo Xit
		'UPGRADE_ISSUE: SHDocVw.WebBrowser method rptViewer.ExecWB was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'rptViewer.ExecWB(8, 0)
Xit: 
	End Sub
	
	
	Private Sub FrmTransmittalForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		If CON.State Then CON.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CON.Open(ConnectString)
		rptViewer.Navigate(New System.URI("about:blank"))
		LoadInvoices()
	End Sub
	
	Private Function LoadInvoices() As Object
		Dim rsInvoices As New ADODB.Recordset
		If rsInvoices.State Then RS.Close()
		rsInvoices.Open("Select ExprConcat from vInvoiceVendorValue where TransmittalNumber = 0", CON, 3, 2)
		While Not rsInvoices.EOF
			lstInvoiceNos.Items.Add(rsInvoices.Fields(0).Value)
			rsInvoices.MoveNext()
		End While
		If rsInvoices.State Then rsInvoices.Close()
	End Function
End Class