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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNsales = New System.Windows.Forms.TextBox()
        Me.txtSsales = New System.Windows.Forms.TextBox()
        Me.txtEsales = New System.Windows.Forms.TextBox()
        Me.txtWsales = New System.Windows.Forms.TextBox()
        Me.txtNincrease = New System.Windows.Forms.TextBox()
        Me.txtSincrease = New System.Windows.Forms.TextBox()
        Me.txtEincrease = New System.Windows.Forms.TextBox()
        Me.txtWincrease = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNorth = New System.Windows.Forms.Label()
        Me.lblSouth = New System.Windows.Forms.Label()
        Me.lblEast = New System.Windows.Forms.Label()
        Me.lblWest = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Note: Enter the projected increase in decimal form."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&North"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&South"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&East"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(483, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "&West"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Current sales:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Projected increase:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Projected sales:"
        '
        'txtNsales
        '
        Me.txtNsales.Location = New System.Drawing.Point(141, 113)
        Me.txtNsales.Name = "txtNsales"
        Me.txtNsales.Size = New System.Drawing.Size(100, 20)
        Me.txtNsales.TabIndex = 1
        Me.txtNsales.Text = "25000"
        Me.txtNsales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSsales
        '
        Me.txtSsales.Location = New System.Drawing.Point(245, 113)
        Me.txtSsales.Name = "txtSsales"
        Me.txtSsales.Size = New System.Drawing.Size(100, 20)
        Me.txtSsales.TabIndex = 3
        Me.txtSsales.Text = "10000"
        Me.txtSsales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEsales
        '
        Me.txtEsales.Location = New System.Drawing.Point(349, 113)
        Me.txtEsales.Name = "txtEsales"
        Me.txtEsales.Size = New System.Drawing.Size(100, 20)
        Me.txtEsales.TabIndex = 5
        Me.txtEsales.Text = "10000"
        Me.txtEsales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWsales
        '
        Me.txtWsales.Location = New System.Drawing.Point(453, 113)
        Me.txtWsales.Name = "txtWsales"
        Me.txtWsales.Size = New System.Drawing.Size(100, 20)
        Me.txtWsales.TabIndex = 7
        Me.txtWsales.Text = "15000"
        Me.txtWsales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNincrease
        '
        Me.txtNincrease.Location = New System.Drawing.Point(141, 143)
        Me.txtNincrease.Name = "txtNincrease"
        Me.txtNincrease.Size = New System.Drawing.Size(100, 20)
        Me.txtNincrease.TabIndex = 2
        Me.txtNincrease.Text = "0.10"
        Me.txtNincrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSincrease
        '
        Me.txtSincrease.Location = New System.Drawing.Point(245, 143)
        Me.txtSincrease.Name = "txtSincrease"
        Me.txtSincrease.Size = New System.Drawing.Size(100, 20)
        Me.txtSincrease.TabIndex = 4
        Me.txtSincrease.Text = "0.05"
        Me.txtSincrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEincrease
        '
        Me.txtEincrease.Location = New System.Drawing.Point(349, 143)
        Me.txtEincrease.Name = "txtEincrease"
        Me.txtEincrease.Size = New System.Drawing.Size(100, 20)
        Me.txtEincrease.TabIndex = 6
        Me.txtEincrease.Text = "0.04"
        Me.txtEincrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWincrease
        '
        Me.txtWincrease.Location = New System.Drawing.Point(453, 143)
        Me.txtWincrease.Name = "txtWincrease"
        Me.txtWincrease.Size = New System.Drawing.Size(100, 20)
        Me.txtWincrease.TabIndex = 8
        Me.txtWincrease.Text = "0.11"
        Me.txtWincrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(155, 218)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(259, 218)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(365, 218)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(462, 218)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.jjohnson1f1.My.Resources.Resources.compass
        Me.PictureBox1.Location = New System.Drawing.Point(35, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'lblNorth
        '
        Me.lblNorth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNorth.Location = New System.Drawing.Point(141, 173)
        Me.lblNorth.Name = "lblNorth"
        Me.lblNorth.Size = New System.Drawing.Size(100, 20)
        Me.lblNorth.TabIndex = 20
        Me.lblNorth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSouth
        '
        Me.lblSouth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSouth.Location = New System.Drawing.Point(245, 173)
        Me.lblSouth.Name = "lblSouth"
        Me.lblSouth.Size = New System.Drawing.Size(100, 20)
        Me.lblSouth.TabIndex = 21
        Me.lblSouth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEast
        '
        Me.lblEast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEast.Location = New System.Drawing.Point(349, 173)
        Me.lblEast.Name = "lblEast"
        Me.lblEast.Size = New System.Drawing.Size(100, 20)
        Me.lblEast.TabIndex = 22
        Me.lblEast.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWest
        '
        Me.lblWest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWest.Location = New System.Drawing.Point(453, 173)
        Me.lblWest.Name = "lblWest"
        Me.lblWest.Size = New System.Drawing.Size(100, 20)
        Me.lblWest.TabIndex = 23
        Me.lblWest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 262)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblWest)
        Me.Controls.Add(Me.lblEast)
        Me.Controls.Add(Me.lblSouth)
        Me.Controls.Add(Me.lblNorth)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtWincrease)
        Me.Controls.Add(Me.txtEincrease)
        Me.Controls.Add(Me.txtSincrease)
        Me.Controls.Add(Me.txtNincrease)
        Me.Controls.Add(Me.txtWsales)
        Me.Controls.Add(Me.txtEsales)
        Me.Controls.Add(Me.txtSsales)
        Me.Controls.Add(Me.txtNsales)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JJohnson1F1: KJ Sales Projections"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNsales As TextBox
    Friend WithEvents txtSsales As TextBox
    Friend WithEvents txtEsales As TextBox
    Friend WithEvents txtWsales As TextBox
    Friend WithEvents txtNincrease As TextBox
    Friend WithEvents txtSincrease As TextBox
    Friend WithEvents txtEincrease As TextBox
    Friend WithEvents txtWincrease As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNorth As Label
    Friend WithEvents lblSouth As Label
    Friend WithEvents lblEast As Label
    Friend WithEvents lblWest As Label
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
