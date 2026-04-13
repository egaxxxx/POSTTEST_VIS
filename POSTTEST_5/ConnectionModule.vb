Imports MySqlConnector

Module ConnectionModule
    Public conn As MySqlConnection
    Public connString As String = "Server=localhost;Database=db_depot_barokah;Uid=root;Pwd=;"

    Public Function GetConnection() As MySqlConnection
        Try
            conn = New MySqlConnection(connString)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Return conn
        Catch ex As Exception
            MessageBox.Show("Gagal terhubung ke database: " & ex.Message, "Error Koneksi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Sub CloseConnection()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Module
