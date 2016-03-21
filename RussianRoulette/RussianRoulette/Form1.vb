Public Class Form1
    Public Name1 As String
    Dim HighScoreName As String
    Dim HighScore As Integer
    Dim Path As String = "\\telmar\users\CK025\My Documents\Visual Studio 2013\Projects\RussianRoulette\RussianRoulette\Assessment Resources\HighScores.txt"
    Public Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Name1 = txtName.Text
        If Name1 = "" Then
            MsgBox("Please enter a name to continue")
        Else
            Me.Hide()
            Game.Show()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnHighScores_Click(sender As Object, e As EventArgs)
        Me.Hide()
        HighScores.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FileNum As Integer
        BackColor = Color.Black
        FileNum = FreeFile()
        FileOpen(FileNum, Path, OpenMode.Input)
        HighScoreName = LineInput(FileNum)
        HighScore = LineInput(FileNum)
        FileClose(FileNum)
        lblHighScore.Text = ("Highest Scoring Player: " & HighScoreName & vbCrLf & "           Their Score: " & HighScore)
    End Sub
End Class
