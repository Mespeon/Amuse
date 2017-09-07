Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Xml

Module Cardinal
    'For log-in purposes ONLY
    Public username As String
    Public password As String   ' This will be cleared after a successful login.

    'For user session
    Public FirstName As String
    Public LastName As String
    Public UserType As String
    Public UserLevel As String
    Public UserShopPoints As String
    Public PhotoPath As String

    'For registration purposes
    Public reg_FirstName As String
    Public reg_LastName As String
    Public reg_Username As String
    Public reg_Password As String
    Public reg_Email As String
    Public reg_SecretQuestion As String
    Public reg_SecretAnswer As String

    'CONTROLS WITHIN THE LOGIN FORM
    Public Sub VerifyUserLogin()
        'MASTER LOGIN CODE
        If Gate.txtUsernameField.Text <> "" And Gate.txtPasswordField.Text <> "" Then
            'Initialize Database Connection and Query String
            Dim ConnectionString As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Mark Nolledo\Documents\Visual Studio 2010\Projects\Project Amuse 2\Project Amuse 2\data\ProjectAmuse.mdb"
            Dim QueryString As String = _
                "SELECT Username, Pass FROM amusers " _
                & "WHERE Username = '" & Gate.txtUsernameField.Text & "'"

            'Begin Process
            Using DBConnection As New OleDb.OleDbConnection(ConnectionString)
                Dim DBCommand As New OleDbCommand(QueryString, DBConnection)
                Try
                    DBConnection.Open()
                    Dim DataReader As OleDbDataReader = DBCommand.ExecuteReader()
                    If DataReader.HasRows() Then
                        DataReader.Read()
                        username = DataReader.Item("Username")
                        password = DataReader.Item("Pass")

                        'Verify user
                        If Gate.txtUsernameField.Text = username Then
                            If Gate.txtPasswordField.Text = password Then
                                Gate.Hide()
                                Overview.Show()
                            Else
                                MessageBox.Show("The password you entered is incorrect.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                                Gate.txtPasswordField.Clear()
                                Gate.txtPasswordField.Focus()
                            End If
                        Else
                            MessageBox.Show("The username you entered is not registered.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                            Gate.txtUsernameField.Clear()
                            Gate.txtUsernameField.Focus()
                            Gate.txtPasswordField.Clear()
                        End If
                    Else
                        MessageBox.Show("The username you entered is not yet registered.")
                        Gate.txtUsernameField.Clear()
                        Gate.txtUsernameField.Focus()
                        Gate.txtPasswordField.Clear()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Database process failed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End Try
                DBConnection.Close()
                password = ""
            End Using
        Else
            MessageBox.Show("Please provide your log-in details.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Gate.txtUsernameField.Focus()
        End If
    End Sub

    Public Sub ProcessRegistrationForm()
        'MASTER REGISTRATION FORM VERIFICATION AND DATABASE UPDATER
        Dim SecretQuestion As String = Register.cbxSecretQuestion.SelectedItem

        If Register.txtFirstNameField.Text <> "" And Register.txtLastNameField.Text <> "" And Register.txtUsernameField.Text <> "" And Register.txtEmailField.Text <> "" And Register.txtConfirmEmailField.Text <> "" And SecretQuestion <> "" And Register.txtSecretAnswerField.Text <> "" Then
            If Register.txtUsernameField.TextLength >= 6 Then
                If Register.txtEmailField.Text = Register.txtConfirmEmailField.Text Then
                    reg_Username = Register.txtUsernameField.Text
                    reg_FirstName = Register.txtFirstNameField.Text
                    reg_LastName = Register.txtLastNameField.Text
                    reg_Email = Register.txtEmailField.Text
                    reg_SecretQuestion = SecretQuestion
                    reg_SecretAnswer = Register.txtSecretAnswerField.Text
                    FinalizeRegistration()
                    Passgen.Show()
                    Register.Close()
                End If
            Else
                MessageBox.Show("The username has to be at least 6 characters in length.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Else
            MessageBox.Show("Please fill up all the fields.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Public Sub ProcessPassword()
        If Passgen.txtPasswordField.Text <> "" And Passgen.txtConfirmPasswordField.Text <> "" Then
            If Passgen.txtPasswordField.TextLength >= 8 Then
                If Passgen.txtPasswordField.Text = Passgen.txtConfirmPasswordField.Text Then
                    reg_Password = Passgen.txtPasswordField.Text
                    GeneratePassword()
                Else
                    MessageBox.Show("Passwords do not match.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                End If
            Else
                MessageBox.Show("Passwords must be at least 8 characters.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Else
            MessageBox.Show("Please fill up all the fields.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Public Sub FinalizeRegistration()
        Dim ConnectionString As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Mark Nolledo\Documents\Visual Studio 2010\Projects\Project Amuse 2\Project Amuse 2\data\ProjectAmuse.mdb"
        Dim InsertString As String = "INSERT INTO amusers (Username, FName, LName, Email, SecQuestion, SecAnswer, UType, AccLevel, UserLevel, UserCashPoints) VALUES ('" & reg_Username & "', '" & reg_FirstName & "', '" & reg_LastName & "', '" & reg_Email & "', '" & reg_SecretQuestion & "', '" & reg_SecretAnswer & "', 'User', '9', '1', '1000')"
        Dim DataAdapter As New OleDbDataAdapter

        Using DBConnection As New OleDb.OleDbConnection(ConnectionString)
            Try
                DBConnection.Open()
                DataAdapter.InsertCommand = New OleDbCommand(InsertString, DBConnection)
                DataAdapter.InsertCommand.ExecuteNonQuery()
                MessageBox.Show("You have completed the first step in Project Amuse 2." & vbCrLf & vbCrLf & "Please proceed to the next step to finalize the registration.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Public Sub GeneratePassword()
        Dim ConnectionString As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Mark Nolledo\Documents\Visual Studio 2010\Projects\Project Amuse 2\Project Amuse 2\data\ProjectAmuse.mdb"
        Dim UpdateString As String = "UPDATE amusers SET Pass = '" & reg_Password & "' WHERE Username = '" & reg_Username & "'"
        Dim DataAdapter As New OleDbDataAdapter

        Using DBConnection As New OleDb.OleDbConnection(ConnectionString)
            Try
                DBConnection.Open()
                DataAdapter.UpdateCommand = DBConnection.CreateCommand()
                DataAdapter.UpdateCommand.CommandText = UpdateString
                DataAdapter.UpdateCommand.ExecuteNonQuery()
                MessageBox.Show("You are now registered in Project Amuse 2." & vbCrLf & vbCrLf & "You may now log in to your account.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Passgen.Close()
                Gate.Show()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End Using
    End Sub

    'CONTROLS WITHIN THE OVERVIEW FORM
    Public Sub GetUserInformation()
        'Begin Data Reading once the form loads
        Dim ConnectionString As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Mark Nolledo\Documents\Visual Studio 2010\Projects\Project Amuse 2\Project Amuse 2\data\ProjectAmuse.mdb"
        Dim QueryString As String = _
            "SELECT Username, UType, FName, LName, UserLevel, UserCashPoints FROM amusers " _
            & "WHERE Username = '" & username & "'"

        Using DBConnection As New OleDbConnection(ConnectionString)
            Dim DBCommand As New OleDbCommand(QueryString, DBConnection)
            Try
                DBConnection.Open()
                Dim AmuseDataReader As OleDbDataReader = DBCommand.ExecuteReader()
                If AmuseDataReader.HasRows() Then
                    AmuseDataReader.Read()
                    FirstName = AmuseDataReader.Item("FName")
                    LastName = AmuseDataReader.Item("LName")
                    UserType = AmuseDataReader.Item("UType")
                    UserLevel = AmuseDataReader.Item("UserLevel")
                    UserShopPoints = AmuseDataReader.Item("UserCashPoints")

                    Overview.lblControlBoxFormName.Text = username & Overview.lblControlBoxFormName.Text
                    Overview.lblUserNameText.Text = FirstName & " " & LastName
                    Overview.lblUserTypeText.Text = UserType
                    Overview.lblAmuseLevelNumber.Text = UserLevel
                    Overview.lblShopPointsNumber.Text = UserShopPoints

                    If AmuseDataReader.Item("Username") = "Airin" Then
                        PhotoPath = "C:\Users\Mark Nolledo\Documents\Visual Studio 2010\Projects\Project Amuse 2\Project Amuse 2\img\user\Airin-chan DP.png"
                        Overview.picUserImage.ImageLocation = PhotoPath
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Database process failed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
            DBConnection.Close()
        End Using
    End Sub

    Public Sub UserLogOut()
        Dim UserPrompt As DialogResult = MessageBox.Show("Are you sure you want to log out?" & vbCrLf & "Logging out will terminate the program as well.", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If UserPrompt = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Public Sub AccessShop()
        Shop.Show()
    End Sub

    'VARIABLES FOR CODENAME BLACK SQUARE
    Public index As Integer
    Public GameTimer As Integer
    Public GameMode As String
    Public GameScore As String
    Public UserCorrectAnswers As Integer = 0
    Public UserIncorrectAnswers As Integer = 0
    Public GameRating As String

    'RANDOMIZER
    Public Randomizer As New Random
    Public QuestionNumber As Integer
    Public RandomizedNumbers(120) As Integer
    Public x As Integer = 0

    'DATABASE CONTROLS
    Public AmuseDataSet As New DataSet
    Public AnswerFromUser As String = ""

    Public Sub SetGameMode()
        Select Case GameMode
            Case "standard"
                StandardMode()

            Case "timeattack"
                TimeAttackMode()

            Case "relaxed"
                RelaxedMode()

            Case "tgmchallenge"
                TGMCMode()
        End Select
    End Sub

    Public Sub StandardMode()
        Try
            x = 0
            index = 0
            GetQuestionnaire()
            BlackSquareGame.lblGameMode.Text &= GameMode.ToUpper()
            BlackSquareGame.Text &= GameMode.ToUpper()
        Catch ex As Exception
            MessageBox.Show("Failed to call subroutine GetQuestionnaire. Exiting game mode.", "Subroutine Call Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            BlackSquareGame.Close()
            BlackSquareSettings.Show()
        End Try
    End Sub

    Public Sub TimeAttackMode()
        Try
            x = 0
            GetQuestionnaire()
            GenerateRandomNumber()
            BlackSquareGame.lblGameMode.Text = "TIME ATTACK"
            BlackSquareGame.Text &= BlackSquareGame.lblGameMode.Text
        Catch ex As Exception
            MessageBox.Show("Failed to call some or all of the required subroutines. Exiting game mode.", "Subroutine Call Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            BlackSquareGame.Close()
            BlackSquareSettings.Show()
        End Try
    End Sub

    Public Sub RelaxedMode()
        Try
            x = 0
            index = 0
            GetQuestionnaire()
            BlackSquareGame.lblGameMode.Text &= GameMode.ToUpper()
            BlackSquareGame.Text &= GameMode.ToUpper()
        Catch ex As Exception
            MessageBox.Show("Failed to call subroutine GetQuestionnaire. Exiting game mode.", "Subroutine Call Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            BlackSquareGame.Close()
            BlackSquareSettings.Show()
        End Try
    End Sub

    Public Sub TGMCMode()
        Try
            x = 0
            GetQuestionnaire()
            GenerateRandomNumber()
            BlackSquareGame.lblGameMode.Text = "THE GRAND MASTER CHALLENGE"
            BlackSquareGame.Text &= BlackSquareGame.lblGameMode.Text
        Catch ex As Exception
            MessageBox.Show("Failed to call some or all of the required subroutines. Exiting game mode.", "Subroutine Call Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            BlackSquareGame.Close()
            BlackSquareSettings.Show()
        End Try
    End Sub

    Public Sub GetQuestionnaire()
        Dim ConnectionString As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Mark Nolledo\Documents\Visual Studio 2010\Projects\Project Amuse 2\Project Amuse 2\data\ProjectAmuse.mdb"
        Dim SelectQuery As String = "SELECT * FROM questionnaire ORDER BY ID ASC"
        Dim AmuseDataAdapter As New OleDbDataAdapter(SelectQuery, ConnectionString)

        Using DBConnection As New OleDbConnection(ConnectionString)
            Try
                DBConnection.Open()
                'MessageBox.Show("Connection to question database is successfully established.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Catch ex As Exception
                MessageBox.Show("Connection failed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try

            Try
                AmuseDataAdapter.Fill(AmuseDataSet, "QuestionSheet")
                'MessageBox.Show("Questions are successfully loaded.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Dim RowCount As Integer = AmuseDataSet.Tables("QuestionSheet").Rows.Count()
                'MessageBox.Show("There are " & RowCount & " questions in the current data set. Good luck!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Catch ex As Exception
                MessageBox.Show("Question loading failed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        End Using

        Try
            DisplayQuestions()
            Try
                SetTimer()
                BlackSquareGame.Show()
            Catch ex As Exception
                MessageBox.Show("Failed to call subroutine SetTimer. Exiting game mode.", "Subroutine Call Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                BlackSquareGame.Close()
                BlackSquareSettings.Show()
            End Try
        Catch ex As Exception
            MessageBox.Show("An error occured while trying to display the questions.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Sub GenerateRandomNumber()
        Dim RowCount As Integer = AmuseDataSet.Tables("QuestionSheet").Rows.Count() - 1
        If x >= RowCount Then
            BlackSquareGame.GameTimer.Enabled = False
            BlackSquareResults.Show()
        Else
            QuestionNumber = Randomizer.Next(0, RowCount)
            RandomizedNumbers(x) = QuestionNumber
            CheckRandomNumber()
            index = QuestionNumber
            DisplayQuestions()
        End If
    End Sub

    Public Sub CheckRandomNumber()
        For ctr = 0 To x - 1 Step 1
            If RandomizedNumbers(ctr) = QuestionNumber Then
                GenerateRandomNumber()
            End If
        Next
    End Sub

    Public Sub DisplayQuestions()
        Dim RowCount As Integer = AmuseDataSet.Tables("QuestionSheet").Rows.Count() - 1

        If x <= RowCount Then
            BlackSquareGame.lblQuestion.Text = AmuseDataSet.Tables("QuestionSheet").Rows(index).Item("Question")
            BlackSquareGame.lblQuestion.Text = AmuseDataSet.Tables("QuestionSheet").Rows(index).Item("Question")
            BlackSquareGame.btnChoiceA.Text = AmuseDataSet.Tables("QuestionSheet").Rows(index).Item("ChoiceA")
            BlackSquareGame.btnChoiceB.Text = AmuseDataSet.Tables("QuestionSheet").Rows(index).Item("ChoiceB")
            BlackSquareGame.btnChoiceC.Text = AmuseDataSet.Tables("QuestionSheet").Rows(index).Item("ChoiceC")
            BlackSquareGame.btnChoiceD.Text = AmuseDataSet.Tables("QuestionSheet").Rows(index).Item("ChoiceD")
        Else
            BlackSquareGame.GameTimer.Enabled = False
            BlackSquareResults.Show()
        End If
    End Sub

    Public Sub GetAnswer()
        Dim AnswerKey As String

        AnswerKey = AmuseDataSet.Tables("QuestionSheet").Rows(index).Item("Answer")
        If AnswerFromUser <> AnswerKey Then
            If GameMode = "timeattack" Then
                BlackSquareGame.HPBarMain.Width -= 10
            ElseIf GameMode = "tgmchallenge" Then
                BlackSquareGame.HPBarMain.Width -= 20
            Else
                BlackSquareGame.HPBarMain.Width -= 7
            End If

            UserIncorrectAnswers += 1
            If GameMode = "timeattack" Or GameMode = "tgmchallenge" Then
                GenerateRandomNumber()
            Else
                index += 1
            End If
            x += 1
        Else
            If BlackSquareGame.HPBarMain.Width >= 360 Then
                BlackSquareGame.HPBarMain.Width += 0    'No longer increases the bar's width
                BlackSquareGame.HPBarMain.Width = 360   'If it exceeds the default width, resets the width to 360
            Else
                If GameMode = "tgmchallenge" Then
                    BlackSquareGame.HPBarMain.Width += 7
                Else
                    BlackSquareGame.HPBarMain.Width += 5
                End If
            End If

            BlackSquareGame.lblScoreCounter.Text = Val(BlackSquareGame.lblScoreCounter.Text) + 300
            UserCorrectAnswers += 1
            If GameMode = "timeattack" Or GameMode = "tgmchallenge" Then
                GenerateRandomNumber()
            Else
                index += 1
            End If
            x += 1

            If x > 5 And GameMode = "timeattack" Then
                BlackSquareGame.lblTimer.Text = Val(BlackSquareGame.lblTimer.Text) + 3
            ElseIf x > 10 And GameMode = "tgmchallenge" Then
                BlackSquareGame.lblTimer.Text = Val(BlackSquareGame.lblTimer.Text) + 3
            End If
        End If

        If GameMode = "standard" Or GameMode = "relaxed" Then
            DisplayQuestions()
        End If

        If BlackSquareGame.HPBarMain.Width <= 0 Then
            BlackSquareGame.Close()
            BlackSquareResults.Show()
            BlackSquareResults.lblGameVerdict.Text = "HP DRAINED"
            BlackSquareResults.lblGameVerdict.ForeColor = Color.Red
        End If
    End Sub

    Public Sub SetTimer()
        If GameMode = "standard" Then
            Try
                BlackSquareGame.lblTimer.Text = 0
                BlackSquareGame.GameTimer.Enabled = True
            Catch ex As Exception
                MessageBox.Show("An error was encountered while setting the timer. Exiting Standard game mode.", "Set Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                BlackSquareGame.Close()
                BlackSquareSettings.Show()
            End Try

        ElseIf GameMode = "timeattack" Then
            Try
                BlackSquareGame.lblTimer.Text = 25
                BlackSquareGame.GameTimer.Enabled = True
            Catch ex As Exception
                MessageBox.Show("An error was encountered while setting the timer. Exiting Time Attack game mode.", "Set Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                BlackSquareGame.Close()
                BlackSquareSettings.Show()
            End Try

        ElseIf GameMode = "relaxed" Then
            Try
                BlackSquareGame.lblTimer.Text = "∞"
            Catch ex As Exception
                MessageBox.Show("An error was encountered while setting the timer. Exiting Relaxed game mode.", "Set Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                BlackSquareGame.Close()
                BlackSquareSettings.Show()
            End Try

        ElseIf GameMode = "tgmchallenge" Then
            Try
                BlackSquareGame.lblTimer.Text = 30
                BlackSquareGame.GameTimer.Enabled = True
            Catch ex As Exception
                MessageBox.Show("An error was encountered while setting the timer. Exiting The Grand Master Challenge game mode.", "Set Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                BlackSquareGame.Close()
                BlackSquareSettings.Show()
            End Try
        End If
    End Sub

    Public Sub Drain()
        If GameMode = "timeattack" Or GameMode = "tgmchallenge" Then
            BlackSquareGame.lblTimer.Text = Val(BlackSquareGame.lblTimer.Text) - 1
            If GameMode = "tgmchallenge" Then
                BlackSquareGame.HPBarMain.Width = BlackSquareGame.HPBarMain.Width - 3
            End If
        Else
            BlackSquareGame.lblTimer.Text = Val(BlackSquareGame.lblTimer.Text) + 1
        End If

        If BlackSquareGame.HPBarMain.Width <= 0 Then
            BlackSquareGame.Close()
            BlackSquareResults.Show()
            BlackSquareResults.lblGameVerdict.Text = "HP DRAINED"
            BlackSquareResults.lblGameVerdict.ForeColor = Color.Red
        End If

        If Val(BlackSquareGame.lblTimer.Text) = 0 Then
            BlackSquareGame.GameTimer.Enabled = False
            BlackSquareGame.Close()
            BlackSquareResults.Show()
            BlackSquareResults.lblGameVerdict.Text = "OUT OF TIME"
            BlackSquareResults.lblGameVerdict.ForeColor = Color.Red
        End If

        If BlackSquareGame.HPBarMain.Width < 100 Then
            BlackSquareGame.HPBarMain.BackColor = Color.Red

        ElseIf BlackSquareGame.HPBarMain.Width < 200 Then
            BlackSquareGame.HPBarMain.BackColor = Color.Gold

        ElseIf BlackSquareGame.HPBarMain.Width < 260 Then
            BlackSquareGame.HPBarMain.BackColor = Color.Yellow
        End If
    End Sub

    Public Sub GameResults()
        AmuseDataSet.Tables.Clear()

        GameScore = Val(BlackSquareGame.lblScoreCounter.Text)
        BlackSquareResults.lblGameScore.Text = GameScore

        'Show user information
        BlackSquareResults.lblUsername.Text = Cardinal.username.ToUpper()
        BlackSquareResults.lblUserLevel.Text &= Cardinal.UserLevel
        BlackSquareResults.lblUserType.Text = Cardinal.UserType.ToUpper()
        BlackSquareResults.picMiniUserPhoto.ImageLocation = Cardinal.PhotoPath

        'Get correct answer count
        BlackSquareResults.lblCorrectAnswerCounter.Text = UserCorrectAnswers

        'Get incorrect answer count
        BlackSquareResults.lblMissCounter.Text = UserIncorrectAnswers

        'Compute accuracy
        Dim accuracy As Decimal
        accuracy = Math.Floor((UserCorrectAnswers / (x + 1)) * 100)
        BlackSquareResults.lblAccuracyCounter.Text = accuracy & "%"

        'Assign game grade
        If accuracy < 50 Or BlackSquareGame.HPBarMain.Width <= 0 Or BlackSquareGame.lblTimer.Text <= 0 Then
            BlackSquareResults.lblGameGrade.Text = "F"
            BlackSquareResults.lblGameGrade.ForeColor = Color.Red

        ElseIf accuracy > 50 And accuracy <= 60 Then
            BlackSquareResults.lblGameGrade.Text = "D"
            BlackSquareResults.lblGameGrade.ForeColor = Color.Red

        ElseIf accuracy > 60 And accuracy <= 70 Then
            BlackSquareResults.lblGameGrade.Text = "C"
            BlackSquareResults.lblGameGrade.ForeColor = Color.BlueViolet

        ElseIf accuracy > 70 And accuracy <= 80 Then
            BlackSquareResults.lblGameGrade.Text = "B"
            BlackSquareResults.lblGameGrade.ForeColor = Color.Blue

        ElseIf accuracy > 80 And accuracy <= 85 Then
            BlackSquareResults.lblGameGrade.Text = "A"
            BlackSquareResults.lblGameGrade.ForeColor = Color.Green

        ElseIf accuracy > 85 And accuracy <= 90 Then
            BlackSquareResults.lblGameGrade.Text = "A+"
            BlackSquareResults.lblGameGrade.ForeColor = Color.Green

        ElseIf accuracy > 90 And accuracy <= 95 Then
            BlackSquareResults.lblGameGrade.Text = "A++"
            BlackSquareResults.lblGameGrade.ForeColor = Color.GreenYellow

        ElseIf accuracy > 95 And accuracy <= 98 Then
            BlackSquareResults.lblGameGrade.Text = "S"
            BlackSquareResults.lblGameGrade.ForeColor = Color.Yellow

        ElseIf accuracy > 98 And accuracy <= 100 Then
            BlackSquareResults.lblGameGrade.Text = "S++"
            BlackSquareResults.lblGameGrade.ForeColor = Color.Gold
        End If

        'Get earned shop points
        Dim EarnedShopPoints As Integer
        EarnedShopPoints = GameScore * 0.1
        BlackSquareResults.lblEarnedShopPoints.Text = "+" & EarnedShopPoints
        Overview.lblShopPointsNumber.Text = Val(Overview.lblShopPointsNumber.Text) + EarnedShopPoints

        'Get earned experience points
        Dim EarnedExperience As Integer
        EarnedExperience = ((GameScore * accuracy) / 100) * 0.01
        BlackSquareResults.lblExperiencePointsGained.Text = "+" & EarnedExperience
        Overview.lblAmuseEXPNumber.Text = Val(Overview.lblAmuseEXPNumber.Text) + EarnedExperience

        'Set game verdict
        BlackSquareResults.lblGameVerdict.Text = "MODE CLEARED"
        BlackSquareResults.lblGameVerdict.ForeColor = Color.GreenYellow

    End Sub

    Public Sub EndGame()
        Dim UserPrompt As DialogResult = MessageBox.Show("Are you sure you want to end the game?" & vbCrLf & "Doing so will cause you to lose any unsaved progress in the game.", "End Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If UserPrompt = Windows.Forms.DialogResult.Yes Then
            AmuseDataSet.Tables.Clear()
            BlackSquareGame.Close()
            Overview.Show()
        End If
    End Sub
End Module
