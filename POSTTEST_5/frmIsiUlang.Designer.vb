<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIsiUlang
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
        lblHP = New Label()
        txtHP = New TextBox()
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
        pnlHeader.Margin = New Padding(4, 5, 4, 5)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1457, 100)
        pnlHeader.TabIndex = 2
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(29, 27)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(743, 36)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Manajemen Isi Ulang / Pesanan - Depot Air Minum Barokah"
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.White
        pnlLeft.Controls.Add(lblFormTitle)
        pnlLeft.Controls.Add(lblNama)
        pnlLeft.Controls.Add(txtNama)
        pnlLeft.Controls.Add(lblHP)
        pnlLeft.Controls.Add(txtHP)
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
        pnlLeft.Location = New Point(0, 100)
        pnlLeft.Margin = New Padding(4, 5, 4, 5)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(429, 1033)
        pnlLeft.TabIndex = 1
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.FromArgb(CByte(15), CByte(110), CByte(86))
        lblFormTitle.Location = New Point(23, 23)
        lblFormTitle.Margin = New Padding(4, 0, 4, 0)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(199, 28)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "Form Input Pesanan"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNama.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblNama.Location = New Point(23, 83)
        lblNama.Margin = New Padding(4, 0, 4, 0)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(156, 25)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama Pelanggan"
        ' 
        ' txtNama
        ' 
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Font = New Font("Segoe UI", 10.0F)
        txtNama.Location = New Point(23, 113)
        txtNama.Margin = New Padding(4, 5, 4, 5)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(376, 34)
        txtNama.TabIndex = 2
        ' 
        ' lblHP
        ' 
        lblHP.AutoSize = True
        lblHP.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblHP.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblHP.Location = New Point(23, 180)
        lblHP.Margin = New Padding(4, 0, 4, 0)
        lblHP.Name = "lblHP"
        lblHP.Size = New Size(72, 25)
        lblHP.TabIndex = 3
        lblHP.Text = "No. HP"
        ' 
        ' txtHP
        ' 
        txtHP.BorderStyle = BorderStyle.FixedSingle
        txtHP.Font = New Font("Segoe UI", 10.0F)
        txtHP.Location = New Point(23, 210)
        txtHP.Margin = New Padding(4, 5, 4, 5)
        txtHP.Name = "txtHP"
        txtHP.Size = New Size(376, 34)
        txtHP.TabIndex = 4
        ' 
        ' lblProduk
        ' 
        lblProduk.AutoSize = True
        lblProduk.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblProduk.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblProduk.Location = New Point(23, 277)
        lblProduk.Margin = New Padding(4, 0, 4, 0)
        lblProduk.Name = "lblProduk"
        lblProduk.Size = New Size(73, 25)
        lblProduk.TabIndex = 5
        lblProduk.Text = "Produk"
        ' 
        ' cboProduk
        ' 
        cboProduk.DropDownStyle = ComboBoxStyle.DropDownList
        cboProduk.Font = New Font("Segoe UI", 10.0F)
        cboProduk.Location = New Point(23, 307)
        cboProduk.Margin = New Padding(4, 5, 4, 5)
        cboProduk.Name = "cboProduk"
        cboProduk.Size = New Size(375, 36)
        cboProduk.TabIndex = 6
        ' 
        ' lblJumlahInput
        ' 
        lblJumlahInput.AutoSize = True
        lblJumlahInput.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblJumlahInput.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblJumlahInput.Location = New Point(23, 373)
        lblJumlahInput.Margin = New Padding(4, 0, 4, 0)
        lblJumlahInput.Name = "lblJumlahInput"
        lblJumlahInput.Size = New Size(73, 25)
        lblJumlahInput.TabIndex = 7
        lblJumlahInput.Text = "Jumlah"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.BorderStyle = BorderStyle.FixedSingle
        txtJumlah.Font = New Font("Segoe UI", 10.0F)
        txtJumlah.Location = New Point(23, 403)
        txtJumlah.Margin = New Padding(4, 5, 4, 5)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(376, 34)
        txtJumlah.TabIndex = 8
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblTotal.Location = New Point(23, 470)
        lblTotal.Margin = New Padding(4, 0, 4, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(153, 25)
        lblTotal.TabIndex = 9
        lblTotal.Text = "Total Harga (Rp)"
        ' 
        ' txtTotal
        ' 
        txtTotal.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        txtTotal.BorderStyle = BorderStyle.FixedSingle
        txtTotal.Font = New Font("Segoe UI", 10.0F)
        txtTotal.Location = New Point(23, 500)
        txtTotal.Margin = New Padding(4, 5, 4, 5)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(376, 34)
        txtTotal.TabIndex = 10
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTgl.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblTgl.Location = New Point(23, 567)
        lblTgl.Margin = New Padding(4, 0, 4, 0)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(79, 25)
        lblTgl.TabIndex = 11
        lblTgl.Text = "Tanggal"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Font = New Font("Segoe UI", 10.0F)
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(23, 597)
        dtpTanggal.Margin = New Padding(4, 5, 4, 5)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(375, 34)
        dtpTanggal.TabIndex = 12
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblStatus.Location = New Point(23, 663)
        lblStatus.Margin = New Padding(4, 0, 4, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(65, 25)
        lblStatus.TabIndex = 13
        lblStatus.Text = "Status"
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10.0F)
        cboStatus.Items.AddRange(New Object() {"Proses", "Selesai"})
        cboStatus.Location = New Point(23, 693)
        cboStatus.Margin = New Padding(4, 5, 4, 5)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(375, 36)
        cboStatus.TabIndex = 14
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(23, 777)
        btnSimpan.Margin = New Padding(4, 5, 4, 5)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(174, 57)
        btnSimpan.TabIndex = 15
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
        btnHapus.Location = New Point(220, 777)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(174, 57)
        btnHapus.TabIndex = 16
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
        btnBatal.Location = New Point(23, 850)
        btnBatal.Margin = New Padding(4, 5, 4, 5)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(174, 57)
        btnBatal.TabIndex = 17
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
        btnTutup.Location = New Point(220, 850)
        btnTutup.Margin = New Padding(4, 5, 4, 5)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(174, 57)
        btnTutup.TabIndex = 18
        btnTutup.Text = "TUTUP"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        pnlRight.Controls.Add(lblJumlah)
        pnlRight.Controls.Add(dgvPesan)
        pnlRight.Location = New Point(429, 100)
        pnlRight.Margin = New Padding(4, 5, 4, 5)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(1029, 1033)
        pnlRight.TabIndex = 0
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblJumlah.ForeColor = Color.FromArgb(CByte(15), CByte(110), CByte(86))
        lblJumlah.Location = New Point(17, 20)
        lblJumlah.Margin = New Padding(4, 0, 4, 0)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(149, 25)
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
        dgvPesan.Location = New Point(17, 60)
        dgvPesan.Margin = New Padding(4, 5, 4, 5)
        dgvPesan.MultiSelect = False
        dgvPesan.Name = "dgvPesan"
        dgvPesan.ReadOnly = True
        dgvPesan.RowHeadersVisible = False
        dgvPesan.RowHeadersWidth = 62
        dgvPesan.RowTemplate.Height = 28
        dgvPesan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPesan.Size = New Size(994, 943)
        dgvPesan.TabIndex = 1
        ' 
        ' frmIsiUlang
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1457, 1050)
        Controls.Add(pnlRight)
        Controls.Add(pnlLeft)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
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

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblHP As System.Windows.Forms.Label
    Friend WithEvents txtHP As System.Windows.Forms.TextBox
    Friend WithEvents lblProduk As System.Windows.Forms.Label
    Friend WithEvents cboProduk As System.Windows.Forms.ComboBox
    Friend WithEvents lblJumlahInput As System.Windows.Forms.Label
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTgl As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents dgvPesan As System.Windows.Forms.DataGridView

End Class