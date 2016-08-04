Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ark Notes v" + My.Settings.VersionNum
        lblVersion.Text = My.Settings.VersionNum
    End Sub
End Class