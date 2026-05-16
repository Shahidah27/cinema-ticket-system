<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.radPremium = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQtySeat = New System.Windows.Forms.TextBox()
        Me.txtSeat = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCardNum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.radDuitNow = New System.Windows.Forms.RadioButton()
        Me.radApplePay = New System.Windows.Forms.RadioButton()
        Me.radBoost = New System.Windows.Forms.RadioButton()
        Me.radBanking = New System.Windows.Forms.RadioButton()
        Me.radCard = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PeachPuff
        Me.Label1.Location = New System.Drawing.Point(413, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(784, 595)
        Me.Label1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.BurlyWood
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.radStandard)
        Me.GroupBox1.Controls.Add(Me.radPremium)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(439, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 132)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seat Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "(RM 25)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "(RM 15)"
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.BackColor = System.Drawing.Color.BurlyWood
        Me.radStandard.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStandard.Location = New System.Drawing.Point(21, 34)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(127, 29)
        Me.radStandard.TabIndex = 2
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard"
        Me.radStandard.UseVisualStyleBackColor = False
        '
        'radPremium
        '
        Me.radPremium.AutoSize = True
        Me.radPremium.BackColor = System.Drawing.Color.BurlyWood
        Me.radPremium.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPremium.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.radPremium.Location = New System.Drawing.Point(21, 78)
        Me.radPremium.Name = "radPremium"
        Me.radPremium.Size = New System.Drawing.Size(125, 29)
        Me.radPremium.TabIndex = 3
        Me.radPremium.TabStop = True
        Me.radPremium.Text = "Premium"
        Me.radPremium.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PeachPuff
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(749, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 24)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Number of seat: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.PeachPuff
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(739, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 48)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Seat Number(s) : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[exp: 21,22] "
        '
        'txtQtySeat
        '
        Me.txtQtySeat.Location = New System.Drawing.Point(915, 77)
        Me.txtQtySeat.Name = "txtQtySeat"
        Me.txtQtySeat.Size = New System.Drawing.Size(254, 22)
        Me.txtQtySeat.TabIndex = 39
        '
        'txtSeat
        '
        Me.txtSeat.Location = New System.Drawing.Point(915, 138)
        Me.txtSeat.Name = "txtSeat"
        Me.txtSeat.Size = New System.Drawing.Size(254, 22)
        Me.txtSeat.TabIndex = 40
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.BurlyWood
        Me.GroupBox2.Controls.Add(Me.txtCardNum)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtBank)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.radDuitNow)
        Me.GroupBox2.Controls.Add(Me.radApplePay)
        Me.GroupBox2.Controls.Add(Me.radBoost)
        Me.GroupBox2.Controls.Add(Me.radBanking)
        Me.GroupBox2.Controls.Add(Me.radCard)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(439, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(730, 279)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment"
        '
        'txtCardNum
        '
        Me.txtCardNum.Location = New System.Drawing.Point(194, 129)
        Me.txtCardNum.Name = "txtCardNum"
        Me.txtCardNum.Size = New System.Drawing.Size(219, 27)
        Me.txtCardNum.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.BurlyWood
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 22)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Card Number:"
        '
        'txtBank
        '
        Me.txtBank.Location = New System.Drawing.Point(194, 61)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(219, 27)
        Me.txtBank.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.BurlyWood
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(127, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 22)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Bank: "
        '
        'radDuitNow
        '
        Me.radDuitNow.AutoSize = True
        Me.radDuitNow.BackColor = System.Drawing.Color.BurlyWood
        Me.radDuitNow.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDuitNow.Location = New System.Drawing.Point(21, 204)
        Me.radDuitNow.Name = "radDuitNow"
        Me.radDuitNow.Size = New System.Drawing.Size(169, 29)
        Me.radDuitNow.TabIndex = 6
        Me.radDuitNow.TabStop = True
        Me.radDuitNow.Text = "Duit Now QR"
        Me.radDuitNow.UseVisualStyleBackColor = False
        '
        'radApplePay
        '
        Me.radApplePay.AutoSize = True
        Me.radApplePay.BackColor = System.Drawing.Color.BurlyWood
        Me.radApplePay.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radApplePay.Location = New System.Drawing.Point(21, 167)
        Me.radApplePay.Name = "radApplePay"
        Me.radApplePay.Size = New System.Drawing.Size(135, 29)
        Me.radApplePay.TabIndex = 5
        Me.radApplePay.TabStop = True
        Me.radApplePay.Text = "Apple Pay"
        Me.radApplePay.UseVisualStyleBackColor = False
        '
        'radBoost
        '
        Me.radBoost.AutoSize = True
        Me.radBoost.BackColor = System.Drawing.Color.BurlyWood
        Me.radBoost.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBoost.Location = New System.Drawing.Point(21, 242)
        Me.radBoost.Name = "radBoost"
        Me.radBoost.Size = New System.Drawing.Size(158, 29)
        Me.radBoost.TabIndex = 4
        Me.radBoost.TabStop = True
        Me.radBoost.Text = "Boost Wallet"
        Me.radBoost.UseVisualStyleBackColor = False
        '
        'radBanking
        '
        Me.radBanking.AutoSize = True
        Me.radBanking.BackColor = System.Drawing.Color.BurlyWood
        Me.radBanking.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBanking.Location = New System.Drawing.Point(21, 26)
        Me.radBanking.Name = "radBanking"
        Me.radBanking.Size = New System.Drawing.Size(187, 29)
        Me.radBanking.TabIndex = 2
        Me.radBanking.TabStop = True
        Me.radBanking.Text = "Online Banking"
        Me.radBanking.UseVisualStyleBackColor = False
        '
        'radCard
        '
        Me.radCard.AutoSize = True
        Me.radCard.BackColor = System.Drawing.Color.BurlyWood
        Me.radCard.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.radCard.Location = New System.Drawing.Point(21, 94)
        Me.radCard.Name = "radCard"
        Me.radCard.Size = New System.Drawing.Size(215, 29)
        Me.radCard.TabIndex = 3
        Me.radCard.TabStop = True
        Me.radCard.Text = "Credit/Debit Card"
        Me.radCard.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(439, 545)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(730, 70)
        Me.btnConfirm.TabIndex = 41
        Me.btnConfirm.Text = "CONFIRM PAYMENT?"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 31.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MistyRose
        Me.Label8.Location = New System.Drawing.Point(31, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(320, 130)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "TICKET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PURCHASE"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(31, 611)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(123, 33)
        Me.btnBack.TabIndex = 43
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(743, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(426, 37)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "ADD FOOD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.PeachPuff
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(450, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(270, 24)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = ">>Do you want to add food?"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CINEMA_TICKETING_SYSTEM_FINAL.My.Resources.Resources.bggggggg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1240, 678)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtSeat)
        Me.Controls.Add(Me.txtQtySeat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.Text = "Ticket Purchasing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents radPremium As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQtySeat As TextBox
    Friend WithEvents txtSeat As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radBoost As RadioButton
    Friend WithEvents radBanking As RadioButton
    Friend WithEvents radCard As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents radDuitNow As RadioButton
    Friend WithEvents radApplePay As RadioButton
    Friend WithEvents txtBank As TextBox
    Friend WithEvents txtCardNum As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
End Class
