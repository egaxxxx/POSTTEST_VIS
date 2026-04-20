<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPilihan
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
        pnlHeader = New Panel()
        lblJudul = New Label()
        lblSub = New Label()
        pnlBody = New Panel()
        lblMenuTitle = New Label()
        btnProduk = New Button()
        btnPelanggan = New Button()
        btnIsiUlang = New Button()
        pnlFooter = New Panel()
        btnLogout = New Button()
        btnKeluar = New Button()
        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Controls.Add(lblSub)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(500, 90)
        pnlHeader.TabIndex = 1
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(20, 16)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(246, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Depot Air Minum Barokah"
        ' 
        ' lblSub
        ' 
        lblSub.AutoSize = True
        lblSub.Font = New Font("Segoe UI", 9.0F)
        lblSub.ForeColor = Color.FromArgb(CByte(181), CByte(212), CByte(244))
        lblSub.Location = New Point(22, 52)
        lblSub.Name = "lblSub"
        lblSub.Size = New Size(143, 15)
        lblSub.TabIndex = 1
        lblSub.Text = "Sistem Manajemen Depot"
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Color.White
        pnlBody.Controls.Add(lblMenuTitle)
        pnlBody.Controls.Add(btnProduk)
        pnlBody.Controls.Add(btnPelanggan)
        pnlBody.Controls.Add(btnIsiUlang)
        pnlBody.Location = New Point(0, 90)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(500, 360)
        pnlBody.TabIndex = 0
        ' 
        ' lblMenuTitle
        ' 
        lblMenuTitle.AutoSize = True
        lblMenuTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblMenuTitle.ForeColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        lblMenuTitle.Location = New Point(30, 18)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.Size = New Size(83, 20)
        lblMenuTitle.TabIndex = 0
        lblMenuTitle.Text = "Pilih Menu"
        ' 
        ' btnProduk
        ' 
        btnProduk.BackColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        btnProduk.Cursor = Cursors.Hand
        btnProduk.FlatAppearance.BorderSize = 0
        btnProduk.FlatStyle = FlatStyle.Flat
        btnProduk.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnProduk.ForeColor = Color.White
        btnProduk.Location = New Point(40, 54)
        btnProduk.Name = "btnProduk"
        btnProduk.Size = New Size(420, 54)
        btnProduk.TabIndex = 1
        btnProduk.Text = "Manajemen Produk"
        btnProduk.UseVisualStyleBackColor = False
        ' 
        ' btnPelanggan
        ' 
        btnPelanggan.BackColor = Color.FromArgb(CByte(15), CByte(110), CByte(86))
        btnPelanggan.Cursor = Cursors.Hand
        btnPelanggan.FlatAppearance.BorderSize = 0
        btnPelanggan.FlatStyle = FlatStyle.Flat
        btnPelanggan.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnPelanggan.ForeColor = Color.White
        btnPelanggan.Location = New Point(40, 123)
        btnPelanggan.Name = "btnPelanggan"
        btnPelanggan.Size = New Size(420, 54)
        btnPelanggan.TabIndex = 2
        btnPelanggan.Text = "Manajemen Pelanggan"
        btnPelanggan.UseVisualStyleBackColor = False
        ' 
        ' btnIsiUlang
        ' 
        btnIsiUlang.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnIsiUlang.Cursor = Cursors.Hand
        btnIsiUlang.FlatAppearance.BorderSize = 0
        btnIsiUlang.FlatStyle = FlatStyle.Flat
        btnIsiUlang.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnIsiUlang.ForeColor = Color.White
        btnIsiUlang.Location = New Point(40, 192)
        btnIsiUlang.Name = "btnIsiUlang"
        btnIsiUlang.Size = New Size(420, 54)
        btnIsiUlang.TabIndex = 3
        btnIsiUlang.Text = "Manajemen Isi Ulang / Pesanan"
        btnIsiUlang.UseVisualStyleBackColor = False
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        pnlFooter.Controls.Add(btnLogout)
        pnlFooter.Controls.Add(btnKeluar)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 451)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(500, 56)
        pnlFooter.TabIndex = 2
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(133), CByte(79), CByte(11))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(260, 11)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(110, 34)
        btnLogout.TabIndex = 0
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.FromArgb(CByte(163), CByte(45), CByte(45))
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.FlatAppearance.BorderSize = 0
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnKeluar.ForeColor = Color.White
        btnKeluar.Location = New Point(385, 11)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(110, 34)
        btnKeluar.TabIndex = 1
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' frmpilihan
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(500, 507)
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Controls.Add(pnlFooter)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmpilihan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu Utama - Depot Air Minum Barokah"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlBody.PerformLayout()
        pnlFooter.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents pnlBody As Panel
    Friend WithEvents lblMenuTitle As Label
    Friend WithEvents btnProduk As Button
    Friend WithEvents btnPelanggan As Button
    Friend WithEvents btnIsiUlang As Button
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnKeluar As Button
End Class
