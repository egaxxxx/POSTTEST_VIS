Public Class FormHasil
	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblNama.Text = DataModule.Nama
		lblUmur.Text = DataModule.Umur
		lblLahir.Text = DataModule.TglLahir
		lblKelamin.Text = DataModule.jkelamin
		lblNo.Text = DataModule.notlp
		lblHobby.Text = DataModule.Hobi
		lblAlamat.Text = Form1.txtAlamat.Text
		pbFoto.Image = Image.FromFile(DataModule.Foto)
	End Sub
End Class