﻿'File Created by Nick nick@etheralstudios.com
'File has been edited by:
'Nick nick@etheralstudios.com
'Rhys rhys@realmofconflict.com

' Synx the files from your android device to your windows box
' Note: the copies on the phone take precedence for all media types
' it first copies the files from the device to your computer then from
' your computer to your device.

Imports System.IO
Imports System

Public Class Home

    Private Sub AboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutButton.Click
        About.Show()
    End Sub

    Private Sub SynxButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SynxButton.Click
        ' Checks that the device specified exists - should be an android device
        If My.Computer.FileSystem.DirectoryExists(DevDrv.Text) Then
            ' Setting up vars for accesing the expected directories
            Dim DevDrvMusic As String
            DevDrvMusic = DevDrv.Text + "\" + "Music"
            Dim DevDrvVideos As String
            DevDrvVideos = DevDrv.Text + "\" + "Videos"
            Dim DevDrvMovies As String
            DevDrvMovies = DevDrv.Text + "\" + "Movies"
            Dim DevDrvPictures As String
            DevDrvPictures = DevDrv.Text + "\" + "Pictures"
            Dim DevDrvDCIM As String
            DevDrvDCIM = DevDrv.Text + "\" + "DCIM" + "\" + "Camera"

            ' If the directory does not exist on the device drive it will be
            ' created. If it does not exist on the computer an error msg is
            ' printed. Files are copied device drive to computer and then
            ' from the computer to the device drive.
            ' This is repeated for each media type.
            If MusicCheckBox.Checked Then
                If My.Computer.FileSystem.DirectoryExists(MusicDir.Text) Then
                    If My.Computer.FileSystem.DirectoryExists(DevDrvMusic) Then
                        My.Computer.FileSystem.CopyDirectory(DevDrvMusic, MusicDir.Text)
                        My.Computer.FileSystem.CopyDirectory(MusicDir.Text, DevDrvMusic)
                    Else
                        My.Computer.FileSystem.CreateDirectory(DevDrvMusic)
                        My.Computer.FileSystem.CopyDirectory(MusicDir.Text, DevDrvMusic)
                    End If
                Else
                    MessageBox.Show("Sorry I can not find your Music folder, does it exist?", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            If VideosCheckBox.Checked Then
                If My.Computer.FileSystem.DirectoryExists(VideosDir.Text) Then
                    If My.Computer.FileSystem.DirectoryExists(DevDrvVideos) Then
                        My.Computer.FileSystem.CopyDirectory(DevDrvVideos, VideosDir.Text)
                        My.Computer.FileSystem.CopyDirectory(VideosDir.Text, DevDrvVideos)
                    Else
                        My.Computer.FileSystem.CreateDirectory(DevDrvVideos)
                        My.Computer.FileSystem.CopyDirectory(VideosDir.Text, DevDrvVideos)
                    End If
                Else
                    MessageBox.Show("Sorry I can not find your Videos folder, does it exist?", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            If MoviesCheckBox.Checked Then
                If My.Computer.FileSystem.DirectoryExists(MoviesDir.Text) Then
                    If My.Computer.FileSystem.DirectoryExists(DevDrvMovies) Then
                        My.Computer.FileSystem.CopyDirectory(DevDrvMovies, MoviesDir.Text)
                        My.Computer.FileSystem.CopyDirectory(MoviesDir.Text, DevDrvMovies)
                    Else
                        My.Computer.FileSystem.CreateDirectory(DevDrvMovies)
                        My.Computer.FileSystem.CopyDirectory(MoviesDir.Text, DevDrvMovies)
                    End If
                Else
                    MessageBox.Show("Sorry I can not find your Movies folder, does it exist?", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            If PicturesCheckBox.Checked Then
                If My.Computer.FileSystem.DirectoryExists(PicturesDir.Text) Then
                    If My.Computer.FileSystem.DirectoryExists(DevDrvPictures) Then
                        My.Computer.FileSystem.CopyDirectory(DevDrvPictures, PicturesDir.Text)
                        My.Computer.FileSystem.CopyDirectory(PicturesDir.Text, DevDrvPictures)
                    Else
                        My.Computer.FileSystem.CreateDirectory(DevDrvPictures)
                        My.Computer.FileSystem.CopyDirectory(PicturesDir.Text, DevDrvPictures)
                    End If
                Else
                    MessageBox.Show("Sorry I can not find your Pictures folder, does it exist?", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

            ' Copying photos from your camera to the pictures folder on your computer
            ' this will have the affect that the next time you synx they will be copied back up to the pictures folder on your device
            ' resulting in duplicate copies on your device one in DCIM and one in the pictures folder
            If DCIMCheckBox.Checked Then
                If My.Computer.FileSystem.DirectoryExists(PicturesDir.Text) Then
                    If My.Computer.FileSystem.DirectoryExists(DevDrvDCIM) Then
                        My.Computer.FileSystem.CopyDirectory(DevDrvDCIM, PicturesDir.Text)
                    End If
                End If
            End If
        Else
            MessageBox.Show("Sorry I can not find your phone, is USB Storage turned on?", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub IdeaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdeaButton.Click
        IssueTracker.Show()
    End Sub

    Private Sub PatchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatchButton.Click
        SubmitPatch.Show()
    End Sub

    Private Sub FollowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FollowButton.Click
        GooglePlus.Show()
    End Sub
    Private Sub WindowsContentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsContentButton.Click
        Dim SystemMusic As String
        SystemMusic = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
        Dim SystemVideos As String
        SystemVideos = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
        Dim SystemPictures As String
        SystemPictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

        MusicDir.Text = SystemMusic
        VideosDir.Text = SystemVideos
        PicturesDir.Text = SystemPictures
    End Sub

    Private Sub iTunesContentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iTunesContentButton.Click
        Dim iTunesMusic As String
        iTunesMusic = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\iTunes\iTunes Media\Music"
        Dim iTunesMovies As String
        iTunesMovies = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\iTunes\iTunes Media\Movies"

        MusicDir.Text = iTunesMusic
        MoviesDir.Text = iTunesMovies
    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SystemMusic As String
        SystemMusic = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
        Dim SystemVideos As String
        SystemVideos = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
        Dim SystemPictures As String
        SystemPictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

        MusicDir.Text = SystemMusic
        VideosDir.Text = SystemVideos
        PicturesDir.Text = SystemPictures
    End Sub

    Private Sub HelpSiteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpSiteButton.Click
        Help.Show()
    End Sub

    Private Sub AirSynxButton_Click(sender As System.Object, e As System.EventArgs) Handles AirSynxButton.Click

        If MusicCheckBox.Checked Then
            If My.Computer.FileSystem.DirectoryExists(MusicDir.Text) Then
                Process.Start("explorer.exe", MusicDir.Text)
                Process.Start("explorer.exe", "ftp://ftp.etheralstudios.com/Music")
                Me.WindowState = FormWindowState.Minimized

            Else
                MessageBox.Show("Sorry I can not find your Music folder, does it exist?", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        If PicturesCheckBox.Checked Then
            If My.Computer.FileSystem.DirectoryExists(PicturesDir.Text) Then
                Process.Start("explorer.exe", PicturesDir.Text)
                Process.Start("explorer.exe", "ftp://ftp.etheralstudios.com/Pictures")
                Me.WindowState = FormWindowState.Minimized

            Else
                MessageBox.Show("Sorry I can not find your Pictures folder, does it exist?", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        If VideosCheckBox.Checked Then
            If My.Computer.FileSystem.DirectoryExists(VideosDir.Text) Then
                Process.Start("explorer.exe", VideosDir.Text)
                Process.Start("explorer.exe", "ftp://ftp.etheralstudios.com/Videos")
                Me.WindowState = FormWindowState.Minimized

            Else
                MessageBox.Show("Sorry I can not find your Videos folder, does it exist?", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub MusicBrowse_Click(sender As System.Object, e As System.EventArgs) Handles MusicBrowse.Click
        Dim MusicBrowser As New FolderBrowserDialog
        MusicBrowser.Description = "Please select a Music Directory"
        MusicBrowser.SelectedPath = MusicDir.Text
        If MusicBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.MusicDir.Text = MusicBrowser.SelectedPath
        End If
    End Sub

    Private Sub VideosBrowse_Click(sender As System.Object, e As System.EventArgs) Handles VideosBrowse.Click
        Dim VideosBrowser As New FolderBrowserDialog
        VideosBrowser.Description = "Please select a Videos Directory"
        VideosBrowser.SelectedPath = VideosDir.Text
        If VideosBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.VideosDir.Text = VideosBrowser.SelectedPath
        End If
    End Sub

    Private Sub MoviesBrowse_Click(sender As System.Object, e As System.EventArgs) Handles MoviesBrowse.Click
        Dim MoviesBrowser As New FolderBrowserDialog
        MoviesBrowser.Description = "Please select a Movies Directory"
        MoviesBrowser.SelectedPath = MoviesDir.Text
        If MoviesBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.MoviesDir.Text = MoviesBrowser.SelectedPath
        End If
    End Sub

    Private Sub PicturesBrowse_Click(sender As System.Object, e As System.EventArgs) Handles PicturesBrowse.Click
        Dim PicturesBrowser As New FolderBrowserDialog
        PicturesBrowser.Description = "Please select a Pictures Directory"
        PicturesBrowser.SelectedPath = PicturesDir.Text
        If PicturesBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.PicturesDir.Text = PicturesBrowser.SelectedPath
        End If
    End Sub

    Private Sub DevDrvBrowse_Click(sender As System.Object, e As System.EventArgs) Handles DevDrvBrowse.Click
        Dim DeviceBrowser As New FolderBrowserDialog
        DeviceBrowser.Description = "Please select your Device"
        DeviceBrowser.SelectedPath = DevDrv.Text
        If DeviceBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.DevDrv.Text = DeviceBrowser.SelectedPath
        End If
    End Sub
End Class