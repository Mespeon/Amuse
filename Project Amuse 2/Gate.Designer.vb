<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gate))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.picLoginImage = New System.Windows.Forms.PictureBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblUsernameText = New System.Windows.Forms.Label()
        Me.lblPasswordText = New System.Windows.Forms.Label()
        Me.txtUsernameField = New System.Windows.Forms.TextBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AmuseDataSet = New Project_Amuse_2.AmuseDataSet()
        Me.txtPasswordField = New System.Windows.Forms.TextBox()
        Me.UsersTableAdapter = New Project_Amuse_2.AmuseDataSetTableAdapters.amusersTableAdapter()
        Me.TableAdapterManager = New Project_Amuse_2.AmuseDataSetTableAdapters.TableAdapterManager()
        Me.lblLoginBanner = New System.Windows.Forms.Label()
        CType(Me.picLoginImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmuseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.Silver
        Me.btnLogin.Location = New System.Drawing.Point(190, 372)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(71, 48)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.TabStop = False
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'picLoginImage
        '
        Me.picLoginImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.picLoginImage.Image = CType(resources.GetObject("picLoginImage.Image"), System.Drawing.Image)
        Me.picLoginImage.Location = New System.Drawing.Point(0, 0)
        Me.picLoginImage.Margin = New System.Windows.Forms.Padding(1, 1, 1, 10)
        Me.picLoginImage.Name = "picLoginImage"
        Me.picLoginImage.Size = New System.Drawing.Size(344, 320)
        Me.picLoginImage.TabIndex = 2
        Me.picLoginImage.TabStop = False
        '
        'btnRegister
        '
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.ForeColor = System.Drawing.Color.Silver
        Me.btnRegister.Location = New System.Drawing.Point(263, 372)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(71, 48)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.TabStop = False
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(0, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(1, 1)
        Me.btnClose.TabIndex = 4
        Me.btnClose.TabStop = False
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblUsernameText
        '
        Me.lblUsernameText.AutoSize = True
        Me.lblUsernameText.ForeColor = System.Drawing.Color.Silver
        Me.lblUsernameText.Location = New System.Drawing.Point(8, 374)
        Me.lblUsernameText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsernameText.Name = "lblUsernameText"
        Me.lblUsernameText.Size = New System.Drawing.Size(51, 14)
        Me.lblUsernameText.TabIndex = 5
        Me.lblUsernameText.Text = "Username"
        '
        'lblPasswordText
        '
        Me.lblPasswordText.AutoSize = True
        Me.lblPasswordText.ForeColor = System.Drawing.Color.Silver
        Me.lblPasswordText.Location = New System.Drawing.Point(8, 403)
        Me.lblPasswordText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPasswordText.Name = "lblPasswordText"
        Me.lblPasswordText.Size = New System.Drawing.Size(49, 14)
        Me.lblPasswordText.TabIndex = 6
        Me.lblPasswordText.Text = "Password"
        '
        'txtUsernameField
        '
        Me.txtUsernameField.BackColor = System.Drawing.Color.White
        Me.txtUsernameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsernameField.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Username", True))
        Me.txtUsernameField.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameField.ForeColor = System.Drawing.Color.Black
        Me.txtUsernameField.Location = New System.Drawing.Point(58, 372)
        Me.txtUsernameField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtUsernameField.Name = "txtUsernameField"
        Me.txtUsernameField.Size = New System.Drawing.Size(125, 19)
        Me.txtUsernameField.TabIndex = 7
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "amusers"
        Me.UsersBindingSource.DataSource = Me.AmuseDataSet
        '
        'AmuseDataSet
        '
        Me.AmuseDataSet.DataSetName = "AmuseDataSet"
        Me.AmuseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPasswordField
        '
        Me.txtPasswordField.BackColor = System.Drawing.Color.White
        Me.txtPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordField.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordField.ForeColor = System.Drawing.Color.Black
        Me.txtPasswordField.Location = New System.Drawing.Point(58, 401)
        Me.txtPasswordField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPasswordField.Name = "txtPasswordField"
        Me.txtPasswordField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPasswordField.Size = New System.Drawing.Size(125, 19)
        Me.txtPasswordField.TabIndex = 8
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.amusersTableAdapter = Me.UsersTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.questionnaireTableAdapter = Nothing
        Me.TableAdapterManager.tblContactsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project_Amuse_2.AmuseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblLoginBanner
        '
        Me.lblLoginBanner.Font = New System.Drawing.Font("Swis721 Cn BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginBanner.ForeColor = System.Drawing.Color.White
        Me.lblLoginBanner.Location = New System.Drawing.Point(12, 330)
        Me.lblLoginBanner.Name = "lblLoginBanner"
        Me.lblLoginBanner.Size = New System.Drawing.Size(322, 30)
        Me.lblLoginBanner.TabIndex = 9
        Me.lblLoginBanner.Text = "Project Amuse : Log In"
        Me.lblLoginBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Gate
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(344, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLoginBanner)
        Me.Controls.Add(Me.txtPasswordField)
        Me.Controls.Add(Me.txtUsernameField)
        Me.Controls.Add(Me.lblPasswordText)
        Me.Controls.Add(Me.lblUsernameText)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.picLoginImage)
        Me.Controls.Add(Me.btnLogin)
        Me.Font = New System.Drawing.Font("Swis721 Cn BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Gate"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.picLoginImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmuseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents picLoginImage As System.Windows.Forms.PictureBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblUsernameText As System.Windows.Forms.Label
    Friend WithEvents lblPasswordText As System.Windows.Forms.Label
    Friend WithEvents txtUsernameField As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswordField As System.Windows.Forms.TextBox
    Friend WithEvents AmuseDataSet As Project_Amuse_2.AmuseDataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As Project_Amuse_2.AmuseDataSetTableAdapters.amusersTableAdapter
    Friend WithEvents TableAdapterManager As Project_Amuse_2.AmuseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblLoginBanner As System.Windows.Forms.Label

End Class
