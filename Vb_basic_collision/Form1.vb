Public Class Form1
    Dim goUp As Boolean = False
    Dim goDown As Boolean = False
    Dim goLeft As Boolean = False
    Dim goRight As Boolean = False
    Dim playerSpeed As Integer = 10

    Private Sub Keydown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Up) Then
            goUp = True

        End If
        If (e.KeyCode = Keys.Down) Then
            goDown = True

        End If
        If (e.KeyCode = Keys.Left) Then
            goLeft = True

        End If
        If (e.KeyCode = Keys.Right) Then
            goRight = True

        End If


    End Sub

    Private Sub Keyup(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        goUp = False


        goDown = False


        goLeft = False


        goRight = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If goUp = True Then
            player.Top = player.Top - playerSpeed
        End If

        If goDown = True Then
            player.Top = player.Top + playerSpeed
        End If

        If goLeft = True Then
            player.Left = player.Left - playerSpeed

        End If

        If goRight = True Then
            player.Left = player.Left + playerSpeed
        End If

        If Collision(player, PictureBox1) = True Then

            PictureBox1.Dispose()
        End If

        If Collision(player, PictureBox2) = True Then

            PictureBox2.Dispose()

        End If


    End Sub



    Private Function Collision(ByVal Player1 As Object, ByVal Enemy1 As Object) As Boolean
        Dim Collide As Boolean = False

        If Player1.Top + Player1.Height >= Enemy1.Top And
           Enemy1.Top + Enemy1.Height >= Player1.Top And
            Player1.Left + Player1.Width >= Enemy1.Left And
            Enemy1.Left + Enemy1.Width >= Player1.Left Then
            Collide = True
            Console.WriteLine(Collision)


        End If

        Return Collide



    End Function

    Private Sub player_Click(sender As Object, e As EventArgs) Handles player.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
