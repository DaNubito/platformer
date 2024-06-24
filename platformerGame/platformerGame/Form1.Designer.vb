<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        player = New PictureBox()
        timerLeft = New Timer(components)
        lblScore = New Label()
        btnStart = New Button()
        platform3 = New PictureBox()
        platform1 = New PictureBox()
        platform5 = New PictureBox()
        platform4 = New PictureBox()
        platform2 = New PictureBox()
        platform6 = New PictureBox()
        platform7 = New PictureBox()
        platform8 = New PictureBox()
        platform9 = New PictureBox()
        timerRight = New Timer(components)
        timerUp = New Timer(components)
        timerGameLogic = New Timer(components)
        timerGravity = New Timer(components)
        picAir = New PictureBox()
        picGround = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        timerAir = New Timer(components)
        trophy = New PictureBox()
        CType(player, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform3, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform1, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform5, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform4, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform2, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform6, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform7, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform8, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform9, ComponentModel.ISupportInitialize).BeginInit()
        CType(picAir, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGround, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(trophy, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' player
        ' 
        player.BackColor = SystemColors.ActiveCaption
        player.Image = My.Resources.Resources.image__6_
        player.Location = New Point(0, 412)
        player.Name = "player"
        player.Size = New Size(50, 50)
        player.SizeMode = PictureBoxSizeMode.StretchImage
        player.TabIndex = 0
        player.TabStop = False
        ' 
        ' timerLeft
        ' 
        timerLeft.Interval = 20
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScore.Location = New Point(10, 11)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(94, 24)
        lblScore.TabIndex = 1
        lblScore.Text = "Score: 0"
        ' 
        ' btnStart
        ' 
        btnStart.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(10, 49)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(89, 39)
        btnStart.TabIndex = 2
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' platform3
        ' 
        platform3.BackColor = Color.IndianRed
        platform3.Location = New Point(434, 348)
        platform3.Name = "platform3"
        platform3.Size = New Size(100, 17)
        platform3.SizeMode = PictureBoxSizeMode.StretchImage
        platform3.TabIndex = 3
        platform3.TabStop = False
        platform3.Tag = "bound"
        ' 
        ' platform1
        ' 
        platform1.BackColor = Color.IndianRed
        platform1.Location = New Point(150, 403)
        platform1.Name = "platform1"
        platform1.Size = New Size(111, 19)
        platform1.SizeMode = PictureBoxSizeMode.StretchImage
        platform1.TabIndex = 4
        platform1.TabStop = False
        platform1.Tag = "bound"
        ' 
        ' platform5
        ' 
        platform5.BackColor = Color.IndianRed
        platform5.Location = New Point(161, 275)
        platform5.Name = "platform5"
        platform5.Size = New Size(100, 23)
        platform5.SizeMode = PictureBoxSizeMode.StretchImage
        platform5.TabIndex = 5
        platform5.TabStop = False
        platform5.Tag = "bound"
        ' 
        ' platform4
        ' 
        platform4.BackColor = Color.IndianRed
        platform4.Location = New Point(301, 308)
        platform4.Name = "platform4"
        platform4.Size = New Size(100, 19)
        platform4.SizeMode = PictureBoxSizeMode.StretchImage
        platform4.TabIndex = 6
        platform4.TabStop = False
        platform4.Tag = "bound"
        ' 
        ' platform2
        ' 
        platform2.BackColor = Color.IndianRed
        platform2.Location = New Point(301, 376)
        platform2.Name = "platform2"
        platform2.Size = New Size(100, 30)
        platform2.SizeMode = PictureBoxSizeMode.StretchImage
        platform2.TabIndex = 7
        platform2.TabStop = False
        platform2.Tag = "bound"
        ' 
        ' platform6
        ' 
        platform6.BackColor = Color.IndianRed
        platform6.Location = New Point(301, 233)
        platform6.Name = "platform6"
        platform6.Size = New Size(100, 21)
        platform6.SizeMode = PictureBoxSizeMode.StretchImage
        platform6.TabIndex = 8
        platform6.TabStop = False
        platform6.Tag = "bound"
        ' 
        ' platform7
        ' 
        platform7.BackColor = Color.IndianRed
        platform7.Location = New Point(434, 183)
        platform7.Name = "platform7"
        platform7.Size = New Size(100, 20)
        platform7.SizeMode = PictureBoxSizeMode.StretchImage
        platform7.TabIndex = 9
        platform7.TabStop = False
        platform7.Tag = "bound"
        ' 
        ' platform8
        ' 
        platform8.BackColor = Color.IndianRed
        platform8.Location = New Point(301, 141)
        platform8.Name = "platform8"
        platform8.Size = New Size(100, 19)
        platform8.SizeMode = PictureBoxSizeMode.StretchImage
        platform8.TabIndex = 10
        platform8.TabStop = False
        platform8.Tag = "bound"
        ' 
        ' platform9
        ' 
        platform9.BackColor = Color.IndianRed
        platform9.Location = New Point(171, 98)
        platform9.Name = "platform9"
        platform9.Size = New Size(100, 24)
        platform9.SizeMode = PictureBoxSizeMode.StretchImage
        platform9.TabIndex = 11
        platform9.TabStop = False
        platform9.Tag = "bound"
        ' 
        ' timerRight
        ' 
        timerRight.Interval = 20
        ' 
        ' timerUp
        ' 
        timerUp.Interval = 20
        ' 
        ' timerGameLogic
        ' 
        timerGameLogic.Interval = 20
        ' 
        ' timerGravity
        ' 
        ' 
        ' picAir
        ' 
        picAir.BackColor = Color.Transparent
        picAir.Location = New Point(0, -33)
        picAir.Name = "picAir"
        picAir.Size = New Size(860, 439)
        picAir.TabIndex = 12
        picAir.TabStop = False
        ' 
        ' picGround
        ' 
        picGround.BackColor = Color.DarkOliveGreen
        picGround.Location = New Point(-1, 428)
        picGround.Name = "picGround"
        picGround.Size = New Size(886, 34)
        picGround.TabIndex = 13
        picGround.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.IndianRed
        PictureBox1.Location = New Point(301, 49)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 22)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        PictureBox1.Tag = "bound"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.IndianRed
        PictureBox2.Location = New Point(487, 48)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 23)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        PictureBox2.Tag = "bound"
        ' 
        ' timerAir
        ' 
        timerAir.Interval = 700
        ' 
        ' trophy
        ' 
        trophy.BackgroundImageLayout = ImageLayout.Center
        trophy.Image = My.Resources.Resources.istockphoto_1398070734_612x612
        trophy.Location = New Point(541, 11)
        trophy.Name = "trophy"
        trophy.Size = New Size(46, 46)
        trophy.SizeMode = PictureBoxSizeMode.StretchImage
        trophy.TabIndex = 20
        trophy.TabStop = False
        trophy.Tag = "trophy"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = My.Resources.Resources._360_F_105600193_Bq7GrUHfRaaPQeoJW6m9kDWIVuXvPqHQ
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(834, 461)
        Controls.Add(trophy)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(player)
        Controls.Add(platform9)
        Controls.Add(platform8)
        Controls.Add(platform7)
        Controls.Add(platform6)
        Controls.Add(platform2)
        Controls.Add(platform4)
        Controls.Add(platform5)
        Controls.Add(platform1)
        Controls.Add(platform3)
        Controls.Add(btnStart)
        Controls.Add(lblScore)
        Controls.Add(picAir)
        Controls.Add(picGround)
        Name = "Form1"
        Text = "Form1"
        CType(player, ComponentModel.ISupportInitialize).EndInit()
        CType(platform3, ComponentModel.ISupportInitialize).EndInit()
        CType(platform1, ComponentModel.ISupportInitialize).EndInit()
        CType(platform5, ComponentModel.ISupportInitialize).EndInit()
        CType(platform4, ComponentModel.ISupportInitialize).EndInit()
        CType(platform2, ComponentModel.ISupportInitialize).EndInit()
        CType(platform6, ComponentModel.ISupportInitialize).EndInit()
        CType(platform7, ComponentModel.ISupportInitialize).EndInit()
        CType(platform8, ComponentModel.ISupportInitialize).EndInit()
        CType(platform9, ComponentModel.ISupportInitialize).EndInit()
        CType(picAir, ComponentModel.ISupportInitialize).EndInit()
        CType(picGround, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(trophy, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents player As PictureBox
    Friend WithEvents timerLeft As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents platform3 As PictureBox
    Friend WithEvents platform1 As PictureBox
    Friend WithEvents platform5 As PictureBox
    Friend WithEvents platform4 As PictureBox
    Friend WithEvents platform2 As PictureBox
    Friend WithEvents platform6 As PictureBox
    Friend WithEvents platform7 As PictureBox
    Friend WithEvents platform8 As PictureBox
    Friend WithEvents platform9 As PictureBox
    Friend WithEvents timerRight As Timer
    Friend WithEvents timerUp As Timer
    Friend WithEvents timerGameLogic As Timer
    Friend WithEvents timerGravity As Timer
    Friend WithEvents picAir As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents timerAir As Timer
    Friend WithEvents trophy As PictureBox

End Class
