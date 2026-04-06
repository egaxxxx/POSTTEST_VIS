Imports System.IO
Imports System.Linq
Imports System.Drawing.Drawing2D

Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private fotoProfil As Image = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(10, 10, 30)
        MenuStrip1.Renderer = New CustomMenuRenderer()

        AddHandler PnlHeader.Paint, AddressOf PnlHeader_Paint
        AddHandler PbFotoProfil.Paint, AddressOf PbFoto_Paint
        AddHandler GrpGender.Paint, AddressOf GrpBox_Paint
        AddHandler GrpPeran.Paint, AddressOf GrpBox_Paint
        AddHandler GrpHobi.Paint, AddressOf GrpBox_Paint

        AddHandler DtpTglLahir.ValueChanged,
            Sub(s, ev)
                Dim umur As Integer = DateTime.Now.Year - DtpTglLahir.Value.Year
                If DtpTglLahir.Value.Date > DateTime.Now.AddYears(-umur) Then umur -= 1
                TxtUmur.Text = umur.ToString()
            End Sub

        AddHandler BtnNextTab1.Click, Sub(s, ev) TabMain.SelectedIndex = 1
        AddHandler BtnBackTab2.Click, Sub(s, ev) TabMain.SelectedIndex = 0
        AddHandler BtnNextTab2.Click, Sub(s, ev) TabMain.SelectedIndex = 2
        AddHandler BtnBackTab3.Click, Sub(s, ev) TabMain.SelectedIndex = 1

        AddHandler BtnBrowse.Click, AddressOf BtnBrowse_Click
        AddHandler BtnSimpanCetak.Click, AddressOf BtnSimpanCetak_Click
        AddHandler MnuInputData.Click, AddressOf MnuInputData_Click
        AddHandler MnuLihatKartu.Click, AddressOf MnuLihatKartu_Click
        AddHandler MnuSimpanData.Click, AddressOf MnuSimpanData_Click
        AddHandler MnuBukaData.Click, AddressOf MnuBukaData_Click
        AddHandler MnuKeluar.Click, AddressOf MnuKeluar_Click
        AddHandler TxtNama.KeyPress, AddressOf TxtNama_KeyPress

        TxtUmur.Text = HitungUmur(DtpTglLahir.Value).ToString()
        SetStatus("Siap  —  BEAR COMMUNITY Member Card System")
    End Sub

    Private Function HitungUmur(tglLahir As DateTime) As Integer
        Dim umur As Integer = DateTime.Now.Year - tglLahir.Year
        If tglLahir.Date > DateTime.Now.AddYears(-umur) Then umur -= 1
        Return umur
    End Function

    Private Sub PnlHeader_Paint(sender As Object, e As PaintEventArgs)
        Dim g = e.Graphics
        Dim pnl = CType(sender, Panel)

        Using br As New LinearGradientBrush(
            New Rectangle(0, 0, pnl.Width, pnl.Height),
            Color.FromArgb(5, 5, 25),
            Color.FromArgb(10, 40, 80),
            0.0F)
            g.FillRectangle(br, New Rectangle(0, 0, pnl.Width, pnl.Height))
        End Using

        Using pen As New Pen(Color.FromArgb(0, 150, 220), 2)
            g.DrawLine(pen, 0, pnl.Height - 1, pnl.Width, pnl.Height - 1)
        End Using
    End Sub

    Private Sub PbFoto_Paint(sender As Object, e As PaintEventArgs)
        If fotoProfil Is Nothing Then
            Dim g = e.Graphics
            g.SmoothingMode = SmoothingMode.AntiAlias

            Using br As New SolidBrush(Color.FromArgb(30, 30, 70))
                g.FillRectangle(br, New Rectangle(0, 0, 130, 155))
            End Using

            Using sf As New StringFormat()
                sf.Alignment = StringAlignment.Center
                sf.LineAlignment = StringAlignment.Center

                g.DrawString(
                    "👤" & Environment.NewLine & "Klik Browse" & Environment.NewLine & "untuk foto",
                    New Font("Segoe UI", 8),
                    Brushes.Gray,
                    New RectangleF(0, 0, 130, 155),
                    sf)
            End Using
        End If
    End Sub

    Private Sub GrpBox_Paint(sender As Object, e As PaintEventArgs)
        Dim grp = CType(sender, GroupBox)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Using pen As New Pen(Color.FromArgb(0, 100, 180), 1)
            e.Graphics.DrawRectangle(pen, New Rectangle(1, 10, grp.Width - 2, grp.Height - 11))
        End Using

        Using br As New SolidBrush(Color.FromArgb(0, 200, 255))
            e.Graphics.DrawString(grp.Text, grp.Font, br, New PointF(8, 0))
        End Using
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " "c OrElse e.KeyChar = Convert.ToChar(8)) Then
            e.Handled = True
            MessageBox.Show(
                "⚠ Nama hanya boleh berisi huruf!",
                "Validasi Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function ValidasiSemuaInput() As Boolean
        If String.IsNullOrWhiteSpace(TxtNama.Text) Then
            TabMain.SelectedIndex = 0
            MessageBox.Show(
                "⚠ Inputan tidak boleh kosong!" & Environment.NewLine & "Nama Lengkap harus diisi.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            TxtNama.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtID.Text) Then
            TabMain.SelectedIndex = 0
            MessageBox.Show(
                "⚠ Inputan tidak boleh kosong!" & Environment.NewLine & "ID Anggota harus diisi.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            TxtID.Focus()
            Return False
        End If

        If Not MtbTelp.MaskCompleted Then
            TabMain.SelectedIndex = 1
            MessageBox.Show(
                "⚠ Inputan tidak boleh kosong!" & Environment.NewLine & "Nomor Telepon harus sesuai format 0000-0000-00000.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            MtbTelp.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtEmail.Text) Then
            TabMain.SelectedIndex = 1
            MessageBox.Show(
                "⚠ Inputan tidak boleh kosong!" & Environment.NewLine & "Email harus diisi.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            TxtEmail.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtAlamat.Text) Then
            TabMain.SelectedIndex = 1
            MessageBox.Show(
                "⚠ Inputan tidak boleh kosong!" & Environment.NewLine & "Alamat harus diisi.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            TxtAlamat.Focus()
            Return False
        End If

        Dim allChk = {
            ChkCoding, ChkDesain, ChkFotografi, ChkMusik,
            ChkGaming, ChkMembaca, ChkTravelling, ChkOlahraga,
            ChkFilm, ChkRobotik, ChkNetworking, ChkPublicSpeak
        }

        If Not allChk.Any(Function(c) c.Checked) Then
            TabMain.SelectedIndex = 2
            MessageBox.Show(
                "⚠ Inputan tidak boleh kosong!" & Environment.NewLine & "Pilih minimal 1 hobi/aktivitas.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Function KumpulkanData() As Dictionary(Of String, String)
        Dim data As New Dictionary(Of String, String)

        data("Nama") = TxtNama.Text.Trim()
        data("ID") = TxtID.Text.Trim()
        data("TglLahir") = DtpTglLahir.Value.ToString("dd MMMM yyyy")
        data("Umur") = TxtUmur.Text
        data("Gender") = If(RbPria.Checked, "Laki-laki", "Perempuan")

        Dim rawKom As String = CmbKomunitas.Text
        data("Komunitas") = rawKom.Trim()

        data("Telepon") = MtbTelp.Text
        data("Email") = TxtEmail.Text.Trim()
        data("Alamat") = TxtAlamat.Text.Trim()
        data("Kota") = TxtKota.Text.Trim()
        data("Provinsi") = TxtProvinsi.Text.Trim()

        Dim peranRadio = {
            Tuple.Create(RbKetua, "Ketua"),
            Tuple.Create(RbWakilKetua, "Wakil Ketua"),
            Tuple.Create(RbAdmin, "Admin"),
            Tuple.Create(RbSekretaris, "Sekretaris"),
            Tuple.Create(RbBendahara, "Bendahara"),
            Tuple.Create(RbKoordinator, "Koordinator"),
            Tuple.Create(RbAnggota, "Anggota"),
            Tuple.Create(RbMentor, "Mentor")
        }

        For Each item In peranRadio
            If item.Item1.Checked Then
                data("Peran") = item.Item2
                Exit For
            End If
        Next

        Dim hobiMap = {
            Tuple.Create(ChkCoding, "Coding"),
            Tuple.Create(ChkDesain, "Desain Grafis"),
            Tuple.Create(ChkFotografi, "Fotografi"),
            Tuple.Create(ChkMusik, "Musik"),
            Tuple.Create(ChkGaming, "Gaming"),
            Tuple.Create(ChkMembaca, "Membaca"),
            Tuple.Create(ChkTravelling, "Travelling"),
            Tuple.Create(ChkOlahraga, "Olahraga"),
            Tuple.Create(ChkFilm, "Film"),
            Tuple.Create(ChkRobotik, "Robotik"),
            Tuple.Create(ChkNetworking, "Networking"),
            Tuple.Create(ChkPublicSpeak, "Public Speaking")
        }

        Dim hobi As New List(Of String)
        For Each item In hobiMap
            If item.Item1.Checked Then
                hobi.Add(item.Item2)
            End If
        Next

        data("Hobi") = String.Join(", ", hobi)

        Return data
    End Function

    Private Sub MnuInputData_Click(sender As Object, e As EventArgs)
        TabMain.SelectedIndex = 0
        SetStatus("Mode: Input Data")
    End Sub

    Private Sub MnuLihatKartu_Click(sender As Object, e As EventArgs)
        If Not ValidasiSemuaInput() Then Return

        Dim kartu As New FormKartu(KumpulkanData(), fotoProfil)
        kartu.ShowDialog()
    End Sub

    Private Sub MnuSimpanData_Click(sender As Object, e As EventArgs)
        If Not ValidasiSemuaInput() Then Return

        Dim hasil = MessageBox.Show(
            "Simpan data anggota ke file?",
            "Konfirmasi Simpan",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            SimpanKeFile()
        End If
    End Sub

    Private Sub MnuBukaData_Click(sender As Object, e As EventArgs)
        BukaFile()
    End Sub

    Private Sub MnuKeluar_Click(sender As Object, e As EventArgs)
        Dim hasil = MessageBox.Show(
            "Apakah Anda yakin ingin keluar?",
            "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs)
        Using ofd As New OpenFileDialog()
            ofd.Title = "Pilih Foto Profil"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

            If ofd.ShowDialog() = DialogResult.OK Then
                If fotoProfil IsNot Nothing Then
                    fotoProfil.Dispose()
                    fotoProfil = Nothing
                End If

                Using tempImg As Image = Image.FromFile(ofd.FileName)
                    fotoProfil = New Bitmap(tempImg)
                End Using

                PbFotoProfil.Image = fotoProfil
                PbFotoProfil.Invalidate()

                SetStatus("Foto dimuat: " & Path.GetFileName(ofd.FileName))
            End If
        End Using
    End Sub

    Private Sub BtnSimpanCetak_Click(sender As Object, e As EventArgs)
        If Not ValidasiSemuaInput() Then Return

        Dim hasil = MessageBox.Show(
            "Konfirmasi cetak kartu untuk:" & Environment.NewLine & TxtNama.Text,
            "Konfirmasi Cetak",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            Dim kartu As New FormKartu(KumpulkanData(), fotoProfil)
            kartu.ShowDialog()
        End If
    End Sub

    Private Sub SimpanKeFile()
        Using sfd As New SaveFileDialog()
            sfd.Title = "Simpan Data Anggota"
            sfd.Filter = "Text File|*.txt|CSV File|*.csv"
            sfd.FileName = "Data_Anggota_" & DateTime.Now.ToString("yyyyMMdd_HHmm")

            If sfd.ShowDialog() = DialogResult.OK Then
                Dim data = KumpulkanData()
                Dim lines As New List(Of String)

                lines.Add("===== DATA ANGGOTA BEAR COMMUNITY =====")
                lines.Add("Tanggal Simpan : " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
                lines.Add("")

                For Each kvp In data
                    lines.Add(kvp.Key.PadRight(15) & ": " & kvp.Value)
                Next

                File.WriteAllLines(sfd.FileName, lines, System.Text.Encoding.UTF8)

                MessageBox.Show(
                    "✅ Data berhasil disimpan!" & Environment.NewLine & sfd.FileName,
                    "Simpan Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                SetStatus("Tersimpan: " & Path.GetFileName(sfd.FileName))
            End If
        End Using
    End Sub

    Private Sub BukaFile()
        Using ofd As New OpenFileDialog()
            ofd.Title = "Buka Data Anggota"
            ofd.Filter = "Text File|*.txt|CSV File|*.csv|All Files|*.*"

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim isi = File.ReadAllText(ofd.FileName, System.Text.Encoding.UTF8)

                MessageBox.Show(
                    isi,
                    "Data — " & Path.GetFileName(ofd.FileName),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                SetStatus("Dibuka: " & Path.GetFileName(ofd.FileName))
            End If
        End Using
    End Sub

    Private Sub SetStatus(pesan As String)
        LblStatus.Text = "  ● " & pesan
    End Sub

End Class

Public Class CustomMenuRenderer
    Inherits ToolStripProfessionalRenderer

    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        If e.Item.Selected OrElse e.Item.Pressed Then
            Using br As New SolidBrush(Color.FromArgb(0, 100, 180))
                e.Graphics.FillRectangle(br, New Rectangle(Point.Empty, e.Item.Size))
            End Using
        Else
            Using br As New SolidBrush(Color.FromArgb(15, 15, 40))
                e.Graphics.FillRectangle(br, New Rectangle(Point.Empty, e.Item.Size))
            End Using
        End If
    End Sub

    Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)
        Using br As New SolidBrush(Color.FromArgb(15, 15, 40))
            e.Graphics.FillRectangle(br, e.AffectedBounds)
        End Using
    End Sub
End Class