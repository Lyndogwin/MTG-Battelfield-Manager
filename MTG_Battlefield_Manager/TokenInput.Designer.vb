<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TokenInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TokenInput))
        Me.typeText = New System.Windows.Forms.TextBox()
        Me.tokenDataButton = New System.Windows.Forms.Button()
        Me.abilitiesText = New System.Windows.Forms.TextBox()
        Me.colorText = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tokenIndexText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'typeText
        '
        Me.typeText.Location = New System.Drawing.Point(127, 95)
        Me.typeText.Name = "typeText"
        Me.typeText.Size = New System.Drawing.Size(212, 31)
        Me.typeText.TabIndex = 1
        Me.typeText.Text = "Enter Type"
        '
        'tokenDataButton
        '
        Me.tokenDataButton.Location = New System.Drawing.Point(127, 252)
        Me.tokenDataButton.Name = "tokenDataButton"
        Me.tokenDataButton.Size = New System.Drawing.Size(204, 39)
        Me.tokenDataButton.TabIndex = 4
        Me.tokenDataButton.Text = "Generate Token"
        Me.tokenDataButton.UseVisualStyleBackColor = True
        '
        'abilitiesText
        '
        Me.abilitiesText.Location = New System.Drawing.Point(127, 162)
        Me.abilitiesText.Name = "abilitiesText"
        Me.abilitiesText.Size = New System.Drawing.Size(212, 31)
        Me.abilitiesText.TabIndex = 2
        Me.abilitiesText.Text = "Enter Abilities"
        '
        'colorText
        '
        Me.colorText.Location = New System.Drawing.Point(127, 32)
        Me.colorText.Name = "colorText"
        Me.colorText.Size = New System.Drawing.Size(212, 31)
        Me.colorText.TabIndex = 0
        Me.colorText.Text = "Enter Color"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-73, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 259)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'tokenIndexText
        '
        Me.tokenIndexText.Location = New System.Drawing.Point(388, 98)
        Me.tokenIndexText.Name = "tokenIndexText"
        Me.tokenIndexText.Size = New System.Drawing.Size(60, 31)
        Me.tokenIndexText.TabIndex = 5
        Me.tokenIndexText.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(358, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "#"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TokenInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 377)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tokenIndexText)
        Me.Controls.Add(Me.colorText)
        Me.Controls.Add(Me.abilitiesText)
        Me.Controls.Add(Me.tokenDataButton)
        Me.Controls.Add(Me.typeText)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "TokenInput"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Token Info"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents typeText As TextBox
    Friend WithEvents tokenDataButton As Button
    Friend WithEvents abilitiesText As TextBox
    Friend WithEvents colorText As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tokenIndexText As TextBox
    Friend WithEvents Label1 As Label
End Class
