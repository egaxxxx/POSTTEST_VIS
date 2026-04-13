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
        pnlHeader.Margin = New Padding(4, 5, 4, 5)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1371, 100)
        pnlHeader.TabIndex = 2
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(29, 27)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(601, 36)
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
        pnlLeft.Location = New Point(0, 100)
        pnlLeft.Margin = New Padding(4, 5, 4, 5)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Padding = New Padding(23, 27, 23, 27)
        pnlLeft.Size = New Size(429, 933)
        pnlLeft.TabIndex = 1
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        lblFormTitle.Location = New Point(23, 23)
        lblFormTitle.Margin = New Padding(4, 0, 4, 0)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(189, 28)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "Form Input Produk"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNama.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblNama.Location = New Point(23, 83)
        lblNama.Margin = New Padding(4, 0, 4, 0)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(128, 25)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama Produk"
        ' 
        ' txtNama
        ' 
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Font = New Font("Segoe UI", 10F)
        txtNama.Location = New Point(23, 113)
        txtNama.Margin = New Padding(4, 5, 4, 5)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(371, 34)
        txtNama.TabIndex = 2
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblKategori.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblKategori.Location = New Point(23, 180)
        lblKategori.Margin = New Padding(4, 0, 4, 0)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(85, 25)
        lblKategori.TabIndex = 3
        lblKategori.Text = "Kategori"
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.Font = New Font("Segoe UI", 10F)
        cboKategori.Items.AddRange(New Object() {"Galon", "Botol", "Lainnya"})
        cboKategori.Location = New Point(23, 210)
        cboKategori.Margin = New Padding(4, 5, 4, 5)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(370, 36)
        cboKategori.TabIndex = 4
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblHarga.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblHarga.Location = New Point(23, 277)
        lblHarga.Margin = New Padding(4, 0, 4, 0)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(106, 25)
        lblHarga.TabIndex = 5
        lblHarga.Text = "Harga (Rp)"
        ' 
        ' txtHarga
        ' 
        txtHarga.BorderStyle = BorderStyle.FixedSingle
        txtHarga.Font = New Font("Segoe UI", 10F)
        txtHarga.Location = New Point(23, 307)
        txtHarga.Margin = New Padding(4, 5, 4, 5)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(371, 34)
        txtHarga.TabIndex = 6
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStok.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblStok.Location = New Point(23, 373)
        lblStok.Margin = New Padding(4, 0, 4, 0)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(103, 25)
        lblStok.TabIndex = 7
        lblStok.Text = "Stok (unit)"
        ' 
        ' txtStok
        ' 
        txtStok.BorderStyle = BorderStyle.FixedSingle
        txtStok.Font = New Font("Segoe UI", 10F)
        txtStok.Location = New Point(23, 403)
        txtStok.Margin = New Padding(4, 5, 4, 5)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(371, 34)
        txtStok.TabIndex = 8
        ' 
        ' lblKet
        ' 
        lblKet.AutoSize = True
        lblKet.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblKet.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblKet.Location = New Point(23, 470)
        lblKet.Margin = New Padding(4, 0, 4, 0)
        lblKet.Name = "lblKet"
        lblKet.Size = New Size(111, 25)
        lblKet.TabIndex = 9
        lblKet.Text = "Keterangan"
        ' 
        ' txtKet
        ' 
        txtKet.BorderStyle = BorderStyle.FixedSingle
        txtKet.Font = New Font("Segoe UI", 10F)
        txtKet.Location = New Point(23, 500)
        txtKet.Margin = New Padding(4, 5, 4, 5)
        txtKet.Multiline = True
        txtKet.Name = "txtKet"
        txtKet.Size = New Size(371, 115)
        txtKet.TabIndex = 10
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(23, 647)
        btnSimpan.Margin = New Padding(4, 5, 4, 5)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(174, 57)
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
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(220, 647)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(174, 57)
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
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(23, 720)
        btnBatal.Margin = New Padding(4, 5, 4, 5)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(174, 57)
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
        btnTutup.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(220, 720)
        btnTutup.Margin = New Padding(4, 5, 4, 5)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(174, 57)
        btnTutup.TabIndex = 14
        btnTutup.Text = "TUTUP"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        pnlRight.Controls.Add(lblJumlah)
        pnlRight.Controls.Add(dgvProduk)
        pnlRight.Location = New Point(429, 100)
        pnlRight.Margin = New Padding(4, 5, 4, 5)
        pnlRight.Name = "pnlRight"
        pnlRight.Padding = New Padding(17, 20, 17, 20)
        pnlRight.Size = New Size(943, 933)
        pnlRight.TabIndex = 0
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblJumlah.ForeColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        lblJumlah.Location = New Point(17, 20)
        lblJumlah.Margin = New Padding(4, 0, 4, 0)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(141, 25)
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
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvProduk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvProduk.ColumnHeadersHeight = 34
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvProduk.DefaultCellStyle = DataGridViewCellStyle3
        dgvProduk.EnableHeadersVisualStyles = False
        dgvProduk.GridColor = Color.FromArgb(CByte(200), CByte(220), CByte(240))
        dgvProduk.Location = New Point(17, 60)
        dgvProduk.Margin = New Padding(4, 5, 4, 5)
        dgvProduk.MultiSelect = False
        dgvProduk.Name = "dgvProduk"
        dgvProduk.ReadOnly = True
        dgvProduk.RowHeadersVisible = False
        dgvProduk.RowHeadersWidth = 62
        dgvProduk.RowTemplate.Height = 28
        dgvProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProduk.Size = New Size(909, 843)
        dgvProduk.TabIndex = 1
        ' 
        ' frmProdukJadi
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1371, 1033)
        Controls.Add(pnlRight)
        Controls.Add(pnlLeft)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
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

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblKategori As System.Windows.Forms.Label
    Friend WithEvents cboKategori As System.Windows.Forms.ComboBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents lblStok As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents lblKet As System.Windows.Forms.Label
    Friend WithEvents txtKet As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents dgvProduk As System.Windows.Forms.DataGridView

End Class