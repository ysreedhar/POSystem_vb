<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmVendor
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
	Public WithEvents txtVendorEmail As System.Windows.Forms.TextBox
	Public WithEvents txtVendorFirmName As System.Windows.Forms.TextBox
	Public WithEvents txtVendorAdd As System.Windows.Forms.TextBox
	Public WithEvents txtVendorPh As System.Windows.Forms.TextBox
	Public WithEvents txtVendorMob As System.Windows.Forms.TextBox
	Public WithEvents txtVendorZip As System.Windows.Forms.TextBox
	Public WithEvents txtVendorFax As System.Windows.Forms.TextBox
	Public WithEvents txtVendorName As System.Windows.Forms.TextBox
	Public WithEvents txtVendorCity As System.Windows.Forms.TextBox
	Public WithEvents txtVendorCountry As System.Windows.Forms.TextBox
	Public WithEvents TxtRegNo As System.Windows.Forms.TextBox
	Public WithEvents chkAVL As System.Windows.Forms.CheckBox
	Public WithEvents txtVendorCode As System.Windows.Forms.TextBox
	Public WithEvents cmdclosevendor As AxMSForms.AxCommandButton
	Public WithEvents cmdSaveVendor As AxMSForms.AxCommandButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents txtVendorId As System.Windows.Forms.TextBox
	Public WithEvents DTPicker1 As AxMSComCtl2.AxDTPicker
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents chkAVLM As System.Windows.Forms.CheckBox
	Public WithEvents txtVendorCodeM As System.Windows.Forms.TextBox
	Public WithEvents TxtRegNoM As System.Windows.Forms.TextBox
	Public WithEvents txtExVCountry As System.Windows.Forms.TextBox
	Public WithEvents txtExVCity As System.Windows.Forms.TextBox
	Public WithEvents txtExVName As System.Windows.Forms.TextBox
	Public WithEvents txtExVZip As System.Windows.Forms.TextBox
	Public WithEvents txtExVFax As System.Windows.Forms.TextBox
	Public WithEvents txtExVEmai As System.Windows.Forms.TextBox
	Public WithEvents txtExVMob As System.Windows.Forms.TextBox
	Public WithEvents txtExVPh As System.Windows.Forms.TextBox
	Public WithEvents txtExVAddress As System.Windows.Forms.TextBox
	Public WithEvents txtExVFirm As System.Windows.Forms.TextBox
	Public WithEvents txtExVID As System.Windows.Forms.TextBox
	Public WithEvents Label25 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents MSFlexGrid1 As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents cmdclose1 As AxMSForms.AxCommandButton
	Public WithEvents cmdExVenDelete As AxMSForms.AxCommandButton
	Public WithEvents cmdExVenSave As AxMSForms.AxCommandButton
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As System.Windows.Forms.TabControl
	Public WithEvents Vendor As System.Windows.Forms.Label
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Public WithEvents Image2 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVendor))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.SSTab1 = New System.Windows.Forms.TabControl
		Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.txtVendorEmail = New System.Windows.Forms.TextBox
		Me.txtVendorFirmName = New System.Windows.Forms.TextBox
		Me.txtVendorAdd = New System.Windows.Forms.TextBox
		Me.txtVendorPh = New System.Windows.Forms.TextBox
		Me.txtVendorMob = New System.Windows.Forms.TextBox
		Me.txtVendorZip = New System.Windows.Forms.TextBox
		Me.txtVendorFax = New System.Windows.Forms.TextBox
		Me.txtVendorName = New System.Windows.Forms.TextBox
		Me.txtVendorCity = New System.Windows.Forms.TextBox
		Me.txtVendorCountry = New System.Windows.Forms.TextBox
		Me.TxtRegNo = New System.Windows.Forms.TextBox
		Me.chkAVL = New System.Windows.Forms.CheckBox
		Me.txtVendorCode = New System.Windows.Forms.TextBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cmdclosevendor = New AxMSForms.AxCommandButton
		Me.cmdSaveVendor = New AxMSForms.AxCommandButton
		Me.txtVendorId = New System.Windows.Forms.TextBox
		Me.DTPicker1 = New AxMSComCtl2.AxDTPicker
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label24 = New System.Windows.Forms.Label
		Me.Label23 = New System.Windows.Forms.Label
		Me.Label17 = New System.Windows.Forms.Label
		Me.Label19 = New System.Windows.Forms.Label
		Me.Label18 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.chkAVLM = New System.Windows.Forms.CheckBox
		Me.txtVendorCodeM = New System.Windows.Forms.TextBox
		Me.TxtRegNoM = New System.Windows.Forms.TextBox
		Me.txtExVCountry = New System.Windows.Forms.TextBox
		Me.txtExVCity = New System.Windows.Forms.TextBox
		Me.txtExVName = New System.Windows.Forms.TextBox
		Me.txtExVZip = New System.Windows.Forms.TextBox
		Me.txtExVFax = New System.Windows.Forms.TextBox
		Me.txtExVEmai = New System.Windows.Forms.TextBox
		Me.txtExVMob = New System.Windows.Forms.TextBox
		Me.txtExVPh = New System.Windows.Forms.TextBox
		Me.txtExVAddress = New System.Windows.Forms.TextBox
		Me.txtExVFirm = New System.Windows.Forms.TextBox
		Me.txtExVID = New System.Windows.Forms.TextBox
		Me.Label25 = New System.Windows.Forms.Label
		Me.Label22 = New System.Windows.Forms.Label
		Me.Label21 = New System.Windows.Forms.Label
		Me.Label20 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.Label15 = New System.Windows.Forms.Label
		Me.Label16 = New System.Windows.Forms.Label
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me.MSFlexGrid1 = New AxMSFlexGridLib.AxMSFlexGrid
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.cmdclose1 = New AxMSForms.AxCommandButton
		Me.cmdExVenDelete = New AxMSForms.AxCommandButton
		Me.cmdExVenSave = New AxMSForms.AxCommandButton
		Me.Vendor = New System.Windows.Forms.Label
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.Image2 = New System.Windows.Forms.PictureBox
		Me.SSTab1.SuspendLayout()
		Me._SSTab1_TabPage0.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me._SSTab1_TabPage1.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me.Frame5.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.cmdclosevendor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdSaveVendor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MSFlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdclose1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdExVenDelete, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdExVenSave, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Vendor Management"
		Me.ClientSize = New System.Drawing.Size(749, 566)
		Me.Location = New System.Drawing.Point(8, 53)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.KeyPreview = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.Name = "frmVendor"
		Me.SSTab1.Size = New System.Drawing.Size(846, 562)
		Me.SSTab1.Location = New System.Drawing.Point(43, 44)
		Me.SSTab1.TabIndex = 14
		Me.SSTab1.SelectedIndex = 1
		Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
		Me.SSTab1.BackColor = System.Drawing.Color.FromARGB(224, 224, 224)
		Me.SSTab1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SSTab1.Name = "SSTab1"
		Me._SSTab1_TabPage0.Text = "Create New Vendor"
		Me.Frame1.Text = "  New Vendor Details  "
		Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.ForeColor = System.Drawing.Color.Black
		Me.Frame1.Size = New System.Drawing.Size(831, 520)
		Me.Frame1.Location = New System.Drawing.Point(1, 24)
		Me.Frame1.TabIndex = 32
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.txtVendorEmail.AutoSize = False
		Me.txtVendorEmail.Size = New System.Drawing.Size(192, 22)
		Me.txtVendorEmail.Location = New System.Drawing.Point(138, 485)
		Me.txtVendorEmail.Maxlength = 35
		Me.txtVendorEmail.TabIndex = 66
		Me.txtVendorEmail.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendorEmail.AcceptsReturn = True
		Me.txtVendorEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendorEmail.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendorEmail.CausesValidation = True
		Me.txtVendorEmail.Enabled = True
		Me.txtVendorEmail.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendorEmail.HideSelection = True
		Me.txtVendorEmail.ReadOnly = False
		Me.txtVendorEmail.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendorEmail.MultiLine = False
		Me.txtVendorEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendorEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendorEmail.TabStop = True
		Me.txtVendorEmail.Visible = True
		Me.txtVendorEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtVendorEmail.Name = "txtVendorEmail"
		Me.txtVendorFirmName.AutoSize = False
		Me.txtVendorFirmName.Size = New System.Drawing.Size(192, 22)
		Me.txtVendorFirmName.Location = New System.Drawing.Point(138, 14)
		Me.txtVendorFirmName.Maxlength = 75
		Me.txtVendorFirmName.TabIndex = 64
		Me.txtVendorFirmName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendorFirmName.AcceptsReturn = True
		Me.txtVendorFirmName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendorFirmName.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendorFirmName.CausesValidation = True
		Me.txtVendorFirmName.Enabled = True
		Me.txtVendorFirmName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendorFirmName.HideSelection = True
		Me.txtVendorFirmName.ReadOnly = False
		Me.txtVendorFirmName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendorFirmName.MultiLine = False
		Me.txtVendorFirmName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendorFirmName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendorFirmName.TabStop = True
		Me.txtVendorFirmName.Visible = True
		Me.txtVendorFirmName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtVendorFirmName.Name = "txtVendorFirmName"
		Me.txtVendorAdd.AutoSize = False
		Me.txtVendorAdd.Size = New System.Drawing.Size(192, 22)
		Me.txtVendorAdd.Location = New System.Drawing.Point(138, 158)
		Me.txtVendorAdd.Maxlength = 255
		Me.txtVendorAdd.TabIndex = 63
		Me.txtVendorAdd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendorAdd.AcceptsReturn = True
		Me.txtVendorAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendorAdd.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendorAdd.CausesValidation = True
		Me.txtVendorAdd.Enabled = True
		Me.txtVendorAdd.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendorAdd.HideSelection = True
		Me.txtVendorAdd.ReadOnly = False
		Me.txtVendorAdd.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendorAdd.MultiLine = False
		Me.txtVendorAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendorAdd.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendorAdd.TabStop = True
		Me.txtVendorAdd.Visible = True
		Me.txtVendorAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtVendorAdd.Name = "txtVendorAdd"
		Me.txtVendorPh.AutoSize = False
		Me.txtVendorPh.Size = New System.Drawing.Size(193, 22)
		Me.txtVendorPh.Location = New System.Drawing.Point(138, 345)
		Me.txtVendorPh.Maxlength = 20
		Me.txtVendorPh.TabIndex = 62
		Me.txtVendorPh.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendorPh.AcceptsReturn = True
		Me.txtVendorPh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendorPh.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendorPh.CausesValidation = True
		Me.txtVendorPh.Enabled = True
		Me.txtVendorPh.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendorPh.HideSelection = True
		Me.txtVendorPh.ReadOnly = False
		Me.txtVendorPh.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendorPh.MultiLine = False
		Me.txtVendorPh.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendorPh.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendorPh.TabStop = True
		Me.txtVendorPh.Visible = True
		Me.txtVendorPh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtVendorPh.Name = "txtVendorPh"
		Me.txtVendorMob.AutoSize = False
		Me.txtVendorMob.Size = New System.Drawing.Size(193, 22)
		Me.txtVendorMob.Location = New System.Drawing.Point(138, 391)
		Me.txtVendorMob.Maxlength = 20
		Me.txtVendorMob.TabIndex = 61
		Me.txtVendorMob.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendorMob.AcceptsReturn = True
		Me.txtVendorMob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendorMob.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendorMob.CausesValidation = True
		Me.txtVendorMob.Enabled = True
		Me.txtVendorMob.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendorMob.HideSelection = True
		Me.txtVendorMob.ReadOnly = False
		Me.txtVendorMob.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendorMob.MultiLine = False
		Me.txtVendorMob.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendorMob.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendorMob.TabStop = True
		Me.txtVendorMob.Visible = True
		Me.txtVendorMob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtVendorMob.Name = "txtVendorMob"
		Me.txtVendorZip.AutoSize = False
		Me.txtVendorZip.Size = New System.Drawing.Size(193, 22)
		Me.txtVendorZip.Location = New System.Drawing.Point(138, 251)
		Me.txtVendorZip.Maxlength = 15
		Me.txtVendorZip.TabIndex = 60
		Me.txtVendorZip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendorZip.AcceptsReturn = True
		Me.txtVendorZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendorZip.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendorZip.CausesValidation = True
		Me.txtVendorZip.Enabled = True
		Me.txtVendorZip.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendorZip.HideSelection = True
		Me.txtVendorZip.ReadOnly = False
		Me.txtVendorZip.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendorZip.MultiLine = False
		Me.txtVendorZip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendorZip.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendorZip.TabStop = True
		Me.txtVendorZip.Visible = True
		Me.txtVendorZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtVendorZip.Name = "txtVendorZip"
		Me.txtVendorFax.AutoSize = False
		Me.txtVendorFax.Size = New System.Drawing.Size(193, 22)
		Me.txtVendorFax.Location = New System.Drawing.Point(138, 438)
		Me.txtVendorFax.Maxlength = 20
		Me.txtVendorFax.TabIndex = 59
		Me.txtVendorFax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendorFax.AcceptsReturn = True
		Me.txtVendorFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendorFax.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendorFax.CausesValidation = True
		Me.txtVendorFax.Enabled = True
		Me.txtVendorFax.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendorFax.HideSelection = True
		Me.txtVendorFax.ReadOnly = False
		Me.txtVendorFax.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendorFax.MultiLine = False
		Me.txtVendorFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendorFax.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendorFax.TabStop = True
		Me.txtVendorFax.Visible = True
		Me.txtVendorFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtVendorFax.Name = "txtVendorFax"
		Me.txtVendorName.AutoSize = False
		Me.txtVendorName.Size = New System.Drawing.Size(193, 24)
		Me.txtVendorName.Location = New System.Drawing.Point(138, 109)
		Me.txtVendorName.Maxlength = 75
		Me.txtVendorName.TabIndex = 58
		Me.txtVendorName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendorName.AcceptsReturn = True
		Me.txtVendorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendorName.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendorName.CausesValidation = True
		Me.txtVendorName.Enabled = True
		Me.txtVendorName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendorName.HideSelection = True
		Me.txtVendorName.ReadOnly = False
		Me.txtVendorName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendorName.MultiLine = False
		Me.txtVendorName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendorName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendorName.TabStop = True
		Me.txtVendorName.Visible = True
		Me.txtVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtVendorName.Name = "txtVendorName"
		Me.txtVendorCity.AutoSize = False
		Me.txtVendorCity.Size = New System.Drawing.Size(193, 22)
		Me.txtVendorCity.Location = New System.Drawing.Point(138, 205)
		Me.txtVendorCity.Maxlength = 25
		Me.txtVendorCity.TabIndex = 57
		Me.txtVendorCity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendorCity.AcceptsReturn = True
		Me.txtVendorCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendorCity.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendorCity.CausesValidation = True
		Me.txtVendorCity.Enabled = True
		Me.txtVendorCity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendorCity.HideSelection = True
		Me.txtVendorCity.ReadOnly = False
		Me.txtVendorCity.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendorCity.MultiLine = False
		Me.txtVendorCity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendorCity.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendorCity.TabStop = True
		Me.txtVendorCity.Visible = True
		Me.txtVendorCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtVendorCity.Name = "txtVendorCity"
		Me.txtVendorCountry.AutoSize = False
		Me.txtVendorCountry.Size = New System.Drawing.Size(193, 22)
		Me.txtVendorCountry.Location = New System.Drawing.Point(138, 298)
		Me.txtVendorCountry.Maxlength = 25
		Me.txtVendorCountry.TabIndex = 56
		Me.txtVendorCountry.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendorCountry.AcceptsReturn = True
		Me.txtVendorCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendorCountry.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendorCountry.CausesValidation = True
		Me.txtVendorCountry.Enabled = True
		Me.txtVendorCountry.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendorCountry.HideSelection = True
		Me.txtVendorCountry.ReadOnly = False
		Me.txtVendorCountry.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendorCountry.MultiLine = False
		Me.txtVendorCountry.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendorCountry.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendorCountry.TabStop = True
		Me.txtVendorCountry.Visible = True
		Me.txtVendorCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtVendorCountry.Name = "txtVendorCountry"
		Me.TxtRegNo.AutoSize = False
		Me.TxtRegNo.Size = New System.Drawing.Size(193, 24)
		Me.TxtRegNo.Location = New System.Drawing.Point(138, 61)
		Me.TxtRegNo.Maxlength = 30
		Me.TxtRegNo.TabIndex = 55
		Me.TxtRegNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtRegNo.AcceptsReturn = True
		Me.TxtRegNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtRegNo.BackColor = System.Drawing.SystemColors.Window
		Me.TxtRegNo.CausesValidation = True
		Me.TxtRegNo.Enabled = True
		Me.TxtRegNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtRegNo.HideSelection = True
		Me.TxtRegNo.ReadOnly = False
		Me.TxtRegNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtRegNo.MultiLine = False
		Me.TxtRegNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtRegNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtRegNo.TabStop = True
		Me.TxtRegNo.Visible = True
		Me.TxtRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtRegNo.Name = "TxtRegNo"
		Me.chkAVL.Text = "AVL"
		Me.chkAVL.Size = New System.Drawing.Size(81, 33)
		Me.chkAVL.Location = New System.Drawing.Point(347, 80)
		Me.chkAVL.TabIndex = 51
		Me.chkAVL.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkAVL.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkAVL.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkAVL.BackColor = System.Drawing.SystemColors.Control
		Me.chkAVL.CausesValidation = True
		Me.chkAVL.Enabled = True
		Me.chkAVL.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkAVL.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAVL.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAVL.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAVL.TabStop = True
		Me.chkAVL.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAVL.Visible = True
		Me.chkAVL.Name = "chkAVL"
		Me.txtVendorCode.AutoSize = False
		Me.txtVendorCode.Size = New System.Drawing.Size(105, 24)
		Me.txtVendorCode.Location = New System.Drawing.Point(456, 48)
		Me.txtVendorCode.Maxlength = 30
		Me.txtVendorCode.TabIndex = 49
		Me.txtVendorCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendorCode.AcceptsReturn = True
		Me.txtVendorCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendorCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendorCode.CausesValidation = True
		Me.txtVendorCode.Enabled = True
		Me.txtVendorCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendorCode.HideSelection = True
		Me.txtVendorCode.ReadOnly = False
		Me.txtVendorCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendorCode.MultiLine = False
		Me.txtVendorCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendorCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendorCode.TabStop = True
		Me.txtVendorCode.Visible = True
		Me.txtVendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtVendorCode.Name = "txtVendorCode"
		Me.Frame2.Text = "  Options  "
		Me.Frame2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.ForeColor = System.Drawing.Color.Black
		Me.Frame2.Size = New System.Drawing.Size(151, 65)
		Me.Frame2.Location = New System.Drawing.Point(664, 440)
		Me.Frame2.TabIndex = 34
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		cmdclosevendor.OcxState = CType(resources.GetObject("cmdclosevendor.OcxState"), System.Windows.Forms.AxHost.State)
		Me.cmdclosevendor.Size = New System.Drawing.Size(65, 33)
		Me.cmdclosevendor.Location = New System.Drawing.Point(80, 16)
		Me.cmdclosevendor.TabIndex = 36
		Me.cmdclosevendor.Name = "cmdclosevendor"
		cmdSaveVendor.OcxState = CType(resources.GetObject("cmdSaveVendor.OcxState"), System.Windows.Forms.AxHost.State)
		Me.cmdSaveVendor.Size = New System.Drawing.Size(65, 33)
		Me.cmdSaveVendor.Location = New System.Drawing.Point(8, 16)
		Me.cmdSaveVendor.TabIndex = 35
		Me.cmdSaveVendor.Name = "cmdSaveVendor"
		Me.txtVendorId.AutoSize = False
		Me.txtVendorId.Enabled = False
		Me.txtVendorId.Size = New System.Drawing.Size(25, 25)
		Me.txtVendorId.Location = New System.Drawing.Point(611, 20)
		Me.txtVendorId.TabIndex = 33
		Me.txtVendorId.Visible = False
		Me.txtVendorId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendorId.AcceptsReturn = True
		Me.txtVendorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendorId.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendorId.CausesValidation = True
		Me.txtVendorId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendorId.HideSelection = True
		Me.txtVendorId.ReadOnly = False
		Me.txtVendorId.Maxlength = 0
		Me.txtVendorId.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendorId.MultiLine = False
		Me.txtVendorId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendorId.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendorId.TabStop = True
		Me.txtVendorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtVendorId.Name = "txtVendorId"
		DTPicker1.OcxState = CType(resources.GetObject("DTPicker1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPicker1.Size = New System.Drawing.Size(103, 22)
		Me.DTPicker1.Location = New System.Drawing.Point(456, 16)
		Me.DTPicker1.TabIndex = 37
		Me.DTPicker1.Name = "DTPicker1"
		Me.Label7.Text = "Email"
		Me.Label7.Size = New System.Drawing.Size(121, 17)
		Me.Label7.Location = New System.Drawing.Point(9, 488)
		Me.Label7.TabIndex = 65
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label24.Text = "Vendor Code"
		Me.Label24.Size = New System.Drawing.Size(62, 13)
		Me.Label24.Location = New System.Drawing.Point(347, 56)
		Me.Label24.TabIndex = 50
		Me.Label24.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label24.BackColor = System.Drawing.Color.Transparent
		Me.Label24.Enabled = True
		Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label24.UseMnemonic = True
		Me.Label24.Visible = True
		Me.Label24.AutoSize = True
		Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label24.Name = "Label24"
		Me.Label23.Text = "Supplier Since"
		Me.Label23.Size = New System.Drawing.Size(121, 17)
		Me.Label23.Location = New System.Drawing.Point(347, 16)
		Me.Label23.TabIndex = 48
		Me.Label23.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label23.BackColor = System.Drawing.Color.Transparent
		Me.Label23.Enabled = True
		Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label23.UseMnemonic = True
		Me.Label23.Visible = True
		Me.Label23.AutoSize = False
		Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label23.Name = "Label23"
		Me.Label17.Text = "Biz. Registration No."
		Me.Label17.Size = New System.Drawing.Size(98, 13)
		Me.Label17.Location = New System.Drawing.Point(9, 67)
		Me.Label17.TabIndex = 47
		Me.Label17.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label17.BackColor = System.Drawing.Color.Transparent
		Me.Label17.Enabled = True
		Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label17.UseMnemonic = True
		Me.Label17.Visible = True
		Me.Label17.AutoSize = True
		Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label17.Name = "Label17"
		Me.Label19.Text = "Country"
		Me.Label19.Size = New System.Drawing.Size(89, 17)
		Me.Label19.Location = New System.Drawing.Point(9, 301)
		Me.Label19.TabIndex = 46
		Me.Label19.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label19.BackColor = System.Drawing.Color.Transparent
		Me.Label19.Enabled = True
		Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label19.UseMnemonic = True
		Me.Label19.Visible = True
		Me.Label19.AutoSize = False
		Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label19.Name = "Label19"
		Me.Label18.Text = "City"
		Me.Label18.Size = New System.Drawing.Size(81, 17)
		Me.Label18.Location = New System.Drawing.Point(9, 208)
		Me.Label18.TabIndex = 45
		Me.Label18.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label18.BackColor = System.Drawing.Color.Transparent
		Me.Label18.Enabled = True
		Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label18.UseMnemonic = True
		Me.Label18.Visible = True
		Me.Label18.AutoSize = False
		Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label18.Name = "Label18"
		Me.Label8.Text = "Company / Firm Name"
		Me.Label8.Size = New System.Drawing.Size(154, 25)
		Me.Label8.Location = New System.Drawing.Point(9, 16)
		Me.Label8.TabIndex = 44
		Me.Label8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Label6.Text = "Fax"
		Me.Label6.Size = New System.Drawing.Size(129, 17)
		Me.Label6.Location = New System.Drawing.Point(9, 441)
		Me.Label6.TabIndex = 43
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label5.Text = "Pos Code"
		Me.Label5.Size = New System.Drawing.Size(121, 17)
		Me.Label5.Location = New System.Drawing.Point(9, 254)
		Me.Label5.TabIndex = 42
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.Text = "Mobile"
		Me.Label4.Size = New System.Drawing.Size(113, 25)
		Me.Label4.Location = New System.Drawing.Point(9, 390)
		Me.Label4.TabIndex = 41
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "Phone"
		Me.Label3.Size = New System.Drawing.Size(113, 25)
		Me.Label3.Location = New System.Drawing.Point(9, 344)
		Me.Label3.TabIndex = 40
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "Address"
		Me.Label2.Size = New System.Drawing.Size(121, 25)
		Me.Label2.Location = New System.Drawing.Point(9, 157)
		Me.Label2.TabIndex = 39
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Contact Person"
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Size = New System.Drawing.Size(137, 17)
		Me.Label1.Location = New System.Drawing.Point(9, 113)
		Me.Label1.TabIndex = 38
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me._SSTab1_TabPage1.Text = "List of Vendors/ Modify Vendor"
		Me.Frame4.Text = "  Details  "
		Me.Frame4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame4.ForeColor = System.Drawing.Color.Black
		Me.Frame4.Size = New System.Drawing.Size(710, 212)
		Me.Frame4.Location = New System.Drawing.Point(8, 336)
		Me.Frame4.TabIndex = 17
		Me.Frame4.BackColor = System.Drawing.SystemColors.Control
		Me.Frame4.Enabled = True
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Name = "Frame4"
		Me.chkAVLM.Text = "AVL"
		Me.chkAVLM.Size = New System.Drawing.Size(81, 33)
		Me.chkAVLM.Location = New System.Drawing.Point(488, 168)
		Me.chkAVLM.TabIndex = 54
		Me.chkAVLM.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkAVLM.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkAVLM.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkAVLM.BackColor = System.Drawing.SystemColors.Control
		Me.chkAVLM.CausesValidation = True
		Me.chkAVLM.Enabled = True
		Me.chkAVLM.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkAVLM.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAVLM.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAVLM.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAVLM.TabStop = True
		Me.chkAVLM.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAVLM.Visible = True
		Me.chkAVLM.Name = "chkAVLM"
		Me.txtVendorCodeM.AutoSize = False
		Me.txtVendorCodeM.Size = New System.Drawing.Size(105, 24)
		Me.txtVendorCodeM.Location = New System.Drawing.Point(488, 8)
		Me.txtVendorCodeM.Maxlength = 30
		Me.txtVendorCodeM.TabIndex = 52
		Me.txtVendorCodeM.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendorCodeM.AcceptsReturn = True
		Me.txtVendorCodeM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendorCodeM.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendorCodeM.CausesValidation = True
		Me.txtVendorCodeM.Enabled = True
		Me.txtVendorCodeM.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendorCodeM.HideSelection = True
		Me.txtVendorCodeM.ReadOnly = False
		Me.txtVendorCodeM.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendorCodeM.MultiLine = False
		Me.txtVendorCodeM.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendorCodeM.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendorCodeM.TabStop = True
		Me.txtVendorCodeM.Visible = True
		Me.txtVendorCodeM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtVendorCodeM.Name = "txtVendorCodeM"
		Me.TxtRegNoM.AutoSize = False
		Me.TxtRegNoM.Size = New System.Drawing.Size(145, 25)
		Me.TxtRegNoM.Location = New System.Drawing.Point(488, 42)
		Me.TxtRegNoM.Maxlength = 35
		Me.TxtRegNoM.TabIndex = 2
		Me.TxtRegNoM.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtRegNoM.AcceptsReturn = True
		Me.TxtRegNoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtRegNoM.BackColor = System.Drawing.SystemColors.Window
		Me.TxtRegNoM.CausesValidation = True
		Me.TxtRegNoM.Enabled = True
		Me.TxtRegNoM.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtRegNoM.HideSelection = True
		Me.TxtRegNoM.ReadOnly = False
		Me.TxtRegNoM.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtRegNoM.MultiLine = False
		Me.TxtRegNoM.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtRegNoM.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtRegNoM.TabStop = True
		Me.TxtRegNoM.Visible = True
		Me.TxtRegNoM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtRegNoM.Name = "TxtRegNoM"
		Me.txtExVCountry.AutoSize = False
		Me.txtExVCountry.Size = New System.Drawing.Size(113, 22)
		Me.txtExVCountry.Location = New System.Drawing.Point(488, 107)
		Me.txtExVCountry.Maxlength = 25
		Me.txtExVCountry.TabIndex = 5
		Me.txtExVCountry.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExVCountry.AcceptsReturn = True
		Me.txtExVCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExVCountry.BackColor = System.Drawing.SystemColors.Window
		Me.txtExVCountry.CausesValidation = True
		Me.txtExVCountry.Enabled = True
		Me.txtExVCountry.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExVCountry.HideSelection = True
		Me.txtExVCountry.ReadOnly = False
		Me.txtExVCountry.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExVCountry.MultiLine = False
		Me.txtExVCountry.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExVCountry.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExVCountry.TabStop = True
		Me.txtExVCountry.Visible = True
		Me.txtExVCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtExVCountry.Name = "txtExVCountry"
		Me.txtExVCity.AutoSize = False
		Me.txtExVCity.Size = New System.Drawing.Size(96, 22)
		Me.txtExVCity.Location = New System.Drawing.Point(104, 107)
		Me.txtExVCity.Maxlength = 25
		Me.txtExVCity.TabIndex = 4
		Me.txtExVCity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExVCity.AcceptsReturn = True
		Me.txtExVCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExVCity.BackColor = System.Drawing.SystemColors.Window
		Me.txtExVCity.CausesValidation = True
		Me.txtExVCity.Enabled = True
		Me.txtExVCity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExVCity.HideSelection = True
		Me.txtExVCity.ReadOnly = False
		Me.txtExVCity.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExVCity.MultiLine = False
		Me.txtExVCity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExVCity.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExVCity.TabStop = True
		Me.txtExVCity.Visible = True
		Me.txtExVCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtExVCity.Name = "txtExVCity"
		Me.txtExVName.AutoSize = False
		Me.txtExVName.Size = New System.Drawing.Size(259, 22)
		Me.txtExVName.Location = New System.Drawing.Point(104, 43)
		Me.txtExVName.Maxlength = 75
		Me.txtExVName.TabIndex = 1
		Me.txtExVName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExVName.AcceptsReturn = True
		Me.txtExVName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExVName.BackColor = System.Drawing.SystemColors.Window
		Me.txtExVName.CausesValidation = True
		Me.txtExVName.Enabled = True
		Me.txtExVName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExVName.HideSelection = True
		Me.txtExVName.ReadOnly = False
		Me.txtExVName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExVName.MultiLine = False
		Me.txtExVName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExVName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExVName.TabStop = True
		Me.txtExVName.Visible = True
		Me.txtExVName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtExVName.Name = "txtExVName"
		Me.txtExVZip.AutoSize = False
		Me.txtExVZip.Size = New System.Drawing.Size(115, 22)
		Me.txtExVZip.Location = New System.Drawing.Point(251, 107)
		Me.txtExVZip.Maxlength = 15
		Me.txtExVZip.TabIndex = 6
		Me.txtExVZip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExVZip.AcceptsReturn = True
		Me.txtExVZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExVZip.BackColor = System.Drawing.SystemColors.Window
		Me.txtExVZip.CausesValidation = True
		Me.txtExVZip.Enabled = True
		Me.txtExVZip.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExVZip.HideSelection = True
		Me.txtExVZip.ReadOnly = False
		Me.txtExVZip.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExVZip.MultiLine = False
		Me.txtExVZip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExVZip.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExVZip.TabStop = True
		Me.txtExVZip.Visible = True
		Me.txtExVZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtExVZip.Name = "txtExVZip"
		Me.txtExVFax.AutoSize = False
		Me.txtExVFax.Size = New System.Drawing.Size(115, 22)
		Me.txtExVFax.Location = New System.Drawing.Point(488, 140)
		Me.txtExVFax.Maxlength = 20
		Me.txtExVFax.TabIndex = 9
		Me.txtExVFax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExVFax.AcceptsReturn = True
		Me.txtExVFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExVFax.BackColor = System.Drawing.SystemColors.Window
		Me.txtExVFax.CausesValidation = True
		Me.txtExVFax.Enabled = True
		Me.txtExVFax.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExVFax.HideSelection = True
		Me.txtExVFax.ReadOnly = False
		Me.txtExVFax.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExVFax.MultiLine = False
		Me.txtExVFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExVFax.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExVFax.TabStop = True
		Me.txtExVFax.Visible = True
		Me.txtExVFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtExVFax.Name = "txtExVFax"
		Me.txtExVEmai.AutoSize = False
		Me.txtExVEmai.Size = New System.Drawing.Size(267, 22)
		Me.txtExVEmai.Location = New System.Drawing.Point(104, 171)
		Me.txtExVEmai.TabIndex = 10
		Me.txtExVEmai.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExVEmai.AcceptsReturn = True
		Me.txtExVEmai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExVEmai.BackColor = System.Drawing.SystemColors.Window
		Me.txtExVEmai.CausesValidation = True
		Me.txtExVEmai.Enabled = True
		Me.txtExVEmai.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExVEmai.HideSelection = True
		Me.txtExVEmai.ReadOnly = False
		Me.txtExVEmai.Maxlength = 0
		Me.txtExVEmai.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExVEmai.MultiLine = False
		Me.txtExVEmai.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExVEmai.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExVEmai.TabStop = True
		Me.txtExVEmai.Visible = True
		Me.txtExVEmai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtExVEmai.Name = "txtExVEmai"
		Me.txtExVMob.AutoSize = False
		Me.txtExVMob.Size = New System.Drawing.Size(108, 22)
		Me.txtExVMob.Location = New System.Drawing.Point(255, 139)
		Me.txtExVMob.Maxlength = 20
		Me.txtExVMob.TabIndex = 8
		Me.txtExVMob.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExVMob.AcceptsReturn = True
		Me.txtExVMob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExVMob.BackColor = System.Drawing.SystemColors.Window
		Me.txtExVMob.CausesValidation = True
		Me.txtExVMob.Enabled = True
		Me.txtExVMob.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExVMob.HideSelection = True
		Me.txtExVMob.ReadOnly = False
		Me.txtExVMob.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExVMob.MultiLine = False
		Me.txtExVMob.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExVMob.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExVMob.TabStop = True
		Me.txtExVMob.Visible = True
		Me.txtExVMob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtExVMob.Name = "txtExVMob"
		Me.txtExVPh.AutoSize = False
		Me.txtExVPh.Size = New System.Drawing.Size(97, 22)
		Me.txtExVPh.Location = New System.Drawing.Point(104, 139)
		Me.txtExVPh.Maxlength = 20
		Me.txtExVPh.TabIndex = 7
		Me.txtExVPh.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExVPh.AcceptsReturn = True
		Me.txtExVPh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExVPh.BackColor = System.Drawing.SystemColors.Window
		Me.txtExVPh.CausesValidation = True
		Me.txtExVPh.Enabled = True
		Me.txtExVPh.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExVPh.HideSelection = True
		Me.txtExVPh.ReadOnly = False
		Me.txtExVPh.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExVPh.MultiLine = False
		Me.txtExVPh.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExVPh.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExVPh.TabStop = True
		Me.txtExVPh.Visible = True
		Me.txtExVPh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtExVPh.Name = "txtExVPh"
		Me.txtExVAddress.AutoSize = False
		Me.txtExVAddress.Size = New System.Drawing.Size(259, 22)
		Me.txtExVAddress.Location = New System.Drawing.Point(104, 75)
		Me.txtExVAddress.Maxlength = 255
		Me.txtExVAddress.TabIndex = 3
		Me.txtExVAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExVAddress.AcceptsReturn = True
		Me.txtExVAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExVAddress.BackColor = System.Drawing.SystemColors.Window
		Me.txtExVAddress.CausesValidation = True
		Me.txtExVAddress.Enabled = True
		Me.txtExVAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExVAddress.HideSelection = True
		Me.txtExVAddress.ReadOnly = False
		Me.txtExVAddress.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExVAddress.MultiLine = False
		Me.txtExVAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExVAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExVAddress.TabStop = True
		Me.txtExVAddress.Visible = True
		Me.txtExVAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtExVAddress.Name = "txtExVAddress"
		Me.txtExVFirm.AutoSize = False
		Me.txtExVFirm.Size = New System.Drawing.Size(259, 22)
		Me.txtExVFirm.Location = New System.Drawing.Point(104, 11)
		Me.txtExVFirm.Maxlength = 75
		Me.txtExVFirm.TabIndex = 0
		Me.txtExVFirm.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExVFirm.AcceptsReturn = True
		Me.txtExVFirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExVFirm.BackColor = System.Drawing.SystemColors.Window
		Me.txtExVFirm.CausesValidation = True
		Me.txtExVFirm.Enabled = True
		Me.txtExVFirm.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExVFirm.HideSelection = True
		Me.txtExVFirm.ReadOnly = False
		Me.txtExVFirm.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExVFirm.MultiLine = False
		Me.txtExVFirm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExVFirm.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExVFirm.TabStop = True
		Me.txtExVFirm.Visible = True
		Me.txtExVFirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtExVFirm.Name = "txtExVFirm"
		Me.txtExVID.AutoSize = False
		Me.txtExVID.Enabled = False
		Me.txtExVID.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExVID.Size = New System.Drawing.Size(25, 25)
		Me.txtExVID.Location = New System.Drawing.Point(384, 171)
		Me.txtExVID.TabIndex = 15
		Me.txtExVID.Visible = False
		Me.txtExVID.AcceptsReturn = True
		Me.txtExVID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExVID.BackColor = System.Drawing.SystemColors.Window
		Me.txtExVID.CausesValidation = True
		Me.txtExVID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExVID.HideSelection = True
		Me.txtExVID.ReadOnly = False
		Me.txtExVID.Maxlength = 0
		Me.txtExVID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExVID.MultiLine = False
		Me.txtExVID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExVID.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExVID.TabStop = True
		Me.txtExVID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtExVID.Name = "txtExVID"
		Me.Label25.Text = "Vendor Code"
		Me.Label25.Size = New System.Drawing.Size(62, 13)
		Me.Label25.Location = New System.Drawing.Point(424, 16)
		Me.Label25.TabIndex = 53
		Me.Label25.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label25.BackColor = System.Drawing.Color.Transparent
		Me.Label25.Enabled = True
		Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label25.UseMnemonic = True
		Me.Label25.Visible = True
		Me.Label25.AutoSize = True
		Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label25.Name = "Label25"
		Me.Label22.Text = "Biz. Registration No."
		Me.Label22.Size = New System.Drawing.Size(98, 13)
		Me.Label22.Location = New System.Drawing.Point(388, 48)
		Me.Label22.TabIndex = 31
		Me.Label22.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label22.BackColor = System.Drawing.Color.Transparent
		Me.Label22.Enabled = True
		Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label22.UseMnemonic = True
		Me.Label22.Visible = True
		Me.Label22.AutoSize = True
		Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label22.Name = "Label22"
		Me.Label21.Text = "Country"
		Me.Label21.Size = New System.Drawing.Size(49, 17)
		Me.Label21.Location = New System.Drawing.Point(437, 109)
		Me.Label21.TabIndex = 27
		Me.Label21.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label21.BackColor = System.Drawing.Color.Transparent
		Me.Label21.Enabled = True
		Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label21.UseMnemonic = True
		Me.Label21.Visible = True
		Me.Label21.AutoSize = False
		Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label21.Name = "Label21"
		Me.Label20.Text = "City"
		Me.Label20.Size = New System.Drawing.Size(81, 17)
		Me.Label20.Location = New System.Drawing.Point(8, 115)
		Me.Label20.TabIndex = 26
		Me.Label20.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label20.BackColor = System.Drawing.Color.Transparent
		Me.Label20.Enabled = True
		Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label20.UseMnemonic = True
		Me.Label20.Visible = True
		Me.Label20.AutoSize = False
		Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label20.Name = "Label20"
		Me.Label9.Text = "Company / Firm"
		Me.Label9.Size = New System.Drawing.Size(89, 25)
		Me.Label9.Location = New System.Drawing.Point(8, 20)
		Me.Label9.TabIndex = 25
		Me.Label9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label10.Text = "Contact Person"
		Me.Label10.Size = New System.Drawing.Size(97, 17)
		Me.Label10.Location = New System.Drawing.Point(8, 51)
		Me.Label10.TabIndex = 24
		Me.Label10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.BackColor = System.Drawing.Color.Transparent
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Label11.Text = "Email"
		Me.Label11.Size = New System.Drawing.Size(65, 17)
		Me.Label11.Location = New System.Drawing.Point(8, 179)
		Me.Label11.TabIndex = 23
		Me.Label11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label11.BackColor = System.Drawing.Color.Transparent
		Me.Label11.Enabled = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.Visible = True
		Me.Label11.AutoSize = False
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me.Label12.Text = "Pos Code"
		Me.Label12.Size = New System.Drawing.Size(45, 13)
		Me.Label12.Location = New System.Drawing.Point(205, 111)
		Me.Label12.TabIndex = 22
		Me.Label12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Enabled = True
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.UseMnemonic = True
		Me.Label12.Visible = True
		Me.Label12.AutoSize = True
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.Name = "Label12"
		Me.Label13.Text = "Phone"
		Me.Label13.Size = New System.Drawing.Size(73, 17)
		Me.Label13.Location = New System.Drawing.Point(8, 147)
		Me.Label13.TabIndex = 21
		Me.Label13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label13.BackColor = System.Drawing.Color.Transparent
		Me.Label13.Enabled = True
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label13.UseMnemonic = True
		Me.Label13.Visible = True
		Me.Label13.AutoSize = False
		Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label13.Name = "Label13"
		Me.Label14.Text = "Address"
		Me.Label14.Size = New System.Drawing.Size(57, 17)
		Me.Label14.Location = New System.Drawing.Point(8, 83)
		Me.Label14.TabIndex = 20
		Me.Label14.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label14.BackColor = System.Drawing.Color.Transparent
		Me.Label14.Enabled = True
		Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.UseMnemonic = True
		Me.Label14.Visible = True
		Me.Label14.AutoSize = False
		Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label14.Name = "Label14"
		Me.Label15.Text = "Mobile"
		Me.Label15.Size = New System.Drawing.Size(41, 17)
		Me.Label15.Location = New System.Drawing.Point(212, 144)
		Me.Label15.TabIndex = 19
		Me.Label15.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label15.BackColor = System.Drawing.Color.Transparent
		Me.Label15.Enabled = True
		Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label15.UseMnemonic = True
		Me.Label15.Visible = True
		Me.Label15.AutoSize = False
		Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label15.Name = "Label15"
		Me.Label16.Text = "Fax"
		Me.Label16.Size = New System.Drawing.Size(33, 17)
		Me.Label16.Location = New System.Drawing.Point(453, 144)
		Me.Label16.TabIndex = 18
		Me.Label16.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label16.BackColor = System.Drawing.Color.Transparent
		Me.Label16.Enabled = True
		Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label16.UseMnemonic = True
		Me.Label16.Visible = True
		Me.Label16.AutoSize = False
		Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label16.Name = "Label16"
		Me.Frame5.Text = "  Existing Vendor Details  "
		Me.Frame5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame5.ForeColor = System.Drawing.Color.Black
		Me.Frame5.Size = New System.Drawing.Size(829, 308)
		Me.Frame5.Location = New System.Drawing.Point(4, 21)
		Me.Frame5.TabIndex = 28
		Me.Frame5.BackColor = System.Drawing.SystemColors.Control
		Me.Frame5.Enabled = True
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Name = "Frame5"
		MSFlexGrid1.OcxState = CType(resources.GetObject("MSFlexGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.MSFlexGrid1.Size = New System.Drawing.Size(808, 267)
		Me.MSFlexGrid1.Location = New System.Drawing.Point(9, 24)
		Me.MSFlexGrid1.TabIndex = 16
		Me.MSFlexGrid1.Name = "MSFlexGrid1"
		Me.Frame3.Text = "  Options  "
		Me.Frame3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.ForeColor = System.Drawing.Color.Black
		Me.Frame3.Size = New System.Drawing.Size(104, 214)
		Me.Frame3.Location = New System.Drawing.Point(728, 336)
		Me.Frame3.TabIndex = 29
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Name = "Frame3"
		cmdclose1.OcxState = CType(resources.GetObject("cmdclose1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.cmdclose1.Size = New System.Drawing.Size(65, 33)
		Me.cmdclose1.Location = New System.Drawing.Point(23, 105)
		Me.cmdclose1.TabIndex = 13
		Me.cmdclose1.Name = "cmdclose1"
		cmdExVenDelete.OcxState = CType(resources.GetObject("cmdExVenDelete.OcxState"), System.Windows.Forms.AxHost.State)
		Me.cmdExVenDelete.Size = New System.Drawing.Size(65, 33)
		Me.cmdExVenDelete.Location = New System.Drawing.Point(24, 65)
		Me.cmdExVenDelete.TabIndex = 12
		Me.cmdExVenDelete.Name = "cmdExVenDelete"
		cmdExVenSave.OcxState = CType(resources.GetObject("cmdExVenSave.OcxState"), System.Windows.Forms.AxHost.State)
		Me.cmdExVenSave.Size = New System.Drawing.Size(65, 33)
		Me.cmdExVenSave.Location = New System.Drawing.Point(24, 24)
		Me.cmdExVenSave.TabIndex = 11
		Me.cmdExVenSave.Name = "cmdExVenSave"
		Me.Vendor.Text = "Vendor Management"
		Me.Vendor.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Vendor.ForeColor = System.Drawing.Color.Black
		Me.Vendor.Size = New System.Drawing.Size(195, 25)
		Me.Vendor.Location = New System.Drawing.Point(277, 12)
		Me.Vendor.TabIndex = 30
		Me.Vendor.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Vendor.BackColor = System.Drawing.Color.Transparent
		Me.Vendor.Enabled = True
		Me.Vendor.Cursor = System.Windows.Forms.Cursors.Default
		Me.Vendor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Vendor.UseMnemonic = True
		Me.Vendor.Visible = True
		Me.Vendor.AutoSize = True
		Me.Vendor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Vendor.Name = "Vendor"
		Me.Image1.Size = New System.Drawing.Size(155, 33)
		Me.Image1.Location = New System.Drawing.Point(435, 444)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Image2.Size = New System.Drawing.Size(59, 22)
		Me.Image2.Location = New System.Drawing.Point(603, 454)
		Me.Image2.Enabled = True
		Me.Image2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Image2.Visible = True
		Me.Image2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image2.Name = "Image2"
		CType(Me.cmdExVenSave, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdExVenDelete, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdclose1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MSFlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdSaveVendor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdclosevendor, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(SSTab1)
		Me.Controls.Add(Vendor)
		Me.Controls.Add(Image1)
		Me.Controls.Add(Image2)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage0)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage1)
		Me._SSTab1_TabPage0.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(txtVendorEmail)
		Me.Frame1.Controls.Add(txtVendorFirmName)
		Me.Frame1.Controls.Add(txtVendorAdd)
		Me.Frame1.Controls.Add(txtVendorPh)
		Me.Frame1.Controls.Add(txtVendorMob)
		Me.Frame1.Controls.Add(txtVendorZip)
		Me.Frame1.Controls.Add(txtVendorFax)
		Me.Frame1.Controls.Add(txtVendorName)
		Me.Frame1.Controls.Add(txtVendorCity)
		Me.Frame1.Controls.Add(txtVendorCountry)
		Me.Frame1.Controls.Add(TxtRegNo)
		Me.Frame1.Controls.Add(chkAVL)
		Me.Frame1.Controls.Add(txtVendorCode)
		Me.Frame1.Controls.Add(Frame2)
		Me.Frame1.Controls.Add(txtVendorId)
		Me.Frame1.Controls.Add(DTPicker1)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(Label24)
		Me.Frame1.Controls.Add(Label23)
		Me.Frame1.Controls.Add(Label17)
		Me.Frame1.Controls.Add(Label19)
		Me.Frame1.Controls.Add(Label18)
		Me.Frame1.Controls.Add(Label8)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame2.Controls.Add(cmdclosevendor)
		Me.Frame2.Controls.Add(cmdSaveVendor)
		Me._SSTab1_TabPage1.Controls.Add(Frame4)
		Me._SSTab1_TabPage1.Controls.Add(Frame5)
		Me._SSTab1_TabPage1.Controls.Add(Frame3)
		Me.Frame4.Controls.Add(chkAVLM)
		Me.Frame4.Controls.Add(txtVendorCodeM)
		Me.Frame4.Controls.Add(TxtRegNoM)
		Me.Frame4.Controls.Add(txtExVCountry)
		Me.Frame4.Controls.Add(txtExVCity)
		Me.Frame4.Controls.Add(txtExVName)
		Me.Frame4.Controls.Add(txtExVZip)
		Me.Frame4.Controls.Add(txtExVFax)
		Me.Frame4.Controls.Add(txtExVEmai)
		Me.Frame4.Controls.Add(txtExVMob)
		Me.Frame4.Controls.Add(txtExVPh)
		Me.Frame4.Controls.Add(txtExVAddress)
		Me.Frame4.Controls.Add(txtExVFirm)
		Me.Frame4.Controls.Add(txtExVID)
		Me.Frame4.Controls.Add(Label25)
		Me.Frame4.Controls.Add(Label22)
		Me.Frame4.Controls.Add(Label21)
		Me.Frame4.Controls.Add(Label20)
		Me.Frame4.Controls.Add(Label9)
		Me.Frame4.Controls.Add(Label10)
		Me.Frame4.Controls.Add(Label11)
		Me.Frame4.Controls.Add(Label12)
		Me.Frame4.Controls.Add(Label13)
		Me.Frame4.Controls.Add(Label14)
		Me.Frame4.Controls.Add(Label15)
		Me.Frame4.Controls.Add(Label16)
		Me.Frame5.Controls.Add(MSFlexGrid1)
		Me.Frame3.Controls.Add(cmdclose1)
		Me.Frame3.Controls.Add(cmdExVenDelete)
		Me.Frame3.Controls.Add(cmdExVenSave)
		Me.SSTab1.ResumeLayout(False)
		Me._SSTab1_TabPage0.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me._SSTab1_TabPage1.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me.Frame5.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class