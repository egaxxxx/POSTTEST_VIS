<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCetak))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtAlamat = New TextBox()
        txtTelp = New TextBox()
        dtpLahir = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        gbKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        cb1 = New CheckBox()
        GroupBox2 = New GroupBox()
        cb10 = New CheckBox()
        cb9 = New CheckBox()
        cb8 = New CheckBox()
        cb5 = New CheckBox()
        cb4 = New CheckBox()
        cb7 = New CheckBox()
        cb6 = New CheckBox()
        cb3 = New CheckBox()
        cb2 = New CheckBox()
        Label6 = New Label()
        pbFoto = New PictureBox()
        btBrowse = New Button()
        btCetak = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        gbKelamin.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(49, 17)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(587, 447)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(239, 102)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 1
        Label1.Text = " Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(337, 100)
        txtNama.Margin = New Padding(2)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(213, 23)
        txtNama.TabIndex = 2
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(337, 127)
        txtUmur.Margin = New Padding(2)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(213, 23)
        txtUmur.TabIndex = 3
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(337, 215)
        txtAlamat.Margin = New Padding(2)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(213, 23)
        txtAlamat.TabIndex = 4
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(338, 184)
        txtTelp.Margin = New Padding(2)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(213, 23)
        txtTelp.TabIndex = 5
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(339, 155)
        dtpLahir.Margin = New Padding(2)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(213, 23)
        dtpLahir.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(243, 128)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 8
        Label3.Text = "Umur"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(242, 155)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 15)
        Label4.TabIndex = 9
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(245, 186)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 15)
        Label5.TabIndex = 10
        Label5.Text = "No Telepon"
        ' 
        ' gbKelamin
        ' 
        gbKelamin.Controls.Add(rbPerempuan)
        gbKelamin.Controls.Add(rbLaki)
        gbKelamin.Location = New Point(151, 262)
        gbKelamin.Margin = New Padding(2)
        gbKelamin.Name = "gbKelamin"
        gbKelamin.Padding = New Padding(2)
        gbKelamin.Size = New Size(127, 130)
        gbKelamin.TabIndex = 11
        gbKelamin.TabStop = False
        gbKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(4, 39)
        rbPerempuan.Margin = New Padding(2)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(89, 19)
        rbPerempuan.TabIndex = 13
        rbPerempuan.TabStop = True
        rbPerempuan.Text = " Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(4, 18)
        rbLaki.Margin = New Padding(2)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(75, 19)
        rbLaki.TabIndex = 12
        rbLaki.TabStop = True
        rbLaki.Text = " Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' cb1
        ' 
        cb1.AutoSize = True
        cb1.Location = New Point(4, 18)
        cb1.Margin = New Padding(2)
        cb1.Name = "cb1"
        cb1.Size = New Size(68, 19)
        cb1.TabIndex = 13
        cb1.Text = "Gaming"
        cb1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cb10)
        GroupBox2.Controls.Add(cb9)
        GroupBox2.Controls.Add(cb8)
        GroupBox2.Controls.Add(cb5)
        GroupBox2.Controls.Add(cb4)
        GroupBox2.Controls.Add(cb7)
        GroupBox2.Controls.Add(cb6)
        GroupBox2.Controls.Add(cb3)
        GroupBox2.Controls.Add(cb2)
        GroupBox2.Controls.Add(cb1)
        GroupBox2.Location = New Point(306, 262)
        GroupBox2.Margin = New Padding(2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(2)
        GroupBox2.Size = New Size(246, 130)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobby"
        ' 
        ' cb10
        ' 
        cb10.AutoSize = True
        cb10.Location = New Point(126, 102)
        cb10.Margin = New Padding(2)
        cb10.Name = "cb10"
        cb10.Size = New Size(63, 19)
        cb10.TabIndex = 22
        cb10.Text = "Menari"
        cb10.UseVisualStyleBackColor = True
        ' 
        ' cb9
        ' 
        cb9.AutoSize = True
        cb9.Location = New Point(126, 81)
        cb9.Margin = New Padding(2)
        cb9.Name = "cb9"
        cb9.Size = New Size(78, 19)
        cb9.TabIndex = 21
        cb9.Text = "Menyanyi"
        cb9.UseVisualStyleBackColor = True
        ' 
        ' cb8
        ' 
        cb8.AutoSize = True
        cb8.Location = New Point(126, 60)
        cb8.Margin = New Padding(2)
        cb8.Name = "cb8"
        cb8.Size = New Size(74, 19)
        cb8.TabIndex = 20
        cb8.Text = "Olahraga"
        cb8.UseVisualStyleBackColor = True
        ' 
        ' cb5
        ' 
        cb5.AutoSize = True
        cb5.Location = New Point(4, 102)
        cb5.Margin = New Padding(2)
        cb5.Name = "cb5"
        cb5.Size = New Size(68, 19)
        cb5.TabIndex = 19
        cb5.Text = "Menulis"
        cb5.UseVisualStyleBackColor = True
        ' 
        ' cb4
        ' 
        cb4.AutoSize = True
        cb4.Location = New Point(4, 81)
        cb4.Margin = New Padding(2)
        cb4.Name = "cb4"
        cb4.Size = New Size(98, 19)
        cb4.TabIndex = 18
        cb4.Text = "Menggambar"
        cb4.UseVisualStyleBackColor = True
        ' 
        ' cb7
        ' 
        cb7.AutoSize = True
        cb7.Location = New Point(126, 40)
        cb7.Margin = New Padding(2)
        cb7.Name = "cb7"
        cb7.Size = New Size(79, 19)
        cb7.TabIndex = 16
        cb7.Text = "Membaca"
        cb7.UseVisualStyleBackColor = True
        ' 
        ' cb6
        ' 
        cb6.AutoSize = True
        cb6.Location = New Point(126, 19)
        cb6.Margin = New Padding(2)
        cb6.Name = "cb6"
        cb6.Size = New Size(90, 19)
        cb6.TabIndex = 17
        cb6.Text = "Memancing"
        cb6.UseVisualStyleBackColor = True
        ' 
        ' cb3
        ' 
        cb3.AutoSize = True
        cb3.Location = New Point(4, 60)
        cb3.Margin = New Padding(2)
        cb3.Name = "cb3"
        cb3.Size = New Size(74, 19)
        cb3.TabIndex = 15
        cb3.Text = "Traveling"
        cb3.UseVisualStyleBackColor = True
        ' 
        ' cb2
        ' 
        cb2.AutoSize = True
        cb2.Location = New Point(4, 39)
        cb2.Margin = New Padding(2)
        cb2.Name = "cb2"
        cb2.Size = New Size(65, 19)
        cb2.TabIndex = 14
        cb2.Text = "Coding"
        cb2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(245, 218)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 15)
        Label6.TabIndex = 15
        Label6.Text = "Alamat"
        ' 
        ' pbFoto
        ' 
        pbFoto.Location = New Point(104, 102)
        pbFoto.Margin = New Padding(2)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(105, 101)
        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbFoto.TabIndex = 16
        pbFoto.TabStop = False
        ' 
        ' btBrowse
        ' 
        btBrowse.Location = New Point(123, 215)
        btBrowse.Margin = New Padding(2)
        btBrowse.Name = "btBrowse"
        btBrowse.Size = New Size(68, 20)
        btBrowse.TabIndex = 17
        btBrowse.Text = " Browse"
        btBrowse.UseVisualStyleBackColor = True
        ' 
        ' btCetak
        ' 
        btCetak.Location = New Point(254, 403)
        btCetak.Margin = New Padding(2)
        btCetak.Name = "btCetak"
        btCetak.Size = New Size(177, 20)
        btCetak.TabIndex = 18
        btCetak.Text = "Cetak Kartu"
        btCetak.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(807, 492)
        Controls.Add(btCetak)
        Controls.Add(btBrowse)
        Controls.Add(pbFoto)
        Controls.Add(Label6)
        Controls.Add(GroupBox2)
        Controls.Add(gbKelamin)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(dtpLahir)
        Controls.Add(txtTelp)
        Controls.Add(txtAlamat)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Margin = New Padding(2)
        Name = "Form1"
        Text = "FormCetak"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        gbKelamin.ResumeLayout(False)
        gbKelamin.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents gbKelamin As GroupBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb6 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb7 As CheckBox
    Friend WithEvents cb5 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb9 As CheckBox
    Friend WithEvents cb8 As CheckBox
    Friend WithEvents cb10 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btBrowse As Button
    Friend WithEvents btCetak As Button

End Class
