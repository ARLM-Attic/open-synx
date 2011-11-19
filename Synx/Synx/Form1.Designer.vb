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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MusicDir = New System.Windows.Forms.TextBox()
        Me.VideosDir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MoviesDir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DevDrv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PicturesDir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MusicCheckBox = New System.Windows.Forms.CheckBox()
        Me.VideosCheckBox = New System.Windows.Forms.CheckBox()
        Me.MoviesCheckBox = New System.Windows.Forms.CheckBox()
        Me.PicturesCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ClassicSynxButton = New System.Windows.Forms.Button()
        Me.D2PCSynxButton = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SynxButton
        '
        Me.SynxButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 85.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SynxButton.Location = New System.Drawing.Point(12, 12)
        Me.SynxButton.Name = "SynxButton"
        Me.SynxButton.Size = New System.Drawing.Size(406, 197)
        Me.SynxButton.TabIndex = 0
        Me.SynxButton.Text = "SYNX!"
        Me.SynxButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Music Directory:"
        '
        'MusicDir
        '
        Me.MusicDir.Location = New System.Drawing.Point(12, 263)
        Me.MusicDir.Name = "MusicDir"
        Me.MusicDir.Size = New System.Drawing.Size(405, 20)
        Me.MusicDir.TabIndex = 2
        Me.MusicDir.Text = "e.g. C:\Users\Example\Music"
        '
        'VideosDir
        '
        Me.VideosDir.Location = New System.Drawing.Point(12, 308)
        Me.VideosDir.Name = "VideosDir"
        Me.VideosDir.Size = New System.Drawing.Size(405, 20)
        Me.VideosDir.TabIndex = 4
        Me.VideosDir.Text = "e.g. C:\Users\Example\Videos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Videos Directory:"
        '
        'MoviesDir
        '
        Me.MoviesDir.Location = New System.Drawing.Point(12, 353)
        Me.MoviesDir.Name = "MoviesDir"
        Me.MoviesDir.Size = New System.Drawing.Size(405, 20)
        Me.MoviesDir.TabIndex = 6
        Me.MoviesDir.Text = "e.g. C:\Users\Example\Videos\Movies"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Movies Directory:"
        '
        'DevDrv
        '
        Me.DevDrv.Location = New System.Drawing.Point(422, 34)
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
        Me.Label4.Location = New System.Drawing.Point(423, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Android Device Drive"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(426, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "About Synx"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PicturesDir
        '
        Me.PicturesDir.Location = New System.Drawing.Point(12, 398)
        Me.PicturesDir.Name = "PicturesDir"
        Me.PicturesDir.Size = New System.Drawing.Size(405, 20)
        Me.PicturesDir.TabIndex = 11
        Me.PicturesDir.Text = "e.g. C:\Users\Example\Pictures"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pictures Directory:"
        '
        'MusicCheckBox
        '
        Me.MusicCheckBox.AutoSize = True
        Me.MusicCheckBox.Location = New System.Drawing.Point(425, 265)
        Me.MusicCheckBox.Name = "MusicCheckBox"
        Me.MusicCheckBox.Size = New System.Drawing.Size(96, 17)
        Me.MusicCheckBox.TabIndex = 12
        Me.MusicCheckBox.Text = "Synx my Music"
        Me.MusicCheckBox.UseVisualStyleBackColor = True
        '
        'VideosCheckBox
        '
        Me.VideosCheckBox.AutoSize = True
        Me.VideosCheckBox.Location = New System.Drawing.Point(425, 311)
        Me.VideosCheckBox.Name = "VideosCheckBox"
        Me.VideosCheckBox.Size = New System.Drawing.Size(100, 17)
        Me.VideosCheckBox.TabIndex = 13
        Me.VideosCheckBox.Text = "Synx my Videos"
        Me.VideosCheckBox.UseVisualStyleBackColor = True
        '
        'MoviesCheckBox
        '
        Me.MoviesCheckBox.AutoSize = True
        Me.MoviesCheckBox.Location = New System.Drawing.Point(425, 355)
        Me.MoviesCheckBox.Name = "MoviesCheckBox"
        Me.MoviesCheckBox.Size = New System.Drawing.Size(102, 17)
        Me.MoviesCheckBox.TabIndex = 14
        Me.MoviesCheckBox.Text = "Synx my Movies"
        Me.MoviesCheckBox.UseVisualStyleBackColor = True
        '
        'PicturesCheckBox
        '
        Me.PicturesCheckBox.AutoSize = True
        Me.PicturesCheckBox.Location = New System.Drawing.Point(425, 401)
        Me.PicturesCheckBox.Name = "PicturesCheckBox"
        Me.PicturesCheckBox.Size = New System.Drawing.Size(106, 17)
        Me.PicturesCheckBox.TabIndex = 15
        Me.PicturesCheckBox.Text = "Synx my Pictures"
        Me.PicturesCheckBox.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(422, 63)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Submit an Idea/Bug!"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(422, 92)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(190, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Upload a patch to make Synx better!"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 499)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(833, 22)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(80, 17)
        Me.ToolStripStatusLabel1.Text = "Ready to Synx"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(426, 121)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 97)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Follow us on Google+"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ClassicSynxButton
        '
        Me.ClassicSynxButton.Location = New System.Drawing.Point(12, 215)
        Me.ClassicSynxButton.Name = "ClassicSynxButton"
        Me.ClassicSynxButton.Size = New System.Drawing.Size(75, 23)
        Me.ClassicSynxButton.TabIndex = 20
        Me.ClassicSynxButton.Text = "Classic Synx"
        Me.ClassicSynxButton.UseVisualStyleBackColor = True
        '
        'D2PCSynxButton
        '
        Me.D2PCSynxButton.Location = New System.Drawing.Point(93, 215)
        Me.D2PCSynxButton.Name = "D2PCSynxButton"
        Me.D2PCSynxButton.Size = New System.Drawing.Size(101, 23)
        Me.D2PCSynxButton.TabIndex = 21
        Me.D2PCSynxButton.Text = "Device 2 PC Synx"
        Me.D2PCSynxButton.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 521)
        Me.Controls.Add(Me.D2PCSynxButton)
        Me.Controls.Add(Me.ClassicSynxButton)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PicturesCheckBox)
        Me.Controls.Add(Me.MoviesCheckBox)
        Me.Controls.Add(Me.VideosCheckBox)
        Me.Controls.Add(Me.MusicCheckBox)
        Me.Controls.Add(Me.PicturesDir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DevDrv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MoviesDir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.VideosDir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MusicDir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SynxButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.Text = "Synx"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SynxButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MusicDir As System.Windows.Forms.TextBox
    Friend WithEvents VideosDir As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MoviesDir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DevDrv As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PicturesDir As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MusicCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents VideosCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MoviesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PicturesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ClassicSynxButton As System.Windows.Forms.Button
    Friend WithEvents D2PCSynxButton As System.Windows.Forms.Button

End Class
