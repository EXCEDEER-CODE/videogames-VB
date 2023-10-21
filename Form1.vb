Public Class Form1

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles logo.Click
        My.Computer.Audio.Play("C:\atomic.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("C:\introvideogame.wav", AudioPlayMode.BackgroundLoop)
        music.Visible = True
        muted.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles music.Click
        My.Computer.Audio.Stop()
        music.Visible = False
        muted.Visible = True
    End Sub

    Private Sub muted_Click(sender As Object, e As EventArgs) Handles muted.Click
        My.Computer.Audio.Play("C:\introvideogame.wav", AudioPlayMode.BackgroundLoop)
        music.Visible = True
        muted.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\introvideogame.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub cmdjugar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        End
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        cmdopc.Visible = False
        cmdsalir.Visible = False
        cmdregre.Visible = True
        cmdmulti.Visible = True
        cmdsingle.Visible = True
    End Sub

    Private Sub cmdregre_Click(sender As Object, e As EventArgs) Handles cmdregre.Click
        cmdopc.Visible = True
        cmdsalir.Visible = True
        cmdregre.Visible = False
        cmdmulti.Visible = False
        cmdsingle.Visible = False
        cmdopc1.Visible = False
        cmdopc2.Visible = False
        cmdopc3.Visible = False
        cmdlevel1.visible = False
        cmdlevel2.Visible = False
        cmdlevel3.Visible = False
    End Sub

    Private Sub cmdopc_Click(sender As Object, e As EventArgs) Handles cmdopc.Click
        cmdopc1.Visible = True
        cmdopc2.Visible = True
        cmdopc3.Visible = True
        cmdregre.Visible = True
    End Sub

    Private Sub cmdlevel1_Click(sender As Object, e As EventArgs) Handles cmdlevel1.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub cmdlevel2_Click(sender As Object, e As EventArgs) Handles cmdlevel2.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub cmdlevel3_Click(sender As Object, e As EventArgs) Handles cmdlevel3.Click
        Me.Hide()
        My.Computer.Audio.Play("C:\contra.wav", AudioPlayMode.BackgroundLoop)
        Form6.Show()
    End Sub

    Private Sub cmdsingle_Click(sender As Object, e As EventArgs) Handles cmdsingle.Click
        cmdlevel1.Visible = True
        cmdlevel2.Visible = True
        cmdlevel3.Visible = True
    End Sub
End Class
