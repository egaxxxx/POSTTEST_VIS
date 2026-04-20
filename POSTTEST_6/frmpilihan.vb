Public Class frmPilihan
    Private Sub frmPilihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Menu Utama - Depot Air Minum Barokah"
    End Sub

    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        Dim frm As New frmProdukJadi()
        frm.Show()
    End Sub

    Private Sub btnPelanggan_Click(sender As Object, e As EventArgs) Handles btnPelanggan.Click
        Dim frm As New frmPelanggan()
        frm.Show()
    End Sub

    Private Sub btnIsiUlang_Click(sender As Object, e As EventArgs) Handles btnIsiUlang.Click
        Dim frm As New frmIsiUlang()
        frm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim frm As New Form1()
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MessageBox.Show("Yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class