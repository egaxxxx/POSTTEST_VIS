<System.ComponentModel.DesignerCategory("Form")>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        MnuInputData = New ToolStripMenuItem()
        MnuLihatKartu = New ToolStripMenuItem()
        MnuSimpanData = New ToolStripMenuItem()
        MnuBukaData = New ToolStripMenuItem()
        MnuKeluar = New ToolStripMenuItem()
        PnlHeader = New Panel()
        PbLogo = New PictureBox()
        LblJudul = New Label()
        LblSubJudul = New Label()
        TabMain = New TabControl()
        TabDataUtama = New TabPage()
        LblNama = New Label()
        TxtNama = New TextBox()
        LblID = New Label()
        TxtID = New TextBox()
        LblTglLahir = New Label()
        DtpTglLahir = New DateTimePicker()
        LblUmur = New Label()
        TxtUmur = New TextBox()
        LblGender = New Label()
        GrpGender = New GroupBox()
        RbPria = New RadioButton()
        RbWanita = New RadioButton()
        LblKomunitas = New Label()
        CmbKomunitas = New ComboBox()
        BtnNextTab1 = New Button()
        TabKontak = New TabPage()
        LblTelp = New Label()
        MtbTelp = New MaskedTextBox()
        LblFmtTelp = New Label()
        LblEmail = New Label()
        TxtEmail = New TextBox()
        LblAlamat = New Label()
        TxtAlamat = New RichTextBox()
        LblKota = New Label()
        TxtKota = New TextBox()
        LblProvinsi = New Label()
        TxtProvinsi = New TextBox()
        BtnBackTab2 = New Button()
        BtnNextTab2 = New Button()
        TabProfil = New TabPage()
        LblFoto = New Label()
        PbFotoProfil = New PictureBox()
        BtnBrowse = New Button()
        GrpPeran = New GroupBox()
        RbKetua = New RadioButton()
        RbWakilKetua = New RadioButton()
        RbAdmin = New RadioButton()
        RbSekretaris = New RadioButton()
        RbBendahara = New RadioButton()
        RbKoordinator = New RadioButton()
        RbAnggota = New RadioButton()
        RbMentor = New RadioButton()
        LblHobi = New Label()
        GrpHobi = New GroupBox()
        ChkCoding = New CheckBox()
        ChkDesain = New CheckBox()
        ChkFotografi = New CheckBox()
        ChkMusik = New CheckBox()
        ChkGaming = New CheckBox()
        ChkMembaca = New CheckBox()
        ChkTravelling = New CheckBox()
        ChkOlahraga = New CheckBox()
        ChkFilm = New CheckBox()
        ChkRobotik = New CheckBox()
        ChkNetworking = New CheckBox()
        ChkPublicSpeak = New CheckBox()
        BtnBackTab3 = New Button()
        BtnSimpanCetak = New Button()
        PnlStatus = New Panel()
        LblStatus = New Label()
        MenuStrip1.SuspendLayout()
        PnlHeader.SuspendLayout()
        CType(PbLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabMain.SuspendLayout()
        TabDataUtama.SuspendLayout()
        GrpGender.SuspendLayout()
        TabKontak.SuspendLayout()
        TabProfil.SuspendLayout()
        CType(PbFotoProfil, ComponentModel.ISupportInitialize).BeginInit()
        GrpPeran.SuspendLayout()
        GrpHobi.SuspendLayout()
        PnlStatus.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(40))
        MenuStrip1.Font = New Font("Segoe UI Semibold", 9.5F)
        MenuStrip1.ForeColor = Color.FromArgb(CByte(0), CByte(220), CByte(255))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MnuInputData, MnuLihatKartu, MnuSimpanData, MnuBukaData, MnuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(9, 3, 0, 3)
        MenuStrip1.Size = New Size(1369, 35)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MnuInputData
        ' 
        MnuInputData.ForeColor = Color.FromArgb(CByte(0), CByte(220), CByte(255))
        MnuInputData.Name = "MnuInputData"
        MnuInputData.Size = New Size(140, 29)
        MnuInputData.Text = "  Input Data  "
        ' 
        ' MnuLihatKartu
        ' 
        MnuLihatKartu.ForeColor = Color.FromArgb(CByte(0), CByte(220), CByte(255))
        MnuLihatKartu.Name = "MnuLihatKartu"
        MnuLihatKartu.Size = New Size(143, 29)
        MnuLihatKartu.Text = "  Lihat Kartu  "
        ' 
        ' MnuSimpanData
        ' 
        MnuSimpanData.ForeColor = Color.FromArgb(CByte(0), CByte(220), CByte(255))
        MnuSimpanData.Name = "MnuSimpanData"
        MnuSimpanData.Size = New Size(158, 29)
        MnuSimpanData.Text = "  Simpan Data  "
        ' 
        ' MnuBukaData
        ' 
        MnuBukaData.ForeColor = Color.FromArgb(CByte(0), CByte(220), CByte(255))
        MnuBukaData.Name = "MnuBukaData"
        MnuBukaData.Size = New Size(136, 29)
        MnuBukaData.Text = "  Buka Data  "
        ' 
        ' MnuKeluar
        ' 
        MnuKeluar.ForeColor = Color.FromArgb(CByte(255), CByte(80), CByte(80))
        MnuKeluar.Name = "MnuKeluar"
        MnuKeluar.Size = New Size(103, 29)
        MnuKeluar.Text = "  Keluar  "
        ' 
        ' PnlHeader
        ' 
        PnlHeader.BackColor = Color.FromArgb(CByte(8), CByte(12), CByte(40))
        PnlHeader.Controls.Add(PbLogo)
        PnlHeader.Controls.Add(LblJudul)
        PnlHeader.Controls.Add(LblSubJudul)
        PnlHeader.Location = New Point(0, 40)
        PnlHeader.Margin = New Padding(4, 5, 4, 5)
        PnlHeader.Name = "PnlHeader"
        PnlHeader.Size = New Size(1400, 150)
        PnlHeader.TabIndex = 1
        ' 
        ' PbLogo
        ' 
        PbLogo.BackColor = Color.Transparent
        PbLogo.Image = CType(resources.GetObject("PbLogo.Image"), Image)
        PbLogo.Location = New Point(29, 25)
        PbLogo.Margin = New Padding(4, 5, 4, 5)
        PbLogo.Name = "PbLogo"
        PbLogo.Size = New Size(86, 100)
        PbLogo.SizeMode = PictureBoxSizeMode.Zoom
        PbLogo.TabIndex = 0
        PbLogo.TabStop = False
        ' 
        ' LblJudul
        ' 
        LblJudul.AutoSize = True
        LblJudul.BackColor = Color.Transparent
        LblJudul.Font = New Font("Segoe UI Black", 22F, FontStyle.Bold)
        LblJudul.ForeColor = Color.FromArgb(CByte(0), CByte(220), CByte(255))
        LblJudul.Location = New Point(129, 27)
        LblJudul.Margin = New Padding(4, 0, 4, 0)
        LblJudul.Name = "LblJudul"
        LblJudul.Size = New Size(443, 60)
        LblJudul.TabIndex = 1
        LblJudul.Text = "BEAR COMMUNITY"
        ' 
        ' LblSubJudul
        ' 
        LblSubJudul.AutoSize = True
        LblSubJudul.BackColor = Color.Transparent
        LblSubJudul.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        LblSubJudul.ForeColor = Color.FromArgb(CByte(120), CByte(180), CByte(220))
        LblSubJudul.Location = New Point(133, 92)
        LblSubJudul.Margin = New Padding(4, 0, 4, 0)
        LblSubJudul.Name = "LblSubJudul"
        LblSubJudul.Size = New Size(300, 25)
        LblSubJudul.TabIndex = 2
        LblSubJudul.Text = "Digital Member Card System  ─  v2.0"
        ' 
        ' TabMain
        ' 
        TabMain.Controls.Add(TabDataUtama)
        TabMain.Controls.Add(TabKontak)
        TabMain.Controls.Add(TabProfil)
        TabMain.Font = New Font("Segoe UI Semibold", 10F)
        TabMain.ForeColor = Color.Black
        TabMain.Location = New Point(29, 200)
        TabMain.Margin = New Padding(4, 5, 4, 5)
        TabMain.Name = "TabMain"
        TabMain.SelectedIndex = 0
        TabMain.Size = New Size(1182, 645)
        TabMain.TabIndex = 2
        ' 
        ' TabDataUtama
        ' 
        TabDataUtama.BackColor = Color.FromArgb(CByte(14), CByte(14), CByte(38))
        TabDataUtama.Controls.Add(LblNama)
        TabDataUtama.Controls.Add(TxtNama)
        TabDataUtama.Controls.Add(LblID)
        TabDataUtama.Controls.Add(TxtID)
        TabDataUtama.Controls.Add(LblTglLahir)
        TabDataUtama.Controls.Add(DtpTglLahir)
        TabDataUtama.Controls.Add(LblUmur)
        TabDataUtama.Controls.Add(TxtUmur)
        TabDataUtama.Controls.Add(LblGender)
        TabDataUtama.Controls.Add(GrpGender)
        TabDataUtama.Controls.Add(LblKomunitas)
        TabDataUtama.Controls.Add(CmbKomunitas)
        TabDataUtama.Controls.Add(BtnNextTab1)
        TabDataUtama.Location = New Point(4, 37)
        TabDataUtama.Margin = New Padding(4, 5, 4, 5)
        TabDataUtama.Name = "TabDataUtama"
        TabDataUtama.Padding = New Padding(4, 5, 4, 5)
        TabDataUtama.Size = New Size(1174, 604)
        TabDataUtama.TabIndex = 0
        TabDataUtama.Text = "Data Utama"
        ' 
        ' LblNama
        ' 
        LblNama.AutoSize = True
        LblNama.BackColor = Color.Transparent
        LblNama.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblNama.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblNama.Location = New Point(29, 33)
        LblNama.Margin = New Padding(4, 0, 4, 0)
        LblNama.Name = "LblNama"
        LblNama.Size = New Size(131, 23)
        LblNama.TabIndex = 0
        LblNama.Text = "Nama Lengkap"
        ' 
        ' TxtNama
        ' 
        TxtNama.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(55))
        TxtNama.BorderStyle = BorderStyle.FixedSingle
        TxtNama.Font = New Font("Segoe UI", 10F)
        TxtNama.ForeColor = Color.White
        TxtNama.Location = New Point(29, 72)
        TxtNama.Margin = New Padding(4, 5, 4, 5)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(371, 34)
        TxtNama.TabIndex = 1
        ' 
        ' LblID
        ' 
        LblID.AutoSize = True
        LblID.BackColor = Color.Transparent
        LblID.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblID.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblID.Location = New Point(464, 33)
        LblID.Margin = New Padding(4, 0, 4, 0)
        LblID.Name = "LblID"
        LblID.Size = New Size(103, 23)
        LblID.TabIndex = 2
        LblID.Text = "ID Anggota"
        ' 
        ' TxtID
        ' 
        TxtID.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(55))
        TxtID.BorderStyle = BorderStyle.FixedSingle
        TxtID.Font = New Font("Segoe UI", 10F)
        TxtID.ForeColor = Color.White
        TxtID.Location = New Point(464, 72)
        TxtID.Margin = New Padding(4, 5, 4, 5)
        TxtID.Name = "TxtID"
        TxtID.Size = New Size(239, 34)
        TxtID.TabIndex = 3
        ' 
        ' LblTglLahir
        ' 
        LblTglLahir.AutoSize = True
        LblTglLahir.BackColor = Color.Transparent
        LblTglLahir.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblTglLahir.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblTglLahir.Location = New Point(29, 167)
        LblTglLahir.Margin = New Padding(4, 0, 4, 0)
        LblTglLahir.Name = "LblTglLahir"
        LblTglLahir.Size = New Size(119, 23)
        LblTglLahir.TabIndex = 4
        LblTglLahir.Text = "Tanggal Lahir"
        ' 
        ' DtpTglLahir
        ' 
        DtpTglLahir.CalendarForeColor = Color.White
        DtpTglLahir.CalendarMonthBackground = Color.FromArgb(CByte(20), CByte(20), CByte(50))
        DtpTglLahir.CalendarTitleBackColor = Color.FromArgb(CByte(0), CByte(150), CByte(200))
        DtpTglLahir.Font = New Font("Segoe UI", 10F)
        DtpTglLahir.Location = New Point(29, 205)
        DtpTglLahir.Margin = New Padding(4, 5, 4, 5)
        DtpTglLahir.Name = "DtpTglLahir"
        DtpTglLahir.Size = New Size(368, 34)
        DtpTglLahir.TabIndex = 5
        ' 
        ' LblUmur
        ' 
        LblUmur.AutoSize = True
        LblUmur.BackColor = Color.Transparent
        LblUmur.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblUmur.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblUmur.Location = New Point(464, 167)
        LblUmur.Margin = New Padding(4, 0, 4, 0)
        LblUmur.Name = "LblUmur"
        LblUmur.Size = New Size(118, 23)
        LblUmur.TabIndex = 6
        LblUmur.Text = "Umur (tahun)"
        ' 
        ' TxtUmur
        ' 
        TxtUmur.BackColor = Color.FromArgb(CByte(8), CByte(8), CByte(25))
        TxtUmur.BorderStyle = BorderStyle.FixedSingle
        TxtUmur.Font = New Font("Segoe UI", 10F)
        TxtUmur.ForeColor = Color.FromArgb(CByte(0), CByte(220), CByte(255))
        TxtUmur.Location = New Point(464, 205)
        TxtUmur.Margin = New Padding(4, 5, 4, 5)
        TxtUmur.Name = "TxtUmur"
        TxtUmur.ReadOnly = True
        TxtUmur.Size = New Size(113, 34)
        TxtUmur.TabIndex = 7
        TxtUmur.TabStop = False
        ' 
        ' LblGender
        ' 
        LblGender.AutoSize = True
        LblGender.BackColor = Color.Transparent
        LblGender.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblGender.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblGender.Location = New Point(29, 272)
        LblGender.Margin = New Padding(4, 0, 4, 0)
        LblGender.Name = "LblGender"
        LblGender.Size = New Size(119, 23)
        LblGender.TabIndex = 8
        LblGender.Text = "Jenis Kelamin"
        ' 
        ' GrpGender
        ' 
        GrpGender.BackColor = Color.Transparent
        GrpGender.Controls.Add(RbPria)
        GrpGender.Controls.Add(RbWanita)
        GrpGender.Font = New Font("Segoe UI", 8.5F)
        GrpGender.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(255))
        GrpGender.Location = New Point(26, 310)
        GrpGender.Margin = New Padding(4, 5, 4, 5)
        GrpGender.Name = "GrpGender"
        GrpGender.Padding = New Padding(4, 5, 4, 5)
        GrpGender.Size = New Size(371, 92)
        GrpGender.TabIndex = 9
        GrpGender.TabStop = False
        GrpGender.Text = "  Pilih Gender"
        ' 
        ' RbPria
        ' 
        RbPria.AutoSize = True
        RbPria.BackColor = Color.Transparent
        RbPria.Checked = True
        RbPria.Font = New Font("Segoe UI", 9.5F)
        RbPria.ForeColor = Color.White
        RbPria.Location = New Point(14, 37)
        RbPria.Margin = New Padding(4, 5, 4, 5)
        RbPria.Name = "RbPria"
        RbPria.Size = New Size(107, 29)
        RbPria.TabIndex = 0
        RbPria.TabStop = True
        RbPria.Text = "Laki-laki"
        RbPria.UseVisualStyleBackColor = False
        ' 
        ' RbWanita
        ' 
        RbWanita.AutoSize = True
        RbWanita.BackColor = Color.Transparent
        RbWanita.Font = New Font("Segoe UI", 9.5F)
        RbWanita.ForeColor = Color.White
        RbWanita.Location = New Point(186, 37)
        RbWanita.Margin = New Padding(4, 5, 4, 5)
        RbWanita.Name = "RbWanita"
        RbWanita.Size = New Size(133, 29)
        RbWanita.TabIndex = 1
        RbWanita.Text = "Perempuan"
        RbWanita.UseVisualStyleBackColor = False
        ' 
        ' LblKomunitas
        ' 
        LblKomunitas.AutoSize = True
        LblKomunitas.BackColor = Color.Transparent
        LblKomunitas.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblKomunitas.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblKomunitas.Location = New Point(464, 272)
        LblKomunitas.Margin = New Padding(4, 0, 4, 0)
        LblKomunitas.Name = "LblKomunitas"
        LblKomunitas.Size = New Size(201, 23)
        LblKomunitas.TabIndex = 10
        LblKomunitas.Text = "Jenis Komunitas / Divisi"
        ' 
        ' CmbKomunitas
        ' 
        CmbKomunitas.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(55))
        CmbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        CmbKomunitas.FlatStyle = FlatStyle.Flat
        CmbKomunitas.Font = New Font("Segoe UI", 10F)
        CmbKomunitas.ForeColor = Color.White
        CmbKomunitas.FormattingEnabled = True
        CmbKomunitas.Items.AddRange(New Object() {"Technology & Innovation", "Creative Arts & Design", "Gaming & Esports", "Education & Research", "Environment & Sustainability", "Social Impact & Volunteering", "Business & Entrepreneurship", "Music & Performing Arts", "Sports & Fitness", "Science & Engineering"})
        CmbKomunitas.Location = New Point(464, 310)
        CmbKomunitas.Margin = New Padding(4, 5, 4, 5)
        CmbKomunitas.Name = "CmbKomunitas"
        CmbKomunitas.Size = New Size(428, 36)
        CmbKomunitas.TabIndex = 11
        ' 
        ' BtnNextTab1
        ' 
        BtnNextTab1.BackColor = Color.FromArgb(CByte(0), CByte(150), CByte(220))
        BtnNextTab1.Cursor = Cursors.Hand
        BtnNextTab1.FlatStyle = FlatStyle.Flat
        BtnNextTab1.Font = New Font("Segoe UI Semibold", 10F)
        BtnNextTab1.ForeColor = Color.White
        BtnNextTab1.Location = New Point(842, 490)
        BtnNextTab1.Margin = New Padding(4, 5, 4, 5)
        BtnNextTab1.Name = "BtnNextTab1"
        BtnNextTab1.Size = New Size(257, 40)
        BtnNextTab1.TabIndex = 12
        BtnNextTab1.Text = "Lanjut ke Kontak  ›"
        BtnNextTab1.UseVisualStyleBackColor = False
        ' 
        ' TabKontak
        ' 
        TabKontak.BackColor = Color.FromArgb(CByte(14), CByte(14), CByte(38))
        TabKontak.Controls.Add(LblTelp)
        TabKontak.Controls.Add(MtbTelp)
        TabKontak.Controls.Add(LblFmtTelp)
        TabKontak.Controls.Add(LblEmail)
        TabKontak.Controls.Add(TxtEmail)
        TabKontak.Controls.Add(LblAlamat)
        TabKontak.Controls.Add(TxtAlamat)
        TabKontak.Controls.Add(LblKota)
        TabKontak.Controls.Add(TxtKota)
        TabKontak.Controls.Add(LblProvinsi)
        TabKontak.Controls.Add(TxtProvinsi)
        TabKontak.Controls.Add(BtnBackTab2)
        TabKontak.Controls.Add(BtnNextTab2)
        TabKontak.Location = New Point(4, 37)
        TabKontak.Margin = New Padding(4, 5, 4, 5)
        TabKontak.Name = "TabKontak"
        TabKontak.Padding = New Padding(4, 5, 4, 5)
        TabKontak.Size = New Size(1174, 604)
        TabKontak.TabIndex = 1
        TabKontak.Text = "Kontak & Info"
        ' 
        ' LblTelp
        ' 
        LblTelp.AutoSize = True
        LblTelp.BackColor = Color.Transparent
        LblTelp.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblTelp.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblTelp.Location = New Point(29, 52)
        LblTelp.Margin = New Padding(4, 0, 4, 0)
        LblTelp.Name = "LblTelp"
        LblTelp.Size = New Size(133, 23)
        LblTelp.TabIndex = 0
        LblTelp.Text = "Nomor Telepon"
        ' 
        ' MtbTelp
        ' 
        MtbTelp.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(55))
        MtbTelp.BorderStyle = BorderStyle.FixedSingle
        MtbTelp.Font = New Font("Consolas", 12F, FontStyle.Bold)
        MtbTelp.ForeColor = Color.FromArgb(CByte(0), CByte(220), CByte(255))
        MtbTelp.Location = New Point(29, 91)
        MtbTelp.Margin = New Padding(4, 5, 4, 5)
        MtbTelp.Mask = "0000-0000-00000"
        MtbTelp.Name = "MtbTelp"
        MtbTelp.Size = New Size(371, 36)
        MtbTelp.TabIndex = 1
        ' 
        ' LblFmtTelp
        ' 
        LblFmtTelp.AutoSize = True
        LblFmtTelp.BackColor = Color.Transparent
        LblFmtTelp.Font = New Font("Segoe UI", 8F, FontStyle.Italic)
        LblFmtTelp.ForeColor = Color.FromArgb(CByte(100), CByte(150), CByte(180))
        LblFmtTelp.Location = New Point(29, 151)
        LblFmtTelp.Margin = New Padding(4, 0, 4, 0)
        LblFmtTelp.Name = "LblFmtTelp"
        LblFmtTelp.Size = New Size(197, 21)
        LblFmtTelp.TabIndex = 2
        LblFmtTelp.Text = "Format: 0812-3456-78901"
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.BackColor = Color.Transparent
        LblEmail.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblEmail.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblEmail.Location = New Point(29, 250)
        LblEmail.Margin = New Padding(4, 0, 4, 0)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(54, 23)
        LblEmail.TabIndex = 3
        LblEmail.Text = "Email"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(55))
        TxtEmail.BorderStyle = BorderStyle.FixedSingle
        TxtEmail.Font = New Font("Segoe UI", 10F)
        TxtEmail.ForeColor = Color.White
        TxtEmail.Location = New Point(29, 288)
        TxtEmail.Margin = New Padding(4, 5, 4, 5)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(371, 34)
        TxtEmail.TabIndex = 4
        ' 
        ' LblAlamat
        ' 
        LblAlamat.AutoSize = True
        LblAlamat.BackColor = Color.Transparent
        LblAlamat.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblAlamat.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblAlamat.Location = New Point(510, 52)
        LblAlamat.Margin = New Padding(4, 0, 4, 0)
        LblAlamat.Name = "LblAlamat"
        LblAlamat.Size = New Size(142, 23)
        LblAlamat.TabIndex = 5
        LblAlamat.Text = "Alamat Lengkap"
        ' 
        ' TxtAlamat
        ' 
        TxtAlamat.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(55))
        TxtAlamat.BorderStyle = BorderStyle.FixedSingle
        TxtAlamat.Font = New Font("Segoe UI", 10F)
        TxtAlamat.ForeColor = Color.White
        TxtAlamat.Location = New Point(510, 84)
        TxtAlamat.Margin = New Padding(4, 5, 4, 5)
        TxtAlamat.Name = "TxtAlamat"
        TxtAlamat.Size = New Size(589, 88)
        TxtAlamat.TabIndex = 6
        TxtAlamat.Text = ""
        ' 
        ' LblKota
        ' 
        LblKota.AutoSize = True
        LblKota.BackColor = Color.Transparent
        LblKota.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblKota.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblKota.Location = New Point(510, 250)
        LblKota.Margin = New Padding(4, 0, 4, 0)
        LblKota.Name = "LblKota"
        LblKota.Size = New Size(47, 23)
        LblKota.TabIndex = 7
        LblKota.Text = "Kota"
        ' 
        ' TxtKota
        ' 
        TxtKota.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(55))
        TxtKota.BorderStyle = BorderStyle.FixedSingle
        TxtKota.Font = New Font("Segoe UI", 10F)
        TxtKota.ForeColor = Color.White
        TxtKota.Location = New Point(510, 288)
        TxtKota.Margin = New Padding(4, 5, 4, 5)
        TxtKota.Name = "TxtKota"
        TxtKota.Size = New Size(285, 34)
        TxtKota.TabIndex = 8
        ' 
        ' LblProvinsi
        ' 
        LblProvinsi.AutoSize = True
        LblProvinsi.BackColor = Color.Transparent
        LblProvinsi.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblProvinsi.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblProvinsi.Location = New Point(824, 250)
        LblProvinsi.Margin = New Padding(4, 0, 4, 0)
        LblProvinsi.Name = "LblProvinsi"
        LblProvinsi.Size = New Size(73, 23)
        LblProvinsi.TabIndex = 9
        LblProvinsi.Text = "Provinsi"
        ' 
        ' TxtProvinsi
        ' 
        TxtProvinsi.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(55))
        TxtProvinsi.BorderStyle = BorderStyle.FixedSingle
        TxtProvinsi.Font = New Font("Segoe UI", 10F)
        TxtProvinsi.ForeColor = Color.White
        TxtProvinsi.Location = New Point(824, 288)
        TxtProvinsi.Margin = New Padding(4, 5, 4, 5)
        TxtProvinsi.Name = "TxtProvinsi"
        TxtProvinsi.Size = New Size(275, 34)
        TxtProvinsi.TabIndex = 10
        ' 
        ' BtnBackTab2
        ' 
        BtnBackTab2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(80))
        BtnBackTab2.Cursor = Cursors.Hand
        BtnBackTab2.FlatStyle = FlatStyle.Flat
        BtnBackTab2.Font = New Font("Segoe UI Semibold", 10F)
        BtnBackTab2.ForeColor = Color.FromArgb(CByte(180), CByte(220), CByte(255))
        BtnBackTab2.Location = New Point(627, 517)
        BtnBackTab2.Margin = New Padding(4, 5, 4, 5)
        BtnBackTab2.Name = "BtnBackTab2"
        BtnBackTab2.Size = New Size(223, 42)
        BtnBackTab2.TabIndex = 11
        BtnBackTab2.Text = "‹  Kembali"
        BtnBackTab2.UseVisualStyleBackColor = False
        ' 
        ' BtnNextTab2
        ' 
        BtnNextTab2.BackColor = Color.FromArgb(CByte(0), CByte(150), CByte(220))
        BtnNextTab2.Cursor = Cursors.Hand
        BtnNextTab2.FlatStyle = FlatStyle.Flat
        BtnNextTab2.Font = New Font("Segoe UI Semibold", 10F)
        BtnNextTab2.ForeColor = Color.White
        BtnNextTab2.Location = New Point(875, 517)
        BtnNextTab2.Margin = New Padding(4, 5, 4, 5)
        BtnNextTab2.Name = "BtnNextTab2"
        BtnNextTab2.Size = New Size(223, 42)
        BtnNextTab2.TabIndex = 12
        BtnNextTab2.Text = "Lanjut ke Profil  ›"
        BtnNextTab2.UseVisualStyleBackColor = False
        ' 
        ' TabProfil
        ' 
        TabProfil.BackColor = Color.FromArgb(CByte(14), CByte(14), CByte(38))
        TabProfil.Controls.Add(LblFoto)
        TabProfil.Controls.Add(PbFotoProfil)
        TabProfil.Controls.Add(BtnBrowse)
        TabProfil.Controls.Add(GrpPeran)
        TabProfil.Controls.Add(LblHobi)
        TabProfil.Controls.Add(GrpHobi)
        TabProfil.Controls.Add(BtnBackTab3)
        TabProfil.Controls.Add(BtnSimpanCetak)
        TabProfil.Location = New Point(4, 37)
        TabProfil.Margin = New Padding(4, 5, 4, 5)
        TabProfil.Name = "TabProfil"
        TabProfil.Padding = New Padding(4, 5, 4, 5)
        TabProfil.Size = New Size(1174, 604)
        TabProfil.TabIndex = 2
        TabProfil.Text = "Profil & Aktivitas"
        ' 
        ' LblFoto
        ' 
        LblFoto.AutoSize = True
        LblFoto.BackColor = Color.Transparent
        LblFoto.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblFoto.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblFoto.Location = New Point(29, 33)
        LblFoto.Margin = New Padding(4, 0, 4, 0)
        LblFoto.Name = "LblFoto"
        LblFoto.Size = New Size(95, 23)
        LblFoto.TabIndex = 0
        LblFoto.Text = "Foto Profil"
        ' 
        ' PbFotoProfil
        ' 
        PbFotoProfil.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(55))
        PbFotoProfil.BorderStyle = BorderStyle.FixedSingle
        PbFotoProfil.Location = New Point(29, 66)
        PbFotoProfil.Margin = New Padding(4, 5, 4, 5)
        PbFotoProfil.Name = "PbFotoProfil"
        PbFotoProfil.Size = New Size(208, 295)
        PbFotoProfil.SizeMode = PictureBoxSizeMode.Zoom
        PbFotoProfil.TabIndex = 1
        PbFotoProfil.TabStop = False
        ' 
        ' BtnBrowse
        ' 
        BtnBrowse.BackColor = Color.FromArgb(CByte(0), CByte(150), CByte(220))
        BtnBrowse.Cursor = Cursors.Hand
        BtnBrowse.FlatStyle = FlatStyle.Flat
        BtnBrowse.Font = New Font("Segoe UI", 8.5F)
        BtnBrowse.ForeColor = Color.White
        BtnBrowse.Location = New Point(28, 382)
        BtnBrowse.Margin = New Padding(4, 5, 4, 5)
        BtnBrowse.Name = "BtnBrowse"
        BtnBrowse.Size = New Size(209, 60)
        BtnBrowse.TabIndex = 2
        BtnBrowse.Text = "Browse Foto"
        BtnBrowse.UseVisualStyleBackColor = False
        ' 
        ' GrpPeran
        ' 
        GrpPeran.BackColor = Color.Transparent
        GrpPeran.Controls.Add(RbKetua)
        GrpPeran.Controls.Add(RbWakilKetua)
        GrpPeran.Controls.Add(RbAdmin)
        GrpPeran.Controls.Add(RbSekretaris)
        GrpPeran.Controls.Add(RbBendahara)
        GrpPeran.Controls.Add(RbKoordinator)
        GrpPeran.Controls.Add(RbAnggota)
        GrpPeran.Controls.Add(RbMentor)
        GrpPeran.Font = New Font("Segoe UI Semibold", 9F)
        GrpPeran.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(255))
        GrpPeran.Location = New Point(301, 58)
        GrpPeran.Margin = New Padding(4, 5, 4, 5)
        GrpPeran.Name = "GrpPeran"
        GrpPeran.Padding = New Padding(4, 5, 4, 5)
        GrpPeran.Size = New Size(339, 303)
        GrpPeran.TabIndex = 3
        GrpPeran.TabStop = False
        GrpPeran.Text = "  Peran dalam Komunitas"
        ' 
        ' RbKetua
        ' 
        RbKetua.AutoSize = True
        RbKetua.BackColor = Color.Transparent
        RbKetua.Font = New Font("Segoe UI", 9F)
        RbKetua.ForeColor = Color.White
        RbKetua.Location = New Point(14, 47)
        RbKetua.Margin = New Padding(4, 5, 4, 5)
        RbKetua.Name = "RbKetua"
        RbKetua.Size = New Size(81, 29)
        RbKetua.TabIndex = 0
        RbKetua.Text = "Ketua"
        RbKetua.UseVisualStyleBackColor = False
        ' 
        ' RbWakilKetua
        ' 
        RbWakilKetua.AutoSize = True
        RbWakilKetua.BackColor = Color.Transparent
        RbWakilKetua.Font = New Font("Segoe UI", 9F)
        RbWakilKetua.ForeColor = Color.White
        RbWakilKetua.Location = New Point(190, 47)
        RbWakilKetua.Margin = New Padding(4, 5, 4, 5)
        RbWakilKetua.Name = "RbWakilKetua"
        RbWakilKetua.Size = New Size(128, 29)
        RbWakilKetua.TabIndex = 1
        RbWakilKetua.Text = "Wakil Ketua"
        RbWakilKetua.UseVisualStyleBackColor = False
        ' 
        ' RbAdmin
        ' 
        RbAdmin.AutoSize = True
        RbAdmin.BackColor = Color.Transparent
        RbAdmin.Font = New Font("Segoe UI", 9F)
        RbAdmin.ForeColor = Color.White
        RbAdmin.Location = New Point(14, 97)
        RbAdmin.Margin = New Padding(4, 5, 4, 5)
        RbAdmin.Name = "RbAdmin"
        RbAdmin.Size = New Size(90, 29)
        RbAdmin.TabIndex = 2
        RbAdmin.Text = "Admin"
        RbAdmin.UseVisualStyleBackColor = False
        ' 
        ' RbSekretaris
        ' 
        RbSekretaris.AutoSize = True
        RbSekretaris.BackColor = Color.Transparent
        RbSekretaris.Font = New Font("Segoe UI", 9F)
        RbSekretaris.ForeColor = Color.White
        RbSekretaris.Location = New Point(190, 97)
        RbSekretaris.Margin = New Padding(4, 5, 4, 5)
        RbSekretaris.Name = "RbSekretaris"
        RbSekretaris.Size = New Size(113, 29)
        RbSekretaris.TabIndex = 3
        RbSekretaris.Text = "Sekretaris"
        RbSekretaris.UseVisualStyleBackColor = False
        ' 
        ' RbBendahara
        ' 
        RbBendahara.AutoSize = True
        RbBendahara.BackColor = Color.Transparent
        RbBendahara.Font = New Font("Segoe UI", 9F)
        RbBendahara.ForeColor = Color.White
        RbBendahara.Location = New Point(14, 185)
        RbBendahara.Margin = New Padding(4, 5, 4, 5)
        RbBendahara.Name = "RbBendahara"
        RbBendahara.Size = New Size(120, 29)
        RbBendahara.TabIndex = 4
        RbBendahara.Text = "Bendahara"
        RbBendahara.UseVisualStyleBackColor = False
        ' 
        ' RbKoordinator
        ' 
        RbKoordinator.AutoSize = True
        RbKoordinator.BackColor = Color.Transparent
        RbKoordinator.Font = New Font("Segoe UI", 9F)
        RbKoordinator.ForeColor = Color.White
        RbKoordinator.Location = New Point(190, 185)
        RbKoordinator.Margin = New Padding(4, 5, 4, 5)
        RbKoordinator.Name = "RbKoordinator"
        RbKoordinator.Size = New Size(132, 29)
        RbKoordinator.TabIndex = 5
        RbKoordinator.Text = "Koordinator"
        RbKoordinator.UseVisualStyleBackColor = False
        ' 
        ' RbAnggota
        ' 
        RbAnggota.AutoSize = True
        RbAnggota.BackColor = Color.Transparent
        RbAnggota.Checked = True
        RbAnggota.Font = New Font("Segoe UI", 9F)
        RbAnggota.ForeColor = Color.White
        RbAnggota.Location = New Point(14, 235)
        RbAnggota.Margin = New Padding(4, 5, 4, 5)
        RbAnggota.Name = "RbAnggota"
        RbAnggota.Size = New Size(107, 29)
        RbAnggota.TabIndex = 6
        RbAnggota.TabStop = True
        RbAnggota.Text = "Anggota"
        RbAnggota.UseVisualStyleBackColor = False
        ' 
        ' RbMentor
        ' 
        RbMentor.AutoSize = True
        RbMentor.BackColor = Color.Transparent
        RbMentor.Font = New Font("Segoe UI", 9F)
        RbMentor.ForeColor = Color.White
        RbMentor.Location = New Point(190, 235)
        RbMentor.Margin = New Padding(4, 5, 4, 5)
        RbMentor.Name = "RbMentor"
        RbMentor.Size = New Size(95, 29)
        RbMentor.TabIndex = 7
        RbMentor.Text = "Mentor"
        RbMentor.UseVisualStyleBackColor = False
        ' 
        ' LblHobi
        ' 
        LblHobi.AutoSize = True
        LblHobi.BackColor = Color.Transparent
        LblHobi.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblHobi.ForeColor = Color.FromArgb(CByte(140), CByte(200), CByte(240))
        LblHobi.Location = New Point(732, 33)
        LblHobi.Margin = New Padding(4, 0, 4, 0)
        LblHobi.Name = "LblHobi"
        LblHobi.Size = New Size(269, 23)
        LblHobi.TabIndex = 4
        LblHobi.Text = "Hobi & Aktivitas (pilih minimal 1)"
        ' 
        ' GrpHobi
        ' 
        GrpHobi.BackColor = Color.Transparent
        GrpHobi.Controls.Add(ChkCoding)
        GrpHobi.Controls.Add(ChkDesain)
        GrpHobi.Controls.Add(ChkFotografi)
        GrpHobi.Controls.Add(ChkMusik)
        GrpHobi.Controls.Add(ChkGaming)
        GrpHobi.Controls.Add(ChkMembaca)
        GrpHobi.Controls.Add(ChkTravelling)
        GrpHobi.Controls.Add(ChkOlahraga)
        GrpHobi.Controls.Add(ChkFilm)
        GrpHobi.Controls.Add(ChkRobotik)
        GrpHobi.Controls.Add(ChkNetworking)
        GrpHobi.Controls.Add(ChkPublicSpeak)
        GrpHobi.Font = New Font("Segoe UI", 9F)
        GrpHobi.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(255))
        GrpHobi.Location = New Point(736, 56)
        GrpHobi.Margin = New Padding(4, 5, 4, 5)
        GrpHobi.Name = "GrpHobi"
        GrpHobi.Padding = New Padding(4, 5, 4, 5)
        GrpHobi.Size = New Size(367, 386)
        GrpHobi.TabIndex = 5
        GrpHobi.TabStop = False
        GrpHobi.Text = "  Hobi & Minat"
        ' 
        ' ChkCoding
        ' 
        ChkCoding.AutoSize = True
        ChkCoding.BackColor = Color.Transparent
        ChkCoding.Font = New Font("Segoe UI", 9F)
        ChkCoding.ForeColor = Color.White
        ChkCoding.Location = New Point(14, 37)
        ChkCoding.Margin = New Padding(4, 5, 4, 5)
        ChkCoding.Name = "ChkCoding"
        ChkCoding.Size = New Size(96, 29)
        ChkCoding.TabIndex = 0
        ChkCoding.Text = "Coding"
        ChkCoding.UseVisualStyleBackColor = False
        ' 
        ' ChkDesain
        ' 
        ChkDesain.AutoSize = True
        ChkDesain.BackColor = Color.Transparent
        ChkDesain.Font = New Font("Segoe UI", 9F)
        ChkDesain.ForeColor = Color.White
        ChkDesain.Location = New Point(165, 37)
        ChkDesain.Margin = New Padding(4, 5, 4, 5)
        ChkDesain.Name = "ChkDesain"
        ChkDesain.Size = New Size(141, 29)
        ChkDesain.TabIndex = 1
        ChkDesain.Text = "Desain Grafis"
        ChkDesain.UseVisualStyleBackColor = False
        ' 
        ' ChkFotografi
        ' 
        ChkFotografi.AutoSize = True
        ChkFotografi.BackColor = Color.Transparent
        ChkFotografi.Font = New Font("Segoe UI", 9F)
        ChkFotografi.ForeColor = Color.White
        ChkFotografi.Location = New Point(14, 276)
        ChkFotografi.Margin = New Padding(4, 5, 4, 5)
        ChkFotografi.Name = "ChkFotografi"
        ChkFotografi.Size = New Size(111, 29)
        ChkFotografi.TabIndex = 2
        ChkFotografi.Text = "Fotografi"
        ChkFotografi.UseVisualStyleBackColor = False
        ' 
        ' ChkMusik
        ' 
        ChkMusik.AutoSize = True
        ChkMusik.BackColor = Color.Transparent
        ChkMusik.Font = New Font("Segoe UI", 9F)
        ChkMusik.ForeColor = Color.White
        ChkMusik.Location = New Point(15, 221)
        ChkMusik.Margin = New Padding(4, 5, 4, 5)
        ChkMusik.Name = "ChkMusik"
        ChkMusik.Size = New Size(85, 29)
        ChkMusik.TabIndex = 3
        ChkMusik.Text = "Musik"
        ChkMusik.UseVisualStyleBackColor = False
        ' 
        ' ChkGaming
        ' 
        ChkGaming.AutoSize = True
        ChkGaming.BackColor = Color.Transparent
        ChkGaming.Font = New Font("Segoe UI", 9F)
        ChkGaming.ForeColor = Color.White
        ChkGaming.Location = New Point(14, 100)
        ChkGaming.Margin = New Padding(4, 5, 4, 5)
        ChkGaming.Name = "ChkGaming"
        ChkGaming.Size = New Size(100, 29)
        ChkGaming.TabIndex = 4
        ChkGaming.Text = "Gaming"
        ChkGaming.UseVisualStyleBackColor = False
        ' 
        ' ChkMembaca
        ' 
        ChkMembaca.AutoSize = True
        ChkMembaca.BackColor = Color.Transparent
        ChkMembaca.Font = New Font("Segoe UI", 9F)
        ChkMembaca.ForeColor = Color.White
        ChkMembaca.Location = New Point(165, 100)
        ChkMembaca.Margin = New Padding(4, 5, 4, 5)
        ChkMembaca.Name = "ChkMembaca"
        ChkMembaca.Size = New Size(116, 29)
        ChkMembaca.TabIndex = 5
        ChkMembaca.Text = "Membaca"
        ChkMembaca.UseVisualStyleBackColor = False
        ' 
        ' ChkTravelling
        ' 
        ChkTravelling.AutoSize = True
        ChkTravelling.BackColor = Color.Transparent
        ChkTravelling.Font = New Font("Segoe UI", 9F)
        ChkTravelling.ForeColor = Color.White
        ChkTravelling.Location = New Point(164, 276)
        ChkTravelling.Margin = New Padding(4, 5, 4, 5)
        ChkTravelling.Name = "ChkTravelling"
        ChkTravelling.Size = New Size(111, 29)
        ChkTravelling.TabIndex = 6
        ChkTravelling.Text = "Travelling"
        ChkTravelling.UseVisualStyleBackColor = False
        ' 
        ' ChkOlahraga
        ' 
        ChkOlahraga.AutoSize = True
        ChkOlahraga.BackColor = Color.Transparent
        ChkOlahraga.Font = New Font("Segoe UI", 9F)
        ChkOlahraga.ForeColor = Color.White
        ChkOlahraga.Location = New Point(165, 221)
        ChkOlahraga.Margin = New Padding(4, 5, 4, 5)
        ChkOlahraga.Name = "ChkOlahraga"
        ChkOlahraga.Size = New Size(110, 29)
        ChkOlahraga.TabIndex = 7
        ChkOlahraga.Text = "Olahraga"
        ChkOlahraga.UseVisualStyleBackColor = False
        ' 
        ' ChkFilm
        ' 
        ChkFilm.AutoSize = True
        ChkFilm.BackColor = Color.Transparent
        ChkFilm.Font = New Font("Segoe UI", 9F)
        ChkFilm.ForeColor = Color.White
        ChkFilm.Location = New Point(14, 163)
        ChkFilm.Margin = New Padding(4, 5, 4, 5)
        ChkFilm.Name = "ChkFilm"
        ChkFilm.Size = New Size(71, 29)
        ChkFilm.TabIndex = 8
        ChkFilm.Text = "Film"
        ChkFilm.UseVisualStyleBackColor = False
        ' 
        ' ChkRobotik
        ' 
        ChkRobotik.AutoSize = True
        ChkRobotik.BackColor = Color.Transparent
        ChkRobotik.Font = New Font("Segoe UI", 9F)
        ChkRobotik.ForeColor = Color.White
        ChkRobotik.Location = New Point(165, 163)
        ChkRobotik.Margin = New Padding(4, 5, 4, 5)
        ChkRobotik.Name = "ChkRobotik"
        ChkRobotik.Size = New Size(100, 29)
        ChkRobotik.TabIndex = 9
        ChkRobotik.Text = "Robotik"
        ChkRobotik.UseVisualStyleBackColor = False
        ' 
        ' ChkNetworking
        ' 
        ChkNetworking.AutoSize = True
        ChkNetworking.BackColor = Color.Transparent
        ChkNetworking.Font = New Font("Segoe UI", 9F)
        ChkNetworking.ForeColor = Color.White
        ChkNetworking.Location = New Point(14, 332)
        ChkNetworking.Margin = New Padding(4, 5, 4, 5)
        ChkNetworking.Name = "ChkNetworking"
        ChkNetworking.Size = New Size(130, 29)
        ChkNetworking.TabIndex = 10
        ChkNetworking.Text = "Networking"
        ChkNetworking.UseVisualStyleBackColor = False
        ' 
        ' ChkPublicSpeak
        ' 
        ChkPublicSpeak.AutoSize = True
        ChkPublicSpeak.BackColor = Color.Transparent
        ChkPublicSpeak.Font = New Font("Segoe UI", 9F)
        ChkPublicSpeak.ForeColor = Color.White
        ChkPublicSpeak.Location = New Point(165, 332)
        ChkPublicSpeak.Margin = New Padding(4, 5, 4, 5)
        ChkPublicSpeak.Name = "ChkPublicSpeak"
        ChkPublicSpeak.Size = New Size(163, 29)
        ChkPublicSpeak.TabIndex = 11
        ChkPublicSpeak.Text = "Public Speaking"
        ChkPublicSpeak.UseVisualStyleBackColor = False
        ' 
        ' BtnBackTab3
        ' 
        BtnBackTab3.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(80))
        BtnBackTab3.Cursor = Cursors.Hand
        BtnBackTab3.FlatStyle = FlatStyle.Flat
        BtnBackTab3.Font = New Font("Segoe UI Semibold", 10F)
        BtnBackTab3.ForeColor = Color.FromArgb(CByte(180), CByte(220), CByte(255))
        BtnBackTab3.Location = New Point(620, 501)
        BtnBackTab3.Margin = New Padding(4, 5, 4, 5)
        BtnBackTab3.Name = "BtnBackTab3"
        BtnBackTab3.Size = New Size(194, 42)
        BtnBackTab3.TabIndex = 6
        BtnBackTab3.Text = "‹  Kembali"
        BtnBackTab3.UseVisualStyleBackColor = False
        ' 
        ' BtnSimpanCetak
        ' 
        BtnSimpanCetak.BackColor = Color.FromArgb(CByte(0), CByte(150), CByte(220))
        BtnSimpanCetak.Cursor = Cursors.Hand
        BtnSimpanCetak.FlatStyle = FlatStyle.Flat
        BtnSimpanCetak.Font = New Font("Segoe UI Semibold", 10F)
        BtnSimpanCetak.ForeColor = Color.White
        BtnSimpanCetak.Location = New Point(877, 501)
        BtnSimpanCetak.Margin = New Padding(4, 5, 4, 5)
        BtnSimpanCetak.Name = "BtnSimpanCetak"
        BtnSimpanCetak.Size = New Size(226, 42)
        BtnSimpanCetak.TabIndex = 7
        BtnSimpanCetak.Text = "Simpan & Cetak Kartu"
        BtnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' PnlStatus
        ' 
        PnlStatus.BackColor = Color.FromArgb(CByte(5), CByte(5), CByte(20))
        PnlStatus.Controls.Add(LblStatus)
        PnlStatus.Location = New Point(0, 1183)
        PnlStatus.Margin = New Padding(4, 5, 4, 5)
        PnlStatus.Name = "PnlStatus"
        PnlStatus.Size = New Size(1400, 50)
        PnlStatus.TabIndex = 3
        ' 
        ' LblStatus
        ' 
        LblStatus.AutoSize = True
        LblStatus.BackColor = Color.Transparent
        LblStatus.Font = New Font("Segoe UI", 8.5F)
        LblStatus.ForeColor = Color.FromArgb(CByte(0), CByte(180), CByte(100))
        LblStatus.Location = New Point(0, 12)
        LblStatus.Margin = New Padding(4, 0, 4, 0)
        LblStatus.Name = "LblStatus"
        LblStatus.Size = New Size(433, 23)
        LblStatus.TabIndex = 0
        LblStatus.Text = "  ● Siap  —  NEXUS COMMUNITY Member Card System"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(30))
        ClientSize = New Size(1369, 950)
        Controls.Add(PnlHeader)
        Controls.Add(TabMain)
        Controls.Add(PnlStatus)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 9F)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 5, 4, 5)
        MinimumSize = New Size(1391, 1006)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NEXUS COMMUNITY ─ Sistem Kartu Anggota"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        PnlHeader.ResumeLayout(False)
        PnlHeader.PerformLayout()
        CType(PbLogo, ComponentModel.ISupportInitialize).EndInit()
        TabMain.ResumeLayout(False)
        TabDataUtama.ResumeLayout(False)
        TabDataUtama.PerformLayout()
        GrpGender.ResumeLayout(False)
        GrpGender.PerformLayout()
        TabKontak.ResumeLayout(False)
        TabKontak.PerformLayout()
        TabProfil.ResumeLayout(False)
        TabProfil.PerformLayout()
        CType(PbFotoProfil, ComponentModel.ISupportInitialize).EndInit()
        GrpPeran.ResumeLayout(False)
        GrpPeran.PerformLayout()
        GrpHobi.ResumeLayout(False)
        GrpHobi.PerformLayout()
        PnlStatus.ResumeLayout(False)
        PnlStatus.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MnuInputData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuLihatKartu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuSimpanData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuBukaData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuKeluar As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents PbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents LblJudul As System.Windows.Forms.Label
    Friend WithEvents LblSubJudul As System.Windows.Forms.Label

    Friend WithEvents TabMain As System.Windows.Forms.TabControl
    Friend WithEvents TabDataUtama As System.Windows.Forms.TabPage
    Friend WithEvents TabKontak As System.Windows.Forms.TabPage
    Friend WithEvents TabProfil As System.Windows.Forms.TabPage

    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents LblTglLahir As System.Windows.Forms.Label
    Friend WithEvents DtpTglLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblUmur As System.Windows.Forms.Label
    Friend WithEvents TxtUmur As System.Windows.Forms.TextBox
    Friend WithEvents LblGender As System.Windows.Forms.Label
    Friend WithEvents GrpGender As System.Windows.Forms.GroupBox
    Friend WithEvents RbPria As System.Windows.Forms.RadioButton
    Friend WithEvents RbWanita As System.Windows.Forms.RadioButton
    Friend WithEvents LblKomunitas As System.Windows.Forms.Label
    Friend WithEvents CmbKomunitas As System.Windows.Forms.ComboBox
    Friend WithEvents BtnNextTab1 As System.Windows.Forms.Button

    Friend WithEvents LblTelp As System.Windows.Forms.Label
    Friend WithEvents MtbTelp As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblFmtTelp As System.Windows.Forms.Label
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LblAlamat As System.Windows.Forms.Label
    Friend WithEvents TxtAlamat As System.Windows.Forms.RichTextBox
    Friend WithEvents LblKota As System.Windows.Forms.Label
    Friend WithEvents TxtKota As System.Windows.Forms.TextBox
    Friend WithEvents LblProvinsi As System.Windows.Forms.Label
    Friend WithEvents TxtProvinsi As System.Windows.Forms.TextBox
    Friend WithEvents BtnBackTab2 As System.Windows.Forms.Button
    Friend WithEvents BtnNextTab2 As System.Windows.Forms.Button

    Friend WithEvents LblFoto As System.Windows.Forms.Label
    Friend WithEvents PbFotoProfil As System.Windows.Forms.PictureBox
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents GrpPeran As System.Windows.Forms.GroupBox
    Friend WithEvents RbKetua As System.Windows.Forms.RadioButton
    Friend WithEvents RbWakilKetua As System.Windows.Forms.RadioButton
    Friend WithEvents RbAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents RbSekretaris As System.Windows.Forms.RadioButton
    Friend WithEvents RbBendahara As System.Windows.Forms.RadioButton
    Friend WithEvents RbKoordinator As System.Windows.Forms.RadioButton
    Friend WithEvents RbAnggota As System.Windows.Forms.RadioButton
    Friend WithEvents RbMentor As System.Windows.Forms.RadioButton
    Friend WithEvents LblHobi As System.Windows.Forms.Label
    Friend WithEvents GrpHobi As System.Windows.Forms.GroupBox
    Friend WithEvents ChkCoding As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDesain As System.Windows.Forms.CheckBox
    Friend WithEvents ChkFotografi As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMusik As System.Windows.Forms.CheckBox
    Friend WithEvents ChkGaming As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMembaca As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTravelling As System.Windows.Forms.CheckBox
    Friend WithEvents ChkOlahraga As System.Windows.Forms.CheckBox
    Friend WithEvents ChkFilm As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRobotik As System.Windows.Forms.CheckBox
    Friend WithEvents ChkNetworking As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPublicSpeak As System.Windows.Forms.CheckBox
    Friend WithEvents BtnBackTab3 As System.Windows.Forms.Button
    Friend WithEvents BtnSimpanCetak As System.Windows.Forms.Button

    Friend WithEvents PnlStatus As System.Windows.Forms.Panel
    Friend WithEvents LblStatus As System.Windows.Forms.Label
End Class