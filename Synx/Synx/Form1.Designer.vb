﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 85.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(405, 197)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SYNX!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Music Directory:"
        '
        'MusicDir
        '
        Me.MusicDir.Location = New System.Drawing.Point(13, 238)
        Me.MusicDir.Name = "MusicDir"
        Me.MusicDir.Size = New System.Drawing.Size(405, 20)
        Me.MusicDir.TabIndex = 2
        Me.MusicDir.Text = "e.g. C:\Users\Example\Music"
        '
        'VideosDir
        '
        Me.VideosDir.Location = New System.Drawing.Point(13, 283)
        Me.VideosDir.Name = "VideosDir"
        Me.VideosDir.Size = New System.Drawing.Size(405, 20)
        Me.VideosDir.TabIndex = 4
        Me.VideosDir.Text = "e.g. C:\Users\Example\Videos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Videos Directory:"
        '
        'MoviesDir
        '
        Me.MoviesDir.Location = New System.Drawing.Point(13, 328)
        Me.MoviesDir.Name = "MoviesDir"
        Me.MoviesDir.Size = New System.Drawing.Size(405, 20)
        Me.MoviesDir.TabIndex = 6
        Me.MoviesDir.Text = "e.g. C:\Users\Example\Videos\Movies"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Movies Directory:"
        '
        'DevDrv
        '
        Me.DevDrv.Location = New System.Drawing.Point(422, 34)
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
        Me.Button2.Location = New System.Drawing.Point(423, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "About Synx"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PicturesDir
        '
        Me.PicturesDir.Location = New System.Drawing.Point(13, 373)
        Me.PicturesDir.Name = "PicturesDir"
        Me.PicturesDir.Size = New System.Drawing.Size(405, 20)
        Me.PicturesDir.TabIndex = 11
        Me.PicturesDir.Text = "e.g. C:\Users\Example\Pictures"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pictures Directory:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 521)
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
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Synx"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
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

End Class
