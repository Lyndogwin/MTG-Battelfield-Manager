Public Class deleteFieldState
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles finishDeleteButton.Click
        PlayerStatus.fieldStatusLabel.Text = deleteFieldStateText.Text 'COPIES TEXT FROM "PlayerStatus.fieldStatusLabel" IN ORDER TO EDIT IT IN "deleteFieldStateText"
        Me.Close()
    End Sub
End Class