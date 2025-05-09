<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.cboDuration = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.chkWaiver = New System.Windows.Forms.CheckBox()
        Me.chkInsurance = New System.Windows.Forms.CheckBox()
        Me.btnCalulate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lstEquipment = New System.Windows.Forms.ListBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDuration
        '
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Items.AddRange(New Object() {"1 day", "2 days", "3 days", "1 week", "2 weeks"})
        Me.cboDuration.Location = New System.Drawing.Point(195, 50)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(164, 21)
        Me.cboDuration.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select all Equipment to  be Rented "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Deposit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(409, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tax"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(409, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Subtotal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Rental duration"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(409, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Bal due"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(494, 16)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 13)
        Me.lblDate.TabIndex = 9
        Me.lblDate.Text = "Label9"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(488, 58)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(48, 15)
        Me.lblSubtotal.TabIndex = 12
        Me.lblSubtotal.Text = "      0.00"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(485, 92)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(48, 15)
        Me.lblTax.TabIndex = 14
        Me.lblTax.Text = "      0.00"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Location = New System.Drawing.Point(485, 173)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(48, 15)
        Me.lblBalance.TabIndex = 15
        Me.lblBalance.Text = "      0.00"
        '
        'chkWaiver
        '
        Me.chkWaiver.AutoSize = True
        Me.chkWaiver.Location = New System.Drawing.Point(200, 132)
        Me.chkWaiver.Name = "chkWaiver"
        Me.chkWaiver.Size = New System.Drawing.Size(94, 17)
        Me.chkWaiver.TabIndex = 16
        Me.chkWaiver.Text = "Liability waiver"
        Me.chkWaiver.UseVisualStyleBackColor = True
        '
        'chkInsurance
        '
        Me.chkInsurance.AutoSize = True
        Me.chkInsurance.Location = New System.Drawing.Point(200, 94)
        Me.chkInsurance.Name = "chkInsurance"
        Me.chkInsurance.Size = New System.Drawing.Size(115, 17)
        Me.chkInsurance.TabIndex = 17
        Me.chkInsurance.Text = "Damage insurance"
        Me.chkInsurance.UseVisualStyleBackColor = True
        '
        'btnCalulate
        '
        Me.btnCalulate.Location = New System.Drawing.Point(170, 183)
        Me.btnCalulate.Name = "btnCalulate"
        Me.btnCalulate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalulate.TabIndex = 18
        Me.btnCalulate.Text = "Calculate"
        Me.btnCalulate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(284, 183)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'lstEquipment
        '
        Me.lstEquipment.FormattingEnabled = True
        Me.lstEquipment.Items.AddRange(New Object() {"Skis, beginner", "Skis, advanced", "Snowboard, beginner", "Snowboard, advanced", "Ski boots", "Snowboard boots", "Helmet, stadard", "Helmet, deluxe"})
        Me.lstEquipment.Location = New System.Drawing.Point(12, 50)
        Me.lstEquipment.Name = "lstEquipment"
        Me.lstEquipment.Size = New System.Drawing.Size(120, 108)
        Me.lstEquipment.TabIndex = 20
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(26, 192)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(89, 13)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Weather forecast"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(472, 133)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(71, 20)
        Me.txtDeposit.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 230)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lstEquipment)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalulate)
        Me.Controls.Add(Me.chkInsurance)
        Me.Controls.Add(Me.chkWaiver)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboDuration)
        Me.Name = "Form1"
        Me.Text = "Winter Sport Rentals"
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboDuration As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents chkWaiver As CheckBox
    Friend WithEvents chkInsurance As CheckBox
    Friend WithEvents btnCalulate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents errorProvider As ErrorProvider
    Friend WithEvents lstEquipment As ListBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtDeposit As TextBox
End Class
