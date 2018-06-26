Public Class TokenTab
    Private Sub upPowerButton_Click(sender As Object, e As EventArgs) Handles upPowerButton.Click
        powerLabel.Text = CDbl(powerLabel.Text) + 1
    End Sub

    Private Sub downPowerButton_Click(sender As Object, e As EventArgs) Handles downPowerButton.Click
        powerLabel.Text = CDbl(powerLabel.Text) - 1
    End Sub

    Private Sub upToughButton_Click(sender As Object, e As EventArgs) Handles upToughButton.Click
        toughLabel.Text = CDbl(toughLabel.Text) + 1
    End Sub

    Private Sub downToughButton_Click(sender As Object, e As EventArgs) Handles downToughButton.Click
        toughLabel.Text = CDbl(toughLabel.Text) - 1
    End Sub

    Private Sub upCounterButton_Click(sender As Object, e As EventArgs) Handles upCounterButton.Click
        counterLabel.Text = CDbl(counterLabel.Text) + 1
    End Sub

    Private Sub downCounterButton_Click(sender As Object, e As EventArgs) Handles downCounterButton.Click
        counterLabel.Text = CDbl(counterLabel.Text) - 1
    End Sub
End Class