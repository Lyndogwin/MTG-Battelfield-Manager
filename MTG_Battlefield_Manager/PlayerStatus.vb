Public Class PlayerStatus
    Private Sub addTokenButton_Click(sender As Object, e As EventArgs) Handles addTokenButton.Click
        TokenInput.Show()
    End Sub

    Private Sub upLifeButton_Click(sender As Object, e As EventArgs) Handles upLifeButton.Click
        lifeLabel.Text = CDbl(lifeLabel.Text) + 1
    End Sub

    Private Sub downLifeButton_Click(sender As Object, e As EventArgs) Handles downLifeButton.Click
        lifeLabel.Text = CDbl(lifeLabel.Text) - 1
    End Sub

    Private Sub upPoisonButton_Click(sender As Object, e As EventArgs) Handles upPoisonButton.Click
        poisonLabel.Text = CDbl(poisonLabel.Text) + 1
    End Sub

    Private Sub downPoisonButton_Click(sender As Object, e As EventArgs) Handles downPoisonButton.Click
        poisonLabel.Text = CDbl(poisonLabel.Text) - 1
    End Sub

    Private Sub addFieldStatusButton_Click(sender As Object, e As EventArgs) Handles addFieldStatusButton.Click
        addFieldState.Show()
    End Sub

    Private Sub deleteFieldStatusButton_Click(sender As Object, e As EventArgs) Handles deleteFieldStatusButton.Click
        deleteFieldState.Show()
        deleteFieldState.deleteFieldStateText.Text = fieldStatusLabel.Text
    End Sub
End Class
