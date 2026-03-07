<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim lblgenre As Label
        gbtbuku = New GroupBox()
        txtgenre = New TextBox()
        btntambah = New Button()
        txtjudul1 = New TextBox()
        lbljudul1 = New Label()
        gbhbuku = New GroupBox()
        btnhapus = New Button()
        txtjudul2 = New TextBox()
        lbljudul2 = New Label()
        dgvhasil = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        lblgenre = New Label()
        gbtbuku.SuspendLayout()
        gbhbuku.SuspendLayout()
        CType(dgvhasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblgenre
        ' 
        lblgenre.AutoSize = True
        lblgenre.Location = New Point(20, 78)
        lblgenre.Name = "lblgenre"
        lblgenre.Size = New Size(41, 15)
        lblgenre.TabIndex = 4
        lblgenre.Text = " Genre"
        ' 
        ' gbtbuku
        ' 
        gbtbuku.Controls.Add(txtgenre)
        gbtbuku.Controls.Add(btntambah)
        gbtbuku.Controls.Add(txtjudul1)
        gbtbuku.Controls.Add(lbljudul1)
        gbtbuku.Controls.Add(lblgenre)
        gbtbuku.Location = New Point(130, 48)
        gbtbuku.Name = "gbtbuku"
        gbtbuku.Size = New Size(236, 152)
        gbtbuku.TabIndex = 7
        gbtbuku.TabStop = False
        gbtbuku.Text = " Tambah Buku"
        ' 
        ' txtgenre
        ' 
        txtgenre.Location = New Point(106, 75)
        txtgenre.Name = "txtgenre"
        txtgenre.Size = New Size(100, 23)
        txtgenre.TabIndex = 5
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(154, 123)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(75, 23)
        btntambah.TabIndex = 0
        btntambah.Text = " Tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' txtjudul1
        ' 
        txtjudul1.Location = New Point(106, 36)
        txtjudul1.Name = "txtjudul1"
        txtjudul1.Size = New Size(100, 23)
        txtjudul1.TabIndex = 1
        ' 
        ' lbljudul1
        ' 
        lbljudul1.AutoSize = True
        lbljudul1.Location = New Point(11, 36)
        lbljudul1.Name = "lbljudul1"
        lbljudul1.Size = New Size(68, 15)
        lbljudul1.TabIndex = 3
        lbljudul1.Text = " Judul Buku"
        ' 
        ' gbhbuku
        ' 
        gbhbuku.Controls.Add(btnhapus)
        gbhbuku.Controls.Add(txtjudul2)
        gbhbuku.Controls.Add(lbljudul2)
        gbhbuku.Location = New Point(435, 48)
        gbhbuku.Name = "gbhbuku"
        gbhbuku.Size = New Size(236, 152)
        gbhbuku.TabIndex = 8
        gbhbuku.TabStop = False
        gbhbuku.Text = " Hapus Buku"
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(154, 123)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(75, 23)
        btnhapus.TabIndex = 0
        btnhapus.Text = " Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' txtjudul2
        ' 
        txtjudul2.Location = New Point(106, 33)
        txtjudul2.Name = "txtjudul2"
        txtjudul2.Size = New Size(100, 23)
        txtjudul2.TabIndex = 1
        ' 
        ' lbljudul2
        ' 
        lbljudul2.AutoSize = True
        lbljudul2.Location = New Point(11, 36)
        lbljudul2.Name = "lbljudul2"
        lbljudul2.Size = New Size(68, 15)
        lbljudul2.TabIndex = 3
        lbljudul2.Text = " Judul Buku"
        ' 
        ' dgvhasil
        ' 
        dgvhasil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvhasil.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgvhasil.Location = New Point(265, 223)
        dgvhasil.Margin = New Padding(2)
        dgvhasil.Name = "dgvhasil"
        dgvhasil.RowHeadersWidth = 62
        dgvhasil.Size = New Size(339, 167)
        dgvhasil.TabIndex = 10
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Judul"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Genre"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(827, 467)
        Controls.Add(dgvhasil)
        Controls.Add(gbhbuku)
        Controls.Add(gbtbuku)
        Name = "Form1"
        Text = " Posttest 2"
        gbtbuku.ResumeLayout(False)
        gbtbuku.PerformLayout()
        gbhbuku.ResumeLayout(False)
        gbhbuku.PerformLayout()
        CType(dgvhasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents gbtbuku As GroupBox
    Friend WithEvents txtgenre As TextBox
    Friend WithEvents btntambah As Button
    Friend WithEvents txtjudul1 As TextBox
    Friend WithEvents lbljudul1 As Label
    Friend WithEvents lblgenre As Label
    Friend WithEvents gbhbuku As GroupBox
    Friend WithEvents btnhapus As Button
    Friend WithEvents txtjudul2 As TextBox
    Friend WithEvents lbljudul2 As Label
    Friend WithEvents dgvhasil As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn

End Class
