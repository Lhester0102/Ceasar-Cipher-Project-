Public Class Menus
    Private Sub EncryptToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EncryptToolStripMenuItem1.Click
        With Form1
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub DecryptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecryptToolStripMenuItem.Click
        With Form2
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ForceCrackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForceCrackToolStripMenuItem.Click
        With Form3
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub
End Class