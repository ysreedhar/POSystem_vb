<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmInvoiceLog
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		'This form is an MDI child.
		'This code simulates the VB6 
		' functionality of automatically
		' loading and showing an MDI
		' child's parent.
		Me.MDIParent = POSystem.MDIMain
		POSystem.MDIMain.Show
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
	Public WithEvents txtEditFlexMatrix As System.Windows.Forms.TextBox
	Public WithEvents dtpInvoiceDate As AxMSComCtl2.AxDTPicker
	Public WithEvents cmdReset As System.Windows.Forms.Button
	Public WithEvents cmdLogInvoice As System.Windows.Forms.Button
	Public WithEvents txtInvoiceNumber As System.Windows.Forms.TextBox
	Public WithEvents cboPurchaseOrders As System.Windows.Forms.ComboBox
	Public WithEvents flxPODetails As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents dtpReceiptDate As AxMSComCtl2.AxDTPicker
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents lblPOValue As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents lblVendorName As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents lblInvoiceValue As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmInvoiceLog))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtEditFlexMatrix = New System.Windows.Forms.TextBox
		Me.dtpInvoiceDate = New AxMSComCtl2.AxDTPicker
		Me.cmdReset = New System.Windows.Forms.Button
		Me.cmdLogInvoice = New System.Windows.Forms.Button
		Me.txtInvoiceNumber = New System.Windows.Forms.TextBox
		Me.cboPurchaseOrders = New System.Windows.Forms.ComboBox
		Me.flxPODetails = New AxMSFlexGridLib.AxMSFlexGrid
		Me.dtpReceiptDate = New AxMSComCtl2.AxDTPicker
		Me.Label9 = New System.Windows.Forms.Label
		Me.lblPOValue = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.lblVendorName = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.lblInvoiceValue = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtpInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.flxPODetails, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtpReceiptDate, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Invoice Log"
		Me.ClientSize = New System.Drawing.Size(760, 558)
		Me.Location = New System.Drawing.Point(11, 37)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.Name = "FrmInvoiceLog"
		Me.txtEditFlexMatrix.AutoSize = False
		Me.txtEditFlexMatrix.Size = New System.Drawing.Size(81, 33)
		Me.txtEditFlexMatrix.Location = New System.Drawing.Point(64, 432)
		Me.txtEditFlexMatrix.TabIndex = 15
		Me.txtEditFlexMatrix.Visible = False
		Me.txtEditFlexMatrix.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEditFlexMatrix.AcceptsReturn = True
		Me.txtEditFlexMatrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtEditFlexMatrix.BackColor = System.Drawing.SystemColors.Window
		Me.txtEditFlexMatrix.CausesValidation = True
		Me.txtEditFlexMatrix.Enabled = True
		Me.txtEditFlexMatrix.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEditFlexMatrix.HideSelection = True
		Me.txtEditFlexMatrix.ReadOnly = False
		Me.txtEditFlexMatrix.Maxlength = 0
		Me.txtEditFlexMatrix.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEditFlexMatrix.MultiLine = False
		Me.txtEditFlexMatrix.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEditFlexMatrix.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEditFlexMatrix.TabStop = True
		Me.txtEditFlexMatrix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtEditFlexMatrix.Name = "txtEditFlexMatrix"
		dtpInvoiceDate.OcxState = CType(resources.GetObject("dtpInvoiceDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtpInvoiceDate.Size = New System.Drawing.Size(169, 21)
		Me.dtpInvoiceDate.Location = New System.Drawing.Point(168, 96)
		Me.dtpInvoiceDate.TabIndex = 10
		Me.dtpInvoiceDate.Name = "dtpInvoiceDate"
		Me.cmdReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdReset.Text = "Reset"
		Me.cmdReset.Size = New System.Drawing.Size(81, 33)
		Me.cmdReset.Location = New System.Drawing.Point(312, 432)
		Me.cmdReset.TabIndex = 8
		Me.cmdReset.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdReset.BackColor = System.Drawing.SystemColors.Control
		Me.cmdReset.CausesValidation = True
		Me.cmdReset.Enabled = True
		Me.cmdReset.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdReset.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdReset.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdReset.TabStop = True
		Me.cmdReset.Name = "cmdReset"
		Me.cmdLogInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLogInvoice.Text = "Log Invoice"
		Me.cmdLogInvoice.Size = New System.Drawing.Size(81, 33)
		Me.cmdLogInvoice.Location = New System.Drawing.Point(216, 432)
		Me.cmdLogInvoice.TabIndex = 7
		Me.cmdLogInvoice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLogInvoice.BackColor = System.Drawing.SystemColors.Control
		Me.cmdLogInvoice.CausesValidation = True
		Me.cmdLogInvoice.Enabled = True
		Me.cmdLogInvoice.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdLogInvoice.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLogInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdLogInvoice.TabStop = True
		Me.cmdLogInvoice.Name = "cmdLogInvoice"
		Me.txtInvoiceNumber.AutoSize = False
		Me.txtInvoiceNumber.Size = New System.Drawing.Size(169, 21)
		Me.txtInvoiceNumber.Location = New System.Drawing.Point(168, 56)
		Me.txtInvoiceNumber.TabIndex = 3
		Me.txtInvoiceNumber.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtInvoiceNumber.AcceptsReturn = True
		Me.txtInvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtInvoiceNumber.BackColor = System.Drawing.SystemColors.Window
		Me.txtInvoiceNumber.CausesValidation = True
		Me.txtInvoiceNumber.Enabled = True
		Me.txtInvoiceNumber.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtInvoiceNumber.HideSelection = True
		Me.txtInvoiceNumber.ReadOnly = False
		Me.txtInvoiceNumber.Maxlength = 0
		Me.txtInvoiceNumber.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtInvoiceNumber.MultiLine = False
		Me.txtInvoiceNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtInvoiceNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtInvoiceNumber.TabStop = True
		Me.txtInvoiceNumber.Visible = True
		Me.txtInvoiceNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
		Me.cboPurchaseOrders.Size = New System.Drawing.Size(169, 21)
		Me.cboPurchaseOrders.Location = New System.Drawing.Point(168, 20)
		Me.cboPurchaseOrders.TabIndex = 0
		Me.cboPurchaseOrders.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPurchaseOrders.BackColor = System.Drawing.SystemColors.Window
		Me.cboPurchaseOrders.CausesValidation = True
		Me.cboPurchaseOrders.Enabled = True
		Me.cboPurchaseOrders.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPurchaseOrders.IntegralHeight = True
		Me.cboPurchaseOrders.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPurchaseOrders.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPurchaseOrders.Sorted = False
		Me.cboPurchaseOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboPurchaseOrders.TabStop = True
		Me.cboPurchaseOrders.Visible = True
		Me.cboPurchaseOrders.Name = "cboPurchaseOrders"
		flxPODetails.OcxState = CType(resources.GetObject("flxPODetails.OcxState"), System.Windows.Forms.AxHost.State)
		Me.flxPODetails.Size = New System.Drawing.Size(617, 217)
		Me.flxPODetails.Location = New System.Drawing.Point(16, 200)
		Me.flxPODetails.TabIndex = 4
		Me.flxPODetails.Name = "flxPODetails"
		dtpReceiptDate.OcxState = CType(resources.GetObject("dtpReceiptDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtpReceiptDate.Size = New System.Drawing.Size(169, 21)
		Me.dtpReceiptDate.Location = New System.Drawing.Point(480, 96)
		Me.dtpReceiptDate.TabIndex = 12
		Me.dtpReceiptDate.Name = "dtpReceiptDate"
		Me.Label9.Text = "PO Value"
		Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Size = New System.Drawing.Size(49, 13)
		Me.Label9.Location = New System.Drawing.Point(352, 56)
		Me.Label9.TabIndex = 18
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = True
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.lblPOValue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPOValue.Size = New System.Drawing.Size(3, 13)
		Me.lblPOValue.Location = New System.Drawing.Point(480, 56)
		Me.lblPOValue.TabIndex = 17
		Me.lblPOValue.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPOValue.BackColor = System.Drawing.SystemColors.Control
		Me.lblPOValue.Enabled = True
		Me.lblPOValue.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPOValue.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPOValue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPOValue.UseMnemonic = True
		Me.lblPOValue.Visible = True
		Me.lblPOValue.AutoSize = True
		Me.lblPOValue.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPOValue.Name = "lblPOValue"
		Me.Label7.Text = "Modify Inv. Quantity to match the delivery as per Invoice."
		Me.Label7.Size = New System.Drawing.Size(280, 13)
		Me.Label7.Location = New System.Drawing.Point(16, 168)
		Me.Label7.TabIndex = 16
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = True
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label8.Text = "Vendor Name"
		Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Size = New System.Drawing.Size(75, 13)
		Me.Label8.Location = New System.Drawing.Point(352, 24)
		Me.Label8.TabIndex = 14
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = True
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.lblVendorName.Size = New System.Drawing.Size(3, 13)
		Me.lblVendorName.Location = New System.Drawing.Point(480, 24)
		Me.lblVendorName.TabIndex = 13
		Me.lblVendorName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVendorName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVendorName.BackColor = System.Drawing.SystemColors.Control
		Me.lblVendorName.Enabled = True
		Me.lblVendorName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVendorName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVendorName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVendorName.UseMnemonic = True
		Me.lblVendorName.Visible = True
		Me.lblVendorName.AutoSize = True
		Me.lblVendorName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVendorName.Name = "lblVendorName"
		Me.Label6.Text = "Invoice Receipt Date"
		Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Size = New System.Drawing.Size(118, 13)
		Me.Label6.Location = New System.Drawing.Point(352, 100)
		Me.Label6.TabIndex = 11
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = True
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label5.Text = "Invoice Date"
		Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Size = New System.Drawing.Size(72, 13)
		Me.Label5.Location = New System.Drawing.Point(16, 100)
		Me.Label5.TabIndex = 9
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = True
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.lblInvoiceValue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInvoiceValue.Size = New System.Drawing.Size(3, 13)
		Me.lblInvoiceValue.Location = New System.Drawing.Point(352, 168)
		Me.lblInvoiceValue.TabIndex = 6
		Me.lblInvoiceValue.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblInvoiceValue.BackColor = System.Drawing.SystemColors.Control
		Me.lblInvoiceValue.Enabled = True
		Me.lblInvoiceValue.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblInvoiceValue.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblInvoiceValue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblInvoiceValue.UseMnemonic = True
		Me.lblInvoiceValue.Visible = True
		Me.lblInvoiceValue.AutoSize = True
		Me.lblInvoiceValue.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblInvoiceValue.Name = "lblInvoiceValue"
		Me.Label3.Text = "Match Items on Purchase Order"
		Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Size = New System.Drawing.Size(179, 13)
		Me.Label3.Location = New System.Drawing.Point(16, 144)
		Me.Label3.TabIndex = 5
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = True
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "Invoice Number"
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Size = New System.Drawing.Size(89, 13)
		Me.Label2.Location = New System.Drawing.Point(16, 60)
		Me.Label2.TabIndex = 2
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = True
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Purchase Order Number"
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(134, 13)
		Me.Label1.Location = New System.Drawing.Point(16, 24)
		Me.Label1.TabIndex = 1
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = True
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		CType(Me.dtpReceiptDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.flxPODetails, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtpInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(txtEditFlexMatrix)
		Me.Controls.Add(dtpInvoiceDate)
		Me.Controls.Add(cmdReset)
		Me.Controls.Add(cmdLogInvoice)
		Me.Controls.Add(txtInvoiceNumber)
		Me.Controls.Add(cboPurchaseOrders)
		Me.Controls.Add(flxPODetails)
		Me.Controls.Add(dtpReceiptDate)
		Me.Controls.Add(Label9)
		Me.Controls.Add(lblPOValue)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label8)
		Me.Controls.Add(lblVendorName)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(lblInvoiceValue)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class