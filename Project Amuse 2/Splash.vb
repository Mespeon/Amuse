Public NotInheritable Class Splash

    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        'Application Name
        If My.Application.Info.Title <> "" Then
            ApplicationName.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            'ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Version Information
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright Information
        Copyright.Text = My.Application.Info.Copyright
    End Sub

End Class
