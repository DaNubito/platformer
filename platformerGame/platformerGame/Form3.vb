Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub level1_Click(sender As Object, e As EventArgs) Handles level1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub lvl2selector_Click(sender As Object, e As EventArgs) Handles lvl2selector.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class