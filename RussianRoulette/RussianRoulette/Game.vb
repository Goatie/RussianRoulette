Public Class Game
    Dim Random As New Random
    Dim BulletCount As Integer = 0
    Dim FreeShots As Integer = 2
    Dim Danger As Boolean
    Dim RandomNumber As Integer
    Dim Loaded As Boolean = False
    Public Score As Integer = 0
    Dim HighScore As Integer
    Dim HighScoreName As String
    Dim Winner As Boolean = False
    Public Name1 As String
    Dim Path As String = "\\telmar\users\CK025\My Documents\Visual Studio 2013\Projects\RussianRoulette\RussianRoulette\Assessment Resources\HighScores.txt"
    Private Sub btnSelf_Click(sender As Object, e As EventArgs) Handles btnSelf.Click
        pbGun.Image = My.Resources.Revolver_Front   '           Changes the image of the gun to point towards you when you click the button
        Danger = True
    End Sub

    Private Sub btnAway_Click(sender As Object, e As EventArgs) Handles btnAway.Click
        pbGun.Image = My.Resources.Revolver_Back '           Changes the image of the gun to point away from you when you click the button
        Danger = False
    End Sub

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click



        If Loaded = False Then
            MsgBox("You must load the gun to play the game")        'Stops the player from playing the game until they load the gun

        Else

            BulletCount = BulletCount + 1

            BulletHide()                                            'Adds 1 to the amount of bullets fired and hides one bullet icon

            If BulletCount <> RandomNumber Then                     'Plays a dry fire sound if the bullet count does not equal the random number
                My.Computer.Audio.Play("\\telmar\users\CK025\My Documents\Visual Studio 2013\Projects\RussianRoulette\RussianRoulette\Assessment Resources\Dry Fire Gun.wav")
            End If

            If BulletCount = RandomNumber Then                      'Plays a shooting sound if the player fires when the player fires and the random number equals the amount of bullets fired
                My.Computer.Audio.Play("\\telmar\users\CK025\My Documents\Visual Studio 2013\Projects\RussianRoulette\RussianRoulette\Assessment Resources\GUN_FIRE.wav")
            End If

            If Danger = False Then                                  'If the player points the gun away from them then they lose one free shot
                FreeShots = FreeShots - 1
            End If

            lblFreeShots.Text = ("Free Shots Remaning: " & FreeShots)

            If FreeShots <= 0 Then                                  'If there are 0 or less free shots remaning then the shoot away button is disabled and the gun is pointed towards the player

                lblFreeShots.Text = "Free Shots Remaning: 0"

                btnAway.Enabled = False

                FreeShots = FreeShots - 1

                If Danger = False And BulletCount = RandomNumber Then
                    Win()                                           'But if it is their last shot and they shoot away when the gun would fire then they win 
                End If

                Danger = True
                pbGun.Image = My.Resources.Revolver_Front

            End If

            If Winner = False And BulletCount = RandomNumber And Danger = True Then
                MsgBox("You Died!")
                If Score >= 0 Then
                    SubmitScore()                                   'If the Win() subroutine has not been run and the player does not shoot away when the bullet would be fired then they lose
                End If
                Me.Close()                                          'The game checks if the player's score has beaten the previous highscore and if so, then their name and score are set as the highscore

            Else

                If Danger = False And BulletCount = RandomNumber Then
                    Win()                                           'If the player wins on their first free shot then they are set as the winner and a new round begins
                End If
            End If
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        My.Computer.Audio.Play("\\telmar\users\CK025\My Documents\Visual Studio 2013\Projects\RussianRoulette\RussianRoulette\Assessment Resources\Spinning_Cylinder_Clicky_005.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("\\telmar\users\CK025\My Documents\Visual Studio 2013\Projects\RussianRoulette\RussianRoulette\Assessment Resources\Cylinder_Closed_002.wav")

        Loaded = True           'When the player loads the gun it plays 2 sound effects, the game waits for the first sound to finish playing before it starts playing the second
        Winner = False
        RandomNumber = Random.Next(1, 7)
        pbGun.Image = My.Resources.Revolver_Front
        Danger = True           'It also sets the gun to be pointed at the player
        btnLoad.Enabled = False
        btnLoad.Visible = False
    End Sub
    Private Sub BulletHide()        'This subroutine hides a bullet for each time the shoot button is pressed
        If BulletCount = 1 Then
            pbBullet6.Hide()
        End If
        If BulletCount = 2 Then
            pbBullet5.Hide()
        End If
        If BulletCount = 3 Then
            pbBullet4.Hide()
        End If
        If BulletCount = 4 Then
            pbBullet3.Hide()
        End If
        If BulletCount = 5 Then
            pbBullet2.Hide()
        End If
        If BulletCount = 6 Then
            pbBullet1.Hide()
        End If
    End Sub
    Private Sub Win()
        MsgBox("You Won!")
        Score = Score + 1
        lblRounds.Text = ("Rounds Won By " & Name1 & ": " & Score)  'Increases the player's wins by 1 and resets the game
        MsgBox("New Round")
        Loaded = False
        btnLoad.Enabled = True
        btnLoad.Visible = True
        FreeShots = 2
        BulletCount = 0
        btnAway.Enabled = True
        RandomNumber = Random.Next(1, 7)
        pbGun.Image = My.Resources.Revolver_Front
        Danger = True
        lblFreeShots.Text = ("Free Shots Remaning: " & FreeShots)
        pbBullet1.Show()
        pbBullet2.Show()
        pbBullet3.Show()
        pbBullet4.Show()
        pbBullet5.Show()
        pbBullet6.Show()
        Winner = True
    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FileNum As Integer
        Name1 = Form1.Name1
        lblRounds.Text = ("Rounds Won By " & Name1 & ": " & Score)
        BackColor = Color.Black
        lblFreeShots.ForeColor = Color.Red
        lblRounds.ForeColor = Color.Red
        lblHighscore.ForeColor = Color.Red

        FileNum = FreeFile()
        FileOpen(FileNum, Path, OpenMode.Input)         'Loads the recorded highscore
        HighScoreName = LineInput(FileNum)
        HighScore = LineInput(FileNum)
        FileClose(FileNum)
        lblHighscore.Text = ("Highest Scoring Player: " & HighScoreName & vbCrLf & "Their Score: " & HighScore)
    End Sub
    Public Sub SubmitScore()
        Dim FileNum As Integer
        If Score > HighScore Then
            HighScore = Score
            FileNum = FreeFile()
            FileOpen(FileNum, Path, OpenMode.Output)
            PrintLine(FileNum, Name1)
            PrintLine(FileNum, HighScore)
            FileClose(FileNum)
        End If
    End Sub
End Class