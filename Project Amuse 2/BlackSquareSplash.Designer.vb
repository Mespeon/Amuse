<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlackSquareSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlackSquareSplash))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGameStart = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblUserLevel = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.picMiniUserPhoto = New System.Windows.Forms.PictureBox()
        Me.picGameLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picMiniUserPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGameLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Swis721 Cn BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(548, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PROJECT AMUSE 1.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Swis721 Cn BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(532, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CODENAME: BLACK SQUARE"
        '
        'btnGameStart
        '
        Me.btnGameStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnGameStart.FlatAppearance.BorderSize = 0
        Me.btnGameStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGameStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnGameStart.Location = New System.Drawing.Point(448, 536)
        Me.btnGameStart.Name = "btnGameStart"
        Me.btnGameStart.Size = New System.Drawing.Size(298, 71)
        Me.btnGameStart.TabIndex = 3
        Me.btnGameStart.Text = "GAME START"
        Me.btnGameStart.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(69, 13)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(57, 14)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "USERNAME"
        '
        'lblUserLevel
        '
        Me.lblUserLevel.AutoSize = True
        Me.lblUserLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUserLevel.Location = New System.Drawing.Point(69, 27)
        Me.lblUserLevel.Name = "lblUserLevel"
        Me.lblUserLevel.Size = New System.Drawing.Size(24, 14)
        Me.lblUserLevel.TabIndex = 6
        Me.lblUserLevel.Text = "LV. "
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUserType.Location = New System.Drawing.Point(69, 49)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(53, 14)
        Me.lblUserType.TabIndex = 7
        Me.lblUserType.Text = "USERTYPE"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.Silver
        Me.btnClose.Location = New System.Drawing.Point(448, 637)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(298, 34)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "RETURN TO OVERVIEW"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'picMiniUserPhoto
        '
        Me.picMiniUserPhoto.Location = New System.Drawing.Point(13, 13)
        Me.picMiniUserPhoto.Name = "picMiniUserPhoto"
        Me.picMiniUserPhoto.Size = New System.Drawing.Size(50, 50)
        Me.picMiniUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMiniUserPhoto.TabIndex = 5
        Me.picMiniUserPhoto.TabStop = False
        '
        'picGameLogo
        '
        Me.picGameLogo.Image = Global.Project_Amuse_2.My.Resources.Resources.black_square_2_logo_trans
        Me.picGameLogo.Location = New System.Drawing.Point(481, 173)
        Me.picGameLogo.Name = "picGameLogo"
        Me.picGameLogo.Size = New System.Drawing.Size(232, 150)
        Me.picGameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGameLogo.TabIndex = 0
        Me.picGameLogo.TabStop = False
        '
        'BlackSquareSplash
        '
        Me.AcceptButton = Me.btnGameStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1194, 671)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.lblUserLevel)
        Me.Controls.Add(Me.picMiniUserPhoto)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnGameStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picGameLogo)
        Me.Font = New System.Drawing.Font("Swis721 Cn BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BlackSquareSplash"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Codename: Black Square - Project Amuse 2 v.1.0.0.4"
        Me.TopMost = True
        CType(Me.picMiniUserPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGameLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picGameLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGameStart As System.Windows.Forms.Button
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents picMiniUserPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblUserLevel As System.Windows.Forms.Label
    Friend WithEvents lblUserType As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
