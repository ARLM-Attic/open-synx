'File Created by Nick nick@etheralstudios.com
'File has been edited by:
'Nick nick@etheralstudios.com

Imports System.IO
Imports System

Public Class Home

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        About.Show()
    End Sub

    Private Sub SynxButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SynxButton.Click
        If My.Computer.FileSystem.DirectoryExists(DevDrv.Text) Then
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

            If MusicCheckBox.Checked Then
                If My.Computer.FileSystem.DirectoryExists(MusicDir.Text) Then
                    If My.Computer.FileSystem.DirectoryExists(DevDrvMusic) Then
                        My.Computer.FileSystem.CopyDirectory(DevDrvMusic, MusicDir.Text)
                        My.Computer.FileSystem.CopyDirectory(MusicDir.Text, DevDrvMusic)
                    Else
                        My.Computer.FileSystem.CreateDirectory(DevDrvMusic)
                        My.Computer.FileSystem.CopyDirectory(DevDrvPictures, PicturesDir.Text)
                        My.Computer.FileSystem.CopyDirectory(PicturesDir.Text, DevDrvPictures)
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
                        My.Computer.FileSystem.CopyDirectory(DevDrvPictures, PicturesDir.Text)
                        My.Computer.FileSystem.CopyDirectory(PicturesDir.Text, DevDrvPictures)
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
                        My.Computer.FileSystem.CopyDirectory(DevDrvMovies, MoviesDir.Text)
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
                        My.Computer.FileSystem.CopyDirectory(DevDrvPictures, PicturesDir.Text)
                        My.Computer.FileSystem.CopyDirectory(PicturesDir.Text, DevDrvPictures)
                    End If
                Else
                    MessageBox.Show("Sorry I can not find your Pictures folder, does it exist?", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        IssueTracker.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SubmitPatch.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GooglePlus.Show()
    End Sub

    Private Sub ClassicSynxButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassicSynxButton.Click
        If My.Computer.FileSystem.DirectoryExists(DevDrv.Text) Then
            If MusicCheckBox.Checked Then
                If My.Computer.FileSystem.DirectoryExists(MusicDir.Text) Then
                    My.Computer.FileSystem.CopyDirectory(MusicDir.Text, DevDrv.Text)
                Else
                    MessageBox.Show("Sorry I can not find your music folder, does it exist?", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            If VideosCheckBox.Checked Then
                If My.Computer.FileSystem.DirectoryExists(VideosDir.Text) Then
                    My.Computer.FileSystem.CopyDirectory(VideosDir.Text, DevDrv.Text)
                Else
                    MessageBox.Show("Sorry I can not find your videos folder, does it exist?", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            If MoviesCheckBox.Checked Then
                If My.Computer.FileSystem.DirectoryExists(MoviesDir.Text) Then
                    My.Computer.FileSystem.CopyDirectory(MoviesDir.Text, DevDrv.Text)
                Else
                    MessageBox.Show("Sorry I can not find your movies folder, does it exist?", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            If PicturesCheckBox.Checked Then
                If My.Computer.FileSystem.DirectoryExists(PicturesDir.Text) Then
                    My.Computer.FileSystem.CopyDirectory(PicturesDir.Text, DevDrv.Text)
                Else
                    MessageBox.Show("Sorry I can not find your pictures folder, does it exist?", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Else
            MessageBox.Show("Sorry I can not find your phone, is USB Storage turned on?", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
End Class