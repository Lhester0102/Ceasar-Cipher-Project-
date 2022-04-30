Public Class Form2
    Dim key As Integer
    Dim chh As Char
    Dim new_asc As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        Dim fileReader As String
        OpenFileDialog1.FileName = "encrypt"
        OpenFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        OpenFileDialog1.ShowDialog()
        fileReader = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName.ToString)
        TextBox1.Text = fileReader
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error Resume Next
        SaveFileDialog1.FileName = "decrypt"
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, TextBox2.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = ""
        key = Val(TextBox3.Text)
        Dim value As String = TextBox1.Text
        For Each character In value
            If Asc(character) = 32 Then
                TextBox2.Text = TextBox2.Text + Chr(32)
            ElseIf Asc(character) = 13 Then
                TextBox2.Text = TextBox2.Text + Chr(Asc(character) + 0)
            ElseIf Asc(character) = 10 Then
                TextBox2.Text = TextBox2.Text + Chr(Asc(character) + 0)
            Else
                new_asc = Asc(character) - key
                chh = Chr(new_asc)
                TextBox2.Text = TextBox2.Text & chh
            End If
        Next
    End Sub

   

End Class
