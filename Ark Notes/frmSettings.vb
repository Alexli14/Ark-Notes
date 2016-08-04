Imports System.IO
Public Class frmSettings
    Dim notesdb
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxDatabase.Text = My.Settings.NotesDBConnectionString
        tbxMap.Text = My.Settings.MapImageLocation
        If My.Settings.DBType = "OLEDB" Then
            notesdb = New accessDBlink
            rbOLEDB.Checked = True
        ElseIf My.Settings.DBType = "ODBC" Then
            notesdb = New mysqlDBlink
            rbODBC.Checked = True
        End If
        Call loadSpecies()
    End Sub

    ''' <summary>
    ''' Loads and refreshes list of spices
    ''' </summary>
    Private Sub loadSpecies()
        lbxSpecies.Items.Clear()
        notesdb.connectionString = My.Settings.NotesDBConnectionString
        notesdb.SQL = "SELECT * from Species"
        For i As Integer = 0 To notesdb.ds.Tables(0).Rows.Count - 1
            lbxSpecies.Items.Add(notesdb.ds.Tables(0).Rows(i).Item("species"))
        Next
    End Sub

    ''' <summary>
    ''' Saves changes to database connection  string
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If rbODBC.Checked Then
                Dim testdb As New mysqlDBlink
                testdb.connectionString = tbxDatabase.Text
                testdb.conn.Open()
                My.Settings.DBType = "ODBC"
                My.Settings.NotesDBConnectionString = tbxDatabase.Text
            ElseIf rbOLEDB.Checked Then
                Dim testdb As New accessDBlink
                testdb.connectionString = tbxDatabase.Text
                testdb.conn.Open()
                My.Settings.DBType = "OLEDB"
                My.Settings.NotesDBConnectionString = tbxDatabase.Text
            End If
            MessageBox.Show("Database connection saved.")
        Catch ex As Exception
            MessageBox.Show("Error Connecting To Database: Reverting to Default Connection String. \n" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxDatabase.Text = My.Settings.NotesDBConnectionString
        End Try
        '' If File.Exists(tbxMap.Text) Then
        My.Settings.MapImageLocation = tbxMap.Text
            tbxMap.Text = My.Settings.MapImageLocation
            MessageBox.Show("Image file selection saved.")
        '  Else
        ' MessageBox.Show("Error reading map file: reverting to previous file")
        ' tbxMap.Text = My.Settings.MapImageLocation
        'End If
    End Sub

    ''' <summary>
    ''' exits the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' restores Database connection string to default when clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        tbxDatabase.Text = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ArkNotes\NotesDB.accdb" & "; Persist Security Info=False;"
        My.Settings.NotesDBConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ArkNotes\NotesDB.accdb" & "; Persist Security Info=False;"
        My.Settings.DBType = "OLEDB"
        rbOLEDB.Checked = True
        My.Settings.MapImageLocation = "https://hydra-media.cursecdn.com/ark.gamepedia.com/e/eb/MAP_BC.png"
        tbxMap.Text = My.Settings.MapImageLocation
    End Sub
    ''' <summary>
    ''' fills in tbxSpecies based on selected item in the list box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lbxSpecies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxSpecies.SelectedIndexChanged
        tbxSpecies.Text = lbxSpecies.SelectedItem
    End Sub

    ''' <summary>
    ''' Adds new species from text box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        notesdb.connectionString = My.Settings.NotesDBConnectionString
        notesdb.SQL = "Select * from Species;"
        Dim dsnewrow As DataRow
        dsnewrow = notesdb.ds.Tables(0).NewRow
        dsnewrow.Item("species") = tbxSpecies.Text
        notesdb.ds.Tables(0).Rows.Add(dsnewrow)
        notesdb.da.Update(notesdb.ds)

        loadSpecies()
    End Sub

    ''' <summary>
    ''' removes the selected item from the list of species
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If MessageBox.Show("Are you sure you want to delete " & lbxSpecies.SelectedItem & "?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            'create class
            notesdb.connectionString = My.Settings.NotesDBConnectionString
            Dim strSQL As String
            strSQL = "SELECT * FROM Species WHERE species = '" & lbxSpecies.SelectedItem.ToString & "';"
            notesdb.SQL = strSQL
            notesdb.ds.Tables(0).Rows(0).Delete()
            notesdb.da.Update(notesdb.ds)
            'refresh screen
        End If
        loadSpecies()
    End Sub

    ''' <summary>
    ''' opens browser for map file when browse Button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnBrowseMap_Click(sender As Object, e As EventArgs) Handles btnBrowseMap.Click
        OpenFileDialog1.InitialDirectory = "c:\"
        OpenFileDialog1.Filter = "Image files (*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)|*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png|All files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If File.Exists(OpenFileDialog1.FileName) Then
                'Try
                'Catch Ex As Exception
                '    MessageBox.Show("Cannot read file. Original error: " & Ex.Message)
                'Finally
                '    ' Check this again, since we need to make sure we didn't throw an exception on open.
                'End Try
                tbxMap.Text = My.Settings.MapImageLocation
            Else
                MessageBox.Show("Error reading selected file: reverting to previous file")
            End If
        End If

    End Sub

    ''' <summary>
    ''' Initates database connection test based on radio buttons and textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnTestDB_Click(sender As Object, e As EventArgs) Handles btnTestDB.Click

        Try
            If rbODBC.Checked Then
                Dim testdb As New mysqlDBlink
                testdb.connectionString = tbxDatabase.Text
                testdb.conn.Open()
                MessageBox.Show("Connection Seceded")

            ElseIf rbOLEDB.Checked Then
                Dim testdb As New accessDBlink
                testdb.connectionString = tbxDatabase.Text
                testdb.conn.Open()
                MessageBox.Show("Connection Seceded")

            End If
        Catch ex As Exception
            MessageBox.Show("Error Connecting To Database: Reverting to Default Connection String." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxDatabase.Text = My.Settings.NotesDBConnectionString
            If My.Settings.DBType = "OLEDB" Then
                rbOLEDB.Checked = True
            ElseIf My.Settings.DBType = "ODBC" Then
                rbODBC.Checked = True
            End If

        End Try
    End Sub

    Private Sub tbxDatabase_GotFocus(sender As Object, e As EventArgs) Handles tbxDatabase.GotFocus, tbxDatabase.DoubleClick
        tbxDatabase.SelectAll()
    End Sub



    '''' <summary>
    '''' checks to see if selected file exists
    '''' </summary>
    '''' <param name="FileName"></param>
    '''' <returns></returns>
    'Private Function chkFile(ByVal FileName As String)


    'End Function
End Class