<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addFieldState
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
        Me.fieldStatusText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addFieldStateButton = New System.Windows.Forms.Button()
        Me.finishFieldStateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'fieldStatusText
        '
        Me.fieldStatusText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.fieldStatusText.Location = New System.Drawing.Point(38, 122)
        Me.fieldStatusText.Name = "fieldStatusText"
        Me.fieldStatusText.Size = New System.Drawing.Size(337, 31)
        Me.fieldStatusText.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please add any data on field status"
        '
        'addFieldStateButton
        '
        Me.addFieldStateButton.Location = New System.Drawing.Point(72, 203)
        Me.addFieldStateButton.Name = "addFieldStateButton"
        Me.addFieldStateButton.Size = New System.Drawing.Size(95, 44)
        Me.addFieldStateButton.TabIndex = 2
        Me.addFieldStateButton.Text = "Add"
        Me.addFieldStateButton.UseVisualStyleBackColor = True
        '
        'finishFieldStateButton
        '
        Me.finishFieldStateButton.Location = New System.Drawing.Point(230, 203)
        Me.finishFieldStateButton.Name = "finishFieldStateButton"
        Me.finishFieldStateButton.Size = New System.Drawing.Size(95, 44)
        Me.finishFieldStateButton.TabIndex = 3
        Me.finishFieldStateButton.Text = "Finish"
        Me.finishFieldStateButton.UseVisualStyleBackColor = True
        '
        'addFieldState
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 284)
        Me.Controls.Add(Me.finishFieldStateButton)
        Me.Controls.Add(Me.addFieldStateButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fieldStatusText)
        Me.Name = "addFieldState"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fieldStatusText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents addFieldStateButton As Button
    Friend WithEvents finishFieldStateButton As Button
End Class
