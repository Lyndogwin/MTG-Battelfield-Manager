<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteFieldState
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
        Me.deleteFieldStateText = New System.Windows.Forms.TextBox()
        Me.finishDeleteButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'deleteFieldStateText
        '
        Me.deleteFieldStateText.Location = New System.Drawing.Point(12, 12)
        Me.deleteFieldStateText.Multiline = True
        Me.deleteFieldStateText.Name = "deleteFieldStateText"
        Me.deleteFieldStateText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.deleteFieldStateText.Size = New System.Drawing.Size(382, 317)
        Me.deleteFieldStateText.TabIndex = 0
        '
        'finishDeleteButton
        '
        Me.finishDeleteButton.Location = New System.Drawing.Point(127, 350)
        Me.finishDeleteButton.Name = "finishDeleteButton"
        Me.finishDeleteButton.Size = New System.Drawing.Size(137, 44)
        Me.finishDeleteButton.TabIndex = 1
        Me.finishDeleteButton.Text = "Finish"
        Me.finishDeleteButton.UseVisualStyleBackColor = True
        '
        'deleteFieldState
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 406)
        Me.Controls.Add(Me.finishDeleteButton)
        Me.Controls.Add(Me.deleteFieldStateText)
        Me.Name = "deleteFieldState"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents deleteFieldStateText As TextBox
    Friend WithEvents finishDeleteButton As Button
End Class
