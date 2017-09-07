<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.picRegisterImage = New System.Windows.Forms.PictureBox()
        Me.lblRegisterText = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxSecretQuestion = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSecretAnswerField = New System.Windows.Forms.TextBox()
        Me.txtFirstNameField = New System.Windows.Forms.TextBox()
        Me.txtLastNameField = New System.Windows.Forms.TextBox()
        Me.txtUsernameField = New System.Windows.Forms.TextBox()
        Me.txtEmailField = New System.Windows.Forms.TextBox()
        Me.txtConfirmEmailField = New System.Windows.Forms.TextBox()
        Me.AmuseDataSet1 = New Project_Amuse_2.AmuseDataSet()
        CType(Me.picRegisterImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmuseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picRegisterImage
        '
        Me.picRegisterImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.picRegisterImage.Image = CType(resources.GetObject("picRegisterImage.Image"), System.Drawing.Image)
        Me.picRegisterImage.Location = New System.Drawing.Point(0, 0)
        Me.picRegisterImage.Margin = New System.Windows.Forms.Padding(1, 1, 1, 0)
        Me.picRegisterImage.Name = "picRegisterImage"
        Me.picRegisterImage.Size = New System.Drawing.Size(338, 186)
        Me.picRegisterImage.TabIndex = 0
        Me.picRegisterImage.TabStop = False
        '
        'lblRegisterText
        '
        Me.lblRegisterText.Font = New System.Drawing.Font("Swis721 Cn BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterText.ForeColor = System.Drawing.Color.White
        Me.lblRegisterText.Location = New System.Drawing.Point(4, 191)
        Me.lblRegisterText.Margin = New System.Windows.Forms.Padding(1)
        Me.lblRegisterText.Name = "lblRegisterText"
        Me.lblRegisterText.Size = New System.Drawing.Size(331, 30)
        Me.lblRegisterText.TabIndex = 1
        Me.lblRegisterText.Text = "Project Amuse : Registration"
        Me.lblRegisterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubmit
        '
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Swis721 Cn BT", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Silver
        Me.btnSubmit.Location = New System.Drawing.Point(92, 522)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(1, 20, 1, 1)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(74, 23)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Swis721 Cn BT", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Silver
        Me.btnCancel.Location = New System.Drawing.Point(173, 522)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(1, 20, 1, 1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(74, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 234)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 266)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 298)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 332)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 364)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 14)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Confirm Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 398)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 14)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Secret Question"
        '
        'cbxSecretQuestion
        '
        Me.cbxSecretQuestion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbxSecretQuestion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxSecretQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxSecretQuestion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSecretQuestion.FormattingEnabled = True
        Me.cbxSecretQuestion.Items.AddRange(New Object() {"What is the maiden name of your mother?", "Who is your first love or crush?", "What is the name of your favorite cartoon character?", "Is there such a thing as ""forever""?", "What is the limit of x as x approaches 0?"})
        Me.cbxSecretQuestion.Location = New System.Drawing.Point(54, 413)
        Me.cbxSecretQuestion.Margin = New System.Windows.Forms.Padding(3, 3, 1, 3)
        Me.cbxSecretQuestion.Name = "cbxSecretQuestion"
        Me.cbxSecretQuestion.Size = New System.Drawing.Size(233, 21)
        Me.cbxSecretQuestion.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 456)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 14)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Answer"
        '
        'txtSecretAnswerField
        '
        Me.txtSecretAnswerField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSecretAnswerField.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecretAnswerField.Location = New System.Drawing.Point(54, 471)
        Me.txtSecretAnswerField.Name = "txtSecretAnswerField"
        Me.txtSecretAnswerField.Size = New System.Drawing.Size(233, 22)
        Me.txtSecretAnswerField.TabIndex = 9
        '
        'txtFirstNameField
        '
        Me.txtFirstNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstNameField.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstNameField.Location = New System.Drawing.Point(144, 231)
        Me.txtFirstNameField.Name = "txtFirstNameField"
        Me.txtFirstNameField.Size = New System.Drawing.Size(143, 22)
        Me.txtFirstNameField.TabIndex = 1
        '
        'txtLastNameField
        '
        Me.txtLastNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastNameField.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastNameField.Location = New System.Drawing.Point(144, 263)
        Me.txtLastNameField.Name = "txtLastNameField"
        Me.txtLastNameField.Size = New System.Drawing.Size(143, 22)
        Me.txtLastNameField.TabIndex = 2
        '
        'txtUsernameField
        '
        Me.txtUsernameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsernameField.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameField.Location = New System.Drawing.Point(144, 295)
        Me.txtUsernameField.Name = "txtUsernameField"
        Me.txtUsernameField.Size = New System.Drawing.Size(143, 22)
        Me.txtUsernameField.TabIndex = 3
        '
        'txtEmailField
        '
        Me.txtEmailField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailField.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailField.Location = New System.Drawing.Point(144, 329)
        Me.txtEmailField.Name = "txtEmailField"
        Me.txtEmailField.Size = New System.Drawing.Size(143, 22)
        Me.txtEmailField.TabIndex = 6
        '
        'txtConfirmEmailField
        '
        Me.txtConfirmEmailField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmEmailField.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmEmailField.Location = New System.Drawing.Point(144, 361)
        Me.txtConfirmEmailField.Name = "txtConfirmEmailField"
        Me.txtConfirmEmailField.Size = New System.Drawing.Size(143, 22)
        Me.txtConfirmEmailField.TabIndex = 7
        '
        'AmuseDataSet1
        '
        Me.AmuseDataSet1.DataSetName = "AmuseDataSet"
        Me.AmuseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Register
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(338, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtConfirmEmailField)
        Me.Controls.Add(Me.txtEmailField)
        Me.Controls.Add(Me.txtUsernameField)
        Me.Controls.Add(Me.txtLastNameField)
        Me.Controls.Add(Me.txtFirstNameField)
        Me.Controls.Add(Me.txtSecretAnswerField)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbxSecretQuestion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblRegisterText)
        Me.Controls.Add(Me.picRegisterImage)
        Me.Font = New System.Drawing.Font("Swis721 Cn BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.picRegisterImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmuseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picRegisterImage As System.Windows.Forms.PictureBox
    Friend WithEvents lblRegisterText As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxSecretQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSecretAnswerField As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstNameField As System.Windows.Forms.TextBox
    Friend WithEvents txtLastNameField As System.Windows.Forms.TextBox
    Friend WithEvents txtUsernameField As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailField As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmEmailField As System.Windows.Forms.TextBox
    Friend WithEvents AmuseDataSet1 As Project_Amuse_2.AmuseDataSet
End Class
