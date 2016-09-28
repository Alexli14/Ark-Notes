Public Class frmAssets
    Dim notesdb
    ''' <summary>
    ''' preforms form startup tasks including adding the values to combo boxes and loading data
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAssets_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.DBType = "OLEDB" Then
            notesdb = New accessDBlink
        ElseIf My.Settings.DBType = "ODBC" Then
            notesdb = New mysqlDBlink
        End If
        notesdb.connectionString = My.Settings.NotesDBConnectionString
        gbxFilter.Enabled = chbxFilter.Checked
        Call tableRefresh()

        'fill combo boxes
        cbxSpecies.Items.Add("") 'add blank choice   
        cbxSpeciesFilter.Items.Add("") 'add blank choice 
        Try
            notesdb.SQL = "SELECT * from Species"
            For i As Integer = 0 To notesdb.ds.Tables(0).Rows.Count - 1
                cbxSpecies.Items.Add(notesdb.ds.Tables(0).Rows(i).Item("species"))
                cbxSpeciesFilter.Items.Add(notesdb.ds.Tables(0).Rows(i).Item("species"))
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading species data:" & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK)
        End Try

        Call EnableGroup(False)
    End Sub

    ''' <summary>
    ''' refreshes table then refresh button is clicked
    ''' </summary>
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call tableRefresh()
    End Sub


    ''' <summary>
    ''' reloads the data from the dinos table in the connected database and refreshed the data grid view
    ''' </summary>
    Sub tableRefresh()
        'TODO: This line of code loads data into the 'NotesDBDataSet.Dinos' table. You can move, or remove it, as needed.

        Try
            Dim strSQL As String = "Select * From Dinos"

            'if filters toggled on dynamicaly generate sql based on criteria
            If chbxFilter.Checked Then
                strSQL &= " Where (ID >= 1) "
                If chbxName.Checked Then
                    strSQL &= " AND (dinoName LIKE '" & tbxNameFilter.Text & "')"
                End If
                If chbxGender.Checked Then
                    strSQL &= " AND (Gender = '" & cbxGenderFilter.SelectedItem & "')"
                End If
                If chbxSpecies.Checked Then
                    strSQL &= " AND (species = '" & cbxSpeciesFilter.Text & "')"
                End If
                If chbxHealth.Checked Then
                    strSQL &= " AND (health >= " & nudHealthLow.Value & ") AND (health <= " & nudHealthHigh.Value & " )"
                End If
                If chbxStam.Checked Then
                    strSQL &= " AND (stamina >= " & nudStaminaLow.Value & ") AND (Stamina <= " & nudStaminaHigh.Value & " )"
                End If
                If chbxOxygen.Checked Then
                    ' account for null values
                    strSQL &= " AND ("
                    If nudOxygenLow.Value = -1 Then
                        strSQL &= "(oxygen = '')"
                    Else
                        strSQL &= " (oxygen >= " & nudOxygenLow.Value & ")"
                    End If
                    If nudOxygenLow.Value = -1 Or nudOxygenLow.Value = -1 Then
                        strSQL &= " OR "
                    Else
                        strSQL &= " AND "
                    End If
                    If nudOxygenHigh.Value = -1 Then
                        strSQL &= "(oxygen = '')"
                    Else
                        strSQL &= "(oxygen <= " & nudOxygenHigh.Value & " )"
                    End If
                    strSQL &= ")"
                End If

                If chbxFood.Checked Then
                    strSQL &= " AND (food >= " & nudFoodLow.Value & ") AND (food <= " & nudFoodHigh.Value & " )"
                End If
                If chbxWeight.Checked Then
                    strSQL &= " AND (weightCapacity >= " & nudWeightLow.Value & ") AND (weightCapacity <= " & nudWeightHigh.Value & " )"
                End If
                If chbxDmg.Checked Then
                    strSQL &= " AND (damage >= " & nudDmgLow.Value & ") AND (damage <= " & nudDmgHigh.Value & " )"
                End If
                If chbxSpeed.Checked Then
                    strSQL &= " AND (speed >= " & nudSpeedLow.Value & ") AND (speed <= " & nudSpeedHigh.Value & " )"
                End If
                If chbxTorpor.Checked Then
                    strSQL &= " AND (torpor >= " & nudTorporLow.Value & ") AND (torpor <= " & nudTorporHigh.Value & " )"
                End If
                If chbxStartingLevel.Checked Then
                    strSQL &= " AND (startingLevel >= " & nudStartLow.Value & ") AND (startingLevel <= " & nudStartHigh.Value & " )"
                End If
                If chbxPersonal.Checked Then
                    strSQL &= " AND (personalOwner LIKE '" & tbxPersonalOwnerFilter.Text & "')"
                End If
                If chbxTribe.Checked Then
                    strSQL &= " AND (tribeOwner LIKE '" & tbxTribeOwnerFilter.Text & "')"
                End If
                If chbxFreq.Checked Then
                    If nudFreqFilter.Value = -1 Then
                        strSQL &= " AND (transponderFreq = '')"
                    Else
                        strSQL &= " AND (transponderFreq = '" & nudFreqFilter.Value & "')"
                    End If
                End If
                If chbxLiving.Checked Then
                    strSQL &= " AND (living = " & cbxLivingFilter.Text & ")"
                End If
            End If
            'end sql statement
            strSQL &= ";"

            'Loop through dataset And fill dgv
            dgvDinos.Rows.Clear()
            notesdb.SQL = strSQL
            For i As Integer = 0 To notesdb.ds.Tables(0).Rows.Count - 1
                dgvDinos.Rows.Add()
                With dgvDinos.Rows(i)
                    .Cells(0).Value = notesdb.ds.Tables(0).Rows(i).Item("ID")
                    .Cells(1).Value = notesdb.ds.Tables(0).Rows(i).Item("dinoName")
                    .Cells(2).Value = notesdb.ds.Tables(0).Rows(i).Item("Gender")
                    .Cells(3).Value = notesdb.ds.Tables(0).Rows(i).Item("species")
                    .Cells(4).Value = notesdb.ds.Tables(0).Rows(i).Item("health")
                    .Cells(5).Value = notesdb.ds.Tables(0).Rows(i).Item("stamina")
                    .Cells(6).Value = notesdb.ds.Tables(0).Rows(i).Item("oxygen")
                    .Cells(7).Value = notesdb.ds.Tables(0).Rows(i).Item("food")
                    .Cells(8).Value = notesdb.ds.Tables(0).Rows(i).Item("weightCapacity")
                    .Cells(9).Value = notesdb.ds.Tables(0).Rows(i).Item("damage")
                    .Cells(10).Value = notesdb.ds.Tables(0).Rows(i).Item("speed")
                    .Cells(11).Value = notesdb.ds.Tables(0).Rows(i).Item("torpor")
                    .Cells(12).Value = notesdb.ds.Tables(0).Rows(i).Item("startingLevel")
                    .Cells(13).Value = notesdb.ds.Tables(0).Rows(i).Item("living")
                    .Cells(14).Value = notesdb.ds.Tables(0).Rows(i).Item("personalOwner")
                    .Cells(15).Value = notesdb.ds.Tables(0).Rows(i).Item("tribeOwner")
                    .Cells(16).Value = notesdb.ds.Tables(0).Rows(i).Item("transponderFreq")
                End With
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading table:" & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK)
        End Try

        'fil in autofiill for search fields

        notesdb.sql = "SELECT DISTINCT personalOwner from Dinos"
        For i As Integer = 0 To notesdb.ds.Tables(0).Rows.Count - 1
            With notesdb.ds.Tables(0).Rows(i)
                tbxPersonalOwner.AutoCompleteCustomSource.Add(.item("personalOwner"))
                tbxPersonalOwnerFilter.AutoCompleteCustomSource.Add(.item("personalOwner"))
            End With
        Next
        notesdb.sql = "SELECT DISTINCT tribeOwner from Dinos"
        For i As Integer = 0 To notesdb.ds.Tables(0).Rows.Count - 1
            With notesdb.ds.Tables(0).Rows(i)
                tbxTribeOwner.AutoCompleteCustomSource.Add(.item("tribeOwner"))
                tbxTribeOwnerFilter.AutoCompleteCustomSource.Add(.item("tribeOwner"))
            End With
        Next

    End Sub
    ''' <summary>
    ''' When Filter is toggled on/off enable/disable the filter group box and call tableRefresh
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chbxFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chbxFilter.CheckedChanged
        gbxFilter.Enabled = chbxFilter.Checked
        Call tableRefresh()
    End Sub



    ''' <summary>
    ''' Enable Items Based on bool value. will set group box to enabled and all else to disabled also clears values in text boxes
    ''' </summary>
    ''' <param name="Enableitems"></param>
    Private Sub EnableGroup(ByVal Enableitems As Boolean)
        gbxRecord.Enabled = Enableitems
        dgvDinos.Enabled = Not Enableitems
        btnAdd.Enabled = Not Enableitems
        btnRemove.Enabled = Not Enableitems
        btnEdit.Enabled = Not Enableitems
        If Enableitems Then
            tbxName.Focus()
            cbxLiving.Text = "True"
        Else
            tbxName.Text = ""
            cbxSpecies.Text = ""
            nudHealth.Value = 0
            nudStam.Value = 0
            nudOxygen.Value = 0
            nudFood.Value = 0
            nudStartLevel.Value = 0
            nudWeight.Value = 0
            nudDmg.Value = 0
            nudSpeed.Value = 100
            nudTorpor.Value = 0
            cbxGender.Text = ""
            tbxPersonalOwner.Text = ""
            tbxTribeOwner.Text = ""
            nudFreq.Value = -1
            cbxLiving.Text = ""
        End If
    End Sub

    ''' <summary>
    ''' when user clicks add enable group box and set values to 0 and tag for new record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call EnableGroup(True)
        ' flag group box for add process
        gbxRecord.Tag = 0
    End Sub


    ''' <summary>
    ''' on user cancel disable group box and enable data grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call EnableGroup(False)
        Call tableRefresh()
    End Sub
    ''' <summary>
    ''' when buten is clicked reload table using new filter criteria
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnUpdateFilter_Click(sender As Object, e As EventArgs) Handles btnUpdateFilter.Click
        Call tableRefresh()
    End Sub

    ''' <summary>
    ''' When save button is clicked in the records group box add or update corispoding record 
    ''' for new record gbxRecord.tag is set to 0 for edit of tag is set to the record ID
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cbxSpecies.Text = "" Then
            MessageBox.Show("Error: You must select a species option")
            Exit Sub
        End If
        If cbxLiving.Text = "" Then
            MessageBox.Show("Error: You must select a living status option")
            Exit Sub
        End If

        If gbxRecord.Tag = 0 Then
            'new record 
            notesdb.SQL = "SELECT * From Dinos WHERE ID = 0;"
            Dim dsnewrow As DataRow
            dsnewrow = notesdb.ds.Tables(0).NewRow
            With dsnewrow
                .Item("dinoName") = tbxName.Text
                .Item("Gender") = cbxGender.SelectedItem
                .Item("species") = cbxSpecies.Text
                .Item("health") = nudHealth.Value
                .Item("stamina") = nudStam.Value
                'aquatic dinos have o2 set to -1
                .Item("oxygen") = nudOxygen.Value
                .Item("food") = nudFood.Value
                .Item("weightCapacity") = nudWeight.Value
                .Item("damage") = nudDmg.Value
                .Item("speed") = nudSpeed.Value
                .Item("torpor") = nudTorpor.Value
                .Item("startingLevel") = nudStartLevel.Value
                .Item("personalOwner") = tbxPersonalOwner.Text
                .Item("tribeOwner") = tbxTribeOwner.Text
                .Item("transponderFreq") = nudFreq.Value
                .Item("living") = cbxLiving.Text
            End With
            notesdb.ds.Tables(0).Rows.Add(dsnewrow)
            notesdb.da.Update(notesdb.ds)
        Else
            notesdb.SQL = "SELECT * From Dinos WHERE ID = " & gbxRecord.Tag & ";"
            With notesdb.ds.Tables(0).Rows(0)
                .Item("dinoName") = tbxName.Text
                .Item("Gender") = cbxGender.SelectedItem
                .Item("species") = cbxSpecies.Text
                .Item("health") = nudHealth.Value
                .Item("stamina") = nudStam.Value
                'aquatic dinos have o2 set to -1
                If nudOxygen.Value = -1 Then
                Else
                    .Item("oxygen") = nudOxygen.Value
                End If
                .Item("food") = nudFood.Value
                .Item("weightCapacity") = nudWeight.Value
                .Item("damage") = nudDmg.Value
                .Item("speed") = nudSpeed.Value
                .Item("torpor") = nudTorpor.Value
                .Item("startingLevel") = nudStartLevel.Value
                .Item("personalOwner") = tbxPersonalOwner.Text
                .Item("tribeOwner") = tbxTribeOwner.Text
                .Item("transponderFreq") = nudFreq.Value
                .Item("living") = cbxLiving.Text
            End With
            notesdb.da.Update(notesdb.ds)
        End If
        Call EnableGroup(False)
        Call tableRefresh()
    End Sub

    ''' <summary>
    ''' on edit button click load the selected record into the controls contained in the groupbox and set tag to record ID
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'get current row number (index)
        Dim r As Integer = dgvDinos.CurrentRow.Index
        'get value of cell for selected row
        Dim ID As String = dgvDinos.Rows(r).Cells(0).Value
        gbxRecord.Tag = ID
        With dgvDinos.Rows(r)
            tbxName.Text = .Cells(1).Value
            cbxGender.Text = .Cells(2).Value
            cbxSpecies.Text = .Cells(3).Value
            nudHealth.Value = .Cells(4).Value
            nudStam.Value = .Cells(5).Value
            'aquatic dinos have o2 set to -1
            If Not (.Cells(6).Value >= 0) Then
                nudOxygen.Value = -1
            Else
                nudOxygen.Value = .Cells(6).Value
            End If
            nudFood.Value = .Cells(7).Value
            nudWeight.Value = .Cells(8).Value
            nudDmg.Value = .Cells(9).Value
            nudSpeed.Value = .Cells(10).Value
            nudTorpor.Value = .Cells(11).Value
            nudStartLevel.Value = .Cells(12).Value
            cbxLiving.Text = .Cells(13).Value.ToString
            tbxPersonalOwner.Text = .Cells(14).Value
            tbxTribeOwner.Text = .Cells(15).Value
            If Not (.Cells(16).Value >= 0) Then
                nudFreq.Value = -1
            Else
                nudFreq.Value = .Cells(16).Value
            End If

        End With
        Call EnableGroup(True)
    End Sub

    ''' <summary>
    ''' Removes selected record from database after confirmation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'get current row number (index)
        Dim r As Integer = dgvDinos.CurrentRow.Index
        'get value of cell for selected row
        Dim ID As String = dgvDinos.Rows(r).Cells(0).Value
        'verify intent
        If MessageBox.Show("Are you sure you want to delete " & dgvDinos.Rows(r).Cells(1).Value & "?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            'create class
            notesdb.SQL = "SELECT * From Dinos WHERE ID = " & ID & ";"
            notesdb.ds.Tables(0).Rows(0).Delete()
            notesdb.da.Update(notesdb.ds)
            'refresh screen
            Call tableRefresh()
        End If
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
    ''' launches settings form when settings menu bar item is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSettings_Click(sender As Object, e As EventArgs) Handles mnuSettings.Click
        Dim frm As New frmSettings
        frm.ShowDialog()
        'Reload form data 
        gbxFilter.Enabled = chbxFilter.Checked
        If My.Settings.DBType = "OLEDB" Then
            notesdb = New accessDBlink
        ElseIf My.Settings.DBType = "ODBC" Then
            notesdb = New mysqlDBlink
        End If
        notesdb.connectionString = My.Settings.NotesDBConnectionString
        Call tableRefresh()
        'fill combo boxes
        notesdb.SQL = "SELECT * from Species"
        For i As Integer = 0 To notesdb.ds.Tables(0).Rows.Count - 1
            cbxSpecies.Items.Add(notesdb.ds.Tables(0).Rows(i).Item("species"))
            cbxSpeciesFilter.Items.Add(notesdb.ds.Tables(0).Rows(i).Item("species"))
        Next
    End Sub
    ''' <summary>
    ''' launces an instance of frmMapNotes and closes this form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MapNotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapNotesToolStripMenuItem.Click
        Dim frm As New frmMapNotes
        frm.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Generates and displays a printable report based on the items listed in the data grid view
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim myReportText As String
        myReportText = "<html>"
        myReportText &= "<head>"
        myReportText &= "<title>Dino Lis</title>"
        myReportText &= "</head>"
        myReportText &= "<body>"
        myReportText &= " <h1>Dino List</h1>"
        myReportText &= "<hr/>"
        myReportText &= "<table>"
        myReportText &= "<tr><th>Name</th><th>Gender</th><th>Species</th><th>Health</th><th>Stamina</th><th>Oxygen</th><th>Food</th><th>Weight</th><th>Damage</th><th>Speed</th><th>Torpor</th><th>Start Level</th><th>Personal Owner</th><th>Tribe Owner</th><th>Transponder Frequency</th></tr>"
        For i As Integer = 0 To dgvDinos.RowCount - 1
            With dgvDinos.Rows(i)
                myReportText &= "<tr>"
                myReportText &= "<td>" & .Cells(1).Value & "</td>"
                myReportText &= "<td>" & .Cells(2).Value & "</td>"
                myReportText &= "<td>" & .Cells(3).Value & "</td>"
                myReportText &= "<td>" & .Cells(4).Value & "</td>"
                myReportText &= "<td>" & .Cells(5).Value & "</td>"
                myReportText &= "<td>" & .Cells(6).Value & "</td>"
                myReportText &= "<td>" & .Cells(7).Value & "</td>"
                myReportText &= "<td>" & .Cells(8).Value & "</td>"
                myReportText &= "<td>" & .Cells(9).Value & "</td>"
                myReportText &= "<td>" & .Cells(10).Value & "</td>"
                myReportText &= "<td>" & .Cells(11).Value & "</td>"
                myReportText &= "<td>" & .Cells(12).Value & "</td>"
                myReportText &= "<td>" & .Cells(13).Value & "</td>"
                myReportText &= "<td>" & .Cells(14).Value & "</td>"
                myReportText &= "<td>" & .Cells(15).Value & "</td>"
                myReportText &= "  </tr>"
            End With
        Next

        myReportText &= "</table>"
        myReportText &= "</body>"
        myReportText &= "</html>"

        Dim frm As New frmReport
        frm.wbReport.DocumentText = myReportText
        frm.ShowDialog()
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
    ''' Selects all the text in the box when control revives focus
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectText(sender As Object, e As EventArgs) Handles tbxName.GotFocus, nudHealth.GotFocus, nudStam.GotFocus, nudFood.GotFocus, nudOxygen.GotFocus, nudStartLevel.GotFocus, nudWeight.GotFocus, nudDmg.GotFocus, nudSpeed.GotFocus, nudTorpor.GotFocus, tbxPersonalOwner.GotFocus, tbxTribeOwner.GotFocus, nudFreq.GotFocus, tbxNameFilter.GotFocus, nudHealthLow.GotFocus, nudHealthHigh.GotFocus, nudStaminaLow.GotFocus, nudStaminaHigh.GotFocus, nudOxygenLow.GotFocus, nudOxygenHigh.GotFocus, nudFoodLow.GotFocus, nudFoodHigh.GotFocus, nudWeightLow.GotFocus, nudWeightHigh.GotFocus, nudDmgLow.GotFocus, nudDmgHigh.GotFocus, nudSpeedLow.GotFocus, nudSpeedHigh.GotFocus, nudTorporLow.GotFocus, nudTorporHigh.GotFocus, nudStartLow.GotFocus, nudStartHigh.GotFocus, tbxPersonalOwnerFilter.GotFocus, tbxTribeOwnerFilter.GotFocus, nudFreqFilter.GotFocus
        sender.Select(0, sender.Text.Length)
    End Sub

    '''' <summary>
    '''' sub to advance through controls in the gbxrecord 
    '''' </summary>
    '''' <param name="sender"></param>
    '''' <param name="e"></param>
    'Private Sub gbxRecord_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles gbxRecord.PreviewKeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If btnSave.Focused Then
    '        Else
    '            Dim ctrl As Control = Me.GetNextControl(fo, True)
    '            ctrl.Focus()
    '        End If
    '    End If
    'End Sub
End Class