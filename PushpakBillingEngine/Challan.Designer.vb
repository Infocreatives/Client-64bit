<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Challan
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtChallanNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDt1 = New System.Windows.Forms.Button()
        Me.txtLine4 = New System.Windows.Forms.TextBox()
        Me.txtLine3 = New System.Windows.Forms.TextBox()
        Me.txtLine2 = New System.Windows.Forms.TextBox()
        Me.txtLine1 = New System.Windows.Forms.TextBox()
        Me.btnDt2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPaymentDetails = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtChallanDate = New System.Windows.Forms.TextBox()
        Me.txtOrderDate = New System.Windows.Forms.TextBox()
        Me.txtCno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEno = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.cmbSelectProduct = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSld = New System.Windows.Forms.TextBox()
        Me.sld = New DevComponents.DotNetBar.Controls.Slider()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblCTag = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmbBlock = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmbDAO = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbLessPaidBy = New System.Windows.Forms.ComboBox()
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
        Me.btnPrint.Location = New System.Drawing.Point(379, 417)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(62, 30)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(395, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Challan No. :"
        '
        'txtChallanNo
        '
        Me.txtChallanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChallanNo.Enabled = False
        Me.txtChallanNo.Location = New System.Drawing.Point(485, 140)
        Me.txtChallanNo.MaxLength = 14
        Me.txtChallanNo.Name = "txtChallanNo"
        Me.txtChallanNo.Size = New System.Drawing.Size(223, 22)
        Me.txtChallanNo.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(579, 165)
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
        Me.Label6.Location = New System.Drawing.Point(384, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Challan Date :"
        '
        'btnDt1
        '
        Me.btnDt1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDt1.Location = New System.Drawing.Point(681, 185)
        Me.btnDt1.Name = "btnDt1"
        Me.btnDt1.Size = New System.Drawing.Size(27, 23)
        Me.btnDt1.TabIndex = 11
        Me.btnDt1.Text = "..."
        Me.btnDt1.UseVisualStyleBackColor = True
        '
        'txtLine4
        '
        Me.txtLine4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLine4.Enabled = False
        Me.txtLine4.Location = New System.Drawing.Point(126, 213)
        Me.txtLine4.MaxLength = 50
        Me.txtLine4.Name = "txtLine4"
        Me.txtLine4.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLine4.Size = New System.Drawing.Size(223, 22)
        Me.txtLine4.TabIndex = 7
        Me.txtLine4.Tag = ""
        '
        'txtLine3
        '
        Me.txtLine3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLine3.Location = New System.Drawing.Point(126, 157)
        Me.txtLine3.MaxLength = 50
        Me.txtLine3.Name = "txtLine3"
        Me.txtLine3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLine3.Size = New System.Drawing.Size(223, 22)
        Me.txtLine3.TabIndex = 4
        Me.txtLine3.Tag = ""
        '
        'txtLine2
        '
        Me.txtLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLine2.Location = New System.Drawing.Point(126, 129)
        Me.txtLine2.MaxLength = 50
        Me.txtLine2.Name = "txtLine2"
        Me.txtLine2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLine2.Size = New System.Drawing.Size(223, 22)
        Me.txtLine2.TabIndex = 3
        Me.txtLine2.Tag = ""
        '
        'txtLine1
        '
        Me.txtLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLine1.Location = New System.Drawing.Point(126, 101)
        Me.txtLine1.MaxLength = 50
        Me.txtLine1.Name = "txtLine1"
        Me.txtLine1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLine1.Size = New System.Drawing.Size(223, 22)
        Me.txtLine1.TabIndex = 2
        Me.txtLine1.Tag = ""
        '
        'btnDt2
        '
        Me.btnDt2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDt2.Location = New System.Drawing.Point(681, 240)
        Me.btnDt2.Name = "btnDt2"
        Me.btnDt2.Size = New System.Drawing.Size(27, 23)
        Me.btnDt2.TabIndex = 12
        Me.btnDt2.Text = "..."
        Me.btnDt2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(393, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Order Date :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(123, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 14)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "20 Characters at most"
        '
        'txtOrderNo
        '
        Me.txtOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrderNo.Location = New System.Drawing.Point(126, 241)
        Me.txtOrderNo.MaxLength = 20
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(223, 22)
        Me.txtOrderNo.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Order No. :"
        '
        'txtPaymentDetails
        '
        Me.txtPaymentDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaymentDetails.Location = New System.Drawing.Point(10, 340)
        Me.txtPaymentDetails.MaxLength = 200
        Me.txtPaymentDetails.Multiline = True
        Me.txtPaymentDetails.Name = "txtPaymentDetails"
        Me.txtPaymentDetails.Size = New System.Drawing.Size(478, 66)
        Me.txtPaymentDetails.TabIndex = 14
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 323)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 14)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Payment Details :"
        '
        'txtChallanDate
        '
        Me.txtChallanDate.BackColor = System.Drawing.Color.White
        Me.txtChallanDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChallanDate.Location = New System.Drawing.Point(485, 185)
        Me.txtChallanDate.Name = "txtChallanDate"
        Me.txtChallanDate.ReadOnly = True
        Me.txtChallanDate.Size = New System.Drawing.Size(190, 22)
        Me.txtChallanDate.TabIndex = 44
        '
        'txtOrderDate
        '
        Me.txtOrderDate.BackColor = System.Drawing.Color.White
        Me.txtOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrderDate.Location = New System.Drawing.Point(485, 241)
        Me.txtOrderDate.Name = "txtOrderDate"
        Me.txtOrderDate.ReadOnly = True
        Me.txtOrderDate.Size = New System.Drawing.Size(190, 22)
        Me.txtOrderDate.TabIndex = 45
        '
        'txtCno
        '
        Me.txtCno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCno.Location = New System.Drawing.Point(485, 283)
        Me.txtCno.MaxLength = 30
        Me.txtCno.Name = "txtCno"
        Me.txtCno.Size = New System.Drawing.Size(223, 22)
        Me.txtCno.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(393, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Chassis No. :"
        '
        'txtEno
        '
        Me.txtEno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEno.Location = New System.Drawing.Point(126, 283)
        Me.txtEno.MaxLength = 30
        Me.txtEno.Name = "txtEno"
        Me.txtEno.Size = New System.Drawing.Size(223, 22)
        Me.txtEno.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(40, 287)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 16)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Engine No. :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(376, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 16)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Select Branch :"
        '
        'cmbBranch
        '
        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Items.AddRange(New Object() {"Baripada Branch", "Keonjhargarh Branch", "Rairangpur Branch"})
        Me.cmbBranch.Location = New System.Drawing.Point(485, 42)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(223, 22)
        Me.cmbBranch.TabIndex = 1
        '
        'cmbSelectProduct
        '
        Me.cmbSelectProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectProduct.FormattingEnabled = True
        Me.cmbSelectProduct.Location = New System.Drawing.Point(126, 42)
        Me.cmbSelectProduct.Name = "cmbSelectProduct"
        Me.cmbSelectProduct.Size = New System.Drawing.Size(223, 22)
        Me.cmbSelectProduct.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 16)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Choose Product :"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(442, 417)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(62, 30)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(505, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 30)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(714, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 14)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(714, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 14)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(714, 283)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 14)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(714, 185)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 14)
        Me.Label20.TabIndex = 60
        Me.Label20.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(355, 283)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(14, 14)
        Me.Label21.TabIndex = 61
        Me.Label21.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(355, 42)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 14)
        Me.Label22.TabIndex = 62
        Me.Label22.Text = "*"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(491, 342)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 14)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(657, 343)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 14)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "Down"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(555, 343)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 14)
        Me.Label16.TabIndex = 67
        Me.Label16.Text = "Up"
        '
        'txtSld
        '
        Me.txtSld.BackColor = System.Drawing.Color.White
        Me.txtSld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSld.Location = New System.Drawing.Point(599, 360)
        Me.txtSld.Name = "txtSld"
        Me.txtSld.ReadOnly = True
        Me.txtSld.Size = New System.Drawing.Size(38, 22)
        Me.txtSld.TabIndex = 66
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
        Me.sld.Location = New System.Drawing.Point(580, 339)
        Me.sld.Maximum = 15
        Me.sld.Minimum = -15
        Me.sld.Name = "sld"
        Me.sld.Size = New System.Drawing.Size(77, 23)
        Me.sld.Step = 5
        Me.sld.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sld.TabIndex = 18
        Me.sld.Value = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(578, 323)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 14)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "Adjustment"
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
        Me.pnlDetails.Location = New System.Drawing.Point(734, 42)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(200, 118)
        Me.pnlDetails.TabIndex = 69
        Me.pnlDetails.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(198, 28)
        Me.Panel3.TabIndex = 70
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(45, 7)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(108, 14)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "Current Amount"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.lblVat)
        Me.Panel2.Controls.Add(Me.lblAmount)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Label26)
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
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(22, 12)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(68, 16)
        Me.Label26.TabIndex = 51
        Me.Label26.Text = "Amount :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Location = New System.Drawing.Point(4, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(929, 25)
        Me.Panel1.TabIndex = 84
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(396, 3)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(135, 19)
        Me.Label30.TabIndex = 82
        Me.Label30.Text = "Challan Section"
        '
        'lblCTag
        '
        Me.lblCTag.AutoSize = True
        Me.lblCTag.BackColor = System.Drawing.Color.Transparent
        Me.lblCTag.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCTag.Location = New System.Drawing.Point(482, 144)
        Me.lblCTag.Name = "lblCTag"
        Me.lblCTag.Size = New System.Drawing.Size(21, 14)
        Me.lblCTag.TabIndex = 88
        Me.lblCTag.Text = "R-"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(87, 214)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 16)
        Me.Label29.TabIndex = 98
        Me.Label29.Text = "Dist"
        '
        'cmbBlock
        '
        Me.cmbBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBlock.FormattingEnabled = True
        Me.cmbBlock.Location = New System.Drawing.Point(260, 185)
        Me.cmbBlock.Name = "cmbBlock"
        Me.cmbBlock.Size = New System.Drawing.Size(89, 22)
        Me.cmbBlock.TabIndex = 6
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(217, 189)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(41, 16)
        Me.Label31.TabIndex = 97
        Me.Label31.Text = "Block"
        '
        'cmbDAO
        '
        Me.cmbDAO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDAO.FormattingEnabled = True
        Me.cmbDAO.Location = New System.Drawing.Point(126, 185)
        Me.cmbDAO.Name = "cmbDAO"
        Me.cmbDAO.Size = New System.Drawing.Size(89, 22)
        Me.cmbDAO.TabIndex = 5
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(84, 188)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(36, 16)
        Me.Label32.TabIndex = 96
        Me.Label32.Text = "DAO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(227, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 14)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "*"
        '
        'cmbLessPaidBy
        '
        Me.cmbLessPaidBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLessPaidBy.FormattingEnabled = True
        Me.cmbLessPaidBy.Items.AddRange(New Object() {"Bank", "Party"})
        Me.cmbLessPaidBy.Location = New System.Drawing.Point(126, 70)
        Me.cmbLessPaidBy.Name = "cmbLessPaidBy"
        Me.cmbLessPaidBy.Size = New System.Drawing.Size(95, 22)
        Me.cmbLessPaidBy.TabIndex = 99
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(26, 73)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(97, 16)
        Me.Label33.TabIndex = 100
        Me.Label33.Text = "Less Paid By :"
        '
        'Challan
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PushpakBillingEngine.My.Resources.Resources.PushpakBack
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(940, 464)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbLessPaidBy)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.cmbBlock)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.cmbDAO)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtSld)
        Me.Controls.Add(Me.sld)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cmbSelectProduct)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbBranch)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEno)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtOrderDate)
        Me.Controls.Add(Me.txtChallanDate)
        Me.Controls.Add(Me.txtPaymentDetails)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btnDt2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtOrderNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtLine4)
        Me.Controls.Add(Me.txtLine3)
        Me.Controls.Add(Me.txtLine2)
        Me.Controls.Add(Me.txtLine1)
        Me.Controls.Add(Me.btnDt1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtChallanNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblCTag)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Challan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Challan Print"
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtChallanNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDt1 As System.Windows.Forms.Button
    Friend WithEvents txtLine4 As System.Windows.Forms.TextBox
    Friend WithEvents txtLine3 As System.Windows.Forms.TextBox
    Friend WithEvents txtLine2 As System.Windows.Forms.TextBox
    Friend WithEvents txtLine1 As System.Windows.Forms.TextBox
    Friend WithEvents btnDt2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtChallanDate As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderDate As System.Windows.Forms.TextBox
    Friend WithEvents txtCno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEno As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSelectProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSld As System.Windows.Forms.TextBox
    Friend WithEvents sld As DevComponents.DotNetBar.Controls.Slider
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblCTag As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmbBlock As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cmbDAO As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLessPaidBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label33 As System.Windows.Forms.Label

End Class
