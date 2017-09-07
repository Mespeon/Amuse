<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlackSquareSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlackSquareSettings))
        Me.btnGrandMasterMode = New System.Windows.Forms.Button()
        Me.btnRelaxedMode = New System.Windows.Forms.Button()
        Me.btnTimeAttackMode = New System.Windows.Forms.Button()
        Me.btnStandardMode = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGrandMasterMode
        '
        Me.btnGrandMasterMode.BackgroundImage = Global.Project_Amuse_2.My.Resources.Resources.gmc_mode_btn
        Me.btnGrandMasterMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrandMasterMode.FlatAppearance.BorderSize = 0
        Me.btnGrandMasterMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrandMasterMode.ForeColor = System.Drawing.Color.Silver
        Me.btnGrandMasterMode.Location = New System.Drawing.Point(17, 358)
        Me.btnGrandMasterMode.Name = "btnGrandMasterMode"
        Me.btnGrandMasterMode.Size = New System.Drawing.Size(460, 109)
        Me.btnGrandMasterMode.TabIndex = 4
        Me.btnGrandMasterMode.UseVisualStyleBackColor = True
        '
        'btnRelaxedMode
        '
        Me.btnRelaxedMode.BackgroundImage = Global.Project_Amuse_2.My.Resources.Resources.relaxed_mode_btn
        Me.btnRelaxedMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRelaxedMode.FlatAppearance.BorderSize = 0
        Me.btnRelaxedMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelaxedMode.ForeColor = System.Drawing.Color.Silver
        Me.btnRelaxedMode.Location = New System.Drawing.Point(17, 243)
        Me.btnRelaxedMode.Name = "btnRelaxedMode"
        Me.btnRelaxedMode.Size = New System.Drawing.Size(460, 109)
        Me.btnRelaxedMode.TabIndex = 3
        Me.btnRelaxedMode.UseVisualStyleBackColor = True
        '
        'btnTimeAttackMode
        '
        Me.btnTimeAttackMode.BackgroundImage = Global.Project_Amuse_2.My.Resources.Resources.time_attack_mode_btn1
        Me.btnTimeAttackMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimeAttackMode.FlatAppearance.BorderSize = 0
        Me.btnTimeAttackMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeAttackMode.ForeColor = System.Drawing.Color.Silver
        Me.btnTimeAttackMode.Location = New System.Drawing.Point(17, 128)
        Me.btnTimeAttackMode.Name = "btnTimeAttackMode"
        Me.btnTimeAttackMode.Size = New System.Drawing.Size(460, 109)
        Me.btnTimeAttackMode.TabIndex = 2
        Me.btnTimeAttackMode.UseVisualStyleBackColor = True
        '
        'btnStandardMode
        '
        Me.btnStandardMode.BackgroundImage = Global.Project_Amuse_2.My.Resources.Resources.standard_mode_btn
        Me.btnStandardMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStandardMode.FlatAppearance.BorderSize = 0
        Me.btnStandardMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStandardMode.ForeColor = System.Drawing.Color.Silver
        Me.btnStandardMode.Location = New System.Drawing.Point(17, 13)
        Me.btnStandardMode.Name = "btnStandardMode"
        Me.btnStandardMode.Size = New System.Drawing.Size(460, 109)
        Me.btnStandardMode.TabIndex = 1
        Me.btnStandardMode.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.Silver
        Me.btnClose.Location = New System.Drawing.Point(425, 476)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 35)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'BlackSquareSettings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(494, 511)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnGrandMasterMode)
        Me.Controls.Add(Me.btnRelaxedMode)
        Me.Controls.Add(Me.btnTimeAttackMode)
        Me.Controls.Add(Me.btnStandardMode)
        Me.Font = New System.Drawing.Font("Swis721 Cn BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BlackSquareSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Black Square 2.0 - Game Modes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStandardMode As System.Windows.Forms.Button
    Friend WithEvents btnTimeAttackMode As System.Windows.Forms.Button
    Friend WithEvents btnRelaxedMode As System.Windows.Forms.Button
    Friend WithEvents btnGrandMasterMode As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
