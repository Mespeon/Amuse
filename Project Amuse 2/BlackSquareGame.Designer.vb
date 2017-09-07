<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlackSquareGame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlackSquareGame))
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnChoiceA = New System.Windows.Forms.Button()
        Me.btnChoiceB = New System.Windows.Forms.Button()
        Me.btnChoiceC = New System.Windows.Forms.Button()
        Me.btnChoiceD = New System.Windows.Forms.Button()
        Me.panelStatus = New System.Windows.Forms.Panel()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblScoreCounter = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblSPGauge = New System.Windows.Forms.Label()
        Me.lblHPGauge = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.picMiniUserPhoto = New System.Windows.Forms.PictureBox()
        Me.lblUserLevel = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.SPBarMain = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.HPBarMain = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SPBarOuter = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.HPBarOuter = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.panelStatusBuffs = New System.Windows.Forms.Panel()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnEndGame = New System.Windows.Forms.Button()
        Me.lblGameMode = New System.Windows.Forms.Label()
        Me.picHeaderPhoto = New System.Windows.Forms.PictureBox()
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.panelChoiceSet = New System.Windows.Forms.Panel()
        Me.panelStatus.SuspendLayout()
        CType(Me.picMiniUserPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelStatusBuffs.SuspendLayout()
        CType(Me.picHeaderPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelChoiceSet.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoEllipsis = True
        Me.lblQuestion.Font = New System.Drawing.Font("Swis721 Cn BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(88, 262)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(1006, 130)
        Me.lblQuestion.TabIndex = 1
        Me.lblQuestion.Text = "Question"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnChoiceA
        '
        Me.btnChoiceA.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnChoiceA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoiceA.Font = New System.Drawing.Font("Swis721 Cn BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoiceA.Location = New System.Drawing.Point(88, 12)
        Me.btnChoiceA.Name = "btnChoiceA"
        Me.btnChoiceA.Size = New System.Drawing.Size(500, 100)
        Me.btnChoiceA.TabIndex = 3
        Me.btnChoiceA.Text = "A"
        Me.btnChoiceA.UseVisualStyleBackColor = True
        '
        'btnChoiceB
        '
        Me.btnChoiceB.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnChoiceB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoiceB.Font = New System.Drawing.Font("Swis721 Cn BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoiceB.Location = New System.Drawing.Point(594, 12)
        Me.btnChoiceB.Name = "btnChoiceB"
        Me.btnChoiceB.Size = New System.Drawing.Size(500, 100)
        Me.btnChoiceB.TabIndex = 4
        Me.btnChoiceB.Text = "B"
        Me.btnChoiceB.UseVisualStyleBackColor = True
        '
        'btnChoiceC
        '
        Me.btnChoiceC.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnChoiceC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoiceC.Font = New System.Drawing.Font("Swis721 Cn BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoiceC.Location = New System.Drawing.Point(88, 118)
        Me.btnChoiceC.Name = "btnChoiceC"
        Me.btnChoiceC.Size = New System.Drawing.Size(500, 100)
        Me.btnChoiceC.TabIndex = 5
        Me.btnChoiceC.Text = "C"
        Me.btnChoiceC.UseVisualStyleBackColor = True
        '
        'btnChoiceD
        '
        Me.btnChoiceD.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnChoiceD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoiceD.Font = New System.Drawing.Font("Swis721 Cn BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoiceD.Location = New System.Drawing.Point(594, 118)
        Me.btnChoiceD.Name = "btnChoiceD"
        Me.btnChoiceD.Size = New System.Drawing.Size(500, 100)
        Me.btnChoiceD.TabIndex = 6
        Me.btnChoiceD.Text = "D"
        Me.btnChoiceD.UseVisualStyleBackColor = True
        '
        'panelStatus
        '
        Me.panelStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelStatus.Controls.Add(Me.lblTimer)
        Me.panelStatus.Controls.Add(Me.lblScoreCounter)
        Me.panelStatus.Controls.Add(Me.lblScore)
        Me.panelStatus.Controls.Add(Me.lblSPGauge)
        Me.panelStatus.Controls.Add(Me.lblHPGauge)
        Me.panelStatus.Controls.Add(Me.lblUserType)
        Me.panelStatus.Controls.Add(Me.picMiniUserPhoto)
        Me.panelStatus.Controls.Add(Me.lblUserLevel)
        Me.panelStatus.Controls.Add(Me.lblUsername)
        Me.panelStatus.Controls.Add(Me.ShapeContainer1)
        Me.panelStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelStatus.Location = New System.Drawing.Point(0, 0)
        Me.panelStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.panelStatus.Name = "panelStatus"
        Me.panelStatus.Size = New System.Drawing.Size(1184, 60)
        Me.panelStatus.TabIndex = 9
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Swis721 Cn BT", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(1098, 1)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(84, 57)
        Me.lblTimer.TabIndex = 18
        Me.lblTimer.Text = "00"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScoreCounter
        '
        Me.lblScoreCounter.Font = New System.Drawing.Font("Swis721 Cn BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreCounter.Location = New System.Drawing.Point(676, 22)
        Me.lblScoreCounter.Name = "lblScoreCounter"
        Me.lblScoreCounter.Size = New System.Drawing.Size(121, 29)
        Me.lblScoreCounter.TabIndex = 17
        Me.lblScoreCounter.Text = "000000000"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(678, 8)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(36, 14)
        Me.lblScore.TabIndex = 16
        Me.lblScore.Text = "SCORE"
        '
        'lblSPGauge
        '
        Me.lblSPGauge.AutoSize = True
        Me.lblSPGauge.Font = New System.Drawing.Font("Swis721 Cn BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSPGauge.Location = New System.Drawing.Point(233, 30)
        Me.lblSPGauge.Name = "lblSPGauge"
        Me.lblSPGauge.Size = New System.Drawing.Size(27, 19)
        Me.lblSPGauge.TabIndex = 15
        Me.lblSPGauge.Text = "SP"
        '
        'lblHPGauge
        '
        Me.lblHPGauge.AutoSize = True
        Me.lblHPGauge.Font = New System.Drawing.Font("Swis721 Cn BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHPGauge.Location = New System.Drawing.Point(233, 9)
        Me.lblHPGauge.Name = "lblHPGauge"
        Me.lblHPGauge.Size = New System.Drawing.Size(28, 19)
        Me.lblHPGauge.TabIndex = 14
        Me.lblHPGauge.Text = "HP"
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUserType.Location = New System.Drawing.Point(74, 40)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(53, 14)
        Me.lblUserType.TabIndex = 12
        Me.lblUserType.Text = "USERTYPE"
        '
        'picMiniUserPhoto
        '
        Me.picMiniUserPhoto.Location = New System.Drawing.Point(18, 4)
        Me.picMiniUserPhoto.Name = "picMiniUserPhoto"
        Me.picMiniUserPhoto.Size = New System.Drawing.Size(50, 50)
        Me.picMiniUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMiniUserPhoto.TabIndex = 0
        Me.picMiniUserPhoto.TabStop = False
        '
        'lblUserLevel
        '
        Me.lblUserLevel.AutoSize = True
        Me.lblUserLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUserLevel.Location = New System.Drawing.Point(74, 18)
        Me.lblUserLevel.Name = "lblUserLevel"
        Me.lblUserLevel.Size = New System.Drawing.Size(24, 14)
        Me.lblUserLevel.TabIndex = 11
        Me.lblUserLevel.Text = "LV. "
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(74, 4)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(57, 14)
        Me.lblUsername.TabIndex = 10
        Me.lblUsername.Text = "USERNAME"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.SPBarMain, Me.HPBarMain, Me.SPBarOuter, Me.HPBarOuter})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1182, 58)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'SPBarMain
        '
        Me.SPBarMain.BackColor = System.Drawing.Color.MediumBlue
        Me.SPBarMain.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.SPBarMain.BorderColor = System.Drawing.Color.Black
        Me.SPBarMain.Location = New System.Drawing.Point(275, 33)
        Me.SPBarMain.Name = "SPBarMain"
        Me.SPBarMain.Size = New System.Drawing.Size(360, 15)
        '
        'HPBarMain
        '
        Me.HPBarMain.BackColor = System.Drawing.Color.LimeGreen
        Me.HPBarMain.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.HPBarMain.BorderColor = System.Drawing.Color.Black
        Me.HPBarMain.Location = New System.Drawing.Point(275, 10)
        Me.HPBarMain.Name = "HPBarMain"
        Me.HPBarMain.Size = New System.Drawing.Size(360, 15)
        '
        'SPBarOuter
        '
        Me.SPBarOuter.BorderColor = System.Drawing.Color.Gray
        Me.SPBarOuter.Location = New System.Drawing.Point(272, 31)
        Me.SPBarOuter.Name = "SPBarOuter"
        Me.SPBarOuter.Size = New System.Drawing.Size(366, 19)
        '
        'HPBarOuter
        '
        Me.HPBarOuter.BorderColor = System.Drawing.Color.Gray
        Me.HPBarOuter.Location = New System.Drawing.Point(272, 8)
        Me.HPBarOuter.Name = "HPBarOuter"
        Me.HPBarOuter.Size = New System.Drawing.Size(366, 19)
        '
        'panelStatusBuffs
        '
        Me.panelStatusBuffs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelStatusBuffs.Controls.Add(Me.btnPause)
        Me.panelStatusBuffs.Controls.Add(Me.btnEndGame)
        Me.panelStatusBuffs.Controls.Add(Me.lblGameMode)
        Me.panelStatusBuffs.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelStatusBuffs.Location = New System.Drawing.Point(0, 631)
        Me.panelStatusBuffs.Name = "panelStatusBuffs"
        Me.panelStatusBuffs.Size = New System.Drawing.Size(1184, 30)
        Me.panelStatusBuffs.TabIndex = 10
        '
        'btnPause
        '
        Me.btnPause.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPause.FlatAppearance.BorderSize = 0
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.Location = New System.Drawing.Point(1020, 3)
        Me.btnPause.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 26)
        Me.btnPause.TabIndex = 2
        Me.btnPause.Text = "PAUSE"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnEndGame
        '
        Me.btnEndGame.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEndGame.FlatAppearance.BorderSize = 0
        Me.btnEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEndGame.Location = New System.Drawing.Point(1108, 3)
        Me.btnEndGame.Name = "btnEndGame"
        Me.btnEndGame.Size = New System.Drawing.Size(75, 26)
        Me.btnEndGame.TabIndex = 1
        Me.btnEndGame.Text = "END GAME"
        Me.btnEndGame.UseVisualStyleBackColor = True
        '
        'lblGameMode
        '
        Me.lblGameMode.Location = New System.Drawing.Point(442, 4)
        Me.lblGameMode.Name = "lblGameMode"
        Me.lblGameMode.Size = New System.Drawing.Size(298, 21)
        Me.lblGameMode.TabIndex = 0
        Me.lblGameMode.Text = "CURRENT GAME MODE: "
        Me.lblGameMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picHeaderPhoto
        '
        Me.picHeaderPhoto.Image = CType(resources.GetObject("picHeaderPhoto.Image"), System.Drawing.Image)
        Me.picHeaderPhoto.Location = New System.Drawing.Point(0, 64)
        Me.picHeaderPhoto.Name = "picHeaderPhoto"
        Me.picHeaderPhoto.Size = New System.Drawing.Size(1183, 195)
        Me.picHeaderPhoto.TabIndex = 11
        Me.picHeaderPhoto.TabStop = False
        '
        'GameTimer
        '
        Me.GameTimer.Interval = 1000
        '
        'panelChoiceSet
        '
        Me.panelChoiceSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelChoiceSet.Controls.Add(Me.btnChoiceC)
        Me.panelChoiceSet.Controls.Add(Me.btnChoiceA)
        Me.panelChoiceSet.Controls.Add(Me.btnChoiceB)
        Me.panelChoiceSet.Controls.Add(Me.btnChoiceD)
        Me.panelChoiceSet.Location = New System.Drawing.Point(0, 395)
        Me.panelChoiceSet.Name = "panelChoiceSet"
        Me.panelChoiceSet.Size = New System.Drawing.Size(1183, 230)
        Me.panelChoiceSet.TabIndex = 12
        '
        'BlackSquareGame
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btnPause
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelChoiceSet)
        Me.Controls.Add(Me.panelStatusBuffs)
        Me.Controls.Add(Me.panelStatus)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.picHeaderPhoto)
        Me.Font = New System.Drawing.Font("Swis721 Cn BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BlackSquareGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Codename: Black Square - Project Amuse 2 v1.0.0.4 - "
        Me.panelStatus.ResumeLayout(False)
        Me.panelStatus.PerformLayout()
        CType(Me.picMiniUserPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelStatusBuffs.ResumeLayout(False)
        CType(Me.picHeaderPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelChoiceSet.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btnChoiceA As System.Windows.Forms.Button
    Friend WithEvents btnChoiceB As System.Windows.Forms.Button
    Friend WithEvents btnChoiceC As System.Windows.Forms.Button
    Friend WithEvents btnChoiceD As System.Windows.Forms.Button
    Friend WithEvents panelStatus As System.Windows.Forms.Panel
    Friend WithEvents picMiniUserPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblUserType As System.Windows.Forms.Label
    Friend WithEvents lblUserLevel As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents HPBarOuter As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblSPGauge As System.Windows.Forms.Label
    Friend WithEvents lblHPGauge As System.Windows.Forms.Label
    Friend WithEvents SPBarOuter As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents SPBarMain As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents HPBarMain As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblScoreCounter As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents panelStatusBuffs As System.Windows.Forms.Panel
    Friend WithEvents picHeaderPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents GameTimer As System.Windows.Forms.Timer
    Friend WithEvents panelChoiceSet As System.Windows.Forms.Panel
    Friend WithEvents lblGameMode As System.Windows.Forms.Label
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnEndGame As System.Windows.Forms.Button
End Class
