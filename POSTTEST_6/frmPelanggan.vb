Imports System.Data
Public Class frmPelanggan
    Private selectedId As Integer = -1

    Private Sub frmPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        ResetForm()
    End Sub

    Private Sub LoadData()
        dgvPelanggan.DataSource = GetAllPelanggan()
        If dgvPelanggan.Columns.Count > 0 Then
            dgvPelanggan.Columns("id_pelanggan").Visible = False
            dgvPelanggan.Columns("nama_pelanggan").HeaderText = "Nama"
            dgvPelanggan.Columns("no_hp").HeaderText = "No HP"
            dgvPelanggan.Columns("alamat").HeaderText = "Alamat"
            dgvPelanggan.Columns("status_aktif").HeaderText = "Status"
        End If
        UpdateJumlahLabel()
    End Sub

    Private Sub UpdateJumlahLabel()
        lblJumlah.Text = "Total Pelanggan: " & dgvPelanggan.Rows.Count
    End Sub

    Private Sub dgvPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPelanggan.CellClick
        If e.RowIndex < 0 Then Return
        Dim row = dgvPelanggan.Rows(e.RowIndex)
        selectedId = CInt(row.Cells("id_pelanggan").Value)
        txtNama.Text = row.Cells("nama_pelanggan").Value.ToString()
        txtHP.Text = If(row.Cells("no_hp").Value IsNot DBNull.Value, row.Cells("no_hp").Value.ToString(), "")
        txtAlamat.Text = If(row.Cells("alamat").Value IsNot DBNull.Value, row.Cells("alamat").Value.ToString(), "")
        cboStatus.Text = row.Cells("status_aktif").Value.ToString()
        btnSimpan.Text = "UPDATE"
        btnSimpan.BackColor = Color.FromArgb(133, 79, 11)
        btnHapus.Enabled = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Nama wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If selectedId = -1 Then
            If InsertPelanggan(txtNama.Text.Trim(), txtHP.Text.Trim(), txtAlamat.Text.Trim(), cboStatus.Text) Then
                MessageBox.Show("Pelanggan ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ResetForm()
            End If
        Else
            If UpdatePelanggan(selectedId, txtNama.Text.Trim(), txtHP.Text.Trim(), txtAlamat.Text.Trim(), cboStatus.Text) Then
                MessageBox.Show("Data diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ResetForm()
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = -1 Then Return
        If MessageBox.Show("Hapus pelanggan? (Data pesanan terkait akan jadi NULL)", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DeletePelanggan(selectedId) Then
                MessageBox.Show("Pelanggan dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ResetForm()
            End If
        End If
    End Sub

    Private Sub ResetForm()
        txtNama.Clear() : txtHP.Clear() : txtAlamat.Clear()
        cboStatus.SelectedIndex = 0
        selectedId = -1
        btnSimpan.Text = "SIMPAN"
        btnSimpan.BackColor = Color.FromArgb(12, 68, 124)
        btnHapus.Enabled = False
        txtNama.Focus()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ResetForm()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class