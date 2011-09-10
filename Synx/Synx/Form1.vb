Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        About.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.DirectoryExists(DevDrv.Text) Then
            If My.Computer.FileSystem.DirectoryExists(MusicDir.Text) Then
                My.Computer.FileSystem.CopyDirectory(MusicDir.Text, DevDrv.Text)
            Else
                MessageBox.Show("Sorry I can not find your music folder, does it exist? If you do not want to Synx your Music please ignore this message.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If My.Computer.FileSystem.DirectoryExists(VideosDir.Text) Then
                'Copy files to DevDrv
            Else
                MessageBox.Show("Sorry I can not find your videos folder, does it exist? If you do not want to Synx your Videos please ignore this message.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If My.Computer.FileSystem.DirectoryExists(MoviesDir.Text) Then
                'Copy files to DevDrv
            Else
                MessageBox.Show("Sorry I can not find your movies folder, does it exist? If you do not want to Synx your Movies please ignore this message.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If My.Computer.FileSystem.DirectoryExists(PicturesDir.Text) Then
                'Copy files to DevDrv
            Else
                MessageBox.Show("Sorry I can not find your pictures folder, does it exist? If you do not want to Synx your Pictures please ignore this message.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Sorry I can not find your phone, is USB Storage turned on?", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
