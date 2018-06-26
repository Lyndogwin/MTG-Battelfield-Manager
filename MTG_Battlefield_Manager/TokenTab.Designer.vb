<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TokenTab
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
        Me.abilitiesLabel = New System.Windows.Forms.Label()
        Me.colorLabel = New System.Windows.Forms.Label()
        Me.powerLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.toughLabel = New System.Windows.Forms.Label()
        Me.upPowerButton = New System.Windows.Forms.Button()
        Me.upToughButton = New System.Windows.Forms.Button()
        Me.downPowerButton = New System.Windows.Forms.Button()
        Me.downToughButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.counterLabel = New System.Windows.Forms.Label()
        Me.upCounterButton = New System.Windows.Forms.Button()
        Me.downCounterButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'abilitiesLabel
        '
        Me.abilitiesLabel.AutoSize = True
        Me.abilitiesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abilitiesLabel.Location = New System.Drawing.Point(49, 48)
        Me.abilitiesLabel.Name = "abilitiesLabel"
        Me.abilitiesLabel.Size = New System.Drawing.Size(147, 31)
        Me.abilitiesLabel.TabIndex = 0
        Me.abilitiesLabel.Text = "No abilities"
        '
        'colorLabel
        '
        Me.colorLabel.AutoSize = True
        Me.colorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorLabel.Location = New System.Drawing.Point(304, 31)
        Me.colorLabel.Name = "colorLabel"
        Me.colorLabel.Size = New System.Drawing.Size(93, 42)
        Me.colorLabel.TabIndex = 1
        Me.colorLabel.Text = "Void"
        '
        'powerLabel
        '
        Me.powerLabel.AutoSize = True
        Me.powerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.powerLabel.Location = New System.Drawing.Point(44, 199)
        Me.powerLabel.Name = "powerLabel"
        Me.powerLabel.Size = New System.Drawing.Size(56, 61)
        Me.powerLabel.TabIndex = 2
        Me.powerLabel.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 61)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "/"
        '
        'toughLabel
        '
        Me.toughLabel.AutoSize = True
        Me.toughLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toughLabel.Location = New System.Drawing.Point(155, 199)
        Me.toughLabel.Name = "toughLabel"
        Me.toughLabel.Size = New System.Drawing.Size(56, 61)
        Me.toughLabel.TabIndex = 4
        Me.toughLabel.Text = "1"
        '
        'upPowerButton
        '
        Me.upPowerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upPowerButton.Location = New System.Drawing.Point(45, 133)
        Me.upPowerButton.Name = "upPowerButton"
        Me.upPowerButton.Size = New System.Drawing.Size(55, 53)
        Me.upPowerButton.TabIndex = 5
        Me.upPowerButton.Text = "+"
        Me.upPowerButton.UseVisualStyleBackColor = True
        '
        'upToughButton
        '
        Me.upToughButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upToughButton.Location = New System.Drawing.Point(156, 133)
        Me.upToughButton.Name = "upToughButton"
        Me.upToughButton.Size = New System.Drawing.Size(55, 53)
        Me.upToughButton.TabIndex = 6
        Me.upToughButton.Text = "+"
        Me.upToughButton.UseVisualStyleBackColor = True
        '
        'downPowerButton
        '
        Me.downPowerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.downPowerButton.Location = New System.Drawing.Point(45, 276)
        Me.downPowerButton.Name = "downPowerButton"
        Me.downPowerButton.Size = New System.Drawing.Size(55, 53)
        Me.downPowerButton.TabIndex = 7
        Me.downPowerButton.Text = "-"
        Me.downPowerButton.UseVisualStyleBackColor = True
        '
        'downToughButton
        '
        Me.downToughButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.downToughButton.Location = New System.Drawing.Point(156, 276)
        Me.downToughButton.Name = "downToughButton"
        Me.downToughButton.Size = New System.Drawing.Size(55, 53)
        Me.downToughButton.TabIndex = 8
        Me.downToughButton.Text = "-"
        Me.downToughButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(290, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Counters "
        '
        'counterLabel
        '
        Me.counterLabel.AutoSize = True
        Me.counterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.counterLabel.Location = New System.Drawing.Point(338, 199)
        Me.counterLabel.Name = "counterLabel"
        Me.counterLabel.Size = New System.Drawing.Size(35, 37)
        Me.counterLabel.TabIndex = 10
        Me.counterLabel.Text = "0"
        '
        'upCounterButton
        '
        Me.upCounterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upCounterButton.Location = New System.Drawing.Point(284, 193)
        Me.upCounterButton.Name = "upCounterButton"
        Me.upCounterButton.Size = New System.Drawing.Size(48, 43)
        Me.upCounterButton.TabIndex = 11
        Me.upCounterButton.Text = "+"
        Me.upCounterButton.UseVisualStyleBackColor = True
        '
        'downCounterButton
        '
        Me.downCounterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.downCounterButton.Location = New System.Drawing.Point(377, 193)
        Me.downCounterButton.Name = "downCounterButton"
        Me.downCounterButton.Size = New System.Drawing.Size(48, 43)
        Me.downCounterButton.TabIndex = 12
        Me.downCounterButton.Text = "-"
        Me.downCounterButton.UseVisualStyleBackColor = True
        '
        'TokenTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.downCounterButton)
        Me.Controls.Add(Me.upCounterButton)
        Me.Controls.Add(Me.counterLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.downToughButton)
        Me.Controls.Add(Me.downPowerButton)
        Me.Controls.Add(Me.upToughButton)
        Me.Controls.Add(Me.upPowerButton)
        Me.Controls.Add(Me.toughLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.powerLabel)
        Me.Controls.Add(Me.colorLabel)
        Me.Controls.Add(Me.abilitiesLabel)
        Me.Name = "TokenTab"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents abilitiesLabel As Label
    Friend WithEvents colorLabel As Label
    Friend WithEvents powerLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents toughLabel As Label
    Friend WithEvents upPowerButton As Button
    Friend WithEvents upToughButton As Button
    Friend WithEvents downPowerButton As Button
    Friend WithEvents downToughButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents counterLabel As Label
    Friend WithEvents upCounterButton As Button
    Friend WithEvents downCounterButton As Button
End Class
