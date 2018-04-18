<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrintSO
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
	Public WithEvents chkShowPrinted As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cboPurchaseOrders As System.Windows.Forms.ComboBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPrintSO))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.chkShowPrinted = New System.Windows.Forms.CheckBox
		Me.cmdPrint = New System.Windows.Forms.Button
		Me.cboPurchaseOrders = New System.Windows.Forms.ComboBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Print SO"
		Me.ClientSize = New System.Drawing.Size(437, 256)
		Me.Location = New System.Drawing.Point(10, 26)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("frmPrintSO.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmPrintSO"
		Me.chkShowPrinted.Text = "Show Printed Service Orders"
		Me.chkShowPrinted.Size = New System.Drawing.Size(241, 33)
		Me.chkShowPrinted.Location = New System.Drawing.Point(16, 8)
		Me.chkShowPrinted.TabIndex = 3
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
		Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrint.Text = "Print SO"
		Me.cmdPrint.Size = New System.Drawing.Size(81, 33)
		Me.cmdPrint.Location = New System.Drawing.Point(16, 112)
		Me.cmdPrint.TabIndex = 2
		Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrint.CausesValidation = True
		Me.cmdPrint.Enabled = True
		Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrint.TabStop = True
		Me.cmdPrint.Name = "cmdPrint"
		Me.cboPurchaseOrders.Size = New System.Drawing.Size(169, 21)
		Me.cboPurchaseOrders.Location = New System.Drawing.Point(168, 48)
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
		Me.Label1.Text = "Service Order Number"
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(124, 13)
		Me.Label1.Location = New System.Drawing.Point(16, 50)
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
		Me.Controls.Add(chkShowPrinted)
		Me.Controls.Add(cmdPrint)
		Me.Controls.Add(cboPurchaseOrders)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class