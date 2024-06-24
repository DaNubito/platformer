Imports System.Windows.Forms

Public Class Form1
    Dim movespeed As Integer = 20
    Dim score As Integer = 0
    Dim isGameRunning As Boolean = False
    Dim jumpSpeed As Integer = 10
    Dim force As Integer = 8
    Dim gravity As Integer = -10
    Dim isJumping As Boolean = False
    Dim isMovingLeft As Boolean = False
    Dim isMovingRight As Boolean = False
    Private airTime As Integer = 0.7

    Dim jumpDuration As Integer = 175
    Dim cooldownDuration As Integer = 250
    Dim jumpTimeRemaining As Integer
    Dim isCooldown As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnStart.Click, AddressOf StartGame

        AddHandler timerLeft.Tick, AddressOf GameLoop

        ' Set form properties
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf Form1_KeyDown
        AddHandler Me.KeyUp, AddressOf Form1_KeyUp
        timerGameLogic.Start()
    End Sub


    Private Sub StartGame(sender As Object, e As EventArgs)
        If isGameRunning Then
            RestartGame()
        Else
            btnStart.Visible = False
            isGameRunning = True
        End If
    End Sub

    Private Sub RestartGame()
        score = 0
        lblScore.Text = "Score: 0"

        ' Start game
        btnStart.Visible = False
        isGameRunning = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.A Then
            isMovingLeft = True
            timerLeft.Start()
        ElseIf e.KeyCode = Keys.D Then
            isMovingRight = True
            timerRight.Start()
        ElseIf e.KeyCode = Keys.W And Not isCooldown Then
            isJumping = True
            force = jumpSpeed
            jumpTimeRemaining = jumpDuration
            timerUp.Start()
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.A Then
            isMovingLeft = False
            timerLeft.Stop()
        ElseIf e.KeyCode = Keys.D Then
            isMovingRight = False
            timerRight.Stop()
        ElseIf e.KeyCode = Keys.W Then
            isJumping = False
            timerUp.Stop()
            StartCooldown()
        End If
    End Sub

    Private Sub GameLoop(sender As Object, e As EventArgs)
        ' Apply gravity
        player.Top += gravity

        ' Move player left or right
        If isMovingLeft Then
            player.Left -= 5
        ElseIf isMovingRight Then
            player.Left += 5
        End If

        ' Jumping logic
        If isJumping And force > 0 Then
            player.Top -= force
            force -= 1
        End If


        ' Check if player is falling off the screen
        If player.Top + player.Height > Me.ClientSize.Height Then
            MessageBox.Show("Game Over! Score: " & score)
            btnStart.Text = "Restart"
            btnStart.Visible = True
            isGameRunning = False
        End If

        ' Update score
        score += 1
        lblScore.Text = "Score: " & score
    End Sub

    Private Sub timerLeft_Tick(sender As Object, e As EventArgs) Handles timerLeft.Tick
        player.Left = player.Left - movespeed
    End Sub

    Private Sub timerRight_Tick(sender As Object, e As EventArgs) Handles timerRight.Tick
        player.Left = player.Left + movespeed
    End Sub

    Private Sub timerUp_Tick(sender As Object, e As EventArgs) Handles timerUp.Tick
        player.Top = player.Top - movespeed
    End Sub

    Private Sub timerGameLogic_Tick(sender As Object, e As EventArgs) Handles timerGameLogic.Tick
        If player.Bounds.IntersectsWith(picAir.Bounds) Then
            If isJumping = False Then
                timerGravity.Start()
            End If
        ElseIf player.Bounds.IntersectsWith(picGround.Bounds) Then
            timerGravity.Stop()
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If player.Bounds.IntersectsWith(b.Bounds) Then
                        timerGravity.Stop()
                    End If
                End If
            End If
        Next

        For Each W As Control In Me.Controls
            If TypeOf W Is PictureBox Then
                If W.Tag = "trophy" Then
                    If player.Bounds.IntersectsWith(W.Bounds) Then
                        Me.Hide()
                        Form5.Show()
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub timerGravity_Tick(sender As Object, e As EventArgs) Handles timerGravity.Tick
        player.Top += movespeed
    End Sub

    Private Sub timerAir_Tick(sender As Object, e As EventArgs) Handles timerAir.Tick
        If airTime <= 0 Then
            timerAir.Stop()
        End If
    End Sub

    Private Sub StartCooldown()
        isCooldown = True
        Dim cooldownTimer As New Timer()
        cooldownTimer.Interval = cooldownDuration
        AddHandler cooldownTimer.Tick, Sub()
                                           isCooldown = False
                                           cooldownTimer.Stop()
                                       End Sub
        cooldownTimer.Start()
    End Sub
End Class