<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSOEntry
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
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents cmdReset As System.Windows.Forms.Button
	Public WithEvents Text5 As System.Windows.Forms.TextBox
	Public WithEvents Text4 As System.Windows.Forms.TextBox
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents cboDeliveryPoint As System.Windows.Forms.ComboBox
	Public WithEvents cboVendorName As System.Windows.Forms.ComboBox
	Public WithEvents txtCurrency As System.Windows.Forms.TextBox
	Public WithEvents dtpPODate As AxMSComCtl2.AxDTPicker
	Public WithEvents txtDeliveryTerms As System.Windows.Forms.TextBox
	Public WithEvents txtRemarks As System.Windows.Forms.TextBox
	Public WithEvents txtApprovedBy As System.Windows.Forms.TextBox
	Public WithEvents txtOrderedBy As System.Windows.Forms.TextBox
	Public WithEvents txtCostCenter As System.Windows.Forms.TextBox
	Public WithEvents txtReqOrderNo As System.Windows.Forms.TextBox
	Public WithEvents txtPONumber As System.Windows.Forms.TextBox
	Public WithEvents txtAddress As System.Windows.Forms.TextBox
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSOEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdPrint = New System.Windows.Forms.Button
		Me.cmdSave = New System.Windows.Forms.Button
		Me.cmdReset = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Text5 = New System.Windows.Forms.TextBox
		Me.Text4 = New System.Windows.Forms.TextBox
		Me.Text3 = New System.Windows.Forms.TextBox
		Me.Text2 = New System.Windows.Forms.TextBox
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.cboDeliveryPoint = New System.Windows.Forms.ComboBox
		Me.cboVendorName = New System.Windows.Forms.ComboBox
		Me.txtCurrency = New System.Windows.Forms.TextBox
		Me.dtpPODate = New AxMSComCtl2.AxDTPicker
		Me.txtDeliveryTerms = New System.Windows.Forms.TextBox
		Me.txtRemarks = New System.Windows.Forms.TextBox
		Me.txtApprovedBy = New System.Windows.Forms.TextBox
		Me.txtOrderedBy = New System.Windows.Forms.TextBox
		Me.txtCostCenter = New System.Windows.Forms.TextBox
		Me.txtReqOrderNo = New System.Windows.Forms.TextBox
		Me.txtPONumber = New System.Windows.Forms.TextBox
		Me.txtAddress = New System.Windows.Forms.TextBox
		Me.Label17 = New System.Windows.Forms.Label
		Me.Label16 = New System.Windows.Forms.Label
		Me.Label15 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtpPODate, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Enter Service Order"
		Me.ClientSize = New System.Drawing.Size(727, 618)
		Me.Location = New System.Drawing.Point(4, 30)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("frmSOEntry.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmSOEntry"
		Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrint.Text = "&Print"
		Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPrint.Size = New System.Drawing.Size(81, 33)
		Me.cmdPrint.Location = New System.Drawing.Point(611, 520)
		Me.cmdPrint.TabIndex = 27
		Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrint.CausesValidation = True
		Me.cmdPrint.Enabled = True
		Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrint.TabStop = True
		Me.cmdPrint.Name = "cmdPrint"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSave.Text = "&Save"
		Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.Size = New System.Drawing.Size(81, 33)
		Me.cmdSave.Location = New System.Drawing.Point(419, 520)
		Me.cmdSave.TabIndex = 21
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Enabled = True
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.TabStop = True
		Me.cmdSave.Name = "cmdSave"
		Me.cmdReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdReset.Text = "&Reset"
		Me.cmdReset.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdReset.Size = New System.Drawing.Size(81, 33)
		Me.cmdReset.Location = New System.Drawing.Point(515, 520)
		Me.cmdReset.TabIndex = 20
		Me.cmdReset.BackColor = System.Drawing.SystemColors.Control
		Me.cmdReset.CausesValidation = True
		Me.cmdReset.Enabled = True
		Me.cmdReset.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdReset.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdReset.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdReset.TabStop = True
		Me.cmdReset.Name = "cmdReset"
		Me.Frame1.Text = "Service Order"
		Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Size = New System.Drawing.Size(657, 481)
		Me.Frame1.Location = New System.Drawing.Point(35, 16)
		Me.Frame1.TabIndex = 0
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.Text5.AutoSize = False
		Me.Text5.Size = New System.Drawing.Size(121, 25)
		Me.Text5.Location = New System.Drawing.Point(264, 280)
		Me.Text5.TabIndex = 36
		Me.Text5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text5.AcceptsReturn = True
		Me.Text5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text5.BackColor = System.Drawing.SystemColors.Window
		Me.Text5.CausesValidation = True
		Me.Text5.Enabled = True
		Me.Text5.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text5.HideSelection = True
		Me.Text5.ReadOnly = False
		Me.Text5.Maxlength = 0
		Me.Text5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text5.MultiLine = False
		Me.Text5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text5.TabStop = True
		Me.Text5.Visible = True
		Me.Text5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text5.Name = "Text5"
		Me.Text4.AutoSize = False
		Me.Text4.Size = New System.Drawing.Size(97, 25)
		Me.Text4.Location = New System.Drawing.Point(80, 280)
		Me.Text4.TabIndex = 34
		Me.Text4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text4.AcceptsReturn = True
		Me.Text4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text4.BackColor = System.Drawing.SystemColors.Window
		Me.Text4.CausesValidation = True
		Me.Text4.Enabled = True
		Me.Text4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text4.HideSelection = True
		Me.Text4.ReadOnly = False
		Me.Text4.Maxlength = 0
		Me.Text4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text4.MultiLine = False
		Me.Text4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text4.TabStop = True
		Me.Text4.Visible = True
		Me.Text4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text4.Name = "Text4"
		Me.Text3.AutoSize = False
		Me.Text3.Size = New System.Drawing.Size(305, 25)
		Me.Text3.Location = New System.Drawing.Point(80, 248)
		Me.Text3.TabIndex = 32
		Me.Text3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text3.AcceptsReturn = True
		Me.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text3.BackColor = System.Drawing.SystemColors.Window
		Me.Text3.CausesValidation = True
		Me.Text3.Enabled = True
		Me.Text3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text3.HideSelection = True
		Me.Text3.ReadOnly = False
		Me.Text3.Maxlength = 0
		Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text3.MultiLine = False
		Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text3.TabStop = True
		Me.Text3.Visible = True
		Me.Text3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text3.Name = "Text3"
		Me.Text2.AutoSize = False
		Me.Text2.Size = New System.Drawing.Size(121, 25)
		Me.Text2.Location = New System.Drawing.Point(264, 216)
		Me.Text2.TabIndex = 30
		Me.Text2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text2.AcceptsReturn = True
		Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text2.BackColor = System.Drawing.SystemColors.Window
		Me.Text2.CausesValidation = True
		Me.Text2.Enabled = True
		Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text2.HideSelection = True
		Me.Text2.ReadOnly = False
		Me.Text2.Maxlength = 0
		Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text2.MultiLine = False
		Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text2.TabStop = True
		Me.Text2.Visible = True
		Me.Text2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text2.Name = "Text2"
		Me.Text1.AutoSize = False
		Me.Text1.Size = New System.Drawing.Size(97, 25)
		Me.Text1.Location = New System.Drawing.Point(80, 216)
		Me.Text1.TabIndex = 28
		Me.Text1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.AcceptsReturn = True
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text1.BackColor = System.Drawing.SystemColors.Window
		Me.Text1.CausesValidation = True
		Me.Text1.Enabled = True
		Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text1.HideSelection = True
		Me.Text1.ReadOnly = False
		Me.Text1.Maxlength = 0
		Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text1.MultiLine = False
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text1.TabStop = True
		Me.Text1.Visible = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text1.Name = "Text1"
		Me.cboDeliveryPoint.Size = New System.Drawing.Size(169, 21)
		Me.cboDeliveryPoint.Location = New System.Drawing.Point(472, 220)
		Me.cboDeliveryPoint.TabIndex = 25
		Me.cboDeliveryPoint.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDeliveryPoint.BackColor = System.Drawing.SystemColors.Window
		Me.cboDeliveryPoint.CausesValidation = True
		Me.cboDeliveryPoint.Enabled = True
		Me.cboDeliveryPoint.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDeliveryPoint.IntegralHeight = True
		Me.cboDeliveryPoint.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDeliveryPoint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDeliveryPoint.Sorted = False
		Me.cboDeliveryPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboDeliveryPoint.TabStop = True
		Me.cboDeliveryPoint.Visible = True
		Me.cboDeliveryPoint.Name = "cboDeliveryPoint"
		Me.cboVendorName.Size = New System.Drawing.Size(305, 21)
		Me.cboVendorName.Location = New System.Drawing.Point(80, 24)
		Me.cboVendorName.TabIndex = 24
		Me.cboVendorName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboVendorName.BackColor = System.Drawing.SystemColors.Window
		Me.cboVendorName.CausesValidation = True
		Me.cboVendorName.Enabled = True
		Me.cboVendorName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVendorName.IntegralHeight = True
		Me.cboVendorName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVendorName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVendorName.Sorted = False
		Me.cboVendorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVendorName.TabStop = True
		Me.cboVendorName.Visible = True
		Me.cboVendorName.Name = "cboVendorName"
		Me.txtCurrency.AutoSize = False
		Me.txtCurrency.Size = New System.Drawing.Size(33, 25)
		Me.txtCurrency.Location = New System.Drawing.Point(472, 176)
		Me.txtCurrency.TabIndex = 22
		Me.txtCurrency.Text = "RM"
		Me.txtCurrency.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCurrency.AcceptsReturn = True
		Me.txtCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCurrency.BackColor = System.Drawing.SystemColors.Window
		Me.txtCurrency.CausesValidation = True
		Me.txtCurrency.Enabled = True
		Me.txtCurrency.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCurrency.HideSelection = True
		Me.txtCurrency.ReadOnly = False
		Me.txtCurrency.Maxlength = 0
		Me.txtCurrency.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCurrency.MultiLine = False
		Me.txtCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCurrency.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCurrency.TabStop = True
		Me.txtCurrency.Visible = True
		Me.txtCurrency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCurrency.Name = "txtCurrency"
		dtpPODate.OcxState = CType(resources.GetObject("dtpPODate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtpPODate.Size = New System.Drawing.Size(89, 25)
		Me.dtpPODate.Location = New System.Drawing.Point(472, 16)
		Me.dtpPODate.TabIndex = 19
		Me.dtpPODate.Name = "dtpPODate"
		Me.txtDeliveryTerms.AutoSize = False
		Me.txtDeliveryTerms.Size = New System.Drawing.Size(385, 113)
		Me.txtDeliveryTerms.Location = New System.Drawing.Point(8, 344)
		Me.txtDeliveryTerms.MultiLine = True
		Me.txtDeliveryTerms.TabIndex = 18
		Me.txtDeliveryTerms.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDeliveryTerms.AcceptsReturn = True
		Me.txtDeliveryTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDeliveryTerms.BackColor = System.Drawing.SystemColors.Window
		Me.txtDeliveryTerms.CausesValidation = True
		Me.txtDeliveryTerms.Enabled = True
		Me.txtDeliveryTerms.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDeliveryTerms.HideSelection = True
		Me.txtDeliveryTerms.ReadOnly = False
		Me.txtDeliveryTerms.Maxlength = 0
		Me.txtDeliveryTerms.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDeliveryTerms.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDeliveryTerms.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDeliveryTerms.TabStop = True
		Me.txtDeliveryTerms.Visible = True
		Me.txtDeliveryTerms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDeliveryTerms.Name = "txtDeliveryTerms"
		Me.txtRemarks.AutoSize = False
		Me.txtRemarks.Size = New System.Drawing.Size(305, 25)
		Me.txtRemarks.Location = New System.Drawing.Point(80, 184)
		Me.txtRemarks.TabIndex = 16
		Me.txtRemarks.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRemarks.AcceptsReturn = True
		Me.txtRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRemarks.BackColor = System.Drawing.SystemColors.Window
		Me.txtRemarks.CausesValidation = True
		Me.txtRemarks.Enabled = True
		Me.txtRemarks.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRemarks.HideSelection = True
		Me.txtRemarks.ReadOnly = False
		Me.txtRemarks.Maxlength = 0
		Me.txtRemarks.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRemarks.MultiLine = False
		Me.txtRemarks.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRemarks.TabStop = True
		Me.txtRemarks.Visible = True
		Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRemarks.Name = "txtRemarks"
		Me.txtApprovedBy.AutoSize = False
		Me.txtApprovedBy.Size = New System.Drawing.Size(169, 25)
		Me.txtApprovedBy.Location = New System.Drawing.Point(472, 144)
		Me.txtApprovedBy.TabIndex = 14
		Me.txtApprovedBy.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtApprovedBy.AcceptsReturn = True
		Me.txtApprovedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtApprovedBy.BackColor = System.Drawing.SystemColors.Window
		Me.txtApprovedBy.CausesValidation = True
		Me.txtApprovedBy.Enabled = True
		Me.txtApprovedBy.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtApprovedBy.HideSelection = True
		Me.txtApprovedBy.ReadOnly = False
		Me.txtApprovedBy.Maxlength = 0
		Me.txtApprovedBy.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtApprovedBy.MultiLine = False
		Me.txtApprovedBy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtApprovedBy.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtApprovedBy.TabStop = True
		Me.txtApprovedBy.Visible = True
		Me.txtApprovedBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtApprovedBy.Name = "txtApprovedBy"
		Me.txtOrderedBy.AutoSize = False
		Me.txtOrderedBy.Size = New System.Drawing.Size(169, 25)
		Me.txtOrderedBy.Location = New System.Drawing.Point(472, 112)
		Me.txtOrderedBy.TabIndex = 12
		Me.txtOrderedBy.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtOrderedBy.AcceptsReturn = True
		Me.txtOrderedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtOrderedBy.BackColor = System.Drawing.SystemColors.Window
		Me.txtOrderedBy.CausesValidation = True
		Me.txtOrderedBy.Enabled = True
		Me.txtOrderedBy.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtOrderedBy.HideSelection = True
		Me.txtOrderedBy.ReadOnly = False
		Me.txtOrderedBy.Maxlength = 0
		Me.txtOrderedBy.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtOrderedBy.MultiLine = False
		Me.txtOrderedBy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtOrderedBy.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtOrderedBy.TabStop = True
		Me.txtOrderedBy.Visible = True
		Me.txtOrderedBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtOrderedBy.Name = "txtOrderedBy"
		Me.txtCostCenter.AutoSize = False
		Me.txtCostCenter.Size = New System.Drawing.Size(89, 25)
		Me.txtCostCenter.Location = New System.Drawing.Point(472, 80)
		Me.txtCostCenter.TabIndex = 10
		Me.txtCostCenter.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCostCenter.AcceptsReturn = True
		Me.txtCostCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCostCenter.BackColor = System.Drawing.SystemColors.Window
		Me.txtCostCenter.CausesValidation = True
		Me.txtCostCenter.Enabled = True
		Me.txtCostCenter.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCostCenter.HideSelection = True
		Me.txtCostCenter.ReadOnly = False
		Me.txtCostCenter.Maxlength = 0
		Me.txtCostCenter.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCostCenter.MultiLine = False
		Me.txtCostCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCostCenter.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCostCenter.TabStop = True
		Me.txtCostCenter.Visible = True
		Me.txtCostCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCostCenter.Name = "txtCostCenter"
		Me.txtReqOrderNo.AutoSize = False
		Me.txtReqOrderNo.Size = New System.Drawing.Size(89, 25)
		Me.txtReqOrderNo.Location = New System.Drawing.Point(472, 48)
		Me.txtReqOrderNo.TabIndex = 8
		Me.txtReqOrderNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtReqOrderNo.AcceptsReturn = True
		Me.txtReqOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtReqOrderNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtReqOrderNo.CausesValidation = True
		Me.txtReqOrderNo.Enabled = True
		Me.txtReqOrderNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtReqOrderNo.HideSelection = True
		Me.txtReqOrderNo.ReadOnly = False
		Me.txtReqOrderNo.Maxlength = 0
		Me.txtReqOrderNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtReqOrderNo.MultiLine = False
		Me.txtReqOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtReqOrderNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtReqOrderNo.TabStop = True
		Me.txtReqOrderNo.Visible = True
		Me.txtReqOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtReqOrderNo.Name = "txtReqOrderNo"
		Me.txtPONumber.AutoSize = False
		Me.txtPONumber.Size = New System.Drawing.Size(305, 25)
		Me.txtPONumber.Location = New System.Drawing.Point(80, 144)
		Me.txtPONumber.TabIndex = 5
		Me.txtPONumber.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPONumber.AcceptsReturn = True
		Me.txtPONumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPONumber.BackColor = System.Drawing.SystemColors.Window
		Me.txtPONumber.CausesValidation = True
		Me.txtPONumber.Enabled = True
		Me.txtPONumber.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPONumber.HideSelection = True
		Me.txtPONumber.ReadOnly = False
		Me.txtPONumber.Maxlength = 0
		Me.txtPONumber.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPONumber.MultiLine = False
		Me.txtPONumber.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPONumber.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPONumber.TabStop = True
		Me.txtPONumber.Visible = True
		Me.txtPONumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPONumber.Name = "txtPONumber"
		Me.txtAddress.AutoSize = False
		Me.txtAddress.Size = New System.Drawing.Size(305, 81)
		Me.txtAddress.Location = New System.Drawing.Point(80, 56)
		Me.txtAddress.MultiLine = True
		Me.txtAddress.TabIndex = 3
		Me.txtAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAddress.AcceptsReturn = True
		Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
		Me.txtAddress.CausesValidation = True
		Me.txtAddress.Enabled = True
		Me.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAddress.HideSelection = True
		Me.txtAddress.ReadOnly = False
		Me.txtAddress.Maxlength = 0
		Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAddress.TabStop = True
		Me.txtAddress.Visible = True
		Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAddress.Name = "txtAddress"
		Me.Label17.Text = "Unit Rate"
		Me.Label17.Size = New System.Drawing.Size(45, 13)
		Me.Label17.Location = New System.Drawing.Point(202, 288)
		Me.Label17.TabIndex = 37
		Me.Label17.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label17.BackColor = System.Drawing.SystemColors.Control
		Me.Label17.Enabled = True
		Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label17.UseMnemonic = True
		Me.Label17.Visible = True
		Me.Label17.AutoSize = True
		Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label17.Name = "Label17"
		Me.Label16.Text = "Cost Code"
		Me.Label16.Size = New System.Drawing.Size(50, 13)
		Me.Label16.Location = New System.Drawing.Point(8, 288)
		Me.Label16.TabIndex = 35
		Me.Label16.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label16.BackColor = System.Drawing.SystemColors.Control
		Me.Label16.Enabled = True
		Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label16.UseMnemonic = True
		Me.Label16.Visible = True
		Me.Label16.AutoSize = True
		Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label16.Name = "Label16"
		Me.Label15.Text = "Description"
		Me.Label15.Size = New System.Drawing.Size(53, 13)
		Me.Label15.Location = New System.Drawing.Point(8, 256)
		Me.Label15.TabIndex = 33
		Me.Label15.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label15.BackColor = System.Drawing.SystemColors.Control
		Me.Label15.Enabled = True
		Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label15.UseMnemonic = True
		Me.Label15.Visible = True
		Me.Label15.AutoSize = True
		Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label15.Name = "Label15"
		Me.Label14.Text = "UOM"
		Me.Label14.Size = New System.Drawing.Size(23, 13)
		Me.Label14.Location = New System.Drawing.Point(224, 224)
		Me.Label14.TabIndex = 31
		Me.Label14.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label14.BackColor = System.Drawing.SystemColors.Control
		Me.Label14.Enabled = True
		Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.UseMnemonic = True
		Me.Label14.Visible = True
		Me.Label14.AutoSize = True
		Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label14.Name = "Label14"
		Me.Label11.Text = "Quantity"
		Me.Label11.Size = New System.Drawing.Size(42, 13)
		Me.Label11.Location = New System.Drawing.Point(8, 224)
		Me.Label11.TabIndex = 29
		Me.Label11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.Enabled = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.Visible = True
		Me.Label11.AutoSize = True
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me.Label13.Text = "Delivery Point"
		Me.Label13.Size = New System.Drawing.Size(66, 13)
		Me.Label13.Location = New System.Drawing.Point(400, 224)
		Me.Label13.TabIndex = 26
		Me.Label13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label13.BackColor = System.Drawing.SystemColors.Control
		Me.Label13.Enabled = True
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label13.UseMnemonic = True
		Me.Label13.Visible = True
		Me.Label13.AutoSize = True
		Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label13.Name = "Label13"
		Me.Label12.Text = "Currency"
		Me.Label12.Size = New System.Drawing.Size(44, 13)
		Me.Label12.Location = New System.Drawing.Point(400, 184)
		Me.Label12.TabIndex = 23
		Me.Label12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label12.BackColor = System.Drawing.SystemColors.Control
		Me.Label12.Enabled = True
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.UseMnemonic = True
		Me.Label12.Visible = True
		Me.Label12.AutoSize = True
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.Name = "Label12"
		Me.Label10.Text = "MOB Details"
		Me.Label10.Size = New System.Drawing.Size(57, 13)
		Me.Label10.Location = New System.Drawing.Point(8, 320)
		Me.Label10.TabIndex = 17
		Me.Label10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = True
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Label9.Text = "Remarks"
		Me.Label9.Size = New System.Drawing.Size(41, 13)
		Me.Label9.Location = New System.Drawing.Point(8, 192)
		Me.Label9.TabIndex = 15
		Me.Label9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Label8.Text = "Approved By"
		Me.Label8.Size = New System.Drawing.Size(62, 13)
		Me.Label8.Location = New System.Drawing.Point(400, 152)
		Me.Label8.TabIndex = 13
		Me.Label8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Label7.Text = "Ordered By"
		Me.Label7.Size = New System.Drawing.Size(55, 13)
		Me.Label7.Location = New System.Drawing.Point(400, 120)
		Me.Label7.TabIndex = 11
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
		Me.Label6.Text = "Cost Center"
		Me.Label6.Size = New System.Drawing.Size(58, 13)
		Me.Label6.Location = New System.Drawing.Point(400, 88)
		Me.Label6.TabIndex = 9
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Label5.Text = "Req. Order # "
		Me.Label5.Size = New System.Drawing.Size(68, 13)
		Me.Label5.Location = New System.Drawing.Point(400, 56)
		Me.Label5.TabIndex = 7
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Label4.Text = "Date"
		Me.Label4.Size = New System.Drawing.Size(23, 13)
		Me.Label4.Location = New System.Drawing.Point(400, 24)
		Me.Label4.TabIndex = 6
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = True
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "SO. Number"
		Me.Label3.Size = New System.Drawing.Size(58, 13)
		Me.Label3.Location = New System.Drawing.Point(8, 152)
		Me.Label3.TabIndex = 4
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Label2.Text = "Address"
		Me.Label2.Size = New System.Drawing.Size(39, 13)
		Me.Label2.Location = New System.Drawing.Point(8, 64)
		Me.Label2.TabIndex = 2
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Label1.Text = "Vendor Name"
		Me.Label1.Size = New System.Drawing.Size(64, 13)
		Me.Label1.Location = New System.Drawing.Point(8, 24)
		Me.Label1.TabIndex = 1
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		CType(Me.dtpPODate, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(cmdPrint)
		Me.Controls.Add(cmdSave)
		Me.Controls.Add(cmdReset)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Text5)
		Me.Frame1.Controls.Add(Text4)
		Me.Frame1.Controls.Add(Text3)
		Me.Frame1.Controls.Add(Text2)
		Me.Frame1.Controls.Add(Text1)
		Me.Frame1.Controls.Add(cboDeliveryPoint)
		Me.Frame1.Controls.Add(cboVendorName)
		Me.Frame1.Controls.Add(txtCurrency)
		Me.Frame1.Controls.Add(dtpPODate)
		Me.Frame1.Controls.Add(txtDeliveryTerms)
		Me.Frame1.Controls.Add(txtRemarks)
		Me.Frame1.Controls.Add(txtApprovedBy)
		Me.Frame1.Controls.Add(txtOrderedBy)
		Me.Frame1.Controls.Add(txtCostCenter)
		Me.Frame1.Controls.Add(txtReqOrderNo)
		Me.Frame1.Controls.Add(txtPONumber)
		Me.Frame1.Controls.Add(txtAddress)
		Me.Frame1.Controls.Add(Label17)
		Me.Frame1.Controls.Add(Label16)
		Me.Frame1.Controls.Add(Label15)
		Me.Frame1.Controls.Add(Label14)
		Me.Frame1.Controls.Add(Label11)
		Me.Frame1.Controls.Add(Label13)
		Me.Frame1.Controls.Add(Label12)
		Me.Frame1.Controls.Add(Label10)
		Me.Frame1.Controls.Add(Label9)
		Me.Frame1.Controls.Add(Label8)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class