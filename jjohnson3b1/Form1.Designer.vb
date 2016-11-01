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
        Me.lstMultTable = New System.Windows.Forms.ListBox()
        Me.btnWileLoopDT = New System.Windows.Forms.Button()
        Me.btnForLoopDT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInputNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalNet = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalExpenses = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lstExpenses = New System.Windows.Forms.ListBox()
        Me.lstSales = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddExpense = New System.Windows.Forms.Button()
        Me.btnAddSale = New System.Windows.Forms.Button()
        Me.txtAddExpense = New System.Windows.Forms.TextBox()
        Me.txtAddSale = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstMultTable)
        Me.GroupBox1.Controls.Add(Me.btnWileLoopDT)
        Me.GroupBox1.Controls.Add(Me.btnForLoopDT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtInputNum)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 327)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Multiplication Tables"
        '
        'lstMultTable
        '
        Me.lstMultTable.FormattingEnabled = True
        Me.lstMultTable.Location = New System.Drawing.Point(13, 81)
        Me.lstMultTable.Name = "lstMultTable"
        Me.lstMultTable.Size = New System.Drawing.Size(155, 147)
        Me.lstMultTable.TabIndex = 5
        '
        'btnWileLoopDT
        '
        Me.btnWileLoopDT.Location = New System.Drawing.Point(10, 263)
        Me.btnWileLoopDT.Name = "btnWileLoopDT"
        Me.btnWileLoopDT.Size = New System.Drawing.Size(155, 23)
        Me.btnWileLoopDT.TabIndex = 4
        Me.btnWileLoopDT.Text = "While Loop: Display Table"
        Me.btnWileLoopDT.UseVisualStyleBackColor = True
        '
        'btnForLoopDT
        '
        Me.btnForLoopDT.Location = New System.Drawing.Point(10, 234)
        Me.btnForLoopDT.Name = "btnForLoopDT"
        Me.btnForLoopDT.Size = New System.Drawing.Size(155, 23)
        Me.btnForLoopDT.TabIndex = 3
        Me.btnForLoopDT.Text = "For Loop: Display Table"
        Me.btnForLoopDT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Multiplication table:"
        '
        'txtInputNum
        '
        Me.txtInputNum.Location = New System.Drawing.Point(10, 37)
        Me.txtInputNum.Name = "txtInputNum"
        Me.txtInputNum.Size = New System.Drawing.Size(100, 20)
        Me.txtInputNum.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(169, 346)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalNet)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblTotalExpenses)
        Me.GroupBox2.Controls.Add(Me.lblTotalSales)
        Me.GroupBox2.Controls.Add(Me.lstExpenses)
        Me.GroupBox2.Controls.Add(Me.lstSales)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnAddExpense)
        Me.GroupBox2.Controls.Add(Me.btnAddSale)
        Me.GroupBox2.Controls.Add(Me.txtAddExpense)
        Me.GroupBox2.Controls.Add(Me.txtAddSale)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(210, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 327)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sales/Expenses"
        '
        'lblTotalNet
        '
        Me.lblTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalNet.Location = New System.Drawing.Point(60, 292)
        Me.lblTotalNet.Name = "lblTotalNet"
        Me.lblTotalNet.Size = New System.Drawing.Size(81, 23)
        Me.lblTotalNet.TabIndex = 13
        Me.lblTotalNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Net:"
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalExpenses.Location = New System.Drawing.Point(102, 263)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(81, 23)
        Me.lblTotalExpenses.TabIndex = 11
        Me.lblTotalExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalSales
        '
        Me.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSales.Location = New System.Drawing.Point(13, 263)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(81, 23)
        Me.lblTotalSales.TabIndex = 10
        Me.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstExpenses
        '
        Me.lstExpenses.FormattingEnabled = True
        Me.lstExpenses.Items.AddRange(New Object() {"2.00", "3.00", "4.00", "5.00", "6.00"})
        Me.lstExpenses.Location = New System.Drawing.Point(102, 110)
        Me.lstExpenses.Name = "lstExpenses"
        Me.lstExpenses.Size = New System.Drawing.Size(81, 147)
        Me.lstExpenses.TabIndex = 9
        '
        'lstSales
        '
        Me.lstSales.FormattingEnabled = True
        Me.lstSales.Items.AddRange(New Object() {"1.00", "2.00", "3.00", "4.00", "5.00"})
        Me.lstSales.Location = New System.Drawing.Point(13, 110)
        Me.lstSales.Name = "lstSales"
        Me.lstSales.Size = New System.Drawing.Size(81, 147)
        Me.lstSales.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Expenses:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sales:"
        '
        'btnAddExpense
        '
        Me.btnAddExpense.Location = New System.Drawing.Point(99, 64)
        Me.btnAddExpense.Name = "btnAddExpense"
        Me.btnAddExpense.Size = New System.Drawing.Size(84, 20)
        Me.btnAddExpense.TabIndex = 5
        Me.btnAddExpense.Text = "Add Expense"
        Me.btnAddExpense.UseVisualStyleBackColor = True
        '
        'btnAddSale
        '
        Me.btnAddSale.Location = New System.Drawing.Point(10, 64)
        Me.btnAddSale.Name = "btnAddSale"
        Me.btnAddSale.Size = New System.Drawing.Size(84, 20)
        Me.btnAddSale.TabIndex = 4
        Me.btnAddSale.Text = "Add Sale"
        Me.btnAddSale.UseVisualStyleBackColor = True
        '
        'txtAddExpense
        '
        Me.txtAddExpense.Location = New System.Drawing.Point(99, 37)
        Me.txtAddExpense.Name = "txtAddExpense"
        Me.txtAddExpense.Size = New System.Drawing.Size(84, 20)
        Me.txtAddExpense.TabIndex = 3
        Me.txtAddExpense.Text = "0.00"
        '
        'txtAddSale
        '
        Me.txtAddSale.Location = New System.Drawing.Point(10, 37)
        Me.txtAddSale.Name = "txtAddSale"
        Me.txtAddSale.Size = New System.Drawing.Size(84, 20)
        Me.txtAddSale.TabIndex = 2
        Me.txtAddSale.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Input expense:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Input sale:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 377)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "JJohnson3b1: Loops, List Boxes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstMultTable As ListBox
    Friend WithEvents btnWileLoopDT As Button
    Friend WithEvents btnForLoopDT As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInputNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTotalNet As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalExpenses As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents lstExpenses As ListBox
    Friend WithEvents lstSales As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAddExpense As Button
    Friend WithEvents btnAddSale As Button
    Friend WithEvents txtAddExpense As TextBox
    Friend WithEvents txtAddSale As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
