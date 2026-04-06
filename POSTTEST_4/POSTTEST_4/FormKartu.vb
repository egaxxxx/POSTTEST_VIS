Imports System.IO

Public Class FormKartu

    Private _data As Dictionary(Of String, String)
    Private _foto As Image

    Public Sub New(data As Dictionary(Of String, String), foto As Image)
        InitializeComponent()

        If data IsNot Nothing Then
            _data = data
        Else
            _data = New Dictionary(Of String, String)()
        End If

        _foto = foto
    End Sub

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
    End Sub

    Private Sub TampilkanData()
        LblNama.Text = GetData("Nama")
        LblID.Text = GetData("ID")
        LblCardID.Text = GetData("ID")

        Dim peran As String = GetData("Peran")
        Dim gender As String = GetData("Gender")
        LblPeranGender.Text = peran & " • " & gender

        LblKomunitas.Text = GetData("Komunitas")
        LblLahir.Text = "Lahir : " & GetData("TglLahir") & " (" & GetData("Umur") & " tahun)"
        LblTelepon.Text = "Telepon : " & GetData("Telepon")
        LblEmail.Text = "Email : " & GetData("Email")
        LblKota.Text = "Kota : " & GetData("Kota") & ", " & GetData("Provinsi")
        LblHobi.Text = "Hobi : " & GetData("Hobi")

        LblMemberSince.Text = "Since : " & DateTime.Now.Year.ToString()
        LblFooterKanan.Text = "Bergabung " & DateTime.Now.Year.ToString()

        If _foto IsNot Nothing Then
            PbFoto.Image = _foto
        Else
            PbFoto.Image = Nothing
        End If
    End Sub

    Private Function GetData(key As String) As String
        If _data IsNot Nothing AndAlso _data.ContainsKey(key) Then
            Return _data(key)
        End If
        Return "-"
    End Function

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnSimpanGambar_Click(sender As Object, e As EventArgs) Handles BtnSimpanGambar.Click
        Using sfd As New SaveFileDialog()
            sfd.Title = "Simpan Kartu sebagai Gambar"
            sfd.Filter = "PNG Image|*.png"
            sfd.FileName = "Kartu_" & GetData("Nama").Replace(" ", "_") & "_" & DateTime.Now.ToString("yyyyMMdd")

            If sfd.ShowDialog() = DialogResult.OK Then
                Using bmp As New Bitmap(PnlKartu.Width, PnlKartu.Height)
                    PnlKartu.DrawToBitmap(bmp, New Rectangle(0, 0, PnlKartu.Width, PnlKartu.Height))
                    bmp.Save(sfd.FileName, Imaging.ImageFormat.Png)
                End Using

                MessageBox.Show(
                    "Kartu berhasil disimpan sebagai gambar.",
                    "Simpan Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub BtnCetak_Click(sender As Object, e As EventArgs) Handles BtnCetak.Click
        Dim hasil = MessageBox.Show(
            "Cetak kartu anggota ini?",
            "Konfirmasi Cetak",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            Using pd As New Printing.PrintDocument()
                AddHandler pd.PrintPage,
                    Sub(s, pe)
                        Using bmp As New Bitmap(PnlKartu.Width, PnlKartu.Height)
                            PnlKartu.DrawToBitmap(bmp, New Rectangle(0, 0, PnlKartu.Width, PnlKartu.Height))
                            pe.Graphics.DrawImage(bmp, 20, 20)
                        End Using
                    End Sub

                Using ppd As New PrintPreviewDialog()
                    ppd.Document = pd
                    ppd.ShowDialog()
                End Using
            End Using
        End If
    End Sub

End Class