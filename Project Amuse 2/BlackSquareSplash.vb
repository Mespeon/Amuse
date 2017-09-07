Public Class BlackSquareSplash

    Private Sub BlackSquare_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Get variable values for user data from Cardinal module
        lblUsername.Text = Cardinal.username.ToUpper()
        lblUserLevel.Text = lblUserLevel.Text & Cardinal.UserLevel
        lblUserType.Text = Cardinal.UserType.ToUpper()
        picMiniUserPhoto.ImageLocation = Cardinal.PhotoPath
    End Sub

    Private Sub btnGameStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGameStart.Click
        Me.Close()
        BlackSquareSettings.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Overview.Show()
    End Sub
End Class