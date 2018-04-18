<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmTransmittalForm
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
	Public WithEvents cmdPreview As System.Windows.Forms.Button
	Public WithEvents cmdPageSetup As System.Windows.Forms.Button
	Public WithEvents txtTransmitToDept As System.Windows.Forms.TextBox
	Public WithEvents rptViewer As System.Windows.Forms.WebBrowser
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents lstInvoiceNos As System.Windows.Forms.CheckedListBox
	Public WithEvents cmdView As System.Windows.Forms.Button
	Public WithEvents txtTransmitToName As System.Windows.Forms.TextBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTransmittalForm))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdPreview = New System.Windows.Forms.Button
		Me.cmdPageSetup = New System.Windows.Forms.Button
		Me.txtTransmitToDept = New System.Windows.Forms.TextBox
		Me.rptViewer = New System.Windows.Forms.WebBrowser
		Me.cmdPrint = New System.Windows.Forms.Button
		Me.lstInvoiceNos = New System.Windows.Forms.CheckedListBox
		Me.cmdView = New System.Windows.Forms.Button
		Me.txtTransmitToName = New System.Windows.Forms.TextBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Transmittal Form"
		Me.ClientSize = New System.Drawing.Size(658, 445)
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
		Me.Name = "FrmTransmittalForm"
		Me.cmdPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPreview.Text = "P&review"
		Me.cmdPreview.Size = New System.Drawing.Size(105, 33)
		Me.cmdPreview.Location = New System.Drawing.Point(548, 176)
		Me.cmdPreview.TabIndex = 11
		Me.cmdPreview.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPreview.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPreview.CausesValidation = True
		Me.cmdPreview.Enabled = True
		Me.cmdPreview.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPreview.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPreview.TabStop = True
		Me.cmdPreview.Name = "cmdPreview"
		Me.cmdPageSetup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPageSetup.Text = "Page Set&up"
		Me.cmdPageSetup.Size = New System.Drawing.Size(113, 33)
		Me.cmdPageSetup.Location = New System.Drawing.Point(424, 176)
		Me.cmdPageSetup.TabIndex = 10
		Me.cmdPageSetup.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPageSetup.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPageSetup.CausesValidation = True
		Me.cmdPageSetup.Enabled = True
		Me.cmdPageSetup.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPageSetup.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPageSetup.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPageSetup.TabStop = True
		Me.cmdPageSetup.Name = "cmdPageSetup"
		Me.txtTransmitToDept.AutoSize = False
		Me.txtTransmitToDept.Size = New System.Drawing.Size(305, 21)
		Me.txtTransmitToDept.Location = New System.Drawing.Point(128, 56)
		Me.txtTransmitToDept.TabIndex = 7
		Me.txtTransmitToDept.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTransmitToDept.AcceptsReturn = True
		Me.txtTransmitToDept.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTransmitToDept.BackColor = System.Drawing.SystemColors.Window
		Me.txtTransmitToDept.CausesValidation = True
		Me.txtTransmitToDept.Enabled = True
		Me.txtTransmitToDept.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTransmitToDept.HideSelection = True
		Me.txtTransmitToDept.ReadOnly = False
		Me.txtTransmitToDept.Maxlength = 0
		Me.txtTransmitToDept.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTransmitToDept.MultiLine = False
		Me.txtTransmitToDept.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTransmitToDept.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTransmitToDept.TabStop = True
		Me.txtTransmitToDept.Visible = True
		Me.txtTransmitToDept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTransmitToDept.Name = "txtTransmitToDept"
		Me.rptViewer.Size = New System.Drawing.Size(953, 401)
		Me.rptViewer.Location = New System.Drawing.Point(32, 232)
		Me.rptViewer.TabIndex = 6
		Me.rptViewer.AllowWebBrowserDrop = True
		Me.rptViewer.Name = "rptViewer"
		Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrint.Text = "&Print"
		Me.cmdPrint.Size = New System.Drawing.Size(105, 33)
		Me.cmdPrint.Location = New System.Drawing.Point(300, 176)
		Me.cmdPrint.TabIndex = 5
		Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrint.CausesValidation = True
		Me.cmdPrint.Enabled = True
		Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrint.TabStop = True
		Me.cmdPrint.Name = "cmdPrint"
		Me.lstInvoiceNos.BackColor = System.Drawing.Color.White
		Me.lstInvoiceNos.Size = New System.Drawing.Size(508, 79)
		Me.lstInvoiceNos.Location = New System.Drawing.Point(128, 88)
		Me.lstInvoiceNos.TabIndex = 4
		Me.lstInvoiceNos.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstInvoiceNos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstInvoiceNos.CausesValidation = True
		Me.lstInvoiceNos.Enabled = True
		Me.lstInvoiceNos.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstInvoiceNos.IntegralHeight = True
		Me.lstInvoiceNos.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstInvoiceNos.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstInvoiceNos.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstInvoiceNos.Sorted = False
		Me.lstInvoiceNos.TabStop = True
		Me.lstInvoiceNos.Visible = True
		Me.lstInvoiceNos.MultiColumn = False
		Me.lstInvoiceNos.Name = "lstInvoiceNos"
		Me.cmdView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdView.Text = "&View Transmittal Form"
		Me.cmdView.Size = New System.Drawing.Size(161, 33)
		Me.cmdView.Location = New System.Drawing.Point(128, 176)
		Me.cmdView.TabIndex = 3
		Me.cmdView.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdView.BackColor = System.Drawing.SystemColors.Control
		Me.cmdView.CausesValidation = True
		Me.cmdView.Enabled = True
		Me.cmdView.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdView.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdView.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdView.TabStop = True
		Me.cmdView.Name = "cmdView"
		Me.txtTransmitToName.AutoSize = False
		Me.txtTransmitToName.Size = New System.Drawing.Size(305, 21)
		Me.txtTransmitToName.Location = New System.Drawing.Point(128, 24)
		Me.txtTransmitToName.TabIndex = 1
		Me.txtTransmitToName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTransmitToName.AcceptsReturn = True
		Me.txtTransmitToName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTransmitToName.BackColor = System.Drawing.SystemColors.Window
		Me.txtTransmitToName.CausesValidation = True
		Me.txtTransmitToName.Enabled = True
		Me.txtTransmitToName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTransmitToName.HideSelection = True
		Me.txtTransmitToName.ReadOnly = False
		Me.txtTransmitToName.Maxlength = 0
		Me.txtTransmitToName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTransmitToName.MultiLine = False
		Me.txtTransmitToName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTransmitToName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTransmitToName.TabStop = True
		Me.txtTransmitToName.Visible = True
		Me.txtTransmitToName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTransmitToName.Name = "txtTransmitToName"
		Me.Label4.Text = "Name"
		Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Size = New System.Drawing.Size(32, 13)
		Me.Label4.Location = New System.Drawing.Point(24, 32)
		Me.Label4.TabIndex = 9
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
		Me.Label1.Text = "Department"
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(69, 13)
		Me.Label1.Location = New System.Drawing.Point(24, 60)
		Me.Label1.TabIndex = 8
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
		Me.Label3.Text = "Invoice Nos."
		Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Size = New System.Drawing.Size(68, 13)
		Me.Label3.Location = New System.Drawing.Point(24, 96)
		Me.Label3.TabIndex = 2
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
		Me.Label2.Text = "Transmit to:"
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Size = New System.Drawing.Size(69, 13)
		Me.Label2.Location = New System.Drawing.Point(24, 8)
		Me.Label2.TabIndex = 0
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
		Me.Controls.Add(cmdPreview)
		Me.Controls.Add(cmdPageSetup)
		Me.Controls.Add(txtTransmitToDept)
		Me.Controls.Add(rptViewer)
		Me.Controls.Add(cmdPrint)
		Me.Controls.Add(lstInvoiceNos)
		Me.Controls.Add(cmdView)
		Me.Controls.Add(txtTransmitToName)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class