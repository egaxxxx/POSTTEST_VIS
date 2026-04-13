Imports MySqlConnector
Imports System.Data

Module DataModuleIsiUlang

    ' ── READ: ambil semua pesanan ─────────────────────────────────
    Public Function GetAllIsiUlang() As DataTable
        Dim dt As New DataTable()
        Try
            Dim cn As MySqlConnection = GetConnection()
            Dim sql As String =
                "SELECT i.id_pesan, i.nama_pelanggan, i.no_hp, p.nama_produk, " &
                "i.jumlah, i.total_harga, i.tanggal, i.status " &
                "FROM tbl_isiulang i " &
                "INNER JOIN tbl_produk p ON i.id_produk = p.id_produk " &
                "ORDER BY i.id_pesan DESC"
            Dim da As New MySqlDataAdapter(sql, cn)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error GetAllIsiUlang: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' ── READ: ambil satu pesanan by id ───────────────────────────
    Public Function GetIsiUlangById(id As Integer) As DataRow
        Try
            Dim cn As MySqlConnection = GetConnection()
            Dim sql As String = "SELECT * FROM tbl_isiulang WHERE id_pesan = @id"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", id)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then Return dt.Rows(0)
        Catch ex As Exception
            MessageBox.Show("Error GetIsiUlangById: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    ' ── CREATE: tambah pesanan baru ──────────────────────────────
    Public Function InsertIsiUlang(nama As String, hp As String,
                                    idProduk As Integer, jumlah As Integer,
                                    total As Decimal, tgl As Date,
                                    status As String) As Boolean
        Try
            Dim cn As MySqlConnection = GetConnection()
            Dim sql As String =
                "INSERT INTO tbl_isiulang (nama_pelanggan, no_hp, id_produk, jumlah, total_harga, tanggal, status) " &
                "VALUES (@nama, @hp, @idp, @jml, @total, @tgl, @status)"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@hp", hp)
            cmd.Parameters.AddWithValue("@idp", idProduk)
            cmd.Parameters.AddWithValue("@jml", jumlah)
            cmd.Parameters.AddWithValue("@total", total)
            cmd.Parameters.AddWithValue("@tgl", tgl.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@status", status)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error InsertIsiUlang: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── UPDATE: ubah data pesanan ────────────────────────────────
    Public Function UpdateIsiUlang(id As Integer, nama As String, hp As String,
                                    idProduk As Integer, jumlah As Integer,
                                    total As Decimal, tgl As Date,
                                    status As String) As Boolean
        Try
            Dim cn As MySqlConnection = GetConnection()
            Dim sql As String =
                "UPDATE tbl_isiulang SET nama_pelanggan=@nama, no_hp=@hp, id_produk=@idp, " &
                "jumlah=@jml, total_harga=@total, tanggal=@tgl, status=@status WHERE id_pesan=@id"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@hp", hp)
            cmd.Parameters.AddWithValue("@idp", idProduk)
            cmd.Parameters.AddWithValue("@jml", jumlah)
            cmd.Parameters.AddWithValue("@total", total)
            cmd.Parameters.AddWithValue("@tgl", tgl.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@status", status)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error UpdateIsiUlang: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── DELETE: hapus pesanan ────────────────────────────────────
    Public Function DeleteIsiUlang(id As Integer) As Boolean
        Try
            Dim cn As MySqlConnection = GetConnection()
            Dim sql As String = "DELETE FROM tbl_isiulang WHERE id_pesan = @id"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error DeleteIsiUlang: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── Helper: harga produk berdasarkan id ──────────────────────
    Public Function GetHargaProduk(idProduk As Integer) As Decimal
        Try
            Dim cn As MySqlConnection = GetConnection()
            Dim sql As String = "SELECT harga FROM tbl_produk WHERE id_produk = @id"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", idProduk)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing Then Return CDec(result)
        Catch ex As Exception
            MessageBox.Show("Error GetHargaProduk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

End Module
