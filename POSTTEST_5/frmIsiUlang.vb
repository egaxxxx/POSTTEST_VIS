Imports System.Data

Public Class frmIsiUlang
    Dim selectedId As Integer = -1

    Private Sub frmIsiUlang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProdukDenganPlaceholder()
        dtpTanggal.Value = Date.Today
        LoadData()
        ResetForm()
    End Sub

    '── Load ComboBox produk + placeholder ───────────────────────
    Private Sub LoadProdukDenganPlaceholder()
        Try
            ' Isi combo dari module yang sudah ada
            IsiComboProduk(cboProduk)

            ' Jika datasource combo berupa DataTable, tambahkan item placeholder di atas
            If cboProduk.DataSource IsNot Nothing Then
                Dim dtSource As DataTable = TryCast(cboProduk.DataSource, DataTable)

                If dtSource IsNot Nothing Then
                    Dim dtBaru As DataTable = dtSource.Copy()

                    Dim row As DataRow = dtBaru.NewRow()

                    ' Sesuaikan dengan kolom yang dipakai combo produk
                    ' Umumnya: id_produk dan nama_produk
                    If dtBaru.Columns.Contains("id_produk") Then
                        row("id_produk") = 0
                    End If

                    If dtBaru.Columns.Contains("nama_produk") Then
                        row("nama_produk") = "-- Pilih Produk --"
                    End If

                    dtBaru.Rows.InsertAt(row, 0)

                    cboProduk.DataSource = dtBaru

                    If cboProduk.DisplayMember <> "" Then
                        cboProduk.DisplayMember = "nama_produk"
                    End If

                    If cboProduk.ValueMember <> "" Then
                        cboProduk.ValueMember = "id_produk"
                    End If
                End If
            Else
                ' Jika combo tidak pakai datasource, tambahkan manual
                cboProduk.Items.Insert(0, "-- Pilih Produk --")
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal memuat produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '── Load data ke DataGridView ─────────────────────────────────
    Private Sub LoadData()
        Dim dt As DataTable = GetAllIsiUlang()
        dgvPesan.DataSource = dt

        If dgvPesan.Columns.Count > 0 Then
            dgvPesan.Columns("id_pesan").HeaderText = "ID"
            dgvPesan.Columns("nama_pelanggan").HeaderText = "Nama Pelanggan"
            dgvPesan.Columns("no_hp").HeaderText = "No. HP"
            dgvPesan.Columns("nama_produk").HeaderText = "Produk"
            dgvPesan.Columns("jumlah").HeaderText = "Jumlah"
            dgvPesan.Columns("total_harga").HeaderText = "Total (Rp)"
            dgvPesan.Columns("tanggal").HeaderText = "Tanggal"
            dgvPesan.Columns("status").HeaderText = "Status"

            dgvPesan.Columns("id_pesan").Width = 45
            dgvPesan.Columns("nama_pelanggan").Width = 140
            dgvPesan.Columns("no_hp").Width = 110
            dgvPesan.Columns("nama_produk").Width = 150
            dgvPesan.Columns("jumlah").Width = 55
            dgvPesan.Columns("total_harga").Width = 100
            dgvPesan.Columns("tanggal").Width = 90
            dgvPesan.Columns("status").Width = 80
        End If

        UpdateJumlahLabel()
    End Sub

    '── Reset form ────────────────────────────────────────────────
    Private Sub ResetForm()
        txtNama.Clear()
        txtHP.Clear()

        If cboProduk.Items.Count > 0 Then
            cboProduk.SelectedIndex = 0
        End If

        txtJumlah.Clear()
        txtTotal.Clear()

        dtpTanggal.Value = Date.Today

        If cboStatus.Items.Count > 0 Then
            cboStatus.SelectedIndex = 0
        End If

        selectedId = -1
        btnSimpan.Text = "SIMPAN"
        btnSimpan.BackColor = System.Drawing.Color.FromArgb(12, 68, 124)
        btnHapus.Enabled = False
        btnBatal.Enabled = False

        txtNama.Focus()
    End Sub

    Private Sub UpdateJumlahLabel()
        lblJumlah.Text = "Total Pesanan: " & dgvPesan.Rows.Count
    End Sub

    '── Cek apakah produk valid dipilih ──────────────────────────
    Private Function ProdukValidDipilih() As Boolean
        If cboProduk.SelectedIndex < 0 Then Return False

        ' Jika placeholder punya value 0
        If cboProduk.SelectedValue IsNot Nothing AndAlso IsNumeric(cboProduk.SelectedValue) Then
            If CInt(cboProduk.SelectedValue) = 0 Then
                Return False
            End If
        End If

        ' Jika pakai item text biasa
        If cboProduk.Text.Trim() = "" OrElse cboProduk.Text.Trim() = "-- Pilih Produk --" Then
            Return False
        End If

        Return True
    End Function

    '── Hitung total otomatis ─────────────────────────────────────
    Private Sub HitungTotal()
        Try
            If Not ProdukValidDipilih() Then
                txtTotal.Clear()
                Exit Sub
            End If

            Dim jumlahTemp As Integer
            If Not Integer.TryParse(txtJumlah.Text, jumlahTemp) OrElse jumlahTemp < 1 Then
                txtTotal.Clear()
                Exit Sub
            End If

            Dim idProduk As Integer = CInt(cboProduk.SelectedValue)
            Dim harga As Decimal = GetHargaProduk(idProduk)

            txtTotal.Text = (harga * jumlahTemp).ToString("N0")
        Catch
            txtTotal.Clear()
        End Try
    End Sub

    Private Sub cboProduk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduk.SelectedIndexChanged
        HitungTotal()
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        HitungTotal()
    End Sub

    '── Validasi jumlah hanya angka ──────────────────────────────
    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    '── Klik baris tabel ─────────────────────────────────────────
    Private Sub dgvPesan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPesan.CellClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvPesan.Rows(e.RowIndex)
        selectedId = CInt(row.Cells("id_pesan").Value)

        Dim dr As DataRow = GetIsiUlangById(selectedId)
        If dr IsNot Nothing Then
            txtNama.Text = dr("nama_pelanggan").ToString()
            txtHP.Text = If(dr("no_hp") Is DBNull.Value, "", dr("no_hp").ToString())
            cboProduk.SelectedValue = CInt(dr("id_produk"))
            txtJumlah.Text = dr("jumlah").ToString()
            txtTotal.Text = Convert.ToDecimal(dr("total_harga")).ToString("N0")
            dtpTanggal.Value = CDate(dr("tanggal"))
            cboStatus.Text = dr("status").ToString()
        End If

        btnSimpan.Text = "UPDATE"
        btnSimpan.BackColor = System.Drawing.Color.FromArgb(133, 79, 11)
        btnHapus.Enabled = True
        btnBatal.Enabled = True
    End Sub

    '── Tombol SIMPAN / UPDATE ───────────────────────────────────
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama pelanggan tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If

        If Not ProdukValidDipilih() Then
            MessageBox.Show("Silakan pilih produk terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboProduk.Focus()
            Return
        End If

        Dim jumlahTemp As Integer
        If Not Integer.TryParse(txtJumlah.Text, jumlahTemp) OrElse jumlahTemp < 1 Then
            MessageBox.Show("Jumlah harus angka minimal 1!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtJumlah.Focus()
            Return
        End If

        If txtTotal.Text.Trim() = "" Then
            MessageBox.Show("Total harga belum terbentuk. Pilih produk dan isi jumlah dengan benar.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nama As String = txtNama.Text.Trim()
        Dim hp As String = txtHP.Text.Trim()
        Dim idProduk As Integer = CInt(cboProduk.SelectedValue)
        Dim jumlah As Integer = jumlahTemp

        Dim totalText As String = txtTotal.Text.Replace(",", "").Replace(".", "")
        Dim total As Decimal = CDec(totalText)

        Dim tgl As Date = dtpTanggal.Value
        Dim status As String = cboStatus.Text

        If selectedId = -1 Then
            If InsertIsiUlang(nama, hp, idProduk, jumlah, total, tgl, status) Then
                MessageBox.Show("Pesanan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ResetForm()
            End If
        Else
            If UpdateIsiUlang(selectedId, nama, hp, idProduk, jumlah, total, tgl, status) Then
                MessageBox.Show("Pesanan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ResetForm()
            End If
        End If
    End Sub

    '── Tombol HAPUS ─────────────────────────────────────────────
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = -1 Then Return

        If MessageBox.Show("Yakin hapus pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DeleteIsiUlang(selectedId) Then
                MessageBox.Show("Pesanan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ResetForm()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ResetForm()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class