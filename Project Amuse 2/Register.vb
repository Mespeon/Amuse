Public Class Register

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Gate.Show()
    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to Project Amuse!" & vbCrLf & vbCrLf &
                        "Before registering, please be reminded of the following guidelines: " & vbCrLf & vbCrLf &
                        "1. ALL FIELDS ARE REQUIRED. DO NOT LEAVE ANY BLANK FIELDS OR YOUR REGISTRATION WILL BE REJECTED." & vbCrLf & vbCrLf &
                        "2. Usernames must be unique. Username duplicates will be rejected." & vbCrLf & vbCrLf &
                        "3. Usernames must be at least 6 CHARACTERS in length." & vbCrLf & vbCrLf &
                        "4. Passwords must be at least 8 CHARACTERS in length. Passwords must not be similar to your username." & vbCrLf & vbCrLf &
                        "5. Secret answers are case-sensitive. Make sure that you type your answer properly.")
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Cardinal.ProcessRegistrationForm()
    End Sub
End Class