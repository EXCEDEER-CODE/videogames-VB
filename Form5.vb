Public Class Form5

    Private Sub Button1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button1.KeyPress

        If e.KeyChar = "w" Then
            Timer3.Enabled = True
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.BackgroundImage() = PictureBox1.Image()
        PictureBox2.Top = PictureBox2.Top + 1
        PictureBox2.Top = PictureBox2.Top - 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Enabled = True
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles c2.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        c2.Left = c2.Left + 1
        If c2.Left = 735 Then
            MsgBox("perdiste")
            Timer3.Enabled = False
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        c1.Left = c1.Left + 2
        If c1.Left = 735 Then
            MsgBox("ganaste")
            Timer2.Enabled = False
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class