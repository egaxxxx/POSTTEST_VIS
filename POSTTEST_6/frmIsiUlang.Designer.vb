<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIsiUlang
    Inherits System.Windows.Forms.Form
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblTitle = New Label()
        pnlLeft = New Panel()
        lblFormTitle = New Label()
        lblHP = New Label()
        txtHP = New TextBox()
        lblPelanggan = New Label()
        cboPelanggan = New ComboBox()
        lblProduk = New Label()
        cboProduk = New ComboBox()
        lblJumlahInput = New Label()
        txtJumlah = New TextBox()
        lblTotal = New Label()
        txtTotal = New TextBox()
        lblTgl = New Label()
        dtpTanggal = New DateTimePicker()
        lblStatus = New Label()
        cboStatus = New ComboBox()
        btnSimpan = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnTutup = New Button()
        pnlRight = New Panel()
        lblJumlah = New Label()
        dgvPesan = New DataGridView()
        pnlHeader.SuspendLayout()
        pnlLeft.SuspendLayout()
        pnlRight.SuspendLayout()
        CType(dgvPesan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(110), CByte(86))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1020, 60)
        pnlHeader.TabIndex = 2
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 16)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(519, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Manajemen Isi Ulang / Pesanan - Depot Air Minum Barokah"
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.White
        pnlLeft.Controls.Add(lblFormTitle)
        pnlLeft.Controls.Add(lblHP)
        pnlLeft.Controls.Add(txtHP)
        pnlLeft.Controls.Add(lblPelanggan)
        pnlLeft.Controls.Add(cboPelanggan)
        pnlLeft.Controls.Add(lblProduk)
        pnlLeft.Controls.Add(cboProduk)
        pnlLeft.Controls.Add(lblJumlahInput)
        pnlLeft.Controls.Add(txtJumlah)
        pnlLeft.Controls.Add(lblTotal)
        pnlLeft.Controls.Add(txtTotal)
        pnlLeft.Controls.Add(lblTgl)
        pnlLeft.Controls.Add(dtpTanggal)
        pnlLeft.Controls.Add(lblStatus)
        pnlLeft.Controls.Add(cboStatus)
        pnlLeft.Controls.Add(btnSimpan)
        pnlLeft.Controls.Add(btnHapus)
        pnlLeft.Controls.Add(btnBatal)
        pnlLeft.Controls.Add(btnTutup)
        pnlLeft.Location = New Point(0, 60)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(300, 620)
        pnlLeft.TabIndex = 1
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.FromArgb(CByte(15), CByte(110), CByte(86))
        lblFormTitle.Location = New Point(16, 14)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(141, 19)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "Form Input Pesanan"
        ' 
        ' lblHP
        ' 
        lblHP.AutoSize = True
        lblHP.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblHP.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblHP.Location = New Point(16, 50)
        lblHP.Name = "lblHP"
        lblHP.Size = New Size(45, 15)
        lblHP.TabIndex = 1
        lblHP.Text = "No. HP"
        ' 
        ' txtHP
        ' 
        txtHP.BorderStyle = BorderStyle.FixedSingle
        txtHP.Font = New Font("Segoe UI", 10.0F)
        txtHP.Location = New Point(16, 68)
        txtHP.Name = "txtHP"
        txtHP.Size = New Size(264, 25)
        txtHP.TabIndex = 2
        ' 
        ' lblPelanggan
        ' 
        lblPelanggan.AutoSize = True
        lblPelanggan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPelanggan.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblPelanggan.Location = New Point(16, 102)
        lblPelanggan.Name = "lblPelanggan"
        lblPelanggan.Size = New Size(90, 15)
        lblPelanggan.TabIndex = 25
        lblPelanggan.Text = "Pilih Pelanggan"
        ' 
        ' cboPelanggan
        ' 
        cboPelanggan.DropDownStyle = ComboBoxStyle.DropDownList
        cboPelanggan.Font = New Font("Segoe UI", 10.0F)
        cboPelanggan.Location = New Point(16, 120)
        cboPelanggan.Name = "cboPelanggan"
        cboPelanggan.Size = New Size(264, 25)
        cboPelanggan.TabIndex = 26
        ' 
        ' lblProduk
        ' 
        lblProduk.AutoSize = True
        lblProduk.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblProduk.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblProduk.Location = New Point(16, 162)
        lblProduk.Name = "lblProduk"
        lblProduk.Size = New Size(47, 15)
        lblProduk.TabIndex = 3
        lblProduk.Text = "Produk"
        ' 
        ' cboProduk
        ' 
        cboProduk.DropDownStyle = ComboBoxStyle.DropDownList
        cboProduk.Font = New Font("Segoe UI", 10.0F)
        cboProduk.Location = New Point(16, 180)
        cboProduk.Name = "cboProduk"
        cboProduk.Size = New Size(264, 25)
        cboProduk.TabIndex = 4
        ' 
        ' lblJumlahInput
        ' 
        lblJumlahInput.AutoSize = True
        lblJumlahInput.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblJumlahInput.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblJumlahInput.Location = New Point(16, 222)
        lblJumlahInput.Name = "lblJumlahInput"
        lblJumlahInput.Size = New Size(46, 15)
        lblJumlahInput.TabIndex = 5
        lblJumlahInput.Text = "Jumlah"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.BorderStyle = BorderStyle.FixedSingle
        txtJumlah.Font = New Font("Segoe UI", 10.0F)
        txtJumlah.Location = New Point(16, 240)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(264, 25)
        txtJumlah.TabIndex = 6
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblTotal.Location = New Point(16, 282)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(96, 15)
        lblTotal.TabIndex = 7
        lblTotal.Text = "Total Harga (Rp)"
        ' 
        ' txtTotal
        ' 
        txtTotal.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        txtTotal.BorderStyle = BorderStyle.FixedSingle
        txtTotal.Font = New Font("Segoe UI", 10.0F)
        txtTotal.Location = New Point(16, 300)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(264, 25)
        txtTotal.TabIndex = 8
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTgl.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblTgl.Location = New Point(16, 342)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(49, 15)
        lblTgl.TabIndex = 9
        lblTgl.Text = "Tanggal"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Font = New Font("Segoe UI", 10.0F)
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(16, 360)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(264, 25)
        dtpTanggal.TabIndex = 10
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblStatus.Location = New Point(16, 402)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(42, 15)
        lblStatus.TabIndex = 11
        lblStatus.Text = "Status"
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10.0F)
        cboStatus.Items.AddRange(New Object() {"Proses", "Selesai"})
        cboStatus.Location = New Point(16, 420)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(264, 25)
        cboStatus.TabIndex = 12
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(16, 468)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(122, 34)
        btnSimpan.TabIndex = 13
        btnSimpan.Text = "SIMPAN"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(163), CByte(45), CByte(45))
        btnHapus.Cursor = Cursors.Hand
        btnHapus.Enabled = False
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(154, 468)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(122, 34)
        btnHapus.TabIndex = 14
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(133), CByte(79), CByte(11))
        btnBatal.Cursor = Cursors.Hand
        btnBatal.Enabled = False
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(16, 510)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(122, 34)
        btnBatal.TabIndex = 15
        btnBatal.Text = "BATAL"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnTutup.Cursor = Cursors.Hand
        btnTutup.FlatAppearance.BorderSize = 0
        btnTutup.FlatStyle = FlatStyle.Flat
        btnTutup.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(154, 510)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(122, 34)
        btnTutup.TabIndex = 16
        btnTutup.Text = "TUTUP"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        pnlRight.Controls.Add(lblJumlah)
        pnlRight.Controls.Add(dgvPesan)
        pnlRight.Location = New Point(300, 60)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(720, 620)
        pnlRight.TabIndex = 0
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblJumlah.ForeColor = Color.FromArgb(CByte(15), CByte(110), CByte(86))
        lblJumlah.Location = New Point(12, 12)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(95, 15)
        lblJumlah.TabIndex = 0
        lblJumlah.Text = "Total Pesanan: 0"
        ' 
        ' dgvPesan
        ' 
        dgvPesan.AllowUserToAddRows = False
        dgvPesan.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(225), CByte(245), CByte(237))
        dgvPesan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvPesan.BackgroundColor = Color.White
        dgvPesan.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(15), CByte(110), CByte(86))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvPesan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvPesan.ColumnHeadersHeight = 34
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvPesan.DefaultCellStyle = DataGridViewCellStyle3
        dgvPesan.EnableHeadersVisualStyles = False
        dgvPesan.GridColor = Color.FromArgb(CByte(180), CByte(220), CByte(205))
        dgvPesan.Location = New Point(12, 36)
        dgvPesan.MultiSelect = False
        dgvPesan.Name = "dgvPesan"
        dgvPesan.ReadOnly = True
        dgvPesan.RowHeadersVisible = False
        dgvPesan.RowHeadersWidth = 62
        dgvPesan.RowTemplate.Height = 28
        dgvPesan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPesan.Size = New Size(696, 566)
        dgvPesan.TabIndex = 1
        ' 
        ' frmIsiUlang
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1020, 630)
        Controls.Add(pnlRight)
        Controls.Add(pnlLeft)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmIsiUlang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manajemen Isi Ulang - Depot Barokah"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        pnlRight.ResumeLayout(False)
        pnlRight.PerformLayout()
        CType(dgvPesan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblHP As Label
    Friend WithEvents txtHP As TextBox
    Friend WithEvents lblPelanggan As Label
    Friend WithEvents cboPelanggan As ComboBox
    Friend WithEvents lblProduk As Label
    Friend WithEvents cboProduk As ComboBox
    Friend WithEvents lblJumlahInput As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTgl As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents lblStatus As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents pnlRight As Panel
    Friend WithEvents lblJumlah As Label
    Friend WithEvents dgvPesan As DataGridView
End Class
