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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl16CountScores = New System.Windows.Forms.Label()
        Me.btnCount16 = New System.Windows.Forms.Button()
        Me.txtEnterScore = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFindTestScores = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl17CountScores = New System.Windows.Forms.Label()
        Me.btnCount17 = New System.Windows.Forms.Button()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCountTestScores = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl16CountScores)
        Me.GroupBox1.Controls.Add(Me.btnCount16)
        Me.GroupBox1.Controls.Add(Me.txtEnterScore)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblFindTestScores)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p552 #16 Find test scores"
        '
        'lbl16CountScores
        '
        Me.lbl16CountScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl16CountScores.Location = New System.Drawing.Point(243, 58)
        Me.lbl16CountScores.Name = "lbl16CountScores"
        Me.lbl16CountScores.Size = New System.Drawing.Size(100, 23)
        Me.lbl16CountScores.TabIndex = 4
        Me.lbl16CountScores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCount16
        '
        Me.btnCount16.Location = New System.Drawing.Point(151, 59)
        Me.btnCount16.Name = "btnCount16"
        Me.btnCount16.Size = New System.Drawing.Size(86, 23)
        Me.btnCount16.TabIndex = 3
        Me.btnCount16.Text = "Count Scores"
        Me.btnCount16.UseVisualStyleBackColor = True
        '
        'txtEnterScore
        '
        Me.txtEnterScore.Location = New System.Drawing.Point(76, 61)
        Me.txtEnterScore.Name = "txtEnterScore"
        Me.txtEnterScore.Size = New System.Drawing.Size(29, 20)
        Me.txtEnterScore.TabIndex = 2
        Me.txtEnterScore.Text = "72"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter score:"
        '
        'lblFindTestScores
        '
        Me.lblFindTestScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFindTestScores.Location = New System.Drawing.Point(7, 20)
        Me.lblFindTestScores.Name = "lblFindTestScores"
        Me.lblFindTestScores.Size = New System.Drawing.Size(336, 28)
        Me.lblFindTestScores.TabIndex = 0
        Me.lblFindTestScores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMax)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbl17CountScores)
        Me.GroupBox2.Controls.Add(Me.btnCount17)
        Me.GroupBox2.Controls.Add(Me.txtMin)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblCountTestScores)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 103)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p552 #17 Count test scores in range"
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(114, 72)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(29, 20)
        Me.txtMax.TabIndex = 7
        Me.txtMax.Text = "89"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(111, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Max:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Min:"
        '
        'lbl17CountScores
        '
        Me.lbl17CountScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl17CountScores.Location = New System.Drawing.Point(243, 71)
        Me.lbl17CountScores.Name = "lbl17CountScores"
        Me.lbl17CountScores.Size = New System.Drawing.Size(100, 23)
        Me.lbl17CountScores.TabIndex = 4
        Me.lbl17CountScores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCount17
        '
        Me.btnCount17.Location = New System.Drawing.Point(151, 72)
        Me.btnCount17.Name = "btnCount17"
        Me.btnCount17.Size = New System.Drawing.Size(86, 23)
        Me.btnCount17.TabIndex = 3
        Me.btnCount17.Text = "Count Scores"
        Me.btnCount17.UseVisualStyleBackColor = True
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(76, 72)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(29, 20)
        Me.txtMin.TabIndex = 2
        Me.txtMin.Text = "80"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Enter range:"
        '
        'lblCountTestScores
        '
        Me.lblCountTestScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountTestScores.Location = New System.Drawing.Point(7, 19)
        Me.lblCountTestScores.Name = "lblCountTestScores"
        Me.lblCountTestScores.Size = New System.Drawing.Size(336, 28)
        Me.lblCountTestScores.TabIndex = 0
        Me.lblCountTestScores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(154, 233)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 268)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "JJohnson3e1: Searching Arrays"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl16CountScores As Label
    Friend WithEvents btnCount16 As Button
    Friend WithEvents txtEnterScore As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFindTestScores As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtMax As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl17CountScores As Label
    Friend WithEvents btnCount17 As Button
    Friend WithEvents txtMin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCountTestScores As Label
    Friend WithEvents btnExit As Button
End Class
