Imports System.Data

Public Class frmIsiUlang
    Private selectedId As Integer = -1

    Private Sub frmIsiUlang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        IsiComboProduk()
        IsiComboPelanggan()
        ResetForm()
    End Sub

    Private Sub LoadData()
        ' Panggil modul secara eksplisit agar tidak error BC30451
        dgvPesan.DataSource = DataModuleIsiUlang.GetAllIsiUlang()
        FormatGrid()
        UpdateJumlahLabel()
    End Sub

    Private Sub FormatGrid()
        If dgvPesan.Columns.Count > 0 Then
            dgvPesan.Columns("id_pesan").HeaderText = "ID"
            dgvPesan.Columns("nama_pelanggan").HeaderText = "Pelanggan"
            dgvPesan.Columns("no_hp").HeaderText = "No HP"
            dgvPesan.Columns("nama_produk").HeaderText = "Produk"
            dgvPesan.Columns("jumlah").HeaderText = "Qty"
            dgvPesan.Columns("total_harga").HeaderText = "Total (Rp)"
            dgvPesan.Columns("tanggal").HeaderText = "Tanggal"
            dgvPesan.Columns("status").HeaderText = "Status"
        End If
    End Sub

    Private Sub IsiComboProduk()
        ' Panggil langsung fungsi di modul, bukan memanggil diri sendiri
        DataModuleProduk.IsiComboProduk(cboProduk)
    End Sub

    Private Sub IsiComboPelanggan()
        DataModulePelanggan.IsiComboPelanggan(cboPelanggan)
    End Sub

    Private Sub cboProduk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduk.SelectedIndexChanged
        HitungTotal()
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        HitungTotal()
    End Sub

    Private Sub HitungTotal()
        Dim qty As Integer = 0
        Integer.TryParse(txtJumlah.Text, qty)
        If cboProduk.SelectedValue IsNot Nothing Then
            Dim harga As Decimal = DataModuleIsiUlang.GetHargaProduk(CInt(cboProduk.SelectedValue))
            txtTotal.Text = (harga * qty).ToString("N0")
        Else
            txtTotal.Clear()
        End If
    End Sub

    Private Sub dgvPesan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPesan.CellClick
        If e.RowIndex < 0 Then Return
        Dim row = dgvPesan.Rows(e.RowIndex)
        selectedId = CInt(row.Cells("id_pesan").Value)

        Dim namaPelanggan As Object = row.Cells("nama_pelanggan").Value
        If namaPelanggan IsNot DBNull.Value AndAlso namaPelanggan IsNot Nothing Then
            cboPelanggan.Text = namaPelanggan.ToString()
        Else
            cboPelanggan.SelectedIndex = -1
        End If

        txtHP.Text = If(row.Cells("no_hp").Value IsNot DBNull.Value, row.Cells("no_hp").Value.ToString(), "")
        txtJumlah.Text = row.Cells("jumlah").Value.ToString()
        txtTotal.Text = row.Cells("total_harga").Value.ToString()
        dtpTanggal.Value = CDate(row.Cells("tanggal").Value)
        cboStatus.Text = row.Cells("status").Value.ToString()
        cboProduk.Text = row.Cells("nama_produk").Value.ToString()

        btnSimpan.Text = "UPDATE"
        btnSimpan.BackColor = Color.FromArgb(133, 79, 11)
        btnHapus.Enabled = True
        btnBatal.Enabled = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cboPelanggan.SelectedValue Is Nothing Then
            MessageBox.Show("Pilih pelanggan terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrWhiteSpace(txtHP.Text) Then
            MessageBox.Show("No HP wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cboProduk.SelectedValue Is Nothing Then
            MessageBox.Show("Pilih produk terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim qty As Integer = 0
        If Not Integer.TryParse(txtJumlah.Text, qty) OrElse qty <= 0 Then
            MessageBox.Show("Jumlah harus angka > 0!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idPelanggan As Integer = CInt(cboPelanggan.SelectedValue)
        Dim idProduk As Integer = CInt(cboProduk.SelectedValue)
        Dim total As Decimal = 0
        Decimal.TryParse(txtTotal.Text.Replace(".", "").Replace(",", ""), total)

        If selectedId = -1 Then
            If DataModuleIsiUlang.InsertIsiUlang(idPelanggan, txtHP.Text.Trim(), idProduk, qty, total, dtpTanggal.Value.Date, cboStatus.Text) Then
                MessageBox.Show("Pesanan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ResetForm()
            End If
        Else
            If DataModuleIsiUlang.UpdateIsiUlang(selectedId, idPelanggan, txtHP.Text.Trim(), idProduk, qty, total, dtpTanggal.Value.Date, cboStatus.Text) Then
                MessageBox.Show("Pesanan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ResetForm()
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = -1 Then Return
        If MessageBox.Show("Yakin hapus pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DataModuleIsiUlang.DeleteIsiUlang(selectedId) Then
                MessageBox.Show("Pesanan dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub ResetForm()
        cboPelanggan.SelectedIndex = -1
        txtHP.Clear()
        cboProduk.SelectedIndex = -1
        txtJumlah.Clear()
        txtTotal.Clear()
        dtpTanggal.Value = Date.Now
        cboStatus.SelectedIndex = 0
        selectedId = -1
        btnSimpan.Text = "SIMPAN"
        btnSimpan.BackColor = Color.FromArgb(12, 68, 124)
        btnHapus.Enabled = False
        btnBatal.Enabled = False
        txtHP.Focus()
    End Sub

    Private Sub UpdateJumlahLabel()
        lblJumlah.Text = "Total Pesanan: " & dgvPesan.Rows.Count
    End Sub
End Class