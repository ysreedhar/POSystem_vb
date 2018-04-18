Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility

Module DataEnvironment_DataEnvironment1_Module
	Friend DataEnvironment1 As DataEnvironment_DataEnvironment1 = New DataEnvironment_DataEnvironment1()
End Module

Friend Class DataEnvironment_DataEnvironment1
	Inherits VB6.BaseDataEnvironment
	Public WithEvents Connection1 As ADODB.Connection
	Public Sub New()
		MyBase.New()
		Dim par As ADODB.Parameter
		
		
		Connection1 = New ADODB.Connection()
		Connection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sreedhar\Works\POSystem\PO_System.mdb;Persist Security Info=False;"
		m_Connections.Add(Connection1, "Connection1")
	End Sub
End Class