<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnFairmontCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFairTotComm = New System.Windows.Forms.Label()
        Me.lblFairTotSales = New System.Windows.Forms.Label()
        Me.txtAKSales = New System.Windows.Forms.TextBox()
        Me.txtINSales = New System.Windows.Forms.TextBox()
        Me.txtILSales = New System.Windows.Forms.TextBox()
        Me.txtLoanPmt = New System.Windows.Forms.TextBox()
        Me.txtInsPayment = New System.Windows.Forms.TextBox()
        Me.txtOilChange = New System.Windows.Forms.TextBox()
        Me.txtMaintenance = New System.Windows.Forms.TextBox()
        Me.txtCarWash = New System.Windows.Forms.TextBox()
        Me.txtGas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblCarMonthlyTotal = New System.Windows.Forms.Label()
        Me.lblCarYearlyTotal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCarCalculate = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Illinois sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "I&ndiana sales:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Alaska sales:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total sales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total commission:"
        '
        'btnFairmontCalculate
        '
        Me.btnFairmontCalculate.Location = New System.Drawing.Point(113, 172)
        Me.btnFairmontCalculate.Name = "btnFairmontCalculate"
        Me.btnFairmontCalculate.Size = New System.Drawing.Size(100, 20)
        Me.btnFairmontCalculate.TabIndex = 5
        Me.btnFairmontCalculate.Text = "&Calculate"
        Me.btnFairmontCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(126, 249)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 20)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFairTotComm)
        Me.GroupBox1.Controls.Add(Me.lblFairTotSales)
        Me.GroupBox1.Controls.Add(Me.txtAKSales)
        Me.GroupBox1.Controls.Add(Me.txtINSales)
        Me.GroupBox1.Controls.Add(Me.txtILSales)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnFairmontCalculate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 212)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fairmont Sales"
        '
        'lblFairTotComm
        '
        Me.lblFairTotComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFairTotComm.Location = New System.Drawing.Point(113, 142)
        Me.lblFairTotComm.Name = "lblFairTotComm"
        Me.lblFairTotComm.Size = New System.Drawing.Size(100, 20)
        Me.lblFairTotComm.TabIndex = 10
        Me.lblFairTotComm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFairTotSales
        '
        Me.lblFairTotSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFairTotSales.Location = New System.Drawing.Point(113, 111)
        Me.lblFairTotSales.Name = "lblFairTotSales"
        Me.lblFairTotSales.Size = New System.Drawing.Size(100, 20)
        Me.lblFairTotSales.TabIndex = 9
        Me.lblFairTotSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAKSales
        '
        Me.txtAKSales.Location = New System.Drawing.Point(113, 83)
        Me.txtAKSales.Name = "txtAKSales"
        Me.txtAKSales.Size = New System.Drawing.Size(100, 20)
        Me.txtAKSales.TabIndex = 8
        Me.txtAKSales.Text = "50000.00"
        Me.txtAKSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtINSales
        '
        Me.txtINSales.Location = New System.Drawing.Point(113, 57)
        Me.txtINSales.Name = "txtINSales"
        Me.txtINSales.Size = New System.Drawing.Size(100, 20)
        Me.txtINSales.TabIndex = 7
        Me.txtINSales.Text = "30000.00"
        Me.txtINSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtILSales
        '
        Me.txtILSales.Location = New System.Drawing.Point(113, 30)
        Me.txtILSales.Name = "txtILSales"
        Me.txtILSales.Size = New System.Drawing.Size(100, 20)
        Me.txtILSales.TabIndex = 6
        Me.txtILSales.Text = "20000.00"
        Me.txtILSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLoanPmt
        '
        Me.txtLoanPmt.Location = New System.Drawing.Point(112, 16)
        Me.txtLoanPmt.Name = "txtLoanPmt"
        Me.txtLoanPmt.Size = New System.Drawing.Size(100, 20)
        Me.txtLoanPmt.TabIndex = 9
        Me.txtLoanPmt.Text = "300.00"
        Me.txtLoanPmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInsPayment
        '
        Me.txtInsPayment.Location = New System.Drawing.Point(112, 42)
        Me.txtInsPayment.Name = "txtInsPayment"
        Me.txtInsPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtInsPayment.TabIndex = 10
        Me.txtInsPayment.Text = "100.00"
        Me.txtInsPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOilChange
        '
        Me.txtOilChange.Location = New System.Drawing.Point(112, 68)
        Me.txtOilChange.Name = "txtOilChange"
        Me.txtOilChange.Size = New System.Drawing.Size(100, 20)
        Me.txtOilChange.TabIndex = 11
        Me.txtOilChange.Text = "20.00"
        Me.txtOilChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMaintenance
        '
        Me.txtMaintenance.Location = New System.Drawing.Point(112, 94)
        Me.txtMaintenance.Name = "txtMaintenance"
        Me.txtMaintenance.Size = New System.Drawing.Size(100, 20)
        Me.txtMaintenance.TabIndex = 12
        Me.txtMaintenance.Text = "80.00"
        Me.txtMaintenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCarWash
        '
        Me.txtCarWash.Location = New System.Drawing.Point(112, 120)
        Me.txtCarWash.Name = "txtCarWash"
        Me.txtCarWash.Size = New System.Drawing.Size(100, 20)
        Me.txtCarWash.TabIndex = 13
        Me.txtCarWash.Text = "20.00"
        Me.txtCarWash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGas
        '
        Me.txtGas.Location = New System.Drawing.Point(112, 146)
        Me.txtGas.Name = "txtGas"
        Me.txtGas.Size = New System.Drawing.Size(100, 20)
        Me.txtGas.TabIndex = 14
        Me.txtGas.Text = "180.00"
        Me.txtGas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Loan payment:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Insurance payment:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Oil change:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Maintenance:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Car washes:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Gas:"
        '
        'lblCarMonthlyTotal
        '
        Me.lblCarMonthlyTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCarMonthlyTotal.Location = New System.Drawing.Point(112, 175)
        Me.lblCarMonthlyTotal.Name = "lblCarMonthlyTotal"
        Me.lblCarMonthlyTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblCarMonthlyTotal.TabIndex = 21
        Me.lblCarMonthlyTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCarYearlyTotal
        '
        Me.lblCarYearlyTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCarYearlyTotal.Location = New System.Drawing.Point(112, 205)
        Me.lblCarYearlyTotal.Name = "lblCarYearlyTotal"
        Me.lblCarYearlyTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblCarYearlyTotal.TabIndex = 22
        Me.lblCarYearlyTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 182)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Monthly total:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 264)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 13)
        Me.Label15.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCarCalculate)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lblCarYearlyTotal)
        Me.GroupBox2.Controls.Add(Me.lblCarMonthlyTotal)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtGas)
        Me.GroupBox2.Controls.Add(Me.txtCarWash)
        Me.GroupBox2.Controls.Add(Me.txtMaintenance)
        Me.GroupBox2.Controls.Add(Me.txtOilChange)
        Me.GroupBox2.Controls.Add(Me.txtInsPayment)
        Me.GroupBox2.Controls.Add(Me.txtLoanPmt)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 265)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Car Expenses"
        '
        'btnCarCalculate
        '
        Me.btnCarCalculate.Location = New System.Drawing.Point(112, 237)
        Me.btnCarCalculate.Name = "btnCarCalculate"
        Me.btnCarCalculate.Size = New System.Drawing.Size(100, 20)
        Me.btnCarCalculate.TabIndex = 26
        Me.btnCarCalculate.Text = "Calculate"
        Me.btnCarCalculate.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 212)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Yearly total:"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnFairmontCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 289)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JJohnson2B1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFairmontCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFairTotComm As Label
    Friend WithEvents lblFairTotSales As Label
    Friend WithEvents txtAKSales As TextBox
    Friend WithEvents txtINSales As TextBox
    Friend WithEvents txtILSales As TextBox
    Friend WithEvents txtLoanPmt As TextBox
    Friend WithEvents txtInsPayment As TextBox
    Friend WithEvents txtOilChange As TextBox
    Friend WithEvents txtMaintenance As TextBox
    Friend WithEvents txtCarWash As TextBox
    Friend WithEvents txtGas As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblCarMonthlyTotal As Label
    Friend WithEvents lblCarYearlyTotal As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCarCalculate As Button
    Friend WithEvents Label16 As Label
End Class
