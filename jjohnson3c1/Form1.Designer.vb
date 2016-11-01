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
        Me.btn12CtoF = New System.Windows.Forms.Button()
        Me.btn12FtoC = New System.Windows.Forms.Button()
        Me.txtCel12 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFar12 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn13CtoF = New System.Windows.Forms.Button()
        Me.btn13FtoC = New System.Windows.Forms.Button()
        Me.txtCel13 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFar13 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblAvgRain = New System.Windows.Forms.Label()
        Me.lblTotRain = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRainCalFunc = New System.Windows.Forms.Button()
        Me.btnRanCalSubpro = New System.Windows.Forms.Button()
        Me.txtMonRain = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn12CtoF)
        Me.GroupBox1.Controls.Add(Me.btn12FtoC)
        Me.GroupBox1.Controls.Add(Me.txtCel12)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFar12)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p435 #12 (2 Subprocedures)"
        '
        'btn12CtoF
        '
        Me.btn12CtoF.Location = New System.Drawing.Point(114, 85)
        Me.btn12CtoF.Name = "btn12CtoF"
        Me.btn12CtoF.Size = New System.Drawing.Size(75, 23)
        Me.btn12CtoF.TabIndex = 5
        Me.btn12CtoF.Text = "°C to °F"
        Me.btn12CtoF.UseVisualStyleBackColor = True
        '
        'btn12FtoC
        '
        Me.btn12FtoC.Location = New System.Drawing.Point(26, 85)
        Me.btn12FtoC.Name = "btn12FtoC"
        Me.btn12FtoC.Size = New System.Drawing.Size(75, 23)
        Me.btn12FtoC.TabIndex = 4
        Me.btn12FtoC.Text = "°F to °C"
        Me.btn12FtoC.UseVisualStyleBackColor = True
        '
        'txtCel12
        '
        Me.txtCel12.Location = New System.Drawing.Point(89, 45)
        Me.txtCel12.Name = "txtCel12"
        Me.txtCel12.Size = New System.Drawing.Size(100, 20)
        Me.txtCel12.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "°Celsius:"
        '
        'txtFar12
        '
        Me.txtFar12.Location = New System.Drawing.Point(89, 16)
        Me.txtFar12.Name = "txtFar12"
        Me.txtFar12.Size = New System.Drawing.Size(100, 20)
        Me.txtFar12.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "°Fahrenheit:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn13CtoF)
        Me.GroupBox2.Controls.Add(Me.btn13FtoC)
        Me.GroupBox2.Controls.Add(Me.txtCel13)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtFar13)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(238, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(199, 126)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p435 #13 (2 Functions)"
        '
        'btn13CtoF
        '
        Me.btn13CtoF.Location = New System.Drawing.Point(114, 85)
        Me.btn13CtoF.Name = "btn13CtoF"
        Me.btn13CtoF.Size = New System.Drawing.Size(75, 23)
        Me.btn13CtoF.TabIndex = 5
        Me.btn13CtoF.Text = "°C to °F"
        Me.btn13CtoF.UseVisualStyleBackColor = True
        '
        'btn13FtoC
        '
        Me.btn13FtoC.Location = New System.Drawing.Point(26, 85)
        Me.btn13FtoC.Name = "btn13FtoC"
        Me.btn13FtoC.Size = New System.Drawing.Size(75, 23)
        Me.btn13FtoC.TabIndex = 4
        Me.btn13FtoC.Text = "°F to °C"
        Me.btn13FtoC.UseVisualStyleBackColor = True
        '
        'txtCel13
        '
        Me.txtCel13.Location = New System.Drawing.Point(89, 45)
        Me.txtCel13.Name = "txtCel13"
        Me.txtCel13.Size = New System.Drawing.Size(100, 20)
        Me.txtCel13.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "°Celsius:"
        '
        'txtFar13
        '
        Me.txtFar13.Location = New System.Drawing.Point(89, 16)
        Me.txtFar13.Name = "txtFar13"
        Me.txtFar13.Size = New System.Drawing.Size(100, 20)
        Me.txtFar13.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "°Fahrenheit:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblAvgRain)
        Me.GroupBox3.Controls.Add(Me.lblTotRain)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.btnRainCalFunc)
        Me.GroupBox3.Controls.Add(Me.btnRanCalSubpro)
        Me.GroupBox3.Controls.Add(Me.txtMonRain)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 173)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(413, 102)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "p437 #18-19 Rainfall"
        '
        'lblAvgRain
        '
        Me.lblAvgRain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgRain.Location = New System.Drawing.Point(110, 67)
        Me.lblAvgRain.Name = "lblAvgRain"
        Me.lblAvgRain.Size = New System.Drawing.Size(82, 23)
        Me.lblAvgRain.TabIndex = 7
        '
        'lblTotRain
        '
        Me.lblTotRain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotRain.Location = New System.Drawing.Point(13, 67)
        Me.lblTotRain.Name = "lblTotRain"
        Me.lblTotRain.Size = New System.Drawing.Size(79, 23)
        Me.lblTotRain.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(107, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Average rainfall:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total rainfall:"
        '
        'btnRainCalFunc
        '
        Me.btnRainCalFunc.Location = New System.Drawing.Point(223, 67)
        Me.btnRainCalFunc.Name = "btnRainCalFunc"
        Me.btnRainCalFunc.Size = New System.Drawing.Size(165, 23)
        Me.btnRainCalFunc.TabIndex = 3
        Me.btnRainCalFunc.Text = "Calculate w/function"
        Me.btnRainCalFunc.UseVisualStyleBackColor = True
        '
        'btnRanCalSubpro
        '
        Me.btnRanCalSubpro.Location = New System.Drawing.Point(223, 15)
        Me.btnRanCalSubpro.Name = "btnRanCalSubpro"
        Me.btnRanCalSubpro.Size = New System.Drawing.Size(165, 23)
        Me.btnRanCalSubpro.TabIndex = 2
        Me.btnRanCalSubpro.Text = "Calculate w/subprocedure"
        Me.btnRanCalSubpro.UseVisualStyleBackColor = True
        '
        'txtMonRain
        '
        Me.txtMonRain.Location = New System.Drawing.Point(98, 17)
        Me.txtMonRain.Name = "txtMonRain"
        Me.txtMonRain.Size = New System.Drawing.Size(100, 20)
        Me.txtMonRain.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Monthly Rainfall:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(196, 281)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 314)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "JJohnson 3C1 - Subprocedures and Functions"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn12CtoF As Button
    Friend WithEvents btn12FtoC As Button
    Friend WithEvents txtCel12 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFar12 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn13CtoF As Button
    Friend WithEvents btn13FtoC As Button
    Friend WithEvents txtCel13 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFar13 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblAvgRain As Label
    Friend WithEvents lblTotRain As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnRainCalFunc As Button
    Friend WithEvents btnRanCalSubpro As Button
    Friend WithEvents txtMonRain As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnExit As Button
End Class
