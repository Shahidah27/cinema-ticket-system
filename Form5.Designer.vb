<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MovieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MOVIE_DATADataSet = New CINEMA_TICKETING_SYSTEM_FINAL.MOVIE_DATADataSet()
        Me.MovieTableAdapter = New CINEMA_TICKETING_SYSTEM_FINAL.MOVIE_DATADataSetTableAdapters.MovieTableAdapter()
        Me.TableAdapterManager = New CINEMA_TICKETING_SYSTEM_FINAL.MOVIE_DATADataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtMovieID = New System.Windows.Forms.TextBox()
        Me.txtMovieTitle = New System.Windows.Forms.TextBox()
        Me.txtMovieGenre = New System.Windows.Forms.TextBox()
        Me.txtMovieDuration = New System.Windows.Forms.TextBox()
        Me.txtMovieShowDate = New System.Windows.Forms.DateTimePicker()
        Me.txtMovieShowTime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMovieDesc = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        MovieIDLabel = New System.Windows.Forms.Label()
        MovieTitleLabel = New System.Windows.Forms.Label()
        MovieGenreLabel = New System.Windows.Forms.Label()
        MovieDurationLabel = New System.Windows.Forms.Label()
        MovieShowDateLabel = New System.Windows.Forms.Label()
        MovieShowTimeLabel = New System.Windows.Forms.Label()
        MovieDescLabel = New System.Windows.Forms.Label()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIE_DATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MovieIDLabel
        '
        MovieIDLabel.AutoSize = True
        MovieIDLabel.BackColor = System.Drawing.Color.LavenderBlush
        MovieIDLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieIDLabel.Location = New System.Drawing.Point(298, 311)
        MovieIDLabel.Name = "MovieIDLabel"
        MovieIDLabel.Size = New System.Drawing.Size(72, 18)
        MovieIDLabel.TabIndex = 5
        MovieIDLabel.Text = "Movie ID:"
        '
        'MovieTitleLabel
        '
        MovieTitleLabel.AutoSize = True
        MovieTitleLabel.BackColor = System.Drawing.Color.LavenderBlush
        MovieTitleLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieTitleLabel.Location = New System.Drawing.Point(298, 354)
        MovieTitleLabel.Name = "MovieTitleLabel"
        MovieTitleLabel.Size = New System.Drawing.Size(83, 18)
        MovieTitleLabel.TabIndex = 7
        MovieTitleLabel.Text = "Movie Title:"
        '
        'MovieGenreLabel
        '
        MovieGenreLabel.AutoSize = True
        MovieGenreLabel.BackColor = System.Drawing.Color.LavenderBlush
        MovieGenreLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieGenreLabel.Location = New System.Drawing.Point(298, 405)
        MovieGenreLabel.Name = "MovieGenreLabel"
        MovieGenreLabel.Size = New System.Drawing.Size(95, 18)
        MovieGenreLabel.TabIndex = 9
        MovieGenreLabel.Text = "Movie Genre:"
        '
        'MovieDurationLabel
        '
        MovieDurationLabel.AutoSize = True
        MovieDurationLabel.BackColor = System.Drawing.Color.LavenderBlush
        MovieDurationLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieDurationLabel.Location = New System.Drawing.Point(298, 454)
        MovieDurationLabel.Name = "MovieDurationLabel"
        MovieDurationLabel.Size = New System.Drawing.Size(110, 18)
        MovieDurationLabel.TabIndex = 11
        MovieDurationLabel.Text = "Movie Duration:"
        '
        'MovieShowDateLabel
        '
        MovieShowDateLabel.AutoSize = True
        MovieShowDateLabel.BackColor = System.Drawing.Color.LavenderBlush
        MovieShowDateLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieShowDateLabel.Location = New System.Drawing.Point(298, 493)
        MovieShowDateLabel.Name = "MovieShowDateLabel"
        MovieShowDateLabel.Size = New System.Drawing.Size(126, 18)
        MovieShowDateLabel.TabIndex = 13
        MovieShowDateLabel.Text = "Movie Show Date:"
        '
        'MovieShowTimeLabel
        '
        MovieShowTimeLabel.AutoSize = True
        MovieShowTimeLabel.BackColor = System.Drawing.Color.LavenderBlush
        MovieShowTimeLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieShowTimeLabel.Location = New System.Drawing.Point(296, 541)
        MovieShowTimeLabel.Name = "MovieShowTimeLabel"
        MovieShowTimeLabel.Size = New System.Drawing.Size(128, 18)
        MovieShowTimeLabel.TabIndex = 15
        MovieShowTimeLabel.Text = "Movie Show Time:"
        '
        'MovieDescLabel
        '
        MovieDescLabel.AutoSize = True
        MovieDescLabel.BackColor = System.Drawing.Color.LavenderBlush
        MovieDescLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieDescLabel.Location = New System.Drawing.Point(677, 311)
        MovieDescLabel.Name = "MovieDescLabel"
        MovieDescLabel.Size = New System.Drawing.Size(126, 18)
        MovieDescLabel.TabIndex = 17
        MovieDescLabel.Text = "Movie Description:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovieBindingSource, "movieDesc", True))
        Me.Label1.Location = New System.Drawing.Point(159, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(915, 435)
        Me.Label1.TabIndex = 0
        '
        'MovieBindingSource
        '
        Me.MovieBindingSource.DataMember = "Movie"
        Me.MovieBindingSource.DataSource = Me.MOVIE_DATADataSet
        '
        'MOVIE_DATADataSet
        '
        Me.MOVIE_DATADataSet.DataSetName = "MOVIE_DATADataSet"
        Me.MOVIE_DATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MovieTableAdapter
        '
        Me.MovieTableAdapter.ClearBeforeFill = True
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search Movie Name"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(301, 258)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(447, 22)
        Me.txtSearch.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(765, 253)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 32)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtMovieID
        '
        Me.txtMovieID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovieBindingSource, "movieID", True))
        Me.txtMovieID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieID.Location = New System.Drawing.Point(444, 305)
        Me.txtMovieID.Name = "txtMovieID"
        Me.txtMovieID.Size = New System.Drawing.Size(200, 26)
        Me.txtMovieID.TabIndex = 6
        '
        'txtMovieTitle
        '
        Me.txtMovieTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovieBindingSource, "movieTitle", True))
        Me.txtMovieTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieTitle.Location = New System.Drawing.Point(444, 351)
        Me.txtMovieTitle.Name = "txtMovieTitle"
        Me.txtMovieTitle.Size = New System.Drawing.Size(200, 26)
        Me.txtMovieTitle.TabIndex = 8
        '
        'txtMovieGenre
        '
        Me.txtMovieGenre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovieBindingSource, "movieGenre", True))
        Me.txtMovieGenre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieGenre.Location = New System.Drawing.Point(444, 402)
        Me.txtMovieGenre.Name = "txtMovieGenre"
        Me.txtMovieGenre.Size = New System.Drawing.Size(200, 26)
        Me.txtMovieGenre.TabIndex = 10
        '
        'txtMovieDuration
        '
        Me.txtMovieDuration.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovieBindingSource, "movieDuration", True))
        Me.txtMovieDuration.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieDuration.Location = New System.Drawing.Point(444, 452)
        Me.txtMovieDuration.Name = "txtMovieDuration"
        Me.txtMovieDuration.Size = New System.Drawing.Size(200, 26)
        Me.txtMovieDuration.TabIndex = 12
        '
        'txtMovieShowDate
        '
        Me.txtMovieShowDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MovieBindingSource, "movieShowDate", True))
        Me.txtMovieShowDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieShowDate.Location = New System.Drawing.Point(444, 493)
        Me.txtMovieShowDate.Name = "txtMovieShowDate"
        Me.txtMovieShowDate.Size = New System.Drawing.Size(200, 26)
        Me.txtMovieShowDate.TabIndex = 14
        '
        'txtMovieShowTime
        '
        Me.txtMovieShowTime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovieBindingSource, "movieShowTime", True))
        Me.txtMovieShowTime.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieShowTime.Location = New System.Drawing.Point(444, 537)
        Me.txtMovieShowTime.Name = "txtMovieShowTime"
        Me.txtMovieShowTime.Size = New System.Drawing.Size(200, 26)
        Me.txtMovieShowTime.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Stencil", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label3.Location = New System.Drawing.Point(357, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(490, 58)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "SEGAR AMAT CINEMA"
        '
        'txtMovieDesc
        '
        Me.txtMovieDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovieBindingSource, "movieDesc", True))
        Me.txtMovieDesc.Location = New System.Drawing.Point(680, 351)
        Me.txtMovieDesc.Multiline = True
        Me.txtMovieDesc.Name = "txtMovieDesc"
        Me.txtMovieDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMovieDesc.Size = New System.Drawing.Size(300, 150)
        Me.txtMovieDesc.TabIndex = 20
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(1096, 619)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(114, 37)
        Me.btnNext.TabIndex = 21
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(28, 619)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(114, 37)
        Me.btnBack.TabIndex = 22
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.BackColor = System.Drawing.Color.Goldenrod
        Me.btnBook.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.Location = New System.Drawing.Point(680, 518)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(300, 50)
        Me.btnBook.TabIndex = 23
        Me.btnBook.Text = "BOOK MOVIE"
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CINEMA_TICKETING_SYSTEM_FINAL.My.Resources.Resources.bggggggg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1240, 678)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtMovieDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(MovieDescLabel)
        Me.Controls.Add(MovieIDLabel)
        Me.Controls.Add(Me.txtMovieID)
        Me.Controls.Add(MovieTitleLabel)
        Me.Controls.Add(Me.txtMovieTitle)
        Me.Controls.Add(MovieGenreLabel)
        Me.Controls.Add(Me.txtMovieGenre)
        Me.Controls.Add(MovieDurationLabel)
        Me.Controls.Add(Me.txtMovieDuration)
        Me.Controls.Add(MovieShowDateLabel)
        Me.Controls.Add(Me.txtMovieShowDate)
        Me.Controls.Add(MovieShowTimeLabel)
        Me.Controls.Add(Me.txtMovieShowTime)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Booking Selection"
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIE_DATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MOVIE_DATADataSet As MOVIE_DATADataSet
    Friend WithEvents MovieBindingSource As BindingSource
    Friend WithEvents MovieTableAdapter As MOVIE_DATADataSetTableAdapters.MovieTableAdapter
    Friend WithEvents TableAdapterManager As MOVIE_DATADataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtMovieID As TextBox
    Friend WithEvents txtMovieTitle As TextBox
    Friend WithEvents txtMovieGenre As TextBox
    Friend WithEvents txtMovieDuration As TextBox
    Friend WithEvents txtMovieShowDate As DateTimePicker
    Friend WithEvents txtMovieShowTime As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMovieDesc As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnBook As Button
End Class
