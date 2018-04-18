<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmNewUser
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
	Public WithEvents optAdministrator As System.Windows.Forms.RadioButton
	Public WithEvents optGeneralUser As System.Windows.Forms.RadioButton
	Public WithEvents txtDepartment As System.Windows.Forms.TextBox
	Public WithEvents txtUName As System.Windows.Forms.TextBox
	Public WithEvents lstsecurity As System.Windows.Forms.CheckedListBox
	Public WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
	Public WithEvents txtNewPassword As System.Windows.Forms.TextBox
	Public WithEvents txtUsername As System.Windows.Forms.TextBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents flxUsers As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents cmdClear As AxMSForms.AxCommandButton
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents CommandButton1 As AxMSForms.AxCommandButton
	Public WithEvents CmdDelete As AxMSForms.AxCommandButton
	Public WithEvents cmdExit As AxMSForms.AxCommandButton
	Public WithEvents cmdClose As AxMSForms.AxCommandButton
	Public WithEvents cmdSave As AxMSForms.AxCommandButton
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmNewUser))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.optAdministrator = New System.Windows.Forms.RadioButton
		Me.optGeneralUser = New System.Windows.Forms.RadioButton
		Me.txtDepartment = New System.Windows.Forms.TextBox
		Me.txtUName = New System.Windows.Forms.TextBox
		Me.lstsecurity = New System.Windows.Forms.CheckedListBox
		Me.txtConfirmPassword = New System.Windows.Forms.TextBox
		Me.txtNewPassword = New System.Windows.Forms.TextBox
		Me.txtUsername = New System.Windows.Forms.TextBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me._Label1_4 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me._Label1_0 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.flxUsers = New AxMSFlexGridLib.AxMSFlexGrid
		Me.cmdClear = New AxMSForms.AxCommandButton
		Me._Label1_1 = New System.Windows.Forms.Label
		Me.CommandButton1 = New AxMSForms.AxCommandButton
		Me.CmdDelete = New AxMSForms.AxCommandButton
		Me.cmdExit = New AxMSForms.AxCommandButton
		Me.cmdClose = New AxMSForms.AxCommandButton
		Me.cmdSave = New AxMSForms.AxCommandButton
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.Frame3.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.flxUsers, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdClear, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CommandButton1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CmdDelete, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdSave, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "User Management"
		Me.ClientSize = New System.Drawing.Size(779, 639)
		Me.Location = New System.Drawing.Point(4, 30)
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
		Me.Name = "frmNewUser"
		Me.Frame3.Text = "User Details"
		Me.Frame3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.Size = New System.Drawing.Size(489, 320)
		Me.Frame3.Location = New System.Drawing.Point(48, 24)
		Me.Frame3.TabIndex = 15
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Name = "Frame3"
		Me.optAdministrator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optAdministrator.Text = "Administrator"
		Me.optAdministrator.Size = New System.Drawing.Size(105, 33)
		Me.optAdministrator.Location = New System.Drawing.Point(152, 184)
		Me.optAdministrator.TabIndex = 5
		Me.optAdministrator.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optAdministrator.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optAdministrator.BackColor = System.Drawing.SystemColors.Control
		Me.optAdministrator.CausesValidation = True
		Me.optAdministrator.Enabled = True
		Me.optAdministrator.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optAdministrator.Cursor = System.Windows.Forms.Cursors.Default
		Me.optAdministrator.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optAdministrator.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optAdministrator.TabStop = True
		Me.optAdministrator.Checked = False
		Me.optAdministrator.Visible = True
		Me.optAdministrator.Name = "optAdministrator"
		Me.optGeneralUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optGeneralUser.Text = "General User"
		Me.optGeneralUser.Size = New System.Drawing.Size(113, 33)
		Me.optGeneralUser.Location = New System.Drawing.Point(264, 184)
		Me.optGeneralUser.TabIndex = 6
		Me.optGeneralUser.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optGeneralUser.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optGeneralUser.BackColor = System.Drawing.SystemColors.Control
		Me.optGeneralUser.CausesValidation = True
		Me.optGeneralUser.Enabled = True
		Me.optGeneralUser.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optGeneralUser.Cursor = System.Windows.Forms.Cursors.Default
		Me.optGeneralUser.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optGeneralUser.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optGeneralUser.TabStop = True
		Me.optGeneralUser.Checked = False
		Me.optGeneralUser.Visible = True
		Me.optGeneralUser.Name = "optGeneralUser"
		Me.txtDepartment.AutoSize = False
		Me.txtDepartment.ForeColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.txtDepartment.Size = New System.Drawing.Size(209, 21)
		Me.txtDepartment.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtDepartment.Location = New System.Drawing.Point(151, 88)
		Me.txtDepartment.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDepartment.TabIndex = 2
		Me.txtDepartment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDepartment.AcceptsReturn = True
		Me.txtDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDepartment.BackColor = System.Drawing.SystemColors.Window
		Me.txtDepartment.CausesValidation = True
		Me.txtDepartment.Enabled = True
		Me.txtDepartment.HideSelection = True
		Me.txtDepartment.ReadOnly = False
		Me.txtDepartment.Maxlength = 0
		Me.txtDepartment.MultiLine = False
		Me.txtDepartment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDepartment.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDepartment.TabStop = True
		Me.txtDepartment.Visible = True
		Me.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtDepartment.Name = "txtDepartment"
		Me.txtUName.AutoSize = False
		Me.txtUName.ForeColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.txtUName.Size = New System.Drawing.Size(209, 21)
		Me.txtUName.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtUName.Location = New System.Drawing.Point(151, 56)
		Me.txtUName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUName.TabIndex = 1
		Me.txtUName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUName.AcceptsReturn = True
		Me.txtUName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUName.BackColor = System.Drawing.SystemColors.Window
		Me.txtUName.CausesValidation = True
		Me.txtUName.Enabled = True
		Me.txtUName.HideSelection = True
		Me.txtUName.ReadOnly = False
		Me.txtUName.Maxlength = 0
		Me.txtUName.MultiLine = False
		Me.txtUName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUName.TabStop = True
		Me.txtUName.Visible = True
		Me.txtUName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtUName.Name = "txtUName"
		Me.lstsecurity.BackColor = System.Drawing.Color.White
		Me.lstsecurity.Size = New System.Drawing.Size(204, 79)
		Me.lstsecurity.Location = New System.Drawing.Point(151, 220)
		Me.lstsecurity.Items.AddRange(New Object(){"Application Administration", "Purchasing Transactions", "Invoice Log"})
		Me.lstsecurity.TabIndex = 7
		Me.lstsecurity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstsecurity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstsecurity.CausesValidation = True
		Me.lstsecurity.Enabled = True
		Me.lstsecurity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstsecurity.IntegralHeight = True
		Me.lstsecurity.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstsecurity.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstsecurity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstsecurity.Sorted = False
		Me.lstsecurity.TabStop = True
		Me.lstsecurity.Visible = True
		Me.lstsecurity.MultiColumn = False
		Me.lstsecurity.Name = "lstsecurity"
		Me.txtConfirmPassword.AutoSize = False
		Me.txtConfirmPassword.ForeColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.txtConfirmPassword.Size = New System.Drawing.Size(209, 21)
		Me.txtConfirmPassword.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtConfirmPassword.Location = New System.Drawing.Point(151, 156)
		Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtConfirmPassword.PasswordChar = ChrW(42)
		Me.txtConfirmPassword.TabIndex = 4
		Me.txtConfirmPassword.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtConfirmPassword.AcceptsReturn = True
		Me.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Window
		Me.txtConfirmPassword.CausesValidation = True
		Me.txtConfirmPassword.Enabled = True
		Me.txtConfirmPassword.HideSelection = True
		Me.txtConfirmPassword.ReadOnly = False
		Me.txtConfirmPassword.Maxlength = 0
		Me.txtConfirmPassword.MultiLine = False
		Me.txtConfirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtConfirmPassword.TabStop = True
		Me.txtConfirmPassword.Visible = True
		Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtConfirmPassword.Name = "txtConfirmPassword"
		Me.txtNewPassword.AutoSize = False
		Me.txtNewPassword.ForeColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.txtNewPassword.Size = New System.Drawing.Size(209, 21)
		Me.txtNewPassword.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtNewPassword.Location = New System.Drawing.Point(151, 124)
		Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNewPassword.PasswordChar = ChrW(42)
		Me.txtNewPassword.TabIndex = 3
		Me.txtNewPassword.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNewPassword.AcceptsReturn = True
		Me.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNewPassword.BackColor = System.Drawing.SystemColors.Window
		Me.txtNewPassword.CausesValidation = True
		Me.txtNewPassword.Enabled = True
		Me.txtNewPassword.HideSelection = True
		Me.txtNewPassword.ReadOnly = False
		Me.txtNewPassword.Maxlength = 0
		Me.txtNewPassword.MultiLine = False
		Me.txtNewPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNewPassword.TabStop = True
		Me.txtNewPassword.Visible = True
		Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtNewPassword.Name = "txtNewPassword"
		Me.txtUsername.AutoSize = False
		Me.txtUsername.ForeColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.txtUsername.Size = New System.Drawing.Size(209, 21)
		Me.txtUsername.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtUsername.Location = New System.Drawing.Point(151, 28)
		Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUsername.TabIndex = 0
		Me.txtUsername.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUsername.AcceptsReturn = True
		Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUsername.BackColor = System.Drawing.SystemColors.Window
		Me.txtUsername.CausesValidation = True
		Me.txtUsername.Enabled = True
		Me.txtUsername.HideSelection = True
		Me.txtUsername.ReadOnly = False
		Me.txtUsername.Maxlength = 0
		Me.txtUsername.MultiLine = False
		Me.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUsername.TabStop = True
		Me.txtUsername.Visible = True
		Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtUsername.Name = "txtUsername"
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Text = "Department"
		Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.Black
		Me.Label5.Size = New System.Drawing.Size(69, 13)
		Me.Label5.Location = New System.Drawing.Point(21, 92)
		Me.Label5.TabIndex = 22
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.Enabled = True
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = True
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Text = "Name"
		Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Black
		Me.Label3.Size = New System.Drawing.Size(32, 13)
		Me.Label3.Location = New System.Drawing.Point(21, 60)
		Me.Label3.TabIndex = 21
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = True
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me._Label1_4.Text = "Access Rights"
		Me._Label1_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_4.ForeColor = System.Drawing.Color.Black
		Me._Label1_4.Size = New System.Drawing.Size(78, 13)
		Me._Label1_4.Location = New System.Drawing.Point(21, 216)
		Me._Label1_4.TabIndex = 19
		Me._Label1_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_4.BackColor = System.Drawing.Color.Transparent
		Me._Label1_4.Enabled = True
		Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_4.UseMnemonic = True
		Me._Label1_4.Visible = True
		Me._Label1_4.AutoSize = True
		Me._Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_4.Name = "_Label1_4"
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Text = "Confirm  Password"
		Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.Black
		Me.Label4.Size = New System.Drawing.Size(104, 13)
		Me.Label4.Location = New System.Drawing.Point(21, 160)
		Me.Label4.TabIndex = 18
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.Enabled = True
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = True
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me._Label1_0.BackColor = System.Drawing.Color.Transparent
		Me._Label1_0.Text = "Password"
		Me._Label1_0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_0.ForeColor = System.Drawing.Color.Black
		Me._Label1_0.Size = New System.Drawing.Size(54, 13)
		Me._Label1_0.Location = New System.Drawing.Point(21, 128)
		Me._Label1_0.TabIndex = 17
		Me._Label1_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_0.Enabled = True
		Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_0.UseMnemonic = True
		Me._Label1_0.Visible = True
		Me._Label1_0.AutoSize = True
		Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_0.Name = "_Label1_0"
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Text = "User ID"
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Black
		Me.Label2.Size = New System.Drawing.Size(42, 13)
		Me.Label2.Location = New System.Drawing.Point(21, 32)
		Me.Label2.TabIndex = 16
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = True
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		flxUsers.OcxState = CType(resources.GetObject("flxUsers.OcxState"), System.Windows.Forms.AxHost.State)
		Me.flxUsers.Size = New System.Drawing.Size(489, 153)
		Me.flxUsers.Location = New System.Drawing.Point(48, 384)
		Me.flxUsers.TabIndex = 8
		Me.flxUsers.Name = "flxUsers"
		cmdClear.OcxState = CType(resources.GetObject("cmdClear.OcxState"), System.Windows.Forms.AxHost.State)
		Me.cmdClear.Size = New System.Drawing.Size(82, 33)
		Me.cmdClear.Location = New System.Drawing.Point(176, 552)
		Me.cmdClear.TabIndex = 9
		Me.cmdClear.Name = "cmdClear"
		Me._Label1_1.Text = "List of Existing Users"
		Me._Label1_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_1.ForeColor = System.Drawing.Color.Black
		Me._Label1_1.Size = New System.Drawing.Size(116, 13)
		Me._Label1_1.Location = New System.Drawing.Point(48, 368)
		Me._Label1_1.TabIndex = 20
		Me._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_1.BackColor = System.Drawing.Color.Transparent
		Me._Label1_1.Enabled = True
		Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_1.UseMnemonic = True
		Me._Label1_1.Visible = True
		Me._Label1_1.AutoSize = True
		Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_1.Name = "_Label1_1"
		CommandButton1.OcxState = CType(resources.GetObject("CommandButton1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CommandButton1.Size = New System.Drawing.Size(82, 33)
		Me.CommandButton1.Location = New System.Drawing.Point(264, 551)
		Me.CommandButton1.TabIndex = 10
		Me.CommandButton1.Name = "CommandButton1"
		CmdDelete.OcxState = CType(resources.GetObject("CmdDelete.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CmdDelete.Size = New System.Drawing.Size(82, 33)
		Me.CmdDelete.Location = New System.Drawing.Point(360, 552)
		Me.CmdDelete.TabIndex = 11
		Me.CmdDelete.Name = "CmdDelete"
		cmdExit.OcxState = CType(resources.GetObject("cmdExit.OcxState"), System.Windows.Forms.AxHost.State)
		Me.cmdExit.Size = New System.Drawing.Size(82, 33)
		Me.cmdExit.Location = New System.Drawing.Point(452, 551)
		Me.cmdExit.TabIndex = 12
		Me.cmdExit.Name = "cmdExit"
		cmdClose.OcxState = CType(resources.GetObject("cmdClose.OcxState"), System.Windows.Forms.AxHost.State)
		Me.cmdClose.Size = New System.Drawing.Size(33, 33)
		Me.cmdClose.Location = New System.Drawing.Point(232, 791)
		Me.cmdClose.TabIndex = 14
		Me.cmdClose.Name = "cmdClose"
		cmdSave.OcxState = CType(resources.GetObject("cmdSave.OcxState"), System.Windows.Forms.AxHost.State)
		Me.cmdSave.Size = New System.Drawing.Size(33, 33)
		Me.cmdSave.Location = New System.Drawing.Point(152, 791)
		Me.cmdSave.TabIndex = 13
		Me.cmdSave.Name = "cmdSave"
		Me.Label1.SetIndex(_Label1_4, CType(4, Short))
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		Me.Label1.SetIndex(_Label1_1, CType(1, Short))
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdSave, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CmdDelete, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CommandButton1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdClear, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.flxUsers, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(Frame3)
		Me.Controls.Add(flxUsers)
		Me.Controls.Add(cmdClear)
		Me.Controls.Add(_Label1_1)
		Me.Controls.Add(CommandButton1)
		Me.Controls.Add(CmdDelete)
		Me.Controls.Add(cmdExit)
		Me.Controls.Add(cmdClose)
		Me.Controls.Add(cmdSave)
		Me.Frame3.Controls.Add(optAdministrator)
		Me.Frame3.Controls.Add(optGeneralUser)
		Me.Frame3.Controls.Add(txtDepartment)
		Me.Frame3.Controls.Add(txtUName)
		Me.Frame3.Controls.Add(lstsecurity)
		Me.Frame3.Controls.Add(txtConfirmPassword)
		Me.Frame3.Controls.Add(txtNewPassword)
		Me.Frame3.Controls.Add(txtUsername)
		Me.Frame3.Controls.Add(Label5)
		Me.Frame3.Controls.Add(Label3)
		Me.Frame3.Controls.Add(_Label1_4)
		Me.Frame3.Controls.Add(Label4)
		Me.Frame3.Controls.Add(_Label1_0)
		Me.Frame3.Controls.Add(Label2)
		Me.Frame3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class