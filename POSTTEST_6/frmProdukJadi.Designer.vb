<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProdukJadi
    Inherits System.Windows.Forms.Form
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblTitle = New Label()
        pnlLeft = New Panel()
        lblFormTitle = New Label()
        lblNama = New Label()
        txtNama = New TextBox()
        lblKategori = New Label()
        cboKategori = New ComboBox()
        lblHarga = New Label()
        txtHarga = New TextBox()
        lblStok = New Label()
        txtStok = New TextBox()
        lblKet = New Label()
        txtKet = New TextBox()
        btnSimpan = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnTutup = New Button()
        pnlRight = New Panel()
        lblJumlah = New Label()
        dgvProduk = New DataGridView()
        pnlHeader.SuspendLayout()
        pnlLeft.SuspendLayout()
        pnlRight.SuspendLayout()
        CType(dgvProduk, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(960, 60)
        pnlHeader.TabIndex = 2
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 16)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(418, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Manajemen Produk - Depot Air Minum Barokah"
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.White
        pnlLeft.Controls.Add(lblFormTitle)
        pnlLeft.Controls.Add(lblNama)
        pnlLeft.Controls.Add(txtNama)
        pnlLeft.Controls.Add(lblKategori)
        pnlLeft.Controls.Add(cboKategori)
        pnlLeft.Controls.Add(lblHarga)
        pnlLeft.Controls.Add(txtHarga)
        pnlLeft.Controls.Add(lblStok)
        pnlLeft.Controls.Add(txtStok)
        pnlLeft.Controls.Add(lblKet)
        pnlLeft.Controls.Add(txtKet)
        pnlLeft.Controls.Add(btnSimpan)
        pnlLeft.Controls.Add(btnHapus)
        pnlLeft.Controls.Add(btnBatal)
        pnlLeft.Controls.Add(btnTutup)
        pnlLeft.Location = New Point(0, 60)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Padding = New Padding(16, 16, 16, 16)
        pnlLeft.Size = New Size(300, 560)
        pnlLeft.TabIndex = 1
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        lblFormTitle.Location = New Point(16, 14)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(135, 19)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "Form Input Produk"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNama.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblNama.Location = New Point(16, 50)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(82, 15)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama Produk"
        ' 
        ' txtNama
        ' 
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Font = New Font("Segoe UI", 10.0F)
        txtNama.Location = New Point(16, 68)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(260, 25)
        txtNama.TabIndex = 2
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblKategori.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblKategori.Location = New Point(16, 108)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(55, 15)
        lblKategori.TabIndex = 3
        lblKategori.Text = "Kategori"
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.Font = New Font("Segoe UI", 10.0F)
        cboKategori.Items.AddRange(New Object() {"Galon", "Botol", "Lainnya"})
        cboKategori.Location = New Point(16, 126)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(260, 25)
        cboKategori.TabIndex = 4
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblHarga.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblHarga.Location = New Point(16, 166)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(66, 15)
        lblHarga.TabIndex = 5
        lblHarga.Text = "Harga (Rp)"
        ' 
        ' txtHarga
        ' 
        txtHarga.BorderStyle = BorderStyle.FixedSingle
        txtHarga.Font = New Font("Segoe UI", 10.0F)
        txtHarga.Location = New Point(16, 184)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(260, 25)
        txtHarga.TabIndex = 6
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblStok.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblStok.Location = New Point(16, 224)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(66, 15)
        lblStok.TabIndex = 7
        lblStok.Text = "Stok (unit)"
        ' 
        ' txtStok
        ' 
        txtStok.BorderStyle = BorderStyle.FixedSingle
        txtStok.Font = New Font("Segoe UI", 10.0F)
        txtStok.Location = New Point(16, 242)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(260, 25)
        txtStok.TabIndex = 8
        ' 
        ' lblKet
        ' 
        lblKet.AutoSize = True
        lblKet.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblKet.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblKet.Location = New Point(16, 282)
        lblKet.Name = "lblKet"
        lblKet.Size = New Size(72, 15)
        lblKet.TabIndex = 9
        lblKet.Text = "Keterangan"
        ' 
        ' txtKet
        ' 
        txtKet.BorderStyle = BorderStyle.FixedSingle
        txtKet.Font = New Font("Segoe UI", 10.0F)
        txtKet.Location = New Point(16, 300)
        txtKet.Multiline = True
        txtKet.Name = "txtKet"
        txtKet.Size = New Size(260, 70)
        txtKet.TabIndex = 10
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(16, 388)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(122, 34)
        btnSimpan.TabIndex = 11
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
        btnHapus.Location = New Point(154, 388)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(122, 34)
        btnHapus.TabIndex = 12
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
        btnBatal.Location = New Point(16, 432)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(122, 34)
        btnBatal.TabIndex = 13
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
        btnTutup.Location = New Point(154, 432)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(122, 34)
        btnTutup.TabIndex = 14
        btnTutup.Text = "TUTUP"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        pnlRight.Controls.Add(lblJumlah)
        pnlRight.Controls.Add(dgvProduk)
        pnlRight.Location = New Point(300, 60)
        pnlRight.Name = "pnlRight"
        pnlRight.Padding = New Padding(12, 12, 12, 12)
        pnlRight.Size = New Size(660, 560)
        pnlRight.TabIndex = 0
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblJumlah.ForeColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        lblJumlah.Location = New Point(12, 12)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(90, 15)
        lblJumlah.TabIndex = 0
        lblJumlah.Text = "Total Produk: 0"
        ' 
        ' dgvProduk
        ' 
        dgvProduk.AllowUserToAddRows = False
        dgvProduk.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(230), CByte(241), CByte(251))
        dgvProduk.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvProduk.BackgroundColor = Color.White
        dgvProduk.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvProduk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvProduk.ColumnHeadersHeight = 34
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvProduk.DefaultCellStyle = DataGridViewCellStyle3
        dgvProduk.EnableHeadersVisualStyles = False
        dgvProduk.GridColor = Color.FromArgb(CByte(200), CByte(220), CByte(240))
        dgvProduk.Location = New Point(12, 36)
        dgvProduk.MultiSelect = False
        dgvProduk.Name = "dgvProduk"
        dgvProduk.ReadOnly = True
        dgvProduk.RowHeadersVisible = False
        dgvProduk.RowHeadersWidth = 62
        dgvProduk.RowTemplate.Height = 28
        dgvProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProduk.Size = New Size(636, 506)
        dgvProduk.TabIndex = 1
        ' 
        ' frmProdukJadi
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(960, 620)
        Controls.Add(pnlRight)
        Controls.Add(pnlLeft)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmProdukJadi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manajemen Produk - Depot Barokah"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        pnlRight.ResumeLayout(False)
        pnlRight.PerformLayout()
        CType(dgvProduk, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblKategori As Label
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents lblHarga As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents lblStok As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents lblKet As Label
    Friend WithEvents txtKet As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents pnlRight As Panel
    Friend WithEvents lblJumlah As Label
    Friend WithEvents dgvProduk As DataGridView
End Class