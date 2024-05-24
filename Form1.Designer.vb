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
        Me.rad800min = New System.Windows.Forms.RadioButton()
        Me.rad1500min = New System.Windows.Forms.RadioButton()
        Me.radUnlimitedTalk = New System.Windows.Forms.RadioButton()
        Me.radSamsung = New System.Windows.Forms.RadioButton()
        Me.radIphone = New System.Windows.Forms.RadioButton()
        Me.radCustmerPhone = New System.Windows.Forms.RadioButton()
        Me.chckUnlimitedText = New System.Windows.Forms.CheckBox()
        Me.chckVideoChat = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblMonthlyTotal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'rad800min
        '
        Me.rad800min.AutoSize = True
        Me.rad800min.Location = New System.Drawing.Point(23, 30)
        Me.rad800min.Name = "rad800min"
        Me.rad800min.Size = New System.Drawing.Size(161, 17)
        Me.rad800min.TabIndex = 0
        Me.rad800min.TabStop = True
        Me.rad800min.Text = "800 minutes:          $19.99/m"
        Me.rad800min.UseVisualStyleBackColor = True
        '
        'rad1500min
        '
        Me.rad1500min.AutoSize = True
        Me.rad1500min.Location = New System.Drawing.Point(23, 53)
        Me.rad1500min.Name = "rad1500min"
        Me.rad1500min.Size = New System.Drawing.Size(161, 17)
        Me.rad1500min.TabIndex = 1
        Me.rad1500min.TabStop = True
        Me.rad1500min.Text = "1500 minutes:        $28.99/m"
        Me.rad1500min.UseVisualStyleBackColor = True
        '
        'radUnlimitedTalk
        '
        Me.radUnlimitedTalk.AutoSize = True
        Me.radUnlimitedTalk.Location = New System.Drawing.Point(23, 76)
        Me.radUnlimitedTalk.Name = "radUnlimitedTalk"
        Me.radUnlimitedTalk.Size = New System.Drawing.Size(161, 17)
        Me.radUnlimitedTalk.TabIndex = 2
        Me.radUnlimitedTalk.TabStop = True
        Me.radUnlimitedTalk.Text = "Unlimited talk:        $39.99/m"
        Me.radUnlimitedTalk.UseVisualStyleBackColor = True
        '
        'radSamsung
        '
        Me.radSamsung.AutoSize = True
        Me.radSamsung.Location = New System.Drawing.Point(21, 26)
        Me.radSamsung.Name = "radSamsung"
        Me.radSamsung.Size = New System.Drawing.Size(160, 17)
        Me.radSamsung.TabIndex = 3
        Me.radSamsung.TabStop = True
        Me.radSamsung.Text = "Samsung:              $29.99/m"
        Me.radSamsung.UseVisualStyleBackColor = True
        '
        'radIphone
        '
        Me.radIphone.AutoSize = True
        Me.radIphone.Location = New System.Drawing.Point(21, 49)
        Me.radIphone.Name = "radIphone"
        Me.radIphone.Size = New System.Drawing.Size(161, 17)
        Me.radIphone.TabIndex = 4
        Me.radIphone.TabStop = True
        Me.radIphone.Text = "iPhone 15:             $39.99/m"
        Me.radIphone.UseVisualStyleBackColor = True
        '
        'radCustmerPhone
        '
        Me.radCustmerPhone.AutoSize = True
        Me.radCustmerPhone.Checked = True
        Me.radCustmerPhone.Location = New System.Drawing.Point(21, 72)
        Me.radCustmerPhone.Name = "radCustmerPhone"
        Me.radCustmerPhone.Size = New System.Drawing.Size(161, 17)
        Me.radCustmerPhone.TabIndex = 5
        Me.radCustmerPhone.TabStop = True
        Me.radCustmerPhone.Text = "Customer Phone:     $0.00/m"
        Me.radCustmerPhone.UseVisualStyleBackColor = True
        '
        'chckUnlimitedText
        '
        Me.chckUnlimitedText.AutoSize = True
        Me.chckUnlimitedText.Location = New System.Drawing.Point(23, 28)
        Me.chckUnlimitedText.Name = "chckUnlimitedText"
        Me.chckUnlimitedText.Size = New System.Drawing.Size(163, 17)
        Me.chckUnlimitedText.TabIndex = 6
        Me.chckUnlimitedText.Text = "Unlimited Text:       $10.00/m"
        Me.chckUnlimitedText.UseVisualStyleBackColor = True
        '
        'chckVideoChat
        '
        Me.chckVideoChat.AutoSize = True
        Me.chckVideoChat.Location = New System.Drawing.Point(23, 61)
        Me.chckVideoChat.Name = "chckVideoChat"
        Me.chckVideoChat.Size = New System.Drawing.Size(163, 17)
        Me.chckVideoChat.TabIndex = 7
        Me.chckVideoChat.Text = "Video Chat:            $15.00/m"
        Me.chckVideoChat.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(63, 308)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(85, 24)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "OK"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(225, 308)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 24)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(387, 308)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 24)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(116, 15)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(66, 19)
        Me.lblSubtotal.TabIndex = 11
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(116, 41)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(66, 19)
        Me.lblTax.TabIndex = 12
        '
        'lblMonthlyTotal
        '
        Me.lblMonthlyTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthlyTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyTotal.Location = New System.Drawing.Point(116, 65)
        Me.lblMonthlyTotal.Name = "lblMonthlyTotal"
        Me.lblMonthlyTotal.Size = New System.Drawing.Size(66, 19)
        Me.lblMonthlyTotal.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radUnlimitedTalk)
        Me.GroupBox1.Controls.Add(Me.rad1500min)
        Me.GroupBox1.Controls.Add(Me.rad800min)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 116)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plans"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radCustmerPhone)
        Me.GroupBox2.Controls.Add(Me.radIphone)
        Me.GroupBox2.Controls.Add(Me.radSamsung)
        Me.GroupBox2.Location = New System.Drawing.Point(290, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 116)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Phones"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chckVideoChat)
        Me.GroupBox3.Controls.Add(Me.chckUnlimitedText)
        Me.GroupBox3.Location = New System.Drawing.Point(40, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(205, 100)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Subtotal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Tax:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Monthyl Total:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.lblMonthlyTotal)
        Me.GroupBox4.Controls.Add(Me.lblTax)
        Me.GroupBox4.Controls.Add(Me.lblSubtotal)
        Me.GroupBox4.Location = New System.Drawing.Point(290, 170)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(205, 100)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Monthly Payment"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 367)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cell Phone Company"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rad800min As RadioButton
    Friend WithEvents rad1500min As RadioButton
    Friend WithEvents radUnlimitedTalk As RadioButton
    Friend WithEvents radSamsung As RadioButton
    Friend WithEvents radIphone As RadioButton
    Friend WithEvents radCustmerPhone As RadioButton
    Friend WithEvents chckUnlimitedText As CheckBox
    Friend WithEvents chckVideoChat As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblMonthlyTotal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
End Class
