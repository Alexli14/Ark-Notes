<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAssets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssets))
        Me.dgvDinos = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DinoNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notesdbGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HealthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaminaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OxygenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightCapacityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DamageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpeedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TorporDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartingLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LivingDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PersonalOwnerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TribeOwnerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransponderFreqDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbxFilter = New System.Windows.Forms.CheckBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.gbxRecord = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cbxLiving = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.nudFreq = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbxGender = New System.Windows.Forms.ComboBox()
        Me.tbxTribeOwner = New System.Windows.Forms.TextBox()
        Me.tbxPersonalOwner = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nudStartLevel = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxSpecies = New System.Windows.Forms.ComboBox()
        Me.nudTorpor = New System.Windows.Forms.NumericUpDown()
        Me.nudDmg = New System.Windows.Forms.NumericUpDown()
        Me.nudSpeed = New System.Windows.Forms.NumericUpDown()
        Me.nudFood = New System.Windows.Forms.NumericUpDown()
        Me.nudOxygen = New System.Windows.Forms.NumericUpDown()
        Me.nudStam = New System.Windows.Forms.NumericUpDown()
        Me.nudWeight = New System.Windows.Forms.NumericUpDown()
        Me.nudHealth = New System.Windows.Forms.NumericUpDown()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DinoTrackingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutArkNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.nudHealthLow = New System.Windows.Forms.NumericUpDown()
        Me.nudHealthHigh = New System.Windows.Forms.NumericUpDown()
        Me.nudStaminaLow = New System.Windows.Forms.NumericUpDown()
        Me.nudStaminaHigh = New System.Windows.Forms.NumericUpDown()
        Me.nudOxygenLow = New System.Windows.Forms.NumericUpDown()
        Me.nudOxygenHigh = New System.Windows.Forms.NumericUpDown()
        Me.nudFoodLow = New System.Windows.Forms.NumericUpDown()
        Me.nudFoodHigh = New System.Windows.Forms.NumericUpDown()
        Me.nudStartLow = New System.Windows.Forms.NumericUpDown()
        Me.nudStartHigh = New System.Windows.Forms.NumericUpDown()
        Me.nudWeightLow = New System.Windows.Forms.NumericUpDown()
        Me.nudWeightHigh = New System.Windows.Forms.NumericUpDown()
        Me.nudDmgLow = New System.Windows.Forms.NumericUpDown()
        Me.nudDmgHigh = New System.Windows.Forms.NumericUpDown()
        Me.nudSpeedLow = New System.Windows.Forms.NumericUpDown()
        Me.nudSpeedHigh = New System.Windows.Forms.NumericUpDown()
        Me.nudTorporLow = New System.Windows.Forms.NumericUpDown()
        Me.nudTorporHigh = New System.Windows.Forms.NumericUpDown()
        Me.nudFreqFilter = New System.Windows.Forms.NumericUpDown()
        Me.chbxName = New System.Windows.Forms.CheckBox()
        Me.chbxSpecies = New System.Windows.Forms.CheckBox()
        Me.chbxStartingLevel = New System.Windows.Forms.CheckBox()
        Me.chbxPersonal = New System.Windows.Forms.CheckBox()
        Me.chbxHealth = New System.Windows.Forms.CheckBox()
        Me.chbxStam = New System.Windows.Forms.CheckBox()
        Me.chbxOxygen = New System.Windows.Forms.CheckBox()
        Me.chbxFood = New System.Windows.Forms.CheckBox()
        Me.chbxTribe = New System.Windows.Forms.CheckBox()
        Me.chbxFreq = New System.Windows.Forms.CheckBox()
        Me.tbxNameFilter = New System.Windows.Forms.TextBox()
        Me.cbxSpeciesFilter = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.chbxWeight = New System.Windows.Forms.CheckBox()
        Me.chbxDmg = New System.Windows.Forms.CheckBox()
        Me.chbxSpeed = New System.Windows.Forms.CheckBox()
        Me.chbxTorpor = New System.Windows.Forms.CheckBox()
        Me.chbxGender = New System.Windows.Forms.CheckBox()
        Me.cbxGenderFilter = New System.Windows.Forms.ComboBox()
        Me.tbxPersonalOwnerFilter = New System.Windows.Forms.TextBox()
        Me.tbxTribeOwnerFilter = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnUpdateFilter = New System.Windows.Forms.Button()
        Me.gbxFilter = New System.Windows.Forms.GroupBox()
        Me.cbxLivingFilter = New System.Windows.Forms.ComboBox()
        Me.chbxLiving = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        CType(Me.dgvDinos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbxRecord.SuspendLayout()
        CType(Me.nudFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTorpor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDmg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOxygen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.nudHealthLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHealthHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStaminaLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStaminaHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOxygenLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOxygenHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFoodLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFoodHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWeightLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWeightHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDmgLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDmgHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSpeedLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSpeedHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTorporLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTorporHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFreqFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDinos
        '
        Me.dgvDinos.AllowUserToAddRows = False
        Me.dgvDinos.AllowUserToDeleteRows = False
        Me.dgvDinos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDinos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DinoNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.notesdbGridViewTextBoxColumn, Me.HealthDataGridViewTextBoxColumn, Me.StaminaDataGridViewTextBoxColumn, Me.OxygenDataGridViewTextBoxColumn, Me.FoodDataGridViewTextBoxColumn, Me.WeightCapacityDataGridViewTextBoxColumn, Me.DamageDataGridViewTextBoxColumn, Me.SpeedDataGridViewTextBoxColumn, Me.TorporDataGridViewTextBoxColumn, Me.StartingLevelDataGridViewTextBoxColumn, Me.LivingDataGridViewCheckBoxColumn, Me.PersonalOwnerDataGridViewTextBoxColumn, Me.TribeOwnerDataGridViewTextBoxColumn, Me.TransponderFreqDataGridViewTextBoxColumn})
        Me.dgvDinos.Location = New System.Drawing.Point(6, 19)
        Me.dgvDinos.Name = "dgvDinos"
        Me.dgvDinos.ReadOnly = True
        Me.dgvDinos.Size = New System.Drawing.Size(931, 196)
        Me.dgvDinos.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'DinoNameDataGridViewTextBoxColumn
        '
        Me.DinoNameDataGridViewTextBoxColumn.DataPropertyName = "dinoName"
        Me.DinoNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.DinoNameDataGridViewTextBoxColumn.Name = "DinoNameDataGridViewTextBoxColumn"
        Me.DinoNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Width = 50
        '
        'notesdbGridViewTextBoxColumn
        '
        Me.notesdbGridViewTextBoxColumn.DataPropertyName = "species"
        Me.notesdbGridViewTextBoxColumn.HeaderText = "Species"
        Me.notesdbGridViewTextBoxColumn.Name = "notesdbGridViewTextBoxColumn"
        Me.notesdbGridViewTextBoxColumn.ReadOnly = True
        '
        'HealthDataGridViewTextBoxColumn
        '
        Me.HealthDataGridViewTextBoxColumn.DataPropertyName = "health"
        Me.HealthDataGridViewTextBoxColumn.HeaderText = "Health"
        Me.HealthDataGridViewTextBoxColumn.Name = "HealthDataGridViewTextBoxColumn"
        Me.HealthDataGridViewTextBoxColumn.ReadOnly = True
        Me.HealthDataGridViewTextBoxColumn.Width = 75
        '
        'StaminaDataGridViewTextBoxColumn
        '
        Me.StaminaDataGridViewTextBoxColumn.DataPropertyName = "stamina"
        Me.StaminaDataGridViewTextBoxColumn.HeaderText = "Stamina"
        Me.StaminaDataGridViewTextBoxColumn.Name = "StaminaDataGridViewTextBoxColumn"
        Me.StaminaDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaminaDataGridViewTextBoxColumn.Width = 75
        '
        'OxygenDataGridViewTextBoxColumn
        '
        Me.OxygenDataGridViewTextBoxColumn.DataPropertyName = "oxygen"
        Me.OxygenDataGridViewTextBoxColumn.HeaderText = "Oxygen"
        Me.OxygenDataGridViewTextBoxColumn.Name = "OxygenDataGridViewTextBoxColumn"
        Me.OxygenDataGridViewTextBoxColumn.ReadOnly = True
        Me.OxygenDataGridViewTextBoxColumn.Width = 75
        '
        'FoodDataGridViewTextBoxColumn
        '
        Me.FoodDataGridViewTextBoxColumn.DataPropertyName = "food"
        Me.FoodDataGridViewTextBoxColumn.HeaderText = "Food"
        Me.FoodDataGridViewTextBoxColumn.Name = "FoodDataGridViewTextBoxColumn"
        Me.FoodDataGridViewTextBoxColumn.ReadOnly = True
        Me.FoodDataGridViewTextBoxColumn.Width = 75
        '
        'WeightCapacityDataGridViewTextBoxColumn
        '
        Me.WeightCapacityDataGridViewTextBoxColumn.DataPropertyName = "weightCapacity"
        Me.WeightCapacityDataGridViewTextBoxColumn.HeaderText = "Weight Capacity"
        Me.WeightCapacityDataGridViewTextBoxColumn.Name = "WeightCapacityDataGridViewTextBoxColumn"
        Me.WeightCapacityDataGridViewTextBoxColumn.ReadOnly = True
        Me.WeightCapacityDataGridViewTextBoxColumn.Width = 75
        '
        'DamageDataGridViewTextBoxColumn
        '
        Me.DamageDataGridViewTextBoxColumn.DataPropertyName = "damage"
        Me.DamageDataGridViewTextBoxColumn.HeaderText = "Damage"
        Me.DamageDataGridViewTextBoxColumn.Name = "DamageDataGridViewTextBoxColumn"
        Me.DamageDataGridViewTextBoxColumn.ReadOnly = True
        Me.DamageDataGridViewTextBoxColumn.Width = 50
        '
        'SpeedDataGridViewTextBoxColumn
        '
        Me.SpeedDataGridViewTextBoxColumn.DataPropertyName = "speed"
        Me.SpeedDataGridViewTextBoxColumn.HeaderText = "Speed"
        Me.SpeedDataGridViewTextBoxColumn.Name = "SpeedDataGridViewTextBoxColumn"
        Me.SpeedDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpeedDataGridViewTextBoxColumn.Width = 50
        '
        'TorporDataGridViewTextBoxColumn
        '
        Me.TorporDataGridViewTextBoxColumn.DataPropertyName = "torpor"
        Me.TorporDataGridViewTextBoxColumn.HeaderText = "Torpor"
        Me.TorporDataGridViewTextBoxColumn.Name = "TorporDataGridViewTextBoxColumn"
        Me.TorporDataGridViewTextBoxColumn.ReadOnly = True
        Me.TorporDataGridViewTextBoxColumn.Width = 75
        '
        'StartingLevelDataGridViewTextBoxColumn
        '
        Me.StartingLevelDataGridViewTextBoxColumn.DataPropertyName = "startingLevel"
        Me.StartingLevelDataGridViewTextBoxColumn.HeaderText = "Starting Level"
        Me.StartingLevelDataGridViewTextBoxColumn.Name = "StartingLevelDataGridViewTextBoxColumn"
        Me.StartingLevelDataGridViewTextBoxColumn.ReadOnly = True
        Me.StartingLevelDataGridViewTextBoxColumn.Width = 50
        '
        'LivingDataGridViewCheckBoxColumn
        '
        Me.LivingDataGridViewCheckBoxColumn.HeaderText = "Living"
        Me.LivingDataGridViewCheckBoxColumn.Name = "LivingDataGridViewCheckBoxColumn"
        Me.LivingDataGridViewCheckBoxColumn.ReadOnly = True
        Me.LivingDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LivingDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PersonalOwnerDataGridViewTextBoxColumn
        '
        Me.PersonalOwnerDataGridViewTextBoxColumn.DataPropertyName = "personalOwner"
        Me.PersonalOwnerDataGridViewTextBoxColumn.HeaderText = "Personal Owner"
        Me.PersonalOwnerDataGridViewTextBoxColumn.Name = "PersonalOwnerDataGridViewTextBoxColumn"
        Me.PersonalOwnerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TribeOwnerDataGridViewTextBoxColumn
        '
        Me.TribeOwnerDataGridViewTextBoxColumn.DataPropertyName = "tribeOwner"
        Me.TribeOwnerDataGridViewTextBoxColumn.HeaderText = "Tribe Owner"
        Me.TribeOwnerDataGridViewTextBoxColumn.Name = "TribeOwnerDataGridViewTextBoxColumn"
        Me.TribeOwnerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransponderFreqDataGridViewTextBoxColumn
        '
        Me.TransponderFreqDataGridViewTextBoxColumn.DataPropertyName = "transponderFreq"
        Me.TransponderFreqDataGridViewTextBoxColumn.HeaderText = "Transponder Frequency"
        Me.TransponderFreqDataGridViewTextBoxColumn.Name = "TransponderFreqDataGridViewTextBoxColumn"
        Me.TransponderFreqDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransponderFreqDataGridViewTextBoxColumn.Width = 75
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(6, 221)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(168, 221)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Location = New System.Drawing.Point(87, 221)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.chbxFilter)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.btnReport)
        Me.GroupBox1.Controls.Add(Me.dgvDinos)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(947, 250)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dino List"
        '
        'chbxFilter
        '
        Me.chbxFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chbxFilter.AutoSize = True
        Me.chbxFilter.Location = New System.Drawing.Point(411, 225)
        Me.chbxFilter.Name = "chbxFilter"
        Me.chbxFilter.Size = New System.Drawing.Size(84, 17)
        Me.chbxFilter.TabIndex = 5
        Me.chbxFilter.Text = "Toggle Filter"
        Me.chbxFilter.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(330, 221)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReport.Location = New System.Drawing.Point(249, 221)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'gbxRecord
        '
        Me.gbxRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbxRecord.Controls.Add(Me.Label26)
        Me.gbxRecord.Controls.Add(Me.cbxLiving)
        Me.gbxRecord.Controls.Add(Me.btnCancel)
        Me.gbxRecord.Controls.Add(Me.btnSave)
        Me.gbxRecord.Controls.Add(Me.Label19)
        Me.gbxRecord.Controls.Add(Me.nudFreq)
        Me.gbxRecord.Controls.Add(Me.Label18)
        Me.gbxRecord.Controls.Add(Me.cbxGender)
        Me.gbxRecord.Controls.Add(Me.tbxTribeOwner)
        Me.gbxRecord.Controls.Add(Me.tbxPersonalOwner)
        Me.gbxRecord.Controls.Add(Me.Label17)
        Me.gbxRecord.Controls.Add(Me.Label16)
        Me.gbxRecord.Controls.Add(Me.nudStartLevel)
        Me.gbxRecord.Controls.Add(Me.Label15)
        Me.gbxRecord.Controls.Add(Me.Label14)
        Me.gbxRecord.Controls.Add(Me.Label13)
        Me.gbxRecord.Controls.Add(Me.Label12)
        Me.gbxRecord.Controls.Add(Me.Label11)
        Me.gbxRecord.Controls.Add(Me.Label10)
        Me.gbxRecord.Controls.Add(Me.Label9)
        Me.gbxRecord.Controls.Add(Me.Label5)
        Me.gbxRecord.Controls.Add(Me.Label3)
        Me.gbxRecord.Controls.Add(Me.Label2)
        Me.gbxRecord.Controls.Add(Me.cbxSpecies)
        Me.gbxRecord.Controls.Add(Me.nudTorpor)
        Me.gbxRecord.Controls.Add(Me.nudDmg)
        Me.gbxRecord.Controls.Add(Me.nudSpeed)
        Me.gbxRecord.Controls.Add(Me.nudFood)
        Me.gbxRecord.Controls.Add(Me.nudOxygen)
        Me.gbxRecord.Controls.Add(Me.nudStam)
        Me.gbxRecord.Controls.Add(Me.nudWeight)
        Me.gbxRecord.Controls.Add(Me.nudHealth)
        Me.gbxRecord.Controls.Add(Me.tbxName)
        Me.gbxRecord.Controls.Add(Me.Label1)
        Me.gbxRecord.Location = New System.Drawing.Point(18, 285)
        Me.gbxRecord.Name = "gbxRecord"
        Me.gbxRecord.Size = New System.Drawing.Size(351, 315)
        Me.gbxRecord.TabIndex = 9
        Me.gbxRecord.TabStop = False
        Me.gbxRecord.Text = "Selected Record"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(224, 257)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(38, 13)
        Me.Label26.TabIndex = 82
        Me.Label26.Text = "Living:"
        '
        'cbxLiving
        '
        Me.cbxLiving.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLiving.FormattingEnabled = True
        Me.cbxLiving.Items.AddRange(New Object() {"", "True", "False"})
        Me.cbxLiving.Location = New System.Drawing.Point(268, 254)
        Me.cbxLiving.Name = "cbxLiving"
        Me.cbxLiving.Size = New System.Drawing.Size(74, 21)
        Me.cbxLiving.TabIndex = 15
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(183, 284)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(162, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(6, 284)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(162, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 257)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 13)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Transponder Frequency:"
        '
        'nudFreq
        '
        Me.nudFreq.InterceptArrowKeys = False
        Me.nudFreq.Location = New System.Drawing.Point(135, 255)
        Me.nudFreq.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nudFreq.Name = "nudFreq"
        Me.HelpProvider1.SetShowHelp(Me.nudFreq, False)
        Me.nudFreq.Size = New System.Drawing.Size(66, 20)
        Me.nudFreq.TabIndex = 14
        Me.nudFreq.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(209, 177)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Gender:"
        '
        'cbxGender
        '
        Me.cbxGender.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female", "N/A"})
        Me.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGender.FormattingEnabled = True
        Me.cbxGender.Items.AddRange(New Object() {"Male", "Female", "N/A"})
        Me.cbxGender.Location = New System.Drawing.Point(260, 174)
        Me.cbxGender.Name = "cbxGender"
        Me.cbxGender.Size = New System.Drawing.Size(82, 21)
        Me.cbxGender.TabIndex = 11
        '
        'tbxTribeOwner
        '
        Me.tbxTribeOwner.Location = New System.Drawing.Point(97, 229)
        Me.tbxTribeOwner.Name = "tbxTribeOwner"
        Me.tbxTribeOwner.Size = New System.Drawing.Size(245, 20)
        Me.tbxTribeOwner.TabIndex = 13
        '
        'tbxPersonalOwner
        '
        Me.tbxPersonalOwner.Location = New System.Drawing.Point(97, 201)
        Me.tbxPersonalOwner.Name = "tbxPersonalOwner"
        Me.tbxPersonalOwner.Size = New System.Drawing.Size(245, 20)
        Me.tbxPersonalOwner.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 232)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Tribe Owner:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 204)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Personal Owner:"
        '
        'nudStartLevel
        '
        Me.nudStartLevel.DecimalPlaces = 1
        Me.nudStartLevel.InterceptArrowKeys = False
        Me.nudStartLevel.Location = New System.Drawing.Point(97, 175)
        Me.nudStartLevel.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudStartLevel.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nudStartLevel.Name = "nudStartLevel"
        Me.HelpProvider1.SetShowHelp(Me.nudStartLevel, False)
        Me.nudStartLevel.Size = New System.Drawing.Size(82, 20)
        Me.nudStartLevel.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 177)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Starting Level:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(210, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Torpor:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(210, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Speed:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(204, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Damage:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(43, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Stamina:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(45, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Oxygen:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Food:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(210, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Weight:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Health:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Species:"
        '
        'cbxSpecies
        '
        Me.cbxSpecies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbxSpecies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSpecies.FormattingEnabled = True
        Me.cbxSpecies.Location = New System.Drawing.Point(97, 44)
        Me.cbxSpecies.Name = "cbxSpecies"
        Me.cbxSpecies.Size = New System.Drawing.Size(245, 21)
        Me.cbxSpecies.TabIndex = 1
        '
        'nudTorpor
        '
        Me.nudTorpor.DecimalPlaces = 1
        Me.nudTorpor.InterceptArrowKeys = False
        Me.nudTorpor.Location = New System.Drawing.Point(260, 149)
        Me.nudTorpor.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudTorpor.Name = "nudTorpor"
        Me.HelpProvider1.SetShowHelp(Me.nudTorpor, False)
        Me.nudTorpor.Size = New System.Drawing.Size(82, 20)
        Me.nudTorpor.TabIndex = 9
        '
        'nudDmg
        '
        Me.nudDmg.DecimalPlaces = 2
        Me.nudDmg.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nudDmg.InterceptArrowKeys = False
        Me.nudDmg.Location = New System.Drawing.Point(260, 97)
        Me.nudDmg.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudDmg.Name = "nudDmg"
        Me.HelpProvider1.SetShowHelp(Me.nudDmg, False)
        Me.nudDmg.Size = New System.Drawing.Size(82, 20)
        Me.nudDmg.TabIndex = 7
        Me.nudDmg.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudSpeed
        '
        Me.nudSpeed.DecimalPlaces = 2
        Me.nudSpeed.InterceptArrowKeys = False
        Me.nudSpeed.Location = New System.Drawing.Point(260, 123)
        Me.nudSpeed.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudSpeed.Name = "nudSpeed"
        Me.HelpProvider1.SetShowHelp(Me.nudSpeed, False)
        Me.nudSpeed.Size = New System.Drawing.Size(82, 20)
        Me.nudSpeed.TabIndex = 8
        Me.nudSpeed.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudFood
        '
        Me.nudFood.DecimalPlaces = 1
        Me.nudFood.InterceptArrowKeys = False
        Me.nudFood.Location = New System.Drawing.Point(97, 149)
        Me.nudFood.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudFood.Name = "nudFood"
        Me.HelpProvider1.SetShowHelp(Me.nudFood, False)
        Me.nudFood.Size = New System.Drawing.Size(82, 20)
        Me.nudFood.TabIndex = 5
        '
        'nudOxygen
        '
        Me.nudOxygen.DecimalPlaces = 1
        Me.nudOxygen.InterceptArrowKeys = False
        Me.nudOxygen.Location = New System.Drawing.Point(97, 123)
        Me.nudOxygen.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudOxygen.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nudOxygen.Name = "nudOxygen"
        Me.HelpProvider1.SetShowHelp(Me.nudOxygen, False)
        Me.nudOxygen.Size = New System.Drawing.Size(82, 20)
        Me.nudOxygen.TabIndex = 4
        '
        'nudStam
        '
        Me.nudStam.DecimalPlaces = 1
        Me.nudStam.InterceptArrowKeys = False
        Me.nudStam.Location = New System.Drawing.Point(97, 97)
        Me.nudStam.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudStam.Name = "nudStam"
        Me.HelpProvider1.SetShowHelp(Me.nudStam, False)
        Me.nudStam.Size = New System.Drawing.Size(82, 20)
        Me.nudStam.TabIndex = 3
        '
        'nudWeight
        '
        Me.nudWeight.DecimalPlaces = 1
        Me.nudWeight.InterceptArrowKeys = False
        Me.nudWeight.Location = New System.Drawing.Point(260, 71)
        Me.nudWeight.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudWeight.Name = "nudWeight"
        Me.HelpProvider1.SetShowHelp(Me.nudWeight, False)
        Me.nudWeight.Size = New System.Drawing.Size(82, 20)
        Me.nudWeight.TabIndex = 6
        '
        'nudHealth
        '
        Me.nudHealth.DecimalPlaces = 1
        Me.nudHealth.InterceptArrowKeys = False
        Me.nudHealth.Location = New System.Drawing.Point(97, 71)
        Me.nudHealth.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudHealth.Name = "nudHealth"
        Me.HelpProvider1.SetShowHelp(Me.nudHealth, False)
        Me.nudHealth.Size = New System.Drawing.Size(82, 20)
        Me.nudHealth.TabIndex = 2
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(97, 15)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(245, 20)
        Me.tbxName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.mnuHelp, Me.mnuSettings})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(971, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'nudHealthLow
        '
        Me.nudHealthLow.InterceptArrowKeys = False
        Me.nudHealthLow.Location = New System.Drawing.Point(106, 71)
        Me.nudHealthLow.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudHealthLow.Name = "nudHealthLow"
        Me.HelpProvider1.SetShowHelp(Me.nudHealthLow, False)
        Me.nudHealthLow.Size = New System.Drawing.Size(82, 20)
        Me.nudHealthLow.TabIndex = 2
        '
        'nudHealthHigh
        '
        Me.nudHealthHigh.InterceptArrowKeys = False
        Me.nudHealthHigh.Location = New System.Drawing.Point(220, 71)
        Me.nudHealthHigh.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudHealthHigh.Name = "nudHealthHigh"
        Me.HelpProvider1.SetShowHelp(Me.nudHealthHigh, False)
        Me.nudHealthHigh.Size = New System.Drawing.Size(82, 20)
        Me.nudHealthHigh.TabIndex = 3
        '
        'nudStaminaLow
        '
        Me.nudStaminaLow.InterceptArrowKeys = False
        Me.nudStaminaLow.Location = New System.Drawing.Point(106, 97)
        Me.nudStaminaLow.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudStaminaLow.Name = "nudStaminaLow"
        Me.HelpProvider1.SetShowHelp(Me.nudStaminaLow, False)
        Me.nudStaminaLow.Size = New System.Drawing.Size(82, 20)
        Me.nudStaminaLow.TabIndex = 4
        '
        'nudStaminaHigh
        '
        Me.nudStaminaHigh.InterceptArrowKeys = False
        Me.nudStaminaHigh.Location = New System.Drawing.Point(220, 97)
        Me.nudStaminaHigh.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudStaminaHigh.Name = "nudStaminaHigh"
        Me.HelpProvider1.SetShowHelp(Me.nudStaminaHigh, False)
        Me.nudStaminaHigh.Size = New System.Drawing.Size(82, 20)
        Me.nudStaminaHigh.TabIndex = 5
        '
        'nudOxygenLow
        '
        Me.nudOxygenLow.InterceptArrowKeys = False
        Me.nudOxygenLow.Location = New System.Drawing.Point(106, 123)
        Me.nudOxygenLow.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudOxygenLow.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nudOxygenLow.Name = "nudOxygenLow"
        Me.HelpProvider1.SetShowHelp(Me.nudOxygenLow, False)
        Me.nudOxygenLow.Size = New System.Drawing.Size(82, 20)
        Me.nudOxygenLow.TabIndex = 6
        '
        'nudOxygenHigh
        '
        Me.nudOxygenHigh.InterceptArrowKeys = False
        Me.nudOxygenHigh.Location = New System.Drawing.Point(220, 123)
        Me.nudOxygenHigh.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudOxygenHigh.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nudOxygenHigh.Name = "nudOxygenHigh"
        Me.HelpProvider1.SetShowHelp(Me.nudOxygenHigh, False)
        Me.nudOxygenHigh.Size = New System.Drawing.Size(82, 20)
        Me.nudOxygenHigh.TabIndex = 7
        '
        'nudFoodLow
        '
        Me.nudFoodLow.InterceptArrowKeys = False
        Me.nudFoodLow.Location = New System.Drawing.Point(106, 149)
        Me.nudFoodLow.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudFoodLow.Name = "nudFoodLow"
        Me.HelpProvider1.SetShowHelp(Me.nudFoodLow, False)
        Me.nudFoodLow.Size = New System.Drawing.Size(82, 20)
        Me.nudFoodLow.TabIndex = 8
        '
        'nudFoodHigh
        '
        Me.nudFoodHigh.InterceptArrowKeys = False
        Me.nudFoodHigh.Location = New System.Drawing.Point(220, 149)
        Me.nudFoodHigh.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudFoodHigh.Name = "nudFoodHigh"
        Me.HelpProvider1.SetShowHelp(Me.nudFoodHigh, False)
        Me.nudFoodHigh.Size = New System.Drawing.Size(82, 20)
        Me.nudFoodHigh.TabIndex = 9
        '
        'nudStartLow
        '
        Me.nudStartLow.InterceptArrowKeys = False
        Me.nudStartLow.Location = New System.Drawing.Point(106, 172)
        Me.nudStartLow.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudStartLow.Name = "nudStartLow"
        Me.HelpProvider1.SetShowHelp(Me.nudStartLow, False)
        Me.nudStartLow.Size = New System.Drawing.Size(82, 20)
        Me.nudStartLow.TabIndex = 18
        '
        'nudStartHigh
        '
        Me.nudStartHigh.InterceptArrowKeys = False
        Me.nudStartHigh.Location = New System.Drawing.Point(220, 172)
        Me.nudStartHigh.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudStartHigh.Name = "nudStartHigh"
        Me.HelpProvider1.SetShowHelp(Me.nudStartHigh, False)
        Me.nudStartHigh.Size = New System.Drawing.Size(82, 20)
        Me.nudStartHigh.TabIndex = 19
        '
        'nudWeightLow
        '
        Me.nudWeightLow.InterceptArrowKeys = False
        Me.nudWeightLow.Location = New System.Drawing.Point(378, 71)
        Me.nudWeightLow.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudWeightLow.Name = "nudWeightLow"
        Me.HelpProvider1.SetShowHelp(Me.nudWeightLow, False)
        Me.nudWeightLow.Size = New System.Drawing.Size(82, 20)
        Me.nudWeightLow.TabIndex = 10
        '
        'nudWeightHigh
        '
        Me.nudWeightHigh.InterceptArrowKeys = False
        Me.nudWeightHigh.Location = New System.Drawing.Point(492, 71)
        Me.nudWeightHigh.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudWeightHigh.Name = "nudWeightHigh"
        Me.HelpProvider1.SetShowHelp(Me.nudWeightHigh, False)
        Me.nudWeightHigh.Size = New System.Drawing.Size(82, 20)
        Me.nudWeightHigh.TabIndex = 11
        '
        'nudDmgLow
        '
        Me.nudDmgLow.DecimalPlaces = 2
        Me.nudDmgLow.InterceptArrowKeys = False
        Me.nudDmgLow.Location = New System.Drawing.Point(378, 97)
        Me.nudDmgLow.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudDmgLow.Name = "nudDmgLow"
        Me.HelpProvider1.SetShowHelp(Me.nudDmgLow, False)
        Me.nudDmgLow.Size = New System.Drawing.Size(82, 20)
        Me.nudDmgLow.TabIndex = 12
        Me.nudDmgLow.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudDmgHigh
        '
        Me.nudDmgHigh.DecimalPlaces = 2
        Me.nudDmgHigh.InterceptArrowKeys = False
        Me.nudDmgHigh.Location = New System.Drawing.Point(492, 97)
        Me.nudDmgHigh.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudDmgHigh.Name = "nudDmgHigh"
        Me.HelpProvider1.SetShowHelp(Me.nudDmgHigh, False)
        Me.nudDmgHigh.Size = New System.Drawing.Size(82, 20)
        Me.nudDmgHigh.TabIndex = 13
        Me.nudDmgHigh.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudSpeedLow
        '
        Me.nudSpeedLow.DecimalPlaces = 2
        Me.nudSpeedLow.InterceptArrowKeys = False
        Me.nudSpeedLow.Location = New System.Drawing.Point(378, 123)
        Me.nudSpeedLow.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudSpeedLow.Name = "nudSpeedLow"
        Me.HelpProvider1.SetShowHelp(Me.nudSpeedLow, False)
        Me.nudSpeedLow.Size = New System.Drawing.Size(82, 20)
        Me.nudSpeedLow.TabIndex = 14
        Me.nudSpeedLow.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudSpeedHigh
        '
        Me.nudSpeedHigh.DecimalPlaces = 2
        Me.nudSpeedHigh.InterceptArrowKeys = False
        Me.nudSpeedHigh.Location = New System.Drawing.Point(492, 123)
        Me.nudSpeedHigh.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudSpeedHigh.Name = "nudSpeedHigh"
        Me.HelpProvider1.SetShowHelp(Me.nudSpeedHigh, False)
        Me.nudSpeedHigh.Size = New System.Drawing.Size(82, 20)
        Me.nudSpeedHigh.TabIndex = 15
        Me.nudSpeedHigh.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudTorporLow
        '
        Me.nudTorporLow.InterceptArrowKeys = False
        Me.nudTorporLow.Location = New System.Drawing.Point(378, 149)
        Me.nudTorporLow.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudTorporLow.Name = "nudTorporLow"
        Me.HelpProvider1.SetShowHelp(Me.nudTorporLow, False)
        Me.nudTorporLow.Size = New System.Drawing.Size(82, 20)
        Me.nudTorporLow.TabIndex = 16
        '
        'nudTorporHigh
        '
        Me.nudTorporHigh.InterceptArrowKeys = False
        Me.nudTorporHigh.Location = New System.Drawing.Point(492, 149)
        Me.nudTorporHigh.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudTorporHigh.Name = "nudTorporHigh"
        Me.HelpProvider1.SetShowHelp(Me.nudTorporHigh, False)
        Me.nudTorporHigh.Size = New System.Drawing.Size(82, 20)
        Me.nudTorporHigh.TabIndex = 17
        '
        'nudFreqFilter
        '
        Me.nudFreqFilter.InterceptArrowKeys = False
        Me.nudFreqFilter.Location = New System.Drawing.Point(492, 202)
        Me.nudFreqFilter.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudFreqFilter.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nudFreqFilter.Name = "nudFreqFilter"
        Me.HelpProvider1.SetShowHelp(Me.nudFreqFilter, False)
        Me.nudFreqFilter.Size = New System.Drawing.Size(82, 20)
        Me.nudFreqFilter.TabIndex = 23
        '
        'chbxName
        '
        Me.chbxName.AutoSize = True
        Me.chbxName.Location = New System.Drawing.Point(6, 19)
        Me.chbxName.Name = "chbxName"
        Me.chbxName.Size = New System.Drawing.Size(57, 17)
        Me.chbxName.TabIndex = 25
        Me.chbxName.Text = "Name:"
        Me.chbxName.UseVisualStyleBackColor = True
        '
        'chbxSpecies
        '
        Me.chbxSpecies.AutoSize = True
        Me.chbxSpecies.Location = New System.Drawing.Point(6, 46)
        Me.chbxSpecies.Name = "chbxSpecies"
        Me.chbxSpecies.Size = New System.Drawing.Size(67, 17)
        Me.chbxSpecies.TabIndex = 26
        Me.chbxSpecies.Text = "Species:"
        Me.chbxSpecies.UseVisualStyleBackColor = True
        '
        'chbxStartingLevel
        '
        Me.chbxStartingLevel.AutoSize = True
        Me.chbxStartingLevel.Location = New System.Drawing.Point(6, 173)
        Me.chbxStartingLevel.Name = "chbxStartingLevel"
        Me.chbxStartingLevel.Size = New System.Drawing.Size(94, 17)
        Me.chbxStartingLevel.TabIndex = 35
        Me.chbxStartingLevel.Text = "Starting Level:"
        Me.chbxStartingLevel.UseVisualStyleBackColor = True
        '
        'chbxPersonal
        '
        Me.chbxPersonal.AutoSize = True
        Me.chbxPersonal.Location = New System.Drawing.Point(6, 203)
        Me.chbxPersonal.Name = "chbxPersonal"
        Me.chbxPersonal.Size = New System.Drawing.Size(104, 17)
        Me.chbxPersonal.TabIndex = 37
        Me.chbxPersonal.Text = "Personal Owner:"
        Me.chbxPersonal.UseVisualStyleBackColor = True
        '
        'chbxHealth
        '
        Me.chbxHealth.AutoSize = True
        Me.chbxHealth.Location = New System.Drawing.Point(6, 72)
        Me.chbxHealth.Name = "chbxHealth"
        Me.chbxHealth.Size = New System.Drawing.Size(60, 17)
        Me.chbxHealth.TabIndex = 27
        Me.chbxHealth.Text = "Health:"
        Me.chbxHealth.UseVisualStyleBackColor = True
        '
        'chbxStam
        '
        Me.chbxStam.AutoSize = True
        Me.chbxStam.Location = New System.Drawing.Point(6, 98)
        Me.chbxStam.Name = "chbxStam"
        Me.chbxStam.Size = New System.Drawing.Size(67, 17)
        Me.chbxStam.TabIndex = 28
        Me.chbxStam.Text = "Stamina:"
        Me.chbxStam.UseVisualStyleBackColor = True
        '
        'chbxOxygen
        '
        Me.chbxOxygen.AutoSize = True
        Me.chbxOxygen.Location = New System.Drawing.Point(6, 124)
        Me.chbxOxygen.Name = "chbxOxygen"
        Me.chbxOxygen.Size = New System.Drawing.Size(65, 17)
        Me.chbxOxygen.TabIndex = 29
        Me.chbxOxygen.Text = "Oxygen:"
        Me.chbxOxygen.UseVisualStyleBackColor = True
        '
        'chbxFood
        '
        Me.chbxFood.AutoSize = True
        Me.chbxFood.Location = New System.Drawing.Point(6, 150)
        Me.chbxFood.Name = "chbxFood"
        Me.chbxFood.Size = New System.Drawing.Size(53, 17)
        Me.chbxFood.TabIndex = 30
        Me.chbxFood.Text = "Food:"
        Me.chbxFood.UseVisualStyleBackColor = True
        '
        'chbxTribe
        '
        Me.chbxTribe.AutoSize = True
        Me.chbxTribe.Location = New System.Drawing.Point(6, 231)
        Me.chbxTribe.Name = "chbxTribe"
        Me.chbxTribe.Size = New System.Drawing.Size(87, 17)
        Me.chbxTribe.TabIndex = 38
        Me.chbxTribe.Text = "Tribe Owner:"
        Me.chbxTribe.UseVisualStyleBackColor = True
        '
        'chbxFreq
        '
        Me.chbxFreq.AutoSize = True
        Me.chbxFreq.Location = New System.Drawing.Point(308, 203)
        Me.chbxFreq.Name = "chbxFreq"
        Me.chbxFreq.Size = New System.Drawing.Size(142, 17)
        Me.chbxFreq.TabIndex = 39
        Me.chbxFreq.Text = "Transponder Frequency:"
        Me.chbxFreq.UseVisualStyleBackColor = True
        '
        'tbxNameFilter
        '
        Me.tbxNameFilter.Location = New System.Drawing.Point(106, 18)
        Me.tbxNameFilter.Name = "tbxNameFilter"
        Me.tbxNameFilter.Size = New System.Drawing.Size(196, 20)
        Me.tbxNameFilter.TabIndex = 0
        '
        'cbxSpeciesFilter
        '
        Me.cbxSpeciesFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbxSpeciesFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxSpeciesFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSpeciesFilter.FormattingEnabled = True
        Me.cbxSpeciesFilter.Location = New System.Drawing.Point(106, 44)
        Me.cbxSpeciesFilter.Name = "cbxSpeciesFilter"
        Me.cbxSpeciesFilter.Size = New System.Drawing.Size(196, 21)
        Me.cbxSpeciesFilter.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(194, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(194, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "To"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(194, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "To"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(194, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "To"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(194, 174)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(20, 13)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "To"
        '
        'chbxWeight
        '
        Me.chbxWeight.AutoSize = True
        Me.chbxWeight.Location = New System.Drawing.Point(308, 72)
        Me.chbxWeight.Name = "chbxWeight"
        Me.chbxWeight.Size = New System.Drawing.Size(63, 17)
        Me.chbxWeight.TabIndex = 31
        Me.chbxWeight.Text = "Weight:"
        Me.chbxWeight.UseVisualStyleBackColor = True
        '
        'chbxDmg
        '
        Me.chbxDmg.AutoSize = True
        Me.chbxDmg.Location = New System.Drawing.Point(308, 98)
        Me.chbxDmg.Name = "chbxDmg"
        Me.chbxDmg.Size = New System.Drawing.Size(69, 17)
        Me.chbxDmg.TabIndex = 32
        Me.chbxDmg.Text = "Damage:"
        Me.chbxDmg.UseVisualStyleBackColor = True
        '
        'chbxSpeed
        '
        Me.chbxSpeed.AutoSize = True
        Me.chbxSpeed.Location = New System.Drawing.Point(308, 124)
        Me.chbxSpeed.Name = "chbxSpeed"
        Me.chbxSpeed.Size = New System.Drawing.Size(60, 17)
        Me.chbxSpeed.TabIndex = 33
        Me.chbxSpeed.Text = "Speed:"
        Me.chbxSpeed.UseVisualStyleBackColor = True
        '
        'chbxTorpor
        '
        Me.chbxTorpor.AutoSize = True
        Me.chbxTorpor.Location = New System.Drawing.Point(308, 150)
        Me.chbxTorpor.Name = "chbxTorpor"
        Me.chbxTorpor.Size = New System.Drawing.Size(60, 17)
        Me.chbxTorpor.TabIndex = 34
        Me.chbxTorpor.Text = "Torpor:"
        Me.chbxTorpor.UseVisualStyleBackColor = True
        '
        'chbxGender
        '
        Me.chbxGender.AutoSize = True
        Me.chbxGender.Location = New System.Drawing.Point(308, 173)
        Me.chbxGender.Name = "chbxGender"
        Me.chbxGender.Size = New System.Drawing.Size(64, 17)
        Me.chbxGender.TabIndex = 36
        Me.chbxGender.Text = "Gender:"
        Me.chbxGender.UseVisualStyleBackColor = True
        '
        'cbxGenderFilter
        '
        Me.cbxGenderFilter.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female", "N/A"})
        Me.cbxGenderFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGenderFilter.FormattingEnabled = True
        Me.cbxGenderFilter.Items.AddRange(New Object() {"Male", "Female", "N/A"})
        Me.cbxGenderFilter.Location = New System.Drawing.Point(378, 171)
        Me.cbxGenderFilter.Name = "cbxGenderFilter"
        Me.cbxGenderFilter.Size = New System.Drawing.Size(82, 21)
        Me.cbxGenderFilter.TabIndex = 20
        '
        'tbxPersonalOwnerFilter
        '
        Me.tbxPersonalOwnerFilter.Location = New System.Drawing.Point(106, 201)
        Me.tbxPersonalOwnerFilter.Name = "tbxPersonalOwnerFilter"
        Me.tbxPersonalOwnerFilter.Size = New System.Drawing.Size(196, 20)
        Me.tbxPersonalOwnerFilter.TabIndex = 21
        '
        'tbxTribeOwnerFilter
        '
        Me.tbxTribeOwnerFilter.Location = New System.Drawing.Point(106, 227)
        Me.tbxTribeOwnerFilter.Name = "tbxTribeOwnerFilter"
        Me.tbxTribeOwnerFilter.Size = New System.Drawing.Size(196, 20)
        Me.tbxTribeOwnerFilter.TabIndex = 22
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(466, 73)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(20, 13)
        Me.Label24.TabIndex = 66
        Me.Label24.Text = "To"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(466, 99)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(20, 13)
        Me.Label23.TabIndex = 69
        Me.Label23.Text = "To"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(466, 125)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(20, 13)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "To"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(466, 151)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(20, 13)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "To"
        '
        'btnUpdateFilter
        '
        Me.btnUpdateFilter.Location = New System.Drawing.Point(304, 19)
        Me.btnUpdateFilter.Name = "btnUpdateFilter"
        Me.btnUpdateFilter.Size = New System.Drawing.Size(270, 47)
        Me.btnUpdateFilter.TabIndex = 77
        Me.btnUpdateFilter.Text = "Update Filter"
        Me.btnUpdateFilter.UseVisualStyleBackColor = True
        '
        'gbxFilter
        '
        Me.gbxFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbxFilter.Controls.Add(Me.cbxLivingFilter)
        Me.gbxFilter.Controls.Add(Me.chbxLiving)
        Me.gbxFilter.Controls.Add(Me.btnUpdateFilter)
        Me.gbxFilter.Controls.Add(Me.nudFreqFilter)
        Me.gbxFilter.Controls.Add(Me.Label21)
        Me.gbxFilter.Controls.Add(Me.nudTorporHigh)
        Me.gbxFilter.Controls.Add(Me.nudTorporLow)
        Me.gbxFilter.Controls.Add(Me.Label22)
        Me.gbxFilter.Controls.Add(Me.nudSpeedHigh)
        Me.gbxFilter.Controls.Add(Me.nudSpeedLow)
        Me.gbxFilter.Controls.Add(Me.Label23)
        Me.gbxFilter.Controls.Add(Me.nudDmgHigh)
        Me.gbxFilter.Controls.Add(Me.nudDmgLow)
        Me.gbxFilter.Controls.Add(Me.Label24)
        Me.gbxFilter.Controls.Add(Me.nudWeightHigh)
        Me.gbxFilter.Controls.Add(Me.nudWeightLow)
        Me.gbxFilter.Controls.Add(Me.tbxTribeOwnerFilter)
        Me.gbxFilter.Controls.Add(Me.tbxPersonalOwnerFilter)
        Me.gbxFilter.Controls.Add(Me.cbxGenderFilter)
        Me.gbxFilter.Controls.Add(Me.chbxGender)
        Me.gbxFilter.Controls.Add(Me.chbxTorpor)
        Me.gbxFilter.Controls.Add(Me.chbxSpeed)
        Me.gbxFilter.Controls.Add(Me.chbxDmg)
        Me.gbxFilter.Controls.Add(Me.chbxWeight)
        Me.gbxFilter.Controls.Add(Me.Label20)
        Me.gbxFilter.Controls.Add(Me.nudStartHigh)
        Me.gbxFilter.Controls.Add(Me.nudStartLow)
        Me.gbxFilter.Controls.Add(Me.Label8)
        Me.gbxFilter.Controls.Add(Me.nudFoodHigh)
        Me.gbxFilter.Controls.Add(Me.nudFoodLow)
        Me.gbxFilter.Controls.Add(Me.Label7)
        Me.gbxFilter.Controls.Add(Me.nudOxygenHigh)
        Me.gbxFilter.Controls.Add(Me.nudOxygenLow)
        Me.gbxFilter.Controls.Add(Me.Label6)
        Me.gbxFilter.Controls.Add(Me.nudStaminaHigh)
        Me.gbxFilter.Controls.Add(Me.nudStaminaLow)
        Me.gbxFilter.Controls.Add(Me.Label4)
        Me.gbxFilter.Controls.Add(Me.nudHealthHigh)
        Me.gbxFilter.Controls.Add(Me.nudHealthLow)
        Me.gbxFilter.Controls.Add(Me.cbxSpeciesFilter)
        Me.gbxFilter.Controls.Add(Me.tbxNameFilter)
        Me.gbxFilter.Controls.Add(Me.chbxFreq)
        Me.gbxFilter.Controls.Add(Me.chbxTribe)
        Me.gbxFilter.Controls.Add(Me.chbxFood)
        Me.gbxFilter.Controls.Add(Me.chbxOxygen)
        Me.gbxFilter.Controls.Add(Me.chbxStam)
        Me.gbxFilter.Controls.Add(Me.chbxHealth)
        Me.gbxFilter.Controls.Add(Me.chbxPersonal)
        Me.gbxFilter.Controls.Add(Me.chbxStartingLevel)
        Me.gbxFilter.Controls.Add(Me.chbxSpecies)
        Me.gbxFilter.Controls.Add(Me.chbxName)
        Me.gbxFilter.Location = New System.Drawing.Point(375, 285)
        Me.gbxFilter.Name = "gbxFilter"
        Me.gbxFilter.Size = New System.Drawing.Size(584, 258)
        Me.gbxFilter.TabIndex = 10
        Me.gbxFilter.TabStop = False
        Me.gbxFilter.Text = "Filter Records"
        '
        'cbxLivingFilter
        '
        Me.cbxLivingFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLivingFilter.FormattingEnabled = True
        Me.cbxLivingFilter.Items.AddRange(New Object() {"", "True", "False"})
        Me.cbxLivingFilter.Location = New System.Drawing.Point(371, 226)
        Me.cbxLivingFilter.Name = "cbxLivingFilter"
        Me.cbxLivingFilter.Size = New System.Drawing.Size(89, 21)
        Me.cbxLivingFilter.TabIndex = 24
        '
        'chbxLiving
        '
        Me.chbxLiving.AutoSize = True
        Me.chbxLiving.Location = New System.Drawing.Point(308, 229)
        Me.chbxLiving.Name = "chbxLiving"
        Me.chbxLiving.Size = New System.Drawing.Size(57, 17)
        Me.chbxLiving.TabIndex = 40
        Me.chbxLiving.Text = "Living:"
        Me.chbxLiving.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(381, 550)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(225, 13)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Notes: values set to -1 represent NULL values"
        '
        'frmAssets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 605)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.gbxFilter)
        Me.Controls.Add(Me.gbxRecord)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(986, 643)
        Me.Name = "frmAssets"
        Me.Text = "Dino Tracking"
        CType(Me.dgvDinos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxRecord.ResumeLayout(False)
        Me.gbxRecord.PerformLayout()
        CType(Me.nudFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTorpor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDmg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOxygen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHealth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.nudHealthLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHealthHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStaminaLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStaminaHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOxygenLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOxygenHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFoodLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFoodHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWeightLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWeightHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDmgLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDmgHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSpeedLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSpeedHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTorporLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTorporHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFreqFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxFilter.ResumeLayout(False)
        Me.gbxFilter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDinos As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbxRecord As GroupBox
    Friend WithEvents tbxName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSettings As ToolStripMenuItem
    Friend WithEvents btnRefresh As Button
    Friend WithEvents tbxTribeOwner As TextBox
    Friend WithEvents tbxPersonalOwner As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents nudStartLevel As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxSpecies As ComboBox
    Friend WithEvents nudTorpor As NumericUpDown
    Friend WithEvents nudDmg As NumericUpDown
    Friend WithEvents nudSpeed As NumericUpDown
    Friend WithEvents nudFood As NumericUpDown
    Friend WithEvents nudOxygen As NumericUpDown
    Friend WithEvents nudStam As NumericUpDown
    Friend WithEvents nudWeight As NumericUpDown
    Friend WithEvents nudHealth As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents cbxGender As ComboBox
    Friend WithEvents chbxFilter As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents nudFreq As NumericUpDown
    Friend WithEvents chbxName As CheckBox
    Friend WithEvents chbxSpecies As CheckBox
    Friend WithEvents chbxStartingLevel As CheckBox
    Friend WithEvents chbxPersonal As CheckBox
    Friend WithEvents chbxHealth As CheckBox
    Friend WithEvents chbxStam As CheckBox
    Friend WithEvents chbxOxygen As CheckBox
    Friend WithEvents chbxFood As CheckBox
    Friend WithEvents chbxTribe As CheckBox
    Friend WithEvents chbxFreq As CheckBox
    Friend WithEvents tbxNameFilter As TextBox
    Friend WithEvents cbxSpeciesFilter As ComboBox
    Friend WithEvents nudHealthLow As NumericUpDown
    Friend WithEvents nudHealthHigh As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents nudStaminaLow As NumericUpDown
    Friend WithEvents nudStaminaHigh As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents nudOxygenLow As NumericUpDown
    Friend WithEvents nudOxygenHigh As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents nudFoodLow As NumericUpDown
    Friend WithEvents nudFoodHigh As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents nudStartLow As NumericUpDown
    Friend WithEvents nudStartHigh As NumericUpDown
    Friend WithEvents Label20 As Label
    Friend WithEvents chbxWeight As CheckBox
    Friend WithEvents chbxDmg As CheckBox
    Friend WithEvents chbxSpeed As CheckBox
    Friend WithEvents chbxTorpor As CheckBox
    Friend WithEvents chbxGender As CheckBox
    Friend WithEvents cbxGenderFilter As ComboBox
    Friend WithEvents tbxPersonalOwnerFilter As TextBox
    Friend WithEvents tbxTribeOwnerFilter As TextBox
    Friend WithEvents nudWeightLow As NumericUpDown
    Friend WithEvents nudWeightHigh As NumericUpDown
    Friend WithEvents Label24 As Label
    Friend WithEvents nudDmgLow As NumericUpDown
    Friend WithEvents nudDmgHigh As NumericUpDown
    Friend WithEvents Label23 As Label
    Friend WithEvents nudSpeedLow As NumericUpDown
    Friend WithEvents nudSpeedHigh As NumericUpDown
    Friend WithEvents Label22 As Label
    Friend WithEvents nudTorporLow As NumericUpDown
    Friend WithEvents nudTorporHigh As NumericUpDown
    Friend WithEvents Label21 As Label
    Friend WithEvents nudFreqFilter As NumericUpDown
    Friend WithEvents btnUpdateFilter As Button
    Friend WithEvents gbxFilter As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents AboutArkNotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MapNotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DinoTrackingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DinoNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents notesdbGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HealthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaminaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OxygenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightCapacityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DamageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpeedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TorporDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartingLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LivingDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PersonalOwnerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TribeOwnerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransponderFreqDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cbxLivingFilter As ComboBox
    Friend WithEvents chbxLiving As CheckBox
    Friend WithEvents Label26 As Label
    Friend WithEvents cbxLiving As ComboBox
End Class
