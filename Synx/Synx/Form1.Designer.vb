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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ClassicSynxButton = New System.Windows.Forms.Button()
        Me.PicturesCheckBox = New System.Windows.Forms.CheckBox()
        Me.MoviesCheckBox = New System.Windows.Forms.CheckBox()
        Me.VideosCheckBox = New System.Windows.Forms.CheckBox()
        Me.MusicCheckBox = New System.Windows.Forms.CheckBox()
        Me.PicturesDir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MoviesDir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VideosDir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MusicDir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DCIMCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SynxButton
        '
        Me.SynxButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SynxButton.Location = New System.Drawing.Point(432, 303)
        Me.SynxButton.Name = "SynxButton"
        Me.SynxButton.Size = New System.Drawing.Size(180, 147)
        Me.SynxButton.TabIndex = 0
        Me.SynxButton.Text = "SYNX!"
        Me.SynxButton.UseVisualStyleBackColor = True
        '
        'DevDrv
        '
        Me.DevDrv.Location = New System.Drawing.Point(432, 48)
        Me.DevDrv.MaxLength = 4
        Me.DevDrv.Name = "DevDrv"
        Me.DevDrv.Size = New System.Drawing.Size(49, 20)
        Me.DevDrv.TabIndex = 8
        Me.DevDrv.Text = "e.g. E:\"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(429, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Android Device Drive"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(323, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "About Synx"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 274)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Submit an Idea/Bug!"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(127, 274)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(190, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Upload a patch to make Synx better!"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(6, 303)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 97)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Follow us on Google+"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ClassicSynxButton
        '
        Me.ClassicSynxButton.Location = New System.Drawing.Point(432, 274)
        Me.ClassicSynxButton.Name = "ClassicSynxButton"
        Me.ClassicSynxButton.Size = New System.Drawing.Size(75, 23)
        Me.ClassicSynxButton.TabIndex = 20
        Me.ClassicSynxButton.Text = "Classic Synx"
        Me.ClassicSynxButton.UseVisualStyleBackColor = True
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
        Me.PicturesDir.Size = New System.Drawing.Size(405, 20)
        Me.PicturesDir.TabIndex = 28
        Me.PicturesDir.Text = "e.g. C:\Users\Example\Pictures"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 18)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Pictures Directory:"
        '
        'MoviesDir
        '
        Me.MoviesDir.Location = New System.Drawing.Point(6, 159)
        Me.MoviesDir.Name = "MoviesDir"
        Me.MoviesDir.Size = New System.Drawing.Size(405, 20)
        Me.MoviesDir.TabIndex = 26
        Me.MoviesDir.Text = "e.g. C:\Users\Example\Videos\Movies"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Movies Directory:"
        '
        'VideosDir
        '
        Me.VideosDir.Location = New System.Drawing.Point(6, 92)
        Me.VideosDir.Name = "VideosDir"
        Me.VideosDir.Size = New System.Drawing.Size(405, 20)
        Me.VideosDir.TabIndex = 24
        Me.VideosDir.Text = "e.g. C:\Users\Example\Videos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Videos Directory:"
        '
        'MusicDir
        '
        Me.MusicDir.Location = New System.Drawing.Point(6, 25)
        Me.MusicDir.Name = "MusicDir"
        Me.MusicDir.Size = New System.Drawing.Size(405, 20)
        Me.MusicDir.TabIndex = 22
        Me.MusicDir.Text = "e.g. C:\Users\Example\Music"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Music Directory:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Find iTunes content"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(432, 74)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(160, 23)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Find Default Windows Content"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DCIMCheckBox
        '
        Me.DCIMCheckBox.AutoSize = True
        Me.DCIMCheckBox.Location = New System.Drawing.Point(118, 252)
        Me.DCIMCheckBox.Name = "DCIMCheckBox"
        Me.DCIMCheckBox.Size = New System.Drawing.Size(96, 17)
        Me.DCIMCheckBox.TabIndex = 35
        Me.DCIMCheckBox.Text = "Back up DCIM"
        Me.DCIMCheckBox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 438)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(355, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "When you Synx you may get an exeption, just click continue and ignore it."
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 454)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DCIMCheckBox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PicturesCheckBox)
        Me.Controls.Add(Me.MoviesCheckBox)
        Me.Controls.Add(Me.VideosCheckBox)
        Me.Controls.Add(Me.MusicCheckBox)
        Me.Controls.Add(Me.PicturesDir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MoviesDir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.VideosDir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MusicDir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ClassicSynxButton)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ClassicSynxButton As System.Windows.Forms.Button
    Friend WithEvents PicturesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MoviesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents VideosCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MusicCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PicturesDir As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MoviesDir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents VideosDir As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MusicDir As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DCIMCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
