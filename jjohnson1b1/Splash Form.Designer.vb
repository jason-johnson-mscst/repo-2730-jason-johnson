<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.picRti = New System.Windows.Forms.PictureBox()
        Me.picRedTree = New System.Windows.Forms.PictureBox()
        Me.tmrExit = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picRti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRedTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(315, 108)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(161, 32)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Red Tree Inn"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(315, 153)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(266, 32)
        Me.lblMsg.TabIndex = 2
        Me.lblMsg.Text = "A relaxing place to stay!"
        '
        'picRti
        '
        Me.picRti.Image = Global.jjohnson1b1.My.Resources.Resources.RTI
        Me.picRti.Location = New System.Drawing.Point(498, 12)
        Me.picRti.Name = "picRti"
        Me.picRti.Size = New System.Drawing.Size(100, 50)
        Me.picRti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRti.TabIndex = 4
        Me.picRti.TabStop = False
        '
        'picRedTree
        '
        Me.picRedTree.Image = Global.jjohnson1b1.My.Resources.Resources.RedTreeInn
        Me.picRedTree.Location = New System.Drawing.Point(12, 12)
        Me.picRedTree.Name = "picRedTree"
        Me.picRedTree.Size = New System.Drawing.Size(245, 270)
        Me.picRedTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRedTree.TabIndex = 3
        Me.picRedTree.TabStop = False
        '
        'tmrExit
        '
        Me.tmrExit.Enabled = True
        Me.tmrExit.Interval = 6000
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 293)
        Me.ControlBox = False
        Me.Controls.Add(Me.picRti)
        Me.Controls.Add(Me.picRedTree)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picRti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRedTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents lblMsg As Label
    Friend WithEvents picRedTree As PictureBox
    Friend WithEvents picRti As PictureBox
    Friend WithEvents tmrExit As Timer
End Class
