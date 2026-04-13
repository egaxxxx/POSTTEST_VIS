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
        pnlHeader.Margin = New Padding(4, 5, 4, 5)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(600, 150)
        pnlHeader.TabIndex = 1
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(29, 27)
        lblJudul.Margin = New Padding(4, 0, 4, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(336, 36)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Depot Air Minum Barokah"
        ' 
        ' lblSub
        ' 
        lblSub.AutoSize = True
        lblSub.Font = New Font("Segoe UI", 9.0F)
        lblSub.ForeColor = Color.FromArgb(CByte(181), CByte(212), CByte(244))
        lblSub.Location = New Point(31, 87)
        lblSub.Margin = New Padding(4, 0, 4, 0)
        lblSub.Name = "lblSub"
        lblSub.Size = New Size(217, 25)
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
        pnlBody.Location = New Point(0, 150)
        pnlBody.Margin = New Padding(4, 5, 4, 5)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(600, 483)
        pnlBody.TabIndex = 0
        ' 
        ' lblLoginTitle
        ' 
        lblLoginTitle.AutoSize = True
        lblLoginTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblLoginTitle.ForeColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        lblLoginTitle.Location = New Point(43, 33)
        lblLoginTitle.Margin = New Padding(4, 0, 4, 0)
        lblLoginTitle.Name = "lblLoginTitle"
        lblLoginTitle.Size = New Size(149, 30)
        lblLoginTitle.TabIndex = 0
        lblLoginTitle.Text = "Silakan Login"
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblUser.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblUser.Location = New Point(43, 100)
        lblUser.Margin = New Padding(4, 0, 4, 0)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(97, 25)
        lblUser.TabIndex = 1
        lblUser.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10.0F)
        txtUsername.Location = New Point(43, 133)
        txtUsername.Margin = New Padding(4, 5, 4, 5)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(513, 34)
        txtUsername.TabIndex = 2
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPass.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        lblPass.Location = New Point(43, 208)
        lblPass.Margin = New Padding(4, 0, 4, 0)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(92, 25)
        lblPass.TabIndex = 3
        lblPass.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10.0F)
        txtPassword.Location = New Point(43, 242)
        txtPassword.Margin = New Padding(4, 5, 4, 5)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(513, 34)
        txtPassword.TabIndex = 4
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(43, 333)
        btnLogin.Margin = New Padding(4, 5, 4, 5)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(243, 63)
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
        btnBatal.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(314, 333)
        btnBatal.Margin = New Padding(4, 5, 4, 5)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(243, 63)
        btnBatal.TabIndex = 6
        btnBatal.Text = "KELUAR"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 8.0F)
        lblInfo.ForeColor = Color.Gray
        lblInfo.Location = New Point(43, 425)
        lblInfo.Margin = New Padding(4, 0, 4, 0)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(235, 21)
        lblInfo.TabIndex = 7
        lblInfo.Text = "Default login: admin / admin123"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(600, 633)
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
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

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblLoginTitle As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label

End Class