﻿Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ark Notes v" + My.Settings.VersionNum
        lblVersion.Text = My.Settings.VersionNum
        If My.Settings.firstsetup Then
            My.Settings.NotesDBConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ArkNotes\NotesDB.accdb" & "; Persist Security Info=False;"
            My.Settings.firstsetup = False
        End If
    End Sub

End Class