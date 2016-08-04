Imports System.IO
Imports System.Environment
Public Class frmMain

    ''' <summary>
    ''' Set database connection string on first startup and set My.Settings.firstsetup = False
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.firstsetup Then
            My.Settings.NotesDBConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ArkNotes\NotesDB.accdb" & "; Persist Security Info=False;"
            My.Settings.firstsetup = False
        End If
    End Sub

    ''' <summary>
    ''' launches an instance of frmAssets when clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDino_Click(sender As Object, e As EventArgs) Handles btnDino.Click
        Dim frm As New frmAssets
        frm.Show()
    End Sub
    ''' <summary>
    ''' launches an instance of frmMapNotes when clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMapNotes_Click(sender As Object, e As EventArgs) Handles btnMapNotes.Click
        Dim frm As New frmMapNotes
        frm.Show()
    End Sub
End Class
