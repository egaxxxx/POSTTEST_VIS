Imports MySqlConnector
Imports System.Data

Module DataModulePelanggan
    Public Function GetAllPelanggan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim sql As String = "SELECT id_pelanggan, nama_pelanggan, no_hp, alamat, status_aktif FROM tbl_pelanggan ORDER BY nama_pelanggan"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(sql, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data pelanggan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function InsertPelanggan(nama As String, hp As String, alamat As String, status As String) As Boolean
        Try
            Dim sql As String = "INSERT INTO tbl_pelanggan (nama_pelanggan, no_hp, alamat, status_aktif) VALUES (@nama, @hp, @alamat, @status)"
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@hp", hp)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan pelanggan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UpdatePelanggan(id As Integer, nama As String, hp As String, alamat As String, status As String) As Boolean
        Try
            Dim sql As String = "UPDATE tbl_pelanggan SET nama_pelanggan=@nama, no_hp=@hp, alamat=@alamat, status_aktif=@status WHERE id_pelanggan=@id"
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@hp", hp)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal memperbarui pelanggan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function DeletePelanggan(id As Integer) As Boolean
        Try
            Dim sql As String = "DELETE FROM tbl_pelanggan WHERE id_pelanggan = @id"
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus pelanggan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub IsiComboPelanggan(cb As ComboBox)
        Try
            Dim sql As String = "SELECT id_pelanggan, nama_pelanggan FROM tbl_pelanggan ORDER BY nama_pelanggan"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(sql, conn)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    cb.DataSource = dt
                    cb.DisplayMember = "nama_pelanggan"
                    cb.ValueMember = "id_pelanggan"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengisi combo pelanggan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
