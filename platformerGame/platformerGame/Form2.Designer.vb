<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        player = New PictureBox()
        timerLeft = New Timer(components)
        timerRight = New Timer(components)
        timerUp = New Timer(components)
        timerGameLogic = New Timer(components)
        timerGravity = New Timer(components)
        picAir = New PictureBox()
        picGround = New PictureBox()
        airTime = New Timer(components)
        platform4 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        lblScore = New Label()
        btnStart = New Button()
        PictureBox1 = New PictureBox()
        PictureBox9 = New PictureBox()
        trophy = New PictureBox()
        CType(player, ComponentModel.ISupportInitialize).BeginInit()
        CType(picAir, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGround, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(trophy, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' player
        ' 
        player.BackColor = Color.Transparent
        player.Image = My.Resources.Resources.image__6_
        player.Location = New Point(0, 412)
        player.Name = "player"
        player.Size = New Size(50, 50)
        player.SizeMode = PictureBoxSizeMode.StretchImage
        player.TabIndex = 1
        player.TabStop = False
        ' 
        ' timerLeft
        ' 
        timerLeft.Interval = 20
        ' 
        ' timerRight
        ' 
        timerRight.Interval = 20
        ' 
        ' timerUp
        ' 
        timerUp.Enabled = True
        timerUp.Interval = 20
        ' 
        ' timerGameLogic
        ' 
        timerGameLogic.Interval = 20
        ' 
        ' timerGravity
        ' 
        timerGravity.Interval = 20
        ' 
        ' picAir
        ' 
        picAir.BackColor = Color.Transparent
        picAir.Location = New Point(-4, -6)
        picAir.Name = "picAir"
        picAir.Size = New Size(841, 401)
        picAir.TabIndex = 2
        picAir.TabStop = False
        ' 
        ' picGround
        ' 
        picGround.BackColor = Color.SandyBrown
        picGround.Location = New Point(-4, 439)
        picGround.Name = "picGround"
        picGround.Size = New Size(841, 25)
        picGround.TabIndex = 3
        picGround.TabStop = False
        ' 
        ' airTime
        ' 
        airTime.Interval = 50
        ' 
        ' platform4
        ' 
        platform4.BackColor = Color.DarkKhaki
        platform4.Location = New Point(102, 401)
        platform4.Name = "platform4"
        platform4.Size = New Size(100, 19)
        platform4.SizeMode = PictureBoxSizeMode.StretchImage
        platform4.TabIndex = 7
        platform4.TabStop = False
        platform4.Tag = "bound"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.DarkKhaki
        PictureBox2.Location = New Point(244, 376)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(316, 19)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        PictureBox2.Tag = "bound"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.DarkKhaki
        PictureBox3.Location = New Point(604, 323)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(100, 19)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        PictureBox3.Tag = "bound"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.DarkKhaki
        PictureBox4.Location = New Point(514, 260)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(46, 19)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        PictureBox4.Tag = "bound"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.DarkKhaki
        PictureBox5.Location = New Point(244, 260)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(100, 19)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        PictureBox5.Tag = "bound"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.DarkKhaki
        PictureBox6.Location = New Point(138, 189)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(100, 19)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 12
        PictureBox6.TabStop = False
        PictureBox6.Tag = "bound"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.DarkKhaki
        PictureBox7.Location = New Point(244, 108)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(316, 19)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 13
        PictureBox7.TabStop = False
        PictureBox7.Tag = "bound"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.DarkKhaki
        PictureBox8.Location = New Point(604, 64)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(100, 19)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 14
        PictureBox8.TabStop = False
        PictureBox8.Tag = "bound"
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScore.Location = New Point(12, 9)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(94, 24)
        lblScore.TabIndex = 15
        lblScore.Text = "Score: 0"
        ' 
        ' btnStart
        ' 
        btnStart.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(12, 53)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(89, 39)
        btnStart.TabIndex = 16
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.CadetBlue
        PictureBox1.BackgroundImage = My.Resources.Resources.image__8_
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(411, 323)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(27, 50)
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        PictureBox1.Tag = "cactus"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.CadetBlue
        PictureBox9.BackgroundImage = My.Resources.Resources.image__8_
        PictureBox9.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox9.Location = New Point(394, 64)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(27, 50)
        PictureBox9.TabIndex = 18
        PictureBox9.TabStop = False
        PictureBox9.Tag = "cactus"
        ' 
        ' trophy
        ' 
        trophy.BackgroundImageLayout = ImageLayout.Center
        trophy.Image = My.Resources.Resources.istockphoto_1398070734_612x612
        trophy.Location = New Point(658, 21)
        trophy.Name = "trophy"
        trophy.Size = New Size(46, 46)
        trophy.SizeMode = PictureBoxSizeMode.StretchImage
        trophy.TabIndex = 19
        trophy.TabStop = False
        trophy.Tag = "trophy1"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        BackgroundImage = My.Resources.Resources._360_F_49519769_g7gruSqdf6BI3iaVxL0Yu86wDnP429LZ
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(834, 461)
        Controls.Add(trophy)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox1)
        Controls.Add(btnStart)
        Controls.Add(lblScore)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(platform4)
        Controls.Add(player)
        Controls.Add(picGround)
        Controls.Add(picAir)
        Name = "Form2"
        Text = "Form2"
        CType(player, ComponentModel.ISupportInitialize).EndInit()
        CType(picAir, ComponentModel.ISupportInitialize).EndInit()
        CType(picGround, ComponentModel.ISupportInitialize).EndInit()
        CType(platform4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(trophy, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents player As PictureBox
    Friend WithEvents timerLeft As Timer
    Friend WithEvents timerRight As Timer
    Friend WithEvents timerUp As Timer
    Friend WithEvents timerGameLogic As Timer
    Friend WithEvents timerGravity As Timer
    Friend WithEvents picAir As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents airTime As Timer
    Friend WithEvents platform4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents trophy As PictureBox
End Class
