<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDeliveryPointMgmt
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
	Public WithEvents cmdClear As System.Windows.Forms.Button
	Public WithEvents cmdDelete As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents txtDPAddress As System.Windows.Forms.TextBox
	Public WithEvents txtDPName As System.Windows.Forms.TextBox
	Public WithEvents flxDeliveryPoints As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDeliveryPointMgmt))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdClear = New System.Windows.Forms.Button
		Me.cmdDelete = New System.Windows.Forms.Button
		Me.cmdSave = New System.Windows.Forms.Button
		Me.txtDPAddress = New System.Windows.Forms.TextBox
		Me.txtDPName = New System.Windows.Forms.TextBox
		Me.flxDeliveryPoints = New AxMSFlexGridLib.AxMSFlexGrid
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.flxDeliveryPoints, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Delivery Point Management"
		Me.ClientSize = New System.Drawing.Size(670, 445)
		Me.Location = New System.Drawing.Point(4, 30)
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
		Me.Name = "frmDeliveryPointMgmt"
		Me.cmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClear.Text = "Clear"
		Me.cmdClear.Size = New System.Drawing.Size(81, 33)
		Me.cmdClear.Location = New System.Drawing.Point(488, 120)
		Me.cmdClear.TabIndex = 8
		Me.cmdClear.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClear.CausesValidation = True
		Me.cmdClear.Enabled = True
		Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClear.TabStop = True
		Me.cmdClear.Name = "cmdClear"
		Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDelete.Text = "Delete"
		Me.cmdDelete.Size = New System.Drawing.Size(81, 33)
		Me.cmdDelete.Location = New System.Drawing.Point(488, 72)
		Me.cmdDelete.TabIndex = 6
		Me.cmdDelete.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDelete.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDelete.CausesValidation = True
		Me.cmdDelete.Enabled = True
		Me.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDelete.TabStop = True
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSave.Text = "Save"
		Me.cmdSave.Size = New System.Drawing.Size(81, 33)
		Me.cmdSave.Location = New System.Drawing.Point(488, 24)
		Me.cmdSave.TabIndex = 5
		Me.cmdSave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Enabled = True
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.TabStop = True
		Me.cmdSave.Name = "cmdSave"
		Me.txtDPAddress.AutoSize = False
		Me.txtDPAddress.Size = New System.Drawing.Size(281, 73)
		Me.txtDPAddress.Location = New System.Drawing.Point(144, 64)
		Me.txtDPAddress.TabIndex = 2
		Me.txtDPAddress.Text = " "
		Me.txtDPAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDPAddress.AcceptsReturn = True
		Me.txtDPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDPAddress.BackColor = System.Drawing.SystemColors.Window
		Me.txtDPAddress.CausesValidation = True
		Me.txtDPAddress.Enabled = True
		Me.txtDPAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDPAddress.HideSelection = True
		Me.txtDPAddress.ReadOnly = False
		Me.txtDPAddress.Maxlength = 0
		Me.txtDPAddress.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDPAddress.MultiLine = False
		Me.txtDPAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDPAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDPAddress.TabStop = True
		Me.txtDPAddress.Visible = True
		Me.txtDPAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDPAddress.Name = "txtDPAddress"
		Me.txtDPName.AutoSize = False
		Me.txtDPName.Size = New System.Drawing.Size(281, 25)
		Me.txtDPName.Location = New System.Drawing.Point(144, 24)
		Me.txtDPName.TabIndex = 1
		Me.txtDPName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDPName.AcceptsReturn = True
		Me.txtDPName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDPName.BackColor = System.Drawing.SystemColors.Window
		Me.txtDPName.CausesValidation = True
		Me.txtDPName.Enabled = True
		Me.txtDPName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDPName.HideSelection = True
		Me.txtDPName.ReadOnly = False
		Me.txtDPName.Maxlength = 0
		Me.txtDPName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDPName.MultiLine = False
		Me.txtDPName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDPName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDPName.TabStop = True
		Me.txtDPName.Visible = True
		Me.txtDPName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDPName.Name = "txtDPName"
		flxDeliveryPoints.OcxState = CType(resources.GetObject("flxDeliveryPoints.OcxState"), System.Windows.Forms.AxHost.State)
		Me.flxDeliveryPoints.Size = New System.Drawing.Size(537, 241)
		Me.flxDeliveryPoints.Location = New System.Drawing.Point(32, 176)
		Me.flxDeliveryPoints.TabIndex = 0
		Me.flxDeliveryPoints.Name = "flxDeliveryPoints"
		Me.Label3.Text = "Existing Delivery Points"
		Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Size = New System.Drawing.Size(132, 13)
		Me.Label3.Location = New System.Drawing.Point(40, 152)
		Me.Label3.TabIndex = 7
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
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Size = New System.Drawing.Size(46, 13)
		Me.Label2.Location = New System.Drawing.Point(40, 80)
		Me.Label2.TabIndex = 4
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
		Me.Label1.Text = "Delivery Point"
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(79, 13)
		Me.Label1.Location = New System.Drawing.Point(40, 32)
		Me.Label1.TabIndex = 3
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
		CType(Me.flxDeliveryPoints, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(cmdClear)
		Me.Controls.Add(cmdDelete)
		Me.Controls.Add(cmdSave)
		Me.Controls.Add(txtDPAddress)
		Me.Controls.Add(txtDPName)
		Me.Controls.Add(flxDeliveryPoints)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class