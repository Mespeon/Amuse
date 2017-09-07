Public Class BlackSquareSettings

    Private Sub btnStandardMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStandardMode.Click
        Me.Close()
        Cardinal.GameMode = "standard"
        Cardinal.SetGameMode()
    End Sub

    Private Sub btnTimeAttackMode_Click(sender As Object, e As EventArgs) Handles btnTimeAttackMode.Click
        Me.Close()
        Cardinal.GameMode = "timeattack"
        Cardinal.SetGameMode()
    End Sub

    Private Sub btnRelaxedMode_Click(sender As Object, e As EventArgs) Handles btnRelaxedMode.Click
        Me.Close()
        Cardinal.GameMode = "relaxed"
        Cardinal.SetGameMode()
    End Sub

    Private Sub btnGrandMasterMode_Click(sender As Object, e As EventArgs) Handles btnGrandMasterMode.Click
        Me.Close()
        Cardinal.GameMode = "tgmchallenge"
        Cardinal.SetGameMode()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        BlackSquareSplash.Show()
    End Sub

    Private Sub btnGameModeHelp_Click(sender As Object, e As EventArgs)
        Guide.Show()
    End Sub
End Class