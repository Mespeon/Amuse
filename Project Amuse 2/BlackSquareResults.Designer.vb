<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlackSquareResults
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlackSquareResults))
        Me.lblResultsTitle = New System.Windows.Forms.Label()
        Me.picGameMode = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.picMiniUserPhoto = New System.Windows.Forms.PictureBox()
        Me.lblUserLevel = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblCorrectAnswers = New System.Windows.Forms.Label()
        Me.lblMisses = New System.Windows.Forms.Label()
        Me.lblAccuracy = New System.Windows.Forms.Label()
        Me.lblGameGrade = New System.Windows.Forms.Label()
        Me.lblCorrectAnswerCounter = New System.Windows.Forms.Label()
        Me.lblMissCounter = New System.Windows.Forms.Label()
        Me.lblAccuracyCounter = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEarnedShopPoints = New System.Windows.Forms.Label()
        Me.lblExperiencePointsGained = New System.Windows.Forms.Label()
        Me.lblGameVerdict = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblGameScore = New System.Windows.Forms.Label()
        CType(Me.picGameMode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picMiniUserPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResultsTitle
        '
        Me.lblResultsTitle.AutoSize = True
        Me.lblResultsTitle.Font = New System.Drawing.Font("Swis721 Cn BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultsTitle.Location = New System.Drawing.Point(8, 105)
        Me.lblResultsTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblResultsTitle.Name = "lblResultsTitle"
        Me.lblResultsTitle.Size = New System.Drawing.Size(146, 29)
        Me.lblResultsTitle.TabIndex = 0
        Me.lblResultsTitle.Text = "Game Results"
        '
        'picGameMode
        '
        Me.picGameMode.Image = Global.Project_Amuse_2.My.Resources.Resources.Splasher_BG_2
        Me.picGameMode.Location = New System.Drawing.Point(0, 0)
        Me.picGameMode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.picGameMode.Name = "picGameMode"
        Me.picGameMode.Size = New System.Drawing.Size(396, 100)
        Me.picGameMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGameMode.TabIndex = 1
        Me.picGameMode.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblGameScore)
        Me.Panel1.Controls.Add(Me.lblScore)
        Me.Panel1.Controls.Add(Me.lblUserType)
        Me.Panel1.Controls.Add(Me.picMiniUserPhoto)
        Me.Panel1.Controls.Add(Me.lblUserLevel)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Location = New System.Drawing.Point(13, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 100)
        Me.Panel1.TabIndex = 2
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUserType.Location = New System.Drawing.Point(71, 61)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(53, 14)
        Me.lblUserType.TabIndex = 11
        Me.lblUserType.Text = "USERTYPE"
        '
        'picMiniUserPhoto
        '
        Me.picMiniUserPhoto.Location = New System.Drawing.Point(15, 25)
        Me.picMiniUserPhoto.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.picMiniUserPhoto.Name = "picMiniUserPhoto"
        Me.picMiniUserPhoto.Size = New System.Drawing.Size(50, 50)
        Me.picMiniUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMiniUserPhoto.TabIndex = 9
        Me.picMiniUserPhoto.TabStop = False
        '
        'lblUserLevel
        '
        Me.lblUserLevel.AutoSize = True
        Me.lblUserLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUserLevel.Location = New System.Drawing.Point(71, 39)
        Me.lblUserLevel.Name = "lblUserLevel"
        Me.lblUserLevel.Size = New System.Drawing.Size(24, 14)
        Me.lblUserLevel.TabIndex = 10
        Me.lblUserLevel.Text = "LV. "
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(71, 25)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(57, 14)
        Me.lblUsername.TabIndex = 8
        Me.lblUsername.Text = "USERNAME"
        '
        'lblCorrectAnswers
        '
        Me.lblCorrectAnswers.AutoSize = True
        Me.lblCorrectAnswers.Location = New System.Drawing.Point(69, 246)
        Me.lblCorrectAnswers.Margin = New System.Windows.Forms.Padding(5)
        Me.lblCorrectAnswers.Name = "lblCorrectAnswers"
        Me.lblCorrectAnswers.Size = New System.Drawing.Size(46, 14)
        Me.lblCorrectAnswers.TabIndex = 3
        Me.lblCorrectAnswers.Text = "Star Hits"
        '
        'lblMisses
        '
        Me.lblMisses.AutoSize = True
        Me.lblMisses.Location = New System.Drawing.Point(168, 246)
        Me.lblMisses.Margin = New System.Windows.Forms.Padding(5)
        Me.lblMisses.Name = "lblMisses"
        Me.lblMisses.Size = New System.Drawing.Size(38, 14)
        Me.lblMisses.TabIndex = 4
        Me.lblMisses.Text = "Misses"
        '
        'lblAccuracy
        '
        Me.lblAccuracy.AutoSize = True
        Me.lblAccuracy.Location = New System.Drawing.Point(269, 246)
        Me.lblAccuracy.Margin = New System.Windows.Forms.Padding(5)
        Me.lblAccuracy.Name = "lblAccuracy"
        Me.lblAccuracy.Size = New System.Drawing.Size(47, 14)
        Me.lblAccuracy.TabIndex = 5
        Me.lblAccuracy.Text = "Accuracy"
        '
        'lblGameGrade
        '
        Me.lblGameGrade.Font = New System.Drawing.Font("Swis721 Cn BT", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameGrade.Location = New System.Drawing.Point(54, 309)
        Me.lblGameGrade.Margin = New System.Windows.Forms.Padding(5)
        Me.lblGameGrade.Name = "lblGameGrade"
        Me.lblGameGrade.Size = New System.Drawing.Size(287, 77)
        Me.lblGameGrade.TabIndex = 6
        Me.lblGameGrade.Text = "S++"
        Me.lblGameGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorrectAnswerCounter
        '
        Me.lblCorrectAnswerCounter.Font = New System.Drawing.Font("Swis721 Cn BT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectAnswerCounter.Location = New System.Drawing.Point(51, 265)
        Me.lblCorrectAnswerCounter.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        Me.lblCorrectAnswerCounter.Name = "lblCorrectAnswerCounter"
        Me.lblCorrectAnswerCounter.Size = New System.Drawing.Size(82, 39)
        Me.lblCorrectAnswerCounter.TabIndex = 7
        Me.lblCorrectAnswerCounter.Text = "000"
        Me.lblCorrectAnswerCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMissCounter
        '
        Me.lblMissCounter.Font = New System.Drawing.Font("Swis721 Cn BT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissCounter.Location = New System.Drawing.Point(146, 265)
        Me.lblMissCounter.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        Me.lblMissCounter.Name = "lblMissCounter"
        Me.lblMissCounter.Size = New System.Drawing.Size(82, 39)
        Me.lblMissCounter.TabIndex = 8
        Me.lblMissCounter.Text = "000"
        Me.lblMissCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAccuracyCounter
        '
        Me.lblAccuracyCounter.Font = New System.Drawing.Font("Swis721 Cn BT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccuracyCounter.Location = New System.Drawing.Point(241, 265)
        Me.lblAccuracyCounter.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        Me.lblAccuracyCounter.Name = "lblAccuracyCounter"
        Me.lblAccuracyCounter.Size = New System.Drawing.Size(103, 39)
        Me.lblAccuracyCounter.TabIndex = 9
        Me.lblAccuracyCounter.Text = "00.00%"
        Me.lblAccuracyCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.Silver
        Me.btnClose.Location = New System.Drawing.Point(307, 425)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(89, 34)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Shop Points"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 395)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Experience"
        '
        'lblEarnedShopPoints
        '
        Me.lblEarnedShopPoints.Location = New System.Drawing.Point(109, 395)
        Me.lblEarnedShopPoints.Name = "lblEarnedShopPoints"
        Me.lblEarnedShopPoints.Size = New System.Drawing.Size(88, 14)
        Me.lblEarnedShopPoints.TabIndex = 13
        Me.lblEarnedShopPoints.Text = "+000000"
        Me.lblEarnedShopPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExperiencePointsGained
        '
        Me.lblExperiencePointsGained.Location = New System.Drawing.Point(262, 395)
        Me.lblExperiencePointsGained.Name = "lblExperiencePointsGained"
        Me.lblExperiencePointsGained.Size = New System.Drawing.Size(88, 14)
        Me.lblExperiencePointsGained.TabIndex = 14
        Me.lblExperiencePointsGained.Text = "+000000"
        Me.lblExperiencePointsGained.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGameVerdict
        '
        Me.lblGameVerdict.Location = New System.Drawing.Point(141, 425)
        Me.lblGameVerdict.Name = "lblGameVerdict"
        Me.lblGameVerdict.Size = New System.Drawing.Size(113, 33)
        Me.lblGameVerdict.TabIndex = 15
        Me.lblGameVerdict.Text = "VERDICT"
        Me.lblGameVerdict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(177, 25)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(36, 14)
        Me.lblScore.TabIndex = 12
        Me.lblScore.Text = "SCORE"
        '
        'lblGameScore
        '
        Me.lblGameScore.Font = New System.Drawing.Font("Swis721 Cn BT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameScore.Location = New System.Drawing.Point(174, 43)
        Me.lblGameScore.Name = "lblGameScore"
        Me.lblGameScore.Size = New System.Drawing.Size(177, 32)
        Me.lblGameScore.TabIndex = 13
        Me.lblGameScore.Text = "00000"
        '
        'BlackSquareResults
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(394, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblGameVerdict)
        Me.Controls.Add(Me.lblExperiencePointsGained)
        Me.Controls.Add(Me.lblEarnedShopPoints)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblAccuracyCounter)
        Me.Controls.Add(Me.lblMissCounter)
        Me.Controls.Add(Me.lblCorrectAnswerCounter)
        Me.Controls.Add(Me.lblGameGrade)
        Me.Controls.Add(Me.lblAccuracy)
        Me.Controls.Add(Me.lblMisses)
        Me.Controls.Add(Me.lblCorrectAnswers)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picGameMode)
        Me.Controls.Add(Me.lblResultsTitle)
        Me.Font = New System.Drawing.Font("Swis721 Cn BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BlackSquareResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Results"
        CType(Me.picGameMode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picMiniUserPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResultsTitle As System.Windows.Forms.Label
    Friend WithEvents picGameMode As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblUserType As System.Windows.Forms.Label
    Friend WithEvents picMiniUserPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblUserLevel As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblCorrectAnswers As System.Windows.Forms.Label
    Friend WithEvents lblMisses As System.Windows.Forms.Label
    Friend WithEvents lblAccuracy As System.Windows.Forms.Label
    Friend WithEvents lblGameGrade As System.Windows.Forms.Label
    Friend WithEvents lblCorrectAnswerCounter As System.Windows.Forms.Label
    Friend WithEvents lblMissCounter As System.Windows.Forms.Label
    Friend WithEvents lblAccuracyCounter As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEarnedShopPoints As System.Windows.Forms.Label
    Friend WithEvents lblExperiencePointsGained As System.Windows.Forms.Label
    Friend WithEvents lblGameVerdict As System.Windows.Forms.Label
    Friend WithEvents lblGameScore As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
End Class
