<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
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
        Me.components = New System.ComponentModel.Container()
        Dim MovieIDLabel As System.Windows.Forms.Label
        Dim MovieTitleLabel As System.Windows.Forms.Label
        Dim MovieGenreLabel As System.Windows.Forms.Label
        Dim MovieDurationLabel As System.Windows.Forms.Label
        Dim MovieShowDateLabel As System.Windows.Forms.Label
        Dim MovieShowTimeLabel As System.Windows.Forms.Label
        Dim MovieDescLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MOVIE_DATADataSet = New CINEMA_TICKETING_SYSTEM_FINAL.MOVIE_DATADataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MovieIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieGenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieDurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieShowDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieShowTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovieTableAdapter = New CINEMA_TICKETING_SYSTEM_FINAL.MOVIE_DATADataSetTableAdapters.MovieTableAdapter()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TableAdapterManager = New CINEMA_TICKETING_SYSTEM_FINAL.MOVIE_DATADataSetTableAdapters.TableAdapterManager()
        Me.MovieIDLabel1 = New System.Windows.Forms.Label()
        Me.MovieTitleTextBox = New System.Windows.Forms.TextBox()
        Me.MovieGenreTextBox = New System.Windows.Forms.TextBox()
        Me.MovieDurationTextBox = New System.Windows.Forms.TextBox()
        Me.MovieShowDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MovieShowTimeTextBox = New System.Windows.Forms.TextBox()
        Me.MovieDescTextBox = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        MovieIDLabel = New System.Windows.Forms.Label()
        MovieTitleLabel = New System.Windows.Forms.Label()
        MovieGenreLabel = New System.Windows.Forms.Label()
        MovieDurationLabel = New System.Windows.Forms.Label()
        MovieShowDateLabel = New System.Windows.Forms.Label()
        MovieShowTimeLabel = New System.Windows.Forms.Label()
        MovieDescLabel = New System.Windows.Forms.Label()
        CType(Me.MOVIE_DATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MovieIDLabel
        '
        MovieIDLabel.AutoSize = True
        MovieIDLabel.BackColor = System.Drawing.Color.AntiqueWhite
        MovieIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieIDLabel.Location = New System.Drawing.Point(182, 147)
        MovieIDLabel.Name = "MovieIDLabel"
        MovieIDLabel.Size = New System.Drawing.Size(94, 25)
        MovieIDLabel.TabIndex = 5
        MovieIDLabel.Text = "movie ID:"
        '
        'MovieTitleLabel
        '
        MovieTitleLabel.AutoSize = True
        MovieTitleLabel.BackColor = System.Drawing.Color.AntiqueWhite
        MovieTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieTitleLabel.Location = New System.Drawing.Point(182, 187)
        MovieTitleLabel.Name = "MovieTitleLabel"
        MovieTitleLabel.Size = New System.Drawing.Size(112, 25)
        MovieTitleLabel.TabIndex = 7
        MovieTitleLabel.Text = "movie Title:"
        '
        'MovieGenreLabel
        '
        MovieGenreLabel.AutoSize = True
        MovieGenreLabel.BackColor = System.Drawing.Color.AntiqueWhite
        MovieGenreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieGenreLabel.Location = New System.Drawing.Point(182, 232)
        MovieGenreLabel.Name = "MovieGenreLabel"
        MovieGenreLabel.Size = New System.Drawing.Size(129, 25)
        MovieGenreLabel.TabIndex = 9
        MovieGenreLabel.Text = "movie Genre:"
        '
        'MovieDurationLabel
        '
        MovieDurationLabel.AutoSize = True
        MovieDurationLabel.BackColor = System.Drawing.Color.AntiqueWhite
        MovieDurationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieDurationLabel.Location = New System.Drawing.Point(182, 276)
        MovieDurationLabel.Name = "MovieDurationLabel"
        MovieDurationLabel.Size = New System.Drawing.Size(148, 25)
        MovieDurationLabel.TabIndex = 11
        MovieDurationLabel.Text = "movie Duration:"
        '
        'MovieShowDateLabel
        '
        MovieShowDateLabel.AutoSize = True
        MovieShowDateLabel.BackColor = System.Drawing.Color.AntiqueWhite
        MovieShowDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieShowDateLabel.Location = New System.Drawing.Point(179, 318)
        MovieShowDateLabel.Name = "MovieShowDateLabel"
        MovieShowDateLabel.Size = New System.Drawing.Size(171, 25)
        MovieShowDateLabel.TabIndex = 13
        MovieShowDateLabel.Text = "movie Show Date:"
        '
        'MovieShowTimeLabel
        '
        MovieShowTimeLabel.AutoSize = True
        MovieShowTimeLabel.BackColor = System.Drawing.Color.AntiqueWhite
        MovieShowTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieShowTimeLabel.Location = New System.Drawing.Point(179, 367)
        MovieShowTimeLabel.Name = "MovieShowTimeLabel"
        MovieShowTimeLabel.Size = New System.Drawing.Size(174, 25)
        MovieShowTimeLabel.TabIndex = 15
        MovieShowTimeLabel.Text = "movie Show Time:"
        '
        'MovieDescLabel
        '
        MovieDescLabel.AutoSize = True
        MovieDescLabel.BackColor = System.Drawing.Color.AntiqueWhite
        MovieDescLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieDescLabel.Location = New System.Drawing.Point(182, 415)
        MovieDescLabel.Name = "MovieDescLabel"
        MovieDescLabel.Size = New System.Drawing.Size(120, 25)
        MovieDescLabel.TabIndex = 17
        MovieDescLabel.Text = "movie Desc:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(103, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1025, 514)
        Me.Label2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(376, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(505, 52)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MOVIE INFORMATION"
        '
        'MOVIE_DATADataSet
        '
        Me.MOVIE_DATADataSet.DataSetName = "MOVIE_DATADataSet"
        Me.MOVIE_DATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovieIDDataGridViewTextBoxColumn, Me.MovieTitleDataGridViewTextBoxColumn, Me.MovieGenreDataGridViewTextBoxColumn, Me.MovieDurationDataGridViewTextBoxColumn, Me.MovieShowDateDataGridViewTextBoxColumn, Me.MovieShowTimeDataGridViewTextBoxColumn, Me.MovieDescDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MovieBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(169, 495)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(923, 102)
        Me.DataGridView1.TabIndex = 4
        '
        'MovieIDDataGridViewTextBoxColumn
        '
        Me.MovieIDDataGridViewTextBoxColumn.DataPropertyName = "movieID"
        Me.MovieIDDataGridViewTextBoxColumn.HeaderText = "movieID"
        Me.MovieIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MovieIDDataGridViewTextBoxColumn.Name = "MovieIDDataGridViewTextBoxColumn"
        Me.MovieIDDataGridViewTextBoxColumn.Width = 125
        '
        'MovieTitleDataGridViewTextBoxColumn
        '
        Me.MovieTitleDataGridViewTextBoxColumn.DataPropertyName = "movieTitle"
        Me.MovieTitleDataGridViewTextBoxColumn.HeaderText = "movieTitle"
        Me.MovieTitleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MovieTitleDataGridViewTextBoxColumn.Name = "MovieTitleDataGridViewTextBoxColumn"
        Me.MovieTitleDataGridViewTextBoxColumn.Width = 125
        '
        'MovieGenreDataGridViewTextBoxColumn
        '
        Me.MovieGenreDataGridViewTextBoxColumn.DataPropertyName = "movieGenre"
        Me.MovieGenreDataGridViewTextBoxColumn.HeaderText = "movieGenre"
        Me.MovieGenreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MovieGenreDataGridViewTextBoxColumn.Name = "MovieGenreDataGridViewTextBoxColumn"
        Me.MovieGenreDataGridViewTextBoxColumn.Width = 125
        '
        'MovieDurationDataGridViewTextBoxColumn
        '
        Me.MovieDurationDataGridViewTextBoxColumn.DataPropertyName = "movieDuration"
        Me.MovieDurationDataGridViewTextBoxColumn.HeaderText = "movieDuration"
        Me.MovieDurationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MovieDurationDataGridViewTextBoxColumn.Name = "MovieDurationDataGridViewTextBoxColumn"
        Me.MovieDurationDataGridViewTextBoxColumn.Width = 125
        '
        'MovieShowDateDataGridViewTextBoxColumn
        '
        Me.MovieShowDateDataGridViewTextBoxColumn.DataPropertyName = "movieShowDate"
        Me.MovieShowDateDataGridViewTextBoxColumn.HeaderText = "movieShowDate"
        Me.MovieShowDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MovieShowDateDataGridViewTextBoxColumn.Name = "MovieShowDateDataGridViewTextBoxColumn"
        Me.MovieShowDateDataGridViewTextBoxColumn.Width = 125
        '
        'MovieShowTimeDataGridViewTextBoxColumn
        '
        Me.MovieShowTimeDataGridViewTextBoxColumn.DataPropertyName = "movieShowTime"
        Me.MovieShowTimeDataGridViewTextBoxColumn.HeaderText = "movieShowTime"
        Me.MovieShowTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MovieShowTimeDataGridViewTextBoxColumn.Name = "MovieShowTimeDataGridViewTextBoxColumn"
        Me.MovieShowTimeDataGridViewTextBoxColumn.Width = 125
        '
        'MovieDescDataGridViewTextBoxColumn
        '
        Me.MovieDescDataGridViewTextBoxColumn.DataPropertyName = "movieDesc"
        Me.MovieDescDataGridViewTextBoxColumn.HeaderText = "movieDesc"
        Me.MovieDescDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MovieDescDataGridViewTextBoxColumn.Name = "MovieDescDataGridViewTextBoxColumn"
        Me.MovieDescDataGridViewTextBoxColumn.Width = 125
        '
        'MovieBindingSource
        '
        Me.MovieBindingSource.DataMember = "Movie"
        Me.MovieBindingSource.DataSource = Me.MOVIE_DATADataSet
        '
        'MovieTableAdapter
        '
        Me.MovieTableAdapter.ClearBeforeFill = True
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
        Me.BindingNavigator1.TabIndex = 5
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Cust_LoginTableAdapter = Nothing
        Me.TableAdapterManager.MovieTableAdapter = Me.MovieTableAdapter
        Me.TableAdapterManager.SeatTableAdapter = Nothing
        Me.TableAdapterManager.Staff_LoginTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CINEMA_TICKETING_SYSTEM_FINAL.MOVIE_DATADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MovieIDLabel1
        '
        Me.MovieIDLabel1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.MovieIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MovieIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovieBindingSource, "movieID", True))
        Me.MovieIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieIDLabel1.Location = New System.Drawing.Point(376, 147)
        Me.MovieIDLabel1.Name = "MovieIDLabel1"
        Me.MovieIDLabel1.Size = New System.Drawing.Size(116, 23)
        Me.MovieIDLabel1.TabIndex = 6
        Me.MovieIDLabel1.Text = "Label3"
        '
        'MovieTitleTextBox
        '
        Me.MovieTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovieBindingSource, "movieTitle", True))
        Me.MovieTitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieTitleTextBox.Location = New System.Drawing.Point(376, 187)
        Me.MovieTitleTextBox.Name = "MovieTitleTextBox"
        Me.MovieTitleTextBox.Size = New System.Drawing.Size(342, 30)
        Me.MovieTitleTextBox.TabIndex = 8
        '
        'MovieGenreTextBox
        '
        Me.MovieGenreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovieBindingSource, "movieGenre", True))
        Me.MovieGenreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieGenreTextBox.Location = New System.Drawing.Point(376, 229)
        Me.MovieGenreTextBox.Name = "MovieGenreTextBox"
        Me.MovieGenreTextBox.Size = New System.Drawing.Size(338, 30)
        Me.MovieGenreTextBox.TabIndex = 10
        '
        'MovieDurationTextBox
        '
        Me.MovieDurationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovieBindingSource, "movieDuration", True))
        Me.MovieDurationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieDurationTextBox.Location = New System.Drawing.Point(376, 271)
        Me.MovieDurationTextBox.Name = "MovieDurationTextBox"
        Me.MovieDurationTextBox.Size = New System.Drawing.Size(338, 30)
        Me.MovieDurationTextBox.TabIndex = 12
        '
        'MovieShowDateDateTimePicker
        '
        Me.MovieShowDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MovieBindingSource, "movieShowDate", True))
        Me.MovieShowDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieShowDateDateTimePicker.Location = New System.Drawing.Point(376, 318)
        Me.MovieShowDateDateTimePicker.Name = "MovieShowDateDateTimePicker"
        Me.MovieShowDateDateTimePicker.Size = New System.Drawing.Size(338, 30)
        Me.MovieShowDateDateTimePicker.TabIndex = 14
        '
        'MovieShowTimeTextBox
        '
        Me.MovieShowTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovieBindingSource, "movieShowTime", True))
        Me.MovieShowTimeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieShowTimeTextBox.Location = New System.Drawing.Point(376, 364)
        Me.MovieShowTimeTextBox.Name = "MovieShowTimeTextBox"
        Me.MovieShowTimeTextBox.Size = New System.Drawing.Size(338, 30)
        Me.MovieShowTimeTextBox.TabIndex = 16
        '
        'MovieDescTextBox
        '
        Me.MovieDescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovieBindingSource, "movieDesc", True))
        Me.MovieDescTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieDescTextBox.Location = New System.Drawing.Point(376, 415)
        Me.MovieDescTextBox.Multiline = True
        Me.MovieDescTextBox.Name = "MovieDescTextBox"
        Me.MovieDescTextBox.Size = New System.Drawing.Size(338, 50)
        Me.MovieDescTextBox.TabIndex = 18
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSalmon
        Me.btnAdd.Location = New System.Drawing.Point(800, 170)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 42)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSalmon
        Me.btnSave.Location = New System.Drawing.Point(800, 229)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 42)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightSalmon
        Me.btnDelete.Location = New System.Drawing.Point(800, 289)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 42)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.LightSalmon
        Me.btnUpdate.Location = New System.Drawing.Point(800, 350)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 42)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSalmon
        Me.btnExit.Location = New System.Drawing.Point(800, 412)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 42)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.LightSalmon
        Me.btnFirst.Location = New System.Drawing.Point(947, 170)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(111, 42)
        Me.btnFirst.TabIndex = 24
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightSalmon
        Me.btnNext.Location = New System.Drawing.Point(947, 226)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(111, 42)
        Me.btnNext.TabIndex = 25
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.LightSalmon
        Me.btnPrevious.Location = New System.Drawing.Point(947, 289)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(111, 42)
        Me.btnPrevious.TabIndex = 26
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.LightSalmon
        Me.btnLast.Location = New System.Drawing.Point(947, 352)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(111, 42)
        Me.btnLast.TabIndex = 27
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1078, 633)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 33)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.EditToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1224, 28)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
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
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1224, 678)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(MovieIDLabel)
        Me.Controls.Add(Me.MovieIDLabel1)
        Me.Controls.Add(MovieTitleLabel)
        Me.Controls.Add(Me.MovieTitleTextBox)
        Me.Controls.Add(MovieGenreLabel)
        Me.Controls.Add(Me.MovieGenreTextBox)
        Me.Controls.Add(MovieDurationLabel)
        Me.Controls.Add(Me.MovieDurationTextBox)
        Me.Controls.Add(MovieShowDateLabel)
        Me.Controls.Add(Me.MovieShowDateDateTimePicker)
        Me.Controls.Add(MovieShowTimeLabel)
        Me.Controls.Add(Me.MovieShowTimeTextBox)
        Me.Controls.Add(MovieDescLabel)
        Me.Controls.Add(Me.MovieDescTextBox)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form10"
        Me.Text = "Movie Information"
        CType(Me.MOVIE_DATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MOVIE_DATADataSet As MOVIE_DATADataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MovieBindingSource As BindingSource
    Friend WithEvents MovieTableAdapter As MOVIE_DATADataSetTableAdapters.MovieTableAdapter
    Friend WithEvents MovieIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieGenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieDurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieShowDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieShowTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents TableAdapterManager As MOVIE_DATADataSetTableAdapters.TableAdapterManager
    Friend WithEvents MovieIDLabel1 As Label
    Friend WithEvents MovieTitleTextBox As TextBox
    Friend WithEvents MovieGenreTextBox As TextBox
    Friend WithEvents MovieDurationTextBox As TextBox
    Friend WithEvents MovieShowDateDateTimePicker As DateTimePicker
    Friend WithEvents MovieShowTimeTextBox As TextBox
    Friend WithEvents MovieDescTextBox As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
