<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxDatabase = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.tbxSpecies = New System.Windows.Forms.TextBox()
        Me.lbxSpecies = New System.Windows.Forms.ListBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxMap = New System.Windows.Forms.TextBox()
        Me.btnBrowseMap = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnTestDB = New System.Windows.Forms.Button()
        Me.rbOLEDB = New System.Windows.Forms.RadioButton()
        Me.rbODBC = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database Connection String:"
        '
        'tbxDatabase
        '
        Me.tbxDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxDatabase.Location = New System.Drawing.Point(15, 25)
        Me.tbxDatabase.Name = "tbxDatabase"
        Me.tbxDatabase.Size = New System.Drawing.Size(372, 20)
        Me.tbxDatabase.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 359)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Location = New System.Drawing.Point(139, 359)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(121, 23)
        Me.btnRestore.TabIndex = 3
        Me.btnRestore.Text = "Restore Defaults"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.tbxSpecies)
        Me.GroupBox1.Controls.Add(Me.lbxSpecies)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 231)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add/Remove Spicies"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(7, 199)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(108, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add Species"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(261, 199)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(108, 23)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'tbxSpecies
        '
        Me.tbxSpecies.Location = New System.Drawing.Point(6, 173)
        Me.tbxSpecies.Name = "tbxSpecies"
        Me.tbxSpecies.Size = New System.Drawing.Size(363, 20)
        Me.tbxSpecies.TabIndex = 2
        '
        'lbxSpecies
        '
        Me.lbxSpecies.FormattingEnabled = True
        Me.lbxSpecies.Location = New System.Drawing.Point(7, 20)
        Me.lbxSpecies.Name = "lbxSpecies"
        Me.lbxSpecies.Size = New System.Drawing.Size(362, 147)
        Me.lbxSpecies.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(266, 359)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(121, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Map Image File"
        '
        'tbxMap
        '
        Me.tbxMap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxMap.Location = New System.Drawing.Point(12, 95)
        Me.tbxMap.Name = "tbxMap"
        Me.tbxMap.Size = New System.Drawing.Size(291, 20)
        Me.tbxMap.TabIndex = 7
        '
        'btnBrowseMap
        '
        Me.btnBrowseMap.Location = New System.Drawing.Point(309, 93)
        Me.btnBrowseMap.Name = "btnBrowseMap"
        Me.btnBrowseMap.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseMap.TabIndex = 8
        Me.btnBrowseMap.Text = "Browse"
        Me.btnBrowseMap.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Image files (*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)|*.gif; *.jpg; *.jpeg; *.b" &
    "mp; *.wmf; *.png|All files (*.*)|*.*"
        Me.OpenFileDialog1.Title = "Browse For File"
        '
        'btnTestDB
        '
        Me.btnTestDB.Location = New System.Drawing.Point(263, 51)
        Me.btnTestDB.Name = "btnTestDB"
        Me.btnTestDB.Size = New System.Drawing.Size(124, 23)
        Me.btnTestDB.TabIndex = 9
        Me.btnTestDB.Text = "Test Connection"
        Me.btnTestDB.UseVisualStyleBackColor = True
        '
        'rbOLEDB
        '
        Me.rbOLEDB.AutoSize = True
        Me.rbOLEDB.Location = New System.Drawing.Point(136, 54)
        Me.rbOLEDB.Name = "rbOLEDB"
        Me.rbOLEDB.Size = New System.Drawing.Size(61, 17)
        Me.rbOLEDB.TabIndex = 10
        Me.rbOLEDB.TabStop = True
        Me.rbOLEDB.Text = "OELDB"
        Me.rbOLEDB.UseVisualStyleBackColor = True
        '
        'rbODBC
        '
        Me.rbODBC.AutoSize = True
        Me.rbODBC.Location = New System.Drawing.Point(203, 54)
        Me.rbODBC.Name = "rbODBC"
        Me.rbODBC.Size = New System.Drawing.Size(55, 17)
        Me.rbODBC.TabIndex = 11
        Me.rbODBC.TabStop = True
        Me.rbODBC.Text = "ODBC"
        Me.rbODBC.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Connection Type:"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 388)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbODBC)
        Me.Controls.Add(Me.rbOLEDB)
        Me.Controls.Add(Me.btnTestDB)
        Me.Controls.Add(Me.btnBrowseMap)
        Me.Controls.Add(Me.tbxMap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbxDatabase)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbxDatabase As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRestore As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbxSpecies As ListBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents tbxSpecies As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxMap As TextBox
    Friend WithEvents btnBrowseMap As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnTestDB As Button
    Friend WithEvents rbOLEDB As RadioButton
    Friend WithEvents rbODBC As RadioButton
    Friend WithEvents Label3 As Label
End Class
