Imports System.Data

Public Class frmProdukJadi
    Dim selectedId As Integer = -1

    Private Sub frmProdukJadi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        ResetForm()
    End Sub

    '── Load data ke DataGridView ─────────────────────────────────
    Private Sub LoadData()
        Dim dt As DataTable = GetAllProduk()
        dgvProduk.DataSource = dt

        ' Cek apakah kolom sudah ada sebelum diubah
        If dgvProduk.Columns.Count > 0 Then
            dgvProduk.Columns("id_produk").HeaderText = "ID"
            dgvProduk.Columns("nama_produk").HeaderText = "Nama Produk"
            dgvProduk.Columns("kategori").HeaderText = "Kategori"
            dgvProduk.Columns("harga").HeaderText = "Harga (Rp)"
            dgvProduk.Columns("stok").HeaderText = "Stok"
            dgvProduk.Columns("keterangan").HeaderText = "Keterangan"

            dgvProduk.Columns("id_produk").Width = 50
            dgvProduk.Columns("nama_produk").Width = 180
            dgvProduk.Columns("kategori").Width = 80
            dgvProduk.Columns("harga").Width = 100
            dgvProduk.Columns("stok").Width = 60
            dgvProduk.Columns("keterangan").Width = 180
        End If

        UpdateJumlahLabel()
    End Sub

    '── Reset form input ──────────────────────────────────────────
    Private Sub ResetForm()
        txtNama.Clear()
        cboKategori.SelectedIndex = 0
        txtHarga.Clear()
        txtStok.Clear()
        txtKet.Clear()
        selectedId = -1
        btnSimpan.Text = "SIMPAN"
        btnSimpan.BackColor = System.Drawing.Color.FromArgb(12, 68, 124)
        btnHapus.Enabled = False
        btnBatal.Enabled = False
        txtNama.Focus()
    End Sub

    '── Update label jumlah record ───────────────────────────────
    Private Sub UpdateJumlahLabel()
        lblJumlah.Text = "Total Produk: " & dgvProduk.Rows.Count
    End Sub

    '── Klik baris tabel → isi form ──────────────────────────────
    Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvProduk.Rows(e.RowIndex)
        selectedId = CInt(row.Cells("id_produk").Value)

        txtNama.Text = row.Cells("nama_produk").Value.ToString()
        cboKategori.Text = row.Cells("kategori").Value.ToString()
        txtHarga.Text = row.Cells("harga").Value.ToString()
        txtStok.Text = row.Cells("stok").Value.ToString()

        Dim ketVal = row.Cells("keterangan").Value
        txtKet.Text = If(ketVal Is DBNull.Value, "", ketVal.ToString())

        btnSimpan.Text = "UPDATE"
        btnSimpan.BackColor = System.Drawing.Color.FromArgb(133, 79, 11)
        btnHapus.Enabled = True
        btnBatal.Enabled = True
    End Sub

    '── Tombol SIMPAN / UPDATE ───────────────────────────────────
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        '── Validasi
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama produk tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus() : Return
        End If

        Dim hargaTemp As Decimal
        If txtHarga.Text.Trim() = "" OrElse Not Decimal.TryParse(txtHarga.Text, hargaTemp) Then
            MessageBox.Show("Harga harus berupa angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHarga.Focus() : Return
        End If

        Dim stokTemp As Integer
        If txtStok.Text.Trim() = "" OrElse Not Integer.TryParse(txtStok.Text, stokTemp) Then
            MessageBox.Show("Stok harus berupa angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStok.Focus() : Return
        End If

        Dim nama As String = txtNama.Text.Trim()
        Dim kat As String = cboKategori.Text
        Dim harga As Decimal = hargaTemp
        Dim stok As Integer = stokTemp
        Dim ket As String = txtKet.Text.Trim()

        If selectedId = -1 Then
            '── INSERT
            If InsertProduk(nama, kat, harga, stok, ket) Then
                MessageBox.Show("Produk berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ResetForm()
            End If
        Else
            '── UPDATE
            If UpdateProduk(selectedId, nama, kat, harga, stok, ket) Then
                MessageBox.Show("Produk berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ResetForm()
            End If
        End If
    End Sub

    '── Tombol HAPUS ─────────────────────────────────────────────
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = -1 Then Return

        If MessageBox.Show("Yakin hapus produk ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DeleteProduk(selectedId) Then
                MessageBox.Show("Produk berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ResetForm()
            End If
        End If
    End Sub

    '── Tombol BATAL ─────────────────────────────────────────────
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ResetForm()
    End Sub

    '── Tombol TUTUP ─────────────────────────────────────────────
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class