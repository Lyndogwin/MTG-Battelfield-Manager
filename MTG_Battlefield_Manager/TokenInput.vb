Imports MTG_Battlefield_Manager.PlayerStatus
Imports MTG_Battlefield_Manager.TokenTab


Public Class TokenInput 'ACTS AS DATA ENTRY DIALOG FOR THE TOKENTAB
    Public Sub tokenDataButton_Click(sender As Object, e As EventArgs) Handles tokenDataButton.Click

        For index As Integer = CInt(tokenIndexText.Text) To 1 Step -1 'ALLOWS THE CREATION OF COPY TOKENS 

            Dim tabpage As New TabPage 'THIS MAKES AN INSTANCE OF A TabPage CALLED tabpage
            Dim tb As New TokenTab 'THIS MAKES AN INSTANCE OF TokenTab[FORM] CALLED tb

            tb.TopLevel = False 'REMOVING THE TOP LEVEL IS ESSENTIAL FOR THE tabpage TO ADOPT THE CONTROLS FROM THE TOKENTAB
            tb.Visible = True

            tb.abilitiesLabel.Text = abilitiesText.Text
            tb.colorLabel.Text = colorText.Text

            'A NEW INSTANCE OF TokenTab WAS CALLED, SO THE FOLLOW IS FUTHER EDITING A COPYING OF THE FORM INTO THE NEW tabpage

            tabpage.Controls.Add(tb) 'FIXED--PASSES CONTROLS FROM tb TO tabpage 
            tabpage.Text = typeText.Text 'THIS CHANGES THE tabpage INFO TO THE VALUE ENTERED IN THE TYPETEXT FIELD

            'THE FOLLOWING IS COPIED FROM http://www.tek-tips.com/viewthread.cfm?qid=1211324
            '------------------------
            'Create a new button to close the individual TokenTabs
            Dim btn As New Button

            'add the new button to the TabPage just created above
            btn.Parent = tabpage 'parent page to recieve button

            'set button properties (location, size, etc.)
            btn.Left = 250
            btn.Top = 0
            btn.Width = 20
            btn.Height = 20
            btn.Text = "X"
            btn.Visible = True

            'assign Click event handler to the button's Click event
            AddHandler btn.Click, AddressOf btn_Click
            '----------------------------------------

            'ToDo-----create a loop that will make multiple copies of the token
            PlayerStatus.tokenTab.TabPages.Add(tabpage) 'THIS ADDS THE tabpage TO THE TAB CONTROLLER IN FORM1, WHICH NOW CONTAINS AN INSTANCE OF FORM3 CALLED f3
        Next
        Me.Close() 'CLOSES TokenInput, WHICH ACTS AS A DATA ENTRY DIALOG
    End Sub

    'THE FOLLOWING SUBROUTINE HOUSES THE EVENT FOR THE PREVIOUSLY CREATED BUTTON btn
    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PlayerStatus.tokenTab.TabPages.Remove(CType(sender.parent, TabPage))
    End Sub

    Private Sub colorText_TextChanged(sender As Object, e As EventArgs) Handles colorText.TextChanged

    End Sub

End Class

