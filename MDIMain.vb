Option Strict Off
Option Explicit On
Friend Class MDIMain
	Inherits System.Windows.Forms.Form
	'UPGRADE_WARNING: Form event MDIMain.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub MDIMain_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		'UPGRADE_WARNING: Couldn't resolve default property of object VarLogName. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If "" & VarLogName = "" Then
			'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
            'Load(frmLogin)
			VB6.ShowForm(frmLogin, (1))
		End If
	End Sub
	Public Sub mnuDeliveryPointManagement_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDeliveryPointManagement.Click
		frmDeliveryPointMgmt.Show()
	End Sub
	Public Sub mnuExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuExit.Click
		SafeExit()
	End Sub
	Public Sub mnuInvoiceLog_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuInvoiceLog.Click
		FrmInvoiceLog.Show()
	End Sub
	Public Sub mnuNewPurchaseOrder_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNewPurchaseOrder.Click
		frmPOEntry.Show()
	End Sub
	Public Sub mnuNewServiceOrder_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNewServiceOrder.Click
		frmSOEntry.Show()
	End Sub
	Public Sub mnuPrintOrders_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPrintOrders.Click
		frmPrintPOSO.Show()
	End Sub
	Public Sub mnuPrintServiceOrder_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPrintServiceOrder.Click
		frmPrintSO.Show()
	End Sub
	Public Sub mnuPurchaseOrderListing_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPurchaseOrderListing.Click
		frmPOListing.Show()
	End Sub
	Public Sub mnuServiceOrderListing_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuServiceOrderListing.Click
		frmSOListing.Show()
	End Sub
	Public Sub mnuTransmittalForm_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuTransmittalForm.Click
		FrmTransmittalForm.Show()
	End Sub
	Public Sub mnuUserManagement_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuUserManagement.Click
		frmNewUser.Show()
	End Sub
	Public Sub mnuVendorManagement_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuVendorManagement.Click
		frmVendor.Show()
	End Sub
End Class