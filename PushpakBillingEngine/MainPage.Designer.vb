<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.components = New System.ComponentModel.Container()
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.bnRefresh = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lnkMisc = New System.Windows.Forms.LinkLabel()
        Me.lnkInvoice = New System.Windows.Forms.LinkLabel()
        Me.lnkChallan = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.pnlImage = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.picCenter = New System.Windows.Forms.PictureBox()
        Me.pnlCenter = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlSlide = New System.Windows.Forms.Panel()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.pnlBase = New DevComponents.DotNetBar.PanelEx()
        Me.lnkTax = New System.Windows.Forms.LinkLabel()
        Me.ExpandablePanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlImage.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCenter.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSlide.SuspendLayout()
        Me.pnlBase.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExpandablePanel1.Controls.Add(Me.lnkTax)
        Me.ExpandablePanel1.Controls.Add(Me.bnRefresh)
        Me.ExpandablePanel1.Controls.Add(Me.PictureBox1)
        Me.ExpandablePanel1.Controls.Add(Me.lnkMisc)
        Me.ExpandablePanel1.Controls.Add(Me.lnkInvoice)
        Me.ExpandablePanel1.Controls.Add(Me.lnkChallan)
        Me.ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExpandablePanel1.ExpandButtonVisible = False
        Me.ExpandablePanel1.Location = New System.Drawing.Point(0, 0)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(200, 706)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 1
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Main Panel"
        '
        'bnRefresh
        '
        Me.bnRefresh.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnRefresh.Location = New System.Drawing.Point(46, 144)
        Me.bnRefresh.Name = "bnRefresh"
        Me.bnRefresh.Size = New System.Drawing.Size(104, 36)
        Me.bnRefresh.TabIndex = 5
        Me.bnRefresh.Text = "Refresh"
        Me.bnRefresh.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Image = Global.PushpakBillingEngine.My.Resources.Resources.developed_by_info_logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 656)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lnkMisc
        '
        Me.lnkMisc.AutoSize = True
        Me.lnkMisc.BackColor = System.Drawing.Color.Transparent
        Me.lnkMisc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkMisc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkMisc.LinkColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lnkMisc.Location = New System.Drawing.Point(46, 94)
        Me.lnkMisc.Name = "lnkMisc"
        Me.lnkMisc.Size = New System.Drawing.Size(104, 19)
        Me.lnkMisc.TabIndex = 3
        Me.lnkMisc.TabStop = True
        Me.lnkMisc.Text = "Spare Parts"
        '
        'lnkInvoice
        '
        Me.lnkInvoice.AutoSize = True
        Me.lnkInvoice.BackColor = System.Drawing.Color.Transparent
        Me.lnkInvoice.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkInvoice.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkInvoice.LinkColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lnkInvoice.Location = New System.Drawing.Point(34, 67)
        Me.lnkInvoice.Name = "lnkInvoice"
        Me.lnkInvoice.Size = New System.Drawing.Size(133, 19)
        Me.lnkInvoice.TabIndex = 2
        Me.lnkInvoice.TabStop = True
        Me.lnkInvoice.Text = "Invoice Section"
        '
        'lnkChallan
        '
        Me.lnkChallan.AutoSize = True
        Me.lnkChallan.BackColor = System.Drawing.Color.Transparent
        Me.lnkChallan.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkChallan.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkChallan.LinkColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lnkChallan.Location = New System.Drawing.Point(33, 40)
        Me.lnkChallan.Name = "lnkChallan"
        Me.lnkChallan.Size = New System.Drawing.Size(135, 19)
        Me.lnkChallan.TabIndex = 1
        Me.lnkChallan.TabStop = True
        Me.lnkChallan.Text = "Challan Section"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(46, 40)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(109, 16)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Challan Section"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.Location = New System.Drawing.Point(46, 40)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(109, 16)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Challan Section"
        '
        'bgWorker
        '
        '
        'pnlImage
        '
        Me.pnlImage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlImage.Controls.Add(Me.Label1)
        Me.pnlImage.Controls.Add(Me.pic1)
        Me.pnlImage.Location = New System.Drawing.Point(250, 128)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(200, 72)
        Me.pnlImage.TabIndex = 3
        Me.pnlImage.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Processing .."
        '
        'pic1
        '
        Me.pic1.Image = Global.PushpakBillingEngine.My.Resources.Resources.Loader
        Me.pic1.Location = New System.Drawing.Point(21, 44)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(159, 18)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'picCenter
        '
        Me.picCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCenter.Image = Global.PushpakBillingEngine.My.Resources.Resources.Slide1
        Me.picCenter.Location = New System.Drawing.Point(11, 11)
        Me.picCenter.Name = "picCenter"
        Me.picCenter.Size = New System.Drawing.Size(714, 217)
        Me.picCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCenter.TabIndex = 5
        Me.picCenter.TabStop = False
        '
        'pnlCenter
        '
        Me.pnlCenter.BackColor = System.Drawing.Color.DarkGray
        Me.pnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCenter.Controls.Add(Me.picCenter)
        Me.pnlCenter.Location = New System.Drawing.Point(3, 69)
        Me.pnlCenter.Name = "pnlCenter"
        Me.pnlCenter.Size = New System.Drawing.Size(737, 238)
        Me.pnlCenter.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.PushpakBillingEngine.My.Resources.Resources.V6nz9D
        Me.PictureBox2.Location = New System.Drawing.Point(10, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(714, 136)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'pnlSlide
        '
        Me.pnlSlide.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlSlide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSlide.Controls.Add(Me.PictureBox2)
        Me.pnlSlide.Location = New System.Drawing.Point(3, 313)
        Me.pnlSlide.Name = "pnlSlide"
        Me.pnlSlide.Size = New System.Drawing.Size(737, 156)
        Me.pnlSlide.TabIndex = 9
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'pnlBase
        '
        Me.pnlBase.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlBase.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlBase.Controls.Add(Me.pnlSlide)
        Me.pnlBase.Controls.Add(Me.pnlImage)
        Me.pnlBase.Controls.Add(Me.pnlCenter)
        Me.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBase.Location = New System.Drawing.Point(200, 0)
        Me.pnlBase.Name = "pnlBase"
        Me.pnlBase.Size = New System.Drawing.Size(743, 706)
        Me.pnlBase.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlBase.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlBase.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlBase.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlBase.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlBase.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlBase.Style.GradientAngle = 90
        Me.pnlBase.TabIndex = 11
        '
        'lnkTax
        '
        Me.lnkTax.AutoSize = True
        Me.lnkTax.BackColor = System.Drawing.Color.Transparent
        Me.lnkTax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkTax.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkTax.LinkColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lnkTax.Location = New System.Drawing.Point(48, 121)
        Me.lnkTax.Name = "lnkTax"
        Me.lnkTax.Size = New System.Drawing.Size(105, 19)
        Me.lnkTax.TabIndex = 6
        Me.lnkTax.TabStop = True
        Me.lnkTax.Text = "Tax Section"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BackgroundImage = Global.PushpakBillingEngine.My.Resources.Resources.PushpakBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(943, 706)
        Me.Controls.Add(Me.pnlBase)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pushpak Traders Billing Client"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.ExpandablePanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlImage.ResumeLayout(False)
        Me.pnlImage.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCenter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCenter.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSlide.ResumeLayout(False)
        Me.pnlBase.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lnkInvoice As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkChallan As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkMisc As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Private WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnlImage As System.Windows.Forms.Panel
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picCenter As System.Windows.Forms.PictureBox
    Friend WithEvents pnlCenter As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlSlide As System.Windows.Forms.Panel
    Friend WithEvents bnRefresh As System.Windows.Forms.Button
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents pnlBase As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lnkTax As System.Windows.Forms.LinkLabel
End Class
