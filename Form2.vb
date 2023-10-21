Public Class Form2
    Dim vel As Double
    Dim dif As Integer

    Public Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        car1.Left = car1.Left + vel
        car2.Left = car2.Left + dif
        If vel > 0 Then
            vel = vel - 1
        End If
        If car1.Left > 740 Then
            Me.Hide()
            Form3.Show()
        End If
        If car2.Left > 740 Then
            Timer3.Enabled = True
        End If
    End Sub
    Public Sub Form2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

       
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.BackgroundImage() = PictureBox4.Image()
        c1.Top = c1.Top + 1
        c1.Top = c1.Top - 1
        c2.Top = c2.Top + 1
        c2.Top = c2.Top - 1
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles car1.Click

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub cmdinicio_Click(sender As Object, e As EventArgs) Handles cmdinicio.Click
        Timer2.Enabled = True
        vel = 0
        cmdfacil.Visible = False
        cmdnormal.Visible = False
        cmdificil.Visible = False
        cmdinicio.Visible = False
    End Sub

    Private Sub cmdfacil_Click(sender As Object, e As EventArgs) Handles cmdfacil.Click
        dif = 1
        cmdinicio.Visible = True
    End Sub

    Private Sub cmdnormal_Click(sender As Object, e As EventArgs) Handles cmdnormal.Click
        dif = 2
        cmdinicio.Visible = True
    End Sub

    Private Sub cmdificil_Click(sender As Object, e As EventArgs) Handles cmdificil.Click
        dif = 3
        cmdinicio.Visible = True
    End Sub

    Private Sub cmdinicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmdinicio.KeyPress
        If e.KeyChar = "a" Then
            c1.Left = c1.Left - 1
            c1.Image() = PictureBox8.Image()
            If c1.Left < 120 Then
                c1.Width = 150
                c1.Height = 150
                c1.Top = 100
                c1.Image() = explosion.Image()
                Timer3.Enabled = True
            End If
        End If
        If e.KeyChar = "d" Then
            c1.Left = c1.Left + 1
            c1.Image() = PictureBox6.Image()
            If c1.Left > 500 Then
                c1.Width = 150
                c1.Height = 150
                c1.Top = 100
                c1.Image() = explosion.Image()
                Timer3.Enabled = True
            End If
        End If
        If e.KeyChar = "w" Then
            If vel < 4 Then
                vel = vel + 1
            End If
            c1.Image() = PictureBox10.Image()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class