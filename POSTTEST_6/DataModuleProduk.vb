Imports MySqlConnector
Imports System.Data

Module DataModuleProduk
    ' ── READ: Ambil semua produk ──────────────────────────────────
    Public Function GetAllProduk() As DataTable
        Dim dt As New DataTable()
        Try
            Dim sql As String = "SELECT id_produk, nama_produk, kategori, harga, stok, keterangan FROM tbl_produk ORDER BY id_produk ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(sql, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' ── CREATE: Tambah produk baru ───────────────────────────────
    Public Function InsertProduk(nama As String, kategori As String, harga As Decimal, stok As Integer, ket As String) As Boolean
        Try
            Dim sql As String = "INSERT INTO tbl_produk (nama_produk, kategori, harga, stok, keterangan) VALUES (@nama, @kat, @harga, @stok, @ket)"
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kat", kategori)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@ket", ket)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── UPDATE: Ubah data produk ─────────────────────────────────
    Public Function UpdateProduk(id As Integer, nama As String, kategori As String, harga As Decimal, stok As Integer, ket As String) As Boolean
        Try
            Dim sql As String = "UPDATE tbl_produk SET nama_produk=@nama, kategori=@kat, harga=@harga, stok=@stok, keterangan=@ket WHERE id_produk=@id"
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kat", kategori)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@ket", ket)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal memperbarui produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── DELETE: Hapus produk ─────────────────────────────────────
    Public Function DeleteProduk(id As Integer) As Boolean
        Try
            Dim sql As String = "DELETE FROM tbl_produk WHERE id_produk = @id"
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── Helper: Isi ComboBox dengan daftar produk ────────────────
    Public Sub IsiComboProduk(cb As ComboBox)
        Try
            Dim sql As String = "SELECT id_produk, nama_produk FROM tbl_produk ORDER BY nama_produk ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(sql, conn)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    cb.DataSource = dt
                    cb.DisplayMember = "nama_produk"
                    cb.ValueMember = "id_produk"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengisi daftar produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module