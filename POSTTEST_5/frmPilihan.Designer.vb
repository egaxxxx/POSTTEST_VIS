<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPilihan
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
        pnlHeader = New System.Windows.Forms.Panel()
        lblJudul = New System.Windows.Forms.Label()
        lblSub = New System.Windows.Forms.Label()
        pnlBody = New System.Windows.Forms.Panel()
        lblMenuTitle = New System.Windows.Forms.Label()
        btnProduk = New System.Windows.Forms.Button()
        btnIsiUlang = New System.Windows.Forms.Button()
        pnlFooter = New System.Windows.Forms.Panel()
        btnLogout = New System.Windows.Forms.Button()
        btnKeluar = New System.Windows.Forms.Button()

        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()

        '
        ' pnlHeader
        '
        pnlHeader.BackColor = System.Drawing.Color.FromArgb(CByte(12), CByte(68), CByte(124))
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Controls.Add(lblSub)
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        pnlHeader.Location = New System.Drawing.Point(0, 0)
        pnlHeader.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New System.Drawing.Size(714, 150)
        pnlHeader.TabIndex = 1

        '
        ' lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0F, System.Drawing.FontStyle.Bold)
        lblJudul.ForeColor = System.Drawing.Color.White
        lblJudul.Location = New System.Drawing.Point(29, 27)
        lblJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(365, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Depot Air Minum Barokah"

        '
        ' lblSub
        '
        lblSub.AutoSize = True
        lblSub.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        lblSub.ForeColor = System.Drawing.Color.FromArgb(CByte(181), CByte(212), CByte(244))
        lblSub.Location = New System.Drawing.Point(31, 87)
        lblSub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblSub.Name = "lblSub"
        lblSub.Size = New System.Drawing.Size(217, 25)
        lblSub.TabIndex = 1
        lblSub.Text = "Sistem Manajemen Depot"

        '
        ' pnlBody
        '
        pnlBody.BackColor = System.Drawing.Color.White
        pnlBody.Controls.Add(lblMenuTitle)
        pnlBody.Controls.Add(btnProduk)
        pnlBody.Controls.Add(btnIsiUlang)
        pnlBody.Location = New System.Drawing.Point(0, 150)
        pnlBody.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New System.Drawing.Size(714, 400)
        pnlBody.TabIndex = 0

        '
        ' lblMenuTitle
        '
        lblMenuTitle.AutoSize = True
        lblMenuTitle.Font = New System.Drawing.Font("Segoe UI", 11.0F, System.Drawing.FontStyle.Bold)
        lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(CByte(12), CByte(68), CByte(124))
        lblMenuTitle.Location = New System.Drawing.Point(43, 40)
        lblMenuTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.Size = New System.Drawing.Size(123, 30)
        lblMenuTitle.TabIndex = 0
        lblMenuTitle.Text = "Pilih Menu"

        '
        ' btnProduk
        '
        btnProduk.BackColor = System.Drawing.Color.FromArgb(CByte(12), CByte(68), CByte(124))
        btnProduk.Cursor = System.Windows.Forms.Cursors.Hand
        btnProduk.FlatAppearance.BorderSize = 0
        btnProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnProduk.Font = New System.Drawing.Font("Segoe UI", 11.0F, System.Drawing.FontStyle.Bold)
        btnProduk.ForeColor = System.Drawing.Color.White
        btnProduk.Location = New System.Drawing.Point(57, 117)
        btnProduk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        btnProduk.Name = "btnProduk"
        btnProduk.Size = New System.Drawing.Size(600, 107)
        btnProduk.TabIndex = 1
        btnProduk.Text = "Manajemen Produk"
        btnProduk.UseVisualStyleBackColor = False

        '
        ' btnIsiUlang
        '
        btnIsiUlang.BackColor = System.Drawing.Color.FromArgb(CByte(15), CByte(110), CByte(86))
        btnIsiUlang.Cursor = System.Windows.Forms.Cursors.Hand
        btnIsiUlang.FlatAppearance.BorderSize = 0
        btnIsiUlang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnIsiUlang.Font = New System.Drawing.Font("Segoe UI", 11.0F, System.Drawing.FontStyle.Bold)
        btnIsiUlang.ForeColor = System.Drawing.Color.White
        btnIsiUlang.Location = New System.Drawing.Point(57, 258)
        btnIsiUlang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        btnIsiUlang.Name = "btnIsiUlang"
        btnIsiUlang.Size = New System.Drawing.Size(600, 107)
        btnIsiUlang.TabIndex = 2
        btnIsiUlang.Text = "Manajemen Isi Ulang / Pesanan"
        btnIsiUlang.UseVisualStyleBackColor = False

        '
        ' pnlFooter
        '
        pnlFooter.BackColor = System.Drawing.Color.FromArgb(CByte(240), CByte(244), CByte(248))
        pnlFooter.Controls.Add(btnLogout)
        pnlFooter.Controls.Add(btnKeluar)
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        pnlFooter.Location = New System.Drawing.Point(0, 550)
        pnlFooter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New System.Drawing.Size(714, 93)
        pnlFooter.TabIndex = 2

        '
        ' btnLogout
        '
        btnLogout.BackColor = System.Drawing.Color.FromArgb(CByte(133), CByte(79), CByte(11))
        btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
        btnLogout.ForeColor = System.Drawing.Color.White
        btnLogout.Location = New System.Drawing.Point(371, 18)
        btnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New System.Drawing.Size(157, 57)
        btnLogout.TabIndex = 0
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False

        '
        ' btnKeluar
        '
        btnKeluar.BackColor = System.Drawing.Color.FromArgb(CByte(163), CByte(45), CByte(45))
        btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        btnKeluar.FlatAppearance.BorderSize = 0
        btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnKeluar.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
        btnKeluar.ForeColor = System.Drawing.Color.White
        btnKeluar.Location = New System.Drawing.Point(550, 18)
        btnKeluar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New System.Drawing.Size(157, 57)
        btnKeluar.TabIndex = 1
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False

        '
        ' frmPilihan
        '
        AutoScaleDimensions = New System.Drawing.SizeF(10.0F, 25.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.White
        ClientSize = New System.Drawing.Size(714, 643)
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Controls.Add(pnlFooter)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "frmPilihan"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Menu Utama - Depot Air Minum Barokah"

        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlBody.PerformLayout()
        pnlFooter.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblMenuTitle As System.Windows.Forms.Label
    Friend WithEvents btnProduk As System.Windows.Forms.Button
    Friend WithEvents btnIsiUlang As System.Windows.Forms.Button
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button

End Class