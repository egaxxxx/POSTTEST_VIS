Imports System.IO

Public Class FormCetak
	Dim grupHobi() As CheckBox
	Dim grupJK() As RadioButton
	Private Function CekData() As Boolean
		grupHobi = {cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10}
		grupJK = {rbLaki, rbPerempuan}
		If Not ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then Return False
		If Not ValidasiTextBox(txtUmur, "Umur Tidak Boleh Kosong") Then Return False
		If Not ValidasiTextBox(txtTelp, "No Telepon Tidak Boleh Kosong") Then Return False
		If Not ValidasiTextBox(txtAlamat, "Alamat Tidak Boleh Kosong") Then Return False
		If Not ValidasiRadioButton(grupJK, "Pilih Jenis Kelamin Anda") Then Return False
		If Not ValidasiCheckBox(grupHobi, "Pilih Minimal 1 Hobi") Then Return False
		If Not ValidasiPictureBox(pbFoto, "Gambar Tidak Boleh Kosong") Then Return False
		Return True
	End Function

	Private Sub btCetak_Click(sender As Object, e As EventArgs) Handles btCetak.Click
		If CekData() Then
			grupHobi = {cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10}
			grupJK = {rbLaki, rbPerempuan}
			Dim Hobi_Selected As String = GetSelectedCheckBox(grupHobi)
			Dim jk_Selected As String = GetSelectedRadioButton(grupJK)
			DataModule.Nama = txtNama.Text
			DataModule.Umur = txtUmur.Text
			DataModule.notlp = txtTelp.Text
			DataModule.jkelamin = jk_Selected
			DataModule.Hobi = Hobi_Selected
			DataModule.TglLahir = dtpLahir.Value.ToShortDateString()
			DataModule.alamat = txtAlamat.Text
			Form2.Show()
		End If
	End Sub

	Private Sub btGambar_Click(sender As Object, e As EventArgs) Handles btBrowse.Click
		If ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then
			Dim NamaFile As String = txtNama.Text.Trim()
			Dim openFileDialog As New OpenFileDialog()
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
			openFileDialog.Title = "Pilih Gambar"
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
				Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
				Dim destinationPath As String = Path.Combine(folderPath, fileName)
				If Not Directory.Exists(folderPath) Then
					Directory.CreateDirectory(folderPath)
				End If
				File.Copy(openFileDialog.FileName, destinationPath, True)
				DataModule.Foto = destinationPath
				pbFoto.Image = Image.FromFile(destinationPath)
				MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End If
	End Sub
	Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
		ValidationModule.HanyaHuruf(sender, e)
	End Sub
	Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
		ValidationModule.HanyaAngka(sender, e)
	End Sub
	Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress
		ValidationModule.HanyaAngka(sender, e)
	End Sub
End Class