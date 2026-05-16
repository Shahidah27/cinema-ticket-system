<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Me.components = New System.ComponentModel.Container()
        Dim SeatIDLabel As System.Windows.Forms.Label
        Dim SeatNumLabel As System.Windows.Forms.Label
        Dim SeatHallLabel As System.Windows.Forms.Label
        Dim SeatAvailabilityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SeatIDLabel1 = New System.Windows.Forms.Label()
        Me.SeatNumTextBox = New System.Windows.Forms.TextBox()
        Me.SeatHallTextBox = New System.Windows.Forms.TextBox()
        Me.SeatAvailabilityTextBox = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.SeatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MOVIE_DATADataSet = New CINEMA_TICKETING_SYSTEM_FINAL.MOVIE_DATADataSet()
        Me.SeatIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatHallDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatAvailabilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatTableAdapter = New CINEMA_TICKETING_SYSTEM_FINAL.MOVIE_DATADataSetTableAdapters.SeatTableAdapter()
        Me.TableAdapterManager = New CINEMA_TICKETING_SYSTEM_FINAL.MOVIE_DATADataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        SeatIDLabel = New System.Windows.Forms.Label()
        SeatNumLabel = New System.Windows.Forms.Label()
        SeatHallLabel = New System.Windows.Forms.Label()
        SeatAvailabilityLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SeatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIE_DATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SeatIDLabel
        '
        SeatIDLabel.AutoSize = True
        SeatIDLabel.BackColor = System.Drawing.Color.AntiqueWhite
        SeatIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SeatIDLabel.Location = New System.Drawing.Point(212, 175)
        SeatIDLabel.Name = "SeatIDLabel"
        SeatIDLabel.Size = New System.Drawing.Size(79, 25)
        SeatIDLabel.TabIndex = 54
        SeatIDLabel.Text = "seat ID:"
        '
        'SeatNumLabel
        '
        SeatNumLabel.AutoSize = True
        SeatNumLabel.BackColor = System.Drawing.Color.AntiqueWhite
        SeatNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SeatNumLabel.Location = New System.Drawing.Point(212, 231)
        SeatNumLabel.Name = "SeatNumLabel"
        SeatNumLabel.Size = New System.Drawing.Size(101, 25)
        SeatNumLabel.TabIndex = 56
        SeatNumLabel.Text = "seat Num:"
        '
        'SeatHallLabel
        '
        SeatHallLabel.AutoSize = True
        SeatHallLabel.BackColor = System.Drawing.Color.AntiqueWhite
        SeatHallLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SeatHallLabel.Location = New System.Drawing.Point(212, 288)
        SeatHallLabel.Name = "SeatHallLabel"
        SeatHallLabel.Size = New System.Drawing.Size(93, 25)
        SeatHallLabel.TabIndex = 58
        SeatHallLabel.Text = "seat Hall:"
        '
        'SeatAvailabilityLabel
        '
        SeatAvailabilityLabel.AutoSize = True
        SeatAvailabilityLabel.BackColor = System.Drawing.Color.AntiqueWhite
        SeatAvailabilityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SeatAvailabilityLabel.Location = New System.Drawing.Point(212, 349)
        SeatAvailabilityLabel.Name = "SeatAvailabilityLabel"
        SeatAvailabilityLabel.Size = New System.Drawing.Size(152, 25)
        SeatAvailabilityLabel.TabIndex = 60
        SeatAvailabilityLabel.Text = "seat Availability:"
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.LightSalmon
        Me.btnLast.Location = New System.Drawing.Point(909, 351)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(111, 42)
        Me.btnLast.TabIndex = 53
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.LightSalmon
        Me.btnPrevious.Location = New System.Drawing.Point(909, 288)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(111, 42)
        Me.btnPrevious.TabIndex = 52
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightSalmon
        Me.btnNext.Location = New System.Drawing.Point(909, 225)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(111, 42)
        Me.btnNext.TabIndex = 51
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.LightSalmon
        Me.btnFirst.Location = New System.Drawing.Point(909, 169)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(111, 42)
        Me.btnFirst.TabIndex = 50
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSalmon
        Me.btnExit.Location = New System.Drawing.Point(762, 411)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 42)
        Me.btnExit.TabIndex = 49
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.LightSalmon
        Me.btnUpdate.Location = New System.Drawing.Point(762, 349)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 42)
        Me.btnUpdate.TabIndex = 48
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightSalmon
        Me.btnDelete.Location = New System.Drawing.Point(762, 288)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 42)
        Me.btnDelete.TabIndex = 47
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSalmon
        Me.btnSave.Location = New System.Drawing.Point(762, 228)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 42)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(380, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 52)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "SEAT INFORMATION"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(142, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(948, 494)
        Me.Label2.TabIndex = 28
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SeatIDDataGridViewTextBoxColumn, Me.SeatNumDataGridViewTextBoxColumn, Me.SeatHallDataGridViewTextBoxColumn, Me.SeatAvailabilityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SeatBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(180, 428)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(553, 102)
        Me.DataGridView1.TabIndex = 30
        '
        'SeatIDLabel1
        '
        Me.SeatIDLabel1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.SeatIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SeatIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatBindingSource, "seatID", True))
        Me.SeatIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatIDLabel1.Location = New System.Drawing.Point(389, 177)
        Me.SeatIDLabel1.Name = "SeatIDLabel1"
        Me.SeatIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SeatIDLabel1.TabIndex = 55
        Me.SeatIDLabel1.Text = "Label3"
        '
        'SeatNumTextBox
        '
        Me.SeatNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatBindingSource, "seatNum", True))
        Me.SeatNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatNumTextBox.Location = New System.Drawing.Point(389, 225)
        Me.SeatNumTextBox.Name = "SeatNumTextBox"
        Me.SeatNumTextBox.Size = New System.Drawing.Size(300, 30)
        Me.SeatNumTextBox.TabIndex = 57
        '
        'SeatHallTextBox
        '
        Me.SeatHallTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatBindingSource, "seatHall", True))
        Me.SeatHallTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatHallTextBox.Location = New System.Drawing.Point(389, 288)
        Me.SeatHallTextBox.Name = "SeatHallTextBox"
        Me.SeatHallTextBox.Size = New System.Drawing.Size(296, 30)
        Me.SeatHallTextBox.TabIndex = 59
        '
        'SeatAvailabilityTextBox
        '
        Me.SeatAvailabilityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatBindingSource, "seatAvailability", True))
        Me.SeatAvailabilityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatAvailabilityTextBox.Location = New System.Drawing.Point(389, 349)
        Me.SeatAvailabilityTextBox.Name = "SeatAvailabilityTextBox"
        Me.SeatAvailabilityTextBox.Size = New System.Drawing.Size(296, 30)
        Me.SeatAvailabilityTextBox.TabIndex = 61
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSalmon
        Me.btnAdd.Location = New System.Drawing.Point(762, 169)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 42)
        Me.btnAdd.TabIndex = 45
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(26, 633)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(124, 33)
        Me.btnBack.TabIndex = 62
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.EditToolStripMenuItem, Me.EndToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1224, 28)
        Me.MenuStrip1.TabIndex = 63
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.AboutToolStripMenuItem.Text = "About "
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EndToolStripMenuItem.Text = "Exit"
        '
        'SeatBindingSource
        '
        Me.SeatBindingSource.DataMember = "Seat"
        Me.SeatBindingSource.DataSource = Me.MOVIE_DATADataSet
        '
        'MOVIE_DATADataSet
        '
        Me.MOVIE_DATADataSet.DataSetName = "MOVIE_DATADataSet"
        Me.MOVIE_DATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeatIDDataGridViewTextBoxColumn
        '
        Me.SeatIDDataGridViewTextBoxColumn.DataPropertyName = "seatID"
        Me.SeatIDDataGridViewTextBoxColumn.HeaderText = "seatID"
        Me.SeatIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SeatIDDataGridViewTextBoxColumn.Name = "SeatIDDataGridViewTextBoxColumn"
        Me.SeatIDDataGridViewTextBoxColumn.Width = 125
        '
        'SeatNumDataGridViewTextBoxColumn
        '
        Me.SeatNumDataGridViewTextBoxColumn.DataPropertyName = "seatNum"
        Me.SeatNumDataGridViewTextBoxColumn.HeaderText = "seatNum"
        Me.SeatNumDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SeatNumDataGridViewTextBoxColumn.Name = "SeatNumDataGridViewTextBoxColumn"
        Me.SeatNumDataGridViewTextBoxColumn.Width = 125
        '
        'SeatHallDataGridViewTextBoxColumn
        '
        Me.SeatHallDataGridViewTextBoxColumn.DataPropertyName = "seatHall"
        Me.SeatHallDataGridViewTextBoxColumn.HeaderText = "seatHall"
        Me.SeatHallDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SeatHallDataGridViewTextBoxColumn.Name = "SeatHallDataGridViewTextBoxColumn"
        Me.SeatHallDataGridViewTextBoxColumn.Width = 125
        '
        'SeatAvailabilityDataGridViewTextBoxColumn
        '
        Me.SeatAvailabilityDataGridViewTextBoxColumn.DataPropertyName = "seatAvailability"
        Me.SeatAvailabilityDataGridViewTextBoxColumn.HeaderText = "seatAvailability"
        Me.SeatAvailabilityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SeatAvailabilityDataGridViewTextBoxColumn.Name = "SeatAvailabilityDataGridViewTextBoxColumn"
        Me.SeatAvailabilityDataGridViewTextBoxColumn.Width = 125
        '
        'SeatTableAdapter
        '
        Me.SeatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Cust_LoginTableAdapter = Nothing
        Me.TableAdapterManager.MovieTableAdapter = Nothing
        Me.TableAdapterManager.SeatTableAdapter = Me.SeatTableAdapter
        Me.TableAdapterManager.Staff_LoginTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CINEMA_TICKETING_SYSTEM_FINAL.MOVIE_DATADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 28)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1224, 27)
        Me.BindingNavigator1.TabIndex = 64
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1224, 686)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(SeatIDLabel)
        Me.Controls.Add(Me.SeatIDLabel1)
        Me.Controls.Add(SeatNumLabel)
        Me.Controls.Add(Me.SeatNumTextBox)
        Me.Controls.Add(SeatHallLabel)
        Me.Controls.Add(Me.SeatHallTextBox)
        Me.Controls.Add(SeatAvailabilityLabel)
        Me.Controls.Add(Me.SeatAvailabilityTextBox)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form11"
        Me.Text = "Seat Information"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.SeatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIE_DATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MOVIE_DATADataSet As MOVIE_DATADataSet
    Friend WithEvents SeatBindingSource As BindingSource
    Friend WithEvents SeatTableAdapter As MOVIE_DATADataSetTableAdapters.SeatTableAdapter
    Friend WithEvents SeatIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatHallDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatAvailabilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As MOVIE_DATADataSetTableAdapters.TableAdapterManager
    Friend WithEvents SeatIDLabel1 As Label
    Friend WithEvents SeatNumTextBox As TextBox
    Friend WithEvents SeatHallTextBox As TextBox
    Friend WithEvents SeatAvailabilityTextBox As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
End Class
