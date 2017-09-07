<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Overview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Overview))
        Me.pnlCustomControlBox = New System.Windows.Forms.Panel()
        Me.cbxThemeSelector = New System.Windows.Forms.ComboBox()
        Me.lblThemeSelector = New System.Windows.Forms.Label()
        Me.lblControlBoxFormName = New System.Windows.Forms.Label()
        Me.btnAccountLogout = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lineFormSplitter = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblUserNameText = New System.Windows.Forms.Label()
        Me.lblUserTypeText = New System.Windows.Forms.Label()
        Me.panelOverview = New System.Windows.Forms.Panel()
        Me.btnAboutAmuse = New System.Windows.Forms.Button()
        Me.btnGuideToAmuse = New System.Windows.Forms.Button()
        Me.lblNoticeText = New System.Windows.Forms.Label()
        Me.panelGameSelector = New System.Windows.Forms.Panel()
        Me.btnLaunchApplication = New System.Windows.Forms.Button()
        Me.lblGameDescription = New System.Windows.Forms.Label()
        Me.lblGameTitle = New System.Windows.Forms.Label()
        Me.picGameImage = New System.Windows.Forms.PictureBox()
        Me.btnBlackSquareSelect = New System.Windows.Forms.Button()
        Me.lblAchievementsText = New System.Windows.Forms.Label()
        Me.lblShopPoints = New System.Windows.Forms.Label()
        Me.lblShopPointsNumber = New System.Windows.Forms.Label()
        Me.lblAmuseEXP = New System.Windows.Forms.Label()
        Me.lblAmuseEXPNumber = New System.Windows.Forms.Label()
        Me.btnAccountControls = New System.Windows.Forms.Button()
        Me.btnAdministratorTools = New System.Windows.Forms.Button()
        Me.btnViewLevelSystemInformation = New System.Windows.Forms.Button()
        Me.btnAccessShop = New System.Windows.Forms.Button()
        Me.lblUserRankNumber = New System.Windows.Forms.Label()
        Me.lblUserRankText = New System.Windows.Forms.Label()
        Me.lblAmuseLevelNumber = New System.Windows.Forms.Label()
        Me.lblUserLevelText = New System.Windows.Forms.Label()
        Me.picUserImage = New System.Windows.Forms.PictureBox()
        Me.pnlCustomControlBox.SuspendLayout()
        Me.panelOverview.SuspendLayout()
        Me.panelGameSelector.SuspendLayout()
        CType(Me.picGameImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCustomControlBox
        '
        Me.pnlCustomControlBox.Controls.Add(Me.cbxThemeSelector)
        Me.pnlCustomControlBox.Controls.Add(Me.lblThemeSelector)
        Me.pnlCustomControlBox.Controls.Add(Me.lblControlBoxFormName)
        Me.pnlCustomControlBox.Controls.Add(Me.btnAccountLogout)
        Me.pnlCustomControlBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCustomControlBox.Location = New System.Drawing.Point(0, 0)
        Me.pnlCustomControlBox.Margin = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.pnlCustomControlBox.Name = "pnlCustomControlBox"
        Me.pnlCustomControlBox.Size = New System.Drawing.Size(800, 30)
        Me.pnlCustomControlBox.TabIndex = 0
        '
        'cbxThemeSelector
        '
        Me.cbxThemeSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxThemeSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxThemeSelector.ForeColor = System.Drawing.Color.Silver
        Me.cbxThemeSelector.FormattingEnabled = True
        Me.cbxThemeSelector.Items.AddRange(New Object() {"Dark", "Light", "Lollipop"})
        Me.cbxThemeSelector.Location = New System.Drawing.Point(608, 5)
        Me.cbxThemeSelector.Margin = New System.Windows.Forms.Padding(2, 3, 10, 3)
        Me.cbxThemeSelector.Name = "cbxThemeSelector"
        Me.cbxThemeSelector.Size = New System.Drawing.Size(111, 22)
        Me.cbxThemeSelector.TabIndex = 3
        '
        'lblThemeSelector
        '
        Me.lblThemeSelector.AutoSize = True
        Me.lblThemeSelector.ForeColor = System.Drawing.Color.Silver
        Me.lblThemeSelector.Location = New System.Drawing.Point(560, 9)
        Me.lblThemeSelector.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblThemeSelector.Name = "lblThemeSelector"
        Me.lblThemeSelector.Size = New System.Drawing.Size(35, 14)
        Me.lblThemeSelector.TabIndex = 2
        Me.lblThemeSelector.Text = "Theme"
        '
        'lblControlBoxFormName
        '
        Me.lblControlBoxFormName.Font = New System.Drawing.Font("Swis721 Cn BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlBoxFormName.ForeColor = System.Drawing.Color.Silver
        Me.lblControlBoxFormName.Location = New System.Drawing.Point(0, 0)
        Me.lblControlBoxFormName.Margin = New System.Windows.Forms.Padding(0)
        Me.lblControlBoxFormName.Name = "lblControlBoxFormName"
        Me.lblControlBoxFormName.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblControlBoxFormName.Size = New System.Drawing.Size(557, 30)
        Me.lblControlBoxFormName.TabIndex = 1
        Me.lblControlBoxFormName.Text = " - Project Amuse Account Overview"
        Me.lblControlBoxFormName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAccountLogout
        '
        Me.btnAccountLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAccountLogout.FlatAppearance.BorderSize = 0
        Me.btnAccountLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountLogout.Font = New System.Drawing.Font("Swis721 Cn BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountLogout.ForeColor = System.Drawing.Color.Silver
        Me.btnAccountLogout.Location = New System.Drawing.Point(728, 0)
        Me.btnAccountLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAccountLogout.Name = "btnAccountLogout"
        Me.btnAccountLogout.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.btnAccountLogout.Size = New System.Drawing.Size(71, 30)
        Me.btnAccountLogout.TabIndex = 1
        Me.btnAccountLogout.Text = "Log Out"
        Me.btnAccountLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAccountLogout.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lineFormSplitter})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 400)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'lineFormSplitter
        '
        Me.lineFormSplitter.BorderColor = System.Drawing.Color.Gray
        Me.lineFormSplitter.Enabled = False
        Me.lineFormSplitter.Name = "lineFormSplitter"
        Me.lineFormSplitter.X1 = 10
        Me.lineFormSplitter.X2 = 790
        Me.lineFormSplitter.Y1 = 30
        Me.lineFormSplitter.Y2 = 30
        '
        'lblUserNameText
        '
        Me.lblUserNameText.Font = New System.Drawing.Font("Swis721 Cn BT", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserNameText.ForeColor = System.Drawing.Color.White
        Me.lblUserNameText.Location = New System.Drawing.Point(156, -1)
        Me.lblUserNameText.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUserNameText.Name = "lblUserNameText"
        Me.lblUserNameText.Size = New System.Drawing.Size(383, 45)
        Me.lblUserNameText.TabIndex = 3
        Me.lblUserNameText.Text = "User Name"
        '
        'lblUserTypeText
        '
        Me.lblUserTypeText.BackColor = System.Drawing.Color.Transparent
        Me.lblUserTypeText.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserTypeText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUserTypeText.Location = New System.Drawing.Point(158, 35)
        Me.lblUserTypeText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserTypeText.Name = "lblUserTypeText"
        Me.lblUserTypeText.Size = New System.Drawing.Size(206, 21)
        Me.lblUserTypeText.TabIndex = 4
        Me.lblUserTypeText.Text = "User Type"
        '
        'panelOverview
        '
        Me.panelOverview.Controls.Add(Me.btnAboutAmuse)
        Me.panelOverview.Controls.Add(Me.btnGuideToAmuse)
        Me.panelOverview.Controls.Add(Me.lblNoticeText)
        Me.panelOverview.Controls.Add(Me.panelGameSelector)
        Me.panelOverview.Controls.Add(Me.lblAchievementsText)
        Me.panelOverview.Controls.Add(Me.lblShopPoints)
        Me.panelOverview.Controls.Add(Me.lblShopPointsNumber)
        Me.panelOverview.Controls.Add(Me.lblAmuseEXP)
        Me.panelOverview.Controls.Add(Me.lblAmuseEXPNumber)
        Me.panelOverview.Controls.Add(Me.btnAccountControls)
        Me.panelOverview.Controls.Add(Me.btnAdministratorTools)
        Me.panelOverview.Controls.Add(Me.btnViewLevelSystemInformation)
        Me.panelOverview.Controls.Add(Me.btnAccessShop)
        Me.panelOverview.Controls.Add(Me.lblUserRankNumber)
        Me.panelOverview.Controls.Add(Me.lblUserRankText)
        Me.panelOverview.Controls.Add(Me.lblAmuseLevelNumber)
        Me.panelOverview.Controls.Add(Me.lblUserLevelText)
        Me.panelOverview.Controls.Add(Me.lblUserTypeText)
        Me.panelOverview.Controls.Add(Me.lblUserNameText)
        Me.panelOverview.Controls.Add(Me.picUserImage)
        Me.panelOverview.Location = New System.Drawing.Point(10, 45)
        Me.panelOverview.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.panelOverview.Name = "panelOverview"
        Me.panelOverview.Size = New System.Drawing.Size(781, 346)
        Me.panelOverview.TabIndex = 7
        '
        'btnAboutAmuse
        '
        Me.btnAboutAmuse.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAboutAmuse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutAmuse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAboutAmuse.Location = New System.Drawing.Point(2, 249)
        Me.btnAboutAmuse.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAboutAmuse.Name = "btnAboutAmuse"
        Me.btnAboutAmuse.Size = New System.Drawing.Size(150, 39)
        Me.btnAboutAmuse.TabIndex = 21
        Me.btnAboutAmuse.Text = "About Project Amuse"
        Me.btnAboutAmuse.UseVisualStyleBackColor = True
        '
        'btnGuideToAmuse
        '
        Me.btnGuideToAmuse.Enabled = False
        Me.btnGuideToAmuse.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnGuideToAmuse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuideToAmuse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnGuideToAmuse.Location = New System.Drawing.Point(2, 204)
        Me.btnGuideToAmuse.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGuideToAmuse.Name = "btnGuideToAmuse"
        Me.btnGuideToAmuse.Size = New System.Drawing.Size(150, 39)
        Me.btnGuideToAmuse.TabIndex = 20
        Me.btnGuideToAmuse.Text = "Guide to Project Amuse"
        Me.btnGuideToAmuse.UseVisualStyleBackColor = True
        '
        'lblNoticeText
        '
        Me.lblNoticeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoticeText.ForeColor = System.Drawing.Color.White
        Me.lblNoticeText.Location = New System.Drawing.Point(160, 190)
        Me.lblNoticeText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNoticeText.Name = "lblNoticeText"
        Me.lblNoticeText.Size = New System.Drawing.Size(371, 153)
        Me.lblNoticeText.TabIndex = 19
        Me.lblNoticeText.Text = "Section coming soon."
        Me.lblNoticeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelGameSelector
        '
        Me.panelGameSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelGameSelector.Controls.Add(Me.btnLaunchApplication)
        Me.panelGameSelector.Controls.Add(Me.lblGameDescription)
        Me.panelGameSelector.Controls.Add(Me.lblGameTitle)
        Me.panelGameSelector.Controls.Add(Me.picGameImage)
        Me.panelGameSelector.Controls.Add(Me.btnBlackSquareSelect)
        Me.panelGameSelector.Location = New System.Drawing.Point(540, 3)
        Me.panelGameSelector.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.panelGameSelector.Name = "panelGameSelector"
        Me.panelGameSelector.Size = New System.Drawing.Size(238, 340)
        Me.panelGameSelector.TabIndex = 18
        '
        'btnLaunchApplication
        '
        Me.btnLaunchApplication.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnLaunchApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaunchApplication.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnLaunchApplication.Location = New System.Drawing.Point(2, 257)
        Me.btnLaunchApplication.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnLaunchApplication.Name = "btnLaunchApplication"
        Me.btnLaunchApplication.Size = New System.Drawing.Size(232, 23)
        Me.btnLaunchApplication.TabIndex = 24
        Me.btnLaunchApplication.Text = "Start Application"
        Me.btnLaunchApplication.UseVisualStyleBackColor = True
        Me.btnLaunchApplication.Visible = False
        '
        'lblGameDescription
        '
        Me.lblGameDescription.ForeColor = System.Drawing.Color.Silver
        Me.lblGameDescription.Location = New System.Drawing.Point(2, 186)
        Me.lblGameDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGameDescription.Name = "lblGameDescription"
        Me.lblGameDescription.Size = New System.Drawing.Size(230, 68)
        Me.lblGameDescription.TabIndex = 23
        Me.lblGameDescription.Text = "Game Description"
        Me.lblGameDescription.Visible = False
        '
        'lblGameTitle
        '
        Me.lblGameTitle.AutoEllipsis = True
        Me.lblGameTitle.Font = New System.Drawing.Font("Swis721 Cn BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTitle.ForeColor = System.Drawing.Color.White
        Me.lblGameTitle.Location = New System.Drawing.Point(-1, 157)
        Me.lblGameTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGameTitle.Name = "lblGameTitle"
        Me.lblGameTitle.Size = New System.Drawing.Size(234, 29)
        Me.lblGameTitle.TabIndex = 22
        Me.lblGameTitle.Text = "Game Title"
        Me.lblGameTitle.Visible = False
        '
        'picGameImage
        '
        Me.picGameImage.Image = Global.Project_Amuse_2.My.Resources.Resources.game_pic_default
        Me.picGameImage.Location = New System.Drawing.Point(2, 2)
        Me.picGameImage.Margin = New System.Windows.Forms.Padding(1, 1, 1, 5)
        Me.picGameImage.Name = "picGameImage"
        Me.picGameImage.Size = New System.Drawing.Size(232, 150)
        Me.picGameImage.TabIndex = 21
        Me.picGameImage.TabStop = False
        '
        'btnBlackSquareSelect
        '
        Me.btnBlackSquareSelect.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBlackSquareSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlackSquareSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBlackSquareSelect.Location = New System.Drawing.Point(2, 284)
        Me.btnBlackSquareSelect.Margin = New System.Windows.Forms.Padding(2, 1, 1, 1)
        Me.btnBlackSquareSelect.Name = "btnBlackSquareSelect"
        Me.btnBlackSquareSelect.Size = New System.Drawing.Size(232, 53)
        Me.btnBlackSquareSelect.TabIndex = 19
        Me.btnBlackSquareSelect.Text = "Black Square 2.0"
        Me.btnBlackSquareSelect.UseVisualStyleBackColor = True
        '
        'lblAchievementsText
        '
        Me.lblAchievementsText.AutoSize = True
        Me.lblAchievementsText.Font = New System.Drawing.Font("Swis721 Cn BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAchievementsText.ForeColor = System.Drawing.Color.White
        Me.lblAchievementsText.Location = New System.Drawing.Point(155, 159)
        Me.lblAchievementsText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAchievementsText.Name = "lblAchievementsText"
        Me.lblAchievementsText.Size = New System.Drawing.Size(128, 25)
        Me.lblAchievementsText.TabIndex = 17
        Me.lblAchievementsText.Text = "Achievements"
        '
        'lblShopPoints
        '
        Me.lblShopPoints.AutoSize = True
        Me.lblShopPoints.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblShopPoints.Location = New System.Drawing.Point(425, 71)
        Me.lblShopPoints.Margin = New System.Windows.Forms.Padding(2, 15, 2, 0)
        Me.lblShopPoints.Name = "lblShopPoints"
        Me.lblShopPoints.Size = New System.Drawing.Size(58, 14)
        Me.lblShopPoints.TabIndex = 16
        Me.lblShopPoints.Text = "Shop Points"
        '
        'lblShopPointsNumber
        '
        Me.lblShopPointsNumber.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShopPointsNumber.ForeColor = System.Drawing.Color.White
        Me.lblShopPointsNumber.Location = New System.Drawing.Point(380, 84)
        Me.lblShopPointsNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblShopPointsNumber.Name = "lblShopPointsNumber"
        Me.lblShopPointsNumber.Size = New System.Drawing.Size(156, 39)
        Me.lblShopPointsNumber.TabIndex = 15
        Me.lblShopPointsNumber.Text = "00"
        Me.lblShopPointsNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAmuseEXP
        '
        Me.lblAmuseEXP.AutoSize = True
        Me.lblAmuseEXP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAmuseEXP.Location = New System.Drawing.Point(308, 71)
        Me.lblAmuseEXP.Margin = New System.Windows.Forms.Padding(2, 15, 2, 0)
        Me.lblAmuseEXP.Name = "lblAmuseEXP"
        Me.lblAmuseEXP.Size = New System.Drawing.Size(56, 14)
        Me.lblAmuseEXP.TabIndex = 14
        Me.lblAmuseEXP.Text = "Amuse EXP"
        '
        'lblAmuseEXPNumber
        '
        Me.lblAmuseEXPNumber.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmuseEXPNumber.ForeColor = System.Drawing.Color.White
        Me.lblAmuseEXPNumber.Location = New System.Drawing.Point(306, 84)
        Me.lblAmuseEXPNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAmuseEXPNumber.Name = "lblAmuseEXPNumber"
        Me.lblAmuseEXPNumber.Size = New System.Drawing.Size(68, 39)
        Me.lblAmuseEXPNumber.TabIndex = 13
        Me.lblAmuseEXPNumber.Text = "00"
        Me.lblAmuseEXPNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAccountControls
        '
        Me.btnAccountControls.Enabled = False
        Me.btnAccountControls.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAccountControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountControls.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAccountControls.Location = New System.Drawing.Point(2, 159)
        Me.btnAccountControls.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAccountControls.Name = "btnAccountControls"
        Me.btnAccountControls.Size = New System.Drawing.Size(150, 39)
        Me.btnAccountControls.TabIndex = 12
        Me.btnAccountControls.Text = "Account Controls"
        Me.btnAccountControls.UseVisualStyleBackColor = True
        '
        'btnAdministratorTools
        '
        Me.btnAdministratorTools.Enabled = False
        Me.btnAdministratorTools.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAdministratorTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdministratorTools.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAdministratorTools.Location = New System.Drawing.Point(2, 294)
        Me.btnAdministratorTools.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdministratorTools.Name = "btnAdministratorTools"
        Me.btnAdministratorTools.Size = New System.Drawing.Size(150, 47)
        Me.btnAdministratorTools.TabIndex = 11
        Me.btnAdministratorTools.Text = "Administrative Tools"
        Me.btnAdministratorTools.UseVisualStyleBackColor = True
        '
        'btnViewLevelSystemInformation
        '
        Me.btnViewLevelSystemInformation.Enabled = False
        Me.btnViewLevelSystemInformation.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnViewLevelSystemInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewLevelSystemInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnViewLevelSystemInformation.Location = New System.Drawing.Point(163, 126)
        Me.btnViewLevelSystemInformation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnViewLevelSystemInformation.Name = "btnViewLevelSystemInformation"
        Me.btnViewLevelSystemInformation.Size = New System.Drawing.Size(212, 27)
        Me.btnViewLevelSystemInformation.TabIndex = 10
        Me.btnViewLevelSystemInformation.Text = "Level System Information"
        Me.btnViewLevelSystemInformation.UseVisualStyleBackColor = True
        '
        'btnAccessShop
        '
        Me.btnAccessShop.Enabled = False
        Me.btnAccessShop.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAccessShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccessShop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAccessShop.Location = New System.Drawing.Point(419, 126)
        Me.btnAccessShop.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAccessShop.Name = "btnAccessShop"
        Me.btnAccessShop.Size = New System.Drawing.Size(80, 27)
        Me.btnAccessShop.TabIndex = 9
        Me.btnAccessShop.Text = "Go to Shop"
        Me.btnAccessShop.UseVisualStyleBackColor = True
        '
        'lblUserRankNumber
        '
        Me.lblUserRankNumber.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserRankNumber.ForeColor = System.Drawing.Color.White
        Me.lblUserRankNumber.Location = New System.Drawing.Point(230, 84)
        Me.lblUserRankNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserRankNumber.Name = "lblUserRankNumber"
        Me.lblUserRankNumber.Size = New System.Drawing.Size(68, 39)
        Me.lblUserRankNumber.TabIndex = 8
        Me.lblUserRankNumber.Text = "00"
        Me.lblUserRankNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUserRankText
        '
        Me.lblUserRankText.AutoSize = True
        Me.lblUserRankText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUserRankText.Location = New System.Drawing.Point(248, 71)
        Me.lblUserRankText.Margin = New System.Windows.Forms.Padding(2, 15, 2, 0)
        Me.lblUserRankText.Name = "lblUserRankText"
        Me.lblUserRankText.Size = New System.Drawing.Size(28, 14)
        Me.lblUserRankText.TabIndex = 7
        Me.lblUserRankText.Text = "Rank"
        '
        'lblAmuseLevelNumber
        '
        Me.lblAmuseLevelNumber.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmuseLevelNumber.ForeColor = System.Drawing.Color.White
        Me.lblAmuseLevelNumber.Location = New System.Drawing.Point(160, 84)
        Me.lblAmuseLevelNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAmuseLevelNumber.Name = "lblAmuseLevelNumber"
        Me.lblAmuseLevelNumber.Size = New System.Drawing.Size(68, 39)
        Me.lblAmuseLevelNumber.TabIndex = 6
        Me.lblAmuseLevelNumber.Text = "00"
        Me.lblAmuseLevelNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUserLevelText
        '
        Me.lblUserLevelText.AutoSize = True
        Me.lblUserLevelText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUserLevelText.Location = New System.Drawing.Point(160, 71)
        Me.lblUserLevelText.Margin = New System.Windows.Forms.Padding(2, 15, 10, 0)
        Me.lblUserLevelText.Name = "lblUserLevelText"
        Me.lblUserLevelText.Size = New System.Drawing.Size(62, 14)
        Me.lblUserLevelText.TabIndex = 5
        Me.lblUserLevelText.Text = "Amuse Level"
        '
        'picUserImage
        '
        Me.picUserImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picUserImage.Image = CType(resources.GetObject("picUserImage.Image"), System.Drawing.Image)
        Me.picUserImage.Location = New System.Drawing.Point(2, 3)
        Me.picUserImage.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picUserImage.Name = "picUserImage"
        Me.picUserImage.Size = New System.Drawing.Size(150, 150)
        Me.picUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUserImage.TabIndex = 1
        Me.picUserImage.TabStop = False
        '
        'Overview
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btnAccountLogout
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.panelOverview)
        Me.Controls.Add(Me.pnlCustomControlBox)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Swis721 Cn BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Overview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Overview"
        Me.pnlCustomControlBox.ResumeLayout(False)
        Me.pnlCustomControlBox.PerformLayout()
        Me.panelOverview.ResumeLayout(False)
        Me.panelOverview.PerformLayout()
        Me.panelGameSelector.ResumeLayout(False)
        CType(Me.picGameImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlCustomControlBox As System.Windows.Forms.Panel
    Friend WithEvents btnAccountLogout As System.Windows.Forms.Button
    Friend WithEvents lblControlBoxFormName As System.Windows.Forms.Label
    Friend WithEvents picUserImage As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lineFormSplitter As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblUserNameText As System.Windows.Forms.Label
    Friend WithEvents lblUserTypeText As System.Windows.Forms.Label
    Friend WithEvents panelOverview As System.Windows.Forms.Panel
    Friend WithEvents lblAmuseLevelNumber As System.Windows.Forms.Label
    Friend WithEvents lblUserLevelText As System.Windows.Forms.Label
    Friend WithEvents lblUserRankNumber As System.Windows.Forms.Label
    Friend WithEvents lblUserRankText As System.Windows.Forms.Label
    Friend WithEvents lblShopPoints As System.Windows.Forms.Label
    Friend WithEvents lblShopPointsNumber As System.Windows.Forms.Label
    Friend WithEvents lblAmuseEXP As System.Windows.Forms.Label
    Friend WithEvents lblAmuseEXPNumber As System.Windows.Forms.Label
    Friend WithEvents btnAccountControls As System.Windows.Forms.Button
    Friend WithEvents btnAdministratorTools As System.Windows.Forms.Button
    Friend WithEvents btnViewLevelSystemInformation As System.Windows.Forms.Button
    Friend WithEvents btnAccessShop As System.Windows.Forms.Button
    Friend WithEvents lblAchievementsText As System.Windows.Forms.Label
    Friend WithEvents panelGameSelector As System.Windows.Forms.Panel
    Friend WithEvents btnBlackSquareSelect As System.Windows.Forms.Button
    Friend WithEvents btnAboutAmuse As System.Windows.Forms.Button
    Friend WithEvents btnGuideToAmuse As System.Windows.Forms.Button
    Friend WithEvents lblNoticeText As System.Windows.Forms.Label
    Friend WithEvents cbxThemeSelector As System.Windows.Forms.ComboBox
    Friend WithEvents lblThemeSelector As System.Windows.Forms.Label
    Friend WithEvents btnLaunchApplication As System.Windows.Forms.Button
    Friend WithEvents lblGameDescription As System.Windows.Forms.Label
    Friend WithEvents lblGameTitle As System.Windows.Forms.Label
    Friend WithEvents picGameImage As System.Windows.Forms.PictureBox
End Class
