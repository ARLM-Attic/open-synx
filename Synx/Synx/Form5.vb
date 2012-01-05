Public Class AirSynx

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim LoginDetails As String
        LoginDetails = "http://asx" + username.Text + password.Text + ".etheralstudios.com/content"

        Process.Start(LoginDetails)
    End Sub
End Class