<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.InputBoxButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InputBoxButton
        '
        Me.InputBoxButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.InputBoxButton.Location = New System.Drawing.Point(126, 46)
        Me.InputBoxButton.Name = "InputBoxButton"
        Me.InputBoxButton.Size = New System.Drawing.Size(189, 80)
        Me.InputBoxButton.TabIndex = 0
        Me.InputBoxButton.Text = "REVIEW"
        Me.InputBoxButton.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(450, 185)
        Me.Controls.Add(Me.InputBoxButton)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REVIEW"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InputBoxButton As Button
End Class
