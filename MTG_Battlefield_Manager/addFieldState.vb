Public Class addFieldState
    Private Sub addFieldStateButton_Click(sender As Object, e As EventArgs) Handles addFieldStateButton.Click
        'THE FOLLOWING CODE ALLOWS THE USER TO ADD A NEW LINE TO THE "PlayerStatus.fieldStatusLabel"
        PlayerStatus.fieldStatusLabel.Text = (PlayerStatus.fieldStatusLabel.Text) + (fieldStatusText.Text + vbCrLf)
    End Sub

    Private Sub finishFieldStateButton_Click(sender As Object, e As EventArgs) Handles finishFieldStateButton.Click
        Me.Close()
    End Sub
End Class