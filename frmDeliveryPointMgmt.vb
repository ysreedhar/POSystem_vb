Option Strict Off
Option Explicit On
Friend Class frmDeliveryPointMgmt
	Inherits System.Windows.Forms.Form
	Dim flxDPRowID As Short
	Dim con As New ADODB.Connection
	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
		flxDPRowID = 0
		txtDPName.Text = ""
		txtDPAddress.Text = ""
	End Sub
	
	Private Sub cmdDelete_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.Click
		Dim vsqlstr As Object
		Dim response As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object response. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		response = MsgBox("Are you sure you want to delete this Delivery Point?", MsgBoxStyle.OKCancel, My.Application.Info.Title)
		'UPGRADE_WARNING: Couldn't resolve default property of object response. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Dim rsDeliveryPoint As New ADODB.Recordset
		If response = 1 Then
			rsDeliveryPoint.Open("Select * from DeliveryPoints Where DeliveryPointID=" & flxDPRowID, con, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
			If Not rsDeliveryPoint.EOF Then
				'UPGRADE_WARNING: Couldn't resolve default property of object vsqlstr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				vsqlstr = "Delete from deliverypoints WHERE DeliveryPointID= " & flxDPRowID
				'UPGRADE_WARNING: Couldn't resolve default property of object vsqlstr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cn.Execute(vsqlstr)
				MsgBox("Record Deleted", MsgBoxStyle.Information, My.Application.Info.Title)
				LoadDeliveryPoints()
				cmdClear_Click(cmdClear, New System.EventArgs())
			End If
		End If
	End Sub
	
	Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
		Dim vsqlstr As Object
		Dim response As Object
		If Trim(txtDPName.Text) = "" Then
			MsgBox("Choose a Name for Delivery Point!", MsgBoxStyle.Information, My.Application.Info.Title)
			Exit Sub
		End If
		If Trim(txtDPAddress.Text) = "" Then
			MsgBox("Enter Address for Delivery Point", MsgBoxStyle.Information, My.Application.Info.Title)
			Exit Sub
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object response. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		response = MsgBox("Are you sure you want to add this Delivery Point?", MsgBoxStyle.OKCancel, My.Application.Info.Title)
		'UPGRADE_WARNING: Couldn't resolve default property of object response. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Dim rsDeliveryPoint As New ADODB.Recordset
		If response = 1 Then
			rsDeliveryPoint.Open("Select * from DeliveryPoints Where DeliveryPointID=" & flxDPRowID, con, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
			If rsDeliveryPoint.EOF Then
				'AddNew
				'UPGRADE_WARNING: Couldn't resolve default property of object vsqlstr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				vsqlstr = "Insert Into DeliveryPoints (" & "DeliveryPointName," & "DeliveryPointAddress)" & " Values (" & "'" & Trim(txtDPName.Text) & "', '" & Trim(txtDPAddress.Text) & "')"
				
				'UPGRADE_WARNING: Couldn't resolve default property of object vsqlstr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cn.Execute(vsqlstr)
				MsgBox("Record Added", MsgBoxStyle.Information, My.Application.Info.Title)
			Else
				'Update
				'UPGRADE_WARNING: Couldn't resolve default property of object vsqlstr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				vsqlstr = "Update DeliveryPoints SET " & "DeliveryPointName= '" & Trim(txtDPName.Text) & "', DeliveryPointAddress= '" & Trim(txtDPAddress.Text) & "' WHERE DeliveryPointID= " & flxDPRowID
				'UPGRADE_WARNING: Couldn't resolve default property of object vsqlstr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cn.Execute(vsqlstr)
				MsgBox("Record Updated", MsgBoxStyle.Information, My.Application.Info.Title)
			End If
			
			If rsDeliveryPoint.State Then rsDeliveryPoint.Close()
			'UPGRADE_NOTE: Object rsDeliveryPoint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsDeliveryPoint = Nothing
			LoadDeliveryPoints()
			cmdClear_Click(cmdClear, New System.EventArgs())
		End If
	End Sub
	
	Private Sub flxDeliveryPoints_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxDeliveryPoints.ClickEvent
		Dim vprev As Object
		Dim i As Object
		Dim current As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object current. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		current = flxDeliveryPoints.Row
		RepaintFlexGrid()
		'Current  row
		'UPGRADE_WARNING: Couldn't resolve default property of object current. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		flxDeliveryPoints.Row = current
		For i = 1 To flxDeliveryPoints.Cols - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			flxDeliveryPoints.Col = i
			flxDeliveryPoints.CellBackColor = System.Drawing.Color.Yellow
		Next 
		flxDPRowID = CShort(flxDeliveryPoints.get_TextMatrix(flxDeliveryPoints.Row, 0))
		txtDPName.Text = flxDeliveryPoints.get_TextMatrix(flxDeliveryPoints.Row, 1)
		txtDPAddress.Text = flxDeliveryPoints.get_TextMatrix(flxDeliveryPoints.Row, 2)
		'UPGRADE_WARNING: Couldn't resolve default property of object vprev. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vprev = flxDeliveryPoints.Row
		flxDeliveryPoints.Col = 1
	End Sub
	Function RepaintFlexGrid() As Object
		Dim flxcls As Object
		Dim ch As Object
		' Reset the backcolor
		For ch = 1 To flxDeliveryPoints.Rows - 1
			For flxcls = 0 To flxDeliveryPoints.Cols - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object ch. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				flxDeliveryPoints.Row = ch
				'UPGRADE_WARNING: Couldn't resolve default property of object flxcls. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				flxDeliveryPoints.Col = flxcls
				If flxDeliveryPoints.CellBackColor.equals(System.Drawing.Color.Yellow) Then flxDeliveryPoints.CellBackColor = System.Drawing.Color.White
			Next flxcls
		Next ch
	End Function
	Private Sub frmDeliveryPointMgmt_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		If con.State Then con.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object ConnectString. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		con.Open(ConnectString)
		LoadFlexTitles()
		LoadDeliveryPoints()
	End Sub
	
	Private Sub LoadDeliveryPoints()
		Dim fldata3 As New ADODB.Recordset
		If fldata3.State Then fldata3.Close()
		fldata3.Open("select * from DeliveryPoints", con, 3, 2)
		With flxDeliveryPoints
			.Rows = 1
			While Not fldata3.EOF
				.Rows = .Rows + 1
				.set_TextMatrix(.Rows - 1, 0, fldata3.Fields("DeliveryPointID").Value)
				.set_TextMatrix(.Rows - 1, 1, fldata3.Fields("DeliveryPointName").Value)
				.set_TextMatrix(.Rows - 1, 2, fldata3.Fields("DeliveryPointAddress").Value)
				fldata3.MoveNext()
			End While
		End With
		If fldata3.State Then fldata3.Close()
	End Sub
	Private Sub LoadFlexTitles()
		On Error Resume Next
		With flxDeliveryPoints
			.Row = 0 : .Col = 0
			.set_ColWidth(0, 0)
			.set_TextMatrix(0, 1, "Name")
			.set_ColWidth(1, 3500)
			.set_TextMatrix(0, 2, "Address")
			.set_ColWidth(2, 5000)
		End With
	End Sub
End Class