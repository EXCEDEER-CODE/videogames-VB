Public Class Form6
    Dim a As Integer
    Dim vida As Integer
    Private Sub Form6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "a" Then
            player1.Image = PictureBox3.Image
            level1.Left = level1.Left + 2
            enemy1.Left = enemy1.Left + 2
            enemy2.Left = enemy2.Left + 2
            enemy3.Left = enemy3.Left + 2
            player2.Top = 1000
            Timer1.Enabled = False
            level1.Image = Me.BackgroundImage

        End If
        If e.KeyChar = "d" Then
            player1.Image = PictureBox3.Image
            level1.Left = level1.Left - 2
            enemy1.Left = enemy1.Left - 2
            enemy2.Left = enemy2.Left - 2
            enemy3.Left = enemy3.Left - 2
            player2.Top = 1000
            Timer1.Enabled = False
            If enemy1.Left <= player1.Left Then
                Timer2.Enabled = True
            Else : Timer2.Enabled = False
            End If
            If level1.Left = -5000 Then
                Me.Hide()
                Form1.Show()
            End If
            level1.Image = Me.BackgroundImage
        End If
        If e.KeyChar = "j" Then
            bala.Left = player1.Left + 10
            bala.Visible = True
            For i = 0 To 950
                bala.Left = bala.Left + 1
                level1.Image = Me.BackgroundImage
                If bala.Left > enemy1.Left Then
                    enemy1.Top = 2000
                End If
                If bala.Left > enemy2.Left Then
                    enemy2.Top = 2000
                End If
                If bala.Left > enemy3.Left Then
                    enemy3.Top = 2000
                End If
            Next
            Timer2.Enabled = False
        End If
        If e.KeyChar = "w" Then
            player2.Top = player1.Top - 50
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


    End Sub
End Class