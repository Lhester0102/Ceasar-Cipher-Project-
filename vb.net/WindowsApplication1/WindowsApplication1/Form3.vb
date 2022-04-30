Public Class Form3
    Dim key As Integer
    Dim chh As Char
    Dim new_asc As Integer
    Dim charr As String = ""
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        Dim fileReader As String
        OpenFileDialog1.FileName = "encrypt"
        OpenFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        OpenFileDialog1.ShowDialog()
        fileReader = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName.ToString)
        TextBox2.Text = fileReader
    End Sub

  
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For i = 0 To 25
            charr = ""
            Dim value As String = TextBox2.Text
            For Each character In value
                If Asc(character) = 32 Then
                    charr = charr + Chr(32)
                ElseIf Asc(character) = 13 Then
                    charr = charr + Chr(Asc(character) + 0)
                ElseIf Asc(character) = 10 Then
                    charr = charr + Chr(Asc(character) + 0)
                Else
                    new_asc = Asc(character) - i
                    If Asc(character) > 64 And new_asc < 65 Then
                        new_asc += 26
                    End If
                    If Asc(character) > 96 And new_asc < 97 Then
                        new_asc += 26
                    End If
                    chh = Chr(new_asc)
                    charr = charr & chh
                End If
            Next
            TextBox4.Text += i & " " & charr & Chr(13) & Chr(10)
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error Resume Next
        SaveFileDialog1.FileName = "crack"
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, TextBox4.Text)
        End If
    End Sub
End Class
