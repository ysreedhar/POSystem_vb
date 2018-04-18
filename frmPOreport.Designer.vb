<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPOreport
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
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents cmdGenerate As System.Windows.Forms.Button
	Public WithEvents cmbPONumbers As System.Windows.Forms.ComboBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPOreport))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Command2 = New System.Windows.Forms.Button
		Me.cmdGenerate = New System.Windows.Forms.Button
		Me.cmbPONumbers = New System.Windows.Forms.ComboBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Invoice Summary Report"
		Me.ClientSize = New System.Drawing.Size(737, 475)
		Me.Location = New System.Drawing.Point(4, 30)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmPOreport"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "Close"
		Me.Command2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.Size = New System.Drawing.Size(81, 33)
		Me.Command2.Location = New System.Drawing.Point(288, 24)
		Me.Command2.TabIndex = 3
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.cmdGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdGenerate.Text = "Generate"
		Me.cmdGenerate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdGenerate.Size = New System.Drawing.Size(81, 33)
		Me.cmdGenerate.Location = New System.Drawing.Point(192, 24)
		Me.cmdGenerate.TabIndex = 2
		Me.cmdGenerate.BackColor = System.Drawing.SystemColors.Control
		Me.cmdGenerate.CausesValidation = True
		Me.cmdGenerate.Enabled = True
		Me.cmdGenerate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdGenerate.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdGenerate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdGenerate.TabStop = True
		Me.cmdGenerate.Name = "cmdGenerate"
		Me.cmbPONumbers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbPONumbers.Size = New System.Drawing.Size(145, 21)
		Me.cmbPONumbers.Location = New System.Drawing.Point(24, 32)
		Me.cmbPONumbers.TabIndex = 0
		Me.cmbPONumbers.BackColor = System.Drawing.SystemColors.Window
		Me.cmbPONumbers.CausesValidation = True
		Me.cmbPONumbers.Enabled = True
		Me.cmbPONumbers.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbPONumbers.IntegralHeight = True
		Me.cmbPONumbers.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbPONumbers.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbPONumbers.Sorted = False
		Me.cmbPONumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbPONumbers.TabStop = True
		Me.cmbPONumbers.Visible = True
		Me.cmbPONumbers.Name = "cmbPONumbers"
		Me.Label1.Text = "PO Number"
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(54, 13)
		Me.Label1.Location = New System.Drawing.Point(24, 8)
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
		Me.Controls.Add(Command2)
		Me.Controls.Add(cmdGenerate)
		Me.Controls.Add(cmbPONumbers)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class