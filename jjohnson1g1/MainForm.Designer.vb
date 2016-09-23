<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDvdQuantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBlueRayQuantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalDisks = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.txtDvdPrice = New System.Windows.Forms.TextBox()
        Me.txtBlueRayPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDvdTotal = New System.Windows.Forms.Label()
        Me.lblBlueRayTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Sales Receipt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(329, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Da&te:"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(368, 40)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&DVDs:"
        '
        'txtDvdQuantity
        '
        Me.txtDvdQuantity.Location = New System.Drawing.Point(124, 140)
        Me.txtDvdQuantity.Name = "txtDvdQuantity"
        Me.txtDvdQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtDvdQuantity.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&Blu-rays:"
        '
        'txtBlueRayQuantity
        '
        Me.txtBlueRayQuantity.Location = New System.Drawing.Point(124, 167)
        Me.txtBlueRayQuantity.Name = "txtBlueRayQuantity"
        Me.txtBlueRayQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtBlueRayQuantity.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(282, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total Disks:"
        '
        'lblTotalDisks
        '
        Me.lblTotalDisks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDisks.Location = New System.Drawing.Point(365, 202)
        Me.lblTotalDisks.Name = "lblTotalDisks"
        Me.lblTotalDisks.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalDisks.TabIndex = 12
        Me.lblTotalDisks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(282, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total Sales:"
        '
        'lblTotalSales
        '
        Me.lblTotalSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSales.Location = New System.Drawing.Point(365, 236)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalSales.TabIndex = 14
        Me.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(504, 137)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(85, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(504, 169)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(85, 23)
        Me.BtnPrint.TabIndex = 7
        Me.BtnPrint.Text = "&Print Receipt"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(504, 202)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(504, 236)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'txtDvdPrice
        '
        Me.txtDvdPrice.Location = New System.Drawing.Point(245, 140)
        Me.txtDvdPrice.Name = "txtDvdPrice"
        Me.txtDvdPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtDvdPrice.TabIndex = 15
        '
        'txtBlueRayPrice
        '
        Me.txtBlueRayPrice.Location = New System.Drawing.Point(245, 166)
        Me.txtBlueRayPrice.Name = "txtBlueRayPrice"
        Me.txtBlueRayPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtBlueRayPrice.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Price:"
        '
        'lblDvdTotal
        '
        Me.lblDvdTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDvdTotal.Location = New System.Drawing.Point(365, 138)
        Me.lblDvdTotal.Name = "lblDvdTotal"
        Me.lblDvdTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblDvdTotal.TabIndex = 18
        Me.lblDvdTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBlueRayTotal
        '
        Me.lblBlueRayTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlueRayTotal.Location = New System.Drawing.Point(365, 165)
        Me.lblBlueRayTotal.Name = "lblBlueRayTotal"
        Me.lblBlueRayTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblBlueRayTotal.TabIndex = 19
        Me.lblBlueRayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(124, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Quantity:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 285)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblBlueRayTotal)
        Me.Controls.Add(Me.lblDvdTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBlueRayPrice)
        Me.Controls.Add(Me.txtDvdPrice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotalDisks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBlueRayQuantity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDvdQuantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JJohnson1G1 Play It Again"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDvdQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBlueRayQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalDisks As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents lblBlueRayTotal As Label
    Friend WithEvents lblDvdTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBlueRayPrice As TextBox
    Friend WithEvents txtDvdPrice As TextBox
    Friend WithEvents Label8 As Label
End Class
