Public Class BlackSquareResults

    Private Sub BlackSquareResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cardinal.GameResults()
        BlackSquareGame.Hide()
        Select Case Cardinal.GameMode
            Case "standard"
                picGameMode.Image = My.Resources.standard_mode_btn

            Case "timeattack"
                picGameMode.Image = My.Resources.time_attack_mode_btn

            Case "relaxed"
                picGameMode.Image = My.Resources.relaxed_mode_btn

            Case "tgmchallenge"
                picGameMode.Image = My.Resources.gmc_mode_btn
        End Select
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        BlackSquareGame.Close()
        Overview.Show()
    End Sub
End Class