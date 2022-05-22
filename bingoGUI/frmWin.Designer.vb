<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWin
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
        Me.lblCongrats = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCongrats
        '
        Me.lblCongrats.AutoSize = True
        Me.lblCongrats.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblCongrats.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCongrats.Location = New System.Drawing.Point(118, 87)
        Me.lblCongrats.Name = "lblCongrats"
        Me.lblCongrats.Size = New System.Drawing.Size(339, 86)
        Me.lblCongrats.TabIndex = 0
        Me.lblCongrats.Text = "BINGO!!!!!!"
        '
        'frmWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(587, 263)
        Me.Controls.Add(Me.lblCongrats)
        Me.Name = "frmWin"
        Me.Text = "Bingo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCongrats As Label
End Class
