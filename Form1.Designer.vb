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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBookNow = New System.Windows.Forms.Button()
        Me.lblAboutUs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(176, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 190)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SEGAR AMAT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CINEMA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBookNow
        '
        Me.btnBookNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBookNow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookNow.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookNow.Location = New System.Drawing.Point(280, 372)
        Me.btnBookNow.Name = "btnBookNow"
        Me.btnBookNow.Size = New System.Drawing.Size(342, 73)
        Me.btnBookNow.TabIndex = 1
        Me.btnBookNow.Text = "LOGIN"
        Me.btnBookNow.UseVisualStyleBackColor = False
        '
        'lblAboutUs
        '
        Me.lblAboutUs.AutoSize = True
        Me.lblAboutUs.BackColor = System.Drawing.Color.Transparent
        Me.lblAboutUs.Cursor = System.Windows.Forms.Cursors.Help
        Me.lblAboutUs.Font = New System.Drawing.Font("Tahoma", 13.8!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutUs.ForeColor = System.Drawing.Color.Blue
        Me.lblAboutUs.Location = New System.Drawing.Point(398, 460)
        Me.lblAboutUs.Name = "lblAboutUs"
        Me.lblAboutUs.Size = New System.Drawing.Size(104, 28)
        Me.lblAboutUs.TabIndex = 2
        Me.lblAboutUs.Text = "About Us"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CINEMA_TICKETING_SYSTEM_FINAL.My.Resources.Resources.bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(909, 766)
        Me.Controls.Add(Me.lblAboutUs)
        Me.Controls.Add(Me.btnBookNow)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Main Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBookNow As Button
    Friend WithEvents lblAboutUs As Label
End Class
