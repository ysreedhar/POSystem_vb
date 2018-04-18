<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrintPOSO
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
	Public WithEvents cmdView As System.Windows.Forms.Button
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cmdPageSetup As System.Windows.Forms.Button
	Public WithEvents cmdPreview As System.Windows.Forms.Button
	Public WithEvents POViewer As System.Windows.Forms.WebBrowser
	Public WithEvents cboPurchaseOrders As System.Windows.Forms.ComboBox
	Public WithEvents chkShowPrinted As System.Windows.Forms.CheckBox
	Public WithEvents chkPrintDraft As System.Windows.Forms.CheckBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPrintPOSO))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdView = New System.Windows.Forms.Button
		Me.cmdPrint = New System.Windows.Forms.Button
		Me.cmdPageSetup = New System.Windows.Forms.Button
		Me.cmdPreview = New System.Windows.Forms.Button
		Me.POViewer = New System.Windows.Forms.WebBrowser
		Me.cboPurchaseOrders = New System.Windows.Forms.ComboBox
		Me.chkShowPrinted = New System.Windows.Forms.CheckBox
		Me.chkPrintDraft = New System.Windows.Forms.CheckBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "View and Print PO"
		Me.ClientSize = New System.Drawing.Size(681, 488)
		Me.Location = New System.Drawing.Point(4, 30)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("frmPrintPOSO.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmPrintPOSO"
		Me.cmdView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdView.Text = "&View PO"
		Me.cmdView.Size = New System.Drawing.Size(105, 33)
		Me.cmdView.Location = New System.Drawing.Point(16, 88)
		Me.cmdView.TabIndex = 8
		Me.cmdView.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdView.BackColor = System.Drawing.SystemColors.Control
		Me.cmdView.CausesValidation = True
		Me.cmdView.Enabled = True
		Me.cmdView.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdView.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdView.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdView.TabStop = True
		Me.cmdView.Name = "cmdView"
		Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrint.Text = "&Print"
		Me.cmdPrint.Size = New System.Drawing.Size(105, 33)
		Me.cmdPrint.Location = New System.Drawing.Point(139, 88)
		Me.cmdPrint.TabIndex = 7
		Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrint.CausesValidation = True
		Me.cmdPrint.Enabled = True
		Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrint.TabStop = True
		Me.cmdPrint.Name = "cmdPrint"
		Me.cmdPageSetup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPageSetup.Text = "Page Set&up"
		Me.cmdPageSetup.Size = New System.Drawing.Size(105, 33)
		Me.cmdPageSetup.Location = New System.Drawing.Point(262, 88)
		Me.cmdPageSetup.TabIndex = 6
		Me.cmdPageSetup.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPageSetup.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPageSetup.CausesValidation = True
		Me.cmdPageSetup.Enabled = True
		Me.cmdPageSetup.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPageSetup.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPageSetup.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPageSetup.TabStop = True
		Me.cmdPageSetup.Name = "cmdPageSetup"
		Me.cmdPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPreview.Text = "P&review"
		Me.cmdPreview.Size = New System.Drawing.Size(105, 33)
		Me.cmdPreview.Location = New System.Drawing.Point(384, 88)
		Me.cmdPreview.TabIndex = 5
		Me.cmdPreview.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPreview.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPreview.CausesValidation = True
		Me.cmdPreview.Enabled = True
		Me.cmdPreview.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPreview.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPreview.TabStop = True
		Me.cmdPreview.Name = "cmdPreview"
		Me.POViewer.Size = New System.Drawing.Size(977, 505)
		Me.POViewer.Location = New System.Drawing.Point(16, 136)
		Me.POViewer.TabIndex = 4
		Me.POViewer.AllowWebBrowserDrop = True
		Me.POViewer.Name = "POViewer"
		Me.cboPurchaseOrders.Size = New System.Drawing.Size(169, 21)
		Me.cboPurchaseOrders.Location = New System.Drawing.Point(168, 16)
		Me.cboPurchaseOrders.TabIndex = 2
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
		Me.chkShowPrinted.Text = "Show Printed Purchase Orders"
		Me.chkShowPrinted.Size = New System.Drawing.Size(241, 33)
		Me.chkShowPrinted.Location = New System.Drawing.Point(16, 40)
		Me.chkShowPrinted.TabIndex = 1
		Me.chkShowPrinted.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkShowPrinted.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkShowPrinted.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkShowPrinted.BackColor = System.Drawing.SystemColors.Control
		Me.chkShowPrinted.CausesValidation = True
		Me.chkShowPrinted.Enabled = True
		Me.chkShowPrinted.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkShowPrinted.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkShowPrinted.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkShowPrinted.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkShowPrinted.TabStop = True
		Me.chkShowPrinted.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkShowPrinted.Visible = True
		Me.chkShowPrinted.Name = "chkShowPrinted"
		Me.chkPrintDraft.Text = "Print Draft"
		Me.chkPrintDraft.Size = New System.Drawing.Size(241, 33)
		Me.chkPrintDraft.Location = New System.Drawing.Point(352, 8)
		Me.chkPrintDraft.TabIndex = 0
		Me.chkPrintDraft.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkPrintDraft.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkPrintDraft.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkPrintDraft.BackColor = System.Drawing.SystemColors.Control
		Me.chkPrintDraft.CausesValidation = True
		Me.chkPrintDraft.Enabled = True
		Me.chkPrintDraft.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkPrintDraft.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkPrintDraft.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkPrintDraft.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkPrintDraft.TabStop = True
		Me.chkPrintDraft.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkPrintDraft.Visible = True
		Me.chkPrintDraft.Name = "chkPrintDraft"
		Me.Label1.Text = "Purchase Order Number"
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(134, 13)
		Me.Label1.Location = New System.Drawing.Point(16, 18)
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
		Me.Controls.Add(cmdView)
		Me.Controls.Add(cmdPrint)
		Me.Controls.Add(cmdPageSetup)
		Me.Controls.Add(cmdPreview)
		Me.Controls.Add(POViewer)
		Me.Controls.Add(cboPurchaseOrders)
		Me.Controls.Add(chkShowPrinted)
		Me.Controls.Add(chkPrintDraft)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class