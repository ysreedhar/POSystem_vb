Option Strict Off
Option Explicit On
Module clsGlobalVariables
	
	'Public Recordset Declaration
	Public tblRecord As New ADODB.Recordset
	'Public connection declaration for MRU DB
	Public Con As New ADODB.Connection
	Public con2 As New ADODB.Connection
	
	'Public connection declaration for AAM DB
	Public member As New ADODB.Connection
	
	'Public connection declaration for AAMBreakdown DB
	Public breakdwn As New ADODB.Connection
	
	'Public connection declaration for BrDwn DB
	Public adoCon As New ADODB.Connection
	
	
	'User identification declaration
	Public strMemType, strMemName, strMemNo, strMemVehNo As Object
	Public strMemCategory As String
	
	'Public declaration for table name
	Public strTableName As Object
	Public VarLogged As String
	
	'Public declaration to store the server date
	Public vsystemdate As Object
	Public strQuery As String
	
	Public GridColorCount As Short
	Public GridAltColor As Integer
	Public GridLineToggle As Short
	
	Public strStatus As String
	
	Public strPendingFlag As String
	
	Public strPendingQry As String
	Public Sub SafeExit()
		
		On Error Resume Next
		'
		'Method for ensuring that all forms are unloaded from memory
		'before exiting the program
		Dim Form As System.Windows.Forms.Form
		
        For Each Form In Application.OpenForms
            Form.Close()
            'UPGRADE_NOTE: Object Form may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            Form = Nothing
        Next Form
		
	End Sub
End Module