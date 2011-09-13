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
                My.Computer.FileSystem.CopyDirectory(VideosDir.Text, DevDrv.Text)
            Else
                MessageBox.Show("Sorry I can not find your videos folder, does it exist? If you do not want to Synx your Videos please ignore this message.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If My.Computer.FileSystem.DirectoryExists(MoviesDir.Text) Then
                My.Computer.FileSystem.CopyDirectory(MoviesDir.Text, DevDrv.Text)
            Else
                MessageBox.Show("Sorry I can not find your movies folder, does it exist? If you do not want to Synx your Movies please ignore this message.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If My.Computer.FileSystem.DirectoryExists(PicturesDir.Text) Then
                My.Computer.FileSystem.CopyDirectory(PicturesDir.Text, DevDrv.Text)
            Else
                MessageBox.Show("Sorry I can not find your pictures folder, does it exist? If you do not want to Synx your Pictures please ignore this message.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Sorry I can not find your phone, is USB Storage turned on?", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''declaration of our list, windowHandle is the handle of the window 
        ''you want the JumpList to be attached to
        'Dim list As JumpList = JumpList.CreateJumpListForIndividualWindow(TaskbarManager.Instance.ApplicationId, windowHandle)

        ''defining a new Custom Category called Actions
        'Dim userActionsCategory As New JumpListCustomCategory("Actions")

        ''defining the JumpListLink "Clear History"
        'Dim userActionLink As New JumpListLink(Assembly.GetEntryAssembly().Location, "Clear History")
        'userActionLink.Arguments = "-1"

        ''add this link to the Actions Category
        'userActionsCategory.AddJumpListItems(userActionLink)

        ''finally add the category to the JumpList
        'list.AddCustomCategories(userActionsCategory)
    End Sub
End Class
