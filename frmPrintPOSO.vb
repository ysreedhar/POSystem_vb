Option Strict Off
Option Explicit On
Friend Class frmPrintPOSO
	Inherits System.Windows.Forms.Form
	Dim fso As New Scripting.FileSystemObject
	Dim rsPoHeader As New ADODB.Recordset
	Dim rsPodetails As New ADODB.Recordset
	
	Public Sub PrintPOSO(ByRef boolSaveAsExcel As Boolean)
		Dim WebBrowser As Object
		Dim rowsHeight As Object
		Dim Sno As Object
		Dim GrandTotal As Object
		Dim filpat As Object
		Dim fs As Object
		'On Error Resume Next
		If boolSaveAsExcel = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object filpat. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs = fso.CreateTextFile("C:\PCIS-Reports\" & filpat, True)
		Else
			fs = fso.CreateTextFile(My.Application.Info.DirectoryPath & "\rep.html")
		End If
		If IsNumeric(cboPurchaseOrders.Text) = False Then Exit Sub
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine(" <html> ")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine(" <head>")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("<LINK href='POS.css' rel='stylesheet' type='text/css' media='screen' >")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("<LINK href='POS_Print.css' rel='stylesheet' type='text/css' media='print' >")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine(" </head>")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("<body scroll=auto>")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("<table border='0' width='100%' class='CompanyLogoAddress' >")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("<tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("<td width='80%'>&nbsp;</td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("<td style='text-align: right'>")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("<img src='Images/logo.png' /></td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("</tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("<tr><td colspan=2 height='30px'>&nbsp;</td>")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("</tr>")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("</table>")
		If rsPoHeader.State Then rsPoHeader.Close()
		rsPoHeader.Open("Select * from Po_header where Po_OrderNo = '" & cboPurchaseOrders.Text & "'", Con, 3, 2)
		If Not rsPoHeader.EOF Then
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <table border='0' width='100%' cellpadding='0' class='PoHeader' cellspacing='0'>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td colspan=4 width='95%' class='PONumber' nowrap >Purchase Order No: SO-02105</b></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td class='PoHeader'>PO Date:</b></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td>" & VB6.Format(rsPoHeader.Fields("PO_Date").Value, "dd-MMM-yyyy") & "</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object vPubAddress. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td rowspan='11' valign='top' align='right' >&nbsp;<div id='CompanyAddress'>" & Replace(vPubAddress, vbNewLine, "<br>"))
			'UPGRADE_WARNING: Couldn't resolve default property of object vPubPhone. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("tel:" & vPubPhone & "<br/>")
			'UPGRADE_WARNING: Couldn't resolve default property of object vPubFax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("fax:" & vPubFax & "<br/>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("website: http://www.crest.com.my</div></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td><b>To:</b></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td>" & rsPoHeader.Fields("VendorName").Value & "<br/>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(Replace(rsPoHeader.Fields("VendorAddress").Value, vbNewLine, "<br>") & "</td></tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr><td><b>Attn:</b></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td>" & rsPoHeader.Fields("CnctPerson").Value & "</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td> </td></tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td><b>Vendor 's Ref:</b></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td>" & rsPoHeader.Fields("VendorRef").Value & "</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td  ></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td><b>Project:</b></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td>" & rsPoHeader.Fields("Project").Value & "</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td><b>Vessel:</b></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td>" & rsPoHeader.Fields("VesselName").Value & "</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td><b>End-user:</b></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td >" & rsPoHeader.Fields("EndUser").Value & "</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td><b> Buyer:</b></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td>" & rsPoHeader.Fields("Buyer").Value & "</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td><b> Charge Code:</b></td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td>" & rsPoHeader.Fields("ChargeType").Value & "</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td>&nbsp;</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <table border='0' width='100%' height='500px' cellpadding='0' class='PoHeader' cellspacing='0'>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<tr height='20px' class='ItemList'>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<th>Item No</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<th>MSR No</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<th>Description</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<th>Qty</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<th>UOM</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<th>Unit Price" & "(" & rsPoHeader.Fields("Currency").Value & ")" & "</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<th>Total Price " & "(" & rsPoHeader.Fields("Currency").Value & ")" & "</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("</th>")
			'Po details
			'UPGRADE_WARNING: Couldn't resolve default property of object GrandTotal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GrandTotal = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object Sno. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sno = 1
			If rsPodetails.State Then rsPodetails.Close()
			rsPodetails.Open("Select * from Po_Details Where poid in (select Poid from Po_header where Po_OrderNo = '" & cboPurchaseOrders.Text & "')", Con, 1, 1)
			While Not rsPodetails.EOF
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<tr height='30px' valign='top' class='ItemList'>")
				'UPGRADE_WARNING: Couldn't resolve default property of object Sno. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td>" & Sno & " </td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td>" & rsPodetails.Fields("MSRNo").Value & " </td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td><span class='costcode'>Cost Code : " & rsPodetails.Fields("AccountCode").Value & "</span><br>" & rsPodetails.Fields("ItemDescription").Value & "</td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td align='right'>" & VB6.Format(rsPodetails.Fields("Quantity").Value, "##,###") & " </td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td>" & rsPodetails.Fields("UOM").Value & " </td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td align='right'>" & VB6.Format(rsPodetails.Fields("UnitPrice").Value, "###,###,##0.00") & " </td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td align='right'>" & VB6.Format(rsPodetails.Fields("Quantity").Value * rsPodetails.Fields("UnitPrice").Value, "###,###,##0.00") & " </td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("</tr>")
				'UPGRADE_WARNING: Couldn't resolve default property of object GrandTotal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				GrandTotal = GrandTotal + (rsPodetails.Fields("Quantity").Value * rsPodetails.Fields("UnitPrice").Value)
				'UPGRADE_WARNING: Couldn't resolve default property of object Sno. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Sno = Sno + 1
				'UPGRADE_WARNING: Couldn't resolve default property of object rowsHeight. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				rowsHeight = rowsHeight + 30
				rsPodetails.MoveNext()
			End While
			'UPGRADE_WARNING: Couldn't resolve default property of object rowsHeight. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			While rowsHeight < 300
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<tr height='30px' valign='top' class='ItemList'>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td>&nbsp;</td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td>&nbsp;</td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td>&nbsp;</td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td>&nbsp;</td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td>&nbsp;</td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td>&nbsp;</td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("<td>&nbsp;</td>")
				'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fs.WriteLine("</tr>")
				'UPGRADE_WARNING: Couldn't resolve default property of object rowsHeight. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				rowsHeight = rowsHeight + 30
			End While
			'fs.WriteLine "<tr class='ItemListspl'><td colspan=9>&nbsp;</td></tr>"
			'Total
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<tr height='20px' class='ItemListSpl'>")
			'UPGRADE_WARNING: Couldn't resolve default property of object GrandTotal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<td colspan=5>Ringgit Malaysia :" & NumToWords(GrandTotal) & " only.</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<td>Total</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object GrandTotal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<td align='right'>" & VB6.Format(GrandTotal, "###,###,##0.00") & "</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("</tr>")
			'Salient Terms
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<tr height='20px' class='ItemListspl'>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<td colspan=7 align='center'>Salient Terms</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("</tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<tr class='ItemListspl' height='100px' valign='top'>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<td colspan=7>" & Replace(rsPoHeader.Fields("DeliveryTerms").Value, vbNewLine, "<br/>") & "</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("</tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </table>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <table >")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" <td>&nbsp;</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine(" </table>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<table  border='0' width='100%' cellpadding='0' class='NormalStyle' cellspacing='0'>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<td width=80%>&nbsp; ")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<td rowspan='2'>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("For and on behalf of<br />")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("TL OFFSHORE SDN BHD<br />")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<br />")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<br />")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<br />")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("_____________________<br />")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("Authorised Signatory(ies)<br />")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("</tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("<td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("Master Control Copy<br />")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("Accounts Copy<br />")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("Requsitioner 's Copy</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("</tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("</table>")
			'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fs.WriteLine("    </table><br>")
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("    </body>")
		'UPGRADE_WARNING: Couldn't resolve default property of object fs.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fs.WriteLine("    <html>")
		If boolSaveAsExcel = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object filpat. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object WebBrowser.Navigate. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WebBrowser.Navigate("C:\POS_Reports\" & filpat)
		Else
			POViewer.Navigate(New System.URI(My.Application.Info.DirectoryPath & "\rep.html"))
		End If
	End Sub
	Private Sub cmdView_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdView.Click
		PrintPOSO(False)
	End Sub
	Private Sub cmdPageSetup_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPageSetup.Click
		'On Error GoTo Xit
		'UPGRADE_ISSUE: SHDocVw.WebBrowser method POViewer.ExecWB was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'POViewer.ExecWB(8, 0)
Xit: 
	End Sub
	Private Sub cmdPreview_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPreview.Click
		'On Error GoTo Xit
		'UPGRADE_ISSUE: Constant OLECMDEXECOPT_PROMPTUSER was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Constant OLECMDID_PRINTPREVIEW was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: SHDocVw.WebBrowser method POViewer.ExecWB was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'POViewer.ExecWB(OLECMDID_PRINTPREVIEW, OLECMDEXECOPT_PROMPTUSER)
Xit: 
	End Sub
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
		'On Error GoTo Xit
		'UPGRADE_ISSUE: Constant OLECMDEXECOPT_DODEFAULT was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: SHDocVw.WebBrowser method POViewer.ExecWB was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'POViewer.ExecWB(6, OLECMDEXECOPT_DODEFAULT)
	End Sub
	Private Sub frmPrintPOSO_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		If Con.State Then Con.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Con.Open(ConnectString)
		fncFillCombo(cboPurchaseOrders, "Select distinct(PO_OrderNo) from PO_header where status = 1 order by po_OrderNo asc")
	End Sub
End Class