Public Class Form1
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim judul1 As String = txtjudul1.Text
        Dim genre1 As String = txtgenre.Text
        tambahbuku(judul1, genre1)
        tampilkanData()

    End Sub

    Private Sub tampilkanData()
        dgvhasil.Rows.Clear()
        For i As Integer = 0 To jumlahbuku - 1
            dgvhasil.Rows.Add(daftarbuku(i, 0), daftarbuku(i, 1))
        Next
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim judul2 As String = txtjudul2.Text
        hapusbuku(judul2)
        tampilkanData()
    End Sub
End Class



