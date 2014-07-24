<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLine1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtChallanNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDt1 = New System.Windows.Forms.Button()
        Me.btnDt2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtInvNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCno = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEno = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtLine2 = New System.Windows.Forms.TextBox()
        Me.txtLine3 = New System.Windows.Forms.TextBox()
        Me.txtLine4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbLessPaidBy = New System.Windows.Forms.ComboBox()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCDate = New System.Windows.Forms.TextBox()
        Me.txtIDate = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbSelectProduct = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSld = New System.Windows.Forms.TextBox()
        Me.sld = New DevComponents.DotNetBar.Controls.Slider()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.lblCTag = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmbBlock = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cmbDAO = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.pnlDetails.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(130, 375)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(62, 32)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "To :"
        '
        'txtLine1
        '
        Me.txtLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLine1.Location = New System.Drawing.Point(130, 93)
        Me.txtLine1.MaxLength = 50
        Me.txtLine1.Name = "txtLine1"
        Me.txtLine1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLine1.Size = New System.Drawing.Size(238, 22)
        Me.txtLine1.TabIndex = 3
        Me.txtLine1.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(407, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Challan No. :"
        '
        'txtChallanNo
        '
        Me.txtChallanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChallanNo.Enabled = False
        Me.txtChallanNo.Location = New System.Drawing.Point(498, 107)
        Me.txtChallanNo.MaxLength = 3
        Me.txtChallanNo.Name = "txtChallanNo"
        Me.txtChallanNo.Size = New System.Drawing.Size(238, 22)
        Me.txtChallanNo.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(615, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "3 Characters at most"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(396, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Challan Date :"
        '
        'btnDt1
        '
        Me.btnDt1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDt1.Location = New System.Drawing.Point(709, 148)
        Me.btnDt1.Name = "btnDt1"
        Me.btnDt1.Size = New System.Drawing.Size(27, 23)
        Me.btnDt1.TabIndex = 12
        Me.btnDt1.Text = "..."
        Me.btnDt1.UseVisualStyleBackColor = True
        '
        'btnDt2
        '
        Me.btnDt2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDt2.Location = New System.Drawing.Point(709, 232)
        Me.btnDt2.Name = "btnDt2"
        Me.btnDt2.Size = New System.Drawing.Size(27, 23)
        Me.btnDt2.TabIndex = 14
        Me.btnDt2.Text = "..."
        Me.btnDt2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(395, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Invoice Date :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(615, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "3 Characters at most"
        '
        'txtInvNo
        '
        Me.txtInvNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvNo.Enabled = False
        Me.txtInvNo.Location = New System.Drawing.Point(498, 191)
        Me.txtInvNo.MaxLength = 3
        Me.txtInvNo.Name = "txtInvNo"
        Me.txtInvNo.Size = New System.Drawing.Size(238, 22)
        Me.txtInvNo.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(406, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Invoice No. :"
        '
        'txtCno
        '
        Me.txtCno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCno.Location = New System.Drawing.Point(130, 260)
        Me.txtCno.MaxLength = 30
        Me.txtCno.Name = "txtCno"
        Me.txtCno.Size = New System.Drawing.Size(238, 22)
        Me.txtCno.TabIndex = 10
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(38, 263)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 16)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Chassis No. :"
        '
        'txtEno
        '
        Me.txtEno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEno.Location = New System.Drawing.Point(130, 232)
        Me.txtEno.MaxLength = 30
        Me.txtEno.Name = "txtEno"
        Me.txtEno.Size = New System.Drawing.Size(238, 22)
        Me.txtEno.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(44, 235)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 16)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Engine No. :"
        '
        'txtLine2
        '
        Me.txtLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLine2.Location = New System.Drawing.Point(130, 121)
        Me.txtLine2.MaxLength = 50
        Me.txtLine2.Name = "txtLine2"
        Me.txtLine2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLine2.Size = New System.Drawing.Size(238, 22)
        Me.txtLine2.TabIndex = 4
        Me.txtLine2.Tag = ""
        '
        'txtLine3
        '
        Me.txtLine3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLine3.Location = New System.Drawing.Point(130, 149)
        Me.txtLine3.MaxLength = 50
        Me.txtLine3.Name = "txtLine3"
        Me.txtLine3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLine3.Size = New System.Drawing.Size(238, 22)
        Me.txtLine3.TabIndex = 5
        Me.txtLine3.Tag = ""
        '
        'txtLine4
        '
        Me.txtLine4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLine4.Enabled = False
        Me.txtLine4.Location = New System.Drawing.Point(130, 205)
        Me.txtLine4.MaxLength = 50
        Me.txtLine4.Name = "txtLine4"
        Me.txtLine4.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLine4.Size = New System.Drawing.Size(238, 22)
        Me.txtLine4.TabIndex = 8
        Me.txtLine4.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Less Paid By :"
        '
        'cmbLessPaidBy
        '
        Me.cmbLessPaidBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLessPaidBy.FormattingEnabled = True
        Me.cmbLessPaidBy.Items.AddRange(New Object() {"Bank", "Party"})
        Me.cmbLessPaidBy.Location = New System.Drawing.Point(130, 65)
        Me.cmbLessPaidBy.Name = "cmbLessPaidBy"
        Me.cmbLessPaidBy.Size = New System.Drawing.Size(95, 22)
        Me.cmbLessPaidBy.TabIndex = 2
        '
        'cmbBranch
        '
        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.Enabled = False
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Items.AddRange(New Object() {"Baripada Branch", "Keonjhargarh Branch", "Rairangpur Branch"})
        Me.cmbBranch.Location = New System.Drawing.Point(498, 37)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(238, 22)
        Me.cmbBranch.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(432, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Branch :"
        '
        'txtCDate
        '
        Me.txtCDate.BackColor = System.Drawing.Color.White
        Me.txtCDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCDate.Location = New System.Drawing.Point(498, 149)
        Me.txtCDate.Name = "txtCDate"
        Me.txtCDate.ReadOnly = True
        Me.txtCDate.Size = New System.Drawing.Size(205, 22)
        Me.txtCDate.TabIndex = 54
        '
        'txtIDate
        '
        Me.txtIDate.BackColor = System.Drawing.Color.White
        Me.txtIDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDate.Location = New System.Drawing.Point(498, 233)
        Me.txtIDate.Name = "txtIDate"
        Me.txtIDate.ReadOnly = True
        Me.txtIDate.Size = New System.Drawing.Size(205, 22)
        Me.txtIDate.TabIndex = 55
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(195, 375)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(62, 32)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(374, 37)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 14)
        Me.Label22.TabIndex = 65
        Me.Label22.Text = "*"
        '
        'cmbSelectProduct
        '
        Me.cmbSelectProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectProduct.FormattingEnabled = True
        Me.cmbSelectProduct.Location = New System.Drawing.Point(130, 37)
        Me.cmbSelectProduct.Name = "cmbSelectProduct"
        Me.cmbSelectProduct.Size = New System.Drawing.Size(238, 22)
        Me.cmbSelectProduct.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 16)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Choose Product :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(742, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 14)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(742, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 14)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(374, 235)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 14)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(231, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 14)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(742, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 14)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(742, 191)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 14)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(742, 232)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 14)
        Me.Label20.TabIndex = 73
        Me.Label20.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(374, 260)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(14, 14)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "*"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(260, 375)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 32)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(234, 315)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 14)
        Me.Label23.TabIndex = 80
        Me.Label23.Text = "Down"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(132, 315)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(23, 14)
        Me.Label24.TabIndex = 79
        Me.Label24.Text = "Up"
        '
        'txtSld
        '
        Me.txtSld.BackColor = System.Drawing.Color.White
        Me.txtSld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSld.Location = New System.Drawing.Point(176, 332)
        Me.txtSld.Name = "txtSld"
        Me.txtSld.ReadOnly = True
        Me.txtSld.Size = New System.Drawing.Size(38, 22)
        Me.txtSld.TabIndex = 14
        Me.txtSld.Text = "0"
        '
        'sld
        '
        Me.sld.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.sld.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sld.LabelVisible = False
        Me.sld.Location = New System.Drawing.Point(157, 311)
        Me.sld.Maximum = 15
        Me.sld.Minimum = -15
        Me.sld.Name = "sld"
        Me.sld.Size = New System.Drawing.Size(77, 23)
        Me.sld.Step = 5
        Me.sld.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sld.TabIndex = 13
        Me.sld.Value = 0
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(155, 295)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 14)
        Me.Label25.TabIndex = 76
        Me.Label25.Text = "Adjustment"
        '
        'PrintDocument2
        '
        '
        'pnlDetails
        '
        Me.pnlDetails.BackColor = System.Drawing.Color.Transparent
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDetails.Controls.Add(Me.Panel3)
        Me.pnlDetails.Controls.Add(Me.Panel2)
        Me.pnlDetails.Location = New System.Drawing.Point(762, 40)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(200, 118)
        Me.pnlDetails.TabIndex = 81
        Me.pnlDetails.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(198, 28)
        Me.Panel3.TabIndex = 70
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(45, 7)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(108, 14)
        Me.Label26.TabIndex = 51
        Me.Label26.Text = "Current Amount"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.lblVat)
        Me.Panel2.Controls.Add(Me.lblAmount)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(198, 88)
        Me.Panel2.TabIndex = 52
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(96, 58)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(15, 16)
        Me.lblTotal.TabIndex = 56
        Me.lblTotal.Text = "|"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.BackColor = System.Drawing.Color.Transparent
        Me.lblVat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.Location = New System.Drawing.Point(96, 35)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(15, 16)
        Me.lblVat.TabIndex = 55
        Me.lblVat.Text = "|"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(96, 12)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(15, 16)
        Me.lblAmount.TabIndex = 54
        Me.lblAmount.Text = "|"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(41, 58)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(49, 16)
        Me.Label28.TabIndex = 53
        Me.Label28.Text = "Total :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(50, 35)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(40, 16)
        Me.Label27.TabIndex = 52
        Me.Label27.Text = "Vat :"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(22, 12)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(68, 16)
        Me.Label29.TabIndex = 51
        Me.Label29.Text = "Amount :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(415, 3)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(133, 19)
        Me.Label30.TabIndex = 82
        Me.Label30.Text = "Invoice Section"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Location = New System.Drawing.Point(1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 25)
        Me.Panel1.TabIndex = 83
        '
        'lblTag
        '
        Me.lblTag.AutoSize = True
        Me.lblTag.BackColor = System.Drawing.Color.Transparent
        Me.lblTag.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTag.Location = New System.Drawing.Point(495, 194)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(84, 14)
        Me.lblTag.TabIndex = 84
        Me.lblTag.Text = "RRP/12-13/"
        '
        'lblCTag
        '
        Me.lblCTag.AutoSize = True
        Me.lblCTag.BackColor = System.Drawing.Color.Transparent
        Me.lblCTag.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCTag.Location = New System.Drawing.Point(495, 111)
        Me.lblCTag.Name = "lblCTag"
        Me.lblCTag.Size = New System.Drawing.Size(21, 14)
        Me.lblCTag.TabIndex = 88
        Me.lblCTag.Text = "R-"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(91, 207)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(33, 16)
        Me.Label31.TabIndex = 98
        Me.Label31.Text = "Dist"
        '
        'cmbBlock
        '
        Me.cmbBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBlock.FormattingEnabled = True
        Me.cmbBlock.Location = New System.Drawing.Point(275, 177)
        Me.cmbBlock.Name = "cmbBlock"
        Me.cmbBlock.Size = New System.Drawing.Size(93, 22)
        Me.cmbBlock.TabIndex = 7
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(230, 180)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(41, 16)
        Me.Label32.TabIndex = 97
        Me.Label32.Text = "Block"
        '
        'cmbDAO
        '
        Me.cmbDAO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDAO.FormattingEnabled = True
        Me.cmbDAO.Location = New System.Drawing.Point(130, 177)
        Me.cmbDAO.Name = "cmbDAO"
        Me.cmbDAO.Size = New System.Drawing.Size(95, 22)
        Me.cmbDAO.TabIndex = 6
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(88, 180)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(36, 16)
        Me.Label33.TabIndex = 96
        Me.Label33.Text = "DAO"
        '
        'Invoice
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PushpakBillingEngine.My.Resources.Resources.PushpakBack
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(975, 409)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.cmbBlock)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.cmbDAO)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtSld)
        Me.Controls.Add(Me.sld)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmbSelectProduct)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtIDate)
        Me.Controls.Add(Me.txtCDate)
        Me.Controls.Add(Me.cmbBranch)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbLessPaidBy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLine4)
        Me.Controls.Add(Me.txtLine3)
        Me.Controls.Add(Me.txtLine2)
        Me.Controls.Add(Me.txtCno)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtEno)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnDt2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtInvNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnDt1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtChallanNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLine1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblTag)
        Me.Controls.Add(Me.lblCTag)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Section"
        Me.pnlDetails.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLine1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtChallanNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDt1 As System.Windows.Forms.Button
    Friend WithEvents btnDt2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtInvNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCno As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtEno As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtLine2 As System.Windows.Forms.TextBox
    Friend WithEvents txtLine3 As System.Windows.Forms.TextBox
    Friend WithEvents txtLine4 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLessPaidBy As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCDate As System.Windows.Forms.TextBox
    Friend WithEvents txtIDate As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbSelectProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtSld As System.Windows.Forms.TextBox
    Friend WithEvents sld As DevComponents.DotNetBar.Controls.Slider
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTag As System.Windows.Forms.Label
    Friend WithEvents lblCTag As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cmbBlock As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cmbDAO As System.Windows.Forms.ComboBox
    Friend WithEvents Label33 As System.Windows.Forms.Label

End Class
