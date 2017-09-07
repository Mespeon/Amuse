<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Passgen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Passgen))
        Me.picRegisterImage = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.lblNotice = New System.Windows.Forms.Label()
        Me.txtPasswordField = New System.Windows.Forms.TextBox()
        Me.txtConfirmPasswordField = New System.Windows.Forms.TextBox()
        CType(Me.picRegisterImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picRegisterImage
        '
        Me.picRegisterImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.picRegisterImage.Image = CType(resources.GetObject("picRegisterImage.Image"), System.Drawing.Image)
        Me.picRegisterImage.Location = New System.Drawing.Point(0, 0)
        Me.picRegisterImage.Margin = New System.Windows.Forms.Padding(1, 1, 1, 0)
        Me.picRegisterImage.Name = "picRegisterImage"
        Me.picRegisterImage.Size = New System.Drawing.Size(284, 186)
        Me.picRegisterImage.TabIndex = 1
        Me.picRegisterImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 Cn BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 196)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Generate Password"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(67, 278)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(3, 25, 3, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(49, 14)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(30, 317)
        Me.lblConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 25, 3, 0)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(86, 14)
        Me.lblConfirmPassword.TabIndex = 4
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'btnExecute
        '
        Me.btnExecute.FlatAppearance.BorderSize = 0
        Me.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExecute.Location = New System.Drawing.Point(70, 358)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(138, 30)
        Me.btnExecute.TabIndex = 2
        Me.btnExecute.Text = "Submit"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'lblNotice
        '
        Me.lblNotice.Location = New System.Drawing.Point(12, 221)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(260, 41)
        Me.lblNotice.TabIndex = 6
        Me.lblNotice.Text = "You are now just a single step away from Project Amuse 2! Please type your desire" & _
    "d password in the fields below."
        '
        'txtPasswordField
        '
        Me.txtPasswordField.Location = New System.Drawing.Point(122, 275)
        Me.txtPasswordField.Name = "txtPasswordField"
        Me.txtPasswordField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPasswordField.Size = New System.Drawing.Size(132, 21)
        Me.txtPasswordField.TabIndex = 0
        '
        'txtConfirmPasswordField
        '
        Me.txtConfirmPasswordField.Location = New System.Drawing.Point(122, 314)
        Me.txtConfirmPasswordField.Name = "txtConfirmPasswordField"
        Me.txtConfirmPasswordField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirmPasswordField.Size = New System.Drawing.Size(132, 21)
        Me.txtConfirmPasswordField.TabIndex = 1
        '
        'Passgen
        '
        Me.AcceptButton = Me.btnExecute
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 400)
        Me.Controls.Add(Me.txtConfirmPasswordField)
        Me.Controls.Add(Me.txtPasswordField)
        Me.Controls.Add(Me.lblNotice)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picRegisterImage)
        Me.Font = New System.Drawing.Font("Swis721 Cn BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Passgen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Passgen"
        CType(Me.picRegisterImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picRegisterImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents lblNotice As System.Windows.Forms.Label
    Friend WithEvents txtPasswordField As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPasswordField As System.Windows.Forms.TextBox
End Class
