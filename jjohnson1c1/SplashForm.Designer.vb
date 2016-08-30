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
        Me.picPetal = New System.Windows.Forms.PictureBox()
        CType(Me.picPetal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPetal
        '
        Me.picPetal.Image = Global.jjohnson1c1.My.Resources.Resources.PetalShop_1_
        Me.picPetal.Location = New System.Drawing.Point(12, 12)
        Me.picPetal.Name = "picPetal"
        Me.picPetal.Size = New System.Drawing.Size(455, 384)
        Me.picPetal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPetal.TabIndex = 0
        Me.picPetal.TabStop = False
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.picPetal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplash"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.picPetal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPetal As PictureBox
End Class
