<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.btnSelf = New System.Windows.Forms.Button()
        Me.btnAway = New System.Windows.Forms.Button()
        Me.lblFreeShots = New System.Windows.Forms.Label()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblRounds = New System.Windows.Forms.Label()
        Me.lblHighscore = New System.Windows.Forms.Label()
        Me.pbBullet6 = New System.Windows.Forms.PictureBox()
        Me.pbBullet5 = New System.Windows.Forms.PictureBox()
        Me.pbBullet4 = New System.Windows.Forms.PictureBox()
        Me.pbBullet3 = New System.Windows.Forms.PictureBox()
        Me.pbBullet2 = New System.Windows.Forms.PictureBox()
        Me.pbBullet1 = New System.Windows.Forms.PictureBox()
        Me.pbGun = New System.Windows.Forms.PictureBox()
        CType(Me.pbBullet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBullet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBullet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBullet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBullet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBullet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelf
        '
        Me.btnSelf.Location = New System.Drawing.Point(535, 173)
        Me.btnSelf.Name = "btnSelf"
        Me.btnSelf.Size = New System.Drawing.Size(104, 42)
        Me.btnSelf.TabIndex = 7
        Me.btnSelf.Text = "Point At Yourself"
        Me.btnSelf.UseVisualStyleBackColor = True
        '
        'btnAway
        '
        Me.btnAway.Location = New System.Drawing.Point(535, 242)
        Me.btnAway.Name = "btnAway"
        Me.btnAway.Size = New System.Drawing.Size(104, 42)
        Me.btnAway.TabIndex = 8
        Me.btnAway.Text = "Point Away"
        Me.btnAway.UseVisualStyleBackColor = True
        '
        'lblFreeShots
        '
        Me.lblFreeShots.AutoSize = True
        Me.lblFreeShots.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFreeShots.Location = New System.Drawing.Point(532, 58)
        Me.lblFreeShots.Name = "lblFreeShots"
        Me.lblFreeShots.Size = New System.Drawing.Size(161, 17)
        Me.lblFreeShots.TabIndex = 9
        Me.lblFreeShots.Text = "Free Shots Remaning: 2"
        '
        'btnFire
        '
        Me.btnFire.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnFire.Location = New System.Drawing.Point(280, 417)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(154, 49)
        Me.btnFire.TabIndex = 10
        Me.btnFire.Text = "FIRE!"
        Me.btnFire.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(535, 107)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(104, 42)
        Me.btnLoad.TabIndex = 11
        Me.btnLoad.Text = "Load the Gun"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblRounds
        '
        Me.lblRounds.AutoSize = True
        Me.lblRounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.lblRounds.Location = New System.Drawing.Point(12, 73)
        Me.lblRounds.Name = "lblRounds"
        Me.lblRounds.Size = New System.Drawing.Size(94, 15)
        Me.lblRounds.TabIndex = 12
        Me.lblRounds.Text = "Rounds Won : 0"
        '
        'lblHighscore
        '
        Me.lblHighscore.AutoSize = True
        Me.lblHighscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.lblHighscore.Location = New System.Drawing.Point(12, 98)
        Me.lblHighscore.Name = "lblHighscore"
        Me.lblHighscore.Size = New System.Drawing.Size(74, 15)
        Me.lblHighscore.TabIndex = 13
        Me.lblHighscore.Text = "High Score: "
        '
        'pbBullet6
        '
        Me.pbBullet6.Image = Global.RussianRoulette.My.Resources.Resources.RevolverBullet
        Me.pbBullet6.Location = New System.Drawing.Point(303, 505)
        Me.pbBullet6.Name = "pbBullet6"
        Me.pbBullet6.Size = New System.Drawing.Size(41, 101)
        Me.pbBullet6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBullet6.TabIndex = 6
        Me.pbBullet6.TabStop = False
        '
        'pbBullet5
        '
        Me.pbBullet5.Image = Global.RussianRoulette.My.Resources.Resources.RevolverBullet
        Me.pbBullet5.Location = New System.Drawing.Point(256, 505)
        Me.pbBullet5.Name = "pbBullet5"
        Me.pbBullet5.Size = New System.Drawing.Size(41, 101)
        Me.pbBullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBullet5.TabIndex = 5
        Me.pbBullet5.TabStop = False
        '
        'pbBullet4
        '
        Me.pbBullet4.Image = Global.RussianRoulette.My.Resources.Resources.RevolverBullet
        Me.pbBullet4.Location = New System.Drawing.Point(209, 505)
        Me.pbBullet4.Name = "pbBullet4"
        Me.pbBullet4.Size = New System.Drawing.Size(41, 101)
        Me.pbBullet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBullet4.TabIndex = 4
        Me.pbBullet4.TabStop = False
        '
        'pbBullet3
        '
        Me.pbBullet3.Image = Global.RussianRoulette.My.Resources.Resources.RevolverBullet
        Me.pbBullet3.Location = New System.Drawing.Point(162, 505)
        Me.pbBullet3.Name = "pbBullet3"
        Me.pbBullet3.Size = New System.Drawing.Size(41, 101)
        Me.pbBullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBullet3.TabIndex = 3
        Me.pbBullet3.TabStop = False
        '
        'pbBullet2
        '
        Me.pbBullet2.Image = Global.RussianRoulette.My.Resources.Resources.RevolverBullet
        Me.pbBullet2.Location = New System.Drawing.Point(115, 505)
        Me.pbBullet2.Name = "pbBullet2"
        Me.pbBullet2.Size = New System.Drawing.Size(41, 101)
        Me.pbBullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBullet2.TabIndex = 2
        Me.pbBullet2.TabStop = False
        '
        'pbBullet1
        '
        Me.pbBullet1.Image = Global.RussianRoulette.My.Resources.Resources.RevolverBullet
        Me.pbBullet1.Location = New System.Drawing.Point(68, 505)
        Me.pbBullet1.Name = "pbBullet1"
        Me.pbBullet1.Size = New System.Drawing.Size(41, 101)
        Me.pbBullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBullet1.TabIndex = 1
        Me.pbBullet1.TabStop = False
        '
        'pbGun
        '
        Me.pbGun.Image = Global.RussianRoulette.My.Resources.Resources.Revolver_Front
        Me.pbGun.InitialImage = Global.RussianRoulette.My.Resources.Resources.Revolver_Front
        Me.pbGun.Location = New System.Drawing.Point(226, 73)
        Me.pbGun.Name = "pbGun"
        Me.pbGun.Size = New System.Drawing.Size(253, 301)
        Me.pbGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGun.TabIndex = 0
        Me.pbGun.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 618)
        Me.Controls.Add(Me.lblHighscore)
        Me.Controls.Add(Me.lblRounds)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.lblFreeShots)
        Me.Controls.Add(Me.btnAway)
        Me.Controls.Add(Me.btnSelf)
        Me.Controls.Add(Me.pbBullet6)
        Me.Controls.Add(Me.pbBullet5)
        Me.Controls.Add(Me.pbBullet4)
        Me.Controls.Add(Me.pbBullet3)
        Me.Controls.Add(Me.pbBullet2)
        Me.Controls.Add(Me.pbBullet1)
        Me.Controls.Add(Me.pbGun)
        Me.Name = "Game"
        Me.Text = "Game"
        CType(Me.pbBullet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBullet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBullet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBullet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBullet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBullet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbGun As System.Windows.Forms.PictureBox
    Friend WithEvents pbBullet1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBullet2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBullet3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBullet4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBullet5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBullet6 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSelf As System.Windows.Forms.Button
    Friend WithEvents btnAway As System.Windows.Forms.Button
    Friend WithEvents lblFreeShots As System.Windows.Forms.Label
    Friend WithEvents btnFire As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents lblRounds As System.Windows.Forms.Label
    Friend WithEvents lblHighscore As System.Windows.Forms.Label
End Class
