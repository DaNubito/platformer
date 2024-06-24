<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        lblTitle = New Label()
        level1 = New Button()
        lvl2selector = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 40F, FontStyle.Bold)
        lblTitle.Location = New Point(171, 51)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(419, 63)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Level Selection"
        ' 
        ' level1
        ' 
        level1.BackColor = Color.DeepSkyBlue
        level1.Font = New Font("Arial", 36F, FontStyle.Bold)
        level1.Location = New Point(149, 185)
        level1.Name = "level1"
        level1.Size = New Size(150, 150)
        level1.TabIndex = 1
        level1.Text = "1"
        level1.UseVisualStyleBackColor = False
        ' 
        ' lvl2selector
        ' 
        lvl2selector.BackColor = Color.DarkSalmon
        lvl2selector.Font = New Font("Arial", 36F, FontStyle.Bold)
        lvl2selector.Location = New Point(450, 185)
        lvl2selector.Name = "lvl2selector"
        lvl2selector.Size = New Size(150, 150)
        lvl2selector.TabIndex = 2
        lvl2selector.Text = "2"
        lvl2selector.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.cartoon_cloud_sky_background_4
        PictureBox1.Location = New Point(0, -5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(747, 235)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._360_F_49519769_g7gruSqdf6BI3iaVxL0Yu86wDnP429LZ
        PictureBox2.Location = New Point(0, 129)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(799, 321)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(751, 450)
        Controls.Add(lvl2selector)
        Controls.Add(level1)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Name = "Form3"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents level1 As Button
    Friend WithEvents lvl2selector As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
