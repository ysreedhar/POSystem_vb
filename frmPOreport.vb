Option Strict Off
Option Explicit On
Friend Class frmPOreport
	Inherits System.Windows.Forms.Form
	Dim con As New ADODB.Connection
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
	End Sub
	Private Sub cmdGenerate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGenerate.Click
		Dim WebBrowser1 As Object
		Dim GrandTotal As Object
		Dim vLineCount As Object
		Dim Sno As Object
		Dim sql As Object
		Dim fso As Object
		Dim rs2 As New ADODB.Recordset
		Dim RS As New ADODB.Recordset
		Dim Sum As Decimal
		'*****************************************************************************
		Dim a As Object
		fso = CreateObject("Scripting.FileSystemObject")
		'UPGRADE_WARNING: Couldn't resolve default property of object fso.CreateTextFile. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a = fso.CreateTextFile(My.Application.Info.DirectoryPath & "\report.html", True)
		Sum = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a.WriteLine("<html>")
		'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a.WriteLine("<head>")
		'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a.WriteLine("<Style type=text/css>P {page-break-before:always}</Style>")
		'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a.WriteLine("</head>")
		'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a.WriteLine("<BODY>")
		'UPGRADE_WARNING: Couldn't resolve default property of object sql. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sql = "select * from PO_Header where PONumber = " & cmbPONumbers.Text
		rs2.Open(sql, con, 1, 1)
		'UPGRADE_WARNING: Couldn't resolve default property of object Sno. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sno = 0
		While Not rs2.EOF
			'UPGRADE_WARNING: Couldn't resolve default property of object Sno. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sno = Sno + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object vLineCount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			vLineCount = vLineCount + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object vLineCount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If vLineCount > 28 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				a.WriteLine("<P></p>")
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<table border=0 cellspacing=0 cellpadding=0>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  <td width=295 colspan=3 valign=top>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  <p>To</p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  <p></p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  </td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  <td width=197 colspan=2 valign=top>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  <p> </p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  <p> </p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  </td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  <td width=98 valign=top >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  <p >" & VB6.Format(rs2.Fields("PODate").Value, "dd-MMM-yy") & "</p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  </td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine(" </tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine(" <tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  <td width=295 colspan=3 valign=top  >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  <p ></p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=197 colspan=2 valign=top>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p >" & rs2.Fields("Requisition_OrderNo").Value & "</p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p >" & rs2.Fields("CostCenter").Value & "</p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=295 colspan=3 valign=top>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p ></p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=197 colspan=2 valign=top >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p >" & rs2.Fields("Orderedby").Value & "</p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p >" & rs2.Fields("Approvedby").Value & "</p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=295 colspan=3 valign=top>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p ></p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=295 colspan=3 valign=top >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p >" & rs2.Fields("Remarks").Value & "</p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<tr>")
			RS.Open("Select * from PO_details where POID = rs2!POID , con, 1, 1")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=590 colspan=6 valign=top  >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p ></p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top   >")
			'UPGRADE_WARNING: Couldn't resolve default property of object Sno. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p >" & Sno & "</p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top  >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p >" & RS.Fields("quantity").Value & "</p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p >" & RS.Fields("ItemDescription").Value & "</p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top  >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p >" & RS.Fields("AccountCode").Value & "</p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p >" & RS.Fields("UnitPrice").Value & "</p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top  >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p >" & RS.Fields("quantity").Value * RS.Fields("UnitPrice").Value & "</p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object GrandTotal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GrandTotal = GrandTotal + (RS.Fields("quantity").Value * RS.Fields("UnitPrice").Value)
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p ></p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("</td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p ></p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine(" </td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  <p ></p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  </td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<p ></p>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("  </td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<td width=98 valign=top  >")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine(" </td>")
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine(" </tr>")
			RS.Close()
			rs2.MoveNext()
		End While
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vLineCount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		While vLineCount <> 28
			'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			a.WriteLine("<tr><td COLSPAN=5><br></td></tr>")
			'UPGRADE_WARNING: Couldn't resolve default property of object vLineCount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			vLineCount = vLineCount + 1
		End While
		'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a.WriteLine("</table>")
		
		'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a.WriteLine("</body>")
		'UPGRADE_WARNING: Couldn't resolve default property of object a.WriteLine. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a.WriteLine("</html>")
		'UPGRADE_WARNING: Couldn't resolve default property of object a.Close. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object WebBrowser1.Navigate. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WebBrowser1.Navigate(My.Application.Info.DirectoryPath & "\report.html")
		
	End Sub
	
	Private Sub frmPOreport_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim WebBrowser1 As Object
		If con.State Then con.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		con.Open(ConnectString)
		'UPGRADE_WARNING: Couldn't resolve default property of object WebBrowser1.Navigate. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WebBrowser1.Navigate("about:blank")
		LoadPONumbers()
	End Sub
	Private Sub LoadPONumbers()
		cmbPONumbers.Items.Clear()
		Dim rsPoNumbers As New ADODB.Recordset
		If rsPoNumbers.State Then RS.Close()
		rsPoNumbers.Open("select PO_OrderNo from PO_header  ", con, 3, 2)
        While Not rsPoNumbers.EOF
            cmbPONumbers.Items.Add(rsPoNumbers.Fields(0).Value)
        End While
		If rsPoNumbers.State Then rsPoNumbers.Close()
		cn.Close()
	End Sub
End Class