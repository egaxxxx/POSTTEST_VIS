<System.ComponentModel.DesignerCategory("Form")>
Partial Class FormKartu
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PnlKartu = New Panel()
        PnlHeaderKartu = New Panel()
        LblNamaApp = New Label()
        LblSubApp = New Label()
        LblKomunitas = New Label()
        PbFoto = New PictureBox()
        LblID = New Label()
        LblNama = New Label()
        LblPeranGender = New Label()
        LblLahir = New Label()
        LblTelepon = New Label()
        LblEmail = New Label()
        LblKota = New Label()
        LblHobi = New Label()
        PnlStatus = New Panel()
        LblStatusTitle = New Label()
        LblStatusValue = New Label()
        LblMemberSince = New Label()
        LblCardID = New Label()
        LblFooterKiri = New Label()
        LblFooterTengah = New Label()
        LblFooterKanan = New Label()
        LblHeader = New Label()
        BtnTutup = New Button()
        BtnSimpanGambar = New Button()
        BtnCetak = New Button()
        PnlKartu.SuspendLayout()
        PnlHeaderKartu.SuspendLayout()
        CType(PbFoto, ComponentModel.ISupportInitialize).BeginInit()
        PnlStatus.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlKartu
        ' 
        PnlKartu.BackColor = Color.FromArgb(CByte(7), CByte(12), CByte(45))
        PnlKartu.BorderStyle = BorderStyle.FixedSingle
        PnlKartu.Controls.Add(PnlHeaderKartu)
        PnlKartu.Controls.Add(PbFoto)
        PnlKartu.Controls.Add(LblID)
        PnlKartu.Controls.Add(LblNama)
        PnlKartu.Controls.Add(LblPeranGender)
        PnlKartu.Controls.Add(LblLahir)
        PnlKartu.Controls.Add(LblTelepon)
        PnlKartu.Controls.Add(LblEmail)
        PnlKartu.Controls.Add(LblKota)
        PnlKartu.Controls.Add(LblHobi)
        PnlKartu.Controls.Add(PnlStatus)
        PnlKartu.Controls.Add(LblFooterKiri)
        PnlKartu.Controls.Add(LblFooterTengah)
        PnlKartu.Controls.Add(LblFooterKanan)
        PnlKartu.Location = New Point(36, 84)
        PnlKartu.Name = "PnlKartu"
        PnlKartu.Size = New Size(1029, 667)
        PnlKartu.TabIndex = 1
        ' 
        ' PnlHeaderKartu
        ' 
        PnlHeaderKartu.BackColor = Color.FromArgb(CByte(10), CByte(20), CByte(60))
        PnlHeaderKartu.Controls.Add(LblNamaApp)
        PnlHeaderKartu.Controls.Add(LblSubApp)
        PnlHeaderKartu.Controls.Add(LblKomunitas)
        PnlHeaderKartu.Location = New Point(18, 16)
        PnlHeaderKartu.Name = "PnlHeaderKartu"
        PnlHeaderKartu.Size = New Size(980, 86)
        PnlHeaderKartu.TabIndex = 0
        ' 
        ' LblNamaApp
        ' 
        LblNamaApp.AutoSize = True
        LblNamaApp.Font = New Font("Segoe UI Black", 15.0F, FontStyle.Bold)
        LblNamaApp.ForeColor = Color.FromArgb(CByte(0), CByte(220), CByte(255))
        LblNamaApp.Location = New Point(16, 8)
        LblNamaApp.Name = "LblNamaApp"
        LblNamaApp.Size = New Size(287, 41)
        LblNamaApp.TabIndex = 0
        LblNamaApp.Text = "KARTU ANGGOTA"
        ' 
        ' LblSubApp
        ' 
        LblSubApp.AutoSize = True
        LblSubApp.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblSubApp.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblSubApp.Location = New Point(18, 47)
        LblSubApp.Name = "LblSubApp"
        LblSubApp.Size = New Size(128, 25)
        LblSubApp.TabIndex = 1
        LblSubApp.Text = "Data Member"
        ' 
        ' LblKomunitas
        ' 
        LblKomunitas.BackColor = Color.FromArgb(CByte(0), CByte(75), CByte(155))
        LblKomunitas.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblKomunitas.ForeColor = Color.White
        LblKomunitas.Location = New Point(630, 24)
        LblKomunitas.Name = "LblKomunitas"
        LblKomunitas.Padding = New Padding(10, 4, 10, 4)
        LblKomunitas.Size = New Size(320, 38)
        LblKomunitas.TabIndex = 2
        LblKomunitas.Text = "Komunitas"
        LblKomunitas.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PbFoto
        ' 
        PbFoto.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(55))
        PbFoto.BorderStyle = BorderStyle.FixedSingle
        PbFoto.Location = New Point(28, 126)
        PbFoto.Name = "PbFoto"
        PbFoto.Size = New Size(150, 180)
        PbFoto.SizeMode = PictureBoxSizeMode.Zoom
        PbFoto.TabIndex = 1
        PbFoto.TabStop = False
        ' 
        ' LblID
        ' 
        LblID.BackColor = Color.FromArgb(CByte(0), CByte(75), CByte(155))
        LblID.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        LblID.ForeColor = Color.White
        LblID.Location = New Point(28, 316)
        LblID.Name = "LblID"
        LblID.Size = New Size(150, 30)
        LblID.TabIndex = 2
        LblID.Text = "ID-0001"
        LblID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblNama
        ' 
        LblNama.AutoSize = True
        LblNama.Font = New Font("Segoe UI Black", 17.0F, FontStyle.Bold)
        LblNama.ForeColor = Color.White
        LblNama.Location = New Point(210, 130)
        LblNama.Name = "LblNama"
        LblNama.Size = New Size(273, 46)
        LblNama.TabIndex = 3
        LblNama.Text = "Nama Anggota"
        ' 
        ' LblPeranGender
        ' 
        LblPeranGender.AutoSize = True
        LblPeranGender.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
        LblPeranGender.ForeColor = Color.FromArgb(CByte(0), CByte(210), CByte(255))
        LblPeranGender.Location = New Point(212, 182)
        LblPeranGender.Name = "LblPeranGender"
        LblPeranGender.Size = New Size(169, 28)
        LblPeranGender.TabIndex = 4
        LblPeranGender.Text = "Anggota • Gender"
        ' 
        ' LblLahir
        ' 
        LblLahir.AutoSize = True
        LblLahir.Font = New Font("Segoe UI", 10.0F)
        LblLahir.ForeColor = Color.White
        LblLahir.Location = New Point(212, 230)
        LblLahir.Name = "LblLahir"
        LblLahir.Size = New Size(172, 28)
        LblLahir.TabIndex = 5
        LblLahir.Text = "Lahir : 01 Jan 2000"
        ' 
        ' LblTelepon
        ' 
        LblTelepon.AutoSize = True
        LblTelepon.Font = New Font("Segoe UI", 10.0F)
        LblTelepon.ForeColor = Color.White
        LblTelepon.Location = New Point(212, 270)
        LblTelepon.Name = "LblTelepon"
        LblTelepon.Size = New Size(152, 28)
        LblTelepon.TabIndex = 6
        LblTelepon.Text = "Telepon : 08xxxx"
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.Font = New Font("Segoe UI", 10.0F)
        LblEmail.ForeColor = Color.White
        LblEmail.Location = New Point(212, 310)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(191, 28)
        LblEmail.TabIndex = 7
        LblEmail.Text = "Email : contoh@mail"
        ' 
        ' LblKota
        ' 
        LblKota.AutoSize = True
        LblKota.Font = New Font("Segoe UI", 10.0F)
        LblKota.ForeColor = Color.White
        LblKota.Location = New Point(212, 350)
        LblKota.Name = "LblKota"
        LblKota.Size = New Size(160, 28)
        LblKota.TabIndex = 8
        LblKota.Text = "Kota : Samarinda"
        ' 
        ' LblHobi
        ' 
        LblHobi.Font = New Font("Segoe UI", 9.5F)
        LblHobi.ForeColor = Color.White
        LblHobi.Location = New Point(212, 394)
        LblHobi.Name = "LblHobi"
        LblHobi.Size = New Size(580, 84)
        LblHobi.TabIndex = 9
        LblHobi.Text = "Hobi : Coding, Gaming, Desain"
        ' 
        ' PnlStatus
        ' 
        PnlStatus.BackColor = Color.FromArgb(CByte(0), CByte(45), CByte(100))
        PnlStatus.BorderStyle = BorderStyle.FixedSingle
        PnlStatus.Controls.Add(LblStatusTitle)
        PnlStatus.Controls.Add(LblStatusValue)
        PnlStatus.Controls.Add(LblMemberSince)
        PnlStatus.Controls.Add(LblCardID)
        PnlStatus.Location = New Point(830, 126)
        PnlStatus.Name = "PnlStatus"
        PnlStatus.Size = New Size(150, 170)
        PnlStatus.TabIndex = 10
        ' 
        ' LblStatusTitle
        ' 
        LblStatusTitle.AutoSize = True
        LblStatusTitle.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        LblStatusTitle.ForeColor = Color.FromArgb(CByte(130), CByte(190), CByte(230))
        LblStatusTitle.Location = New Point(12, 12)
        LblStatusTitle.Name = "LblStatusTitle"
        LblStatusTitle.Size = New Size(67, 21)
        LblStatusTitle.TabIndex = 0
        LblStatusTitle.Text = "STATUS"
        ' 
        ' LblStatusValue
        ' 
        LblStatusValue.AutoSize = True
        LblStatusValue.Font = New Font("Segoe UI Black", 12.0F, FontStyle.Bold)
        LblStatusValue.ForeColor = Color.Lime
        LblStatusValue.Location = New Point(12, 38)
        LblStatusValue.Name = "LblStatusValue"
        LblStatusValue.Size = New Size(85, 32)
        LblStatusValue.TabIndex = 1
        LblStatusValue.Text = "AKTIF"
        ' 
        ' LblMemberSince
        ' 
        LblMemberSince.AutoSize = True
        LblMemberSince.Font = New Font("Segoe UI", 8.5F)
        LblMemberSince.ForeColor = Color.White
        LblMemberSince.Location = New Point(12, 86)
        LblMemberSince.Name = "LblMemberSince"
        LblMemberSince.Size = New Size(100, 23)
        LblMemberSince.TabIndex = 2
        LblMemberSince.Text = "Since : 2025"
        ' 
        ' LblCardID
        ' 
        LblCardID.AutoSize = True
        LblCardID.Font = New Font("Consolas", 9.0F, FontStyle.Bold)
        LblCardID.ForeColor = Color.White
        LblCardID.Location = New Point(12, 122)
        LblCardID.Name = "LblCardID"
        LblCardID.Size = New Size(80, 22)
        LblCardID.TabIndex = 3
        LblCardID.Text = "ID-0001"
        ' 
        ' LblFooterKiri
        ' 
        LblFooterKiri.AutoSize = True
        LblFooterKiri.Font = New Font("Segoe UI", 8.5F, FontStyle.Italic)
        LblFooterKiri.ForeColor = Color.FromArgb(CByte(120), CByte(180), CByte(220))
        LblFooterKiri.Location = New Point(24, 620)
        LblFooterKiri.Name = "LblFooterKiri"
        LblFooterKiri.Size = New Size(114, 23)
        LblFooterKiri.TabIndex = 11
        LblFooterKiri.Text = "kartu anggota"
        ' 
        ' LblFooterTengah
        ' 
        LblFooterTengah.AutoSize = True
        LblFooterTengah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblFooterTengah.ForeColor = Color.Lime
        LblFooterTengah.Location = New Point(420, 620)
        LblFooterTengah.Name = "LblFooterTengah"
        LblFooterTengah.Size = New Size(133, 25)
        LblFooterTengah.TabIndex = 12
        LblFooterTengah.Text = "Anggota Aktif"
        ' 
        ' LblFooterKanan
        ' 
        LblFooterKanan.AutoSize = True
        LblFooterKanan.Font = New Font("Segoe UI", 8.5F)
        LblFooterKanan.ForeColor = Color.FromArgb(CByte(120), CByte(180), CByte(220))
        LblFooterKanan.Location = New Point(850, 620)
        LblFooterKanan.Name = "LblFooterKanan"
        LblFooterKanan.Size = New Size(135, 23)
        LblFooterKanan.TabIndex = 13
        LblFooterKanan.Text = "Bergabung 2025"
        ' 
        ' LblHeader
        ' 
        LblHeader.AutoSize = True
        LblHeader.Font = New Font("Segoe UI Black", 13.0F, FontStyle.Bold)
        LblHeader.ForeColor = Color.FromArgb(CByte(0), CByte(220), CByte(255))
        LblHeader.Location = New Point(376, 25)
        LblHeader.Name = "LblHeader"
        LblHeader.Size = New Size(365, 36)
        LblHeader.TabIndex = 0
        LblHeader.Text = "KARTU ANGGOTA DIGITAL"
        ' 
        ' BtnTutup
        ' 
        BtnTutup.BackColor = Color.FromArgb(CByte(140), CByte(30), CByte(50))
        BtnTutup.FlatStyle = FlatStyle.Flat
        BtnTutup.Font = New Font("Segoe UI Semibold", 10.0F)
        BtnTutup.ForeColor = Color.White
        BtnTutup.Location = New Point(829, 780)
        BtnTutup.Name = "BtnTutup"
        BtnTutup.Size = New Size(186, 60)
        BtnTutup.TabIndex = 4
        BtnTutup.Text = "Tutup"
        BtnTutup.UseVisualStyleBackColor = False
        ' 
        ' BtnSimpanGambar
        ' 
        BtnSimpanGambar.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(60))
        BtnSimpanGambar.FlatStyle = FlatStyle.Flat
        BtnSimpanGambar.Font = New Font("Segoe UI Semibold", 10.0F)
        BtnSimpanGambar.ForeColor = Color.White
        BtnSimpanGambar.Location = New Point(543, 780)
        BtnSimpanGambar.Name = "BtnSimpanGambar"
        BtnSimpanGambar.Size = New Size(257, 60)
        BtnSimpanGambar.TabIndex = 3
        BtnSimpanGambar.Text = "Simpan Gambar"
        BtnSimpanGambar.UseVisualStyleBackColor = False
        ' 
        ' BtnCetak
        ' 
        BtnCetak.BackColor = Color.FromArgb(CByte(0), CByte(100), CByte(180))
        BtnCetak.FlatStyle = FlatStyle.Flat
        BtnCetak.Font = New Font("Segoe UI Semibold", 10.0F)
        BtnCetak.ForeColor = Color.White
        BtnCetak.Location = New Point(314, 780)
        BtnCetak.Name = "BtnCetak"
        BtnCetak.Size = New Size(200, 60)
        BtnCetak.TabIndex = 2
        BtnCetak.Text = "Cetak"
        BtnCetak.UseVisualStyleBackColor = False
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(8), CByte(25))
        ClientSize = New Size(1100, 870)
        Controls.Add(PnlKartu)
        Controls.Add(LblHeader)
        Controls.Add(BtnCetak)
        Controls.Add(BtnSimpanGambar)
        Controls.Add(BtnTutup)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "FormKartu"
        StartPosition = FormStartPosition.CenterParent
        Text = "Form Kartu"
        PnlKartu.ResumeLayout(False)
        PnlKartu.PerformLayout()
        PnlHeaderKartu.ResumeLayout(False)
        PnlHeaderKartu.PerformLayout()
        CType(PbFoto, ComponentModel.ISupportInitialize).EndInit()
        PnlStatus.ResumeLayout(False)
        PnlStatus.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PnlKartu As Panel
    Friend WithEvents PnlHeaderKartu As Panel
    Friend WithEvents LblNamaApp As Label
    Friend WithEvents LblSubApp As Label
    Friend WithEvents LblKomunitas As Label
    Friend WithEvents PbFoto As PictureBox
    Friend WithEvents LblID As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents LblPeranGender As Label
    Friend WithEvents LblLahir As Label
    Friend WithEvents LblTelepon As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblKota As Label
    Friend WithEvents LblHobi As Label
    Friend WithEvents PnlStatus As Panel
    Friend WithEvents LblStatusTitle As Label
    Friend WithEvents LblStatusValue As Label
    Friend WithEvents LblMemberSince As Label
    Friend WithEvents LblCardID As Label
    Friend WithEvents LblFooterKiri As Label
    Friend WithEvents LblFooterTengah As Label
    Friend WithEvents LblFooterKanan As Label
    Friend WithEvents LblHeader As Label
    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnSimpanGambar As Button
    Friend WithEvents BtnCetak As Button
End Class