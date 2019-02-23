<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSale = New System.Windows.Forms.ToolStripButton()
        Me.btnEmp = New System.Windows.Forms.ToolStripButton()
        Me.btnCus = New System.Windows.Forms.ToolStripButton()
        Me.btnProduct = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.menuExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.menushowLevel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.menushowUser = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.menushowDate = New System.Windows.Forms.ToolStripLabel()
        Me.btncheckPro = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbltitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(0, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(1342, 52)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "ระบบจัดการร้าน"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSale, Me.btnEmp, Me.btnCus, Me.btnProduct, Me.ToolStripButton5, Me.ToolStripButton6, Me.btncheckPro, Me.menuExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 52)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1342, 153)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSale
        '
        Me.btnSale.AutoSize = False
        Me.btnSale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSale.Image = Global.ProjectVB.My.Resources.Resources.icons8_Sale_96px
        Me.btnSale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(150, 150)
        Me.btnSale.Text = "ขายไอศรีม"
        Me.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEmp
        '
        Me.btnEmp.AutoSize = False
        Me.btnEmp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEmp.Image = Global.ProjectVB.My.Resources.Resources.icons8_Conference_96px
        Me.btnEmp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEmp.Name = "btnEmp"
        Me.btnEmp.Size = New System.Drawing.Size(150, 150)
        Me.btnEmp.Text = "จัดการพนักงาน"
        Me.btnEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCus
        '
        Me.btnCus.AutoSize = False
        Me.btnCus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCus.Image = Global.ProjectVB.My.Resources.Resources.icons8_Queue_96px
        Me.btnCus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCus.Name = "btnCus"
        Me.btnCus.Size = New System.Drawing.Size(150, 150)
        Me.btnCus.Text = "จัดการลูกค้า"
        Me.btnCus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnProduct
        '
        Me.btnProduct.AutoSize = False
        Me.btnProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnProduct.Image = Global.ProjectVB.My.Resources.Resources.icons8_Shop_96px
        Me.btnProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(150, 150)
        Me.btnProduct.Text = "จัดการสินค้า"
        Me.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.AutoSize = False
        Me.ToolStripButton5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripButton5.Image = Global.ProjectVB.My.Resources.Resources.icons8_Edit_Property_96px
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(150, 150)
        Me.ToolStripButton5.Text = "จัดการวัตถุดิบ"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.AutoSize = False
        Me.ToolStripButton6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripButton6.Image = Global.ProjectVB.My.Resources.Resources.icons8_Search_Property_96px
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(150, 150)
        Me.ToolStripButton6.Text = "ตรวจสอบยอดขาย"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuExit
        '
        Me.menuExit.AutoSize = False
        Me.menuExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.menuExit.Image = Global.ProjectVB.My.Resources.Resources.icons8_Close_Program_96px
        Me.menuExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(150, 150)
        Me.menuExit.Text = "Exit"
        Me.menuExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.menushowLevel, Me.ToolStripLabel3, Me.menushowUser, Me.ToolStripLabel2, Me.menushowDate})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 661)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1342, 25)
        Me.ToolStrip2.TabIndex = 10
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripLabel1.Text = "ผู้เข้าใช้งาน :"
        '
        'menushowLevel
        '
        Me.menushowLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.menushowLevel.Name = "menushowLevel"
        Me.menushowLevel.Size = New System.Drawing.Size(37, 22)
        Me.menushowLevel.Text = "xxxx"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripLabel3.Text = "Username :"
        '
        'menushowUser
        '
        Me.menushowUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.menushowUser.Name = "menushowUser"
        Me.menushowUser.Size = New System.Drawing.Size(37, 22)
        Me.menushowUser.Text = "xxxx"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripLabel2.Text = "Date And Time:"
        '
        'menushowDate
        '
        Me.menushowDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.menushowDate.Name = "menushowDate"
        Me.menushowDate.Size = New System.Drawing.Size(37, 22)
        Me.menushowDate.Text = "xxxx"
        '
        'btncheckPro
        '
        Me.btncheckPro.AutoSize = False
        Me.btncheckPro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncheckPro.Image = Global.ProjectVB.My.Resources.Resources.icons8_Hand_With_Pen_96px
        Me.btncheckPro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btncheckPro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncheckPro.Name = "btncheckPro"
        Me.btncheckPro.Size = New System.Drawing.Size(150, 150)
        Me.btncheckPro.Text = "ตรวจสอบวัตถุดิบ"
        Me.btncheckPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1342, 686)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbltitle)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "ระบบจัดการ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitle As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnEmp As ToolStripButton
    Friend WithEvents btnSale As ToolStripButton
    Friend WithEvents btnCus As ToolStripButton
    Friend WithEvents btnProduct As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents menuExit As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents menushowLevel As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents menushowUser As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents menushowDate As ToolStripLabel
    Friend WithEvents btncheckPro As ToolStripButton
End Class
