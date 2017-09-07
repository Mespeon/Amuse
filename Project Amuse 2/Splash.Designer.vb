<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.SplashImage = New System.Windows.Forms.PictureBox()
        Me.ApplicationInitials = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Splitter = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ApplicationName = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        CType(Me.SplashImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashImage
        '
        Me.SplashImage.Image = CType(resources.GetObject("SplashImage.Image"), System.Drawing.Image)
        Me.SplashImage.Location = New System.Drawing.Point(10, 10)
        Me.SplashImage.Margin = New System.Windows.Forms.Padding(1)
        Me.SplashImage.Name = "SplashImage"
        Me.SplashImage.Size = New System.Drawing.Size(378, 450)
        Me.SplashImage.TabIndex = 0
        Me.SplashImage.TabStop = False
        '
        'ApplicationInitials
        '
        Me.ApplicationInitials.Font = New System.Drawing.Font("Swis721 Cn BT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationInitials.ForeColor = System.Drawing.Color.Silver
        Me.ApplicationInitials.Location = New System.Drawing.Point(7, 462)
        Me.ApplicationInitials.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.ApplicationInitials.Name = "ApplicationInitials"
        Me.ApplicationInitials.Size = New System.Drawing.Size(90, 76)
        Me.ApplicationInitials.TabIndex = 1
        Me.ApplicationInitials.Text = "PA"
        Me.ApplicationInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Splitter})
        Me.ShapeContainer1.Size = New System.Drawing.Size(398, 548)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'Splitter
        '
        Me.Splitter.BorderColor = System.Drawing.Color.White
        Me.Splitter.Enabled = False
        Me.Splitter.Name = "Splitter"
        Me.Splitter.X1 = 99
        Me.Splitter.X2 = 99
        Me.Splitter.Y1 = 470
        Me.Splitter.Y2 = 535
        '
        'ApplicationName
        '
        Me.ApplicationName.AutoSize = True
        Me.ApplicationName.Font = New System.Drawing.Font("Swis721 Cn BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationName.ForeColor = System.Drawing.Color.White
        Me.ApplicationName.Location = New System.Drawing.Point(100, 470)
        Me.ApplicationName.Name = "ApplicationName"
        Me.ApplicationName.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ApplicationName.Size = New System.Drawing.Size(166, 29)
        Me.ApplicationName.TabIndex = 3
        Me.ApplicationName.Text = "Project Amuse"
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Version.Location = New System.Drawing.Point(102, 499)
        Me.Version.Name = "Version"
        Me.Version.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Version.Size = New System.Drawing.Size(112, 14)
        Me.Version.TabIndex = 4
        Me.Version.Text = "Version {0}.{1,00}"
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Copyright.Location = New System.Drawing.Point(102, 522)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Copyright.Size = New System.Drawing.Size(63, 14)
        Me.Copyright.TabIndex = 5
        Me.Copyright.Text = "Copyright"
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(398, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.ApplicationName)
        Me.Controls.Add(Me.ApplicationInitials)
        Me.Controls.Add(Me.SplashImage)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Swis721 Cn BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.SplashImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplashImage As System.Windows.Forms.PictureBox
    Friend WithEvents ApplicationInitials As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Splitter As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ApplicationName As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label

End Class
