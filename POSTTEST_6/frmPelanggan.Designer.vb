<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPelanggan
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
        lblNama = New Label()
        txtNama = New TextBox()
        lblHP = New Label()
        txtHP = New TextBox()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        lblStatus = New Label()
        cboStatus = New ComboBox()
        btnSimpan = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnTutup = New Button()
        pnlRight = New Panel()
        lblJumlah = New Label()
        dgvPelanggan = New DataGridView()
        pnlHeader.SuspendLayout()
        pnlLeft.SuspendLayout()
        pnlRight.SuspendLayout()
        CType(dgvPelanggan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(110), CByte(86))
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
        lblTitle.Size = New Size(446, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Manajemen Pelanggan - Depot Air Minum Barokah"
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.White
        pnlLeft.Controls.Add(lblFormTitle)
        pnlLeft.Controls.Add(lblNama)
        pnlLeft.Controls.Add(txtNama)
        pnlLeft.Controls.Add(lblHP)
        pnlLeft.Controls.Add(txtHP)
        pnlLeft.Controls.Add(lblAlamat)
        pnlLeft.Controls.Add(txtAlamat)
        pnlLeft.Controls.Add(lblStatus)
        pnlLeft.Controls.Add(cboStatus)
        pnlLeft.Controls.Add(btnSimpan)
        pnlLeft.Controls.Add(btnHapus)
        pnlLeft.Controls.Add(btnBatal)
        pnlLeft.Controls.Add(btnTutup)
        pnlLeft.Location = New Point(0, 60)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Padding = New Padding(16, 16, 16, 16)
        pnlLeft.Size = New Size(300, 500)
        pnlLeft.TabIndex = 1
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.FromArgb(CByte(15), CByte(110), CByte(86))
        lblFormTitle.Location = New Point(16, 14)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(157, 19)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "Form Input Pelanggan"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNama.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblNama.Location = New Point(16, 50)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(99, 15)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama Pelanggan"
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
        ' lblHP
        ' 
        lblHP.AutoSize = True
        lblHP.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblHP.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblHP.Location = New Point(16, 108)
        lblHP.Name = "lblHP"
        lblHP.Size = New Size(45, 15)
        lblHP.TabIndex = 3
        lblHP.Text = "No. HP"
        ' 
        ' txtHP
        ' 
        txtHP.BorderStyle = BorderStyle.FixedSingle
        txtHP.Font = New Font("Segoe UI", 10.0F)
        txtHP.Location = New Point(16, 126)
        txtHP.Name = "txtHP"
        txtHP.Size = New Size(260, 25)
        txtHP.TabIndex = 4
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblAlamat.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblAlamat.Location = New Point(16, 166)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(46, 15)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.Font = New Font("Segoe UI", 10.0F)
        txtAlamat.Location = New Point(16, 184)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(260, 61)
        txtAlamat.TabIndex = 6
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblStatus.Location = New Point(16, 264)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(42, 15)
        lblStatus.TabIndex = 7
        lblStatus.Text = "Status"
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10.0F)
        cboStatus.Items.AddRange(New Object() {"Aktif", "Tidak Aktif"})
        cboStatus.Location = New Point(16, 282)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(261, 25)
        cboStatus.TabIndex = 8
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(16, 330)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(122, 34)
        btnSimpan.TabIndex = 9
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
        btnHapus.Location = New Point(154, 330)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(122, 34)
        btnHapus.TabIndex = 10
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
        btnBatal.Location = New Point(16, 374)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(122, 34)
        btnBatal.TabIndex = 11
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
        btnTutup.Location = New Point(154, 374)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(122, 34)
        btnTutup.TabIndex = 12
        btnTutup.Text = "TUTUP"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        pnlRight.Controls.Add(lblJumlah)
        pnlRight.Controls.Add(dgvPelanggan)
        pnlRight.Location = New Point(300, 60)
        pnlRight.Name = "pnlRight"
        pnlRight.Padding = New Padding(12, 12, 12, 12)
        pnlRight.Size = New Size(660, 500)
        pnlRight.TabIndex = 0
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblJumlah.ForeColor = Color.FromArgb(CByte(15), CByte(110), CByte(86))
        lblJumlah.Location = New Point(12, 12)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(107, 15)
        lblJumlah.TabIndex = 0
        lblJumlah.Text = "Total Pelanggan: 0"
        ' 
        ' dgvPelanggan
        ' 
        dgvPelanggan.AllowUserToAddRows = False
        dgvPelanggan.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(230), CByte(241), CByte(251))
        dgvPelanggan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvPelanggan.BackgroundColor = Color.White
        dgvPelanggan.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(15), CByte(110), CByte(86))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvPelanggan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvPelanggan.ColumnHeadersHeight = 34
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvPelanggan.DefaultCellStyle = DataGridViewCellStyle3
        dgvPelanggan.EnableHeadersVisualStyles = False
        dgvPelanggan.GridColor = Color.FromArgb(CByte(180), CByte(220), CByte(205))
        dgvPelanggan.Location = New Point(12, 36)
        dgvPelanggan.MultiSelect = False
        dgvPelanggan.Name = "dgvPelanggan"
        dgvPelanggan.ReadOnly = True
        dgvPelanggan.RowHeadersVisible = False
        dgvPelanggan.RowHeadersWidth = 62
        dgvPelanggan.RowTemplate.Height = 28
        dgvPelanggan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPelanggan.Size = New Size(636, 446)
        dgvPelanggan.TabIndex = 1
        ' 
        ' frmPelanggan
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(960, 560)
        Controls.Add(pnlRight)
        Controls.Add(pnlLeft)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmPelanggan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manajemen Pelanggan - Depot Barokah"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        pnlRight.ResumeLayout(False)
        pnlRight.PerformLayout()
        CType(dgvPelanggan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblHP As Label
    Friend WithEvents txtHP As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents pnlRight As Panel
    Friend WithEvents lblJumlah As Label
    Friend WithEvents dgvPelanggan As DataGridView
End Class
