<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMapNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMapNotes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.dgvNotes = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XCord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YCord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteText = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxNotes = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudY = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudX = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxTitle = New System.Windows.Forms.TextBox()
        Me.rtbxNoteText = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DinoTrackingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutArkNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbxMap = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxNotes.SuspendLayout()
        CType(Me.nudY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbxMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(569, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Locations:"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(668, 262)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(70, 23)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(823, 262)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(569, 262)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(93, 23)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'dgvNotes
        '
        Me.dgvNotes.AllowUserToAddRows = False
        Me.dgvNotes.AllowUserToDeleteRows = False
        Me.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Title, Me.XCord, Me.YCord, Me.NoteText})
        Me.dgvNotes.Location = New System.Drawing.Point(569, 45)
        Me.dgvNotes.Name = "dgvNotes"
        Me.dgvNotes.ReadOnly = True
        Me.dgvNotes.Size = New System.Drawing.Size(350, 211)
        Me.dgvNotes.TabIndex = 15
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Title
        '
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        Me.Title.Width = 150
        '
        'XCord
        '
        Me.XCord.HeaderText = "X"
        Me.XCord.Name = "XCord"
        Me.XCord.ReadOnly = True
        Me.XCord.Width = 50
        '
        'YCord
        '
        Me.YCord.HeaderText = "Y"
        Me.YCord.Name = "YCord"
        Me.YCord.ReadOnly = True
        Me.YCord.Width = 50
        '
        'NoteText
        '
        Me.NoteText.HeaderText = "Note"
        Me.NoteText.Name = "NoteText"
        Me.NoteText.ReadOnly = True
        Me.NoteText.Width = 55
        '
        'gbxNotes
        '
        Me.gbxNotes.Controls.Add(Me.btnCancel)
        Me.gbxNotes.Controls.Add(Me.btnSave)
        Me.gbxNotes.Controls.Add(Me.Label5)
        Me.gbxNotes.Controls.Add(Me.nudY)
        Me.gbxNotes.Controls.Add(Me.Label4)
        Me.gbxNotes.Controls.Add(Me.Label3)
        Me.gbxNotes.Controls.Add(Me.nudX)
        Me.gbxNotes.Controls.Add(Me.Label2)
        Me.gbxNotes.Controls.Add(Me.tbxTitle)
        Me.gbxNotes.Controls.Add(Me.rtbxNoteText)
        Me.gbxNotes.Enabled = False
        Me.gbxNotes.Location = New System.Drawing.Point(570, 292)
        Me.gbxNotes.Name = "gbxNotes"
        Me.gbxNotes.Size = New System.Drawing.Size(349, 287)
        Me.gbxNotes.TabIndex = 16
        Me.gbxNotes.TabStop = False
        Me.gbxNotes.Text = "Note"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(225, 258)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(118, 23)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(6, 258)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(118, 23)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Note Text:"
        '
        'nudY
        '
        Me.nudY.DecimalPlaces = 2
        Me.nudY.Location = New System.Drawing.Point(83, 71)
        Me.nudY.Name = "nudY"
        Me.nudY.Size = New System.Drawing.Size(136, 20)
        Me.nudY.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Y Coordinate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "X Coordinate:"
        '
        'nudX
        '
        Me.nudX.DecimalPlaces = 2
        Me.nudX.Location = New System.Drawing.Point(83, 45)
        Me.nudX.Name = "nudX"
        Me.nudX.Size = New System.Drawing.Size(136, 20)
        Me.nudX.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Note Title:"
        '
        'tbxTitle
        '
        Me.tbxTitle.Location = New System.Drawing.Point(68, 19)
        Me.tbxTitle.Name = "tbxTitle"
        Me.tbxTitle.Size = New System.Drawing.Size(275, 20)
        Me.tbxTitle.TabIndex = 1
        '
        'rtbxNoteText
        '
        Me.rtbxNoteText.Location = New System.Drawing.Point(9, 113)
        Me.rtbxNoteText.Name = "rtbxNoteText"
        Me.rtbxNoteText.Size = New System.Drawing.Size(334, 139)
        Me.rtbxNoteText.TabIndex = 0
        Me.rtbxNoteText.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.mnuHelp, Me.mnuSettings})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(928, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MapNotesToolStripMenuItem, Me.DinoTrackingToolStripMenuItem})
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MainMenuToolStripMenuItem.Text = "Menu"
        '
        'MapNotesToolStripMenuItem
        '
        Me.MapNotesToolStripMenuItem.Name = "MapNotesToolStripMenuItem"
        Me.MapNotesToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.MapNotesToolStripMenuItem.Text = "Map Notes"
        '
        'DinoTrackingToolStripMenuItem
        '
        Me.DinoTrackingToolStripMenuItem.Name = "DinoTrackingToolStripMenuItem"
        Me.DinoTrackingToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.DinoTrackingToolStripMenuItem.Text = "Dino Tracking"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutArkNotesToolStripMenuItem, Me.ViewHelpToolStripMenuItem})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'AboutArkNotesToolStripMenuItem
        '
        Me.AboutArkNotesToolStripMenuItem.Name = "AboutArkNotesToolStripMenuItem"
        Me.AboutArkNotesToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AboutArkNotesToolStripMenuItem.Text = "About ArkNotes"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'mnuSettings
        '
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(61, 20)
        Me.mnuSettings.Text = "Settings"
        '
        'pbxMap
        '
        Me.pbxMap.InitialImage = Global.Ark_Notes.My.Resources.Resources.ArkNotesIcon
        Me.pbxMap.Location = New System.Drawing.Point(13, 29)
        Me.pbxMap.Name = "pbxMap"
        Me.pbxMap.Size = New System.Drawing.Size(550, 550)
        Me.pbxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxMap.TabIndex = 2
        Me.pbxMap.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(742, 263)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 18
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'frmMapNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 588)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbxNotes)
        Me.Controls.Add(Me.dgvNotes)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbxMap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(944, 627)
        Me.MinimumSize = New System.Drawing.Size(944, 627)
        Me.Name = "frmMapNotes"
        Me.Text = "Map Notes"
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxNotes.ResumeLayout(False)
        Me.gbxNotes.PerformLayout()
        CType(Me.nudY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbxMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxMap As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents dgvNotes As DataGridView
    Friend WithEvents gbxNotes As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nudX As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxTitle As TextBox
    Friend WithEvents rtbxNoteText As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nudY As NumericUpDown
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents XCord As DataGridViewTextBoxColumn
    Friend WithEvents YCord As DataGridViewTextBoxColumn
    Friend WithEvents NoteText As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MapNotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DinoTrackingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents AboutArkNotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSettings As ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnRefresh As Button
End Class
