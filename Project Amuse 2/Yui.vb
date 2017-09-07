Module Yui
    'THIS MODULE WILL HOLD ALL THE DATA ARRAYS AND ALL THEIR RESPECTIVE DATA
    'ARRAYS WILL BE GROUPED ACCORDING TO THEIR USE AND WILL BE INSIDE SUB-ROUTINES FOR
    ' EASE IN REDUNDANT ARRAY USE DURING A SESSION.

    'Save user data once session starts
    Public UserSessionData(10) As String
    Public Sub DisplayUserData()
        Overview.lblControlBoxFormName.Text = UserSessionData(0) & Overview.lblControlBoxFormName.Text
        Overview.lblUserNameText.Text = UserSessionData(1) & " " & UserSessionData(2)
        Overview.lblUserTypeText.Text = UserSessionData(3)
    End Sub
End Module
