<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MDIMain
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents mnuVendorManagement As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuUserManagement As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuDeliveryPointManagement As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAdministration As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuPurchaseOrderListing As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuNewPurchaseOrder As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuServiceOrderListing As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuNewServiceOrder As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuPrintOrders As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuPrintServiceOrder As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuReports As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuTransactions As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuInvoiceLog As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuTransmittalForm As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuInvoiceTransactions As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuExitOptions As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MDIMain))
		Me.IsMDIContainer = True
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuAdministration = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuVendorManagement = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuUserManagement = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuDeliveryPointManagement = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuTransactions = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuPurchaseOrderListing = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuNewPurchaseOrder = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuServiceOrderListing = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuNewServiceOrder = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuReports = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuPrintOrders = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuPrintServiceOrder = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuInvoiceTransactions = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuInvoiceLog = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuTransmittalForm = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuExitOptions = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
		Me.MainMenu1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.Text = "Purchase Order System"
		Me.ClientSize = New System.Drawing.Size(542, 359)
		Me.Location = New System.Drawing.Point(11, 57)
		Me.Icon = CType(resources.GetObject("MDIMain.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Name = "MDIMain"
		Me.mnuAdministration.Name = "mnuAdministration"
		Me.mnuAdministration.Text = "Administration"
		Me.mnuAdministration.Checked = False
		Me.mnuAdministration.Enabled = True
		Me.mnuAdministration.Visible = True
		Me.mnuVendorManagement.Name = "mnuVendorManagement"
		Me.mnuVendorManagement.Text = "Vendor Management"
		Me.mnuVendorManagement.Checked = False
		Me.mnuVendorManagement.Enabled = True
		Me.mnuVendorManagement.Visible = True
		Me.mnuUserManagement.Name = "mnuUserManagement"
		Me.mnuUserManagement.Text = "User Management"
		Me.mnuUserManagement.Checked = False
		Me.mnuUserManagement.Enabled = True
		Me.mnuUserManagement.Visible = True
		Me.mnuDeliveryPointManagement.Name = "mnuDeliveryPointManagement"
		Me.mnuDeliveryPointManagement.Text = "Delivery Point Management"
		Me.mnuDeliveryPointManagement.Checked = False
		Me.mnuDeliveryPointManagement.Enabled = True
		Me.mnuDeliveryPointManagement.Visible = True
		Me.mnuTransactions.Name = "mnuTransactions"
		Me.mnuTransactions.Text = "Transactions"
		Me.mnuTransactions.Checked = False
		Me.mnuTransactions.Enabled = True
		Me.mnuTransactions.Visible = True
		Me.mnuPurchaseOrderListing.Name = "mnuPurchaseOrderListing"
		Me.mnuPurchaseOrderListing.Text = "Purchase Order Listing"
		Me.mnuPurchaseOrderListing.Checked = False
		Me.mnuPurchaseOrderListing.Enabled = True
		Me.mnuPurchaseOrderListing.Visible = True
		Me.mnuNewPurchaseOrder.Name = "mnuNewPurchaseOrder"
		Me.mnuNewPurchaseOrder.Text = "Enter Purchase Order"
		Me.mnuNewPurchaseOrder.Checked = False
		Me.mnuNewPurchaseOrder.Enabled = True
		Me.mnuNewPurchaseOrder.Visible = True
		Me.mnuServiceOrderListing.Name = "mnuServiceOrderListing"
		Me.mnuServiceOrderListing.Text = "Service Order Listing"
		Me.mnuServiceOrderListing.Checked = False
		Me.mnuServiceOrderListing.Enabled = True
		Me.mnuServiceOrderListing.Visible = True
		Me.mnuNewServiceOrder.Name = "mnuNewServiceOrder"
		Me.mnuNewServiceOrder.Text = "Enter Service Order"
		Me.mnuNewServiceOrder.Checked = False
		Me.mnuNewServiceOrder.Enabled = True
		Me.mnuNewServiceOrder.Visible = True
		Me.mnuReports.Name = "mnuReports"
		Me.mnuReports.Text = "Reports"
		Me.mnuReports.Checked = False
		Me.mnuReports.Enabled = True
		Me.mnuReports.Visible = True
		Me.mnuPrintOrders.Name = "mnuPrintOrders"
		Me.mnuPrintOrders.Text = "Print Purchase Order"
		Me.mnuPrintOrders.Checked = False
		Me.mnuPrintOrders.Enabled = True
		Me.mnuPrintOrders.Visible = True
		Me.mnuPrintServiceOrder.Name = "mnuPrintServiceOrder"
		Me.mnuPrintServiceOrder.Text = "Print Service Order"
		Me.mnuPrintServiceOrder.Checked = False
		Me.mnuPrintServiceOrder.Enabled = True
		Me.mnuPrintServiceOrder.Visible = True
		Me.mnuInvoiceTransactions.Name = "mnuInvoiceTransactions"
		Me.mnuInvoiceTransactions.Text = "Invoice Transactions"
		Me.mnuInvoiceTransactions.Checked = False
		Me.mnuInvoiceTransactions.Enabled = True
		Me.mnuInvoiceTransactions.Visible = True
		Me.mnuInvoiceLog.Name = "mnuInvoiceLog"
		Me.mnuInvoiceLog.Text = "Invoice Log"
		Me.mnuInvoiceLog.Checked = False
		Me.mnuInvoiceLog.Enabled = True
		Me.mnuInvoiceLog.Visible = True
		Me.mnuTransmittalForm.Name = "mnuTransmittalForm"
		Me.mnuTransmittalForm.Text = "Transmittal Form"
		Me.mnuTransmittalForm.Checked = False
		Me.mnuTransmittalForm.Enabled = True
		Me.mnuTransmittalForm.Visible = True
		Me.mnuExitOptions.Name = "mnuExitOptions"
		Me.mnuExitOptions.Text = "Exit"
		Me.mnuExitOptions.Checked = False
		Me.mnuExitOptions.Enabled = True
		Me.mnuExitOptions.Visible = True
		Me.mnuExit.Name = "mnuExit"
		Me.mnuExit.Text = "LogOff"
		Me.mnuExit.Checked = False
		Me.mnuExit.Enabled = True
		Me.mnuExit.Visible = True
		Me.mnuAdministration.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.mnuTransactions.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.mnuInvoiceTransactions.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.mnuExitOptions.MergeAction = System.Windows.Forms.MergeAction.Remove
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuAdministration, Me.mnuTransactions, Me.mnuInvoiceTransactions, Me.mnuExitOptions})
		mnuAdministration.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuVendorManagement, Me.mnuUserManagement, Me.mnuDeliveryPointManagement})
		mnuTransactions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuPurchaseOrderListing, Me.mnuNewPurchaseOrder, Me.mnuServiceOrderListing, Me.mnuNewServiceOrder, Me.mnuReports})
		mnuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuPrintOrders, Me.mnuPrintServiceOrder})
		mnuInvoiceTransactions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuInvoiceLog, Me.mnuTransmittalForm})
		mnuExitOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuExit})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class