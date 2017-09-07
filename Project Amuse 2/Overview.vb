Public Class Overview

    'Theme Selector
    Private Sub cbxThemeSelector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxThemeSelector.SelectedIndexChanged

    End Sub

    'Handles Account Logout
    Private Sub btnAccountLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccountLogout.Click
        Cardinal.UserLogOut()
    End Sub

    'Captures the ALT+F4 (Close) action and asks user if he/she wants to log out of the system
    Private Sub Overview_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim UserPrompt As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If UserPrompt = Windows.Forms.DialogResult.Yes Then
            e.Cancel = True
            Me.Hide()
            Gate.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    'ON-LOAD ACTIONS
    Private Sub Overview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sets theme to Dark (default)
        cbxThemeSelector.SelectedIndex = 0

        'Gets all user information from database
        Cardinal.GetUserInformation()
        If Cardinal.UserType <> "Administrator" Then
            btnAdministratorTools.Visible = False
            btnAdministratorTools.Enabled = False
        End If
    End Sub

    'GENERAL ACCOUNT ACTIONS
    'Profile Photo Actions
    Private Sub picUserImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picUserImage.Click

    End Sub
    'End Profile Photo Actions

    Private Sub btnViewLevelSystemInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewLevelSystemInformation.Click

    End Sub

    Private Sub btnAccessShop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccessShop.Click
        Cardinal.AccessShop()
    End Sub

    Private Sub btnAccountControls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccountControls.Click

    End Sub

    Private Sub btnGuideToAmuse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuideToAmuse.Click
        Guide.Show()
    End Sub

    Private Sub btnAboutAmuse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAboutAmuse.Click
        About.Show()
    End Sub

    'THIS BUTTON/SETTING IS ONLY ACCESSIBLE IF USER IS OF THE ADMINISTRATOR TYPE
    'Otherwise, this button is hidden and deactivated.
    Private Sub btnAdministratorTools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdministratorTools.Click

    End Sub

    'BEGIN APP SELECTOR ACTIONS
    Private Sub btnBlackSquareSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlackSquareSelect.Click
        picGameImage.Image = My.Resources.game_pic_black_square_2
        lblGameTitle.Text = "Black Square 2.0"
        lblGameDescription.Text = "A quiz game, and more. Named after the hardest version of the DJMAX Portable series, this game will take you through 100 different questions with varying difficulty and subjects."

        lblGameTitle.Visible = True
        lblGameDescription.Visible = True
        btnLaunchApplication.Visible = True
    End Sub

    Private Sub btnLaunchApplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaunchApplication.Click
        BlackSquareSplash.Show()
        Me.Hide()
    End Sub
End Class