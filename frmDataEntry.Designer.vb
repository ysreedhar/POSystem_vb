<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPOEntry
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
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Text6 As System.Windows.Forms.TextBox
	Public WithEvents Text5 As System.Windows.Forms.TextBox
	Public WithEvents Text4 As System.Windows.Forms.TextBox
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents txtEditFlexMatrix As System.Windows.Forms.TextBox
	Public WithEvents flxPODetails As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents cmdReset As System.Windows.Forms.Button
	Public WithEvents cboChargeType As System.Windows.Forms.ComboBox
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
	Public WithEvents Label14 As System.Windows.Forms.Label
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
	Public WithEvents lblPOtotal As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOEntry))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.Command1 = New System.Windows.Forms.Button
        Me.Text6 = New System.Windows.Forms.TextBox
        Me.Text5 = New System.Windows.Forms.TextBox
        Me.Text4 = New System.Windows.Forms.TextBox
        Me.Text3 = New System.Windows.Forms.TextBox
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txtEditFlexMatrix = New System.Windows.Forms.TextBox
        Me.flxPODetails = New AxMSFlexGridLib.AxMSFlexGrid
        Me.cmdReset = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cboChargeType = New System.Windows.Forms.ComboBox
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
        Me.Label14 = New System.Windows.Forms.Label
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
        Me.lblPOtotal = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Frame2.SuspendLayout()
        CType(Me.flxPODetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.dtpPODate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Command1)
        Me.Frame2.Controls.Add(Me.Text6)
        Me.Frame2.Controls.Add(Me.Text5)
        Me.Frame2.Controls.Add(Me.Text4)
        Me.Frame2.Controls.Add(Me.Text3)
        Me.Frame2.Controls.Add(Me.Text2)
        Me.Frame2.Controls.Add(Me.Text1)
        Me.Frame2.Controls.Add(Me.Label22)
        Me.Frame2.Controls.Add(Me.Label21)
        Me.Frame2.Controls.Add(Me.Label20)
        Me.Frame2.Controls.Add(Me.Label19)
        Me.Frame2.Controls.Add(Me.Label18)
        Me.Frame2.Controls.Add(Me.Label17)
        Me.Frame2.Controls.Add(Me.Label16)
        Me.Frame2.Controls.Add(Me.Label15)
        Me.Frame2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(736, 16)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(273, 449)
        Me.Frame2.TabIndex = 33
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Add PO Items"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(80, 272)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(81, 33)
        Me.Command1.TabIndex = 46
        Me.Command1.Text = "Add Item"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Text6
        '
        Me.Text6.AcceptsReturn = True
        Me.Text6.BackColor = System.Drawing.SystemColors.Window
        Me.Text6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text6.Location = New System.Drawing.Point(80, 200)
        Me.Text6.MaxLength = 0
        Me.Text6.Name = "Text6"
        Me.Text6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text6.Size = New System.Drawing.Size(185, 25)
        Me.Text6.TabIndex = 44
        Me.Text6.Text = "0"
        '
        'Text5
        '
        Me.Text5.AcceptsReturn = True
        Me.Text5.BackColor = System.Drawing.SystemColors.Window
        Me.Text5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text5.Location = New System.Drawing.Point(80, 168)
        Me.Text5.MaxLength = 0
        Me.Text5.Name = "Text5"
        Me.Text5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text5.Size = New System.Drawing.Size(185, 25)
        Me.Text5.TabIndex = 42
        '
        'Text4
        '
        Me.Text4.AcceptsReturn = True
        Me.Text4.BackColor = System.Drawing.SystemColors.Window
        Me.Text4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text4.Location = New System.Drawing.Point(80, 40)
        Me.Text4.MaxLength = 0
        Me.Text4.Name = "Text4"
        Me.Text4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text4.Size = New System.Drawing.Size(185, 25)
        Me.Text4.TabIndex = 37
        '
        'Text3
        '
        Me.Text3.AcceptsReturn = True
        Me.Text3.BackColor = System.Drawing.SystemColors.Window
        Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text3.Location = New System.Drawing.Point(80, 72)
        Me.Text3.MaxLength = 0
        Me.Text3.Name = "Text3"
        Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text3.Size = New System.Drawing.Size(185, 25)
        Me.Text3.TabIndex = 36
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(80, 104)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(185, 25)
        Me.Text2.TabIndex = 35
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(80, 136)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(185, 25)
        Me.Text1.TabIndex = 34
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(80, 240)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(0, 13)
        Me.Label22.TabIndex = 48
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(8, 240)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(57, 14)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Total Price"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(8, 208)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(65, 14)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "With holding"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(8, 176)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(52, 14)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Unit Price"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(8, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(45, 14)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Item No."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(8, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(48, 14)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "MSR No."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(8, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(47, 14)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Quantity"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(8, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(30, 14)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "UOM"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSave.Location = New System.Drawing.Point(451, 488)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSave.Size = New System.Drawing.Size(81, 33)
        Me.cmdSave.TabIndex = 24
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'txtEditFlexMatrix
        '
        Me.txtEditFlexMatrix.AcceptsReturn = True
        Me.txtEditFlexMatrix.BackColor = System.Drawing.SystemColors.Window
        Me.txtEditFlexMatrix.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEditFlexMatrix.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditFlexMatrix.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEditFlexMatrix.Location = New System.Drawing.Point(312, 480)
        Me.txtEditFlexMatrix.MaxLength = 0
        Me.txtEditFlexMatrix.Name = "txtEditFlexMatrix"
        Me.txtEditFlexMatrix.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEditFlexMatrix.Size = New System.Drawing.Size(81, 33)
        Me.txtEditFlexMatrix.TabIndex = 23
        Me.txtEditFlexMatrix.Visible = False
        '
        'flxPODetails
        '
        Me.flxPODetails.Location = New System.Drawing.Point(35, 536)
        Me.flxPODetails.Name = "flxPODetails"
        Me.flxPODetails.OcxState = CType(resources.GetObject("flxPODetails.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxPODetails.Size = New System.Drawing.Size(689, 177)
        Me.flxPODetails.TabIndex = 22
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReset.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReset.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdReset.Location = New System.Drawing.Point(547, 488)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReset.Size = New System.Drawing.Size(81, 33)
        Me.cmdReset.TabIndex = 21
        Me.cmdReset.Text = "&Reset"
        Me.cmdReset.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cboChargeType)
        Me.Frame1.Controls.Add(Me.cboDeliveryPoint)
        Me.Frame1.Controls.Add(Me.cboVendorName)
        Me.Frame1.Controls.Add(Me.txtCurrency)
        Me.Frame1.Controls.Add(Me.dtpPODate)
        Me.Frame1.Controls.Add(Me.txtDeliveryTerms)
        Me.Frame1.Controls.Add(Me.txtRemarks)
        Me.Frame1.Controls.Add(Me.txtApprovedBy)
        Me.Frame1.Controls.Add(Me.txtOrderedBy)
        Me.Frame1.Controls.Add(Me.txtCostCenter)
        Me.Frame1.Controls.Add(Me.txtReqOrderNo)
        Me.Frame1.Controls.Add(Me.txtPONumber)
        Me.Frame1.Controls.Add(Me.txtAddress)
        Me.Frame1.Controls.Add(Me.Label14)
        Me.Frame1.Controls.Add(Me.Label13)
        Me.Frame1.Controls.Add(Me.Label12)
        Me.Frame1.Controls.Add(Me.Label10)
        Me.Frame1.Controls.Add(Me.Label9)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(35, 16)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(689, 449)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Purchase Order"
        '
        'cboChargeType
        '
        Me.cboChargeType.BackColor = System.Drawing.SystemColors.Window
        Me.cboChargeType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboChargeType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChargeType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboChargeType.Items.AddRange(New Object() {"NA", "DR", "LS", "AC", "CP"})
        Me.cboChargeType.Location = New System.Drawing.Point(472, 256)
        Me.cboChargeType.Name = "cboChargeType"
        Me.cboChargeType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboChargeType.Size = New System.Drawing.Size(49, 22)
        Me.cboChargeType.TabIndex = 30
        Me.cboChargeType.Text = "NA"
        '
        'cboDeliveryPoint
        '
        Me.cboDeliveryPoint.BackColor = System.Drawing.SystemColors.Window
        Me.cboDeliveryPoint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDeliveryPoint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeliveryPoint.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDeliveryPoint.Location = New System.Drawing.Point(472, 220)
        Me.cboDeliveryPoint.Name = "cboDeliveryPoint"
        Me.cboDeliveryPoint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDeliveryPoint.Size = New System.Drawing.Size(209, 22)
        Me.cboDeliveryPoint.TabIndex = 28
        '
        'cboVendorName
        '
        Me.cboVendorName.BackColor = System.Drawing.SystemColors.Window
        Me.cboVendorName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboVendorName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVendorName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVendorName.Location = New System.Drawing.Point(80, 24)
        Me.cboVendorName.Name = "cboVendorName"
        Me.cboVendorName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboVendorName.Size = New System.Drawing.Size(305, 22)
        Me.cboVendorName.TabIndex = 27
        '
        'txtCurrency
        '
        Me.txtCurrency.AcceptsReturn = True
        Me.txtCurrency.BackColor = System.Drawing.SystemColors.Window
        Me.txtCurrency.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCurrency.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrency.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCurrency.Location = New System.Drawing.Point(472, 176)
        Me.txtCurrency.MaxLength = 0
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCurrency.Size = New System.Drawing.Size(33, 25)
        Me.txtCurrency.TabIndex = 25
        Me.txtCurrency.Text = "RM"
        '
        'dtpPODate
        '
        Me.dtpPODate.Location = New System.Drawing.Point(472, 16)
        Me.dtpPODate.Name = "dtpPODate"
        Me.dtpPODate.OcxState = CType(resources.GetObject("dtpPODate.OcxState"), System.Windows.Forms.AxHost.State)
        Me.dtpPODate.Size = New System.Drawing.Size(121, 25)
        Me.dtpPODate.TabIndex = 19
        '
        'txtDeliveryTerms
        '
        Me.txtDeliveryTerms.AcceptsReturn = True
        Me.txtDeliveryTerms.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeliveryTerms.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeliveryTerms.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeliveryTerms.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDeliveryTerms.Location = New System.Drawing.Point(80, 360)
        Me.txtDeliveryTerms.MaxLength = 0
        Me.txtDeliveryTerms.Multiline = True
        Me.txtDeliveryTerms.Name = "txtDeliveryTerms"
        Me.txtDeliveryTerms.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeliveryTerms.Size = New System.Drawing.Size(593, 73)
        Me.txtDeliveryTerms.TabIndex = 18
        '
        'txtRemarks
        '
        Me.txtRemarks.AcceptsReturn = True
        Me.txtRemarks.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemarks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRemarks.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRemarks.Location = New System.Drawing.Point(80, 184)
        Me.txtRemarks.MaxLength = 0
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRemarks.Size = New System.Drawing.Size(305, 25)
        Me.txtRemarks.TabIndex = 16
        '
        'txtApprovedBy
        '
        Me.txtApprovedBy.AcceptsReturn = True
        Me.txtApprovedBy.BackColor = System.Drawing.SystemColors.Window
        Me.txtApprovedBy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApprovedBy.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovedBy.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtApprovedBy.Location = New System.Drawing.Point(472, 144)
        Me.txtApprovedBy.MaxLength = 0
        Me.txtApprovedBy.Name = "txtApprovedBy"
        Me.txtApprovedBy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtApprovedBy.Size = New System.Drawing.Size(209, 25)
        Me.txtApprovedBy.TabIndex = 14
        '
        'txtOrderedBy
        '
        Me.txtOrderedBy.AcceptsReturn = True
        Me.txtOrderedBy.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrderedBy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrderedBy.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderedBy.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOrderedBy.Location = New System.Drawing.Point(472, 112)
        Me.txtOrderedBy.MaxLength = 0
        Me.txtOrderedBy.Name = "txtOrderedBy"
        Me.txtOrderedBy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOrderedBy.Size = New System.Drawing.Size(209, 25)
        Me.txtOrderedBy.TabIndex = 12
        '
        'txtCostCenter
        '
        Me.txtCostCenter.AcceptsReturn = True
        Me.txtCostCenter.BackColor = System.Drawing.SystemColors.Window
        Me.txtCostCenter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCostCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostCenter.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCostCenter.Location = New System.Drawing.Point(472, 80)
        Me.txtCostCenter.MaxLength = 0
        Me.txtCostCenter.Name = "txtCostCenter"
        Me.txtCostCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCostCenter.Size = New System.Drawing.Size(209, 25)
        Me.txtCostCenter.TabIndex = 10
        '
        'txtReqOrderNo
        '
        Me.txtReqOrderNo.AcceptsReturn = True
        Me.txtReqOrderNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtReqOrderNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReqOrderNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReqOrderNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtReqOrderNo.Location = New System.Drawing.Point(472, 48)
        Me.txtReqOrderNo.MaxLength = 0
        Me.txtReqOrderNo.Name = "txtReqOrderNo"
        Me.txtReqOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtReqOrderNo.Size = New System.Drawing.Size(89, 25)
        Me.txtReqOrderNo.TabIndex = 8
        '
        'txtPONumber
        '
        Me.txtPONumber.AcceptsReturn = True
        Me.txtPONumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtPONumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPONumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPONumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPONumber.Location = New System.Drawing.Point(80, 144)
        Me.txtPONumber.MaxLength = 0
        Me.txtPONumber.Name = "txtPONumber"
        Me.txtPONumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPONumber.Size = New System.Drawing.Size(305, 25)
        Me.txtPONumber.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.AcceptsReturn = True
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddress.Location = New System.Drawing.Point(80, 56)
        Me.txtAddress.MaxLength = 0
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAddress.Size = New System.Drawing.Size(305, 81)
        Me.txtAddress.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(400, 260)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(69, 14)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Charge Type"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(400, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(72, 14)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Delivery Point"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(400, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(52, 14)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Currency"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 368)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(79, 14)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Delivery Terms"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(49, 14)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Remarks"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(400, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(71, 14)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Approved By"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(400, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(63, 14)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Ordered By"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(400, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(64, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cost Center"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(400, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(72, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Req. Order # "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(400, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(29, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(64, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PO. Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vendor Name"
        '
        'lblPOtotal
        '
        Me.lblPOtotal.AutoSize = True
        Me.lblPOtotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblPOtotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPOtotal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOtotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPOtotal.Location = New System.Drawing.Point(710, 560)
        Me.lblPOtotal.Name = "lblPOtotal"
        Me.lblPOtotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPOtotal.Size = New System.Drawing.Size(0, 23)
        Me.lblPOtotal.TabIndex = 32
        Me.lblPOtotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(35, 512)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(136, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Purchase Order Details"
        '
        'frmPOEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(912, 618)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtEditFlexMatrix)
        Me.Controls.Add(Me.flxPODetails)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.lblPOtotal)
        Me.Controls.Add(Me.Label11)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmPOEntry"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Enter Purchase Order"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.flxPODetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.dtpPODate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class