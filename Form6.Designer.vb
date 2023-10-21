<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.level1 = New System.Windows.Forms.PictureBox()
        Me.player1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bala = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.enemy1 = New System.Windows.Forms.PictureBox()
        Me.player2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.enemy2 = New System.Windows.Forms.PictureBox()
        Me.enemy3 = New System.Windows.Forms.PictureBox()
        CType(Me.level1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'level1
        '
        Me.level1.Image = Global.WindowsApplication8.My.Resources.Resources.contralevel
        Me.level1.Location = New System.Drawing.Point(-1, 1)
        Me.level1.Name = "level1"
        Me.level1.Size = New System.Drawing.Size(3455, 224)
        Me.level1.TabIndex = 0
        Me.level1.TabStop = False
        '
        'player1
        '
        Me.player1.BackColor = System.Drawing.Color.Transparent
        Me.player1.Image = Global.WindowsApplication8.My.Resources.Resources.LanceStandingR
        Me.player1.Location = New System.Drawing.Point(33, 74)
        Me.player1.Name = "player1"
        Me.player1.Size = New System.Drawing.Size(23, 34)
        Me.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player1.TabIndex = 1
        Me.player1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "contra-corriendo1.png")
        Me.ImageList1.Images.SetKeyName(1, "contracorriendo2.png")
        Me.ImageList1.Images.SetKeyName(2, "contracorriendo2.png")
        '
        'bala
        '
        Me.bala.BackColor = System.Drawing.Color.Transparent
        Me.bala.Image = Global.WindowsApplication8.My.Resources.Resources.New_Piskel
        Me.bala.Location = New System.Drawing.Point(62, 74)
        Me.bala.Name = "bala"
        Me.bala.Size = New System.Drawing.Size(32, 32)
        Me.bala.TabIndex = 3
        Me.bala.TabStop = False
        Me.bala.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'enemy1
        '
        Me.enemy1.BackColor = System.Drawing.Color.Transparent
        Me.enemy1.Image = Global.WindowsApplication8.My.Resources.Resources.RiflemanL
        Me.enemy1.Location = New System.Drawing.Point(621, 77)
        Me.enemy1.Name = "enemy1"
        Me.enemy1.Size = New System.Drawing.Size(55, 31)
        Me.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy1.TabIndex = 4
        Me.enemy1.TabStop = False
        '
        'player2
        '
        Me.player2.BackColor = System.Drawing.Color.Transparent
        Me.player2.Image = Global.WindowsApplication8.My.Resources.Resources.LanceJumpingR
        Me.player2.Location = New System.Drawing.Point(28, -90)
        Me.player2.Name = "player2"
        Me.player2.Size = New System.Drawing.Size(28, 96)
        Me.player2.TabIndex = 5
        Me.player2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication8.My.Resources.Resources.contracorriendo1
        Me.PictureBox3.Location = New System.Drawing.Point(209, 26)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 51)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'enemy2
        '
        Me.enemy2.BackColor = System.Drawing.Color.Transparent
        Me.enemy2.Image = Global.WindowsApplication8.My.Resources.Resources.RiflemanL
        Me.enemy2.Location = New System.Drawing.Point(1097, 77)
        Me.enemy2.Name = "enemy2"
        Me.enemy2.Size = New System.Drawing.Size(55, 31)
        Me.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy2.TabIndex = 7
        Me.enemy2.TabStop = False
        '
        'enemy3
        '
        Me.enemy3.BackColor = System.Drawing.Color.Transparent
        Me.enemy3.Image = Global.WindowsApplication8.My.Resources.Resources.RiflemanL
        Me.enemy3.Location = New System.Drawing.Point(1351, 77)
        Me.enemy3.Name = "enemy3"
        Me.enemy3.Size = New System.Drawing.Size(55, 31)
        Me.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy3.TabIndex = 8
        Me.enemy3.TabStop = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication8.My.Resources.Resources.contralevel
        Me.ClientSize = New System.Drawing.Size(796, 225)
        Me.Controls.Add(Me.enemy3)
        Me.Controls.Add(Me.enemy2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.player2)
        Me.Controls.Add(Me.enemy1)
        Me.Controls.Add(Me.bala)
        Me.Controls.Add(Me.player1)
        Me.Controls.Add(Me.level1)
        Me.DoubleBuffered = True
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.level1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents level1 As System.Windows.Forms.PictureBox
    Friend WithEvents player1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents bala As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents enemy1 As System.Windows.Forms.PictureBox
    Friend WithEvents player2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents enemy2 As System.Windows.Forms.PictureBox
    Friend WithEvents enemy3 As System.Windows.Forms.PictureBox
End Class
