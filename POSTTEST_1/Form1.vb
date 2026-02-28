Public Class Form1
    Dim semester As Integer
    Dim Total As Double
    Dim IPK As Double
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ips As Double
        If Double.TryParse(TextBox1.Text, Ips) Then
            If Ips >= 0 And Ips <= 4 Then
                TextBox1.Text = ""
                Total = Total + Ips
                semester = semester + 1
                IPK = Total / semester
                TextBox2.Text = IPK
                If IPK >= 2 And IPK <= 2.75 Then
                    Label3.Text = "Cukup"
                ElseIf IPK >= 2.76 And IPK <= 3 Then
                    Label3.Text = "Memuaskan"
                ElseIf IPK >= 3.01 Then
                    Label3.Text = "Sangat Memuaskan"
                Else
                    Label3.Text = "Tidak Lulus"
                End If
            Else
                MessageBox.Show("Input Harus Antara 0-4")
            End If


        Else
            MessageBox.Show("Input Harus Angka")
            End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        semester = 0
        Total = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
