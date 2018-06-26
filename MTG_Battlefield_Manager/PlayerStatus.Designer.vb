<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlayerStatus
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
        Me.lifeLabel = New System.Windows.Forms.Label()
        Me.poisonLabel = New System.Windows.Forms.Label()
        Me.upLifeButton = New System.Windows.Forms.Button()
        Me.downLifeButton = New System.Windows.Forms.Button()
        Me.upPoisonButton = New System.Windows.Forms.Button()
        Me.downPoisonButton = New System.Windows.Forms.Button()
        Me.addTokenButton = New System.Windows.Forms.Button()
        Me.tokenTab = New System.Windows.Forms.TabControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fieldStatusLabel = New System.Windows.Forms.Label()
        Me.addFieldStatusButton = New System.Windows.Forms.Button()
        Me.deleteFieldStatusButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lifeLabel
        '
        Me.lifeLabel.AutoSize = True
        Me.lifeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lifeLabel.Location = New System.Drawing.Point(250, 55)
        Me.lifeLabel.Name = "lifeLabel"
        Me.lifeLabel.Size = New System.Drawing.Size(85, 61)
        Me.lifeLabel.TabIndex = 1
        Me.lifeLabel.Text = "20"
        '
        'poisonLabel
        '
        Me.poisonLabel.AutoSize = True
        Me.poisonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poisonLabel.Location = New System.Drawing.Point(269, 173)
        Me.poisonLabel.Name = "poisonLabel"
        Me.poisonLabel.Size = New System.Drawing.Size(51, 55)
        Me.poisonLabel.TabIndex = 2
        Me.poisonLabel.Text = "0"
        '
        'upLifeButton
        '
        Me.upLifeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upLifeButton.Location = New System.Drawing.Point(164, 55)
        Me.upLifeButton.Name = "upLifeButton"
        Me.upLifeButton.Size = New System.Drawing.Size(74, 59)
        Me.upLifeButton.TabIndex = 3
        Me.upLifeButton.Text = "&+"
        Me.upLifeButton.UseVisualStyleBackColor = True
        '
        'downLifeButton
        '
        Me.downLifeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.downLifeButton.Location = New System.Drawing.Point(353, 55)
        Me.downLifeButton.Name = "downLifeButton"
        Me.downLifeButton.Size = New System.Drawing.Size(74, 59)
        Me.downLifeButton.TabIndex = 4
        Me.downLifeButton.Text = "&-"
        Me.downLifeButton.UseVisualStyleBackColor = True
        '
        'upPoisonButton
        '
        Me.upPoisonButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upPoisonButton.Location = New System.Drawing.Point(164, 173)
        Me.upPoisonButton.Name = "upPoisonButton"
        Me.upPoisonButton.Size = New System.Drawing.Size(74, 59)
        Me.upPoisonButton.TabIndex = 5
        Me.upPoisonButton.Text = "+"
        Me.upPoisonButton.UseVisualStyleBackColor = True
        '
        'downPoisonButton
        '
        Me.downPoisonButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.downPoisonButton.Location = New System.Drawing.Point(353, 173)
        Me.downPoisonButton.Name = "downPoisonButton"
        Me.downPoisonButton.Size = New System.Drawing.Size(74, 59)
        Me.downPoisonButton.TabIndex = 6
        Me.downPoisonButton.Text = "-"
        Me.downPoisonButton.UseVisualStyleBackColor = True
        '
        'addTokenButton
        '
        Me.addTokenButton.Location = New System.Drawing.Point(90, 307)
        Me.addTokenButton.Name = "addTokenButton"
        Me.addTokenButton.Size = New System.Drawing.Size(212, 45)
        Me.addTokenButton.TabIndex = 7
        Me.addTokenButton.Text = "Add &Token"
        Me.addTokenButton.UseVisualStyleBackColor = True
        '
        'tokenTab
        '
        Me.tokenTab.Location = New System.Drawing.Point(90, 401)
        Me.tokenTab.Name = "tokenTab"
        Me.tokenTab.SelectedIndex = 0
        Me.tokenTab.Size = New System.Drawing.Size(550, 496)
        Me.tokenTab.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Life"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 37)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Poison"
        '
        'fieldStatusLabel
        '
        Me.fieldStatusLabel.AutoSize = True
        Me.fieldStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldStatusLabel.Location = New System.Drawing.Point(474, 55)
        Me.fieldStatusLabel.Name = "fieldStatusLabel"
        Me.fieldStatusLabel.Size = New System.Drawing.Size(0, 25)
        Me.fieldStatusLabel.TabIndex = 10
        '
        'addFieldStatusButton
        '
        Me.addFieldStatusButton.Location = New System.Drawing.Point(428, 278)
        Me.addFieldStatusButton.Name = "addFieldStatusButton"
        Me.addFieldStatusButton.Size = New System.Drawing.Size(212, 45)
        Me.addFieldStatusButton.TabIndex = 11
        Me.addFieldStatusButton.Text = "&Add field status"
        Me.addFieldStatusButton.UseVisualStyleBackColor = True
        '
        'deleteFieldStatusButton
        '
        Me.deleteFieldStatusButton.Location = New System.Drawing.Point(428, 339)
        Me.deleteFieldStatusButton.Name = "deleteFieldStatusButton"
        Me.deleteFieldStatusButton.Size = New System.Drawing.Size(212, 45)
        Me.deleteFieldStatusButton.TabIndex = 12
        Me.deleteFieldStatusButton.Text = "&Delete field status"
        Me.deleteFieldStatusButton.UseVisualStyleBackColor = True
        '
        'PlayerStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 922)
        Me.Controls.Add(Me.deleteFieldStatusButton)
        Me.Controls.Add(Me.addFieldStatusButton)
        Me.Controls.Add(Me.fieldStatusLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addTokenButton)
        Me.Controls.Add(Me.downPoisonButton)
        Me.Controls.Add(Me.upPoisonButton)
        Me.Controls.Add(Me.downLifeButton)
        Me.Controls.Add(Me.upLifeButton)
        Me.Controls.Add(Me.poisonLabel)
        Me.Controls.Add(Me.lifeLabel)
        Me.Controls.Add(Me.tokenTab)
        Me.Name = "PlayerStatus"
        Me.Text = "Welcome Planeswalker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lifeLabel As Label
    Friend WithEvents poisonLabel As Label
    Friend WithEvents upLifeButton As Button
    Friend WithEvents downLifeButton As Button
    Friend WithEvents upPoisonButton As Button
    Friend WithEvents downPoisonButton As Button
    Friend WithEvents addTokenButton As Button
    Friend WithEvents tokenTab As TabControl
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fieldStatusLabel As Label
    Friend WithEvents addFieldStatusButton As Button
    Friend WithEvents deleteFieldStatusButton As Button
End Class
