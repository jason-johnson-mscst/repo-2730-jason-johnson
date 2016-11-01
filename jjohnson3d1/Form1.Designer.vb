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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDisplayDays = New System.Windows.Forms.Button()
        Me.lblNumberDays = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMonthNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblLowest = New System.Windows.Forms.Label()
        Me.lblScores = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDisplayStats = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPercent = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.lstNew = New System.Windows.Forms.ListBox()
        Me.lstOriginal = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDisplayDays)
        Me.GroupBox1.Controls.Add(Me.lblNumberDays)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMonthNumber)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Days in Month"
        '
        'btnDisplayDays
        '
        Me.btnDisplayDays.Location = New System.Drawing.Point(39, 110)
        Me.btnDisplayDays.Name = "btnDisplayDays"
        Me.btnDisplayDays.Size = New System.Drawing.Size(89, 23)
        Me.btnDisplayDays.TabIndex = 4
        Me.btnDisplayDays.Text = "&Display Days"
        Me.btnDisplayDays.UseVisualStyleBackColor = True
        '
        'lblNumberDays
        '
        Me.lblNumberDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumberDays.Location = New System.Drawing.Point(109, 65)
        Me.lblNumberDays.Name = "lblNumberDays"
        Me.lblNumberDays.Size = New System.Drawing.Size(34, 23)
        Me.lblNumberDays.TabIndex = 3
        Me.lblNumberDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of days:"
        '
        'txtMonthNumber
        '
        Me.txtMonthNumber.Location = New System.Drawing.Point(109, 31)
        Me.txtMonthNumber.Name = "txtMonthNumber"
        Me.txtMonthNumber.Size = New System.Drawing.Size(34, 20)
        Me.txtMonthNumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Month number:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAverage)
        Me.GroupBox2.Controls.Add(Me.lblLowest)
        Me.GroupBox2.Controls.Add(Me.lblScores)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnDisplayStats)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(199, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 118)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Display Scores, Lowest, Average"
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverage.Location = New System.Drawing.Point(210, 51)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(44, 23)
        Me.lblAverage.TabIndex = 10
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLowest
        '
        Me.lblLowest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLowest.Location = New System.Drawing.Point(56, 51)
        Me.lblLowest.Name = "lblLowest"
        Me.lblLowest.Size = New System.Drawing.Size(44, 23)
        Me.lblLowest.TabIndex = 9
        Me.lblLowest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScores
        '
        Me.lblScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScores.Location = New System.Drawing.Point(56, 16)
        Me.lblScores.Name = "lblScores"
        Me.lblScores.Size = New System.Drawing.Size(198, 30)
        Me.lblScores.TabIndex = 7
        Me.lblScores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(154, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Average:"
        '
        'btnDisplayStats
        '
        Me.btnDisplayStats.Location = New System.Drawing.Point(96, 86)
        Me.btnDisplayStats.Name = "btnDisplayStats"
        Me.btnDisplayStats.Size = New System.Drawing.Size(93, 23)
        Me.btnDisplayStats.TabIndex = 3
        Me.btnDisplayStats.Text = "Display &Stats"
        Me.btnDisplayStats.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Lowest:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Scores:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPercent)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.btnIncrease)
        Me.GroupBox3.Controls.Add(Me.lstNew)
        Me.GroupBox3.Controls.Add(Me.lstOriginal)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(317, 187)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "#22 Increase Prices"
        '
        'txtPercent
        '
        Me.txtPercent.Location = New System.Drawing.Point(281, 48)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Size = New System.Drawing.Size(25, 20)
        Me.txtPercent.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(219, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "% Increase:"
        '
        'btnIncrease
        '
        Me.btnIncrease.Location = New System.Drawing.Point(231, 84)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(75, 23)
        Me.btnIncrease.TabIndex = 4
        Me.btnIncrease.Text = "&Increase"
        Me.btnIncrease.UseVisualStyleBackColor = True
        '
        'lstNew
        '
        Me.lstNew.FormattingEnabled = True
        Me.lstNew.Location = New System.Drawing.Point(123, 36)
        Me.lstNew.Name = "lstNew"
        Me.lstNew.Size = New System.Drawing.Size(90, 134)
        Me.lstNew.TabIndex = 3
        '
        'lstOriginal
        '
        Me.lstOriginal.FormattingEnabled = True
        Me.lstOriginal.Location = New System.Drawing.Point(13, 37)
        Me.lstOriginal.Name = "lstOriginal"
        Me.lstOriginal.Size = New System.Drawing.Size(90, 134)
        Me.lstOriginal.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "&New prices:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "&Original prices:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(159, 383)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 414)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "JJohnson 3D1 Arrays"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDisplayDays As Button
    Friend WithEvents lblNumberDays As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMonthNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblLowest As Label
    Friend WithEvents lblScores As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDisplayStats As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnIncrease As Button
    Friend WithEvents lstNew As ListBox
    Friend WithEvents lstOriginal As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents txtPercent As TextBox
    Friend WithEvents Label8 As Label
End Class
