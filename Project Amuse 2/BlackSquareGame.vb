Imports System.Xml

Public Class BlackSquareGame

    Private Sub BlackSquareGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Focus()

        lblUsername.Text = Cardinal.username.ToUpper()
        lblUserLevel.Text &= Cardinal.UserLevel
        lblUserType.Text = Cardinal.UserType.ToUpper()
        picMiniUserPhoto.ImageLocation = Cardinal.PhotoPath
    End Sub

    Private Sub GameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameTimer.Tick
        Cardinal.Drain()
    End Sub

    Private Sub btnChoiceA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoiceA.Click
        Cardinal.AnswerFromUser = btnChoiceA.Text
        Cardinal.GetAnswer()
    End Sub

    Private Sub btnChoiceB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoiceB.Click
        Cardinal.AnswerFromUser = btnChoiceB.Text
        Cardinal.GetAnswer()
    End Sub

    Private Sub btnChoiceC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoiceC.Click
        Cardinal.AnswerFromUser = btnChoiceC.Text
        Cardinal.GetAnswer()
    End Sub

    Private Sub btnChoiceD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoiceD.Click
        Cardinal.AnswerFromUser = btnChoiceD.Text
        Cardinal.GetAnswer()
    End Sub

    Private Sub btnEndGame_Click(sender As Object, e As EventArgs) Handles btnEndGame.Click
        Cardinal.EndGame()
    End Sub
End Class