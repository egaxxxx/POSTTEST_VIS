<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        pnlHeader = New Panel()
        lblJudul = New Label()
        lblSub = New Label()
        pnlBody = New Panel()
        lblLoginTitle = New Label()
        lblUser = New Label()
        txtUsername = New TextBox()
        lblPass = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnBatal = New Button()
        lblInfo = New Label()
        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
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
        pnlHeader.Size = New Size(553, 90)
        pnlHeader.TabIndex = 1
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(20, 16)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(235, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Depot Air Minum Barokah"
        ' 
        ' lblSub
        ' 
        lblSub.AutoSize = True
        lblSub.Font = New Font("Segoe UI", 9F)
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
        pnlBody.Controls.Add(lblLoginTitle)
        pnlBody.Controls.Add(lblUser)
        pnlBody.Controls.Add(txtUsername)
        pnlBody.Controls.Add(lblPass)
        pnlBody.Controls.Add(txtPassword)
        pnlBody.Controls.Add(btnLogin)
        pnlBody.Controls.Add(btnBatal)
        pnlBody.Controls.Add(lblInfo)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 90)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(553, 290)
        pnlBody.TabIndex = 0
        ' 
        ' lblLoginTitle
        ' 
        lblLoginTitle.AutoSize = True
        lblLoginTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblLoginTitle.ForeColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        lblLoginTitle.Location = New Point(30, 20)
        lblLoginTitle.Name = "lblLoginTitle"
        lblLoginTitle.Size = New Size(101, 20)
        lblLoginTitle.TabIndex = 0
        lblLoginTitle.Text = "Silakan Login"
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUser.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblUser.Location = New Point(30, 60)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(64, 15)
        lblUser.TabIndex = 1
        lblUser.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10F)
        txtUsername.Location = New Point(30, 80)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(360, 25)
        txtUsername.TabIndex = 2
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPass.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblPass.Location = New Point(30, 125)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(59, 15)
        lblPass.TabIndex = 3
        lblPass.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10F)
        txtPassword.Location = New Point(30, 145)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(360, 25)
        txtPassword.TabIndex = 4
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(30, 200)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(170, 38)
        btnLogin.TabIndex = 5
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(180), CByte(40), CByte(40))
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(220, 200)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(170, 38)
        btnBatal.TabIndex = 6
        btnBatal.Text = "KELUAR"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 8F)
        lblInfo.ForeColor = Color.Gray
        lblInfo.Location = New Point(30, 255)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(173, 13)
        lblInfo.TabIndex = 7
        lblInfo.Text = "Default login: admin / admin123"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(553, 380)
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login - Depot Air Minum Barokah"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlBody.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents pnlBody As Panel
    Friend WithEvents lblLoginTitle As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents lblInfo As Label
End Class
