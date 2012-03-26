<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.SynxButton = New System.Windows.Forms.Button()
        Me.DevDrv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.IdeaButton = New System.Windows.Forms.Button()
        Me.PatchButton = New System.Windows.Forms.Button()
        Me.FollowButton = New System.Windows.Forms.Button()
        Me.PicturesCheckBox = New System.Windows.Forms.CheckBox()
        Me.MoviesCheckBox = New System.Windows.Forms.CheckBox()
        Me.VideosCheckBox = New System.Windows.Forms.CheckBox()
        Me.MusicCheckBox = New System.Windows.Forms.CheckBox()
        Me.PicturesDir = New System.Windows.Forms.TextBox()
        Me.PicturesLabel = New System.Windows.Forms.Label()
        Me.MoviesDir = New System.Windows.Forms.TextBox()
        Me.MoviesLabel = New System.Windows.Forms.Label()
        Me.VideosDir = New System.Windows.Forms.TextBox()
        Me.VideosLabel = New System.Windows.Forms.Label()
        Me.MusicDir = New System.Windows.Forms.TextBox()
        Me.MusicLabel = New System.Windows.Forms.Label()
        Me.iTunesContentButton = New System.Windows.Forms.Button()
        Me.WindowsContentButton = New System.Windows.Forms.Button()
        Me.DCIMCheckBox = New System.Windows.Forms.CheckBox()
        Me.exeptionLabel = New System.Windows.Forms.Label()
        Me.AirSynxButton = New System.Windows.Forms.Button()
        Me.HelpSiteButton = New System.Windows.Forms.Button()
        Me.MusicBrowse = New System.Windows.Forms.Button()
        Me.VideosBrowse = New System.Windows.Forms.Button()
        Me.MoviesBrowse = New System.Windows.Forms.Button()
        Me.PicturesBrowse = New System.Windows.Forms.Button()
        Me.DevDrvBrowse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SynxButton
        '
        Me.SynxButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SynxButton.Location = New System.Drawing.Point(437, 293)
        Me.SynxButton.Name = "SynxButton"
        Me.SynxButton.Size = New System.Drawing.Size(188, 178)
        Me.SynxButton.TabIndex = 0
        Me.SynxButton.Text = "SYNX!"
        Me.SynxButton.UseVisualStyleBackColor = True
        '
        'DevDrv
        '
        Me.DevDrv.Location = New System.Drawing.Point(445, 50)
        Me.DevDrv.MaxLength = 13
        Me.DevDrv.Name = "DevDrv"
        Me.DevDrv.Size = New System.Drawing.Size(82, 20)
        Me.DevDrv.TabIndex = 8
        Me.DevDrv.Text = "E:\"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(442, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Android Device Drive"
        '
        'AboutButton
        '
        Me.AboutButton.Location = New System.Drawing.Point(321, 310)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(75, 23)
        Me.AboutButton.TabIndex = 9
        Me.AboutButton.Text = "About Synx"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'IdeaButton
        '
        Me.IdeaButton.Location = New System.Drawing.Point(6, 310)
        Me.IdeaButton.Name = "IdeaButton"
        Me.IdeaButton.Size = New System.Drawing.Size(113, 23)
        Me.IdeaButton.TabIndex = 16
        Me.IdeaButton.Text = "Submit an Idea/Bug!"
        Me.IdeaButton.UseVisualStyleBackColor = True
        '
        'PatchButton
        '
        Me.PatchButton.Location = New System.Drawing.Point(125, 310)
        Me.PatchButton.Name = "PatchButton"
        Me.PatchButton.Size = New System.Drawing.Size(190, 23)
        Me.PatchButton.TabIndex = 17
        Me.PatchButton.Text = "Upload a patch to make Synx better!"
        Me.PatchButton.UseVisualStyleBackColor = True
        '
        'FollowButton
        '
        Me.FollowButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FollowButton.Location = New System.Drawing.Point(6, 339)
        Me.FollowButton.Name = "FollowButton"
        Me.FollowButton.Size = New System.Drawing.Size(113, 95)
        Me.FollowButton.TabIndex = 19
        Me.FollowButton.Text = "Follow us on Google+"
        Me.FollowButton.UseVisualStyleBackColor = True
        '
        'PicturesCheckBox
        '
        Me.PicturesCheckBox.AutoSize = True
        Me.PicturesCheckBox.Location = New System.Drawing.Point(6, 252)
        Me.PicturesCheckBox.Name = "PicturesCheckBox"
        Me.PicturesCheckBox.Size = New System.Drawing.Size(106, 17)
        Me.PicturesCheckBox.TabIndex = 32
        Me.PicturesCheckBox.Text = "Synx my Pictures"
        Me.PicturesCheckBox.UseVisualStyleBackColor = True
        '
        'MoviesCheckBox
        '
        Me.MoviesCheckBox.AutoSize = True
        Me.MoviesCheckBox.Location = New System.Drawing.Point(6, 185)
        Me.MoviesCheckBox.Name = "MoviesCheckBox"
        Me.MoviesCheckBox.Size = New System.Drawing.Size(102, 17)
        Me.MoviesCheckBox.TabIndex = 31
        Me.MoviesCheckBox.Text = "Synx my Movies"
        Me.MoviesCheckBox.UseVisualStyleBackColor = True
        '
        'VideosCheckBox
        '
        Me.VideosCheckBox.AutoSize = True
        Me.VideosCheckBox.Location = New System.Drawing.Point(6, 118)
        Me.VideosCheckBox.Name = "VideosCheckBox"
        Me.VideosCheckBox.Size = New System.Drawing.Size(100, 17)
        Me.VideosCheckBox.TabIndex = 30
        Me.VideosCheckBox.Text = "Synx my Videos"
        Me.VideosCheckBox.UseVisualStyleBackColor = True
        '
        'MusicCheckBox
        '
        Me.MusicCheckBox.AutoSize = True
        Me.MusicCheckBox.Location = New System.Drawing.Point(6, 51)
        Me.MusicCheckBox.Name = "MusicCheckBox"
        Me.MusicCheckBox.Size = New System.Drawing.Size(96, 17)
        Me.MusicCheckBox.TabIndex = 29
        Me.MusicCheckBox.Text = "Synx my Music"
        Me.MusicCheckBox.UseVisualStyleBackColor = True
        '
        'PicturesDir
        '
        Me.PicturesDir.Location = New System.Drawing.Point(6, 226)
        Me.PicturesDir.Name = "PicturesDir"
        Me.PicturesDir.Size = New System.Drawing.Size(325, 20)
        Me.PicturesDir.TabIndex = 28
        Me.PicturesDir.Text = "e.g. C:\Users\Example\Pictures"
        '
        'PicturesLabel
        '
        Me.PicturesLabel.AutoSize = True
        Me.PicturesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicturesLabel.Location = New System.Drawing.Point(3, 205)
        Me.PicturesLabel.Name = "PicturesLabel"
        Me.PicturesLabel.Size = New System.Drawing.Size(130, 18)
        Me.PicturesLabel.TabIndex = 27
        Me.PicturesLabel.Text = "Pictures Directory:"
        '
        'MoviesDir
        '
        Me.MoviesDir.Location = New System.Drawing.Point(6, 159)
        Me.MoviesDir.Name = "MoviesDir"
        Me.MoviesDir.Size = New System.Drawing.Size(325, 20)
        Me.MoviesDir.TabIndex = 26
        Me.MoviesDir.Text = "e.g. C:\Users\Example\Videos\Movies"
        '
        'MoviesLabel
        '
        Me.MoviesLabel.AutoSize = True
        Me.MoviesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoviesLabel.Location = New System.Drawing.Point(3, 138)
        Me.MoviesLabel.Name = "MoviesLabel"
        Me.MoviesLabel.Size = New System.Drawing.Size(124, 18)
        Me.MoviesLabel.TabIndex = 25
        Me.MoviesLabel.Text = "Movies Directory:"
        '
        'VideosDir
        '
        Me.VideosDir.Location = New System.Drawing.Point(6, 92)
        Me.VideosDir.Name = "VideosDir"
        Me.VideosDir.Size = New System.Drawing.Size(325, 20)
        Me.VideosDir.TabIndex = 24
        Me.VideosDir.Text = "e.g. C:\Users\Example\Videos"
        '
        'VideosLabel
        '
        Me.VideosLabel.AutoSize = True
        Me.VideosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideosLabel.Location = New System.Drawing.Point(3, 71)
        Me.VideosLabel.Name = "VideosLabel"
        Me.VideosLabel.Size = New System.Drawing.Size(121, 18)
        Me.VideosLabel.TabIndex = 23
        Me.VideosLabel.Text = "Videos Directory:"
        '
        'MusicDir
        '
        Me.MusicDir.Location = New System.Drawing.Point(6, 25)
        Me.MusicDir.Name = "MusicDir"
        Me.MusicDir.Size = New System.Drawing.Size(325, 20)
        Me.MusicDir.TabIndex = 22
        Me.MusicDir.Text = "e.g. C:\Users\Example\Music"
        '
        'MusicLabel
        '
        Me.MusicLabel.AutoSize = True
        Me.MusicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicLabel.Location = New System.Drawing.Point(3, 3)
        Me.MusicLabel.Name = "MusicLabel"
        Me.MusicLabel.Size = New System.Drawing.Size(116, 18)
        Me.MusicLabel.TabIndex = 21
        Me.MusicLabel.Text = "Music Directory:"
        '
        'iTunesContentButton
        '
        Me.iTunesContentButton.Location = New System.Drawing.Point(445, 105)
        Me.iTunesContentButton.Name = "iTunesContentButton"
        Me.iTunesContentButton.Size = New System.Drawing.Size(109, 23)
        Me.iTunesContentButton.TabIndex = 33
        Me.iTunesContentButton.Text = "Find iTunes content"
        Me.iTunesContentButton.UseVisualStyleBackColor = True
        '
        'WindowsContentButton
        '
        Me.WindowsContentButton.Location = New System.Drawing.Point(445, 76)
        Me.WindowsContentButton.Name = "WindowsContentButton"
        Me.WindowsContentButton.Size = New System.Drawing.Size(160, 23)
        Me.WindowsContentButton.TabIndex = 34
        Me.WindowsContentButton.Text = "Find Default Windows Content"
        Me.WindowsContentButton.UseVisualStyleBackColor = True
        '
        'DCIMCheckBox
        '
        Me.DCIMCheckBox.AutoSize = True
        Me.DCIMCheckBox.Location = New System.Drawing.Point(118, 252)
        Me.DCIMCheckBox.Name = "DCIMCheckBox"
        Me.DCIMCheckBox.Size = New System.Drawing.Size(213, 17)
        Me.DCIMCheckBox.TabIndex = 35
        Me.DCIMCheckBox.Text = "Back up Recorded Pictures and Videos"
        Me.DCIMCheckBox.UseVisualStyleBackColor = True
        '
        'exeptionLabel
        '
        Me.exeptionLabel.AutoSize = True
        Me.exeptionLabel.Location = New System.Drawing.Point(3, 461)
        Me.exeptionLabel.Name = "exeptionLabel"
        Me.exeptionLabel.Size = New System.Drawing.Size(355, 13)
        Me.exeptionLabel.TabIndex = 36
        Me.exeptionLabel.Text = "When you Synx you may get an exeption, just click continue and ignore it."
        '
        'AirSynxButton
        '
        Me.AirSynxButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AirSynxButton.Location = New System.Drawing.Point(125, 339)
        Me.AirSynxButton.Name = "AirSynxButton"
        Me.AirSynxButton.Size = New System.Drawing.Size(190, 97)
        Me.AirSynxButton.TabIndex = 37
        Me.AirSynxButton.Text = "AirSynx"
        Me.AirSynxButton.UseVisualStyleBackColor = True
        '
        'HelpSiteButton
        '
        Me.HelpSiteButton.Location = New System.Drawing.Point(321, 339)
        Me.HelpSiteButton.Name = "HelpSiteButton"
        Me.HelpSiteButton.Size = New System.Drawing.Size(75, 23)
        Me.HelpSiteButton.TabIndex = 38
        Me.HelpSiteButton.Text = "Help"
        Me.HelpSiteButton.UseVisualStyleBackColor = True
        '
        'MusicBrowse
        '
        Me.MusicBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MusicBrowse.Location = New System.Drawing.Point(336, 23)
        Me.MusicBrowse.Name = "MusicBrowse"
        Me.MusicBrowse.Size = New System.Drawing.Size(75, 23)
        Me.MusicBrowse.TabIndex = 40
        Me.MusicBrowse.Text = "Browse..."
        Me.MusicBrowse.UseVisualStyleBackColor = True
        '
        'VideosBrowse
        '
        Me.VideosBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.VideosBrowse.Location = New System.Drawing.Point(336, 91)
        Me.VideosBrowse.Name = "VideosBrowse"
        Me.VideosBrowse.Size = New System.Drawing.Size(75, 23)
        Me.VideosBrowse.TabIndex = 41
        Me.VideosBrowse.Text = "Browse..."
        Me.VideosBrowse.UseVisualStyleBackColor = True
        '
        'MoviesBrowse
        '
        Me.MoviesBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MoviesBrowse.Location = New System.Drawing.Point(336, 157)
        Me.MoviesBrowse.Name = "MoviesBrowse"
        Me.MoviesBrowse.Size = New System.Drawing.Size(75, 23)
        Me.MoviesBrowse.TabIndex = 42
        Me.MoviesBrowse.Text = "Browse..."
        Me.MoviesBrowse.UseVisualStyleBackColor = True
        '
        'PicturesBrowse
        '
        Me.PicturesBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.PicturesBrowse.Location = New System.Drawing.Point(336, 225)
        Me.PicturesBrowse.Name = "PicturesBrowse"
        Me.PicturesBrowse.Size = New System.Drawing.Size(75, 23)
        Me.PicturesBrowse.TabIndex = 43
        Me.PicturesBrowse.Text = "Browse..."
        Me.PicturesBrowse.UseVisualStyleBackColor = True
        '
        'DevDrvBrowse
        '
        Me.DevDrvBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.DevDrvBrowse.Location = New System.Drawing.Point(532, 48)
        Me.DevDrvBrowse.Name = "DevDrvBrowse"
        Me.DevDrvBrowse.Size = New System.Drawing.Size(75, 23)
        Me.DevDrvBrowse.TabIndex = 44
        Me.DevDrvBrowse.Text = "Browse..."
        Me.DevDrvBrowse.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(631, 477)
        Me.Controls.Add(Me.DevDrvBrowse)
        Me.Controls.Add(Me.PicturesBrowse)
        Me.Controls.Add(Me.MoviesBrowse)
        Me.Controls.Add(Me.VideosBrowse)
        Me.Controls.Add(Me.MusicBrowse)
        Me.Controls.Add(Me.HelpSiteButton)
        Me.Controls.Add(Me.AirSynxButton)
        Me.Controls.Add(Me.exeptionLabel)
        Me.Controls.Add(Me.DCIMCheckBox)
        Me.Controls.Add(Me.WindowsContentButton)
        Me.Controls.Add(Me.iTunesContentButton)
        Me.Controls.Add(Me.PicturesCheckBox)
        Me.Controls.Add(Me.MoviesCheckBox)
        Me.Controls.Add(Me.VideosCheckBox)
        Me.Controls.Add(Me.MusicCheckBox)
        Me.Controls.Add(Me.PicturesDir)
        Me.Controls.Add(Me.PicturesLabel)
        Me.Controls.Add(Me.MoviesDir)
        Me.Controls.Add(Me.MoviesLabel)
        Me.Controls.Add(Me.VideosDir)
        Me.Controls.Add(Me.VideosLabel)
        Me.Controls.Add(Me.MusicDir)
        Me.Controls.Add(Me.MusicLabel)
        Me.Controls.Add(Me.FollowButton)
        Me.Controls.Add(Me.PatchButton)
        Me.Controls.Add(Me.IdeaButton)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.DevDrv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SynxButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Text = "Synx"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SynxButton As System.Windows.Forms.Button
    Friend WithEvents DevDrv As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AboutButton As System.Windows.Forms.Button
    Friend WithEvents IdeaButton As System.Windows.Forms.Button
    Friend WithEvents PatchButton As System.Windows.Forms.Button
    Friend WithEvents FollowButton As System.Windows.Forms.Button
    Friend WithEvents PicturesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MoviesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents VideosCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MusicCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PicturesDir As System.Windows.Forms.TextBox
    Friend WithEvents PicturesLabel As System.Windows.Forms.Label
    Friend WithEvents MoviesDir As System.Windows.Forms.TextBox
    Friend WithEvents MoviesLabel As System.Windows.Forms.Label
    Friend WithEvents VideosDir As System.Windows.Forms.TextBox
    Friend WithEvents VideosLabel As System.Windows.Forms.Label
    Friend WithEvents MusicDir As System.Windows.Forms.TextBox
    Friend WithEvents MusicLabel As System.Windows.Forms.Label
    Friend WithEvents iTunesContentButton As System.Windows.Forms.Button
    Friend WithEvents WindowsContentButton As System.Windows.Forms.Button
    Friend WithEvents DCIMCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents exeptionLabel As System.Windows.Forms.Label
    Friend WithEvents AirSynxButton As System.Windows.Forms.Button
    Friend WithEvents HelpSiteButton As System.Windows.Forms.Button
    Friend WithEvents MusicBrowse As System.Windows.Forms.Button
    Friend WithEvents VideosBrowse As System.Windows.Forms.Button
    Friend WithEvents MoviesBrowse As System.Windows.Forms.Button
    Friend WithEvents PicturesBrowse As System.Windows.Forms.Button
    Friend WithEvents DevDrvBrowse As System.Windows.Forms.Button

End Class
