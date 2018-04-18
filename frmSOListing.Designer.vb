<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSOListing
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
	Public WithEvents chkShowCancelled As System.Windows.Forms.CheckBox
	Public WithEvents flxPurchaseOrders As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents lblPOtotal As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSOListing))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.chkShowCancelled = New System.Windows.Forms.CheckBox
		Me.flxPurchaseOrders = New AxMSFlexGridLib.AxMSFlexGrid
		Me.Label3 = New System.Windows.Forms.Label
		Me.lblPOtotal = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.flxPurchaseOrders, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Service Order Listing"
		Me.ClientSize = New System.Drawing.Size(790, 594)
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
		Me.Name = "frmSOListing"
		Me.chkShowCancelled.Text = "Show Cancelled Service Orders"
		Me.chkShowCancelled.Size = New System.Drawing.Size(185, 33)
		Me.chkShowCancelled.Location = New System.Drawing.Point(32, 40)
		Me.chkShowCancelled.TabIndex = 2
		Me.chkShowCancelled.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkShowCancelled.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkShowCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkShowCancelled.BackColor = System.Drawing.SystemColors.Control
		Me.chkShowCancelled.CausesValidation = True
		Me.chkShowCancelled.Enabled = True
		Me.chkShowCancelled.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkShowCancelled.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkShowCancelled.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkShowCancelled.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkShowCancelled.TabStop = True
		Me.chkShowCancelled.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkShowCancelled.Visible = True
		Me.chkShowCancelled.Name = "chkShowCancelled"
		flxPurchaseOrders.OcxState = CType(resources.GetObject("flxPurchaseOrders.OcxState"), System.Windows.Forms.AxHost.State)
		Me.flxPurchaseOrders.Size = New System.Drawing.Size(961, 361)
		Me.flxPurchaseOrders.Location = New System.Drawing.Point(32, 72)
		Me.flxPurchaseOrders.TabIndex = 0
		Me.flxPurchaseOrders.Name = "flxPurchaseOrders"
		Me.Label3.Text = "Label3"
		Me.Label3.Size = New System.Drawing.Size(81, 1)
		Me.Label3.Location = New System.Drawing.Point(472, 352)
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
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.lblPOtotal.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblPOtotal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPOtotal.Size = New System.Drawing.Size(6, 23)
		Me.lblPOtotal.Location = New System.Drawing.Point(984, 320)
		Me.lblPOtotal.TabIndex = 3
		Me.lblPOtotal.BackColor = System.Drawing.SystemColors.Control
		Me.lblPOtotal.Enabled = True
		Me.lblPOtotal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPOtotal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPOtotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPOtotal.UseMnemonic = True
		Me.lblPOtotal.Visible = True
		Me.lblPOtotal.AutoSize = True
		Me.lblPOtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPOtotal.Name = "lblPOtotal"
		Me.Label1.Text = "Service Orders"
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(139, 23)
		Me.Label1.Location = New System.Drawing.Point(32, 8)
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
		CType(Me.flxPurchaseOrders, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(chkShowCancelled)
		Me.Controls.Add(flxPurchaseOrders)
		Me.Controls.Add(Label3)
		Me.Controls.Add(lblPOtotal)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class