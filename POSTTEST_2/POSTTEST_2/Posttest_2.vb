Module Posttest_2
    Public daftarbuku(99, 1) As String
    Public jumlahbuku As Integer = 0
    Public hapus As Integer = -1


    Public Sub tambahbuku(ByVal judul As String, ByVal genre As String)
        If jumlahbuku < 100 Then
            daftarbuku(jumlahbuku, 0) = judul
            daftarbuku(jumlahbuku, 1) = genre
            jumlahbuku += 1
        End If
    End Sub


    Public Sub hapusbuku(ByVal judulbuku As String)
        hapus = caribuku(judulbuku)

        If hapus >= 0 And hapus < jumlahbuku Then
            For i As Integer = hapus To jumlahbuku - 2
                daftarbuku(i, 0) = daftarbuku(i + 1, 0)
                daftarbuku(i, 1) = daftarbuku(i + 1, 1)
            Next
            jumlahbuku -= 1
            daftarbuku(jumlahbuku, 0) = Nothing
            daftarbuku(jumlahbuku, 1) = Nothing

            hapus = -1
        End If
    End Sub

    Public Function caribuku(ByVal judulbuku As String) As Integer
        For i As Integer = 0 To jumlahbuku - 1
            If daftarbuku(i, 0) = judulbuku Then
                Return i
            End If
        Next
        Return -1
    End Function

End Module

