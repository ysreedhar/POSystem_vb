<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmLogin
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
	Public WithEvents picLogo As System.Windows.Forms.PictureBox
	Public WithEvents cmbName As System.Windows.Forms.TextBox
	Public WithEvents cmdExit As System.Windows.Forms.Button
	Public WithEvents cmdContinue As System.Windows.Forms.Button
	Public WithEvents txtPassword As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLogin))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.picLogo = New System.Windows.Forms.PictureBox
		Me.cmbName = New System.Windows.Forms.TextBox
		Me.cmdExit = New System.Windows.Forms.Button
		Me.cmdContinue = New System.Windows.Forms.Button
		Me.txtPassword = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "PO System Login"
		Me.ClientSize = New System.Drawing.Size(381, 265)
		Me.Location = New System.Drawing.Point(3, 29)
		Me.ForeColor = System.Drawing.SystemColors.Control
		Me.Icon = CType(resources.GetObject("frmLogin.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmLogin"
		Me.picLogo.BackColor = System.Drawing.SystemColors.Window
		Me.picLogo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picLogo.Size = New System.Drawing.Size(350, 116)
		Me.picLogo.Location = New System.Drawing.Point(16, 14)
		Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
		Me.picLogo.TabIndex = 6
		Me.picLogo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picLogo.Dock = System.Windows.Forms.DockStyle.None
		Me.picLogo.CausesValidation = True
		Me.picLogo.Enabled = True
		Me.picLogo.Cursor = System.Windows.Forms.Cursors.Default
		Me.picLogo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picLogo.TabStop = True
		Me.picLogo.Visible = True
		Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picLogo.Name = "picLogo"
		Me.cmbName.AutoSize = False
		Me.cmbName.BackColor = System.Drawing.Color.White
		Me.cmbName.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbName.ForeColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.cmbName.Size = New System.Drawing.Size(177, 21)
		Me.cmbName.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.cmbName.Location = New System.Drawing.Point(136, 145)
		Me.cmbName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.cmbName.TabIndex = 0
		Me.cmbName.AcceptsReturn = True
		Me.cmbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.cmbName.CausesValidation = True
		Me.cmbName.Enabled = True
		Me.cmbName.HideSelection = True
		Me.cmbName.ReadOnly = False
		Me.cmbName.Maxlength = 0
		Me.cmbName.MultiLine = False
		Me.cmbName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.cmbName.TabStop = True
		Me.cmbName.Visible = True
		Me.cmbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.cmbName.Name = "cmbName"
		Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdExit.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.cmdExit.Text = "E&xit"
		Me.cmdExit.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdExit.Size = New System.Drawing.Size(81, 20)
		Me.cmdExit.Location = New System.Drawing.Point(232, 232)
		Me.cmdExit.TabIndex = 3
		Me.cmdExit.CausesValidation = True
		Me.cmdExit.Enabled = True
		Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdExit.TabStop = True
		Me.cmdExit.Name = "cmdExit"
		Me.cmdContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdContinue.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.cmdContinue.Text = "&Login"
		Me.cmdContinue.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdContinue.Size = New System.Drawing.Size(81, 20)
		Me.cmdContinue.Location = New System.Drawing.Point(147, 232)
		Me.cmdContinue.TabIndex = 2
		Me.cmdContinue.CausesValidation = True
		Me.cmdContinue.Enabled = True
		Me.cmdContinue.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdContinue.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdContinue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdContinue.TabStop = True
		Me.cmdContinue.Name = "cmdContinue"
		Me.txtPassword.AutoSize = False
		Me.txtPassword.BackColor = System.Drawing.Color.White
		Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.ForeColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.txtPassword.Size = New System.Drawing.Size(177, 21)
		Me.txtPassword.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtPassword.Location = New System.Drawing.Point(135, 172)
		Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPassword.PasswordChar = ChrW(42)
		Me.txtPassword.TabIndex = 1
		Me.txtPassword.AcceptsReturn = True
		Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPassword.CausesValidation = True
		Me.txtPassword.Enabled = True
		Me.txtPassword.HideSelection = True
		Me.txtPassword.ReadOnly = False
		Me.txtPassword.Maxlength = 0
		Me.txtPassword.MultiLine = False
		Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPassword.TabStop = True
		Me.txtPassword.Visible = True
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtPassword.Name = "txtPassword"
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Text = "Password"
		Me.Label3.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Black
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.Location = New System.Drawing.Point(55, 172)
		Me.Label3.TabIndex = 5
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Text = "Username"
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Black
		Me.Label2.Size = New System.Drawing.Size(65, 17)
		Me.Label2.Location = New System.Drawing.Point(55, 148)
		Me.Label2.TabIndex = 4
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Controls.Add(picLogo)
		Me.Controls.Add(cmbName)
		Me.Controls.Add(cmdExit)
		Me.Controls.Add(cmdContinue)
		Me.Controls.Add(txtPassword)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class