Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = txtUsername.Text.Trim()
        Dim pass As String = txtPassword.Text.Trim()

        If user = "" OrElse pass = "" Then
            MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi login (bisa diubah ke query DB)
        If user = "admin" AndAlso pass = "admin123" Then
            Dim frm As New frmPilihan()
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau Password salah!", "Login Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If MessageBox.Show("Yakin ingin keluar?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then btnLogin_Click(sender, e)
    End Sub

End Class