﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.HelpSiteButton = New System.Windows.Forms.Button()
        Me.MusicBrowse = New System.Windows.Forms.Button()
        Me.VideosBrowse = New System.Windows.Forms.Button()
        Me.MoviesBrowse = New System.Windows.Forms.Button()
        Me.PicturesBrowse = New System.Windows.Forms.Button()
        Me.DevDrvBrowse = New System.Windows.Forms.Button()
        Me.DevDrvRButton = New System.Windows.Forms.RadioButton()
        Me.ASXRButton = New System.Windows.Forms.RadioButton()
        Me.ASXUsername = New System.Windows.Forms.TextBox()
        Me.ASXPassword = New System.Windows.Forms.TextBox()
        Me.LikeButton = New System.Windows.Forms.Button()
        Me.ASXSignupButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ASXkey = New System.Windows.Forms.TextBox()
        Me.keyhelpbutton = New System.Windows.Forms.Button()
        Me.WebsiteButton = New System.Windows.Forms.Button()
        Me.asxhelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SynxButton
        '
        Me.SynxButton.BackgroundImage = Global.Synx.My.Resources.Resources.button
        Me.SynxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SynxButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SynxButton.Location = New System.Drawing.Point(437, 293)
        Me.SynxButton.Name = "SynxButton"
        Me.SynxButton.Size = New System.Drawing.Size(207, 124)
        Me.SynxButton.TabIndex = 0
        Me.SynxButton.UseVisualStyleBackColor = False
        '
        'DevDrv
        '
        Me.DevDrv.Location = New System.Drawing.Point(437, 29)
        Me.DevDrv.MaxLength = 50
        Me.DevDrv.Name = "DevDrv"
        Me.DevDrv.Size = New System.Drawing.Size(98, 20)
        Me.DevDrv.TabIndex = 8
        Me.DevDrv.Text = "E:\"
        '
        'AboutButton
        '
        Me.AboutButton.Location = New System.Drawing.Point(372, 293)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(49, 23)
        Me.AboutButton.TabIndex = 9
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = False
        '
        'IdeaButton
        '
        Me.IdeaButton.Location = New System.Drawing.Point(6, 293)
        Me.IdeaButton.Name = "IdeaButton"
        Me.IdeaButton.Size = New System.Drawing.Size(113, 23)
        Me.IdeaButton.TabIndex = 16
        Me.IdeaButton.Text = "Submit an Idea/Bug!"
        Me.IdeaButton.UseVisualStyleBackColor = False
        '
        'PatchButton
        '
        Me.PatchButton.Location = New System.Drawing.Point(125, 293)
        Me.PatchButton.Name = "PatchButton"
        Me.PatchButton.Size = New System.Drawing.Size(190, 23)
        Me.PatchButton.TabIndex = 17
        Me.PatchButton.Text = "Upload a patch to make Synx better!"
        Me.PatchButton.UseVisualStyleBackColor = False
        '
        'FollowButton
        '
        Me.FollowButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FollowButton.Location = New System.Drawing.Point(6, 322)
        Me.FollowButton.Name = "FollowButton"
        Me.FollowButton.Size = New System.Drawing.Size(135, 95)
        Me.FollowButton.TabIndex = 19
        Me.FollowButton.Text = "Follow us on Google+"
        Me.FollowButton.UseVisualStyleBackColor = False
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
        Me.iTunesContentButton.Location = New System.Drawing.Point(437, 85)
        Me.iTunesContentButton.Name = "iTunesContentButton"
        Me.iTunesContentButton.Size = New System.Drawing.Size(109, 23)
        Me.iTunesContentButton.TabIndex = 33
        Me.iTunesContentButton.Text = "Find iTunes content"
        Me.iTunesContentButton.UseVisualStyleBackColor = False
        '
        'WindowsContentButton
        '
        Me.WindowsContentButton.Location = New System.Drawing.Point(437, 56)
        Me.WindowsContentButton.Name = "WindowsContentButton"
        Me.WindowsContentButton.Size = New System.Drawing.Size(160, 23)
        Me.WindowsContentButton.TabIndex = 34
        Me.WindowsContentButton.Text = "Find Default Windows Content"
        Me.WindowsContentButton.UseVisualStyleBackColor = False
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
        'HelpSiteButton
        '
        Me.HelpSiteButton.Location = New System.Drawing.Point(321, 293)
        Me.HelpSiteButton.Name = "HelpSiteButton"
        Me.HelpSiteButton.Size = New System.Drawing.Size(45, 23)
        Me.HelpSiteButton.TabIndex = 38
        Me.HelpSiteButton.Text = "Help"
        Me.HelpSiteButton.UseVisualStyleBackColor = False
        '
        'MusicBrowse
        '
        Me.MusicBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MusicBrowse.Location = New System.Drawing.Point(336, 23)
        Me.MusicBrowse.Name = "MusicBrowse"
        Me.MusicBrowse.Size = New System.Drawing.Size(75, 23)
        Me.MusicBrowse.TabIndex = 40
        Me.MusicBrowse.Text = "Browse..."
        Me.MusicBrowse.UseVisualStyleBackColor = False
        '
        'VideosBrowse
        '
        Me.VideosBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.VideosBrowse.Location = New System.Drawing.Point(336, 91)
        Me.VideosBrowse.Name = "VideosBrowse"
        Me.VideosBrowse.Size = New System.Drawing.Size(75, 23)
        Me.VideosBrowse.TabIndex = 41
        Me.VideosBrowse.Text = "Browse..."
        Me.VideosBrowse.UseVisualStyleBackColor = False
        '
        'MoviesBrowse
        '
        Me.MoviesBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MoviesBrowse.Location = New System.Drawing.Point(336, 157)
        Me.MoviesBrowse.Name = "MoviesBrowse"
        Me.MoviesBrowse.Size = New System.Drawing.Size(75, 23)
        Me.MoviesBrowse.TabIndex = 42
        Me.MoviesBrowse.Text = "Browse..."
        Me.MoviesBrowse.UseVisualStyleBackColor = False
        '
        'PicturesBrowse
        '
        Me.PicturesBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.PicturesBrowse.Location = New System.Drawing.Point(336, 225)
        Me.PicturesBrowse.Name = "PicturesBrowse"
        Me.PicturesBrowse.Size = New System.Drawing.Size(75, 23)
        Me.PicturesBrowse.TabIndex = 43
        Me.PicturesBrowse.Text = "Browse..."
        Me.PicturesBrowse.UseVisualStyleBackColor = False
        '
        'DevDrvBrowse
        '
        Me.DevDrvBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.DevDrvBrowse.Location = New System.Drawing.Point(541, 27)
        Me.DevDrvBrowse.Name = "DevDrvBrowse"
        Me.DevDrvBrowse.Size = New System.Drawing.Size(75, 23)
        Me.DevDrvBrowse.TabIndex = 44
        Me.DevDrvBrowse.Text = "Browse..."
        Me.DevDrvBrowse.UseVisualStyleBackColor = False
        '
        'DevDrvRButton
        '
        Me.DevDrvRButton.AutoSize = True
        Me.DevDrvRButton.Checked = True
        Me.DevDrvRButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DevDrvRButton.Location = New System.Drawing.Point(437, 3)
        Me.DevDrvRButton.Name = "DevDrvRButton"
        Me.DevDrvRButton.Size = New System.Drawing.Size(179, 22)
        Me.DevDrvRButton.TabIndex = 45
        Me.DevDrvRButton.TabStop = True
        Me.DevDrvRButton.Text = "Synx to Android device:"
        Me.DevDrvRButton.UseVisualStyleBackColor = True
        '
        'ASXRButton
        '
        Me.ASXRButton.AutoSize = True
        Me.ASXRButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ASXRButton.Location = New System.Drawing.Point(437, 114)
        Me.ASXRButton.Name = "ASXRButton"
        Me.ASXRButton.Size = New System.Drawing.Size(132, 22)
        Me.ASXRButton.TabIndex = 46
        Me.ASXRButton.Text = "Synx to AirSynx:"
        Me.ASXRButton.UseVisualStyleBackColor = True
        '
        'ASXUsername
        '
        Me.ASXUsername.Location = New System.Drawing.Point(437, 165)
        Me.ASXUsername.Name = "ASXUsername"
        Me.ASXUsername.Size = New System.Drawing.Size(179, 20)
        Me.ASXUsername.TabIndex = 47
        Me.ASXUsername.Text = "AirSynx Username"
        '
        'ASXPassword
        '
        Me.ASXPassword.Location = New System.Drawing.Point(437, 191)
        Me.ASXPassword.Name = "ASXPassword"
        Me.ASXPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ASXPassword.Size = New System.Drawing.Size(179, 20)
        Me.ASXPassword.TabIndex = 48
        Me.ASXPassword.Text = "AirSynx Password"
        '
        'LikeButton
        '
        Me.LikeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LikeButton.Location = New System.Drawing.Point(147, 322)
        Me.LikeButton.Name = "LikeButton"
        Me.LikeButton.Size = New System.Drawing.Size(135, 95)
        Me.LikeButton.TabIndex = 50
        Me.LikeButton.Text = "Like us on Facebook"
        Me.LikeButton.UseVisualStyleBackColor = False
        '
        'ASXSignupButton
        '
        Me.ASXSignupButton.Location = New System.Drawing.Point(437, 217)
        Me.ASXSignupButton.Name = "ASXSignupButton"
        Me.ASXSignupButton.Size = New System.Drawing.Size(109, 23)
        Me.ASXSignupButton.TabIndex = 51
        Me.ASXSignupButton.Text = "Sign up for AirSynx"
        Me.ASXSignupButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(437, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 23)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Get the AirSynx app"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ASXkey
        '
        Me.ASXkey.Location = New System.Drawing.Point(437, 139)
        Me.ASXkey.Name = "ASXkey"
        Me.ASXkey.Size = New System.Drawing.Size(179, 20)
        Me.ASXkey.TabIndex = 53
        Me.ASXkey.Text = "Access Key"
        '
        'keyhelpbutton
        '
        Me.keyhelpbutton.Location = New System.Drawing.Point(622, 138)
        Me.keyhelpbutton.Name = "keyhelpbutton"
        Me.keyhelpbutton.Size = New System.Drawing.Size(22, 21)
        Me.keyhelpbutton.TabIndex = 54
        Me.keyhelpbutton.Text = "?"
        Me.keyhelpbutton.UseVisualStyleBackColor = False
        '
        'WebsiteButton
        '
        Me.WebsiteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebsiteButton.Location = New System.Drawing.Point(288, 322)
        Me.WebsiteButton.Name = "WebsiteButton"
        Me.WebsiteButton.Size = New System.Drawing.Size(135, 95)
        Me.WebsiteButton.TabIndex = 55
        Me.WebsiteButton.Text = "Visit our Website"
        Me.WebsiteButton.UseVisualStyleBackColor = False
        '
        'asxhelp
        '
        Me.asxhelp.Location = New System.Drawing.Point(564, 116)
        Me.asxhelp.Name = "asxhelp"
        Me.asxhelp.Size = New System.Drawing.Size(22, 21)
        Me.asxhelp.TabIndex = 56
        Me.asxhelp.Text = "?"
        Me.asxhelp.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(647, 422)
        Me.Controls.Add(Me.asxhelp)
        Me.Controls.Add(Me.WebsiteButton)
        Me.Controls.Add(Me.keyhelpbutton)
        Me.Controls.Add(Me.ASXkey)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ASXSignupButton)
        Me.Controls.Add(Me.LikeButton)
        Me.Controls.Add(Me.ASXPassword)
        Me.Controls.Add(Me.ASXUsername)
        Me.Controls.Add(Me.ASXRButton)
        Me.Controls.Add(Me.DevDrvRButton)
        Me.Controls.Add(Me.DevDrvBrowse)
        Me.Controls.Add(Me.PicturesBrowse)
        Me.Controls.Add(Me.MoviesBrowse)
        Me.Controls.Add(Me.VideosBrowse)
        Me.Controls.Add(Me.MusicBrowse)
        Me.Controls.Add(Me.HelpSiteButton)
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
    Friend WithEvents HelpSiteButton As System.Windows.Forms.Button
    Friend WithEvents MusicBrowse As System.Windows.Forms.Button
    Friend WithEvents VideosBrowse As System.Windows.Forms.Button
    Friend WithEvents MoviesBrowse As System.Windows.Forms.Button
    Friend WithEvents PicturesBrowse As System.Windows.Forms.Button
    Friend WithEvents DevDrvBrowse As System.Windows.Forms.Button
    Friend WithEvents DevDrvRButton As System.Windows.Forms.RadioButton
    Friend WithEvents ASXRButton As System.Windows.Forms.RadioButton
    Friend WithEvents ASXUsername As System.Windows.Forms.TextBox
    Friend WithEvents ASXPassword As System.Windows.Forms.TextBox
    Friend WithEvents LikeButton As System.Windows.Forms.Button
    Friend WithEvents ASXSignupButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ASXkey As System.Windows.Forms.TextBox
    Friend WithEvents keyhelpbutton As System.Windows.Forms.Button
    Friend WithEvents WebsiteButton As System.Windows.Forms.Button
    Friend WithEvents asxhelp As System.Windows.Forms.Button

End Class
