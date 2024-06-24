<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        lblTitle2 = New Label()
        btnStart = New Button()
        btnQuit = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Arial", 72F, FontStyle.Bold)
        lblTitle.ForeColor = SystemColors.ActiveCaption
        lblTitle.Location = New Point(22, 64)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(351, 182)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Nature"
        ' 
        ' lblTitle2
        ' 
        lblTitle2.BackColor = Color.Transparent
        lblTitle2.Font = New Font("Arial", 72F, FontStyle.Bold)
        lblTitle2.ForeColor = Color.Bisque
        lblTitle2.Location = New Point(349, 64)
        lblTitle2.Name = "lblTitle2"
        lblTitle2.Size = New Size(422, 182)
        lblTitle2.TabIndex = 1
        lblTitle2.Text = "Jumper!"
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.Transparent
        btnStart.Font = New Font("Arial", 18F, FontStyle.Bold)
        btnStart.Location = New Point(218, 300)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(165, 47)
        btnStart.TabIndex = 2
        btnStart.Text = "Start!"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' btnQuit
        ' 
        btnQuit.BackColor = Color.Transparent
        btnQuit.Font = New Font("Arial", 18F, FontStyle.Bold)
        btnQuit.Location = New Point(426, 300)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(165, 47)
        btnQuit.TabIndex = 3
        btnQuit.Text = "Quit :("
        btnQuit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(169, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 4
        Label1.Text = "(The Picture)"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.image__9_
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(btnQuit)
        Controls.Add(btnStart)
        Controls.Add(lblTitle2)
        Controls.Add(lblTitle)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents Label1 As Label
End Class
