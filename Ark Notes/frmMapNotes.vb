Public Class frmMapNotes
    Dim WithEvents pbxPinX As PictureBox
    Dim notesdb

    ''' <summary>
    ''' runs loadNotes on form load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMapNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.DBType = "OLEDB" Then
            notesdb = New accessDBlink
        ElseIf My.Settings.DBType = "ODBC" Then
            notesdb = New mysqlDBlink
        End If
        notesdb.connectionString = My.Settings.NotesDBConnectionString
        pbxMap.ImageLocation = My.Settings.MapImageLocation
        loadNotes()
    End Sub

    ''' <summary>
    ''' Loads/refreshes notes list in dgvNotes
    ''' </summary>
    Sub loadNotes()
        Dim MinMapX, MinMapY, MaxMapX, MaxMapY As Double
        Dim scalerValX, scalerValY As Single
        Dim pinOffsetX As Integer = -11
        Dim pinOffsetY As Integer = -30
        'MinMapX = pbxMap.Location.X
        'MinMapY = pbxMap.Location.Y 
        'MaxMapX = pbxMap.Location.X + pbxMap.Width
        'MaxMapY = pbxMap.Location.Y + pbxMap.Height
        MinMapX = 20 / 1434 * pbxMap.Width
        MinMapY = 40 / 1434 * pbxMap.Width
        MaxMapX = pbxMap.Width
        MaxMapY = pbxMap.Height
        scalerValX = (MaxMapX - MinMapX) / 100
        scalerValY = (MaxMapY - MinMapY) / 100
        pbxMap.Controls.Clear()
        pbxMap.Refresh()
        dgvNotes.Rows.Clear()
        notesdb.SQL = "SELECT * from mapNotes"
        For i As Integer = 0 To notesdb.ds.Tables(0).Rows.Count - 1
            dgvNotes.Rows.Add()
            With dgvNotes.Rows(i)
                .Cells(0).Value = notesdb.ds.Tables(0).Rows(i).Item("ID")
                .Cells(1).Value = notesdb.ds.Tables(0).Rows(i).Item("noteName")
                .Cells(2).Value = notesdb.ds.Tables(0).Rows(i).Item("Xcoord")
                .Cells(3).Value = notesdb.ds.Tables(0).Rows(i).Item("Ycoord")
                .Cells(4).Value = notesdb.ds.Tables(0).Rows(i).Item("noteText")
            End With
            pbxPinX = New PictureBox
            pbxPinX.SizeMode = PictureBoxSizeMode.Zoom
            pbxPinX.Image = My.Resources.Map_pin_icon_svg
            pbxPinX.Width = 22
            pbxPinX.Height = 30
            pbxPinX.Location = New Point((scalerValX * notesdb.ds.Tables(0).Rows(i).Item("Xcoord")) + pinOffsetX + MinMapX, (scalerValY * notesdb.ds.Tables(0).Rows(i).Item("Ycoord")) + pinOffsetY + MinMapY)
            pbxPinX.BackColor = Color.Transparent
            pbxPinX.Name = "pbxPin" + notesdb.ds.Tables(0).Rows(i).Item("ID").ToString
            pbxMap.Controls.Add(pbxPinX)
        Next

    End Sub

    ''' <summary>
    ''' opens frmAssets and closes current form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DinoTrackingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DinoTrackingToolStripMenuItem.Click
        Dim frm As New frmAssets
        frm.Show()
        Me.Close()
    End Sub
    ''' <summary>
    ''' Displays an about message window when the about menu item is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AboutArkNotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutArkNotesToolStripMenuItem.Click
        Dim frmInfo As Splash
        frmInfo.ShowDialog()
    End Sub
    ''' <summary>
    ''' load and display help when help menu button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        HelpProvider1.HelpNamespace = Application.StartupPath & "\help.chm"
        Help.ShowHelp(Me, HelpProvider1.HelpNamespace)
    End Sub

    ''' <summary>
    ''' launches settings form when settings menu bar item is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSettings_Click(sender As Object, e As EventArgs) Handles mnuSettings.Click
        Dim frm As New frmSettings
        frm.ShowDialog()
        If My.Settings.DBType = "OLEDB" Then
            notesdb = New accessDBlink
        ElseIf My.Settings.DBType = "ODBC" Then
            notesdb = New mysqlDBlink
        End If
        notesdb.connectionString = My.Settings.NotesDBConnectionString
        Call loadNotes()
        pbxMap.ImageLocation = My.Settings.MapImageLocation
    End Sub

    ''' <summary>
    ''' Updates notes group box with selected note content
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvNotes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvNotes.SelectionChanged
        Dim i As Integer = dgvNotes.CurrentRow().Index()
        With dgvNotes.Rows(i)
            tbxTitle.Text = .Cells(1).Value
            nudX.Value = .Cells(2).Value
            nudY.Value = .Cells(3).Value
            rtbxNoteText.Text = .Cells(4).Value
        End With
    End Sub

    ''' <summary>
    ''' Removes the selected recod from the database and refreshes the dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'get current row number (index)
        Dim r As Integer = dgvNotes.CurrentRow.Index
        'get value of cell for selected row
        Dim ID As String = dgvNotes.Rows(r).Cells(0).Value
        'verify intent
        If MessageBox.Show("Are you sure you want to delete " & dgvNotes.Rows(r).Cells(1).Value & "?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            'create class
            notesdb.SQL = "SELECT * From mapNotes WHERE ID = " & ID & ";"
            notesdb.ds.Tables(0).Rows(0).Delete()
            notesdb.da.Update(notesdb.ds)
        End If
        loadNotes()

    End Sub

    ''' <summary>
    ''' toggles the data entry section of the form on/off and disables dgv controls and buttons
    ''' </summary>
    ''' <param name="Enableitems">if true enables the Data entry section of the form and disables add/remove/edit buttons</param>
    Private Sub EnableGroup(ByVal Enableitems As Boolean)
        gbxNotes.Enabled = Enableitems
        dgvNotes.Enabled = Not Enableitems
        btnAdd.Enabled = Not Enableitems
        btnRemove.Enabled = Not Enableitems
        btnEdit.Enabled = Not Enableitems
        If Enableitems Then
            tbxTitle.Focus()
        Else
            tbxTitle.Text = ""
            nudX.Value = 0
            nudY.Value = 0
            rtbxNoteText.Text = ""
            gbxNotes.Tag = 0
            dgvNotes.Enabled = False
        End If
    End Sub
    ''' <summary>
    ''' sets up the data entry controls in gbxNotes to recive new information and sets gbxNotes.tag to 0 representing a new record also calls EnableGroup(True)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call EnableGroup(True)
        tbxTitle.Text = ""
        nudX.Value = 0
        nudY.Value = 0
        rtbxNoteText.Text = ""
        gbxNotes.Tag = 0

    End Sub

    ''' <summary>
    ''' Loads the selected record into the data entry controls in gbxNotes and calls Enable Group
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'get current row number (index)
        Dim r As Integer = dgvNotes.CurrentRow.Index
        Call EnableGroup(True)
        'get value of cell for selected row
        Dim ID As String = dgvNotes.Rows(r).Cells(0).Value
        gbxNotes.Tag = ID
        With dgvNotes.Rows(r)
            tbxTitle.Text = .Cells(1).Value
            nudX.Value = .Cells(2).Value
            nudY.Value = .Cells(3).Value
            rtbxNoteText.Text = .Cells(4).Value
        End With
    End Sub

    ''' <summary>
    ''' when clicked saves the changes made during an edit procedure or saves the new record created from the add process
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If gbxNotes.Tag = 0 Then
            'new record 
            notesdb.SQL = "SELECT * From mapNotes WHERE ID = 0;"
            Dim dsnewrow As DataRow
            dsnewrow = notesdb.ds.Tables(0).NewRow
            With dsnewrow
                .Item("noteName") = tbxTitle.Text
                .Item("Xcoord") = nudX.Value
                .Item("Ycoord") = nudY.Value
                .Item("noteText") = rtbxNoteText.Text
            End With
            notesdb.ds.Tables(0).Rows.Add(dsnewrow)
            notesdb.da.Update(notesdb.ds)
        Else
            notesdb.SQL = "SELECT * From mapNotes WHERE ID = " & gbxNotes.Tag & ";"
            With notesdb.ds.Tables(0).Rows(0)
                .Item("noteName") = tbxTitle.Text
                .Item("Xcoord") = nudX.Value
                .Item("Ycoord") = nudY.Value
                .Item("noteText") = rtbxNoteText.Text
            End With
            notesdb.da.Update(notesdb.ds)
        End If
        Call EnableGroup(False)
        Call loadNotes()
    End Sub
    ''' <summary>
    ''' cancels the add or edit process and resets the controls in gbxNotes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call EnableGroup(False)
        Call loadNotes()
        tbxTitle.Text = ""
        nudX.Value = 0
        nudY.Value = 0
        rtbxNoteText.Text = ""
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call loadNotes()
    End Sub
End Class