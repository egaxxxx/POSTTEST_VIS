Imports MySqlConnector
Imports System.Data

Module DataModuleProduk

    ' ── READ: ambil semua produk ──────────────────────────────────
    Public Function GetAllProduk() As DataTable
        Dim dt As New DataTable()
        Try
            Dim cn As MySqlConnection = GetConnection()
            Dim sql As String = "SELECT id_produk, nama_produk, kategori, harga, stok, keterangan FROM tbl_produk ORDER BY id_produk"
            Dim da As New MySqlDataAdapter(sql, cn)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error GetAllProduk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' ── READ: ambil satu produk by id ────────────────────────────
    Public Function GetProdukById(id As Integer) As DataRow
        Try
            Dim cn As MySqlConnection = GetConnection()
            Dim sql As String = "SELECT * FROM tbl_produk WHERE id_produk = @id"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", id)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then Return dt.Rows(0)
        Catch ex As Exception
            MessageBox.Show("Error GetProdukById: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    ' ── CREATE: tambah produk baru ───────────────────────────────
    Public Function InsertProduk(nama As String, kategori As String,
                                  harga As Decimal, stok As Integer,
                                  ket As String) As Boolean
        Try
            Dim cn As MySqlConnection = GetConnection()
            Dim sql As String = "INSERT INTO tbl_produk (nama_produk, kategori, harga, stok, keterangan) " &
                                "VALUES (@nama, @kat, @harga, @stok, @ket)"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@kat", kategori)
            cmd.Parameters.AddWithValue("@harga", harga)
            cmd.Parameters.AddWithValue("@stok", stok)
            cmd.Parameters.AddWithValue("@ket", ket)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error InsertProduk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── UPDATE: ubah data produk ─────────────────────────────────
    Public Function UpdateProduk(id As Integer, nama As String, kategori As String,
                                  harga As Decimal, stok As Integer,
                                  ket As String) As Boolean
        Try
            Dim cn As MySqlConnection = GetConnection()
            Dim sql As String = "UPDATE tbl_produk SET nama_produk=@nama, kategori=@kat, " &
                                "harga=@harga, stok=@stok, keterangan=@ket WHERE id_produk=@id"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@kat", kategori)
            cmd.Parameters.AddWithValue("@harga", harga)
            cmd.Parameters.AddWithValue("@stok", stok)
            cmd.Parameters.AddWithValue("@ket", ket)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error UpdateProduk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── DELETE: hapus produk ─────────────────────────────────────
    Public Function DeleteProduk(id As Integer) As Boolean
        Try
            Dim cn As MySqlConnection = GetConnection()
            Dim sql As String = "DELETE FROM tbl_produk WHERE id_produk = @id"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error DeleteProduk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── Helper: isi ComboBox dengan daftar produk ────────────────
    Public Sub IsiComboProduk(cb As ComboBox)
        Try
            Dim cn As MySqlConnection = GetConnection()
            Dim sql As String = "SELECT id_produk, nama_produk, harga FROM tbl_produk ORDER BY nama_produk"
            Dim da As New MySqlDataAdapter(sql, cn)
            Dim dt As New DataTable()
            da.Fill(dt)
            cb.DataSource = dt
            cb.DisplayMember = "nama_produk"
            cb.ValueMember = "id_produk"
        Catch ex As Exception
            MessageBox.Show("Error IsiComboProduk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
