﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMSBEdit
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtMSBfile = New System.Windows.Forms.TextBox()
        Me.lblGAFile = New System.Windows.Forms.Label()
        Me.dgvCreatures2 = New System.Windows.Forms.DataGridView()
        Me.tabParts = New System.Windows.Forms.TabControl()
        Me.tabModels = New System.Windows.Forms.TabPage()
        Me.dgvModels = New System.Windows.Forms.DataGridView()
        Me.tabPoints0 = New System.Windows.Forms.TabPage()
        Me.dgvPoints0 = New System.Windows.Forms.DataGridView()
        Me.tabPoints2 = New System.Windows.Forms.TabPage()
        Me.dgvPoints2 = New System.Windows.Forms.DataGridView()
        Me.tabPoints3 = New System.Windows.Forms.TabPage()
        Me.dgvPoints3 = New System.Windows.Forms.DataGridView()
        Me.tabPoints5 = New System.Windows.Forms.TabPage()
        Me.dgvPoints5 = New System.Windows.Forms.DataGridView()
        Me.tabMapPieces0 = New System.Windows.Forms.TabPage()
        Me.dgvMapPieces0 = New System.Windows.Forms.DataGridView()
        Me.tabObjects1 = New System.Windows.Forms.TabPage()
        Me.dgvObjects1 = New System.Windows.Forms.DataGridView()
        Me.tabCreatures2 = New System.Windows.Forms.TabPage()
        Me.tabCreatures4 = New System.Windows.Forms.TabPage()
        Me.dgvCreatures4 = New System.Windows.Forms.DataGridView()
        Me.tabCollision5 = New System.Windows.Forms.TabPage()
        Me.dgvCollision5 = New System.Windows.Forms.DataGridView()
        Me.tabNavimesh8 = New System.Windows.Forms.TabPage()
        Me.dgvNavimesh8 = New System.Windows.Forms.DataGridView()
        Me.tabObjects9 = New System.Windows.Forms.TabPage()
        Me.dgvObjects9 = New System.Windows.Forms.DataGridView()
        Me.tabCreatures10 = New System.Windows.Forms.TabPage()
        Me.dgvCreatures10 = New System.Windows.Forms.DataGridView()
        Me.tabCollision11 = New System.Windows.Forms.TabPage()
        Me.dgvCollision11 = New System.Windows.Forms.DataGridView()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.ChkUpdatePhysIndices = New System.Windows.Forms.CheckBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnMoveUp = New System.Windows.Forms.Button()
        Me.btnMoveDown = New System.Windows.Forms.Button()
        CType(Me.dgvCreatures2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabParts.SuspendLayout()
        Me.tabModels.SuspendLayout()
        CType(Me.dgvModels, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPoints0.SuspendLayout()
        CType(Me.dgvPoints0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPoints2.SuspendLayout()
        CType(Me.dgvPoints2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPoints3.SuspendLayout()
        CType(Me.dgvPoints3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPoints5.SuspendLayout()
        CType(Me.dgvPoints5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMapPieces0.SuspendLayout()
        CType(Me.dgvMapPieces0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabObjects1.SuspendLayout()
        CType(Me.dgvObjects1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCreatures2.SuspendLayout()
        Me.tabCreatures4.SuspendLayout()
        CType(Me.dgvCreatures4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCollision5.SuspendLayout()
        CType(Me.dgvCollision5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNavimesh8.SuspendLayout()
        CType(Me.dgvNavimesh8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabObjects9.SuspendLayout()
        CType(Me.dgvObjects9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCreatures10.SuspendLayout()
        CType(Me.dgvCreatures10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCollision11.SuspendLayout()
        CType(Me.dgvCollision11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(743, 40)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(665, 40)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 34
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'txtMSBfile
        '
        Me.txtMSBfile.AllowDrop = True
        Me.txtMSBfile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMSBfile.Location = New System.Drawing.Point(46, 14)
        Me.txtMSBfile.Name = "txtMSBfile"
        Me.txtMSBfile.Size = New System.Drawing.Size(691, 20)
        Me.txtMSBfile.TabIndex = 31
        '
        'lblGAFile
        '
        Me.lblGAFile.AutoSize = True
        Me.lblGAFile.Location = New System.Drawing.Point(14, 17)
        Me.lblGAFile.Name = "lblGAFile"
        Me.lblGAFile.Size = New System.Drawing.Size(26, 13)
        Me.lblGAFile.TabIndex = 33
        Me.lblGAFile.Text = "File:"
        '
        'dgvCreatures2
        '
        Me.dgvCreatures2.AllowUserToDeleteRows = False
        Me.dgvCreatures2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCreatures2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCreatures2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCreatures2.Location = New System.Drawing.Point(6, 6)
        Me.dgvCreatures2.Name = "dgvCreatures2"
        Me.dgvCreatures2.Size = New System.Drawing.Size(790, 640)
        Me.dgvCreatures2.TabIndex = 37
        '
        'tabParts
        '
        Me.tabParts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabParts.Controls.Add(Me.tabModels)
        Me.tabParts.Controls.Add(Me.tabPoints0)
        Me.tabParts.Controls.Add(Me.tabPoints2)
        Me.tabParts.Controls.Add(Me.tabPoints3)
        Me.tabParts.Controls.Add(Me.tabPoints5)
        Me.tabParts.Controls.Add(Me.tabMapPieces0)
        Me.tabParts.Controls.Add(Me.tabObjects1)
        Me.tabParts.Controls.Add(Me.tabCreatures2)
        Me.tabParts.Controls.Add(Me.tabCreatures4)
        Me.tabParts.Controls.Add(Me.tabCollision5)
        Me.tabParts.Controls.Add(Me.tabNavimesh8)
        Me.tabParts.Controls.Add(Me.tabObjects9)
        Me.tabParts.Controls.Add(Me.tabCreatures10)
        Me.tabParts.Controls.Add(Me.tabCollision11)
        Me.tabParts.Location = New System.Drawing.Point(12, 69)
        Me.tabParts.Name = "tabParts"
        Me.tabParts.SelectedIndex = 0
        Me.tabParts.Size = New System.Drawing.Size(810, 678)
        Me.tabParts.TabIndex = 38
        '
        'tabModels
        '
        Me.tabModels.Controls.Add(Me.dgvModels)
        Me.tabModels.Location = New System.Drawing.Point(4, 22)
        Me.tabModels.Name = "tabModels"
        Me.tabModels.Size = New System.Drawing.Size(802, 652)
        Me.tabModels.TabIndex = 2
        Me.tabModels.Text = "Models"
        Me.tabModels.UseVisualStyleBackColor = True
        '
        'dgvModels
        '
        Me.dgvModels.AllowUserToDeleteRows = False
        Me.dgvModels.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvModels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModels.Location = New System.Drawing.Point(6, 6)
        Me.dgvModels.Name = "dgvModels"
        Me.dgvModels.RowHeadersWidth = 60
        Me.dgvModels.Size = New System.Drawing.Size(790, 640)
        Me.dgvModels.TabIndex = 38
        '
        'tabPoints0
        '
        Me.tabPoints0.Controls.Add(Me.dgvPoints0)
        Me.tabPoints0.Location = New System.Drawing.Point(4, 22)
        Me.tabPoints0.Name = "tabPoints0"
        Me.tabPoints0.Size = New System.Drawing.Size(802, 652)
        Me.tabPoints0.TabIndex = 0
        Me.tabPoints0.Text = "Points (0)"
        Me.tabPoints0.UseVisualStyleBackColor = True
        '
        'dgvPoints0
        '
        Me.dgvPoints0.AllowUserToDeleteRows = False
        Me.dgvPoints0.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPoints0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPoints0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPoints0.Location = New System.Drawing.Point(6, 6)
        Me.dgvPoints0.Name = "dgvPoints0"
        Me.dgvPoints0.Size = New System.Drawing.Size(790, 640)
        Me.dgvPoints0.TabIndex = 39
        '
        'tabPoints2
        '
        Me.tabPoints2.Controls.Add(Me.dgvPoints2)
        Me.tabPoints2.Location = New System.Drawing.Point(4, 22)
        Me.tabPoints2.Name = "tabPoints2"
        Me.tabPoints2.Size = New System.Drawing.Size(802, 652)
        Me.tabPoints2.TabIndex = 12
        Me.tabPoints2.Text = "Points (2)"
        Me.tabPoints2.UseVisualStyleBackColor = True
        '
        'dgvPoints2
        '
        Me.dgvPoints2.AllowUserToDeleteRows = False
        Me.dgvPoints2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPoints2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPoints2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPoints2.Location = New System.Drawing.Point(6, 6)
        Me.dgvPoints2.Name = "dgvPoints2"
        Me.dgvPoints2.Size = New System.Drawing.Size(790, 640)
        Me.dgvPoints2.TabIndex = 40
        '
        'tabPoints3
        '
        Me.tabPoints3.Controls.Add(Me.dgvPoints3)
        Me.tabPoints3.Location = New System.Drawing.Point(4, 22)
        Me.tabPoints3.Name = "tabPoints3"
        Me.tabPoints3.Size = New System.Drawing.Size(802, 652)
        Me.tabPoints3.TabIndex = 13
        Me.tabPoints3.Text = "Points (3)"
        Me.tabPoints3.UseVisualStyleBackColor = True
        '
        'dgvPoints3
        '
        Me.dgvPoints3.AllowUserToDeleteRows = False
        Me.dgvPoints3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPoints3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPoints3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPoints3.Location = New System.Drawing.Point(6, 6)
        Me.dgvPoints3.Name = "dgvPoints3"
        Me.dgvPoints3.Size = New System.Drawing.Size(790, 640)
        Me.dgvPoints3.TabIndex = 40
        '
        'tabPoints5
        '
        Me.tabPoints5.Controls.Add(Me.dgvPoints5)
        Me.tabPoints5.Location = New System.Drawing.Point(4, 22)
        Me.tabPoints5.Name = "tabPoints5"
        Me.tabPoints5.Size = New System.Drawing.Size(802, 652)
        Me.tabPoints5.TabIndex = 14
        Me.tabPoints5.Text = "Points (5)"
        Me.tabPoints5.UseVisualStyleBackColor = True
        '
        'dgvPoints5
        '
        Me.dgvPoints5.AllowUserToDeleteRows = False
        Me.dgvPoints5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPoints5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPoints5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPoints5.Location = New System.Drawing.Point(6, 6)
        Me.dgvPoints5.Name = "dgvPoints5"
        Me.dgvPoints5.Size = New System.Drawing.Size(790, 640)
        Me.dgvPoints5.TabIndex = 40
        '
        'tabMapPieces0
        '
        Me.tabMapPieces0.Controls.Add(Me.dgvMapPieces0)
        Me.tabMapPieces0.Location = New System.Drawing.Point(4, 22)
        Me.tabMapPieces0.Name = "tabMapPieces0"
        Me.tabMapPieces0.Size = New System.Drawing.Size(802, 652)
        Me.tabMapPieces0.TabIndex = 4
        Me.tabMapPieces0.Text = "Map Pieces (0)"
        Me.tabMapPieces0.UseVisualStyleBackColor = True
        '
        'dgvMapPieces0
        '
        Me.dgvMapPieces0.AllowUserToDeleteRows = False
        Me.dgvMapPieces0.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMapPieces0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMapPieces0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMapPieces0.Location = New System.Drawing.Point(6, 6)
        Me.dgvMapPieces0.Name = "dgvMapPieces0"
        Me.dgvMapPieces0.Size = New System.Drawing.Size(790, 640)
        Me.dgvMapPieces0.TabIndex = 38
        '
        'tabObjects1
        '
        Me.tabObjects1.Controls.Add(Me.dgvObjects1)
        Me.tabObjects1.Location = New System.Drawing.Point(4, 22)
        Me.tabObjects1.Name = "tabObjects1"
        Me.tabObjects1.Size = New System.Drawing.Size(802, 652)
        Me.tabObjects1.TabIndex = 1
        Me.tabObjects1.Text = "Objects (1)"
        Me.tabObjects1.UseVisualStyleBackColor = True
        '
        'dgvObjects1
        '
        Me.dgvObjects1.AllowUserToDeleteRows = False
        Me.dgvObjects1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvObjects1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvObjects1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvObjects1.Location = New System.Drawing.Point(6, 6)
        Me.dgvObjects1.Name = "dgvObjects1"
        Me.dgvObjects1.Size = New System.Drawing.Size(790, 640)
        Me.dgvObjects1.TabIndex = 38
        '
        'tabCreatures2
        '
        Me.tabCreatures2.Controls.Add(Me.dgvCreatures2)
        Me.tabCreatures2.Location = New System.Drawing.Point(4, 22)
        Me.tabCreatures2.Name = "tabCreatures2"
        Me.tabCreatures2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCreatures2.Size = New System.Drawing.Size(802, 652)
        Me.tabCreatures2.TabIndex = 0
        Me.tabCreatures2.Text = "Creatures (2)"
        Me.tabCreatures2.UseVisualStyleBackColor = True
        '
        'tabCreatures4
        '
        Me.tabCreatures4.Controls.Add(Me.dgvCreatures4)
        Me.tabCreatures4.Location = New System.Drawing.Point(4, 22)
        Me.tabCreatures4.Name = "tabCreatures4"
        Me.tabCreatures4.Size = New System.Drawing.Size(802, 652)
        Me.tabCreatures4.TabIndex = 9
        Me.tabCreatures4.Text = "Creatures (4)"
        Me.tabCreatures4.UseVisualStyleBackColor = True
        '
        'dgvCreatures4
        '
        Me.dgvCreatures4.AllowUserToDeleteRows = False
        Me.dgvCreatures4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCreatures4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCreatures4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCreatures4.Location = New System.Drawing.Point(6, 6)
        Me.dgvCreatures4.Name = "dgvCreatures4"
        Me.dgvCreatures4.Size = New System.Drawing.Size(790, 640)
        Me.dgvCreatures4.TabIndex = 38
        '
        'tabCollision5
        '
        Me.tabCollision5.Controls.Add(Me.dgvCollision5)
        Me.tabCollision5.Location = New System.Drawing.Point(4, 22)
        Me.tabCollision5.Name = "tabCollision5"
        Me.tabCollision5.Size = New System.Drawing.Size(802, 652)
        Me.tabCollision5.TabIndex = 6
        Me.tabCollision5.Text = "Collision (5)"
        Me.tabCollision5.UseVisualStyleBackColor = True
        '
        'dgvCollision5
        '
        Me.dgvCollision5.AllowUserToDeleteRows = False
        Me.dgvCollision5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCollision5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCollision5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCollision5.Location = New System.Drawing.Point(6, 6)
        Me.dgvCollision5.Name = "dgvCollision5"
        Me.dgvCollision5.Size = New System.Drawing.Size(790, 640)
        Me.dgvCollision5.TabIndex = 39
        '
        'tabNavimesh8
        '
        Me.tabNavimesh8.Controls.Add(Me.dgvNavimesh8)
        Me.tabNavimesh8.Location = New System.Drawing.Point(4, 22)
        Me.tabNavimesh8.Name = "tabNavimesh8"
        Me.tabNavimesh8.Size = New System.Drawing.Size(802, 652)
        Me.tabNavimesh8.TabIndex = 8
        Me.tabNavimesh8.Text = "Navimesh (8)"
        Me.tabNavimesh8.UseVisualStyleBackColor = True
        '
        'dgvNavimesh8
        '
        Me.dgvNavimesh8.AllowUserToDeleteRows = False
        Me.dgvNavimesh8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvNavimesh8.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvNavimesh8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNavimesh8.Location = New System.Drawing.Point(6, 6)
        Me.dgvNavimesh8.Name = "dgvNavimesh8"
        Me.dgvNavimesh8.Size = New System.Drawing.Size(790, 640)
        Me.dgvNavimesh8.TabIndex = 39
        '
        'tabObjects9
        '
        Me.tabObjects9.Controls.Add(Me.dgvObjects9)
        Me.tabObjects9.Location = New System.Drawing.Point(4, 22)
        Me.tabObjects9.Name = "tabObjects9"
        Me.tabObjects9.Size = New System.Drawing.Size(802, 652)
        Me.tabObjects9.TabIndex = 11
        Me.tabObjects9.Text = "Objects (9)"
        Me.tabObjects9.UseVisualStyleBackColor = True
        '
        'dgvObjects9
        '
        Me.dgvObjects9.AllowUserToDeleteRows = False
        Me.dgvObjects9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvObjects9.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvObjects9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvObjects9.Location = New System.Drawing.Point(6, 6)
        Me.dgvObjects9.Name = "dgvObjects9"
        Me.dgvObjects9.Size = New System.Drawing.Size(790, 640)
        Me.dgvObjects9.TabIndex = 39
        '
        'tabCreatures10
        '
        Me.tabCreatures10.Controls.Add(Me.dgvCreatures10)
        Me.tabCreatures10.Location = New System.Drawing.Point(4, 22)
        Me.tabCreatures10.Name = "tabCreatures10"
        Me.tabCreatures10.Size = New System.Drawing.Size(802, 652)
        Me.tabCreatures10.TabIndex = 10
        Me.tabCreatures10.Text = "Creatures (10)"
        Me.tabCreatures10.UseVisualStyleBackColor = True
        '
        'dgvCreatures10
        '
        Me.dgvCreatures10.AllowUserToDeleteRows = False
        Me.dgvCreatures10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCreatures10.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCreatures10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCreatures10.Location = New System.Drawing.Point(6, 6)
        Me.dgvCreatures10.Name = "dgvCreatures10"
        Me.dgvCreatures10.Size = New System.Drawing.Size(790, 640)
        Me.dgvCreatures10.TabIndex = 38
        '
        'tabCollision11
        '
        Me.tabCollision11.Controls.Add(Me.dgvCollision11)
        Me.tabCollision11.Location = New System.Drawing.Point(4, 22)
        Me.tabCollision11.Name = "tabCollision11"
        Me.tabCollision11.Size = New System.Drawing.Size(802, 652)
        Me.tabCollision11.TabIndex = 3
        Me.tabCollision11.Text = "Collision (11)"
        Me.tabCollision11.UseVisualStyleBackColor = True
        '
        'dgvCollision11
        '
        Me.dgvCollision11.AllowUserToDeleteRows = False
        Me.dgvCollision11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCollision11.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCollision11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCollision11.Location = New System.Drawing.Point(6, 6)
        Me.dgvCollision11.Name = "dgvCollision11"
        Me.dgvCollision11.Size = New System.Drawing.Size(790, 640)
        Me.dgvCollision11.TabIndex = 38
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(12, 40)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 39
        Me.btnCopy.Text = "Copy Entry"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(743, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 40
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'ChkUpdatePhysIndices
        '
        Me.ChkUpdatePhysIndices.AutoSize = True
        Me.ChkUpdatePhysIndices.Checked = True
        Me.ChkUpdatePhysIndices.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkUpdatePhysIndices.Location = New System.Drawing.Point(366, 46)
        Me.ChkUpdatePhysIndices.Name = "ChkUpdatePhysIndices"
        Me.ChkUpdatePhysIndices.Size = New System.Drawing.Size(124, 17)
        Me.ChkUpdatePhysIndices.TabIndex = 42
        Me.ChkUpdatePhysIndices.Text = "Update Phys Indices"
        Me.ChkUpdatePhysIndices.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(93, 40)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 43
        Me.btnDelete.Text = "Delete Entry"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Location = New System.Drawing.Point(186, 40)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveUp.TabIndex = 44
        Me.btnMoveUp.Text = "Move Up"
        Me.btnMoveUp.UseVisualStyleBackColor = True
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Location = New System.Drawing.Point(267, 40)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveDown.TabIndex = 45
        Me.btnMoveDown.Text = "Move Down"
        Me.btnMoveDown.UseVisualStyleBackColor = True
        '
        'frmMSBEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 761)
        Me.Controls.Add(Me.btnMoveDown)
        Me.Controls.Add(Me.btnMoveUp)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.ChkUpdatePhysIndices)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.tabParts)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.txtMSBfile)
        Me.Controls.Add(Me.lblGAFile)
        Me.Name = "frmMSBEdit"
        Me.Text = "Wulf's MSB Editor 2016-07-31"
        CType(Me.dgvCreatures2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabParts.ResumeLayout(False)
        Me.tabModels.ResumeLayout(False)
        CType(Me.dgvModels, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPoints0.ResumeLayout(False)
        CType(Me.dgvPoints0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPoints2.ResumeLayout(False)
        CType(Me.dgvPoints2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPoints3.ResumeLayout(False)
        CType(Me.dgvPoints3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPoints5.ResumeLayout(False)
        CType(Me.dgvPoints5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMapPieces0.ResumeLayout(False)
        CType(Me.dgvMapPieces0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabObjects1.ResumeLayout(False)
        CType(Me.dgvObjects1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCreatures2.ResumeLayout(False)
        Me.tabCreatures4.ResumeLayout(False)
        CType(Me.dgvCreatures4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCollision5.ResumeLayout(False)
        CType(Me.dgvCollision5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNavimesh8.ResumeLayout(False)
        CType(Me.dgvNavimesh8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabObjects9.ResumeLayout(False)
        CType(Me.dgvObjects9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCreatures10.ResumeLayout(False)
        CType(Me.dgvCreatures10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCollision11.ResumeLayout(False)
        CType(Me.dgvCollision11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents txtMSBfile As System.Windows.Forms.TextBox
    Friend WithEvents lblGAFile As System.Windows.Forms.Label
    Friend WithEvents dgvCreatures2 As System.Windows.Forms.DataGridView
    Friend WithEvents tabParts As System.Windows.Forms.TabControl
    Friend WithEvents tabCreatures2 As System.Windows.Forms.TabPage
    Friend WithEvents tabObjects1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvObjects1 As System.Windows.Forms.DataGridView
    Friend WithEvents tabModels As System.Windows.Forms.TabPage
    Friend WithEvents dgvModels As System.Windows.Forms.DataGridView
    Friend WithEvents tabCollision11 As System.Windows.Forms.TabPage
    Friend WithEvents dgvCollision11 As System.Windows.Forms.DataGridView
    Friend WithEvents tabMapPieces0 As System.Windows.Forms.TabPage
    Friend WithEvents dgvMapPieces0 As System.Windows.Forms.DataGridView
    Friend WithEvents tabCollision5 As System.Windows.Forms.TabPage
    Friend WithEvents dgvCollision5 As System.Windows.Forms.DataGridView
    Friend WithEvents tabNavimesh8 As TabPage
    Friend WithEvents dgvNavimesh8 As DataGridView
    Friend WithEvents tabCreatures4 As TabPage
    Friend WithEvents dgvCreatures4 As DataGridView
    Friend WithEvents tabObjects9 As TabPage
    Friend WithEvents tabCreatures10 As TabPage
    Friend WithEvents dgvObjects9 As DataGridView
    Friend WithEvents dgvCreatures10 As DataGridView
    Friend WithEvents tabPoints0 As TabPage
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents dgvPoints0 As DataGridView
    Friend WithEvents tabPoints2 As TabPage
    Friend WithEvents tabPoints3 As TabPage
    Friend WithEvents tabPoints5 As TabPage
    Friend WithEvents dgvPoints2 As DataGridView
    Friend WithEvents dgvPoints3 As DataGridView
    Friend WithEvents dgvPoints5 As DataGridView
    Friend WithEvents ChkUpdatePhysIndices As CheckBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnMoveUp As Button
    Friend WithEvents btnMoveDown As Button
End Class
