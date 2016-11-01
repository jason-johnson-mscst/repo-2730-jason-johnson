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
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.chkMorThan10 = New System.Windows.Forms.CheckBox()
        Me.chkTravel = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.btnCalc_IfThen = New System.Windows.Forms.Button()
        Me.btnCalc_NestedIf = New System.Windows.Forms.Button()
        Me.btnCalc_IfElseIf = New System.Windows.Forms.Button()
        Me.btnCalc_SelectCase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(16, 30)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 20)
        Me.txtSales.TabIndex = 1
        '
        'chkMorThan10
        '
        Me.chkMorThan10.AutoSize = True
        Me.chkMorThan10.Location = New System.Drawing.Point(16, 57)
        Me.chkMorThan10.Name = "chkMorThan10"
        Me.chkMorThan10.Size = New System.Drawing.Size(77, 17)
        Me.chkMorThan10.TabIndex = 2
        Me.chkMorThan10.Text = "> 10 Years"
        Me.chkMorThan10.UseVisualStyleBackColor = True
        '
        'chkTravel
        '
        Me.chkTravel.AutoSize = True
        Me.chkTravel.Location = New System.Drawing.Point(16, 81)
        Me.chkTravel.Name = "chkTravel"
        Me.chkTravel.Size = New System.Drawing.Size(70, 17)
        Me.chkTravel.TabIndex = 3
        Me.chkTravel.Text = "Traveling"
        Me.chkTravel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Commission:"
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Location = New System.Drawing.Point(16, 131)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(100, 23)
        Me.lblCommission.TabIndex = 5
        Me.lblCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc_IfThen
        '
        Me.btnCalc_IfThen.Location = New System.Drawing.Point(225, 27)
        Me.btnCalc_IfThen.Name = "btnCalc_IfThen"
        Me.btnCalc_IfThen.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc_IfThen.TabIndex = 6
        Me.btnCalc_IfThen.Text = "If Then"
        Me.btnCalc_IfThen.UseVisualStyleBackColor = True
        '
        'btnCalc_NestedIf
        '
        Me.btnCalc_NestedIf.Location = New System.Drawing.Point(225, 53)
        Me.btnCalc_NestedIf.Name = "btnCalc_NestedIf"
        Me.btnCalc_NestedIf.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc_NestedIf.TabIndex = 7
        Me.btnCalc_NestedIf.Text = "Nested If"
        Me.btnCalc_NestedIf.UseVisualStyleBackColor = True
        '
        'btnCalc_IfElseIf
        '
        Me.btnCalc_IfElseIf.Location = New System.Drawing.Point(225, 77)
        Me.btnCalc_IfElseIf.Name = "btnCalc_IfElseIf"
        Me.btnCalc_IfElseIf.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc_IfElseIf.TabIndex = 8
        Me.btnCalc_IfElseIf.Text = "If ElseIf"
        Me.btnCalc_IfElseIf.UseVisualStyleBackColor = True
        '
        'btnCalc_SelectCase
        '
        Me.btnCalc_SelectCase.Location = New System.Drawing.Point(225, 105)
        Me.btnCalc_SelectCase.Name = "btnCalc_SelectCase"
        Me.btnCalc_SelectCase.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc_SelectCase.TabIndex = 9
        Me.btnCalc_SelectCase.Text = "Select Case"
        Me.btnCalc_SelectCase.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(225, 134)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 204)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc_SelectCase)
        Me.Controls.Add(Me.btnCalc_IfElseIf)
        Me.Controls.Add(Me.btnCalc_NestedIf)
        Me.Controls.Add(Me.btnCalc_IfThen)
        Me.Controls.Add(Me.lblCommission)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkTravel)
        Me.Controls.Add(Me.chkMorThan10)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "JJohnson2H1: Marshall Sales Commission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents chkMorThan10 As CheckBox
    Friend WithEvents chkTravel As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCommission As Label
    Friend WithEvents btnCalc_IfThen As Button
    Friend WithEvents btnCalc_NestedIf As Button
    Friend WithEvents btnCalc_IfElseIf As Button
    Friend WithEvents btnCalc_SelectCase As Button
    Friend WithEvents btnExit As Button
End Class
